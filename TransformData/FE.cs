using System.Collections.Generic;

namespace TransformData
{
    class FE
    {
    }
    public class IdDoc
    {
        public string TipoCF { get; set; }
        public string NCF { get; set; }
        public string FechaVencimientoSecuencia { get; set; }
        public string IndicadorNotaCredito { get; set; }
        public string IndicadorEnvioDiferido { get; set; }
        public string IndicadorMontoGravado { get; set; }
        public string TipoIngresos { get; set; }
        public string TipoPago { get; set; }
        public string FechaLimitePago { get; set; }
        public string TerminoPago { get; set; }
        public TablaFormasPago TablaFormasPago { get; set; }
        public string TipoCuentaPago { get; set; }
        public string NumeroCuentaPago { get; set; }
        public string BancoPago { get; set; }
        public string FechaDesde { get; set; }
        public string FechaHasta { get; set; }
        public int TotalPaginas { get; set; }
    }
    public class FormaDePago
    {
        public string FormaPago { get; set; }
        public decimal MontoPago { get; set; }
    }
    public class TablaFormasPago
    {
        public List<FormaDePago> FormaDePago { get; set; }
    }
    public class Emisor
    {
        public string RNCEmisor { get; set; }
        public string RazonSocialEmisor { get; set; }
        public string NombreComercial { get; set; }
        public string Sucursal { get; set; }
        public string DireccionEmisor { get; set; }
        public string Municipio { get; set; }
        public string Provincia { get; set; }
        public TablaTelefonoEmisor TablaTelefonoEmisor { get; set; }
        public string CorreoEmisor { get; set; }
        public string WebSite { get; set; }
        public string ActividadEconomica { get; set; }
        public string CodigoVendedor { get; set; }
        public string NumeroFacturaInterna { get; set; }
        public string NumeroPedidoInterno { get; set; }
        public string ZonaVenta { get; set; }
        public string RutaVenta { get; set; }
        public string InformacionAdicionalEmisor { get; set; }
        public string FechaEmision { get; set; }
    }
    public class TablaTelefonoEmisor
    {
        public List<string> TelefonoEmisor { get; set; }
    }
}
