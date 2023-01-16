﻿using animais.Generics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animais.Animais
{
    class Lontra : Mamifero
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

        public override int QtdMamas { get => qtdMamas; set => qtdMamas = value; }
        public override bool Pelos { get => pelos; set => pelos = value; }
        public override string corPelo { get => CorPelo; set => CorPelo = value; }
        public override string Nome { get => nome; set => nome = value; }
        public override DateTime DataNascimento { get => dataNascimento; set => dataNascimento = value; }
        public override char Sexo { get => sexo; set => sexo = value; }
        public override int Idade { get => idade; set => idade = value; }
        public override bool Carnivoro { get => carnivoro; set => carnivoro = value; }
        public override bool Peconhento { get => peconhento; set => peconhento = value; }

        public void ExibirInformacoes()
        {
            Console.WriteLine($"Informações da Lontra:" +
                $"\nQuantidade mamas: {qtdMamas}, " +
                $"\ntem pelos? {pelos}, " +
                $"\ncor dos pelos: {corPelo}" +
                $"\nNome: {nome}" +
                $"\n Data nascimento: {dataNascimento}" +
                $"\nSexo: {sexo}" +
                $"\nIdade: {idade}" +
                $"\nCarnivoro: {carnivoro}" +
                $"\nPeçonhento: {peconhento}");
        }
        public override void Alimentar()
        {
            Console.WriteLine("Lontra alimentando-se");
        }

        public override void Amamentar()
        {
            Console.WriteLine("Lontra amamentando");

        }

        public override void Comunicar()
        {
            Console.WriteLine("Lontra comunicando-se");
        }

        public override void Movimentar()
        {
            Console.WriteLine("Lontra movimentando-se");
        }
    }
}
