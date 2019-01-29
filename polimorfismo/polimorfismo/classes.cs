using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace polimorfismo
{
    abstract class Player
    {
        string _compositor;
        string _titulo;
        string _cantor;
        string _album;
        int _ano;

        public string Compositor
        {
            get { return _compositor; }
            set { _compositor = value; }
        }
        public string Titulo
        {
            get { return _titulo; }
            set { _titulo = value; }
        }
        public string Cantor
        {
            get { return _cantor; }
            set { _cantor = value; }
        }
        public string Album
        {
            get { return _album; }
            set { _album = value; }
        }
        public int Ano
        {
            get { return _ano; }
            set { _ano = value; }
        }
        public void Musica()
        {
            System.Windows.Forms.MessageBox.Show("A música "+ Titulo + " é de autoria de " + Compositor + ".");
        }

        public abstract void Play();

    }
    class MP3Player : Player
    {
        public override void Play()
        {
            System.Windows.Forms.MessageBox.Show("Gravada por " + Cantor + ", no album " + Album + ", em " + Ano.ToString() + ". Disponível no formato MP3.");
        }
    }
    class LPPlayer : Player
    {
        public override void Play()
        {
            System.Windows.Forms.MessageBox.Show("Gravada por " + Cantor + ", no album " + Album + ", em " + Ano.ToString() + ". Disponível no formato LP.");
        }
    }
    class CassetePlayer : Player
    {
        public override void Play()
        {
            System.Windows.Forms.MessageBox.Show("Gravada por " + Cantor + ", no album " + Album + ", em " + Ano.ToString() + ". Disponível no formato Cassete.");
        }
    }
}
