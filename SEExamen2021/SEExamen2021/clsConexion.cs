using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SEExamen2021
{
    class clsConexion
    {
        string cadena = "Data Source=LAPTOP-LP3O0GNC\\SQLEXPRESS; Initial Catalog=SEExamen2021; Integrated Security=True";
        public SqlConnection conectar = new SqlConnection();

        //Constructor de la clase
        public clsConexion()
        {
            conectar.ConnectionString = cadena;

        }

        public void abrir()
        {
            try
            {
                conectar.Open();
                Console.WriteLine("CONEXIÓN ABIERTA");
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR EN ABRIR CONEXION BD" + ex);
            }
        }

        public void cerrar()
        {
            conectar.Close();
        }
    }
}
