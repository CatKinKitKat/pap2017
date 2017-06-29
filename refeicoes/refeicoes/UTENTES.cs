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
    public partial class UTENTES : Form
    {
        public UTENTES()
        {
            InitializeComponent();
        }

        private void utentesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.utentesBindingSource.EndEdit();
           

        }

        private void UTENTES_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'registossaidasDataSet.reservas' table. You can move, or remove it, as needed.
            this.reservasTableAdapter.Fill(this.registossaidasDataSet.reservas);
            // TODO: This line of code loads data into the 'registossaidasDataSet.utentes' table. You can move, or remove it, as needed.
            this.utentesTableAdapter.Fill(this.registossaidasDataSet.utentes);
            // TODO: This line of code loads data into the 'registossaidasDataSet.utentes' table. You can move, or remove it, as needed.
            this.utentesTableAdapter.Fill(this.registossaidasDataSet.utentes);
            // TODO: This line of code loads data into the 'registossaidasDataSet.utentes' table. You can move, or remove it, as needed.
            this.utentesTableAdapter.Fill(this.registossaidasDataSet.utentes);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog fdlg = new OpenFileDialog();
            fdlg.Title = "Nova Foto";
            fdlg.Filter = "Images (all images)|*.jpg; *.png;*.bmp;*.gif";

            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                pic.Image = Image.FromFile(fdlg.FileName);
            }
        }

        private void utentesBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.utentesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.registossaidasDataSet);

        }
    }
}
