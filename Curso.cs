namespace Aula13_Atividade
{
    class Curso : Administracao
    {
        Dictionary<int, Aluno> Alunos = new Dictionary<int, Aluno>();
        override public void Cadastrar()
        {

            Console.WriteLine("Digite o nome do Aluno: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite o sobrenome do Aluno: ");
            string sobrenome = Console.ReadLine();
            Console.WriteLine("Digite o telefone do aluno");
            string telefone = Console.ReadLine();
            int matricula = Alunos.Count;

            Alunos.TryAdd(matricula, new Aluno(matricula, nome, sobrenome, telefone));
        }

        override public void Remover()
        {
            Console.WriteLine("Qual a matricula do aluno que deseja remover: ");
            int matricula = int.Parse(Console.ReadLine());
            Alunos.Remove(matricula);
        }

        override public void Atualizar()
        {
            Console.WriteLine("Qual a matricula do aluno que você quer atualizar: ");
            int matricula = int.Parse(Console.ReadLine());
            bool aluno = Alunos.ContainsKey(matricula);
            if (aluno)
            {
                //Console.WriteLine(Alunos[matricula]);
                // string nome, string sobrenome, string telefone, int[] notas
                Console.WriteLine("Nome atualizado: ");
                string nomeAtualizado = Console.ReadLine();
                Console.WriteLine("Sobrenom atualizado: ");
                string sobrenomeAtualizado = Console.ReadLine();
                Console.WriteLine("Telefone atualizado: ");
                string telefoneAtualizado = Console.ReadLine();
                int[] notasAtualizadas = new int[4];
                for (int i = 0; i < notasAtualizadas.Length; i++)
                {
                    Console.WriteLine($"Nota{i+1} atualizada: ");
                    notasAtualizadas[i] = int.Parse(Console.ReadLine());
                }
                Alunos[matricula].Atualizar(nomeAtualizado, sobrenomeAtualizado,telefoneAtualizado, notasAtualizadas);
            }
            

        }

        void ApresentarTodos()
        {

        }
    }
}
