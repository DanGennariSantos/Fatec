using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PClasses
{
    class Horista : Empregado
        //nao posso herdar  mais de uma classe não existe herança multipla em C#
    {
        //prop e 2x TAB cria a estrutura da propriedada

        public double SalarioHora { get; set; }

        public double NumeroHora { get; set; }
        public int DiasFalta { get; set; }

        public override double SalarioBruto()
        {
            return SalarioHora * NumeroHora;
        }

        //override indica sobreescrever

        public override int TempoTrabalho()
        {
            //o metodo retorna um tipo span
            TimeSpan span = DateTime.Today.Subtract(DataEntradaEmpresa);
            return (span.Days - DiasFalta);
        }

    }
}
