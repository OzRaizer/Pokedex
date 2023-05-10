﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorWasm.Compartilhado.Entidades
{
    public class Pokemon : IEntity
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int PokemonAtk { get; set; }  
        public string Tipo { get; set; }
        public string GolpePrincipal { get; set; }
        
    }
}
