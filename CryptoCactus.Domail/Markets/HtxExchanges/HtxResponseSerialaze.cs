using System.Text.Json.Serialization;

public class KlineData
{
    [JsonPropertyName("id")]
    public long Id { get; set; }

    [JsonPropertyName("open")]
    public double Open { get; set; }

    [JsonPropertyName("close")]
    public double Close { get; set; }

    [JsonPropertyName("low")]
    public double Low { get; set; }

    [JsonPropertyName("high")]
    public double High { get; set; }

    [JsonPropertyName("amount")]
    public double Amount { get; set; }

    [JsonPropertyName("vol")]
    public double Vol { get; set; }

    [JsonPropertyName("count")]
    public long Count { get; set; }
}

// Класс для представления всего ответа
public class HtxResponseSerialaze
{
    [JsonPropertyName("ch")]
    public string? Ch { get; set; }

    [JsonPropertyName("status")]
    public string? Status { get; set; }

    [JsonPropertyName("ts")]
    public long Ts { get; set; }

    [JsonPropertyName("data")]
    public KlineData[]? Data { get; set; }
}