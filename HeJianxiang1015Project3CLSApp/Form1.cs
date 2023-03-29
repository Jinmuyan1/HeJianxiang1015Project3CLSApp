using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeJianxiang1015Project3CLSApp
{
    public partial class frmCreative : Form
    {
        private Icon m_ready=new Icon(SystemIcons.Information,40,40);

        public frmCreative()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frmCreative_Load(object sender, EventArgs e)
        {
            txtSource.Text = "D:\\Creative\\Source\\";
            txtProcessedFile.Text = "D:\\Creative\\Processed\\";
            txtDest.Text = "D:\\Creative\\Destination\\";
            opsGenerateLog.Checked = true;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(txtSource.Text))
            {
                errMessage.SetError(txtSource, "invalid txtProcessedFile directory");
                txtSource.Focus();
                tabControl1.SelectedTab = tabSource;
                return;
            }
            else
                errMessage.SetError(txtSource, "");
            watchdir.EnableRaisingEvents = true;
            watchdir.Path = txtSource.Text;

            mnuNotify.Icon = m_ready;
            mnuNotify.Visible = true;
            this.ShowInTaskbar = true;
            this.Hide();

            if (!Directory.Exists(txtProcessedFile.Text))
            {
                errMessage.SetError(txtProcessedFile, "invalid txtProcessedFile directory");
                txtProcessedFile.Focus();
                tabControl1.SelectedTab = tabSource;
                return;
            }
            else
                errMessage.SetError(txtProcessedFile, "");

            if (!Directory.Exists(txtDest.Text))
            {
                errMessage.SetError(txtDest, "invalid Destination directory");
                txtDest.Focus();
                tabControl1.SelectedTab = tabDest;
                return;
            }
            else
                errMessage.SetError(txtDest, "");



        }

        private void txtSource_KeyUp(object sender, KeyEventArgs e)
        {
            if (Directory.Exists(txtSource.Text))
            {
                txtSource.BackColor = Color.White;
            }
            else
                txtSource.BackColor = Color.Pink;

           

           
        }

        private void txtProcessedFile_KeyUp(object sender, KeyEventArgs e)
        {
            if (Directory.Exists(txtProcessedFile.Text))
            {
                txtProcessedFile.BackColor = Color.White;
            }
            else
                txtProcessedFile.BackColor = Color.Pink;
        }

        private void txtDest_KeyUp(object sender, KeyEventArgs e)
        {
            if (Directory.Exists(txtDest.Text))
            {
                txtDest.BackColor = Color.White;
            }
            else
                txtDest.BackColor = Color.Pink;
        }

        private void configureApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mnuNotify.Visible= true;
            this.ShowInTaskbar = true;
            this.Show();
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnuNotify_DoubleClick(object sender, EventArgs e)
        {
            mnuNotify.Visible=false;
            this.ShowInTaskbar = true;
            this.Show();

        }
    }
}
