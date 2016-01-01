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
        }
        int c = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            c++;
            progressBar1.Value = c;
            if (c == 100)
            {
                SqlConnection con = new SqlConnection(Cely_Sistema.Properties.Settings.Default.CelyDBConnectionString);
                try
                {
                    con.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    con.Close();
                }
                timer1.Stop();
                this.Hide();
                frmLogin lg = new frmLogin();
                lg.Show();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
