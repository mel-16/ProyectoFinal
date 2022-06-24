using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.DAL

{
    private String CadenaConexion = "Data Source= 127.0.0.1 via TCP;=p_final;Integrated Security = True"
    internal class ConexionDAL
    {
        SqlConnection Conexion;

        public SqlConnection EstablecerConexion() {
            this.Conexion = new SqlConnection(this.CadenaConexion);
            return this.Conexion;
        }

        public bool PruebaConectar(){
            try{

                
                SqlCommand Comando = new SqlCommand();


                 Comando.CommandText = "SELECT* FROM Helados";
                Comando.Connection = Conexion;
                Conexion.Open();
                Comando.ExecuteNonQuery();
                Conexion.Close();

                return true;



            }catch{

                return false;
            }
        }
    }
} 

