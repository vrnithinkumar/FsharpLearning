let prefix prefixStr baseStr = 
    prefixStr + "," + baseStr

let exclaim s =
    s + " !"
//prefix "Hello" "VR"

let names = ["One";"Two";"Three"]

let intFoo = prefix "ah"
names

|> Seq.map intFoo
|> Seq.map exclaim
|> Seq.sort 


let testing = List.map (fun x -> x * x) [1;2;4]
testing