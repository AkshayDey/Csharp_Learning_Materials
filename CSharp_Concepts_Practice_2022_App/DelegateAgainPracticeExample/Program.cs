using DelegateAgainPracticeExample;


int Compare(int a, int b)
{
    if (a == b)
        return 0;
    else if (a > b)
        return 1;
    else
        return -1;
}

List<int> ages = new List<int>();
ages.Add(10);
ages.Add(1);
ages.Add(30);
ages.Add(4);
ages.Add(50);

BubbleSort aBubbleSort = new BubbleSort(ages);

aBubbleSort.Sort(Compare);

foreach(var allAges in ages)
{
    Console.WriteLine(allAges);
}