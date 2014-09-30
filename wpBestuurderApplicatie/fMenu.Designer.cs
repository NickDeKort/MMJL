namespace wpBestuurderApplicatie
{
    partial class fMenu
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
            this.gbTramstatus = new System.Windows.Forms.GroupBox();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.lStatus = new System.Windows.Forms.Label();
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            this.bOpslaan = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cbTrams = new System.Windows.Forms.ComboBox();
            this.lTijd = new System.Windows.Forms.Label();
            this.tbTijd = new System.Windows.Forms.TextBox();
            this.lDatum = new System.Windows.Forms.Label();
            this.gbTramlocatielijst = new System.Windows.Forms.GroupBox();
            this.cbLocatieType = new System.Windows.Forms.ComboBox();
            this.lLocatielijstType = new System.Windows.Forms.Label();
            this.lLocatielijstStatus = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.dgvTramLocatie = new System.Windows.Forms.DataGridView();
            this.tram = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spoor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sector = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbTramLocatie = new System.Windows.Forms.GroupBox();
            this.tbTramlocatieTram = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbZoeken = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gbOpmerking = new System.Windows.Forms.GroupBox();
            this.tbOpmerking = new System.Windows.Forms.TextBox();
            this.bOpmerkingOpslaan = new System.Windows.Forms.Button();
            this.lOpmerkingTram = new System.Windows.Forms.Label();
            this.cbOpmerkingTram = new System.Windows.Forms.ComboBox();
            this.lOpmerking = new System.Windows.Forms.Label();
            this.gbTramstatus.SuspendLayout();
            this.gbTramlocatielijst.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTramLocatie)).BeginInit();
            this.gbTramLocatie.SuspendLayout();
            this.gbZoeken.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbOpmerking.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbTramstatus
            // 
            this.gbTramstatus.Controls.Add(this.cbStatus);
            this.gbTramstatus.Controls.Add(this.lStatus);
            this.gbTramstatus.Controls.Add(this.dtpDatum);
            this.gbTramstatus.Controls.Add(this.bOpslaan);
            this.gbTramstatus.Controls.Add(this.label4);
            this.gbTramstatus.Controls.Add(this.cbTrams);
            this.gbTramstatus.Controls.Add(this.lTijd);
            this.gbTramstatus.Controls.Add(this.tbTijd);
            this.gbTramstatus.Controls.Add(this.lDatum);
            this.gbTramstatus.Location = new System.Drawing.Point(405, 12);
            this.gbTramstatus.Name = "gbTramstatus";
            this.gbTramstatus.Size = new System.Drawing.Size(263, 209);
            this.gbTramstatus.TabIndex = 0;
            this.gbTramstatus.TabStop = false;
            this.gbTramstatus.Text = "Tramstatus Aanpassen";
            // 
            // cbStatus
            // 
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(33, 173);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(120, 21);
            this.cbStatus.TabIndex = 11;
            // 
            // lStatus
            // 
            this.lStatus.AutoSize = true;
            this.lStatus.Location = new System.Drawing.Point(18, 157);
            this.lStatus.Name = "lStatus";
            this.lStatus.Size = new System.Drawing.Size(40, 13);
            this.lStatus.TabIndex = 10;
            this.lStatus.Text = "Status:";
            // 
            // dtpDatum
            // 
            this.dtpDatum.Location = new System.Drawing.Point(33, 95);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(213, 20);
            this.dtpDatum.TabIndex = 9;
            // 
            // bOpslaan
            // 
            this.bOpslaan.Location = new System.Drawing.Point(182, 171);
            this.bOpslaan.Name = "bOpslaan";
            this.bOpslaan.Size = new System.Drawing.Size(75, 23);
            this.bOpslaan.TabIndex = 8;
            this.bOpslaan.Text = "Opslaan";
            this.bOpslaan.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Selecteer Tram:";
            // 
            // cbTrams
            // 
            this.cbTrams.FormattingEnabled = true;
            this.cbTrams.Location = new System.Drawing.Point(33, 41);
            this.cbTrams.Name = "cbTrams";
            this.cbTrams.Size = new System.Drawing.Size(213, 21);
            this.cbTrams.TabIndex = 6;
            // 
            // lTijd
            // 
            this.lTijd.AutoSize = true;
            this.lTijd.Location = new System.Drawing.Point(18, 118);
            this.lTijd.Name = "lTijd";
            this.lTijd.Size = new System.Drawing.Size(27, 13);
            this.lTijd.TabIndex = 3;
            this.lTijd.Text = "Tijd:";
            // 
            // tbTijd
            // 
            this.tbTijd.Location = new System.Drawing.Point(33, 134);
            this.tbTijd.Name = "tbTijd";
            this.tbTijd.Size = new System.Drawing.Size(120, 20);
            this.tbTijd.TabIndex = 2;
            this.tbTijd.Text = "00:00";
            // 
            // lDatum
            // 
            this.lDatum.AutoSize = true;
            this.lDatum.Location = new System.Drawing.Point(18, 78);
            this.lDatum.Name = "lDatum";
            this.lDatum.Size = new System.Drawing.Size(41, 13);
            this.lDatum.TabIndex = 1;
            this.lDatum.Text = "Datum:";
            // 
            // gbTramlocatielijst
            // 
            this.gbTramlocatielijst.Controls.Add(this.cbLocatieType);
            this.gbTramlocatielijst.Controls.Add(this.lLocatielijstType);
            this.gbTramlocatielijst.Controls.Add(this.lLocatielijstStatus);
            this.gbTramlocatielijst.Controls.Add(this.comboBox2);
            this.gbTramlocatielijst.Location = new System.Drawing.Point(6, 19);
            this.gbTramlocatielijst.Name = "gbTramlocatielijst";
            this.gbTramlocatielijst.Size = new System.Drawing.Size(157, 118);
            this.gbTramlocatielijst.TabIndex = 12;
            this.gbTramlocatielijst.TabStop = false;
            this.gbTramlocatielijst.Text = "Tramlocatielijst Opvragen";
            // 
            // cbLocatieType
            // 
            this.cbLocatieType.FormattingEnabled = true;
            this.cbLocatieType.Location = new System.Drawing.Point(31, 79);
            this.cbLocatieType.Name = "cbLocatieType";
            this.cbLocatieType.Size = new System.Drawing.Size(120, 21);
            this.cbLocatieType.TabIndex = 11;
            // 
            // lLocatielijstType
            // 
            this.lLocatielijstType.AutoSize = true;
            this.lLocatielijstType.Location = new System.Drawing.Point(16, 63);
            this.lLocatielijstType.Name = "lLocatielijstType";
            this.lLocatielijstType.Size = new System.Drawing.Size(34, 13);
            this.lLocatielijstType.TabIndex = 10;
            this.lLocatielijstType.Text = "Type:";
            // 
            // lLocatielijstStatus
            // 
            this.lLocatielijstStatus.AutoSize = true;
            this.lLocatielijstStatus.Location = new System.Drawing.Point(16, 23);
            this.lLocatielijstStatus.Name = "lLocatielijstStatus";
            this.lLocatielijstStatus.Size = new System.Drawing.Size(40, 13);
            this.lLocatielijstStatus.TabIndex = 7;
            this.lLocatielijstStatus.Text = "Status:";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(31, 39);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(120, 21);
            this.comboBox2.TabIndex = 6;
            // 
            // dgvTramLocatie
            // 
            this.dgvTramLocatie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTramLocatie.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tram,
            this.spoor,
            this.sector});
            this.dgvTramLocatie.Location = new System.Drawing.Point(15, 19);
            this.dgvTramLocatie.Name = "dgvTramLocatie";
            this.dgvTramLocatie.Size = new System.Drawing.Size(344, 250);
            this.dgvTramLocatie.TabIndex = 12;
            // 
            // tram
            // 
            this.tram.Frozen = true;
            this.tram.HeaderText = "Tram";
            this.tram.Name = "tram";
            this.tram.ReadOnly = true;
            // 
            // spoor
            // 
            this.spoor.Frozen = true;
            this.spoor.HeaderText = "Spoor";
            this.spoor.Name = "spoor";
            this.spoor.ReadOnly = true;
            // 
            // sector
            // 
            this.sector.Frozen = true;
            this.sector.HeaderText = "Sector";
            this.sector.Name = "sector";
            this.sector.ReadOnly = true;
            // 
            // gbTramLocatie
            // 
            this.gbTramLocatie.Controls.Add(this.tbTramlocatieTram);
            this.gbTramLocatie.Controls.Add(this.label1);
            this.gbTramLocatie.Location = new System.Drawing.Point(213, 19);
            this.gbTramLocatie.Name = "gbTramLocatie";
            this.gbTramLocatie.Size = new System.Drawing.Size(158, 118);
            this.gbTramLocatie.TabIndex = 12;
            this.gbTramLocatie.TabStop = false;
            this.gbTramLocatie.Text = "Tramlocatie Opvragen";
            // 
            // tbTramlocatieTram
            // 
            this.tbTramlocatieTram.Location = new System.Drawing.Point(24, 44);
            this.tbTramlocatieTram.Name = "tbTramlocatieTram";
            this.tbTramlocatieTram.Size = new System.Drawing.Size(117, 20);
            this.tbTramlocatieTram.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Tramnummer:";
            // 
            // gbZoeken
            // 
            this.gbZoeken.Controls.Add(this.groupBox1);
            this.gbZoeken.Controls.Add(this.gbTramLocatie);
            this.gbZoeken.Controls.Add(this.gbTramlocatielijst);
            this.gbZoeken.Location = new System.Drawing.Point(12, 12);
            this.gbZoeken.Name = "gbZoeken";
            this.gbZoeken.Size = new System.Drawing.Size(387, 424);
            this.gbZoeken.TabIndex = 13;
            this.gbZoeken.TabStop = false;
            this.gbZoeken.Text = "Zoeken";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvTramLocatie);
            this.groupBox1.Location = new System.Drawing.Point(6, 143);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(365, 275);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resultaat";
            // 
            // gbOpmerking
            // 
            this.gbOpmerking.Controls.Add(this.tbOpmerking);
            this.gbOpmerking.Controls.Add(this.bOpmerkingOpslaan);
            this.gbOpmerking.Controls.Add(this.lOpmerkingTram);
            this.gbOpmerking.Controls.Add(this.cbOpmerkingTram);
            this.gbOpmerking.Controls.Add(this.lOpmerking);
            this.gbOpmerking.Location = new System.Drawing.Point(405, 227);
            this.gbOpmerking.Name = "gbOpmerking";
            this.gbOpmerking.Size = new System.Drawing.Size(263, 209);
            this.gbOpmerking.TabIndex = 0;
            this.gbOpmerking.TabStop = false;
            this.gbOpmerking.Text = "Opmerking";
            // 
            // tbOpmerking
            // 
            this.tbOpmerking.Location = new System.Drawing.Point(21, 81);
            this.tbOpmerking.Multiline = true;
            this.tbOpmerking.Name = "tbOpmerking";
            this.tbOpmerking.Size = new System.Drawing.Size(225, 93);
            this.tbOpmerking.TabIndex = 9;
            // 
            // bOpmerkingOpslaan
            // 
            this.bOpmerkingOpslaan.Location = new System.Drawing.Point(182, 180);
            this.bOpmerkingOpslaan.Name = "bOpmerkingOpslaan";
            this.bOpmerkingOpslaan.Size = new System.Drawing.Size(75, 23);
            this.bOpmerkingOpslaan.TabIndex = 8;
            this.bOpmerkingOpslaan.Text = "Opslaan";
            this.bOpmerkingOpslaan.UseVisualStyleBackColor = true;
            // 
            // lOpmerkingTram
            // 
            this.lOpmerkingTram.AutoSize = true;
            this.lOpmerkingTram.Location = new System.Drawing.Point(6, 25);
            this.lOpmerkingTram.Name = "lOpmerkingTram";
            this.lOpmerkingTram.Size = new System.Drawing.Size(82, 13);
            this.lOpmerkingTram.TabIndex = 7;
            this.lOpmerkingTram.Text = "Selecteer Tram:";
            // 
            // cbOpmerkingTram
            // 
            this.cbOpmerkingTram.FormattingEnabled = true;
            this.cbOpmerkingTram.Location = new System.Drawing.Point(21, 41);
            this.cbOpmerkingTram.Name = "cbOpmerkingTram";
            this.cbOpmerkingTram.Size = new System.Drawing.Size(225, 21);
            this.cbOpmerkingTram.TabIndex = 6;
            // 
            // lOpmerking
            // 
            this.lOpmerking.AutoSize = true;
            this.lOpmerking.Location = new System.Drawing.Point(6, 65);
            this.lOpmerking.Name = "lOpmerking";
            this.lOpmerking.Size = new System.Drawing.Size(61, 13);
            this.lOpmerking.TabIndex = 3;
            this.lOpmerking.Text = "Opmerking:";
            // 
            // fMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 445);
            this.Controls.Add(this.gbZoeken);
            this.Controls.Add(this.gbOpmerking);
            this.Controls.Add(this.gbTramstatus);
            this.Name = "fMenu";
            this.Text = "Bestuurder Applicatie";
            this.gbTramstatus.ResumeLayout(false);
            this.gbTramstatus.PerformLayout();
            this.gbTramlocatielijst.ResumeLayout(false);
            this.gbTramlocatielijst.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTramLocatie)).EndInit();
            this.gbTramLocatie.ResumeLayout(false);
            this.gbTramLocatie.PerformLayout();
            this.gbZoeken.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.gbOpmerking.ResumeLayout(false);
            this.gbOpmerking.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbTramstatus;
        private System.Windows.Forms.Button bOpslaan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbTrams;
        private System.Windows.Forms.Label lTijd;
        private System.Windows.Forms.TextBox tbTijd;
        private System.Windows.Forms.Label lDatum;
        private System.Windows.Forms.DateTimePicker dtpDatum;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Label lStatus;
        private System.Windows.Forms.GroupBox gbTramlocatielijst;
        private System.Windows.Forms.ComboBox cbLocatieType;
        private System.Windows.Forms.Label lLocatielijstType;
        private System.Windows.Forms.Label lLocatielijstStatus;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.DataGridView dgvTramLocatie;
        private System.Windows.Forms.GroupBox gbTramLocatie;
        private System.Windows.Forms.DataGridViewTextBoxColumn tram;
        private System.Windows.Forms.DataGridViewTextBoxColumn spoor;
        private System.Windows.Forms.DataGridViewTextBoxColumn sector;
        private System.Windows.Forms.TextBox tbTramlocatieTram;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbZoeken;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gbOpmerking;
        private System.Windows.Forms.Button bOpmerkingOpslaan;
        private System.Windows.Forms.Label lOpmerkingTram;
        private System.Windows.Forms.ComboBox cbOpmerkingTram;
        private System.Windows.Forms.Label lOpmerking;
        private System.Windows.Forms.TextBox tbOpmerking;
    }
}

