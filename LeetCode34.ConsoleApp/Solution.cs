namespace LeetCode34.ConsoleApp;



public class Solution
{
    public int[] SearchRange(int[] nums, int target)
    {
        if (nums.Length == 0)
        {
            return new int[] { -1, -1 };
        }

        int finalStartIndex = -1;
        int finalEndIndex = -1;

        int searchStartIndex = 0;
        int searchEndIndex = nums.Length - 1;

        int currentEndIndex = -1;
        int lastGreaterThanIndex = nums.Length - 1;

        // Find the start index "finalStartIndex".
        int currentStartIndex = -1;
        while (true)
        {
            double _middleIndex = (searchEndIndex + searchStartIndex) / 2d;
            int middleIndex = (int)Math.Floor(_middleIndex);
            int middleItem = nums[middleIndex];

            if (middleItem < target)
            {
                searchStartIndex = ++middleIndex;
            }
            else if (middleItem > target)
            {
                lastGreaterThanIndex = middleIndex - 1;
                searchEndIndex = middleIndex - 1;
            }
            else // means middleItem == target
            {
                if (currentEndIndex == -1)
                {
                    finalEndIndex = middleIndex;

                    if (middleIndex + 1 <= nums.Length - 1)
                    {
                        currentEndIndex = middleIndex + 1;
                    }
                }

                currentStartIndex = middleIndex;
                searchEndIndex = --middleIndex;
            }

            if (searchStartIndex <= searchEndIndex)
            {
                continue;
            }
            else
            {
                finalStartIndex = currentStartIndex;
                break;
            }
        }

        if (finalStartIndex == -1)
        {
            return new int[] { -1, -1 };
        }

        if (finalEndIndex == nums.Length - 1)
        {
            return new int[] { finalStartIndex, finalEndIndex };
        }

        // Find the end index "finalEndIndex".
        // Search between the "currentEndIndex" and "lastGreaterThanIndex".
        while (true)
        {
            double _middleIndex = (currentEndIndex + lastGreaterThanIndex) / 2d;
            int middleIndex = (int)Math.Ceiling(_middleIndex);
            int middleItem = nums[middleIndex];

            if (middleItem < target)
            {
                currentEndIndex = middleIndex + 1;
            }
            else if (middleItem > target)
            {
                lastGreaterThanIndex = middleIndex - 1;
            }
            else // means middleItem == target
            {
                finalEndIndex = middleIndex;
                currentEndIndex = middleIndex + 1;
            }

            if (currentEndIndex <= lastGreaterThanIndex)
            {
                continue;
            }
            else
            {
                return new int[] { finalStartIndex, finalEndIndex };
            }
        }
    }
}