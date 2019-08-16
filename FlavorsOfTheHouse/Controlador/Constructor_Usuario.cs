namespace FlavorsOfTheHouse.Controlador
{
    class Constructor_Usuario : Constructor_Respuestas
    {
        public static int id_usuario { get; set; }
        public string usuario { get; set; }
        public string clave { get; set; }
        public string nombres { get; set; }
        public string apellidos { get; set; }
        public string documento { get; set; }
        public string nacimiento { get; set; }
        public int intentos { get; set; }
        public int id_empresa { get; set; }
        public int id_estado { get; set; }
        public int id_tipo_usuario { get; set; }
        public string imagen { get; set; }
        public Constructor_Usuario() { }
    }

    class Constructor_Respuestas
    {
        public string respuesta { get; set; }
        public int id_pregunta { get; set; }
        public Constructor_Respuestas() { }
    }
}
