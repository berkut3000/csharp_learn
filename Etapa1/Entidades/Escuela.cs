namespace CoreEscuela.Entidades
{
    class Escuela
    {
        string nombre;
        public string Nombre
        {
            get{ return "Copia:" + nombre; }
            set{ nombre = value.ToUpper(); }
        }
        
        public int añoCreacion{ get; set;}

        public string Pais { get; set; }
        public string Ciudad { get; set; }

        public TiposEscuela tiposEscuela { get; set; }

/*         public Escuela(string nombre, int año)
        {
            this.nombre = nombre;
            this.añoCreacion = año;
        } */
        public Escuela(string nombre, int año) => (Nombre, añoCreacion) = (nombre, año);

        public override string ToString()
        {
            return $"Nombre:  \"{Nombre}\" \r\nTipo: \"{tiposEscuela}\" \r\nPais: \"{Pais}\" {System.Environment.NewLine}Ciudad: \"{Ciudad}\"";
        }

        
    }
}