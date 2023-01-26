using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System;
using NetWork_Food.DB_NetWork_Food;
using NetWork_Food.DB_NetWork_Food.Entities;

namespace NetWork_Food.Services
{
    public class ServiceFood
    {
        private readonly NetWork_Food_DBContext _dbContext;

        public ServiceFood(NetWork_Food_DBContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task Create(User user)
        {
            User foundUser = await _dbContext.Users.FirstOrDefaultAsync(u => u.Email == user.Email);
            if (foundUser != null)
            {
                foundUser.DateTime = DateTime.Now;
                _dbContext.Entry(foundUser).State = EntityState.Modified;
                await _dbContext.SaveChangesAsync();
            }
            else
            {
                user.DateTime = DateTime.Now;
                _dbContext.Users.Add(user);
                await _dbContext.SaveChangesAsync();
            }

        }
        public IQueryable<User> GetAll()
        {
            return _dbContext.Users;
        }

        public List<string> GetList()
        {
            var food = _dbContext.Users.GroupBy(e => e.Email)
                .Select(e =>
                    $"{e.Max(e => e.DateTime)} - {e.OrderByDescending(e => e.DateTime).First().Name} Eat {e.Count()} time").ToList();

            return food;
        }
    }
}
