using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISVEN_DAO._Model
{
    public class Oficina : BaseModel
    {
        #region Atributos
        public byte Id { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        #endregion

        #region Constructores
        public Oficina()
        {
        }

        public Oficina(byte id, string nombre, string direccion, byte estado, DateTime fechaRegistro, DateTime fechaActualizacion) :base( estado,  fechaRegistro,  fechaActualizacion)
        {
            Id = id;
            Nombre = nombre;
            Direccion = direccion;
        }

        /// <summary>
        /// Insert 
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="direccion"></param>
        public Oficina(string nombre, string direccion)
        {
            Nombre = nombre;
            Direccion = direccion;
        }
        #endregion

    }
}
