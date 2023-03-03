using SabreenCompany.Connection;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SabreenCompany.Classes.Connection.SettingsProcess
{
    class Cls_SettingsDB
    {
        Cls_AccessLayer_DB connection = new Cls_AccessLayer_DB();
        //==> Process Settings Forms

        //    <=============== Method ======================>

        //==> 1 getData To User
        public DataTable getDataUser(string userName)
        {
            DataTable dataUser = new DataTable();
            try
            {
                connection.open();
                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@userName", SqlDbType.NVarChar);
                param[0].Value = userName;
                dataUser = connection.Read_Data("getDataUser", param);
                connection.cloes();
                return dataUser;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return dataUser;
            }

        }
        //==> 2 Update To User Password
        public void updateUserPassword(int id,string newPassword)
        {
            try
            {
                connection.open();
                SqlParameter[] param = new SqlParameter[2];
                param[0] = new SqlParameter("@id", SqlDbType.Int);
                param[0].Value = id;
                param[1] = new SqlParameter("@newPassword", SqlDbType.NVarChar);
                param[1].Value = newPassword;
                connection.process("updateUserPassword", param);
                connection.cloes();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
