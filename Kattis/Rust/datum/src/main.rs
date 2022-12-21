// https://open.kattis.com/problems/datum
// Rust
// Easy
use std::io::stdin;
fn main() {
    let mut day = 4;
    let mut input = String::new();
    stdin().read_line(&mut input).unwrap();

    let result = input
        .trim()
        .split_whitespace()
        .map(|val| val.parse::<i32>().unwrap())
        .collect::<Vec<i32>>();

    day += (result[0] - 1) + months_to_days(result[1]);
    let switch = day % 7;

    match switch {
        0 => print!("Sunday"),
        1 => print!("Monday"),
        2 => print!("Tuesday"),
        3 => print!("Wednesday"),
        4 => print!("Thursday"),
        5 => print!("Friday"),
        6 => print!("Saturday"),
        _ => print!("error"),
    }
}

fn months_to_days(day: i32) -> i32 {
    match day {
        1 => 0,
        2 => 31,
        3 => 59,
        4 => 90,
        5 => 120,
        6 => 151,
        7 => 181,
        8 => 212,
        9 => 243,
        10 => 273,
        11 => 304,
        _ => 334,
    }
}
