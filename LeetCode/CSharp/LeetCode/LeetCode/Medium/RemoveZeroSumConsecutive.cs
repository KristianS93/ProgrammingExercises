using Microsoft.Diagnostics.Tracing.Parsers.MicrosoftWindowsTCPIP;

namespace LeetCode.Medium;

public class RemoveZeroSumConsecutive
{
    public void Run()
    {
        var ex1h = new ListNode(5);
        var ex11 = new ListNode(1);
        var ex12 = new ListNode(2);
        var ex13 = new ListNode(-3);
        var ex14 = new ListNode(3);
        var ex15 = new ListNode(1);
        ex1h.next = ex11;
        ex11.next = ex12;
        ex12.next = ex13;
        ex13.next = ex14;
        ex14.next = ex15;

        var cur = RemoveZeroSumSublists(ex1h);
        while (cur is not null)
        {
            Console.Write(cur.val + " ");
            cur = cur.next;
        }

        Console.WriteLine();
    }
    public ListNode RemoveZeroSumSublists(ListNode head) {
        var ft = new Dictionary<int, ListNode>();
        var dummyHead = new ListNode(0, head);

        var sum = 0;
        var current = head;
        while(current is not null){
            sum += current.val;
            Console.WriteLine("Current sum: " + sum);
            ft[sum] = current;
            current = current.next; 
        }

        sum = 0;
        current = dummyHead;
        while(current is not null){
            sum += current.val;
            Console.WriteLine("Current2 sum: " + sum + " is it in ft " + ft.ContainsKey(sum));
            if(ft.ContainsKey(sum)){
                current.next = ft[sum].next;
            }
            current = current.next;
        }
        
        return dummyHead.next;
    }
}