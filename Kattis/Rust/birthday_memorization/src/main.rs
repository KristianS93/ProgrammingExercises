// https://open.kattis.com/problems/fodelsedagsmemorisering
// Rust
// Easy

use std::{collections::HashMap, io::stdin};

fn main() {
    let mut input = String::new();

    stdin().read_line(&mut input).unwrap();

    let amount_of_input = input.trim().parse::<i32>().unwrap();
    let mut map: HashMap<String, (usize, String)> = HashMap::new();

    for _ in 0..amount_of_input {
        let mut input = String::new();
        stdin().read_line(&mut input).unwrap();

        let split_values: Vec<&str> = input.split_whitespace().collect();
        let name = split_values[0].to_string();
        let val = split_values[1].trim().parse::<usize>().unwrap();
        let date = split_values[2].to_string();

        match map.get(&date) {
            Some((x, _)) => {
                if *x < val {
                    map.insert(date, (val, name));
                }
            }
            None => _ = map.insert(date, (val, name)),
        }
    }
    let mut result: Vec<String> = Vec::new();
    for x in map {
        let val = x.1;
        result.push(val.1);
    }

    result.sort();

    println!("{}", result.len());
    for y in result {
        println!("{}", y);
    }
}

#[cfg(test)]
mod samples {
    use std::collections::HashMap;

    #[test]
    fn sample_one() {
        let amount_of_input = 3;
        let input = vec!["Sanna 1 16/03", "Simon 2 16/03", "Saga 3 14/10"];

        let expected_length = 2;
        let expected_output = vec!["Saga", "Simon"];

        let mut map: HashMap<&str, (usize, &str)> = HashMap::new();

        for n in 0..amount_of_input {
            let split_values: Vec<&str> = input[n].split_whitespace().collect();

            if map.get(split_values[2]).is_some() {
                let entry = map.get(split_values[2]).unwrap();
                if entry.0 < split_values[1].parse::<usize>().unwrap() {
                    entry.0 = split_values[1].parse::<usize>().unwrap()
                }
            }
        }
    }

    #[test]
    fn sample_two() {}

    #[test]
    fn sample_three() {}
}
