type Details = 
    {
        Name: string
        Description:string
    }
type Item =
    {
        Details: Details
    }

type Exit =
    | PassableExit of Details * destination: Room
    | LockedExit of Details * key:Item *next:Exit
    | NoExit of Details option

and Exits =
    {   
        North: Exit
        South: Exit
        West : Exit
        East : Exit
    }

and Room =
    {
        Details: Details 
        Items: Item list
        Exits: Exits
    }

let firstRoom =
    {
        Details = {Name = "first Room "; Description = "You are in First Room"};
        Items = [];
        Exits =
         {
            North = NoExit(None);
            South = NoExit(None);
            West = NoExit(None);
            East = NoExit(None)
            }
     }    