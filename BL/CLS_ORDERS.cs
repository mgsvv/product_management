using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient; 
namespace product_management.BL
{
    class CLS_ORDERS
    {
        public DataTable GET_LAST_ORDER_ID()
        {
            DAL.DataAccessLayer dataAccessLayer = new DAL.DataAccessLayer();
            DAL.DataAccessLayer DAL = dataAccessLayer;
            DAL.Open();
            DataTable dt = new DataTable();
            dt = DAL.Selectdata("GET_LAST_ORDER_ID", null);
            DAL.Close();
            return dt;
        }
        public void ADD_ORDER(int ID_ORDER, DateTime DATE_ORDER, int CUSTOMER_ID,
                    string DES_ORDER, string SALES_MAN)
        {
            DAL.DataAccessLayer dataAccessLayer = new DAL.DataAccessLayer();
            dataAccessLayer.Open();
            SqlParameter[] param = new SqlParameter[5];
            param[0] = new SqlParameter("@ID_ORDER", SqlDbType.Int);
            param[0].Value = ID_ORDER;

            param[1] = new SqlParameter("@DATE_ORDER", SqlDbType.DateTime);
            param[1].Value = DATE_ORDER;

            param[2] = new SqlParameter("@CUSTOMER_ID", SqlDbType.Int);
            param[2].Value = CUSTOMER_ID;

            param[3] = new SqlParameter("@DES_ORDER", SqlDbType.VarChar, 250);
            param[3].Value = DES_ORDER;

            param[4] = new SqlParameter("@SALES_MAN", SqlDbType.VarChar, 75);
            param[4].Value = SALES_MAN;


            dataAccessLayer.Excutecommand("ADD_ORDER", param);
            dataAccessLayer.Close();
        }

        public DataTable verfiqte(string ID_PRODUCT,int QTE_ent)
        {
            DAL.DataAccessLayer dataAccessLayer = new DAL.DataAccessLayer();
            DAL.DataAccessLayer DAL = dataAccessLayer;
            DAL.Open();
            DataTable dt = new DataTable();
            SqlParameter[] parm = new SqlParameter[2];
            parm[0] = new SqlParameter("@ID_PRODUCT", SqlDbType.VarChar, 30);
            parm[0].Value = ID_PRODUCT;

            parm[1] = new SqlParameter("@QTE_ent", SqlDbType.Int);
            parm[1].Value = QTE_ent;
            dt = DAL.Selectdata("verfiqte", parm);
            DAL.Close();
            return dt;
        }

        public DataTable serach_orders(string criterio)
        {
            DAL.DataAccessLayer dataAccessLayer = new DAL.DataAccessLayer();
            DAL.DataAccessLayer DAL = dataAccessLayer;
            DAL.Open();
            DataTable dt = new DataTable();
            SqlParameter[] parm = new SqlParameter[1];
            parm[0] = new SqlParameter("@criterio", SqlDbType.VarChar, 50);
            parm[0].Value = criterio;

            dt = DAL.Selectdata("serach_orders", parm);
            DAL.Close();
            return dt;
        }





        public void ADD_ORDER_DETAILS(string @ID_PRODUCT, int @ID_ORDER, int @QTE,
                   string @PRICE, float @DISCOUNT,string @AMOUNT,string @TOTAL_AMOUNT)
        {
            DAL.DataAccessLayer dataAccessLayer = new DAL.DataAccessLayer();
            dataAccessLayer.Open();
            SqlParameter[] param = new SqlParameter[7];
            param[0] = new SqlParameter("@ID_PRODUCT", SqlDbType.VarChar,30);
            param[0].Value = ID_PRODUCT;

            param[1] = new SqlParameter("@ID_ORDER", SqlDbType.Int);
            param[1].Value = ID_ORDER;

            param[2] = new SqlParameter("@QTE", SqlDbType.Int);
            param[2].Value = QTE;

            param[3] = new SqlParameter("@PRICE", SqlDbType.VarChar,50);
            param[3].Value = PRICE;

            param[4] = new SqlParameter("@DISCOUNT", SqlDbType.Float);
            param[4].Value = DISCOUNT;

            param[5] = new SqlParameter("@AMOUNT", SqlDbType.VarChar,50);
            param[5].Value = DISCOUNT;

            param[6] = new SqlParameter("@TOTAL_AMOUNT", SqlDbType.VarChar,50);
            param[6].Value = TOTAL_AMOUNT;


            dataAccessLayer.Excutecommand("ADD_ORDER_DETAILS", param);
            dataAccessLayer.Close();
        }
    }
}
