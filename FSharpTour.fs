let sampleFunction2 x:int = 2*x*x - x/5 + 3
let z = sampleFunction2 4
let x = ((1,3,5),4)

let foo = [1,2,3]
let bar = [1;2;3]


printfn "val z is %A " (1,2,3)

let string1 = "Hello F#"
let subString = string1.[0]
let subString2 = string1.[0..4]
printfn "sub string is %s " subString2
let swapElems (aq, bq) = (bq, aq)
printfn "The result of swapping (1, 2) is %A" (swapElems (1,2))
let tuple2 = (1, "fred", 3.1415)

let sampleStructTuple = struct (1, 2)
//let thisWillNotCompile: (int*int) = struct (1, 2)

/// Squares a value.
let square x = x * x

/// Adds 1 to a value.
let addOne x = x + 1
let isOdd x = x % 2 <> 0

let xdr = square >> addOne
let squareOddValuesAndAddOneComposition = 
    List.filter isOdd >> List.map (square >> addOne)
let array2 = [| "hello"; "world"; "and"; "hello"; "world"; "again" |]
array2.[1] <- "qweqwe"

printfn "%A " array2

let list2 = [ 1; 2; 3 ]

let print =
    printfn "we"
let xp = print 
printf "print %A" xp
let rec loopTest n =
    match n with
    | 0 -> printfn "End"
    | i ->
        printfn "%d" i
        loopTest(n - 1)

loopTest 5000


let ProductN n =
    let iniVal = 1
    let action iniVal x = iniVal * x
    [1..n] |> List.fold action iniVal
ProductN 5

let product n = 
    let initialValue = 1
    let action productSoFar x = productSoFar * x
    [1..n] |> List.fold action initialValue

let sum    