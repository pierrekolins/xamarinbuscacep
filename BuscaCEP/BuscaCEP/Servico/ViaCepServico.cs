using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using BuscaCEP.Servico.Modelo;
using Newtonsoft.Json;

namespace BuscaCEP.Servico
{
    public class ViaCepServico
    {

        private static string URL = "http://viacep.com.br/ws/{0}/json/";

        public static Endereco BuscaEnderecoViaCep(string cep) {
            string NovaURL = string.Format(URL, cep);

            WebClient wc = new WebClient();
            string conteudo = wc.DownloadString(NovaURL);

            Endereco end = JsonConvert.DeserializeObject<Endereco>(conteudo);

            return end;
        }
    }
}
