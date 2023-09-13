using Pizza.Models;
using System.Linq.Expressions;

namespace Pizza.Services
{
    public interface IMyPizzaService
    {
        bool Delete(int id);
        List<MyPizza> GetAll();
        List<MyPizza> GetAll(Expression<Func<MyPizza, bool>> predicate);
        MyPizza? GetById(Expression<Func<MyPizza, bool>> predicate);
        MyPizza? GetById(int id);
        bool Post(MyPizza myPizza);
        bool Update(MyPizza myPizza);
    }
}