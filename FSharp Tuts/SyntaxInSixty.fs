// single line comments use a double slash
(* multi line comments use (* . . . *) pair
-end of multi line comment- *)
// ======== "Variables" (but not really) ==========
// The "let" keyword defines an (immutable) value
let myInt = 5
let myFloat = 3.14
let myString = "hello" //note that no types needed
let x = myFloat+ (float)myInt

// =========Lists=========== 
let listTwoToFive = [2;3;4;5] // Its semicolumn not comma 
listTwoToFive |> List.iter (fun x -> printfn "List item : %d" x)

let oneToFive = 1 :: listTwoToFive
let zeroToFive = [0;1] @ listTwoToFive // @ will concate the list.
// IMPORTANT: commas are never used as delimiters, only semicolons!

// =========Functions=========== 
// The "let" keyword also defines a named function.
let square x = x * x        // Note that no parens are used.
square 3                    // Now run the function. Again, no parens.
let add x y = x + y         // don't use add (x,y)! It means something completely different.
let w  = add 2 3            // Now run the function.
printfn "sum of two and fice is %d" (add 2 5)

// to define a multiline function, just use indents. No semicolons needed.
let evens list =
    let isEven x = x%2 = 0       // Define "isEven" as an inner ("nested") function
    List.filter isEven list      // List.filter is a library function
                                 // with two parameters: a boolean function
                                 // and a list to work on

evens oneToFive |> List.iter(fun x -> printfn "even : %d" x) // Now run the function


printfn "What is this"