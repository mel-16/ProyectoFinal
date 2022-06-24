

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoFinal.DAL;
using ProyectoFinal.BLL;

namespace ProyectoFinal.PL
{
  public partial class FrmHeladerias : Form
{
    public FrmHeladerias()
    {
        InitializeComponent();
    }



        private void btnsi_Click(object sender, EventArgs e)
        {
            //Intrucion GUI (obtener informacion de la precentacion)
            RecuperarInformacion();

            ConexionDAL conexion = new ConexionDAL();
           
            MessageBox.Show("Conectado.."+ conexion.PruebaConectar());
 }
        private void RecuperarInformacion() {
            HeladeriaBLL oHeladeria = new HeladeriaBLL();

            int NumeroID = 0; int.TryParse(Text, out NumeroID);

            oHeladeria.NumeroID = NumeroID;

            oHeladeria.Nombre = txtnomb.Text;

            oHeladeria.Direccion = txtdireccion.Text;

            oHeladeria.Refrencia1 = txtref.Text;

            oHeladeria.Referencia2 = txtrerf2.Text;

            MessageBox.Show(oHeladeria.NumeroID.ToString());
            MessageBox.Show(oHeladeria.Nombre);
            MessageBox.Show(oHeladeria.Direccion);
            MessageBox.Show(oHeladeria.Refrencia1);
            MessageBox.Show(oHeladeria.Referencia2);

        }
    }
}