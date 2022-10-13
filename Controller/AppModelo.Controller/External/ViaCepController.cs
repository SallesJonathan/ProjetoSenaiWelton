using AppModelo.Model.Domain.Wrappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppModelo.Controller.External
{
    public class ViaCepController
    {
        //Retorna a classe ViaCepWrapper
        public ViaCepWrapper Obter(string cep)
        {
            var viaCep = new ViaCepWrapper();
            
            //FAKE CONSULTA
            viaCep.Bairro = "Aviso";
            viaCep.Logradouro = "Filogonio Peixoto";
            viaCep.Localidade = "Linhares";

            return viaCep;
        }
    }
}
