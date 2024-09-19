﻿using SalesWebMvc.Data;
using SalesWebMvc.Models;
using SalesWebMvc.Models.Enums;
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
        //var newsDepartments = new Department { Id = 1, Name = "Computers" };
        Department d1 = new Department {Name = "Computers" };
        Department d2 = new Department {Name = "Electronics" };
        Department d3 = new Department {Name = "Fashion" };
        Department d4 = new Department {Name = "Books" };
        Department d5 = new Department {Name = "Electronics" };

        Seller s1 = new Seller { Id = 1, Name = "Bob Brown", Email = "bob@gmail.com", BirthDate = new DateTime(1998, 4, 21), BaseSalary = 1000.0, Department = d1 };
        Seller s2 = new Seller { Id = 2, Name = "Ana", Email = "ana@gmail.com", BirthDate = new DateTime(1998, 6, 10), BaseSalary = 1000.0, Department = d2 };
        Seller s3 = new Seller { Id = 3, Name = "Maria", Email = "maria@gmail.com", BirthDate = new DateTime(2000, 11, 5), BaseSalary = 1000.0, Department = d3 };
        Seller s4 = new Seller { Id = 4, Name = "Joao", Email = "joao@gmail.com", BirthDate = new DateTime(1985, 12, 23), BaseSalary = 1000.0, Department = d4 };
        Seller s5 = new Seller { Id = 5, Name = "Jose", Email = "jose@gmail.com", BirthDate = new DateTime(1972, 5, 17), BaseSalary = 1000.0, Department = d5 };
        Seller s6 = new Seller { Id = 6, Name = "Claudia", Email = "clauda@gmail.com", BirthDate = new DateTime(2005, 2, 2), BaseSalary = 1000.0, Department = d1 };

        SalesRecord r1 = new SalesRecord { Id = 1, Date = new DateTime(2018, 09, 25), Amount = 11000.0, Status = SaleStatus.Billed, Seller = s1 };
        SalesRecord r2 = new SalesRecord { Id = 2, Date = new DateTime(2018, 09, 4), Amount = 7000.0, Status = SaleStatus.Billed, Seller = s5 };
        SalesRecord r3 = new SalesRecord { Id = 3, Date = new DateTime(2018, 09, 13), Amount = 4000.0, Status = SaleStatus.Canceled, Seller = s4 };
        SalesRecord r4 = new SalesRecord { Id = 4, Date = new DateTime(2018, 09, 1), Amount = 8000.0, Status = SaleStatus.Billed, Seller = s1 };
        SalesRecord r5 = new SalesRecord { Id = 5, Date = new DateTime(2018, 09, 21), Amount = 3000.0, Status = SaleStatus.Billed, Seller = s3 };
        SalesRecord r6 = new SalesRecord { Id = 6, Date = new DateTime(2018, 09, 15), Amount = 2000.0, Status = SaleStatus.Billed, Seller = s1 };
        SalesRecord r7 = new SalesRecord { Id = 7, Date = new DateTime(2018, 09, 28), Amount = 13000.0, Status = SaleStatus.Billed, Seller = s2 };
        SalesRecord r8 = new SalesRecord { Id = 8, Date = new DateTime(2018, 09, 11), Amount = 4000.0, Status = SaleStatus.Billed, Seller = s4 };
        SalesRecord r9 = new SalesRecord { Id = 9, Date = new DateTime(2018, 09, 14), Amount = 11000.0, Status = SaleStatus.Pending, Seller = s6 };
        SalesRecord r10 = new SalesRecord { Id = 10, Date = new DateTime(2018, 09, 7), Amount = 9000.0, Status = SaleStatus.Billed, Seller = s6 };
        SalesRecord r11 = new SalesRecord { Id = 11, Date = new DateTime(2018, 09, 13), Amount = 6000.0, Status = SaleStatus.Billed, Seller = s2 };
        SalesRecord r12 = new SalesRecord { Id = 12, Date = new DateTime(2018, 09, 25), Amount = 7000.0, Status = SaleStatus.Pending, Seller = s3 };
        SalesRecord r13 = new SalesRecord { Id = 13, Date = new DateTime(2018, 09, 29), Amount = 10000.0, Status = SaleStatus.Billed, Seller = s4 };
        SalesRecord r14 = new SalesRecord { Id = 14, Date = new DateTime(2018, 09, 4), Amount = 3000.0, Status = SaleStatus.Billed, Seller = s5 };
        SalesRecord r15 = new SalesRecord { Id = 15, Date = new DateTime(2018, 09, 12), Amount = 4000.0, Status = SaleStatus.Billed, Seller = s1 };
        SalesRecord r16 = new SalesRecord { Id = 16, Date = new DateTime(2018, 10, 5), Amount = 2000.0, Status = SaleStatus.Billed, Seller = s4 };
        SalesRecord r17 = new SalesRecord { Id = 17, Date = new DateTime(2018, 10, 1), Amount = 12000.0, Status = SaleStatus.Billed, Seller = s1 };
        SalesRecord r18 = new SalesRecord { Id = 18, Date = new DateTime(2018, 10, 24), Amount = 6000.0, Status = SaleStatus.Billed, Seller = s3 };
        SalesRecord r19 = new SalesRecord { Id = 19, Date = new DateTime(2018, 10, 22), Amount = 8000.0, Status = SaleStatus.Billed, Seller = s5 };
        SalesRecord r20 = new SalesRecord { Id = 20, Date = new DateTime(2018, 10, 15), Amount = 8000.0, Status = SaleStatus.Billed, Seller = s6 };
        SalesRecord r21 = new SalesRecord { Id = 21, Date = new DateTime(2018, 10, 17), Amount = 9000.0, Status = SaleStatus.Billed, Seller = s2 };
        SalesRecord r22 = new SalesRecord { Id = 22, Date = new DateTime(2018, 10, 24), Amount = 4000.0, Status = SaleStatus.Billed, Seller = s4 };
        SalesRecord r23 = new SalesRecord { Id = 23, Date = new DateTime(2018, 10, 19), Amount = 11000.0, Status = SaleStatus.Canceled, Seller = s2 };
        SalesRecord r24 = new SalesRecord { Id = 24, Date = new DateTime(2018, 10, 12), Amount = 8000.0, Status = SaleStatus.Billed, Seller = s5 };
        SalesRecord r25 = new SalesRecord { Id = 25, Date = new DateTime(2018, 10, 31), Amount = 7000.0, Status = SaleStatus.Billed, Seller = s3 };
        SalesRecord r26 = new SalesRecord { Id = 26, Date = new DateTime(2018, 10, 6), Amount = 5000.0, Status = SaleStatus.Billed, Seller = s4 };
        SalesRecord r27 = new SalesRecord { Id = 27, Date = new DateTime(2018, 10, 13), Amount = 9000.0, Status = SaleStatus.Pending, Seller = s1 };
        SalesRecord r28 = new SalesRecord { Id = 28, Date = new DateTime(2018, 10, 7), Amount = 4000.0, Status = SaleStatus.Billed, Seller = s3 };
        SalesRecord r29 = new SalesRecord { Id = 29, Date = new DateTime(2018, 10, 23), Amount = 12000.0, Status = SaleStatus.Billed, Seller = s5 };
        SalesRecord r30 = new SalesRecord { Id = 30, Date = new DateTime(2018, 10, 12), Amount = 5000.0, Status = SaleStatus.Billed, Seller = s2 };


        _context.Department.AddRange(d1, d2, d3, d4);
        _context.Seller.AddRange(s1, s2, s3, s4, s5, s6);
        _context.SalesRecord.AddRange(
            r1, r2, r3, r4, r5, r6, r7, r8, r9, r10,
            r11, r12, r13, r14, r15, r16, r17, r18, r19, r20,
            r21, r22, r23, r24, r25, r26, r27, r28, r29, r30
        );
        // Salva as alterações no banco de dados
        _context.SaveChanges();
    }

        // Adiciona os dados ao contexto
    
}


//using SalesWebMvc.Models;
//using SalesWebMvc.Models.Enums;
//namespace SalesWebMvc.Data
//{
//    public class SeedingService
//    {
//        private SalesWebMvcContext _context;
//        public SeedingService(SalesWebMvcContext context)
//        {
//            _context = context;
//        }

//        public void Seed()
//        {
//            if (_context.Department.Any() || _context.Seller.Any() || _context.SalesRecord.Any()) // Verificando se possui algum dado na base de dados
//            {
//                return; // O banco de dados já foi populado
//            }

//            Department d1 = new Department { Id = 1, Name = "Computers" };
//            Department d2 = new Department { Id = 2, Name = "Electronics" };
//            Department d3 = new Department { Id = 3, Name = "Fashion" };
//            Department d4 = new Department { Id = 4, Name = "Books" };
//            Department d5 = new Department { Id = 5, Name = "Electronics" };

//            Seller s1 = new Seller(1, "Bob Brown", "bob@gmail.com", new DateTime(1998, 4, 21), 1000.0, d1);
//            Seller s2 = new Seller(1, "Ana", "ana@gmail.com", new DateTime(1998, 6, 10), 1000.0, d2);
//            Seller s3 = new Seller(1, "Maria", "maria@gmail.com", new DateTime(2000, 11, 5), 1000.0, d3);
//            Seller s4 = new Seller(1, "Joao", "joao@gmail.com", new DateTime(1985, 12, 23), 1000.0, d4);
//            Seller s5 = new Seller(1, "Jose", "jose@gmail.com", new DateTime(1972, 5, 17), 1000.0, d5);
//            Seller s6 = new Seller(1, "Claudia", "clauda@gmail.com", new DateTime(2005, 2, 2), 1000.0, d1);

//            SalesRecord r1 = new SalesRecord(1, new DateTime(2018, 09, 25), 11000.0, SaleStatus.Billed, s1);
//            SalesRecord r2 = new SalesRecord(2, new DateTime(2018, 09, 4), 7000.0, SaleStatus.Billed, s5);
//            SalesRecord r3 = new SalesRecord(3, new DateTime(2018, 09, 13), 4000.0, SaleStatus.Canceled, s4);
//            SalesRecord r4 = new SalesRecord(4, new DateTime(2018, 09, 1), 8000.0, SaleStatus.Billed, s1);
//            SalesRecord r5 = new SalesRecord(5, new DateTime(2018, 09, 21), 3000.0, SaleStatus.Billed, s3);
//            SalesRecord r6 = new SalesRecord(6, new DateTime(2018, 09, 15), 2000.0, SaleStatus.Billed, s1);
//            SalesRecord r7 = new SalesRecord(7, new DateTime(2018, 09, 28), 13000.0, SaleStatus.Billed, s2);
//            SalesRecord r8 = new SalesRecord(8, new DateTime(2018, 09, 11), 4000.0, SaleStatus.Billed, s4);
//            SalesRecord r9 = new SalesRecord(9, new DateTime(2018, 09, 14), 11000.0, SaleStatus.Pending, s6);
//            SalesRecord r10 = new SalesRecord(10, new DateTime(2018, 09, 7), 9000.0, SaleStatus.Billed, s6);
//            SalesRecord r11 = new SalesRecord(11, new DateTime(2018, 09, 13), 6000.0, SaleStatus.Billed, s2);
//            SalesRecord r12 = new SalesRecord(12, new DateTime(2018, 09, 25), 7000.0, SaleStatus.Pending, s3);
//            SalesRecord r13 = new SalesRecord(13, new DateTime(2018, 09, 29), 10000.0, SaleStatus.Billed, s4);
//            SalesRecord r14 = new SalesRecord(14, new DateTime(2018, 09, 4), 3000.0, SaleStatus.Billed, s5);
//            SalesRecord r15 = new SalesRecord(15, new DateTime(2018, 09, 12), 4000.0, SaleStatus.Billed, s1);
//            SalesRecord r16 = new SalesRecord(16, new DateTime(2018, 10, 5), 2000.0, SaleStatus.Billed, s4);
//            SalesRecord r17 = new SalesRecord(17, new DateTime(2018, 10, 1), 12000.0, SaleStatus.Billed, s1);
//            SalesRecord r18 = new SalesRecord(18, new DateTime(2018, 10, 24), 6000.0, SaleStatus.Billed, s3);
//            SalesRecord r19 = new SalesRecord(19, new DateTime(2018, 10, 22), 8000.0, SaleStatus.Billed, s5);
//            SalesRecord r20 = new SalesRecord(20, new DateTime(2018, 10, 15), 8000.0, SaleStatus.Billed, s6);
//            SalesRecord r21 = new SalesRecord(21, new DateTime(2018, 10, 17), 9000.0, SaleStatus.Billed, s2);
//            SalesRecord r22 = new SalesRecord(22, new DateTime(2018, 10, 24), 4000.0, SaleStatus.Billed, s4);
//            SalesRecord r23 = new SalesRecord(23, new DateTime(2018, 10, 19), 11000.0, SaleStatus.Canceled, s2);
//            SalesRecord r24 = new SalesRecord(24, new DateTime(2018, 10, 12), 8000.0, SaleStatus.Billed, s5);
//            SalesRecord r25 = new SalesRecord(25, new DateTime(2018, 10, 31), 7000.0, SaleStatus.Billed, s3);
//            SalesRecord r26 = new SalesRecord(26, new DateTime(2018, 10, 6), 5000.0, SaleStatus.Billed, s4);
//            SalesRecord r27 = new SalesRecord(27, new DateTime(2018, 10, 13), 9000.0, SaleStatus.Pending, s1);
//            SalesRecord r28 = new SalesRecord(28, new DateTime(2018, 10, 7), 4000.0, SaleStatus.Billed, s3);
//            SalesRecord r29 = new SalesRecord(29, new DateTime(2018, 10, 23), 12000.0, SaleStatus.Billed, s5);
//            SalesRecord r30 = new SalesRecord(30, new DateTime(2018, 10, 12), 5000.0, SaleStatus.Billed, s2);

//            _context.Department.AddRange(d1, d2, d3, d4);
//            _context.Seller.AddRange(s1, s2, s3, s4, s5, s6);
//            _context.SalesRecord.AddRange(
//                r1, r2, r3, r4, r5, r6, r7, r8, r9, r10,
//                r11, r12, r13, r14, r15, r16, r17, r18, r19, r20,
//                r21, r22, r23, r24, r25, r26, r27, r28, r29, r30
//            );

//            _context.SaveChanges();
//        }
//    }
//}
