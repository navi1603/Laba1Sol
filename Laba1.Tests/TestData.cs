using Laba1.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba1.Tests
{
    public class TestData
    {
        public static List<Dish> GetDishesList()
        {
            return new List<Dish>
             {
                 new Dish{ DishId=1, DishGroupId=1},
                 new Dish{ DishId=2, DishGroupId=1},
                 new Dish{ DishId=3, DishGroupId=2},
                 new Dish{ DishId=4, DishGroupId=2},
                 new Dish{ DishId=5, DishGroupId=3}
             };
        }
        public static IEnumerable<object[]> Params()
        {
            // 1-я страница, кол. объектов 3, id первого объекта 1
            yield return new object[] { 1, 3, 1 };
            // 2-я страница, кол. объектов 2, id первого объекта 4
            yield return new object[] { 2, 2, 4 };
        }

    }
}
