using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace product_management.BL
{
    class CLS_PRODUCT
    {
        public DataTable GET_ALL_CATAGORIES()
        {
            DAL.DataAccessLayer dataAccessLayer = new DAL.DataAccessLayer();
            DAL.DataAccessLayer DAL = dataAccessLayer;
            DAL.Open();
            DataTable dt = new DataTable();
            dt = DAL.Selectdata("GET_ALL_CATAGORIES", null);
            DAL.Close();
            return dt;
        }
       
        public void ADD_PRODUCT(int id_cat, string lebel_product,string id_product,
            int qte,string price,byte[] image)
        {
            DAL.DataAccessLayer dataAccessLayer = new DAL.DataAccessLayer();
            dataAccessLayer.Open();
            SqlParameter[] param = new SqlParameter[6];
            param[0] = new SqlParameter("@id_cat", SqlDbType.Int);
            param[0].Value = id_cat;

            param[1] = new SqlParameter("@id_product", SqlDbType.VarChar,30);
            param[1].Value = id_product;

            param[2] = new SqlParameter("@lebel", SqlDbType.VarChar,30);
            param[2].Value = lebel_product;

            param[3] = new SqlParameter("@qte", SqlDbType.Int);
            param[3].Value = qte;

            param[4] = new SqlParameter("@price", SqlDbType.VarChar,50);
            param[4].Value = price;

            param[5] = new SqlParameter("@img", SqlDbType.Image);
            param[5].Value = image;
            dataAccessLayer.Excutecommand("ADD_PRODUCT", param);
            dataAccessLayer.Close();
            

        }


        public void update_product(int id_cat, string lebel_product, string id_product,
           int qte, string price, byte[] image)
        {
            DAL.DataAccessLayer dataAccessLayer = new DAL.DataAccessLayer();
            dataAccessLayer.Open();
            SqlParameter[] param = new SqlParameter[6];
            param[0] = new SqlParameter("@id_cat", SqlDbType.Int);
            param[0].Value = id_cat;

            param[1] = new SqlParameter("@id_product", SqlDbType.VarChar, 30);
            param[1].Value = id_product;

            param[2] = new SqlParameter("@lebel", SqlDbType.VarChar, 30);
            param[2].Value = lebel_product;

            param[3] = new SqlParameter("@qte", SqlDbType.Int);
            param[3].Value = qte;

            param[4] = new SqlParameter("@price", SqlDbType.VarChar, 50);
            param[4].Value = price;

            param[5] = new SqlParameter("@img", SqlDbType.Image);
            param[5].Value = image;
            dataAccessLayer.Excutecommand("update_product", param);
            dataAccessLayer.Close();


        }

        public DataTable verifyProductdi(string ID)
        {
            DAL.DataAccessLayer dataAccessLayer = new DAL.DataAccessLayer();
            DAL.DataAccessLayer DAL = dataAccessLayer;
            DAL.Open();
            DataTable dt = new DataTable();
            SqlParameter[] parm = new SqlParameter[1];
            parm[0] = new SqlParameter("@ID", SqlDbType.VarChar, 50);
            parm[0].Value = ID;
            dt = DAL.Selectdata("verifyProductdi", parm);
            DAL.Close();
            return dt;
        }

        public DataTable GET_ALL_PRODUCTS()
        {
            DAL.DataAccessLayer dataAccessLayer = new DAL.DataAccessLayer();
            DAL.DataAccessLayer DAL = dataAccessLayer;
            DAL.Open();
            DataTable dt = new DataTable();
            dt = DAL.Selectdata("GET_ALL_PRODUCTS", null);
            DAL.Close();
            return dt;
        }


        public DataTable SerechProduct(string ID)
        {
            DAL.DataAccessLayer dataAccessLayer = new DAL.DataAccessLayer();
            DAL.DataAccessLayer DAL = dataAccessLayer;
            DAL.Open();
            DataTable dt = new DataTable();
            SqlParameter[] parm = new SqlParameter[1];
            parm[0] = new SqlParameter("@ID", SqlDbType.VarChar, 50);
            parm[0].Value = ID;
            dt = DAL.Selectdata("SerechProduct", parm);
            DAL.Close();
            return dt;
        }

       


        public void DeleteProduct(string ID)
           
        {
            DAL.DataAccessLayer dataAccessLayer = new DAL.DataAccessLayer();
            dataAccessLayer.Open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID", SqlDbType.VarChar,50);
            param[0].Value = ID;
            dataAccessLayer.Excutecommand("DeleteProduct", param);
            dataAccessLayer.Close();


        }
    }
}
