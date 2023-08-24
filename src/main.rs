use std::{fs, path::Path, io::read_to_string, fmt::format};
use anyhow::Result;
use reqwest::Error;
use tokio;

#[tokio::main]
async fn main() {
    //Kattis Rust
    let kattis_rust = fs::read_dir("./Kattis/Rust").unwrap();

    let mut Exercises = Exercises::new();

    // get level
    
    for dir in kattis_rust {
        let dir_path = dir.unwrap().path();
        let src_path = Path::new(&dir_path).join("src").join("main.rs");
        if let Ok(file) = fs::read_to_string(src_path) {
            let lines = file.trim().lines().map(|l| l.to_owned()).collect::<Vec<String>>();
            if let Some(first) = lines.chunks(4).next() {
                let mut result: Vec<String> = Vec::new();
                for line in first {
                    result.push(line.strip_prefix("// ").unwrap().to_string());
                }
                Exercises.Kattis.push(ExerciseEntry { link: result.get(0).unwrap().to_string(), lang: result.get(1).unwrap().to_string(), diff: result.get(2).unwrap().to_string(), name: result.get(3).unwrap().to_string() })
            }
        }
    }



    sort_name(&mut Exercises);
    let x = create_readme_string(Exercises.Kattis);
    // for e in x {
    //     println!("{}", e)
    // }
    get_diff().await.unwrap();

}

async fn get_diff() -> Result<(), Error> {
    let res = reqwest::get("https://open.kattis.com/problems/sequences?tab=metadata").await?;
    let body = res.text().await?;
    println!("{}", body);
    Ok(())
}

fn sort_name(exercise: &mut Exercises) -> &Exercises{

   exercise.Kattis.sort_by_key(|entry| entry.name.to_owned());
   return exercise;

}

fn create_readme_string(exercises: Vec<ExerciseEntry>) -> Vec<String> {
    let mut strings = vec!["|Problem Name|Difficulty|Language|".to_string(), "|--|--|--|".to_string()];
    for ex in exercises {
        let link = format!("https://github.com/KristianS93/ProgrammingExercises/blob/master/Kattis/Rust/{}/src/main.rs", ex.name.to_lowercase().replace(' ', "_"));
        strings.push(format!("|[{}]({})|{}|[{}]({})|", ex.name, ex.link, ex.diff, ex.lang, link));
    }

    return strings;
}

#[derive(Default, Debug)]
struct Exercises {
    Kattis: Vec<ExerciseEntry>,
    Leetcode: Vec<ExerciseEntry>,
    AOC: Vec<ExerciseEntry>,
}

impl Exercises {
    fn new() -> Self {
        Self {
            Kattis: Vec::new(),
            Leetcode: Vec::new(),
            AOC: Vec::new(),
        }
    }
}

#[derive(Default, Debug)]
struct ExerciseEntry {
    link: String,
    lang: String,
    diff: String,
    name: String,
}