﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batalha_Pokemon
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Pokemon[] Pokebox = new Pokemon[]
            {
                new Pokemon(1,"Venusaur", 364, 60, 90),
                new Pokemon(2,"Charizard", 380, 75, 20),
                new Pokemon(3,"Blastoise", 500, 65, 20),
            };

            Pokemon PokemonAtual = new Pokemon(0,"Defult",0,0,0);

            int opition;

            Console.WriteLine("Olá futuro mestre pokémon:");

            Console.WriteLine("1-Venusaur\n2-Charizard\n3-Blastoise");
            opition = Convert.ToInt32(Console.ReadLine());
            for(int i=0; i<Pokebox.Length; i++)
            {
                if(opition == Pokebox[i].codPokemon)
                {
                    PokemonAtual = Pokebox[i];
                    break;
                }
                    
            }

            while(PokemonAtual.GetVidaPokemon() != 0)
            {
                Console.Clear();
                Console.WriteLine("Escolha o seu movimento\n 1\n2 \n3 \n4");
                opition= Convert.ToInt32(Console.ReadLine());

                for( int i=0;i<MoveBox.Length; i++)
                {
                    if(opition == MoveBox[i].moveCod)

                }
            }

            Console.WriteLine(PokemonAtual.nomePokemon);

            

            

         

            
            Console.ReadLine();
        }
    }
}
