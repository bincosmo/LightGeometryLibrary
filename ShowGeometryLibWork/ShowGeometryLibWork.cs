namespace GeometryLibrary.Light;

class ShowGeometryLibWork
{
    static void Main(string[] args)
    {
        byte figureType;
        do 
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Title = "LightGeometry"; 
            Console.WriteLine("LightGeometryLibrary DEMO\n");
            Console.WriteLine("Choose the type of figure:");
            Console.WriteLine("1.Circle\n2.Rectangle\n3.Triangle\n\n9.Autodefinition\n\n0.Exit");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Enter the number of the action:");
            figureType = Convert.ToByte(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Green;
            
            if (figureType == 9)
            {
                double sideValue = default;
                Figure autofigure = new Figure();
                while (sideValue >= 0){
                Console.WriteLine($"Enter the size of the {autofigure.Side.Count + 1} Side:");
                Console.WriteLine($"Enter a negative number for finish input");
                sideValue = Convert.ToDouble(Console.ReadLine());
                if (sideValue >= 0)
                    autofigure.Side.Add(sideValue);
                }  
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine ($"Area: {autofigure.AutoDefinitionArea()}");               
                Console.WriteLine ($"Figure type:{autofigure.figureType}");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Press any key to continue...");
                Console.ReadLine();
                }else if(figureType > 0 && figureType <= 3){
                        Figure figure = new Figure(figureType);
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"\nFigure area:{figure.areaResult}");
                        if(figure.figureType == "Triangle")
                            Console.WriteLine($"Rightangle triangle:{figure.RightTriangle}");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"Press Enter to continue...");
                        Console.ReadLine();
                    }
                    else if (figureType < 0 || figureType > 3){
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Incorrect input. Try again.");
                        Console.ReadLine();
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
        }while(figureType > 0);
    }
}

