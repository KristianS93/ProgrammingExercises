using LeetCode.Medium;

namespace LeetCode.Easy;

public class ReverseLL
{
    public void Run()
    {
        var ex1_h = new ListNode(1);
        var ex1_1 = new ListNode(2);
        var ex1_2 = new ListNode(4);
        ex1_h.next = ex1_1;
        ex1_1.next = ex1_2;
        var ex2_h = new ListNode(1);
        var ex2_1 = new ListNode(3);
        var ex2_2 = new ListNode(4);
        ex2_h.next = ex2_1;
        ex2_1.next = ex2_2;
        var res = MergeTwoLists(ex1_h, ex2_h);
        while (res is not null)
        {
            Console.Write(res.val + " ");
            res = res.next;
        }
    }
    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        ListNode dummy = new ListNode(0);
        var head = dummy;
        while (list1 is not null || list2 is not null)
        {
            if (list1 is not null && list2 is not null)
            {
                if (list1.val <= list2.val)
                {
                    dummy.next = list1;
                    list1 = list1.next;
                    dummy = dummy.next;
                }
                else
                {
                    dummy.next = list2;
                    list2 = list2.next;
                    dummy = dummy.next;
                }
            } else if (list1 is not null && list2 is null)
            {
                dummy.next = list1;
                return head.next;
            }
            else
            {
                dummy.next = list2;
                return head.next;
            }
        }

        return head.next;
    }
}