<Query Kind="FSharpProgram" />

let a = [1..3]
let rnd = new System.Random();
let rndFileName() =
    let start = System.IO.Path.GetRandomFileName().Substring(0,7)
    start + "@testdomain.testo.com"
    
let b = a |> List.map (fun e -> rndFileName())

b.Dump()
