using System;
using System.Threading.Tasks;
using MySqlConnector;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Data.SqlTypes;
using System.Collections.Generic;

namespace DataManipulation
{
    //Objetivo do programa é manipular os dados e tabelas em um banco de dados
    internal class SQL
    {
        //Classe para manipulação de dados utilizando mySql server 8.0
        static async Task Main(string[] args)
        {
            var builder = new MySqlConnectionStringBuilder//Construtor para conexão
            {
                Server = "localhost",//ip do servidor da conexão
                Database = "DB",//Banco alvo da conexão
                UserID = "root",//usuário para acesso ao banco
                Password = "tatu9012",//senha de acesso ao banco
                SslMode = MySqlSslMode.Required,//Só permite a conexão se o servidor possuir o ssl habilitado
            };
            using (var conn = new MySqlConnection(builder.ConnectionString))
            {
                    Console.WriteLine($"Iniciando a conexão com o servidor de Banco {builder.Database}");
                    await conn.OpenAsync();
                    using( var command = conn.CreateCommand() )
                    {
                        for ( int i = 1; i < 10; i++) 
                        {
                        //Insere números de 0 á 10
                            command.CommandText = $"INSERT INTO numero VALUES ({i})";
                            await command.ExecuteNonQueryAsync();
                            Console.WriteLine("Inserindo números de 1 a 10 na tabela");

                        }
                        //Exclui tabela de números
                        command.CommandText = "DROP TABLE IF EXISTS numero";
                        await command.ExecuteNonQueryAsync();
                        Console.WriteLine("Excluindo a tabela de números(caso ela exista)");
                        //cria a mesma tabela novamente
                        command.CommandText = "CREATE TABLE `numero1` (\r\n  `num` int NOT NULL DEFAULT '0',\r\n  PRIMARY KEY (`num`)\r\n) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;\r\n";
                        await command.ExecuteNonQueryAsync();
                        Console.WriteLine("Criando tabela de números novamentte");
                    }
                    Console.WriteLine("Finalizando conexão com o banco");

                
            }
            Console.WriteLine("Pressione a tecla de RETORNO para sair.");
            Console.ReadLine();
        }
    }
}
