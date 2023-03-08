using SabreenCompany.Connection;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SabreenCompany.Classes.Connection.ProductsProcess
{
    class Cls_ProductDB
    {
        Cls_AccessLayer_DB connection = new Cls_AccessLayer_DB();
        //==> Process Products Forms

        //    <=============== Method ======================>

        //==> 1 getData To Products
        public DataTable getDataProducts()
        {
            DataTable dataProducts = new DataTable();
            try
            {
                connection.open();
                dataProducts = connection.Read_Data("getDataProducts", null);
                connection.cloes();
                return dataProducts;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return dataProducts;
            }
        }
        //==> 2 Insert To Products
        public void insertProduct(int  id_Category,string name, float price, float number,string desc,byte []image)
        {
            try
            {
                connection.open();
                SqlParameter[] param = new SqlParameter[6];
                param[0] = new SqlParameter("@id_Cat", SqlDbType.Int);
                param[0].Value = id_Category;
                param[1] = new SqlParameter("@name", SqlDbType.NVarChar);
                param[1].Value = name;
                param[2] = new SqlParameter("@price", SqlDbType.Money);
                param[2].Value = price;
                param[3] = new SqlParameter("@number", SqlDbType.Float);
                param[3].Value = number;
                param[4] = new SqlParameter("@desc", SqlDbType.Text);
                param[4].Value = desc;
                param[5] = new SqlParameter("@image", SqlDbType.Image);
                param[5].Value = image;
                connection.process("insertProduct", param);
                connection.cloes();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        //==> 3 Update To Products
        public void updateProduct(int id,int id_Category, string name, float price, float number, string desc, byte[] image)
        {
            try
            {
                connection.open();
                SqlParameter[] param = new SqlParameter[7];
                param[0] = new SqlParameter("@id_Cat", SqlDbType.Int);
                param[0].Value = id_Category;
                param[1] = new SqlParameter("@name", SqlDbType.NVarChar);
                param[1].Value = name;
                param[2] = new SqlParameter("@price", SqlDbType.Money);
                param[2].Value = price;
                param[3] = new SqlParameter("@number", SqlDbType.Float);
                param[3].Value = number;
                param[4] = new SqlParameter("@desc", SqlDbType.Text);
                param[4].Value = desc;
                param[5] = new SqlParameter("@image", SqlDbType.Image);
                param[5].Value = image;
                param[6] = new SqlParameter("@id", SqlDbType.Int);
                param[6].Value = id;
                connection.process("updateProduct", param);
                connection.cloes();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        //==> 4 Delete To Products
        public void deleteProduct(int id)
        {
            try
            {
                connection.open();
                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@id", SqlDbType.Int);
                param[0].Value = id;
                connection.process("deleteProduct", param);
                connection.cloes();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        //==> 5 Seaech To Products
        public DataTable serachDataProduct(string text)
        {
            DataTable dataCategory = new DataTable();
            try
            {
                connection.open();
                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@textSearch", SqlDbType.NVarChar);
                param[0].Value = text;
                dataCategory = connection.Read_Data("serachDataProduct", param);
                connection.cloes();
                return dataCategory;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return dataCategory;
            }
        }
        //==> 5 getproductIndividual To Products
        public DataTable getproductIndividualData(int id)
        {
            DataTable dataProduct = new DataTable();
            try
            {
                connection.open();
                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@id", SqlDbType.Int);
                param[0].Value = id;
                dataProduct = connection.Read_Data("getproductIndividualData", param);
                connection.cloes();
                return dataProduct;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return dataProduct;
            }
        }
        //==> 6 Update Set Number Product  To Invoice
        public void updateSetNumberProduct(int id, float numberNew)
        {
            try
            {
                connection.open();
                SqlParameter[] param = new SqlParameter[2];
                param[0] = new SqlParameter("@id", SqlDbType.Int);
                param[0].Value = id;
                param[1] = new SqlParameter("@numberNew", SqlDbType.Float);
                param[1].Value = numberNew;
                connection.process("updateSetNumberProduct", param);
                connection.cloes();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
