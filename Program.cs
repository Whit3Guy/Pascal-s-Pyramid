using Algs;

bool loop = true;

    ProgramDesign.Header();
while (loop)
{
    ProgramDesign.Options();    

string decision = Console.ReadLine();

switch(decision)
{
    case "1":
        Console.Clear();
        Console.WriteLine("Insira o número de linhas da pirâmide");
        int numbLines = int.Parse(Console.ReadLine());
        Methods.Ppyramid(numbLines);
        Console.WriteLine("Deseja prosseguir? (s/n) ");
        string otherDecision = Console.ReadLine();
        switch (otherDecision)
        {
            case "s":
                ProgramDesign.Header();
                break;
            case "n":
                loop = false;
                break;
            default:
                loop = false;
                break;
                }
        break;
    case "2":
        loop = false; 
        break;
    default:
        ProgramDesign.Header();
        break;
}
}


