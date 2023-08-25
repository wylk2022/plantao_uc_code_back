﻿using System.Runtime.ExceptionServices;
using Plantao_UC_COD_BACK.Classes;

string? opcao = "";
PessoaJuridica PJ = new PessoaJuridica();

do
{
    Console.WriteLine(@"
    
    1 - Cadastrar
    2 - Sair
    
    ");

    opcao = Console.ReadLine();

    if (opcao == "1")
    {
        PessoaJuridica pj = new PessoaJuridica();
        Console.WriteLine("Digite o nome da Pessoa Juridica");
        pj.Nome = Console.ReadLine();

        Console.WriteLine("Digite o rendimento da Pessoa Juridica");
        if (float.TryParse(Console.ReadLine(), out float rendimento))
{
    pj.Rendimento = rendimento;
}
else
{
    Console.WriteLine("Valor de rendimento inválido. O valor será definido como 0.");
    pj.Rendimento = 0;
}

        Console.WriteLine("Digite o cnpj da Pessoa Juridica");
        pj.Cnpj = Console.ReadLine();

        PJ.Inserir(pj);
    }
} while (opcao != "2");
