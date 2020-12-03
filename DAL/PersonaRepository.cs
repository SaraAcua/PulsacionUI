using Entity;
using System;
using System.Collections.Generic;

using System.IO;
using System.Linq;

namespace DAL
{
    public class PersonaRepository
    {
        private readonly string FileName = "Persona.txt";
        public void Guardar(Persona persona)
        {
            FileStream file = new FileStream(FileName, FileMode.Append);
            StreamWriter writer = new StreamWriter(file);
            writer.WriteLine($"{persona.Identificacion};{persona.Nombre};{persona.Edad};{persona.Email};{persona.Sexo};{persona.Pulsacion} ");
            writer.Close();
            file.Close();

        }
        public Persona Buscar(string identificacion)
        {
            List<Persona> personas = ConsultarTodos();
            foreach (var item in personas)
            {
                if (EsEncontrado(item.Identificacion, identificacion))
                {
                    return item;
                }
            }
            return null;
        }
        private bool EsEncontrado(string identificacioRegistrada, string identificacionBuscada)
        {
            return identificacioRegistrada == identificacionBuscada;
        }
        public List<Persona> ConsultarTodos()
        {
            List<Persona> personas = new List<Persona>();
            FileStream file = new FileStream(FileName, FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader reader = new StreamReader(file);
            string linea = string.Empty;
            while ((linea = reader.ReadLine()) != null)
            {

                Persona persona = Map(linea);
                personas.Add(persona);
            }
            reader.Close();
            file.Close();
            return personas;
        }
        private Persona Map(string linea)
        {
            Persona persona = new Persona();
            char delimiter = ';';
            string[] matrizPersona = linea.Split(delimiter);
            persona.Identificacion = matrizPersona[0];
            persona.Nombre = matrizPersona[1];
            persona.Edad = int.Parse(matrizPersona[2]);
            persona.Email = matrizPersona[3];
            persona.Sexo = matrizPersona[4];
            persona.Pulsacion = Convert.ToDecimal(matrizPersona[5]);
            return persona;
        }


        public void Eliminar(string identificacion)
        {
            List<Persona> personas = new List<Persona>();
            personas = ConsultarTodos();
            FileStream file = new FileStream(FileName, FileMode.Create);
            file.Close();
            foreach (var item in personas)
            {
                if (!EsEncontrado(item.Identificacion, identificacion))
                {
                    Guardar(item);
                }

            }

        }
        public void Modificar(Persona personaOld, Persona personaNew)
        {
            List<Persona> personas = new List<Persona>();
            personas = ConsultarTodos();
            FileStream file = new FileStream(FileName, FileMode.Create);
            file.Close();
            foreach (var item in personas)
            {
                if (!EsEncontrado(item.Identificacion, personaOld.Identificacion))
                {
                    Guardar(item);
                }
                else
                {
                    Guardar(personaNew);
                }

            }

        }
        public string ModificarUsuario(string identificacion, string nombre, int edad, string sexo)
        {
            FileStream file = new FileStream("Temp.txt", FileMode.OpenOrCreate);
            StreamWriter escribir = new StreamWriter(file);
            FileStream filereader = new FileStream(FileName, FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader leer = new StreamReader(filereader);
            string linea = string.Empty;
            bool encontrado = false;
            while ((linea = leer.ReadLine()) != null)
            {
                Persona persona = Map(linea);
                if (persona.Identificacion == identificacion)
                {
                    encontrado = true;
                    persona.Nombre = nombre;
                    persona.Edad = edad;
                    persona.Sexo = sexo;
                    persona.CalcularPulsacion();

                    escribir.WriteLine(persona.TemporalArchivo());

                }
                else
                {
                    escribir.WriteLine(persona.TemporalArchivo());
                }

            }


            leer.Close();
            escribir.Close();
            File.Delete("Persona.txt");
            File.Move("Temp.txt", "Persona.txt");
            File.Delete("Temp.txt");

            if (encontrado == false)
            {
                return "No se encontro Registro";
            }
            else
            {
                return "Se encontro Registro";
            }



        }
        public List<Persona> FiltrarSexo(string sexo)
        {
            return ConsultarTodos().Where(p => p.Sexo.Equals(sexo)).ToList();
        }

        public List<Persona> FiltrarPorHombres()
        {

            List<Persona> personas = ConsultarTodos();
            List<Persona> personasFiltradas =
                (from persona in personas
                 where persona.Sexo.Equals("M")
                 select persona).ToList();
            return personasFiltradas;
        }
        public int ContarSexo(string sexo)
        {
            return ConsultarTodos().Count(p => p.Sexo.Equals(sexo));
        }

        public List<Persona> FiltroPorNombre(string nombre)
        {
            return ConsultarTodos().Where(p => p.Nombre.Contains(nombre)).ToList();
        }
    }
}

