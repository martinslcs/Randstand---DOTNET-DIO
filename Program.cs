﻿using System;

namespace TrainCsharp.Models
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Aqui você pode instanciar o objeto Pessoa
            Pessoa p = new Pessoa();
            p.Nome = "João";
            p.Idade = 30;

            // Chamando o método Apresentar
            p.Apresentar();
        }
    }
}