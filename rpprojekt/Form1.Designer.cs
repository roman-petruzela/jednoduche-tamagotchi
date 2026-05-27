namespace rpprojekt
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblNadpis;
        private System.Windows.Forms.Label lblNadpisZviratko;
        private System.Windows.Forms.Label lblJmeno;
        private System.Windows.Forms.TextBox txtJmeno;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.GroupBox grpStav;
        private System.Windows.Forms.Label lblHlad;
        private System.Windows.Forms.Label lblNalada;
        private System.Windows.Forms.Label lblEnergie;
        private System.Windows.Forms.Label lblVek;
        private System.Windows.Forms.Label lblStav;
        private System.Windows.Forms.ProgressBar pbHlad;
        private System.Windows.Forms.ProgressBar pbNalada;
        private System.Windows.Forms.ProgressBar pbEnergie;
        private System.Windows.Forms.Label lblPorce;
        private System.Windows.Forms.TrackBar trkPorce;
        private System.Windows.Forms.Button btnKrm;
        private System.Windows.Forms.Button btnHraj;
        private System.Windows.Forms.Button btnSpi;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.ListBox lstMazlicci;
        private System.Windows.Forms.Timer timerHra;

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
            this.lblNadpis = new System.Windows.Forms.Label();
            this.lblNadpisZviratko = new System.Windows.Forms.Label();
            this.lblJmeno = new System.Windows.Forms.Label();
            this.txtJmeno = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.grpStav = new System.Windows.Forms.GroupBox();
            this.pbEnergie = new System.Windows.Forms.ProgressBar();
            this.pbNalada = new System.Windows.Forms.ProgressBar();
            this.pbHlad = new System.Windows.Forms.ProgressBar();
            this.lblStav = new System.Windows.Forms.Label();
            this.lblVek = new System.Windows.Forms.Label();
            this.lblEnergie = new System.Windows.Forms.Label();
            this.lblNalada = new System.Windows.Forms.Label();
            this.lblHlad = new System.Windows.Forms.Label();
            this.lblPorce = new System.Windows.Forms.Label();
            this.trkPorce = new System.Windows.Forms.TrackBar();
            this.btnKrm = new System.Windows.Forms.Button();
            this.btnHraj = new System.Windows.Forms.Button();
            this.btnSpi = new System.Windows.Forms.Button();
            this.btnRestart = new System.Windows.Forms.Button();
            this.lstMazlicci = new System.Windows.Forms.ListBox();
            this.timerHra = new System.Windows.Forms.Timer(this.components);
            this.grpStav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkPorce)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNadpis
            // 
            this.lblNadpis.AutoSize = true;
            this.lblNadpis.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNadpis.Location = new System.Drawing.Point(12, 9);
            this.lblNadpis.Name = "lblNadpis";
            this.lblNadpis.Size = new System.Drawing.Size(217, 24);
            this.lblNadpis.TabIndex = 0;
            this.lblNadpis.Text = "Jednoduche tamagoci";
            // 
            // lblNadpisZviratko
            // 
            this.lblNadpisZviratko.AutoSize = true;
            this.lblNadpisZviratko.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNadpisZviratko.Location = new System.Drawing.Point(12, 33);
            this.lblNadpisZviratko.Name = "lblNadpisZviratko";
            this.lblNadpisZviratko.Size = new System.Drawing.Size(89, 20);
            this.lblNadpisZviratko.TabIndex = 1;
            this.lblNadpisZviratko.Text = "Zviratko: -";
            // 
            // lblJmeno
            // 
            this.lblJmeno.AutoSize = true;
            this.lblJmeno.Location = new System.Drawing.Point(13, 74);
            this.lblJmeno.Name = "lblJmeno";
            this.lblJmeno.Size = new System.Drawing.Size(41, 13);
            this.lblJmeno.TabIndex = 2;
            this.lblJmeno.Text = "Jmeno:";
            // 
            // txtJmeno
            // 
            this.txtJmeno.Location = new System.Drawing.Point(58, 71);
            this.txtJmeno.Name = "txtJmeno";
            this.txtJmeno.Size = new System.Drawing.Size(148, 20);
            this.txtJmeno.TabIndex = 3;
            this.txtJmeno.Text = "Mazlík";
            this.txtJmeno.TextChanged += new System.EventHandler(this.txtJmeno_TextChanged);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(212, 69);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // grpStav
            // 
            this.grpStav.Controls.Add(this.pbEnergie);
            this.grpStav.Controls.Add(this.pbNalada);
            this.grpStav.Controls.Add(this.pbHlad);
            this.grpStav.Controls.Add(this.lblStav);
            this.grpStav.Controls.Add(this.lblVek);
            this.grpStav.Controls.Add(this.lblEnergie);
            this.grpStav.Controls.Add(this.lblNalada);
            this.grpStav.Controls.Add(this.lblHlad);
            this.grpStav.Location = new System.Drawing.Point(12, 107);
            this.grpStav.Name = "grpStav";
            this.grpStav.Size = new System.Drawing.Size(271, 173);
            this.grpStav.TabIndex = 5;
            this.grpStav.TabStop = false;
            this.grpStav.Text = "Stav zviratka";
            // 
            // pbEnergie
            // 
            this.pbEnergie.Location = new System.Drawing.Point(98, 83);
            this.pbEnergie.Name = "pbEnergie";
            this.pbEnergie.Size = new System.Drawing.Size(156, 18);
            this.pbEnergie.TabIndex = 7;
            // 
            // pbNalada
            // 
            this.pbNalada.Location = new System.Drawing.Point(98, 51);
            this.pbNalada.Name = "pbNalada";
            this.pbNalada.Size = new System.Drawing.Size(156, 18);
            this.pbNalada.TabIndex = 6;
            // 
            // pbHlad
            // 
            this.pbHlad.Location = new System.Drawing.Point(98, 19);
            this.pbHlad.Name = "pbHlad";
            this.pbHlad.Size = new System.Drawing.Size(156, 18);
            this.pbHlad.TabIndex = 5;
            // 
            // lblStav
            // 
            this.lblStav.AutoSize = true;
            this.lblStav.Location = new System.Drawing.Point(10, 143);
            this.lblStav.Name = "lblStav";
            this.lblStav.Size = new System.Drawing.Size(194, 13);
            this.lblStav.TabIndex = 4;
            this.lblStav.Text = "Nejsou tu zadni mazlicci. Klikni na Start.";
            // 
            // lblVek
            // 
            this.lblVek.AutoSize = true;
            this.lblVek.Location = new System.Drawing.Point(10, 120);
            this.lblVek.Name = "lblVek";
            this.lblVek.Size = new System.Drawing.Size(35, 13);
            this.lblVek.TabIndex = 3;
            this.lblVek.Text = "Vek: -";
            // 
            // lblEnergie
            // 
            this.lblEnergie.AutoSize = true;
            this.lblEnergie.Location = new System.Drawing.Point(10, 88);
            this.lblEnergie.Name = "lblEnergie";
            this.lblEnergie.Size = new System.Drawing.Size(52, 13);
            this.lblEnergie.TabIndex = 2;
            this.lblEnergie.Text = "Energie: -";
            // 
            // lblNalada
            // 
            this.lblNalada.AutoSize = true;
            this.lblNalada.Location = new System.Drawing.Point(10, 56);
            this.lblNalada.Name = "lblNalada";
            this.lblNalada.Size = new System.Drawing.Size(50, 13);
            this.lblNalada.TabIndex = 1;
            this.lblNalada.Text = "Nalada: -";
            // 
            // lblHlad
            // 
            this.lblHlad.AutoSize = true;
            this.lblHlad.Location = new System.Drawing.Point(10, 24);
            this.lblHlad.Name = "lblHlad";
            this.lblHlad.Size = new System.Drawing.Size(38, 13);
            this.lblHlad.TabIndex = 0;
            this.lblHlad.Text = "Hlad: -";
            // 
            // lblPorce
            // 
            this.lblPorce.AutoSize = true;
            this.lblPorce.Location = new System.Drawing.Point(314, 58);
            this.lblPorce.Name = "lblPorce";
            this.lblPorce.Size = new System.Drawing.Size(56, 13);
            this.lblPorce.TabIndex = 6;
            this.lblPorce.Text = "Porce jidla";
            // 
            // trkPorce
            // 
            this.trkPorce.Location = new System.Drawing.Point(303, 74);
            this.trkPorce.Minimum = 1;
            this.trkPorce.Name = "trkPorce";
            this.trkPorce.Size = new System.Drawing.Size(188, 45);
            this.trkPorce.TabIndex = 7;
            this.trkPorce.Value = 3;
            // 
            // btnKrm
            // 
            this.btnKrm.Enabled = false;
            this.btnKrm.Location = new System.Drawing.Point(303, 114);
            this.btnKrm.Name = "btnKrm";
            this.btnKrm.Size = new System.Drawing.Size(88, 30);
            this.btnKrm.TabIndex = 8;
            this.btnKrm.Text = "Krmit";
            this.btnKrm.UseVisualStyleBackColor = true;
            this.btnKrm.Click += new System.EventHandler(this.btnKrm_Click);
            // 
            // btnHraj
            // 
            this.btnHraj.Enabled = false;
            this.btnHraj.Location = new System.Drawing.Point(397, 114);
            this.btnHraj.Name = "btnHraj";
            this.btnHraj.Size = new System.Drawing.Size(88, 30);
            this.btnHraj.TabIndex = 9;
            this.btnHraj.Text = "Hrat si";
            this.btnHraj.UseVisualStyleBackColor = true;
            this.btnHraj.Click += new System.EventHandler(this.btnHraj_Click);
            // 
            // btnSpi
            // 
            this.btnSpi.Enabled = false;
            this.btnSpi.Location = new System.Drawing.Point(303, 149);
            this.btnSpi.Name = "btnSpi";
            this.btnSpi.Size = new System.Drawing.Size(88, 30);
            this.btnSpi.TabIndex = 10;
            this.btnSpi.Text = "Spat";
            this.btnSpi.UseVisualStyleBackColor = true;
            this.btnSpi.Click += new System.EventHandler(this.btnSpi_Click);
            // 
            // btnRestart
            // 
            this.btnRestart.Enabled = false;
            this.btnRestart.Location = new System.Drawing.Point(397, 149);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(88, 30);
            this.btnRestart.TabIndex = 11;
            this.btnRestart.Text = "Restart";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // lstMazlicci
            // 
            this.lstMazlicci.FormattingEnabled = true;
            this.lstMazlicci.Location = new System.Drawing.Point(303, 185);
            this.lstMazlicci.Name = "lstMazlicci";
            this.lstMazlicci.Size = new System.Drawing.Size(182, 95);
            this.lstMazlicci.TabIndex = 12;
            this.lstMazlicci.SelectedIndexChanged += new System.EventHandler(this.lstMazlicci_SelectedIndexChanged);
            // 
            // timerHra
            // 
            this.timerHra.Interval = 2000;
            this.timerHra.Tick += new System.EventHandler(this.timerHra_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 292);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.lstMazlicci);
            this.Controls.Add(this.btnSpi);
            this.Controls.Add(this.btnHraj);
            this.Controls.Add(this.btnKrm);
            this.Controls.Add(this.trkPorce);
            this.Controls.Add(this.lblPorce);
            this.Controls.Add(this.grpStav);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtJmeno);
            this.Controls.Add(this.lblJmeno);
            this.Controls.Add(this.lblNadpisZviratko);
            this.Controls.Add(this.lblNadpis);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jednoduche Tamagoci";
            this.grpStav.ResumeLayout(false);
            this.grpStav.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkPorce)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}

