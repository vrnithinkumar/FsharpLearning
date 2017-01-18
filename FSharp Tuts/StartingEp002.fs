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
    | LockedExit of Details * key:Item
    | NoExit

type Exits =
    {   
        North: Exit
        South: Exit
        West : Exit
        East : Exit
    }
    


type Room =
    {
        Details: Details 
        Exits: Exits
    }
