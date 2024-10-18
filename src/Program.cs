using Maskify.Core;

namespace exemplo_usando_maskify;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("| ------------------------------------------------------------");
        Exemplo1();
        Console.WriteLine("| ------------------------------------------------------------");
        Exemplo2();
        Console.WriteLine("| ------------------------------------------------------------");
        Exemplo3();
        Console.WriteLine("| ------------------------------------------------------------");
        Exemplo4();
        Console.WriteLine("| ------------------------------------------------------------");
        Exemplo5();
        Console.WriteLine("| ------------------------------------------------------------");
    }


    static void Exemplo1()
    {
        string dados = "1234 5678 1234 5678";
        string dadosMascarado = Masker.MaskCreditCard(dados);
        Console.WriteLine($"| Original: {dados}");
        Console.WriteLine($"| Mascarado: {dadosMascarado}");
    }

    static void Exemplo2()
    {
        string dados = "nome.sobrenome@servidor.com.br";
        string dadosMascarado = Masker.MaskEmail(dados);
        Console.WriteLine($"| Original: {dados}");
        Console.WriteLine($"| Mascarado: {dadosMascarado}");
    }
    
    static void Exemplo3()
    {        
        string dados = "123.456.789-00";
        string dadosMascarado = Masker.MaskCPF(dados);
        Console.WriteLine($"| Original: {dados}");
        Console.WriteLine($"| Mascarado: {dadosMascarado}");
    }
    
    static void Exemplo4()
    {
        string dados = "12.345.678/0001-00";
        string dadosMascarado = Masker.MaskCNPJ(dados);
        Console.WriteLine($"| Original: {dados}");
        Console.WriteLine($"| Mascarado: {dadosMascarado}");
    }

    static void Exemplo5()
    {
        string dados = "Meus dados são confidenciais";
        string dadosMascarado = Masker.Mask(dados, 5, 9, '#');
        Console.WriteLine($"| Original: {dados}");
        Console.WriteLine($"| Mascarado: {dadosMascarado}");
    }
}

