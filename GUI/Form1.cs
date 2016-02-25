using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Client c = new Client();
            c.Nom = "Toto";
            c.Prenom = "Titi";
            c.Ville = "Amiens";

            ClientDAO database = new ClientDAO();

            database.Insert(c);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClientDAO data = new ClientDAO();

            listBox1.DisplayMember = "Nom";
            listBox1.DataSource = data.List();

            dataGridView1.DataSource = data.List();
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }
    


    }
}
