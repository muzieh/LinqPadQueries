<Query Kind="FSharpProgram" />

let pattern = @"*.pdf"
let outputDir = @"G:\pdf\"
let FilesInDir dir =
    try
        Directory.GetFiles(dir, pattern)
    with
        | :? (Exception) as ex -> [||]
        

let CopyFile file =
    let fileName = Path.GetFileName file
    let newFileNameWithPath = Path.Combine(outputDir, fileName)
    try
        printfn "copying %s" file
        File.Copy(file, newFileNameWithPath)
    with
        | :? (Exception) as ex -> printfn "%s exists" fileName
        

let searchPath = @"d:\"
//let dirs = Array.append [|searchPath|] (Directory.GetDirectories(searchPath)) 

let rec pd dir acc =
    let files = FilesInDir dir
    let newAcc = Array.append acc files
    try
        let dirsInside = Directory.GetDirectories(dir)
        Array.fold (fun acc diri -> pd diri acc) newAcc dirsInside
    with
        | :? (Exception) as ex -> 
            printfn "something wrong with the path %s" dir
            newAcc
        
    
    
let files = pd searchPath [||]

files.Dump()
                
files |> Array.iter (fun file -> CopyFile file)