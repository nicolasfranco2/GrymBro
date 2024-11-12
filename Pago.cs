using System;

public class Pago
{
    public int PagoID { get; set; }
    public int MiembroID { get; set; }
    public DateTime FechaPago { get; set; }
    public decimal Monto { get; set; }
    public string MetodoPago { get; set; }
}
