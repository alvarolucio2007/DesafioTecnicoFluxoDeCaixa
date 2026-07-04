using System.Data;
using Microsoft.Data.Sqlite;
using Dapper;

using DesafioTecnicoC.Models;

namespace DesafioTecnicoC.Repositories;

public class TransacaoRepository
{

    private readonly string _connectionString;
    public TransacaoRepository(string connectionString)
    {
        _connectionString = connectionString;
    }
}
