namespace GeometryLibrary.Light;

public class Figure
{   public string? figureType;
    public List<double>Side = new List<double>();
    private double area;
    public double areaResult
    {
        get { return area; }
        set { area = value; }
    }

    public Figure()
    {
    }
    public Figure (byte figure)
    {
        switch(figure)
        {
            case 1: 
              Circle circle = new Circle();
              areaResult = circle.Area();
              break;
            case 2: 
              Rectangle rectangle = new Rectangle();
              areaResult = rectangle.Area();
              break;
            case 3: 
              Triangle triangle = new Triangle();
              areaResult = triangle.Area();              
              break;
        }
    }
    //autodefinition
    public double AutoDefinitionArea(){
        switch (Side.Count)
        {
            case 1:
                figureType = "Circle";
                Circle circle = new Circle();
                areaResult = circle.Area(Side[0]);               
                break;
            case 2:
                figureType = "Rectangle";
                Rectangle rectangle = new Rectangle();
                areaResult = rectangle.Area(Side[0], Side[1]);             
                break;
            case 3:
                figureType = "Triangle";
                Triangle triangle = new Triangle();
                areaResult = triangle.Area(Side[0], Side[1], Side[2]);           
                break;
            default:
                Console.WriteLine("Error input");
                break;
        }
       return areaResult;
    }
    

}

//Circle
public class Circle
{        
    public Circle()
    {
    }
     public Circle(double radius)
    {
        Console.WriteLine(Area(radius));
    }

    public double Area ()
    {        
        Console.WriteLine("Enter radius:");
        double radius = Convert.ToDouble(Console.ReadLine());  
            return Math.PI * Math.Pow(radius, 2);
    }
    public double Area (double radius)
    {         
            return Math.PI * Math.Pow(radius, 2);
    }

}

//Rectangle
public class Rectangle
{
    public Rectangle ()
    {       
    }
    public Rectangle (double length, double width)
    {
        Area(length, width);
    }
    public double Area()
    {
        Console.WriteLine("Enter length:");
        double length = Convert.ToDouble(Console.ReadLine()); 
        Console.WriteLine("Enter width:");
        double width = Convert.ToDouble(Console.ReadLine());
            return length * width;
    }
    public double Area (double length, double width)
    { 
            return length * width;
    }
}

//Triangle
public class Triangle
{
    public Triangle()
    {
    }
    public Triangle (double sideA, double sideB, double sideC)
    {
        Area(sideA, sideB, sideC);
    }
    
    public double Area()
    { 
        Console.WriteLine("Enter Side A:");
        double sideA = Convert.ToDouble(Console.ReadLine()); 
        Console.WriteLine("Enter Side B:");
        double sideB = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter Side C:");
        double sideC = Convert.ToDouble(Console.ReadLine());
        double s = (sideA + sideB + sideC)/2; //semiperimeter
            return Math.Sqrt(s * (s - sideA)*(s - sideB)*(s -sideC));
    }
    //Heron's formula is used to calculate the area 
    public double Area (double sideA, double sideB, double sideC)
    { 
        double s = (sideA + sideB + sideC)/2; //semiperimeter
            return Math.Sqrt(s * (s - sideA)*(s - sideB)*(s -sideC));
    }
}