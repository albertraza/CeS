using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Cely_Sistema.Properties;

namespace Cely_Sistema
{
    public partial class frmSplash : Form
    {
        public frmSplash()
        {
            InitializeComponent();
        }

        private void frmSplash_Load(object sender, EventArgs e)
        {
            timer1.Start();
            SqlConnection con = new SqlConnection(Cely_Sistema.Properties.Settings.Default.CelyDBConnectionString);
            try
            {
                con.Open(); c +=20;
                progressBar1.Value = c;
                GananciasDB.updateDescuentos();
                c += 20;
                progressBar1.Value = c;
                GananciasDB.updateTotalGanancias();
                c += 30;
                GananciasDB.fixMathIssue();
                c += 30;
                progressBar1.Value = c;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " La aplicacion se cerrara", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            finally
            {
                con.Close();
            }
        }
        int c = 0;
        int a = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            a++;
            if(c == 100)
            {
                if (a == 7)
                {
                    frmLogin lg = new frmLogin();
                    lg.Show();
                    this.Hide();
                }
            }
            else
            {

            }
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
