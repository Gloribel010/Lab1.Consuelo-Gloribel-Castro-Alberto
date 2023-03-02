using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABORATORIO.Consuelo_Gloribel_Castro_Alberto.Entidades.Negocio
{
    public class ClsPersona
    {
        List<Persona> Persona = new List<Persona>();
        public void PesodePersonas(Persona per)
        {
            double pro = per.peso / Math.Pow(per.altura, 2);

            if (pro < 18.5)
            {
                Console.WriteLine("Tiene un sobrepeso");
            }
            else if ((pro >= 18.5)&& (pro <= 24.9))
            {
                Console.WriteLine("Tiene un peso ideal");
            }

        }
        public List<Persona> ListadoDePeso()
        {
            return Persona;
        }

        public void MayordeEdad(Persona perso)
        {

            if (perso.edad >= 18)
            {
                Console.WriteLine("Es Mayor de edad");

            }
            else
            {
                Console.WriteLine("Es menor de edad");
            }
        }
            public List<Persona> ListadoDeEdad()
        {
            return Persona;
        }


    }


}
    

