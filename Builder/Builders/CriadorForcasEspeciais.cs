using Builder.Models;

namespace Builders
{
  public class CriadorForcasEspeciais : CriadorSoldado
  {
    public CriadorForcasEspeciais()
    {
      _soldado = new SoldadoForcasEspeciais();
    }
    public override void Arma()
    {
      _soldado.EscolherArma("Fuzil");
    }

    public override void Foco()
    {
      _soldado.EscolherFoco("Carro de operações especiais");
    }

    public override void Transporte()
    {
      _soldado.EscolherTransporte("Combate em solo");
    }
  }
}