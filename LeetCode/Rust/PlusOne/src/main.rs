// https://leetcode.com/problems/plus-one/
// Plus One

impl Solution {
    pub fn plus_one(mut digits: Vec<i32>) -> Vec<i32> {
        let last = digits.len();
        if digits[last - 1] == 9 {
            digits = check_is_nine(digits, 1);
        } else {
            digits[last - 1] += 1;
        }
        return digits;
    }
}

pub fn check_is_nine(mut digits: Vec<i32>, mut current_index: usize) -> Vec<i32> {
    let last = digits.len();
    if current_index > last {
        return digits;
    }

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
