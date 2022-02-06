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
    public partial class AdminControl : UserControl
    {
        private List<string> listaPeliculas;
        string titulo;
        string modo;
        string mensajeError;

        public AdminControl()
        {
            InitializeComponent();
            listaPeliculas = new List<string>();
            modoPorDefecto();
        }

        public void cargarLista()
        {
            listaPeliculas.Clear();
            string line;
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

        private void cargarListBox()
        {
            listBox.Items.Clear();

            for (int i = 0; i < listaPeliculas.Count; i++)
            {
                listBox.Items.Add(listaPeliculas[i]);
            }
            
        }

        public void modoPorDefecto()
        {
            cargarLista();
            cargarListBox();

            aniadir.Enabled = true;
            modificar.Enabled = true;
            eliminar.Enabled = true;
            guardar.Visible = false;
            cancelar.Visible = false;
            campo.Enabled = false;

            listBox.SelectionMode = SelectionMode.None;

            campo.Text = "";
            modo = "";
            titulo = "";
            mensajeError = "";

            listBox.ClearSelected();
            recargarInstrucciones();            
        }

        private void modoAniadir()
        {
            eliminarLabels();
            recargarInstrucciones();

            aniadir.Enabled = false;
            modificar.Enabled = false;
            eliminar.Enabled = false;
            guardar.Visible = true;
            cancelar.Visible = true;
            campo.Enabled = true;
            listBox.SelectionMode = SelectionMode.None;
            modo = "Añadir:";
        }

        private void modoModificar()
        {
            eliminarLabels();
            recargarInstrucciones();

            aniadir.Enabled = false;
            modificar.Enabled = false;
            eliminar.Enabled = false;
            guardar.Visible = true;
            cancelar.Visible = true;
            campo.Enabled = true;
            listBox.SelectionMode = SelectionMode.One;
            modo = "Modificar:";
        }

        private void modoEliminar()
        {
            eliminarLabels();
            recargarInstrucciones();

            aniadir.Enabled = false;
            modificar.Enabled = false;
            eliminar.Enabled = false;
            guardar.Visible = true;
            cancelar.Visible = true;
            campo.Enabled = false;
            listBox.SelectionMode = SelectionMode.One;
            modo = "Eliminar:";
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox.SelectedIndex >= 0)
            {
                campo.Text = listBox.SelectedItem.ToString();
            }
        }

        private void aniadir_Click(object sender, EventArgs e)
        {
            modoAniadir();
            Label modus = new Label();
            modus.Text = modo;
            modus.Location = new Point(138, 355);
            modus.AutoSize = false;
            modus.Size = new Size(81, 18);
            modus.Font = new Font("Verdana", 11);
            modus.TextAlign = ContentAlignment.MiddleRight;
            this.Controls.Add(modus);
            modus.BringToFront();
        }

        private void modificar_Click(object sender, EventArgs e)
        {
            modoModificar();
            Label modus = new Label();
            modus.Text = modo;
            modus.Location = new Point(138, 355);
            modus.AutoSize = false;
            modus.Size = new Size(81, 18);
            modus.Font = new Font("Verdana", 11);
            modus.TextAlign = ContentAlignment.MiddleRight;
            this.Controls.Add(modus);
            modus.BringToFront();
        }

        private void eliminar_Click(object sender, EventArgs e)
        {
            modoEliminar();
            Label modus = new Label();
            modus.Text = modo;
            modus.Location = new Point(138, 355);
            modus.AutoSize = false;
            modus.Size = new Size(81, 18);
            modus.Font = new Font("Verdana", 11);
            modus.TextAlign = ContentAlignment.MiddleRight;
            this.Controls.Add(modus);
            modus.BringToFront();
        }

        private void guardar_Click(object sender, EventArgs e)
        {
            if (modo.Equals("Eliminar:"))
            {
                if (listBox.SelectedIndex >= 0)
                {
                    listaPeliculas.RemoveAt(listBox.SelectedIndex);
                }
                else
                {
                    mensajeError = "No se ha seleccionado titulo a eliminar";
                }
                
            }
            else if (modo.Equals("Modificar:"))
            {
                if (comprobar())
                {
                    listaPeliculas[listBox.SelectedIndex] = titulo;
                }                
            }
            else if (modo.Equals("Añadir:"))
            {
                if (comprobar())
                {
                    listaPeliculas.Add(titulo);
                }
            }

            eliminarLabels();
            escribirMensajError();        
            escribirFichero();
            modoPorDefecto();            
            recargarInstrucciones();
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            modoPorDefecto();
            eliminarLabels();
            recargarInstrucciones();
        }
        
        private bool comprobar()
        {         
            return !caracterNoPermitido() && !palabraGrande() && !muchasPalabras();          
        }

        private bool caracterNoPermitido()
        {
            titulo = campo.Text.ToUpper();

            bool erroneo = false;
            int i = 0;
            if (titulo.Length <= 0)
            {
                mensajeError = "El título no puede estar vacío";
                erroneo = true;
            }
            else
            {
                if (titulo[0].Equals(' '))
                {
                    mensajeError = "El título no puede comenzar con espacio";
                    erroneo = true;
                }
                while (i < titulo.Length && !erroneo)
                {
                    if (titulo[i].Equals(' ') && titulo[i + 1].Equals(' '))//doble espacio
                    {
                        mensajeError = "No se permite doble espacio";
                        erroneo = true;
                    }

                    if (!titulo[i].Equals('A') && !titulo[i].Equals('Á') && !titulo[i].Equals('E') && !titulo[i].Equals('É')
                        && !titulo[i].Equals('I') && !titulo[i].Equals('Í') && !titulo[i].Equals('O') && !titulo[i].Equals('Ó')
                        && !titulo[i].Equals('U') && !titulo[i].Equals('Ú') && !titulo[i].Equals('Ü')
                        && !titulo[i].Equals('B') && !titulo[i].Equals('C') && !titulo[i].Equals('D') && !titulo[i].Equals('F')
                        && !titulo[i].Equals('G') && !titulo[i].Equals('H') && !titulo[i].Equals('J') && !titulo[i].Equals('K')
                        && !titulo[i].Equals('L') && !titulo[i].Equals('M') && !titulo[i].Equals('N') && !titulo[i].Equals('Ñ')
                        && !titulo[i].Equals('P') && !titulo[i].Equals('Q') && !titulo[i].Equals('R') && !titulo[i].Equals('S')
                        && !titulo[i].Equals('T') && !titulo[i].Equals('V') && !titulo[i].Equals('W') && !titulo[i].Equals('X')
                        && !titulo[i].Equals('Y') && !titulo[i].Equals('Z') && !titulo[i].Equals(' '))
                    {
                        mensajeError = "No se permiten números ni caracteres especiales";
                        erroneo = true;
                    }
                    i++;
                }
            }
            
            return erroneo;
        }

        private bool muchasPalabras()
        {
            
            int numPalabras = 1;
            for (int i = 0; i < titulo.Length; i++)
            {
                if (titulo[i].Equals(' '))
                {
                    numPalabras++;
                }
            }

            if (numPalabras > 5)
            {
                mensajeError = "No se permiten títulos con más de 5 palabras";
            }
            
            return numPalabras > 5;
        }

        private bool palabraGrande()
        {
            int letras = 0;
            int temp = 0;
            for (int i = 0; i < titulo.Length; i++)
            {
                if (titulo[i].Equals(' '))
                {
                    if (temp > letras)
                    {
                        letras = temp;
                    }
                    temp = 0;
                }
                else
                {
                    temp++;
                }
            }

            if (temp > letras)
            {
                letras = temp;
            }

            if (letras > 8)
            {
                mensajeError = "No se permiten palabras con más de 8 letras";
            }
            
            return letras > 8;
        }

        private void escribirFichero()
        {
            try
            {
                StreamWriter sw = new StreamWriter(".\\peliculas.txt", false, Encoding.UTF8);
                for (int i = 0; i < listaPeliculas.Count; i++)
                {
                    sw.WriteLine(listaPeliculas[i]);
                }
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
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
        }

        public void recargarInstrucciones()
        {
            Label instrucciones1 = new Label();
            instrucciones1.Text = "No se permiten números ni caracteres especiales";
            instrucciones1.Location = new Point(222, 477);
            instrucciones1.AutoSize = true;
            instrucciones1.Font = new Font("Verdana", 11);
            this.Controls.Add(instrucciones1);
            instrucciones1.BringToFront();

            Label instrucciones2 = new Label();
            instrucciones2.Text = "No se permite comenzar con espacio";
            instrucciones2.Location = new Point(222, 507);
            instrucciones2.AutoSize = true;
            instrucciones2.Font = new Font("Verdana", 11);
            this.Controls.Add(instrucciones2);
            instrucciones2.BringToFront();

            Label instrucciones3 = new Label();
            instrucciones3.Text = "No se permiten títulos con más de 5 palabras";
            instrucciones3.Location = new Point(222, 537);
            instrucciones3.AutoSize = true;
            instrucciones3.Font = new Font("Verdana", 11);
            this.Controls.Add(instrucciones3);
            instrucciones3.BringToFront();

            Label instrucciones4 = new Label();
            instrucciones4.Text = "No se permiten palabras superiores a 8 letras";
            instrucciones4.Location = new Point(222, 567);
            instrucciones4.AutoSize = true;
            instrucciones4.Font = new Font("Verdana", 11);
            this.Controls.Add(instrucciones4);
            instrucciones4.BringToFront();

            Label modoAdmin = new Label();
            modoAdmin.Text = "Modo admin";
            modoAdmin.Location = new Point(25, 25);
            modoAdmin.AutoSize = true;
            modoAdmin.Font = new Font("Verdana", 11);
            this.Controls.Add(modoAdmin);
            modoAdmin.BringToFront();
        }

        private void escribirMensajError()
        {
            Label mensaje = new Label();
            mensaje.Text = mensajeError;
            mensaje.Location = new Point(222, 321);
            mensaje.AutoSize = true;
            mensaje.Font = new Font("Verdana", 11, FontStyle.Bold);
            mensaje.ForeColor = Color.Red;
            this.Controls.Add(mensaje);
            mensaje.BringToFront();
        }

        
    }
}
