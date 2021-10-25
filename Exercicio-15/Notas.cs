using System;
using System.Globalization;
namespace Exercicio_15
{
    public class Notas
    {
        public string Materia;
        public double Nota;

        public double Media(double contNotas, int qntNotas){
            return (double) (contNotas/qntNotas);
        }

        public override string ToString(){
            return "Matéria: "+Materia+"\nNota: "+Nota;
        }
    }
}