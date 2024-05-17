[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestSubtraction()
    {
        // Arrange
        int a = 10;
        int b = 5;

        // Act
        int result = SimpleMath.Subtract(a, b);

        // Assert
        Assert.AreEqual(5, result);
    }

    [TestMethod]
    public void TestMultiplication()
    {
        // Arrange
        int a = 6;
        int b = 7;

        // Act
        int result = SimpleMath.Multiply(a, b);

        // Assert
        Assert.AreEqual(42, result);
    }
}

public static class SimpleMath
{
    public static int Add(int a, int b)
    {
        return a + b;
    }

    public static int Subtract(int a, int b)
    {
        return a - b;
    }

    public static int Multiply(int a, int b)
    {
        return a * b;
    }

    public static int Divide(int numerator, int denominator)
    {
        return numerator / denominator;
    }
}

public static class StringHelper
{
    public static bool IsPalindrome(string str)
    {
        for (int i = 0; i < str.Length / 2; i++)
        {
            if (str[i] != str[str.Length - 1 - i])
            {
                return false;
            }
        }
        return true;
    }
}
