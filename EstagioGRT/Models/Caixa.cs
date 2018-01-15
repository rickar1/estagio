using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EstagioGRT.Models
{
    public class Caixa
    {
        public Caixa()
        {
            int lastId = 0;
            if (GlobalVar.FluxoCaixa.Count > 0)
                lastId = GlobalVar.FluxoCaixa.Max(t => t.Id);
            this.Id = lastId + 1;
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Valor { get; set; }
        public char Operacao { get; set; }
    }
}