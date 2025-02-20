double[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, -1, -2, -3, -4, -5 };

Console.WriteLine("Сумма отрицательных элементов:");
var sumNegative = nums.Where(num => num < 0).Sum();
Console.WriteLine(sumNegative);

int minIndex = Array.IndexOf(nums, nums.Min());
int maxIndex = Array.IndexOf(nums, nums.Max());

if (minIndex > maxIndex)
{
    (minIndex, maxIndex) = (maxIndex, minIndex);
}

double product = nums.Skip(minIndex + 1).Take(maxIndex - minIndex - 1).Aggregate(1.0, (acc, x) => acc * x);

Console.WriteLine("Произведение элементов между минимальным и максимальным:");
Console.WriteLine(product);

var sortedNums = nums.OrderBy(num => num).ToArray();

Console.WriteLine("Отсортированный массив:");
Console.WriteLine(string.Join(", ", sortedNums));