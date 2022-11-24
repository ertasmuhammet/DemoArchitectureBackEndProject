using EntityLayer.Concrete;
using EntityLayer.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IUserService
    {
        void Add(RegisterAuthDto authDto);
        List<User> GetList();
        User GetByMail(string email);
    }
}
