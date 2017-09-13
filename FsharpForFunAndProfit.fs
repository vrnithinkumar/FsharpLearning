let sumOfOdd n =
    [1..n]
    |> List.filter (fun x -> x%2<>0)
    |> List.sum
// Test 
let x = sumOfOdd 10
printfn "%d" x

let listMatcher listToMatch =
    match listToMatch with
    | [] -> printfn "Empty list"
    | [sing] -> printfn "Single element : %A" sing
    | [first;second] -> printfn "first : %A second : %A" first second
    | _ -> printfn "many elements"

listMatcher []
listMatcher [1]
listMatcher [1;2]
listMatcher [1;2;3;4]

type Suit = Club | Diamond | Spade | Heart
type Rank = Two | Three | Four | Five | Six | Seven | Eight 
            | Nine | Ten | Jack | Queen | King | Ace

let compareCard card1 card2 = 
    if card1 < card2 
    then printfn "%A is greater than %A" card2 card1 
    else printfn "%A is greater than %A" card1 card2

let aceHearts = Heart, Ace
let twoHearts = Heart, Two
let aceSpades = Spade, Ace

compareCard aceHearts twoHearts 
compareCard twoHearts aceSpades