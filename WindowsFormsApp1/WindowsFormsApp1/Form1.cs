using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
            database con = new database();

        private void Form1_Load(object sender, EventArgs e)
        {
            getDataKlant();
            getDataArts();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();

            form2.Show();
            
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var query = from Klanten in con.klanten
                        where Klanten.Voornaam.Contains(textBox1.Text)
                        select Klanten;

            dataGridView1.DataSource = query.ToList();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void getDataArts()
        {
            dataGridView2.DataSource = con.arts.Select(a => new {
                ArtsID = a.ArtsID,
                Voornaam = a.Voornaam,
                Achternaam = a.Achternaam,
                Einddatum = a.Einddatum,
                Klanten = a.Klanten,
            }).OrderBy(p => p.Achternaam).ToList();
        }

        private void getDataKlant()
        {
            // Klanten k = new Klanten();
            // k.Naam = "Sander Baak";
            // k.Plaats = "Alkmaar";
            // k.Adres = "Mogool 10";
            // con.klanten.Add(k);
            // con.SaveChanges();
            dataGridView1.DataSource = con.klanten.Select(p => new {
                KlantID = p.KlantID,
                VerzekeringsID = p.VerzekeringsID,
                Voornaam = p.Voornaam,
                Achternaam = p.Achternaam,
                Adres = p.Adres,
                Plaats = p.Plaats
            }).OrderBy(p => p.Achternaam).ToList();

            dataGridView1.Columns["KlantID"].Visible = false;

            dataGridView1.Columns["VerzekeringsID"].Visible = false;
        }

        private void txtSearchArts_TextChanged(object sender, EventArgs e)
        {
            var query = from Arts in con.arts
                        where Arts.Voornaam.Contains(txtSearchArts.Text)
                        select Arts;

            dataGridView2.DataSource = query.ToList();
        }
    }
}
