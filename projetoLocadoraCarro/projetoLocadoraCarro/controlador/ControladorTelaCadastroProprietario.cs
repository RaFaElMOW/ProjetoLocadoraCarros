﻿using projetoLocadoraCarro.dominio;
using projetoLocadoraCarro.repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetoLocadoraCarro.controlador
{
    class ControladorTelaCadastroProprietario
    {
        RepositorioProprietario repositorioProprietario = new RepositorioProprietario();
        public ControladorTelaCadastroProprietario()
        {

        }

        public void InserirProprietario(Proprietario proprietario, Veiculo veiculo)
        {
            repositorioProprietario.salvarProprietario(proprietario, veiculo);
        }

        public void alterarProprietario(Proprietario proprietario)
        {
            repositorioProprietario.updgradeProprietario(proprietario);
        }

        public void apagarProprietario(Proprietario proprietario)
        {
            repositorioProprietario.deleteProprietario(proprietario);
        }
    }
}
