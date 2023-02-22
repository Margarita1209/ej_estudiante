
namespace ConBase
{
    partial class ListarEstudiante
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblEs = new System.Windows.Forms.Label();
            this.cmbEstudiante = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.gdvEstudiante = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gdvEstudiante)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEs
            // 
            this.lblEs.AutoSize = true;
            this.lblEs.Location = new System.Drawing.Point(67, 70);
            this.lblEs.Name = "lblEs";
            this.lblEs.Size = new System.Drawing.Size(79, 17);
            this.lblEs.TabIndex = 0;
            this.lblEs.Text = "Estudiante:";
            // 
            // cmbEstudiante
            // 
            this.cmbEstudiante.FormattingEnabled = true;
            this.cmbEstudiante.Location = new System.Drawing.Point(177, 67);
            this.cmbEstudiante.Name = "cmbEstudiante";
            this.cmbEstudiante.Size = new System.Drawing.Size(243, 24);
            this.cmbEstudiante.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(465, 70);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Ver Datos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // gdvEstudiante
            // 
            this.gdvEstudiante.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdvEstudiante.Location = new System.Drawing.Point(149, 178);
            this.gdvEstudiante.Name = "gdvEstudiante";
            this.gdvEstudiante.RowHeadersWidth = 51;
            this.gdvEstudiante.RowTemplate.Height = 24;
            this.gdvEstudiante.Size = new System.Drawing.Size(548, 150);
            this.gdvEstudiante.TabIndex = 3;
            // 
            // ListarEstudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gdvEstudiante);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbEstudiante);
            this.Controls.Add(this.lblEs);
            this.Name = "ListarEstudiante";
            this.Text = "ListarEstudiante";
            ((System.ComponentModel.ISupportInitialize)(this.gdvEstudiante)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEs;
        private System.Windows.Forms.ComboBox cmbEstudiante;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView gdvEstudiante;
    }
}