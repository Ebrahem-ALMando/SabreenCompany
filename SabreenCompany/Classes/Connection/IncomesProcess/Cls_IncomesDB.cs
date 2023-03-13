using SabreenCompany.Connection;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SabreenCompany.Classes.Connection.IncomesProcess
{
    class Cls_IncomesDB
    {
        Cls_AccessLayer_DB connection = new Cls_AccessLayer_DB();
        //==> Process Incomes Forms

        //    <=============== Method ======================>

        //==> 1 getData To Incomes
        public DataTable getDataIncomes()
        {
            DataTable dataIncomes = new DataTable();
            try
            {
                connection.open();
                dataIncomes = connection.Read_Data("getDataIncomes", null);
                connection.cloes();
                return dataIncomes;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return dataIncomes;
            }

        }
        //==> 2 Insert To Incomes
        public void insertIncomes(int idCus,int idInv,float total,DateTime date)
        {
            try
            {
                connection.open();
                SqlParameter[] param = new SqlParameter[4];
                param[0] = new SqlParameter("@id_Cus", SqlDbType.Int);
                param[0].Value = idCus;
                param[1] = new SqlParameter("@id_Inv", SqlDbType.Int);
                param[1].Value = idInv;
                param[2] = new SqlParameter("@totalAmount", SqlDbType.Money);
                param[2].Value = total;
                param[3] = new SqlParameter("@date", SqlDbType.Date);
                param[3].Value = date;
                connection.process("insertIncomes", param);
                connection.cloes();
              
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
           
            }
        }
        //==> 3 Update To Incomes


        //==> 4 Delete To Incomes
        public void deleteIncome(int id, int idInv, float total)
        {
            try
            {
                connection.open();
                SqlParameter[] param = new SqlParameter[3];
                param[0] = new SqlParameter("@id", SqlDbType.Int);
                param[0].Value = id;
                param[1] = new SqlParameter("@id_Inv", SqlDbType.Int);
                param[1].Value = idInv;
                param[2] = new SqlParameter("@totalAmount", SqlDbType.Money);
                param[2].Value = total;
                connection.process("deleteIncome", param);
                connection.cloes();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        //==> 5 Search To Incomes
        public DataTable serachDataIncome(string text)
        {
            DataTable dataIncomes = new DataTable();
            try
            {
                connection.open();
                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@textSearch", SqlDbType.NVarChar);
                param[0].Value = text;
                dataIncomes = connection.Read_Data("serachDataIncome", param);
                connection.cloes();
                return dataIncomes;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return dataIncomes;
            }
        }
        //==> 6 Get ID To Current Income
        public DataTable getIdcurrentIncome()
        {
            DataTable dataIncomes = new DataTable();
            try
            {
                connection.open();
                dataIncomes = connection.Read_Data("getIdcurrentIncome", null);
                connection.cloes();
                return dataIncomes;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return dataIncomes;
            }

        }
        //==> 7 Get IDInc_FK  From BoxMoney  Details and Invoice
        public DataTable getIDIncome_FKFromMoneyBox(int id)
        {
            DataTable dataIncome = new DataTable();
            try
            {
                connection.open();
                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@id_Inc", SqlDbType.Int);
                param[0].Value = id;
                dataIncome = connection.Read_Data("getIDIncome_FKFromMoneyBox", param);
                connection.cloes();
                return dataIncome;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return dataIncome;
            }
        }

    }
}
