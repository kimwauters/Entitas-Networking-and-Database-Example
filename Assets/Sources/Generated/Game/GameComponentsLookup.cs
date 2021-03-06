//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentLookupGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public static class GameComponentsLookup {

    public const int ClientConnected = 0;
    public const int Database = 1;
    public const int Destroyed = 2;
    public const int Health = 3;
    public const int InputRequest = 4;
    public const int NetworkID = 5;
    public const int Position = 6;
    public const int UpdateDatabase = 7;
    public const int User = 8;

    public const int TotalComponents = 9;

    public static readonly string[] componentNames = {
        "ClientConnected",
        "Database",
        "Destroyed",
        "Health",
        "InputRequest",
        "NetworkID",
        "Position",
        "UpdateDatabase",
        "User"
    };

    public static readonly System.Type[] componentTypes = {
        typeof(ClientConnected),
        typeof(DatabaseComponent),
        typeof(DestroyedComponent),
        typeof(HealthComponent),
        typeof(InputRequestComponent),
        typeof(NetworkIDComponent),
        typeof(PositionComponent),
        typeof(UpdateDatabaseComponent),
        typeof(UserComponent)
    };
}
