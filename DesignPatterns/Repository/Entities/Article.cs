using System.Collections.Generic;

namespace DesignPatterns.Repository.Entities
{
  public class Article
  {
    public long Id { get; set; }
    public string Title { get; set; }
    public string Subtitle { get; set; }
    public List<string> Paragraphs { get; set; }
    public List<Tag> Tags { get; set; }
  }
}