using BusinessLayer.Abstract;
using CoreLayer.Utilities.Hashing;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using EntityLayer.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal userDal;

        public UserManager(IUserDal _userDal)
        {
            userDal = _userDal; 
        }
        public void Add(RegisterAuthDto register)
        {
            byte[] passwordHash, passwordSalt;

            HashingHelper.CreatePassword(register.Password, out passwordHash,out passwordSalt);

            User user = new User();
            user.EMAIL= register.Email;
            user.NAME = register.Name;
            user.IMAGE_URL = register.ImageUrl;
            user.PASSWORD_HASH = passwordHash;
            user.PASSWORD_SALT = passwordSalt;

            userDal.Add(user);
        }

        public User GetByMail(string email)
        {
            var user = userDal.Get(p => p.EMAIL == email);
            return user;
        }

        public List<User> GetList()
        {
            return userDal.GetAll();
        }
    }
}
