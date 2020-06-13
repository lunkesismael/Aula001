﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp001.Models
{
    public abstract class Pessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public Cidades Cidade { get; set; }

    }
}