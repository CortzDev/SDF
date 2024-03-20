using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class DBConexion
    {
        protected MySqlConnection _CONEXION = new MySqlConnection();

        protected Boolean Conectar()
        {
            Boolean resultado = false;
            try
            {
                _CONEXION.ConnectionString = "Server=localhost;Port=3306;Database=sistema;Uid=sistema-user;Pwd=root; SSL Mode=None";
                _CONEXION.Open();
                resultado = true;
            }
            catch (Exception)
            {

                resultado = false;
            }

            return resultado;   
        }

        protected void Desconectar()
        {
            try
            {
                if(_CONEXION.State == System.Data.ConnectionState.Open)
                {
                    _CONEXION.Close();
                }
            }
            catch (Exception)
            {

                
            }
        }
    }
}
