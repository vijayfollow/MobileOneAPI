using DataAccessLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public interface iLogin
    {
        int InsertRegistration(UserData userData);
        DataTable UserLogin(UserData loginData);
    }
}
