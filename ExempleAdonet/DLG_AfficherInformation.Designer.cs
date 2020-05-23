namespace ExempleAdonet
{
    partial class DLG_AfficherInformation
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
            this.IMB_Monuments = new PhotoManagerClient.ImageBox();
            this.Etoiles = new EvaluationDemo.Stars();
            this.CBB_Circuit = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.DTP_DateMonument = new System.Windows.Forms.DateTimePicker();
            this.BTN_Quitter = new System.Windows.Forms.Button();
            this.RTBX_Histoire = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LBX_Monuments = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TBX_Ordre = new System.Windows.Forms.TextBox();
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
            this.SPX_Panel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SPX_Panel.Name = "SPX_Panel";
            this.SPX_Panel.Size = new System.Drawing.Size(612, 34);
            this.SPX_Panel.TabIndex = 2;
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
            this.label1.Location = new System.Drawing.Point(7, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Afficher les informations...";
            // 
            // LBX_Quitter
            // 
            this.LBX_Quitter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LBX_Quitter.AutoSize = true;
            this.LBX_Quitter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.LBX_Quitter.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBX_Quitter.ForeColor = System.Drawing.Color.White;
            this.LBX_Quitter.Location = new System.Drawing.Point(581, 2);
            this.LBX_Quitter.Name = "LBX_Quitter";
            this.LBX_Quitter.Size = new System.Drawing.Size(28, 30);
            this.LBX_Quitter.TabIndex = 3;
            this.LBX_Quitter.Text = "X";
            this.LBX_Quitter.Click += new System.EventHandler(this.LBX_Quitter_Click);
            // 
            // IMB_Monuments
            // 
            this.IMB_Monuments.AllowDrop = true;
            this.IMB_Monuments.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.IMB_Monuments.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IMB_Monuments.ControlToolTipText = "You can either drag & drop, paste image from clipboard or choose an image file wi" +
    "th context menu.";
            this.IMB_Monuments.Enabled = false;
            this.IMB_Monuments.ImportImageText = "Import image from file...";
            this.IMB_Monuments.Location = new System.Drawing.Point(35, 482);
            this.IMB_Monuments.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.IMB_Monuments.Name = "IMB_Monuments";
            this.IMB_Monuments.OpenFileDialogTitle = "Please choose image an file";
            this.IMB_Monuments.PasteMenuText = "Paste image from clipboard";
            this.IMB_Monuments.Size = new System.Drawing.Size(543, 254);
            this.IMB_Monuments.TabIndex = 46;
            this.IMB_Monuments.TabStop = false;
            // 
            // Etoiles
            // 
            this.Etoiles.Enabled = false;
            this.Etoiles.Location = new System.Drawing.Point(213, 274);
            this.Etoiles.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Etoiles.MinimumSize = new System.Drawing.Size(100, 20);
            this.Etoiles.Name = "Etoiles";
            this.Etoiles.Size = new System.Drawing.Size(150, 30);
            this.Etoiles.StarsCount = 5;
            this.Etoiles.TabIndex = 45;
            this.Etoiles.Value = 0;
            // 
            // CBB_Circuit
            // 
            this.CBB_Circuit.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBB_Circuit.FormattingEnabled = true;
            this.CBB_Circuit.Location = new System.Drawing.Point(213, 62);
            this.CBB_Circuit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CBB_Circuit.Name = "CBB_Circuit";
            this.CBB_Circuit.Size = new System.Drawing.Size(367, 29);
            this.CBB_Circuit.TabIndex = 44;
            this.CBB_Circuit.SelectedIndexChanged += new System.EventHandler(this.CBB_Circuit_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(56, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 21);
            this.label6.TabIndex = 43;
            this.label6.Text = "Nom du circuit";
            // 
            // DTP_DateMonument
            // 
            this.DTP_DateMonument.CustomFormat = "yyyy-MM-dd";
            this.DTP_DateMonument.Enabled = false;
            this.DTP_DateMonument.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTP_DateMonument.Location = new System.Drawing.Point(213, 235);
            this.DTP_DateMonument.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DTP_DateMonument.Name = "DTP_DateMonument";
            this.DTP_DateMonument.Size = new System.Drawing.Size(367, 28);
            this.DTP_DateMonument.TabIndex = 42;
            this.DTP_DateMonument.Value = new System.DateTime(2018, 12, 7, 0, 0, 0, 0);
            // 
            // BTN_Quitter
            // 
            this.BTN_Quitter.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BTN_Quitter.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Quitter.Location = new System.Drawing.Point(35, 761);
            this.BTN_Quitter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTN_Quitter.Name = "BTN_Quitter";
            this.BTN_Quitter.Size = new System.Drawing.Size(544, 47);
            this.BTN_Quitter.TabIndex = 41;
            this.BTN_Quitter.Text = "Quitter";
            this.BTN_Quitter.UseVisualStyleBackColor = true;
            this.BTN_Quitter.Click += new System.EventHandler(this.BTN_Quitter_Click);
            // 
            // RTBX_Histoire
            // 
            this.RTBX_Histoire.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RTBX_Histoire.Location = new System.Drawing.Point(213, 330);
            this.RTBX_Histoire.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RTBX_Histoire.MaxLength = 1000;
            this.RTBX_Histoire.Name = "RTBX_Histoire";
            this.RTBX_Histoire.ReadOnly = true;
            this.RTBX_Histoire.Size = new System.Drawing.Size(367, 127);
            this.RTBX_Histoire.TabIndex = 39;
            this.RTBX_Histoire.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(117, 382);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 21);
            this.label5.TabIndex = 38;
            this.label5.Text = "Histoire";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 286);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 21);
            this.label4.TabIndex = 37;
            this.label4.Text = "Nombre d\'étoiles";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 21);
            this.label3.TabIndex = 36;
            this.label3.Text = "Date de création";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 21);
            this.label2.TabIndex = 34;
            this.label2.Text = "Liste des monuments";
            // 
            // LBX_Monuments
            // 
            this.LBX_Monuments.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBX_Monuments.FormattingEnabled = true;
            this.LBX_Monuments.ItemHeight = 21;
            this.LBX_Monuments.Location = new System.Drawing.Point(213, 110);
            this.LBX_Monuments.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LBX_Monuments.Name = "LBX_Monuments";
            this.LBX_Monuments.Size = new System.Drawing.Size(367, 67);
            this.LBX_Monuments.TabIndex = 47;
            this.LBX_Monuments.SelectedIndexChanged += new System.EventHandler(this.LBX_Monuments_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(369, 282);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 21);
            this.label7.TabIndex = 48;
            this.label7.Text = "Ordre";
            // 
            // TBX_Ordre
            // 
            this.TBX_Ordre.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBX_Ordre.Location = new System.Drawing.Point(433, 279);
            this.TBX_Ordre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TBX_Ordre.Name = "TBX_Ordre";
            this.TBX_Ordre.ReadOnly = true;
            this.TBX_Ordre.Size = new System.Drawing.Size(145, 28);
            this.TBX_Ordre.TabIndex = 49;
            // 
            // DLG_AfficherInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 818);
            this.Controls.Add(this.TBX_Ordre);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.LBX_Monuments);
            this.Controls.Add(this.IMB_Monuments);
            this.Controls.Add(this.Etoiles);
            this.Controls.Add(this.CBB_Circuit);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DTP_DateMonument);
            this.Controls.Add(this.BTN_Quitter);
            this.Controls.Add(this.RTBX_Histoire);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SPX_Panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DLG_AfficherInformation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DLG_AfficherInformation";
            this.Load += new System.EventHandler(this.DLG_AfficherInformation_Load);
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
        private PhotoManagerClient.ImageBox IMB_Monuments;
        private EvaluationDemo.Stars Etoiles;
        public System.Windows.Forms.ComboBox CBB_Circuit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker DTP_DateMonument;
        private System.Windows.Forms.Button BTN_Quitter;
        private System.Windows.Forms.RichTextBox RTBX_Histoire;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox LBX_Monuments;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TBX_Ordre;
    }
}