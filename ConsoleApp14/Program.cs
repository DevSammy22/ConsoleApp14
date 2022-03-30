/* Create a Node and LinkedList class, implement a method
that returns the middle element of
a linked list.Example
{0, 1, 2, 3, 4, 5, 6, 7, 8, 9 }
Return 5
*/
internal class Program
{
    static void Main(string[] args)
    {
        LinkedList linkedList = new LinkedList();
        linkedList.Add(2);
        linkedList.Add(3);
        linkedList.Add(4);
        linkedList.Add(6);
        linkedList.Add(7);
        ;
        int number = linkedList.FindMiddleNumber();
    }

}
public class Node
{
    public int Elements;
    public Node NextNode;
    public Node(int data)
    {
        Elements = data;
        NextNode = null;
    }
}
public class LinkedList
{
    public Node Head;
    public int Count;
    public LinkedList()
    {
        Head = null;
    }
    public void Add(int data)
    {
        Node node = new Node(data);
        if (Head == null)
        {
            Head = node;
            Count++;
        }
        else
        {
            Node temp = Head;
            while (temp.NextNode != null)
            {
                temp = temp.NextNode;
            }
            temp.NextNode = node;
            Count++;
        }
    }

    List<int> arr = new List<int>();
    public int FindMiddleNumber()
    {
        int i = 0;
        Node temp = Head;
        while (temp != null)
        {
            if (i < Count)
            {
                arr.Add(temp.Elements);
                i++;
                temp = temp.NextNode;
            }
        }

        int middle = arr.Count / 2;
        if (!(arr.Count % 2 == 0))
        {
            for (i = 0; i < arr.Count; i++)
            {
                if (i == middle)
                {
                    Console.WriteLine(arr[i]);
                    return arr[i];
                }
            }
        }
        else
        {
            for (i = 0; i < arr.Count; i++)
            {
                if (i == middle)
                {
                    Console.WriteLine(arr[i - 1] + ", " + arr[i]);
                    return arr[i];
                }
            }
        }
        return -1;
    }
}