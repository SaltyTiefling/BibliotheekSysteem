namespace BibliotheekSysteem
{
    partial class BoekForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTitel = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnEditAuteurs = new System.Windows.Forms.Button();
            this.btnEditGenres = new System.Windows.Forms.Button();
            this.lblId = new System.Windows.Forms.Label();
            this.numScore = new System.Windows.Forms.NumericUpDown();
            this.numPaginas = new System.Windows.Forms.NumericUpDown();
            this.dtpPublicatie = new System.Windows.Forms.DateTimePicker();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtGenres = new System.Windows.Forms.TextBox();
            this.txtAuteurs = new System.Windows.Forms.TextBox();
            this.btnlock = new System.Windows.Forms.Button();
            this.cbUitgever = new System.Windows.Forms.ComboBox();
            this.btnNew = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numScore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPaginas)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Titel:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Id:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 358);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Aantal paginas:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 383);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Score:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 410);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Publicatie:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 440);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Uitgever:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 221);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Auteur(s):";
            // 
            // txtTitel
            // 
            this.txtTitel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTitel.Location = new System.Drawing.Point(100, 65);
            this.txtTitel.Name = "txtTitel";
            this.txtTitel.Size = new System.Drawing.Size(110, 20);
            this.txtTitel.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 91);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Genre(s):";
            // 
            // btnEditAuteurs
            // 
            this.btnEditAuteurs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditAuteurs.Location = new System.Drawing.Point(135, 327);
            this.btnEditAuteurs.Name = "btnEditAuteurs";
            this.btnEditAuteurs.Size = new System.Drawing.Size(75, 23);
            this.btnEditAuteurs.TabIndex = 18;
            this.btnEditAuteurs.Text = "pas aan";
            this.btnEditAuteurs.UseVisualStyleBackColor = true;
            this.btnEditAuteurs.Click += new System.EventHandler(this.btnEditAuteurs_Click);
            // 
            // btnEditGenres
            // 
            this.btnEditGenres.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditGenres.Location = new System.Drawing.Point(135, 192);
            this.btnEditGenres.Name = "btnEditGenres";
            this.btnEditGenres.Size = new System.Drawing.Size(75, 23);
            this.btnEditGenres.TabIndex = 19;
            this.btnEditGenres.Text = "pas aan";
            this.btnEditGenres.UseVisualStyleBackColor = true;
            this.btnEditGenres.Click += new System.EventHandler(this.btnEditGenres_Click);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(97, 41);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(19, 13);
            this.lblId.TabIndex = 21;
            this.lblId.Text = "00";
            this.lblId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numScore
            // 
            this.numScore.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numScore.Location = new System.Drawing.Point(100, 381);
            this.numScore.Name = "numScore";
            this.numScore.Size = new System.Drawing.Size(110, 20);
            this.numScore.TabIndex = 16;
            // 
            // numPaginas
            // 
            this.numPaginas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numPaginas.Location = new System.Drawing.Point(100, 356);
            this.numPaginas.Name = "numPaginas";
            this.numPaginas.Size = new System.Drawing.Size(110, 20);
            this.numPaginas.TabIndex = 22;
            // 
            // dtpPublicatie
            // 
            this.dtpPublicatie.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpPublicatie.CustomFormat = "dd MMM yyyy";
            this.dtpPublicatie.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpPublicatie.Location = new System.Drawing.Point(100, 407);
            this.dtpPublicatie.Name = "dtpPublicatie";
            this.dtpPublicatie.Size = new System.Drawing.Size(110, 20);
            this.dtpPublicatie.TabIndex = 23;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.Location = new System.Drawing.Point(15, 459);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(195, 43);
            this.btnUpdate.TabIndex = 24;
            this.btnUpdate.Text = "Done";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtGenres
            // 
            this.txtGenres.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGenres.Location = new System.Drawing.Point(100, 91);
            this.txtGenres.Multiline = true;
            this.txtGenres.Name = "txtGenres";
            this.txtGenres.ReadOnly = true;
            this.txtGenres.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtGenres.Size = new System.Drawing.Size(110, 100);
            this.txtGenres.TabIndex = 25;
            // 
            // txtAuteurs
            // 
            this.txtAuteurs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAuteurs.Location = new System.Drawing.Point(100, 221);
            this.txtAuteurs.Multiline = true;
            this.txtAuteurs.Name = "txtAuteurs";
            this.txtAuteurs.ReadOnly = true;
            this.txtAuteurs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAuteurs.Size = new System.Drawing.Size(110, 100);
            this.txtAuteurs.TabIndex = 26;
            // 
            // btnlock
            // 
            this.btnlock.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnlock.Location = new System.Drawing.Point(15, 12);
            this.btnlock.Name = "btnlock";
            this.btnlock.Size = new System.Drawing.Size(148, 26);
            this.btnlock.TabIndex = 27;
            this.btnlock.Text = "unlock";
            this.btnlock.UseVisualStyleBackColor = true;
            this.btnlock.Click += new System.EventHandler(this.btnlock_Click);
            // 
            // cbUitgever
            // 
            this.cbUitgever.FormattingEnabled = true;
            this.cbUitgever.Location = new System.Drawing.Point(100, 432);
            this.cbUitgever.Name = "cbUitgever";
            this.cbUitgever.Size = new System.Drawing.Size(110, 21);
            this.cbUitgever.TabIndex = 28;
            // 
            // btnNew
            // 
            this.btnNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNew.Location = new System.Drawing.Point(169, 12);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(41, 26);
            this.btnNew.TabIndex = 46;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // BoekForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 514);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.cbUitgever);
            this.Controls.Add(this.btnlock);
            this.Controls.Add(this.txtAuteurs);
            this.Controls.Add(this.txtGenres);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dtpPublicatie);
            this.Controls.Add(this.numPaginas);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.btnEditGenres);
            this.Controls.Add(this.btnEditAuteurs);
            this.Controls.Add(this.numScore);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtTitel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.MinimumSize = new System.Drawing.Size(250, 480);
            this.Name = "BoekForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Boek";
            this.Load += new System.EventHandler(this.Boek_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numScore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPaginas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTitel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnEditAuteurs;
        private System.Windows.Forms.Button btnEditGenres;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.NumericUpDown numScore;
        private System.Windows.Forms.NumericUpDown numPaginas;
        private System.Windows.Forms.DateTimePicker dtpPublicatie;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtGenres;
        private System.Windows.Forms.TextBox txtAuteurs;
        private System.Windows.Forms.Button btnlock;
        private System.Windows.Forms.ComboBox cbUitgever;
        private System.Windows.Forms.Button btnNew;
    }
}