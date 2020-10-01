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
        public bool editable = false;
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
                txtUitgever.Text = query.Uitgeverijen.Naam;
            }
        }

        private void Boek_Load(object sender, EventArgs e)
        {
            txtTitel.ReadOnly = !editable;
            numPaginas.ReadOnly = !editable;
            numScore.ReadOnly = !editable;
            txtUitgever.ReadOnly = !editable;

            dtpPublicatie.Enabled = editable;
            btnUpdate.Enabled = editable;
            btnEditAuteurs.Visible = editable;
            btnEditGenres.Visible = editable;

            lblId.Text = selectedID.ToString();
            laadboek();
        }
    }
}
