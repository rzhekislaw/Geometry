namespace Geometry
{
    public class Triangle
    {
        #region Perimeter
        public static double GetPerimeter(double a)
        {
            return a * 3;
        }

        public static double GetPerimeter(double a, double b)
        {
            return a * 2 + b;
        }

        public static double GetPerimeter(double a, double b, double c)
        {
            return a + b + c;
        }
        #endregion

        #region Area
        public static double GetArea(double a, double h)
        {
            return (a + h) / 2;
        }

        public static double GetArea(double a, double b, double c)
        {
            double p = (a + b + c) / 2;
            return (Math.Sqrt(p * (p - a) * (p - b) * (p - c)));
        }

        public static double GetArea(double a, double b, float a_b_Angle)
        {
            return (a * b * Math.Sin(a_b_Angle)) / 2;
        }

        public static double GetArea(double a, double b, double c, double R)
        {
            return (a * b * c) / (R * 4);
        }

        public static double GetArea(double p, float r)
        {
            return p * r;
        }

        #endregion

        #region Volume

        public static double GetTriangularPrismVolume(double S, double h)
        {
            return S * h;
        }

        public static double GetRegularTetrahedronVolume(double a)
        {
            return (Math.Pow(a, 3) * Math.Sqrt(2)) / 12;
        }

        public static double GetRegualPyramidVolume(double S, double h)
        {
            return (S * h) / 3;
        }
        #endregion

    }

    public class Square
    {
        public float a;

        public double d;

        #region Perimeter
        public float GetPerimeter(float a)
        {
            return a * 4;
        }

        public double GetPerimeter(double d)
        {
            return Math.Sqrt(2) * 2 * d;
        }
        #endregion

        #region Area
        public float GetArea(float a)
        {
            return a * a;
        }

        public double GetArea(double d)
        {
            return Math.Pow(d, 2) / 2;
        }
        #endregion

        #region Volume

        public float GetVolume(float a)
        {
            return a * a * a;
        }

        #endregion

    }

    public class Tetragon
    {
        #region Perimeter
        public static double GetPerimeter(params double[] sides)
        {
            double perimeter = 0;
            foreach (var s in sides)
            {
                perimeter += s;
            }
            return perimeter;
        }
        #endregion

        #region Area

        public static double GetArea(double d1, double d2, float d1_d2_angle)
        {
            return (d1 * d2 * Math.Sin(d1_d2_angle)) / 2;
        }

        public static double GetArea(double p, double r)
        {
            return p * r;
        }

        public static double GetArea(double a, double b, double c, double d)
        {
            double p = (a + b + c + d) / 2;
            return Math.Sqrt((p - a) * (p - b) * (p - c) * (p - d));
        }

        public static double GetArea(double a, double b, double c, double d, float opCorner1, float opCorner2)
        {
            double p = (a + b + c + d) / 2;
            float theta = (opCorner1 + opCorner2) / 2;
            return Math.Sqrt((p - a) * (p - b) * (p - c) * (p - d) - (a * b * c * d) * Math.Pow(Math.Cos(theta), 2));
        }

        #endregion

        #region Volume
        public static double GetPrismVolume(double S, double h)
        {
            return S * h;
        }
        #endregion
    }

    public class Rectangle
    {
        #region Perimeter
        public static double GetPerimeter(double a, double b)
        {
            return (a + b) * 2;
        }
        #endregion

        #region Area
        public static double GetArea(double a, double b)
        {
            return a * b;
        }
        #endregion

        #region Volume
        public static double GetVolume(double a, double b, double c)
        {
            return a * b * c;
        }

        public static double GetPyramidVolume(double S, double h)
        {
            return (S * h) / 3;
        }
        #endregion
    }

    public class Rhombus
    {
        #region Perimeter
        public static double GetPerimeter(double a)
        {
            return a * 4;
        }
        #endregion

        #region Area
        public static double GetArea(double a, double h)
        {
            return a * h;
        }

        public static double GetArea(double a, float angle)
        {
            return Math.Pow(a, 2) * Math.Sin(angle);
        }

        public static double GetArea(float d1, float d2)
        {
            return (d1 * d2) / 2;
        }
        #endregion
    }

    public class Parallelogram
    {
        #region Perimeter
        public static double GetPerimeter(double a, double b)
        {
            return (a + b) * 2;
        }
        #endregion

        #region Area
        public static double GetArea(double a, double h)
        {
            return a * h;
        }
        public static double GetArea(double a, double b, float a_b_angle)
        {
            return a * b * Math.Sin(a_b_angle);
        }
        public static double GetArea(float d1, float d2, float d1_d2_angle)
        {
            return (double)(d1 * d2 * Math.Sin(d1_d2_angle)) / 2;
        }
        #endregion

        #region Volume
        public static double GetVolume(double S, double h)
        {
            return S * h;
        }
        #endregion
    }

    public class Trapezoid
    {
        #region Perimeter
        public static double GetPerimeter(params double[] sides)
        {
            double perimeter = 0;
            foreach (var s in sides)
            {
                perimeter += s;
            }
            return perimeter;
        }
        #endregion

        #region Area
        public static double GetArea(double a, double b, double h)
        {
            return (a + b) * h / 2;
        }

        public static double GetArea(double a, double b, double c, double d)
        {
            double p = (a + b + c + d) / 2;
            return (Math.Sqrt((p - a) * (p - b) * (p - a - c) * (p - a - d))) * ((a + b) / (Math.Abs(a - b)));
        }
        #endregion
    }

    public class Circle
    {
        #region Perimeter
        public static double GetPerimeter(double d)
        {
            return Math.PI * d;
        }

        public static double GetPerimeter(float r)
        {
            return Math.PI * 2 * r;
        }
        #endregion

        #region Area
        public static double GetArea(double d)
        {
            return Math.PI * Math.Pow(d, 2) / 4;
        }

        public static double GetArea(float r)
        {
            return Math.PI * r * r;
        }
        #endregion

        #region Volume
        public static double GetVolume(double r)
        {
            return (4 * Math.PI * Math.Pow(r, 3)) / 3;
        }
        #endregion
    }

    public class Ellipse
    {
        #region Perimeter
        public static double GetPerimeter(double a, double b)
        {
            return ((4 * Math.PI * a * b) + (a - b)) / (a + b);
        }
        #endregion

        #region Area
        public static double GetArea(double a, double b)
        {
            return Math.PI * a * b;
        }
        #endregion


    }

    public class Cylinder
    {

        #region Area 
        public static double GetArea(double r, double h)
        {
            return Math.PI * r * h * 2;
        }
        #endregion

        #region Volume
        public static double GetVolume(double S, double h)
        {
            return S * h;
        }

        public static double GetVolume(float r, double h)
        {
            return Math.PI * r * r * h;
        }
        #endregion
    }

    public class Cone
    {
        #region Area
        public static double GetArea(double r, double l)
        {
            return (Math.PI * r * l) + (Math.PI * r * r);
        }
        #endregion

        #region Volume
        public static double GetVolume(double r, double h)
        {
            return (Math.PI * h * r * r) / 3;
        }
        #endregion
    }

    public class ArbitraryFigure
    {
        #region Perimeter
        public static double GetPerimeter(params double[] sides)
        {
            double perimeter = 0;
            foreach (var s in sides)
            {
                perimeter += s;
            }
            return perimeter;
        }
        #endregion
    }
}