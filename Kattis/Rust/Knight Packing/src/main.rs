fn main() {
    let mut digits: Vec<i32> = vec![9, 9]; //Test input

    let last = digits.len();
    if digits[last - 1] == 9 {
        println!("xD");
        digits = check_is_nine(digits, 1);
    } else {
        digits[last - 1] += 1;
    }
}

fn check_is_nine(mut digits: Vec<i32>, mut current_index: usize) -> Vec<i32> {
    let last = digits.len();
    if current_index > last {
        return digits;
    }

    println!("Last: {}", last);
    println!("Index: {}", current_index);

    if last == 1 && digits[last - current_index] == 9 {
        digits[last - current_index] = 1;
        digits.push(0);
        return digits;
    }

    if last - current_index - 1 == 0 && digits[last - current_index - 1] == 9 {
        digits.push(0);
        digits[last - current_index - 1] = 1;
    } else if digits[last - current_index - 1] != 9 {
        digits[last - current_index - 1] += 1;
        return digits;
    }

    if digits[last - current_index] == 9 {
        digits[last - current_index] = 0;
        current_index += 1;
        return check_is_nine(digits, current_index);
    }

    return digits;
}
