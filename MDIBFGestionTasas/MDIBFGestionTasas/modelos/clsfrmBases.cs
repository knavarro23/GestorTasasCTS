using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDIBFGestionTasasDP.modelos
{
    public class clsfrmBases
    {
        public int Responsable { get; set; }
        public string Comentarios { get; set; }
        public string Tipo { get; set; }
        public decimal TipoCambio { get; set; }
        
        //CTS
        public string pathNombreArchivosCuentaSueldoCTS { get; set; }
        public string pathNombreArchivosAbono360CTS { get; set; }
        public string pathNombreArchivosAbonoQuintaCTS { get; set; }
        public string pathNombreArchivosMigracionCuentaCTS { get; set; }
        public string pathNombreArchivosDatosContactoCTS { get; set; }
        public string NombreArchivosCuentaSueldoCTS { get; set; }
        public string NombreArchivosAbono360CTS { get; set; }
        public string NombreArchivosAbonoQuintaCTS { get; set; }
        public string NombreArchivosMigracionCuentaCTS { get; set; }
        public string NombreArchivosDatosContactoCTS { get; set; }
        public bool TextoAbono360CTS { get; set; }
        public bool TextoAbonoQuintaCTS { get; set; }
        public bool TextoMigracionCuentaCTS { get; set; }
        public bool TextoDatosContactoCTS { get; set; }
        public bool BotonCuentaSueldoCTS { get; set; }
        public bool BotonAbono360CTS { get; set; }
        public bool BotonAbonoQuintaCTS { get; set; }
        public bool BotonMigracionCuentaCTS { get; set; }
        public bool BotonDatosContactoCTS { get; set; }

        //DP
        public string pathNombreArchivosDP { get; set; }
        public string pathNombreArchivosCuentaSueldoDP { get; set; }
        public string pathNombreArchivosClienteCMRDP { get; set; }
        public string NombreArchivos { get; set; }
        public string NombreArchivosDP { get; set; }
        public string NombreArchivosClienteCMRDP { get; set; }
        public string NombreArchivosCuentaSueldoDP { get; set; }
        public bool ExportarTotalDP { get; set; }
        public bool ExportarTotalCTS { get; set; }
        public bool TextoProcesoDP { get; set; }
        public bool TextoCuentaSueldoDP { get; set; }
        public bool TextoClienteCMRDP { get; set; }
        public bool BotonAgregarDP { get; set; }
        public bool BotonCuentaSueldoDP { get; set; }
        public bool BotonClienteCMRDP { get; set; }
        public string MensajeProceso { get; set; }
        public bool BotonProcesar { get; set; }
        public bool BotonExportar { get; set; }
        public bool BotonBuscar { get; set; }
        public string Producto { get; set; }
        public bool BotonCerrarVentana { get; set; }
        public bool BotonSalir { get; set; }
        public bool BotonActualizar { get; set; }
        public bool BotonMenuProcesos { get; set; }
        public bool BotonMenuMantenimientos { get; set; }
        public bool BotonMenuReportes { get; set; }
        public bool BotonLimpiar { get; set; }
        public bool TextoTipoCambio { get; set; }
       
    }
}
