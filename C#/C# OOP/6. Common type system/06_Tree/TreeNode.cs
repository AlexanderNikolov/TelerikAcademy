namespace BST
{
    using System;

	/// <summary>
	/// Summary description for Node.
	/// </summary>
	public class TreeNode : ICloneable
	{
		private IComparable data;
		private TreeNode left, right;

		#region Constructors
		//.tor with reuse
		public TreeNode() 
			: this(null) 
		{
		}
		
		//.tor with reuse
		public TreeNode(IComparable data) 
			: this(data, null, null)
		{
		}

		//default constructor
		public TreeNode(IComparable data, TreeNode left, TreeNode right)
		{
			this.data = data;
			this.left = left;
			this.right = right;
		}
		#endregion

		#region Public Methods
		public object Clone()
		{
			TreeNode clone = new TreeNode();
			if (data is ICloneable)
				clone.Value = (IComparable) ((ICloneable) data).Clone();
			else
				clone.Value = data;

			if (left != null)
				clone.Left = (TreeNode) left.Clone();
			
			if (right != null)
				clone.Right = (TreeNode) right.Clone();

			return clone;
		}

		public override string ToString()
		{
			return String.Format("{0}", this.data);
		}
		#endregion

		#region Public Properties
		public IComparable Value
		{
			get
			{
				return data;
			}
			set
			{
				data = value;
			}
		}

		public TreeNode Left
		{
			get
			{
				return left;
			}
			set
			{
				left = value;
			}
		}

		public TreeNode Right
		{
			get
			{
				return right;
			}
			set
			{
				right = value;
			}
		}
		#endregion
	}
}
