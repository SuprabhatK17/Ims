using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Ims
{
    class DBConnection
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        //DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        private string Mycon;
        

        private double dailySaels;
        private int productline;
        private int stockonHand;
        private int criticalItems;

        private static string salt = "key";

        public string MyConnection() //Connection Function
        {
            string Mycon = @"Data Source=DESKTOP-AMS1M7O\SQLEXPRESS;Initial Catalog=InventorySystem;Integrated Security=True "; //Connection String
            return Mycon;// it will return result of the function
        }

        public string GenerateHash(string password)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(password + salt);
            SHA256Managed sha = new SHA256Managed();
            byte[] hash = sha.ComputeHash(bytes);
            return Convert.ToBase64String(hash);

        }

        public LoginStatus CheckLogin(string email,string pw)
        {
            con.ConnectionString = MyConnection();
            con.Open();
            cmd = new SqlCommand("SELECT * FROM tblUser WHERE email = @email AND password = @password",con);
            var hash = GenerateHash(pw);
            cmd.Parameters.AddWithValue("@email",email);
            cmd.Parameters.AddWithValue("@password", hash);
            using (var read = cmd.ExecuteReader())
            {
                if (read.Read())
                {
                    if(!string.IsNullOrEmpty(read["code"] + string.Empty))
                    {
                        return LoginStatus.NeedVerify;
                    }
                    else if (!string.IsNullOrEmpty(read["email"] + string.Empty))
                    {
                        return LoginStatus.OK;
                    }
                    else
                    {
                        return LoginStatus.Incorrect;
                    }
                }
            }

            return LoginStatus.NotExist;
        }


        public bool SignUp(string email, string pw)
        {
            LoginStatus loginStatus = CheckLogin(email, pw);
            if (loginStatus == LoginStatus.NotExist)
            {
                con.ConnectionString = MyConnection();
                con.Open();
                var hash = GenerateHash(pw);
                var code = new Random().Next(999999);
                var cmd = new SqlCommand("INSERT INTO tblUser(username ,name,role.email,password,code) VALUES (@username,name,role,@email,@password,@code)  ", con);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@password", code);
                cmd.Parameters.AddWithValue("@code", code);
                cmd.Parameters.AddWithValue("@username", null);
                cmd.Parameters.AddWithValue("@name", null);
                cmd.Parameters.AddWithValue("@role", "CASHIER");
                var mailhelp = new EmailRegister();
                mailhelp.Send(code + string.Empty, email);
                return cmd.ExecuteNonQuery() > 0;


            }
            
            return false;
        }


        public bool VerifyCode(string email,string pw,string code)
        {
            LoginStatus loginStatus = CheckLogin(email, pw);
            if (loginStatus != LoginStatus.NeedVerify) return false;
            con.ConnectionString = MyConnection();
            con.Open();
            cmd = new SqlCommand("SELECT code FROM tblUser WHERE email = @email", con);
            cmd.Parameters.AddWithValue("@email", email);
            if(cmd.ExecuteScalar().ToString() == code)
            {
                var cmdUpdate = new SqlCommand("UPDATE tblUser SET code = NULL WHERE email = @email",con);
                cmdUpdate.Parameters.AddWithValue("email", email);
                return cmdUpdate.ExecuteNonQuery() > 0;
            }
            
            return false;
        }
        

        public double DailySales()
        {

            string sdate = DateTime.Now.ToShortTimeString();
            //con = new SqlConnection();
            //con.ConnectionString = Mycon;
            con.ConnectionString = MyConnection();
            con.Open();
            cmd = new SqlCommand("SELECT isnull (SUM(total),0) as total from tblCart WHERE sdate between '" + sdate  +"' and '" + sdate +"' and status like 'sold' " , con);
            dailySaels = double.Parse(cmd.ExecuteScalar().ToString());
            con.Close();
            return dailySaels;
        }

        public double ProductLine()
        {

            string sdate = DateTime.Now.ToShortTimeString();
            //con = new SqlConnection();
            //con.ConnectionString = Mycon;
            con.ConnectionString = MyConnection();
            con.Open();
            cmd = new SqlCommand("SELECT COUNT(*) from tblProduct  ", con);
            productline = int.Parse(cmd.ExecuteScalar().ToString());
            con.Close();
            return productline;
        }

        public double StockOnHand()
        {

            //string sdate = DateTime.Now.ToShortTimeString();
            //con = new SqlConnection();
            //con.ConnectionString = Mycon;
            con.ConnectionString = MyConnection();
            con.Open();
            cmd = new SqlCommand("SELECT isnull (sum(qty,0) as qty from tblProduct  ", con);
            stockonHand = int.Parse(cmd.ExecuteScalar().ToString());
            con.Close();
            return stockonHand;
        }

        public double CrititcalItems()
        {

            //string sdate = DateTime.Now.ToShortTimeString();
            //con = new SqlConnection();
            //con.ConnectionString = Mycon;
            con.ConnectionString = MyConnection();
            con.Open();
            cmd = new SqlCommand("SELECT COUNT(*) from vwCriticalItems  ", con);
            criticalItems = int.Parse(cmd.ExecuteScalar().ToString());
            con.Close();
            return criticalItems;
        }







        public double GetVal()
        {
            double vat = 0;
            con.ConnectionString = MyConnection();
            con.Open();
            cmd = new SqlCommand("SELECT * FROM tblVat ", con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                vat = Double.Parse(dr["vat"].ToString());
            }
            dr.Close();
            con.Close();
            return vat;

        }

        public string GetPassword(string user)
        {
            string password = "";
            con.ConnectionString = MyConnection();
            con.Open();
            cmd = new SqlCommand("SELECT * FROM tblUser WHERE username = @username ", con);
            cmd.Parameters.AddWithValue("@username", user);
            dr = cmd.ExecuteReader();

            dr.Read();
            if(dr.HasRows)
            {
                password = dr["password"].ToString();
            }
            dr.Close();
            con.Close();
            return password;

        }

    }
}
