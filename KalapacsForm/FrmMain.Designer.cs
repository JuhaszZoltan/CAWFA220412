namespace KalapacsForm
{
    partial class FrmMain
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
            this.uiLbl1 = new System.Windows.Forms.Label();
            this.cbNevek = new System.Windows.Forms.ComboBox();
            this.pbZaszlo = new System.Windows.Forms.PictureBox();
            this.lblCsoport = new System.Windows.Forms.Label();
            this.lblNemzet = new System.Windows.Forms.Label();
            this.lblKod = new System.Windows.Forms.Label();
            this.lblSorozat = new System.Windows.Forms.Label();
            this.lblEredmeny = new System.Windows.Forms.Label();
            this.uiLbl2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbZaszlo)).BeginInit();
            this.SuspendLayout();
            // 
            // uiLbl1
            // 
            this.uiLbl1.AutoSize = true;
            this.uiLbl1.Location = new System.Drawing.Point(102, 47);
            this.uiLbl1.Name = "uiLbl1";
            this.uiLbl1.Size = new System.Drawing.Size(210, 25);
            this.uiLbl1.TabIndex = 0;
            this.uiLbl1.Text = "Válasszon versenyzőt!";
            // 
            // cbNevek
            // 
            this.cbNevek.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNevek.FormattingEnabled = true;
            this.cbNevek.Location = new System.Drawing.Point(107, 96);
            this.cbNevek.Name = "cbNevek";
            this.cbNevek.Size = new System.Drawing.Size(340, 33);
            this.cbNevek.TabIndex = 1;
            this.cbNevek.SelectedIndexChanged += new System.EventHandler(this.CbNevek_SelectedIndexChanged);
            // 
            // pbZaszlo
            // 
            this.pbZaszlo.Location = new System.Drawing.Point(107, 429);
            this.pbZaszlo.Name = "pbZaszlo";
            this.pbZaszlo.Size = new System.Drawing.Size(340, 163);
            this.pbZaszlo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbZaszlo.TabIndex = 2;
            this.pbZaszlo.TabStop = false;
            // 
            // lblCsoport
            // 
            this.lblCsoport.AutoSize = true;
            this.lblCsoport.Location = new System.Drawing.Point(102, 155);
            this.lblCsoport.Name = "lblCsoport";
            this.lblCsoport.Size = new System.Drawing.Size(178, 25);
            this.lblCsoport.TabIndex = 0;
            this.lblCsoport.Text = "###CSOPORT###";
            // 
            // lblNemzet
            // 
            this.lblNemzet.AutoSize = true;
            this.lblNemzet.Location = new System.Drawing.Point(102, 203);
            this.lblNemzet.Name = "lblNemzet";
            this.lblNemzet.Size = new System.Drawing.Size(160, 25);
            this.lblNemzet.TabIndex = 0;
            this.lblNemzet.Text = "###NEMZET###";
            // 
            // lblKod
            // 
            this.lblKod.AutoSize = true;
            this.lblKod.Location = new System.Drawing.Point(102, 249);
            this.lblKod.Name = "lblKod";
            this.lblKod.Size = new System.Drawing.Size(215, 25);
            this.lblKod.TabIndex = 0;
            this.lblKod.Text = "###NEMZET_KOD###";
            // 
            // lblSorozat
            // 
            this.lblSorozat.AutoSize = true;
            this.lblSorozat.Location = new System.Drawing.Point(102, 294);
            this.lblSorozat.Name = "lblSorozat";
            this.lblSorozat.Size = new System.Drawing.Size(176, 25);
            this.lblSorozat.TabIndex = 0;
            this.lblSorozat.Text = "###SOROZAT###";
            // 
            // lblEredmeny
            // 
            this.lblEredmeny.AutoSize = true;
            this.lblEredmeny.Location = new System.Drawing.Point(102, 339);
            this.lblEredmeny.Name = "lblEredmeny";
            this.lblEredmeny.Size = new System.Drawing.Size(188, 25);
            this.lblEredmeny.TabIndex = 0;
            this.lblEredmeny.Text = "###EREDMENY###";
            // 
            // uiLbl2
            // 
            this.uiLbl2.AutoSize = true;
            this.uiLbl2.Location = new System.Drawing.Point(102, 383);
            this.uiLbl2.Name = "uiLbl2";
            this.uiLbl2.Size = new System.Drawing.Size(76, 25);
            this.uiLbl2.TabIndex = 0;
            this.uiLbl2.Text = "Zászló:";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 653);
            this.Controls.Add(this.pbZaszlo);
            this.Controls.Add(this.uiLbl2);
            this.Controls.Add(this.lblEredmeny);
            this.Controls.Add(this.lblSorozat);
            this.Controls.Add(this.lblKod);
            this.Controls.Add(this.lblNemzet);
            this.Controls.Add(this.lblCsoport);
            this.Controls.Add(this.cbNevek);
            this.Controls.Add(this.uiLbl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmMain";
            this.Text = "London 2012 - Férfi kalapácsvetés - selejtező";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbZaszlo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label uiLbl1;
        private System.Windows.Forms.ComboBox cbNevek;
        private System.Windows.Forms.PictureBox pbZaszlo;
        private System.Windows.Forms.Label lblCsoport;
        private System.Windows.Forms.Label lblNemzet;
        private System.Windows.Forms.Label lblKod;
        private System.Windows.Forms.Label lblSorozat;
        private System.Windows.Forms.Label lblEredmeny;
        private System.Windows.Forms.Label uiLbl2;
    }
}

