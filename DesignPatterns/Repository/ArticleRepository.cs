using System;
using System.Collections.Generic;
using DesignPatterns.Repository.Entities;
using DesignPatterns.Repository.Interfaces;

namespace DesignPatterns.Repository
{
  public class ArticleRepository : IArticleRepository
  {
    private readonly List<Article> _articles;
    private readonly Tag _scienceFiction;
    private readonly Tag _crime;
    private readonly Tag _starTrek;
    private readonly Tag _loveStory;
    private readonly Article _first;
    private readonly Article _second;
    private readonly Article _third;
    public ArticleRepository()
    {
      _scienceFiction = new Tag {Id = 1, Name = "science fiction"};
      _crime = new Tag {Id = 1, Name = "crime"};
      _starTrek = new Tag {Id = 1, Name = "star trek"};
      _loveStory = new Tag {Id = 1, Name = "love story"};
      _first = new Article();
      _first.Id = 1;
      _first.Title = "Jeff Vader";
      _first.Subtitle = "Lord Vader gives the cook";
      _first.Tags = new List<Tag>
      {
        _scienceFiction,
        _crime
      };

      _second = new Article();
      _second.Id = 2;
      _second.Tags = new List<Tag>
      {
          _scienceFiction,
          _starTrek
      };

      _second.Title = "Spock";
      _second.Subtitle = "Spock drives the Enterprise towards a Tree";

      _third = new Article();
      _third.Id = 3;
      _third.Subtitle = "Code to love and to die for";
      _third.Tags = new List<Tag>
      {
        _loveStory,
        _crime
      };
      _third.Title = "R2D2";

      _articles = new List<Article> {_first, _second, _third};
    }
    
    public List<Article> ReadAll()
    {
      Console.WriteLine("Returning all Articles");
      return _articles;
    }

    public Article ReadById(long id)
    {
      Console.WriteLine("Returning the Article found on ID");
      return _articles[Convert.ToInt32(id)];
    }

    public Article Create(Article entity)
    {
      var newArticle = new Article
      {
        Id = 4,
        Title = "Kirk speaks",
        Subtitle = "To boldly go where no man has gone before",
        Paragraphs = new List<string> {"lorem ipsum", "ipsum lorem", "lipsum orem"},
        Tags = new List<Tag> {new Tag {Id = 5, Name = "star trek"}}
      };
      _articles.Add(newArticle);
      Console.WriteLine("Created a Article");
      return newArticle;
    }

    public Article Update(Article entity)
    {
      Console.WriteLine("Updating an Article");
      return _articles[0];
    }

    public Article Delete(Article entity)
    {
      Console.WriteLine("Deleting an Article");
      var articleToDelete = _articles[1];
      _articles.Remove(articleToDelete);
      return articleToDelete;
    }

    public Article ReadLatest()
    {
      return _articles[^1];
    }

    public List<Article> ReadByTags(List<Tag> tags)
    {
      var searchTag = new Tag {Id = 1, Name = "science fiction"};
      Console.WriteLine("Searching all (\"science fiction\") tagged Articles.");
      return _articles.FindAll(x => x.Tags.Contains(searchTag));
    }
  }
}