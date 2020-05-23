namespace ExempleAdonet
{
    partial class DLG_AjoutCircuit
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
            this.LBX_Quitter = new System.Windows.Forms.Label();
            this.BTN_Ajouter = new System.Windows.Forms.Button();
            this.BTN_Quitter = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TBX_NomCircuit = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TBX_PrixCircuit = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TBX_DureeCircuit = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CBB_VilleDepart = new System.Windows.Forms.ComboBox();
            this.CBB_Arrivee = new System.Windows.Forms.ComboBox();
            this.SPX_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // SPX_Panel
            // 
            this.SPX_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.SPX_Panel.Controls.Add(this.label1);
            this.SPX_Panel.Controls.Add(this.LBX_Quitter);
            this.SPX_Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.SPX_Panel.Location = new System.Drawing.Point(0, 0);
            this.SPX_Panel.Name = "SPX_Panel";
            this.SPX_Panel.Size = new System.Drawing.Size(437, 34);
            this.SPX_Panel.TabIndex = 0;
            this.SPX_Panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SPX_Panel_MouseDown);
            this.SPX_Panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SPX_Panel_MouseMove);
            this.SPX_Panel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.SPX_Panel_MouseUp);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.label1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ajouter un circuit...";
            // 
            // LBX_Quitter
            // 
            this.LBX_Quitter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LBX_Quitter.AutoSize = true;
            this.LBX_Quitter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.LBX_Quitter.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBX_Quitter.ForeColor = System.Drawing.Color.White;
            this.LBX_Quitter.Location = new System.Drawing.Point(409, 7);
            this.LBX_Quitter.Name = "LBX_Quitter";
            this.LBX_Quitter.Size = new System.Drawing.Size(28, 30);
            this.LBX_Quitter.TabIndex = 3;
            this.LBX_Quitter.Text = "X";
            this.LBX_Quitter.Click += new System.EventHandler(this.LBX_Quitter_Click);
            // 
            // BTN_Ajouter
            // 
            this.BTN_Ajouter.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BTN_Ajouter.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Ajouter.Location = new System.Drawing.Point(19, 255);
            this.BTN_Ajouter.Name = "BTN_Ajouter";
            this.BTN_Ajouter.Size = new System.Drawing.Size(197, 47);
            this.BTN_Ajouter.TabIndex = 1;
            this.BTN_Ajouter.Text = "Ajouter";
            this.BTN_Ajouter.UseVisualStyleBackColor = true;
            this.BTN_Ajouter.Click += new System.EventHandler(this.BTN_Ajouter_Click);
            // 
            // BTN_Quitter
            // 
            this.BTN_Quitter.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BTN_Quitter.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Quitter.Location = new System.Drawing.Point(222, 255);
            this.BTN_Quitter.Name = "BTN_Quitter";
            this.BTN_Quitter.Size = new System.Drawing.Size(197, 47);
            this.BTN_Quitter.TabIndex = 2;
            this.BTN_Quitter.Text = "Quitter";
            this.BTN_Quitter.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nom du circuit";
            // 
            // TBX_NomCircuit
            // 
            this.TBX_NomCircuit.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBX_NomCircuit.Location = new System.Drawing.Point(145, 58);
            this.TBX_NomCircuit.Name = "TBX_NomCircuit";
            this.TBX_NomCircuit.Size = new System.Drawing.Size(274, 28);
            this.TBX_NomCircuit.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 21);
            this.label3.TabIndex = 8;
            this.label3.Text = "Prix du circuit";
            // 
            // TBX_PrixCircuit
            // 
            this.TBX_PrixCircuit.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBX_PrixCircuit.Location = new System.Drawing.Point(145, 92);
            this.TBX_PrixCircuit.MaxLength = 4;
            this.TBX_PrixCircuit.Name = "TBX_PrixCircuit";
            this.TBX_PrixCircuit.Size = new System.Drawing.Size(274, 28);
            this.TBX_PrixCircuit.TabIndex = 2;
            this.TBX_PrixCircuit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBX_PrixCircuit_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(72, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 21);
            this.label4.TabIndex = 10;
            this.label4.Text = "Durée";
            // 
            // TBX_DureeCircuit
            // 
            this.TBX_DureeCircuit.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBX_DureeCircuit.Location = new System.Drawing.Point(145, 126);
            this.TBX_DureeCircuit.MaxLength = 3;
            this.TBX_DureeCircuit.Name = "TBX_DureeCircuit";
            this.TBX_DureeCircuit.Size = new System.Drawing.Size(274, 28);
            this.TBX_DureeCircuit.TabIndex = 3;
            this.TBX_DureeCircuit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBX_DureeCircuit_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 21);
            this.label5.TabIndex = 12;
            this.label5.Text = "Ville de départ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(22, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 21);
            this.label6.TabIndex = 14;
            this.label6.Text = "Ville d\'arrivée";
            // 
            // CBB_VilleDepart
            // 
            this.CBB_VilleDepart.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.CBB_VilleDepart.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CBB_VilleDepart.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBB_VilleDepart.FormattingEnabled = true;
            this.CBB_VilleDepart.Location = new System.Drawing.Point(145, 165);
            this.CBB_VilleDepart.Name = "CBB_VilleDepart";
            this.CBB_VilleDepart.Size = new System.Drawing.Size(274, 29);
            this.CBB_VilleDepart.TabIndex = 4;
            // 
            // CBB_Arrivee
            // 
            this.CBB_Arrivee.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.CBB_Arrivee.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CBB_Arrivee.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBB_Arrivee.FormattingEnabled = true;
            this.CBB_Arrivee.Location = new System.Drawing.Point(145, 202);
            this.CBB_Arrivee.Name = "CBB_Arrivee";
            this.CBB_Arrivee.Size = new System.Drawing.Size(274, 29);
            this.CBB_Arrivee.TabIndex = 5;
            // 
            // DLG_AjoutCircuit
            // 
            this.AcceptButton = this.BTN_Ajouter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 314);
            this.Controls.Add(this.CBB_Arrivee);
            this.Controls.Add(this.CBB_VilleDepart);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TBX_DureeCircuit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TBX_PrixCircuit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TBX_NomCircuit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BTN_Quitter);
            this.Controls.Add(this.BTN_Ajouter);
            this.Controls.Add(this.SPX_Panel);
            this.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DLG_AjoutCircuit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DLG_AjoutCircuit";
            this.Load += new System.EventHandler(this.DLG_AjoutCircuit_Load);
            this.SPX_Panel.ResumeLayout(false);
            this.SPX_Panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel SPX_Panel;
        private System.Windows.Forms.Label LBX_Quitter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTN_Ajouter;
        private System.Windows.Forms.Button BTN_Quitter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBX_NomCircuit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TBX_PrixCircuit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TBX_DureeCircuit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CBB_VilleDepart;
        private System.Windows.Forms.ComboBox CBB_Arrivee;
    }
}