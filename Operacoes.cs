using System;
using Calculadora;
namespace Calculadora{
    class Operacoes {
        public double x, y, res;
        public void pegarNumeros(){
            Console.WriteLine("Primeiro número: ");
            this.x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Segundo número: ");
            this.y = Convert.ToDouble(Console.ReadLine());
        }
        public double somar(){
            this.res = this.x + this.y;
            return(this.res);
        }
        public double subtrair(){
            this.res = this.x - this.y;
            return(this.res);
        }
        public double multiplicar(){
            this.res = this.x * this.y;
            return(this.res);
        }
        public double dividir(){
            this.res = this.x / this.y;
            return(this.res);
        }
    }
}