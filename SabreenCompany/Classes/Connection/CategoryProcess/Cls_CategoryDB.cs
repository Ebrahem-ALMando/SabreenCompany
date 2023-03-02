using SabreenCompany.Connection;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SabreenCompany.Classes.Connection.CategoryProcess
{
    class Cls_CategoryDB
    {
        Cls_AccessLayer_DB connection = new Cls_AccessLayer_DB();
        //==> Process Category Forms

        //    <=============== Method ======================>

        //==> 1 getData To Category
        public DataTable getDataCategory()
        {
            DataTable dataCategory = new DataTable();
            try
            {
                connection.open();
                dataCategory = connection.Read_Data("getDataCategory", null);
                connection.cloes();
                return dataCategory;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return dataCategory;
            }

        }
        //==> 2 Insert To Category
        public void insertCategory(int id_Sup,string name,string type,string note,DateTime date)
        {
            try
            {
                connection.open();
                SqlParameter[] param = new SqlParameter[5];
                param[0] = new SqlParameter("@name", SqlDbType.NVarChar);
                param[0].Value = name;
                param[1] = new SqlParameter("@idSupplier", SqlDbType.Int);
                param[1].Value = id_Sup;
                param[2] = new SqlParameter("@type", SqlDbType.NVarChar);
                param[2].Value = type;
                param[3] = new SqlParameter("@note", SqlDbType.NVarChar);
                param[3].Value = note;
                param[4] = new SqlParameter("@date", SqlDbType.Date);
                param[4].Value = date;
                connection.process("insertCategory", param);
                connection.cloes();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
     
        }
        //==> 3 Update To Category
        public void updateCategory(int id ,int id_Sup, string name, string type, string note, DateTime date)
        {
            try
            {
                connection.open();
                SqlParameter[] param = new SqlParameter[6];
                param[0] = new SqlParameter("@name", SqlDbType.NVarChar);
                param[0].Value = name;
                param[1] = new SqlParameter("@idSupplier", SqlDbType.Int);
                param[1].Value = id_Sup;
                param[2] = new SqlParameter("@type", SqlDbType.NVarChar);
                param[2].Value = type;
                param[3] = new SqlParameter("@note", SqlDbType.NVarChar);
                param[3].Value = note;
                param[4] = new SqlParameter("@date", SqlDbType.Date);
                param[4].Value = date;
                param[5] = new SqlParameter("@id", SqlDbType.Int);
                param[5].Value = id;
                connection.process("updateCategory", param);
                connection.cloes();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        //==> 4 Delete To Category
        public void deleteCategory(int id)
        {
            try
            {
                connection.open();
                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@id", SqlDbType.Int);
                param[0].Value = id;
                connection.process("deleteCategory", param);
                connection.cloes();
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        //==> 5 Seaech To Category
        public DataTable serachDataCategory(string text)
        {
            DataTable dataCategory = new DataTable();
            try
            {
                connection.open();
                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@textSearch", SqlDbType.NVarChar);
                param[0].Value = text;
                dataCategory = connection.Read_Data("serachDataCategory", param);
                connection.cloes();
                return dataCategory;
            }
            catch (Exception ex)
            {
                return dataCategory;
            }
        }
    }
}
