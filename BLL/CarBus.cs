using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CarBus
    {
        private readonly CarDAL _dal;

        public CarBus()
        {
            _dal = new CarDAL();
        }

        public void AddCar(string model, string nsx, string fuel, string func, double price, string brand)
        {
            _dal.AddCar(model, nsx, fuel, func, price, brand);
        }

        public void DeleteCar(int id)
        {
            _dal.DeleteCar(id);
        }

        public DataTable GetAllCar()
        {
            return _dal.GetAllCar();
        }

        public object SearchCar(string keyword)
        {
           return _dal.SearchCar(keyword);
        }

        public void UpdateCar(int id, string model, string nsx, string fuel, string func, double price, string brand)
        {
            _dal.UpdateCar(id,model, nsx, fuel, func, price, brand);
        }

        public object GetCarsForRent(string model, string function, string fueltype)
        {
            // Logic to get cars by type from DAL
            return _dal.GetCarsForRent(model, function, fueltype);
        }

        public void ExportToExcel()
        {
            _dal.ExportToExcel();
        }

        public object ImportToExcel(string path)
        {
            return _dal.ImportToExcel(path);
        }

        public DataTable SearchCarsByID(int id)
        {
            return _dal.SearchCarByID(id);
        }

        public void UpdateStatus(int id, string status)
        {
            _dal.UpdateStatus(id, status);
        }
    }
}
