using System.Text.Json.Serialization;

namespace Qb.AI.Models;

public class AnalysisInput
{
    [JsonPropertyName("documents")]
    public List<AnalysisDocument> Documents { get; set; }
}