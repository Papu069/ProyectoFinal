using Indice.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Indice.Formularios
{
    /// <summary>
    /// Formulario principal de la aplicación de reservas de cine.
    /// </summary>
    public partial class FormInicio: Form
    {
        /// <summary>
        /// Películas disponibles en el cine.
        /// </summary>
        private Pelicula pelicula1;
        private Pelicula pelicula2;
        private Pelicula pelicula3;
        private Pelicula pelicula4;
        private Pelicula pelicula5;
        private Pelicula pelicula6;
        private Pelicula pelicula7;
        private Pelicula pelicula8;
        private Pelicula pelicula9;
        private Pelicula pelicula10;
        private Pelicula pelicula11;
        private Pelicula pelicula12;
        private Pelicula pelicula13;
        private Pelicula pelicula14;
        private Pelicula pelicula15;
        private Pelicula pelicula16;
        private Pelicula pelicula17;
        private Pelicula pelicula18;
        private Pelicula pelicula19;
        private Pelicula pelicula20;
        private Pelicula pelicula21;
        private Pelicula pelicula22;
        private Pelicula pelicula23;
        private Pelicula pelicula24;
        private Pelicula pelicula25;
        private Pelicula pelicula26;
        private Pelicula pelicula27;
        private Pelicula pelicula28;
        private Pelicula pelicula29;
        private Pelicula pelicula30;


        /// <summary>
        /// Constructor que inicializa el formulario y las películas.
        /// </summary>
        public FormInicio()
        {
            InitializeComponent();
            tabGeneral.TabPages.Clear();
            tabGeneral.TabPages.Add(tabInicio);

            pelicula1 = new Pelicula
            {
                NombreDEPelicula = "QUANTUMANIA",
                Genero = "Ciencia ficción",
                Descripcion = "Los superhéroes Scott y Cassie Lang, Hope van Dyne y sus padres, se " +
                "encuentran accidentalmente atrapados en el reino cuántico y deben enfrentarse a un " +
                "nuevo enemigo, Kang el Conquistador.",
                FechaEstreno = new DateTime(2025, 09, 29),
                HoraDEestreno = new TimeSpan(11, 30, 0)


            };
            pelicula1.Salas.Add(new Sala { NumDESala = 1, Capacidad = 30 });

            pelicula2 = new Pelicula
            {
                NombreDEPelicula = "65, AL BORDE DE LA EXTINCIÓN",
                Genero = "Ficción histórica",
                Descripcion = "Tras sufrir un accidente y caer a un planeta desconocido, los supervivientes de una nave descubren que " +
                "han llegado a la Tierra, pero hace" +
                " 65 millones de años. Ahora, deben cruzar un territorio inhóspito, poblado de bestias prehistóricas, para salir.",
                FechaEstreno = new DateTime(2025, 09, 30),
                 HoraDEestreno = new TimeSpan(12, 30, 0)
            };
            pelicula2.Salas.Add(new Sala { NumDESala = 2, Capacidad = 30 });

            pelicula3 = new Pelicula
            {
                NombreDEPelicula = "LOS MUÉRTIMER",
                Genero = "Misterio y comedia",
                Descripcion = "Nico es un joven de 15 años inteligente e introvertido que sufre acoso escolar por ser hijo de " +
                "los dueños de la funeraria del pueblo. Todo cambia cuando llega de Gabrielle, una joven francesa rebelde que participa " +
                "en un programa de intercambio. Juntos " +
                "descubren un misterio en el cementerio: un cadáver oculto y unas joyas que desaparecen sin dejar rastro.",
                FechaEstreno = new DateTime(2025, 09, 28),
                 HoraDEestreno = new TimeSpan(10, 30, 0)
            };
            pelicula3.Salas.Add(new Sala { NumDESala = 3, Capacidad = 30 });
            pelicula4 = new Pelicula
            {
                NombreDEPelicula="PLANTAS VRS ZOMBIS LA PELICULA",
                Genero= "Animación y comedia",
                Descripcion = "En un tranquilo vecindario, la paz de los jardines se ve amenazada cuando un ejército de zombis " +
                "comienza a invadir la ciudad bajo el mando del enigmático Dr. Zomboss",


                FechaEstreno = new DateTime(2025, 10, 01),
                HoraDEestreno = new TimeSpan(15, 30, 0)


            };
            pelicula4.Salas.Add(new Sala { NumDESala=4, Capacidad = 30 });
            pelicula5 = new Pelicula
            {
                NombreDEPelicula = "Five Nights at Freddy’s: La película:",
                Genero= "terror y suspenso",
                Descripcion= "En esta adaptación del famoso videojuego, un joven guardia de seguridad comienza a " +
                "trabajar en la pizzería abandonada Freddy Fazbear’s Pizza. Pronto descubre que el lugar esconde " +
                "un oscuro secreto:",
                 FechaEstreno = new DateTime(2025, 09, 30),
                HoraDEestreno = new TimeSpan(18, 30, 0)


            };
            pelicula5.Salas.Add(new Sala { NumDESala = 5, Capacidad = 30 });
            pelicula6 = new Pelicula
            {
                NombreDEPelicula="your name",
                Genero= "Animación y romance",
                Descripcion = "Mitsuha es una chica de un pequeño pueblo que sueña con vivir en la bulliciosa ciudad de Tokio. " ,
                FechaEstreno = new DateTime(2025, 10, 01),
                HoraDEestreno = new TimeSpan(19, 30, 0)

            };
            pelicula6.Salas.Add(new Sala { NumDESala = 6, Capacidad = 30 });
            pelicula7 = new Pelicula
            {
                NombreDEPelicula= "interstellar",
                Genero = "Ciencia ficción y drama",
                Descripcion = "En un futuro cercano, la Tierra enfrenta una crisis ambiental que amenaza la supervivencia de la humanidad. " ,
                FechaEstreno = new DateTime(2025, 10, 05),
                HoraDEestreno = new TimeSpan(20, 30, 0)

            };
            pelicula7.Salas.Add(new Sala { NumDESala = 7, Capacidad = 30 });
            pelicula8 = new Pelicula
            {
                NombreDEPelicula="el caballero de la noche",
                Genero = "Acción y crimen",
                Descripcion = "Gotham City está sumida en el caos mientras el Joker, un criminal psicópata, desata una ola de terror en la ciudad. ",
                FechaEstreno = new DateTime(2025, 10, 03),
                HoraDEestreno = new TimeSpan(21, 30, 0)
            };
            pelicula8.Salas.Add(new Sala { NumDESala = 8, Capacidad = 30 });
            pelicula9 = new Pelicula
            {
                NombreDEPelicula="gato con botas",
                Genero = "Animación y aventura",
                Descripcion = "En esta precuela de la saga de Shrek, el Gato con Botas, un astuto y valiente felino, " +
                "se embarca en una aventura épica para encontrar el legendario Huevo de Oro.",
                FechaEstreno = new DateTime(2025, 09, 29),
                HoraDEestreno = new TimeSpan(14, 30, 0)
            };
            pelicula9.Salas.Add(new Sala { NumDESala = 9, Capacidad = 30 });
            pelicula10 = new Pelicula
            {
                NombreDEPelicula= "Chainsaw Man",
                Genero = "Acción y horror",
                Descripcion = "Denji es un joven que vive en la pobreza y trabaja como cazador de demonios " +
                "para pagar las deudas de su difunto padre. " ,
                FechaEstreno = new DateTime(2025, 09, 29),
                HoraDEestreno = new TimeSpan(13, 30, 0)

            };
            pelicula10.Salas.Add(new Sala { NumDESala = 10, Capacidad = 30 });
            pelicula11 = new Pelicula
            {
                NombreDEPelicula = "miles morales",
                Genero = "Animación y superhéroes",
                Descripcion = "En Brooklyn, el adolescente Miles Morales descubre que ha heredado poderes " +
                "similares a los de Spider-Man. Mientras intenta equilibrar su vida como estudiante y héroe",
                FechaEstreno = new DateTime(2025, 10, 01),
                HoraDEestreno = new TimeSpan(16, 30, 0)
            };
            pelicula11.Salas.Add(new Sala { NumDESala = 11, Capacidad = 30 });
            pelicula12 = new Pelicula
            {
                NombreDEPelicula="el padrino",
                Genero = "Crimen y drama",
                Descripcion = "La historia épica de la familia Corleone, una poderosa dinastía mafiosa en Nueva York. ",
                FechaEstreno = new DateTime(2025, 10, 02),
                HoraDEestreno = new TimeSpan(17, 30, 0)
            };
            pelicula12.Salas.Add(new Sala { NumDESala = 12, Capacidad = 30 });
            pelicula13 = new Pelicula
            {
                NombreDEPelicula = "los colegas del barrio",
                Genero = "Comedia y acción",
                Descripcion = "Un grupo de amigos de la infancia se reencuentran en su barrio natal después de varios años. ",
                FechaEstreno = new DateTime(2025, 09, 30),
                HoraDEestreno = new TimeSpan(12, 34, 0)
            };
            pelicula13.Salas.Add(new Sala { NumDESala = 13, Capacidad = 30 });
            pelicula14 = new Pelicula
            {
                NombreDEPelicula = "2012",
                Genero = "Ciencia ficción y desastre",
                Descripcion = "Un escritor de ciencia ficción y su familia luchan por sobrevivir cuando una serie de catástrofes naturales devastan la Tierra. ",
                FechaEstreno = new DateTime(2025, 09, 30),
                HoraDEestreno = new TimeSpan(2, 30, 0)
            };
            pelicula14.Salas.Add(new Sala { NumDESala = 14, Capacidad = 30 });
            pelicula15 = new Pelicula
            {
                NombreDEPelicula = "que paso ayer 3",
                Genero = "Comedia",
                Descripcion = "Después de una noche de fiesta en Las Vegas, un grupo de amigos se despiertan sin recordar nada de lo ocurrido. ",
                FechaEstreno = new DateTime(2025, 10, 01),
                HoraDEestreno = new TimeSpan(3, 30, 0)
            };
            pelicula15.Salas.Add(new Sala { NumDESala = 15, Capacidad = 30 });
            pelicula16 = new Pelicula
            {
                NombreDEPelicula = "tron ares",
                Genero = "Ciencia ficción y aventura",
                Descripcion = "Sam Flynn, el hijo del legendario programador Kevin Flynn, se encuentra atrapado en el mundo digital de Tron. ",
                FechaEstreno = new DateTime(2025, 10, 04),
                HoraDEestreno = new TimeSpan(4, 30, 0)
            };
            pelicula16.Salas.Add(new Sala { NumDESala = 16, Capacidad = 30 });
            pelicula17 = new Pelicula
            {
                NombreDEPelicula = "te veo",
                Genero = "Suspenso y misterio",
                Descripcion = "Una joven comienza a recibir mensajes inquietantes de alguien que afirma conocer todos sus secretos más oscuros. ",
                FechaEstreno = new DateTime(2025, 10, 01),
                HoraDEestreno = new TimeSpan(5, 30, 0)
            };
            pelicula17.Salas.Add(new Sala { NumDESala = 17, Capacidad = 30 });
            pelicula18 = new Pelicula
            {
                NombreDEPelicula = "a ciegas",
                Genero = "Suspenso y drama",
                Descripcion = "En un mundo postapocalíptico, una mujer ciega lucha por sobrevivir mientras es perseguida por un grupo de personas que buscan aprovecharse de su vulnerabilidad. ",
                FechaEstreno = new DateTime(2025, 10,03 ),
                HoraDEestreno = new TimeSpan(6, 30, 0)
            };
            pelicula18.Salas.Add(new Sala { NumDESala = 18, Capacidad = 30 });
            pelicula19 = new Pelicula
            {
                NombreDEPelicula = "EL HOYO",
                Genero = "Ciencia ficción y drama",
                Descripcion = "En una prisión vertical, los reclusos son alimentados a través de una plataforma que desciende por los niveles. ",
                FechaEstreno = new DateTime(2025, 10, 05),
                HoraDEestreno = new TimeSpan(7, 30, 0)
            };
            pelicula19.Salas.Add(new Sala { NumDESala = 19, Capacidad = 30 });
            pelicula20 = new Pelicula
            {
                NombreDEPelicula = "la hermana fea",
                Genero = "Comedia y romance",
                Descripcion = "Una joven considerada poco atractiva por su familia y la sociedad decide cambiar su apariencia para encontrar el amor verdadero. ",
                FechaEstreno = new DateTime(2025, 10, 15),
                HoraDEestreno = new TimeSpan(1, 30, 0)
            };
            pelicula20.Salas.Add(new Sala { NumDESala = 29, Capacidad = 30 });
            pelicula21 = new Pelicula
            {
                NombreDEPelicula = "Estacion zombi",
                Genero = "Terror y suspenso",
                Descripcion = "Un grupo de personas queda atrapado en una estación de tren durante un brote de zombis. " ,
                FechaEstreno = new DateTime(2025, 10, 03),
                HoraDEestreno = new TimeSpan(1, 50, 0)


            };
            pelicula21.Salas.Add(new Sala { NumDESala = 21, Capacidad = 30 });
            pelicula22 = new Pelicula
            {
                NombreDEPelicula = "sexo la pelicula",
                Genero = "Comedia y romance",
                Descripcion = "Una comedia romántica que explora las aventuras y desventuras de un grupo de amigos en su búsqueda del amor y la felicidad. ",
                FechaEstreno = new DateTime(2025, 10, 04),
                HoraDEestreno = new TimeSpan(2, 50, 0)
            };
            pelicula22.Salas.Add(new Sala { NumDESala = 22, Capacidad = 30 });
            pelicula23 = new Pelicula
            {
                NombreDEPelicula = "secreto en la montaña",
                Genero = "Drama y romance",
                Descripcion = "En un pequeño pueblo de montaña, dos vaqueros desarrollan una intensa relación amorosa mientras enfrentan los prejuicios de la sociedad. ",
                FechaEstreno = new DateTime(2025, 10, 02),
                HoraDEestreno = new TimeSpan(18, 50, 0)
            };
            pelicula23.Salas.Add(new Sala { NumDESala = 23, Capacidad = 30 });
            pelicula24 = new Pelicula
            {
                NombreDEPelicula="Banana mecanica",
                Genero = "Comedia",
                Descripcion = "Un grupo de amigos encuentra una banana mecánica que les concede deseos, pero pronto descubren que cada deseo tiene consecuencias inesperadas. ",
                FechaEstreno = new DateTime(2025, 10, 30),
                HoraDEestreno = new TimeSpan(19, 50, 0)
            };
            pelicula24.Salas.Add(new Sala { NumDESala = 24, Capacidad = 30 });
            pelicula25 = new Pelicula
            {
                NombreDEPelicula = "el remanenete",
                Genero = "Terror y suspenso",
                Descripcion = "Un grupo de personas queda atrapado en un supermercado durante un apocalipsis zombi, y deben luchar por sobrevivir mientras enfrentan amenazas tanto externas como internas. ",
                FechaEstreno = new DateTime(2025, 10, 04),
                HoraDEestreno = new TimeSpan(20, 50, 0)
            };
            pelicula25.Salas.Add(new Sala { NumDESala = 25, Capacidad = 30 });
            pelicula26 = new Pelicula
            {
                NombreDEPelicula = "Random lunacy",
                Genero = "Comedia y absurdo",
                Descripcion = "Una serie de eventos aleatorios y absurdos ocurren en la vida de un grupo de personas, llevándolos a situaciones hilarantes e inesperadas. ",
                FechaEstreno = new DateTime(2025, 10, 04),
                HoraDEestreno = new TimeSpan(21, 50, 0)

            };
            pelicula26.Salas.Add(new Sala { NumDESala = 26, Capacidad = 30 });
            pelicula27 = new Pelicula
            {
                NombreDEPelicula = "clannad",
                Genero = "Animación y drama",
                Descripcion = "Tomoya Okazaki, un estudiante de secundaria rebelde, conoce a una chica llamada Nagisa Furukawa, quien lo introduce en un mundo de emociones y relaciones profundas. ",
                FechaEstreno = new DateTime(2025, 10, 03),
                HoraDEestreno = new TimeSpan(23, 59, 0)
            };
            pelicula27.Salas.Add(new Sala { NumDESala = 27, Capacidad = 30 });
            pelicula28 = new Pelicula
            {
                NombreDEPelicula = "star wars",
                Genero = "Ciencia ficción y aventura",
                Descripcion = "En una galaxia muy, muy lejana, la lucha entre el bien y el mal se intensifica cuando un joven granjero llamado Luke Skywalker descubre su destino como Jedi y se une a la Rebelión para enfrentarse al malvado Imperio Galáctico. ",
                FechaEstreno = new DateTime(2025, 10, 03),
                HoraDEestreno = new TimeSpan(22, 10, 0)
            };
            pelicula28.Salas.Add(new Sala { NumDESala = 28, Capacidad = 30 });
            pelicula29 = new Pelicula
            {
                NombreDEPelicula = "sexo la pelicula2",
                Genero = "Comedia y romance",
                Descripcion = "Una comedia romántica que explora las aventuras y desventuras de un grupo de amigos en su búsqueda del amor y la felicidad. ",
                FechaEstreno = new DateTime(2025, 10, 02),
                HoraDEestreno = new TimeSpan(20, 10, 0)

            };
            pelicula29.Salas.Add(new Sala { NumDESala = 29, Capacidad = 30 });
            pelicula30 = new Pelicula
            {
                NombreDEPelicula = "huevos congelados",
                Genero = "Comedia",
                Descripcion = "En esta divertida aventura animada, Toto y sus amigos huevos se enfrentan a un nuevo y frío desafío cuando un villano amenaza con congelar el futuro del gallinero",
                FechaEstreno = new DateTime(2025, 10, 25),
                HoraDEestreno = new TimeSpan(19, 10, 0)
            };
            pelicula30.Salas.Add(new Sala { NumDESala = 30, Capacidad = 30 });
        }
        /// <summary>
        /// Evento que se dispara al hacer clic en el botón de salir, vuelve al formulario de login.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.Login.Show();
        }
        /// <summary>
        /// Cambia la pestaña visible en el control TabControl.
        /// </summary>
        /// <param name="tab"></param>
        private void CambiarTab(TabPage tab)
        {
            tabGeneral.TabPages.Clear();
            tabGeneral.TabPages.Add(tab);
            tabGeneral.SelectedTab = tab;
        }
        /// <summary>
        /// Evento que se dispara al hacer clic en el botón derecho de la primera página, cambia a la segunda página.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRight1_Click(object sender, EventArgs e)
        {
            CambiarTab(tabInicio2);
        }
        /// <summary>
        /// Evento que se dispara al hacer clic en el botón izquierdo de la segunda página, vuelve a la primera página.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLeft1_Click(object sender, EventArgs e)
        {
            CambiarTab(tabInicio);
        }
        /// <summary>
        /// Evento que se dispara al hacer clic en el botón izquierdo de la tercera página, vuelve a la segunda página.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLeft2_Click(object sender, EventArgs e)
        {
            CambiarTab(tabInicio2);
        }
        /// <summary>
        /// Evento que se dispara al hacer clic en el botón derecho de la segunda página, cambia a la tercera página.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRight2_Click(object sender, EventArgs e)
        {
            CambiarTab(tabInicio3);
        }
        /// <summary>
        /// Evento que se dispara al hacer clic en el botón de inicio, vuelve a la página de inicio.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnHome_Click(object sender, EventArgs e)
        {
            CambiarTab(tabInicio);
        }
        /// <summary>
        /// Evento que se dispara al hacer clic en el botón de lunes, cambia a la pestaña de lunes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLunes_Click(object sender, EventArgs e)
        {
            CambiarTab(tabLunes);
        }
        /// <summary>
        /// Evento que se dispara al hacer clic en el botón de martes, cambia a la pestaña de martes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMartes_Click(object sender, EventArgs e)
        {
            CambiarTab(tabMartes);
        }
        /// <summary>
        /// Evento que se dispara al hacer clic en el botón de miércoles, cambia a la pestaña de miércoles.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMiercoles_Click(object sender, EventArgs e)
        {
            CambiarTab(tabMiercoles);
        }
        /// <summary>
        ///  Evento que se dispara al hacer clic en el botón de jueves, cambia a la pestaña de jueves.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnJueves_Click(object sender, EventArgs e)
        {
            CambiarTab(tabJueves);
        }
        /// <summary>
        /// Evento que se dispara al hacer clic en el botón de viernes, cambia a la pestaña de viernes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnViernes_Click(object sender, EventArgs e)
        {
            CambiarTab(tabViernes);
        }
        /// <summary>
        /// Evento que se dispara al hacer clic en el botón de sábado, cambia a la pestaña de sábado.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSabado_Click(object sender, EventArgs e)
        {
            CambiarTab(tabSabado);
        }
        /// <summary>
        /// Evento que se dispara al hacer clic en el botón de domingo, cambia a la pestaña de domingo.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDomingo_Click(object sender, EventArgs e)
        {
            CambiarTab(tabDomingo);
        }
        /// <summary>
        /// Evento que se dispara al hacer clic en la imagen de una película, abre el formulario 
        /// de detalles de la película y en el resto de peliculas se mantiene el mismo evento.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Img_Click(object sender, EventArgs e)
        {
            FormPelicula formPelicula = new FormPelicula(this, pelicula1, pelicula1.Salas[0]);
            this.Hide();
            formPelicula.ShowDialog();
            this.Show();
        }
        
        private void ImgMovie2_Click(object sender, EventArgs e)
        {
            FormPelicula formPelicula = new FormPelicula(this, pelicula2, pelicula2.Salas[0]);
            this.Hide();
            formPelicula.ShowDialog();
            this.Show();
        }

        private void ImgMovie3_Click(object sender, EventArgs e)
        {
            FormPelicula formPelicula = new FormPelicula(this, pelicula3, pelicula3.Salas[0]);
            this.Hide();
            formPelicula.ShowDialog();
            this.Show();
        }

        private void ImgMovie4_Click(object sender, EventArgs e)
        {
            FormPelicula formPelicula = new FormPelicula(this, pelicula4, pelicula4.Salas[0]);
            this.Hide();
            formPelicula.ShowDialog();
            this.Show();
        }

        private void ImgMovie5_Click(object sender, EventArgs e)
        {
            FormPelicula formPelicula = new FormPelicula(this, pelicula5, pelicula5.Salas[0]);
            this.Hide();
            formPelicula.ShowDialog();
            this.Show();
        }

        private void ImgMovie7_Click(object sender, EventArgs e)
        {
            FormPelicula formPelicula = new FormPelicula(this, pelicula7, pelicula7.Salas[0]);
            this.Hide();
            formPelicula.ShowDialog();
            this.Show();
        }

        private void ImgMovie6_Click(object sender, EventArgs e)
        {
            FormPelicula formPelicula = new FormPelicula(this, pelicula6, pelicula6.Salas[0]);
            this.Hide();
            formPelicula.ShowDialog();
            this.Show();
        }

        private void ImgMovie8_Click(object sender, EventArgs e)
        {
            FormPelicula formPelicula = new FormPelicula(this, pelicula8, pelicula8.Salas[0]);
            this.Hide();
            formPelicula.ShowDialog();
            this.Show();
        }

        private void ImgMovie9_Click(object sender, EventArgs e)
        {
            FormPelicula formPelicula = new FormPelicula(this, pelicula9, pelicula9.Salas[0]);
            this.Hide();
            formPelicula.ShowDialog();
            this.Show();
        }
       
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FormPelicula formPelicula = new FormPelicula(this, pelicula11, pelicula11.Salas[0]);
            this.Hide();
            formPelicula.ShowDialog();
            this.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FormPelicula formPelicula = new FormPelicula(this, pelicula12, pelicula12.Salas[0]);
            this.Hide();
            formPelicula.ShowDialog();
            this.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            FormPelicula formPelicula = new FormPelicula(this, pelicula13, pelicula13.Salas[0]);
            this.Hide();
            formPelicula.ShowDialog();
            this.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            FormPelicula formPelicula = new FormPelicula(this, pelicula14, pelicula14.Salas[0]);
            this.Hide();
            formPelicula.ShowDialog();
            this.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            FormPelicula formPelicula = new FormPelicula(this, pelicula15, pelicula15.Salas[0]);
            this.Hide();
            formPelicula.ShowDialog();
            this.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            FormPelicula formPelicula = new FormPelicula(this, pelicula16, pelicula16.Salas[0]);
            this.Hide();
            formPelicula.ShowDialog();
            this.Show();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            FormPelicula formPelicula = new FormPelicula(this, pelicula17, pelicula17.Salas[0]);
            this.Hide();
            formPelicula.ShowDialog();
            this.Show();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            FormPelicula formPelicula = new FormPelicula(this, pelicula18, pelicula18.Salas[0]);
            this.Hide();
            formPelicula.ShowDialog();
            this.Show();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            FormPelicula formPelicula = new FormPelicula(this, pelicula19, pelicula19.Salas[0]);
            this.Hide();
            formPelicula.ShowDialog();
            this.Show();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            FormPelicula formPelicula = new FormPelicula(this, pelicula20, pelicula20.Salas[0]);
            this.Hide();
            formPelicula.ShowDialog();
            this.Show();
        }

        private void ImgMovie10_Click(object sender, EventArgs e)
        {
            FormPelicula formPelicula = new FormPelicula(this, pelicula10, pelicula10.Salas[0]);
            this.Hide();
            formPelicula.ShowDialog();
            this.Show();

        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            FormPelicula formPelicula = new FormPelicula(this, pelicula21, pelicula21.Salas[0]);
            this.Hide();
            formPelicula.ShowDialog();
            this.Show();
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            FormPelicula formPelicula = new FormPelicula(this, pelicula22, pelicula22.Salas[0]);
            this.Hide();
            formPelicula.ShowDialog();
            this.Show();
        }
        //private void pictureBox14_Click(object sender, EventArgs e)
        //{
        //    FormPelicula formPelicula = new FormPelicula(this, pelicula23, pelicula23.Salas[0]);
        //    this.Hide();
        //    formPelicula.ShowDialog();
        //    this.Show();
        //}

        private void pictureBox14_Click_1(object sender, EventArgs e)
        {
            FormPelicula formPelicula = new FormPelicula(this, pelicula23, pelicula23.Salas[0]);
            this.Hide();
            formPelicula.ShowDialog();
            this.Show();
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            FormPelicula formPelicula = new FormPelicula(this, pelicula24, pelicula24.Salas[0]);
            this.Hide();
            formPelicula.ShowDialog();
            this.Show();
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            FormPelicula formPelicula = new FormPelicula(this, pelicula25, pelicula25.Salas[0]);
            this.Hide();
            formPelicula.ShowDialog();
            this.Show();
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            FormPelicula formPelicula = new FormPelicula(this, pelicula26, pelicula26.Salas[0]);
            this.Hide();
            formPelicula.ShowDialog();
            this.Show();
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            FormPelicula formPelicula = new FormPelicula(this, pelicula27, pelicula27.Salas[0]);
            this.Hide();
            formPelicula.ShowDialog();
            this.Show();
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            FormPelicula formPelicula = new FormPelicula(this, pelicula28, pelicula28.Salas[0]);
            this.Hide();
            formPelicula.ShowDialog();
            this.Show();
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            FormPelicula formPelicula = new FormPelicula(this, pelicula29, pelicula29.Salas[0]);
            this.Hide();
            formPelicula.ShowDialog();
            this.Show();
        }

        private void pictureBox22_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox22_Click_1(object sender, EventArgs e)
        {
            FormPelicula formPelicula = new FormPelicula(this, pelicula20, pelicula20.Salas[0]);
            this.Hide();
            formPelicula.ShowDialog();
            this.Show();

            //pictureBox1.BorderStyle = BorderStyle.FixedSingle;
        }

        private void pictureBox23_Click(object sender, EventArgs e)
        {
            FormPelicula formPelicula = new FormPelicula(this, pelicula9, pelicula9.Salas[0]);
            this.Hide();
            formPelicula.ShowDialog();
            this.Show();
        }

        private void pictureBox24_Click(object sender, EventArgs e)
        {
            FormPelicula formPelicula = new FormPelicula(this, pelicula10, pelicula10.Salas[0]);
            this.Hide();
            formPelicula.ShowDialog();
            this.Show();
        }

        private void pictureBox25_Click(object sender, EventArgs e)
        {
            FormPelicula formPelicula = new FormPelicula(this, pelicula5, pelicula5.Salas[0]);
            this.Hide();
            formPelicula.ShowDialog();
            this.Show();
        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {
            FormPelicula formPelicula = new FormPelicula(this, pelicula30, pelicula30.Salas[0]);
            this.Hide();
            formPelicula.ShowDialog();
            this.Show();
        }

        private void pictureBox26_Click(object sender, EventArgs e)
        {
            FormPelicula formPelicula = new FormPelicula(this, pelicula14, pelicula14.Salas[0]);
            this.Hide();
            formPelicula.ShowDialog();
            this.Show();
        }

        private void pictureBox27_Click(object sender, EventArgs e)
        {
            FormPelicula formPelicula = new FormPelicula(this, pelicula13, pelicula13.Salas[0]);
            this.Hide();
            formPelicula.ShowDialog();
            this.Show();
        }

        private void pictureBox28_Click(object sender, EventArgs e)
        {
            FormPelicula formPelicula = new FormPelicula(this, pelicula4, pelicula4.Salas[0]);
            this.Hide();
            formPelicula.ShowDialog();
            this.Show();
        }

        private void pictureBox32_Click(object sender, EventArgs e)
        {
            FormPelicula formPelicula = new FormPelicula(this, pelicula6, pelicula6.Salas[0]);
            this.Hide();
            formPelicula.ShowDialog();
            this.Show();
        }

        private void pictureBox29_Click(object sender, EventArgs e)
        {
            FormPelicula formPelicula = new FormPelicula(this, pelicula15, pelicula15.Salas[0]);
            this.Hide();
            formPelicula.ShowDialog();
            this.Show();
        }

        private void pictureBox30_Click(object sender, EventArgs e)
        {
            FormPelicula formPelicula = new FormPelicula(this, pelicula10, pelicula10.Salas[0]);
            this.Hide();
            formPelicula.ShowDialog();
            this.Show();
        }

        private void pictureBox31_Click(object sender, EventArgs e)
        {
            FormPelicula formPelicula = new FormPelicula(this, pelicula17, pelicula17.Salas[0]);
            this.Hide();
            formPelicula.ShowDialog();
            this.Show();
        }

        private void pictureBox33_Click(object sender, EventArgs e)
        {
            FormPelicula formPelicula = new FormPelicula(this, pelicula12, pelicula12.Salas[0]);
            this.Hide();
            formPelicula.ShowDialog();
            this.Show();
        }

        private void pictureBox34_Click(object sender, EventArgs e)
        {
            FormPelicula formPelicula = new FormPelicula(this, pelicula29, pelicula29.Salas[0]);
            this.Hide();
            formPelicula.ShowDialog();
            this.Show();
        }

        private void pictureBox35_Click(object sender, EventArgs e)
        {
            FormPelicula formPelicula = new FormPelicula(this, pelicula23, pelicula23.Salas[0]);
            this.Hide();
            formPelicula.ShowDialog();
            this.Show();
        }

        private void pictureBox36_Click(object sender, EventArgs e)
        {
            FormPelicula formPelicula = new FormPelicula(this, pelicula27, pelicula27.Salas[0]);
            this.Hide();
            formPelicula.ShowDialog();
            this.Show();
        }

        private void pictureBox37_Click(object sender, EventArgs e)
        {
            FormPelicula formPelicula = new FormPelicula(this, pelicula18, pelicula18.Salas[0]);
            this.Hide();
            formPelicula.ShowDialog();
            this.Show();
        }

        private void pictureBox38_Click(object sender, EventArgs e)
        {
            FormPelicula formPelicula = new FormPelicula(this, pelicula21, pelicula21.Salas[0]);
            this.Hide();
            formPelicula.ShowDialog();
            this.Show();
        }

        private void pictureBox39_Click(object sender, EventArgs e)
        {
            FormPelicula formPelicula = new FormPelicula(this, pelicula28, pelicula28.Salas[0]);
            this.Hide();
            formPelicula.ShowDialog();
            this.Show();
        }

        private void FormInicio_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox40_Click(object sender, EventArgs e)
        {
            FormPelicula formPelicula = new FormPelicula(this, pelicula22, pelicula22.Salas[0]);
            this.Hide();
            formPelicula.ShowDialog();
            this.Show();
        }

        private void pictureBox41_Click(object sender, EventArgs e)
        {
            FormPelicula formPelicula = new FormPelicula(this, pelicula16, pelicula16.Salas[0]);
            this.Hide();
            formPelicula.ShowDialog();
            this.Show();
        }

        private void pictureBox42_Click(object sender, EventArgs e)
        {
            FormPelicula formPelicula = new FormPelicula(this, pelicula25, pelicula25.Salas[0]);
            this.Hide();
            formPelicula.ShowDialog();
            this.Show();
        }

        private void pictureBox43_Click(object sender, EventArgs e)
        {
            FormPelicula formPelicula = new FormPelicula(this, pelicula26, pelicula26.Salas[0]);
            this.Hide();
            formPelicula.ShowDialog();
            this.Show();
        }

        private void pictureBox44_Click(object sender, EventArgs e)
        {
            FormPelicula formPelicula = new FormPelicula(this, pelicula19, pelicula19.Salas[0]);
            this.Hide();
            formPelicula.ShowDialog();
            this.Show();
        }

        private void pictureBox46_Click(object sender, EventArgs e)
        {
            FormPelicula formPelicula = new FormPelicula(this, pelicula7, pelicula7.Salas[0]);
            this.Hide();
            formPelicula.ShowDialog();
            this.Show();
        }
    }
}
