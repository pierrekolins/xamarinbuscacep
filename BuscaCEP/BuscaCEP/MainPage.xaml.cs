using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using BuscaCEP.Servico;
using BuscaCEP.Servico.Modelo;

namespace BuscaCEP
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            btnBusca.Clicked += BuscarCEP;
        }

        private void BuscarCEP(object sender, EventArgs args) {
            string cep = entryCep.Text.Trim(); 
            Endereco end = ViaCepServico.BuscaEnderecoViaCep(cep);
            lbResultado.Text = end.logradouro + " - " + end.localidade;
        }
    }
}
