using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace refeicoes
{
    public partial class MDIParent1 : Form
    {
        private int childFormNumber = 0;

        public MDIParent1()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            start childForm = new start();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            UTENTES childForm = new UTENTES();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            // childForm.WindowState = FormWindowState.Maximized;
            childForm.Show();
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e) { }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e) { }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reservas childForm = new reservas();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            //childForm.WindowState = FormWindowState.Maximized;
            childForm.Show();
        }

        private void toolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e) { }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            about childForm = new about();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }
    }
}
