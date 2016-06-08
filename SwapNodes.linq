<Query Kind="FSharpProgram" />

type 'a Tree = Unset | Empty | Node of 'a * 'a  Tree * 'a Tree

//let input = [(2,3); (-1,4); (-1,5); (-1,-1);(-1,-1)]
let input = [(2,3); (4,5)]

let traverse tree =
	let rec loop tree acc = 
		match tree with
		| Empty | Unset -> acc
		| Node(a,lt,rt) -> 
			loop lt (a::(loop rt acc))
	loop tree []
	
let printLevel nodeValue elem tree =
	let rec loop tree  =
		let al, ar = elem
		match tree with
		| Empty -> Empty
		| Unset -> Unset
		| Node(a, Unset, Unset) when a = nodeValue -> 
			let buildNode aa = if aa = -1 then Empty else Node(aa, Unset, Unset)
			Node(a, buildNode al, buildNode ar)
		| Node(a, Unset, Unset) -> tree
		| Node(a, lt, rt)  -> Node(a, (loop lt), (loop rt))
			
	loop tree
	
//let tree = Node(1, Node(2,Empty, Empty), Node(3,Node(5,Unset,Empty), Empty))
let tree = Node(1, Unset, Unset)
//
//tree
//	|> traverse
//	|> Dump
let proc tree el =
	let addToNode = 
		let rec loop subtree =
			match subtree with
			| Empty | Unset -> []
			| Node(a, Unset, Unset) -> [a]
			| Node(a, lt, rt) -> (loop lt) @ (loop rt))
	
		(loop tree)
			|> List.min
			
	printLevel addToNode el tree



input 
	|> List.fold (fun acc el -> (proc acc el) ) tree
	|> traverse
	|> Dump
	
