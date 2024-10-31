namespace Algs;

public static class Methods
{
    public static int Factorial(int num)
    {
        if (num == 0)
        {
            return 1;
        }
        
        int temp = 1;
        for (int i = 1; i <= num; i++)
        {
            temp *= i;
        }
        return temp;
    }

    public static int Combination(int elements, int positions)
    {
        if (positions < 0)
        {
            Console.WriteLine("Erro, o número de posições não pode ser menor que zero");
            return 0;
        }

        if (positions > elements)
        {
            Console.WriteLine("Erro, o número de posições não pode ser maior que o número de elementos");
        }

        if (positions == 0 || elements == 0)
        {
            return 1;
        }

        if (positions == elements)
        {
            return 1;
        }

        int combination = Factorial(elements) / (Factorial(positions) * Factorial(elements - positions));
        return combination;
    }
    
    public static void Ppyramid(int rows)
    {
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j <= i; j++)
            {
                int tempCombination = Combination(i,j);
                Console.Write($"{tempCombination} ");
            }
            Console.Write("\n");
        }
    }
    
    
}