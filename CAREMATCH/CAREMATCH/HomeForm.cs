﻿using CAREMATCH.VrijwilligerSysteem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAREMATCH
{
    public partial class HomeForm : Form
    {
        private Gebruiker gebruiker;
        private Database database;

        private ChatForm chatForm;
        private AgendaForm agendaForm;
        private HulpvraagForm hulpvraagForm;
        private HulpvraagOverzichtForm hulpvraagOverzichtForm;
        private ProfielForm profielForm;

        public HomeForm(Gebruiker gebruiker)
        {
            InitializeComponent();
            this.gebruiker = gebruiker;

            //was bezig met de database doorgeven via de constructor
            //this.database = database;

            if (gebruiker.rol == Enum.rol.hulpbehoevende)
            {
                btnAangenomenHulpvragen.Visible = false;

                btnOngepasteBerichten.Visible = false;
                btnAccountOverzicht.Visible = false;
            }
            else if (gebruiker.rol == Enum.rol.vrijwilliger)
            {
                btnHulpvraagIndienen.Visible = false;

                btnOngepasteBerichten.Visible = false;
                btnAccountOverzicht.Visible = false;
            }
            else
            {
                btnAangenomenHulpvragen.Visible = false;
                btnHulpvraagIndienen.Visible = false;
            }
        }

        private void btnHulpvraagIndienen_Click(object sender, EventArgs e)
        {
            this.Hide();
            hulpvraagForm = new HulpvraagForm(gebruiker, true);
            hulpvraagForm.ShowDialog();
            if(hulpvraagForm.DialogResult == DialogResult.OK || hulpvraagForm.DialogResult == DialogResult.Cancel)
            {
                this.Show();
            }
        }

        private void btnHulpvraagAannemen_Click(object sender, EventArgs e)
        {
            this.Hide();
            hulpvraagOverzichtForm = new HulpvraagOverzichtForm(gebruiker);
            hulpvraagOverzichtForm.ShowDialog();
            if(hulpvraagOverzichtForm.DialogResult == DialogResult.OK || hulpvraagOverzichtForm.DialogResult == DialogResult.Cancel)
            {
                this.Show();
            }
        }

        private void btnAangenomenHulpvragen_Click(object sender, EventArgs e)
        {
            this.Hide();
            hulpvraagOverzichtForm = new HulpvraagOverzichtForm(gebruiker);
            hulpvraagOverzichtForm.ShowDialog();
            if (hulpvraagOverzichtForm.DialogResult == DialogResult.OK || hulpvraagOverzichtForm.DialogResult == DialogResult.Cancel)
            {
                this.Show();
            }
        }

        private void btnAgenda_Click(object sender, EventArgs e)
        {
            this.Hide();
            agendaForm = new AgendaForm(gebruiker);
            agendaForm.ShowDialog();
            if (agendaForm.DialogResult == DialogResult.OK || agendaForm.DialogResult == DialogResult.Cancel)
            {
                this.Show();
            }
        }

        private void btnBerichten_Click(object sender, EventArgs e)
        {
            this.Hide();
            chatForm = new ChatForm(gebruiker);
            chatForm.ShowDialog();
            if (chatForm.DialogResult == DialogResult.OK || chatForm.DialogResult == DialogResult.Cancel)
            {
                this.Show();
            }
        }

        private void btnProfiel_Click(object sender, EventArgs e)
        {
            this.Hide();
            profielForm = new ProfielForm(gebruiker);
            profielForm.ShowDialog();
            if (profielForm.DialogResult == DialogResult.OK || profielForm.DialogResult == DialogResult.Cancel)
            {
                this.Show();
            }
        }

        private void btnUitloggen_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Dispose();
            this.Close();
        }

        private void btnOngepasteBerichten_Click(object sender, EventArgs e)
        {

        }

        private void btnAccountOverzicht_Click(object sender, EventArgs e)
        {

        }
    }
}
