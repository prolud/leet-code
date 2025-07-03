using Easy;

namespace LeetCode.Tests.Difficults.Easy;

public class LengthOfLastWordTest
{
    [Fact]
    public void LengthOfLastWord_Example1_Return5()
    {
        // Arrange
        var s = "Hello World";
        LengthOfLastWordExercice lengthOfLastWordExercice = new LengthOfLastWordExercice();


        // Act
        var result = lengthOfLastWordExercice.LengthOfLastWord(s);

        // Assert
        Assert.Equal(5, result);
    }

    [Fact]
    public void LengthOfLastWord_Example1_Return4()
    {
        // Arrange
        var s = "   fly me   to   the moon  ";
        LengthOfLastWordExercice lengthOfLastWordExercice = new LengthOfLastWordExercice();

        // Act
        var result = lengthOfLastWordExercice.LengthOfLastWord(s);

        // Assert
        Assert.Equal(4, result);
    }

    [Fact]
    public void LengthOfLastWord_Example1_Return6()
    {
        // Arrange
        var s = "luffy is still joyboy";
        LengthOfLastWordExercice lengthOfLastWordExercice = new LengthOfLastWordExercice();


        // Act
        var result = lengthOfLastWordExercice.LengthOfLastWord(s);

        // Assert
        Assert.Equal(6, result);
    }
}
