using Pizza.Models;
using System.Linq.Expressions;
using System;

namespace Pizza.Services
{
    public class MyPizzaFakeDbService : IMyPizzaService
    {
        private List<MyPizza> _myPizzas;
        private int _lastIndex = 0;

        public MyPizzaFakeDbService()
        {
            _myPizzas = new List<MyPizza>()
            {
                new MyPizza{ Id =1, Name ="Bacon", Price = 12, Ingredients = "bacon, mozzarella, champignon, emmental", PicturePath = "/images/bacon.jpg"  },
                new MyPizza{ Id =2, Name ="4 fromages", Price= 11, Ingredients = "cantal, mozzarella, fromage de chèvre, gruyère", PicturePath = "/images/cheese.jpg"  },
                new MyPizza{ Id =3, Name ="Margherita", Price = 10, Ingredients = "sauce tomate, mozzarella, basilic", PicturePath = "/images/margherita.jpg"  },
                new MyPizza{ Id =4, Name ="Mexicaine", Price=12, Ingredients = "boeuf, mozzarella, maïs, tomates, oignon, coriandre", PicturePath = "/images/meaty.jpg"  },
                new MyPizza{ Id =5, Name ="Reine", Price=11, Ingredients = "jambon, champignons, mozzarella", PicturePath = "/images/mushroom.jpg"  },
                new MyPizza{ Id =6, Name ="Pepperoni", Price=11, Ingredients = "mozzarella, pepperoni, tomates", PicturePath = "/images/pepperoni.jpg"  },
                new MyPizza{ Id =7, Name ="Végétarienne",Price = 10, Ingredients = "champignons, roquette, artichauts, aubergine", PicturePath = "/images/veggie.jpg"  },
            };
        }
        public List<MyPizza> GetAll()
        {
            return _myPizzas;
        }

        public MyPizza? GetById(int id)
        {
            return _myPizzas.FirstOrDefault(c => c.Id == id);
        }



        public bool Post(MyPizza myPizza)
        {
            myPizza.Id = ++_lastIndex;
            _myPizzas.Add(myPizza);
            return true;
        }

        public bool Update(MyPizza myPizza)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            var myPizza = GetById(id);
            if (myPizza == null)
                return false;
            _myPizzas.Remove(myPizza);
            return true;
        }

        public MyPizza? GetById(Expression<Func<MyPizza, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public List<MyPizza> GetAll(Expression<Func<MyPizza, bool>> predicate)
        {
            throw new NotImplementedException();
        }
    }

}
