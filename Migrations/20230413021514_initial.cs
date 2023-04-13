using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace INTEX.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "analysis",
                columns: table => new
                {
                    id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    analysistype = table.Column<int>(nullable: true),
                    doneby = table.Column<string>(nullable: true),
                    analysisid = table.Column<int>(nullable: true),
                    date = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_analysis", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "analysistextile",
                columns: table => new
                {
                    mainanalysisid = table.Column<long>(nullable: false),
                    maintextileid = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_analysistextile", x => new { x.mainanalysisid, x.maintextileid });
                });

            migrationBuilder.CreateTable(
                name: "artifactfagelgamousregister",
                columns: table => new
                {
                    id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    registernum = table.Column<string>(nullable: true),
                    photographed = table.Column<string>(nullable: true),
                    notes = table.Column<string>(nullable: true),
                    coordinateset = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_artifactfagelgamousregister", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "artifactfagelgamousregisterburialmain",
                columns: table => new
                {
                    mainartifactfagelgamousregisterid = table.Column<long>(nullable: false),
                    mainburialmainid = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_artifactfagelgamousregisterburialmain", x => new { x.mainartifactfagelgamousregisterid, x.mainburialmainid });
                });

            migrationBuilder.CreateTable(
                name: "artifactkomaushimregister",
                columns: table => new
                {
                    id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    provenance = table.Column<string>(nullable: true),
                    description = table.Column<string>(nullable: true),
                    position = table.Column<string>(nullable: true),
                    qualityphotos = table.Column<string>(nullable: true),
                    finder = table.Column<string>(nullable: true),
                    dimensions = table.Column<string>(nullable: true),
                    material = table.Column<string>(nullable: true),
                    rehousedto = table.Column<string>(nullable: true),
                    photos = table.Column<string>(nullable: true),
                    number = table.Column<string>(nullable: true),
                    remarks = table.Column<string>(nullable: true),
                    entrydate = table.Column<DateTime>(nullable: true),
                    currentlocation = table.Column<string>(nullable: true),
                    excavatornum = table.Column<string>(nullable: true),
                    date = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_artifactkomaushimregister", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "artifactkomaushimregisterburialmain",
                columns: table => new
                {
                    mainartifactkomaushimregisterid = table.Column<long>(nullable: false),
                    mainburialmainid = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_artifactkomaushimregisterburialmain", x => new { x.mainartifactkomaushimregisterid, x.mainburialmainid });
                });

            migrationBuilder.CreateTable(
                name: "biological",
                columns: table => new
                {
                    id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    racknumber = table.Column<int>(nullable: true),
                    bagnumber = table.Column<int>(nullable: true),
                    previouslysampled = table.Column<string>(nullable: true),
                    initials = table.Column<string>(nullable: true),
                    clusternumber = table.Column<int>(nullable: true),
                    date = table.Column<DateTime>(nullable: true),
                    notes = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_biological", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "biologicalc14",
                columns: table => new
                {
                    mainbiologicalid = table.Column<long>(nullable: false),
                    mainc14id = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_biologicalc14", x => new { x.mainbiologicalid, x.mainc14id });
                });

            migrationBuilder.CreateTable(
                name: "bodyanalysischart",
                columns: table => new
                {
                    squarenorthsouth = table.Column<string>(nullable: false),
                    northsouth = table.Column<string>(nullable: true),
                    squareeastwest = table.Column<string>(nullable: true),
                    eastwest = table.Column<string>(nullable: true),
                    area = table.Column<string>(nullable: true),
                    burialnumber = table.Column<int>(nullable: false),
                    dateofexamination = table.Column<string>(nullable: true),
                    preservationindex = table.Column<int>(nullable: true),
                    haircolor = table.Column<string>(nullable: true),
                    observations = table.Column<string>(nullable: true),
                    robust = table.Column<string>(nullable: true),
                    supraorbitalridges = table.Column<string>(nullable: true),
                    orbitedge = table.Column<string>(nullable: true),
                    parietalbossing = table.Column<string>(nullable: true),
                    gonion = table.Column<string>(nullable: true),
                    nuchalcrest = table.Column<string>(nullable: true),
                    zygomaticcrest = table.Column<string>(nullable: true),
                    sphenooccipitalsynchondrosis = table.Column<string>(nullable: true),
                    lamboidsuture = table.Column<string>(nullable: true),
                    squamossuture = table.Column<string>(nullable: true),
                    toothattrition = table.Column<string>(nullable: true),
                    tootheruption = table.Column<string>(nullable: true),
                    tootheruptionageestimate = table.Column<string>(nullable: true),
                    ventralarc = table.Column<string>(nullable: true),
                    subpubicangle = table.Column<string>(nullable: true),
                    sciaticnotch = table.Column<string>(nullable: true),
                    pubicbone = table.Column<string>(nullable: true),
                    medialipramus = table.Column<string>(nullable: true),
                    femur = table.Column<string>(nullable: true),
                    humerus = table.Column<string>(nullable: true),
                    femurheaddiameter = table.Column<string>(nullable: true),
                    humerusheaddiameter = table.Column<string>(nullable: true),
                    femurlength = table.Column<decimal>(nullable: true),
                    humeruslength = table.Column<decimal>(nullable: true),
                    osteophytosis = table.Column<string>(nullable: true),
                    cariesperiodontaldisease = table.Column<string>(nullable: true),
                    notes = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bodyanalysischart", x => x.squarenorthsouth);
                });

            migrationBuilder.CreateTable(
                name: "books",
                columns: table => new
                {
                    id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    description = table.Column<string>(nullable: true),
                    title = table.Column<string>(nullable: true),
                    author = table.Column<string>(nullable: true),
                    link = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_books", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "burialmain",
                columns: table => new
                {
                    id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    squarenorthsouth = table.Column<string>(nullable: true),
                    headdirection = table.Column<string>(nullable: true),
                    sex = table.Column<string>(nullable: true),
                    northsouth = table.Column<string>(nullable: true),
                    depth = table.Column<string>(nullable: true),
                    eastwest = table.Column<string>(nullable: true),
                    adultsubadult = table.Column<string>(nullable: true),
                    facebundles = table.Column<string>(nullable: true),
                    southtohead = table.Column<string>(nullable: true),
                    preservation = table.Column<string>(nullable: true),
                    fieldbookpage = table.Column<string>(nullable: true),
                    squareeastwest = table.Column<string>(nullable: true),
                    goods = table.Column<string>(nullable: true),
                    text = table.Column<string>(nullable: true),
                    wrapping = table.Column<string>(nullable: true),
                    haircolor = table.Column<string>(nullable: true),
                    westtohead = table.Column<string>(nullable: true),
                    samplescollected = table.Column<string>(nullable: true),
                    area = table.Column<string>(nullable: true),
                    burialid = table.Column<long>(nullable: true),
                    length = table.Column<string>(nullable: true),
                    burialnumber = table.Column<string>(nullable: true),
                    dataexpertinitials = table.Column<string>(nullable: true),
                    westtofeet = table.Column<string>(nullable: true),
                    ageatdeath = table.Column<string>(nullable: true),
                    southtofeet = table.Column<string>(nullable: true),
                    excavationrecorder = table.Column<string>(nullable: true),
                    photos = table.Column<string>(nullable: true),
                    hair = table.Column<string>(nullable: true),
                    burialmaterials = table.Column<string>(nullable: true),
                    dateofexcavation = table.Column<DateTime>(nullable: true),
                    fieldbookexcavationyear = table.Column<string>(nullable: true),
                    clusternumber = table.Column<string>(nullable: true),
                    shaftnumber = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_burialmain", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "burialmainbiological",
                columns: table => new
                {
                    mainburialmainid = table.Column<long>(nullable: false),
                    mainbiologicalid = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_burialmainbiological", x => new { x.mainburialmainid, x.mainbiologicalid });
                });

            migrationBuilder.CreateTable(
                name: "burialmainbodyanalysischart",
                columns: table => new
                {
                    mainburialmainid = table.Column<long>(nullable: false),
                    mainbodyanalysischartid = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_burialmainbodyanalysischart", x => new { x.mainburialmainid, x.mainbodyanalysischartid });
                });

            migrationBuilder.CreateTable(
                name: "burialmaincranium",
                columns: table => new
                {
                    mainburialmainid = table.Column<long>(nullable: false),
                    maincraniumid = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_burialmaincranium", x => new { x.mainburialmainid, x.maincraniumid });
                });

            migrationBuilder.CreateTable(
                name: "burialmaintextile",
                columns: table => new
                {
                    mainburialmainid = table.Column<long>(nullable: false),
                    maintextileid = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_burialmaintextile", x => new { x.mainburialmainid, x.maintextileid });
                });

            migrationBuilder.CreateTable(
                name: "c14",
                columns: table => new
                {
                    id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    description = table.Column<string>(nullable: true),
                    category = table.Column<string>(nullable: true),
                    size = table.Column<int>(nullable: true),
                    agebp = table.Column<int>(nullable: true),
                    calibratedspan = table.Column<int>(nullable: true),
                    tubenumber = table.Column<int>(nullable: true),
                    calibrateddatemin = table.Column<int>(nullable: true),
                    calibrateddateavg = table.Column<int>(nullable: true),
                    foci = table.Column<string>(nullable: true),
                    rack = table.Column<int>(nullable: true),
                    calendardate = table.Column<int>(nullable: true),
                    calibrateddatemax = table.Column<int>(nullable: true),
                    c14lab = table.Column<string>(nullable: true),
                    questions = table.Column<string>(nullable: true),
                    location = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_c14", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "color",
                columns: table => new
                {
                    id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    value = table.Column<string>(nullable: true),
                    colorid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_color", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "colortextile",
                columns: table => new
                {
                    maincolorid = table.Column<long>(nullable: false),
                    maintextileid = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_colortextile", x => new { x.maincolorid, x.maintextileid });
                });

            migrationBuilder.CreateTable(
                name: "cranium",
                columns: table => new
                {
                    id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    interobitalbreadth = table.Column<decimal>(nullable: true),
                    maxnasalbreadth = table.Column<decimal>(nullable: true),
                    basionnasion = table.Column<decimal>(nullable: true),
                    interorbitalbreadth = table.Column<decimal>(nullable: true),
                    nasionprosthionupper = table.Column<decimal>(nullable: true),
                    nasoalphasubtense = table.Column<decimal>(nullable: true),
                    basionbregmaheight = table.Column<decimal>(nullable: true),
                    maxcraniumlength = table.Column<decimal>(nullable: true),
                    interorbitalsubtense = table.Column<decimal>(nullable: true),
                    basionprosthionlength = table.Column<decimal>(nullable: true),
                    alphacore = table.Column<decimal>(nullable: true),
                    midorbitalsubtense = table.Column<decimal>(nullable: true),
                    maxcraniumbreadth = table.Column<decimal>(nullable: true),
                    bizygomaticdiameter = table.Column<decimal>(nullable: true),
                    midorbitalbreadth = table.Column<decimal>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cranium", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "decoration",
                columns: table => new
                {
                    id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    decorationid = table.Column<int>(nullable: true),
                    value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_decoration", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "decorationtextile",
                columns: table => new
                {
                    maindecorationid = table.Column<long>(nullable: false),
                    maintextileid = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_decorationtextile", x => new { x.maindecorationid, x.maintextileid });
                });

            migrationBuilder.CreateTable(
                name: "dimension",
                columns: table => new
                {
                    id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    dimensiontype = table.Column<string>(nullable: true),
                    value = table.Column<string>(nullable: true),
                    dimensionid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dimension", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "dimensiontextile",
                columns: table => new
                {
                    maindimensionid = table.Column<long>(nullable: false),
                    maintextileid = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dimensiontextile", x => new { x.maindimensionid, x.maintextileid });
                });

            migrationBuilder.CreateTable(
                name: "newsarticle",
                columns: table => new
                {
                    id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    description = table.Column<string>(nullable: true),
                    author = table.Column<string>(nullable: true),
                    title = table.Column<string>(nullable: true),
                    urltoimage = table.Column<string>(nullable: true),
                    url = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_newsarticle", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "photodata",
                columns: table => new
                {
                    id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    description = table.Column<string>(nullable: true),
                    filename = table.Column<string>(nullable: true),
                    photodataid = table.Column<int>(nullable: true),
                    date = table.Column<DateTime>(nullable: true),
                    url = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_photodata", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "photodatatextile",
                columns: table => new
                {
                    mainphotodataid = table.Column<long>(nullable: false),
                    maintextileid = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_photodatatextile", x => new { x.mainphotodataid, x.maintextileid });
                });

            migrationBuilder.CreateTable(
                name: "photoform",
                columns: table => new
                {
                    id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    area = table.Column<string>(nullable: true),
                    squarenorthsouth = table.Column<string>(nullable: true),
                    tableassociation = table.Column<string>(nullable: true),
                    filename = table.Column<string>(nullable: true),
                    photographer = table.Column<string>(nullable: true),
                    burialnumber = table.Column<string>(nullable: true),
                    squareeastwest = table.Column<string>(nullable: true),
                    eastwest = table.Column<string>(nullable: true),
                    northsouth = table.Column<string>(nullable: true),
                    photodate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_photoform", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "structure",
                columns: table => new
                {
                    id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    value = table.Column<string>(nullable: true),
                    structureid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_structure", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "structuretextile",
                columns: table => new
                {
                    mainstructureid = table.Column<long>(nullable: false),
                    maintextileid = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_structuretextile", x => new { x.mainstructureid, x.maintextileid });
                });

            migrationBuilder.CreateTable(
                name: "teammember",
                columns: table => new
                {
                    id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    bio = table.Column<string>(nullable: true),
                    membername = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_teammember", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "textile",
                columns: table => new
                {
                    id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    locale = table.Column<string>(nullable: true),
                    textileid = table.Column<int>(nullable: true),
                    description = table.Column<string>(nullable: true),
                    burialnumber = table.Column<string>(nullable: true),
                    estimatedperiod = table.Column<string>(nullable: true),
                    sampledate = table.Column<DateTime>(nullable: true),
                    photographeddate = table.Column<DateTime>(nullable: true),
                    direction = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_textile", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "textilefunction",
                columns: table => new
                {
                    id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    value = table.Column<string>(nullable: true),
                    textilefunctionid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_textilefunction", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "textilefunctiontextile",
                columns: table => new
                {
                    maintextilefunctionid = table.Column<long>(nullable: false),
                    maintextileid = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_textilefunctiontextile", x => new { x.maintextilefunctionid, x.maintextileid });
                });

            migrationBuilder.CreateTable(
                name: "yarnmanipulation",
                columns: table => new
                {
                    id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    thickness = table.Column<string>(nullable: true),
                    angle = table.Column<string>(nullable: true),
                    manipulation = table.Column<string>(nullable: true),
                    material = table.Column<string>(nullable: true),
                    count = table.Column<string>(nullable: true),
                    component = table.Column<string>(nullable: true),
                    Pply = table.Column<string>(nullable: true),
                    yarnmanipulationid = table.Column<int>(nullable: true),
                    direction = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_yarnmanipulation", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "yarnmanipulationtextile",
                columns: table => new
                {
                    mainyarnmanipulationid = table.Column<long>(nullable: false),
                    maintextileid = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_yarnmanipulationtextile", x => new { x.mainyarnmanipulationid, x.maintextileid });
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "analysis");

            migrationBuilder.DropTable(
                name: "analysistextile");

            migrationBuilder.DropTable(
                name: "artifactfagelgamousregister");

            migrationBuilder.DropTable(
                name: "artifactfagelgamousregisterburialmain");

            migrationBuilder.DropTable(
                name: "artifactkomaushimregister");

            migrationBuilder.DropTable(
                name: "artifactkomaushimregisterburialmain");

            migrationBuilder.DropTable(
                name: "biological");

            migrationBuilder.DropTable(
                name: "biologicalc14");

            migrationBuilder.DropTable(
                name: "bodyanalysischart");

            migrationBuilder.DropTable(
                name: "books");

            migrationBuilder.DropTable(
                name: "burialmain");

            migrationBuilder.DropTable(
                name: "burialmainbiological");

            migrationBuilder.DropTable(
                name: "burialmainbodyanalysischart");

            migrationBuilder.DropTable(
                name: "burialmaincranium");

            migrationBuilder.DropTable(
                name: "burialmaintextile");

            migrationBuilder.DropTable(
                name: "c14");

            migrationBuilder.DropTable(
                name: "color");

            migrationBuilder.DropTable(
                name: "colortextile");

            migrationBuilder.DropTable(
                name: "cranium");

            migrationBuilder.DropTable(
                name: "decoration");

            migrationBuilder.DropTable(
                name: "decorationtextile");

            migrationBuilder.DropTable(
                name: "dimension");

            migrationBuilder.DropTable(
                name: "dimensiontextile");

            migrationBuilder.DropTable(
                name: "newsarticle");

            migrationBuilder.DropTable(
                name: "photodata");

            migrationBuilder.DropTable(
                name: "photodatatextile");

            migrationBuilder.DropTable(
                name: "photoform");

            migrationBuilder.DropTable(
                name: "structure");

            migrationBuilder.DropTable(
                name: "structuretextile");

            migrationBuilder.DropTable(
                name: "teammember");

            migrationBuilder.DropTable(
                name: "textile");

            migrationBuilder.DropTable(
                name: "textilefunction");

            migrationBuilder.DropTable(
                name: "textilefunctiontextile");

            migrationBuilder.DropTable(
                name: "yarnmanipulation");

            migrationBuilder.DropTable(
                name: "yarnmanipulationtextile");
        }
    }
}
