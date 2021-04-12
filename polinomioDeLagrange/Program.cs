using System;

namespace polinomioDeLagrange
{
    class Program
    {
        class calculadora
        {

            /*public void getCalculos(float valx1, float valx2, float valx3, float valx4, float valy1, float valy2, float valy3, float valy4)
            {
                valx1 = vx1;
                valx2 = vx2;
                valx3 = vx3;
                valx4 = vx4;
                valy1 = vy1;
                valy2 = vy2;
                valy3 = vy3;
                valy4 = vy4;

            }*/

            public void polLagrange()
            {
                //puntos en X
                float vx1;
                float vx2;
                float vx3;
                float vx4;

                //puntos en Y
                float vy1;
                float vy2;
                float vy3;
                float vy4;

                Console.WriteLine("Por favor ingrese punto 1 en x: ");
                vx1 = Single.Parse(Console.ReadLine());
                Console.WriteLine("Por favor ingrese punto 2 en x: ");
                vx2 = Single.Parse(Console.ReadLine());
                Console.WriteLine("Por favor ingrese punto 3 en x: ");
                vx3 = Single.Parse(Console.ReadLine());
                Console.WriteLine("Por favor ingrese punto 4 en x: ");
                vx4 = Single.Parse(Console.ReadLine());

                Console.WriteLine("Por favor ingrese punto 1 en y: ");
                vy1 = Single.Parse(Console.ReadLine());
                Console.WriteLine("Por favor ingrese punto 2 en y: ");
                vy2 = Single.Parse(Console.ReadLine());
                Console.WriteLine("Por favor ingrese punto 3 en y: ");
                vy3 = Single.Parse(Console.ReadLine());
                Console.WriteLine("Por favor ingrese punto 4 en y: ");
                vy4 = Single.Parse(Console.ReadLine());

                float dk1, dk2, dk3, dk4;

                dk1 = (vx1 - vx2) * (vx1 - vx3) * (vx1 - vx4);
                dk2 = (vx2 - vx1) * (vx2 - vx3) * (vx2 - vx4);
                dk3 = (vx3 - vx1) * (vx3 - vx2) * (vx3 - vx4);
                dk4 = (vx4 - vx1) * (vx4 - vx2) * (vx4 - vx3);

                Console.WriteLine("---------------------------------------");
                Console.WriteLine("Los valores correspondientes a Dk son: ");

                Console.Write(dk1 + ", ");
                Console.Write(dk2 + ", ");
                Console.Write(dk3 + ", ");
                Console.WriteLine(dk4);
                Console.WriteLine("---------------------------------------");


                //Calculo ax3
                float ax01 = vy1/dk1;
                float ax02 = vy2/dk2;
                float ax03 = vy3/dk3;
                float ax04 = vy4/dk4;

                Console.WriteLine("---------------------------------------");
                Console.WriteLine("Los valores correspondientes a AX3 son: ");
                Console.Write(ax01 + ", ");
                Console.Write(ax02 + ", ");
                Console.Write(ax03 + ", ");
                Console.WriteLine(ax04);
                Console.WriteLine("---------------------------------------");

                //Calculo bx2
                float bx01 = +-(vy1 / dk1)*(vx2+vx3+vx4);
                float bx02 = +-(vy2 / dk2) * (vx1 + vx3 + vx4);
                float bx03 = +-(vy3 / dk3) * (vx1 + vx2 + vx4);
                float bx04 = +-(vy4 / dk4) * (vx1 + vx2 + vx3);

                Console.WriteLine("---------------------------------------");
                Console.WriteLine("Los valores correspondientes a BX2 son: ");
                Console.Write(bx01 + ", ");
                Console.Write(bx02 + ", ");
                Console.Write(bx03 + ", ");
                Console.WriteLine(bx04);
                Console.WriteLine("---------------------------------------");

                //Calculo CX
                float cx01 = (ax01) * (vx2 * vx3 + vx2 * vx4 + vx3 * vx4);
                float cx02 = (ax02) * (vx1 * vx3 + vx1 * vx4 + vx3 * vx4);
                float cx03 = (ax03) * (vx1 * vx2 + vx1 * vx4 + vx2 * vx4);
                float cx04 = (ax04) * (vx1 * vx2 + vx1 * vx3 + vx2 * vx3);

                Console.WriteLine("---------------------------------------");
                Console.WriteLine("Los valores correspondientes a CX son: ");
                Console.Write(cx01 + ", ");
                Console.Write(cx02 + ", ");
                Console.Write(cx03 + ", ");
                Console.WriteLine(cx04);
                Console.WriteLine("---------------------------------------");

                //Calculo d
                float d01 = +-(ax01 * vx2 * vx3 * vx4);
                float d02 = +-(ax02 * vx1 * vx3 * vx4);
                float d03 = +-(ax03 * vx1 * vx2 * vx4);
                float d04 = +-(ax04 * vx1 * vx2 * vx3);

                Console.WriteLine("---------------------------------------");
                Console.WriteLine("Los valores correspondientes a D son: ");
                Console.Write(d01 + ", ");
                Console.Write(d02 + ", ");
                Console.Write(d03 + ", ");
                Console.WriteLine(d04);
                Console.WriteLine("---------------------------------------");

                //Calculo sumatoria

                float sum1 = ax01 + ax02 + ax03 + ax04;
                float sum2 = bx01 + bx02 + bx03 + bx04;
                float sum3 = cx01 + cx02 + cx03 + cx04;
                float sum4 = d01 + d02 + d03 + d04;

                Console.WriteLine("---------------------------------------");
                Console.WriteLine("Los valores correspondientes a las sumatorias son: ");
                Console.WriteLine("Total ax3: " + sum1);
                Console.WriteLine("Total bx2: " + sum2);
                Console.WriteLine("Total cx: " + sum3);
                Console.WriteLine("Total d: " + sum4);
                Console.WriteLine("---------------------------------------");

            }


            static void Main(string[] args)
            {
                Console.WriteLine("---------------------------------------");
                Console.WriteLine("Nombre: Cristian Jocol");
                Console.WriteLine("Carnet: 0901-19-17747");
                Console.WriteLine("---------------------------------------");


                Console.WriteLine("Bienvenido a la calculadora de polinomios de Lagrange...");
                calculadora c = new calculadora();
                c.polLagrange();
            }
        }
    }
}
