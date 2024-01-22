using DummyMSRestApi.Core.Contracts;
using DummyMSRestApi.Data;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;

namespace DummyMSRestApi.Core.Repository
{
    public class UserRepository : GenericRepository<UserType>, IUserRepository
    {
        private readonly DummyMSRestDbContext _context;

        public UserRepository(DummyMSRestDbContext context) : base(context)
        {
            this._context = context;
        }
        protected override void DefineId(ref UserType entity)
        {
            var sha = SHA256.Create();

            entity.Id = String.Concat(entity.Email, entity.displayName).GetHashCode().ToString();
            base.DefineId(ref entity);
        }

    }
}
