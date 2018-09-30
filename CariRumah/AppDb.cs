using MySql.Data;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using MySqlX.XDevAPI.Common;
using MySqlX.XDevAPI.CRUD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CariRumah
{
    public static class AppDb
    {
        //public static MySqlConnection conn = new MySqlConnection("server=localhost;user=root;database=test_rl;port=3306;password=;SslMode=none");
        public static MySqlConnection conn = new MySqlConnection("server=40.121.65.38;user=root;database=test_rl;port=3306;password=password;SslMode=none");

        /*public static void open() {
            try
            {
                Console.WriteLine("Open Mysql Connection");
                conn.Open();                
            }
            catch (Exception ex)
            {
                Console.WriteLine("error Connection with message : "+ ex.ToString());
            }
        }

        public static void close() {
            conn.Close();
            Console.WriteLine("Connection Close");
        }*/
    }
}
