using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCatalogoJogos.Entities
{
    public class Jogo
    {
        internal double Preco;

        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Produtora { get; set; }    
        public double preco { get; set; }
    }
}