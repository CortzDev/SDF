using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class DBOperacion : DBConexion
    {
        public DataTable consultar(String pConsulta)
        {
			DataTable Resultado = new DataTable();	
			MySqlCommand Comando = new MySqlCommand();
			MySqlDataAdapter Adaptador = new MySqlDataAdapter();

			try
			{
				if (base.Conectar())
				{
					Comando.Connection = base._CONEXION;
					Comando.CommandType = System.Data.CommandType.Text;
					Comando.CommandText = pConsulta;
					Adaptador.SelectCommand = Comando;

					Adaptador.Fill(Resultado);

					base.Desconectar();

				}
			}
			catch (Exception)
			{
				Resultado = new DataTable();				
			}

			return Resultado;
        }
    }
}
