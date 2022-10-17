using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppModelo.Model.Infra.Database
{
    public static class Database
    {
        public static string MySqlConection()
        {
            var conn = "server=mysql.wwonline.com.br;database=wwonline16;uid=wwonline16;password=aluno22senai;";
            return conn;
        }
    }
}
