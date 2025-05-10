namespace TextManagerTest;
using TextManager;
using Xunit;

public class TextManagerTest
{
    
    TextManagerClass textManagerTestGlobal1;
    string stringToFind ="Puchikimon";
    public  TextManagerTest(){
         textManagerTestGlobal1 = new TextManagerClass(stringToFind);

    }

[Fact]
public void CountWordsTest()
{
    
    // Given
    TextManagerClass textManager = new TextManagerClass("Test1");
    
    // When
    var result = textManagerTestGlobal1.CountLetters();

    // Then
    Assert.NotEqual(2, result);
    }


    [Fact]
    public void FindWordTest_NotEmpty()
    {
    // Given
   

    // When
    var result = textManagerTestGlobal1.FindExactWord(stringToFind,true);

    // Then
    //Assert.Contains(stringToFind, result.Count);
    Assert.NotEmpty(result);
    }

        [Fact]
    public void FindWordTest_Empty()
    {
    // Given 
    // When
    var result = textManagerTestGlobal1.FindExactWord("FailString",true);

    // Then
    //Assert.Contains(stringToFind, result.Count);
    Assert.Empty(result);
    }
    [Fact]
    public void CountWordsTestMayorZeroTes()
    {
        // Given
      
       

        // When
        var result= textManagerTestGlobal1.CountWords();
    
        // Then
        Assert.True(result >=1);
    }

    [Fact]
    public void FindExactWord()
    {
        // Given
        
        
    
        // When
        var result = textManagerTestGlobal1.FindExactWord(stringToFind,true);
    
        // Then
        Assert.NotEmpty(result);
    }
}


