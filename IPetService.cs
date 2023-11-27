using Refit;
using RefitSample.Models;

namespace RefitSample;

public interface IPetService
{
    [Get("/pet/findByStatus")]
    Task<List<Pet>> GetPetsByStatus([AliasAs("status")] string status);
    
    [Get("/pet/{petId}")]
    Task<Pet> GetPetById([AliasAs("petId")] long petId);
}