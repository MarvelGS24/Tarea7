using System;
using System.Collections.Generic;
using System.Text;

namespace Clase10POO
{
    /*Objeto Persona*/
    public class Persona
    {
        /*Atributos*/
        public int IdPersona;
        public string Nombre;
        public int Edad;

        /*Constructor 1*/
        public Persona(int _IdPersona, string _Nombre, int _Edad)
        {
            IdPersona = _IdPersona;
            Nombre = _Nombre;
            Edad = _Edad;
        }
        /*Constructor 2*/
        public Persona() { }
    }
}
