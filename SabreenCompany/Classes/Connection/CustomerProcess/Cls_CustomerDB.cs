using SabreenCompany.Connection;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SabreenCompany.Classes.Connection.CustomerProcess
{
    class Cls_CustomerDB
    {
        Cls_AccessLayer_DB connection = new Cls_AccessLayer_DB();
        //==> Process Customer Forms

        //    <=============== Method ======================>

        //==> 1 getData To Customer
        public DataTable getDataCustomer()
        {
            DataTable dataCustomers = new DataTable();
            try
            {
                connection.open();
                dataCustomers = connection.Read_Data("getDataCustomer", null);
                connection.cloes();
                return dataCustomers;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return dataCustomers;
            }
        }
        //==> 2 Insert To Customer
        public void insertCustomer(string name, string place,string phone ,DateTime date)
        {
            try
            {
                connection.open();
                SqlParameter[] param = new SqlParameter[4];
                param[0] = new SqlParameter("@name", SqlDbType.NVarChar);
                param[0].Value = name;
                param[1] = new SqlParameter("@place", SqlDbType.NVarChar);
                param[1].Value = place;
                param[2] = new SqlParameter("@phone", SqlDbType.NVarChar);
                param[2].Value = phone;
                param[3] = new SqlParameter("@date", SqlDbType.Date);
                param[3].Value = date;
                connection.process("insertCustomer", param);
                connection.cloes();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        //==> 3 Update To Customer
        public void updateCustomer(int id,string name, string place, string phone)
        {
            try
            {
                connection.open();
                SqlParameter[] param = new SqlParameter[4];
                param[0] = new SqlParameter("@name", SqlDbType.NVarChar);
                param[0].Value = name;
                param[1] = new SqlParameter("@place", SqlDbType.NVarChar);
                param[1].Value = place;
                param[2] = new SqlParameter("@phone", SqlDbType.NVarChar);
                param[2].Value = phone;
                param[3] = new SqlParameter("@id", SqlDbType.Int);
                param[3].Value = id;
                connection.process("updateCustomer", param);
                connection.cloes();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        //==> 4 Delete To Customer
        public void deleteCustomer(int id)
        {
            try
            {
                connection.open();
                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@id", SqlDbType.Int);
                param[0].Value = id;
                connection.process("deleteCustomer", param);
                connection.cloes();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        // in progras------------------------*-*-*-*-**
        //==> 5 Seaech To Customer
        public DataTable serachDataCustomer(string text)
        {
            DataTable dataCategory = new DataTable();
            try
            {
                connection.open();
                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@textSearch", SqlDbType.NVarChar);
                param[0].Value = text;
                dataCategory = connection.Read_Data("serachDataCustomer", param);
                connection.cloes();
                return dataCategory;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return dataCategory;
            }
        }
    }
}
