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
    public partial class Ingresa_Modulo : Form
    {
        public Ingresa_Modulo()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int Activo = 0;
            string MensajeResutado = null;
            try
            {
                if (chbActivo.Checked)
                {
                    Activo = 1;
                }
                else
                {
                    Activo = 0;
                }
                if (String.IsNullOrEmpty(txtNombre.Text))
                {
                    MessageBox.Show("Debe ingresar el nombre");
                    return;
                }
                Estudiante es = new Estudiante();
                MensajeResutado = es.InsertaModulo(txtNombre.Text,txtCodigo.Text, Activo);

                MessageBox.Show(MensajeResutado);

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        private void chbActivo_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
