using Xunit;
using FluentAssertions;
using Npgsql;
using DotNetEnv;
using backend.Src.Infrastructure.Config;

namespace Tests.Infrastructure
{
    public class DatabaseConnectionTest
    {
        private readonly string? _connectionString;

        public DatabaseConnectionTest()
        {
            // Load environment vars from root backend/.env
            Env.Load("../../../.env");

            _connectionString = Environment.GetEnvironmentVariable("CONNECTION_STRING");
        }

        [Fact]
        public void LoadConnectionString_ShouldLoadFromEnv()
        {
            // Arrange
            var config = new DatabaseConfig
            {
                ConnectionString = _connectionString ?? ""
            };

            // Assert
            config.ConnectionString.Should().NotBeNullOrEmpty();
        }

        [Fact]
        public async Task ShouldConnectToDB()
        {
            // Arrange
            _connectionString.Should().NotBeNullOrEmpty("because DB connection string must exist in .env");

            await using var connection = new NpgsqlConnection(_connectionString);
            Exception? error = null;

            // Act
            try
            {
                await connection.OpenAsync();
            }
            catch (Exception ex)
            {
                error = ex;
            }

            // Assert
            error.Should().BeNull("because the DB should accept connections");
            connection.State.Should().Be(System.Data.ConnectionState.Open);
        }
    }
}
