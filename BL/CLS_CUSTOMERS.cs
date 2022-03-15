using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace product_management.BLbjvhgfhgfhgcgfcftcxrtfctrcrt
{
    class CLS_CUSTOMERS
    {
        public void ADD_CUSTOMER(string first_name, string last_name, string tel,
                    string email)
        {
            DAL.DataAccessLayer dataAccessLayer = new DAL.DataAccessLayer();
            dataAccessLayer.Open();
            SqlParameter[] param = new SqlParameter[4];
            param[0] = new SqlParameter("@first_name", SqlDbType.VarChar,25);
            param[0].Value = first_name;

            param[1] = new SqlParameter("@last_name", SqlDbType.VarChar, 25);
            param[1].Value = last_name;

            param[2] = new SqlParameter("@tel", SqlDbType.NChar, 15);
            param[2].Value = tel;

            param[3] = new SqlParameter("@email", SqlDbType.VarChar,25);
            param[3].Value = email;

            
            dataAccessLayer.Excutecommand("ADD_CUSTOMER", param);
            dataAccessLayer.Close();
        }

        public void edit_CUSTOMERS(string first_name, string last_name, string tel,
                   string email, int ID)
        {
            DAL.DataAccessLayer dataAccessLayer = new DAL.DataAccessLayer();
            dataAccessLayer.Open();
            SqlParameter[] param = new SqlParameter[5];
            param[0] = new SqlParameter("@first_name", SqlDbType.VarChar, 25);
            param[0].Value = first_name;

            param[1] = new SqlParameter("@last_name", SqlDbType.VarChar, 25);
            param[1].Value = last_name;

            param[2] = new SqlParameter("@tel", SqlDbType.NChar, 15);
            param[2].Value = tel;

            param[3] = new SqlParameter("@email", SqlDbType.VarChar, 25);
            param[3].Value = email;

            param[4] = new SqlParameter("@ID", SqlDbType.Int);
            param[4].Value = ID;


            dataAccessLayer.Excutecommand("edit_CUSTOMERS", param);
            dataAccessLayer.Close();
        }

        public void delete_customer(int ID)
        {
            DAL.DataAccessLayer dataAccessLayer = new DAL.DataAccessLayer();
            dataAccessLayer.Open();
            SqlParameter[] param = new SqlParameter[1];
            
            param[0] = new SqlParameter("@ID", SqlDbType.Int);
            param[0].Value = ID;


            dataAccessLayer.Excutecommand("delete_customer", param);
            dataAccessLayer.Close();
        }




        public DataTable GET_ALL_CUSTOMERS()
        {
            DAL.DataAccessLayer dataAccessLayer = new DAL.DataAccessLayer();
            DAL.DataAccessLayer DAL = dataAccessLayer;
            DAL.Open();
            DataTable dt = new DataTable();
            dt = DAL.Selectdata("GET_ALL_CUSTOMERS", null);
            DAL.Close();
            return dt;
        }

        public DataTable search_customer(string criterion)
        {
            DAL.DataAccessLayer dataAccessLayer = new DAL.DataAccessLayer();
            DAL.DataAccessLayer DAL = dataAccessLayer;
            DAL.Open();
            DataTable dt = new DataTable();
            SqlParameter[] param=new SqlParameter[1];
            param[0] = new SqlParameter("@criterion", SqlDbType.VarChar, 50);
            param[0].Value = criterion;
            dt = DAL.Selectdata("search_customer", param);
            DAL.Close();
            return dt;
        }
    }
}
