using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using System.Data;

namespace CapaDatos
{
    public class Actualizar
    {
        public static void ActualizarAgenda(int IDAGENDA,String HORAINICIO, String HORATERMINO, int DURACION, DateTime FECHA, String ASEO,
            String USUARIO_RUTUSUARIO, String PACIENTE_RUTPACIENTE, String PABELLON_IDPABELLON, String ENFERMERO_RUTENFERMERO, String CIRUJANO_RUTCIRUJANO, String PABELLONERO_RUTPABELLONERO,
            String ANESTSISTA_RUTANESTE, String TANESTESISTA_RUTTENANES, String ARSENALERO_RUTARSENA, int ESPECIALIDAD_IDESPECIALIDAD, int ESTADO_IDESTADO)
        {
            using (OracleConnection conn = Conexion.conectar())
            {
                conn.Open();
                OracleCommand consulta = new OracleCommand("PRACTUALIZARAGENDA", conn);
                consulta.CommandType = CommandType.StoredProcedure;
                consulta.Parameters.Add("xidagenda", OracleDbType.Int64).Value = IDAGENDA;
                consulta.Parameters.Add("xhorainicio", OracleDbType.Varchar2).Value = HORAINICIO;
                consulta.Parameters.Add("xhoratermino", OracleDbType.Varchar2).Value = HORATERMINO;
                consulta.Parameters.Add("xduracion", OracleDbType.Int64).Value = DURACION;
                consulta.Parameters.Add("Xfecha", OracleDbType.Date).Value = FECHA.ToString("dd/MM/yy");
                consulta.Parameters.Add("xaseo", OracleDbType.Varchar2).Value = ASEO;
                consulta.Parameters.Add("fk_usuario", OracleDbType.Varchar2).Value = USUARIO_RUTUSUARIO;
                consulta.Parameters.Add("fk_paciente", OracleDbType.Varchar2).Value = PACIENTE_RUTPACIENTE;
                consulta.Parameters.Add("fk_pabellon", OracleDbType.Int64).Value = int.Parse(Vistas.VistaPabellon().Where(a => a.Codigo == PABELLON_IDPABELLON).Select(a => a.Idpabellon).First().ToString());
                consulta.Parameters.Add("fk_enefermero", OracleDbType.Varchar2).Value = ENFERMERO_RUTENFERMERO;
                consulta.Parameters.Add("fk_cirujano", OracleDbType.Varchar2).Value = CIRUJANO_RUTCIRUJANO;
                consulta.Parameters.Add("fk_pabellonero", OracleDbType.Varchar2).Value = "18213925-4";
                consulta.Parameters.Add("fk_anestesista", OracleDbType.Varchar2).Value = ANESTSISTA_RUTANESTE;
                consulta.Parameters.Add("fk_tanestesia", OracleDbType.Varchar2).Value = TANESTESISTA_RUTTENANES;
                consulta.Parameters.Add("fk_arsenalero", OracleDbType.Varchar2).Value = ARSENALERO_RUTARSENA;
                consulta.Parameters.Add("fk_especialidad", OracleDbType.Int64).Value = ESPECIALIDAD_IDESPECIALIDAD;
                consulta.Parameters.Add("fk_estado", OracleDbType.Int64).Value = ESTADO_IDESTADO;

                consulta.ExecuteNonQuery();


            }

        }

        public static void ActualizarEstado(int IDAGENDA, int ESTADO_IDESTADO)
        {
            using (OracleConnection conn = Conexion.conectar())
            {
                conn.Open();
                OracleCommand consulta = new OracleCommand("PRACTUALIZARESTADO", conn);
                consulta.CommandType = CommandType.StoredProcedure;
                consulta.Parameters.Add("xidagenda", OracleDbType.Int64).Value = IDAGENDA;
                consulta.Parameters.Add("fk_estado", OracleDbType.Int64).Value = ESTADO_IDESTADO;
                consulta.ExecuteNonQuery();


            }

        }

        
    }
}
