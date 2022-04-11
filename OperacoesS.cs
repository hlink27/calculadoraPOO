using System;
using Calculadora;
namespace Calculadora{
    class OperacoesS : Operacoes{
        public double potencia(){
            this.res = Math.Pow(this.x, this.y);
            return(this.res);
        }
        public double raizQuadrada(){
            this.res = Math.Sqrt(this.x);
            return(this.res);
        }
        public void pegarNumeroRaiz(){
            Console.WriteLine("Raiz quadrada de: ");
            this.x = Convert.ToDouble(Console.ReadLine());
        }
    }
}