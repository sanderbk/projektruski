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
            Klanten k = new Klanten();
            //k.Voornaam = "Sander";
            //k.Achternaam = "Baak";
            //k.Plaats = "Alkmaar";
            //k.Adres = "Mogool 10";
            con.klanten.Add(k);
             con.SaveChanges();
            KlantenGridView.DataSource = con.klanten.Select(p => new {
                KlantID = p.KlantID,
                ArtsID = p.ArtsID,
                VerzekeringsID = p.VerzekeringsID,
                Voornaam = p.Voornaam,
                Achternaam = p.Achternaam,
                Adres = p.Adres,
                Plaats = p.Plaats
            }).OrderBy(p => p.Achternaam).ToList();

            KlantenGridView.Columns["KlantID"].Visible = false;
            KlantenGridView.Columns["ArtsID"].Visible = false;
            KlantenGridView.Columns["VerzekeringsID"].Visible = false;
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void MaakKlant_Click(object sender, EventArgs e)
        {
            string voornaam = VoornaamtxtKlant.Text;
            string achternaam = VoornaamtxtKlant.Text;
            string verzekeringsid = VoornaamtxtKlant.Text;
            string plaats = VoornaamtxtKlant.Text;
            string adres = VoornaamtxtKlant.Text;
            

            if (verzekeringsid != null && voornaam != null && achternaam != null && plaats != null && adres != null)
            {
                Klanten k = new Klanten();
                k.Voornaam = voornaam;
                k.Achternaam = achternaam;
                k.Adres = adres;
                k.Plaats = plaats;

                con.klanten.Add(k);
                con.SaveChanges();
                KlantenGridView.DataSource = k.ToList();

                voornaam = ""; achternaam = ""; verzekeringsid = ""; plaats = ""; adres = "";
                k.Items.Add(voornaam);
            }

        }

        private void FilterKlant_Click(object sender, EventArgs e)
        {

        }

        private void BewerkKlant_Click(object sender, EventArgs e)
        {

        }

        private void VerwijderKlant_Click(object sender, EventArgs e)
        {

        }

        private void MaakArts_Click(object sender, EventArgs e)
        {

        }

        private void FilterArts_Click(object sender, EventArgs e)
        {

        }

        private void BewerkArts_Click(object sender, EventArgs e)
        {

        }

        private void VerwijderArts_Click(object sender, EventArgs e)
        {

        }

        private void MaakMedicatie_Click(object sender, EventArgs e)
        {

        }

        private void FilterMedicatie_Click(object sender, EventArgs e)
        {

        }

        private void BewerkMedicatie_Click(object sender, EventArgs e)
        {

        }

        private void VerwijderMedicatie_Click(object sender, EventArgs e)
        {

        }
    }
}
