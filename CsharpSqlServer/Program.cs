using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpSqlServer
{
    class Program
    {
        static void Main(string[] args)
        {
            //Syntax Of Sql Server Connection String
            //for windows auth.
            //@"Data Source=(MachineName)\(InstanceName);Initial Catalog=(DBName);Integrated Security=True;"
            //for Sql Server auth.
            //@"Data Source=(MachineName)\(InstanceName);Initial Catalog=(DBName);User ID=(UserName);Password=(Password);"
            SqlConnection sqlCon = new SqlConnection(@"Data Source=(local)\sqle2012;Initial Catalog=DotnetMob;Integrated Security=True");
            SqlDataAdapter sqlda = new SqlDataAdapter("Select * from product", sqlCon);
            DataTable dtbl = new DataTable();
            sqlda.Fill(dtbl);
            foreach (DataRow row in dtbl.Rows)
            {
                Console.WriteLine(row["ProductName"]);
            }
            Console.ReadKey();
        }
    }
}
