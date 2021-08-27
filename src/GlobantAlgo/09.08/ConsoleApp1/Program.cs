
//var array = new int[] { 7, 2, 3, 10, 16, 15 };
//var array2 = new List<int> ();
//foreach (int i in array)
//{
//    if (i / 10 == 0)
//    {
//        array2.Add(i);
//    }
//    else
//    {
//        array2.Add(i/10);
//    }
//}

//array2.OrderBy(x => x);
//Console.WriteLine(array2.Count);


IList<int> FindDisappearedNumbers(int[] nums)
{
    int i = 0;
    while (i < nums.Length)
    {
        var pos = nums[i] - 1;
        if (nums[i] != nums[pos])
        {
            int tmp = nums[i];
            nums[i] = nums[pos];
            nums[pos] = tmp;
        }
        else i++;
    }
    List<int> result = new List<int>();
    for(int j=0; j <= nums.Length; j++)
    {
        if (nums[j] != j + 1)
            result.Add(j+ 1);
    }
    return result;
}
var nums = new int[] { 4, 3, 2, 7, 8, 2, 3, 1 };

var ds = FindDisappearedNumbers(nums);
Console.WriteLine(ds.Count);

//int MissingNumber(int[] nums)
//{
//    var n = nums.Length;
//    return n * (n + 1) / 2 - nums.Sum();
//}
//var nums3 = new int[] { 9, 6, 4, 2, 3, 5, 7, 0, 1 };
//var actual3 = MissingNumber(nums3);
// Console.WriteLine(actual3);


/*
using PredictWinnerName;

var rand = new Random();

int[] arr = new int[200];
for (int i = 0; i < 200; i++)
{
    arr[i] = rand.Next(0, 2000);
}

var res = PairGameWinner.PredictTheWinner(arr);

Console.WriteLine(res); */
