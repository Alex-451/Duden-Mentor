namespace DudenMentor.Domain.Entities;

public class Occurrence
{
    public int Offset { get; set; }
    public string Text { get; set; }
    public string[] Synonyms { get; set; }
}