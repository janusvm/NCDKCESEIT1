using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EITParcelDelivery.Models;
using EITParcelDelivery.Repositories;

namespace EITParcelDelivery.Database.Repositories
{
    public class EdgesRepository
    {
        public List<Edge> getAll()
        {
            List<Edge> edges = new List<Edge>();

            EITDBEntities ctx = new EITDBEntities();
            foreach (var entity in ctx.Edges)
            {
                edges.Add(
                    mapFromEntity(entity)
                );
            }

            return edges;
        }

        private Edge mapFromEntity(Edges entity)
        {
            var citiesRepository = new CitiesRepository();
            Edge obj = new Edge();
            obj.Id = entity.Id;
            obj.Source = citiesRepository.get(entity.Source);
            obj.Destination = citiesRepository.get(entity.Destination);
            obj.Segments = entity.Segments;
            return obj;
        }
    }
}