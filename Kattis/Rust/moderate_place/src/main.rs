// https://open.kattis.com/problems/moderatepace
// Rust
// Easy
// Moderate Pace

use std::{io::stdin, vec};

fn main() {
    let mut i = String::new();
    stdin().read_line(&mut i).unwrap();

    let days = i.trim().parse::<usize>().unwrap();

    let mut i = String::new();
    stdin().read_line(&mut i).unwrap();
    let my = r(i);

    let mut i = String::new();
    stdin().read_line(&mut i).unwrap();
    let f = r(i);

    let mut i = String::new();
    stdin().read_line(&mut i).unwrap();
    let s = r(i);

    for d in 0..days {
        let mut r = vec![my[d], f[d], s[d]];
        r.sort_unstable();
        print!("{} ", r[1]);
    }
}

fn r(s: String) -> Vec<i32> {
    let i = s
        .split_whitespace()
        .map(|x| x.parse::<i32>().unwrap())
        .collect::<Vec<i32>>();
    i
}
