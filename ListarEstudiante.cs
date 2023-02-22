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
    public partial class ListarEstudiante : Form
    {
        public ListarEstudiante()
        {
            InitializeComponent();
            CargaCombo();
        }
        public void CargaCombo()
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

        private void button1_Click(object sender, EventArgs e)
        {
            Estudiante es = new Estudiante();
            try
            {
                gdvEstudiante.DataSource = es.CargaGrillaEstudiante(cmbEstudiante.SelectedValue.ToString());

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
