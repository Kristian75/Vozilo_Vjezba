using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vozilo_Vjezba
{
    public partial class Form1 : Form
    {
        private List<Vozilo> vozila = new List<Vozilo>();

        public Form1()
        {
            InitializeComponent();
            cmbVrsta.Items.AddRange(new string[] { "Avion", "Automobil", "Brod" });
        }

        private void btnUnos_Click(object sender, EventArgs e)
        {
            string marka = txtMarka.Text;
            string model = txtModel.Text;
            string vrsta = cmbVrsta.SelectedItem.ToString();

            vozila.Add(new Vozilo { Marka = marka, Model = model, Vrsta = vrsta });
            txtOutput.Text += $"Marka: {marka}, Model: {model}, Vrsta: {vrsta}\r\n";

            txtMarka.Clear();
            txtModel.Clear();
            cmbVrsta.SelectedIndex = -1;
        }

        private void btnIspis_Click(object sender, EventArgs e)
        {
            txtOutput.Clear();
            foreach (var vozilo in vozila)
            {
                txtOutput.Text += $"Marka: {vozilo.Marka}, Model: {vozilo.Model}, Vrsta: {vozilo.Vrsta}, Vozi po: {vozilo.VoziPo}\r\n";
            }
        }

        private void btnObrada_Click(object sender, EventArgs e)
        {
            foreach (var vozilo in vozila)
            {
                switch (vozilo.Vrsta)
                {
                    case "Avion":
                        vozilo.VoziPo = "Zrak";
                        break;
                    case "Automobil":
                        vozilo.VoziPo = "Cesta";
                        break;
                    case "Brod":
                        vozilo.VoziPo = "Voda";
                        break;
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

    }
}
