using System.Text.Json.Serialization;

namespace Qb.AI.Models;

public class AnalyzeTextEntity
{
    [JsonPropertyName("name")]
    public string Name { get; set; }
    
    [JsonPropertyName("matches")]
    public List<AnalyzeTextMatch> Matches { get; set; }
    
    [JsonPropertyName("type")]
    public string Type { get; set; }
}