using IsExpressionWithPatternMatchingExample;

public class Program
{
    public static void Area(Shape aShape)
    {
        if (aShape is Square)
        {
            Square aSquare = new Square();
            double squareResult = aSquare.size * aSquare.size;
            Console.WriteLine(squareResult);
        }
        else if (aShape is Circle)
        {
            Circle aCircle = new Circle();
            double circleResult = aCircle.Radius * aCircle.Radius * Math.PI;
            Console.WriteLine(circleResult);
        }

        else
        {
            throw new InvalidOperationException("Invalid Shape");
        }


    }

    public static void ChangeToUpperCase(object aObject)
    {
        if (aObject is string stringObject)
        {
            if (string.IsNullOrEmpty(stringObject) == false)
            {
                Console.WriteLine(stringObject.ToUpper());
            }
            else
            {
                Console.WriteLine("The string is empty");
            }

        }
        else
        {
            Console.WriteLine("It is not a string");
        }
    }


    public static void Main()
    {
        Circle aCircle = new Circle();
        Area(aCircle);

        string strOne = "Hello there";
        int numberOne = 231;
        object objectOne = strOne;
        object objectTwo = numberOne;
        ChangeToUpperCase(objectOne);
        ChangeToUpperCase(objectTwo);

    }
}