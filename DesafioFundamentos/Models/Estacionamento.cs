using System;
using System.Diagnostics.CodeAnalysis;
using DesafioFundamentos.models;

namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {

        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<Entrada> veiculos = new List<Entrada>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            Entrada entrada = new Entrada();
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            entrada.Placa = Console.ReadLine()!;
            entrada.Hora = DateTime.Now;
            veiculos.Add(entrada);
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");
            string placa = Console.ReadLine()!;

            if (veiculos.Any(x => x.Placa!.ToUpper() == placa.ToUpper()))
            {
                Entrada entrada = new Entrada();
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                string qtdHoras = Console.ReadLine()!;
                int.TryParse(qtdHoras, out int x);
                Entrada removerVeiculo = veiculos.Find(entrada => entrada.Placa == placa)!;
                decimal valorTotal = precoInicial + x * precoPorHora;
                try
                {
                    veiculos.Remove(removerVeiculo);
                }
                catch (Exception erro)
                {
                    Console.WriteLine(erro.Message);
                }
                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }
        public void ListarVeiculos()
        {
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                foreach (var item in veiculos)
                {
                    Console.WriteLine($"Veículo {item.Placa} entrou às {item.Hora.ToString("HH")}H{item.Hora.ToString("mm")}m.");
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
