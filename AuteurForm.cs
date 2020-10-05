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
    public partial class AuteurForm : Form
    {
        private bool editable = true;
        public int selectedID = 0;

        public AuteurForm()
        {
            InitializeComponent();
        }

        private void nieuweAuteur_Load(object sender, EventArgs e)
        {
            using (BibliotheekEntities ctx = new BibliotheekEntities())
            {
                var query = ctx.Auteurs.Where(s => s.Id == selectedID).FirstOrDefault();
                lblId.Text = query.Id.ToString();
                txtVoornaam.Text = query.Voornaam;
                txtAchternaam.Text = query.Achternaam;

            }
            locking();
        }
        private void locking()
        {
            editable = !editable;

            btnlock.Text = (editable) ? "Lock" : "Unlock";

            txtVoornaam.ReadOnly = !editable;
            txtAchternaam.ReadOnly = !editable;

            btnUpdate.Enabled = editable;

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (BibliotheekEntities ctx = new BibliotheekEntities())
            {
                ctx.Auteurs.Where(s => s.Id == selectedID).FirstOrDefault().Achternaam = txtAchternaam.Text;
                ctx.Auteurs.Where(s => s.Id == selectedID).FirstOrDefault().Voornaam = txtVoornaam.Text;
                ctx.SaveChanges();
                Close();
            }
        }

        private void btnlock_Click(object sender, EventArgs e)
        {
            locking();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            using (BibliotheekEntities ctx = new BibliotheekEntities())
            {
                Auteur auteur = new Auteur();
                ctx.Auteurs.Add(auteur);
                ctx.SaveChanges();
                selectedID = auteur.Id;
            }
            nieuweAuteur_Load(sender, e);
        }
    }
}
