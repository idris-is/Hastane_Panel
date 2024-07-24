using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 
using Npgsql;

namespace Hastane_Panel
{
    internal class SqlBaglantisi
    {
        public NpgsqlConnection baglanti() 
        {
            NpgsqlConnection baglan = new NpgsqlConnection("server = localHost; port = 5432; Database = HastaneProje ; user ID = postgres ; password = 123456");
            baglan.Open();
            return baglan;
        }
    }
}
