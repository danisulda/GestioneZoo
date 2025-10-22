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
            return 0;  
        }
        public virtual double CalcolaCostoGestioneMensile()
        {
            return 0;
        }
        public virtual double EmettiVerso()
        {
            return 0;
        }
        public void AggiornaPeso(double nuovoPeso)
        {
            
        }
        public void EffettuaControlloVeterinario()
        {
            _numeroControlliVeterinario++;
        }
        public virtual double MostraInformazioni()
        {
            return 0;
        }
    }
}
