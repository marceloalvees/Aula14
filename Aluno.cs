namespace Aula13_Atividade
{
    public class Aluno
    {
        int Matricula;
        string Nome;
        string Sobrenome;
        string Telefone;
        int[] Notas;

        public Aluno(int matricula, string nome, string sobrenome, string telefone)
        {
            Matricula = matricula;
            Nome = nome;
            Sobrenome = sobrenome;
            Telefone = telefone;
            int[] notas = new int[4];
        }

        /*
        public virtual void Atualizar(Aluno aluno, string nome, string sobrenome, string telefone, int[] notas)
        {
            aluno.Nome = nome;
            aluno.Sobrenome = sobrenome;
            aluno.Telefone = telefone;
            for (int i = 0; i < aluno.Notas.Length; i++)
            {
                aluno.Notas[i] = notas[i];
            }
        }
        */

        public virtual void Atualizar(string nome, string sobrenome, string telefone, int[] notas)
        {
            this.Nome = nome;
            this.Sobrenome = sobrenome;
            this.Telefone = telefone;
            for (int i = 0; i < this.Notas.Length; i++)
            {
                this.Notas[i] = notas[i];
            }
        }

        public void RegistrarNota(Aluno aluno, int bimestre, int nota)
        {
            aluno.Notas[bimestre] = nota;
        }

        public void ApresentarNotas(Aluno aluno)
        {
            for (int i = 0; i<aluno.Notas.Length; i++)
            {
                Console.WriteLine($"{i+1} Bimestre / Nota {aluno.Notas[i]}");
            }
        }

        public double MediaDasNotas()
        {
            double total = 0, media =0;

           
            foreach (int nota in this.Notas)
            {
                total += nota;
            }
            media = total / this.Notas.Length;
            return media;
        }

        public bool Estagio()
        {
            if (this.MediaDasNotas() >= 6)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
