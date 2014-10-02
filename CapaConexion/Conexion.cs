using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
namespace CapaConexion
{
    public class Conexion : Mysql
    {        
        public static string CadenaConexion { get; set; }
        public static string BaseDatos { get; set; }
        public static string Usuario { get; set; }
        public static string Contraseña { get; set; }
        public static string Servidor { get; set; }
        public static string Puerto { get; set; }

        public static void iniciar(String BaseDatos, String Puerto, String Servidor, String Usuario, String Contrasena)
        {
            Conexion.BaseDatos = BaseDatos;
            Conexion.Usuario = Usuario;
            Conexion.BaseDatos = Contrasena;
            Conexion.Servidor = Servidor;
            Conexion.Puerto = Puerto;
            CadenaConexion = String.Format(" Server = {0}; Port = {1}; Database = {2}; Uid = {3};Pwd = {4};", Servidor, Puerto, BaseDatos, Usuario, Contrasena);

        }



    }
}
