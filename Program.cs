using Refit;
using RefitSample;
using RefitSample.Models;

var petService = RestService.For<IPetService>("https://petstore.swagger.io/v2");

var petsList = await petService.GetPetsByStatus("available");
for (var i = 0; i < 2; i++)
{
    Console.WriteLine(petsList[i].Id);
}

var petDetails = await petService.GetPetById(15903356708141);
Console.WriteLine($"\n{petDetails.Name}");
Console.WriteLine(petDetails.Status);
Console.WriteLine(petDetails.Category?.Name);
Console.Write("\n");

var userService = RestService.For<IUserService>("https://petstore.swagger.io/v2");

var newUser = new User
{
    FirstName = "Jean",
    LastName = "Jack",
    Email = "jean.jack@gmail.com",
    Password = "123456",
    Phone = "+33.6.22.33.44.55",
    Username = "jean.jack"
};

var createdUser = await userService.CreateUser(newUser);
Console.WriteLine($"User ID: {createdUser.Message}\n");

var loginResponse = await userService.LoginUser("jean.jack", "123456");

Console.WriteLine(loginResponse.Content);

if (loginResponse.Headers.TryGetValues("X-Expires-After", out var expiresAfter))
    Console.WriteLine($"Token expiration: {expiresAfter.FirstOrDefault()}");

if (loginResponse.Headers.TryGetValues("X-Rate-Limit", out var rateLimit))
    Console.WriteLine($"Rate limit: {rateLimit.FirstOrDefault()}");
