using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba_IA_Lara
{
    public partial class FRMOchoPuzle : Form
    {
        private bool EstadoInicial = false;
        private List<CLEstado> Resolver;
        private int ContResolver = 0;

        private int contador = 0;
        private String posicionCeroX;
        private String[,] posiciones;
        public FRMOchoPuzle()
        {
            InitializeComponent();
        }


        private void LBL21_Click(object sender, EventArgs e)
        {
            if (LBL22.Text == "0")
            {
                LBL22.Text = LBL21.Text;
                LBL21.Text = "0";
            }

            if (LBL20.Text == "0")
            {
                LBL20.Text = LBL21.Text;
                LBL21.Text = "0";
            }

            if (LBL11.Text == "0")
            {
                LBL11.Text = LBL21.Text;
                LBL21.Text = "0";
            }
        }

        private void LBL11_Click(object sender, EventArgs e)
        {
            if (LBL21.Text == "0")
            {
                LBL21.Text = LBL11.Text;
                LBL11.Text = "0";
            }

            if (LBL10.Text == "0")
            {
                LBL10.Text = LBL11.Text;
                LBL11.Text = "0";
            }

            if (LBL12.Text == "0")
            {
                LBL12.Text = LBL11.Text;
                LBL11.Text = "0";
            }
            if (LBL01.Text == "0")
            {
                LBL01.Text = LBL11.Text;
                LBL11.Text = "0";
            }
        }

        private void LBL20_Click(object sender, EventArgs e)
        {
            if (LBL21.Text == "0")
            {
                LBL21.Text = LBL20.Text;
                LBL20.Text = "0";
            }

            if (LBL10.Text == "0")
            {
                LBL10.Text = LBL20.Text;
                LBL20.Text = "0";
            }
        }

        private void LBL22_Click(object sender, EventArgs e)
        {
            if (LBL21.Text == "0")
            {
                LBL21.Text = LBL22.Text;
                LBL22.Text = "0";
            }

            if (LBL12.Text == "0")
            {
                LBL12.Text = LBL22.Text;
                LBL22.Text = "0";
            }
        }

        private void LBL12_Click(object sender, EventArgs e)
        {
            if (LBL22.Text == "0")
            {
                LBL22.Text = LBL12.Text;
                LBL12.Text = "0";
            }

            if (LBL11.Text == "0")
            {
                LBL11.Text = LBL12.Text;
                LBL12.Text = "0";
            }

            if (LBL02.Text == "0")
            {
                LBL02.Text = LBL12.Text;
                LBL12.Text = "0";
            }
        }

        private void LBL10_Click(object sender, EventArgs e)
        {
            if (LBL0.Text == "0")
            {
                LBL0.Text = LBL10.Text;
                LBL10.Text = "0";
            }

            if (LBL11.Text == "0")
            {
                LBL11.Text = LBL10.Text;
                LBL10.Text = "0";
            }

            if (LBL20.Text == "0")
            {
                LBL20.Text = LBL10.Text;
                LBL10.Text = "0";
            }
        }

        private void LBL0_Click(object sender, EventArgs e)
        {
            if (LBL10.Text == "0")
            {
                LBL10.Text = LBL0.Text;
                LBL0.Text = "0";
            }

            if (LBL01.Text == "0")
            {
                LBL01.Text = LBL0.Text;
                LBL0.Text = "0";
            }
        }

        private void LBL02_Click(object sender, EventArgs e)
        {
            if (LBL12.Text == "0")
            {
                LBL12.Text = LBL02.Text;
                LBL02.Text = "0";
            }

            if (LBL01.Text == "0")
            {
                LBL01.Text = LBL02.Text;
                LBL02.Text = "0";
            }
        }

        private void LBL01_Click(object sender, EventArgs e)
        {
            if (LBL11.Text == "0")
            {
                LBL11.Text = LBL01.Text;
                LBL01.Text = "0";
            }

            if (LBL0.Text == "0")
            {
                LBL0.Text = LBL01.Text;
                LBL01.Text = "0";
            }

            if (LBL02.Text == "0")
            {
                LBL02.Text = LBL01.Text;
                LBL01.Text = "0";
            }
        }

        private void BTNDesordenar_Click(object sender, EventArgs e)
        {
            TMReloj.Enabled = true;
        }

        private void TMReloj_Tick(object sender, EventArgs e)
        {
            posiciones = new string[3, 3];

            posiciones[0, 0] = LBL0.Text;
            posiciones[0, 1] = LBL01.Text;
            posiciones[0, 2] = LBL02.Text;
            posiciones[1, 0] = LBL10.Text;
            posiciones[1, 1] = LBL11.Text;
            posiciones[1, 2] = LBL12.Text;
            posiciones[2, 0] = LBL20.Text;
            posiciones[2, 1] = LBL21.Text;
            posiciones[2, 2] = LBL22.Text;



            if (contador < 50)
            {
                contador++;
                LBLContador.Text = contador.ToString();

                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (posiciones[i, j] == "0")
                        {
                            posicionCeroX = i.ToString() + j.ToString();
                        }

                    }
                }

                Random rn = new Random();
                int aleatorio = 0;
                switch (posicionCeroX)
                {
                    case "00":
                        aleatorio = rn.Next(1, 3);
                        if (aleatorio == 1)
                        {
                            LBL0.Text = LBL10.Text;
                            LBL10.Text = "0";
                        }
                        else
                        {
                            LBL0.Text = LBL01.Text;
                            LBL01.Text = "0";
                        }

                        break;
                    case "01":

                        aleatorio = rn.Next(1, 4);
                        if (aleatorio == 1)
                        {
                            LBL01.Text = LBL0.Text;
                            LBL0.Text = "0";
                        }
                        else
                        {
                            if (aleatorio == 2)
                            {
                                LBL01.Text = LBL11.Text;
                                LBL11.Text = "0";
                            }
                            else
                            {
                                LBL01.Text = LBL02.Text;
                                LBL02.Text = "0";

                            }
                        }

                        break;
                    case "02":
                        aleatorio = rn.Next(1, 3);
                        if (aleatorio == 1)
                        {
                            LBL02.Text = LBL01.Text;
                            LBL01.Text = "0";
                        }
                        else
                        {
                            LBL02.Text = LBL12.Text;
                            LBL12.Text = "0";
                        }

                        break;
                    case "10":
                        aleatorio = rn.Next(1, 4);
                        if (aleatorio == 1)
                        {
                            LBL10.Text = LBL0.Text;
                            LBL0.Text = "0";
                        }
                        else
                        {
                            if (aleatorio == 2)
                            {
                                LBL10.Text = LBL11.Text;
                                LBL11.Text = "0";
                            }
                            else
                            {
                                LBL10.Text = LBL20.Text;
                                LBL20.Text = "0";

                            }
                        }

                        break;
                    case "11":
                        aleatorio = rn.Next(1, 5);
                        if (aleatorio == 1)
                        {
                            LBL11.Text = LBL01.Text;
                            LBL01.Text = "0";
                        }
                        else
                        {
                            if (aleatorio == 2)
                            {
                                LBL11.Text = LBL12.Text;
                                LBL12.Text = "0";

                            }
                            else
                            {
                                if (aleatorio == 3)
                                {
                                    LBL11.Text = LBL21.Text;
                                    LBL21.Text = "0";
                                }
                                else
                                {
                                    LBL11.Text = LBL10.Text;
                                    LBL10.Text = "0";

                                }
                            }
                        }

                        break;
                    case "12":
                        aleatorio = rn.Next(1, 4);
                        if (aleatorio == 1)
                        {
                            LBL12.Text = LBL02.Text;
                            LBL02.Text = "0";
                        }
                        else
                        {
                            if (aleatorio == 2)
                            {
                                LBL12.Text = LBL11.Text;
                                LBL11.Text = "0";
                            }
                            else
                            {
                                LBL12.Text = LBL22.Text;
                                LBL22.Text = "0";

                            }
                        }

                        break;
                    case "20":
                        aleatorio = rn.Next(1, 3);
                        if (aleatorio == 1)
                        {
                            LBL20.Text = LBL10.Text;
                            LBL10.Text = "0";
                        }
                        else
                        {
                            LBL20.Text = LBL21.Text;
                            LBL21.Text = "0";
                        }

                        break;
                    case "21":
                        aleatorio = rn.Next(1, 4);
                        if (aleatorio == 1)
                        {
                            LBL21.Text = LBL20.Text;
                            LBL20.Text = "0";
                        }
                        else
                        {
                            if (aleatorio == 2)
                            {
                                LBL21.Text = LBL11.Text;
                                LBL11.Text = "0";
                            }
                            else
                            {
                                LBL21.Text = LBL22.Text;
                                LBL22.Text = "0";

                            }
                        }

                        break;
                    case "22":

                        aleatorio = rn.Next(1, 3);
                        if (aleatorio == 1)
                        {
                            LBL22.Text = LBL21.Text;
                            LBL21.Text = "0";
                        }
                        else
                        {
                            LBL22.Text = LBL12.Text;
                            LBL12.Text = "0";
                        }

                        break;
                }

            }
            else
            {
                TMReloj.Enabled = false;
                MessageBox.Show("Reloj apagado");
                LBLContador.Text = "";
                contador = 0;
            }
        }


        private void BTNEsFinal_Click(object sender, EventArgs e)
        {
            CLEstado Inicial = new CLEstado(Convert.ToInt32(LBL0.Text),
                                            Convert.ToInt32(LBL01.Text),
                                            Convert.ToInt32(LBL02.Text),
                                            Convert.ToInt32(LBL10.Text),
                                            Convert.ToInt32(LBL11.Text),
                                            Convert.ToInt32(LBL12.Text),
                                            Convert.ToInt32(LBL20.Text),
                                            Convert.ToInt32(LBL21.Text),
                                            Convert.ToInt32(LBL22.Text)
                                            );
            if (Inicial.EsFinal())
            {
                MessageBox.Show("ES el estado FINAL");
            }
            else
            {
                MessageBox.Show("NO ES el estado FINAL");
            }
        }

        private void BTNAnchuraPrioritaria_Click(object sender, EventArgs e)
        {
            CLEstado Inicial = new CLEstado(Convert.ToInt32(LBL0.Text),
                                            Convert.ToInt32(LBL01.Text),
                                            Convert.ToInt32(LBL02.Text),
                                            Convert.ToInt32(LBL10.Text),
                                            Convert.ToInt32(LBL11.Text),
                                            Convert.ToInt32(LBL12.Text),
                                            Convert.ToInt32(LBL20.Text),
                                            Convert.ToInt32(LBL21.Text),
                                            Convert.ToInt32(LBL22.Text)
                                            );
            List<CLEstado> Resultado = CLAlgoritmosDeBusqueda.AnchuraPrioritaria(Inicial);

            if (Resultado.Count > 0)
            {

                MessageBox.Show("Solución Encontrada en "+ Resultado.Count + " pasos");
                TMReloj.Stop();        
                Resolver = Resultado;
                ContResolver = 0;
                TMResolver.Start();

            }
            else
            { MessageBox.Show("Solucion No Encontrada"); }


        }

        private void BTNGenerarHijos_Click(object sender, EventArgs e)
        {
            CLEstado Inicial = new CLEstado(Convert.ToInt32(LBL0.Text),
                                            Convert.ToInt32(LBL01.Text),
                                            Convert.ToInt32(LBL02.Text),
                                            Convert.ToInt32(LBL10.Text),
                                            Convert.ToInt32(LBL11.Text),
                                            Convert.ToInt32(LBL12.Text),
                                            Convert.ToInt32(LBL20.Text),
                                            Convert.ToInt32(LBL21.Text),
                                            Convert.ToInt32(LBL22.Text)
                                            );
            List<CLEstado> Hijos = Inicial.GenerarHijos();
            FRMHijos A = new FRMHijos();
            A.Hijos = Hijos;
            A.ShowDialog();
        }

        private void TMResolver_Tick(object sender, EventArgs e)
        {
            if (ContResolver < Resolver.Count)
            {
                LBL0.Text = Resolver[ContResolver].tablero[0, 0].ToString();
                LBL01.Text = Resolver[ContResolver].tablero[0, 1].ToString();
                LBL02.Text = Resolver[ContResolver].tablero[0, 2].ToString();
                LBL10.Text = Resolver[ContResolver].tablero[1, 0].ToString();
                LBL11.Text = Resolver[ContResolver].tablero[1, 1].ToString();
                LBL12.Text = Resolver[ContResolver].tablero[1, 2].ToString();
                LBL20.Text = Resolver[ContResolver].tablero[2, 0].ToString();
                LBL21.Text = Resolver[ContResolver].tablero[2, 1].ToString();
                LBL22.Text = Resolver[ContResolver].tablero[2, 2].ToString();
                ContResolver++;
            }
            else
            {
                TMResolver.Stop();

                if (!EstadoInicial)
                {
                    EstadoInicial = true;
                    Resolver.Reverse();
                    ContResolver = 0;
                    MessageBox.Show("Volviendo al Esado Inicial");
                    TMResolver.Start();
                }
            }

        }

        private void TMProfLimitada_Tick(object sender, EventArgs e)
        {
            if (ContResolver < Resolver.Count)
            {
                LBL0.Text = Resolver[ContResolver].tablero[0, 0].ToString();
                LBL01.Text = Resolver[ContResolver].tablero[0, 1].ToString();
                LBL02.Text = Resolver[ContResolver].tablero[0, 2].ToString();
                LBL10.Text = Resolver[ContResolver].tablero[1, 0].ToString();
                LBL11.Text = Resolver[ContResolver].tablero[1, 1].ToString();
                LBL12.Text = Resolver[ContResolver].tablero[1, 2].ToString();
                LBL20.Text = Resolver[ContResolver].tablero[2, 0].ToString();
                LBL21.Text = Resolver[ContResolver].tablero[2, 1].ToString();
                LBL22.Text = Resolver[ContResolver].tablero[2, 2].ToString();
                ContResolver++;
            }
            else
            {
                TMProfLimitada.Stop();

                if (!EstadoInicial)
                {
                    EstadoInicial = true;
                    Resolver.Reverse();
                    ContResolver = 0;
                    MessageBox.Show("Volviendo al Esado Inicial Pro");
                    TMProfLimitada.Start();
                }
            }
        }

        private void BTNProfundidadLimitada_Click(object sender, EventArgs e)
        {
            int Limite = Convert.ToInt32(NUDLimite.Text);
            CLEstado Inicial = new CLEstado(Convert.ToInt32(LBL0.Text),
                                            Convert.ToInt32(LBL01.Text),
                                            Convert.ToInt32(LBL02.Text),
                                            Convert.ToInt32(LBL10.Text),
                                            Convert.ToInt32(LBL11.Text),
                                            Convert.ToInt32(LBL12.Text),
                                            Convert.ToInt32(LBL20.Text),
                                            Convert.ToInt32(LBL21.Text),
                                            Convert.ToInt32(LBL22.Text)
                                            );
            List<CLEstado> Resultado = CLAlgoritmosDeBusqueda.ProfundidadLimitada(Inicial, Limite);

            MessageBox.Show("El limite es " + Limite);

            if (Resultado.Count <= Limite+1)
            {

                MessageBox.Show("Solución Encontrada en " + (Resultado.Count - 1) + " pasos");
                TMReloj.Stop();
                Resolver = Resultado;
                ContResolver = 0;
                TMProfLimitada.Start();

            }
            else
            { MessageBox.Show("Solucion fuera de Limite"); }
        }
    }
}
