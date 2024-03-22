using LeetCode.Medium;

namespace LeetCode.Easy;

public class ReverseLL
{
    public void Run()
    {
        var ex1_h = new ListNode(1);
        var ex1_1 = new ListNode(2);
        var ex1_2 = new ListNode(3);
        var ex1_3 = new ListNode(4);
        var ex1_4 = new ListNode(5);
        ex1_h.next = ex1_1;
        ex1_1.next = ex1_2;
        ex1_2.next = ex1_3;
        ex1_3.next = ex1_4;
        var res = ReverseList(ex1_h);
        while (res is not null)
        {
            Console.Write(res.val + " ");
            res = res.next;
        }
    }
    public ListNode ReverseList(ListNode head)
    {
        ListNode prev = null;
        ListNode curr = head;

        while (curr is not null)
        {
            var temp = curr.next;
            curr.next = prev;
            prev = curr;
            curr = temp;
        }

        return prev;
    }
}