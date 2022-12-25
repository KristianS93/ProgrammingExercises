// https://open.kattis.com/problems/oddities
// Rust
// Easy
// Oddities

use std::io::stdin;

fn main() {
    let mut i = String::new();
    stdin().read_line(&mut i).unwrap();

    for _ in 0..i.trim().parse::<i32>().unwrap() {
        let mut i = String::new();
        stdin().read_line(&mut i).unwrap();
        let r = i.trim().parse::<i32>().unwrap();
        if r % 2 == 0 {
            println!("{} is even", r);
        } else {
            println!("{} is odd", r);
        }
    }
}

/* Maybe research if it is possible to do while read_line would trim down the code */
