using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EITParcelDelivery.Models;

namespace EITParcelDelivery.Database.Repositories
{
    public class UserRepository
    {
        public User get(int id)
        {
            var ctx = new EITDBEntities();
            var user = ctx.Users.FirstOrDefault(x => x.Id == id);
            if (user != null)
            {
                return mapFromEntity(user);
            }

            return null;
        }

        public User get(string username, string password)
        {
            var ctx = new EITDBEntities();
            var user = ctx.Users.FirstOrDefault(x => x.Username.ToLower() == username.ToLower() && x.Password == password);
            if (user != null)
            {
                return mapFromEntity(user);
            }

            return null;
        } 

        private User mapFromEntity(Users entity)
        {
            User obj = new User();
            obj.Id = entity.Id;
            obj.Username = entity.Username;
            obj.Password = entity.Password;
            obj.Role = entity.Role == 1 ? Enums.Role.Admin : Enums.Role.PortManager;
            return obj;
        }

        private Users mapToEntity(User obj, Users entity)
        {
            entity.Id = obj.Id;
            entity.Username = obj.Username;
            entity.Password = obj.Password;
            entity.Role = (int)obj.Role;
            return entity;
        }
    }
}