using Builder.Models;

namespace Builders
{
  public abstract class CriadorSoldado
  {
    protected Soldado _soldado;

    public Soldado GetSoldado()
    {
      return _soldado;
    }

    public abstract void Arma();
    public abstract void Transporte();
    public abstract void Foco();
  }
}