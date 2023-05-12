namespace DataStructures.Collections.Trees;

public class TreeNode<T>
{
    private T _data;
    private TreeNode<T> _parent;
    private List<TreeNode<T>> _children;

    public T Data
    {
        get { return this._data; }
        set { this._data = value; }
    }

    public TreeNode<T> Parent
    {
        get { return this._parent; }
        set { this._parent = value; }
    }

    public List<TreeNode<T>> Children
    {
        get { return this._children; }
        set { this._children = value; }
    }

    public TreeNode(T data)
    {
        this.Data = data;
        this.Children = new List<TreeNode<T>>();
    }

    public void AddChild(T childData)
    {
        TreeNode<T> childNode = new TreeNode<T>(childData);
        childNode.Parent = this;
        this.Children.Add(childNode);
    }

    public void RemoveChild(T childData)
    {
        foreach (TreeNode<T> childNode in this.Children)
        {
            if (childNode.Data.Equals(childData))
            {
                this.Children.Remove(childNode);
                return;
            }
        }
    }
    public bool IsLeaf()
    {
    }
}