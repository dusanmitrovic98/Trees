namespace DataStructures.Collections.Trees;

public class Tree<T>
{
    public TreeNode<T> Root { get; set; }

    public Tree(T data)
    {
        this.Root = new TreeNode<T>(data);
    }
    public void Traverse(TreeNode<T> node, Action<T> action)
    {
        action(node.Data);

        foreach (TreeNode<T> child in node.Children)
        {
            Traverse(child, action);
        }
    }
}
