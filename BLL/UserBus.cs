using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace BLL
{
    public class UserBus
    {
        private readonly DataAccessLayer _dal;


        public UserBus() { 
            _dal = new DataAccessLayer(); 
        }

        public string ValidateLogin(string username, string password) {
            DataTable dt = _dal.GetUser(username, password);
            if (dt.Rows.Count > 0) { 
                return dt.Rows[0]["UserRole"].ToString();
            }
            return null;
        }
    }
}
