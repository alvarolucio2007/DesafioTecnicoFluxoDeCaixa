using DesafioTecnicoC.Models;

namespace DesafioTecnicoC.DTOs;

/// <summary>
/// Objeto de transferência de dados utilizado para o registro de novas transações financeiras.
/// </summary>
/// <param name="Descricao">Breve descrição do lançamento (ex: "Combustível", "Almoço").</param>
/// <param name="Valor">Quantia financeira da movimentação. Deve ser maior ou igual a zero.</param>
/// <param name="Tipo">Tipo da transação baseado no enum do sistema (CREDITO ou DEBITO).</param>
/// <param name="Id_Pessoa">Identificador único da pessoa associada ao lançamento.</param>
public record CriarTransacaoDTO(
    string Descricao,
    decimal Valor,
    TipoTransacaoEnum Tipo,
    int Id_Pessoa
);

/// <summary>
/// Objeto de transferência de dados utilizado para a modificação de uma transação existente.
/// </summary>
/// <param name="Id_Transacao">Identificador único da transação que será alterada.</param>
/// <param name="Descricao">Nova descrição para a transação.</param>
/// <param name="Valor">Novo valor monetário atribuído. Deve ser maior ou igual a zero.</param>
/// <param name="Tipo">Novo tipo da transação (CREDITO ou DEBITO).</param>
/// <param name="Id_Pessoa">Identificador único da pessoa que será associada (ou reatrelada) ao lançamento.</param>
public record AtualizarTransacaoDTO(
    int Id_Transacao,
    string Descricao,
    decimal Valor,
    TipoTransacaoEnum Tipo,
    int Id_Pessoa
);

/// <summary>
/// Objeto de transferência de dados utilizado para expor os detalhes de uma transação cadastrada.
/// </summary>
/// <param name="Id">Identificador único da transação gerado pelo banco de dados.</param>
/// <param name="Descricao">Descrição textual do lançamento.</param>
/// <param name="Valor">Quantia financeira movimentada.</param>
/// <param name="Tipo">Tipo da movimentação (CREDITO ou DEBITO).</param>
/// <param name="Id_Pessoa">Identificador único da pessoa proprietária desta transação.</param>
public record TransacaoRespostaDTO(
    int Id,
    string Descricao,
    decimal Valor,
    TipoTransacaoEnum Tipo,
    int Id_Pessoa
);
