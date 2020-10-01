using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotheekSysteem
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void LaadList()
        {
            using (BibliotheekEntities ctx = new BibliotheekEntities())
            {
                switch (cbxTables.SelectedItem)
                {
                    case "Auteur":
                        lbxVieuw.DataSource = ctx.Auteurs.Select(s => new { id = s.Id, Naam = s.Voornaam + " " + s.Achternaam }).ToList();
                        btnview.Enabled = false;
                        break;
                    case "Uitgeverijen":
                        lbxVieuw.DataSource = ctx.Uitgeverijens.Select(s => new { id = s.Id, Naam = s.Naam }).ToList();
                        btnview.Enabled = false;
                        break;
                    case "Genre":
                        lbxVieuw.DataSource = ctx.Genres.Select(s => new { id = s.Id, Naam = s.Genre1 }).ToList();
                        btnview.Enabled = false;
                        btnview.Enabled = false;
                        break;
                    case "BoekenAuteur":
                        btnview.Enabled = false;
                        lbxVieuw.DataSource = ctx.BoekenAuteurs.Select(s => new { id = s.Id, Naam = s.Boeken.Titel + " => " + s.Auteur.Voornaam + " " + s.Auteur.Achternaam }).ToList();
                        break;
                    case "BoekenGenre":
                        btnview.Enabled = false;
                        lbxVieuw.DataSource = ctx.BoekenGenres.Select(s => new { id = s.Id, Naam = s.Boeken.Titel + " => " + s.Genre.Genre1 }).ToList();
                        break;
                    default:
                        btnview.Enabled = true;
                        lbxVieuw.DataSource = ctx.Boekens.Select(s => new { id = s.Id, Naam = s.Titel }).ToList();
                        break;
                }

                lbxVieuw.DisplayMember = "Naam";
                lbxVieuw.ValueMember = "id";
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            cbxTables.Items.Add("Boeken");
            cbxTables.Items.Add("Auteur");
            cbxTables.Items.Add("Uitgeverijen");
            cbxTables.Items.Add("Genre");
            cbxTables.Items.Add("BoekenAuteur");
            cbxTables.Items.Add("BoekenGenre");
            cbxTables.SelectedIndex = 0;
            lbxVieuw_SelectedIndexChanged(sender, e);

        }

        private void cbxTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            LaadList();
        }

        private void lbxVieuw_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblId.Text = lbxVieuw.SelectedValue.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (cbxTables.SelectedItem)
            {
                case "Auteur":

                    break;
                case "Uitgeverijen":

                    break;
                case "Genre":

                    break;
                case "BoekenAuteur":

                    break;
                case "BoekenGenre":

                    break;
                default:
                    BoekForm boekform = new BoekForm();
                    boekform.selectedID = (int)lbxVieuw.SelectedValue;
                    boekform.ShowDialog();
                    break;
            }

        }
    }
}
