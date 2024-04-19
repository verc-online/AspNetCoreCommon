using System.Data;
using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace DataLibrary.Db;

public class SqlDb : IDataAccess
{
    private readonly IConfiguration _configuration;

    public SqlDb(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public async Task<List<T>> LoadData<T, U>(string storedProcedure, U parameters, string connectionStringName)
    {
        string connectionString = _configuration.GetConnectionString(connectionStringName);

        using (IDbConnection connection = new SqlConnection(connectionString))
        {
            var rows = await connection.QueryAsync<T>(
                storedProcedure,
                parameters,
                commandType: CommandType.StoredProcedure);

            return rows.ToList();
        }
    }

    public async Task<int> SaveData<T>(string storedProcedure, T parameters, string connectionStringName)
    {
        string connectionString = _configuration.GetConnectionString(connectionStringName);

        using (IDbConnection connection = new SqlConnection(connectionString))
        {
            return await connection.ExecuteAsync(
                storedProcedure,
                parameters,
                commandType: CommandType.StoredProcedure);
        }
    }
}