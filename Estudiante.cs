using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace ConBase
{
    public class Estudiante
    {
        SqlConnection conn;
        string miConexion = ConfigurationManager.ConnectionStrings["Cadena"].ConnectionString;

        public Estudiante()
        {

        }
        public string InsertaEstudiante(string Nombre, string ApellidoPaterno, string ApellidoMaterno,
            string Edad, string Correo, int EstudiaActualemente,string NombreInstituto,string Direccion, string Fono )
        {
            string mensaje = null;
            try
            {
                conn = new SqlConnection(miConexion);
                conn.Open();

                SqlCommand cmd = new SqlCommand("InsertaEstudiante", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                #region entrega los parametros al procedimiento
                cmd.Parameters.Add("@Nombre", SqlDbType.VarChar, 255);
                cmd.Parameters["@Nombre"].Value = Nombre;

                cmd.Parameters.Add("@ApellidoPaterno", SqlDbType.VarChar, 255);
                cmd.Parameters["@ApellidoPaterno"].Value = ApellidoPaterno;

                cmd.Parameters.Add("@ApellidoMaterno", SqlDbType.VarChar, 255);
                cmd.Parameters["@ApellidoMaterno"].Value = ApellidoMaterno;

                cmd.Parameters.Add("@Edad", SqlDbType.Int);
                cmd.Parameters["@Edad"].Value = Edad;

                cmd.Parameters.Add("@Correo", SqlDbType.VarChar, 64);
                cmd.Parameters["@Correo"].Value = Correo;

                cmd.Parameters.Add("@EstaEstudiando", SqlDbType.Bit);
                cmd.Parameters["@EstaEstudiando"].Value = EstudiaActualemente;

                cmd.Parameters.Add("@NombreInstituto", SqlDbType.VarChar, 255);
                cmd.Parameters["@NombreInstituto"].Value = NombreInstituto;

                cmd.Parameters.Add("@Direccion", SqlDbType.VarChar, 255);
                cmd.Parameters["@Direccion"].Value = Direccion;

                cmd.Parameters.Add("@Fono", SqlDbType.VarChar, 64);
                cmd.Parameters["@Fono"].Value = Fono;
                #endregion
                #region Ejecute el procedimiento Almacenado
                cmd.ExecuteNonQuery();
                #endregion
                #region mensaje al usuario
                mensaje = "Datos ingresados correctamente";
                #endregion
                #region Cierra la conexion
                conn.Close();
                #endregion

            }
            catch (Exception ex)
	        {

		        mensaje =ex.Message.ToString();
	        }
            return mensaje;
        }
        public string InsertaModulo(string Nombre,string Codigo, int Activo)
        {
            string mensaje = null;
            try
            {
                #region abrir conexion
                conn = new SqlConnection(miConexion);
                conn.Open();

                SqlCommand cmd = new SqlCommand("InsertaModulo", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                #endregion

                #region entrega los parametros al procedimiento de mod modulo
                cmd.Parameters.Add("@Nombre", SqlDbType.VarChar, 255);
                cmd.Parameters["@Nombre"].Value = Nombre;

                cmd.Parameters.Add("@Codigo", SqlDbType.VarChar, 30);
                cmd.Parameters["@Codigo"].Value = Codigo;

                cmd.Parameters.Add("@Activo", SqlDbType.Bit);
                cmd.Parameters["@Activo"].Value = Activo;

                #endregion
                #region Ejecute el procedimiento Almacenado
                cmd.ExecuteNonQuery();
                #endregion
                #region mensaje al usuario
                mensaje = "Datos ingresados correctamente";
                #endregion
                #region Cierra la conexion
                conn.Close();
                #endregion

            }
            catch (Exception ex)
            {
                mensaje = ex.Message.ToString();
            }
            return mensaje;
        }
        public DataTable CargaComboEstudiante()
        {
            SqlDataReader dr = null;
            DataTable dt = new DataTable();
            try
            {
                #region abrir conexion
                conn = new SqlConnection(miConexion);
                conn.Open();
                #endregion
                #region llamar al procedimiento
                SqlCommand cmd = new SqlCommand("ListaEstudiante", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                #endregion
                #region Ejecutar el procedimiento
                dr = cmd.ExecuteReader();
                #endregion
                #region Cargar DataTable
                dt.Load(dr);
                #endregion
                #region cerrar conexion
                conn.Close();
                #endregion
                return dt;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public DataTable CargaGrillaEstudiante(string EstudianteID)
        {
            SqlDataReader dr = null;
            DataTable dt = new DataTable();
            try
            {
                #region abrir conexion
                conn = new SqlConnection(miConexion);
                conn.Open();
                #endregion
                #region llamo al procedimiento
                SqlCommand cmd = new SqlCommand("DetalleEstudiante", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                #endregion
                #region Entregar los parametros al procedimiento
                cmd.Parameters.Add("@EstudianteID", SqlDbType.Int);
                cmd.Parameters["@EstudianteID"].Value = EstudianteID;
                #endregion
                #region Ejecutar el procedimiento
                dr = cmd.ExecuteReader();
                #endregion
                #region Cargar DataTable
                dt.Load(dr);
                #endregion
                #region cerrar conexion
                conn.Close();
                #endregion
                return dt;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public DataTable CargaComboModulo()
        {
            SqlDataReader dr = null;
            DataTable dt = new DataTable();
            try
            {
                #region abrir conexion
                conn = new SqlConnection(miConexion);
                conn.Open();
                #endregion
                #region llamar al procedimiento
                SqlCommand cmd = new SqlCommand("ListaModulo", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                #endregion
                #region Ejecutar el procedimiento
                dr = cmd.ExecuteReader();
                #endregion
                #region Cargar DataTable
                dt.Load(dr);
                #endregion
                #region cerrar conexion
                conn.Close();
                #endregion
                return dt;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public string InsertaEstudianteModulo(int ModuloID, int EstudianteID)
        {
            string mensaje = null;
            try
            {
                conn = new SqlConnection(miConexion);
                conn.Open();

                SqlCommand cmd = new SqlCommand("InsertaEstudianteModulo", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                #region entrega los parametros al procedimiento
                cmd.Parameters.Add("@MoluloID", SqlDbType.VarChar, 255);
                cmd.Parameters["@MoluloID"].Value = ModuloID;

                cmd.Parameters.Add("@EstudianteID", SqlDbType.VarChar, 255);
                cmd.Parameters["@EstudianteID"].Value = EstudianteID;
                                
                #endregion
                #region Ejecute el procedimiento Almacenado
                cmd.ExecuteNonQuery();
                #endregion
                #region mensaje al usuario
                mensaje = "Datos ingresados correctamente";
                #endregion
                #region Cierra la conexion
                conn.Close();
                #endregion

            }
            catch (Exception ex)
            {

                mensaje = ex.Message.ToString();
            }
            return mensaje;
        }
        public DataTable CargaGrillaPorModulo(string ModuloID)
        {
            SqlDataReader dr = null;
            DataTable dt = new DataTable();
            try
            {
                #region abrir conexion
                conn = new SqlConnection(miConexion);
                conn.Open();
                #endregion
                #region llamo al procedimiento
                SqlCommand cmd = new SqlCommand("ListaEstudiantesPorModulo", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                #endregion
                #region Entregar los parametros al procedimiento
                cmd.Parameters.Add("@ModuloID", SqlDbType.Int);
                cmd.Parameters["@ModuloID"].Value = ModuloID;
                #endregion
                #region Ejecutar el procedimiento
                dr = cmd.ExecuteReader();
                #endregion
                #region Cargar DataTable
                dt.Load(dr);
                #endregion
                #region cerrar conexion
                conn.Close();
                #endregion
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }

        public DataTable VerificacionUsuario(string Usuario, string Clave)
            { 
            
            SqlDataReader dr = null;
            DataTable dt = new DataTable();
            try
            {
                conn = new SqlConnection(miConexion);
               conn.Open();

                SqlCommand cmd = new SqlCommand("AutoIdentificacion", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                #region entrega los parametros al procedimiento
                cmd.Parameters.Add("@User", SqlDbType.VarChar, 255);
                cmd.Parameters["@User"].Value = Usuario;

                cmd.Parameters.Add("@Clave", SqlDbType.VarChar, 255);
                cmd.Parameters["@Clave"].Value = Clave ;

                #endregion
                #region Ejecute el procedimiento Almacenado
                dr = cmd.ExecuteReader();
                dt.Load(dr);
                #endregion
               
                #region Cierra la conexion
                conn.Close();
                #endregion
             //   return dt;

            }
            catch (Exception ex)
	        {

		        ex.Message.ToString();
	        }
            return dt;
            
            }
    }
}
