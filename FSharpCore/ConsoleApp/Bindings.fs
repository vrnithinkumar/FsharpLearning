namespace BindingTest
// Testing the bindings with let use and do
module Bindings =
    let dummyDispose name =
        {new System.IDisposable 
            with member this.Dispose() = printfn "Disposing the %s" name}
    let disposeTest =
        use myDisp = dummyDispose "Testing Disp"
        printfn "Done disposeTest method"


    let pipeInto (expr, foo) =
        printfn "We are loging expr : %A" expr
        expr |> foo
    
    pipeInto( 42, fun x ->
    pipeInto( 43, fun y ->
    pipeInto(x+y, fun z ->
    z
    )))