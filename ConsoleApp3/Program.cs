namespace ConsoleApp3 {
    internal class Program {
        static void Main(string[] args) {
            //AufDie100();
            //xxxxxxxxx();
            //Schleife2Mal();
            //Pyramide();
            GanzePyramide();
           Console.ReadKey();



          
        }
        public static void AufDie100() {
            int result = 0;
            for (int i = 1; i<= 100; i++) 
            { 
            result = result+ i;
            }
           Console.WriteLine(result); 
        }
        public static void xxxxxxxxx() 
        { 
            for (int i = 0; i<=10; i++)
            {
                Console.Write("xxxxxx\n");
            }
        }
        public static void Schleife2Mal() 
        {
           for ( int l = 0; l <= 6; l++)
           { 

            for (int i = 0; i <= 10; i++) 
            {
                Console.Write('x');
            }
            Console.WriteLine("");
           }
        }   
        public static void Pyramide() 
        {
            for (int l = 0; l <= 14; l++) {
                 //(int k = 1; k <= 10; k++)
                 {
                    for (int i = 0; i <= l ; i++) {
                        Console.Write('x');
                    }
                }
                
                Console.WriteLine("");
            }
        }
        public static void GanzePyramide() 
        {
            for (int l = 0; l <= 12; l++) {
                for (int w = 12)
                {
                    Console.Write(" ");
                    for (int i = 0; i <= l; i++) {
                        
                        Console.Write('x');
                    }
                }

                Console.WriteLine("");
            }
        }
    }
}