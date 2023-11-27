using Newtonsoft.Json;

namespace RefitSample.Models;

public class Category
{
    [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
    public long Id { get; set; }

    [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; }
}