using System;

class PointInsideACircleAndOutsideOfARectangle
{
    static void Main()
    {
        Console.Write("Enter the point's x coordinate: ");
        double pointXCoordinate = double.Parse(Console.ReadLine());
        Console.Write("Enter the point's y coordinate: ");
        double pointYCoordinate = double.Parse(Console.ReadLine());
        int circleCenterXCoordinate = 1;
        int circleCenterYCoordinate = 1;
        double circleRadius = 1.5;
        bool pointIsInCircle = false;
        bool pointIsInRectangle = false;
        int rectangleTopLeftX = -1;
        int rectangleTopLeftY = 1;
        int rectangleWidth = 6;
        int rectangleHeight = 2;

        if (Math.Pow((pointXCoordinate - circleCenterXCoordinate), 2) + Math.Pow((pointYCoordinate - circleCenterYCoordinate), 2) <= Math.Pow(circleRadius, 2))
        {
            pointIsInCircle = true;
        }

        if (pointXCoordinate >= rectangleTopLeftX
            && pointXCoordinate <= rectangleTopLeftX + rectangleWidth
            && pointYCoordinate <= rectangleTopLeftY
            && pointYCoordinate >= rectangleTopLeftY - rectangleHeight)
        {
            pointIsInRectangle = true;
        }

        if (pointIsInCircle && !pointIsInRectangle)
        {
            Console.WriteLine("Point ({0}; {1}) is within the circle and outside the rectangle.", pointXCoordinate, pointYCoordinate);
        }
        else
        {
            Console.WriteLine("Point ({0}; {1}) is somewhere else.", pointXCoordinate, pointYCoordinate);
        }
    }
}