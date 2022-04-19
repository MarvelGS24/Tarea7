using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Clase10POO
{
    /*Objeto Departamento*/
    public class Departamento
    {
        /*Atributos*/
        public int IdDepartamento { get; set; }
        public string NombreDepartamento { get; set; }
        
    }

    /*Clase*/
    public class CargaDepartamentos
    {
        /*Método*/
        public List<Departamento> Departamentos()
        {
            var Departamentos = new List<Departamento>();
            Departamentos.Add(new Departamento { IdDepartamento = 1, NombreDepartamento = "Business Intelligence" });
            Departamentos.Add(new Departamento { IdDepartamento = 2, NombreDepartamento = "Treasury" });
            Departamentos.Add(new Departamento { IdDepartamento = 3, NombreDepartamento = "Administration" });
            Departamentos.Add(new Departamento { IdDepartamento = 4, NombreDepartamento = "Reporting" });
            Departamentos.Add(new Departamento { IdDepartamento = 5, NombreDepartamento = "System" });
            Departamentos.Add(new Departamento { IdDepartamento = 6, NombreDepartamento = "Billing" });
            Departamentos.Add(new Departamento { IdDepartamento = 7, NombreDepartamento = "HR" });

            return Departamentos;
        }
    }

    /*Clase*/
    public static class NombreDepartamento
    {
        /*Método*/
        public static string getNombreDepartamento(int IndexComboBox)
        {
            var cargaDepartamento = new CargaDepartamentos();
            return cargaDepartamento.Departamentos().Where(x => x.IdDepartamento == IndexComboBox).ToArray()[0].NombreDepartamento;
        }
    }
}
