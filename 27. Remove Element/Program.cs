public class Solution
{
    public int RemoveElement(int[] nums, int val)
    {
        if (nums.Length == 0) return 0;
        if (nums.Contains(val) == false) return nums.Length;
        var counter = 0;
        for (var i = 0; i < nums.Length; i++)
        {
            while (nums[i] == val)
            {
                counter++;
                i++;
                if (counter == nums.Length) { nums = null; return 0; }
                if (i == nums.Length)
                    break;
            }
            if (i < nums.Length && counter > 0)
            {
                for (var j = 0; j < i-counter; j++)
                    nums[i - counter + j] = nums[i];
            }
        }
        return nums.Length - counter;
    }
}