using Spectre.Console;
public class Selects {

    public static string SelectEscalera(){

        Console.WriteLine("");
        var Select = AnsiConsole.Prompt(
                            new SelectionPrompt<string>()
                            .Title("Seleccione donde poner la escalera: ")
                            .PageSize(3)
                            .AddChoices(new[] { "Arriba", "Abajo", "Izquierda","Derecha" })
                        );

                        

        return Select;

        
    }

    public static string SelectPlayerBuenos()
    {

        Console.WriteLine("");
        var Select = AnsiConsole.Prompt(
                            new SelectionPrompt<string>()
                            .Title("Seleccione una ficha: ")
                            .PageSize(3)
                            .AddChoices(new[] { "Mario", "Luigi", "Hongo", "Yoshi", "Peach" })
                        );

                        

        return Select;
    }

    public static string SelectPlayerMalos()
    {

        Console.WriteLine("");    
        var Select = AnsiConsole.Prompt(
                           new SelectionPrompt<string>()
                           .Title("Seleccione una ficha: ")
                           .PageSize(3)
                           .AddChoices(new[] { "Bowser", "DonKeyKong", "Koopa", "Waluigi", "Wario" })
                       );

        return Select;
    }

    public static string SelectY_N(){

        var Select = AnsiConsole.Prompt(

                        new SelectionPrompt<string>()
                        .Title("───── [Red1]Abrir cofre[/] ────────────────────────")
                        .PageSize(3)
                                         .AddChoices(new[] { "Si", "No" })
                    );

        return Select;
    }

    public static string AvanzarY_N(){

        var Select = AnsiConsole.Prompt(

                            new SelectionPrompt<string>()
                                      .Title("──── [Red1]Desea Avanzar[/]? ────────────────────────")
                            .PageSize(3)

                            .AddChoices(new[] { "Si", "No" })
                        );

        return Select;
    }

}
