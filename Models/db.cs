using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace FriendApplication.Models
{
    public class db
    {
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-14NO1BO3\\SQLEXPRESS;Initial Catalog=CoreDatabase;Integrated Security=True");
        public int LoginCheck(TbLogin lg)
        {
            SqlCommand com = new SqlCommand("Sp_Login", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@UserId", lg.UserId);
            com.Parameters.AddWithValue("@MobileNo", lg.MobileNo);
            com.Parameters.AddWithValue("@Password", lg.Password);
            SqlParameter oblogin = new SqlParameter();
            oblogin.ParameterName = "@Isvalid";
            oblogin.SqlDbType = SqlDbType.Bit;
            oblogin.Direction = ParameterDirection.Output;
            com.Parameters.Add(oblogin);
            con.Open();
            com.ExecuteNonQuery();
            int res = Convert.ToInt32(oblogin.Value);
            con.Close();
            return res;
        }




    }
    }
