namespace DesafioTecnicoC.Models;

/// <summary>
/// Modelo de domínio que representa o agrupamento financeiro individual consolidado por pessoa.
/// Utilizado para mapear o retorno de queries com junções (JOIN) e agregações no banco de dados.
/// </summary>
public record RelatorioIndividualModel
{
    /// <summary>
    /// Identificador único da pessoa associada ao registro.
    /// </summary>
    public int Id { get; init; }

    /// <summary>
    /// Nome da pessoa associada ao registro.
    /// </summary>
    public string Nome { get; init; } = string.Empty;

    /// <summary>
    /// Somatório das transações de entrada (CREDITO) vinculadas a esta pessoa.
    /// </summary>
    public decimal TotalReceitas { get; init; }

    /// <summary>
    /// Somatório das transações de saída (DEBITO) vinculadas a esta pessoa.
    /// </summary>
    public decimal TotalDespesas { get; init; }

    /// <summary>
    /// Balanço financeiro individual líquido (TotalReceitas menos TotalDespesas).
    /// </summary>
    public decimal Saldo { get; init; }
}
