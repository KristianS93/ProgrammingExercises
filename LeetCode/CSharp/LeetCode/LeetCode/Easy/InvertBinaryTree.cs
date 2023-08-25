namespace LeetCode.Easy;

public class InvertBinaryTree
{
    public TreeNode InvertTree(TreeNode root)
    {
        if(root == null){
            return null;
        }
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