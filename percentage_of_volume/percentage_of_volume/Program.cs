namespace percentage_of_volume;
class Program
{
    static void Main(string[] args)
    {
        decimal porcentagem = ColetaPorcentagem();
        int totalNegociado = ColetaTotalNegociado();
        Console.WriteLine($"A quantidade POV é {funcaoRetornaQuantitadePOV(porcentagem, totalNegociado)}");
    }

    public static int funcaoRetornaQuantitadePOV(decimal porcentagem, int totalNegociado)
        => (int)(porcentagem * totalNegociado / (1 - porcentagem));

    public static decimal ColetaPorcentagem()
    {
        decimal porcentagem;
        Console.WriteLine("Entre com uma porcentagem, como número decimal entre 0 e 1: ");
        while (!decimal.TryParse(Console.ReadLine(), out porcentagem) || porcentagem < 0 || porcentagem > 1)
        {
            Console.WriteLine("Porcentagem inválida, entre com um número decimal entre 0 e 1: ");
        }
        return porcentagem;
    }

    public static int ColetaTotalNegociado()
    {
        int totalNegociado;
        Console.WriteLine("Entre com o total negociado, como um inteiro maior ou igual a 0: ");
        while (!int.TryParse(Console.ReadLine(), out totalNegociado) || totalNegociado < 0)
        {
            Console.WriteLine("Total negociado inválido! Entre com um número inteiro maior ou igual a zero ");
        }
        return totalNegociado;
    }

}

