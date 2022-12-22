// https://open.kattis.com/problems/oddmanout
// Rust
// Easy
// Odd Man Out

use std::{collections::HashMap, io::stdin};

fn main() {
    let mut input = String::new();
    stdin().read_line(&mut input).unwrap();
    // amount of testcases

    let test_cases = input.trim().parse::<i32>().unwrap();

    for n in 0..test_cases {
        let mut input = String::new();
        stdin().read_line(&mut input).unwrap();
        //amount of guest codes //use less
        let mut map: HashMap<String, i32> = HashMap::new();

        let mut input = String::new();
        stdin().read_line(&mut input).unwrap();

        let values = input.split_whitespace().collect::<Vec<&str>>();

        for val in values {
            let key = val.to_string();
            if map.get(&key).is_some() {
                *map.get_mut(&key).unwrap() += 1;
            } else {
                map.insert(key, 1);
            }
        }

        for entry in map {
            if entry.1 == 1 {
                println!("Case #{}: {}", n + 1, entry.0);
            }
        }
    }
}
