using System.Collections.Generic;

namespace DesignPatterns.Repository.Interfaces
{
  public interface IGenericRepository<T, TK>
  {
    List<T> ReadAll();
    T ReadById(in TK id);
    T Create(T entity);
    T Update(T entity);
    T Delete(T entity);
  }
}