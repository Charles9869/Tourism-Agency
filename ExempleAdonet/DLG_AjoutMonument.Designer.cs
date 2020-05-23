namespace ExempleAdonet
{
    partial class DLG_AjoutMonument
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
            this.components = new System.ComponentModel.Container();
            this.SPX_Panel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.LBX_Quitter = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TBX_NomMonument = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.RTBX_Histoire = new System.Windows.Forms.RichTextBox();
            this.BTN_Quitter = new System.Windows.Forms.Button();
            this.BTN_Ajouter = new System.Windows.Forms.Button();
            this.DTP_DateMonument = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.CBB_Circuit = new System.Windows.Forms.ComboBox();
            this.IMB_Monuments = new PhotoManagerClient.ImageBox();
            this.Etoiles = new EvaluationDemo.Stars();
            this.SPX_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IMB_Monuments)).BeginInit();
            this.SuspendLayout();
            // 
            // SPX_Panel
            // 
            this.SPX_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.SPX_Panel.Controls.Add(this.label1);
            this.SPX_Panel.Controls.Add(this.LBX_Quitter);
            this.SPX_Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.SPX_Panel.Location = new System.Drawing.Point(0, 0);
            this.SPX_Panel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SPX_Panel.Name = "SPX_Panel";
            this.SPX_Panel.Size = new System.Drawing.Size(459, 28);
            this.SPX_Panel.TabIndex = 1;
            this.SPX_Panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SPX_Panel_MouseDown);
            this.SPX_Panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SPX_Panel_MouseMove);
            this.SPX_Panel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.SPX_Panel_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.label1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ajouter un monument...";
            // 
            // LBX_Quitter
            // 
            this.LBX_Quitter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LBX_Quitter.AutoSize = true;
            this.LBX_Quitter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.LBX_Quitter.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBX_Quitter.ForeColor = System.Drawing.Color.White;
            this.LBX_Quitter.Location = new System.Drawing.Point(436, 2);
            this.LBX_Quitter.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LBX_Quitter.Name = "LBX_Quitter";
            this.LBX_Quitter.Size = new System.Drawing.Size(22, 22);
            this.LBX_Quitter.TabIndex = 3;
            this.LBX_Quitter.Text = "X";
            this.LBX_Quitter.Click += new System.EventHandler(this.LBX_Quitter_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 155);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 19);
            this.label4.TabIndex = 22;
            this.label4.Text = "Nombre d\'étoiles";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 119);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 19);
            this.label3.TabIndex = 20;
            this.label3.Text = "Date de création";
            // 
            // TBX_NomMonument
            // 
            this.TBX_NomMonument.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBX_NomMonument.Location = new System.Drawing.Point(160, 83);
            this.TBX_NomMonument.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TBX_NomMonument.Name = "TBX_NomMonument";
            this.TBX_NomMonument.Size = new System.Drawing.Size(276, 24);
            this.TBX_NomMonument.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 83);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 19);
            this.label2.TabIndex = 18;
            this.label2.Text = "Nom du monument";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(83, 241);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 19);
            this.label5.TabIndex = 25;
            this.label5.Text = "Histoire";
            // 
            // RTBX_Histoire
            // 
            this.RTBX_Histoire.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RTBX_Histoire.Location = new System.Drawing.Point(160, 199);
            this.RTBX_Histoire.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RTBX_Histoire.MaxLength = 1000;
            this.RTBX_Histoire.Name = "RTBX_Histoire";
            this.RTBX_Histoire.Size = new System.Drawing.Size(276, 104);
            this.RTBX_Histoire.TabIndex = 26;
            this.RTBX_Histoire.Text = "";
            // 
            // BTN_Quitter
            // 
            this.BTN_Quitter.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BTN_Quitter.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Quitter.Location = new System.Drawing.Point(220, 541);
            this.BTN_Quitter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTN_Quitter.Name = "BTN_Quitter";
            this.BTN_Quitter.Size = new System.Drawing.Size(214, 38);
            this.BTN_Quitter.TabIndex = 28;
            this.BTN_Quitter.Text = "Quitter";
            this.BTN_Quitter.UseVisualStyleBackColor = true;
            // 
            // BTN_Ajouter
            // 
            this.BTN_Ajouter.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BTN_Ajouter.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Ajouter.Location = new System.Drawing.Point(14, 541);
            this.BTN_Ajouter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTN_Ajouter.Name = "BTN_Ajouter";
            this.BTN_Ajouter.Size = new System.Drawing.Size(202, 38);
            this.BTN_Ajouter.TabIndex = 27;
            this.BTN_Ajouter.Text = "Ajouter";
            this.BTN_Ajouter.UseVisualStyleBackColor = true;
            this.BTN_Ajouter.Click += new System.EventHandler(this.BTN_Ajouter_Click);
            // 
            // DTP_DateMonument
            // 
            this.DTP_DateMonument.CustomFormat = "yyyy-MM-dd";
            this.DTP_DateMonument.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTP_DateMonument.Location = new System.Drawing.Point(160, 119);
            this.DTP_DateMonument.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DTP_DateMonument.Name = "DTP_DateMonument";
            this.DTP_DateMonument.Size = new System.Drawing.Size(276, 24);
            this.DTP_DateMonument.TabIndex = 29;
            this.DTP_DateMonument.Value = new System.DateTime(2018, 12, 7, 0, 0, 0, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(40, 49);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 19);
            this.label6.TabIndex = 30;
            this.label6.Text = "Nom du circuit";
            // 
            // CBB_Circuit
            // 
            this.CBB_Circuit.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBB_Circuit.FormattingEnabled = true;
            this.CBB_Circuit.Location = new System.Drawing.Point(160, 49);
            this.CBB_Circuit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CBB_Circuit.Name = "CBB_Circuit";
            this.CBB_Circuit.Size = new System.Drawing.Size(276, 27);
            this.CBB_Circuit.TabIndex = 1;
            // 
            // IMB_Monuments
            // 
            this.IMB_Monuments.AllowDrop = true;
            this.IMB_Monuments.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.IMB_Monuments.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IMB_Monuments.ControlToolTipText = "You can either drag & drop, paste image from clipboard or choose an image file wi" +
    "th context menu.";
            this.IMB_Monuments.ImportImageText = "Import image from file...";
            this.IMB_Monuments.Location = new System.Drawing.Point(27, 319);
            this.IMB_Monuments.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.IMB_Monuments.Name = "IMB_Monuments";
            this.IMB_Monuments.OpenFileDialogTitle = "Please choose image an file";
            this.IMB_Monuments.PasteMenuText = "Paste image from clipboard";
            this.IMB_Monuments.Size = new System.Drawing.Size(408, 207);
            this.IMB_Monuments.TabIndex = 33;
            this.IMB_Monuments.TabStop = false;
            // 
            // Etoiles
            // 
            this.Etoiles.Location = new System.Drawing.Point(237, 155);
            this.Etoiles.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Etoiles.MinimumSize = new System.Drawing.Size(75, 16);
            this.Etoiles.Name = "Etoiles";
            this.Etoiles.Size = new System.Drawing.Size(120, 24);
            this.Etoiles.StarsCount = 5;
            this.Etoiles.TabIndex = 32;
            this.Etoiles.Value = 0;
            // 
            // DLG_AjoutMonument
            // 
            this.AcceptButton = this.BTN_Ajouter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 589);
            this.Controls.Add(this.IMB_Monuments);
            this.Controls.Add(this.Etoiles);
            this.Controls.Add(this.CBB_Circuit);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DTP_DateMonument);
            this.Controls.Add(this.BTN_Quitter);
            this.Controls.Add(this.BTN_Ajouter);
            this.Controls.Add(this.RTBX_Histoire);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TBX_NomMonument);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SPX_Panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "DLG_AjoutMonument";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ajouter un monument";
            this.Load += new System.EventHandler(this.DLG_AjoutMonument_Load);
            this.SPX_Panel.ResumeLayout(false);
            this.SPX_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IMB_Monuments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel SPX_Panel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LBX_Quitter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TBX_NomMonument;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox RTBX_Histoire;
        private System.Windows.Forms.Button BTN_Quitter;
        private System.Windows.Forms.Button BTN_Ajouter;
        private System.Windows.Forms.DateTimePicker DTP_DateMonument;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.ComboBox CBB_Circuit;
        private EvaluationDemo.Stars Etoiles;
        private PhotoManagerClient.ImageBox IMB_Monuments;
    }
}