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


}