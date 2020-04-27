using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Dao
{
    public class ConexionDB
    {


        private static ConexionDB objConexionDB = null;
        private SqlConnection con;

        private ConexionDB()
        {
            //Data Source = myServerAddress; Initial Catalog = myDataBase; Integrated Security = SSPI;
            con = new SqlConnection("Data Source=DESKTOP-QDUO02P;Initial Catalog=ventas;Integrated Security = SSPI");
        }

        public static ConexionDB saberEstado()
        {
            if (objConexionDB == null)
            {
                objConexionDB = new ConexionDB();

            }
            return objConexionDB;
        }

        public SqlConnection getCon()
        {
            return con;
        }

        public void closeDB()
        {
            objConexionDB = null;
        }
    }
}
