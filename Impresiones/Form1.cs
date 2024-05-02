using System.Drawing;

namespace Impresiones
{
    
    public partial class Form1 : Form
    {
        int cont = 0;

        Cola alta = new Cola();
        Cola media = new Cola();
        Cola baja = new Cola();
        Form2 f2 = new Form2();

        public Form1()
        {
            InitializeComponent();
            f2.Show();
            alta.Listar(lstAlta);
            media.Listar(lstMedia);
            baja.Listar(lstBaja);
        }

        private void cmdImprimir_Click(object sender, EventArgs e)
        {
            NodoArchivo nuevo = new NodoArchivo(txtArchivo.Text);
            switch (cboPrioridad.Text)
            {
                case "ALTA":
                    alta.Insertar(nuevo);
                    alta.Listar(lstAlta);
                    break;
                case "MEDIA":
                    media.Insertar(nuevo);
                    media.Listar(lstMedia);
                    break;
                case "BAJA":
                    baja.Insertar(nuevo);
                    baja.Listar(lstBaja);
                    break;
            }
            timer1.Start();
        }

        private void cmdEjecutar_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            cont++;
            Text = cont.ToString();
            if (alta.inicio != null)
            {
                f2.pasarNombrearchivo(alta.inicio.nombreArchivo);
                alta.Eliminar();
                alta.Listar(lstAlta);
            }
            else if (media.inicio != null)
            {
                f2.pasarNombrearchivo(media.inicio.nombreArchivo);
                media.Eliminar();
                media.Listar(lstMedia);
            }
            else if (baja.inicio != null)
            {
                f2.pasarNombrearchivo(baja.inicio.nombreArchivo);
                baja.Eliminar();
                baja.Listar(lstBaja);
            }

            if(alta.inicio == null && media.inicio==null && baja.inicio == null) timer1.Stop(); 
        }
    }
}