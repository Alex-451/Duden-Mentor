namespace DudenMentor.Domain.Entities;

public class StyleAdvice
{
    public string ErrorCode { get; set; }
    public string ErrorMessage { get; set; }
    public string ShortMessage { get; set; }
    public string Label { get; set; }
    public string LabelInline { get; set; }
    public int Length { get; set; }
    public int Offset { get; set; }
    public string OriginalError { get; set; }
    public string[] Proposals { get; set; }
    public string[] Synonyms { get; set; }
    public Occurrence[] Occurrences { get; set; }
    public int OccurrenceIndex { get; set; }
    public string Type { get; set; }
}