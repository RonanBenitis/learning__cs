using Desafio.model;

ContaBancaria conta1 = new("123", "Jorge Benjor", 123123123, "Aaaahey123");
conta1.ExibirInformacoes();

Carro carro1 = new("Wolskvagen", "Gol");
carro1.Ano = 2024;
carro1.Acelerar();
carro1.Frear();
carro1.Buzinar();
Console.WriteLine(carro1.DescricaoDetalhada);
// FALTOU FAZER A CLASSE PRODUTO