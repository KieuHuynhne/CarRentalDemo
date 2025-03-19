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
    public class CustomerBus
    {
        private readonly CustomerDAL _dal;

        public CustomerBus()
        {
            _dal = new CustomerDAL();
        }

     

        public DataTable GetAllCustomers()
        {
            return _dal.GetAllCustomers();
        }

        public void AddCustomer(string name, string address, string phone, string email)
        {
            _dal.AddCustomer(name, address, phone, email);
        }

        public void UpdateCustomer(int id, string name, string address, string phone, string email)
        {
            _dal.UpdateCustomer(id, name, address, phone, email);
        }

        public void DeleteCustomer(int id)
        {
            _dal.DeleteCustomer(id);
        }

        public object SearchCustommers(string keyword)
        {
            return _dal.SearchCustommers(keyword);
        }
        public object SearchCustommersByID(int keyword)
        {
            return _dal.SearchCustommersByID(keyword);
        }

        public void ExportToExcel()
        {
            _dal.ExportToExcel();
        }
    }
}
