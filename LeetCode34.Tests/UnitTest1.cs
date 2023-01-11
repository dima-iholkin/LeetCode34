using LeetCode34.ConsoleApp;



namespace LeetCode34.Tests;



public class UnitTest1
{
    [Fact]
    public void Example1()
    {
        // Arrange
        Solution sol = new Solution();

        // Act
        int[] nums = new int[] { 5, 7, 7, 8, 8, 10 };
        int target = 8;
        int[] result = sol.SearchRange(nums, target);

        // Assert
        int[] expected = new int[] { 3, 4 };
        Assert.Equal(expected, result);
    }



    [Fact]
    public void Example2()
    {
        // Arrange
        Solution sol = new Solution();

        // Act
        int[] nums = new int[] { 5, 7, 7, 8, 8, 10 };
        int target = 6;
        int[] result = sol.SearchRange(nums, target);

        // Assert
        int[] expected = new int[] { -1, -1 };
        Assert.Equal(expected, result);
    }



    [Fact]
    public void Example3()
    {
        // Arrange
        Solution sol = new Solution();

        // Act
        int[] nums = new int[0];
        int target = 0;
        int[] result = sol.SearchRange(nums, target);

        // Assert
        int[] expected = new int[] { -1, -1 };
        Assert.Equal(expected, result);
    }



    [Fact]
    public void Test5()
    {
        // Arrange
        Solution sol = new Solution();

        // Act
        int[] nums = new int[] { 1 };
        int target = 1;
        int[] result = sol.SearchRange(nums, target);

        // Assert
        int[] expected = new int[] { 0, 0 };
        Assert.Equal(expected, result);
    }



    [Fact]
    public void Test67()
    {
        // Arrange
        Solution sol = new Solution();

        // Act
        int[] nums = new int[] { 2, 2 };
        int target = 2;
        int[] result = sol.SearchRange(nums, target);

        // Assert
        int[] expected = new int[] { 0, 1 };
        Assert.Equal(expected, result);
    }
}