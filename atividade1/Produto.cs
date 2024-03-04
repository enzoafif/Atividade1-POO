using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade1
{
    public class Produto
    {
        public string Descricao;
        public double Valor;
        public double Desconto;

        public string AnalisarDesconto()
        {
            if(Desconto < 0 || Desconto > 100)
            {
                return "O desconto deve ser um valor entre 0 e 100";
            }

            double descontoEmDecimal = 1 - (Desconto / 100);

            double ValorComDesconto = Valor * descontoEmDecimal;

            return "O valor com desconto é " + ValorComDesconto;
        }
    }
}
