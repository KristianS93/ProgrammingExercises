// https://open.kattis.com/problems/numberfun
// Rust
// Easy
// Number Fun

use std::io::stdin;

fn main() {
    let mut input = String::new();

    stdin().read_line(&mut input).unwrap();

    let cases = input.trim().parse::<i32>().unwrap();

    for _ in 0..cases {
        let mut case = String::new();
        stdin().read_line(&mut case).unwrap();
        // make integers
        let nums = case
            .split_whitespace()
            .map(|x| x.parse::<i32>().unwrap())
            .collect::<Vec<i32>>();

        let div1 = nums[0] / nums[1];
        let div2 = nums[1] / nums[0];

        if nums[0] + nums[1] == nums[2]
            || nums[0] - nums[1] == nums[2]
            || nums[1] - nums[0] == nums[2]
            || nums[0] * nums[1] == nums[2]
            || (div1 == nums[2] && div1 * nums[1] == nums[0])
            || (div2 == nums[2] && div2 * nums[0] == nums[1])
        {
            println!("Possible");
        } else {
            println!("Impossible");
        }
    }
}
