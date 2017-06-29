using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
namespace refeicoes
{
    public partial class Form1 : Form
    {
        registossaidasDataSet ds;
        registossaidasDataSet.reservasRow r;
        public Form1()
        {
            InitializeComponent();
         


        }

      

        private void utentesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.utentesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.registossaidasDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'registossaidasDataSet.reservas' table. You can move, or remove it, as needed.
            this.reservasTableAdapter.Fill(this.registossaidasDataSet.reservas);
            // TODO: This line of code loads data into the 'registossaidasDataSet.reservas' table. You can move, or remove it, as needed.

            this.utentesTableAdapter.Fill(this.registossaidasDataSet.utentes);

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog fdlg = new OpenFileDialog();
            fdlg.Title = "Nova Foto";
            fdlg.Filter = "Images (all images)|*.jpg; *.png;*.bmp;*.gif";

            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                pic.Image = Image.FromFile(fdlg.FileName);
            }
        }

      
    }
}
