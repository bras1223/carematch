﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAREMATCH.Agenda
{
    public partial class AgendaPuntToevoegenForm : Form
    {
        Gebruiker gebruiker;
        AgendaPunt agendaPunt;
        Database database;
        public AgendaPuntToevoegenForm(Gebruiker gebruiker)
        {
            InitializeComponent();
            this.gebruiker = gebruiker;

            database = new Database();
            agendaPunt = new AgendaPunt();
        }
        private void btnSluiten_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void OplsaanEnSluiten_Click(object sender, EventArgs e)
        {
            if(txtEindTijd.Text == "" || txtStartTijd.Text == "")
            {
                MessageBox.Show("Vul in ieder geval een start- en eindtijd in.");
            }
            else
            {
                //Agendapunten opslaan
                agendaPunt.AgendaEigenaar = gebruiker.GebruikersID;
                agendaPunt.Titel = txtTitel.Text;
                agendaPunt.DatumTijdEind = int.Parse(txtEindTijd.Text);                
                agendaPunt.Hulpbehoevende = txtHulpbehoevende.Text;
                agendaPunt.Vrijwilliger = txtVrijwilliger.Text;
                agendaPunt.Beschrijving = txtBeschrijving.Text;
                //Zorgen dat alleen de eerste 2 cijfers van datum Eind & Start meegeven worden.
                while (agendaPunt.DatumTijdEind >= 25)
                {
                    agendaPunt.DatumTijdEind = agendaPunt.DatumTijdEind / 10;
                }
                agendaPunt.DatumTijdStart = int.Parse(txtStartTijd.Text);
                while (agendaPunt.DatumTijdStart >= 25)
                {
                    agendaPunt.DatumTijdStart = agendaPunt.DatumTijdStart / 10;
                }
                //Agendainfo inserten.
                database.AgendaPuntToevoegen(agendaPunt, gebruiker, dtpAfspraakDatum.Value.Date);
                gebruiker.AgendaPuntToevoegen(agendaPunt);

                DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}