using System.Diagnostics.CodeAnalysis;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel.DataAnnotations;

// ex 1

static void Swap<T>(ref T first, ref T second)
{
    T tmp;

    tmp = first;
    first = second;
    second = tmp;
}

// ex 2
public class MyQueue<T>
{

    public MyQueue()
    {
        list = new SortedList<Pair<int>, T>(new PairComparer<int>());
    }

    public void Queue(T item, int priority)
    {
        list.Add(new Pair<int>(priority, Count), item);
        Count++;
    }

    public T Dequeue()
    {
        T item = list[list.Keys[0]];
        list.RemoveAt(0);
        return item;
    }

    SortedList<Pair<int>, T> list;
    public int Count { get; private set; }
}

// ex 3
class CircularQueue<T>
{
    public CircularQueue(int len)
    {
        length = len;
    }

    public void Add(T item)
    {
        items[end++] = item;
        end %= length;
    }

    public T Get()
    {
        T item = items[start++];
        start %= length;
        return item;
    }

    int end = 0;
    int start = 0;

    static int length;
    T[] items = new T[length];
}

// ex 4

public class SingleList<T>
{
    public class Node<K>
    {
        public K Value { get; set; }
        public Node<K> Next { get; set; }
        public Node(K value, Node<K> next)
        {
            Value = value;
            Next = next;
        }
    }

    private Node<T> head { get; set; }
    private Node<T> back { get; set; }
    public int Count { get; private set; } = 0;

    public SingleList()
    {
        head = new Node<T>(default(T), null);
        back = new Node<T>(default(T), null);

        head.Next = back;
    }

    public Node<T> First
    {
        get
        {
            if (Count == 0)
            {
                return null;
            }

            else
            {
                return head.Next;
            }
        }
    }

    public Node<T> Find(T value)
    {
        Node<T> node = head.Next;

        while (!node.Equals(back))
        {
            if (node.Value.Equals(value))
            {
                return node;
            }

            node = node.Next;
        }

        return null;
    }

    public Node<T> AddFirst(T value)
    {
        Node<T> new_node = new Node<T>(value, head.Next);

        head.Next = new_node;

        Count++;

        return new_node;
    }

    public Node<T> AddLast(T value)
    {

        Node<T> node = head;

        while (!node.Next.Next.Equals(Tail))
        {
            node = node.Next;
        }

        Node<T> tmp_node = new Node<T>(value, Tail);
        node.Next.Next = tmp_node;

        Count++;

        return tmp_node;
    }

    public Node<T> AddAfter(Node<T> after, T value)
    {
        Node<T> current_node = after as Node<T>;
        Node<T> new_node = new Node<T>(value, current_node.Next);

        current_node.Next = new_node;

        Count++;

        return new_node;
    }

    public void Remove(Node<T> node)
    {
        if (node == null)
        {
            throw new ArgumentNullException();
        }

        if (Find(node.Value) == null)
        {
            throw new InvalidOperationException();
        }
        Node<T> remove = node as Node<T>;
        Node<T> current_node = Head;

        while (!current_node.Next.Next.Equals(remove.Next))
        {
            current_node = current_node.Next;
        }

        current_node.Next = remove.Next;

        Count--;
    }

    public void RemoveFirst()
    {
        if (Count == 0)
        {
            throw new InvalidOperationException();
        }

        Remove(First);
    }

    public void RemoveLast()
    {
        if (Count == 0)
        {
            throw new InvalidOperationException();
        }

        Node<T> current_node = Head;

        while (!current_node.Next.Next.Equals(Tail))
        {
            current_node = current_node.Next;
        }

        current_node.Next = Tail;

        Count--;
    }
}
// ex 5
public class DoubleLinkedList<T>
{
    public class Node<K>
    {
        public K Value { get; set; }
        public Node<K> Next { get; set; }
        public Node<K> Prev { get; set; }
        public Node(K value, Node<K> next, Node<K> prev)
        {
            Value = value;
            Next = next;
            Prev = prev;
        }
    }

    private Node<T> Head { get; set; }
    private Node<T> Tail { get; set; }
    public int Count { get; private set; } = 0;

    public DoubleLinkedList()
    {
        Head = new Node<T>(default(T), null, null);
        Tail = new Node<T>(default(T), null, null);

        Head.Next = Tail;
    }

    public Node<T> First
    {
        get
        {
            if (Count == 0)
            {
                return null;
            }
            else return Head.Next;
        }
    }

    public Node<T> Find(T value)
    {
        Node<T> node = Head.Next;

        while (!node.Equals(Tail))
        {
            if (node.Value.Equals(value))
            {
                return node;
            }

            node = node.Next;
        }

        return null;
    }

    public Node<T> AddFirst(T value)
    {
        Node<T> new_node = new Node<T>(value, Head.Next, Head.Prev);

        Head.Next = new_node;

        Count++;

        return new_node;
    }

    public Node<T> AddLast(T value)
    {

        Node<T> node = Head;

        while (!node.Next.Next.Equals(Tail))
        {
            node = node.Next;
        }

        Node<T> new_node = new Node<T>(value, Tail, null);
        node.Next.Next = new_node;

        Count++;

        return new_node;
    }

    public Node<T> AddAfter(Node<T> after, T value)
    {
        Node<T> current_node = after as Node<T>;
        Node<T> new_node = new Node<T>(value, current_node.Next, current_node.Prev);

        current_node.Next = new_node;

        Count++;

        return new_node;
    }

    public void Remove(Node<T> node)
    {
        if (node == null)
        {
            throw new ArgumentNullException();
        }

        if (Find(node.Value) == null)
        {
            throw new InvalidOperationException();
        }
        Node<T> remove = node as Node<T>;
        Node<T> current_node = Head;

        while (!current_node.Next.Next.Equals(remove.Next))
        {
            current_node = current_node.Next;
        }

        current_node.Next = remove.Next;

        Count--;
    }

    public void RemoveFirst()
    {
        if (Count == 0)
        {
            throw new InvalidOperationException();
        }
        Remove(First);
    }

    public void RemoveLast()
    {
        if (Count == 0)
        {
            throw new InvalidOperationException();
        }

        Node<T> current_node = Head;

        while (!current_node.Next.Next.Equals(Tail))
        {
            current_node = current_node.Next;
        }

        current_node.Next = Tail;

        Count--;
    }
}

// Additional Classes
class Pair<T>
{
    public Pair(T first, T second)
    {
        First = first;
        Second = second;
    }

    public override bool Equals(object other)
    {
        Pair<T> pair = other as Pair<T>;
        if (pair == null)
        {
            return false;
        }

        return (this.First.Equals(pair.First) && this.Second.Equals(pair.Second));
    }

    public T First { get; private set; }
    public T Second { get; private set; }
}

class PairComparer<T> : IComparer<Pair<T>> where T : IComparable
{
    public int Compare(Pair<T> x, Pair<T> y)
    {
        if (x.First.CompareTo(y.First) < 0)
        {
            return -1;
        }
        else if (x.First.CompareTo(y.First) > 0)
        {
            return 1;
        }
        else
        {
            return x.Second.CompareTo(y.Second);
        }
    }