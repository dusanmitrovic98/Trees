namespace DataStructures.Collections.Trees;

public class Tree<T>
{
    public TreeNode<T> Root { get; set; }

    public Tree(T data)
    {
        this.Root = new TreeNode<T>(data);
    }
}
