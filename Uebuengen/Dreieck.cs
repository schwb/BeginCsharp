namespace Uebungen
{
    public class Dreieck: IGraphicObjects
    {
        public string Name { get; set; }
        public double Seite1 { get; set; }
        public double Seite2 { get; set; }
        public double Seite3 { get; set; }
        public double Basis { get; set; }
        public double Höhe { get; set; }
        public double Umfang()
        {
            return (Seite1 + Seite2 + Seite3);
        }
        public double Fläche()
        {
            return (Basis*Höhe/2);
        }
        public override string ToString()
        {
            return $"Das Dreieck hat den Umfang {Umfang()} und den Flächeninhalt {Fläche()}";
        }
    }
}
