using animais.Generics;
using animais.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animais.Animais
{
    class Cisne : Ave, IAquatico, IOviparo, IVoar
    {
        bool rapina;
        bool corPena;
        bool viveEmTerra;
        bool mergulho;
        bool aguaDoce;
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
        public bool ViveEmTerra { get => viveEmTerra; set => viveEmTerra = value; }
        public bool Mergulho { get => mergulho; set => mergulho = value; }
        public bool AguaDoce { get => aguaDoce; set => aguaDoce = value; }
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
            Console.WriteLine($"Informações do Cisne: " +
                $"\nÉ rapina? {rapina}\n" +
                $"Cor da pena: {corPena}\n" +
                $"Vive em terra? {viveEmTerra}\n" +
                $"Mergulha? {mergulho}\n" +
                $"Mergulha em agua doce? {aguaDoce}\n" +
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
            Console.WriteLine("Cisne alimentando");
        }

        public void Botar()
        {
            Console.WriteLine("Cisne botando ovo");
        }

        public void Chocar()
        {
            Console.WriteLine("Cisne chocando");
        }

        public override void Ciscar()
        {
            Console.WriteLine("Cisne ciscando");
        }

        public override void Comunicar()
        {
            Console.WriteLine("Cisne comunicando");
        }

        public override void Movimentar()
        {
            Console.WriteLine("Cisne movimentando");
        }

        public void Nadar()
        {
            Console.WriteLine("Cisne nadando");
        }

        public void Voar()
        {
            Console.WriteLine("Cisne voando");
        }
    }
}
