using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TradingCompany.DAL.Interfaces;
using TradingCompany.Dto;

namespace TradingCompany.DAL.Concrete
{
    public class UserDAL : IUserDAL
    {
       public bool Delete(int userId)
        {
            throw new NotImplementedException();
        }


        public List<User> GetAll()
        {
            throw new NotImplementedException();
        }

        public User GetById(int userId)
        {
            throw new NotImplementedException();
        }

        public User Register(User user)
        {
            throw new NotImplementedException();
        }

        public User Update(User user)
        {
            throw new NotImplementedException();
        }
    }
}
