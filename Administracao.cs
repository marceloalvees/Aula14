namespace Aula13_Atividade
{
    
    public abstract class Administracao
    {

        public abstract void Cadastrar();

        public abstract void Remover();

        public virtual void Atualizar()
        {

        }
        public virtual void ApresentarTodos()
        {

            //foreach (Student student in subscribers.Values)
            //{
            //    Console.WriteLine($"{student.Matricula} - {student.Nome}");
            //}
        }
    }
}
