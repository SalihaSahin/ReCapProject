using Business.Abstract;
using Core.Entities.Concrete;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class UsersManager : IUsersService
    {
        IUsersDal _usersDal;

        public UsersManager(IUsersDal usersDal)
        {
            _usersDal = usersDal;
        }

        public List<OperationClaim> GetClaims(User user)
        {
            return _usersDal.GetClaims(user);
        }

        public void Add(User user)
        {
            _usersDal.Add(user);
        }

        public User GetByMail(string email)
        {
            return _usersDal.Get(u => u.Email == email);
        }
    }
}
