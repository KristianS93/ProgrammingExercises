// https://open.kattis.com/problems/quickestimate
// Rust
// Easy
// Quick Estimate

use std::io::stdin;

fn main() {
    let mut input = String::new();
    stdin().read_line(&mut input).unwrap();

    let length = input.trim().parse::<i32>().unwrap();

    let mut result: Vec<usize> = Vec::new();

    for _ in 0..length {
        let mut input = String::new();
        stdin().read_line(&mut input).unwrap();
        result.push(get_result(&input));
    }

    for x in result {
        println!("{}", x);
    }
}

#[warn(clippy::needless_return)]
fn get_result(val: &str) -> usize {
    return val.trim().len();
}

#[cfg(test)]
mod samples {
    use crate::get_result;

    #[test]
    fn sample_one() {
        let result = vec![3, 1, 4, 1, 5];
        let input = vec![
            "314".to_string(),
            "1".to_string(),
            "5926".to_string(),
            "5".to_string(),
            "35897".to_string(),
        ];

        for (index, input_str) in input.iter().enumerate() {
            assert_eq!(get_result(input_str), result[index]);
        }
    }
}
