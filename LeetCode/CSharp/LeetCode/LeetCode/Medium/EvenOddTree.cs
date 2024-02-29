using LeetCode.Easy;

namespace LeetCode.Medium;

public class EvenOddTree
{
    public void Run()
    {
        var root = new TreeNode(11);
        
        var t1Left = new TreeNode(8);
        var t1Right = new TreeNode(6);
        root.left = t1Left;
        root.right = t1Right;

        var t2left = new TreeNode(3);
        var t2rl = new TreeNode(7);
        var t2rr = new TreeNode(9);
        t1Left.left = t2left;
        t1Right.left = t2rl;
        t1Right.right = t2rr;
        
        var t3ll = new TreeNode(12);
        var t3lr = new TreeNode(8);
        var t3rl = new TreeNode(6);
        var t3rr = new TreeNode(2);
        
        t2left.left = t3ll;
        t2left.right = t3lr;
        t2rl.left = t3rl;
        t2rr.right = t3rr;
        
        Console.WriteLine(IsEvenOddTree(root));
    }
    public bool IsEvenOddTree(TreeNode root) {
        bool isEven = false; // here we are in the second layer

        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        
        while (queue.Any())
        {
            var layerCount = queue.Count;
            var lastVal = 0;
            if (isEven)
            {
                lastVal = int.MaxValue;
            } 
            for (int i = 0; i < layerCount; i++)
            {
                var node = queue.Dequeue(); // first iter this is root
                
                // handle even case
                if (isEven)
                {
                    if (node.val % 2 != 0 || node.val >= lastVal)
                    {
                        return false;
                    }
                }
                // handle odd case
                if (!isEven)
                {
                    if (node.val % 2 == 0 || node.val <= lastVal)
                    {
                        return false;
                    }
                }
                // if (isEven && node.val % 2 != 0 || !isEven && node.val % 2 == 0 || lastVal <= node.val)
                // {
                //     return false;
                // }
                if (node.left != null)
                {
                    queue.Enqueue(node.left);
                }
                if (node.right != null)
                {
                    queue.Enqueue(node.right);
                }

                lastVal = node.val;
            }

            isEven = !isEven;
        }
        return true;
    }
}
/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
