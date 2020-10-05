namespace BibliotheekSysteem
{
    partial class EditGenreList
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
            this.lbxCurrentGenres = new System.Windows.Forms.ListBox();
            this.cbBoek = new System.Windows.Forms.ComboBox();
            this.lbxAvailableGenres = new System.Windows.Forms.ListBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbxCurrentGenres
            // 
            this.lbxCurrentGenres.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbxCurrentGenres.FormattingEnabled = true;
            this.lbxCurrentGenres.Location = new System.Drawing.Point(12, 39);
            this.lbxCurrentGenres.Name = "lbxCurrentGenres";
            this.lbxCurrentGenres.Size = new System.Drawing.Size(121, 95);
            this.lbxCurrentGenres.TabIndex = 0;
            // 
            // cbBoek
            // 
            this.cbBoek.FormattingEnabled = true;
            this.cbBoek.Location = new System.Drawing.Point(12, 12);
            this.cbBoek.Name = "cbBoek";
            this.cbBoek.Size = new System.Drawing.Size(121, 21);
            this.cbBoek.TabIndex = 1;
            this.cbBoek.SelectedIndexChanged += new System.EventHandler(this.cbBoek_SelectedIndexChanged);
            // 
            // lbxAvailableGenres
            // 
            this.lbxAvailableGenres.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbxAvailableGenres.FormattingEnabled = true;
            this.lbxAvailableGenres.Location = new System.Drawing.Point(220, 39);
            this.lbxAvailableGenres.Name = "lbxAvailableGenres";
            this.lbxAvailableGenres.Size = new System.Drawing.Size(123, 95);
            this.lbxAvailableGenres.TabIndex = 2;
            this.lbxAvailableGenres.SelectedIndexChanged += new System.EventHandler(this.lbxAvailableGenres_SelectedIndexChanged);
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemove.Location = new System.Drawing.Point(139, 54);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(77, 23);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "=>";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Location = new System.Drawing.Point(139, 83);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(77, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "<=";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(217, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Available Genres:";
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Location = new System.Drawing.Point(220, 147);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(123, 23);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "Done";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // EditGenreList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 182);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.lbxAvailableGenres);
            this.Controls.Add(this.cbBoek);
            this.Controls.Add(this.lbxCurrentGenres);
            this.Name = "EditGenreList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "EditGenres";
            this.Load += new System.EventHandler(this.EditGenres_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxCurrentGenres;
        private System.Windows.Forms.ComboBox cbBoek;
        private System.Windows.Forms.ListBox lbxAvailableGenres;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOK;
    }
}