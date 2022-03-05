using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace product_management.BL
{
    class CLS_LOGIN
    {
        public DataTable LOGIN (string ID, string PWD)
        {
            DAL.DataAccessLayer dataAccessLayer = new DAL.DataAccessLayer();
            DAL.DataAccessLayer DAL = dataAccessLayer;
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@id", SqlDbType.VarChar, 50);
            param[0].Value = ID;
            param[1] = new SqlParameter("@PWD", SqlDbType.VarChar, 50);
            param[1].Value = PWD;

            
            DataTable dt = new DataTable();
            dt = DAL.Selectdata("SP_LOGIN", param);
            DAL.Close();
            return dt; 
        }

        public void ADD_USER(string ID, string FULLNAME, string PWD,
                    string USERTYPE)
        {
            DAL.DataAccessLayer dataAccessLayer = new DAL.DataAccessLayer();
            dataAccessLayer.Open();
            SqlParameter[] param = new SqlParameter[4];
            param[0] = new SqlParameter("@ID", SqlDbType.VarChar, 50);
            param[0].Value = ID;

            param[1] = new SqlParameter("@FULLNAME", SqlDbType.VarChar, 50);
            param[1].Value = FULLNAME;

            param[2] = new SqlParameter("@PWD", SqlDbType.VarChar, 50);
            param[2].Value = PWD;

            param[3] = new SqlParameter("@USERTYPE", SqlDbType.VarChar, 50);
            param[3].Value = USERTYPE;


            dataAccessLayer.Excutecommand("ADD_USER", param);
            dataAccessLayer.Close();
        }

        public void EDIT_USER(string ID, string FULLNAME, string PWD,
                   string usertype)
        {
            DAL.DataAccessLayer dataAccessLayer = new DAL.DataAccessLayer();
            dataAccessLayer.Open();
            SqlParameter[] param = new SqlParameter[4];
            param[0] = new SqlParameter("@ID", SqlDbType.VarChar, 50);
            param[0].Value = ID;

            param[1] = new SqlParameter("@FULLNAME", SqlDbType.VarChar, 50);
            param[1].Value = FULLNAME;

            param[2] = new SqlParameter("@PWD", SqlDbType.NChar, 50);
            param[2].Value = PWD;

            param[3] = new SqlParameter("@usertype", SqlDbType.VarChar, 50);
            param[3].Value = usertype;


            dataAccessLayer.Excutecommand("EDIT_USER", param);
            dataAccessLayer.Close();
        }

        public DataTable searchusers(string criterion)
        {
            DAL.DataAccessLayer dataAccessLayer = new DAL.DataAccessLayer();
            DAL.DataAccessLayer DAL = dataAccessLayer;
            DAL.Open();
            DataTable dt = new DataTable();
            SqlParameter[] parm = new SqlParameter[1];
            parm[0] = new SqlParameter("@criterion", SqlDbType.VarChar, 50);
            parm[0].Value = criterion;

            dt = DAL.Selectdata("searchusers", parm);
            DAL.Close();
            return dt;
        }
    }
}
