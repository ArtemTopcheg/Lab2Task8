//Task8

int k = Convert.ToInt32(Console.ReadLine());
int[] nums = new int[k];
Random rnd = new Random();
for (int i = 0; i < nums.Length; i++)
{
    nums[i] = rnd.Next() % 10;
    Console.Write(nums[i]+" ");
}
Console.WriteLine('\n');
int Poisk = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < nums.Length; i++)
{
    if (nums[i] == Poisk)
    {
        Console.WriteLine("Элемент вошёл " + (i + 1) + " по счёту");
    }
}