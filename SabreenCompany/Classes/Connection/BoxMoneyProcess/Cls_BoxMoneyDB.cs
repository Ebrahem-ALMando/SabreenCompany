using SabreenCompany.Connection;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SabreenCompany.Classes.Connection.BoxMoneyProcess
{
    class Cls_BoxMoneyDB
    {
        Cls_AccessLayer_DB connection = new Cls_AccessLayer_DB();
        //==> Process BoxMoney Forms

        //    <=============== Method ======================>

        //==> 1 getData To BoxMoney
        public DataTable getDataBoxMoney()
        {
            DataTable dataBoxMoney = new DataTable();
            try
            {
                connection.open();
                dataBoxMoney = connection.Read_Data("getDataBoxMoney", null);
                connection.cloes();
                return dataBoxMoney;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return dataBoxMoney;
            }
        }

        //==> 2 Withdrawal To BoxMoney
        public void withdrawalBoxMony(int id_Mon_B, int id_inc,int id_Pro, float TotalAmount,int isTake, int isDeposit)
        {
            try
            {
                connection.open();
                SqlParameter[] param = new SqlParameter[6];
                param[0] = new SqlParameter("@id_Mon_B", SqlDbType.Int);
                param[0].Value = id_Mon_B;
                param[1] = new SqlParameter("@id_inc", SqlDbType.Int);
                param[1].Value = id_inc;
                param[2] = new SqlParameter("@id_Pro", SqlDbType.Int);
                param[2].Value = id_Pro;
                param[3] = new SqlParameter("@TotalAmount", SqlDbType.Float);
                param[3].Value = TotalAmount;
                param[4] = new SqlParameter("@isTake", SqlDbType.Int);
                param[4].Value = isTake;
                param[5] = new SqlParameter("@isDeposit", SqlDbType.Int);
                param[5].Value = isDeposit;
                connection.process("withdrawalBoxMony", param);
                connection.cloes();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        //==> 3 Deposit To BoxMoney
        public void depositBoxMony(int id_Mon_B, int id_inc, int id_Pro, float TotalAmount, int isTake, int isDeposit)
        {
            try
            {
                connection.open();
                SqlParameter[] param = new SqlParameter[6];
                param[0] = new SqlParameter("@id_Mon_B", SqlDbType.Int);
                param[0].Value = id_Mon_B;
                param[1] = new SqlParameter("@id_inc", SqlDbType.Int);
                param[1].Value = id_inc;
                param[2] = new SqlParameter("@id_Pro", SqlDbType.Int);
                param[2].Value = id_Pro;
                param[3] = new SqlParameter("@TotalAmount", SqlDbType.Float);
                param[3].Value = TotalAmount;
                param[4] = new SqlParameter("@isTake", SqlDbType.Int);
                param[4].Value = isTake;
                param[5] = new SqlParameter("@isDeposit", SqlDbType.Int);
                param[5].Value = isDeposit;
                connection.process("depositBoxMony", param);
                connection.cloes();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

    }
}
