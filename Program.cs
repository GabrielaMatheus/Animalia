
using animais.Animais;


class Program
{
    static void Main(string[] args)
    {

        var Leao = new Leao()
        {
            QtdMamas = 4,
            Pelos = true,
            corPelo = "caramelo",
            Nome = "Tadeu",
            DataNascimento = DateTime.Now,
            Sexo = 'm',
            Idade = 1,
            Carnivoro = true,
            Peconhento = false


        };
        Leao.ExibirInformacoes();
        Leao.Movimentar();

        Console.WriteLine("\n");

        var Jacare = new Jacare()
        {
            ViveEmTerra = true,
            Mergulho = true,
            AguaDoce = true,
            TemEscamas = true,
            TemCasco = false,
            Nome = "Jaque",
            DataNascimento = DateTime.Now,
            Sexo = 'f',
            Idade = 1,
            Carnivoro = true,
            Peconhento = false
        };

        Jacare.ExibirInformacoes();
        Jacare.Movimentar();
        Jacare.Botar();
        Jacare.Chocar();
        Jacare.Nadar();

        Console.WriteLine("\n");

        var Morcego = new Morcego()
        {
            QtdMamas = 2,
            Pelos = false,
            corPelo = "não tem pelo",
            AltitudeMaximaEmMetros = 10,
            VelocidadeDoVoo = 160.0,
            Nome = "Ilis",
            DataNascimento = DateTime.Now,
            Sexo = 'm',
            Idade = 1,
            Carnivoro = false,
            Peconhento = false

        };

        Morcego.ExibirInformacoes();
        Morcego.Voar();
        Morcego.Alimentar();
        Morcego.Comunicar();

        Console.WriteLine("\n");

        //professor, coloquei somente algumas chamadas aqui por falta de tempo, mas tudo foi testado, agradeço a compreensão.

        Console.ReadLine();

    }
}