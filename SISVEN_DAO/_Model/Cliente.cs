using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISVEN_DAO._Model
{
    public class Cliente : BaseModel
    {
        #region Atributos
        public byte Id { get; set; }
        public string CiNit { get; set; }
        public string RazonSocial { get; set; }
        #endregion

        #region Constructores
        public Cliente()
        {
        }
        /// <summary>
        /// GET
        /// </summary>
        /// <param name="id"></param>
        /// <param name="ciNit"></param>
        /// <param name="razonSocial"></param>
        /// <param name="estado"></param>
        /// <param name="fechaRegistro"></param>
        /// <param name="fechaActualizacion"></param>
        public Cliente(byte id, string ciNit, string razonSocial, byte estado, DateTime fechaRegistro, DateTime fechaActualizacion): base( estado,  fechaRegistro,  fechaActualizacion)
        {
            Id = id;
            CiNit = ciNit;
            RazonSocial = razonSocial;
        }
        /// <summary>
        /// INSERT
        /// </summary>
        /// <param name="ciNit"></param>
        /// <param name="razonSocial"></param>
        public Cliente(string ciNit, string razonSocial)
        {
            CiNit = ciNit;
            RazonSocial = razonSocial;
        }
        #endregion
    }
}
