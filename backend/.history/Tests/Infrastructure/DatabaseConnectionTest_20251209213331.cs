using Xunit;
using FluentAssertions;
using Npgsql;
using DotNetEnv;

namespace Tests.Infrastructure
{
    public class DatabaseConnectionTest
    {
        private readonly string? _connectionString;

        [Fact]
        public void LoadConnectionStringTest()
        {
            // Given
            Env.Load("../../../.env");
            var config = new DatabaseConfig
            {
                _connectionString = Environment.GetEnvironmentVariable("CONNECTION_STRING") ?? throw new Exception("CONNECTION_STRING not found")
            };
        
            // When

        
            // Then
            Assert.False(string.IsNullOrEmpty(config._connectionString));
        }

        [Fact]
        public async Task ShouldConnectToDB()
        {
            // Given
            var _connectionString = Environment.GetEnvironmentVariable("CONNECTION_STRING");
            await using var connection = new NpgsqlConnection(_connectionString);
            Exception? error = null;

            // When
            try
            {
                await connection.OpenAsync();
            }
            catch(Exception ex)
            {
                error = ex;
            }
        
            // Then
            Assert.Null(error);
            Assert.Equal(System.Data.ConnectionState.Open, connection.State);
        }
    }
}