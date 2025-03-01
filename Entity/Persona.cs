﻿
namespace Entity
{
    public class Persona
    {
        public Persona(string identificacion, string nombre, int edad, string email, string sexo)
        {
            Identificacion = identificacion;
            Nombre = nombre;
            Edad = edad;
            Sexo = sexo;
            Email = email;
           
        }

        public Persona()
        {

        }
      

        public string Identificacion { get; set; }
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Sexo { get; set; }
        public decimal Pulsacion { get; set; }
        public string Email { get; set; }
        public override string ToString()
        {
            return $"Identificacion: {Identificacion} - Nombre:{Nombre}-Edad:{Edad} -Sexo:{Sexo} -Pulsacion: {Pulsacion} ";
        }

        public string TemporalArchivo()
        {
            return Identificacion + ";" + Nombre + ";" + Edad + ";" + Sexo + ";" + Pulsacion;
        }
        public void CalcularPulsacion()
        {
       
            if (Sexo.ToUpper().Equals("F"))
            {
                Pulsacion = (220 - Edad) / 10;
            }
            else if (Sexo.ToUpper().Equals("M"))
            {
                Pulsacion = (210 - Edad) / 10;
            }
            else
            {
                Pulsacion = 0;
            }
            
        }
    }
}
