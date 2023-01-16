using animais.Generics;
using animais.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animais.Animais
{
    class Coruja : Ave, IVoar, IOviparo
    {
        bool rapina;
        bool corPena;
        int altitudeMaximaEmMetros;
        double velocidadeDoVoo;
        string nome;
        DateTime dataNascimento;
        char sexo;
        int idade;
        bool carnivoro;
        bool peconhento;

        public override bool Rapina { get => rapina; set => rapina = value; }
        public override bool CorPena { get => corPena; set => corPena = value; }
        public int AltitudeMaximaEmMetros { get => altitudeMaximaEmMetros; set => altitudeMaximaEmMetros = value; }
        public double VelocidadeDoVoo { get => velocidadeDoVoo; set => velocidadeDoVoo = value; }
        public override string Nome { get => nome; set => nome = value; }
        public override DateTime DataNascimento { get => dataNascimento; set => dataNascimento = value; }
        public override char Sexo { get => sexo; set => sexo = value; }
        public override int Idade { get => idade; set => idade = value; }
        public override bool Carnivoro { get => carnivoro; set => carnivoro = value; }
        public override bool Peconhento { get => peconhento; set => peconhento = value; }

        public void ExibirInformacoes()
        {
            Console.WriteLine($"Informações da coruja: " +
                $"\nÉ rapina? {rapina}\n" +
                $"Cor da pena: {corPena}\n" +
                $"Altitude Maxima em metros: {altitudeMaximaEmMetros}\n" +
                $"Velocidade do voo: {velocidadeDoVoo}" +
                $"\nNome: {nome}" +
                $"\n Data nascimento: {dataNascimento}" +
                $"\nSexo: {sexo}" +
                $"\nIdade: {idade}" +
                $"\nCarnivoro: {carnivoro}" +
                $"\nPeçonhento: {peconhento}");
        }

        public override void Alimentar()
        {
            Console.WriteLine("Coruja alimentando-se");
        }

        public void Botar()
        {
            Console.WriteLine("Coruja botando ovo");
        }

        public void Chocar()
        {
            Console.WriteLine("Coruja chocando ovo");
        }

        public override void Ciscar()
        {
            Console.WriteLine("Coruja ciscando");
        }

        public override void Comunicar()
        {
            Console.WriteLine("Coruja comunicando-se");
        }

        public override void Movimentar()
        {
            Console.WriteLine("Coruja movimentando-se");
        }

        public void Voar()
        {
            Console.WriteLine("Coruja voando");
        }
    }
}
