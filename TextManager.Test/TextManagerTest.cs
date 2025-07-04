﻿namespace TextManagerTest;

using Castle.Core.Logging;
using Microsoft.Extensions.Logging;
using Moq;
using TextManager;
using Xunit;



public class TextManagerTest
{

    TextManagerClass textManagerTestGlobal1;
    string stringToFind = "Puchikimon";
    ILogger<TextManagerClass> loggerTest;
    public TextManagerTest()
    {
        var mock = new  Mock<ILogger<TextManagerClass>>();
        loggerTest = mock.Object;
        textManagerTestGlobal1 = new TextManagerClass(stringToFind,loggerTest);

    }

    [Fact]
    public void CountWordsTest()
    {

        // Given
        TextManagerClass textManager = new TextManagerClass("Test1",loggerTest);

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
        var result = textManagerTestGlobal1.FindExactWord(stringToFind, true);

        // Then
        //Assert.Contains(stringToFind, result.Count);
        Assert.NotEmpty(result);
    }

    [Fact]
    public void FindWordTest_Empty()
    {
        // Given 
        // When
        var result = textManagerTestGlobal1.FindExactWord("FailString", true);

        // Then
        //Assert.Contains(stringToFind, result.Count);
        Assert.Empty(result);
    }
    [Fact]
    public void CountWordsTestMayorZeroTes()
    {
        // Given



        // When
        var result = textManagerTestGlobal1.CountWords();

        // Then
        Assert.True(result >= 1);
    }

    [Fact]
    public void FindExactWord()
    {
        // Given



        // When
        var result = textManagerTestGlobal1.FindExactWord(stringToFind, true);

        // Then
        Assert.NotEmpty(result);
    }
    [Theory]
    [InlineData("Hola, Mundo sadas ", 1)]
    public void CountWordsTest2(string text1, int numberOfWord)
    {

        // Given
        TextManagerClass textManager2 = new TextManagerClass(text1,loggerTest);

        // When
        var result = textManagerTestGlobal1.CountWords();

        // Then
        Assert.Equal(numberOfWord, result);
    }
    [Theory]
    [ClassData(typeof(TextManagerClassData))]
    ///Aqui se ejecutan 3 escenarios diferentes para la misma prueba,
    public void CountWordsTesClass(string text1, int numberOfWord)
    {

        // Given
        TextManagerClass textManager2 = new TextManagerClass(text1,loggerTest);

        // When
        var result = textManagerTestGlobal1.CountWords();

        // Then
        Assert.Equal(numberOfWord, result);
    }
    
        public void CountWordsTestMoq()
    {
        var mock = new Mock<TextManagerClass>("Texto"); 
        //Esto es una expresión lambda que indica que cuando se llame al método CountWords() en el objeto simulado p retorne 1
        mock.Setup(p=> p.CountWords()).Returns(1);    
        // Given
        TextManagerClass textManager = new TextManagerClass("Test1",loggerTest);

        // When
        var result = mock.Object.CountWords();
        // Then
        Assert.NotEqual(2, result);
    }
}



