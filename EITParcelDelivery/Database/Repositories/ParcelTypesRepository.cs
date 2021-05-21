using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EITParcelDelivery.Models;

namespace EITParcelDelivery.Database.Repositories
{
    public class ParcelTypesRepository
    {
        public List<ParcelType> getAll() 
        {
            List<ParcelType> parcelTypes = new List<ParcelType>();

            EITDBEntities ctx = new EITDBEntities();
            foreach (var entity in ctx.ParcelTypes)
            {
                parcelTypes.Add(
                    mapFromEntity(entity)
                );
            }

            return parcelTypes;
        }

        private ParcelType mapFromEntity(ParcelTypes entity)
        {
            ParcelType obj = new ParcelType();
            obj.Id = entity.Id;
            obj.Supported = entity.Supported;
            obj.Fee = entity.Fee;
            obj.Type = entity.Type;
            return obj;
        }

        private ParcelTypes mapToEntity(ParcelType obj, ParcelTypes entity)
        {
            entity.Id = obj.Id;
            entity.Supported = obj.Supported;
            entity.Fee = obj.Fee;
            entity.Type = obj.Type;
            return entity;
        }
    }
}