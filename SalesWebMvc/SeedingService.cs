using SalesWebMvc.Data;
using SalesWebMvc.Models;
using System;
using System.Linq;

public class SeedingService
{
    private readonly SalesWebMvcContext _context;

    public SeedingService(SalesWebMvcContext context)
    {
        _context = context;
    }

    public void Seed()
    {
        // Verifica se já existem dados
        if (_context.Department.Any())
        {
            return; // O banco de dados já foi populado
        }

        // Criação de dados de exemplo
        var exampleData = new[]
        {
            new Department { Id = 1, Name = "Value2" },
            new Department { Id = 2, Name = "Value4" },
            // Adicione mais entidades conforme necessário
        };

        // Adiciona os dados ao contexto
        _context.Department.AddRange(exampleData);

        // Salva as alterações no banco de dados
        _context.SaveChanges();
    }
}
