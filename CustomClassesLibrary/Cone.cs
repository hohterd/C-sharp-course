using System;
using System.Collections.Generic;
using System.Text;

namespace CustomClassesLibrary
{
    public class Cone
    {
        public double Height { get; set; }
        public double Radius { get; set; }
        private double Generatrix { get; set; }

        public Cone(double radius, double height)
        {
            Radius = radius;
            Height = height;
            Generatrix = GeneratrixOfACone();
        }

        private double GeneratrixOfACone()
        {
            return Math.Sqrt(Math.Pow(Radius, 2) + Math.Pow(Height, 2));
        }

        public double CompleteSquareOfACone()
        {
            return Math.PI * Radius * (Radius + Generatrix);
        }

        public double ConeBaseSurfaceSquare()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}
