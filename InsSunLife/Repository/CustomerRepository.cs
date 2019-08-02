using Dapper;
using InsSunLife.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace InsSunLife.Repository
{
    public class CustomerRepository
    {       
        public int GetByUserLogin(Customer customer)
        {
            try
            {
                var param = new DynamicParameters();
                if (customer.CustomerID != Guid.Empty)
                    param.Add("@CustomerID", customer.CustomerID, DbType.Guid);
                else
                    param.Add("@CustomerID", Guid.NewGuid(), DbType.Guid);


                param.Add("@Name", customer.Name, DbType.String);
                param.Add("@Dob", customer.Dob, DbType.Date);
                param.Add("@Age", customer.Age, DbType.Int32);
                param.Add("@Job", customer.Job, DbType.String);
                param.Add("@PayMoney", customer.PayMoney, DbType.Int32);
                param.Add("@Duration", customer.Duration, DbType.Int32);
                param.Add("@PayDuration", customer.PayDuration, DbType.Int32);
                param.Add("@TaxPerYear", customer.TaxPerYear, DbType.Int32);
                param.Add("@BasicIns_quy", customer.BasicIns_quy, DbType.String);
                param.Add("@BasicIns_nuanam", customer.BasicIns_nuanam, DbType.String);
                param.Add("@BasicIns_nam", customer.BasicIns_nam, DbType.String);
                param.Add("@AddItemIns_quy", customer.AddItemIns_quy, DbType.String);
                param.Add("@AddItemIns_nuanam", customer.AddItemIns_nuanam, DbType.String);
                param.Add("@AddItemIns_nam", customer.AddItemIns_nam, DbType.String);
                param.Add("@PayAdd_quy", customer.PayAdd_quy, DbType.String);
                param.Add("@PayAdd_nuanam", customer.PayAdd_nuanam, DbType.String);
                param.Add("@PayAdd_nam", customer.PayAdd_nam, DbType.String);
                param.Add("@ProductID", customer.ProductID, DbType.Int32);
                var enumResult = DapperHelper.Execute("insurance_AddNewCustomer", "admin", param);
                return enumResult;


            }
            catch (Exception ex)
            {
                // ghi log
                throw ex;
            }
        }

        public int UpdateCustomer(Customer customer)
        {
            try
            {
                var param = new DynamicParameters();
                param.Add("@CustomerID", customer.CustomerID, DbType.Guid);
                param.Add("@Name", customer.Name, DbType.String);
                param.Add("@Dob", customer.Dob, DbType.Date);
                param.Add("@Age", customer.Age, DbType.Int32);
                param.Add("@Job", customer.Job, DbType.String);
                param.Add("@PayMoney", customer.PayMoney, DbType.Int32);
                param.Add("@Duration", customer.Duration, DbType.Int32);
                param.Add("@PayDuration", customer.PayDuration, DbType.Int32);
                param.Add("@TaxPerYear", customer.TaxPerYear, DbType.Int32);
                param.Add("@BasicIns_quy", customer.BasicIns_quy, DbType.String);
                param.Add("@BasicIns_nuanam", customer.BasicIns_nuanam, DbType.String);
                param.Add("@BasicIns_nam", customer.BasicIns_nam, DbType.String);
                param.Add("@AddItemIns_quy", customer.AddItemIns_quy, DbType.String);
                param.Add("@AddItemIns_nuanam", customer.AddItemIns_nuanam, DbType.String);
                param.Add("@AddItemIns_nam", customer.AddItemIns_nam, DbType.String);
                param.Add("@PayAdd_quy", customer.PayAdd_quy, DbType.String);
                param.Add("@PayAdd_nuanam", customer.PayAdd_nuanam, DbType.String);
                param.Add("@PayAdd_nam", customer.PayAdd_nam, DbType.String);
                param.Add("@ProductID", customer.ProductID, DbType.Int32);
                var enumResult = DapperHelper.Execute("insurance_UpdateCustomer", "admin", param);
                return enumResult;
            }
            catch (Exception ex)
            {
                // ghi log
                throw ex;
            }
        }

        public IEnumerable<Customer> GetAllCustomer(string Name, DateTime CreateDate)
        {
            try
            {
                var param = new DynamicParameters();
                param.Add("@Name", Name, DbType.String);
                if (CreateDate != DateTime.MinValue)
                    param.Add("@CreateDate", CreateDate, DbType.DateTime);

                var enumResult = DapperHelper.Query<Customer>("insurance_GetAllCustomer", "admin", param);
                return enumResult;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public IEnumerable<Customer> GetById(Guid id)
        {
            try
            {
                var param = new DynamicParameters();
                param.Add("@CustomerId", id, DbType.Guid);

                var enumResult = DapperHelper.Query<Customer>("insurance_GetCustomerByID", "admin", param);
                return enumResult;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public IEnumerable<Customer> GetByName(string Name)
        {
            try
            {
                var param = new DynamicParameters();
                param.Add("@Name", Name, DbType.String);

                var enumResult = DapperHelper.Query<Customer>("insurance_GetCustomerByName", "admin", param);
                return enumResult;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}