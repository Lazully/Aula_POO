using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Carro> ListaDeCarros = new List<Carro>();

            #region addToList
            ListaDeCarros.Add(new Carro("vw", "fusca"));
            ListaDeCarros.Add(new Carro("vw", "kombi"));
            ListaDeCarros.Add(new Carro("vw", "gol"));
            ListaDeCarros.Add(new Carro("vw", "saveiro"));
            ListaDeCarros.Add(new Carro("toyota", "corolla"));
            ListaDeCarros.Add(new Carro("toyota", "prius"));
            ListaDeCarros.Add(new Carro("fiat", "uno"));
            ListaDeCarros.Add(new Carro("fiat", "mobi"));
            ListaDeCarros.Add(new Carro("renout", "sandero"));
            ListaDeCarros.Add(new Carro("ford", "ka"));
            ListaDeCarros.Add(new Carro("ford", "ka"));
            ListaDeCarros.Add(new Carro("chevrolet", "onix"));
            #endregion

            Console.WriteLine("====== Marcas e Modelos de Carros ======");

            Console.WriteLine($"{Environment.NewLine}Prefere procurar por marca ou modelo? ");
            string op = Console.ReadLine().ToLower();

            switch (op)
            {
                case "marca":
                    Console.WriteLine($"{Environment.NewLine}Qual a marca procurada? ");
                    string marca_pedida = Console.ReadLine().ToLower();

                    List<Carro> Carros = ListaDeCarros.Where(c => c.Modelo.ToLower().Contains(marca_pedida)).ToList();

                    Console.WriteLine($"{Environment.NewLine}Carro encontrado! Veja a lista abaixo: {Environment.NewLine}");

                    List<Carro> CarrosMarca = ListaDeCarros.Where(c => c.Marca.Contains(marca_pedida)).ToList();

                    foreach (var carro in CarrosMarca)
                        Console.WriteLine("WHERE Carro encontrado: " + carro.Modelo);
                    break;
                case "modelo":
                    Console.WriteLine($"{Environment.NewLine}Qual o modelo procurado? ");
                    string modelo_pedido = Console.ReadLine().ToLower();

                    List<Carro> CarrosModelo = ListaDeCarros.Where(c => c.Modelo.ToLower().Contains(modelo_pedido)).ToList();

                    Console.WriteLine($"{Environment.NewLine}Carro encontrado! ");

                    List<Carro> Carros_modelo;
                    Carros_modelo = ListaDeCarros.Where(c => c.Marca.Contains(modelo_pedido)).ToList();

                    foreach (var carro in CarrosModelo)
                        Console.WriteLine("WHERE Carro encontrado: " + carro.Marca);
                    break;
                default:
                    Console.WriteLine($"{Environment.NewLine}Opção inválida! ");
                    break;
            }

        }
    }

    public class Carro
    {
        public string Marca { get; set; }

        public string Modelo { get; set; }

        public Carro(string marca, string modelo)//não tem retorno pois é um método de construção. Vai ser envocado quando houver a palavra "new"
        {
            this.Marca = marca;//this referencia a marca da main
            this.Modelo = modelo;
        }
    }
}
