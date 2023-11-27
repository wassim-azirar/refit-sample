using Newtonsoft.Json;

namespace RefitSample.Models;

public class Order
{
    [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
    public long Id { get; set; }

    [JsonProperty("petId", NullValueHandling = NullValueHandling.Ignore)]
    public long PetId { get; set; }

    [JsonProperty("quantity", NullValueHandling = NullValueHandling.Ignore)]
    public int Quantity { get; set; }

    [JsonProperty("shipDate", NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset ShipDate { get; set; }

    [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
    public OrderStatus? Status { get; set; }

    [JsonProperty("complete", NullValueHandling = NullValueHandling.Ignore)]
    public bool? Complete { get; set; }
}