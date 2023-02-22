using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConBase
{
    public partial class Autodentificacion : Form
    {
        public Autodentificacion()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            
            Estudiante es = new Estudiante();
            DataTable resultado = new DataTable();
            try
            {               
                resultado = es.VerificacionUsuario(txtUsuario.Text, txtClave.Text);
                if(resultado.Rows.Count>0)//verificacion si la datatable trae filas,
                                                //si es asi es porque encontro coincidencia
                    {
                    //Formulario que lista todos los estudiantes
                    verDatos f = new verDatos();
                    f.Show();
                }
                else
                {
                    //Formulario que Registra los estudiantes
                    registroEstudiante f = new registroEstudiante();
                    f.Show();

                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
}
