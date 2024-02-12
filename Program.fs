﻿module CS220.Program

/// How many different ways can we make change of a given amount of money in
/// Korean coins? Suppose we have 5 different kinds of coins: 500-won coins,
/// 100-won coins, 50-won coins, 10-won coins, and 1-won coins. Write a function
/// prob2 that takes in an amount of money in won, and returns the number of
/// possible combinations. For example, when the given amount is 10, then the
/// function should return 4, because there are 4 different ways to make change
/// for 10 won: (1) one 10-won, (2) two 5-won, (3) one 5-won and five 1-won, and
/// (4) ten 1-won. The function should return -1 if an errorneous input is given,
/// e.g., when negative amount is given.
let prob1 amount =
  failwith "TODO"

/// Write a function `prob2` that computes GCD (Greatest Common Divisor) of two
/// given integers. This function should return -1 if both inputs are 0.
let prob2 a b =
  failwith "TODO"

/// Write a function `prob3` that takes in a string s and an integer n, and
/// returns a string that repeats s for n times. For example, if "abc" and 3 are
/// given, the function should return "abcabcabc". When n is zero, the function
/// returns an empty string. When n is negative, it returns a string that
/// repeats reversed s for -n times. For example, pow "abc" -3 will return
/// "cbacbacba".
let prob3 s n =
  failwith "TODO"

/// Write a function `prob4` that takes in an unsigned integer n (uint32), and
/// returns the smallest integral divisor of n that is greater than 1. For
/// example, given 45, the function will return 3 (45 % 3 = 0). This function
/// returns 0 for all error cases, e.g., when the given number is 1u.
let prob4 (n: uint32) =
  failwith "TODO"

/// Write a function `prob5` that takes in an unsigned integer as input, and
/// checks if the number is a prime number or not. If the number is prime, then
/// the function returns true. Otherwise, it returns false. Hint: you can use
/// the `prob4` function above.
let prob5 (n: uint32) =
  failwith "TODO"

[<EntryPoint>]
let main _args =
  0