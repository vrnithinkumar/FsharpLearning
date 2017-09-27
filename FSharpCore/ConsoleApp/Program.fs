// Learn more about F# at http://fsharp.org

open System
open ComputationExpressions.CompExp
[<EntryPoint>]
let main argv =
    printfn "Hello World from F#! \n Val is %A" TestValFromCompExp 
    callLookUp()
    let x = Console.Read()
    0 // return an integer exit code