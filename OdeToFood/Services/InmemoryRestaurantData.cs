using OdeToFood.Entities;
using System.Collections.Generic;
using System.Linq;

namespace OdeToFood.Services
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> Getall();
        Restaurant Get(int id);
    }

    public class InmemoryRestaurantData : IRestaurantData
    {
        public InmemoryRestaurantData()
        {
            _restaurants = new List<Restaurant>
            {
                new Restaurant{ Id =1, Name = "Asmara Restaurant"},
                new Restaurant{Id = 2, Name = "Nairobi Restaurant"},
                new Restaurant{Id =3 , Name ="Addis Restaurant"}
            };


        }

        public IEnumerable<Restaurant> Getall()
        {
            return _restaurants;
        }

        public Restaurant Get(int id)
        {
            return _restaurants.FirstOrDefault(r => r.Id == id);
        }

        List<Restaurant> _restaurants;
    }
}
