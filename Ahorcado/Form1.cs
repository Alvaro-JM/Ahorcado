using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Ahorcado
{
    public partial class Principal : Form
    {
        private string admin = "admin";
        private string password = "1234";
        private List<string> listaPeliculas;
        private Random random;
        private string titulo;
        private int numeroLetras;
        private int ayuda;
        private int errores;
        private int letrasAcertadas;
        private string dificultad;


        public Principal()
        {
            InitializeComponent();
            listaPeliculas = new List<string>();
            random = new Random();
            cargarLista();
            activarInstrucciones();
        }

        public void cargarLista()
        {
            String line;
            try
            {
                StreamReader sr = new StreamReader(".\\peliculas.txt");
                line = sr.ReadLine();
                while (line != null)
                {
                    listaPeliculas.Add(line);
                    line = sr.ReadLine();
                }
                sr.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }

        private void activarModoPrincipal()
        {
            desactivarModoAdmin();
            desactivarModoJugador();
            desactivarMenuAdmin();
            activarInstrucciones();
            logo.Visible = true;
            logo.BringToFront();
            logoPequeno.Visible = false;
            pictureBox.Image = Ahorcado.Properties.Resources.ahorcado_8;
            ModoAdmin.Visible = true;
            Jugar.Visible = true;
            facil.Visible = true;
            medio.Visible = true;
            dificil.Visible = true;
            Atras.Visible = false;
        }

        private void desactivarModoPrincipal()
        {
            desactivarMenuAdmin();
            eliminarLabels();
            logo.Visible = false;
            logoPequeno.Visible = true;
            logoPequeno.BringToFront();
            ModoAdmin.Visible = false;
            Jugar.Visible = false;
            facil.Visible = false;
            medio.Visible = false;
            dificil.Visible = false;
        }

        private void activarInstrucciones()
        {
            Label instrucciones1 = new Label();
            instrucciones1.Text = "Intenta adivinar";
            instrucciones1.Location = new Point(385, 481);
            instrucciones1.AutoSize = true;
            instrucciones1.Font = new Font("Verdana", 16);
            this.Controls.Add(instrucciones1);
            instrucciones1.BringToFront();

            Label instrucciones2 = new Label();
            instrucciones2.Text = "el título de la película.";
            instrucciones2.Location = new Point(356, 512);
            instrucciones2.AutoSize = true;
            instrucciones2.Font = new Font("Verdana", 16);
            this.Controls.Add(instrucciones2);
            instrucciones2.BringToFront();

            Label instrucciones4 = new Label();
            instrucciones4.Text = "¡Y no te quedes colgado!";
            instrucciones4.Location = new Point(338, 574);
            instrucciones4.AutoSize = true;
            instrucciones4.Font = new Font("Verdana", 16);
            this.Controls.Add(instrucciones4);
            instrucciones4.BringToFront();
        }

        private void activarMenuAdmin()
        {
            NombreAdmin.Visible = true;
            labelNombre.Text = "Nombre";
            ClaveAdmin.Visible = true;
            labelClave.Text = "Clave";
            AccederAdmin.Visible = true;
            labelNombre.Visible = true;
            labelClave.Visible = true;
        }

        private void desactivarMenuAdmin()
        {
            NombreAdmin.Visible = false;
            ClaveAdmin.Visible = false;
            AccederAdmin.Visible = false;
            labelNombre.Visible = false;
            labelClave.Visible = false;
        }               

        private void activarModoAdmin()
        {
            desactivarModoPrincipal();
            desactivarModoJugador();
            adminControl1.Visible = true;
            adminControl1.BringToFront();
            AtrasAdmin.Visible = true;
        }

        private void desactivarModoAdmin()
        {
            adminControl1.Visible = false;
            AtrasAdmin.Visible = false;
        }

        private void limpiarCamposAdmin()
        {
            NombreAdmin.Text = "";
            ClaveAdmin.Text = "";
        }

        private void activarModoJugador()
        {
            desactivarModoAdmin();
            desactivarModoPrincipal();
            verLetras(true);
            Renunciar.Visible = true;
        }

        private void desactivarModoJugador()
        {
            verLetras(false);
            Renunciar.Visible = false;
        }

        private void verLetras(bool activar)
        {
            botonA.Visible = activar;
            botonB.Visible = activar;
            botonC.Visible = activar;
            botonD.Visible = activar;
            botonE.Visible = activar;
            botonF.Visible = activar;
            botonG.Visible = activar;
            botonH.Visible = activar;
            botonI.Visible = activar;
            botonJ.Visible = activar;
            botonK.Visible = activar;
            botonL.Visible = activar;
            botonM.Visible = activar;
            botonN.Visible = activar;
            botonÑ.Visible = activar;
            botonO.Visible = activar;
            botonP.Visible = activar;
            botonQ.Visible = activar;
            botonR.Visible = activar;
            botonS.Visible = activar;
            botonT.Visible = activar;
            botonU.Visible = activar;
            botonV.Visible = activar;
            botonW.Visible = activar;
            botonX.Visible = activar;
            botonY.Visible = activar;
            botonZ.Visible = activar;

            botonA.BackColor = Color.FromArgb(224, 224, 224);
            botonB.BackColor = Color.FromArgb(224, 224, 224);
            botonC.BackColor = Color.FromArgb(224, 224, 224);
            botonD.BackColor = Color.FromArgb(224, 224, 224);
            botonE.BackColor = Color.FromArgb(224, 224, 224);
            botonF.BackColor = Color.FromArgb(224, 224, 224);
            botonG.BackColor = Color.FromArgb(224, 224, 224);
            botonH.BackColor = Color.FromArgb(224, 224, 224);
            botonI.BackColor = Color.FromArgb(224, 224, 224);
            botonJ.BackColor = Color.FromArgb(224, 224, 224);
            botonK.BackColor = Color.FromArgb(224, 224, 224);
            botonL.BackColor = Color.FromArgb(224, 224, 224);
            botonM.BackColor = Color.FromArgb(224, 224, 224);
            botonN.BackColor = Color.FromArgb(224, 224, 224);
            botonÑ.BackColor = Color.FromArgb(224, 224, 224);
            botonO.BackColor = Color.FromArgb(224, 224, 224);
            botonP.BackColor = Color.FromArgb(224, 224, 224);
            botonQ.BackColor = Color.FromArgb(224, 224, 224);
            botonR.BackColor = Color.FromArgb(224, 224, 224);
            botonS.BackColor = Color.FromArgb(224, 224, 224);
            botonT.BackColor = Color.FromArgb(224, 224, 224);
            botonU.BackColor = Color.FromArgb(224, 224, 224);
            botonV.BackColor = Color.FromArgb(224, 224, 224);
            botonW.BackColor = Color.FromArgb(224, 224, 224);
            botonX.BackColor = Color.FromArgb(224, 224, 224);
            botonY.BackColor = Color.FromArgb(224, 224, 224);
            botonZ.BackColor = Color.FromArgb(224, 224, 224);

            activarLetras(activar);
        }

        public void activarLetras(bool activar)
        {
            botonA.Enabled = activar;
            botonB.Enabled = activar;
            botonC.Enabled = activar;
            botonD.Enabled = activar;
            botonE.Enabled = activar;
            botonF.Enabled = activar;
            botonG.Enabled = activar;
            botonH.Enabled = activar;
            botonI.Enabled = activar;
            botonJ.Enabled = activar;
            botonK.Enabled = activar;
            botonL.Enabled = activar;
            botonM.Enabled = activar;
            botonN.Enabled = activar;
            botonÑ.Enabled = activar;
            botonO.Enabled = activar;
            botonP.Enabled = activar;
            botonQ.Enabled = activar;
            botonR.Enabled = activar;
            botonS.Enabled = activar;
            botonT.Enabled = activar;
            botonU.Enabled = activar;
            botonV.Enabled = activar;
            botonW.Enabled = activar;
            botonX.Enabled = activar;
            botonY.Enabled = activar;
            botonZ.Enabled = activar;
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ModoAdmin_Click(object sender, EventArgs e)
        {
            if (NombreAdmin.Visible == false)
            {
                activarMenuAdmin();
            }
            else if (NombreAdmin.Visible == true)
            {
                desactivarMenuAdmin();
            }
        }

        private void AccederAdmin_Click(object sender, EventArgs e)
        {
            string nombre = NombreAdmin.Text;
            string clave = ClaveAdmin.Text;

            if (nombre == admin && clave == password)
            {
                activarModoAdmin();
            }
            limpiarCamposAdmin();
            adminControl1.recargarInstrucciones();
        }

        private void AtrasAdmin_Click(object sender, EventArgs e)
        {
            activarModoPrincipal();
            adminControl1.modoPorDefecto();
        }

        private void Jugar_Click(object sender, EventArgs e)
        {            
            activarModoJugador();
            seleccionDificultad();
            seleccionPelicula();
            crearHuecos();
            usarAyuda();
            errores = 6;
            pictureBox.Image = Ahorcado.Properties.Resources.ahorcado_1;
            Atras.Visible = false;
            mostrarFallos();
        }

        private void seleccionDificultad()
        {
            if (facil.Checked)
            {
                ayuda = 2;
                dificultad = "(fácil)";
            }
            else if (medio.Checked)
            {
                ayuda = 1;
                dificultad = "(medio)";
            }
            else
            {
                ayuda = 0;
                dificultad = "(difícil)";                
            }
        }

        public void seleccionPelicula()
        {
            int numAleatorio = random.Next(0, listaPeliculas.Count);
            titulo = listaPeliculas[numAleatorio];
            contarLetras();
        }

        public void contarLetras()
        {
            letrasAcertadas = 0;
            numeroLetras = 0;
            for (int i = 0; i < titulo.Length; i++)
            {
                if (!titulo[i].Equals(' '))
                {
                    numeroLetras++;
                }
            }
        }

        public void crearHuecos()
        {
            int horizontal = 31;
            int vertical = 305;
            int letraPalabra = 0;
            Label hueco;
            for (int i = 0; i < titulo.Length; i++)
            {
                if (!titulo[i].Equals(' '))
                {
                    hueco = new Label();
                    hueco.Text = "_";
                    hueco.Location = new Point(vertical + (45 * letraPalabra), horizontal);
                    hueco.AutoSize = true;
                    hueco.Font = new Font("Verdana", 30);
                    hueco.TextAlign = ContentAlignment.BottomCenter;
                    this.Controls.Add(hueco);
                    hueco.SendToBack();
                    letraPalabra++;
                }
                else
                {
                    horizontal += 65;
                    letraPalabra = 0;
                }
            }
        }

        public void usarAyuda()
        {
            char letraAnterior = ' ';
            for (int i = ayuda; i > 0; i--)
            {                
                int posicionAleatoria = random.Next(0, titulo.Length);
                char letraEscogida = titulo[posicionAleatoria];
                while (letraEscogida.Equals(' ') || letraEscogida.Equals(letraAnterior))
                {
                    posicionAleatoria = random.Next(0, titulo.Length);
                    letraEscogida = titulo[posicionAleatoria];
                }

                if (letraEscogida.Equals('A') || letraEscogida.Equals('Á') || letraEscogida.Equals('À') || letraEscogida.Equals('Ä'))
                {
                    botonA.PerformClick();
                }           
                else if (letraEscogida.Equals('E') || letraEscogida.Equals('É') || letraEscogida.Equals('È') || letraEscogida.Equals('Ë'))
                {
                    botonE.PerformClick();
                }

                else if(letraEscogida.Equals('I') || letraEscogida.Equals('Í') || letraEscogida.Equals('Ì') || letraEscogida.Equals('ï'))
                {
                    botonI.PerformClick();
                }

                else if (letraEscogida.Equals('O') || letraEscogida.Equals('Ó') || letraEscogida.Equals('Ò') || letraEscogida.Equals('Ö'))
                {
                    botonO.PerformClick();
                }

                else if (letraEscogida.Equals('U') || letraEscogida.Equals('Ú') || letraEscogida.Equals('Ù') || letraEscogida.Equals('Ü'))
                {
                    botonU.PerformClick();
                }

                else if (letraEscogida.Equals('B'))
                {
                    botonB.PerformClick();
                }

                else if (letraEscogida.Equals('C'))
                {
                    botonC.PerformClick();
                }

                else if (letraEscogida.Equals('D'))
                {
                    botonD.PerformClick();
                }

                else if (letraEscogida.Equals('F'))
                {
                    botonF.PerformClick();
                }

                else if (letraEscogida.Equals('G'))
                {
                    botonG.PerformClick();
                }

                else if (letraEscogida.Equals('H'))
                {
                    botonH.PerformClick();
                }

                else if (letraEscogida.Equals('J'))
                {
                    botonJ.PerformClick();
                }

                else if (letraEscogida.Equals('K'))
                {
                    botonK.PerformClick();
                }

                else if (letraEscogida.Equals('L'))
                {
                    botonL.PerformClick();
                }

                else if (letraEscogida.Equals('M'))
                {
                    botonM.PerformClick();
                }

                else if (letraEscogida.Equals('N'))
                {
                    botonN.PerformClick();
                }

                else if (letraEscogida.Equals('P'))
                {
                    botonP.PerformClick();
                }

                else if (letraEscogida.Equals('Q'))
                {
                    botonQ.PerformClick();
                }

                else if (letraEscogida.Equals('R'))
                {
                    botonR.PerformClick();
                }

                else if (letraEscogida.Equals('S'))
                {
                    botonS.PerformClick();
                }

                else if (letraEscogida.Equals('T'))
                {
                    botonT.PerformClick();
                }

                else if (letraEscogida.Equals('V'))
                {
                    botonV.PerformClick();
                }

                else if (letraEscogida.Equals('W'))
                {
                    botonW.PerformClick();
                }

                else if (letraEscogida.Equals('X'))
                {
                    botonX.PerformClick();
                }

                else if (letraEscogida.Equals('Y'))
                {
                    botonY.PerformClick();
                }

                else if (letraEscogida.Equals('Z'))
                {
                    botonZ.PerformClick();
                }

                letraAnterior = Convert.ToChar(letraEscogida.ToString());

            }
        }

        private bool buscarLetra(char letra)
        {
            bool coincidencia = false;
            int horizontal = 30;
            int vertical = 305;
            int letraPalabra = 0;
            Label label;
            for (int i = 0; i < titulo.Length; i++)
            {
                if (!titulo[i].Equals(' '))
                {
                    if (titulo[i].Equals(letra))
                    {
                        label = new Label();
                        label.Text = titulo[i].ToString();
                        label.Location = new Point(vertical + (45 * letraPalabra), horizontal);
                        label.AutoSize = false;
                        label.Size = new Size(45, 45);
                        label.Font = new Font("Verdana", 28);
                        label.TextAlign = ContentAlignment.BottomCenter;
                        this.Controls.Add(label);
                        label.BringToFront();
                        coincidencia = true;
                        letrasAcertadas++;
                    }
                    letraPalabra++;

                }
                else
                {
                    horizontal += 65;
                    letraPalabra = 0;
                }
            }
            if (letrasAcertadas == numeroLetras)
            {
                acertarTitulo();
            }
            return coincidencia;
        }

        private void acertarTitulo()
        {       
            eliminarLabels();
            mostrarTitulo();
            Atras.Visible = true;
            Jugar.Visible = true;
            Renunciar.Visible = false;

            Label acertar = new Label();
            acertar.Location = new Point(262, 375);
            acertar.AutoSize = true;
            acertar.Text = "¡Enhorabuena, lo has conseguido!";
            acertar.Font = new Font("Verdana", 16, FontStyle.Bold);
            acertar.ForeColor = Color.Green;
            this.Controls.Add(acertar);
            acertar.BringToFront();

            Label dificultadLabel = new Label();
            dificultadLabel.Location = new Point(838, 329);
            dificultadLabel.AutoSize = true;
            dificultadLabel.Text = dificultad;
            dificultadLabel.Font = new Font("Verdana", 12);
            this.Controls.Add(dificultadLabel);
            dificultadLabel.BringToFront();

            activarLetras(false);
        }

        private void cometerError()
        {
            errores--;
            if (errores == 5)
            {
                pictureBox.Image = Ahorcado.Properties.Resources.ahorcado_2;                
            }
            else if (errores == 4)
            {
                pictureBox.Image = Ahorcado.Properties.Resources.ahorcado_3;
            }
            else if (errores == 3)
            {
                pictureBox.Image = Ahorcado.Properties.Resources.ahorcado_4;
            }
            else if (errores == 2)
            {
                pictureBox.Image = Ahorcado.Properties.Resources.ahorcado_5;
            }
            else if (errores == 1)
            {
                pictureBox.Image = Ahorcado.Properties.Resources.ahorcado_6;
            }
            else if (errores == 0)
            {
                pictureBox.Image = Ahorcado.Properties.Resources.ahorcado_7;
            }
            else if (errores == -1)
            {
                pictureBox.Image = Ahorcado.Properties.Resources.ahorcado_8;
                eliminarLabels();
                Renunciar.PerformClick();

            }
            mostrarFallos();
        }

        public void mostrarFallos()
        {            
            Label fallos = new Label();            
            fallos.Location = new Point(34, 432);
            fallos.AutoSize = true;
            fallos.Font = new Font("Verdana", 12);
            this.Controls.Add(fallos);
            fallos.BringToFront();

            if (errores > 0)
            {
                fallos.Text = "Puedes cometer " + errores + " fallos sin morir";
            }
            else if (errores == 0)
            {
                fallos.Text = "¡No se permiten más fallos!        \n\n      Al próximo mueres";
            }
            else
            {
                fallos.Text = "";
            }
        }

        public void mostrarTitulo()
        {
            crearHuecos();
            int horizontal = 30;
            int vertical = 305;
            int letraPalabra = 0;
            Label letra;
            for (int i = 0; i < titulo.Length; i++)
            {
                if (!titulo[i].Equals(' '))
                {
                    letra = new Label();
                    letra.Text = titulo[i].ToString();
                    letra.Location = new Point(vertical + (45 * letraPalabra), horizontal);
                    letra.AutoSize = false;
                    letra.Size = new Size(45, 45);
                    letra.Font = new Font("Verdana", 30);
                    letra.TextAlign = ContentAlignment.BottomCenter;
                    this.Controls.Add(letra);
                    letra.BringToFront();
                    letraPalabra++;
                }
                else
                {
                    horizontal += 65;
                    letraPalabra = 0;
                }
            }
        }

        public void eliminarLabels()
        {
            foreach (Control oControls in this.Controls)
            {
                if (oControls is Label)
                {
                    oControls.Text = ""; // Eliminar el texto de los labels
                }
            }
            
            foreach (Control oControls in adminControl1.Controls)
            {
                if (oControls is Label)
                {
                    oControls.Text = ""; // Eliminar el texto de los labels
                }
            }
        }

        private void Renunciar_Click(object sender, EventArgs e)
        {
            pictureBox.Image = Ahorcado.Properties.Resources.ahorcado_8;
            eliminarLabels();
            mostrarTitulo();
            Atras.Visible = true;
            Jugar.Visible = true;

            Label muerte = new Label();
            muerte.Location = new Point(285, 375);
            muerte.AutoSize = true;
            muerte.Text = "Has perdido, intenta de nuevo";
            muerte.Font = new Font("Verdana", 16, FontStyle.Bold);
            muerte.ForeColor = Color.Red;
            this.Controls.Add(muerte);
            muerte.BringToFront();

            Label dificultadLabel = new Label();
            dificultadLabel.Location = new Point(838, 329);
            dificultadLabel.AutoSize = true;
            dificultadLabel.Text = dificultad;
            dificultadLabel.Font = new Font("Verdana", 12);
            this.Controls.Add(dificultadLabel);
            dificultadLabel.BringToFront();

            activarLetras(false);
        }

        private void Atras_Click(object sender, EventArgs e)
        {
            eliminarLabels();
            activarModoPrincipal();
        }

        private void botonA_Click(object sender, EventArgs e)
        {
            bool encontrada = false; 
            // encontrada = buscarLetra('A') || buscarLetra('Á') se detiene si la primera es verdadera y no realiza la segunda comprobación
            if (buscarLetra('A'))
            {
                encontrada = true;
            }

            if (buscarLetra('Á'))
            {
                encontrada = true;
            }
            
            if (encontrada)
            {
                botonA.BackColor = Color.Green;
            }
            else
            {
                botonA.BackColor = Color.Red;
                cometerError();
            }
            botonA.Enabled = false;
        }

        private void botonE_Click(object sender, EventArgs e)
        {
            bool encontrada = false;

            if (buscarLetra('E'))
            {
                encontrada = true;
            }

            if (buscarLetra('É'))
            {
                encontrada = true;
            }

            if (encontrada)
            {
                botonE.BackColor = Color.Green;
            }
            else
            {
                botonE.BackColor = Color.Red;
                cometerError();
            }
            botonE.Enabled = false;
        }

        private void botonI_Click(object sender, EventArgs e)
        {
            bool encontrada = false;

            if (buscarLetra('I'))
            {
                encontrada = true;
            }

            if (buscarLetra('Í'))
            {
                encontrada = true;
            }           
            
            if (encontrada)
            {
                botonI.BackColor = Color.Green;
            }
            else
            {
                botonI.BackColor = Color.Red;
                cometerError();
            }
            botonI.Enabled = false;
        }

        private void botonO_Click(object sender, EventArgs e)
        {
            bool encontrada = false;

            if (buscarLetra('O'))
            {
                encontrada = true;
            }

            if (buscarLetra('Ó'))
            {
                encontrada = true;
            }

            if (encontrada)
            {
                botonO.BackColor = Color.Green;
            }
            else
            {
                botonO.BackColor = Color.Red;
                cometerError();
            }
            botonO.Enabled = false;
        }

        private void botonU_Click(object sender, EventArgs e)
        {
            bool encontrada = false;

            if (buscarLetra('U'))
            {
                encontrada = true;
            }

            if (buscarLetra('Ú'))
            {
                encontrada = true;
            }

            if (buscarLetra('Ü'))
            {
                encontrada = true;
            }
            
            if (encontrada)
            {
                botonU.BackColor = Color.Green;
            }
            else
            {
                botonU.BackColor = Color.Red;
                cometerError();
            }
            botonU.Enabled = false;
        }

        private void botonB_Click(object sender, EventArgs e)
        {
            bool encontrada = buscarLetra('B');
            if (encontrada)
            {
                botonB.BackColor = Color.Green;
            }
            else
            {
                botonB.BackColor = Color.Red;
                cometerError();
            }
            botonB.Enabled = false;
        }

        private void botonC_Click(object sender, EventArgs e)
        {
            bool encontrada = buscarLetra('C');
            if (encontrada)
            {
                botonC.BackColor = Color.Green;
            }
            else
            {
                botonC.BackColor = Color.Red;
                cometerError();
            }
            botonC.Enabled = false;
        }

        private void botonD_Click(object sender, EventArgs e)
        {
            bool encontrada = buscarLetra('D');
            if (encontrada)
            {
                botonD.BackColor = Color.Green;
            }
            else
            {
                botonD.BackColor = Color.Red;
                cometerError();
            }
            botonD.Enabled = false;
        }

        private void botonF_Click(object sender, EventArgs e)
        {
            bool encontrada = buscarLetra('F');
            if (encontrada)
            {
                botonF.BackColor = Color.Green;
            }
            else
            {
                botonF.BackColor = Color.Red;
                cometerError();
            }
            botonF.Enabled = false;
        }

        private void botonG_Click(object sender, EventArgs e)
        {
            bool encontrada = buscarLetra('G');
            if (encontrada)
            {
                botonG.BackColor = Color.Green;
            }
            else
            {
                botonG.BackColor = Color.Red;
                cometerError();
            }
            botonG.Enabled = false;
        }

        private void botonH_Click(object sender, EventArgs e)
        {
            bool encontrada = buscarLetra('H');
            if (encontrada)
            {
                botonH.BackColor = Color.Green;
            }
            else
            {
                botonH.BackColor = Color.Red;
                cometerError();
            }
            botonH.Enabled = false;
        }

        private void botonJ_Click(object sender, EventArgs e)
        {
            bool encontrada = buscarLetra('J');
            if (encontrada)
            {
                botonJ.BackColor = Color.Green;
            }
            else
            {
                botonJ.BackColor = Color.Red;
                cometerError();
            }
            botonJ.Enabled = false;
        }

        private void botonK_Click(object sender, EventArgs e)
        {
            bool encontrada = buscarLetra('K');
            if (encontrada)
            {
                botonK.BackColor = Color.Green;
            }
            else
            {
                botonK.BackColor = Color.Red;
                cometerError();
            }
            botonK.Enabled = false;
        }

        private void botonL_Click(object sender, EventArgs e)
        {
            bool encontrada = buscarLetra('L');
            if (encontrada)
            {
                botonL.BackColor = Color.Green;
            }
            else
            {
                botonL.BackColor = Color.Red;
                cometerError();
            }
            botonL.Enabled = false;
        }

        private void botonM_Click(object sender, EventArgs e)
        {
            bool encontrada = buscarLetra('M');
            if (encontrada)
            {
                botonM.BackColor = Color.Green;
            }
            else
            {
                botonM.BackColor = Color.Red;
                cometerError();
            }
            botonM.Enabled = false;
        }

        private void botonN_Click(object sender, EventArgs e)
        {
            bool encontrada = buscarLetra('N');
            if (encontrada)
            {
                botonN.BackColor = Color.Green;
            }
            else
            {
                botonN.BackColor = Color.Red;
                cometerError();
            }
            botonN.Enabled = false;
        }

        private void botonÑ_Click(object sender, EventArgs e)
        {
            bool encontrada = buscarLetra('Ñ');
            if (encontrada)
            {
                botonÑ.BackColor = Color.Green;
            }
            else
            {
                botonÑ.BackColor = Color.Red;
                cometerError();
            }
            botonÑ.Enabled = false;
        }

        private void botonP_Click(object sender, EventArgs e)
        {
            bool encontrada = buscarLetra('P');
            if (encontrada)
            {
                botonP.BackColor = Color.Green;
            }
            else
            {
                botonP.BackColor = Color.Red;
                cometerError();
            }
            botonP.Enabled = false;
        }

        private void botonQ_Click(object sender, EventArgs e)
        {
            bool encontrada = buscarLetra('Q');
            if (encontrada)
            {
                botonQ.BackColor = Color.Green;
            }
            else
            {
                botonQ.BackColor = Color.Red;
                cometerError();
            }
            botonQ.Enabled = false;
        }

        private void botonR_Click(object sender, EventArgs e)
        {
            bool encontrada = buscarLetra('R');
            if (encontrada)
            {
                botonR.BackColor = Color.Green;
            }
            else
            {
                botonR.BackColor = Color.Red;
                cometerError();
            }
            botonR.Enabled = false;
        }

        private void botonS_Click(object sender, EventArgs e)
        {
            bool encontrada = buscarLetra('S');
            if (encontrada)
            {
                botonS.BackColor = Color.Green;
            }
            else
            {
                botonS.BackColor = Color.Red;
                cometerError();
            }
            botonS.Enabled = false;
        }

        private void botonT_Click(object sender, EventArgs e)
        {
            bool encontrada = buscarLetra('T');
            if (encontrada)
            {
                botonT.BackColor = Color.Green;
            }
            else
            {
                botonT.BackColor = Color.Red;
                cometerError();
            }
            botonT.Enabled = false;
        }

        private void botonV_Click(object sender, EventArgs e)
        {
            bool encontrada = buscarLetra('V');
            if (encontrada)
            {
                botonV.BackColor = Color.Green;
            }
            else
            {
                botonV.BackColor = Color.Red;
                cometerError();
            }
            botonV.Enabled = false;
        }

        private void botonW_Click(object sender, EventArgs e)
        {
            bool encontrada = buscarLetra('W');
            if (encontrada)
            {
                botonW.BackColor = Color.Green;
            }
            else
            {
                botonW.BackColor = Color.Red;
                cometerError();
            }
            botonW.Enabled = false;
        }

        private void botonX_Click(object sender, EventArgs e)
        {
            bool encontrada = buscarLetra('X');
            if (encontrada)
            {
                botonX.BackColor = Color.Green;
            }
            else
            {
                botonX.BackColor = Color.Red;
                cometerError();
            }
            botonX.Enabled = false;
        }

        private void botonY_Click(object sender, EventArgs e)
        {
            bool encontrada = buscarLetra('Y');
            if (encontrada)
            {
                botonY.BackColor = Color.Green;
            }
            else
            {
                botonY.BackColor = Color.Red;
                cometerError();
            }
            botonY.Enabled = false;
        }

        private void botonZ_Click(object sender, EventArgs e)
        {
            bool encontrada = buscarLetra('Z');
            if (encontrada)
            {
                botonZ.BackColor = Color.Green;
            }
            else
            {
                botonZ.BackColor = Color.Red;
                cometerError();
            }
            botonZ.Enabled = false;
        }
        
        // Si se activa el teclado para el ahorcado, no se puede escribir nombre y clave de admin
        /*
        protected override bool ProcessCmdKey(ref System.Windows.Forms.Message msg, System.Windows.Forms.Keys keyData)
        {            
            if (keyData == Keys.A)
            {
                botonA.PerformClick();
            }

            if (keyData == Keys.E)
            {
                botonE.PerformClick();
            }

            if (keyData == Keys.I)
            {
                botonI.PerformClick();
            }

            if (keyData == Keys.O)
            {
                botonO.PerformClick();
            }

            if (keyData == Keys.U)
            {
                botonU.PerformClick();
            }

            if (keyData == Keys.B)
            {
                botonB.PerformClick();
            }

            if (keyData == Keys.C)
            {
                botonC.PerformClick();
            }

            if (keyData == Keys.D)
            {
                botonD.PerformClick();
            }

            if (keyData == Keys.F)
            {
                botonF.PerformClick();
            }

            if (keyData == Keys.G)
            {
                botonG.PerformClick();
            }

            if (keyData == Keys.H)
            {
                botonH.PerformClick();
            }

            if (keyData == Keys.J)
            {
                botonJ.PerformClick();
            }

            if (keyData == Keys.K)
            {
                botonK.PerformClick();
            }

            if (keyData == Keys.L)
            {
                botonL.PerformClick();
            }

            if (keyData == Keys.M)
            {
                botonM.PerformClick();
            }

            if (keyData == Keys.N)
            {
                botonN.PerformClick();
            }

            if (keyData == Keys.P)
            {
                botonP.PerformClick();
            }

            if (keyData == Keys.Q)
            {
                botonQ.PerformClick();
            }

            if (keyData == Keys.R)
            {
                botonR.PerformClick();
            }

            if (keyData == Keys.S)
            {
                botonS.PerformClick();
            }

            if (keyData == Keys.T)
            {
                botonT.PerformClick();
            }

            if (keyData == Keys.V)
            {
                botonV.PerformClick();
            }

            if (keyData == Keys.W)
            {
                botonW.PerformClick();
            }

            if (keyData == Keys.X)
            {
                botonX.PerformClick();
            }

            if (keyData == Keys.Y)
            {
                botonY.PerformClick();
            }

            if (keyData == Keys.Z)
            {
                botonZ.PerformClick();
            }
            return true;
        
        }*/

    }


}
