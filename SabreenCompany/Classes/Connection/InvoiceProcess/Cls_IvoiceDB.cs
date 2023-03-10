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
        //==> 2 get ID Invoice ToAddProduct To Invoice
        public DataTable getIDInvoiceToAddProduct()
        {
            DataTable dataInvoice = new DataTable();
            try
            {
                connection.open();
                dataInvoice = connection.Read_Data("getIDInvoiceToAddProduct", null);
                connection.cloes();
                return dataInvoice;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return dataInvoice;
            }

        }
        //==> 3 Insert To Invoice
        public void insertInvoice(int id_Cus,DateTime date,float totalPrice,float discount,float amountReceived,
            string desc, string note, string typePayment,int isPaymentDone)
        {
            try
            {
                connection.open();
                SqlParameter[] param = new SqlParameter[9];
                param[0] = new SqlParameter("@id_Cus", SqlDbType.Int);
                param[0].Value = id_Cus;
                param[1] = new SqlParameter("@date", SqlDbType.Date);
                param[1].Value = date;
                param[2] = new SqlParameter("@totalPrice", SqlDbType.Float);
                param[2].Value = totalPrice;
                param[3] = new SqlParameter("@discount", SqlDbType.Float);
                param[3].Value = discount;
                param[4] = new SqlParameter("@amountReceived", SqlDbType.Float);
                param[4].Value = amountReceived;
                param[5] = new SqlParameter("@desc", SqlDbType.NVarChar);
                param[5].Value = desc;
                param[6] = new SqlParameter("@note", SqlDbType.NVarChar);
                param[6].Value = note;
                param[7] = new SqlParameter("@typePayment", SqlDbType.NVarChar);
                param[7].Value = typePayment;
                param[8] = new SqlParameter("@isPaymentDone", SqlDbType.Int);
                param[8].Value = isPaymentDone;
                connection.process("insertInvoice", param);
                connection.cloes();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        //==> 4 Insert Product To Invoice
        public void insertProductToInvoice(int id_Inv,int id_pro, float price, float number,float totalPriceProducts)
        {
            try
            {
                connection.open();
                SqlParameter[] param = new SqlParameter[5];
                param[0] = new SqlParameter("@id_Inv", SqlDbType.Int);
                param[0].Value = id_Inv;
                param[1] = new SqlParameter("@id_pro", SqlDbType.Int);
                param[1].Value = id_pro;
                param[2] = new SqlParameter("@price", SqlDbType.Float);
                param[2].Value = price;
                param[3] = new SqlParameter("@number", SqlDbType.Float);
                param[3].Value = number;
                param[4] = new SqlParameter("@totalPriceProducts", SqlDbType.Float);
                param[4].Value = totalPriceProducts;
                connection.process("insertProductToInvoice", param);
                connection.cloes();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        //==> 5 Update To Invoice
        public void updateInvoice(int id,int id_Cus, DateTime date, float totalPrice, float discount, float amountReceived,
          string desc, string note, string typePayment, int isPaymentDone)
        {
            try
            {
                connection.open();
                SqlParameter[] param = new SqlParameter[10];
                param[0] = new SqlParameter("@id_Cus", SqlDbType.Int);
                param[0].Value = id_Cus;
                param[1] = new SqlParameter("@date", SqlDbType.Date);
                param[1].Value = date;
                param[2] = new SqlParameter("@totalPrice", SqlDbType.Float);
                param[2].Value = totalPrice;
                param[3] = new SqlParameter("@discount", SqlDbType.Float);
                param[3].Value = discount;
                param[4] = new SqlParameter("@amountReceived", SqlDbType.Float);
                param[4].Value = amountReceived;
                param[5] = new SqlParameter("@desc", SqlDbType.NVarChar);
                param[5].Value = desc;
                param[6] = new SqlParameter("@note", SqlDbType.NVarChar);
                param[6].Value = note;
                param[7] = new SqlParameter("@typePayment", SqlDbType.NVarChar);
                param[7].Value = typePayment;
                param[8] = new SqlParameter("@isPaymentDone", SqlDbType.Int);
                param[8].Value = isPaymentDone;
                param[9] = new SqlParameter("@id", SqlDbType.Int);
                param[9].Value = id;
                connection.process("updateInvoice", param);
                connection.cloes();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        //==> 6 Update Product To Invoice

        //==> 7 Delete To Invoice
        public void deleteInvoice(int id)
        {
            try
            {
                connection.open();
                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@id", SqlDbType.Int);
                param[0].Value = id;
                connection.process("deleteInvoice", param);
                connection.cloes();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        //==> 8 Seaech To Invoice
        public DataTable serachDataInvoice(string text)
        {
            DataTable dataInvoice = new DataTable();
            try
            {
                connection.open();
                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@textSearch", SqlDbType.NVarChar);
                param[0].Value = text;
                dataInvoice = connection.Read_Data("serachDataInvoice", param);
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
