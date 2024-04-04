using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Numerics;
using System.Text.RegularExpressions;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ERep.Models
{
    public class CSR
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public DateTime Date { get; set; } = DateTime.Now;
        public int PatientId { get; set; }
        public int EreumaticaId { get; set; }
        public string otraEreumatica { get; set; } = string.Empty;
        public DateTime DateSintomas { get; set; } = DateTime.Now;
        public DateTime DateDiagnostico { get; set; } = DateTime.Now;
        //public DateOnly DateDiagnostico { get; set; } = DateOnly.FromDateTime(DateTime.Now);
        //public DateOnly DateSintomas { get; set; } = DateOnly.FromDateTime(DateTime.Now);
        public SiNo embarazada { get; set; }
        public int embarazadaId { get; set; }
        public int numabortos { get; set; }
        public int TipoEmbarazoId { get; set; }
        public int numembarazos { get; set; } = 0;
        public int hijosnacvivosfall { get; set; }

        public List<KeyValuePair<string, int>> SiNol = new List<KeyValuePair<string, int>>() {
                new KeyValuePair<string, int>("Si", 1),
                new KeyValuePair<string, int>("No", 2),
            };

        public List<KeyValuePair<string, int>> Ereumatica = new List<KeyValuePair<string, int>>() {
                new KeyValuePair<string, int>("Artritis Reumatoide (AR)",1),
                new KeyValuePair<string, int>("Lupus Eritematoso Sistémico (LES)",2),
                new KeyValuePair<string, int>("Síndrome Antifosfolípido (SAF)",3),
                new KeyValuePair<string, int>("Síndrome de Sjögren primario (SSp)",4),
                new KeyValuePair<string, int>("Miopatías inflamatorias",5),
                new KeyValuePair<string, int>("Artritis idiopática Juvenil (AIJ)",6),
                new KeyValuePair<string, int>("Enfermedad Mixta del Tejido conectivo (EMTC)",7),
                new KeyValuePair<string, int>("Enfermedad indiferenciada del Tejido Conectivo (EITC)",8),
                new KeyValuePair<string, int>("Escleroderma",9),
                new KeyValuePair<string, int>("Vasculitis",10),
                new KeyValuePair<string, int>("Espondiloartritis",11),
                new KeyValuePair<string, int>("Otra",12),
                new KeyValuePair<string, int>("Aun sin diagnóstico definitivo o consulta de primera vez",13),
            };

        public List<KeyValuePair<string, int>> TipoEmbarazo = new List<KeyValuePair<string, int>>() {
                new KeyValuePair<string, int>("¿Estaba buscando embarazarse?", 1),
                new KeyValuePair<string, int>("¿Quería esperar más tiempo?", 2),
                new KeyValuePair<string, int>("No estaba dentro de mis planes", 3),
            };
        //¿Cuántos hijos desea o planea tener en su vida?
        public int numhijosdesea { get; set; }

        //Hasta el día de hoy, el número de hijos (as) que usted ha tenido han sido… 
        public int pnumhijosId { get; set; }
        public List<KeyValuePair<string, int>> pnumhijos = new List<KeyValuePair<string, int>>() {
            new KeyValuePair<string, int>("Más de los que deseaba",1),
            new KeyValuePair<string, int>("El ideal que deseaba",2),
            new KeyValuePair<string, int>("Menos de los que deseaba",3),
        };

        //¿Cuál es la razón principal por la que ha tenido más hijos (as) de los que deseaba? 
        public int rmashijosId { get; set; }
        public List<KeyValuePair<string, int>> rmashijos = new List<KeyValuePair<string, int>>() {
            new KeyValuePair<string, int>("No utilice métodos anticonceptivos",1),
            new KeyValuePair<string, int>("No conocía los métodos anticonceptivos",2),
            new KeyValuePair<string, int>("Me falló el método anticonceptivo",3),
            new KeyValuePair<string, int>("Mi esposo (o pareja) quería más hijos(as)",4),
            new KeyValuePair<string, int>("Por razones religiosas",5),
            new KeyValuePair<string, int>("Otras",6),
        };

        //¿Cuál es la razón principal por la que ha tenido menos hijos (as) de los que deseaba? 
        public int rmenoshijosId { get; set; }
        public List<KeyValuePair<string, int>> rmenoshijos = new List<KeyValuePair<string, int>>() {
            new KeyValuePair<string, int>("Por falta de dinero",1),
            new KeyValuePair<string, int>("Estoy estudiando",2),
            new KeyValuePair<string, int>("Porque tengo una enfermedad reumática",3),
            new KeyValuePair<string, int>("No tengo pareja",4),
            new KeyValuePair<string, int>("Por Miedo",5),
            new KeyValuePair<string, int>("Mi esposo (o pareja) no quería más hijos (as)",6),
            new KeyValuePair<string, int>("Mi pareja o yo estamos operados para no tener más hijos(as) (ligadura  o vasectomía)",7),
            new KeyValuePair<string, int>("Otra",8),
        };

        //Preferencias reproductivas

        //¿Le gustaría tener hijos (as) alguna vez en su vida?
        public int hijosalgunavezId { get; set; }
        public List<KeyValuePair<string, int>> hijosalgunavez = new List<KeyValuePair<string, int>>() {
            new KeyValuePair<string, int>("Sí",1),
            new KeyValuePair<string, int>("Sí, pero no puedo",2),
            new KeyValuePair<string, int>("No",3),
            new KeyValuePair<string, int>("No se",4),
        };

        //¿Le gustaría tener hijos (as) ahora o en el próximo año?
        public int hijosahoraId { get; set; }
        public List<KeyValuePair<string, int>> hijosahora = new List<KeyValuePair<string, int>>() {
            new KeyValuePair<string, int>("Sí",1),
            new KeyValuePair<string, int>("Sí, pero no puedo",2),
            new KeyValuePair<string, int>("No",3),
            new KeyValuePair<string, int>("No se",4),
        };

        //¿Por qué no puede tener hijos (as) alguna vez en su vida ?
        public int hijosnopuedeId { get; set; }
        public List<KeyValuePair<string, int>> hijosnopuede = new List<KeyValuePair<string, int>>() {
            new KeyValuePair<string, int>("Porque tengo una enfermedad reumática",1),
            new KeyValuePair<string, int>("Yo o mi pareja estamos operados para no tener hijos (as)  (ligadura, salpingoclasia o vasectomía)",2),
            new KeyValuePair<string, int>("No tengo pareja",3),
            new KeyValuePair<string, int>("Menopausia",4),
            new KeyValuePair<string, int>("Tengo esterilidad",5),
            new KeyValuePair<string, int>("Mi pareja tiene esterilidad",6),
            new KeyValuePair<string, int>("Mi pareja es del mismo sexo",7),
            new KeyValuePair<string, int>("Otro",8),
        };
        public string hijosnopuedeotro { get; set; } = string.Empty;

        //¿Por qué no puede tener hijos (as) ahora o en el próximo año ?
        public int hijosnorazonId { get; set; }
        public List<KeyValuePair<string, int>> hijosnorazon = new List<KeyValuePair<string, int>>() {
            new KeyValuePair<string, int>("Porque tengo una enfermedad reumática",1),
            new KeyValuePair<string, int>("Mi pareja o yo estamos operados para no tener hijos (as)  (ligadura, salpingoclasia o vasectomía)",2),
            new KeyValuePair<string, int>("No tengo pareja",3),
            new KeyValuePair<string, int>("Menopausia",4),
            new KeyValuePair<string, int>("Tengo esterilidad",5),
            new KeyValuePair<string, int>("Mi pareja es del mismo sexo",6),
            new KeyValuePair<string, int>("Otro",7),
        };
        public string hijosnorazonotro { get; set; } = string.Empty;

        //¿Por qué no desea tener hijos (as) dentro del próximo año?
        public int hijosnodeseananoId { get; set; }
        public List<KeyValuePair<string, int>> hijosnodeseanano = new List<KeyValuePair<string, int>>() {
            new KeyValuePair<string, int>("Por falta de dinero",1),
            new KeyValuePair<string, int>("Quiero desarrollarme personal y/o profesionalmente",2),
            new KeyValuePair<string, int>("Porque tengo una enfermedad reumática",3),
            new KeyValuePair<string, int>("No tengo pareja",4),
            new KeyValuePair<string, int>("Ya tengo el número de hijos que deso (paridad satisfecha)",5),
            new KeyValuePair<string, int>("Miedo",6),
            new KeyValuePair<string, int>("Medicamentos contraindicados durante el embarazo",7),
            new KeyValuePair<string, int>("No está incluido en mi plan de vida",8),
            new KeyValuePair<string, int>("Por preferencias sexuales",9),
            new KeyValuePair<string, int>("Otra",10),
        };
        public string hijosnodeseananootro { get; set; } = string.Empty;

        //¿Por qué no desea tener hijos (as) nunca más en la vida/un futuro? 
        public int hijosnodeseanuncaId { get; set; }
        public List<KeyValuePair<string, int>> hijosnodeseanunca = new List<KeyValuePair<string, int>>() {
            new KeyValuePair<string, int>("Por falta de dinero",1),
            new KeyValuePair<string, int>("Quiero desarrollarme personal y/o profesionalmente",2),
            new KeyValuePair<string, int>("Porque tengo una enfermedad reumática",3),
            new KeyValuePair<string, int>("No tengo pareja",4),
            new KeyValuePair<string, int>("Ya tengo el número de hijos que deseo (paridad satisfecha)",5),
            new KeyValuePair<string, int>("Miedo",6),
            new KeyValuePair<string, int>("Medicamentos contraindicados durante el embarazo",7),
            new KeyValuePair<string, int>("No está incluido en mi plan de vida",8),
            new KeyValuePair<string, int>("Por preferencias sexuales",9),
            new KeyValuePair<string, int>("Otra",10),
        };
        public string hijosnodeseanuncaotro { get; set; } = string.Empty;

        //¿Cuántos años le gustaría esperar para tener un hijo(a) o varios más?
        public int hijosesperaId { get; set; }
        public List<KeyValuePair<string, int>> hijosespera = new List<KeyValuePair<string, int>>() {
            new KeyValuePair<string, int>("Menos de un año",1),
            new KeyValuePair<string, int>("Ya tengo el número de hijos que deseo (paridad satisfecha)",2),
            new KeyValuePair<string, int>("No estoy segura",3),
            new KeyValuePair<string, int>("Anote el número de años",4),
        };
        public int hijosesperanum { get; set; }

        //Relación con su reumatólogo
        //¿Que tanta confianza tiene para hablar con su reumatólogo para comentarle sobre temas como planificación familiar (deseo de embarazo) y consejería sobre métodos anticonceptivos?
        public int reuma_confianzaplanificarfamiliaId { get; set; }
        public List<KeyValuePair<string, int>> NadaMucho = new List<KeyValuePair<string, int>>() {
            new KeyValuePair<string, int>("Nada",1),
            new KeyValuePair<string, int>("Poca",2),
            new KeyValuePair<string, int>("Algo",3),
            new KeyValuePair<string, int>("Mucho",4),
            new KeyValuePair<string, int>("Muchísima",5),
        };

        //¿Con que frecuencia ha recibido por parte de su reumatólogo consejería sobre planificación familiar (deseo de embarazo) y consejería sobre métodos anticonceptivos ?
        public int reuma_planificarfamiliaId { get; set; }

        //¿Con que frecuencia su reumatólogo le ha dicho de los riesgos de embarazarse en este momento respecto a su enfermedad?
        public int reuma_riesembarazoId { get; set; }

        //¿Con que frecuencia su reumatólogo le ha dicho de los riesgos de tomar algunos medicamentos durante el embarazo?
        public int reuma_riesgomedId { get; set; }

        public List<KeyValuePair<string, int>> NuncaSiempre = new List<KeyValuePair<string, int>>() {
            new KeyValuePair<string, int>("Nunca",1),
            new KeyValuePair<string, int>("Casi nunca",2),
            new KeyValuePair<string, int>("Alguna vez",3),
            new KeyValuePair<string, int>("Casi Siempre",4),
            new KeyValuePair<string, int>("siempre",5),
        };

        //Anticoncepción
        //¿Quisiera usted decirme que métodos conoce? 
        public bool metodos_conoce_a { get; set; } = false;
        public bool metodos_conoce_b { get; set; } = false;
        public bool metodos_conoce_c { get; set; } = false;
        public bool metodos_conoce_d { get; set; } = false;
        public bool metodos_conoce_e { get; set; } = false;
        public bool metodos_conoce_f { get; set; } = false;
        public bool metodos_conoce_g { get; set; } = false;
        public bool metodos_conoce_h { get; set; } = false;
        public bool metodos_conoce_i { get; set; } = false;
        public bool metodos_conoce_j { get; set; } = false;
        public bool metodos_conoce_k { get; set; } = false;
        public bool metodos_conoce_l { get; set; } = false;
        public bool metodos_conoce_m { get; set; } = false;
        public bool metodos_conoce_n { get; set; } = false;
        public bool metodos_conoce_nn { get; set; } = false;
        public string metodos_conoce_o { get; set; } = string.Empty;
        //¿Cuál es su opinión sobre el funcionamiento de los siguientes métodos para evitar el embarazo?
        public bool metodos_funciona_a { get; set; } = false;
        public bool metodos_funciona_b { get; set; } = false;
        public bool metodos_funciona_c { get; set; } = false;
        public bool metodos_funciona_d { get; set; } = false;
        public bool metodos_funciona_e { get; set; } = false;
        public bool metodos_funciona_f { get; set; } = false;
        public bool metodos_funciona_g { get; set; } = false;
        public bool metodos_funciona_h { get; set; } = false;
        public bool metodos_funciona_i { get; set; } = false;
        public bool metodos_funciona_j { get; set; } = false;
        public bool metodos_funciona_k { get; set; } = false;
        public bool metodos_funciona_l { get; set; } = false;
        public bool metodos_funciona_m { get; set; } = false;
        public bool metodos_funciona_n { get; set; } = false;
        public bool metodos_funciona_nn { get; set; } = false;
        public string metodos_funciona_o { get; set; } = string.Empty;
        //¿Alguna vez usted o su pareja (formal u ocacional) han utilizado algún método para evitar el embarazo? 
        public int anticon_histusoId { get; set; }
        //¿Actualmente usted o su pareja (formal u ocacional) están utilizando algún método para evitar el embarazo? 
        public int anticon_usoId { get; set; }
        public List<KeyValuePair<string, int>> SiNoP = new List<KeyValuePair<string, int>>() {
            new KeyValuePair<string, int>("Sí",1),
            new KeyValuePair<string, int>("No",2),
            new KeyValuePair<string, int>("No tengo pareja",3),
        };
        //¿Qué está utilizando usted actualmente o su pareja (formal u ocacional) para no tener hijos(as)? 
        public bool metodos_utiliza_a { get; set; } = false;
        public bool metodos_utiliza_b { get; set; } = false;
        public bool metodos_utiliza_c { get; set; } = false;
        public bool metodos_utiliza_d { get; set; } = false;
        public bool metodos_utiliza_e { get; set; } = false;
        public bool metodos_utiliza_f { get; set; } = false;
        public bool metodos_utiliza_g { get; set; } = false;
        public bool metodos_utiliza_h { get; set; } = false;
        public bool metodos_utiliza_i { get; set; } = false;
        public bool metodos_utiliza_j { get; set; } = false;
        public bool metodos_utiliza_k { get; set; } = false;
        public bool metodos_utiliza_l { get; set; } = false;
        public bool metodos_utiliza_m { get; set; } = false;
        public bool metodos_utiliza_n { get; set; } = false;
        public bool metodos_utiliza_nn { get; set; } = false;
        public string metodos_utiliza_o { get; set; } = string.Empty;
        
        //¿Usted (o su pareja) se operó... 
        public int anticon_operoId { get; set; }
        public List<KeyValuePair<string, int>> anticon_opero = new List<KeyValuePair<string, int>>() {
            new KeyValuePair<string, int>("Para  no  embarazarme nunca más?",1),
            new KeyValuePair<string, int>("Porque tengo el número de hijos que deseaba?",2),
            new KeyValuePair<string, int>("Porque me lo indicó el (la) doctor(a) por motivos de salud?",3),
            new KeyValuePair<string, int>("Porque padezco una enfermedad reumática",4),
            new KeyValuePair<string, int>("¿Por otra razón? ¿Cuál?",5),
        };
        public string anticon_operootro { get; set; } = string.Empty;
        //¿Dónde consiguió el método actual cuando lo empezó a usar?
        public int anticon_dondeId { get; set; }
        public List<KeyValuePair<string, int>> anticon_donde = new List<KeyValuePair<string, int>>() {
            new KeyValuePair<string, int>("Seguro Social (IMSS, IMSSPROSPERA/ Oportunidades INSABI)",1),
            new KeyValuePair<string, int>("ISSSTE o ISSSTE Estatal (ISSEMYM, ISSSTEZAC, etc.)",2),
            new KeyValuePair<string, int>("Centro de salud u hospital de la SSA",3),
            new KeyValuePair<string, int>("Otros servicios públicos (DIF, Pemex, SEMAR, etc.)",4),
            new KeyValuePair<string, int>("Consultorio, clínica u hospital privado (CERVECERÍA, Bancos, Hospital Muguerza, Hospital Zambrano, etc.)",5),
            new KeyValuePair<string, int>("Partera(o)",6),
            new KeyValuePair<string, int>("Farmacia o tienda de autoservicio",7),
            new KeyValuePair<string, int>("Otro lugar",8),
            new KeyValuePair<string, int>("No responde",9),
        };
        public string anticon_dondeotro { get; set; } = string.Empty;

        //¿Cuál es la razón principal por la que le recetaron (prescribieron) el método que utiliza actualmente?
        public bool anticon_razonreceta_1 { get; set; } = false;
        public bool anticon_razonreceta_2 { get; set; } = false;
        public bool anticon_razonreceta_3 { get; set; } = false;
        public bool anticon_razonreceta_4 { get; set; } = false;
        public bool anticon_razonreceta_5 { get; set; } = false;
        public bool anticon_razonreceta_6 { get; set; } = false;
        public bool anticon_razonreceta_7 { get; set; } = false;
        public bool anticon_razonreceta_8 { get; set; } = false;
        public bool anticon_razonreceta_9 { get; set; } = false;
        public bool anticon_razonreceta_10 { get; set; } = false;
        public bool anticon_razonreceta_11 { get; set; } = false;
        public bool anticon_razonreceta_12 { get; set; } = false;
        public string anticon_razonrecetaotro { get; set; } = string.Empty;


        //¿Cuál es la razón principal por la que actualmente no está utilizando algún método para evitar el embarazo? 
        public int anticon_razonnousaId { get; set; }
        public List<KeyValuePair<string, int>> anticon_razonnousa = new List<KeyValuePair<string, int>>() {
            new KeyValuePair<string, int>("Estoy embarazada",1),
            new KeyValuePair<string, int>("Quiero embarazarme",2),
            new KeyValuePair<string, int>("No lo necesito: porque deje de tener relaciones sexuales",3),
            new KeyValuePair<string, int>("No lo necesito: porque nunca he tenido relaciones sexuales",4),
            new KeyValuePair<string, int>("No lo necesito: por estar en la menopausia o por esterilidad mia o de mi pareja",5),
            new KeyValuePair<string, int>("No lo necesito: porque no tengo pareja estable, ausencia temporal de mi pareja, mi pareja es del mismo sexo",6),
            new KeyValuePair<string, int>("Temo a los efectos secundarios",7),
            new KeyValuePair<string, int>("Tuve efectos secundarios",8),
            new KeyValuePair<string, int>("El medicamento que tomo para la enfermedad “se contrapone” con el método anticonceptivo",9),
            new KeyValuePair<string, int>("Se opone mi pareja",10),
            new KeyValuePair<string, int>("Tengo una enfermedad y prefiero no usar algo",11),
            new KeyValuePair<string, int>("Estoy dando pecho a uno de mis hijos",12),
            new KeyValuePair<string, int>("Por razones religiosas",13),
            new KeyValuePair<string, int>("Expulsé el DIU",14),
            new KeyValuePair<string, int>("No estoy de acuerdo con el uso de métodos anticonceptivos",15),
            new KeyValuePair<string, int>("No conozco métodos",16),
            new KeyValuePair<string, int>("No se cómo se usan los métodos",17),
            new KeyValuePair<string, int>("No se dónde obtener los métodos",18),
            new KeyValuePair<string, int>("No se cuál método es el más adecuado para mi",19),
            new KeyValuePair<string, int>("Solo tengo relaciones sexuales con personas de mi mismo sexo",20),
            new KeyValuePair<string, int>("Otra (Escribir cual)",21),
            new KeyValuePair<string, int>("No responde",22),
        };
        public string anticon_razonnousaotro { get; set; } = string.Empty;

        //El medicamento que tomo para la enfermedad “se contrapone” con el método anticonceptivo 
        public int anticon_contraponeId { get; set; }
        public List<KeyValuePair<string, int>> anticon_contrapone = new List<KeyValuePair<string, int>>() {
            new KeyValuePair<string, int>("Tuve efectos secundarios",1),
            new KeyValuePair<string, int>("Se opone mi pareja",2),
            new KeyValuePair<string, int>("Tengo una enfermedad y prefiero no usar algo",3),
            new KeyValuePair<string, int>("Estoy dando pecho a uno de mis hijos",4),
            new KeyValuePair<string, int>("Por razones religiosas",5),
            new KeyValuePair<string, int>("Expulsé el DIU",6),
            new KeyValuePair<string, int>("No estoy de acuerdo con el uso de métodos anticonceptivos ",7),
            new KeyValuePair<string, int>("No conozco métodos",8),
            new KeyValuePair<string, int>("No se cómo se usan los métodos",9),
            new KeyValuePair<string, int>("No se dónde obtener los métodos",10),
            new KeyValuePair<string, int>("No se cuál método es el más adecuado para mi",11),
            new KeyValuePair<string, int>("Otra (Escribir cual)",12),
            new KeyValuePair<string, int>("No responde",13),
        };
        public string anticon_contraponeotro { get; set; } = string.Empty;


        //Sexualidad
        //¿Qué edad tenía usted cuando tuvo su primera relación sexual? 
        public int anticon_edadprimeraId { get; set; }
        public List<KeyValuePair<string, int>> anticon_edadprimera = new List<KeyValuePair<string, int>>() {
            new KeyValuePair<string, int>("Menor a 15 años",1),
            new KeyValuePair<string, int>("De 15 a 18 años",2),
            new KeyValuePair<string, int>("Mayor a los 18 años",3),
            new KeyValuePair<string, int>("No he tenido relaciones",4),
            new KeyValuePair<string, int>("Prefiero no responder",5),
        };
        //En su primera relación sexual, ¿Qué fue lo que usted o su pareja hicieron o usaron para evitar un embarazo o una infección de transmisión sexual?
        public bool anticon_primerapro1 { get; set; } = false;
        public bool anticon_primerapro2 { get; set; } = false;
        public bool anticon_primerapro3 { get; set; } = false;
        public bool anticon_primerapro4 { get; set; } = false;
        public bool anticon_primerapro5 { get; set; } = false;
        public bool anticon_primerapro6 { get; set; } = false;
        public bool anticon_primerapro7 { get; set; } = false;
        public bool anticon_primerapro8 { get; set; } = false;
        public bool anticon_primerapro9 { get; set; } = false;
        public bool anticon_primerapro10 { get; set; } = false;
        public bool anticon_primerapro11 { get; set; } = false;
        public bool anticon_primerapro12 { get; set; } = false;
        public bool anticon_primerapro13 { get; set; } = false;
        public bool anticon_primerapro14 { get; set; } = false;
        public bool anticon_primerapro15 { get; set; } = false;
        public bool anticon_primerapro16 { get; set; } = false;
        public string anticon_primeraprototro { get; set; } = string.Empty;


        //¿Cuál fue la razón principal por la que usted o su pareja no hicieron o usaron algo para protegerse o evitar un embarazo?
        public int anticon_primerarazonId { get; set; }
        public List<KeyValuePair<string, int>> anticon_primerarazon = new List<KeyValuePair<string, int>>() {
            new KeyValuePair<string, int>("Quería embarazarme",1),
            new KeyValuePair<string, int>("No conocía los métodos, no sabía dónde obtenerlos o cómo usarlos",2),
            new KeyValuePair<string, int>("Se opuso mi pareja",3),
            new KeyValuePair<string, int>("No crei que podía quedar embarazada",4),
            new KeyValuePair<string, int>("No estaba de acuerdo con el uso de métodos anticonceptivos",5),
            new KeyValuePair<string, int>("No planeaba tener relaciones sexuales",6),
            new KeyValuePair<string, int>("Me dio pena",7),
            new KeyValuePair<string, int>("Otra razón",8),
            new KeyValuePair<string, int>("No responde",9),
        };
        public string anticon_primerarazonotro { get; set; } = string.Empty;

        //¿Cuándo fue la última vez que usted tuvo relaciones sexuales?
        public bool ultimarelaciones_nodecir { get; set; } = false;
        public int ultimarelaciones_dias { get; set; } = 0;
        public int ultimarelaciones_semanas { get; set; } = 0;
        public int ultimarelaciones_meses { get; set; } = 0;
        public int ultimarelaciones_anos { get; set; } = 0;

        //En los últimos 12 meses, ¿usted ha escuchado o visto información de métodos anticonceptivos en...
        public bool Radio { get; set; } = false;
        public bool Television { get; set; } = false;
        public bool Periodico { get; set; } = false;
        public bool Internet { get; set; } = false;
        public bool RedesSociales { get; set; } = false;
        public bool Carteles { get; set; } = false;
        public bool Platicas { get; set; } = false;
        public bool otro_medio { get; set; } = false;
        public string otro_medio_text { get; set; } = string.Empty;

        //¿Cuáles?
        public bool Facebook { get; set; } = false;
        public bool Instagram { get; set; } = false;
        public bool Twitter { get; set; } = false;
        public bool WhatsApp { get; set; } = false;
        public bool TikTok { get; set; } = false;
        public bool otra_red { get; set; } = false;
        public string otra_red_text { get; set; } = string.Empty;

        //¿Hace cuánto tiempo tuvo usted su última regla (menstruación)?
        public bool ultimaregla_nodecir { get; set; } = false;
        public int ultimaregla_dias { get; set; } = 0;
        public int ultimaregla_semanas { get; set; } = 0;
        public int ultimaregla_meses { get; set; } = 0;
        public int ultimaregla_anos { get; set; } = 0;
        public bool ultimaregla_nohamestruado { get; set; } = false;
        public bool ultimaregla_norecuerdo { get; set; } = false;
        public bool ultimaregla_menopausia { get; set; } = false;

        //Reumatología
        //Actualmente ¿Toma alguno de estos medicamentos? 
        public bool medicamento_1 { get; set; } = false;
        public bool medicamento_2 { get; set; } = false;
        public bool medicamento_3 { get; set; } = false;
        public bool medicamento_4 { get; set; } = false;
        public bool medicamento_5 { get; set; } = false;
        public bool medicamento_6 { get; set; } = false;
        public bool medicamento_7 { get; set; } = false;
        public bool medicamento_8 { get; set; } = false;
        public bool medicamento_9 { get; set; } = false;
        public bool medicamento_10 { get; set; } = false;
        public bool medicamento_11 { get; set; } = false;
        public bool medicamento_12 { get; set; } = false;
        public bool medicamento_13 { get; set; } = false;
        public bool medicamento_14 { get; set; } = false;
        public bool medicamento_15 { get; set; } = false;
        public bool medicamento_16 { get; set; } = false;
        public bool medicamento_17 { get; set; } = false;
        public bool medicamento_otros { get; set; } = false;
        public string medicamento_otros_text { get; set; } = string.Empty;

        //¿Su último parto fue…
        public int parto_tipoId { get; set; }
        public List<KeyValuePair<string, int>> parto_tipo = new List<KeyValuePair<string, int>>() {
            new KeyValuePair<string, int>("Normal (vaginal)?",1),
            new KeyValuePair<string, int>("Cesárea programada?",2),
            new KeyValuePair<string, int>("Cesárea de emergencia?",3),
        };
        public string cesarea_ener_motivo { get; set; } = string.Empty;

        //¿La cesárea, se decidió…
        public int cesarea_decidioId { get; set; }
        public List<KeyValuePair<string, int>> cesarea_decidio = new List<KeyValuePair<string, int>>() {
            new KeyValuePair<string, int>("Durante las consultas prenatales?",1),
            new KeyValuePair<string, int>("Antes de iniciar el trabajo de parto?",2),
            new KeyValuePair<string, int>("Durante el trabajo de parto?",3),
        };

        //El motivo de la cesárea fue por…
        public int cesarea_motivoId { get; set; }
        public List<KeyValuePair<string, int>> cesarea_motivo = new List<KeyValuePair<string, int>>() {
            new KeyValuePair<string, int>("Una complicación en mi salud o en la del bebé (decisión médica)",1),
            new KeyValuePair<string, int>("Sugerencia de su médico general",2),
            new KeyValuePair<string, int>("Sugerencia de su reumatólogo",3),
            new KeyValuePair<string, int>("Sugerencia de su ginecólogo",4),
            new KeyValuePair<string, int>("Para elegir fecha de nacimiento",5),
            new KeyValuePair<string, int>("Decisión del personal médico, pero no conozco el motivo",6),
            new KeyValuePair<string, int>("No quería tener dolor",7),
            new KeyValuePair<string, int>("Otro motivo?",8),
        };
        public string cesarea_motivootro { get; set; } = string.Empty;

        //Después del parto de su hijo(a), ¿le…
        public bool actividad_despues_parto_1 { get; set; } = false;
        public bool actividad_despues_parto_2 { get; set; } = false;
        public bool actividad_despues_parto_3 { get; set; } = false;

        //¿Le dio leche materna o pecho? CIRCULE UNA SOLA RESPUESTA
        public bool lechematerna_dio { get; set; } = false;
        
        //¿Cuánto tiempo de nacida(o) tenía su hijo(a) cuando le empezó a dar leche materna o pecho?
        public int lechematerna_horas { get; set; } = 0;
        public int lechematerna_dias { get; set; } = 0;

        //¿Durante cuánto tiempo le dio (ha dado) a su hijo(a) leche materna o pecho?
        public int lechematerna_duracionId { get; set; }
        public List<KeyValuePair<string, int>> lechematerna_duracion = new List<KeyValuePair<string, int>>() {
            new KeyValuePair<string, int>("Por menos de un mes",1),
            new KeyValuePair<string, int>("Por menos de seis meses",2),
            new KeyValuePair<string, int>("Por más de  meses.",3),
        };

        //¿Por qué no le dio leche materna o pecho a su último hijo(a)?
        public int lechematerna_nodioId { get; set; }
        public List<KeyValuePair<string, int>> lechematerna_nodio = new List<KeyValuePair<string, int>>() {
            new KeyValuePair<string, int>("Falleció a las horas de nacido(a)",1),
            new KeyValuePair<string, int>("Estaba enferma",2),
            new KeyValuePair<string, int>("Por enfermedad del (de la) niño(a)",3),
            new KeyValuePair<string, int>("Nunca tuve leche",4),
            new KeyValuePair<string, int>("El (la) niño (a) lo rechazo",5),
            new KeyValuePair<string, int>("El médico me recomendó dar fórmula",6),
            new KeyValuePair<string, int>("Por los medicamentos que estoy tomando",7),
            new KeyValuePair<string, int>("La enfermedad me impidió dar pecho",8),
            new KeyValuePair<string, int>("Otra razón",9),
        };
        public string lechematerna_nodiootro { get; set; } = string.Empty;

        //Por que dejo de darle leche materna o pecho a su último hijo(a)?
        public int lechematerna_dejadarId { get; set; }
        public List<KeyValuePair<string, int>> lechematerna_dejadar = new List<KeyValuePair<string, int>>() {
            new KeyValuePair<string, int>("Falleció a las horas de nacido(a)",1),
            new KeyValuePair<string, int>("Estaba enferma",2),
            new KeyValuePair<string, int>("Por enfermedad del (de la) niño(a)",3),
            new KeyValuePair<string, int>("Deje de producir leche",4),
            new KeyValuePair<string, int>("El (la) niño (a) lo rechazo",5),
            new KeyValuePair<string, int>("El médico me recomendó dar fórmula",6),
            new KeyValuePair<string, int>("Por los medicamentos que estoy tomando",7),
            new KeyValuePair<string, int>("La enfermedad me impidió dar pecho",8),
            new KeyValuePair<string, int>("Otra razón",9),
        };
        public string lechematerna_dejadarotro { get; set; } = string.Empty;

        //¿La cesárea, se decidió…
        public int vianac_decidioId { get; set; }
        public List<KeyValuePair<string, int>> vianac_decidio = new List<KeyValuePair<string, int>>() {
            new KeyValuePair<string, int>("¿Durante las consultas prenatales?",1),
            new KeyValuePair<string, int>("¿Antes de iniciar el trabajo de parto?",2),
            new KeyValuePair<string, int>("¿Durante el trabajo de parto?",3),
        };

        //Actualmente ¿Toma alguno de estos medicamentos? 
        public bool partomedicamento_1 { get; set; } = false;
        public bool partomedicamento_2 { get; set; } = false;
        public bool partomedicamento_3 { get; set; } = false;
        public bool partomedicamento_4 { get; set; } = false;
        public bool partomedicamento_5 { get; set; } = false;
        public bool partomedicamento_6 { get; set; } = false;
        public bool partomedicamento_7 { get; set; } = false;
        public bool partomedicamento_8 { get; set; } = false;
        public bool partomedicamento_9 { get; set; } = false;
        public bool partomedicamento_10 { get; set; } = false;
        public bool partomedicamento_11 { get; set; } = false;
        public bool partomedicamento_12 { get; set; } = false;
        public bool partomedicamento_13 { get; set; } = false;
        public bool partomedicamento_14 { get; set; } = false;
        public bool partomedicamento_15 { get; set; } = false;
        public bool partomedicamento_16 { get; set; } = false;
        public bool partomedicamento_17 { get; set; } = false;
        public bool partomedicamento_18 { get; set; } = false;
        public bool partomedicamento_19 { get; set; } = false;
        public bool partomedicamento_20 { get; set; } = false;
        public bool partomedicamento_21 { get; set; } = false;
        public bool partomedicamento_22 { get; set; } = false;
        public bool partomedicamento_23 { get; set; } = false;
        public bool partomedicamento_24 { get; set; } = false;
        public bool partomedicamento_25 { get; set; } = false;
        public bool partomedicamento_26 { get; set; } = false;
        public bool partomedicamento_27 { get; set; } = false;
        public bool partomedicamento_28 { get; set; } = false;
        public bool partomedicamento_29 { get; set; } = false;
        public bool partomedicamento_30 { get; set; } = false;
        public bool partomedicamento_otros { get; set; } = false;
        public string partomedicamento_otros_text { get; set; } = string.Empty;



        public List<PartosInfo> PartosInfos { get; set; } = new List<PartosInfo>();
        public List<KeyValuePair<string, int>> GestacionTipo = new List<KeyValuePair<string, int>>() {
                new KeyValuePair<string, int>("De término", 1),
                new KeyValuePair<string, int>("Prematuro", 2),
                new KeyValuePair<string, int>("Postmaduro", 3),
            };

        public List<KeyValuePair<string, int>> PartoCesareaAborto = new List<KeyValuePair<string, int>>() {
                new KeyValuePair<string, int>("Fue parto", 1),
                new KeyValuePair<string, int>("Fue cesárea de emergencia", 2),
                new KeyValuePair<string, int>("Fue cesárea programada", 3),
                new KeyValuePair<string, int>("Fue aborto", 4),
            };

        public List<KeyValuePair<string, int>> Defuncion = new List<KeyValuePair<string, int>>() {
                new KeyValuePair<string, int>("Muerte fetal: muerte antes del parto", 1),
                new KeyValuePair<string, int>("Óbito: el bebé nació muerto", 2),
                new KeyValuePair<string, int>("Muerte neonatal: el bebé nació vivo pero falleció antes/ a los 28 días", 3),
            };
        public List<KeyValuePair<string, int>> Atendida = new List<KeyValuePair<string, int>>() {
                new KeyValuePair<string, int>("Hospital privado", 1),
                new KeyValuePair<string, int>("Hospital público", 2),
                new KeyValuePair<string, int>("Con una partera", 3),
            };

        public List<KeyValuePair<string, int>> CesareaRazones = new List<KeyValuePair<string, int>>() {
                new KeyValuePair<string, int>("1.Una complicación en mi salud o en la del bebé(decisión médica)", 1),
                new KeyValuePair<string, int>("2.Por sugerencia de su médico general", 2),
                new KeyValuePair<string, int>("3.Por sugerencia de su reumatólogop", 3),
                new KeyValuePair<string, int>("4.Por sugerencia de su ginecólogo", 4),
                new KeyValuePair<string, int>("5.Para elegir fecha de nacimiento", 5),
                new KeyValuePair<string, int>("6.Decisión del personal médico, pero no conozco el motivo", 6),
                new KeyValuePair<string, int>("7.No quería tener dolor", 7),
                new KeyValuePair<string, int>("8.Otro motivo", 8),
            };

        public List<KeyValuePair<string, int>> SitioInfoLactancia = new List<KeyValuePair<string, int>>() {
                new KeyValuePair<string, int>("1.Pláticas en centro de salud pública o privada", 1),
                new KeyValuePair<string, int>("2.Información de un familiar o amiga", 2),
                new KeyValuePair<string, int>("3.Consejería de un experto (ginecólogo, médico general o pediatra)", 3),
                new KeyValuePair<string, int>("4.Redes sociales: Página medica", 4),
                new KeyValuePair<string, int>("5.Redes sociales: Página de mamás", 5),
                new KeyValuePair<string, int>("6.Redes sociales: Página de la iglesia", 6),
                new KeyValuePair<string, int>("7.Redes sociales: Twitter", 7),
                new KeyValuePair<string, int>("8.Redes sociales: Facebook", 8),
                new KeyValuePair<string, int>("9.Redes sociales: YouTube", 9),
                new KeyValuePair<string, int>("10.Redes sociales: .Instagram", 10),
                new KeyValuePair<string, int>("11.No recibí pláticas", 11),
            };

        public List<KeyValuePair<string, int>> DarPechoAntesRazon = new List<KeyValuePair<string, int>>() {
                new KeyValuePair<string, int>("1.Porque no quise", 1),
                new KeyValuePair<string, int>("2.Porque sé que es lo mejor para mi bebé", 2),
                new KeyValuePair<string, int>("3.Porque tengo miedo de que mi enfermedad pueda afectarlo", 3),
                new KeyValuePair<string, int>("4.Porque me han recomendado que no le de pecho", 4),
                new KeyValuePair<string, int>("5.Durante mi lactancia previa se activó mi enfermedad", 5),
                new KeyValuePair<string, int>("6.No me gustó la experiencia previa", 6),
                new KeyValuePair<string, int>("7.Estoy tomando medicamentos tóxicos para el bebe", 7),
                new KeyValuePair<string, int>("8.No tengo tiempo", 8),
                new KeyValuePair<string, int>("9.Ahorrar gastos", 9),
                new KeyValuePair<string, int>("10.Mantener período de baja probabilidad de nuevo embarazo", 10),
                new KeyValuePair<string, int>("11.Mi médico me dio Consejería de lactancia", 11),
                new KeyValuePair<string, int>("12.Un familiar me dio Consejería de lactancia", 12),
            };

        public List<KeyValuePair<string, int>> PensabaAlimentarlo = new List<KeyValuePair<string, int>>() {
                new KeyValuePair<string, int>("1.Darle exclusivamente pecho", 1),
                new KeyValuePair<string, int>("2.Darle pecho, agua y tés ", 2),
                new KeyValuePair<string, int>("3.Darle pecho y fórmula", 3),
                new KeyValuePair<string, int>("4.Darle solo fórmula", 4),
            };

        public List<KeyValuePair<string, int>> AlimentoBebesm = new List<KeyValuePair<string, int>>() {
                new KeyValuePair<string, int>("1.Solo pecho", 1),
                new KeyValuePair<string, int>("2.Pecho, agua y tés", 2),
                new KeyValuePair<string, int>("3.Pecho y fórmula", 3),
                new KeyValuePair<string, int>("4.Solamente fórmula", 4),
            };

        public List<KeyValuePair<string, int>> EligioTipoAlim = new List<KeyValuePair<string, int>>() {
                new KeyValuePair<string, int>("1.Porque no quería lactar", 1),
                new KeyValuePair<string, int>("2.Porque me dolía", 2),
                new KeyValuePair<string, int>("3.Porque así me lo recomendó mi pediatra", 3),
                new KeyValuePair<string, int>("4.Porque me lo recomendaron mis familiares", 4),
                new KeyValuePair<string, int>("5.Porque el bebé no se prendía bien", 5),
                new KeyValuePair<string, int>("6.Porque no me salía leche<", 6),
                new KeyValuePair<string, int>("7.Porque sé que es lo mejor para mi bebé", 7),
                new KeyValuePair<string, int>("8.Porque tengo miedo de que mi enfermedad pueda afectarlo", 8),
                new KeyValuePair<string, int>("9.Porque donde trabajo no hay lugar para extraerme la leche", 9),
                new KeyValuePair<string, int>("10.Durante mi lactancia previa se activó mi enfermedad", 10),
                new KeyValuePair<string, int>("11.No me gustó la experiencia previa", 11),
                new KeyValuePair<string, int>("12.Estoy tomando medicamentos tóxicos para el bebe", 12),
                new KeyValuePair<string, int>("13.No tengo tiempo", 13),
                new KeyValuePair<string, int>("14.Mantener baja probabilidad de nuevo embarazo", 14),
            };

        public List<KeyValuePair<string, int>> DejoDarleLechePecho = new List<KeyValuePair<string, int>>() {
                new KeyValuePair<string, int>("1.No lo he dejado de amamantar", 1),
                new KeyValuePair<string, int>("2.Porque separaron al bebé (a", 2),
                new KeyValuePair<string, int>("3.Por enfermedad del niño(a)", 3),
                new KeyValuePair<string, int>("4.Deje de producir leche", 4),
                new KeyValuePair<string, int>("5.El (la) niño (a) lo rechazo", 5),
                new KeyValuePair<string, int>("6.El médico me recomendó dar fórmula", 6),
                new KeyValuePair<string, int>("7.Por los medicamentos que estoy tomando", 7),
                new KeyValuePair<string, int>("8.La enfermedad me impidió dar pecho", 8),
                new KeyValuePair<string, int>("9.Porque no tuve leche", 9),
                new KeyValuePair<string, int>("10.Porque no lo llenaba", 10),
                new KeyValuePair<string, int>("11.Regresé a trabajar", 11),
                new KeyValuePair<string, int>("12.Tuve problemas con mis pezones o pecho (no tenía pezón, grietas, pechos muy llenos, dolor en los pezones)", 12),
                new KeyValuePair<string, int>("13.Otra razón", 13),
            };

        public List<KeyValuePair<string, int>> NuncaLechePecho = new List<KeyValuePair<string, int>>() {
                new KeyValuePair<string, int>("1.Porque separaron a mi bebé", 1),
                new KeyValuePair<string, int>("2.Por enfermedad del niño(a)", 2),
                new KeyValuePair<string, int>("3.Nunca tuve leche", 3),
                new KeyValuePair<string, int>("4.El(la) niño(a) lo rechazo", 4),
                new KeyValuePair<string, int>("5.El médico me recomendó dar fórmula", 5),
                new KeyValuePair<string, int>("6.Por los medicamentos que estoy tomando", 6),
                new KeyValuePair<string, int>("7.Se reactivó mi enfermedad", 7),
                new KeyValuePair<string, int>("8.Porque no tuve leche", 8),
                new KeyValuePair<string, int>("9.Porque no lo llenaba", 9),
                new KeyValuePair<string, int>("10.Regresé a trabajar", 10),
                new KeyValuePair<string, int>("11.Tuve problemas con mis pezones o pecho (no tenía pezón, grietas, pechos muy llenos, dolor en los pezones)", 11),
                new KeyValuePair<string, int>("12.Otra razón", 12),
            };
    }

    public class PartosInfo
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("CSR")]
        public int? CSRId { get; set; }

        public int SemanasGestacion { get; set; }

        public int GestacionTipoId { get; set; }

        public int PartoCesareaAbortoId { get; set; }

        public double Peso { get; set; }
        public double Talla { get; set; }

        public bool HijoVivo { get; set; }

        public int DefuncionId { get; set; }

        public double Dia { get; set; }
        public double Mes { get; set; }
        public double Year { get; set; }

        public int AtendidaId { get; set; }

        //cesarea
        public int CesareaMotivoId { get; set; }
        public string CesareaOtros { get; set; } = string.Empty;

        //reactivo
        public bool Reactivo { get; set; } = false;
        
        //InfoLactancia
        public bool InfoLactancia { get; set; } = false;

        public int SitioInfoLactanciaId { get; set; }

        public bool DarPechoAntes { get; set; } = false;

        public int DarPechoAntesRazonId { get; set; }

        public int PensabaAlimentarloId { get; set; }

        public bool DespuesParto1 { get; set; } = false;
        public bool DespuesParto2 { get; set; } = false;
        public bool DespuesParto3 { get; set; } = false;
        public bool DespuesParto4 { get; set; } = false;
        public bool DespuesParto5 { get; set; } = false;
        public bool DespuesParto6 { get; set; } = false;

        public int AlimentoBebesmId { get; set; }

        public int EligioTipoAlimId { get; set; }

        public int MinutosDesp { get; set; }
        public int HorasDesp { get; set;}
        public int DiasDesp { get; set; }

        public int MinutosTotales { get; set; }
        public int HorasTotales { get; set; }
        public int DiasTotales { get; set; }
        public int MesesTotales { get; set; }
        public int AniosTotales { get; set; }

        public int DejoDarleLechePechoId { get; set; }
        public string DejoDarleLechePechoOtros { get; set; } = string.Empty;

        public int NuncaLechePechoId { get; set; }
        public string NuncaLechePechoOtros { get; set; } = string.Empty;
    }
}