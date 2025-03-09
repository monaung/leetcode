using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Code
{
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
    public class BTPreOrder
    {
        public IList<int> PreorderTraversal(TreeNode root)
        {
            Stack<TreeNode> stack = new Stack<TreeNode>();
            var res = new List<int>();

            if (root == null) return res;

            stack.Push(root);

            while (stack.Count > 0)
            {
                var current = stack.Pop();
                res.Add(current.val);

                if (current.right != null)
                {
                    stack.Push(current.right);
                }

                if (current.left != null)
                {
                    stack.Push(current.left);
                }
            }

            return res;
        }

        List<int> res = new List<int>();
        public IList<int> InorderTraversal(TreeNode root)
        {
          
            if (root == null) return res;

            //res.Add(root.val);

            InorderTraversal(root.left);
            res.Add(root.val);

            InorderTraversal(root.right);

            return res;
        }
    }
}
