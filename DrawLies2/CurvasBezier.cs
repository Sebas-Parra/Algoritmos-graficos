using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawLies2
{
    public class CurvasBezier
    {
        public List<PointF> PuntosControl { get; private set; } = new List<PointF>();
        public List<PointF> CurvaGenerada { get; private set; } = new List<PointF>();

        public float tActual { get; private set; } = 0;
        public float PasoT { get; set; } = 0.01f;

        public int CantidadEsperada { get; set; } = 4; // Se usa cuando se cambie aBernstein


        public CurvasBezier()
        {
            Reset();
        }

        public void AgregarPunto(PointF p)
        {
            if (PuntosControl.Count < CantidadEsperada)
                PuntosControl.Add(p);
        }

        public void GenerarCurva()
        {
            CurvaGenerada.Clear();
            for (float t = 0; t <= 1.0f; t += PasoT)
            {
                var punto = CalcularBernstein(t);
                CurvaGenerada.Add(punto);
            }
        }

        private PointF CalcularBernstein(float t)
        {
            int n = PuntosControl.Count - 1;
            float x = 0, y = 0;

            for (int i = 0; i <= n; i++)
            {
                float bin = Binomial(n, i);
                float term = bin * (float)Math.Pow(1 - t, n - i) * (float)Math.Pow(t, i);
                x += term * PuntosControl[i].X;
                y += term * PuntosControl[i].Y;
            }

            return new PointF(x, y);
        }



        public bool ListoParaAnimar()
        {
            return PuntosControl.Count == 4;
        }

        public void Reset()
        {
            PuntosControl.Clear();
            CurvaGenerada.Clear();
            tActual = 0;
        }

        public void ReiniciarAnimacion()
        {
            CurvaGenerada.Clear();
            tActual = 0;
        }

        public (PointF A, PointF B, PointF C, PointF D, PointF E, PointF F)? AvanzarPaso()
        {
            if (!ListoParaAnimar() || tActual > 1)
                return null;

            PointF P0 = PuntosControl[0];
            PointF P1 = PuntosControl[1];
            PointF P2 = PuntosControl[2];
            PointF P3 = PuntosControl[3];

            float t = tActual;

            // De Casteljau
            PointF A = Lerp(P0, P1, t);
            PointF B = Lerp(P1, P2, t);
            PointF C = Lerp(P2, P3, t);

            PointF D = Lerp(A, B, t);
            PointF E = Lerp(B, C, t);

            PointF F = Lerp(D, E, t);

            CurvaGenerada.Add(F);
            tActual += PasoT;

            return (A, B, C, D, E, F);
        }

        private PointF Lerp(PointF p1, PointF p2, float t)
        {
            return new PointF(
                p1.X + (p2.X - p1.X) * t,
                p1.Y + (p2.Y - p1.Y) * t
            );
        }

        private float Binomial(int n, int k)
        {
            return Factorial(n) / (Factorial(k) * Factorial(n - k));
        }

        private float Factorial(int n)
        {
            float res = 1;
            for (int i = 2; i <= n; i++) res *= i;
            return res;
        }

    }
}
