namespace Merge_Two_Binary_Trees
{
  class Program
  {
    static void Main(string[] args)
    {
      TreeNode root1 = new TreeNode(1);
      root1.left = new TreeNode(3);
      root1.left.left = new TreeNode(5);
      root1.right = new TreeNode(2);

      TreeNode root2 = new TreeNode(2);
      root2.left = new TreeNode(1);
      root2.left.right = new TreeNode(4);
      root2.right = new TreeNode(3);
      root2.right.right = new TreeNode(7);

      Solution s = new Solution();
      s.MergeTrees(root1, root2);
    }
  }

  public class TreeNode
  {
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
    {
      this.val = val;
      this.left = left;
      this.right = right;
    }
  }

  public class Solution
  {
    public TreeNode MergeTrees(TreeNode root1, TreeNode root2)
    {
      if (root1 == null && root2 == null) return null;
      int val1 = root1 == null ? 0 : root1.val;
      int val2 = root2 == null ? 0 : root2.val;
      var merged = new TreeNode(val1 + val2);
      merged.left = MergeTrees(root1?.left, root2?.left);
      merged.right = MergeTrees(root1?.right, root2?.right);
      return merged;
    }
  }
}
