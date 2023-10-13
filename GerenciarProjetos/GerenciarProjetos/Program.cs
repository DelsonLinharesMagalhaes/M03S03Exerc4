class Program
{
    public static void Main(string[] args)
    {

    }

    // Interface para funcionários que podem gerenciar projetos
    public interface IManager
    {
        void GerenciarProjeto();
    }

    // Interface para funcionários que podem programar
    public interface IProgrammer
    {
        void Programar();
    }

    // Classe base para funcionários
    public class Funcionario
    {
        public string Nome { get; set; }
    }

    // Classe que implementa a interface IManager
    public class Gerente : Funcionario, IManager
    {
        public void GerenciarProjeto()
        {
            Console.WriteLine($"{Nome} está gerenciando um projeto.");
        }
    }

    // Classe que implementa a interface IProgrammer
    public class Programador : Funcionario, IProgrammer
    {
        public void Programar()
        {
            Console.WriteLine($"{Nome} está programando.");
        }
    }
}
