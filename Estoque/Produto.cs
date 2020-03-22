using System;
using System.Collections.Generic;
using System.Text;

namespace Estoque
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
            }

                public override string ToString()
        {
            return Nome + ", $ " + Preco;
    }
        }
    }

