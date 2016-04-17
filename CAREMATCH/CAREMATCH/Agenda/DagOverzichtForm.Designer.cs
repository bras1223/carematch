﻿namespace CAREMATCH.Agenda
{
    partial class DagOverzichtForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSluiten = new System.Windows.Forms.Button();
            this.pnlWeekrooster = new System.Windows.Forms.Panel();
            this.dtpTijdPicker = new System.Windows.Forms.DateTimePicker();
            this.btnAgendaPuntToevoegen = new System.Windows.Forms.Button();
            this.cdKiesKleur = new System.Windows.Forms.ColorDialog();
            this.lblDatumVandaag = new System.Windows.Forms.Label();
            this.lblDatumWaarde = new System.Windows.Forms.Label();
            this.cbFilter = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSluiten
            // 
            this.btnSluiten.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSluiten.Location = new System.Drawing.Point(22, 490);
            this.btnSluiten.Name = "btnSluiten";
            this.btnSluiten.Size = new System.Drawing.Size(133, 69);
            this.btnSluiten.TabIndex = 2;
            this.btnSluiten.Text = "Sluiten";
            this.btnSluiten.UseVisualStyleBackColor = true;
            this.btnSluiten.Click += new System.EventHandler(this.btnSluiten_Click);
            // 
            // pnlWeekrooster
            // 
            this.pnlWeekrooster.Location = new System.Drawing.Point(171, 63);
            this.pnlWeekrooster.Name = "pnlWeekrooster";
            this.pnlWeekrooster.Size = new System.Drawing.Size(1033, 496);
            this.pnlWeekrooster.TabIndex = 1;
            this.pnlWeekrooster.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlWeekrooster_Paint);
            // 
            // dtpTijdPicker
            // 
            this.dtpTijdPicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTijdPicker.Location = new System.Drawing.Point(13, 68);
            this.dtpTijdPicker.Name = "dtpTijdPicker";
            this.dtpTijdPicker.Size = new System.Drawing.Size(142, 32);
            this.dtpTijdPicker.TabIndex = 1;
            // 
            // btnAgendaPuntToevoegen
            // 
            this.btnAgendaPuntToevoegen.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgendaPuntToevoegen.Location = new System.Drawing.Point(22, 352);
            this.btnAgendaPuntToevoegen.Name = "btnAgendaPuntToevoegen";
            this.btnAgendaPuntToevoegen.Size = new System.Drawing.Size(133, 69);
            this.btnAgendaPuntToevoegen.TabIndex = 3;
            this.btnAgendaPuntToevoegen.Text = "Afspraak Toevoegen";
            this.btnAgendaPuntToevoegen.UseVisualStyleBackColor = true;
            this.btnAgendaPuntToevoegen.Click += new System.EventHandler(this.btnAgendaPuntToevoegen_Click);
            // 
            // lblDatumVandaag
            // 
            this.lblDatumVandaag.AutoSize = true;
            this.lblDatumVandaag.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatumVandaag.Location = new System.Drawing.Point(168, 21);
            this.lblDatumVandaag.Name = "lblDatumVandaag";
            this.lblDatumVandaag.Size = new System.Drawing.Size(223, 26);
            this.lblDatumVandaag.TabIndex = 5;
            this.lblDatumVandaag.Text = "Actuele Datum && Tijd:";
            // 
            // lblDatumWaarde
            // 
            this.lblDatumWaarde.AutoSize = true;
            this.lblDatumWaarde.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatumWaarde.Location = new System.Drawing.Point(397, 21);
            this.lblDatumWaarde.Name = "lblDatumWaarde";
            this.lblDatumWaarde.Size = new System.Drawing.Size(153, 26);
            this.lblDatumWaarde.TabIndex = 6;
            this.lblDatumWaarde.Text = "DatumWaarde";
            // 
            // cbFilter
            // 
            this.cbFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFilter.FormattingEnabled = true;
            this.cbFilter.Location = new System.Drawing.Point(12, 178);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(152, 33);
            this.cbFilter.TabIndex = 7;
            this.cbFilter.SelectedIndexChanged += new System.EventHandler(this.cbFilter_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 26);
            this.label1.TabIndex = 8;
            this.label1.Text = "Agenda van:";
            // 
            // DagOverzichtForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1216, 571);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbFilter);
            this.Controls.Add(this.lblDatumWaarde);
            this.Controls.Add(this.lblDatumVandaag);
            this.Controls.Add(this.btnAgendaPuntToevoegen);
            this.Controls.Add(this.dtpTijdPicker);
            this.Controls.Add(this.pnlWeekrooster);
            this.Controls.Add(this.btnSluiten);
            this.Name = "DagOverzichtForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agenda Dag Overzicht";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DagOverzichtForm_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSluiten;
        private System.Windows.Forms.Panel pnlWeekrooster;
        private System.Windows.Forms.DateTimePicker dtpTijdPicker;
        private System.Windows.Forms.Button btnAgendaPuntToevoegen;
        private System.Windows.Forms.ColorDialog cdKiesKleur;
        private System.Windows.Forms.Label lblDatumVandaag;
        private System.Windows.Forms.Label lblDatumWaarde;
        private System.Windows.Forms.ComboBox cbFilter;
        private System.Windows.Forms.Label label1;
    }
}