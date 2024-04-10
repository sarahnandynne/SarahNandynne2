namespace JogoSarah;
public class Personagens
{
  protected double fome;
  protected double tristeza;
  protected double sede;

  protected string arquivo;
  protected string arquivomorto;
  protected bool morto;
    
  public Personagens()
  {
    fome=0.5;
    tristeza=1;
    sede=0.7;
  }

  public string GetArquivo()
  {
    if (morto)
      return arquivomorto;
    else 
      return arquivo;
  }

  public bool GetMorto()
  {
    return morto;
  }
    

  public double GetSede()
  {
    return sede;
  }

public double GetTristeza()
  {
    return tristeza;
  }
  public double GetFome()
  {
    return fome;
  }

  public void SetSede( double s)
  {
    if (s > 1)
      sede = 1;
    else if (s <= 0)
    {
      sede = 0;
    }
    else
      sede = s;
    
    if (sede <= 0.1)
    morto = true;

  }

public void SetTristeza(double t)
  {
    if (t>1)
    tristeza = 1;
    else if (t<=0)
    {
      tristeza = 0;
    }
    else
    tristeza = t;

    if (sede <= 0.1)
    morto = true;
  }
  public void SetFome( double f)
  {
    if (f>1)
    fome = 1;
    else if (f<=0)
    {
      fome = 0;
    }
    else
    fome = f;
    if (sede <= 0.1)
    morto = true;
  }
}