namespace LeetCode.Easy;

public class LinkedListCycle
{
    public void Run()
    {
        // ex 1
        var ex1_h = new ListNode2(3);
        var ex1_1 = new ListNode2(2);
        var ex1_2 = new ListNode2(0);
        var ex1_3 = new ListNode2(-3);
        ex1_h.next = ex1_1;
        ex1_1.next = ex1_2;
        ex1_2.next = ex1_3;
        ex1_3.next = ex1_1;
        Console.WriteLine(HasCycle(ex1_h));

        
        // ex 2
        var ex2_h = new ListNode2(1);
        var ex2_1 = new ListNode2(2);
        ex2_h.next = ex2_1;
        ex2_1.next = ex2_h;
        Console.WriteLine(HasCycle(ex2_h));


        // ex3
        var ex3_h = new ListNode2(1);
        Console.WriteLine(HasCycle(ex3_h));
    }
    public bool HasCycle(ListNode2 head)
    {
        var fast = head;
        var slow = head;
        while (fast is not null && fast.next is not null)
        {
            fast = fast.next.next;
            slow = slow.next;
            if (fast == slow)
            {
                return true;
            }
        }

        return false;
    }
}

public class ListNode2 {
    public int val;
    public ListNode2 next;
    public ListNode2(int x) {
            val = x;
            next = null;
        }
}