using System;
using System.Drawing;
using System.Windows.Forms;

namespace SnakeV2
{
    public partial class Form1 : Form
    {
        // ═════════════════════════════════════════════════════════════════
        public Form1()
        {
            InitializeComponent();
        }

        // ── Costanti di gioco ──────────────────────────────────────────────
        private const int CellSize = 20;
        private const int GridWidth = 20;   // 400 / 20
        private const int GridHeight = 20;   // 400 / 20

        // ── Stato del serpente ─────────────────────────────────────────────-
        // snake[0] = testa, snake[snakeLength-1] = coda
        private function.position[] snake = new function.position[GridWidth * GridHeight];
        private int num;
        private function.position food;
        private int dirX, dirY;
        private int nextDirX, nextDirY;

        // ── Punteggi ───────────────────────────────────────────────────────
        private int punteggio;
        private int record;

        // ── Stato macchina ─────────────────────────────────────────────────
        //al'inizio erano cosi ma le ho modificate
        //public enum GameState { Idle, Running, Paused, GameOver }
        //private GameState stato = GameState.Idle;
        function.GameState stato = default;

        


        // ══════════════════════════════════════════════════════════════════
        // INIZIO PARTITA
        // ══════════════════════════════════════════════════════════════════
        private void btnInizia_Click(object sender, EventArgs e)
        {
            function.IniziaPartita(ref num, snake, GridWidth, GridHeight, ref dirX,
            ref dirY,ref nextDirX,ref nextDirY);
            stato.Running = true;
            stato.Paused = false;
            labelStato.Visible = false;
            btnInizia.Enabled = false;
            btnPausa.Enabled = true;
            btnPausa.Text = "⏸  Pausa";
            function.PosizionaCibo(GridWidth,GridHeight,num,snake,ref food);
            labelPunteggio.Text = "punteggio\n" + punteggio;
            
        timer1.Start();
        }

        

        // ══════════════════════════════════════════════════════════════════
        // PAUSA
        // ══════════════════════════════════════════════════════════════════
        private void btnPausa_Click(object sender, EventArgs e)
        {
            if (stato.Running)
            {
                stato.Paused = true;
                stato.Running = false;
                timer1.Stop();
                btnPausa.Text = "▶  Riprendi";
                labelStato.Text = "PAUSA";
                labelStato.Visible = true;
            }
            else if (stato.Paused)
            {
                stato.Running = true;
                stato.Paused = false;
                timer1.Start();
                btnPausa.Text = "⏸  Pausa";
                labelStato.Visible = false;
            }
        }

        // ══════════════════════════════════════════════════════════════════
        // GAME OVER
        // ══════════════════════════════════════════════════════════════════
       
        //                      )
        //{
        //    timer1.Stop();
        //    stato.GameOver = true;
        //    stato.Running = false;
        //    stato.Paused = false;

        //    if (punteggio > record)
        //    {
        //        record = punteggio;
        //        labelRecord.Text = "Record\n" + record;
        //    }

        //    labelStato.Text = "GAME OVER\nPunteggio: " + punteggio + "\n\nPremi Inizia";
        //    labelStato.Visible = true;
        //    btnInizia.Enabled = true;
        //    btnPausa.Enabled = false;
        //}

        // ══════════════════════════════════════════════════════════════════
        // TICK DEL TIMER
        // ══════════════════════════════════════════════════════════════════
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!stato.Running) return;

            dirX = nextDirX;
            dirY = nextDirY;

            function.position nuovaTesta = default;
            nuovaTesta.x = snake[0].x + dirX;
            nuovaTesta.y = snake[0].y + dirY;

            // Collisione con i bordi
            if (nuovaTesta.x < 0 || nuovaTesta.x >= GridWidth ||
                nuovaTesta.y < 0 || nuovaTesta.y >= GridHeight)
            {
                function.GameOver(stato,punteggio,record,labelStato,btnInizia,
                    btnPausa,labelRecord,timer1); return;
            }

            // Collisione con se stesso (escludi l'ultima cella: verrà rimossa)
            for (int i = 0; i < num - 1; i++)
            {
                if (snake[i].x == nuovaTesta.x && snake[i].y == nuovaTesta.y)
                { 
                    function.GameOver(stato,punteggio,record,labelStato,
                    btnInizia,btnPausa,labelRecord,timer1); return; 
                }
            }

            // Ha mangiato il cibo?
            bool mangiato = (nuovaTesta.x == food.x && nuovaTesta.y == food.y);

            int nuovaLunghezza = mangiato ? num + 1 : num;

            // Shift verso il fondo per liberare snake[0]
            for (int i = nuovaLunghezza - 1; i > 0; i--)
                snake[i] = snake[i - 1];

            snake[0] = nuovaTesta;
            num = nuovaLunghezza;

            if (mangiato)
            {
                punteggio += 1;
                labelPunteggio.Text = "punteggio\n" + punteggio;
                function.PosizionaCibo(GridWidth,GridHeight,num,snake,ref food);
            }

            pictureBoxGioco.Invalidate();
        }

        // ══════════════════════════════════════════════════════════════════
        // DISEGNO
        // ══════════════════════════════════════════════════════════════════
        private void pictureBoxGioco_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.Clear(Color.FromArgb(20, 20, 20));

            if (num == 0) return;

            // Cibo
            g.FillEllipse(Brushes.OrangeRed,
                food.x * CellSize + 2,
                food.y * CellSize + 2,
                CellSize - 4,
                CellSize - 4);

            // Serpente
            for (int i = 0; i < num; i++)
            {
                Color colore = (i == 0)
                    ? Color.LimeGreen
                    : Color.FromArgb(0, 180, 0);

                using (SolidBrush b = new SolidBrush(colore))
                {
                    g.FillRectangle(b,
                        snake[i].x * CellSize + 1,
                        snake[i].y * CellSize + 1,
                        CellSize - 2,
                        CellSize - 2);
                }
            }
        }

        // ══════════════════════════════════════════════════════════════════
        // INPUT DA TASTIERA
        // ══════════════════════════════════════════════════════════════════
        // Intercetta i tasti freccia PRIMA che WinForms sposti il focus tra i controlli
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (stato.Running)
            {
                switch (keyData)
                {
                    case Keys.Up: if (dirY != 1) { nextDirX = 0; nextDirY = -1; } return true;
                    case Keys.Down: if (dirY != -1) { nextDirX = 0; nextDirY = 1; } return true;
                    case Keys.Left: if (dirX != 1) { nextDirX = -1; nextDirY = 0; } return true;
                    case Keys.Right: if (dirX != -1) { nextDirX = 1; nextDirY = 0; } return true;
                }
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // ProcessCmdKey gestisce già le frecce; questo metodo rimane per compatibilità
        }

        
    }
}
