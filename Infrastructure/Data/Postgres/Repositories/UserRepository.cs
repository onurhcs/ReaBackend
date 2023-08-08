﻿using Infrastructure.Data.Postgres.Entities;
using Infrastructure.Data.Postgres.EntityFramework;
using Infrastructure.Data.Postgres.Repositories.Base;
using Infrastructure.Data.Postgres.Repositories.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq.Expressions;
using System.Xml.Linq;

namespace Infrastructure.Data.Postgres.Repositories
{
    public class UserRepository : Repository<User, int>, IUserRepository
    {
        private readonly PostgresContext _context;

        public UserRepository(PostgresContext postgresContext) : base(postgresContext)
        {
            _context = postgresContext;
        }

        // IRepository<User, int> arabiriminden gelen GetAllAsync metodu uygulanıyor.
        // Bu metot, tüm kullanıcıları getirmek için filtreleme seçeneği sağlar.
        public async Task<IList<User>> GetAllAsync(Expression<Func<User, bool>>? filter = null)
        {
            var user = PostgresContext.Set<User>();
            //.ThenInclude(advert => advert.Animal); iç içe tablo çağırmak için :)

            return filter == null
                ? await user.ToListAsync()
                : await user.Where(filter)
                .ToListAsync();
        }


        public async Task<User> GetByIdAsync(int id)
        {
            // Belirli bir kullanıcıyı kimlik numarasına göre almak için bu metodu kullanabilirsiniz.
            return await _context.User.FindAsync(id);
        }

        public async Task<List<User>> GetUsersByIdAsync(int id)
        {
            Expression<Func<User, bool>> filter = u => u.Id == id;
            return await GetUsersByFilterAsync(filter);
        }

        private async Task<List<User>> GetUsersByFilterAsync(Expression<Func<User, bool>> filter)
        {
            return await _context.User.Where(filter).ToListAsync();
        }

        public async Task<User> CreateUserAsync(User user)
        {
            // Yeni bir kullanıcıyı veritabanına eklemek için bu metodu kullanabilirsiniz.
            await _context.User.AddAsync(user);
            await _context.SaveChangesAsync();

            return user;
        }

        public async Task<User> UpdateUserAsync(User user)
        {
            // Var olan bir kullanıcıyı güncellemek için bu metodu kullanabilirsiniz.
            _context.User.Update(user);
            await _context.SaveChangesAsync();

            return user;
        }

        public async Task DeleteUserAsync(int id)
        {
            // Bir kullanıcıyı silmek için bu metodu kullanabilirsiniz.
            var user = await _context.User.FindAsync(id);
            if (user != null)
            {
                _context.User.Remove(user);
                await _context.SaveChangesAsync();
            }
        }

        public Task<IList<User>> GetByContactIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
