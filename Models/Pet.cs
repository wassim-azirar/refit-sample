using Newtonsoft.Json;

namespace RefitSample.Models;

public class Pet
{
    [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
    public long Id { get; set; }

    [JsonProperty("category", NullValueHandling = NullValueHandling.Ignore)]
    public Category? Category { get; set; }

    [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; }

    [JsonProperty("photoUrls", NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<string?> PhotoUrls { get; set; } = new List<string?>();

    [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<Tag?> Tags { get; set; } = new List<Tag?>();

    [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
    public PetStatus? Status { get; set; }
}