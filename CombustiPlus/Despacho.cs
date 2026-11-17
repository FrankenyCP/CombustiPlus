namespace CombustiPlus
{
    // R2: un despacho es una venta de combustible a un vehículo.
    public class Despacho
    {
        public int Numero { get; set; }
        public string Placa { get; set; }
        public string Combustible { get; set; }
        public decimal Galones { get; set; }
        public string Pago { get; set; }
        public decimal Total { get; set; }

        // Muestra el despacho en una sola línea, en columnas:
        // #01 A123456  Regular   10.0 gal  Efectivo  RD$  2,720.00
        //   {Numero:00}       -> número con dos dígitos (01, 02...)
        //   {Combustible,-8}  -> texto alineado a la izquierda en 8 espacios
        //   {Galones,5:0.0}   -> número con un decimal, alineado a la derecha en 5 espacios
        //   {Total,9:N2}      -> monto con coma de miles y 2 decimales
        public override string ToString()
        {
            return $"#{Numero:00} {Placa}  {Combustible,-8} {Galones,5:0.0} gal  {Pago,-8}  RD$ {Total,9:N2}";
        }
    }
}
