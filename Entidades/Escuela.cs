namespace CoreEscuela.Entidades
{
    class Escuela
    {
        public string Nombre{ get; set; }
        public int AnoDeCreacion{ get; set; }
        public string Pais { get; set; }
        public string Ciudad { get; set; }
        
        public TiposEscuela TipoEscuela { get; set; }
        public Curso[] Cursos { get; set; }
        public Escuela(string nombre, int año) => (Nombre, AnoDeCreacion) = (nombre, año);

        public Escuela(string nombre, int año, TiposEscuela tipo, string pais = "", string ciudad = "")
        {
            (Nombre, AnoDeCreacion) = (nombre, año);
            Pais = pais;
            Ciudad = ciudad;
        }

        public override string ToString()
        {
            return $"Nombre: {Nombre}, Tipo: {TipoEscuela} \n Pais: {Pais}, Ciudad: {Ciudad} \n Fundada: {AnoDeCreacion}";
        }
    }
}