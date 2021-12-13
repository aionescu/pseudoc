module Utils.Function

let flip f a b = f b a
let const' a _ = a

let curry f a b = f (a, b)
let uncurry f (a, b) = f a b

let curry3 f a b c = f (a, b, c)
let curry4 f a b c d = f (a, b, c, d)
let curry5 f a b c d e = f (a, b, c, d, e)

let (>..) f g a b = g <| f a b
let (..<) f g = g >.. f

let cons x xs = x :: xs
let swap (a, b) = (b, a)

let rec intercalate sep = function
  | [] -> []
  | [x] -> [x]
  | x :: xs -> x :: sep :: intercalate sep xs
