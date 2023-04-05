using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaAplicacao
{                                //exemplo de classe abstrata encapsulada
     class Calculo
    {   //variaveis
        private int parcela1 = 5; //5%
        private int parcela2 = 10;//10%    //não importa mostrar oq acontece aqui dentro 
        private int parcela3 = 15;//15%

        //metodo
        public int MostrarPreco(int precoInicial, int tipoProduto) 
        {
            int precoFinal = 0;

            switch (tipoProduto)//nesse bloco acontece o calculo e é chamado atraves do metodo
            {
                case 1:
                    precoFinal = precoInicial - (precoInicial * parcela1 / 100);
                    break;
                case 2:
                    precoFinal = precoInicial - (precoInicial * parcela2 / 100);
                    break;
                case 3:
                    precoFinal = precoInicial - (precoInicial * parcela3 / 100);
                    break;

            }
            return precoFinal;
        }    
	}
}

