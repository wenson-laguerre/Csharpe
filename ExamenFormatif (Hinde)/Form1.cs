using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenFormatif__Hinde_
{
    public partial class Form1 : Form
    {
        public List<Donneur>Donneur{ get; set; }
        public Form1()
        {
            Donneur = GetDonneur();
            InitializeComponent();
        }
        private List<Donneur> GetDonneur()
        {
            var list = new List<Donneur>();
            list.Add(new Donneur()
            {
                Prenom = "TestPrenom",
                Nom = "TestNom",
                numCarteMaladie = "123-456-789",
                groupSanguine = "A+"

            });
            return list;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var donneur = this.Donneur;
            dataGridView1.DataSource = donneur;
        }
    }
}
