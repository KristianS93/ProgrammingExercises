namespace LeetCode.Easy;

public class InvertBinaryTree
{
    public TreeNode InvertTree(TreeNode root)
    {
        // if (root == null)
        // {
        //     return null;
        // }
        //
        // if (root.left != null && root.right != null)
        // {
        //     InvertTree(root.left);
        //     InvertTree(root.right);
        //     (root.left, root.right) = (root.right, root.left);
        // }
        //
        // if (root.left != null && root.right == null)
        // {
        //     InvertTree(root.left);
        //     (root.left, root.right) = (null, root.left);
        // }
        // if (root.left == null && root.right != null)
        // {
        //     InvertTree(root.right);
        //     (root.left, root.right) = (root.right, null);
        // }
        //
        // return root;
        (root.left, root.right) = (InvertTree(root.right), InvertTree(root.left));
        return root;
    }
}

public class TreeNode {
     public int val;
     public TreeNode? left;
     public TreeNode? right;
     public TreeNode(int val=0, TreeNode? left=null, TreeNode? right=null) {
             this.val = val;
             this.left = left;
             this.right = right;
         }
 }