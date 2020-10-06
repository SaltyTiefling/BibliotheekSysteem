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
                        break;
                    case "Uitgeverijen":
                        lbxVieuw.DataSource = ctx.Uitgeverijens.Select(s => new { id = s.Id, Naam = s.Naam }).ToList();
                        break;
                    case "Genre":
                        lbxVieuw.DataSource = ctx.Genres.Select(s => new { id = s.Id, Naam = s.Genre1 }).ToList();
                        break;
                    case "BoekenAuteur":
                        lbxVieuw.DataSource = ctx.BoekenAuteurs.Select(s => new { id = s.Id, Naam = s.Boeken.Titel + " => " + s.Auteur.Voornaam + " " + s.Auteur.Achternaam }).ToList();
                        break;
                    case "BoekenGenre":
                        lbxVieuw.DataSource = ctx.BoekenGenres.Select(s => new { id = s.Id, Naam = s.Boeken.Titel + " => " + s.Genre.Genre1 }).ToList();
                        break;
                    default:
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
            using (BibliotheekEntities ctx = new BibliotheekEntities())
            {
                switch (cbxTables.SelectedItem)
                {
                    case "Auteur":
                        AuteurForm nieuweAuteur = new AuteurForm();
                        nieuweAuteur.selectedID = (int)lbxVieuw.SelectedValue;
                        nieuweAuteur.ShowDialog();
                        break;

                    case "Uitgeverijen":
                        UitgeverijenForm uitgeverijenForm = new UitgeverijenForm();
                        uitgeverijenForm.selectedID = (int)lbxVieuw.SelectedValue;
                        uitgeverijenForm.ShowDialog();
                        break;

                    case "Genre":
                        GenreForm genreForm = new GenreForm();
                        genreForm.selectedID = (int)lbxVieuw.SelectedValue;
                        genreForm.ShowDialog();
                        break;

                    case "BoekenAuteur":
                        EditAuteurList ea = new EditAuteurList();
                        foreach (var item in ctx.Boekens.Select(s => s))
                        {
                            ea.boekenLijst.Add(item.Id, item.Titel);
                        }
                        ea.ShowDialog();
                        break;

                    case "BoekenGenre":
                        EditGenreList eg = new EditGenreList();
                        foreach (var item in ctx.Boekens.Select(s => s))
                        {
                            eg.boekenLijst.Add(item.Id, item.Titel);
                        }
                        eg.ShowDialog();
                        break;

                    default:
                        BoekForm boekform = new BoekForm();
                        boekform.selectedID = (int)lbxVieuw.SelectedValue;
                        boekform.ShowDialog();
                        break;

                }
                LaadList();
            }

        }
    }
}
