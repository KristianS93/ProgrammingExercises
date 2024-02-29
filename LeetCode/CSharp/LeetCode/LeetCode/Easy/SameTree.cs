
namespace LeetCode.Easy;

public class TreeNode2 {
    public int val;
    public TreeNode2 left;
    public TreeNode2 right;
    public TreeNode2(int val=0, TreeNode2 left=null, TreeNode2 right=null) {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}

public class SameTree
{
    public bool IsSameTree(TreeNode2 p, TreeNode2 q) {
        // Base case only p and q exists root nodes
        if (p == null && q == null) return true;

        if (p == null || q == null || p.val != q.val) return false;
        
        return IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right);
    }
}