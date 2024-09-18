namespace PrimeMinisters
{
    partial class frmPrimeMinisters
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrimeMinisters));
            picPhoto = new PictureBox();
            lblName = new Label();
            lstPrimeMinisters = new ListBox();
            lblTermLabel = new Label();
            lblPartyLabel = new Label();
            lblTerm = new Label();
            lblParty = new Label();
            ((System.ComponentModel.ISupportInitialize)picPhoto).BeginInit();
            SuspendLayout();
            // 
            // picPhoto
            // 
            picPhoto.Location = new Point(40, 32);
            picPhoto.Name = "picPhoto";
            picPhoto.Size = new Size(250, 250);
            picPhoto.TabIndex = 0;
            picPhoto.TabStop = false;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblName.Location = new Point(40, 309);
            lblName.Name = "lblName";
            lblName.Size = new Size(68, 28);
            lblName.TabIndex = 1;
            lblName.Text = "Name";
            // 
            // lstPrimeMinisters
            // 
            lstPrimeMinisters.FormattingEnabled = true;
            lstPrimeMinisters.ItemHeight = 20;
            lstPrimeMinisters.Location = new Point(393, 32);
            lstPrimeMinisters.Name = "lstPrimeMinisters";
            lstPrimeMinisters.Size = new Size(157, 244);
            lstPrimeMinisters.TabIndex = 2;
            lstPrimeMinisters.SelectedIndexChanged += lstPrimeMinisters_SelectedIndexChanged;
            // 
            // lblTermLabel
            // 
            lblTermLabel.AutoSize = true;
            lblTermLabel.Location = new Point(40, 357);
            lblTermLabel.Name = "lblTermLabel";
            lblTermLabel.Size = new Size(45, 20);
            lblTermLabel.TabIndex = 1;
            lblTermLabel.Text = "Term:";
            // 
            // lblPartyLabel
            // 
            lblPartyLabel.AutoSize = true;
            lblPartyLabel.Location = new Point(40, 395);
            lblPartyLabel.Name = "lblPartyLabel";
            lblPartyLabel.Size = new Size(44, 20);
            lblPartyLabel.TabIndex = 1;
            lblPartyLabel.Text = "Party:";
            // 
            // lblTerm
            // 
            lblTerm.AutoSize = true;
            lblTerm.Location = new Point(129, 357);
            lblTerm.Name = "lblTerm";
            lblTerm.Size = new Size(89, 20);
            lblTerm.TabIndex = 1;
            lblTerm.Text = "[Term Time]";
            // 
            // lblParty
            // 
            lblParty.AutoSize = true;
            lblParty.Location = new Point(129, 395);
            lblParty.Name = "lblParty";
            lblParty.Size = new Size(95, 20);
            lblParty.TabIndex = 1;
            lblParty.Text = "[Party Name]";
            // 
            // frmPrimeMinisters
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(592, 457);
            Controls.Add(lstPrimeMinisters);
            Controls.Add(lblParty);
            Controls.Add(lblPartyLabel);
            Controls.Add(lblTerm);
            Controls.Add(lblTermLabel);
            Controls.Add(lblName);
            Controls.Add(picPhoto);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmPrimeMinisters";
            Text = "Prime Ministers";
            Load += frmPrimeMinisters_Load;
            ((System.ComponentModel.ISupportInitialize)picPhoto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picPhoto;
        private Label lblName;
        private ListBox lstPrimeMinisters;
        private Label lblTermLabel;
        private Label lblPartyLabel;
        private Label lblTerm;
        private Label lblParty;
    }
}
