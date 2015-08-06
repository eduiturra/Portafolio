using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
namespace CapaDatos
{
    public class Conexion
    {


        public static OracleConnection conectar()
        {
            OracleConnection con = new OracleConnection("Data Source=XE;User ID=duoc;Password=123");
            return con;


        }

    }
}
