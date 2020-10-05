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
    public partial class UitgeverijenForm : Form
    {
        private bool editable = true;
        public int selectedID = 0;
        public UitgeverijenForm()
        {
            InitializeComponent();
        }

        private void btnlock_Click(object sender, EventArgs e)
        {
            locking();
        }
        private void locking()
        {
            editable = !editable;

            btnlock.Text = (editable) ? "Lock" : "Unlock";

            txtNaam.ReadOnly = !editable;
            
            btnUpdate.Enabled = editable;

        }

        private void UitgeverijenForm_Load(object sender, EventArgs e)
        {
            using (BibliotheekEntities ctx = new BibliotheekEntities())
            {
                var query = ctx.Uitgeverijens.Where(s => s.Id == selectedID).FirstOrDefault();
                lblId.Text = query.Id.ToString();
                txtNaam.Text = query.Naam;
            }
            locking();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (BibliotheekEntities ctx = new BibliotheekEntities())
            {
                ctx.Uitgeverijens.Where(s => s.Id == selectedID).FirstOrDefault().Naam = txtNaam.Text;
                ctx.SaveChanges();
                Close();
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            using (BibliotheekEntities ctx = new BibliotheekEntities())
            {
                Uitgeverijen uitgeverijen = new Uitgeverijen();
                ctx.Uitgeverijens.Add(uitgeverijen);
                ctx.SaveChanges();
                selectedID = uitgeverijen.Id;
            }
                UitgeverijenForm_Load(sender, e);
        }
    }
}
