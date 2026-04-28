using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        }

        private void btnConferma_Click(object sender, EventArgs e)
        {




            //------------CHIUSURA FORM2 CON ESITO OK--------------
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
