using System.ComponentModel.DataAnnotations;

namespace ERep.Models
{
    public class Patient
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public bool aceptoconocimieto { get; set; } = false;
        [Required]
        public string Iniciales { get; set; } = string.Empty;
        public DateTime Date { get; set; } = DateTime.Now;
        [Required]
        public string ECU { get; set; } = string.Empty;
        [Required]
        public DateTime BornDate { get; set; } = DateTime.Now;
        public int Age { get; set; }

        public int sexoId { get; set; }
        public List<KeyValuePair<string, int>> sexo = new List<KeyValuePair<string, int>>() {
                new KeyValuePair<string, int>("Femenino", 1),
                new KeyValuePair<string, int>("Masculino", 2),
                new KeyValuePair<string, int>("Intersex", 3),
            };

        public int generoId { get; set; }
        public List<KeyValuePair<string, int>> genero = new List<KeyValuePair<string, int>>() {
                new KeyValuePair<string, int>("Mujer", 1),
                new KeyValuePair<string, int>("Hombre", 2),
                new KeyValuePair<string, int>("Otro", 3),
                new KeyValuePair<string, int>("Prefiero no decir", 4),
            };

        public string Folio { get; set; } = string.Empty;
        public string PostalCode { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public int estadocivil { get; set; }
        public string estadocivilotro { get; set; } = string.Empty;
        public SiNo CurrentPartner { get; set; }
        public Residencia Residencia { get; set; }
        public string Residencialugar { get; set; } = string.Empty;
        public int escolaridad { get; set; }
        public int escolaridadanos { get; set; }
        public string escolaridadtipo { get; set; } = string.Empty;
        public State? State { get; set; }
        public int StateId { get; set; }
        public List<CSR> CSRs { get; set; }= new List<CSR>();
    }
    public enum CivilState
    {
        Casada,
        Soltera,
        Viuda,
        Divoricada,
        Unionlibre,
        Otro
    }

    public enum Residencia
    {
        Rural,
        Urbana
    }

    public enum Ethnicity
    {
        Indigena,
        Caucasico,
        Mestizo
    }

    public enum SiNo
    {
        Sí,
        No
    }

    public enum Escolarity
    {
        PrimariaIncompletaMenos, 
        Primaria,
        Secundaria,
        Preparatoria,
        UniversidadMas
    }
}
