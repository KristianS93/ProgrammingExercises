// https://open.kattis.com/problems/cetvrta
// Rust
// Easy
// Cetvrta

use std::{collections::HashMap, io::stdin};

fn main() {
    let mut x: HashMap<i32, i32> = HashMap::new();
    let mut y: HashMap<i32, i32> = HashMap::new();

    for _ in 0..3 {
        let mut i = String::new();
        stdin().read_line(&mut i).unwrap();
        let r = i
            .split_whitespace()
            .map(|x| x.parse::<i32>().unwrap())
            .collect::<Vec<i32>>();
        if x.get(&r[0]).is_some() {
            *x.get_mut(&r[0]).unwrap() += 1;
        } else {
            x.insert(r[0], 1);
        }
        if y.get(&r[1]).is_some() {
            *y.get_mut(&r[1]).unwrap() += 1;
        } else {
            y.insert(r[1], 1);
        }
    }
    for xi in x {
        if xi.1 == 1 {
            print!("{} ", xi.0);
        }
    }
    for yi in y {
        if yi.1 == 1 {
            print!("{}", yi.0);
        }
    }
}

// struct Coord {
//     x: i32,
//     y: i32,
// }

// impl Coord {
//     fn new(x: i32, y: i32) -> Coord {
//         Coord { x, y }
//     }
// }

/*
Logic we are given 3 points, we know it a rectangle
we need to determine which of the x coords does not occure more than once
then match it do the missing y cordinate



*/
