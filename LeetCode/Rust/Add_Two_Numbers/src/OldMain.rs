// // https://leetcode.com/problems/add-two-numbers/
// // Add Two Numbers
// // Medium

// use std::cmp;
// fn main() {



//     let l1 = vec![2, 4, 3];
//     let l2 = vec![5, 6, 4];
//     let mut result: Vec<usize> = Vec::new();

//     // find longest list
//     let longest = cmp::max(l1.len(), l2.len());
//     let smallest = cmp::min(l1.len(), l2.len());
//     let mut temp: Vec<usize> = Vec::new();
//     for i in 0..longest {
//         if i < smallest && temp.is_empty() {
//             let value = l1[i] + l2[i];
//             if value > 9 {
//                 temp.push(1);
//                 result.push(value % 10);
//             } else {
//                 println!("{}", value);
//                 result.push(value);
//             }
//         } else if i < smallest {
//             // temp has value
//             let value = l1[i] + l2[i];
//             if value > 9 {
//                 // 1 already in temp no need to modify just add 1
//                 result.push((value % 10) + 1);
//             } else {
//                 result.push(value + 1);
//                 temp.pop();
//             }
//         } else if temp.is_empty() {
//             if l1.len() == longest {
//                 result.push(l1[i]);
//             } else {
//                 result.push(l2[i]);
//             }
//         } else {
//             if l1.len() == longest {
//                 let value = l1[i] + 1;
//                 if value > 9 {
//                     result.push(value % 10);
//                     //still 1 in temp dont need pop
//                 } else {
//                     result.push(value);
//                     temp.pop();
//                 }
//             } else {
//                 let value = l2[i];
//                 if value > 9 {
//                     result.push(value % 10);
//                     //still 1 in temp dont need pop
//                 } else {
//                     result.push(value);
//                     temp.pop();
//                 }
//             }
//         }
//     }
//     if !temp.is_empty() {
//         result.push(1);
//     }

//     for x in result {
//         print!("{}", x);
//     }
// }
