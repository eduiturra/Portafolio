using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using System.Data;
namespace CapaDatos
{
    public class Insertar
    {
        public static void InsertarAgenda(String HORAINICIO, String HORATERMINO, int DURACION, DateTime FECHA, String ASEO,
            String USUARIO_RUTUSUARIO, String PACIENTE_RUTPACIENTE, String PABELLON_IDPABELLON, String ENFERMERO_RUTENFERMERO, String CIRUJANO_RUTCIRUJANO, String PABELLONERO_RUTPABELLONERO,
            String ANESTSISTA_RUTANESTE, String TANESTESISTA_RUTTENANES, String ARSENALERO_RUTARSENA, int ESPECIALIDAD_IDESPECIALIDAD, int ESTADO_IDESTADO)
        {
            using (OracleConnection conn = Conexion.conectar())
            {
                conn.Open();
                OracleCommand consulta = new OracleCommand("prInsertarAgenda", conn);
                consulta.CommandType = CommandType.StoredProcedure;
                consulta.Parameters.Add("horainicio", OracleDbType.Varchar2).Value = HORAINICIO;
                consulta.Parameters.Add("horatermino", OracleDbType.Varchar2).Value = HORATERMINO;
                if (DURACION == 0)
                {
                    consulta.Parameters.Add("duracion", OracleDbType.Int64).Value = null;
                }
                else
                {
                    consulta.Parameters.Add("duracion", OracleDbType.Int64).Value = DURACION;
                }
                consulta.Parameters.Add("fecha", OracleDbType.Date).Value = FECHA.ToString("dd/MM/yy");
                consulta.Parameters.Add("aseo", OracleDbType.Varchar2).Value = ASEO;
                consulta.Parameters.Add("fk_rutusuario", OracleDbType.Varchar2).Value = USUARIO_RUTUSUARIO;
                consulta.Parameters.Add("fk_rutpaciente", OracleDbType.Varchar2).Value = PACIENTE_RUTPACIENTE;
                consulta.Parameters.Add("fk_idpabellon", OracleDbType.Int64).Value = int.Parse(Vistas.VistaPabellon().Where(a => a.Codigo == PABELLON_IDPABELLON).Select(a=>a.Idpabellon).First().ToString());
                if (ENFERMERO_RUTENFERMERO == "[Seleccione]")
                {
                    consulta.Parameters.Add("fk_rutenefermero", OracleDbType.Varchar2).Value = null;
                }
                else
                {
                    consulta.Parameters.Add("fk_rutenefermero", OracleDbType.Varchar2).Value = ENFERMERO_RUTENFERMERO;

                }
                consulta.Parameters.Add("fk_rutcirujano", OracleDbType.Varchar2).Value = CIRUJANO_RUTCIRUJANO;
                consulta.Parameters.Add("fk_rutpabellone", OracleDbType.Varchar2).Value = "18213925-4";
                if (ANESTSISTA_RUTANESTE == "[Seleccione]")
                {
                    consulta.Parameters.Add("fk_rutaneste", OracleDbType.Varchar2).Value = null;
                }
                else
                {
                    consulta.Parameters.Add("fk_rutaneste", OracleDbType.Varchar2).Value = ANESTSISTA_RUTANESTE;
                }

                if (TANESTESISTA_RUTTENANES == "[Seleccione]")
                {
                    consulta.Parameters.Add("fk_ruttenastes", OracleDbType.Varchar2).Value = null;
                }
                else
                {
                    consulta.Parameters.Add("fk_ruttenastes", OracleDbType.Varchar2).Value = TANESTESISTA_RUTTENANES;
                }

                if (ARSENALERO_RUTARSENA == "[Seleccione]")
                {
                    consulta.Parameters.Add("fk_rutarsena", OracleDbType.Varchar2).Value = null;
                }
                else
                {
                    consulta.Parameters.Add("fk_rutarsena", OracleDbType.Varchar2).Value = ARSENALERO_RUTARSENA;
                }



               
               
                consulta.Parameters.Add("fk_especialidad", OracleDbType.Int64).Value = ESPECIALIDAD_IDESPECIALIDAD;
                consulta.Parameters.Add("fk_estado", OracleDbType.Int64).Value = ESTADO_IDESTADO;
                consulta.ExecuteNonQuery();


            }

        }
    }
}
