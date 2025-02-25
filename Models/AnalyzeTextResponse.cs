using System.Text.Json.Serialization;

namespace Qb.AI.Models;

public class AnalyzeTextResponse
{
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    [JsonPropertyName("results")]
    public AnalyzeTextResults Results { get; set; }
}