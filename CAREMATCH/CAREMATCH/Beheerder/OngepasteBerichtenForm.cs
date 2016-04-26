﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CAREMATCH.Hulpvragen;
using CAREMATCH.VrijwilligerSysteem;

namespace CAREMATCH
{
    public partial class OngepasteBerichtenForm : Form
    {
        private Database database;
        private Gebruiker gebruiker;
        private List<Hulpvraag> hulpvragen;
        

        public OngepasteBerichtenForm(Gebruiker gebruiker)
        {
            InitializeComponent();


            this.gebruiker = gebruiker;
            database = new Database();

            lvOngepasteBerichten.View = View.Details;
            lvOngepasteBerichten.CheckBoxes = true;

            hulpvragen = database.HulpvragenOverzicht(gebruiker, "ongepaste hulpvragen");
            RefreshListView();
            VulListViewMetHulpvragen(hulpvragen);
        }


        private void RefreshListView()
        {
            lvOngepasteBerichten.Clear();
            lvOngepasteBerichten.Columns.Add("Check");
            lvOngepasteBerichten.Columns.Add("ID");
            lvOngepasteBerichten.Columns.Add("Titel");
            lvOngepasteBerichten.Columns.Add("Hulpvraag");
            lvOngepasteBerichten.Columns.Add("Uitzetter");
            lvOngepasteBerichten.Columns.Add("Beoordeling");
            lvOngepasteBerichten.Columns.Add("Cijfer");
        }


        private void VerwijderGemarkeerdeHulpvraag(Hulpvraag hulpvraag)
        {
            database.HulpvraagVerwijderen(hulpvraag.HulpvraagID);
            hulpvraag = null;

        }

        private void VulListViewMetHulpvragen(List<Hulpvraag> hulpvragen)
        {
            foreach(Hulpvraag hulpvraag in hulpvragen)
            {
                ListViewItem item = new ListViewItem();
                item.SubItems.Add(hulpvraag.HulpvraagID.ToString());
                item.SubItems.Add(hulpvraag.Titel);
                item.SubItems.Add(hulpvraag.HulpvraagInhoud);
                item.SubItems.Add(hulpvraag.Hulpbehoevende);
                item.SubItems.Add(hulpvraag.Beoordeling);
                item.SubItems.Add(hulpvraag.cijfer);

                lvOngepasteBerichten.Items.Add(item);
            }
        }

        private void btnLaatZien_Click(object sender, EventArgs e)
        {
            this.Hide();
            Hulpvraag hulpvraag;
            //geselecteerde hulpvraag openen.
            hulpvraag = hulpvragen[lvOngepasteBerichten.FocusedItem.Index];
            if(hulpvraag != null)
            {
                HulpvraagForm hulpvraagForm = new HulpvraagForm(hulpvraag, gebruiker, false);
                hulpvraagForm.ShowDialog();
                if (hulpvraagForm.DialogResult == DialogResult.OK || hulpvraagForm.DialogResult == DialogResult.Cancel)
                {
                    this.Show();
                }
            }
            else
            {
                MessageBox.Show("selecteer AUB een hulpvraag");
            }


        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnDeleteSelection_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            foreach(ListViewItem item in lvOngepasteBerichten.Items)
            {
                if (item.Checked)
                {
                    Hulpvraag toDelete = hulpvragen[item.Index];
                    VerwijderGemarkeerdeHulpvraag(toDelete);
                }
            }
            //refresh listview
        }

        private void OngepasteBerichtenForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
