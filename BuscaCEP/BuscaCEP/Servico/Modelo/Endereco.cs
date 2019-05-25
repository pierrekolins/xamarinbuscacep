using System;
using System.Collections.Generic;
using System.Text;

namespace BuscaCEP.Servico.Modelo
{
    public class Endereco
    {

        /*
         JSON
URL: viacep.com.br/ws/01001000/json/ 
UNICODE: viacep.com.br/ws/01001000/json/unicode/

    {
      "cep": "01001-000",
      "logradouro": "Praça da Sé",
      "complemento": "lado ímpar",
      "bairro": "Sé",
      "localidade": "São Paulo",
      "uf": "SP",
      "unidade": "",
      "ibge": "3550308",
      "gia": "1004"
    }
         */

        public string cep { get; set; }
        public string logradouro { get; set; }
        public string complemento { get; set; }
        public string bairro { get; set; }
        public string localidade { get; set; }
        public string uf { get; set; }
        public string unidade { get; set; }
        public string ibge { get; set; }
        public string gia { get; set; }

        public override string ToString()
        {
            return String.Format(" Dados da Pesquisa: \r\n {0} {1} {2} - {3} \r\n {4} - {5} \r\n {6}"
                ,logradouro, complemento, bairro, cep, localidade, uf,  ibge);
        }
    }
}
