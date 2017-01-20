type Details = 
    {
        Name: string
        Description: string
    }

type Item =
    { Details: Details }

type RoomId = 
    | RoomId of string

type Exit =
    | PassableExit of Details * destination: RoomId
    | LockedExit of Details * key:Item *next:Exit
    | NoExit of Details option

type Exits =
    {   
        North: Exit
        South: Exit
        West : Exit
        East : Exit
    }

type Room =
    {
        Id: RoomId
        Details: Details 
        Items: Item list
        Exits: Exits
    }

type Player = 
    {
        Details: Details
        Location: RoomId
        Iventory: Item list
    }

type World = 
    {
        Rooms: Map<RoomId, RoomId>
        Player: Player
    }

// ----------World starts.---------------

//let firstRoom =
//    {
//        Id = 
//        Details = {Name = "first Room "; Description = "You are in First Room"};
//        Items = [];
//        Exits =
//         {
//            North = NoExit(None);
//            South = NoExit(None);
//            West = NoExit(None);
//            East = NoExit(None)
//            }
//     }    


// -----------Logic for thegame -----------
let de