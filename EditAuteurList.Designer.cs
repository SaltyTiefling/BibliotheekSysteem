namespace BibliotheekSysteem
{
    partial class EditAuteurList
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
            this.btnOK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.lbxAvailableAuteurs = new System.Windows.Forms.ListBox();
            this.cbBoek = new System.Windows.Forms.ComboBox();
            this.lbxCurrentAuteurs = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Location = new System.Drawing.Point(219, 147);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(123, 23);
            this.btnOK.TabIndex = 13;
            this.btnOK.Text = "Done";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(216, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Available Auteurs:";
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Location = new System.Drawing.Point(138, 83);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(77, 23);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "<=";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemove.Location = new System.Drawing.Point(138, 54);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(77, 23);
            this.btnRemove.TabIndex = 10;
            this.btnRemove.Text = "=>";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // lbxAvailableAuteurs
            // 
            this.lbxAvailableAuteurs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbxAvailableAuteurs.FormattingEnabled = true;
            this.lbxAvailableAuteurs.Location = new System.Drawing.Point(219, 39);
            this.lbxAvailableAuteurs.Name = "lbxAvailableAuteurs";
            this.lbxAvailableAuteurs.Size = new System.Drawing.Size(123, 95);
            this.lbxAvailableAuteurs.TabIndex = 9;
            // 
            // cbBoek
            // 
            this.cbBoek.FormattingEnabled = true;
            this.cbBoek.Location = new System.Drawing.Point(11, 12);
            this.cbBoek.Name = "cbBoek";
            this.cbBoek.Size = new System.Drawing.Size(121, 21);
            this.cbBoek.TabIndex = 8;
            this.cbBoek.SelectedIndexChanged += new System.EventHandler(this.cbBoek_SelectedIndexChanged);
            // 
            // lbxCurrentAuteurs
            // 
            this.lbxCurrentAuteurs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbxCurrentAuteurs.FormattingEnabled = true;
            this.lbxCurrentAuteurs.Location = new System.Drawing.Point(11, 39);
            this.lbxCurrentAuteurs.Name = "lbxCurrentAuteurs";
            this.lbxCurrentAuteurs.Size = new System.Drawing.Size(121, 95);
            this.lbxCurrentAuteurs.TabIndex = 7;
            // 
            // EditAuteurList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 182);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.lbxAvailableAuteurs);
            this.Controls.Add(this.cbBoek);
            this.Controls.Add(this.lbxCurrentAuteurs);
            this.MinimumSize = new System.Drawing.Size(368, 221);
            this.Name = "EditAuteurList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "EditAuteurList";
            this.Load += new System.EventHandler(this.EditAuteurList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.ListBox lbxAvailableAuteurs;
        private System.Windows.Forms.ComboBox cbBoek;
        private System.Windows.Forms.ListBox lbxCurrentAuteurs;
    }
}