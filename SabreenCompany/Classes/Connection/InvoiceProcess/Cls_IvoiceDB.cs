using SabreenCompany.Connection;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SabreenCompany.Classes.Connection.InvoiceProcess
{
    class Cls_IvoiceDB
    {
        Cls_AccessLayer_DB connection = new Cls_AccessLayer_DB();
        //==> Process Invoice Forms

        //    <=============== Method ======================>

        //==> 1 getData To Invoice
        public DataTable getDataInvoice()
        {
            DataTable dataInvoice = new DataTable();
            try
            {
                connection.open();
                dataInvoice = connection.Read_Data("getDataInvoice", null);
                connection.cloes();
                return dataInvoice;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return dataInvoice;
            }

        }



    }
}
