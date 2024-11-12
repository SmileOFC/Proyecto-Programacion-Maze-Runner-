public class Picks{

    public static Stack<int> Fichas = new Stack<int>();

    public static void SelectEquipo(){
        
        Console.Clear();
        Console.WriteLine();
        Console.WriteLine("//////////////////////");
        Console.WriteLine("Sleccione su equipo:");
        Console.WriteLine("Buenos: 1");
        Console.WriteLine("Malos:  2");
        Console.WriteLine("//////////////////////");
        var keyInfo = Console.ReadKey();

        if(keyInfo.KeyChar == '1'){
            
            SelectFichas('B');
            SelectFichas('M');

        }

        if(keyInfo.KeyChar == '2'){
            
            SelectFichas('M');
            SelectFichas('B');

        }
    }

    static int SelectFichas(char x){
            
        
        if (x == 'B'){

            Console.Clear();
            Console.WriteLine("//////////////////////");
            Console.WriteLine("Sleccione su equipo:");
            Console.WriteLine("Buenos: 1");
            Console.WriteLine("Malos:  2");
            Console.WriteLine("//////////////////////");
            Console.WriteLine("   Equipo de Mario");
            Console.WriteLine("//////////////////////");
            Console.WriteLine("=> Super Mario: 1");
            Console.WriteLine("=> Yoshi: 2");
            Console.WriteLine("=> Hongo: 3");
            Console.WriteLine("=> Luigi: 4");
            Console.WriteLine("=> Peach: 5");
            Console.WriteLine("//////////////////////");

            for(int c=1; c<=3; c++){ 

                var keyInfo = Console.ReadKey();
                Console.Clear();
                Console.WriteLine("//////////////////////");
                Console.WriteLine("Sleccione su equipo:");
                Console.WriteLine("Buenos: 1");
                Console.WriteLine("Malos:  2");
                Console.WriteLine("//////////////////////");
                Console.WriteLine("   Equipo de Mario");
                Console.WriteLine("//////////////////////");
                Console.WriteLine("=> Super Mario: 1");
                Console.WriteLine("=> Yoshi: 2");
                Console.WriteLine("=> Hongo: 3");
                Console.WriteLine("=> Luigi: 4");
                Console.WriteLine("=> Peach: 5");
                Console.WriteLine("//////////////////////");

                if(keyInfo.KeyChar == '1'){
                    Fichas.Push(24);
                    Console.WriteLine("Ficha "+c+": "+ Ficha.Name(24));
                }
                    
                if(keyInfo.KeyChar == '2'){
                    Fichas.Push(21);
                    Console.WriteLine("Ficha "+c+": "+ Ficha.Name(21));
                }
                    
                if(keyInfo.KeyChar == '3'){
                    Fichas.Push(25);
                    Console.WriteLine("Ficha "+c+": "+ Ficha.Name(25));
                }
                    
                if(keyInfo.KeyChar == '4'){
                    Fichas.Push(23);
                    Console.WriteLine("Ficha "+c+": "+ Ficha.Name(23));
                }
                    
                if(keyInfo.KeyChar == '5'){
                    Fichas.Push(29);
                    Console.WriteLine("Ficha "+c+": "+ Ficha.Name(29));
                }
                    
            }

            Thread.Sleep(2000);
            Console.Clear();
            
            return 0;

        }

        if (x == 'M'){

            Console.Clear();
            Console.WriteLine("//////////////////////");
            Console.WriteLine("Sleccione su equipo:");
            Console.WriteLine("Buenos: 1");
            Console.WriteLine("Malos:  2");
            Console.WriteLine("//////////////////////");
            Console.WriteLine("  Equipo de Browser");
            Console.WriteLine("//////////////////////");
            Console.WriteLine("=> Koopa:   1");
            Console.WriteLine("=> Browser: 2");
            Console.WriteLine("=> Wario:   3");
            Console.WriteLine("=> Waluigi: 4");
            Console.WriteLine("=> Tortuga: 5");
            Console.WriteLine("//////////////////////");


            for(int c=1; c<=3; c++){ 
                
                var keyInfo = Console.ReadKey();
                Console.Clear();
                Console.WriteLine("//////////////////////");
                Console.WriteLine("Sleccione su equipo:");
                Console.WriteLine("Buenos: 1");
                Console.WriteLine("Malos:  2");
                Console.WriteLine("//////////////////////");
                Console.WriteLine("  Equipo de Browser");
                Console.WriteLine("//////////////////////");
                Console.WriteLine("=> Koopa:   1");
                Console.WriteLine("=> Browser: 2");
                Console.WriteLine("=> Wario:   3");
                Console.WriteLine("=> Waluigi: 4");
                Console.WriteLine("=> Tortuga: 5");
                Console.WriteLine("//////////////////////");
            
                if(keyInfo.KeyChar == '1'){
                    Fichas.Push(22);
                    Console.WriteLine("Ficha "+c+": "+ Ficha.Name(22));
                }
                    
                if(keyInfo.KeyChar == '2'){
                    Fichas.Push(26);
                    Console.WriteLine("Ficha "+c+": "+ Ficha.Name(26));
                }
                    
                if(keyInfo.KeyChar == '3'){
                    Fichas.Push(28);
                    Console.WriteLine("Ficha "+c+": "+ Ficha.Name(28));
                }
                    
                if(keyInfo.KeyChar == '4'){
                    Fichas.Push(20);
                    Console.WriteLine("Ficha "+c+": "+ Ficha.Name(20));
                }
                    
                if(keyInfo.KeyChar == '5'){
                    Fichas.Push(27);
                    Console.WriteLine("Ficha "+c+": "+ Ficha.Name(27));
                }
                    

            }

            Thread.Sleep(2000);
            Console.Clear();
            
            return 0;

        }

        return 0;
        
    }

}
