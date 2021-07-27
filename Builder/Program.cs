using System;
using Builder.Models;
using Builders;

namespace Builder
{
  class Program
  {
    static void Main(string[] args)
    {
      var exercito = new Exercito();

      CriadorSoldado criadorSoldado;
      Soldado soldado;

      criadorSoldado = new CriadorInfantariaLeve();

      exercito.ConstruirSoldado(criadorSoldado);
      soldado = criadorSoldado.GetSoldado();

      Console.WriteLine("Características do soldado {0}, {1}, {2}",
                        soldado.Arma, soldado.Foco, soldado.Transporte);

      criadorSoldado = new CriadorForcasEspeciais();
      exercito.ConstruirSoldado(criadorSoldado);
      soldado = criadorSoldado.GetSoldado();

      Console.WriteLine("Características do soldado {0}, {1}, {2}",
                        soldado.Arma, soldado.Foco, soldado.Transporte);


    }
  }
}
