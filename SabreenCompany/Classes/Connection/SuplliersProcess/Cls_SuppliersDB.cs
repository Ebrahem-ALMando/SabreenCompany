using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SabreenCompany.Connection
{
    class Cls_SuppliersDB
    {
        Cls_AccessLayer_DB connection = new Cls_AccessLayer_DB();
        //==> Process Suppliers Forms

//    <=============== Method ======================>

        //==> 1 getData To Suppliers
        public DataTable getDataSuppliers()
        {
            DataTable dataSuppliers = new DataTable();
            try
            {
                connection.open();
                dataSuppliers = connection.Read_Data("getDataSuppliers", null);
                connection.cloes();
                return dataSuppliers;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return dataSuppliers;
            }
            
        }
        //==> 2 Insert To Suppliers
        public void insertSupplier(string name,string phone,string locition)
        {
            try
            {
                connection.open();
                SqlParameter[] param = new SqlParameter[3];
                param[0] = new SqlParameter("@name", SqlDbType.NVarChar);
                param[0].Value = name;
                param[1] = new SqlParameter("@phone", SqlDbType.NVarChar);
                param[1].Value = phone;
                param[2] = new SqlParameter("@locition", SqlDbType.NVarChar);
                param[2].Value = locition;
                connection.process("insertSuoppire", param);
                connection.cloes();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        //==> 3 Update To Suppliers
        public void updateSupplier(int id,string name, string phone, string locition)
        {
            try
            {
                connection.open();
                SqlParameter[] param = new SqlParameter[4];
                param[0] = new SqlParameter("@id", SqlDbType.Int);
                param[0].Value = id;
                param[1] = new SqlParameter("@name", SqlDbType.NVarChar);
                param[1].Value = name;
                param[2] = new SqlParameter("@phone", SqlDbType.NVarChar);
                param[2].Value = phone;
                param[3] = new SqlParameter("@locition", SqlDbType.NVarChar);
                param[3].Value = locition;
                connection.process("updateSupplier", param);
                connection.cloes();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        //==> 4 Delete To Suppliers
        public void deleteSupplier(int id)
        {
            try
            {
                connection.open();
                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@id", SqlDbType.Int);
                param[0].Value = id;
                connection.process("deleteSupplier", param);
                connection.cloes();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        //==> 5 Serach To Suppliers
        public DataTable serachDataSupplier(string text)
        {
            DataTable dataSuppliers = new DataTable();
            try
            {
                connection.open();
                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@textSearch", SqlDbType.NVarChar);
                param[0].Value = text;
                dataSuppliers = connection.Read_Data("serachDataSupplier", param);
                connection.cloes();
                return dataSuppliers;
            }
            catch (Exception ex)
            {
                return dataSuppliers;
            }
        }
    }
}
