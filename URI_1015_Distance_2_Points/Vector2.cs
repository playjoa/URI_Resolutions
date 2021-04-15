using System;

public class Vector2
{
    public double x;
    public double y;

    public Vector2(double x, double y)
    {
        this.x = x;
        this.y = y;
    }

    public static double Distance(Vector2 point_A, Vector2 point_B)
    {
        double x_Difference_SQR = Math.Pow(point_A.x - point_B.x, 2);
        double y_Difference_SQR = Math.Pow(point_A.y - point_B.y, 2);

        return Math.Sqrt(x_Difference_SQR + y_Difference_SQR);
    }

    public static void DebugDistance(Vector2 point_A, Vector2 point_B)
    {
        double distance_A_B = Distance(point_A, point_B);
        Console.WriteLine(distance_A_B.ToString("0.0000"));
    }
}