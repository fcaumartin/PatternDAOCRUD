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

        string action = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ClientDAO data = new ClientDAO();

            listBox1.DisplayMember = "Nom";
            listBox1.ValueMember = "Id";
            listBox1.DataSource = data.List();
            Width = 254;

        }

        private void button1_Click(object sender, EventArgs e)
        {

            action = "ajouter";
            Width = 514;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                action = "modifier";
                Width = 514;

                int id = (int)listBox1.SelectedValue;

                ClientDAO data = new ClientDAO();

                Client cli = data.Find(id);

                textBox1.Text = cli.Nom;
                textBox2.Text = cli.Prenom;
                textBox3.Text = cli.Ville;


            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (action == "ajouter")
            {
                Client c = new Client();
                c.Nom = textBox1.Text;
                c.Prenom = textBox2.Text;
                c.Ville = textBox3.Text;

                ClientDAO data = new ClientDAO();

                data.Insert(c);

                listBox1.DataSource = data.List();
            }
            if (action == "modifier")
            {
                Client c = new Client();
                c.Nom = textBox1.Text;
                c.Prenom = textBox2.Text;
                c.Ville = textBox3.Text;
                c.Id = (int)listBox1.SelectedValue;

                ClientDAO data = new ClientDAO();

                data.Update(c);

                listBox1.DataSource = data.List();
            }
            if (action == "supprimer")
            {
                Client c = new Client();
                c.Nom = textBox1.Text;
                c.Prenom = textBox2.Text;
                c.Ville = textBox3.Text;
                c.Id = (int)listBox1.SelectedValue;

                ClientDAO data = new ClientDAO();

                data.Delete(c);

                listBox1.DataSource = data.List();
            }
            Width = 254;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                action = "supprimer";
                Width = 514;

                int id = (int)listBox1.SelectedValue;

                ClientDAO data = new ClientDAO();

                Client cli = data.Find(id);

                textBox1.Text = cli.Nom;
                textBox2.Text = cli.Prenom;
                textBox3.Text = cli.Ville;


            }
        }
    }
}
