using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using EITParcelDelivery.Database;
using EITParcelDelivery.Models;

namespace EITParcelDelivery.Repositories
{
    public class CitiesRepository
    {
        public List<City> getAll()
        {
            List<City> cities = new List<City>();

            EITDBEntities ctx = new EITDBEntities();
            foreach (var entity in ctx.Cities)
            {
                cities.Add(
                    mapFromEntity(entity)  
                );
            }

            return cities;
        }

        public City get(string name)
        {
            EITDBEntities ctx = new EITDBEntities();
            var city = ctx.Cities.FirstOrDefault(x => x.Name.ToLower() == name.ToLower());
            if (city != null)
            {
                return mapFromEntity(city);
            }

            return null;
        }

        private City mapFromEntity(Cities entity)
        {
            City obj = new City();
            obj.Id = entity.Id;
            obj.Name = entity.Name;
            obj.Available = entity.Available;
            return obj;
        }

        private Cities mapToEntity(City obj, Cities entity)
        {
            entity.Id = obj.Id;
            entity.Name = obj.Name;
            entity.Available = obj.Available;
            return entity;
        }
    }
}