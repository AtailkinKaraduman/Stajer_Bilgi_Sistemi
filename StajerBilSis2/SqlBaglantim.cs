using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Reflection;

namespace StajerBilSis2
{
    public static class SqlBaglantim
    {
        public static SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection(@"Data Source=DESKTOP-I33JM8T;Initial Catalog=StajyerBilgi;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
        public static string GetAppFolder()
        {
            return new FileInfo(Assembly.GetExecutingAssembly().Location).Directory.FullName;
        }
    }
}
