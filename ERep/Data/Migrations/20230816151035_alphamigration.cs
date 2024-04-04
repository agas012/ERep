using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ERep.Data.Migrations
{
    /// <inheritdoc />
    public partial class alphamigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "States",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_States", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Patients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    aceptoconocimieto = table.Column<bool>(type: "INTEGER", nullable: false),
                    Iniciales = table.Column<string>(type: "TEXT", nullable: false),
                    Date = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ECU = table.Column<string>(type: "TEXT", nullable: false),
                    BornDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Age = table.Column<int>(type: "INTEGER", nullable: false),
                    sexoId = table.Column<int>(type: "INTEGER", nullable: false),
                    generoId = table.Column<int>(type: "INTEGER", nullable: false),
                    Folio = table.Column<string>(type: "TEXT", nullable: false),
                    PostalCode = table.Column<string>(type: "TEXT", nullable: false),
                    Phone = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    estadocivil = table.Column<int>(type: "INTEGER", nullable: false),
                    estadocivilotro = table.Column<string>(type: "TEXT", nullable: false),
                    CurrentPartner = table.Column<int>(type: "INTEGER", nullable: false),
                    Residencia = table.Column<int>(type: "INTEGER", nullable: false),
                    Residencialugar = table.Column<string>(type: "TEXT", nullable: false),
                    escolaridad = table.Column<int>(type: "INTEGER", nullable: false),
                    escolaridadanos = table.Column<int>(type: "INTEGER", nullable: false),
                    escolaridadtipo = table.Column<string>(type: "TEXT", nullable: false),
                    StateId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patients", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Patients_States_StateId",
                        column: x => x.StateId,
                        principalTable: "States",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CSRs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Date = table.Column<DateTime>(type: "TEXT", nullable: false),
                    PatientId = table.Column<int>(type: "INTEGER", nullable: false),
                    EreumaticaId = table.Column<int>(type: "INTEGER", nullable: false),
                    otraEreumatica = table.Column<string>(type: "TEXT", nullable: false),
                    DateSintomas = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DateDiagnostico = table.Column<DateTime>(type: "TEXT", nullable: false),
                    embarazada = table.Column<int>(type: "INTEGER", nullable: false),
                    embarazadaId = table.Column<int>(type: "INTEGER", nullable: false),
                    numabortos = table.Column<int>(type: "INTEGER", nullable: false),
                    TipoEmbarazoId = table.Column<int>(type: "INTEGER", nullable: false),
                    numembarazos = table.Column<int>(type: "INTEGER", nullable: false),
                    hijosnacvivosfall = table.Column<int>(type: "INTEGER", nullable: false),
                    numhijosdesea = table.Column<int>(type: "INTEGER", nullable: false),
                    pnumhijosId = table.Column<int>(type: "INTEGER", nullable: false),
                    rmashijosId = table.Column<int>(type: "INTEGER", nullable: false),
                    rmenoshijosId = table.Column<int>(type: "INTEGER", nullable: false),
                    hijosalgunavezId = table.Column<int>(type: "INTEGER", nullable: false),
                    hijosahoraId = table.Column<int>(type: "INTEGER", nullable: false),
                    hijosnopuedeId = table.Column<int>(type: "INTEGER", nullable: false),
                    hijosnopuedeotro = table.Column<string>(type: "TEXT", nullable: false),
                    hijosnorazonId = table.Column<int>(type: "INTEGER", nullable: false),
                    hijosnorazonotro = table.Column<string>(type: "TEXT", nullable: false),
                    hijosnodeseananoId = table.Column<int>(type: "INTEGER", nullable: false),
                    hijosnodeseananootro = table.Column<string>(type: "TEXT", nullable: false),
                    hijosnodeseanuncaId = table.Column<int>(type: "INTEGER", nullable: false),
                    hijosnodeseanuncaotro = table.Column<string>(type: "TEXT", nullable: false),
                    hijosesperaId = table.Column<int>(type: "INTEGER", nullable: false),
                    hijosesperanum = table.Column<int>(type: "INTEGER", nullable: false),
                    reuma_confianzaplanificarfamiliaId = table.Column<int>(type: "INTEGER", nullable: false),
                    reuma_planificarfamiliaId = table.Column<int>(type: "INTEGER", nullable: false),
                    reuma_riesembarazoId = table.Column<int>(type: "INTEGER", nullable: false),
                    reuma_riesgomedId = table.Column<int>(type: "INTEGER", nullable: false),
                    metodos_conoce_a = table.Column<bool>(type: "INTEGER", nullable: false),
                    metodos_conoce_b = table.Column<bool>(type: "INTEGER", nullable: false),
                    metodos_conoce_c = table.Column<bool>(type: "INTEGER", nullable: false),
                    metodos_conoce_d = table.Column<bool>(type: "INTEGER", nullable: false),
                    metodos_conoce_e = table.Column<bool>(type: "INTEGER", nullable: false),
                    metodos_conoce_f = table.Column<bool>(type: "INTEGER", nullable: false),
                    metodos_conoce_g = table.Column<bool>(type: "INTEGER", nullable: false),
                    metodos_conoce_h = table.Column<bool>(type: "INTEGER", nullable: false),
                    metodos_conoce_i = table.Column<bool>(type: "INTEGER", nullable: false),
                    metodos_conoce_j = table.Column<bool>(type: "INTEGER", nullable: false),
                    metodos_conoce_k = table.Column<bool>(type: "INTEGER", nullable: false),
                    metodos_conoce_l = table.Column<bool>(type: "INTEGER", nullable: false),
                    metodos_conoce_m = table.Column<bool>(type: "INTEGER", nullable: false),
                    metodos_conoce_n = table.Column<bool>(type: "INTEGER", nullable: false),
                    metodos_conoce_nn = table.Column<bool>(type: "INTEGER", nullable: false),
                    metodos_conoce_o = table.Column<string>(type: "TEXT", nullable: false),
                    metodos_funciona_a = table.Column<bool>(type: "INTEGER", nullable: false),
                    metodos_funciona_b = table.Column<bool>(type: "INTEGER", nullable: false),
                    metodos_funciona_c = table.Column<bool>(type: "INTEGER", nullable: false),
                    metodos_funciona_d = table.Column<bool>(type: "INTEGER", nullable: false),
                    metodos_funciona_e = table.Column<bool>(type: "INTEGER", nullable: false),
                    metodos_funciona_f = table.Column<bool>(type: "INTEGER", nullable: false),
                    metodos_funciona_g = table.Column<bool>(type: "INTEGER", nullable: false),
                    metodos_funciona_h = table.Column<bool>(type: "INTEGER", nullable: false),
                    metodos_funciona_i = table.Column<bool>(type: "INTEGER", nullable: false),
                    metodos_funciona_j = table.Column<bool>(type: "INTEGER", nullable: false),
                    metodos_funciona_k = table.Column<bool>(type: "INTEGER", nullable: false),
                    metodos_funciona_l = table.Column<bool>(type: "INTEGER", nullable: false),
                    metodos_funciona_m = table.Column<bool>(type: "INTEGER", nullable: false),
                    metodos_funciona_n = table.Column<bool>(type: "INTEGER", nullable: false),
                    metodos_funciona_nn = table.Column<bool>(type: "INTEGER", nullable: false),
                    metodos_funciona_o = table.Column<string>(type: "TEXT", nullable: false),
                    anticon_histusoId = table.Column<int>(type: "INTEGER", nullable: false),
                    anticon_usoId = table.Column<int>(type: "INTEGER", nullable: false),
                    metodos_utiliza_a = table.Column<bool>(type: "INTEGER", nullable: false),
                    metodos_utiliza_b = table.Column<bool>(type: "INTEGER", nullable: false),
                    metodos_utiliza_c = table.Column<bool>(type: "INTEGER", nullable: false),
                    metodos_utiliza_d = table.Column<bool>(type: "INTEGER", nullable: false),
                    metodos_utiliza_e = table.Column<bool>(type: "INTEGER", nullable: false),
                    metodos_utiliza_f = table.Column<bool>(type: "INTEGER", nullable: false),
                    metodos_utiliza_g = table.Column<bool>(type: "INTEGER", nullable: false),
                    metodos_utiliza_h = table.Column<bool>(type: "INTEGER", nullable: false),
                    metodos_utiliza_i = table.Column<bool>(type: "INTEGER", nullable: false),
                    metodos_utiliza_j = table.Column<bool>(type: "INTEGER", nullable: false),
                    metodos_utiliza_k = table.Column<bool>(type: "INTEGER", nullable: false),
                    metodos_utiliza_l = table.Column<bool>(type: "INTEGER", nullable: false),
                    metodos_utiliza_m = table.Column<bool>(type: "INTEGER", nullable: false),
                    metodos_utiliza_n = table.Column<bool>(type: "INTEGER", nullable: false),
                    metodos_utiliza_nn = table.Column<bool>(type: "INTEGER", nullable: false),
                    metodos_utiliza_o = table.Column<string>(type: "TEXT", nullable: false),
                    anticon_operoId = table.Column<int>(type: "INTEGER", nullable: false),
                    anticon_operootro = table.Column<string>(type: "TEXT", nullable: false),
                    anticon_dondeId = table.Column<int>(type: "INTEGER", nullable: false),
                    anticon_dondeotro = table.Column<string>(type: "TEXT", nullable: false),
                    anticon_razonreceta_1 = table.Column<bool>(type: "INTEGER", nullable: false),
                    anticon_razonreceta_2 = table.Column<bool>(type: "INTEGER", nullable: false),
                    anticon_razonreceta_3 = table.Column<bool>(type: "INTEGER", nullable: false),
                    anticon_razonreceta_4 = table.Column<bool>(type: "INTEGER", nullable: false),
                    anticon_razonreceta_5 = table.Column<bool>(type: "INTEGER", nullable: false),
                    anticon_razonreceta_6 = table.Column<bool>(type: "INTEGER", nullable: false),
                    anticon_razonreceta_7 = table.Column<bool>(type: "INTEGER", nullable: false),
                    anticon_razonreceta_8 = table.Column<bool>(type: "INTEGER", nullable: false),
                    anticon_razonreceta_9 = table.Column<bool>(type: "INTEGER", nullable: false),
                    anticon_razonreceta_10 = table.Column<bool>(type: "INTEGER", nullable: false),
                    anticon_razonreceta_11 = table.Column<bool>(type: "INTEGER", nullable: false),
                    anticon_razonreceta_12 = table.Column<bool>(type: "INTEGER", nullable: false),
                    anticon_razonrecetaotro = table.Column<string>(type: "TEXT", nullable: false),
                    anticon_razonnousaId = table.Column<int>(type: "INTEGER", nullable: false),
                    anticon_razonnousaotro = table.Column<string>(type: "TEXT", nullable: false),
                    anticon_contraponeId = table.Column<int>(type: "INTEGER", nullable: false),
                    anticon_contraponeotro = table.Column<string>(type: "TEXT", nullable: false),
                    anticon_edadprimeraId = table.Column<int>(type: "INTEGER", nullable: false),
                    anticon_primerapro1 = table.Column<bool>(type: "INTEGER", nullable: false),
                    anticon_primerapro2 = table.Column<bool>(type: "INTEGER", nullable: false),
                    anticon_primerapro3 = table.Column<bool>(type: "INTEGER", nullable: false),
                    anticon_primerapro4 = table.Column<bool>(type: "INTEGER", nullable: false),
                    anticon_primerapro5 = table.Column<bool>(type: "INTEGER", nullable: false),
                    anticon_primerapro6 = table.Column<bool>(type: "INTEGER", nullable: false),
                    anticon_primerapro7 = table.Column<bool>(type: "INTEGER", nullable: false),
                    anticon_primerapro8 = table.Column<bool>(type: "INTEGER", nullable: false),
                    anticon_primerapro9 = table.Column<bool>(type: "INTEGER", nullable: false),
                    anticon_primerapro10 = table.Column<bool>(type: "INTEGER", nullable: false),
                    anticon_primerapro11 = table.Column<bool>(type: "INTEGER", nullable: false),
                    anticon_primerapro12 = table.Column<bool>(type: "INTEGER", nullable: false),
                    anticon_primerapro13 = table.Column<bool>(type: "INTEGER", nullable: false),
                    anticon_primerapro14 = table.Column<bool>(type: "INTEGER", nullable: false),
                    anticon_primerapro15 = table.Column<bool>(type: "INTEGER", nullable: false),
                    anticon_primerapro16 = table.Column<bool>(type: "INTEGER", nullable: false),
                    anticon_primeraprototro = table.Column<string>(type: "TEXT", nullable: false),
                    anticon_primerarazonId = table.Column<int>(type: "INTEGER", nullable: false),
                    anticon_primerarazonotro = table.Column<string>(type: "TEXT", nullable: false),
                    ultimarelaciones_nodecir = table.Column<bool>(type: "INTEGER", nullable: false),
                    ultimarelaciones_dias = table.Column<int>(type: "INTEGER", nullable: false),
                    ultimarelaciones_semanas = table.Column<int>(type: "INTEGER", nullable: false),
                    ultimarelaciones_meses = table.Column<int>(type: "INTEGER", nullable: false),
                    ultimarelaciones_anos = table.Column<int>(type: "INTEGER", nullable: false),
                    Radio = table.Column<bool>(type: "INTEGER", nullable: false),
                    Television = table.Column<bool>(type: "INTEGER", nullable: false),
                    Periodico = table.Column<bool>(type: "INTEGER", nullable: false),
                    Internet = table.Column<bool>(type: "INTEGER", nullable: false),
                    RedesSociales = table.Column<bool>(type: "INTEGER", nullable: false),
                    Carteles = table.Column<bool>(type: "INTEGER", nullable: false),
                    Platicas = table.Column<bool>(type: "INTEGER", nullable: false),
                    otro_medio = table.Column<bool>(type: "INTEGER", nullable: false),
                    otro_medio_text = table.Column<string>(type: "TEXT", nullable: false),
                    Facebook = table.Column<bool>(type: "INTEGER", nullable: false),
                    Instagram = table.Column<bool>(type: "INTEGER", nullable: false),
                    Twitter = table.Column<bool>(type: "INTEGER", nullable: false),
                    WhatsApp = table.Column<bool>(type: "INTEGER", nullable: false),
                    TikTok = table.Column<bool>(type: "INTEGER", nullable: false),
                    otra_red = table.Column<bool>(type: "INTEGER", nullable: false),
                    otra_red_text = table.Column<string>(type: "TEXT", nullable: false),
                    ultimaregla_nodecir = table.Column<bool>(type: "INTEGER", nullable: false),
                    ultimaregla_dias = table.Column<int>(type: "INTEGER", nullable: false),
                    ultimaregla_semanas = table.Column<int>(type: "INTEGER", nullable: false),
                    ultimaregla_meses = table.Column<int>(type: "INTEGER", nullable: false),
                    ultimaregla_anos = table.Column<int>(type: "INTEGER", nullable: false),
                    ultimaregla_nohamestruado = table.Column<bool>(type: "INTEGER", nullable: false),
                    ultimaregla_norecuerdo = table.Column<bool>(type: "INTEGER", nullable: false),
                    ultimaregla_menopausia = table.Column<bool>(type: "INTEGER", nullable: false),
                    medicamento_1 = table.Column<bool>(type: "INTEGER", nullable: false),
                    medicamento_2 = table.Column<bool>(type: "INTEGER", nullable: false),
                    medicamento_3 = table.Column<bool>(type: "INTEGER", nullable: false),
                    medicamento_4 = table.Column<bool>(type: "INTEGER", nullable: false),
                    medicamento_5 = table.Column<bool>(type: "INTEGER", nullable: false),
                    medicamento_6 = table.Column<bool>(type: "INTEGER", nullable: false),
                    medicamento_7 = table.Column<bool>(type: "INTEGER", nullable: false),
                    medicamento_8 = table.Column<bool>(type: "INTEGER", nullable: false),
                    medicamento_9 = table.Column<bool>(type: "INTEGER", nullable: false),
                    medicamento_10 = table.Column<bool>(type: "INTEGER", nullable: false),
                    medicamento_11 = table.Column<bool>(type: "INTEGER", nullable: false),
                    medicamento_12 = table.Column<bool>(type: "INTEGER", nullable: false),
                    medicamento_13 = table.Column<bool>(type: "INTEGER", nullable: false),
                    medicamento_14 = table.Column<bool>(type: "INTEGER", nullable: false),
                    medicamento_15 = table.Column<bool>(type: "INTEGER", nullable: false),
                    medicamento_16 = table.Column<bool>(type: "INTEGER", nullable: false),
                    medicamento_17 = table.Column<bool>(type: "INTEGER", nullable: false),
                    medicamento_otros = table.Column<bool>(type: "INTEGER", nullable: false),
                    medicamento_otros_text = table.Column<string>(type: "TEXT", nullable: false),
                    parto_tipoId = table.Column<int>(type: "INTEGER", nullable: false),
                    cesarea_ener_motivo = table.Column<string>(type: "TEXT", nullable: false),
                    cesarea_decidioId = table.Column<int>(type: "INTEGER", nullable: false),
                    cesarea_motivoId = table.Column<int>(type: "INTEGER", nullable: false),
                    cesarea_motivootro = table.Column<string>(type: "TEXT", nullable: false),
                    actividad_despues_parto_1 = table.Column<bool>(type: "INTEGER", nullable: false),
                    actividad_despues_parto_2 = table.Column<bool>(type: "INTEGER", nullable: false),
                    actividad_despues_parto_3 = table.Column<bool>(type: "INTEGER", nullable: false),
                    lechematerna_dio = table.Column<bool>(type: "INTEGER", nullable: false),
                    lechematerna_horas = table.Column<int>(type: "INTEGER", nullable: false),
                    lechematerna_dias = table.Column<int>(type: "INTEGER", nullable: false),
                    lechematerna_duracionId = table.Column<int>(type: "INTEGER", nullable: false),
                    lechematerna_nodioId = table.Column<int>(type: "INTEGER", nullable: false),
                    lechematerna_nodiootro = table.Column<string>(type: "TEXT", nullable: false),
                    lechematerna_dejadarId = table.Column<int>(type: "INTEGER", nullable: false),
                    lechematerna_dejadarotro = table.Column<string>(type: "TEXT", nullable: false),
                    vianac_decidioId = table.Column<int>(type: "INTEGER", nullable: false),
                    partomedicamento_1 = table.Column<bool>(type: "INTEGER", nullable: false),
                    partomedicamento_2 = table.Column<bool>(type: "INTEGER", nullable: false),
                    partomedicamento_3 = table.Column<bool>(type: "INTEGER", nullable: false),
                    partomedicamento_4 = table.Column<bool>(type: "INTEGER", nullable: false),
                    partomedicamento_5 = table.Column<bool>(type: "INTEGER", nullable: false),
                    partomedicamento_6 = table.Column<bool>(type: "INTEGER", nullable: false),
                    partomedicamento_7 = table.Column<bool>(type: "INTEGER", nullable: false),
                    partomedicamento_8 = table.Column<bool>(type: "INTEGER", nullable: false),
                    partomedicamento_9 = table.Column<bool>(type: "INTEGER", nullable: false),
                    partomedicamento_10 = table.Column<bool>(type: "INTEGER", nullable: false),
                    partomedicamento_11 = table.Column<bool>(type: "INTEGER", nullable: false),
                    partomedicamento_12 = table.Column<bool>(type: "INTEGER", nullable: false),
                    partomedicamento_13 = table.Column<bool>(type: "INTEGER", nullable: false),
                    partomedicamento_14 = table.Column<bool>(type: "INTEGER", nullable: false),
                    partomedicamento_15 = table.Column<bool>(type: "INTEGER", nullable: false),
                    partomedicamento_16 = table.Column<bool>(type: "INTEGER", nullable: false),
                    partomedicamento_17 = table.Column<bool>(type: "INTEGER", nullable: false),
                    partomedicamento_18 = table.Column<bool>(type: "INTEGER", nullable: false),
                    partomedicamento_19 = table.Column<bool>(type: "INTEGER", nullable: false),
                    partomedicamento_20 = table.Column<bool>(type: "INTEGER", nullable: false),
                    partomedicamento_21 = table.Column<bool>(type: "INTEGER", nullable: false),
                    partomedicamento_22 = table.Column<bool>(type: "INTEGER", nullable: false),
                    partomedicamento_23 = table.Column<bool>(type: "INTEGER", nullable: false),
                    partomedicamento_24 = table.Column<bool>(type: "INTEGER", nullable: false),
                    partomedicamento_25 = table.Column<bool>(type: "INTEGER", nullable: false),
                    partomedicamento_26 = table.Column<bool>(type: "INTEGER", nullable: false),
                    partomedicamento_27 = table.Column<bool>(type: "INTEGER", nullable: false),
                    partomedicamento_28 = table.Column<bool>(type: "INTEGER", nullable: false),
                    partomedicamento_29 = table.Column<bool>(type: "INTEGER", nullable: false),
                    partomedicamento_30 = table.Column<bool>(type: "INTEGER", nullable: false),
                    partomedicamento_otros = table.Column<bool>(type: "INTEGER", nullable: false),
                    partomedicamento_otros_text = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CSRs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CSRs_Patients_PatientId",
                        column: x => x.PatientId,
                        principalTable: "Patients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PartosInfos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CSRId = table.Column<int>(type: "INTEGER", nullable: true),
                    SemanasGestacion = table.Column<int>(type: "INTEGER", nullable: false),
                    GestacionTipoId = table.Column<int>(type: "INTEGER", nullable: false),
                    PartoCesareaAbortoId = table.Column<int>(type: "INTEGER", nullable: false),
                    Peso = table.Column<double>(type: "REAL", nullable: false),
                    Talla = table.Column<double>(type: "REAL", nullable: false),
                    HijoVivo = table.Column<bool>(type: "INTEGER", nullable: false),
                    DefuncionId = table.Column<int>(type: "INTEGER", nullable: false),
                    Dia = table.Column<double>(type: "REAL", nullable: false),
                    Mes = table.Column<double>(type: "REAL", nullable: false),
                    Year = table.Column<double>(type: "REAL", nullable: false),
                    AtendidaId = table.Column<int>(type: "INTEGER", nullable: false),
                    CesareaMotivoId = table.Column<int>(type: "INTEGER", nullable: false),
                    CesareaOtros = table.Column<string>(type: "TEXT", nullable: false),
                    Reactivo = table.Column<bool>(type: "INTEGER", nullable: false),
                    InfoLactancia = table.Column<bool>(type: "INTEGER", nullable: false),
                    SitioInfoLactanciaId = table.Column<int>(type: "INTEGER", nullable: false),
                    DarPechoAntes = table.Column<bool>(type: "INTEGER", nullable: false),
                    DarPechoAntesRazonId = table.Column<int>(type: "INTEGER", nullable: false),
                    PensabaAlimentarloId = table.Column<int>(type: "INTEGER", nullable: false),
                    DespuesParto1 = table.Column<bool>(type: "INTEGER", nullable: false),
                    DespuesParto2 = table.Column<bool>(type: "INTEGER", nullable: false),
                    DespuesParto3 = table.Column<bool>(type: "INTEGER", nullable: false),
                    DespuesParto4 = table.Column<bool>(type: "INTEGER", nullable: false),
                    DespuesParto5 = table.Column<bool>(type: "INTEGER", nullable: false),
                    DespuesParto6 = table.Column<bool>(type: "INTEGER", nullable: false),
                    AlimentoBebesmId = table.Column<int>(type: "INTEGER", nullable: false),
                    EligioTipoAlimId = table.Column<int>(type: "INTEGER", nullable: false),
                    MinutosDesp = table.Column<int>(type: "INTEGER", nullable: false),
                    HorasDesp = table.Column<int>(type: "INTEGER", nullable: false),
                    DiasDesp = table.Column<int>(type: "INTEGER", nullable: false),
                    MinutosTotales = table.Column<int>(type: "INTEGER", nullable: false),
                    HorasTotales = table.Column<int>(type: "INTEGER", nullable: false),
                    DiasTotales = table.Column<int>(type: "INTEGER", nullable: false),
                    MesesTotales = table.Column<int>(type: "INTEGER", nullable: false),
                    AniosTotales = table.Column<int>(type: "INTEGER", nullable: false),
                    DejoDarleLechePechoId = table.Column<int>(type: "INTEGER", nullable: false),
                    DejoDarleLechePechoOtros = table.Column<string>(type: "TEXT", nullable: false),
                    NuncaLechePechoId = table.Column<int>(type: "INTEGER", nullable: false),
                    NuncaLechePechoOtros = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PartosInfos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PartosInfos_CSRs_CSRId",
                        column: x => x.CSRId,
                        principalTable: "CSRs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "States",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Aguascalientes" },
                    { 2, "Baja California" },
                    { 3, "Baja California Sur" },
                    { 4, "Campeche" },
                    { 5, "Chiapas" },
                    { 6, "Chihuahua" },
                    { 7, "Coahuila" },
                    { 8, "Colima" },
                    { 9, "Ciudad de México" },
                    { 10, "Durango" },
                    { 11, "Guanajuato" },
                    { 12, "Guerrero" },
                    { 13, "Hidalgo" },
                    { 14, "Jalisco" },
                    { 15, "México" },
                    { 16, "Michoacán" },
                    { 17, "Morelos" },
                    { 18, "Nayarit" },
                    { 19, "Nuevo León" },
                    { 20, "Oaxaca" },
                    { 21, "Puebla" },
                    { 22, "Querétaro" },
                    { 23, "Quintana Roo" },
                    { 24, "San Luis Potosí" },
                    { 25, "Sinaloa" },
                    { 26, "Sonora" },
                    { 27, "Tabasco" },
                    { 28, "Tamaulipas" },
                    { 29, "Tlaxcala" },
                    { 30, "Veracruz" },
                    { 31, "Yucatán" },
                    { 32, "Zacatecas" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CSRs_PatientId",
                table: "CSRs",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_PartosInfos_CSRId",
                table: "PartosInfos",
                column: "CSRId");

            migrationBuilder.CreateIndex(
                name: "IX_Patients_StateId",
                table: "Patients",
                column: "StateId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PartosInfos");

            migrationBuilder.DropTable(
                name: "CSRs");

            migrationBuilder.DropTable(
                name: "Patients");

            migrationBuilder.DropTable(
                name: "States");
        }
    }
}
