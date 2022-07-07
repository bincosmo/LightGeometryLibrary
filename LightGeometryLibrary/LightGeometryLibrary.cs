namespace GeometryLibrary.Light;

public class Figure
{   
    public string? figureType;
    public List<double>Side = new List<double>();
    public bool RightTriangle;
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
              figureType = "Circle";
              Circle circle = new Circle();
              areaResult = circle.Area();
              break;
            case 2: 
              figureType = "Rectangle";
              Rectangle rectangle = new Rectangle();
              areaResult = rectangle.Area();
              break;
            case 3: 
              figureType = "Triangle";
              Triangle triangle = new Triangle();
              areaResult = triangle.Area();  
              RightTriangle = triangle.IsRightAngled();            
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
                Triangle triangle = new Triangle(Side[0], Side[1], Side[2]);
                areaResult = triangle.Area();           
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
    public double SideA { get; set; }
    public double SideB { get; set; }
    public double SideC { get; set; }
    public Triangle()
    {
        AddTriangle();
    }
    public Triangle (double sideA, double sideB, double sideC) 
    {
        SideA = sideA;
        SideB = sideB;
        SideC = sideC;
    }
  
    public void AddTriangle()
    {
        Console.WriteLine("Enter Side A:");
        SideA = Convert.ToDouble(Console.ReadLine()); 
        Console.WriteLine("Enter Side B:");
        SideB = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter Side C:");
        SideC = Convert.ToDouble(Console.ReadLine());
    }
    public double Area(double sideA, double sideB, double sideC)
    { 
        while(SideA + SideB <= SideC || SideA + SideC <= SideB)
        {
            Console.WriteLine("Incorrect input");
            AddTriangle();
        }           
        double s = (sideA + sideB + sideC)/2;
            return Math.Sqrt(s * (s - SideA)*(s - SideB)*(s - SideC));
    }
      public double Area()
    { 
            return Area(SideA,SideB,SideC);
    }
    public bool IsRightAngled(){
        double hypotenuse, leg1, leg2;
        if(SideA > SideB && SideA > SideC)
        {
            hypotenuse = SideA;
            leg1 = SideB;
            leg2 = SideC;
        }  else if (SideB > SideA && SideB > SideC)
                {
                    hypotenuse = SideB;
                    leg1 = SideA;
                    leg2 = SideC;
                } else if (SideC > SideA && SideC > SideB)
                        {
                            hypotenuse = SideC;
                            leg1 = SideA;
                            leg2 = SideB;
                        }
                            else 
                                return false;
        if(hypotenuse == Math.Sqrt((Math.Pow(leg1, 2) + Math.Pow(leg2, 2))))
            return true;
            else 
                return false;
    }

}