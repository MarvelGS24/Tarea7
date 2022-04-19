using System;
using System.Collections.Generic;
using System.Text;

namespace Clase10POO
{
    /*Objeto Trabajador*/
    public class Trabajador : Persona /*Herencia Objeto Persona*/
    {
        /*Atributos*/
        public Guid IdTrabajador { get { return Guid.NewGuid(); }}
        public decimal Salario;
        public int IdDepartamento;

        /*Constructor 1*/
        public Trabajador(int pIdPersona, string pNombre, int pEdad, decimal _Salario, int _IdDepartamento) : base(pIdPersona, pNombre, pEdad)
        {
            Salario = _Salario;
            IdDepartamento = _IdDepartamento;
        }
        /*Constructor 2*/
        public Trabajador() : base() { } 
    }
}
