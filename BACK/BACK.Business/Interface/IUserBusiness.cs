using BACK.Model.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BACK.Business.Interface
{
    public interface IUserBusiness
    {
        UserToken Login(User userInfo);
    }
}
