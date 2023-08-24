// https://open.kattis.com/problems/keylogger
// Rust
// Easy
// Keylogger

use std::{collections::HashMap, io::stdin};

fn main() {
    let mut map: HashMap<String, String> = HashMap::new();
    let inputs = vec![
        ("clank".to_string(), "a".to_string()),
        ("bong".to_string(), "b".to_string()),
        ("click".to_string(), "c".to_string()),
        ("tap".to_string(), "d".to_string()),
        ("poing".to_string(), "e".to_string()),
        ("clonk".to_string(), "f".to_string()),
        ("clack".to_string(), "g".to_string()),
        ("ping".to_string(), "h".to_string()),
        ("tip".to_string(), "i".to_string()),
        ("cloing".to_string(), "j".to_string()),
        ("tic".to_string(), "k".to_string()),
        ("cling".to_string(), "l".to_string()),
        ("bing".to_string(), "m".to_string()),
        ("pong".to_string(), "n".to_string()),
        ("clang".to_string(), "o".to_string()),
        ("pang".to_string(), "p".to_string()),
        ("clong".to_string(), "q".to_string()),
        ("tac".to_string(), "r".to_string()),
        ("boing".to_string(), "s".to_string()),
        ("boink".to_string(), "t".to_string()),
        ("cloink".to_string(), "u".to_string()),
        ("rattle".to_string(), "v".to_string()),
        ("clock".to_string(), "w".to_string()),
        ("toc".to_string(), "x".to_string()),
        ("clink".to_string(), "y".to_string()),
        ("tuc".to_string(), "z".to_string()),
        ("whack".to_string(), " ".to_string()),
        ("bump".to_string(), String::new()),
        ("pop".to_string(), String::new()),
        ("dink".to_string(), String::new()),
        ("thumb".to_string(), String::new()),
    ];

    for input in inputs {
        map.insert(input.0, input.1);
    }

    let mut input: String = String::new();
    stdin().read_line(&mut input).unwrap();
    let click = input.trim().parse::<usize>().unwrap();
    let mut caps_lock = false;
    let mut shift_active = false;

    let mut result_scope: Vec<String> = Vec::new();

    for _ in 0..click {
        let mut input: String = String::new();
        stdin().read_line(&mut input).unwrap();

        let value = map.get_key_value(&input.trim().to_string());
        match value {
            Some((x, y)) => match (x.as_str(), y.as_str()) {
                ("whack", "") => result_scope.push(" ".to_string()),
                ("bump", "") => caps_lock = !caps_lock,
                ("pop", "") => {
                    if !result_scope.is_empty() {
                        result_scope.pop();
                    }
                }
                ("dink", "") => shift_active = true,
                ("thumb", "") => shift_active = false,
                _ => {
                    if (caps_lock && !shift_active) || (!caps_lock && shift_active) {
                        result_scope.push(y.clone().to_uppercase());
                    } else {
                        result_scope.push(y.clone());
                    }
                }
            },
            None => continue,
        }
    }

    for x in result_scope {
        print!("{}", x);
    }
}

// let mut result: Vec<(String, String)> = inputs
// .clone()
// .into_iter()
// .filter(|(x, _)| x.eq(&input.trim()))
// .map(|(x, y)| {
//     if (caps_lock && !shift_active) || (!caps_lock && shift_active) {
//         return (x, y.to_uppercase());
//     }
//     return (x, y);
// })
// .collect();
// let temp = result.pop().unwrap();

// match (temp.0.as_str(), temp.1.as_str()) {
// ("whack", "") => result_scope.push(" ".to_string()),
// ("bump", "") => caps_lock = !caps_lock,
// ("pop", "") => {
//     if !result_scope.is_empty() {
//         result_scope.pop();
//     }
// }
// ("dink", "") => shift_active = true,
// ("thumb", "") => shift_active = false,
// _ => result_scope.push(temp.1),
// }
