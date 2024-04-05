namespace JogoSarah;
public class Personagens
{
  protected double fome;
  protected double tristeza;
  protected double sede;

  protected string arquivo;
    
  public Personagens()
  {
    fome=0.5;
    tristeza=1;
    sede=0.7;
  }

  public string GetArquivo()
  {
    return arquivo;
  }

  public double GetSede()
  {
    return sede;
  }

}