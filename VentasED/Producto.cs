namespace VentasED
{
    internal class Producto
    {
        public string Descripcion { get; set; }
        public decimal ValorUnitario { get; set; }

        public override string ToString()
        {
            return $"El producto seleccionado es {Descripcion} y tiene un costo de {ValorUnitario}";
        }
    }
}
