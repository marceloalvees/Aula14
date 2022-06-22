namespace Aula13_Atividade
{
    
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Dictionary<int, Aluno> Alunos = new Dictionary<int, Aluno>();
            Curso curso = new Curso();


            string opcaoAdministracao = ListaMenu();

            while (opcaoAdministracao!="0") {
                switch (opcaoAdministracao)
                {
                    case "1": curso.Cadastrar();
                        break;
                    case "2":
                        curso.Remover();
                        break;
                    case "3":
                        curso.Atualizar();
                        break;
                    case "4":
                        curso.ApresentarTodos();
                        break;
                    default:
                        Console.WriteLine("Por favor, digite uma opção válida");
                        break;
                }
                opcaoAdministracao = ListaMenu();
            }

            string ListaMenu()
            {
                Console.WriteLine("Digite:" + Environment.NewLine +
                    "1 - Cadastrar" + Environment.NewLine +
                    "2 - Remover" + Environment.NewLine +
                    "3 - Atualizar cadastro" + Environment.NewLine +
                    "4 - Listar todos os inscritos" + Environment.NewLine +
                    "0 - Sair do programa");
                string opcao = Console.ReadLine()!;
                return opcao;
            }


        }

        
    }


}