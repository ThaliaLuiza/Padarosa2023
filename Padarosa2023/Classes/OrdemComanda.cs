﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Padarosa2023.Classes
{
    public class OrdemComanda
    {
        public int Id { get; set; }

        public int IdFicha { get; set; }

        public int IdProduto { get; set; }

        public int quantidade { get; set; }

        public int IdResp { get; set; }

        public DateTime DataAdic { get; set; }

        public int Situacao { get; set;}


    }
}
