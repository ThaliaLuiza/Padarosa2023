﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Padarosa2023.Classes
{
    public class Produto
    {
        public int Id { get; set; }

        public string Nome { get; set;}

        public double preco { get; set; }

        public int IdCategoria { get; set; }

        public int IdRespCadastro { get; set; }
    }
}
