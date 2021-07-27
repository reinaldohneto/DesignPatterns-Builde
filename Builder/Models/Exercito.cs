using Builders;

namespace Builder.Models
{
  public class Exercito
  {
    public void ConstruirSoldado(CriadorSoldado criadorSoldado)
    {
      criadorSoldado.Arma();
      criadorSoldado.Foco();
      criadorSoldado.Transporte();
    }
  }
}