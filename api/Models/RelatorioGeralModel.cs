namespace DesafioTecnicoC.Models;

/// <summary>
/// Modelo de domínio que representa a consolidação dos dados financeiros globais do sistema.
/// Utilizado para mapear o resultado de consultas agregadas do banco de dados.
/// </summary>
public record RelatorioGeralModel
{
    /// <summary>
    /// Somatório bruto de todas as receitas (entradas) registradas no banco de dados.
    /// </summary>
    public decimal TotalGeralReceitas { get; init; }

    /// <summary>
    /// Somatório bruto de todas as despesas (saídas) registradas no banco de dados.
    /// </summary>
    public decimal TotalGeralDespesas { get; init; }

    /// <summary>
    /// Balanço líquido geral do sistema, calculado subtraindo as despesas das receitas.
    /// </summary>
    public decimal SaldoLiquidoGeral { get; init; }
}
