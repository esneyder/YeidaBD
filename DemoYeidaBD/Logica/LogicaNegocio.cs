using DemoYeidaBD.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YeiBD;


namespace DemoYeidaBD.Logica
{
    
    public class LogicaNegocio
    {//ya cada uno organiza su conexión
        YeiConnection cnn = new YeiConnection(Conexion.Conexion.server, Conexion.Conexion.database, Conexion.Conexion.username, Conexion.Conexion.pass, false);
        private string mensaje;
        public string Mensaje {
            get { return mensaje; }
        }

        #region Obtener personas
        public void getPesonas() {
            if (!cnn.OpenConnection()) {
                cnn.CloseConnection();
            }
            cnn.SQL = "select * from persona";
            DataTable dt = cnn.Search(false);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Console.WriteLine("Nombre: " +   " " + "Apellido: " + dt.Rows[i]["nombre"].ToString().Trim() + " "  + dt.Rows[i]["apodo"].ToString().Trim());
                
            }
            Console.ReadLine();



        }
        #endregion


        #region Guardar persona

        public bool NuevaPersona(Persona persona) {
            if (!cnn.OpenConnection()) {
                mensaje = cnn.Error;
                cnn.CloseConnection();
                return false;
            }
            cnn.SQL = "insert into persona values ('"+persona.Nombre+"','"+persona.Apellido+"','"+persona.Apodo+"')";

            if (!cnn.executeQuery(false)) {
                mensaje = cnn.Error;
                cnn.CloseConnection();
                return false;
            }
            mensaje = "Registro ingresado correctamente!";
            cnn.CloseConnection();

            return true;
        }

        #endregion

        #region Actualizar personas
        public bool ActualizarPersona(Persona persona)
        {
            if (!cnn.OpenConnection())
            {
                mensaje = cnn.Error;
                cnn.CloseConnection();
                return false;
            }
            cnn.SQL = "update persona set nombre='"+persona.Nombre+"',apellido='"+persona.Apellido+"',apodo='"+persona.Apellido+"' where id="+persona.Id;

            if (!cnn.executeQuery(false))
            {
                mensaje = cnn.Error;
                cnn.CloseConnection();
                return false;
            }
            mensaje = "Registro actualizado correctamente!";
            cnn.CloseConnection();

            return true;
        }

        #endregion

        #region eliminar persona
        public bool EliminarPersona(int idpersona)
        {
            if (!cnn.OpenConnection())
            {
                mensaje = cnn.Error;
                cnn.CloseConnection();
                return false;
            }
            cnn.SQL = "delete from persona where id="+idpersona;

            if (!cnn.executeQuery(false))
            {
                mensaje = cnn.Error;
                cnn.CloseConnection();
                return false;
            }
            mensaje = "Registro eliminado correctamente!";
            cnn.CloseConnection();

            return true;
        }
        #endregion
    }
}
