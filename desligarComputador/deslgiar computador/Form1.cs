using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace deslgiar_computador
{
    public partial class Temporizador : Form
    {
        public Temporizador()
        {
            InitializeComponent();
        }

        private void Desligar_Click(object sender, EventArgs e)
        {
            SystemSounds.Beep.Play();

            if (ListagemTempo.Text == "")
            {
                MessageBox.Show("Selecione a quantidade de tempo que deseja");
                return;
            }

            var tempoSelecionado = Convert.ToInt16(ListagemTempo.Text);
            var converterMinutos = tempoSelecionado * 60;

            MessageBox.Show("Seu computador irá desligar em "+ tempoSelecionado + " minutos");
            string executar = @"/C " + "shutdown -s -t "+ converterMinutos;
            System.Diagnostics.Process.Start("CMD.exe", executar).WaitForExit();
        }

        private void DesativarDesligamento_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Temporizador de desligamento desativado");
            string executar = @"/C " + "shutdown -a";
            System.Diagnostics.Process.Start("CMD.exe", executar).WaitForExit();
        }

        private void Temporizador_Load(object sender, EventArgs e)
        {

        }
        private void ListagemTempo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TextoTempo_Click(object sender, EventArgs e)
        {

        }
    }
}
