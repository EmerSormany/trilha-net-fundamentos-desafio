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
            Entrada entrada = new Entrada();
            Entrada removerVeiculo = veiculos.Find(entrada => entrada.Placa == placa)!;
            if (removerVeiculo != null)
            {
                DateTime saida = DateTime.Now;
                TimeSpan tempoPassado = saida.Subtract(removerVeiculo.Hora);
                int x = tempoPassado.Minutes;
                decimal valorTotal = precoInicial + x * (precoPorHora/60);
                try
                {
                    veiculos.Remove(removerVeiculo);
                }
                catch (Exception)
                {
                    Console.WriteLine("Ocorreu erro no remoção do vaículo");
                }
                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
            }else
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
