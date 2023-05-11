namespace DataStructures.Collections.Trees;

public class TreeNode<T>
{
    private T _data;
    private TreeNode<T> _parent;

    public T Data { get; set; }
    public TreeNode<T> Parent { get; set; }
    public List<TreeNode<T>> Children { get; set; }
}