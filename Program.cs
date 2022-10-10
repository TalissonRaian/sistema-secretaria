using secretaria_plataforma.Models;

Console.WriteLine("||Secretaria Online||");

Console.WriteLine("Seja bem vindo! \nEscolha uma das opções: \nPress Enter para continuar!");

Console.ReadLine();

Secretaria se = new Secretaria();
bool exibirMenu = true;;
while (exibirMenu)
{
    Console.Clear();
    Console.WriteLine("||=========================||");
    Console.WriteLine("1 - Realizar Matricula");
    Console.WriteLine("2 - Lista de Matriculados");
    Console.WriteLine("3 - Trancar Matricula");
    Console.WriteLine("4 - Encerrar");
    Console.WriteLine("||=========================||");
    switch (Console.ReadLine())
    {
        case "1":
        se.MatriculaAluno();
        break;

        case "2":
        se.AlunoMatriculados();
        break;

        case "3":
        se.TrancarMatricula();
        break;

         case "4":
        exibirMenu = false;
        break;

        default:
        Console.WriteLine("Opção invalida!");
        break;
    }

    Console.WriteLine("Pressione enter para continuar");
    
    Console.ReadLine();
}
Console.WriteLine("O programa se encerrou");