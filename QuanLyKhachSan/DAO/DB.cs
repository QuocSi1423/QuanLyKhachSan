using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotNetEnv;
using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace QuanLyKhachSan.DAO
{
    internal class DB
    {
        private MySqlConnection conn;
        public MySqlConnection Conn
        {
            get { return conn; }
            set { conn = value; }
        }

        public DB()
        {
            DotNetEnv.Env.Load();
            DotNetEnv.Env.TraversePath().Load();

            string strConn = "Server = "+Env.GetString("SERVER")+"; Database = "+Env.GetString("DATABASE")+"; Port = "+Env.GetString("PORT")+"; User ID = "+Env.GetString("USER_ID")+"; Password =" + Env.GetString("PASSWORD");
            conn = new MySqlConnection(strConn);
        }
        
    }
}
