using System;
using System.Collections.Generic;
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
        public static void GameOver(GameState stato,int punteggio,int record,Label labelStato,
            Button btnInizia,Button btnPausa,Label labelRecord,Timer timer)
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

            labelStato.Text = "GAME OVER\nPunteggio: " + punteggio + "\n\nPremi Inizia";
            labelStato.Visible = true;
            btnInizia.Enabled = true;
            btnPausa.Enabled = false;
        }
    }
}
