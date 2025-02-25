using System.Text.Json.Serialization;

namespace Qb.AI.Models;

public class AnalysisDocument
{
    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("language")]
    public string Language { get; set; }

    [JsonPropertyName("text")]
    public string Text { get; set; }
}