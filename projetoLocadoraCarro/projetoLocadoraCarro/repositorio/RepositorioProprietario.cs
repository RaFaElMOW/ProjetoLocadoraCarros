﻿using projetoLocadoraCarro.dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetoLocadoraCarro.repositorio
{
    class RepositorioProprietario
    {
        public void salvarProprietario(Proprietario proprietario, Veiculo veiculo)
        {
            MessageBox.Show("Cadastro efetuado com sucesso!\n\n"+proprietario.ToString()+"\n\n\n\n"+veiculo.ToString());
        }

        public void updgradeProprietario(Proprietario proprietario)
        {

        }

        public void deleteProprietario(Proprietario proprietario)
        {

        }
    }
}
