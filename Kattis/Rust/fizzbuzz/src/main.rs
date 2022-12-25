// https://open.kattis.com/problems/fizzbuzz
// Rust
// Easy
// Fizz Buzz

use std::io::stdin;

fn main() {
    let mut i = String::new();
    stdin().read_line(&mut i).unwrap();

    let r = i
        .split_whitespace()
        .map(|x| x.parse::<i32>().unwrap())
        .collect::<Vec<i32>>();

    for n in 1..=r[2] {
        if n % r[0] == 0 && n % r[1] == 0 {
            println!("FizzBuzz");
        } else if n % r[0] == 0 {
            println!("Fizz");
        } else if n % r[1] == 0 {
            println!("Buzz");
        } else {
            println!("{}", n);
        }
    }
}
