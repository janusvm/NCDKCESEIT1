using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EITParcelDelivery.Models;
using EITParcelDelivery.Repositories;

namespace EITParcelDelivery.Database.Repositories
{
    public class PathComponentsRepository
    {
        public PathComponent get(int id)
        {
            EITDBEntities ctx = new EITDBEntities();

            var entity = ctx.PathComponents.FirstOrDefault(x => x.Id == id);

            if (entity == null)
            {
                return null;
            }

            var citiesRepository = new CitiesRepository();
            PathComponent obj = new PathComponent();
            obj.Id = entity.Id;
            obj.ArrivedAt = entity.ArrivedAt;
            obj.City = citiesRepository.get(entity.City);

            if (entity.NextDestination == null)
            {
                return obj;
            }

            obj.NextDestination = get(entity.NextDestination.Value);

            return obj;
        }
    }
}