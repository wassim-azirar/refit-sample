using Newtonsoft.Json;

namespace RefitSample.Models;

public class ApiResponse
{
    [JsonProperty("code", NullValueHandling = NullValueHandling.Ignore)]
    public int Code { get; set; }

    [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
    public string? Type { get; set; }

    [JsonProperty("message", NullValueHandling = NullValueHandling.Ignore)]
    public string? Message { get; set; }
}