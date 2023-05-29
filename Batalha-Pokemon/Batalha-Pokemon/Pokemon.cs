using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batalha_Pokemon
{
    internal class Pokemon
    {
        public int codPokemon = 0;
        public string nomePokemon = "Defaut";
        private int vidaPokemon = 1;
        private int vidaMaxPokemon = 1;
        private int danoPokemon = 1;
        private int curaPokemon = 1;

        public Pokemon(int cod, string n, int vmax, int d, int c) 
        {
            codPokemon=cod;
            nomePokemon = n;
            SetVidaMaxPokemon(vmax);
            SetVidaPokemon(vmax);
            SetDanoPokemon(d);
            SetCuraPokemon(c);
        }

        

        public bool SetVidaMaxPokemon(int vida)
        {
            if (vida > 0 && vida >= vidaPokemon)
            {
                vidaMaxPokemon = vida;
                return true;
            }

            return false;

        }

        public int GetVidaMaxPokemon()
        {
            return vidaMaxPokemon;
        }


        public bool SetVidaPokemon(int vida) {
            if (vida <= vidaMaxPokemon && vida > 0)
            {
                vidaPokemon = vida;

                return true;
            }
            
            return false;
        }

        public int GetVidaPokemon()
        {
            return vidaPokemon;
        }

        public bool SetDanoPokemon(int dano)
        {
            if (dano > 0)
            {
                danoPokemon = dano;
                return true;
            }

            return false;
        }

        public int GetDanoPokemon()
        {
            return danoPokemon;
        }
        
        public bool SetCuraPokemon(int cura)
        {
            if (cura > 0)
            {
                curaPokemon = cura;
                return true;
            }

            return false;
        }

        public int GetCuraPokemon()
        {
            return curaPokemon;
        }

        public int AtaquePokemon(int vidaInimigo)
        {
            return vidaInimigo - danoPokemon;
        }

        public bool CuraPokemon()
        {
            if(vidaPokemon <= 0)
                return false;

            if (curaPokemon + vidaPokemon >= vidaMaxPokemon)
            {
                vidaPokemon = vidaMaxPokemon;
                
                return true;
            }

            else
            {
                vidaPokemon += curaPokemon;
                return true;
            }

        }

    }
}
