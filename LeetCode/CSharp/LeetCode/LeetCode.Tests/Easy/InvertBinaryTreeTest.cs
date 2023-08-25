using LeetCode.Easy;

namespace LeetCode.Tests.Easy;

public class InvertBinaryTreeTest
{
    [Fact]
    public void Sample1()
    {
        var worker = new InvertBinaryTree();

        var root = new TreeNode
        {
            val = 4,
            left = new TreeNode
            {
                val = 2,
                left = new TreeNode
                {
                    val = 1,
                    left = null,
                    right = null,
                },
                right = new TreeNode
                {
                    val = 3,
                    left = null,
                    right = null,
                },
            },
            right = new TreeNode
            {
                val = 7,
                left = new TreeNode
                {
                    val = 6,
                    left = null,
                    right = null
                },
                right = new TreeNode
                {
                    val = 9,
                    left = null,
                    right = null
                }
            }
        };

        var expected = new TreeNode
        {
            val = 4,
            left = new TreeNode
            {
                val = 7,
                left = new TreeNode
                {
                    val = 9,
                    left = null,
                    right = null,
                },
                right = new TreeNode
                {
                    val = 6,
                    left = null,
                    right = null,
                },
            },
            right = new TreeNode
            {
                val = 2,
                left = new TreeNode
                {
                    val = 3,
                    left = null,
                    right = null
                },
                right = new TreeNode
                {
                    val = 1,
                    left = null,
                    right = null
                }
            }

        };

        var result = worker.InvertTree(root);
        Assert.Equal(expected, result);
    }
}