namespace DesafioTecnicoC.Models;
public record RelatorioIndividual{
  public int Id {get;init;}
  public string Nome {get;init;}=string.Empty;
  public decimal TotalReceitas {get;}
  public decimal TotalDespesas {get;}
  public decimal Saldo {get;}
}
