using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class OrderBus
    {
        private readonly OrderDAL _dal;

        public OrderBus()
        {
            _dal = new OrderDAL();
        }

        public void AddOrder(int cusID,string carID, string dtStart, string dtEnd, string total)
        {
            _dal.AddOrder(cusID,carID, dtStart, dtEnd, total);
        }

        public DataTable GetAllOder()
        {
            return _dal.GetAllOder();
        }

        public int getIDCus(string phone)
        {
            return _dal.getIDCus(phone);
        }

        public int getNumCar()
        {
            return _dal.getNumCar();
        }

        public int getNumCarRent()
        {
            return _dal.getNumCarRent();
        }

        public DataTable GetOrderRent()
        {
            return _dal.GetOrderRent();
        }

        public DataTable GetReportBrand()
        {
            return _dal.GetReportBrand();
        }

        public DataTable GetReportDate()
        {
            return _dal.GetReportDate();
        }

        public DataTable GetReportModel()
        {
            return _dal.GetReportModel();
        }
    }
}
