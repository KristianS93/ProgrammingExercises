// https://open.kattis.com/problems/bijele
// Rust
// Easy
// Bijele

use std::io::stdin;

fn main() {
    let mut i = String::new();
    stdin().read_line(&mut i).unwrap();

    let desired_values: Vec<i32> = vec![1, 1, 2, 2, 2, 8];

    let r = i
        .split_whitespace()
        .map(|num| num.parse::<i32>().unwrap())
        .collect::<Vec<i32>>();

    let mut result: Vec<i32> = Vec::new();
    for n in 0..desired_values.len() {
        result.push(-(*r.get(n).unwrap() - *desired_values.get(n).unwrap()));

        // 0 - 1 = -1 => +
        // 2 - 1 = 1 => -1
        // 3 - 1 = 2 => -2
        // hvis det er plus *-1
        // Hvis det er negative * -1
    }

    print!(
        "{} {} {} {} {} {}",
        result[0], result[1], result[2], result[3], result[4], result[5]
    );
}

// Sample 1: 0 1 2 2 2 7 -> 1 0 0 0 0 1
// Sample 2: 2 1 2 1 2 1 -> -1 0 0 1 0 7

#[cfg(test)]
mod samples {
    #[test]
    fn sample_one() {}

    #[test]
    fn sample_two() {}

    #[test]
    fn sample_three() {}
}
