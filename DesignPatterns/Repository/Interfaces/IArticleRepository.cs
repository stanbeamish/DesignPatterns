using System.Collections.Generic;
using DesignPatterns.Repository.Entities;

namespace DesignPatterns.Repository.Interfaces
{
  public interface IArticleRepository
  {
    List<Article> ReadAll();
    Article ReadById(long id);
    Article Create(Article article);
    Article Update(Article article);
    Article Delete(Article article);
  }
}