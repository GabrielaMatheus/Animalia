using animais.Generics;
using animais.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animais.Animais
{
    class Morcego : Mamifero, IVoar
    {
        int qtdMamas;
        bool pelos;
        string CorPelo;
        string nome;
        DateTime dataNascimento;
        char sexo;
        int idade;
        bool carnivoro;
        bool peconhento;
        int altitudeMaximaEmMetros;
        double velocidadeDoVoo;

        public override int QtdMamas { get => qtdMamas; set => qtdMamas = value; }
        public override bool Pelos { get => pelos; set => pelos = value; }
        public override string corPelo { get => CorPelo; set => CorPelo = value; }
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
            Console.WriteLine($"Informações do Morcego:" +
                $"\nQuantidade mamas: {qtdMamas}, " +
                $"\ntem pelos? {pelos}, " +
                $"\ncor dos pelos: {corPelo}" +
                $"\nAltitude maxima em metros: {AltitudeMaximaEmMetros}" +
                $"\nVelocidade do voo: {VelocidadeDoVoo}" +
                $"\nNome: {nome}" +
                $"\n Data nascimento: {dataNascimento}" +
                $"\nSexo: {sexo}" +
                $"\nIdade: {idade}" +
                $"\nCarnivoro: {carnivoro}" +
                $"\nPeçonhento: {peconhento}");
        }

        public override void Alimentar()
        {
            Console.WriteLine("Morcego Alimentando");

        }

        public override void Amamentar()
        {
            Console.WriteLine("Morcego Amamentando filhote");
        }

        public override void Comunicar()
        {
            Console.WriteLine("Morcego Comunicando");

        }


        public override void Movimentar()
        {
            Console.WriteLine("Morcego Movimentando");
        }

        public void Voar()
        {
            Console.WriteLine("Morcego voando");
        }
    }
}
