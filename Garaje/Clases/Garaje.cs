using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garaje.Clases
{
    public class Garaje
    {
        private int numeroGaraje {  get; set; }
        private string descripcion {  get; set; }
        private int capacidadEspacios { get; set; }
        private int espaciosOcupados { get; set; }


        public Garaje(int numeroGaraje, string descripcion, int capacidadEspacios, int espaciosOcupados)
        {
            this.numeroGaraje = numeroGaraje;
            this.descripcion = descripcion;
            this.capacidadEspacios = capacidadEspacios;
            this.espaciosOcupados = espaciosOcupados;
        }

        //metodo para retornar espacios disponibles

        public int getcapacidadEspacios()
        {
            return capacidadEspacios;
        }

        public int getespaciosOcupados()
        {
            return espaciosOcupados;
        }


        public int getespaciosDisponibles()
        {
            return capacidadEspacios - espaciosOcupados;
        }

        public void actualizarEspaciosOcupados(int cuposSolicitados)
        {
            espaciosOcupados = espaciosOcupados - cuposSolicitados;
        }
    }
}
