using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppEscritorio
{
    public class AdministracionFormularios
    {

        public AdministracionFormularios()
        {

        }

        public void AbrirFormulario(string Pantalla,Form objMdi)
        {
            try
            {

                //foreach (Form frm in Application.OpenForms)
                //{

                //    if (frm.Name != "FrmMain" && frm.Name != "Frm" + Pantalla)
                //    {
                //        frm.Close();
                //    }


                //}

                ////Si el formulario ya esta abierto, no se vuelve abrir
                //foreach (Form frm in Application.OpenForms)
                //{
                //    if (frm.Name == "Frm" + Pantalla)
                //    {
                //        return;
                //    }

                //}

                switch (Pantalla)
                {
                    case "Usuarios":
                        General.FrmUsuarios objFrmUsuarios = new General.FrmUsuarios();
                        objFrmUsuarios.MdiParent = objMdi;
                        objFrmUsuarios.Show();
                        break;
                    case "Permisos":
                        General.FrmPermisos objFrmPermisos = new General.FrmPermisos();
                        objFrmPermisos.MdiParent = objMdi;
                        objFrmPermisos.Show();
                        break;
                    case "Especiales":
                        Colocaciones.FrmEspeciales objFrmEspeciales = new Colocaciones.FrmEspeciales();
                        objFrmEspeciales.MdiParent = objMdi;
                        objFrmEspeciales.Show();
                        break;
                    case "Operaciones":
                        Colocaciones.FrmCambVend objFrmCambVend = new Colocaciones.FrmCambVend();
                        objFrmCambVend.MdiParent = objMdi;
                        objFrmCambVend.Show();
                        break;
                    case "Traslados":
                        Captacion.FrmAhorros objFrmCertiCredito = new Captacion.FrmAhorros();
                        objFrmCertiCredito.MdiParent = objMdi;
                        objFrmCertiCredito.Show();
                        break;
                    case "Avaluos":
                        Colocaciones.FrmAvaluos objFrmAvaluos = new Colocaciones.FrmAvaluos();
                        objFrmAvaluos.MdiParent = objMdi;
                        objFrmAvaluos.Show();
                        break;
                    case "Planillas":
                        Colocaciones.FrmPlanillas objFrmPlanillas = new Colocaciones.FrmPlanillas();
                        objFrmPlanillas.MdiParent = objMdi;
                        objFrmPlanillas.Show();
                        break;
                    case "MoviBank":
                        Tesoreria.FrmConciBancos objFrmConciBancos  = new Tesoreria.FrmConciBancos();
                        objFrmConciBancos.MdiParent = objMdi;
                        objFrmConciBancos.Show();
                        break;
                    case "Liquidacion":
                        Captacion.FrmLiquidacion objFrmLiquidacion = new Captacion.FrmLiquidacion();
                        objFrmLiquidacion.MdiParent = objMdi;
                        objFrmLiquidacion.Show();
                        break;
                    case "Categoría Comercial":
                        Captacion.FrmCategoriaComercial objFrmCategoriaComercial = new Captacion.FrmCategoriaComercial();
                        objFrmCategoriaComercial.MdiParent = objMdi;
                        objFrmCategoriaComercial.Show();
                        break;
                    case "Vendedor":
                        Colocaciones.FrmVendedores objFrmVendedores = new Colocaciones.FrmVendedores();
                        objFrmVendedores.MdiParent = objMdi;
                        objFrmVendedores.Show();
                        break;
                    case "NominaCGP":
                        General.FrmNominaCGP objFrmNominaCGP = new General.FrmNominaCGP();
                        objFrmNominaCGP.MdiParent = objMdi;
                        objFrmNominaCGP.Show();
                        break;
                    case "PagosCGP":
                        General.FrmCargarPagosCGP objFrmPagoCGP = new General.FrmCargarPagosCGP();
                        objFrmPagoCGP.MdiParent = objMdi;
                        objFrmPagoCGP.Show();
                        break;
                    case "CancIncob":
                        Cobros.FrmCancCreditos objCancCreditos = new Cobros.FrmCancCreditos();
                        objCancCreditos.MdiParent = objMdi;
                        objCancCreditos.Show();
                        break;
                    case "GestExced":
                        Captacion.FrmGestionExcedentes objGestionExcedentes = new Captacion.FrmGestionExcedentes();
                        objGestionExcedentes.MdiParent = objMdi;
                        objGestionExcedentes.Show();
                        break;
                    case "Reingresos":
                        General.FrmReingresos objReingresos = new General.FrmReingresos();
                        objReingresos.MdiParent = objMdi;
                        objReingresos.Show();
                        break;
                    case "Inactivo":
                        General.FrmInaAsociados objInaAsociados = new General.FrmInaAsociados();
                        objInaAsociados.MdiParent = objMdi;
                        objInaAsociados.Show();
                        break;
                    case "ICFPC":
                        Colocaciones.FrmXML_ICFPC objFrmXML_ICFPC = new Colocaciones.FrmXML_ICFPC();
                        objFrmXML_ICFPC.MdiParent = objMdi;
                        objFrmXML_ICFPC.Show();
                        break;
                    case "ICFMP":
                        Colocaciones.FrmXML_ICFMP objFrmXML_ICFMP = new Colocaciones.FrmXML_ICFMP();
                        objFrmXML_ICFMP.MdiParent = objMdi;
                        objFrmXML_ICFMP.Show();
                        break;
                    case "Prorroga":
                        Colocaciones.FrmXmlProrrogas objFrmProrrgas = new Colocaciones.FrmXmlProrrogas();
                        objFrmProrrgas.MdiParent = objMdi;
                        objFrmProrrgas.Show();
                        break;
                    case "Con.Intercooperativa":
                        Colocaciones.FrmConsultaIntercooperativa objFrmConsultaIntercooperativa = new Colocaciones.FrmConsultaIntercooperativa();
                        objFrmConsultaIntercooperativa.MdiParent = objMdi;
                        objFrmConsultaIntercooperativa.Show();
                        break;
                    case "Cambio Climático":
                        Colocaciones.FrmXML_CambioClimatico objFrmClimatico = new Colocaciones.FrmXML_CambioClimatico();
                        objFrmClimatico.MdiParent = objMdi;
                        objFrmClimatico.Show();
                        break;
                    case "Actividad Económica":
                        Sugef.FrmActividadEconomica objFrmActividad = new Sugef.FrmActividadEconomica();
                        objFrmActividad.MdiParent = objMdi;
                        objFrmActividad.Show();
                        break;
                    case "Transacciones XML 50":
                        Sugef.FrmXML_TransaccionesMayores objFrmTransacciones = new Sugef.FrmXML_TransaccionesMayores();
                        objFrmTransacciones.MdiParent = objMdi;
                        objFrmTransacciones.Show();
                        break;
                    default:
                        MessageBox.Show("No existe Formulario");
                        break;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("[FrmMain_AbrirFormulario]" + ex.Message + "->" + ex.StackTrace);
            }
        }
    }
}
