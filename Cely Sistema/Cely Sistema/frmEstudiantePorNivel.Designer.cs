namespace Cely_Sistema
{
    partial class frmEstudiantePorNivel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEstudiantePorNivel));
            this.dgvTabla = new System.Windows.Forms.DataGridView();
            this.gbEstudiantesporNivel = new System.Windows.Forms.GroupBox();
            this.btnAñadirEstudiante = new System.Windows.Forms.Button();
            this.btnCambiardeNivel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabla)).BeginInit();
            this.gbEstudiantesporNivel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvTabla
            // 
            this.dgvTabla.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTabla.Location = new System.Drawing.Point(21, 19);
            this.dgvTabla.Name = "dgvTabla";
            this.dgvTabla.Size = new System.Drawing.Size(507, 350);
            this.dgvTabla.TabIndex = 0;
            // 
            // gbEstudiantesporNivel
            // 
            this.gbEstudiantesporNivel.Controls.Add(this.dgvTabla);
            this.gbEstudiantesporNivel.Location = new System.Drawing.Point(12, 12);
            this.gbEstudiantesporNivel.Name = "gbEstudiantesporNivel";
            this.gbEstudiantesporNivel.Size = new System.Drawing.Size(548, 382);
            this.gbEstudiantesporNivel.TabIndex = 3;
            this.gbEstudiantesporNivel.TabStop = false;
            this.gbEstudiantesporNivel.Text = "Estudiantes Por Nivel";
            // 
            // btnAñadirEstudiante
            // 
            this.btnAñadirEstudiante.Location = new System.Drawing.Point(33, 404);
            this.btnAñadirEstudiante.Name = "btnAñadirEstudiante";
            this.btnAñadirEstudiante.Size = new System.Drawing.Size(157, 23);
            this.btnAñadirEstudiante.TabIndex = 5;
            this.btnAñadirEstudiante.UseVisualStyleBackColor = true;
            this.btnAñadirEstudiante.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCambiardeNivel
            // 
            this.btnCambiardeNivel.Location = new System.Drawing.Point(225, 404);
            this.btnCambiardeNivel.Name = "btnCambiardeNivel";
            this.btnCambiardeNivel.Size = new System.Drawing.Size(154, 23);
            this.btnCambiardeNivel.TabIndex = 6;
            this.btnCambiardeNivel.Text = "Cambiar Estudiante de Nivel";
            this.btnCambiardeNivel.UseVisualStyleBackColor = true;
            this.btnCambiardeNivel.Click += new System.EventHandler(this.btnCambiardeNivel_Click);
            // 
            // frmEstudiantePorNivel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 439);
            this.Controls.Add(this.btnCambiardeNivel);
            this.Controls.Add(this.btnAñadirEstudiante);
            this.Controls.Add(this.gbEstudiantesporNivel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmEstudiantePorNivel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estudiantes en el Nivel";
            this.Load += new System.EventHandler(this.frmEstudiantePorNivel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabla)).EndInit();
            this.gbEstudiantesporNivel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTabla;
        private System.Windows.Forms.GroupBox gbEstudiantesporNivel;
        private System.Windows.Forms.Button btnAñadirEstudiante;
        private System.Windows.Forms.Button btnCambiardeNivel;
    }
}