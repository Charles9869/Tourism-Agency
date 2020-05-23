namespace ExempleAdonet
{
    partial class DLG_NbEtoiles
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
            this.BTN_Confirmer = new System.Windows.Forms.Button();
            this.S_Stars = new EvaluationDemo.Stars();
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
            this.SPX_Panel.Name = "SPX_Panel";
            this.SPX_Panel.Size = new System.Drawing.Size(320, 34);
            this.SPX_Panel.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.label1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Choisir la cotation...";
            // 
            // LBX_Reduire
            // 
            this.LBX_Reduire.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LBX_Reduire.AutoSize = true;
            this.LBX_Reduire.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.LBX_Reduire.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBX_Reduire.ForeColor = System.Drawing.Color.White;
            this.LBX_Reduire.Location = new System.Drawing.Point(-163, 5);
            this.LBX_Reduire.Name = "LBX_Reduire";
            this.LBX_Reduire.Size = new System.Drawing.Size(21, 30);
            this.LBX_Reduire.TabIndex = 4;
            this.LBX_Reduire.Text = "-";
            // 
            // LBX_Quitter
            // 
            this.LBX_Quitter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LBX_Quitter.AutoSize = true;
            this.LBX_Quitter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.LBX_Quitter.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBX_Quitter.ForeColor = System.Drawing.Color.White;
            this.LBX_Quitter.Location = new System.Drawing.Point(-140, 3);
            this.LBX_Quitter.Name = "LBX_Quitter";
            this.LBX_Quitter.Size = new System.Drawing.Size(28, 30);
            this.LBX_Quitter.TabIndex = 3;
            this.LBX_Quitter.Text = "X";
            // 
            // BTN_Confirmer
            // 
            this.BTN_Confirmer.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BTN_Confirmer.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Confirmer.Location = new System.Drawing.Point(16, 117);
            this.BTN_Confirmer.Name = "BTN_Confirmer";
            this.BTN_Confirmer.Size = new System.Drawing.Size(292, 41);
            this.BTN_Confirmer.TabIndex = 4;
            this.BTN_Confirmer.Text = "Confirmer";
            this.BTN_Confirmer.UseVisualStyleBackColor = true;
            this.BTN_Confirmer.Click += new System.EventHandler(this.BTN_Confirmer_Click);
            // 
            // S_Stars
            // 
            this.S_Stars.Location = new System.Drawing.Point(47, 55);
            this.S_Stars.MinimumSize = new System.Drawing.Size(100, 20);
            this.S_Stars.Name = "S_Stars";
            this.S_Stars.Size = new System.Drawing.Size(235, 47);
            this.S_Stars.StarsCount = 5;
            this.S_Stars.TabIndex = 3;
            this.S_Stars.Value = 0;
            // 
            // DLG_NbEtoiles
            // 
            this.AcceptButton = this.BTN_Confirmer;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 170);
            this.Controls.Add(this.BTN_Confirmer);
            this.Controls.Add(this.S_Stars);
            this.Controls.Add(this.SPX_Panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DLG_NbEtoiles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DLG_NbEtoiles";
            this.Load += new System.EventHandler(this.DLG_NbEtoiles_Load);
            this.SPX_Panel.ResumeLayout(false);
            this.SPX_Panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SPX_Panel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LBX_Reduire;
        private System.Windows.Forms.Label LBX_Quitter;
        private EvaluationDemo.Stars S_Stars;
        private System.Windows.Forms.Button BTN_Confirmer;
    }
}