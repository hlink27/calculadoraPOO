using System;
namespace Calculadora{
    class CalculadoraMain{

        static void Main(string[] args){
            String comando = "", separador = "-------------";
            OperacoesS operacoes = new OperacoesS();
            while(!comando.Equals("0")){
                Console.WriteLine("___Calculadora___");
                Console.WriteLine("[+] Adição\n[-] Subtração\n[*] Multiplicação\n[/] Divisão\n[^] Potência\n[V] Raiz Quadrada\n[0] Fechar Programa");
                comando = Console.ReadLine();
                comando = comando.Substring(0,1);
                switch (comando) {
                    case "+":
                        operacoes.pegarNumeros();
                        operacoes.somar();
                        Console.WriteLine("Resposta: " + operacoes.res);
                        Console.WriteLine(separador);
                        break;
                    case "-":
                        operacoes.pegarNumeros();
                        operacoes.subtrair();
                        Console.WriteLine("Resposta: " + operacoes.res);
                        Console.WriteLine(separador);
                        break;
                    case "*":
                        operacoes.pegarNumeros();
                        operacoes.multiplicar();
                        Console.WriteLine("Resposta: " + operacoes.res);
                        Console.WriteLine(separador);
                        break;
                    case "/":
                        operacoes.pegarNumeros();
                        operacoes.dividir();
                        Console.WriteLine("Resposta: " + operacoes.res);
                        Console.WriteLine(separador);
                        break;
                    case "^":
                        operacoes.pegarNumeros();
                        operacoes.potencia();
                        Console.WriteLine("Resposta: " + operacoes.res);
                        Console.WriteLine(separador);
                        break;
                    case "V":
                        operacoes.pegarNumeroRaiz();
                        operacoes.raizQuadrada();
                        Console.WriteLine("Resposta: " + operacoes.res);
                        Console.WriteLine(separador);
                        break;
                    case "0":
                        break;
                    default:
                        Console.WriteLine("Erro.");
                        Console.WriteLine(separador);
                        break;
                }
            }
        }
    }
}
