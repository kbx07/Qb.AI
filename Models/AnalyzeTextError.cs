using System.Text.Json.Serialization;

namespace Qb.AI.Models;

public class AnalyzeTextError
{
    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("error")]
    public ErrorDetails Error { get; set; }
}