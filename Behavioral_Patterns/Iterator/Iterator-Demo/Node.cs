namespace Iterator_Demo;

internal class Node(int value)
{
    public int Value { get; set; } = value;
    public Node? Left { get; set; }
	public Node? Right { get; set; }
	public Node? Parent { get; set; }
}