using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba_IA_Lara
{
    public class CLEstado
    {
        private int[,] _tablero;

        private int _nivel;

        private CLEstado _padre;

        public int[,] tablero
        {
            get => _tablero;
            set => _tablero = value;
        }

        public int nivel
        {
            get => _nivel;
            set => _nivel = value;
        }

        public CLEstado padre
        {
            get => _padre;
            set => _padre = value;
        }

        public CLEstado(){

            this._tablero = new int[3, 3];
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    this._tablero[i, j] = 0;
            this._nivel = 0;
            this._padre = null;
        }
        public CLEstado( int p00, int p01, int p02,
                        int p10, int p11, int p12,
                        int p20, int p21, int p22) 
        {
            this._tablero = new int[3,3];
            this._tablero[0, 0] = p00;
            this._tablero[0, 1] = p01;
            this._tablero[0, 2] = p02;
            this._tablero[1, 0] = p10;
            this._tablero[1, 1] = p11;
            this._tablero[1, 2] = p12;
            this._tablero[2, 0] = p20;
            this._tablero[2, 1] = p21;
            this._tablero[2, 2] = p22;
            this._nivel = 0;
            this._padre = null;
        }
        public List<CLEstado> GenerarHijos() 
        {
            List<CLEstado> Respuesta = new List<CLEstado>();
            String pos0 = "";
            int[,] aux = new int[3, 3];
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    if (this._tablero[i, j] == 0)
                    {
                        pos0 = i.ToString() + j.ToString();
                    }
            CLEstado A = new CLEstado();
            switch (pos0)
            {
                case "00":
                    A = new CLEstado(this._tablero[0, 1],
                                             this._tablero[0, 0],
                                             this._tablero[0, 2],
                                             this._tablero[1, 0],
                                             this._tablero[1, 1],
                                             this._tablero[1, 2],
                                             this._tablero[2, 0],
                                             this._tablero[2, 1],
                                             this._tablero[2, 2]);
                    A.nivel = this.nivel + 1;
                    A.padre = this;
                    Respuesta.Add(A);
                    A = new CLEstado(this._tablero[1, 0],
                                     this._tablero[0, 1],
                                     this._tablero[0, 2],
                                     this._tablero[0, 0],
                                     this._tablero[1, 1],
                                     this._tablero[1, 2],
                                     this._tablero[2, 0],
                                     this._tablero[2, 1],
                                     this._tablero[2, 2]);
                    A.nivel = this.nivel + 1;
                    A.padre = this;
                    Respuesta.Add(A);
                    break;
                case "01":
                    A = new CLEstado(this._tablero[0, 1],
                                         this._tablero[0, 0],
                                         this._tablero[0, 2],
                                         this._tablero[1, 0],
                                         this._tablero[1, 1],
                                         this._tablero[1, 2],
                                         this._tablero[2, 0],
                                         this._tablero[2, 1],
                                         this._tablero[2, 2]);
                    A.nivel = this.nivel + 1;
                    A.padre = this;
                    Respuesta.Add(A);

                    A = new CLEstado(this._tablero[0, 0],
                                         this._tablero[1, 1],
                                         this._tablero[0, 2],
                                         this._tablero[1, 0],
                                         this._tablero[0, 1],
                                         this._tablero[1, 2],
                                         this._tablero[2, 0],
                                         this._tablero[2, 1],
                                         this._tablero[2, 2]);
                    A.nivel = this.nivel + 1;
                    A.padre = this;
                    Respuesta.Add(A);

                    A = new CLEstado(this._tablero[0, 0],
                                         this._tablero[0, 2],
                                         this._tablero[0, 1],
                                         this._tablero[1, 0],
                                         this._tablero[1, 1],
                                         this._tablero[1, 2],
                                         this._tablero[2, 0],
                                         this._tablero[2, 1],
                                         this._tablero[2, 2]);
                    A.nivel = this.nivel + 1;
                    A.padre = this;
                    Respuesta.Add(A);
                    break;
                case "02":
                    A = new CLEstado(this._tablero[0, 0],
                                     this._tablero[0, 2],
                                     this._tablero[0, 1],
                                     this._tablero[1, 0],
                                     this._tablero[1, 1],
                                     this._tablero[1, 2],
                                     this._tablero[2, 0],
                                     this._tablero[2, 1],
                                     this._tablero[2, 2]);
                    A.nivel = this.nivel + 1;
                    A.padre = this;
                    Respuesta.Add(A);
                    A = new CLEstado(this._tablero[0, 0],
                                     this._tablero[0, 1],
                                     this._tablero[0, 2],
                                     this._tablero[1, 0],
                                     this._tablero[1, 1],
                                     this._tablero[1, 2],
                                     this._tablero[2, 0],
                                     this._tablero[2, 1],
                                     this._tablero[2, 2]);
                    A.nivel = this.nivel + 1;
                    A.padre = this;
                    Respuesta.Add(A);
                    break;
                case "10":
                    A = new CLEstado(this._tablero[0, 1],
                                     this._tablero[0, 0],
                                     this._tablero[0, 2],
                                     this._tablero[1, 0],
                                     this._tablero[1, 1],
                                     this._tablero[1, 2],
                                     this._tablero[2, 0],
                                     this._tablero[2, 1],
                                     this._tablero[2, 2]);
                    A.nivel = this.nivel + 1;
                    A.padre = this;
                    Respuesta.Add(A);

                    A = new CLEstado(this._tablero[0, 0],
                                     this._tablero[0, 1],
                                     this._tablero[0, 2],
                                     this._tablero[1, 1],
                                     this._tablero[1, 0],
                                     this._tablero[1, 2],
                                     this._tablero[2, 0],
                                     this._tablero[2, 1],
                                     this._tablero[2, 2]);
                    A.nivel = this.nivel + 1;
                    A.padre = this;
                    Respuesta.Add(A);

                    A = new CLEstado(this._tablero[0, 0],
                                     this._tablero[0, 1],
                                     this._tablero[0, 2],
                                     this._tablero[2, 0],
                                     this._tablero[1, 1],
                                     this._tablero[1, 2],
                                     this._tablero[1, 0],
                                     this._tablero[2, 1],
                                     this._tablero[2, 2]);
                    A.nivel = this.nivel + 1;
                    A.padre = this;
                    Respuesta.Add(A);
                    break;
                case "11":
                    A = new CLEstado(this._tablero[0, 0],
                                     this._tablero[0, 1],
                                     this._tablero[0, 2],
                                     this._tablero[1, 1],
                                     this._tablero[1, 0],
                                     this._tablero[1, 2],
                                     this._tablero[2, 0],
                                     this._tablero[2, 1],
                                     this._tablero[2, 2]);
                    A.nivel = this.nivel + 1;
                    A.padre = this;
                    Respuesta.Add(A);

                    A = new CLEstado(this._tablero[0, 0],
                                     this._tablero[1, 1],
                                     this._tablero[0, 2],
                                     this._tablero[1, 0],
                                     this._tablero[0, 1],
                                     this._tablero[1, 2],
                                     this._tablero[2, 0],
                                     this._tablero[2, 1],
                                     this._tablero[2, 2]);
                    A.nivel = this.nivel + 1;
                    A.padre = this;
                    Respuesta.Add(A);

                    A = new CLEstado(this._tablero[0, 0],
                                     this._tablero[0, 1],
                                     this._tablero[0, 2],
                                     this._tablero[1, 0],
                                     this._tablero[1, 2],
                                     this._tablero[1, 1],
                                     this._tablero[2, 0],
                                     this._tablero[2, 1],
                                     this._tablero[2, 2]);
                    A.nivel = this.nivel + 1;
                    A.padre = this;
                    Respuesta.Add(A);
                    A = new CLEstado(this._tablero[0, 0],
                                     this._tablero[0, 1],
                                     this._tablero[0, 2],
                                     this._tablero[1, 0],
                                     this._tablero[2, 1],
                                     this._tablero[1, 2],
                                     this._tablero[2, 0],
                                     this._tablero[1, 1],
                                     this._tablero[2, 2]);

                    A.nivel = this.nivel + 1;
                    A.padre = this;
                    Respuesta.Add(A);
                    break;
                case "12":
                    A = new CLEstado(this._tablero[0, 0],
                                     this._tablero[0, 1],
                                     this._tablero[1, 2],
                                     this._tablero[1, 0],
                                     this._tablero[1, 1],
                                     this._tablero[0, 2],
                                     this._tablero[2, 0],
                                     this._tablero[2, 1],
                                     this._tablero[2, 2]);
                    A.nivel = this.nivel + 1;
                    A.padre = this;
                    Respuesta.Add(A);

                    A = new CLEstado(this._tablero[0, 0],
                                     this._tablero[0, 1],
                                     this._tablero[0, 2],
                                     this._tablero[1, 0],
                                     this._tablero[1, 2],
                                     this._tablero[1, 1],
                                     this._tablero[2, 0],
                                     this._tablero[2, 1],
                                     this._tablero[2, 2]);
                    A.nivel = this.nivel + 1;
                    A.padre = this;
                    Respuesta.Add(A);

                    A = new CLEstado(this._tablero[0, 0],
                                     this._tablero[0, 1],
                                     this._tablero[0, 2],
                                     this._tablero[1, 0],
                                     this._tablero[1, 1],
                                     this._tablero[2, 2],
                                     this._tablero[2, 0],
                                     this._tablero[2, 1],
                                     this._tablero[1, 2]);
                    A.nivel = this.nivel + 1;
                    A.padre = this;
                    Respuesta.Add(A);
                    break;
                case "20":
                    A = new CLEstado(this._tablero[0, 0],
                                     this._tablero[0, 1],
                                     this._tablero[0, 2],
                                     this._tablero[2, 0],
                                     this._tablero[1, 1],
                                     this._tablero[1, 2],
                                     this._tablero[1, 0],
                                     this._tablero[2, 1],
                                     this._tablero[2, 2]);
                    A.nivel = this.nivel + 1;
                    A.padre = this;
                    Respuesta.Add(A);
                    A = new CLEstado(this._tablero[0, 0],
                                     this._tablero[0, 1],
                                     this._tablero[0, 2],
                                     this._tablero[1, 0],
                                     this._tablero[1, 1],
                                     this._tablero[1, 2],
                                     this._tablero[2, 1],
                                     this._tablero[2, 0],
                                     this._tablero[2, 2]);
                    A.nivel = this.nivel + 1;
                    A.padre = this;
                    Respuesta.Add(A);
                    break;
                case "21":
                    A = new CLEstado(this._tablero[0, 0],
                                     this._tablero[0, 1],
                                     this._tablero[0, 2],
                                     this._tablero[1, 0],
                                     this._tablero[1, 1],
                                     this._tablero[1, 2],
                                     this._tablero[2, 1],
                                     this._tablero[2, 0],
                                     this._tablero[2, 2]);
                    A.nivel = this.nivel + 1;
                    A.padre = this;
                    Respuesta.Add(A);

                    A = new CLEstado(this._tablero[0, 0],
                                     this._tablero[0, 1],
                                     this._tablero[0, 2],
                                     this._tablero[1, 0],
                                     this._tablero[2, 1],
                                     this._tablero[1, 2],
                                     this._tablero[2, 0],
                                     this._tablero[1, 1],
                                     this._tablero[2, 2]);
                    A.nivel = this.nivel + 1;
                    A.padre = this;
                    Respuesta.Add(A);

                    A = new CLEstado(this._tablero[0, 0],
                                     this._tablero[0, 1],
                                     this._tablero[0, 2],
                                     this._tablero[1, 0],
                                     this._tablero[1, 1],
                                     this._tablero[1, 2],
                                     this._tablero[2, 0],
                                     this._tablero[2, 2],
                                     this._tablero[2, 1]);
                    A.nivel = this.nivel + 1;
                    A.padre = this;
                    Respuesta.Add(A);
                    break;
                case "22":
                    A = new CLEstado(this._tablero[0, 0],
                                     this._tablero[0, 1],
                                     this._tablero[0, 2],
                                     this._tablero[1, 0],
                                     this._tablero[1, 1],
                                     this._tablero[2, 2],
                                     this._tablero[2, 0],
                                     this._tablero[2, 1],
                                     this._tablero[1, 2]);
                    A.nivel = this.nivel + 1;
                    A.padre = this;
                    Respuesta.Add(A);
                    A = new CLEstado(this._tablero[0, 0],
                                     this._tablero[0, 1],
                                     this._tablero[0, 2],
                                     this._tablero[1, 0],
                                     this._tablero[1, 1],
                                     this._tablero[1, 2],
                                     this._tablero[2, 0],
                                     this._tablero[2, 2],
                                     this._tablero[2, 1]);
                    A.nivel = this.nivel + 1;
                    A.padre = this;
                    Respuesta.Add(A);
                    break;
            }
            return Respuesta;
        }

        public bool EsFinal()
        {
            bool res = false;
            if (_tablero[0, 0] == 1 &&
                _tablero[0, 1] == 2 &&
                _tablero[0, 2] == 3 &&
                _tablero[1, 0] == 4 &&
                _tablero[1, 1] == 5 &&
                _tablero[1, 2] == 6 &&
                _tablero[2, 0] == 7 &&
                _tablero[2, 1] == 8 &&
                _tablero[2, 2] == 0)
            {
                res = true;
            }
            return res;
        }

        public bool EsIgual(CLEstado a)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (a.tablero[i, j] != this.tablero[i, j])
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        private static readonly int[,] OBJETIVO =
        {
            { 1, 2, 3 },
            { 8, 0, 4 },
            { 7, 6, 5 }
        };

        private static readonly Dictionary<int, (int fila, int col)> POS_FINAL =
            new Dictionary<int, (int fila, int col)>
            {
                    {1,(0,0)}, {2,(0,1)}, {3,(0,2)},
                    {8,(1,0)},            {4,(1,2)},
                    {7,(2,0)}, {6,(2,1)}, {5,(2,2)}
            };

        public int H1()
        {
            int h1 = 0;
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    if (_tablero[i, j] != 0 && _tablero[i, j] != OBJETIVO[i, j])
                        h1++;
            return h1; 
        }

        public int H2()
        {
            int h2 = 0;
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                {
                    int ficha = _tablero[i, j];
                    if (ficha != 0)
                    {
                        var (fi, ci) = POS_FINAL[ficha];
                        h2 += Math.Abs(i - fi) + Math.Abs(j - ci);
                    }
                }
            return h2; 
        }

        public int H3()
        {
            int s = 0;
            int[] camino =
            {
                _tablero[0,0], _tablero[0,1], _tablero[0,2],
                _tablero[1,2], _tablero[2,2], _tablero[2,1],
                _tablero[2,0], _tablero[1,0]
            };

            for (int i = 0; i < 8; i++)
            {
                int actual = camino[i];
                int siguiente = camino[(i + 1) % 8];
                if (actual != 0)
                {
                    int sucesor = actual == 8 ? 1 : actual + 1;
                    if (siguiente != sucesor)
                        s += 2;
                }
            }

            if (_tablero[1, 1] != 0)
                s++;

            return H2() + (3 * s); 
        }
        public int[,] Tablero { get => _tablero; set => _tablero = value; }
    }
}
