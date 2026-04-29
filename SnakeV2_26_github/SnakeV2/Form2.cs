using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeV2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            StreamReader p = new StreamReader("dati.txt");
            while(!p.EndOfStream)
            {
                giocatore[utenti].nome = p.ReadLine();
                giocatore[utenti].password = p.ReadLine();
                giocatore[utenti].punti = int.Parse(p.ReadLine());
                utenti++;
            }
            p.Close();
        }
        function_accessi.dati_utente[] giocatore = new function_accessi.dati_utente[100];
        int utenti = 0;


        //----------------BOTTONE ACCEDI---------------
        private void btnConferma_Click(object sender, EventArgs e)
        {
            if(utenti>99)
            {
                MessageBox.Show("utenti massimi inseriti");
                return;
            }

            if (String.IsNullOrEmpty(txtNome.Text))
                return;

            int x = 0;
            bool password_usata = default;
            while(x<utenti)
            {
                if (string.Compare(giocatore[x].password,txtPassword.Text)== 0 && txtNome.Text == giocatore[x].nome)
                {
                    password_usata = true;
                }
                x++;
            }
            giocatore[utenti].nome = txtNome.Text;
            giocatore[utenti].password = txtPassword.Text;
            utenti++;
            function_accessi.password = txtPassword.Text;
            function_accessi.nome = txtNome.Text; 
            int y = 0;
            if(!password_usata)
            {
                StreamWriter p = new StreamWriter("dati.txt");
                while (y < utenti)
                {
                    p.WriteLine(giocatore[y].nome);
                    p.WriteLine(giocatore[y].password);
                    p.WriteLine(giocatore[y].punti);
                    y++;
                }
                p.Close();

            }


            //------------CHIUSURA FORM2 CON ESITO OK--------------
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
