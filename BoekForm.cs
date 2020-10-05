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
    public partial class BoekForm : Form
    {
        private bool editable = true;
        public int selectedID = 0;
        public BoekForm()
        {
            InitializeComponent();
        }

        private void laadboek()
        {
            using (BibliotheekEntities ctx = new BibliotheekEntities())
            {
                var query = ctx.Boekens.Where(b => b.Id == selectedID).FirstOrDefault();
                txtTitel.Text = query.Titel;
                foreach (var genre in query.BoekenGenres.Select(s => new { s, display = s.Genre.Genre1 }).ToList())
                {
                    txtGenres.Text += genre.display + Environment.NewLine;
                }

                foreach (var auteur in query.BoekenAuteurs.Select(s => new { s, display = s.Auteur.Achternaam + " " + s.Auteur.Voornaam }).ToList())
                {
                    txtAuteurs.Text += auteur.display + Environment.NewLine;
                }

                numPaginas.Value = query.AantalPaginas.Value;
                dtpPublicatie.Value = query.Publicatie.Value;
                numScore.Value = query.Score.Value;
                cbUitgever.DataSource = ctx.Uitgeverijens.Select(s => new { s, display = s.Naam }).ToList();
                cbUitgever.DisplayMember = "display";
                cbUitgever.ValueMember = "s";
                cbUitgever.SelectedValue = query.Uitgeverijen;
            }
        }

        private void Boek_Load(object sender, EventArgs e)
        {
            locking();
            lblId.Text = selectedID.ToString();
            laadboek();
        }

        private void btnlock_Click(object sender, EventArgs e)
        {
            locking();
        }

        private void locking()
        {
            editable = !editable;

            btnlock.Text = (editable) ? "Lock" : "Unlock";

            txtTitel.ReadOnly = !editable;

            cbUitgever.Enabled = editable;
            numPaginas.Enabled = editable;
            numScore.Enabled = editable;

            dtpPublicatie.Enabled = editable;
            btnUpdate.Enabled = editable;
            btnEditAuteurs.Visible = editable;
            btnEditGenres.Visible = editable;

        }

        private void btnEditGenres_Click(object sender, EventArgs e)
        {
            EditGenreList editGenreList = new EditGenreList();
            editGenreList.boekenLijst.Clear();
            using (BibliotheekEntities ctx = new BibliotheekEntities())
            {
                Boeken boek = ctx.Boekens.Where(s => s.Id == selectedID).FirstOrDefault();
                editGenreList.boekenLijst.Add(boek.Id, boek.Titel);
            }
            editGenreList.ShowDialog();
            laadboek();
        }

        private void btnEditAuteurs_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Auteurs");
            laadboek();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (BibliotheekEntities ctx = new BibliotheekEntities())
            {
                var query = ctx.Boekens.Where(b => b.Id == selectedID).FirstOrDefault();
                query.Titel = txtTitel.Text;
                query.AantalPaginas = (int)numPaginas.Value;
                query.Score = numScore.Value;
                query.Publicatie = dtpPublicatie.Value;
                query.UitgeverId = (cbUitgever.SelectedValue as Uitgeverijen).Id;
                ctx.SaveChanges();
                Close();
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            using (BibliotheekEntities ctx = new BibliotheekEntities())
            {
                Boeken boek = new Boeken();
                boek.Titel = "[unknown]";
                boek.AantalPaginas = 0;
                boek.Score = 0;
                boek.Publicatie = DateTime.Now;
                boek.UitgeverId = ctx.Uitgeverijens.FirstOrDefault().Id;

                ctx.Boekens.Add(boek);
                ctx.SaveChanges();
                selectedID = boek.Id;
            }
            laadboek();
        }
    }
}
