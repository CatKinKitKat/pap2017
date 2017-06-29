using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Text.RegularExpressions;

using refeicoes.registossaidasDataSetTableAdapters;

namespace refeicoes
{
    public partial class start : Form
    {
        registossaidasDataSet.reservasDataTable tab;
        registossaidasDataSet.reservasRow r;
        registossaidasDataSetTableAdapters.reservasTableAdapter adpt;

        Regex PAD = new Regex(@"\d{3,4}");
        string comPORT;
        string receivedData = "";

        public start()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e) { }

        private void start_Load(object sender, EventArgs e)
        {
            adpt = new reservasTableAdapter();
            tab = adpt.GetData();
            string[] ports = SerialPort.GetPortNames();
            Timer1.Enabled = false;
            comPORT = "";
            // Display each port name to the console.
            foreach (string port in ports)
            {
                comPort_ComboBox.Items.Add(port);
            }
        }

        private void comPort_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comPort_ComboBox.SelectedItem != null)
            {
                comPORT = comPort_ComboBox.SelectedItem.ToString();
            }
        }

        private void connect_BTN_Click(object sender, EventArgs e)
        {
            if ((connect_BTN.Text == "Connect"))
            {
                if ((!string.IsNullOrEmpty(comPORT)))
                {
                    SerialPort1.Close();
                    SerialPort1.PortName = comPORT;
                    SerialPort1.BaudRate = 9600;
                    SerialPort1.DataBits = 8;
                    SerialPort1.Parity = Parity.None;
                    SerialPort1.StopBits = StopBits.One;
                    SerialPort1.Handshake = Handshake.None;
                    SerialPort1.Encoding = System.Text.Encoding.Default;
                    SerialPort1.ReadTimeout = 10000;

                    SerialPort1.Open();
                    connect_BTN.Text = "Dis-connect";
                    Timer1.Enabled = true;
                    Timer_LBL.Text = "Timer: ON";
                }
                else
                {
                    MessageBox.Show("Select a COM port first");
                }
            }
            else
            {
                SerialPort1.Close();
                connect_BTN.Text = "Connect";
                Timer1.Enabled = false;
                Timer_LBL.Text = "Timer: OFF";
            }
        }

        private void clear_BTN_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Text = "";
        }

        public string ReceiveSerialData()
        {
            string Incoming = null;
            try
            {
                Incoming = SerialPort1.ReadExisting();
                if (Incoming == null)
                {
                    return "nothing" + "\r\n";
                }
                else
                {
                    return Incoming;
                }
            }
            catch (TimeoutException ex)
            {
                return "Error: Serial Port read timed out:" + ex.Message;
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            int presente;
            receivedData = ReceiveSerialData();
            this.richTextBox1.Text += receivedData;
            if (!String.IsNullOrEmpty(receivedData))
            {
                Match M = PAD.Match(receivedData);
                if (M.Success)
                {
                    if (int.TryParse(M.Value.ToString(), out presente))
                    {
                        try
                        {
                            if (utilidades.CUSTOREFEICAO <= saldo(presente))
                            {
                                r = (registossaidasDataSet.reservasRow)tab.NewRow();
                                r.rfid = presente;
                                r.datarefeicao = DateTime.Now;
                                r.dataregisto = DateTime.Now;

                                r.tipo = "Almoço";
                                tab.Rows.Add(r);
                                adpt.Update(tab);
                                adpt.Fill(tab);

                                if (estaaberta("reservas"))
                                    Application.OpenForms["reservas"].Close();
                                reservas childForm = new reservas();
                                ((reservas)childForm).filtro = presente;
                                childForm.MdiParent = Application.OpenForms["MDIParent1"];

                                childForm.Show();
                            }
                            else
                            {
                                MessageBox.Show("Saldo Excedido");
                            }
                        }
                        catch (Exception erro)
                        {
                            MessageBox.Show(erro.Message);
                        }
                    } //tryparse
                } //sucess
            }
        }

        public float saldo(int utente)
        {
            float resp = -1;
            registossaidasDataSet.utentesDataTable ut =
                new registossaidasDataSet.utentesDataTable();
            registossaidasDataSetTableAdapters.utentesTableAdapter adpt = new utentesTableAdapter();
            ut = adpt.GetUtenteByid(utente);
            if (ut.Rows.Count > 0)
                resp = float.Parse(ut.Rows[0]["saldo"].ToString());
            return resp;
        }

        public bool estaaberta(string frm)
        {
            FormCollection fc = Application.OpenForms;

            foreach (Form f in fc)
            {
                if (f.Name == frm)
                    return true;
            }
            return false;
        }
    } //CLASS
} //namespace
