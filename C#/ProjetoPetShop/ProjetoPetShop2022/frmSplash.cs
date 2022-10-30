using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoPetShop2022
{
    public partial class frmSplash : Form
    {
        public frmSplash()
        {
            InitializeComponent();
        }

        private void frmTelaInicial_Shown(object sender, EventArgs e)
        {
            lbStatus.Text = "Carregando o Sistema...";
            this.Refresh();
            for (int i = 0; i <101; i++)
            {
                progressBar1.Value = i;
                Thread.Sleep(40);


            }
            Thread.Sleep(2000);
            this.Close();
        }
    }
}
