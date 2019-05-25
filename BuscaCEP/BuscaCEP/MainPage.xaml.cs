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

            if (isValidCep(cep))
            {
                try
                {
                    Endereco end = ViaCepServico.BuscaEnderecoViaCep(cep);

                    if (end != null)
                    {
                        lbResultado.Text = end.ToString();
                    }
                    else
                    {
                        DisplayAlert("Erro", "Endereço não encontrado para o CEP pesquisado.", "Ok");
                    }

                    
                }catch(Exception e)
                {
                    DisplayAlert("Erro", e.Message, "Ok");
                }
            }
        }

        private bool isValidCep(string cep)
        {
            bool valido = true;
            if (cep.Length != 8)
            {
                DisplayAlert("Falha", "CEP deve possuir 8 dígitos.", "Ok");
                valido = false;
            }

            int tam = 0;
            if (!int.TryParse(cep, out tam)){
                DisplayAlert("Falha", "CEP deve possuir apena números.", "Ok");
                valido = false;
            }

            return valido;
        }
    }
}
