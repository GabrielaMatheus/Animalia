using animais.Generics;
using animais.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animais.Animais
{
    class Pinguim : Ave, IAquatico, IOviparo
    {
        bool rapina;
        bool corPena;
        bool viveEmTerra;
        bool mergulho;
        bool aguaDoce;
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
        public override string Nome { get => nome; set => nome = value; }
        public override DateTime DataNascimento { get => dataNascimento; set => dataNascimento = value; }
        public override char Sexo { get => sexo; set => sexo = value; }
        public override int Idade { get => idade; set => idade = value; }
        public override bool Carnivoro { get => carnivoro; set => carnivoro = value; }
        public override bool Peconhento { get => peconhento; set => peconhento = value; }

        public void ExibirInformacoes()
        {
            Console.WriteLine($"Informações do Pinguim: " +
                $"\nÉ rapina? {rapina}\n" +
                $"Cor da pena: {corPena}\n" +
                $"Vive em terra? {viveEmTerra}\n" +
                $"Mergulha? {mergulho}\n" +
                $"Mergulha em agua doce? {aguaDoce}\n" +
                $"\nNome: {nome}" +
                $"\n Data nascimento: {dataNascimento}" +
                $"\nSexo: {sexo}" +
                $"\nIdade: {idade}" +
                $"\nCarnivoro: {carnivoro}" +
                $"\nPeçonhento: {peconhento}");
        }

        public override void Alimentar()
        {
            Console.WriteLine("Pinguim alimentando-se");
        }

        public void Botar()
        {
            Console.WriteLine("Pinguim botando ovo");
        }

        public void Chocar()
        {
            Console.WriteLine("Pinguim chocando ovo");
        }

        public override void Ciscar()
        {
            Console.WriteLine("Pinguim ciscando");
        }

        public override void Comunicar()
        {
            Console.WriteLine("Pinguim comunicando-se");
        }

        public override void Movimentar()
        {
            Console.WriteLine("Pinguim movimentando-se");
        }

        public void Nadar()
        {
            Console.WriteLine("Pinguim nadando");
        }
    }
}
