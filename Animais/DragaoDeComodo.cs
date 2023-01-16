using animais.Generics;
using animais.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animais.Animais
{
    class DragaoDeComodo : Reptil, IOviparo
    {
        bool temEscamas;
        bool temCasco;
        string nome;
        DateTime dataNascimento;
        char sexo;
        int idade;
        bool carnivoro;
        bool peconhento;

        public override bool TemEscamas { get => temEscamas; set => temEscamas = value; }
        public override bool TemCasco { get => temCasco; set => temCasco = value; }
        public override string Nome { get => nome; set => nome = value; }
        public override DateTime DataNascimento { get => dataNascimento; set => dataNascimento = value; }
        public override char Sexo { get => sexo; set => sexo = value; }
        public override int Idade { get => idade; set => idade = value; }
        public override bool Carnivoro { get => carnivoro; set => carnivoro = value; }
        public override bool Peconhento { get => peconhento; set => peconhento = value; }

        public void ExibirInformacoes()
        {
            Console.WriteLine($"Informações do Dragão de Comodo:" +
                $"\nTem escamas? {temEscamas}," +
                $"\nTem casco? {temCasco}" +
                $"\nNome: {nome}" +
                $"\n Data nascimento: {dataNascimento}" +
                $"\nSexo: {sexo}" +
                $"\nIdade: {idade}" +
                $"\nCarnivoro: {carnivoro}" +
                $"\nPeçonhento: {peconhento}");
        }
        public override void Alimentar()
        {
            Console.WriteLine("Dragão de comodo alimentando-se");
        }

        public void Botar()
        {
            Console.WriteLine("Dragão de comodo botando ovo");

        }

        public void Chocar()
        {
            Console.WriteLine("Dragão de comodo chocando ovo");
        }

        public override void Comunicar()
        {
            Console.WriteLine("Dragão de comodo comunicando-se");
        }

        public override void Movimentar()
        {
            Console.WriteLine("Dragão de comodo movimentando-se");
        }
    }
}
