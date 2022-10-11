using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AppEscritorio
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
       
        
        [STAThread]
        static void Main()
        {


            //Colocaciones.FrmMedioElectronico obFrm = new Colocaciones.FrmMedioElectronico();
            //obFrm.ShowDialog();
            //return;

            //Colocaciones.FrmXML_ICFMP obFrm = new Colocaciones.FrmXML_ICFMP();
            //obFrm.ShowDialog();
            //return;

            //Colocaciones.FrmXML_ICFPC obFrm = new Colocaciones.FrmXML_ICFPC();
            //obFrm.ShowDialog();
            //return;

            //return;

            ////  Colocaciones.FrmPlanillas obj = new Colocaciones.FrmPlanillas();
            ////  obj.ShowDialog();
            ////  Tesoreria.FrmConciBancos obj = new Tesoreria.FrmConciBancos();
            ////  obj.ShowDialog();

            //Cobros.FrmCancCreditos obj = new Cobros.FrmCancCreditos();
            //obj.ShowDialog();
            //return;

            //Captacion.FrmGestionExcedentes obj = new Captacion.FrmGestionExcedentes();
            //obj.ShowDialog();
            //return;

            //Colocaciones.FrmVendedores obj = new Colocaciones.FrmVendedores();
            //obj.ShowDialog();
            //return;

            //General.FrmReingresos obj = new General.FrmReingresos();
            //obj.ShowDialog();
            //return;

            //General.FrmNominaCGP obj = new General.FrmNominaCGP();
            //obj.ShowDialog();
            //return;

            //General.FrmCargarPagosCGP obj = new General.FrmCargarPagosCGP();
            //obj.ShowDialog();
            //return;



            FrmLogin fLogin = new FrmLogin();
            fLogin.ShowDialog();
            if (FrmLogin.UsuarioValidado)
            {
                Application.Run(new FrmMain());
            }



        }
    }
}
