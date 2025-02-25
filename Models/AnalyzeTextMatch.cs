using System.Text.Json.Serialization;

namespace Qb.AI.Models;

public class AnalyzeTextMatch
{
    [JsonPropertyName("text")]
    public string Text { get; set; }
    
    [JsonPropertyName("offset")]
    public int Offset { get; set; }
    
    [JsonPropertyName("length")]
    public int Length { get; set; }
    
    [JsonPropertyName("confidenceScore")]
    public double ConfidenceScore { get; set; }
}