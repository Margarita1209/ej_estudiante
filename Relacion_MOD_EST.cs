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
    public partial class Relacion_MOD_EST : Form
    {
        public Relacion_MOD_EST()
        {
            InitializeComponent();
            CargarCombo();
            CargarComboModulo();
        }
        public void CargarCombo()
        {
            Estudiante es = new Estudiante();
            try
            {
                cmbEstudiante.DataSource = es.CargaComboEstudiante();
                cmbEstudiante.ValueMember = "EST_ID";
                cmbEstudiante.DisplayMember = "EST_NOMBRE";

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void CargarComboModulo()
        {
            Estudiante es = new Estudiante();
            try
            {
                cmbModulo.DataSource = es.CargaComboModulo();
                cmbModulo.ValueMember = "MOD_ID";
                cmbModulo.DisplayMember = "MOD_NOMBRE";

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Estudiante es = new Estudiante();
            string MensajeResutado = null;
            try
            {
                MensajeResutado = es.InsertaEstudianteModulo(Convert.ToInt32(cmbModulo.SelectedValue.ToString()), Convert.ToInt32(cmbEstudiante.SelectedValue.ToString()));

                MessageBox.Show(MensajeResutado);

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
