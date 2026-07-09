namespace DesafioTecnicoC.Models;

/// <summary>
/// Modelo de domínio que representa uma movimentação financeira no banco de dados.
/// Vincula uma descrição, valor e tipo (Crédito/Débito) a uma pessoa específica.
/// </summary>
public record TransacaoModel
{
    /// <summary>
    /// Chave primária única e auto-incremental gerada pelo banco de dados.
    /// </summary>
    public int Id { get; init; }

    /// <summary>
    /// Descrição textual ou justificativa do lançamento financeiro.
    /// </summary>
    public string Descricao { get; init; } = string.Empty;

    /// <summary>
    /// Quantia monetária da transação. Armazenada como decimal para preservar a precisão de centavos.
    /// </summary>
    public decimal Valor { get; init; }

    /// <summary>
    /// Tipo da movimentação financeira, mapeado através do enum correspondente (CREDITO ou DEBITO).
    /// </summary>
    public TipoTransacaoEnum Tipo { get; init; }

    /// <summary>
    /// Chave estrangeira (FK) que estabelece o vínculo com a tabela de Pessoas.
    /// </summary>
    public int Id_Pessoa { get; init; }
}

/// <summary>
/// Define os tipos estritos de natureza financeira permitidos para uma transação.
/// </summary>
public enum TipoTransacaoEnum
{
    /// <summary>
    /// Entrada financeira ou receita. Incrementa o saldo individual.
    /// </summary>
    CREDITO,

    /// <summary>
    /// Saída financeira ou despesa. Decrementa o saldo individual.
    /// </summary>
    DEBITO,
}
