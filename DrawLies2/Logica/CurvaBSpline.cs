using System;
using System.Collections.Generic;
using System.Drawing;

namespace DrawLies2
{
    public class CurvaBSpline
    {
        public List<PointF> PuntosControl { get; private set; } = new List<PointF>();
        public List<PointF> CurvaGenerada { get; private set; } = new List<PointF>();
        private float tActual = 0f;
        public float PasoT { get; set; } = 0.01f;

        public void AgregarPunto(PointF p)
        {
            PuntosControl.Add(p);
        }

        public void Reset()
        {
            PuntosControl.Clear();
            CurvaGenerada.Clear();
            tActual = 0f;
        }

        public void ReiniciarAnimacion()
        {
            CurvaGenerada.Clear();
            tActual = 0f;
        }

        public bool ListoParaAnimar()
        {
            return PuntosControl.Count >= 4;
        }

        public PointF? AvanzarPaso()
        {
            if (!ListoParaAnimar() || tActual > PuntosControl.Count - 3)
                return null;

            PointF punto = CalcularBSpline(tActual);
            CurvaGenerada.Add(punto);
            tActual += PasoT;
            return punto;
        }

        public void GenerarCurvaCompleta()
        {
            CurvaGenerada.Clear();
            for (float t = 0; t <= PuntosControl.Count - 3; t += PasoT)
            {
                CurvaGenerada.Add(CalcularBSpline(t));
            }
        }

        private PointF CalcularBSpline(float t)
        {
            int i = (int)Math.Floor(t);
            float u = t - i;

            if (i + 3 >= PuntosControl.Count)
                return PuntosControl[PuntosControl.Count - 1];

            PointF P0 = PuntosControl[i];
            PointF P1 = PuntosControl[i + 1];
            PointF P2 = PuntosControl[i + 2];
            PointF P3 = PuntosControl[i + 3];

            float u2 = u * u;
            float u3 = u2 * u;

            float x = (1f / 6f) * (
                (-u3 + 3 * u2 - 3 * u + 1) * P0.X +
                (3 * u3 - 6 * u2 + 4) * P1.X +
                (-3 * u3 + 3 * u2 + 3 * u + 1) * P2.X +
                u3 * P3.X);

            float y = (1f / 6f) * (
                (-u3 + 3 * u2 - 3 * u + 1) * P0.Y +
                (3 * u3 - 6 * u2 + 4) * P1.Y +
                (-3 * u3 + 3 * u2 + 3 * u + 1) * P2.Y +
                u3 * P3.Y);

            return new PointF(x, y);
        }
    }
}
