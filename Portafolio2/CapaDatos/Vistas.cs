using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using CapaEntidades;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;


namespace CapaDatos
{
    public class Vistas
    {
        public static List<Paciente> VistaPacientes()
        {

            using (OracleConnection conn = Conexion.conectar())
            {
                conn.Open();
                List<Paciente> nuevaLista = new List<Paciente>();
                OracleCommand consulta = new OracleCommand("prMostrarPaciente", conn);
                consulta.CommandType = CommandType.StoredProcedure;
                consulta.Parameters.Add("p_cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                consulta.ExecuteNonQuery();
                OracleDataReader dr = ((OracleRefCursor)consulta.Parameters["p_cursor"].Value).GetDataReader();
                while (dr.Read())
                {
                    Paciente paciente = new Paciente();
                    paciente.Rut = dr[0].ToString();
                    paciente.Nombre = dr[1].ToString();
                    paciente.Apellido = dr[2].ToString();
                    paciente.Edad = int.Parse(dr[3].ToString());
                    paciente.Fono = int.Parse(dr[4].ToString());
                    paciente.Email = dr[5].ToString();
                    nuevaLista.Add(paciente);
                }



                conn.Close();

                return nuevaLista;
            }
        }

        public static List<Usuario> VistaUsuario()
        {

            using (OracleConnection conn = Conexion.conectar())
            {
                conn.Open();
                List<Usuario> nuevaLista = new List<Usuario>();
                OracleCommand consulta = new OracleCommand("prMostrarUsuario", conn);
                consulta.CommandType = CommandType.StoredProcedure;
                consulta.Parameters.Add("p_cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                consulta.ExecuteNonQuery();
                OracleDataReader dr = ((OracleRefCursor)consulta.Parameters["p_cursor"].Value).GetDataReader();
                while (dr.Read())
                {
                    Usuario nuevo = new Usuario();
                    nuevo.Rutusuario = dr[0].ToString();
                    nuevo.Nombre = dr[1].ToString();
                    nuevo.Apellido = dr[2].ToString();
                    nuevo.Fono = int.Parse(dr[3].ToString());
                    nuevo.Email = dr[4].ToString();
                    nuevo.Pass = dr[5].ToString();
                    nuevaLista.Add(nuevo);
                }



                conn.Close();

                return nuevaLista;
            }
        }

        public static List<Roles> VistaRoles()
        {

            using (OracleConnection conn = Conexion.conectar())
            {
                conn.Open();
                List<Roles> nuevaLista = new List<Roles>();
                OracleCommand consulta = new OracleCommand("prMostrarRoles", conn);
                consulta.CommandType = CommandType.StoredProcedure;
                consulta.Parameters.Add("p_cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                consulta.ExecuteNonQuery();
                OracleDataReader dr = ((OracleRefCursor)consulta.Parameters["p_cursor"].Value).GetDataReader();
                while (dr.Read())
                {
                    Roles nuevo = new Roles();
                    nuevo.IdRoles = int.Parse(dr[0].ToString());
                    nuevo.Perfil = dr[1].ToString();
                    nuevaLista.Add(nuevo);
                }



                conn.Close();

                return nuevaLista;
            }
        }

        public static List<Especialidad> VistaEspecialidada()
        {

            using (OracleConnection conn = Conexion.conectar())
            {
                conn.Open();
                List<Especialidad> nuevaLista = new List<Especialidad>();
                OracleCommand consulta = new OracleCommand("prmostrarespecialidad", conn);
                consulta.CommandType = CommandType.StoredProcedure;
                consulta.Parameters.Add("p_cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                consulta.ExecuteNonQuery();
                OracleDataReader dr = ((OracleRefCursor)consulta.Parameters["p_cursor"].Value).GetDataReader();
                while (dr.Read())
                {
                    Especialidad nuevo = new Especialidad();
                    nuevo.Idespecialidad = int.Parse(dr[0].ToString());
                    nuevo.Tipos = dr[1].ToString();
                    nuevaLista.Add(nuevo);
                }



                conn.Close();

                return nuevaLista;
            }
        }

        public static List<Estado> VistaEstado()
        {

            using (OracleConnection conn = Conexion.conectar())
            {
                conn.Open();
                List<Estado> nuevaLista = new List<Estado>();
                OracleCommand consulta = new OracleCommand("prmostrarestado", conn);
                consulta.CommandType = CommandType.StoredProcedure;
                consulta.Parameters.Add("p_cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                consulta.ExecuteNonQuery();
                OracleDataReader dr = ((OracleRefCursor)consulta.Parameters["p_cursor"].Value).GetDataReader();
                while (dr.Read())
                {
                    Estado nuevo = new Estado();
                    nuevo.Idestado = int.Parse(dr[0].ToString());
                    nuevo.Situacion = dr[1].ToString();
                    nuevaLista.Add(nuevo);
                }



                conn.Close();

                return nuevaLista;
            }
        }

        public static List<U_roles> VistaUroles()
        {

            using (OracleConnection conn = Conexion.conectar())
            {
                conn.Open();
                Usuario usuario = new Usuario();
                List<U_roles> nuevaLista = new List<U_roles>();
                OracleCommand consulta = new OracleCommand("prMostrarURoles", conn);
                consulta.CommandType = CommandType.StoredProcedure;
                consulta.Parameters.Add("p_cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                consulta.ExecuteNonQuery();
                OracleDataReader dr = ((OracleRefCursor)consulta.Parameters["p_cursor"].Value).GetDataReader();
                while (dr.Read())
                {

                    U_roles uroles = new U_roles();

                    uroles.Fk_Usuario = VistaUsuario().Where(a => a.Rutusuario == dr[0].ToString()).First();
                    uroles.Fk_Roles = VistaRoles().Where(a => a.IdRoles.ToString() == dr[1].ToString()).First();
                    nuevaLista.Add(uroles);
                }


                conn.Close();

                return nuevaLista;
            }
        }

        public static List<Pabellon> VistaPabellon()
        {

            using (OracleConnection conn = Conexion.conectar())
            {
                conn.Open();
                List<Pabellon> nuevaLista = new List<Pabellon>();
                OracleCommand consulta = new OracleCommand("prMostrarPabellon", conn);
                consulta.CommandType = CommandType.StoredProcedure;
                consulta.Parameters.Add("p_cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                consulta.ExecuteNonQuery();
                OracleDataReader dr = ((OracleRefCursor)consulta.Parameters["p_cursor"].Value).GetDataReader();
                while (dr.Read())
                {
                    Pabellon nuevo = new Pabellon();
                    nuevo.Idpabellon = int.Parse(dr[0].ToString());
                    nuevo.Tamaño = dr[1].ToString();
                    nuevo.Fk_Especialidad = VistaEspecialidada().Where(a => a.Idespecialidad.ToString() == dr[2].ToString()).First();
                    nuevo.Codigo = dr[3].ToString();
                    nuevaLista.Add(nuevo);
                }



                conn.Close();

                return nuevaLista;
            }
        }

        public static List<Cirujano> VistaCirujano()
        {

            using (OracleConnection conn = Conexion.conectar())
            {
                conn.Open();
                List<Cirujano> nuevaLista = new List<Cirujano>();
                OracleCommand consulta = new OracleCommand("prMostrarCirujano", conn);
                consulta.CommandType = CommandType.StoredProcedure;
                consulta.Parameters.Add("p_cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                consulta.ExecuteNonQuery();
                OracleDataReader dr = ((OracleRefCursor)consulta.Parameters["p_cursor"].Value).GetDataReader();
                while (dr.Read())
                {
                    Cirujano nuevo = new Cirujano();
                    nuevo.RutCirujano = dr[0].ToString();
                    nuevo.Nombre = dr[1].ToString();
                    nuevo.Apellido = dr[2].ToString();
                    nuevo.Fono = int.Parse(dr[3].ToString());
                    nuevo.Email = dr[4].ToString();
                    nuevo.Fk_Especialidad = VistaEspecialidada().Where(a => a.Idespecialidad.ToString() == dr[5].ToString()).First();
                    nuevaLista.Add(nuevo);
                }



                conn.Close();

                return nuevaLista;
            }
        }

        public static List<Pabellonero> VistaPabellonero()
        {

            using (OracleConnection conn = Conexion.conectar())
            {
                conn.Open();
                List<Pabellonero> nuevaLista = new List<Pabellonero>();
                OracleCommand consulta = new OracleCommand("prMostrarPabellonero", conn);
                consulta.CommandType = CommandType.StoredProcedure;
                consulta.Parameters.Add("p_cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                consulta.ExecuteNonQuery();
                OracleDataReader dr = ((OracleRefCursor)consulta.Parameters["p_cursor"].Value).GetDataReader();
                while (dr.Read())
                {
                    Pabellonero nuevo = new Pabellonero();
                    nuevo.Rutpabellonero = dr[0].ToString();
                    nuevo.Nombre = dr[1].ToString();
                    nuevo.Apellido = dr[2].ToString();
                    nuevo.Fono = int.Parse(dr[3].ToString());
                    nuevo.Email = dr[4].ToString();
                    nuevaLista.Add(nuevo);
                }



                conn.Close();

                return nuevaLista;
            }
        }

        public static List<Anestesista> VistanAnestesista()
        {

            using (OracleConnection conn = Conexion.conectar())
            {
                conn.Open();
                List<Anestesista> nuevaLista = new List<Anestesista>();
                OracleCommand consulta = new OracleCommand("prMostrarAnestesista", conn);
                consulta.CommandType = CommandType.StoredProcedure;
                consulta.Parameters.Add("p_cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                consulta.ExecuteNonQuery();
                OracleDataReader dr = ((OracleRefCursor)consulta.Parameters["p_cursor"].Value).GetDataReader();
                while (dr.Read())
                {
                    Anestesista nuevo = new Anestesista();
                    nuevo.Rutanestesista = dr[0].ToString();
                    nuevo.Nombre = dr[1].ToString();
                    nuevo.Apellido = dr[2].ToString();
                    nuevo.Fono = int.Parse(dr[3].ToString());
                    nuevo.Email = dr[4].ToString();
                    nuevaLista.Add(nuevo);
                }



                conn.Close();

                return nuevaLista;
            }
        }

        public static List<Arsenalero> VistanArsenalero()
        {

            using (OracleConnection conn = Conexion.conectar())
            {
                conn.Open();
                List<Arsenalero> nuevaLista = new List<Arsenalero>();
                OracleCommand consulta = new OracleCommand("prMostrarArsenalero", conn);
                consulta.CommandType = CommandType.StoredProcedure;
                consulta.Parameters.Add("p_cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                consulta.ExecuteNonQuery();
                OracleDataReader dr = ((OracleRefCursor)consulta.Parameters["p_cursor"].Value).GetDataReader();
                while (dr.Read())
                {
                    Arsenalero nuevo = new Arsenalero();
                    nuevo.Rutarsenalero = dr[0].ToString();
                    nuevo.Nombre = dr[1].ToString();
                    nuevo.Apellido = dr[2].ToString();
                    nuevo.Fono = int.Parse(dr[3].ToString());
                    nuevo.Email = dr[4].ToString();
                    nuevaLista.Add(nuevo);
                }



                conn.Close();

                return nuevaLista;
            }
        }

        public static List<Tanestesista> VistanTanestesista()
        {

            using (OracleConnection conn = Conexion.conectar())
            {
                conn.Open();
                List<Tanestesista> nuevaLista = new List<Tanestesista>();
                OracleCommand consulta = new OracleCommand("prMostrarTanestesista", conn);
                consulta.CommandType = CommandType.StoredProcedure;
                consulta.Parameters.Add("p_cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                consulta.ExecuteNonQuery();
                OracleDataReader dr = ((OracleRefCursor)consulta.Parameters["p_cursor"].Value).GetDataReader();
                while (dr.Read())
                {
                    Tanestesista nuevo = new Tanestesista();
                    nuevo.Ruttanestesista = dr[0].ToString();
                    nuevo.Nombre = dr[1].ToString();
                    nuevo.Apellido = dr[2].ToString();
                    nuevo.Fono = int.Parse(dr[3].ToString());
                    nuevo.Email = dr[4].ToString();
                    nuevaLista.Add(nuevo);
                }



                conn.Close();

                return nuevaLista;
            }
        }

        public static List<Enfermero> VistanEnfermero()
        {

            using (OracleConnection conn = Conexion.conectar())
            {
                conn.Open();
                List<Enfermero> nuevaLista = new List<Enfermero>();
                OracleCommand consulta = new OracleCommand("prMostrarEnfermero", conn);
                consulta.CommandType = CommandType.StoredProcedure;
                consulta.Parameters.Add("p_cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                consulta.ExecuteNonQuery();
                OracleDataReader dr = ((OracleRefCursor)consulta.Parameters["p_cursor"].Value).GetDataReader();
                while (dr.Read())
                {
                    Enfermero nuevo = new Enfermero();
                    nuevo.Rutenfermero = dr[0].ToString();
                    nuevo.Nombre = dr[1].ToString();
                    nuevo.Apellido = dr[2].ToString();
                    nuevo.Fono = int.Parse(dr[3].ToString());
                    nuevo.Email = dr[4].ToString();
                    nuevaLista.Add(nuevo);
                }



                conn.Close();

                return nuevaLista;
            }
        }

        public static List<Agenda> VistaAgenda()
        {

            using (OracleConnection conn = Conexion.conectar())
            {
                conn.Open();
                List<Agenda> nuevaLista = new List<Agenda>();
                OracleCommand consulta = new OracleCommand("prMostrarAgenda", conn);
                consulta.CommandType = CommandType.StoredProcedure;
                consulta.Parameters.Add("p_cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                consulta.ExecuteNonQuery();
                OracleDataReader dr = ((OracleRefCursor)consulta.Parameters["p_cursor"].Value).GetDataReader();
                while (dr.Read())
                {
                    Agenda nuevo = new Agenda();
                    nuevo.Idagenda = int.Parse(dr[0].ToString());
                    nuevo.Horainicio = dr[1].ToString();
                    nuevo.Horatermino = dr[2].ToString();
                    int duracion;
                    bool parse = int.TryParse(dr[3].ToString(), out duracion);
                    nuevo.Duracion = duracion;
                    DateTime tiempo;
                    bool validar = DateTime.TryParse(dr[4].ToString(), out tiempo);
                    nuevo.Fecha = tiempo;
                    nuevo.Aseo = dr[5].ToString();
                    List<Usuario> listausuario = VistaUsuario().Where(a => a.Rutusuario == dr[6].ToString()).ToList();
                    nuevo.Fk_Usuario = listausuario.First();


                    List<Paciente> listapaciente = VistaPacientes().Where(a => a.Rut == dr[7].ToString()).ToList();

                    if (listapaciente.Count() != 0)
                    {
                        nuevo.Fk_Paciente = listapaciente[0];
                    }



                    List<Pabellon> listapabellon = VistaPabellon().Where(a => a.Idpabellon.ToString() == dr[8].ToString()).ToList();
                    if (listapabellon.Count() != 0)
                    {
                        nuevo.Fk_Pabellon = listapabellon[0];
                    }

                    List<Enfermero> listaenfermero = VistanEnfermero().Where(a => a.Rutenfermero == dr[9].ToString()).ToList();
                    if (listaenfermero.Count() != 0)
                    {
                        nuevo.Fk_Enfermero = listaenfermero[0];
                    }
                    else
                    {
                        Enfermero en = new Enfermero();
                        en.Nombre = "[No Especificado]";
                        en.Apellido = "";
                        nuevo.Fk_Enfermero = en;
                    }



                    List<Cirujano> listacirujano = VistaCirujano().Where(a => a.RutCirujano == dr[10].ToString()).ToList();
                    if (listacirujano.Count() != 0)
                    {
                        nuevo.Fk_Cirujano = listacirujano[0];
                    }



                    List<Pabellonero> listapabellonero = VistaPabellonero().Where(a => a.Rutpabellonero == dr[11].ToString()).ToList();
                    if (listapabellonero.Count() != 0)
                    {
                        nuevo.Fk_Pabellonero = listapabellonero[0];
                    }
                    else
                    {
                        Pabellonero pa = new Pabellonero();
                        pa.Nombre = "[No Especificado]";
                        pa.Apellido = "";
                        nuevo.Fk_Pabellonero = pa;
                    }

                    List<Anestesista> listaanestesista = VistanAnestesista().Where(a => a.Rutanestesista == dr[12].ToString()).ToList();
                    if (listaanestesista.Count == 0)
                    {
                        Anestesista an = new Anestesista();
                        an.Nombre = "[No Especificado]";
                        an.Apellido = "";
                        nuevo.Fk_Anestesista = an;
                    }
                    else
                    {
                        if (listaanestesista[0] != null)
                        {
                            nuevo.Fk_Anestesista = listaanestesista[0];
                        }
                    }

                    List<Tanestesista> listatanestesista = VistanTanestesista().Where(a => a.Ruttanestesista == dr[13].ToString()).ToList();
                    if (listatanestesista.Count() != 0)
                    {
                        nuevo.Fk_Tanestesia = listatanestesista[0];
                    }
                    else
                    {
                        Tanestesista ta = new Tanestesista();
                        ta.Nombre = "[No Especificado]";
                        ta.Apellido = "";
                        nuevo.Fk_Tanestesia = ta;
                    }

                    List<Arsenalero> listaarsenalero = VistanArsenalero().Where(a => a.Rutarsenalero == dr[14].ToString()).ToList();
                    if (listaarsenalero.Count() != 0)
                    {
                        nuevo.Fk_Arsenalero = listaarsenalero[0];
                    }
                    else
                    {
                        Arsenalero ar = new Arsenalero();
                        ar.Nombre = "[No Especificado]";
                        ar.Apellido = "";
                        nuevo.Fk_Arsenalero = ar;
                    }

                    nuevo.Fk_Especialidad = VistaEspecialidada().Where(a => a.Idespecialidad.ToString() == dr[15].ToString()).First();

                    nuevo.Fk_Estado = VistaEstado().Where(a => a.Idestado.ToString() == dr[16].ToString()).First();

                    nuevaLista.Add(nuevo);
                }



                conn.Close();

                return nuevaLista;
            }
        }

        public static List<Historial> VistaHistorial()
        {

            using (OracleConnection conn = Conexion.conectar())
            {
                conn.Open();
                List<Historial> nuevaLista = new List<Historial>();
                OracleCommand consulta = new OracleCommand("prmostrarhistorial", conn);
                consulta.CommandType = CommandType.StoredProcedure;
                consulta.Parameters.Add("p_cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                consulta.ExecuteNonQuery();
                OracleDataReader dr = ((OracleRefCursor)consulta.Parameters["p_cursor"].Value).GetDataReader();
                while (dr.Read())
                {
                    Historial nuevo = new Historial();
                    nuevo.IdHistorial = int.Parse(dr[0].ToString());
                    nuevo.Fecha = DateTime.Parse(dr[1].ToString());
                    nuevo.Tipo = dr[2].ToString();
                    nuevo.Fk_idAgenda = VistaAgenda().Where(a => a.Idagenda == int.Parse(dr[3].ToString())).First();
                    nuevaLista.Add(nuevo);

                }



                conn.Close();

                return nuevaLista;
            }
        }

        public static List<Ocupado> VistaOcupado(String Cirugia, String pabellon, DateTime tiempo)
        {
            List<Ocupado> ocupado = new List<Ocupado>();
            int validar = Vistas.VistaAgenda().Where(a => a.Fk_Cirujano.Fk_Especialidad.Idespecialidad.ToString() == Cirugia).Where(a => a.Fk_Pabellon.Codigo == pabellon).Where(a => a.Fecha == tiempo || a.Fecha == tiempo.AddDays(-1)).Count();
            if (validar > 0)
            {
                DateTime prueba = tiempo.AddDays(-1);
                DateTime sumar = new DateTime();
                String[] horas = { "00:00", "01:00", "02:00", "03:00", "04:00", "05:00", "06:00", "07:00", "08:00", "09:00", "10:00", "11:00", "12:00", "13:00", "14:00", "15:00", "16:00", "17:00", "18:00", "19:00", "20:00", "21:00", "22:00", "23:00", "00:00" };

                while (prueba <= tiempo)
                {

                    for (int x = 0; x < horas.Length - 1; x++)
                    {

                        int das = Vistas.VistaAgenda().Where(a => a.Horainicio == horas[x]).Where(b => b.Fecha == prueba).Count();

                        if (das == 0)
                        {
                            Ocupado oc = new Ocupado();
                            oc.Hora = horas[x] + "-" + horas[x + 1];
                            oc.Estado = "Libre";
                            oc.Fecha = prueba;
                            ocupado.Add(oc);


                        }
                        else
                        {
                            int duracion = Vistas.VistaAgenda().Where(a => a.Horainicio == horas[x]).Where(b => b.Fecha == prueba).Select(a => a.Duracion).First();
                            for (int i = 0; i < duracion; i++)
                            {

                                if (x >= 24)
                                {
                                    if (x == 24)
                                    {
                                        sumar = prueba.AddDays(1);
                                        prueba = sumar;
                                        x = 0;
                                    }
                                    Ocupado oc = new Ocupado();
                                    oc.Hora = horas[x] + "-" + horas[x + 1];
                                    oc.Estado = "Ocupado";
                                    oc.Fecha = prueba;
                                    ocupado.Add(oc);
                                    x++;
                                }

                                else
                                {
                                    Ocupado oc = new Ocupado();
                                    oc.Hora = horas[x] + "-" + horas[x + 1]; ;
                                    oc.Estado = "Ocupado";
                                    oc.Fecha = prueba;
                                    ocupado.Add(oc);



                                    if (duracion != i + 1)    //Para que no hayan dos dt.Rows.Add seguidos
                                    {
                                        x++;
                                    }

                                }

                            }
                        }

                    }

                    sumar = prueba.AddDays(1);
                    prueba = sumar;
                }
            }
            else
            {
                String[] horas = { "00:00", "01:00", "02:00", "03:00", "04:00", "05:00", "06:00", "07:00", "08:00", "09:00", "10:00", "11:00", "12:00", "13:00", "14:00", "15:00", "16:00", "17:00", "18:00", "19:00", "20:00", "21:00", "22:00", "23:00", "00:00" };

                for (int x = 0; x < horas.Length - 1; x++)
                {


                    Ocupado oc = new Ocupado();
                    oc.Hora = horas[x] + "-" + horas[x + 1]; ;
                    oc.Estado = "Libre";
                    oc.Fecha = tiempo;
                    ocupado.Add(oc);



                }
            }

            return ocupado;
        }

        public static List<Ocupado> VistaOcupadoCirujano(String Cirujano, DateTime tiempo)
        {
            List<Ocupado> ocupado = new List<Ocupado>();
            int validar = Vistas.VistaAgenda().Where(a => a.Fk_Cirujano.RutCirujano == Cirujano).Where(a => a.Fecha == tiempo || a.Fecha == tiempo.AddDays(-1)).Count();
            if (validar > 0)
            {
                DateTime prueba = tiempo.AddDays(-1);
                DateTime sumar = new DateTime();
                String[] horas = { "00:00", "01:00", "02:00", "03:00", "04:00", "05:00", "06:00", "07:00", "08:00", "09:00", "10:00", "11:00", "12:00", "13:00", "14:00", "15:00", "16:00", "17:00", "18:00", "19:00", "20:00", "21:00", "22:00", "23:00", "00:00" };

                while (prueba <= tiempo)
                {

                    for (int x = 0; x < horas.Length - 1; x++)
                    {

                        int das = Vistas.VistaAgenda().Where(a => a.Horainicio == horas[x]).Where(b => b.Fecha == prueba).Where(a => a.Fk_Cirujano.RutCirujano == Cirujano).Count();

                        if (das == 0)
                        {
                            Ocupado oc = new Ocupado();
                            oc.Hora = horas[x] + "-" + horas[x + 1];
                            oc.Estado = "Libre";
                            oc.Fecha = prueba;
                            ocupado.Add(oc);


                        }
                        else
                        {
                            int duracion = Vistas.VistaAgenda().Where(a => a.Horainicio == horas[x]).Where(b => b.Fecha == prueba).Where(a => a.Fk_Cirujano.RutCirujano == Cirujano).Select(a => a.Duracion).First();
                            for (int i = 0; i < duracion; i++)
                            {

                                if (x >= 24)
                                {
                                    if (x == 24)
                                    {
                                        sumar = prueba.AddDays(1);
                                        prueba = sumar;
                                        x = 0;
                                    }
                                    Ocupado oc = new Ocupado();
                                    oc.Hora = horas[x] + "-" + horas[x + 1];
                                    oc.Estado = "Ocupado";
                                    oc.Fecha = prueba;
                                    ocupado.Add(oc);
                                    x++;
                                }

                                else
                                {
                                    Ocupado oc = new Ocupado();
                                    oc.Hora = horas[x] + "-" + horas[x + 1]; ;
                                    oc.Estado = "Ocupado";
                                    oc.Fecha = prueba;
                                    ocupado.Add(oc);



                                    if (duracion != i + 1)    //Para que no hayan dos dt.Rows.Add seguidos
                                    {
                                        x++;
                                    }

                                }

                            }
                        }

                    }

                    sumar = prueba.AddDays(1);
                    prueba = sumar;
                }
            }
            else
            {
                String[] horas = { "00:00", "01:00", "02:00", "03:00", "04:00", "05:00", "06:00", "07:00", "08:00", "09:00", "10:00", "11:00", "12:00", "13:00", "14:00", "15:00", "16:00", "17:00", "18:00", "19:00", "20:00", "21:00", "22:00", "23:00", "00:00" };

                for (int x = 0; x < horas.Length - 1; x++)
                {


                    Ocupado oc = new Ocupado();
                    oc.Hora = horas[x] + "-" + horas[x + 1]; ;
                    oc.Estado = "Libre";
                    oc.Fecha = tiempo;
                    ocupado.Add(oc);



                }
            }

            return ocupado;
        }

        public static List<Ocupado> VistaOcupadoAnestesista(String Anestesista, DateTime tiempo)
        {
            List<Ocupado> ocupado = new List<Ocupado>();
            int validar = Vistas.VistaAgenda().Where(a => a.Fk_Anestesista.Rutanestesista == Anestesista).Where(a => a.Fecha == tiempo || a.Fecha == tiempo.AddDays(-1)).Count();
            if (validar > 0)
            {
                DateTime prueba = tiempo.AddDays(-1);
                DateTime sumar = new DateTime();
                String[] horas = { "00:00", "01:00", "02:00", "03:00", "04:00", "05:00", "06:00", "07:00", "08:00", "09:00", "10:00", "11:00", "12:00", "13:00", "14:00", "15:00", "16:00", "17:00", "18:00", "19:00", "20:00", "21:00", "22:00", "23:00", "00:00" };

                while (prueba <= tiempo)
                {

                    for (int x = 0; x < horas.Length - 1; x++)
                    {

                        int das = Vistas.VistaAgenda().Where(a => a.Horainicio == horas[x]).Where(b => b.Fecha == prueba).Where(a => a.Fk_Anestesista.Rutanestesista == Anestesista).Count();

                        if (das == 0)
                        {
                            Ocupado oc = new Ocupado();
                            oc.Hora = horas[x] + "-" + horas[x + 1];
                            oc.Estado = "Libre";
                            oc.Fecha = prueba;
                            ocupado.Add(oc);


                        }
                        else
                        {
                            int duracion = Vistas.VistaAgenda().Where(a => a.Horainicio == horas[x]).Where(b => b.Fecha == prueba).Where(a => a.Fk_Anestesista.Rutanestesista == Anestesista).Select(a => a.Duracion).First();
                            for (int i = 0; i < duracion; i++)
                            {

                                if (x >= 24)
                                {
                                    if (x == 24)
                                    {
                                        sumar = prueba.AddDays(1);
                                        prueba = sumar;
                                        x = 0;
                                    }
                                    Ocupado oc = new Ocupado();
                                    oc.Hora = horas[x] + "-" + horas[x + 1];
                                    oc.Estado = "Ocupado";
                                    oc.Fecha = prueba;
                                    ocupado.Add(oc);
                                    x++;
                                }

                                else
                                {
                                    Ocupado oc = new Ocupado();
                                    oc.Hora = horas[x] + "-" + horas[x + 1]; ;
                                    oc.Estado = "Ocupado";
                                    oc.Fecha = prueba;
                                    ocupado.Add(oc);



                                    if (duracion != i + 1)    //Para que no hayan dos dt.Rows.Add seguidos
                                    {
                                        x++;
                                    }

                                }

                            }
                        }

                    }

                    sumar = prueba.AddDays(1);
                    prueba = sumar;
                }
            }
            else
            {
                String[] horas = { "00:00", "01:00", "02:00", "03:00", "04:00", "05:00", "06:00", "07:00", "08:00", "09:00", "10:00", "11:00", "12:00", "13:00", "14:00", "15:00", "16:00", "17:00", "18:00", "19:00", "20:00", "21:00", "22:00", "23:00", "00:00" };

                for (int x = 0; x < horas.Length - 1; x++)
                {


                    Ocupado oc = new Ocupado();
                    oc.Hora = horas[x] + "-" + horas[x + 1]; ;
                    oc.Estado = "Libre";
                    oc.Fecha = tiempo;
                    ocupado.Add(oc);



                }
            }

            return ocupado;
        }

        public static List<Ocupado> VistaOcupadoEnfermero(String Enfermero, DateTime tiempo)
        {
            List<Ocupado> ocupado = new List<Ocupado>();
            int validar = Vistas.VistaAgenda().Where(a => a.Fk_Enfermero.Rutenfermero == Enfermero).Where(a => a.Fecha == tiempo || a.Fecha == tiempo.AddDays(-1)).Count();
            if (validar > 0)
            {
                DateTime prueba = tiempo.AddDays(-1);
                DateTime sumar = new DateTime();
                String[] horas = { "00:00", "01:00", "02:00", "03:00", "04:00", "05:00", "06:00", "07:00", "08:00", "09:00", "10:00", "11:00", "12:00", "13:00", "14:00", "15:00", "16:00", "17:00", "18:00", "19:00", "20:00", "21:00", "22:00", "23:00", "00:00" };

                while (prueba <= tiempo)
                {

                    for (int x = 0; x < horas.Length - 1; x++)
                    {

                        int das = Vistas.VistaAgenda().Where(a => a.Horainicio == horas[x]).Where(b => b.Fecha == prueba).Where(a => a.Fk_Enfermero.Rutenfermero == Enfermero).Count();

                        if (das == 0)
                        {
                            Ocupado oc = new Ocupado();
                            oc.Hora = horas[x] + "-" + horas[x + 1];
                            oc.Estado = "Libre";
                            oc.Fecha = prueba;
                            ocupado.Add(oc);


                        }
                        else
                        {
                            int duracion = Vistas.VistaAgenda().Where(a => a.Horainicio == horas[x]).Where(b => b.Fecha == prueba).Where(a => a.Fk_Enfermero.Rutenfermero == Enfermero).Select(a => a.Duracion).First();
                            for (int i = 0; i < duracion; i++)
                            {

                                if (x >= 24)
                                {
                                    if (x == 24)
                                    {
                                        sumar = prueba.AddDays(1);
                                        prueba = sumar;
                                        x = 0;
                                    }
                                    Ocupado oc = new Ocupado();
                                    oc.Hora = horas[x] + "-" + horas[x + 1];
                                    oc.Estado = "Ocupado";
                                    oc.Fecha = prueba;
                                    ocupado.Add(oc);
                                    x++;
                                }

                                else
                                {
                                    Ocupado oc = new Ocupado();
                                    oc.Hora = horas[x] + "-" + horas[x + 1]; ;
                                    oc.Estado = "Ocupado";
                                    oc.Fecha = prueba;
                                    ocupado.Add(oc);



                                    if (duracion != i + 1)    //Para que no hayan dos dt.Rows.Add seguidos
                                    {
                                        x++;
                                    }

                                }

                            }
                        }

                    }

                    sumar = prueba.AddDays(1);
                    prueba = sumar;
                }
            }
            else
            {
                String[] horas = { "00:00", "01:00", "02:00", "03:00", "04:00", "05:00", "06:00", "07:00", "08:00", "09:00", "10:00", "11:00", "12:00", "13:00", "14:00", "15:00", "16:00", "17:00", "18:00", "19:00", "20:00", "21:00", "22:00", "23:00", "00:00" };

                for (int x = 0; x < horas.Length - 1; x++)
                {


                    Ocupado oc = new Ocupado();
                    oc.Hora = horas[x] + "-" + horas[x + 1]; ;
                    oc.Estado = "Libre";
                    oc.Fecha = tiempo;
                    ocupado.Add(oc);



                }
            }

            return ocupado;
        }

        public static List<Ocupado> VistaOcupadoArsenalero(String Arsenalero, DateTime tiempo)
        {
            List<Ocupado> ocupado = new List<Ocupado>();
            int validar = Vistas.VistaAgenda().Where(a => a.Fk_Arsenalero.Rutarsenalero == Arsenalero).Where(a => a.Fecha == tiempo || a.Fecha == tiempo.AddDays(-1)).Count();
            if (validar > 0)
            {
                DateTime prueba = tiempo.AddDays(-1);
                DateTime sumar = new DateTime();
                String[] horas = { "00:00", "01:00", "02:00", "03:00", "04:00", "05:00", "06:00", "07:00", "08:00", "09:00", "10:00", "11:00", "12:00", "13:00", "14:00", "15:00", "16:00", "17:00", "18:00", "19:00", "20:00", "21:00", "22:00", "23:00", "00:00" };

                while (prueba <= tiempo)
                {

                    for (int x = 0; x < horas.Length - 1; x++)
                    {

                        int das = Vistas.VistaAgenda().Where(a => a.Horainicio == horas[x]).Where(b => b.Fecha == prueba).Where(a => a.Fk_Arsenalero.Rutarsenalero == Arsenalero).Count();

                        if (das == 0)
                        {
                            Ocupado oc = new Ocupado();
                            oc.Hora = horas[x] + "-" + horas[x + 1];
                            oc.Estado = "Libre";
                            oc.Fecha = prueba;
                            ocupado.Add(oc);


                        }
                        else
                        {
                            int duracion = Vistas.VistaAgenda().Where(a => a.Horainicio == horas[x]).Where(b => b.Fecha == prueba).Where(a => a.Fk_Arsenalero.Rutarsenalero == Arsenalero).Select(a => a.Duracion).First();
                            for (int i = 0; i < duracion; i++)
                            {

                                if (x >= 24)
                                {
                                    if (x == 24)
                                    {
                                        sumar = prueba.AddDays(1);
                                        prueba = sumar;
                                        x = 0;
                                    }
                                    Ocupado oc = new Ocupado();
                                    oc.Hora = horas[x] + "-" + horas[x + 1];
                                    oc.Estado = "Ocupado";
                                    oc.Fecha = prueba;
                                    ocupado.Add(oc);
                                    x++;
                                }

                                else
                                {
                                    Ocupado oc = new Ocupado();
                                    oc.Hora = horas[x] + "-" + horas[x + 1]; ;
                                    oc.Estado = "Ocupado";
                                    oc.Fecha = prueba;
                                    ocupado.Add(oc);



                                    if (duracion != i + 1)    //Para que no hayan dos dt.Rows.Add seguidos
                                    {
                                        x++;
                                    }

                                }

                            }
                        }

                    }

                    sumar = prueba.AddDays(1);
                    prueba = sumar;
                }
            }
            else
            {
                String[] horas = { "00:00", "01:00", "02:00", "03:00", "04:00", "05:00", "06:00", "07:00", "08:00", "09:00", "10:00", "11:00", "12:00", "13:00", "14:00", "15:00", "16:00", "17:00", "18:00", "19:00", "20:00", "21:00", "22:00", "23:00", "00:00" };

                for (int x = 0; x < horas.Length - 1; x++)
                {


                    Ocupado oc = new Ocupado();
                    oc.Hora = horas[x] + "-" + horas[x + 1]; ;
                    oc.Estado = "Libre";
                    oc.Fecha = tiempo;
                    ocupado.Add(oc);



                }
            }

            return ocupado;
        }

        public static List<Ocupado> VistaOcupadoT_Anestesista(String T_Anestesista, DateTime tiempo)
        {
            List<Ocupado> ocupado = new List<Ocupado>();
            int validar = Vistas.VistaAgenda().Where(a => a.Fk_Tanestesia.Ruttanestesista == T_Anestesista).Where(a => a.Fecha == tiempo || a.Fecha == tiempo.AddDays(-1)).Count();
            if (validar > 0)
            {
                DateTime prueba = tiempo.AddDays(-1);
                DateTime sumar = new DateTime();
                String[] horas = { "00:00", "01:00", "02:00", "03:00", "04:00", "05:00", "06:00", "07:00", "08:00", "09:00", "10:00", "11:00", "12:00", "13:00", "14:00", "15:00", "16:00", "17:00", "18:00", "19:00", "20:00", "21:00", "22:00", "23:00", "00:00" };

                while (prueba <= tiempo)
                {

                    for (int x = 0; x < horas.Length - 1; x++)
                    {

                        int das = Vistas.VistaAgenda().Where(a => a.Horainicio == horas[x]).Where(b => b.Fecha == prueba).Where(a => a.Fk_Tanestesia.Ruttanestesista == T_Anestesista).Count();

                        if (das == 0)
                        {
                            Ocupado oc = new Ocupado();
                            oc.Hora = horas[x] + "-" + horas[x + 1];
                            oc.Estado = "Libre";
                            oc.Fecha = prueba;
                            ocupado.Add(oc);


                        }
                        else
                        {
                            int duracion = Vistas.VistaAgenda().Where(a => a.Horainicio == horas[x]).Where(b => b.Fecha == prueba).Where(a => a.Fk_Tanestesia.Ruttanestesista == T_Anestesista).Select(a => a.Duracion).First();
                            for (int i = 0; i < duracion; i++)
                            {

                                if (x >= 24)
                                {
                                    if (x == 24)
                                    {
                                        sumar = prueba.AddDays(1);
                                        prueba = sumar;
                                        x = 0;
                                    }
                                    Ocupado oc = new Ocupado();
                                    oc.Hora = horas[x] + "-" + horas[x + 1];
                                    oc.Estado = "Ocupado";
                                    oc.Fecha = prueba;
                                    ocupado.Add(oc);
                                    x++;
                                }

                                else
                                {
                                    Ocupado oc = new Ocupado();
                                    oc.Hora = horas[x] + "-" + horas[x + 1]; ;
                                    oc.Estado = "Ocupado";
                                    oc.Fecha = prueba;
                                    ocupado.Add(oc);



                                    if (duracion != i + 1)    //Para que no hayan dos dt.Rows.Add seguidos
                                    {
                                        x++;
                                    }

                                }

                            }
                        }

                    }

                    sumar = prueba.AddDays(1);
                    prueba = sumar;
                }
            }
            else
            {
                String[] horas = { "00:00", "01:00", "02:00", "03:00", "04:00", "05:00", "06:00", "07:00", "08:00", "09:00", "10:00", "11:00", "12:00", "13:00", "14:00", "15:00", "16:00", "17:00", "18:00", "19:00", "20:00", "21:00", "22:00", "23:00", "00:00" };

                for (int x = 0; x < horas.Length - 1; x++)
                {


                    Ocupado oc = new Ocupado();
                    oc.Hora = horas[x] + "-" + horas[x + 1]; ;
                    oc.Estado = "Libre";
                    oc.Fecha = tiempo;
                    ocupado.Add(oc);



                }
            }

            return ocupado;
        }

        public static List<Reporte> VistaReporte()
        {
            using (OracleConnection conn = Conexion.conectar())
            {
                conn.Open();
                List<Reporte> nuevaLista = new List<Reporte>();
                OracleCommand consulta = new OracleCommand("prreporte", conn);
                consulta.CommandType = CommandType.StoredProcedure;
                consulta.Parameters.Add("p_cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                consulta.ExecuteNonQuery();
                OracleDataReader dr = ((OracleRefCursor)consulta.Parameters["p_cursor"].Value).GetDataReader();
                while (dr.Read())
                {
                    Reporte nuevo = new Reporte();
                    nuevo.Fk_pabellon = VistaPabellon().Where(a => a.Idpabellon.ToString() == dr[0].ToString()).First();
                    nuevo.Fk_especialidad = VistaEspecialidada().Where(a => a.Idespecialidad.ToString() == dr[1].ToString()).First();
                    nuevo.Fk_estado = VistaEstado().Where(a => a.Idestado.ToString() == dr[3].ToString()).First();
                    int contar = VistaTotal().Where(a => a.Fecha == dr[4].ToString() && a.Idpabellon.ToString() == dr[0].ToString()).Count();

                    if (contar == 0)
                    {
                        nuevo.Total = 0;

                    }
                    else
                    {
                        int total = VistaTotal().Where(a => a.Idpabellon.ToString() == dr[0].ToString() && a.Fecha == dr[4].ToString()).Select(a => a.Total).First();
                        nuevo.Total = Math.Round((Double.Parse(dr[2].ToString()) * 100) / (Double)total, 1);

                    }

                    DateTime time;
                    time = DateTime.Parse(dr[4].ToString());
                    nuevo.Fecha = time.ToString("d");



                    nuevaLista.Add(nuevo);
                }



                conn.Close();

                return nuevaLista;
            }
        }

        public static List<Reporte> VistaReporte2()
        {
            using (OracleConnection conn = Conexion.conectar())
            {
                conn.Open();
                List<Reporte> nuevaLista = new List<Reporte>();
                OracleCommand consulta = new OracleCommand("prreporte2", conn);
                consulta.CommandType = CommandType.StoredProcedure;
                consulta.Parameters.Add("p_cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                consulta.ExecuteNonQuery();
                OracleDataReader dr = ((OracleRefCursor)consulta.Parameters["p_cursor"].Value).GetDataReader();
                while (dr.Read())
                {
                    Reporte nuevo = new Reporte();
                    nuevo.Fk_pabellon = VistaPabellon().Where(a => a.Idpabellon.ToString() == dr[0].ToString()).First();
                    nuevo.Fk_especialidad = VistaEspecialidada().Where(a => a.Idespecialidad.ToString() == dr[1].ToString()).First();

                    nuevo.Fk_estado = VistaEstado().Where(a => a.Idestado.ToString() == dr[3].ToString()).First();
                    int contar = VistaTotal2().Where(a => a.Fecha == dr[4].ToString() && a.Idpabellon.ToString() == dr[0].ToString()).Count();
                    if (contar == 0)
                    {
                        nuevo.Total = 0;

                    }
                    else
                    {
                        int total = VistaTotal2().Where(a => a.Fecha == dr[4].ToString() && a.Idpabellon.ToString() == dr[0].ToString()).Select(a => a.Total).First();
                        nuevo.Total = Math.Round((Double.Parse(dr[2].ToString()) * 100) / (Double)total, 1);

                    }
                    nuevo.Fecha = dr[4].ToString();
                    nuevaLista.Add(nuevo);
                }



                conn.Close();

                return nuevaLista;
            }
        }

        public static List<TotalPabellones> VistaTotal()
        {
            using (OracleConnection conn = Conexion.conectar())
            {
                conn.Open();
                List<TotalPabellones> nuevaLista = new List<TotalPabellones>();
                OracleCommand consulta = new OracleCommand("PRTOTALPABELLONES", conn);
                consulta.CommandType = CommandType.StoredProcedure;
                consulta.Parameters.Add("p_cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                consulta.ExecuteNonQuery();
                OracleDataReader dr = ((OracleRefCursor)consulta.Parameters["p_cursor"].Value).GetDataReader();
                while (dr.Read())
                {
                    TotalPabellones nuevo = new TotalPabellones();
                    nuevo.Idpabellon = int.Parse(dr[0].ToString());
                    nuevo.Total = int.Parse(dr[1].ToString());
                    nuevo.Fecha = dr[2].ToString();
                    nuevaLista.Add(nuevo);
                }



                conn.Close();

                return nuevaLista;
            }
        }

        public static List<TotalPabellones> VistaTotal2()
        {
            using (OracleConnection conn = Conexion.conectar())
            {
                conn.Open();
                List<TotalPabellones> nuevaLista = new List<TotalPabellones>();
                OracleCommand consulta = new OracleCommand("PRTOTALPABELLONES2", conn);
                consulta.CommandType = CommandType.StoredProcedure;
                consulta.Parameters.Add("p_cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                consulta.ExecuteNonQuery();
                OracleDataReader dr = ((OracleRefCursor)consulta.Parameters["p_cursor"].Value).GetDataReader();
                while (dr.Read())
                {
                    TotalPabellones nuevo = new TotalPabellones();
                    nuevo.Idpabellon = int.Parse(dr[0].ToString());
                    nuevo.Total = int.Parse(dr[1].ToString());
                    nuevo.Fecha = dr[2].ToString();
                    nuevaLista.Add(nuevo);
                }



                conn.Close();

                return nuevaLista;
            }
        }

        public static List<ReporteFinal> VistaReporteFinal(String fecha, int especialidad)
        {
            using (OracleConnection conn = Conexion.conectar())
            {
                conn.Open();
                List<ReporteFinal> nuevaLista = new List<ReporteFinal>();

                foreach (var item in VistaPabellon().Where(a => a.Fk_Especialidad.Idespecialidad == especialidad))
                {
                    ReporteFinal nuevo = new ReporteFinal();
                    nuevo.Fecha = fecha;
                    nuevo.Especialidad = VistaEspecialidada().Where(a => a.Idespecialidad == especialidad).Select(a => a.Tipos).First();
                    nuevo.Pabellon = item.Codigo;
                    

                    if (VistaReporte().Where(a => a.Fk_estado.Idestado == 1 && a.Fk_pabellon.Codigo == item.Codigo && a.Fecha == fecha).Select(a => a.Total).Count() == 0)
                    {
                        nuevo.Enproceso = "0%";
                    }
                    else
                    {
                        nuevo.Enproceso = VistaReporte().Where(a => a.Fk_estado.Idestado == 1 && a.Fk_pabellon.Codigo == item.Codigo && a.Fecha == fecha).Select(a => a.Total.ToString() + "%").First();

                    }

                    if (VistaReporte().Where(a => a.Fk_estado.Idestado == 2 && a.Fk_pabellon.Codigo == item.Codigo && a.Fecha == fecha).Select(a => a.Total).Count() == 0)
                    {
                        nuevo.Suspendido = "0%";
                    }
                    else
                    {
                        nuevo.Suspendido = VistaReporte().Where(a => a.Fk_estado.Idestado == 2 && a.Fk_pabellon.Codigo == item.Codigo && a.Fecha == fecha).Select(a => a.Total.ToString() + "%").First();

                    }

                    if (VistaReporte().Where(a => a.Fk_estado.Idestado == 3 && a.Fk_pabellon.Codigo == item.Codigo && a.Fecha == fecha).Select(a => a.Total).Count() == 0)
                    {
                        nuevo.Finalizado = "0%";
                    }
                    else
                    {
                        nuevo.Finalizado = VistaReporte().Where(a => a.Fk_estado.Idestado == 3 && a.Fk_pabellon.Codigo == item.Codigo && a.Fecha == fecha).Select(a => a.Total.ToString() + "%").First();

                    }
                    nuevaLista.Add(nuevo);


                }


                return nuevaLista;
            }
        }

        public static List<ReporteFinal> VistaReporteFinal2(String fecha, int especialidad)
        {
            using (OracleConnection conn = Conexion.conectar())
            {
                conn.Open();
                List<ReporteFinal> nuevaLista = new List<ReporteFinal>();

                foreach (var item in VistaPabellon().Where(a => a.Fk_Especialidad.Idespecialidad == especialidad))
                {
                    ReporteFinal nuevo = new ReporteFinal();
                    nuevo.Fecha = fecha;
                    nuevo.Especialidad = VistaEspecialidada().Where(a => a.Idespecialidad == especialidad).Select(a => a.Tipos).First();
                    nuevo.Pabellon = item.Codigo;
                    if (VistaReporte2().Where(a => a.Fk_estado.Idestado == 1 && a.Fk_pabellon.Codigo == item.Codigo && a.Fecha.Trim() == fecha).Count() == 0)
                    {
                        nuevo.Enproceso = "0%";
                    }
                    else
                    {
                        nuevo.Enproceso = VistaReporte2().Where(a => a.Fk_estado.Idestado == 1 && a.Fk_pabellon.Codigo == item.Codigo && a.Fecha.Trim() == fecha).Select(a => a.Total.ToString() + "%").First();

                    }

                    if (VistaReporte2().Where(a => a.Fk_estado.Idestado == 2 && a.Fk_pabellon.Codigo == item.Codigo && a.Fecha == fecha).Select(a => a.Total).Count() == 0)
                    {
                        nuevo.Suspendido = "0%";
                    }
                    else
                    {
                        nuevo.Suspendido = VistaReporte2().Where(a => a.Fk_estado.Idestado == 2 && a.Fk_pabellon.Codigo == item.Codigo && a.Fecha.Trim() == fecha).Select(a => a.Total.ToString() + "%").First();

                    }

                    if (VistaReporte2().Where(a => a.Fk_estado.Idestado == 3 && a.Fk_pabellon.Codigo == item.Codigo && a.Fecha == fecha).Select(a => a.Total).Count() == 0)
                    {
                        nuevo.Finalizado = "0%";
                    }
                    else
                    {
                        nuevo.Finalizado = VistaReporte2().Where(a => a.Fk_estado.Idestado == 3 && a.Fk_pabellon.Codigo == item.Codigo && a.Fecha.Trim() == fecha).Select(a => a.Total.ToString() + "%").First();

                    }
                    nuevaLista.Add(nuevo);


                }


                return nuevaLista;
            }
        }
    }
}

