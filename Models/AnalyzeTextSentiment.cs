using System.Text.Json.Serialization;

namespace Qb.AI.Models;

public class AnalyzeTextSentiment
{
    [JsonPropertyName("documents")]
    public List<AnalyzeTextDocumentSentiment> Documents { get; set; }
    
    [JsonPropertyName("errors")]
    public List<AnalyzeTextError> Errors { get; set; }
}