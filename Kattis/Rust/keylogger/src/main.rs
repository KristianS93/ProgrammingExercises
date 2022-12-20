// https://open.kattis.com/problems/keylogger
// Rust
// Easy

use std::io::stdin;

fn main() {
    let mut input: String = String::new();
    stdin().read_line(&mut input).unwrap();
    let click = input.trim().parse::<usize>().unwrap();
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
        ("whack".to_string(), String::new()),
        ("bump".to_string(), String::new()),
        ("pop".to_string(), String::new()),
        ("dink".to_string(), String::new()),
        ("thumb".to_string(), String::new()),
    ];

    let mut caps_lock = false;
    let mut shift_active = false;

    let mut result_scope: Vec<String> = Vec::new();

    for _ in 0..click {
        let mut input: String = String::new();
        stdin().read_line(&mut input).unwrap();

        let mut result: Vec<(String, String)> = inputs
            .clone()
            .into_iter()
            .filter(|(x, _)| x.eq(&input.trim()))
            .map(|(x, y)| {
                if (caps_lock && !shift_active) || (!caps_lock && shift_active) {
                    return (x, y.to_uppercase());
                }
                return (x, y);
            })
            .collect();
        let temp = result.pop().unwrap();

        match (temp.0.as_str(), temp.1.as_str()) {
            ("whack", "") => result_scope.push(" ".to_string()),
            ("bump", "") => caps_lock = !caps_lock,
            ("pop", "") => {
                if !result_scope.is_empty() {
                    result_scope.pop();
                }
            }
            ("dink", "") => shift_active = true,
            ("thumb", "") => shift_active = false,
            _ => result_scope.push(temp.1),
        }
    }

    for x in result_scope {
        print!("{}", x);
    }
}

// #[warn(clippy::needless_return)]
// fn match_char(char: String, caps_lock: &bool, shift_active: &bool) -> String {
//     // let inputs = vec![("clank".to_string(),"a".to_string()), "bong".to_string(), "click".to_string(),
//     // "tap".to_string(), "poing".to_string(), "clonk".to_string(), "clack".to_string(),
//     // "ping".to_string(), "tip".to_string(), "cloing".to_string(), "tic".to_string(),
//     // "cling".to_string(), "bing".to_string(), "pong".to_string(), "clang".to_string(),
//     // "pang".to_string(), "clong".to_string(), "tac".to_string(), "boink".to_string(),
//     // "cloink".to_string(), "rattle".to_string(), "clock".to_string(), "toc".to_string(),
//     // "clink".to_string(), "tuc".to_string()];

//     let inputs = vec![("clank".to_string(), "a".to_string())];

//     let result: Vec<&(String, String)> = inputs
//         .iter()
//         .filter(|(identifier, value)| *identifier == char)
//         .collect();

//     println!("{}", result.len());

//     return "x".to_string();
//     //"whack".to_string(), "bump".to_string(),
//     //"pop".to_string(), "dink".to_string(), "thumb".to_string()

//     // let results vec!["a", "b", "c", "d", "e","f","g","h","i","j","k","l","m","n","o","p","q","r","s","t","u","v","w","x","y","z"]

//     // for input in inputs {
//     //     if !(input == char) {
//     //         continue;
//     //     }
//     //     if caps_lock ||shift_active {
//     //         return ""
//     //     }
//     // }
// }
