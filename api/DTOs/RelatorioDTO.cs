namespace DesafioTecnicoC.DTOs;

/// <summary>
/// Objeto de transferência de dados que representa o resumo financeiro individual consolidado por pessoa.
/// </summary>
/// <param name="Id">Identificador único da pessoa associada ao relatório.</param>
/// <param name="Nome">Nome da pessoa associada ao relatório.</param>
/// <param name="TotalReceitas">Soma total de todas as transações do tipo CREDITO vinculadas a esta pessoa.</param>
/// <param name="TotalDespesas">Soma total de todas as transações do tipo DEBITO vinculadas a esta pessoa.</param>
/// <param name="Saldo">Saldo líquido individual (TotalReceitas menos TotalDespesas).</param>
public record RelatorioIndividualResponseDto(
    int Id,
    string Nome,
    decimal TotalReceitas,
    decimal TotalDespesas,
    decimal Saldo
);

/// <summary>
/// Objeto de transferência de dados que representa a consolidação financeira global do sistema.
/// </summary>
/// <param name="TotalReceitas">Soma de todas as receitas (CREDITO) registradas no sistema globalmente.</param>
/// <param name="TotalDespesas">Soma de todas as despesas (DEBITO) registradas no sistema globalmente.</param>
/// <param name="SaldoGeral">Saldo líquido geral acumulado de todas as contas (TotalReceitas menos TotalDespesas).</param>
public record RelatorioGeralResponseDto(
    decimal TotalReceitas,
    decimal TotalDespesas,
    decimal SaldoGeral
);
