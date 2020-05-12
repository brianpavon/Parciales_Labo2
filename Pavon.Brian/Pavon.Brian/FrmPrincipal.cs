using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pavon.Brian
{
    public partial class FrmPrincipal : Form
    {
        /// <summary>
        /// Atributos del FormPrincipal
        /// </summary>
        static List<Alumno> listaAlumnos;        
        static List<Docente> listaDocentes;
        List<Administrativo> listaNoDocentes;
        List<Responsable> listaResponsables;

        public FrmPrincipal()
        {
            InitializeComponent();
            lblSaludo.Text = this.Saludar();
            listaAlumnos = new List<Alumno>();
            listaDocentes = new List<Docente>();
            listaNoDocentes = new List<Administrativo>();
            listaResponsables = new List<Responsable>();
        }

        /// <summary>
        /// Funcion asignada a la opcion Salir de la barra de menu, cierra toda la aplicacion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Desea salir del programa?","Cerrar Programa",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.DialogResult = DialogResult.Abort;                
            }
        }

        /// <summary>
        /// Alta del alumno y responsable
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void altaAlumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAlumno altaAlumno = new FrmAlumno();
            altaAlumno.ShowDialog();
            if(altaAlumno.DialogResult == DialogResult.OK)
            {               
                this.AltaExitosa();
                listaAlumnos.Add(altaAlumno.DevolverAlumno);
                listaResponsables.Add(altaAlumno.DevolverAlumno.Responsable);
            }
            else
            {
                this.MensajeError();
            }

        }

        /// <summary>
        /// Alta del Personal Docente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void altaDocenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDocente altaDocente = new FrmDocente();
            altaDocente.ShowDialog();                       
            
            if(altaDocente.DialogResult == DialogResult.OK)
            {
                this.AltaExitosa();
                listaDocentes.Add(altaDocente.DevolverDocente);
            }
            else
            {
                this.MensajeError();
            }
        }

        /// <summary>
        /// Alta del Personal No Docente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void altaNODocenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNoDocente altaNoDocente = new FrmNoDocente();
            altaNoDocente.ShowDialog();
                        
            if(altaNoDocente.DialogResult == DialogResult.OK)
            {
                this.AltaExitosa();
                listaNoDocentes.Add(altaNoDocente.DevolverNoDocente);
            }
            else
            {
                this.MensajeError();
            }

        }

        //HICE UN DOBLE CLICK EN EL FORMPRINCIPAL Y GENERE UN EVENTO POR ERROR
        //private void altaAulaToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    FrmAula altaAula = new FrmAula();
        //    altaAula.ShowDialog();
        //    if(altaAula.DialogResult == DialogResult.OK)
        //    {
        //        this.AltaExitosa();
        //    }
        //    else
        //    {
        //        this.MensajeError();
        //    }
        //}

        /// <summary>
        /// Alta Sala Amarilla
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void salaAmarillaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAula altaAulaAmarilla = new FrmAula();
            altaAulaAmarilla.CambiarFondo(Color.Yellow);
            altaAulaAmarilla.Color = EColores.Amarillo;
            altaAulaAmarilla.ShowDialog();            
            if (altaAulaAmarilla.DialogResult == DialogResult.OK)
            {
                this.AltaExitosa();
            }
            else
            {
                this.MensajeError();
            }
        }
        /// <summary>
        /// Alta Sala Roja
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void salaRojaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAula altaAulaRoja = new FrmAula();
            altaAulaRoja.CambiarFondo(Color.Red);
            altaAulaRoja.Color = EColores.Rojo;
            altaAulaRoja.ShowDialog();
            if (altaAulaRoja.DialogResult == DialogResult.OK)
            {
                this.AltaExitosa();
            }
            else
            {
                this.MensajeError();
            }
        }
        /// <summary>
        /// Alta Sala Verde
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void salaVerdeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAula altaAulaVerde = new FrmAula();
            altaAulaVerde.CambiarFondo(Color.Green);
            altaAulaVerde.Color = EColores.Verde;
            altaAulaVerde.ShowDialog();
            if (altaAulaVerde.DialogResult == DialogResult.OK)
            {
                this.AltaExitosa();
            }
            else
            {
                this.MensajeError();
            }
        }
        /// <summary>
        /// Alta Sala Naranja
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void salaNaranjaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAula altaAulaNaranja = new FrmAula();
            altaAulaNaranja.CambiarFondo(Color.Orange);
            altaAulaNaranja.Color = EColores.Naranja;
            altaAulaNaranja.ShowDialog();
            if (altaAulaNaranja.DialogResult == DialogResult.OK)
            {
                this.AltaExitosa();
            }
            else
            {
                this.MensajeError();
            }

        }    

        /// <summary>
        /// Harcodeo de los alumnos y sus propiedades, y sus responsables
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void iniciarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            #region HarcodeoDeAlumnos
            Alumno alumno1 = new Alumno("Yancy","Lippiello",33526506,false,4624);
            Alumno alumno2 = new Alumno("Gian","MacAlpyne",47072922,false,2000);
            Alumno alumno3 = new Alumno("Mendy","Ceci",19329366,false,2686);
            Alumno alumno4 = new Alumno("Payton","Cammocke",19660923,false,3059);
            Alumno alumno5 = new Alumno("Fredric","Bunney",20956953,false,2995);
            Alumno alumno6 = new Alumno("Clyde","Hollyer",42024441,false,3507);
            Alumno alumno7 = new Alumno("Colin","Neachell",45688914,false,4847);
            Alumno alumno8 = new Alumno("Laurens","Needham",40106348,false,2380);
            Alumno alumno9 = new Alumno("Torry","Mottershead",16825647,false,3836);
            Alumno alumno10 = new Alumno("Jared","Valentine",31105793,false,4818 );
            Alumno alumno11 = new Alumno("Zacharias","Swalteridge",12572894,false,4614);
            Alumno alumno13 = new Alumno("Adolf","Risen",15675665,false,2293);
            Alumno alumno14 = new Alumno("Batholomew","Tomlin",33634584,false,3514);
            Alumno alumno12 = new Alumno("Manolo","Robillard",12213161,false,2232);
            Alumno alumno15 = new Alumno("Giraldo","Saffe",45651034,false,2205);
            Alumno alumno16 = new Alumno("Gilles","Strathearn",7314726,false,4035);
            Alumno alumno17 = new Alumno("Burr","Abyss",55370882,false,3544);
            Alumno alumno18 = new Alumno("Douglass","Scowen",17343979,false,2794);
            Alumno alumno19 = new Alumno("Herschel","Osinin",4998303,false,4965);
            Alumno alumno20 = new Alumno("Ibrahim","Andretti",51279533,false,2661);
            Alumno alumno21 = new Alumno("Ramsay","Gofforth",18098778,false,1958);
            Alumno alumno22 = new Alumno("Carlin","Tyas",49293197,false,2068);
            Alumno alumno23 = new Alumno("Hurleigh","Mattes",23584581,false,2050);
            Alumno alumno24 = new Alumno("Arel","Doddrell",41247920,false,4255);
            Alumno alumno25 = new Alumno("Juan","Perez",36789123,false,1800);
            Alumno alumno26 = new Alumno("Brian","Peposa",52698765,false,2400);
            Alumno alumno27 = new Alumno("Sonia","Swinburn",30794941,true,2277);
            Alumno alumno28 = new Alumno("Donella","Chatwood",34089299,true,3722);
            Alumno alumno29 = new Alumno("Brett","Heys",51240457,true,3685);
            Alumno alumno30 = new Alumno("Izabel","Hawkswood",5227659,true,4791);
            Alumno alumno31 = new Alumno("Carie","Ingerfield",30691518,true,4531);
            Alumno alumno32 = new Alumno("Kinna","Gunbie",40046002,true,4222);
            Alumno alumno33 = new Alumno("Blakeley","Zolini",38493268,true,4116);
            Alumno alumno34 = new Alumno("Elmira","Boddam",53531697,true,4833);
            Alumno alumno35 = new Alumno("Sibyl","Noirel",46985043,true,4936);
            Alumno alumno36 = new Alumno("Mariel","Burnep",52155909,true,2920);
            Alumno alumno37 = new Alumno("Dniren","Gronauer",11001484,true,2025);
            Alumno alumno38 = new Alumno("Valery","Drayn",38417443,true,4072);
            Alumno alumno39 = new Alumno("Eugine","Zipsell",41469574,true,2475);
            Alumno alumno40 = new Alumno("Caitrin","MacClenan",31197229,true,2401);
            Alumno alumno41 = new Alumno("Cheslie","Shyre",36967661,true,4587);
            Alumno alumno42 = new Alumno("Renee","Ravelus",22278199,true,3912);
            Alumno alumno43 = new Alumno("Emyle","Dilawey",25816118,true,4064);
            Alumno alumno44 = new Alumno("Dallas","MacAirt",15537499,true,3846);
            Alumno alumno45 = new Alumno("Celle","Ewles",22140665,true,4277);
            Alumno alumno46 = new Alumno("Elsy","Dudill",33744400,true,2111);
            Alumno alumno47 = new Alumno("Arlyne","Klauber",18038348,true,4386);
            Alumno alumno48 = new Alumno("Caterina","Wick",48234820,true,3242);
            Alumno alumno49 = new Alumno("Ibby","Sabattier",29902149,true,4173);
            Alumno alumno50 = new Alumno("Daiana","Peposa",17894561,true,1900);

            alumno1.Legajo = 50;
            alumno2.Legajo = 49;
            alumno3.Legajo = 48;
            alumno4.Legajo = 47;
            alumno5.Legajo = 46;
            alumno6.Legajo = 45;
            alumno7.Legajo = 44;
            alumno8.Legajo = 43;
            alumno9.Legajo = 42;
            alumno10.Legajo = 41;
            alumno11.Legajo = 40;
            alumno12.Legajo = 39;
            alumno13.Legajo = 38;
            alumno14.Legajo = 37;
            alumno15.Legajo = 36;
            alumno16.Legajo = 35;
            alumno17.Legajo = 34;
            alumno18.Legajo = 33;
            alumno19.Legajo = 32;
            alumno20.Legajo = 31;
            alumno21.Legajo = 30;
            alumno22.Legajo = 29;
            alumno23.Legajo = 28;
            alumno24.Legajo = 27;
            alumno25.Legajo = 26;
            alumno26.Legajo = 25;
            alumno27.Legajo = 24;
            alumno28.Legajo = 23;
            alumno29.Legajo = 22;
            alumno30.Legajo = 21;
            alumno31.Legajo = 20;
            alumno32.Legajo = 19;
            alumno33.Legajo = 18;
            alumno34.Legajo = 17;
            alumno35.Legajo = 16;
            alumno36.Legajo = 15;
            alumno37.Legajo = 14;
            alumno38.Legajo = 13;
            alumno39.Legajo = 12;
            alumno40.Legajo = 11;
            alumno41.Legajo = 10;
            alumno42.Legajo = 9;
            alumno43.Legajo = 8;
            alumno44.Legajo = 7;
            alumno45.Legajo = 6;
            alumno46.Legajo = 5;
            alumno47.Legajo = 4;
            alumno48.Legajo = 3;
            alumno49.Legajo = 2;
            alumno50.Legajo = 1;

            alumno1.ColorSala = EColores.Rojo;
            alumno2.ColorSala = EColores.Rojo;
            alumno3.ColorSala = EColores.Rojo;
            alumno4.ColorSala = EColores.Rojo;
            alumno5.ColorSala = EColores.Rojo;
            alumno6.ColorSala = EColores.Rojo;
            alumno7.ColorSala = EColores.Rojo;
            alumno8.ColorSala = EColores.Rojo;
            alumno9.ColorSala = EColores.Rojo;
            alumno10.ColorSala = EColores.Rojo;
            alumno11.ColorSala = EColores.Rojo;
            alumno12.ColorSala = EColores.Rojo;
            alumno13.ColorSala = EColores.Rojo;
            alumno14.ColorSala = EColores.Naranja;
            alumno15.ColorSala = EColores.Naranja;
            alumno16.ColorSala = EColores.Naranja;
            alumno17.ColorSala = EColores.Naranja;
            alumno18.ColorSala = EColores.Naranja;
            alumno19.ColorSala = EColores.Naranja;
            alumno20.ColorSala = EColores.Naranja;
            alumno21.ColorSala = EColores.Naranja;
            alumno22.ColorSala = EColores.Naranja;
            alumno23.ColorSala = EColores.Naranja;
            alumno24.ColorSala = EColores.Naranja;
            alumno25.ColorSala = EColores.Naranja;
            alumno26.ColorSala = EColores.Naranja;
            alumno27.ColorSala = EColores.Naranja;
            alumno28.ColorSala = EColores.Naranja;
            alumno29.ColorSala = EColores.Amarillo;
            alumno30.ColorSala = EColores.Amarillo;
            alumno31.ColorSala = EColores.Amarillo;
            alumno32.ColorSala = EColores.Amarillo;
            alumno33.ColorSala = EColores.Amarillo;
            alumno34.ColorSala = EColores.Amarillo;
            alumno35.ColorSala = EColores.Amarillo;
            alumno36.ColorSala = EColores.Amarillo;
            alumno37.ColorSala = EColores.Amarillo;
            alumno38.ColorSala = EColores.Amarillo;
            alumno39.ColorSala = EColores.Amarillo;
            alumno40.ColorSala = EColores.Verde;
            alumno41.ColorSala = EColores.Verde;
            alumno42.ColorSala = EColores.Verde;
            alumno43.ColorSala = EColores.Verde;
            alumno44.ColorSala = EColores.Verde;
            alumno45.ColorSala = EColores.Verde;
            alumno46.ColorSala = EColores.Verde;
            alumno47.ColorSala = EColores.Verde;
            alumno48.ColorSala = EColores.Verde;
            alumno49.ColorSala = EColores.Verde;
            alumno50.ColorSala = EColores.Verde;

            Responsable responsable1 = new Responsable("Ottilie","Tunuy",53979186,true,EParentezco.Madre,"3567920693");
            Responsable responsable2 = new Responsable("Gert","Charley",46414920,true,EParentezco.Tia,"9455961838");
            Responsable responsable3 = new Responsable("Gayle","Allwright",11200924,true,EParentezco.Abuela,"7407953455");
            Responsable responsable4 = new Responsable("Ingaberg","Clive",57627811,true,EParentezco.Otro,"3869805808");
            Responsable responsable5 = new Responsable("Lexy","Roo",22522828,true,EParentezco.Tia,"7823364038");
            Responsable responsable6 = new Responsable("Tedda","Gallemore",48316109,true,EParentezco.Abuela,"3786928217");
            Responsable responsable7 = new Responsable("Vivie","Balham",52306690,true,EParentezco.Madre,"9059639073");
            Responsable responsable8 = new Responsable("Fidelity","Gietz",16011032,true,EParentezco.Tia,"2508927219");
            Responsable responsable9 = new Responsable("Dionis","Feldbau",40145738,true,EParentezco.Madre,"9459829718");
            Responsable responsable10= new Responsable("Aloysia","Carbine",57371839,true,EParentezco.Abuela,"8379646844");
            Responsable responsable11= new Responsable("Candice","Peskin",44278741,true,EParentezco.Abuela,"3878481248");
            Responsable responsable12= new Responsable("Belva","Broseman",20170299,true,EParentezco.Madre,"8308885824");
            Responsable responsable13= new Responsable("Livy","O'Hartnedy",55255855,true,EParentezco.Madre,"4919708879");	
            Responsable responsable14= new Responsable("Albina","Normandale",31138333,true,EParentezco.Abuela,"790132767");
            Responsable responsable15= new Responsable("Netta","Oswal",25002070,true,EParentezco.Otro,"3201453979");
            Responsable responsable16= new Responsable("Adela","Cross",24528708,true,EParentezco.Madre,"5371700705");
            Responsable responsable17= new Responsable("Nell","Hallowell",52702071,true,EParentezco.Abuela,"4264318036");
            Responsable responsable18= new Responsable("Cyb","Beamond",47633403,true,EParentezco.Tia,"9754391968");
            Responsable responsable19= new Responsable("Sheba","Schwieso",33289475,true,EParentezco.Madre,"1416220871");
            Responsable responsable20= new Responsable("Eula","Trematick",7436692,true,EParentezco.Madre,"3966736919");
            Responsable responsable21= new Responsable("Teresita","Mainson",7310741,true,EParentezco.Abuela,"3746185192");
            Responsable responsable22= new Responsable("Tildi","Havelin",36316879,true,EParentezco.Tia,"2937293495");
            Responsable responsable23= new Responsable("Myrtie","Mantram",35753319,true,EParentezco.Tia,"8284968422");
            Responsable responsable24= new Responsable("Yalonda","Grenter",47187708,true,EParentezco.Madre,"9733035227");
            Responsable responsable25= new Responsable("Marie","Kondo",526987,true,EParentezco.Madre,"15669988158");             
            Responsable responsable26= new Responsable("Slade","Armfirld",50713516,false,EParentezco.Padre,"8219139532");
            Responsable responsable27= new Responsable("Lefty","Morfett",56358466,false,EParentezco.Tio,"1082504961");
            Responsable responsable28= new Responsable("Turner","Farraway",29513904,false,EParentezco.Abuelo,"9451942653");
            Responsable responsable29= new Responsable("Cassius","Brizell",35995090,false,EParentezco.Abuelo,"3307157923");
            Responsable responsable30= new Responsable("Hailey","Whiten",12005441,false,EParentezco.Padre,"2193628436");
            Responsable responsable31= new Responsable("Sawyer","Shiers",23521009,false,EParentezco.Tio,"8668834489");
            Responsable responsable32= new Responsable("Kristopher","Howsin",17856707,false,EParentezco.Otro,"3434989971");
            Responsable responsable33= new Responsable("Mead","Heckle",12035813,false,EParentezco.Padre,"9621873929");
            Responsable responsable34= new Responsable("Olvan","Chaffyn",10619973,false,EParentezco.Tio,"286846020");
            Responsable responsable35= new Responsable("Kev","Bulpitt",43813487,false,EParentezco.Padre,"7779693386");
            Responsable responsable36= new Responsable("Maximilien","Westerman",4252837,false,EParentezco.Tio,"4461353043");
            Responsable responsable37= new Responsable("Wolf","Dumberell",59341922,false,EParentezco.Otro,"6744105172");
            Responsable responsable38= new Responsable("Devlen","Dorning",37430184,false,EParentezco.Padre,"3306556611");
            Responsable responsable39= new Responsable("Rossy","Wemes",50483082,false,EParentezco.Tio,"9374537826");
            Responsable responsable40= new Responsable("Osbourn","Perelli",47002618,false,EParentezco.Padre,"5941241602");
            Responsable responsable41= new Responsable("Iorgos","Gianolini",22721319,false,EParentezco.Padre,"4478296399");
            Responsable responsable42= new Responsable("Brok","Balassa",36912378,false,EParentezco.Otro,"7878366931");
            Responsable responsable43 = new Responsable("Gardner","L'Episcopio",45093813,false,EParentezco.Tio,"680809755");
            Responsable responsable44= new Responsable("Obed","Marshland",40270175,false,EParentezco.Abuelo,"8307961965");
            Responsable responsable45= new Responsable("Humbert","Floyde",56075674,false,EParentezco.Padre,"8808886957");
            Responsable responsable46= new Responsable("Mortie","Keeting",57727476,false,EParentezco.Abuelo,"2129839547");
            Responsable responsable47= new Responsable("Faber","Eaken",18389850,false,EParentezco.Tio,"8958503405");
            Responsable responsable48= new Responsable("Yorgo","Eddy",6182834,false,EParentezco.Abuelo,"5943697840");
            Responsable responsable49= new Responsable("Papa","Del Nene",17846645,false,EParentezco.Padre,"15987465");
            Responsable responsable50= new Responsable("Tio","Del Alumne",39876456,false,EParentezco.Tio,"1345697845");

            alumno1.Responsable = responsable50;
            alumno2.Responsable = responsable49;
            alumno3.Responsable = responsable48;
            alumno4.Responsable = responsable47;
            alumno5.Responsable = responsable46;
            alumno6.Responsable = responsable45;
            alumno7.Responsable = responsable44;
            alumno8.Responsable = responsable43;
            alumno9.Responsable = responsable42;
            alumno10.Responsable = responsable41;
            alumno11.Responsable = responsable40;
            alumno12.Responsable = responsable39;
            alumno13.Responsable = responsable38;
            alumno14.Responsable = responsable37;
            alumno15.Responsable = responsable36;
            alumno16.Responsable = responsable35;
            alumno17.Responsable = responsable34;
            alumno18.Responsable = responsable33;
            alumno19.Responsable = responsable32;
            alumno20.Responsable = responsable31;
            alumno21.Responsable = responsable30;
            alumno22.Responsable = responsable29;
            alumno23.Responsable = responsable28;
            alumno24.Responsable = responsable27;
            alumno25.Responsable = responsable26;
            alumno26.Responsable = responsable25;
            alumno27.Responsable = responsable24;
            alumno28.Responsable = responsable23;
            alumno29.Responsable = responsable22;
            alumno30.Responsable = responsable21;
            alumno31.Responsable = responsable20;
            alumno32.Responsable = responsable19;
            alumno33.Responsable = responsable18;
            alumno34.Responsable = responsable17;
            alumno35.Responsable = responsable16;
            alumno36.Responsable = responsable15;
            alumno37.Responsable = responsable14;
            alumno38.Responsable = responsable13;
            alumno39.Responsable = responsable12;
            alumno40.Responsable = responsable11;
            alumno41.Responsable = responsable10;
            alumno42.Responsable = responsable9;
            alumno43.Responsable = responsable8;
            alumno44.Responsable = responsable7;
            alumno45.Responsable = responsable6;
            alumno46.Responsable = responsable5;
            alumno47.Responsable = responsable4;
            alumno48.Responsable = responsable3;
            alumno49.Responsable = responsable2;
            alumno50.Responsable = responsable1;
            #endregion
        }
        
        /// <summary>
        /// Harcodeo de los Docentes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cargarDocentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            #region HarcodeoDeDocentes
            Docente docente1 = new Docente("Farlee","Cotterell",39570044,false, DateTime.Parse("08:00"), DateTime.Parse("12:00"), 152);
            Docente docente2 = new Docente("Fredric","Wittman",48665081,false, DateTime.Parse("08:00"), DateTime.Parse("12:00"), 209);
            Docente docente3 = new Docente("Wallie","Syseland",27492878,true, DateTime.Parse("13:00"), DateTime.Parse("17:00"), 127);
            Docente docente4 = new Docente("Liliane","Blowin",21041114,true, DateTime.Parse("13:00"), DateTime.Parse("17:00"), 201);
            Docente docente5 = new Docente("Danit","Reading",16371068,true,DateTime.Parse("13:00"), DateTime.Parse("17:00"), 138);
                      

            #endregion
        }

        
        /// <summary>
        /// Harcodeo de los No Docentes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cargarNoDocenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            #region Harcodeo de los Administrativos
            Administrativo administrativo1 = new Administrativo("Gerri","Markovich",15073372,false,12,14,Senior Quality Engineer);
            Administrativo administrativo2 = new Administrativo("Berti","Inchcomb",24554231,false,8,15,Research Associate);
            Administrativo administrativo3 = new Administrativo("Ronny","Gyenes",28501194,false,12,13,VP Sales);
            Administrativo administrativo4 = new Administrativo("Chauncey","Setch",33181208,false,11,15,Financial Analyst);
            Administrativo administrativo5 = new Administrativo("Inger","Iremonger",35003048,false,9,14,Community Outreach Specialist);
            Administrativo administrativo6 = new Administrativo("Marci","Hansie",44365351,true,8,14,Software Consultant);
            Administrativo administrativo7 = new Administrativo("Jayme","O'Luney",4690442,true,9,13,Junior Executive);
            Administrativo administrativo8 = new Administrativo("Thelma","MacGiffin",7465179,true,13,16,Food Chemist);
            Administrativo administrativo9 = new Administrativo("Delcine","Delle",52591827,true,8,14,Cost Accountant);
            Administrativo administrativo10 = new Administrativo("Cindie","Leif",52421110,true,10,15,Paralegal);


            #endregion

        }

        #region MetodosDelFormPrincipal
        //METODOS:

        /// <summary>
        /// 
        /// </summary>
        public void AltaExitosa()
        {
            MessageBox.Show("Se realizo correctamente el alta", "Alta Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// 
        /// </summary>
        public void MensajeError()
        {
            MessageBox.Show("No se pudo realizar la operacion", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public string Saludar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"BUENOS DIAS!!!! \n\n");
            sb.AppendLine("Hoy es " + DateTime.Now.ToString("dddd, dd MMMM yyyy"));

            return sb.ToString();
        }
        /// <summary>
        /// 
        /// </summary>
        public static List<Docente> ListaDocentes
        {
            get
            {
                return listaDocentes;
            }
        }

        public static List<Alumno> ListaAlumnos
        {
            get
            {
                return listaAlumnos;
            }
        }
        #endregion

    }
}
