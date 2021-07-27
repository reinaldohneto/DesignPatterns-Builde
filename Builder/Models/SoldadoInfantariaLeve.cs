namespace Builder.Models
{
  public class SoldadoInfantariaLeve : Soldado
  {
    public override void EscolherArma(string Arma)
    {
      this.Arma = Arma;
    }

    public override void EscolherFoco(string Foco)
    {
      this.Foco = Foco;
    }

    public override void EscolherTransporte(string Transporte)
    {
      this.Transporte = Transporte;
    }
  }
}