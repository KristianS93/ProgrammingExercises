// https://open.kattis.com/problems/filip
// Rust
// Easy
// Filip

use std::io::stdin;

fn main() {
    let mut i = String::new();
    stdin().read_line(&mut i).unwrap();

    let r = i
        .split_whitespace()
        .map(|x| x.chars().rev().collect::<String>().parse::<i32>().unwrap())
        .collect::<Vec<i32>>();
    if r[0] > r[1] {
        println!("{}", r[0]);
    } else {
        println!("{}", r[1]);
    }
}
