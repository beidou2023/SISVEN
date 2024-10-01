using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISVEN_DAO._Model
{
    public class Producto : BaseModel
    {
        #region Atributos
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public string UnidadMedida { get; set; }
        public int Saldo { get; set; }
        public double PrecioBase { get; set; }
        #endregion

        #region Contructor
        public Producto()
        {
        }
        /// <summary>
        /// GET
        /// </summary>
        /// <param name="id"></param>
        /// <param name="descripcion"></param>
        /// <param name="unidadMedida"></param>
        /// <param name="saldo"></param>
        /// <param name="precioBase"></param>
        /// <param name="estado"></param>
        /// <param name="fechaRegistro"></param>
        /// <param name="fechaActualizacion"></param>
        public Producto(int id, string descripcion, string unidadMedida, int saldo, double precioBase, byte estado, DateTime fechaRegistro, DateTime fechaActualizacion)
            :base ( estado,  fechaRegistro,  fechaActualizacion)
        {
            Id = id;
            Descripcion = descripcion;
            UnidadMedida = unidadMedida;
            Saldo = saldo;
            PrecioBase = precioBase;
        }
        /// <summary>
        /// INSERT
        /// </summary>
        /// <param name="descripcion"></param>
        /// <param name="unidadMedida"></param>
        /// <param name="saldo"></param>
        /// <param name="precioBase"></param>
        public Producto(string descripcion, string unidadMedida, int saldo, double precioBase)
        {
            Descripcion = descripcion;
            UnidadMedida = unidadMedida;
            Saldo = saldo;
            PrecioBase = precioBase;
        }
        #endregion
    }
}
