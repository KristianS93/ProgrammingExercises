// https://open.kattis.com/problems/pet
// Rust
// Easy
// Pet

use std::io::stdin;

fn main() {
    let mut i = 0;
    let mut p = 0;

    for n in 1..=5 {
        let mut s = String::new();
        stdin().read_line(&mut s).unwrap();

        let r = s
            .split_whitespace()
            .map(|x| x.parse::<i32>().unwrap())
            .sum::<i32>();
        if r > p {
            i = n;
            p = r;
        }
    }

    print!("{} {}", i, p);
}
