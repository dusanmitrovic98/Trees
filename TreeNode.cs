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
    public List<TreeNode<T>> Children { get; set; }
}