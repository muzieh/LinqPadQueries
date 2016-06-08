<Query Kind="FSharpProgram" />

let N = 3
let S = "GL"

//
type inputStep = Less | More

let availableNumbers = [for i in 0..(N-1) -> i]
let moves = S.ToCharArray() |> Array.toList |> List.map (fun c-> if c = 'G' then Less else More )

let rec processStep e set remainingMoves acc =
    match remainingMoves with
    | [] -> Console.WriteLine("ok") 
            acc + 1 //Good no more steps
    | move::tail ->  //move is next move
                    //find sub elements for ok and not ok
                    let remaining = set |> List.filter (fun el -> el <> e)
                    let getSmaller = remaining |> List.filter (fun el -> el < e)
                    let getBigger = remaining |> List.filter (fun el -> el > e)
                    let okElements = 
                        match move with
                        | Less -> getSmaller
                        | More -> getBigger
                    if okElements.IsEmpty then 
                        acc
                    else
                        //rekursja dla okElements z polaczonymi listami 
                        let inner = okElements
                                        |> List.fold (fun acci e -> acci + (processStep e remaining tail acci)) 0
                        inner + acc
                    
        
    
                     
    


availableNumbers 
    |> List.fold (fun acc e -> acc + (processStep e availableNumbers moves acc)) 0
    |> Dump
    
