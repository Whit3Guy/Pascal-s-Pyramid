namespace Algs;

public static class Methods
{
    /* Uma função que implementa o funcionamento de Fatorial
     *
     * A função recebe o número e calcula o fatorial dele
     * E claro, conta que o Fatorial de 0 (0!) é igual a 1
     */
    
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

    /* Uma função que implementa a Combinação
     *
     * Usa a clássica formula:
     *
     *  C(a,b) = a!/b!(a - b)!
     *
     *  não aceita números negativos em elementos e nem em posições
     * 
     */
    
    public static int Combination(int elements, int positions)
    {
        if (positions < 0 || elements < 0)
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
    /*
     * Gera a piramide de Pascal
     */
    public static void Ppyramid(int rows)
    { 
        /* Tendo em vista a formula
         *
         * C(a,b) = a!/b!(a-b)!
         *
         */
        // Cada i representa uma linha da pirâmide (Ou um elemento da combinação [O "a" da fórmula])
        for (int i = 0; i < rows; i++)
        {
            //Cada j representa uma coluna da pirâmide (ou o número de posições da combinação[O "b" da fórmula])
            for (int j = 0; j <= i; j++)
            {
                int tempCombination = Combination(i,j);
                Console.Write($"{tempCombination} ");
            }
            Console.Write("\n");
        }
    }
    
    
}