namespace SnakeV2
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBoxGioco = new System.Windows.Forms.PictureBox();
            this.labelPunteggio = new System.Windows.Forms.Label();
            this.labelRecord = new System.Windows.Forms.Label();
            this.labelTitolo = new System.Windows.Forms.Label();
            this.btnInizia = new System.Windows.Forms.Button();
            this.btnPausa = new System.Windows.Forms.Button();
            this.labelStato = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGioco)).BeginInit();
            this.SuspendLayout();

            // 
            // pictureBoxGioco — campo di gioco 400x400
            // 
            this.pictureBoxGioco.BackColor = System.Drawing.Color.FromArgb(20, 20, 20);
            this.pictureBoxGioco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxGioco.Location = new System.Drawing.Point(20, 70);
            this.pictureBoxGioco.Name = "pictureBoxGioco";
            this.pictureBoxGioco.Size = new System.Drawing.Size(400, 400);
            this.pictureBoxGioco.TabIndex = 0;
            this.pictureBoxGioco.TabStop = false;
            this.pictureBoxGioco.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxGioco_Paint);

            // 
            // labelTitolo — "SNAKE" in alto a sinistra
            // 
            this.labelTitolo.AutoSize = true;
            this.labelTitolo.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Bold);
            this.labelTitolo.ForeColor = System.Drawing.Color.LimeGreen;
            this.labelTitolo.Location = new System.Drawing.Point(16, 16);
            this.labelTitolo.Name = "labelTitolo";
            this.labelTitolo.Text = "SNAKE";

            // 
            // labelPunteggio — punteggio attuale, sopra il campo
            // 
            this.labelPunteggio.AutoSize = true;
            this.labelPunteggio.Font = new System.Drawing.Font("Consolas", 12F);
            this.labelPunteggio.ForeColor = System.Drawing.Color.White;
            this.labelPunteggio.Location = new System.Drawing.Point(440, 70);
            this.labelPunteggio.Name = "labelPunteggio";
            this.labelPunteggio.Text = "Punteggio\n0";

            // 
            // labelRecord — record storico
            // 
            this.labelRecord.AutoSize = true;
            this.labelRecord.Font = new System.Drawing.Font("Consolas", 12F);
            this.labelRecord.ForeColor = System.Drawing.Color.Gray;
            this.labelRecord.Location = new System.Drawing.Point(440, 120);
            this.labelRecord.Name = "labelRecord";
            this.labelRecord.Text = "Record\n0";

            // 
            // btnInizia
            // 
            this.btnInizia.BackColor = System.Drawing.Color.LimeGreen;
            this.btnInizia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInizia.FlatAppearance.BorderSize = 0;
            this.btnInizia.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Bold);
            this.btnInizia.ForeColor = System.Drawing.Color.Black;
            this.btnInizia.Location = new System.Drawing.Point(440, 200);
            this.btnInizia.Name = "btnInizia";
            this.btnInizia.Size = new System.Drawing.Size(110, 36);
            this.btnInizia.TabIndex = 1;
            this.btnInizia.Text = "▶  Inizia";
            this.btnInizia.UseVisualStyleBackColor = false;
            this.btnInizia.Click += new System.EventHandler(this.btnInizia_Click);

            // 
            // btnPausa
            // 
            this.btnPausa.BackColor = System.Drawing.Color.FromArgb(50, 50, 50);
            this.btnPausa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPausa.FlatAppearance.BorderSize = 0;
            this.btnPausa.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Bold);
            this.btnPausa.ForeColor = System.Drawing.Color.White;
            this.btnPausa.Location = new System.Drawing.Point(440, 246);
            this.btnPausa.Name = "btnPausa";
            this.btnPausa.Size = new System.Drawing.Size(110, 36);
            this.btnPausa.TabIndex = 2;
            this.btnPausa.Text = "⏸  Pausa";
            this.btnPausa.UseVisualStyleBackColor = false;
            this.btnPausa.Enabled = false;
            this.btnPausa.Click += new System.EventHandler(this.btnPausa_Click);

            // 
            // labelStato — messaggio centrale nel campo ("Premi Inizia")
            // 
            this.labelStato.AutoSize = false;
            this.labelStato.Font = new System.Drawing.Font("Consolas", 13F, System.Drawing.FontStyle.Bold);
            this.labelStato.ForeColor = System.Drawing.Color.White;
            this.labelStato.BackColor = System.Drawing.Color.Transparent;
            this.labelStato.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelStato.Location = new System.Drawing.Point(20, 70);
            this.labelStato.Size = new System.Drawing.Size(400, 400);
            this.labelStato.Name = "labelStato";
            this.labelStato.Text = "Premi Inizia\nper giocare";

            // 
            // timer1
            // 
            this.timer1.Interval = 150;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            this.ClientSize = new System.Drawing.Size(580, 490);
            this.Controls.Add(this.labelStato);   // sopra pictureBox
            this.Controls.Add(this.pictureBoxGioco);
            this.Controls.Add(this.labelTitolo);
            this.Controls.Add(this.labelPunteggio);
            this.Controls.Add(this.labelRecord);
            this.Controls.Add(this.btnInizia);
            this.Controls.Add(this.btnPausa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;   // intercetta i tasti freccia
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Snake";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGioco)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxGioco;
        private System.Windows.Forms.Label labelTitolo;
        private System.Windows.Forms.Label labelPunteggio;
        private System.Windows.Forms.Label labelRecord;
        private System.Windows.Forms.Button btnInizia;
        private System.Windows.Forms.Button btnPausa;
        private System.Windows.Forms.Label labelStato;
        private System.Windows.Forms.Timer timer1;
    }
}