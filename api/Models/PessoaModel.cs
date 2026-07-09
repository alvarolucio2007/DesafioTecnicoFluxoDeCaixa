namespace DesafioTecnicoC.Models;

/// <summary>
/// Modelo de domínio que representa a entidade Pessoa no banco de dados.
/// Os dados são estruturados como record imutável após a inicialização.
/// </summary>
public record PessoaModel
{
    /// <summary>
    /// Chave primária única e auto-incremental gerada pelo banco de dados.
    /// </summary>
    public int Id { get; init; }

    /// <summary>
    /// Nome completo ou identificação da pessoa.
    /// </summary>
    public string Nome { get; init; } = string.Empty;

    /// <summary>
    /// Idade da pessoa em anos.
    /// </summary>
    public int Idade { get; init; }
}
