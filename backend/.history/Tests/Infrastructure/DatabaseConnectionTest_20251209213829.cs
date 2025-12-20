using Xunit;
using FluentAssertions;
using Npgsql;
using DotNetEnv;
using backend.src.Infrastructure.Config;

namespace Tests.Infrastructure
{
    public class DatabaseConnectionTest
    {
        private readonly string? _connectionString;

        public DatabaseConnectionTest()
        {
            // Load environment variables
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
            Env.Load("../../.env");
            var connString = Environment.GetEnvironmentVariable("CONNECTION_STRING");
            connString.Should().NotBeNullOrEmpty();

            await using var connection = new NpgsqlConnection(connString);
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
            error.Should().BeNull();
            connection.State.Should().Be(System.Data.ConnectionState.Open);
        }
    }
}
