
public class Modo{

    public static bool Juego;

    public static void Select(){

        Console.Clear();
        Console.WriteLine();
        Console.WriteLine("//////////////////////");
        Console.WriteLine("Seleccione el Modo:");
        Console.WriteLine("1vs1:  1");
        Console.WriteLine("2vs2:  2");
        Console.WriteLine("//////////////////////");

        var keyInfo = Console.ReadKey();

        if(keyInfo.KeyChar == '1')
            Juego = true;
        if (keyInfo.KeyChar == '2')
            Juego = false;

    }

}

public class Picks{

    public static Stack<int> Fichas = new Stack<int>();
    public static Stack<int> EquipoBuenos = new Stack<int>();
    public static Stack<int> EquipoMalo = new Stack<int>();
    public static void SelectEquipo(){
        
        Console.Clear();
        Console.WriteLine();
        Console.WriteLine("//////////////////////");
        Console.WriteLine("Seleccione su equipo:");
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
            

        if(Modo.Juego){ // 1v1
        if (x == 'B'){

            Console.Clear();
    
            Console.WriteLine("//////////////////////");
            Console.WriteLine("   Equipo de Mario");
            Console.WriteLine("//////////////////////");
            Console.WriteLine("=> Mario: 1");
            Console.WriteLine("=> Yoshi: 2");
            Console.WriteLine("=> Hongo: 3");
            Console.WriteLine("=> Luigi: 4");
            Console.WriteLine("=> Peach: 5");
            Console.WriteLine("//////////////////////");

            for(int c=1; c<=3; c++){ 

                var keyInfo = Console.ReadKey();
                Console.Clear();
            
                Console.WriteLine("//////////////////////");
                Console.WriteLine("   Equipo de Mario");
                Console.WriteLine("//////////////////////");
                Console.WriteLine("=> Mario: 1");
                Console.WriteLine("=> Yoshi: 2");
                Console.WriteLine("=> Hongo: 3");
                Console.WriteLine("=> Luigi: 4");
                Console.WriteLine("=> Peach: 5");
                Console.WriteLine("//////////////////////");

                if(keyInfo.KeyChar == '1'){
                    Fichas.Push(24);
                    EquipoBuenos.Push(24);
                    Console.WriteLine("Ficha "+c+": "+ Program.Player[24].Name);
                }
                    
                if(keyInfo.KeyChar == '2'){
                    Fichas.Push(21);
                    EquipoBuenos.Push(21);
                    Console.WriteLine("Ficha "+c+": "+ Program.Player[21].Name);
                }
                    
                if(keyInfo.KeyChar == '3'){
                    Fichas.Push(25);
                    EquipoBuenos.Push(25);
                    Console.WriteLine("Ficha "+c+": "+ Program.Player[25].Name);
                }
                    
                if(keyInfo.KeyChar == '4'){
                    Fichas.Push(23);
                    EquipoBuenos.Push(23);
                    Console.WriteLine("Ficha "+c+": "+ Program.Player[23].Name);
                }
                    
                if(keyInfo.KeyChar == '5'){
                    Fichas.Push(29);
                    EquipoBuenos.Push(29);
                    Console.WriteLine("Ficha "+c+": "+ Program.Player[29].Name);
                }
                    
            }

            Thread.Sleep(2000);
            Console.Clear();
            
            return 0;

        }

        if (x == 'M'){

            Console.Clear();
            
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
                    EquipoMalo.Push(22);
                    Console.WriteLine("Ficha "+c+": "+ Program.Player[22].Name);
                }
                    
                if(keyInfo.KeyChar == '2'){
                    Fichas.Push(26);
                    EquipoMalo.Push(26);
                    Console.WriteLine("Ficha "+c+": "+ Program.Player[26].Name);
                }
                    
                if(keyInfo.KeyChar == '3'){
                    Fichas.Push(28);
                    EquipoMalo.Push(28);
                    Console.WriteLine("Ficha "+c+": "+ Program.Player[28].Name);
                }
                    
                if(keyInfo.KeyChar == '4'){
                    Fichas.Push(20);
                    EquipoMalo.Push(20);
                    Console.WriteLine("Ficha "+c+": "+ Program.Player[20].Name);
                }
                    
                if(keyInfo.KeyChar == '5'){
                    Fichas.Push(27);
                    EquipoMalo.Push(27);
                    Console.WriteLine("Ficha "+c+": "+ Program.Player[27].Name);
                }
                    

            }

            Thread.Sleep(2000);
            Console.Clear();
            
            return 0;

        }

    } else { // 2v2


if (x == 'B'){

            Console.Clear();
    
            Console.WriteLine("//////////////////////");
            Console.WriteLine("   Equipo de Mario");
            Console.WriteLine("//////////////////////");
            Console.WriteLine("=> Mario: 1");
            Console.WriteLine("=> Yoshi: 2");
            Console.WriteLine("=> Hongo: 3");
            Console.WriteLine("=> Luigi: 4");
            Console.WriteLine("=> Peach: 5");
            Console.WriteLine("//////////////////////");

            for(int c=1; c<=4; c++){ 

                var keyInfo = Console.ReadKey();
                Console.Clear();
            
                Console.WriteLine("//////////////////////");
                Console.WriteLine("   Equipo de Mario");
                Console.WriteLine("//////////////////////");
                Console.WriteLine("=> Mario: 1");
                Console.WriteLine("=> Yoshi: 2");
                Console.WriteLine("=> Hongo: 3");
                Console.WriteLine("=> Luigi: 4");
                Console.WriteLine("=> Peach: 5");
                Console.WriteLine("//////////////////////");

                if(keyInfo.KeyChar == '1'){
                    Fichas.Push(24);
                    EquipoBuenos.Push(24);
                    Console.WriteLine("Ficha "+c+": "+ Program.Player[24].Name);
                }
                    
                if(keyInfo.KeyChar == '2'){
                    Fichas.Push(21);
                    EquipoBuenos.Push(21);
                    Console.WriteLine("Ficha "+c+": "+ Program.Player[21].Name);
                }
                    
                if(keyInfo.KeyChar == '3'){
                    Fichas.Push(25);
                    EquipoBuenos.Push(25);
                    Console.WriteLine("Ficha "+c+": "+ Program.Player[25].Name);
                }
                    
                if(keyInfo.KeyChar == '4'){
                    Fichas.Push(23);
                    EquipoBuenos.Push(23);
                    Console.WriteLine("Ficha "+c+": "+ Program.Player[23].Name);
                }
                    
                if(keyInfo.KeyChar == '5'){
                    Fichas.Push(29);
                    EquipoBuenos.Push(29);
                    Console.WriteLine("Ficha "+c+": "+ Program.Player[29].Name);
                }
                    
            }

            Thread.Sleep(2000);
            Console.Clear();
            
            return 0;

        }

        if (x == 'M'){

            Console.Clear();
            
            Console.WriteLine("//////////////////////");
            Console.WriteLine("  Equipo de Browser");
            Console.WriteLine("//////////////////////");
            Console.WriteLine("=> Koopa:   1");
            Console.WriteLine("=> Browser: 2");
            Console.WriteLine("=> Wario:   3");
            Console.WriteLine("=> Waluigi: 4");
            Console.WriteLine("=> Tortuga: 5");
            Console.WriteLine("//////////////////////");


            for(int c=1; c<=4; c++){ 
                
                var keyInfo = Console.ReadKey();
                Console.Clear();
                
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
                    EquipoMalo.Push(22);
                    Console.WriteLine("Ficha "+c+": "+ Program.Player[22].Name);
                }
                    
                if(keyInfo.KeyChar == '2'){
                    Fichas.Push(26);
                    EquipoMalo.Push(26);
                    Console.WriteLine("Ficha "+c+": "+ Program.Player[26].Name);
                }
                    
                if(keyInfo.KeyChar == '3'){
                    Fichas.Push(28);
                    EquipoMalo.Push(28);
                    Console.WriteLine("Ficha "+c+": "+ Program.Player[28].Name);
                }
                    
                if(keyInfo.KeyChar == '4'){
                    Fichas.Push(20);
                    EquipoMalo.Push(20);
                    Console.WriteLine("Ficha "+c+": "+ Program.Player[20].Name);
                }
                    
                if(keyInfo.KeyChar == '5'){
                    Fichas.Push(27);
                    EquipoMalo.Push(27);
                    Console.WriteLine("Ficha "+c+": "+ Program.Player[27].Name);
                }
                    

            }

            Thread.Sleep(2000);
            Console.Clear();
            
            return 0;

        }

    } return 0;

        
    }

}
