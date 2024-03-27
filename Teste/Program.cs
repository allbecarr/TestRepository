class Program
{
    static void Main(string[] args)
    {
        int a = 6;
        int b = 3;
        int c = 0;
        c = (a - b) * 2;
        if (c >= 6)
            c = c + 3;
        Console.WriteLine("Resposta Exercício 1: " + c);

        int w = 0;
        int z = 10;
        while (z > 0) //4
        {
            w = w + 2; //4+2=6
            z = z - w; //4-6=-2
        }
        Console.WriteLine("Resposta Exercício 3: " + w);

        int q = 4;
        int r = 2;
        int e = 0;
        e = r + q / 2; //4/2=2+2=4
        Console.WriteLine("Resposta Exercício 5: " + e);
    }
}
