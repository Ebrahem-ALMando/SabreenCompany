using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SabreenCompany.Connection;
namespace SabreenCompany.Classes.Login
{
    class Cls_Login:Cls_AccessLayer_DB
    {
  
        public bool isLoogin(string User_Name, string Pass)
        {
            using (var conction = GetConction())
            {
                conction.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = conction;
                    command.CommandText = @"select * from Users_TB 
                                            where UserName = @User_N
                                            and Password = @User_Pass";
                    command.Parameters.AddWithValue("@User_N", User_Name);
                    command.Parameters.AddWithValue("@User_Pass", Pass);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                     
                        return true;
                    }
                    else
                    {
                       
                        return false;
                    }

                }
                
            }
        }

    }
}
