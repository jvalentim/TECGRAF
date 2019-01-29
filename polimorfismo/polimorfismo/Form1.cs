using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace polimorfismo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmd_Play_Click(object sender, EventArgs e)
        {
            MP3Player p = new MP3Player();
            p.Compositor = "Arnaldo passos e Geraldo Pereira";
            p.Cantor = "Cartola";
            p.Titulo = "Escurinha";
            p.Album = "Verde Que Te Quero Rosa";
            p.Ano = 1977;
            p.Musica();
            p.Play();

            CassetePlayer p1 = new CassetePlayer();
            p1.Compositor = "Waldir Azevedo";
            p1.Cantor = "Waldir Azevedo";
            p1.Titulo = "Brasileirinho";
            p1.Album = "Carioquinha/Brasileirinho";
            p1.Ano = 1947;
            p1.Musica();
            p1.Play();

            LPPlayer p2 = new LPPlayer();
            p2.Compositor = "Pixinguinha e João de Barro";
            p2.Cantor = "Orlando Silva";
            p2.Titulo = "Carinhoso";
            p2.Album = " ";
            p2.Ano = 1917;
            p2.Musica();
            p2.Play();

        }
    }
}
