
(*
   CS:3820 Programing Language Concepts

   Homework 1


(* Problem 1 *)

type ilist =
    E
  | L of int * ilist

(* sum : ilist -> int *)

let rec sum l =
  match l with
  | E -> 0
  | L(h, t) -> h + sum t
  
sum (L(1, L(3, L(3, E))))
sum E

(* elem : int -> ilist -> int *)

let rec elem n l =
  if n > 0 
  then match l with
       | E -> failwith "Index out of bound"
       | L(h,t) -> if n = 1 then h else elem (n-1) t
  else failwith "Value of n (index) is non-positive"

elem 2 (L(3, L(21, L(11, E))))
elem 4 (L(3, L(21, L(11, E))))
elem 0 (L(3, L(21, L(11, E))))

(* isIn : int -> ilist -> bool *)


(* remove: int -> ilist -> ilist *)


(* move : ilist -> ilist -> ilist *)


(* reverse : ilist -> ilist *)




(* Problem 2 *)

type btree = Leaf of int | Node of btree * int * btree

type finding = NotFound | Found of int


(* size: btree -> int *)


(* leftmost_nl: btree -> finding *)


(* mirror: btree -> btree *)


(* leftReplace: int -> btree -> btree *)


(* toString_nz: btree -> string *)
