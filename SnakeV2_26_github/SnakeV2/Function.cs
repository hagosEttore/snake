using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeV2
{
    internal class function
    {
        public struct position
        {
            public int x;
            public int y;
        }

        public struct GameState
        {
            public bool Running;
            public bool Paused;
            public bool GameOver;
        }


        //--------------------------------------------------
        //INIZIA PARTITA
        //--------------------------------------------------
        public static void IniziaPartita(ref int num, position[]snake,int GridWidth,int GridHeight,
        ref int dirX,ref int dirY,ref int  nextDirX, ref int nextDirY)
        {
            // snake[0] = testa
            num = 3;
            for (int i = 0; i < num; i++)
            {
                snake[i].x = GridWidth / 2 + (num - 1 - i);
                snake[i].y = GridHeight / 2;
            }    

            dirX = 1; dirY = 0;
            nextDirX = 1; nextDirY = 0;
            

        }



        //--------------------------------------------
        //POSIZIONAMENTO DEL CIBO
        //--------------------------------------------

        public static void PosizionaCibo(int GridWidth, int GridHeight, int num,
            position[] snake, ref position food)
        {
            Random random = new Random();
            function.position pos = default;
            bool sovrapposto = default;
            do
            {
                pos.x = random.Next(0, GridWidth);
                pos.y = random.Next(0, GridHeight);


                sovrapposto = false;
                int x = 0;
                while (x < num)
                {
                    if (snake[x].x == pos.x && snake[x].y == pos.y)
                    {
                        sovrapposto = true;
                        break;
                    }
                    x++;
                }
            }
            while (sovrapposto);

            food = pos;
        }




        //---------------GAME OVER-------------
        public static void GameOver(ref GameState stato,ref int punteggio,ref int record,Label labelStato,
            Button btnInizia,Button btnPausa,Label labelRecord,Timer timer,Label labelPunteggio, function_accessi.dati_utente[]giocatore,int utenti)
        {
            timer.Stop();
            stato.GameOver = true;
            stato.Running = false;
            stato.Paused = false;

            if (punteggio > record)
            {
                record = punteggio;
                labelRecord.Text = "Record\n" + record;
            }
            int x = Cerca_utente(giocatore, utenti);
            if(x == -1)
            {
                MessageBox.Show("errore");
                return;
            }
            giocatore[x].punti = record;
            labelStato.Text = "GAME OVER\nPunteggio: " + punteggio + "\n\nPremi Inizia";
            labelStato.Visible = true;
            btnInizia.Enabled = true;
            btnPausa.Enabled = false;
            punteggio = 0;
            labelPunteggio.Text = "punteggio\n" + punteggio;
            StreamWriter p = new StreamWriter("dati.txt");
            int y = default;
            while (y < utenti)
            {
                p.WriteLine(giocatore[y].nome);
                p.WriteLine(giocatore[y].password);
                p.WriteLine(giocatore[y].punti);
                y++;
            }
            p.Close();
        }


        //----------FUNZIONE CHE CERCA L'UTENTE E MODIFICA RECORD-------------
        public static int Cerca_utente(function_accessi.dati_utente[] giocatore,int utenti)
        {
            int x = 0;
            while(x<utenti)
            {
                if (giocatore[x].password == function_accessi.password && giocatore[x].nome == function_accessi.nome)
                    return x;
                x++;
            }
            return -1;
           
        }

        //---------------FUNZIONE AGGIORNA CLASSIFICA-------------------
        public static void aggiorna_classifica(function_accessi.dati_utente[] giocatore,int utenti, ListView list_view)
        {
            list_view.Items.Clear();
            int x = 0;
            int end = utenti-1;
            int low = 0;
            ordina(giocatore, low, end);

            while(x<utenti)
            {
                ListViewItem item = new ListViewItem((x + 1).ToString());
                item.SubItems.Add(giocatore[x].nome);
                item.SubItems.Add(giocatore[x].punti.ToString());
                x++;
                list_view.Items.Add(item);
            }
        }

        //------------FUNZIONE CHE ORDINA--------------
        public static void ordina(function_accessi.dati_utente[] giocatore, int begin, int end)
        {
            if (end <= begin) return;

            function_accessi.dati_utente pivot = giocatore[begin];
            int l = begin + 1;
            int r = end;

            while (l <= r)
            {
                if (giocatore[l].punti >= pivot.punti) // ✅ >= per ordine decrescente
                    l++;
                else
                    swap(ref giocatore[l], ref giocatore[r--]); // ✅ r--, non l
            }

            // Metti il pivot nella posizione corretta
            swap(ref giocatore[begin], ref giocatore[l - 1]); // ✅ era giocatore[r]

            ordina(giocatore, begin, l - 2);
            ordina(giocatore, l, end);
        }

        public static void swap(ref function_accessi.dati_utente giocatore,ref function_accessi.dati_utente giocatore1)
        {
            function_accessi.dati_utente tmp = giocatore1;
            giocatore1 = giocatore;
            giocatore = tmp;
        }


        //---------FUNZIONE ELIMINA---------
        public static void elimina(function_accessi.dati_utente[] giocatore, int indice, ref int utenti)
        {
              
            for (int i = indice; i < utenti - 1; i++)
                giocatore[i] = giocatore[i + 1];

            utenti--;

            
            StreamWriter p = new StreamWriter("dati.txt");
            for (int i = 0; i < utenti; i++)
            {
                p.WriteLine(giocatore[i].nome);
                p.WriteLine(giocatore[i].password);
                p.WriteLine(giocatore[i].punti);
            }
            p.Close();
        }
    }
}
