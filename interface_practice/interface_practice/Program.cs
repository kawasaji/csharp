
Array aa = new();
aa.Show();
Console.WriteLine(aa.Min());
interface IMath
{
    public int Min();
    public int Max();

    public float Avg();

    public bool Search(int search_num);
}

class Array : IMath
{
    

    public Array()
    {
        int iter = 0;
        Console.Write("enter how many numbers u want to add\n~# ");
        iter = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < iter; i++)
        {
            Console.Write("enter number ~# ");
            my_list.Add(Convert.ToInt32(Console.ReadLine()));
        }
    }

    public int Min()
    {
        int minn = my_list[0];
        for (int i = 0; i < my_list.Count; i++)
        {
            if (minn >= my_list[i])
            {
                minn = my_list[i];
            }
        }

        return minn;
    }

    public int Max()
    {
        int maxx = my_list[0];
        for (int i = 0; i < my_list.Count; i++)
        {
            if (maxx <= my_list[i])
            {
                maxx = my_list[i];
            }
        }

        return maxx;
    }

    public float Avg()
    {
        int avgg = my_list[0];
        for (int i = 1; i < my_list.Count; i++)
        {
            avgg += my_list[i];
        }

        return avgg / my_list.Count;
    }

    public bool Search(int search_num)
    {
        for (int i = 0; i < my_list.Count; i++)
        {
            if (search_num == my_list[i])
            {
                return true;
            }
        }

        return false;
    }

    public void Show()
    {
        for (int i = 0; i < my_list.Count; i++)
        {
            Console.Write($"{my_list[i]} ");
        }

        Console.WriteLine();
    }

    public List<int> my_list = new();
}

