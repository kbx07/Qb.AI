using System.Text.Json.Serialization;

namespace Qb.AI.Models;

public class ErrorDetails
{
    [JsonPropertyName("code")]
    public string Code { get; set; }
    
    [JsonPropertyName("message")]
    public string Message { get; set; }
}