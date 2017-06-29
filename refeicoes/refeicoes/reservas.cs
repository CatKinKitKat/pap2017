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
    public partial class reservas : Form
    {
        int _filtro=0;
        public int filtro {
            get { return _filtro; }
            set { _filtro = value; }
        }
        public reservas()
        {
            InitializeComponent();
        }

        private void reservasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.reservasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.registossaidasDataSet);

        }

        private void reservas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'registossaidasDataSet.reservas' table. You can move, or remove it, as needed.
            this.reservasTableAdapter.Fill(this.registossaidasDataSet.reservas);
            this.reservasBindingSource.Filter = "rfid = " + _filtro;
            this.reservasBindingSource.MoveLast();
        }

        private void rfidLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
