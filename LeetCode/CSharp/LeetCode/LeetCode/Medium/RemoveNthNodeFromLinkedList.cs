namespace LeetCode.Medium;

public class RemoveNthNodeFromLinkedList
{
    
    public void Run()
    {
        var head1 = new ListNode(1);
        var node1 = new ListNode(2);
        head1.next = node1;
        var node2 = new ListNode(3);
        node1.next = node2;
        var node3 = new ListNode(4);
        node2.next = node3;
        var node4 = new ListNode(5);
        node3.next = node4;
        RemoveNthFromEnd(head1, 2);
        ListNode currentNode = head1;
        while (currentNode != null)
        {
            Console.Write(currentNode.val + " ");
            currentNode = currentNode.next;
        }
        Console.WriteLine();

        var head2 = new ListNode(1);
        RemoveNthFromEnd(head2, 1);
        ListNode currentNode1 = head2;
        while (currentNode1 != null)
        {
            Console.Write(currentNode1.val + " ");
            currentNode1 = currentNode1.next;
        }
        Console.WriteLine();
        
        var head3 = new ListNode(1);
        var node1x = new ListNode(2);
        head3.next = node1x;
        RemoveNthFromEnd(head3, 2);
        ListNode currentNode2 = head3;
        while (currentNode2 != null)
        {
            Console.Write(currentNode2.val + " ");
            currentNode2 = currentNode2.next;
        }
        Console.WriteLine();
    }
    public ListNode RemoveNthFromEnd(ListNode head, int n)
    {
        //Base case
        if (head == null)
        {
            return null;
        }
        // Get length
        ListNode currCountNode = head;
        var length = 1;
        while (currCountNode != null)
        {
            length++;
            currCountNode = currCountNode.next;
        }

        // if head is the one to remove:
        if(length-1 == n){
            return head.next;
        }

        // Remove element
        var count = 1;
        ListNode currNode = head;
        ListNode prevNode = null;
        while (currNode != null)
        {

            // Handles any other case where it is not the head we need to remove.
            if (count == length - n && prevNode != null)
            {
                prevNode.next = currNode.next;
                return head;
            }
            count++;
            prevNode = currNode;
            currNode = currNode.next;
        }

        return head;
    }
}

 public class ListNode {
     public int val;
     public ListNode next;
     public ListNode(int val=0, ListNode next=null) {
             this.val = val;
             this.next = next;
         }
 }