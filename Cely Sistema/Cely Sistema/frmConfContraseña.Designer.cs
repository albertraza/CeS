namespace Cely_Sistema
{
    partial class frmConfContraseña
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConfContraseña));
            this.lblConfirmarContrasena = new System.Windows.Forms.Label();
            this.txtConfirmacionContrasena = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblConfirmarContrasena
            // 
            this.lblConfirmarContrasena.AutoSize = true;
            this.lblConfirmarContrasena.Location = new System.Drawing.Point(12, 27);
            this.lblConfirmarContrasena.Name = "lblConfirmarContrasena";
            this.lblConfirmarContrasena.Size = new System.Drawing.Size(128, 13);
            this.lblConfirmarContrasena.TabIndex = 0;
            this.lblConfirmarContrasena.Text = "Confirmacion Contraseña:";
            // 
            // txtConfirmacionContrasena
            // 
            this.txtConfirmacionContrasena.Location = new System.Drawing.Point(146, 24);
            this.txtConfirmacionContrasena.Name = "txtConfirmacionContrasena";
            this.txtConfirmacionContrasena.PasswordChar = '*';
            this.txtConfirmacionContrasena.Size = new System.Drawing.Size(100, 20);
            this.txtConfirmacionContrasena.TabIndex = 1;
            this.txtConfirmacionContrasena.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtConfirmacionContrasena_KeyPress);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(89, 83);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 2;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // frmConfContraseña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 118);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtConfirmacionContrasena);
            this.Controls.Add(this.lblConfirmarContrasena);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmConfContraseña";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmConfContraseña";
            this.Load += new System.EventHandler(this.frmConfContraseña_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblConfirmarContrasena;
        private System.Windows.Forms.TextBox txtConfirmacionContrasena;
        private System.Windows.Forms.Button btnAceptar;
    }
}