using Builder.Models;

namespace Builders
{
  public class CriadorInfantariaLeve : CriadorSoldado
  {

    public CriadorInfantariaLeve()
    {
      _soldado = new SoldadoInfantariaLeve();
    }
    public override void Arma()
    {
      _soldado.EscolherArma("Ataque áereo");
    }

    public override void Foco()
    {
      _soldado.EscolherFoco("Resposta rápida áerea");
    }

    public override void Transporte()
    {
      _soldado.EscolherTransporte("Helicóptero do exército");
    }
  }
}