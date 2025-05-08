namespace TextManagerTest;

using TextManager;
using Xunit;



public class TextManagerTest
{
[Fact]
public void CountWordsTest()
{
    // Given
    TextManagerClass textManager = new TextManagerClass("Test1");
    
    // When
    var result = textManager.CountLetters();

    // Then
    Assert.NotEqual(2, result);
    }


    [Fact]
    public void FindWordTest_NotEmpty()
    {
    // Given
    string stringToFind="Puchikimon";
    TextManagerClass textManagerClass = new TextManagerClass(stringToFind);;

    // When
    var result = textManagerClass.FindExactWord(stringToFind,true);

    // Then
    //Assert.Contains(stringToFind, result.Count);
    Assert.NotEmpty(result);
    }

        [Fact]
    public void FindWordTest_Empty()
    {
    // Given
    string stringToFind="Puchikimon";
    TextManagerClass textManagerClass = new TextManagerClass(stringToFind);;

    // When
    var result = textManagerClass.FindExactWord("FailString",true);

    // Then
    //Assert.Contains(stringToFind, result.Count);
    Assert.Empty(result);
    }
    [Fact]
    public void CountWordsTestMayorZeroTes()
    {
        // Given
        var stringToUse = "Palbra1, palabra2, palabra3, palabra4";
        TextManagerClass textManagerClass = new  TextManagerClass(stringToUse);

        // When
        var result= textManagerClass.CountWords();
    
        // Then
        Assert.True(result >=2);
    }

    [Fact]
    public void FindExactWord()
    {
        // Given
         var stringToUse = "Palbra1, palabra2, palabra3, palabra4";
        TextManagerClass textManagerClass = new TextManagerClass(stringToUse);
    
        // When
        var result = textManagerClass.FindExactWord("palabra4",true);
    
        // Then
        Assert.NotEmpty(result);
    }
}




 