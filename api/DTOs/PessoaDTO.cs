namespace DesafioTecnicoC.DTOs;

/// <summary>
/// Objeto de transferência de dados utilizado para o cadastro de novas pessoas.
/// </summary>
/// <param name="Nome">Nome completo ou identificação da pessoa. Mínimo de 1 caractere.</param>
/// <param name="Idade">Idade da pessoa. Deve estar no intervalo entre 0 e 120 anos.</param>
public record CriarPessoaDto(string Nome, int Idade);

/// <summary>
/// Objeto de transferência de dados utilizado para retornar as informações de uma pessoa cadastrada.
/// </summary>
/// <param name="Id">Identificador único da pessoa gerado automaticamente pelo banco de dados.</param>
/// <param name="Nome">Nome da pessoa cadastrada.</param>
/// <param name="Idade">Idade atual da pessoa.</param>
public record PessoaRespostaDto(int Id, string Nome, int Idade);

/// <summary>
/// Objeto de transferência de dados utilizado para a atualização dos dados de uma pessoa existente.
/// </summary>
/// <param name="Nome">Novo nome a ser atribuído à pessoa.</param>
/// <param name="Idade">Nova idade a ser atribuída à pessoa. Deve estar no intervalo entre 0 e 120 anos.</param>
public record AtualizarPessoaDto(string Nome, int Idade);
