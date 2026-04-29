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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.labelClassifica = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.colPos = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPunteggio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnCancellaRecord = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.labelProfilo = new System.Windows.Forms.Label();
            this.panelProfilo = new System.Windows.Forms.Panel();
            this.labelNomeUtente = new System.Windows.Forms.Label();
            this.txtCNome = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.txtCPassword = new System.Windows.Forms.TextBox();
            this.labelConfermaPassword = new System.Windows.Forms.Label();
            this.txtCNuovaPassword = new System.Windows.Forms.TextBox();
            this.btnSalvaProfilo = new System.Windows.Forms.Button();
            this.labelMessaggioProfilo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGioco)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panelProfilo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxGioco
            // 
            this.pictureBoxGioco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.pictureBoxGioco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxGioco.Location = new System.Drawing.Point(27, 83);
            this.pictureBoxGioco.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxGioco.Name = "pictureBoxGioco";
            this.pictureBoxGioco.Size = new System.Drawing.Size(533, 492);
            this.pictureBoxGioco.TabIndex = 0;
            this.pictureBoxGioco.TabStop = false;
            this.pictureBoxGioco.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxGioco_Paint);
            // 
            // labelPunteggio
            // 
            this.labelPunteggio.AutoSize = true;
            this.labelPunteggio.Font = new System.Drawing.Font("Consolas", 12F);
            this.labelPunteggio.ForeColor = System.Drawing.Color.White;
            this.labelPunteggio.Location = new System.Drawing.Point(587, 83);
            this.labelPunteggio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPunteggio.Name = "labelPunteggio";
            this.labelPunteggio.Size = new System.Drawing.Size(109, 46);
            this.labelPunteggio.TabIndex = 2;
            this.labelPunteggio.Text = "Punteggio\n0";
            // 
            // labelRecord
            // 
            this.labelRecord.AutoSize = true;
            this.labelRecord.Font = new System.Drawing.Font("Consolas", 12F);
            this.labelRecord.ForeColor = System.Drawing.Color.Gray;
            this.labelRecord.Location = new System.Drawing.Point(587, 145);
            this.labelRecord.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRecord.Name = "labelRecord";
            this.labelRecord.Size = new System.Drawing.Size(76, 46);
            this.labelRecord.TabIndex = 3;
            this.labelRecord.Text = "Record\n0";
            // 
            // labelTitolo
            // 
            this.labelTitolo.AutoSize = true;
            this.labelTitolo.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Bold);
            this.labelTitolo.ForeColor = System.Drawing.Color.LimeGreen;
            this.labelTitolo.Location = new System.Drawing.Point(21, 17);
            this.labelTitolo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTitolo.Name = "labelTitolo";
            this.labelTitolo.Size = new System.Drawing.Size(112, 40);
            this.labelTitolo.TabIndex = 1;
            this.labelTitolo.Text = "SNAKE";
            // 
            // btnInizia
            // 
            this.btnInizia.BackColor = System.Drawing.Color.LimeGreen;
            this.btnInizia.FlatAppearance.BorderSize = 0;
            this.btnInizia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInizia.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Bold);
            this.btnInizia.ForeColor = System.Drawing.Color.Black;
            this.btnInizia.Location = new System.Drawing.Point(587, 243);
            this.btnInizia.Margin = new System.Windows.Forms.Padding(4);
            this.btnInizia.Name = "btnInizia";
            this.btnInizia.Size = new System.Drawing.Size(147, 44);
            this.btnInizia.TabIndex = 1;
            this.btnInizia.Text = "▶  Inizia";
            this.btnInizia.UseVisualStyleBackColor = false;
            this.btnInizia.Click += new System.EventHandler(this.btnInizia_Click);
            // 
            // btnPausa
            // 
            this.btnPausa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnPausa.Enabled = false;
            this.btnPausa.FlatAppearance.BorderSize = 0;
            this.btnPausa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPausa.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Bold);
            this.btnPausa.ForeColor = System.Drawing.Color.White;
            this.btnPausa.Location = new System.Drawing.Point(587, 300);
            this.btnPausa.Margin = new System.Windows.Forms.Padding(4);
            this.btnPausa.Name = "btnPausa";
            this.btnPausa.Size = new System.Drawing.Size(147, 44);
            this.btnPausa.TabIndex = 2;
            this.btnPausa.Text = "⏸  Pausa";
            this.btnPausa.UseVisualStyleBackColor = false;
            this.btnPausa.Click += new System.EventHandler(this.btnPausa_Click);
            // 
            // labelStato
            // 
            this.labelStato.BackColor = System.Drawing.Color.Transparent;
            this.labelStato.Font = new System.Drawing.Font("Consolas", 13F, System.Drawing.FontStyle.Bold);
            this.labelStato.ForeColor = System.Drawing.Color.White;
            this.labelStato.Location = new System.Drawing.Point(27, 83);
            this.labelStato.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStato.Name = "labelStato";
            this.labelStato.Size = new System.Drawing.Size(533, 492);
            this.labelStato.TabIndex = 10;
            this.labelStato.Text = "Premi Inizia\nper giocare";
            this.labelStato.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Interval = 150;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabControl.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.tabControl.Location = new System.Drawing.Point(1, 1);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(901, 627);
            this.tabControl.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Black;
            this.tabPage1.Controls.Add(this.labelStato);
            this.tabPage1.Controls.Add(this.btnPausa);
            this.tabPage1.Controls.Add(this.pictureBoxGioco);
            this.tabPage1.Controls.Add(this.btnInizia);
            this.tabPage1.Controls.Add(this.labelTitolo);
            this.tabPage1.Controls.Add(this.labelRecord);
            this.tabPage1.Controls.Add(this.labelPunteggio);
            this.tabPage1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(893, 594);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "🎮  Gioco";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.tabPage2.Controls.Add(this.labelClassifica);
            this.tabPage2.Controls.Add(this.listView1);
            this.tabPage2.Controls.Add(this.btnCancellaRecord);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(893, 594);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "🏆  Classifica";
            // 
            // labelClassifica
            // 
            this.labelClassifica.AutoSize = true;
            this.labelClassifica.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold);
            this.labelClassifica.ForeColor = System.Drawing.Color.LimeGreen;
            this.labelClassifica.Location = new System.Drawing.Point(20, 18);
            this.labelClassifica.Name = "labelClassifica";
            this.labelClassifica.Size = new System.Drawing.Size(244, 36);
            this.labelClassifica.TabIndex = 0;
            this.labelClassifica.Text = "🏆  Classifica";
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colPos,
            this.colNome,
            this.colPunteggio});
            this.listView1.Font = new System.Drawing.Font("Consolas", 10F);
            this.listView1.ForeColor = System.Drawing.Color.White;
            this.listView1.FullRowSelect = true;
            this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(20, 60);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(600, 490);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // colPos
            // 
            this.colPos.Text = "#";
            // 
            // colNome
            // 
            this.colNome.Text = "Giocatore";
            this.colNome.Width = 300;
            // 
            // colPunteggio
            // 
            this.colPunteggio.Text = "Punteggio";
            this.colPunteggio.Width = 238;
            // 
            // btnCancellaRecord
            // 
            this.btnCancellaRecord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnCancellaRecord.FlatAppearance.BorderSize = 0;
            this.btnCancellaRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancellaRecord.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.btnCancellaRecord.ForeColor = System.Drawing.Color.White;
            this.btnCancellaRecord.Location = new System.Drawing.Point(640, 60);
            this.btnCancellaRecord.Name = "btnCancellaRecord";
            this.btnCancellaRecord.Size = new System.Drawing.Size(175, 44);
            this.btnCancellaRecord.TabIndex = 2;
            this.btnCancellaRecord.Text = "🗑  Cancella tutto";
            this.btnCancellaRecord.UseVisualStyleBackColor = false;
            this.btnCancellaRecord.Click += new System.EventHandler(this.btnCancellaRecord_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.tabPage3.Controls.Add(this.labelProfilo);
            this.tabPage3.Controls.Add(this.panelProfilo);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(893, 594);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "👤  Profilo";
            // 
            // labelProfilo
            // 
            this.labelProfilo.AutoSize = true;
            this.labelProfilo.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold);
            this.labelProfilo.ForeColor = System.Drawing.Color.LimeGreen;
            this.labelProfilo.Location = new System.Drawing.Point(20, 18);
            this.labelProfilo.Name = "labelProfilo";
            this.labelProfilo.Size = new System.Drawing.Size(196, 36);
            this.labelProfilo.TabIndex = 0;
            this.labelProfilo.Text = "👤  Profilo";
            // 
            // panelProfilo
            // 
            this.panelProfilo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panelProfilo.Controls.Add(this.labelNomeUtente);
            this.panelProfilo.Controls.Add(this.txtCNome);
            this.panelProfilo.Controls.Add(this.labelPassword);
            this.panelProfilo.Controls.Add(this.txtCPassword);
            this.panelProfilo.Controls.Add(this.labelConfermaPassword);
            this.panelProfilo.Controls.Add(this.txtCNuovaPassword);
            this.panelProfilo.Controls.Add(this.btnSalvaProfilo);
            this.panelProfilo.Controls.Add(this.labelMessaggioProfilo);
            this.panelProfilo.Location = new System.Drawing.Point(200, 70);
            this.panelProfilo.Name = "panelProfilo";
            this.panelProfilo.Padding = new System.Windows.Forms.Padding(20);
            this.panelProfilo.Size = new System.Drawing.Size(460, 420);
            this.panelProfilo.TabIndex = 1;
            // 
            // labelNomeUtente
            // 
            this.labelNomeUtente.AutoSize = true;
            this.labelNomeUtente.Font = new System.Drawing.Font("Consolas", 10F);
            this.labelNomeUtente.ForeColor = System.Drawing.Color.Gray;
            this.labelNomeUtente.Location = new System.Drawing.Point(20, 30);
            this.labelNomeUtente.Name = "labelNomeUtente";
            this.labelNomeUtente.Size = new System.Drawing.Size(108, 20);
            this.labelNomeUtente.TabIndex = 0;
            this.labelNomeUtente.Text = "NOME UTENTE";
            // 
            // txtCNome
            // 
            this.txtCNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtCNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCNome.Font = new System.Drawing.Font("Consolas", 12F);
            this.txtCNome.ForeColor = System.Drawing.Color.White;
            this.txtCNome.Location = new System.Drawing.Point(20, 55);
            this.txtCNome.MaxLength = 20;
            this.txtCNome.Name = "txtCNome";
            this.txtCNome.Size = new System.Drawing.Size(420, 31);
            this.txtCNome.TabIndex = 1;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Consolas", 10F);
            this.labelPassword.ForeColor = System.Drawing.Color.Gray;
            this.labelPassword.Location = new System.Drawing.Point(20, 110);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(171, 20);
            this.labelPassword.TabIndex = 2;
            this.labelPassword.Text = "INSERISCI PASSWORD";
            // 
            // txtCPassword
            // 
            this.txtCPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtCPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCPassword.Font = new System.Drawing.Font("Consolas", 12F);
            this.txtCPassword.ForeColor = System.Drawing.Color.White;
            this.txtCPassword.Location = new System.Drawing.Point(20, 135);
            this.txtCPassword.Name = "txtCPassword";
            this.txtCPassword.PasswordChar = '●';
            this.txtCPassword.Size = new System.Drawing.Size(420, 31);
            this.txtCPassword.TabIndex = 3;
            // 
            // labelConfermaPassword
            // 
            this.labelConfermaPassword.AutoSize = true;
            this.labelConfermaPassword.Font = new System.Drawing.Font("Consolas", 10F);
            this.labelConfermaPassword.ForeColor = System.Drawing.Color.Gray;
            this.labelConfermaPassword.Location = new System.Drawing.Point(20, 190);
            this.labelConfermaPassword.Name = "labelConfermaPassword";
            this.labelConfermaPassword.Size = new System.Drawing.Size(135, 20);
            this.labelConfermaPassword.TabIndex = 4;
            this.labelConfermaPassword.Text = "NUOVA PASSWORD";
            // 
            // txtCNuovaPassword
            // 
            this.txtCNuovaPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtCNuovaPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCNuovaPassword.Font = new System.Drawing.Font("Consolas", 12F);
            this.txtCNuovaPassword.ForeColor = System.Drawing.Color.White;
            this.txtCNuovaPassword.Location = new System.Drawing.Point(20, 215);
            this.txtCNuovaPassword.Name = "txtCNuovaPassword";
            this.txtCNuovaPassword.PasswordChar = '●';
            this.txtCNuovaPassword.Size = new System.Drawing.Size(420, 31);
            this.txtCNuovaPassword.TabIndex = 5;
            // 
            // btnSalvaProfilo
            // 
            this.btnSalvaProfilo.BackColor = System.Drawing.Color.LimeGreen;
            this.btnSalvaProfilo.FlatAppearance.BorderSize = 0;
            this.btnSalvaProfilo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvaProfilo.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Bold);
            this.btnSalvaProfilo.ForeColor = System.Drawing.Color.Black;
            this.btnSalvaProfilo.Location = new System.Drawing.Point(20, 280);
            this.btnSalvaProfilo.Name = "btnSalvaProfilo";
            this.btnSalvaProfilo.Size = new System.Drawing.Size(420, 44);
            this.btnSalvaProfilo.TabIndex = 6;
            this.btnSalvaProfilo.Text = "💾  Salva modifiche";
            this.btnSalvaProfilo.UseVisualStyleBackColor = false;
            this.btnSalvaProfilo.Click += new System.EventHandler(this.btnSalvaProfilo_Click);
            // 
            // labelMessaggioProfilo
            // 
            this.labelMessaggioProfilo.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.labelMessaggioProfilo.ForeColor = System.Drawing.Color.LimeGreen;
            this.labelMessaggioProfilo.Location = new System.Drawing.Point(20, 340);
            this.labelMessaggioProfilo.Name = "labelMessaggioProfilo";
            this.labelMessaggioProfilo.Size = new System.Drawing.Size(420, 50);
            this.labelMessaggioProfilo.TabIndex = 7;
            this.labelMessaggioProfilo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(902, 626);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Snake";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGioco)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.panelProfilo.ResumeLayout(false);
            this.panelProfilo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        // ── TAB 1: Gioco ──
        private System.Windows.Forms.PictureBox pictureBoxGioco;
        private System.Windows.Forms.Label labelTitolo;
        private System.Windows.Forms.Label labelPunteggio;
        private System.Windows.Forms.Label labelRecord;
        private System.Windows.Forms.Button btnInizia;
        private System.Windows.Forms.Button btnPausa;
        private System.Windows.Forms.Label labelStato;
        private System.Windows.Forms.Timer timer1;
        // ── TabControl ──
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        // ── TAB 2: Classifica ──
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader colPos;
        private System.Windows.Forms.ColumnHeader colNome;
        private System.Windows.Forms.ColumnHeader colPunteggio;
        private System.Windows.Forms.Label labelClassifica;
        private System.Windows.Forms.Button btnCancellaRecord;
        // ── TAB 3: Profilo ──
        private System.Windows.Forms.Label labelProfilo;
        private System.Windows.Forms.Panel panelProfilo;
        private System.Windows.Forms.Label labelNomeUtente;
        private System.Windows.Forms.TextBox txtCNome;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox txtCPassword;
        private System.Windows.Forms.Label labelConfermaPassword;
        private System.Windows.Forms.TextBox txtCNuovaPassword;
        private System.Windows.Forms.Button btnSalvaProfilo;
        private System.Windows.Forms.Label labelMessaggioProfilo;
    }
}