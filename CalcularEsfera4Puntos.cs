using System;
using System.Collections.Generic;
using System.Text;

public class CalcularEsfera4Puntos {
    private const float CERO = 0;
    private double m_X0, m_Y0, m_Z0;
    private double m_Radio;
    private double[,] P = {
            { CERO, CERO, CERO },
            { CERO, CERO, CERO },
            { CERO, CERO, CERO },
            { CERO, CERO, CERO } };


    public double[] Centro {
        get { return new double[] { this.m_X0, this.m_Y0, this.m_Z0 }; }
    }


    public double Radio {
        get { return this.m_Radio; }
    }

    public bool esValido {
        get { return this.m_Radio != 0; }
    }


    public CalcularEsfera4Puntos(double[] a, double[] b, double[] c, double[] d) {
        this.Calcular(a, b, c, d);
    }


    private void Calcular(double[] a, double[] b, double[] c, double[] d) {
        P[0, 0] = a[0];
        P[0, 1] = a[1];
        P[0, 2] = a[2];
        P[1, 0] = b[0];
        P[1, 1] = b[1];
        P[1, 2] = b[2];
        P[2, 0] = c[0];
        P[2, 1] = c[1];
        P[2, 2] = c[2];
        P[3, 0] = d[0];
        P[3, 1] = d[1];
        P[3, 2] = d[2];

        this.Esfera();
    }

    private void Esfera() {
        double  m11, m12, m13, m14, m15;
        double[,] a =
            {
                { CERO, CERO, CERO, CERO },
                { CERO, CERO, CERO, CERO },
                { CERO, CERO, CERO, CERO },
                { CERO, CERO, CERO, CERO }
            };


        for (int i = 0; i < 4; i++) {
            a[i, 0] = P[i, 0];
            a[i, 1] = P[i, 1];
            a[i, 2] = P[i, 2];
            a[i, 3] = 1;
        }
        m11 = this.Determinante(a, 4);


        for (int i = 0; i < 4; i++){
            a[i, 0] = P[i, 0] * P[i, 0] + P[i, 1] * P[i, 1] + P[i, 2] * P[i, 2];
            a[i, 1] = P[i, 1];
            a[i, 2] = P[i, 2];
            a[i, 3] = 1;
        }
        m12 = this.Determinante(a, 4);


        for (int i = 0; i < 4; i++) {
            a[i, 0] = P[i, 0] * P[i, 0] + P[i, 1] * P[i, 1] + P[i, 2] * P[i, 2];
            a[i, 1] = P[i, 0];
            a[i, 2] = P[i, 2];
            a[i, 3] = 1;
        }
        m13 = this.Determinante(a, 4);

        for (int i = 0; i < 4; i++) {
            a[i, 0] = P[i, 0] * P[i, 0] + P[i, 1] * P[i, 1] + P[i, 2] * P[i, 2];
            a[i, 1] = P[i, 0];
            a[i, 2] = P[i, 1];
            a[i, 3] = 1;
        }
        m14 = this.Determinante(a, 4);

        for (int i = 0; i < 4; i++) {
            a[i, 0] = P[i, 0] * P[i, 0] + P[i, 1] * P[i, 1] + P[i, 2] * P[i, 2];
            a[i, 1] = P[i, 0];
            a[i, 2] = P[i, 1];
            a[i, 3] = P[i, 2];
        }
        m15 = this.Determinante(a, 4);


        if (m11 == 0) {
            this.m_X0 = 0;
            this.m_Y0 = 0;
            this.m_Z0 = 0;
            this.m_Radio = 0;
        }else{
            this.m_X0 = 0.5 * m12 / m11;
            this.m_Y0 = -0.5 * m13 / m11;
            this.m_Z0 = 0.5 * m14 / m11;
            this.m_Radio = System.Math.Sqrt(this.m_X0 * this.m_X0 + this.m_Y0 * this.m_Y0 + this.m_Z0 * this.m_Z0 - m15 / m11);
        }
    }

    private double Determinante(double[,] a, double n) {
        int i, j, j1, j2;
        double determ = 0;
        double[,] m =  {
                { CERO, CERO, CERO, CERO },
                { CERO, CERO, CERO, CERO },
                { CERO, CERO, CERO, CERO },
                { CERO, CERO, CERO, CERO } };

        if (n == 2) {
            //Fin recursion
            determ = a[0, 0] * a[1, 1] - a[1, 0] * a[0, 1];
        }else{
            determ = 0;
            for (j1 = 0; j1 < n; j1++) {
                for (i = 1; i < n; i++) {
                    j2 = 0;
                    for (j = 0; j < n; j++) {
                        if (j == j1) 
                            continue;
                        m[i - 1, j2] = a[i, j];
                        j2++;
                    }
                }
                determ += System.Math.Pow(-1.0, j1) * a[0, j1] * this.Determinante(m, n - 1);
            }
        }

        return determ;
    }
}
