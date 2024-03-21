using TrabalhoTabuada;

var ClasseTrabalho = new ClasseTrabalho();
bool continua = true;
do
{
    try
    {
        Console.WriteLine("\nPressione 0 para sair \nPressione 1 para somar números \nPressione 2 para converter medida ( Metros x Milímetros) \nPressione 3 para exibir as tabuadas do 1 ao 10\nPressione 4 para realizar tabuada de valor único");
        int escolha = int.Parse(Console.ReadLine());
        switch (escolha)
        {
            case 0:
                Console.WriteLine("Você saiu!");
                continua = false;
                break;

            case 1:
                Console.WriteLine("Escolha dois números para somar: ");
                float num1 = float.Parse(Console.ReadLine());
                float num2 = float.Parse(Console.ReadLine());

                Console.WriteLine($"O resultado da soma é : {ClasseTrabalho.SomarDoisNumeros(num1, num2)}");
                break;

            case 2:
                Console.WriteLine("Insira o valor em Metros que você deseja converter para milimetros: ");
                float metros = float.Parse(Console.ReadLine());

                Console.WriteLine($"{metros} metros equivalem a {ClasseTrabalho.Conversor(metros)} milimetros");
                break;

            case 3:
                Console.WriteLine(ClasseTrabalho.Tabuada());
                break;

            case 4:
                Console.WriteLine("Escolha o número que deseja saber a tabuada");
                float num = float.Parse(Console.ReadLine());
                Console.WriteLine(ClasseTrabalho.Tabuada(num));
                break;

            default:
                Console.WriteLine("Valor não aceito");
                break;
        }
    }
    catch (FormatException)
    {
        Console.WriteLine("Formato Inválido. Digite apenas números de 0 a 4");
    }

}
while (continua == true);
