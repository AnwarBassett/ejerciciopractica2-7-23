using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace Libro
{
    public class Registro
    {
        private String T, AT, Is;
        private int Pag;

        public Registro()
        {
        }

        public Registro(string LocalT, string LocalAT, string LocalIs, int LocalPag)
        {
            T = LocalT;
            AT = LocalAT;
            Is = LocalIs;
            Pag = LocalPag;
        }

        public string Ts { get => T; set => T = value; }
        public string ATs { get => AT; set => AT = value; }
        public string Iss { get => Is; set => Is = value; }
        public int Pags { get => Pag; set => Pag = value; }

        public string guardar(String a, String b, int c, String d)
        {
            string mensaje="";
            mensaje += "Titulo del Libro: " + a;
            mensaje += " Autor del Libro: " + b;
            mensaje += " N° de Paginas: " + c;
            mensaje += " ISBN: " + d;

            StreamWriter archivo = File.AppendText("Examen.txt");
            String mensaje2;
            mensaje2 = mensaje;
            archivo.WriteLine(mensaje2);
            archivo.Close();
            return mensaje;
        }
        public void Borrar()
        {

        }
    }
}
