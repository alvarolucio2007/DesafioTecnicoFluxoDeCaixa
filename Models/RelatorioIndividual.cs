namespace DesafioTecnicoC.Models;
public record RelatorioIndividual{
  public int Id {get;init;}
  public string Nome {get;init;}=string.Empty;
  public float TotalReceitas {get;}
  public float TotalDespesas {get;}
  public float Saldo {get;}
}
