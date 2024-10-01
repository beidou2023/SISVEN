using SISVEN_DAO._Interface;
using SISVEN_DAO._Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data;
using Mysqlx.Connection;
using System.Data;
using MySql.Data.MySqlClient;

namespace SISVEN_DAO._Implementation
{
    public class OficinaImplementation : BaseImplementation ,IOficina
    {
        public int Delete(Oficina t)
        {
            int n = 0;
            query = @"UPDATE oficina 
                    SET nombre=@nombre, direccion=@direccion, fechaActualizacion=NOW()
                    WHERE id=@id;";
            MySqlCommand comand = CreateBasicCommand(this.query);
            comand.Parameters.AddWithValue("@nombre", t.Nombre);
            comand.Parameters.AddWithValue("@direccion", t.Direccion);
            comand.Parameters.AddWithValue("@direccion", t.Id);
            try {
                n = ExecuteBasic(comand);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {

            }
            return n;
        }

        public int Insert(Oficina t)
        {
            int n=0;
            query = "INSERT INTO oficina (nombre,direccion) VALUES (@nombre,@direccion);";
            MySqlCommand comand =CreateBasicCommand(this.query);

            comand.Parameters.AddWithValue("@nombre", t.Nombre);
            comand.Parameters.AddWithValue("@direccion", t.Direccion);
            try
            {
                n=ExecuteBasic(comand);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { 
                
            }
            return n;
        }

        public DataTable Select()
        {
            query= @"SELECT id AS ID, nombre AS 'oficina sucursal', 
                    direccion AS Direccion, 
                    fechaRegistro AS 'Creado en'
                    FROM oficina
                    WHERE estado=1 ORDER BY 2;";
            MySqlCommand command = CreateBasicCommand(this.query);
            return ExecuteDataTableCommand(command);
        }

        public int Update(Oficina t)
        {
            int n = 0;
            query = @"UPDATE oficina 
                    SET estado=0, fechaActualizacion=NOW()
                    WHERE id=@id;";
            MySqlCommand comand = CreateBasicCommand(this.query);
            comand.Parameters.AddWithValue("@direccion", t.Id);
            try
            {
                n = ExecuteBasic(comand);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {

            }
            return n;
        }
    }
}
