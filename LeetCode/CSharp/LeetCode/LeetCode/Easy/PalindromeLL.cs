using LeetCode.Medium;

namespace LeetCode.Easy;

public class PalindromeLL
{
    public void Run()
    {
        var ex1_h = new ListNode(1);
        var ex1_1 = new ListNode(2);
        var ex1_2 = new ListNode(1);
        // var ex1_3 = new ListNode(1);
        ex1_h.next = ex1_1;
        ex1_1.next = ex1_2;
        // ex1_2.next = ex1_3;
        Console.WriteLine(IsPalindrome(ex1_h));
    }

    public bool IsPalindrome(ListNode head) {
        ListNode last = null;
        var current = head;
        var list = new List<int>();
        while(current is not null){
            list.Add(current.val);
            var temp = current.next; // save the next
            current.next = last; // now we reverse such that current.next is last 
            last = current; // now the last is current meaning we have switched 2. 
            current = temp; 
        }

        var i = 0;
        while (last is not null)
        {
            if (list[i] != last.val)
            {
                return false;
            }
            last = last.next;
            i++;
        }
        
        return true;
    }
}