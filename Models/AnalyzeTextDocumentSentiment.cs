using System.Text.Json.Serialization;

namespace Qb.AI.Models;

public class AnalyzeTextDocumentSentiment
{
    [JsonPropertyName("id")]
    public string Id { get; set; }
    
    [JsonPropertyName("sentiment")]
    public string Sentiment { get; set; }
    
    [JsonPropertyName("confidenceScores")]
    public AnalyzeTextConfidenceScores ConfidenceScores { get; set; }
}