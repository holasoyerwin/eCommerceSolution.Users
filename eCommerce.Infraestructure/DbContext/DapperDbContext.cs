﻿using Npgsql;
using System.Data;
using Microsoft.Extensions.Configuration;

namespace eCommerce.Infraestructure.DbContext
{
    public class DapperDbContext
    {
        private readonly IConfiguration _configuration;
        private readonly IDbConnection _connection;

        public DapperDbContext(IConfiguration configuration)
        {
            _configuration = configuration;
            string? connectionString = _configuration.GetConnectionString("DefaultConnection");

            //Create a new NpgsqlConnection with the retrieved connection string
            _connection = new NpgsqlConnection(connectionString);
        }


        public IDbConnection DbConnection => _connection;
    }
}
