using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDF.GUI
{
    public partial class Login : Form
    {
        private Boolean _Autorizado = false;

        //String _Usuario = "Jav";
        //String _Clave = "123";

        public Login()
        {
            InitializeComponent();
        }

        public bool Autorizado { get => _Autorizado; set => _Autorizado = value; }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            DataLayer.DBOperacion oOperacion= new DataLayer.DBOperacion();
            String query = @"SELECT 
                            IDUsuario, Usuario, 
                            IDEmpleado, IDRol
                            FROM usuarios
                            WHERE Usuario ='" + txtUsu.Text + @"' 
                            AND Clave = MD5('" + txtPass.Text + @"');";
            dt = oOperacion.consultar(query);

            if(dt.Rows.Count == 1)
            {
                _Autorizado=true;
                Close();
            }
            else
            {
                MessageBox.Show("NO HAY CHELE");
            }


        }
    }
}
