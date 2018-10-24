using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoLocadoraCarro.dominio
{
    class Veiculo
    {
        private string modeloCarro;
        private string fabricanteCarro;
        private int anoCarro;
        private string corCarro;
        private string placaCarro;
        private string estadoCarro;
        private string cidadeCarro;

        public string ModeloCarro { get => modeloCarro; set => modeloCarro = value; }
        public string FabricanteCarro { get => fabricanteCarro; set => fabricanteCarro = value; }
        public int AnoCarro { get => anoCarro; set => anoCarro = value; }
        public string CorCarro { get => corCarro; set => corCarro = value; }
        public string PlacaCarro { get => placaCarro; set => placaCarro = value; }
        public string EstadoCarro { get => estadoCarro; set => estadoCarro = value; }
        public string CidadeCarro { get => cidadeCarro; set => cidadeCarro = value; }

        public override string ToString()
        {
            return "Modelo: " + modeloCarro + "\n" + "Fabricante: " + fabricanteCarro + "\n" + "Ano: " + anoCarro + "\n" + "Cor: " + corCarro + "\n" +
                "Placa: " + placaCarro + "\n" + "Estado: " + estadoCarro + "\n" + "Cidade: " + cidadeCarro;
        }
    }
}
