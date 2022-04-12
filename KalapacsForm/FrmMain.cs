using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace KalapacsForm
{
    public partial class FrmMain : Form
    {
        public FrmMain() =>
            InitializeComponent();

        private void FrmMain_Load(object sender, EventArgs e)
        {
            var nevek = Program.versenyzok.Select(v => v.Nev);
            foreach (var nev in nevek)
                cbNevek.Items.Add(nev);

            cbNevek.SelectedItem = "Pars Krisztián";
        }

        private void VersenyzoBetolt(string versenyzoNeve)
        {
            var versenyzo = Program.versenyzok
                .Single(v => v.Nev == versenyzoNeve);

            lblCsoport.Text = $"{versenyzo.Csoport}";
            lblEredmeny.Text = $"{versenyzo.Eredmeny}";
            lblKod.Text = $"{versenyzo.Kod}";
            lblNemzet.Text = $"{versenyzo.Nemzet}";
            lblSorozat.Text = $"{versenyzo.Sorozat}";

            pbZaszlo.ImageLocation = $"..\\..\\Images\\{versenyzo.Kod}.png";
        }

        private void CbNevek_SelectedIndexChanged(object sender, EventArgs e) =>
            VersenyzoBetolt(cbNevek.SelectedItem as string);
    }
}
