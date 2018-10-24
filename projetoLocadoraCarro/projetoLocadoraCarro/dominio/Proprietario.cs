using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetoLocadoraCarro.dominio
{
    class Proprietario
    {
        private string nomeProp;
        private string enderecoProp;
        private string bairroProp;
        private string complementoProp;
        private string cidadeProp;
        private string estadoProp;
        private string rgProp;
        private int cpfProp;
        private string dataNascimentoProp;
        private bool primeiroVeiculoProp;
        private string sexoProp;
        private string imagemProp;

        public string NomeProp { get => nomeProp; set => nomeProp = value; }
        public string EnderecoProp { get => enderecoProp; set => enderecoProp = value; }
        public string BairroProp { get => bairroProp; set => bairroProp = value; }
        public string ComplementoProp { get => complementoProp; set => complementoProp = value; }
        public string CidadeProp { get => cidadeProp; set => cidadeProp = value; }
        public string EstadoProp { get => estadoProp; set => estadoProp = value; }
        public string RgProp { get => rgProp; set => rgProp = value; }
        public int CpfProp { get => cpfProp; set => cpfProp = value; }
        public string DataNascimentoProp { get => dataNascimentoProp; set => dataNascimentoProp = value; }
        public bool PrimeiroVeiculoProp { get => primeiroVeiculoProp; set => primeiroVeiculoProp = value; }
        public string SexoProp { get => sexoProp; set => sexoProp = value; }
        public string ImagemProp { get => imagemProp; set => imagemProp = value; }

        public override string ToString()
        {
            return "Nome: " + nomeProp + "\n" + "Endereço: " + enderecoProp + "\n" + "Bairro: " + bairroProp + "\n" +
                "Complemento: " + complementoProp + "\n" + "Cidade: " + cidadeProp + "\n" + "Estado: " + estadoProp + "\n" +
                "RG: " + rgProp + "\n" + "CPF: " + cpfProp + "\n" + "Dt. Nasc.: " + dataNascimentoProp + "\n" +
                "Sexo: " + sexoProp + "\n";
        }
    }
}
