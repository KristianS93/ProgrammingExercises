#[derive(PartialEq, Eq, Clone, Debug)]
pub struct ListNode {
    pub val: i32,
    pub next: Option<Box<ListNode>>,
}

impl ListNode {
    #[inline]
    fn new(val: i32) -> Self {
        ListNode { next: None, val }
    }
}

fn main() {
    //Setup
    //list1
    let mut l1_1 = Some(Box::new(ListNode::new(2)));
    let mut l1_2 = Some(Box::new(ListNode::new(4)));
    // let l1_3 = Some(Box::new(ListNode::new(3)));
    // l1_2.as_mut().unwrap().next = l1_3.clone();
    l1_1.as_mut().unwrap().next = l1_2.clone();

    //list2
    let mut l2_1 = Some(Box::new(ListNode::new(5)));
    let mut l2_2 = Some(Box::new(ListNode::new(6)));
    let l2_3 = Some(Box::new(ListNode::new(4)));
    l2_2.as_mut().unwrap().next = l2_3.clone();
    l2_1.as_mut().unwrap().next = l2_2.clone();

    // let mut head = Some(Box::new(ListNode::new(0)));
    // head.as_mut().unwrap().next = Some(Box::new(ListNode::new(2)));
    // head.as_mut().unwrap().next.as_mut().unwrap().next = Some(Box::new(ListNode::new(4)));
    // head.as_mut()
    //     .unwrap()
    //     .next
    //     .as_mut()
    //     .unwrap()
    //     .next
    //     .as_mut()
    //     .unwrap()
    //     .next = Some(Box::new(ListNode::new(3)));
    // println!("{}", head.clone().unwrap().val);
    // println!("{}", head.unwrap().next.unwrap().val);

    // l1_second.next = Some(Box::new(l1_third.clone()));
    // l1_first.next = Some(Box::new(l1_second.clone()));
    // let mut current = add_two_numbers(l1_1, l1_2.clone());
    // println!("{}", current.unwrap().val);
    let mut current = add_two_numbers(l1_1, l2_1);
    while current.is_some() {
        println!("{}", current.clone().unwrap().val);
        current = current.unwrap().next;
    }
    // println!("{}", add_two_numbers(l1_2, l2_2).unwrap().val);

    // let mut current = l1_1;
    // while current.is_some() {
    //     println!("{}", current.clone().unwrap().val);
    //     current = current.unwrap().next;
    // }

    // while let Some(node) = current {
    //     println!("{}", current.unwrap().val);
    //     current = node.next;
    // }

    // println!("{}", l1_first.unwrap().val);
    // println!("{}", l1_second.unwrap().val);
    // println!("{}", l1_third.unwrap().val);
}

// virker
// fn add_two_numbers(
//     mut l1: Option<Box<ListNode>>,
//     mut l2: Option<Box<ListNode>>,
// ) -> Option<Box<ListNode>> {
//     if l1.as_mut().unwrap().next.is_none() || l2.as_mut().unwrap().next.is_none() {
//         return Some(Box::new(ListNode::new(l1.unwrap().val + l2.unwrap().val)));
//     }
//     let val = l1.as_mut().unwrap().val + l2.as_mut().unwrap().val;
//     let mut node = Some(Box::new(ListNode::new(val)));
//     node.as_mut().unwrap().next = add_two_numbers(l1.unwrap().next, l2.unwrap().next);

//     return node;
// }

fn add_two_numbers(
    mut l1: Option<Box<ListNode>>,
    mut l2: Option<Box<ListNode>>,
) -> Option<Box<ListNode>> {
    if l1.is_none() && l2.is_some() {
        let mut new_node = Some(Box::new(ListNode::new(l2.clone().unwrap().val)));
        new_node.as_mut().unwrap().next = add_two_numbers(None, l2.unwrap().next);
        return new_node;
    } else if l2.is_none() && l1.is_some() {
        let mut new_node = Some(Box::new(ListNode::new(l1.clone().unwrap().val)));
        new_node.as_mut().unwrap().next = add_two_numbers(l1.unwrap().next, None);
        return new_node;
    } else {
        if l1.as_mut().unwrap().next.is_none() && l2.as_mut().unwrap().next.is_some() {
            let mut new_node = Some(Box::new(ListNode::new(l2.clone().unwrap().val)));
            new_node.as_mut().unwrap().next = add_two_numbers(None, l2.unwrap().next);
            return new_node;
        } else if l2.as_mut().unwrap().next.is_none() && l1.as_mut().unwrap().next.is_some() {
            let mut new_node = Some(Box::new(ListNode::new(l1.clone().unwrap().val)));
            new_node.as_mut().unwrap().next = add_two_numbers(l1.unwrap().next, None);
            return new_node;
        };
    }

    // if l1.as_mut().unwrap().next.is_none() && l2.as_mut().unwrap().next.is_some() {
    //     let mut new_node = Some(Box::new(ListNode::new(l2.clone().unwrap().val)));
    //     new_node.as_mut().unwrap().next = add_two_numbers(None, l2.unwrap().next);
    //     return new_node;
    // } else if l2.as_mut().unwrap().next.is_none() && l1.as_mut().unwrap().next.is_some() {
    //     let mut new_node = Some(Box::new(ListNode::new(l1.clone().unwrap().val)));
    //     new_node.as_mut().unwrap().next = add_two_numbers(l1.unwrap().next, None);
    //     return new_node;
    // };

    // if l1.as_mut().unwrap().next.is_none() && l2.as_mut().unwrap().next.is_none() {
    //     return Some(Box::new(ListNode::new(l1.unwrap().val + l2.unwrap().val)));
    // }

    let value = l1.as_mut().unwrap().val + l2.as_mut().unwrap().val;
    if value > 9 {
        let mut new_node = Some(Box::new(ListNode::new(value % 10)));
        // while lists are same length just a 1 to one of them
        // let mut new_l1 = l1.unwrap().next;
        // new_l1.as_mut().unwrap().val += 1;
        new_node.as_mut().unwrap().next = add_two_numbers(l1.unwrap().next, l2.unwrap().next);
        new_node.as_mut().unwrap().next.as_mut().unwrap().val += 1;
        return new_node;
    }
    let mut new_node = Some(Box::new(ListNode::new(
        l1.clone().unwrap().val + l2.clone().unwrap().val,
    )));
    new_node.as_mut().unwrap().next =
        add_two_numbers(l1.clone().unwrap().next, l2.clone().unwrap().next);
    return new_node;
}
