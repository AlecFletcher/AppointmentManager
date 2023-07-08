﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Windows.Forms;

namespace AlecFletcherC969
{
    public class DBConnection
    {
        public static MySqlConnection conn { get; set; }

        public static void OpenConnection()
        {
            try
            {
                string constr = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;
                conn = new MySqlConnection(constr);

                //Open Connection
                conn.Open();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void CloseConnection()
        {
            try
            {
                if (conn != null)
                {
                    conn.Close();
                }
                conn = null;
            }
            catch(MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
