//В этом небольшом задании вам дается строка чисел, разделенных пробелами, и вы должны вернуть наибольшее и наименьшее число.
//Выходная строка должна состоять из двух чисел, разделенных одним пробелом, причем наибольшее число должно быть первым.
Console.WriteLine(Kata.HighAndLow("8 3 -5 42 -1 0 0 -9 4 7 4 -4"));
public static class Kata
{
    public static string HighAndLow(string numbers)
    {
        string[] nums = numbers.Split(" ");
        int[] _nums = new int[nums.Length];

        for (int i = 0; i < nums.Length; i++)
        {
            _nums[i] = int.Parse(nums[i]);
        }

        int maxValue = _nums[0];
        int minValue = _nums[0];
        for (int i = 0; i < _nums.Length; i++)
        {
           
            if (_nums[i] < minValue)
                minValue = _nums[i];
            if (_nums[i] > maxValue)
                maxValue = _nums[i];
            
        }
        return maxValue.ToString() + ' ' + minValue.ToString();
    }
}
