using BusinessLayer.Abstract;
using CoreLayer.Utilities.Hashing;
using EntityLayer.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class AuthManager : IAuthService
    {
        private readonly IUserService userService;

        public AuthManager(IUserService _userService)
        {
            userService = _userService;
        }

        public string Login(LoginAuthDto login)
        {
            var user = userService.GetByMail(login.Email);
            var result = HashingHelper.VerifyPasswordHash(login.Password, user.PASSWORD_HASH, user.PASSWORD_SALT);
            if (result)
            {
                return "Başarılı";
            }
            return "Başarısız";
        }

        public void Register(RegisterAuthDto register)
        {
            userService.Add(register);
        }
    }
}
