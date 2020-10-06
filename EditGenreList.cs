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
    public partial class EditGenreList : Form
    {

        public Dictionary<int, string> boekenLijst = new Dictionary<int, string>();

        public EditGenreList()
        {
            InitializeComponent();
        }

        private void EditGenres_Load(object sender, EventArgs e)
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
                lbxCurrentGenres.DataSource =
                    ctx.BoekenGenres.Where(s => s.BoekId == (int)cbBoek.SelectedValue).Select(s => new {id = s.Id, display = s.Genre.Genre1 })
                    .ToList();
                lbxCurrentGenres.DisplayMember = "display";
                lbxCurrentGenres.ValueMember = "id";

                lbxAvailableGenres.DataSource = ctx.Genres.Where(g => !(ctx.BoekenGenres.Where(s => s.BoekId == (int)cbBoek.SelectedValue).Select(s => s.Genre.Genre1)
                    .ToList().Contains(g.Genre1))).Select(s => new { s, display = s.Genre1 }).ToList();
                lbxAvailableGenres.DisplayMember = "display";
                lbxAvailableGenres.ValueMember = "s";
            }
        }

        private void cbBoek_SelectedIndexChanged(object sender, EventArgs e)
        {
            LaadLists();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            using (BibliotheekEntities ctx = new BibliotheekEntities())
            {
                BoekenGenre query = (lbxCurrentGenres.SelectedValue as BoekenGenre);
                ctx.BoekenGenres.RemoveRange(ctx.BoekenGenres.Where(s => s.Id == (int)lbxCurrentGenres.SelectedValue));
                ctx.SaveChanges();

            }
            LaadLists();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (BibliotheekEntities ctx = new BibliotheekEntities())
            {
                BoekenGenre nieuwe = new BoekenGenre();
                nieuwe.BoekId = (int)cbBoek.SelectedValue;
                nieuwe.GenreId = (lbxAvailableGenres.SelectedValue as Genre).Id;

                ctx.BoekenGenres.Add(nieuwe);
                ctx.SaveChanges();
            }
            LaadLists();
        }

        private void lbxAvailableGenres_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
