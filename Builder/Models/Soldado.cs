namespace Builder.Models
{
  public abstract class Soldado
  {
    public string Arma { get; protected set; }
    public string Transporte { get; protected set; }
    public string Foco { get; protected set; }

    public abstract void EscolherArma(string Arma);
    public abstract void EscolherTransporte(string Transporte);
    public abstract void EscolherFoco(string Foco);
  }
}