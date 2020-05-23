namespace ExempleAdonet
{
    partial class DLG_Prix
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
            this.SPX_Panel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.LBX_Reduire = new System.Windows.Forms.Label();
            this.LBX_Quitter = new System.Windows.Forms.Label();
            this.TBX_Prix = new System.Windows.Forms.TextBox();
            this.BTN_Confirmer = new System.Windows.Forms.Button();
            this.SPX_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // SPX_Panel
            // 
            this.SPX_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.SPX_Panel.Controls.Add(this.label1);
            this.SPX_Panel.Controls.Add(this.LBX_Reduire);
            this.SPX_Panel.Controls.Add(this.LBX_Quitter);
            this.SPX_Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.SPX_Panel.Location = new System.Drawing.Point(0, 0);
            this.SPX_Panel.Margin = new System.Windows.Forms.Padding(2);
            this.SPX_Panel.Name = "SPX_Panel";
            this.SPX_Panel.Size = new System.Drawing.Size(200, 28);
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
            this.label1.Location = new System.Drawing.Point(2, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Entrez un prix...";
            // 
            // LBX_Reduire
            // 
            this.LBX_Reduire.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LBX_Reduire.AutoSize = true;
            this.LBX_Reduire.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.LBX_Reduire.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBX_Reduire.ForeColor = System.Drawing.Color.White;
            this.LBX_Reduire.Location = new System.Drawing.Point(230, 6);
            this.LBX_Reduire.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LBX_Reduire.Name = "LBX_Reduire";
            this.LBX_Reduire.Size = new System.Drawing.Size(16, 22);
            this.LBX_Reduire.TabIndex = 4;
            this.LBX_Reduire.Text = "-";
            // 
            // LBX_Quitter
            // 
            this.LBX_Quitter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LBX_Quitter.AutoSize = true;
            this.LBX_Quitter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.LBX_Quitter.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBX_Quitter.ForeColor = System.Drawing.Color.White;
            this.LBX_Quitter.Location = new System.Drawing.Point(243, 6);
            this.LBX_Quitter.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LBX_Quitter.Name = "LBX_Quitter";
            this.LBX_Quitter.Size = new System.Drawing.Size(22, 22);
            this.LBX_Quitter.TabIndex = 3;
            this.LBX_Quitter.Text = "X";
            // 
            // TBX_Prix
            // 
            this.TBX_Prix.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TBX_Prix.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBX_Prix.Location = new System.Drawing.Point(22, 44);
            this.TBX_Prix.Margin = new System.Windows.Forms.Padding(2);
            this.TBX_Prix.Name = "TBX_Prix";
            this.TBX_Prix.Size = new System.Drawing.Size(155, 24);
            this.TBX_Prix.TabIndex = 2;
            this.TBX_Prix.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBX_Prix_KeyPress);
            // 
            // BTN_Confirmer
            // 
            this.BTN_Confirmer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_Confirmer.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BTN_Confirmer.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Confirmer.Location = new System.Drawing.Point(22, 72);
            this.BTN_Confirmer.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_Confirmer.Name = "BTN_Confirmer";
            this.BTN_Confirmer.Size = new System.Drawing.Size(155, 26);
            this.BTN_Confirmer.TabIndex = 3;
            this.BTN_Confirmer.Text = "Confirmer";
            this.BTN_Confirmer.UseVisualStyleBackColor = true;
            this.BTN_Confirmer.Click += new System.EventHandler(this.BTN_Confirmer_Click);
            // 
            // DLG_Prix
            // 
            this.AcceptButton = this.BTN_Confirmer;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(200, 107);
            this.Controls.Add(this.BTN_Confirmer);
            this.Controls.Add(this.TBX_Prix);
            this.Controls.Add(this.SPX_Panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DLG_Prix";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DLG_Prix";
            this.Load += new System.EventHandler(this.DLG_Prix_Load);
            this.SPX_Panel.ResumeLayout(false);
            this.SPX_Panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel SPX_Panel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LBX_Reduire;
        private System.Windows.Forms.Label LBX_Quitter;
        private System.Windows.Forms.TextBox TBX_Prix;
        private System.Windows.Forms.Button BTN_Confirmer;
    }
}