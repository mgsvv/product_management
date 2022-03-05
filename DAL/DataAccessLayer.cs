using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace product_management.DAL
{
    class DataAccessLayer
    {
        SqlConnection sqlconnection;
        

        //هذا المشيد يقوم باستنساخ كائن الاتصال
        public DataAccessLayer()
        {
            sqlconnection = new SqlConnection(@"server=.\;database=product_DB;integrated security=true ");
        }

        //اجراء فتح الاتصال
        public void Open()
        {
            if (sqlconnection.State != ConnectionState.Open)
            {
                sqlconnection.Open();

            }

        }
        //اجراء اغلاق الاتصال
        public void Close()
        {
            if (sqlconnection.State == ConnectionState.Open)

            {
                sqlconnection.Close();
            }
        }
        //read data from DB
        public DataTable Selectdata(string stored_procedure,SqlParameter [] param )
        {
            SqlCommand sqlcmd = new SqlCommand
            {
                CommandType = CommandType.StoredProcedure,
                CommandText = stored_procedure,
                Connection = sqlconnection
            };
            if (param != null)
            {
                for(int i=0; i < param.Length; i++)
                {
                    sqlcmd.Parameters.Add(param[i]);
                }
            }
            SqlDataAdapter da = new SqlDataAdapter(sqlcmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;

        }
        //method to delet insert update from DB
        public void Excutecommand(string stored_procedure,SqlParameter[]param)
        {
            SqlCommand sqlcmd = new SqlCommand
            {
                CommandType = CommandType.StoredProcedure,
                CommandText = stored_procedure,
                Connection = sqlconnection
            };
            if (param != null)
            {
                sqlcmd.Parameters.AddRange(param);

            }
            sqlcmd.ExecuteNonQuery();
        }

    }


}
