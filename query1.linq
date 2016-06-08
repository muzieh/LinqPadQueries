<Query Kind="FSharpProgram" />

let z = 10
let myf xy =
	
	match xy with
	| 10,_ -> failwith "pierwsze nie moze byc 10"
	| x,y when x < y -> "mniej"
	| x,y when x > y -> "wiecej"
	| _ -> "rowne"
	
let rec concat x =
	match x with head::tile -> head + concat(tile) | [] -> ""


let jabber = ["'Twas "; "brillig, "; "and "; "the "; "slithy "; "toves "; "..."]
printf "%A\n" (myf (11,12))

let con = concat jabber
printf "%A" con

let k = [box 1; box "two"; box 3;box 4]
k.Dump()
let zsd= List.rev k


let rec analyze l =
	printf "current pass: %A\n" l
	match l with 
	| [x;y;z] ->
		printf "last 3 elements %d %d %d\n" x y z
	| 1::2::3::tail -> 
		printf "found sequence 1 2 3\n"
		analyze tail
	| head::tail -> analyze tail
	| [] -> ()
	
let ll =[1;2;3;4;5;6;4;1;2;3;4;3;1;2;3;5;4;5;6]
(List.fold (fun acc ell -> acc + string ell) "" ll).Dump()
type FullName = string * string
let PrintFullName (fn : FullName) = 
	printf "\n%A" fn
	
PrintFullName ("abc", "sd")

type Organ = { boss : string; emploees : string list }
let o = {boss = "tomasz"; emploees = ["jonasz"; "konasz"] }
let o1 = {o with boss = o.boss}
o1.Dump()