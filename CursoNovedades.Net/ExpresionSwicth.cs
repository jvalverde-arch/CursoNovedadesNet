using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoNovedades.Net
{
    public  class ExpresionSwicth
    {
        public ExpresionSwicth()
        {

        }
        public void ImprimirMedida(double measurement)
        {
            switch (measurement)
            {
                case < 0.0:
                    Console.WriteLine($"El valor medido  {measurement}; es muy bajo.");
                    break;

                case > 15.0:
                    Console.WriteLine($"El valor medido  {measurement}; es muy alto.");
                    break;

                case double.NaN:
                    Console.WriteLine("Falla al medir.");
                    break;

                default:
                    Console.WriteLine($"El valor medido es  {measurement}.");
                    break;
            }
        }


        public void AsignarDiaSwitchTradicional(int numero)
        {
            string dia = "";

            switch (numero)
            {
                case 1:
                    dia = "Lunes";
                    break;
                case 2:
                    dia = "Martes";
                    break;
                case 3:
                    dia = "Miércoles";
                    break;
                case 4:
                    dia = "Jueves";
                    break;
                case 5:
                    dia = "Viernes";
                    break;
                case 6:
                    dia = "Sábado";
                    break;
                case 7:
                    dia = "Domingo";
                    break;
                default:
                    dia = "Dia ingresado incorreco";
                    break;
            }
            Console.WriteLine("{0}", dia);
        }
        public void AsignarDiaExpresionSwitchl(int numero)
        {
            string dia = "";

            dia = numero switch
            {
                 
                1 => "Lunes",
                2 => "Martes",
                3 => "Miércoles",
                4 => "Jueves",
                5 => "Viernes",
                6 => "Sábado",
                7 => "Domingo",
                _ => "Día ingresado incorrecto"
            };
            Console.WriteLine("{0}", dia);
        }

        public void AsignarDiaExpresionSwitchl(int numero, string horario)
        {
            string dia = "";

            dia =  (numero, horario) switch
            {

                (1,"diurno") => "Laboral",
                (2, "diurno") => "Laboral",
                (3, "diurno") => "Laboral",
                (3, "nocturno") => "No laboral",
                (4, "diurno") => "No laboral",
                (5, "diurno") => "Laboral",
                (6, "diurno") => "Laboral",
                _ => "Día  y turno no disponible"
            };
            Console.WriteLine("{0}", dia);
        }


        //Expresión Switch en Funciones
        public enum Direction
        {
            Up,
            Down,
            Right,
            Left
        }

        public enum Orientation
        {
            North,
            South,
            East,
            West
        }

        public static Orientation ToOrientation(Direction direction) => direction switch
        {
            Direction.Up => Orientation.North,
            Direction.Down => Orientation.South,
            Direction.Right => Orientation.East,
            Direction.Left => Orientation.West,
            _=> throw new ArgumentOutOfRangeException(nameof(direction), $"Valor de dirección no esperado: {direction}"),

        };

        public static Orientation ToOrientation(Direction direction, Orientation orientation) => (direction, orientation) switch
        {
            (Direction.Up, Orientation.East) => Orientation.North,
            (Direction.Down, Orientation.West) => Orientation.South,
            (Direction.Right,Orientation.South) => Orientation.East,
            (Direction.Left, Orientation.East) => Orientation.West,
            _ => throw new ArgumentOutOfRangeException(nameof(direction), $"Valor de dirección no esperado: {direction}"),

        };


        //Case Guards
        public readonly struct Point
        {

            public Point(int x, int y) => (X, Y) = (x, y);

            public int X { get; }
            public int Y { get; }

        }

        public Point Transform(Point point) => point switch
        {
            { X: 0, Y: 0 } => new Point(0, 0),
            { X: var x, Y: var y } when x < y => new Point(x + y, y),
            { X: var x, Y: var y } when x > y => new Point(x - y, y),
            { X: var x, Y: var y } => new Point(2 * x, 2 * y),
            
        };


    }
}
