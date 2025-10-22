using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;

namespace SoldanoZoooo
{
    class Animale
    {
        public int Nome { get; set; }
        public int Specie { get; set; }
        public int Età { get; set; }
        public int Peso { get; set; }
        public int StatoDiSalute { get; set; }
        public DateOnly DataArrivo { get; set; }
        public int AnniAlloZoo { get; set; }

        //Membri privati

        private double _pesoIniziale;
        private int _numeroControlliVeterinario;

        private void CalcolaVariazionePesoPercentuale()
        {

        }
        public virtual double CalcolaCiboDiarioKg()
        {
            return Peso / 100;  
        }
        public virtual double CalcolaCostoGestioneMensile()
        {
            return 100;
        }
        public virtual string EmettiVerso()
        {
            return "l'animale emette un verso";
        }
        public void AggiornaPeso(int nuovoPeso)
        {
            if (Peso >= 0)
            {
                Peso = nuovoPeso;
                CalcolaVariazionePesoPercentuale();
                DeterminaStatoDiSalute();
            }
            else
            {


            }
        }
        public void EffettuaControlloVeterinario()
        {
            _numeroControlliVeterinario++;
        }
        public virtual string MostraInformazioni()
        {
            return "";
        }
        private void DeterminaStatoDiSalute()
        {

        }
    }
}
