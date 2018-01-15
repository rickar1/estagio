using EstagioGRT.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public static class GlobalVar
{

    static GlobalVar()
    {
        if (GlobalVar.FluxoCaixa?.Count == 0)
        {
            Caixa caixa1 = new Caixa();
            caixa1.Nome = "Salário";
            caixa1.Operacao = 'E';
            caixa1.Valor = 970;
            GlobalVar.FluxoCaixa.Add(caixa1);

            Caixa caixa2 = new Caixa();
            caixa2.Nome = "Compra Pão Supermercado";
            caixa2.Operacao = 'S';
            caixa2.Valor = 10;
            GlobalVar.FluxoCaixa.Add(caixa2);

            Caixa caixa3 = new Caixa();
            caixa3.Nome = "Show de humor";
            caixa3.Operacao = 'S';
            caixa3.Valor = 60;
            GlobalVar.FluxoCaixa.Add(caixa3);
        }
    }

    public static List<Caixa> FluxoCaixa { get; set; } = new List<Caixa>();
}