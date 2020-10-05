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
    public partial class GenreForm : Form
    {
        private bool editable = true;
        public int selectedID = 0;
        public GenreForm()
        {
            InitializeComponent();
        }

        private void GenreForm_Load(object sender, EventArgs e)
        {
            using (BibliotheekEntities ctx = new BibliotheekEntities())
            {
                var query = ctx.Genres.Where(s => s.Id == selectedID).FirstOrDefault();
                lblId.Text = query.Id.ToString();
                txtGenre.Text = query.Genre1;
            }
            locking();
        }
        private void locking()
        {
            editable = !editable;

            btnlock.Text = (editable) ? "Lock" : "Unlock";

            txtGenre.ReadOnly = !editable;

            btnUpdate.Enabled = editable;

        }

        private void btnlock_Click(object sender, EventArgs e)
        {
            locking();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (BibliotheekEntities ctx = new BibliotheekEntities())
            {
                ctx.Genres.Where(s => s.Id == selectedID).FirstOrDefault().Genre1 = txtGenre.Text;
                ctx.SaveChanges();
                Close();
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            using (BibliotheekEntities ctx = new BibliotheekEntities())
            {
                Genre genre = new Genre();
                ctx.Genres.Add(genre);
                ctx.SaveChanges();
                selectedID = genre.Id;
            }
            GenreForm_Load(sender, e);
        }
    }
}
