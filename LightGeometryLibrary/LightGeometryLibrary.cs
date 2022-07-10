namespace GeometryLibrary.Light;

public class Figure
{   
    public string figureType = "not defined";
    public List<double>Side = new List<double>();
    public bool RightTriangle;
    public double areaResult { get; set; }

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
    //autodefinition of figure
    public double AutoDefinitionOfArea(){
        switch (Side.Count)
        {
            case 1:
                figureType = "Circle";
                Circle circle = new Circle(Side[0]);
                areaResult = circle.Area();               
                break;
            case 2:
                figureType = "Rectangle";
                Rectangle rectangle = new Rectangle(Side[0], Side[1]);
                areaResult = rectangle.Area();             
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
    public double Radius { get; set; }
    public Circle()
    {
        AddCircle();
    }
    public Circle (double radius)
    {
        Radius = radius;
    }
    public void AddCircle()
    {
        Console.WriteLine("Enter radius:");
        Radius = Convert.ToDouble(Console.ReadLine()); 
    }

    public double Area ()
    {              
            return Math.PI * Math.Pow(Radius, 2);
    }
    public double Area (double radius)
    {         
            return Math.PI * Math.Pow(Radius, 2);
    }

}

//Rectangle
public class Rectangle
{
    public double Length { get; set; }
    public double Width { get; set; }
    public Rectangle ()
    {       
        AddRectangle();
    }
    public Rectangle (double length, double width)
    {       
        Length = length;
        Width = width;
    }
    public void AddRectangle()
    {
        Console.WriteLine("Enter length:");
        Length = Convert.ToDouble(Console.ReadLine()); 
        Console.WriteLine("Enter width:");
        Width = Convert.ToDouble(Console.ReadLine());
    }
    public double Area()
    {
            return Length * Width;
    }
    public double Area (double length, double width)
    { 
            return Length * Width;
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
            Console.WriteLine("Incorrect input");
            if (SideA + SideB <= SideC || SideA + SideC <= SideB)
            {
                Console.WriteLine("Incorrect input");
                AddTriangle();
            }        
    }
    public double Area(double sideA, double sideB, double sideC)
    { 
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