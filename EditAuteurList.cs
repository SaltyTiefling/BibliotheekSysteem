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
    public partial class EditAuteurList : Form
    {
        public Dictionary<int, string> boekenLijst = new Dictionary<int, string>();
        public EditAuteurList()
        {
            InitializeComponent();
        }

        private void EditAuteurList_Load(object sender, EventArgs e)
        {
            cbBoek.DisplayMember = "Value";
            cbBoek.ValueMember = "Key";
            cbBoek.DataSource = new BindingSource(boekenLijst, null);
            cbBoek.SelectedIndex = 0;

            if (boekenLijst.Count <= 1)
            {
                cbBoek.Enabled = false;
            }

            LaadLists();
        }
        private void LaadLists()
        {
            using (BibliotheekEntities ctx = new BibliotheekEntities())
            {
                lbxCurrentAuteurs.DataSource =
                    ctx.BoekenAuteurs.Where(s => s.BoekenId == (int)cbBoek.SelectedValue).Select(s => new { id = s.Id, display = s.Auteur.Voornaam + " " + s.Auteur.Achternaam })
                    .ToList();
                lbxCurrentAuteurs.DisplayMember = "display";
                lbxCurrentAuteurs.ValueMember = "id";

                lbxAvailableAuteurs.DataSource = ctx.Auteurs.Where(g => !(ctx.BoekenAuteurs.Where(s => s.BoekenId == (int)cbBoek.SelectedValue).Select(s => s.Auteur.Voornaam + " " + s.Auteur.Achternaam)
                    .ToList().Contains(g.Voornaam + " " + g.Achternaam))).Select(s => new { s, display = s.Voornaam + " " + s.Achternaam }).ToList();
                lbxAvailableAuteurs.DisplayMember = "display";
                lbxAvailableAuteurs.ValueMember = "s";
            }
        }

        private void cbBoek_SelectedIndexChanged(object sender, EventArgs e)
        {
            LaadLists();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (BibliotheekEntities ctx = new BibliotheekEntities())
            {
                BoekenAuteur nieuwe = new BoekenAuteur();
                nieuwe.BoekenId = (int)cbBoek.SelectedValue;
                nieuwe.AuteurId = (lbxAvailableAuteurs.SelectedValue as Auteur).Id;

                ctx.BoekenAuteurs.Add(nieuwe);
                ctx.SaveChanges();
            }
            LaadLists();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            using (BibliotheekEntities ctx = new BibliotheekEntities())
            {
                BoekenAuteur query = (lbxCurrentAuteurs.SelectedValue as BoekenAuteur);
                ctx.BoekenAuteurs.RemoveRange(ctx.BoekenAuteurs.Where(s => s.Id == (int)lbxCurrentAuteurs.SelectedValue));
                ctx.SaveChanges();

            }
            LaadLists();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
