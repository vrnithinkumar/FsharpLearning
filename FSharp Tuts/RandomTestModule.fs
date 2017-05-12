module RandomTest =
    let addOne x = x+1
    /// Tests if an integer value is odd via modulo.
    let isOdd x = x % 2 <> 0
    let listOfNumber = [1..100]
    let oddNumb = 
        listOfNumber 
        |> List.filter isOdd
    printfn "Od vals %A" oddNumb 