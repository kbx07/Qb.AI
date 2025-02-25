using System.Text.Json.Serialization;

namespace Qb.AI.Models;

public class AnalyzeTextDocument
{
    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("sentiment")]
    public string Sentiment { get; set; }

    [JsonPropertyName("confidenceScores")]
    public ConfidenceScores ConfidenceScores { get; set; }

    [JsonPropertyName("keyPhrases")]
    public List<string> KeyPhrases { get; set; }
} 
 // The  AnalyzeTextDocument  class is a model class that represents the document-level sentiment analysis results. It contains the following properties: 
 // Id : The unique identifier of the document. Sentiment : The sentiment of the document. ConfidenceScores : The confidence scores of the sentiment analysis. KeyPhrases : The key phrases detected in the document. 
 // The  AnalyzeTextDocument  class is decorated with the  JsonPropertyName  attribute to specify the JSON property names. 
 // Step 4: Create the AnalyzeTextDocumentSentiment Class 
 // The  AnalyzeTextDocumentSentiment  class is a model class that represents the document-level sentiment analysis results. It contains the following properties: 
 // Id : The unique identifier of the document. Sentiment : The sentiment of the document. ConfidenceScores : The confidence scores of the sentiment analysis. 
 // The  AnalyzeTextDocumentSentiment  class is decorated with the  JsonPropertyName  attribute to specify the JSON property names. 
 // Create a new file named  AnalyzeTextDocumentSentiment.cs  in the  Models  folder and add the following code: