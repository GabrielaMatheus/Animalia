using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using animais.Generics;
using animais.Interfaces;

namespace animais.Animais
{
     class Jacare : Reptil, IAquatico, IOviparo
    {
        bool viveEmTerra;
        bool mergulho;
        bool aguaDoce;
        bool temEscamas;
        bool temCasco;
        string nome;
        DateTime dataNascimento;
        char sexo;
        int idade;
        bool carnivoro;
        bool peconhento;
        public bool ViveEmTerra { get => viveEmTerra; set => viveEmTerra = value; }
        public bool Mergulho { get => mergulho; set => mergulho = value; }
        public bool AguaDoce { get => aguaDoce; set => aguaDoce = value; }
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
            Console.WriteLine($"Informações do Jacaré:" +
                $"\nVive em terra? {viveEmTerra}, " +
                $"\nMergulha? {mergulho}, " +
                $"\nÁgua doce? {aguaDoce}," +
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
            Console.WriteLine("Jacaré Eu como carne");
        }

        public void Botar()
        {
            Console.WriteLine("Jacaré Botando ovo");
        }

        public void Chocar()
        {
            Console.WriteLine("Jacaré Chocando ovo");
        }

        public override void Comunicar()
        {
            Console.WriteLine("Jacaré Rugindo - se comunicando");
        }

        public override void Movimentar()
        {
            Console.WriteLine("Jacaré Rastejando - se movimentando");
        }

        public void Nadar()
        {
            Console.WriteLine("Jacaré Nadando");
        }
    }
}
