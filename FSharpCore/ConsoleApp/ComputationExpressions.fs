namespace ComputationExpressions
module CompExp =
    let map1 = [ ("1","One"); ("2","Two") ] |> Map.ofList
    let map2 = [ ("A","Alice"); ("B","Bob") ] |> Map.ofList
    let map3 = [ ("CA","California"); ("NY","New York") ] |> Map.ofList
    let TestValFromCompExp = 45

    // Chains of "or else" tests.
    let lookUpInMaps key =
        match map1.TryFind key with
        | Some res1 -> Some res1        
        | None ->
            printfn "Did not find in map1"
            match map2.TryFind key with
            | Some res2 -> Some res2
            | None ->
                printfn "Did not find in map2"
                match map3.TryFind key with
                | Some res3 -> Some res3
                | None -> 
                    printfn "Did not find in map3"
                    None
    
    let callLookUp() = 
        lookUpInMaps "A" |> printfn "Result for A is %A" 
        lookUpInMaps "CA" |> printfn "Result for CA is %A" 
        lookUpInMaps "X" |> printfn "Result for X is %A"