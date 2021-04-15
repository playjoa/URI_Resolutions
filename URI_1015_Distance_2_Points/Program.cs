using System;
using Inputs;
using Inputs.Readers;

namespace URI_1015_Distance_2_Points
{
    class Program
    {
        static void Main(string[] args)
        {
            XandY_Reader leitorDe_XY;
            Vector2 ponto_A, ponto_B;
            string linhaLida;
            double tempX, tempY;

            linhaLida = InputSystem.ReadLine();
            leitorDe_XY = new XandY_Reader(linhaLida);
            tempX = leitorDe_XY.LerX();
            tempY = leitorDe_XY.LerY();
            ponto_A = new Vector2(tempX, tempY);

            linhaLida = InputSystem.ReadLine();
            leitorDe_XY.LerOutraLinha(linhaLida);
            tempX = leitorDe_XY.LerX();
            tempY = leitorDe_XY.LerY();
            ponto_B = new Vector2(tempX, tempY);

            Vector2.DebugDistance(ponto_A, ponto_B);

            Console.ReadKey();
        }
    }
}
