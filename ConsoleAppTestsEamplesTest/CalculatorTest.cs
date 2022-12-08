using ConsoleAppTestsEamples;

namespace ConsoleAppTestsEamplesTest;

public class CalculatorTest
{
    [Fact]
    public void GetSum_2and3_Return5()
    {
        //arrange //give //подготовка
        Calculator calculator = new Calculator(2, 3);

        //act //when //тестирование
        double expected = 5;
        double actual = calculator.GetSum();

        //aasert //than //проверка
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void GetDiv_9and3_Return3()
    {
        //arrange //give //подготовка
        Calculator calculator = new Calculator(9, 3);

        //act //when //тестирование
        double expected = 3;
        double actual = calculator.GetDiv();

        //aasert //than //проверка
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void GetDiv_9and0_ThrowException()
    {
        //arrange //give //подготовка
        Calculator calculator = new Calculator(9, 0);

        //act //when //тестирование

        //aasert //than //проверка
        Assert.Throws<Exception>(() => calculator.GetDiv());
    }

    [Fact]
    public void CalcExpression_Return0()
    {
        //arrange //give //подготовка

        //act //when //тестирование
        double expectedNull = 0;
        double actualNull = Calculator.CalcExpression(null);
        
        double expectedEmpty = 0;
        double actualEmpty = Calculator.CalcExpression("");

        //aasert //than //проверка
        Assert.Equal(expectedNull, actualNull);
        
        Assert.Equal(expectedEmpty, actualEmpty);
    }
    
    [Fact]
    public void CalcExpression_SetUp2_Return2()
    {
        //arrange //give //подготовка

        //act //when //тестирование
        double expected = 2;
        double actual = Calculator.CalcExpression("2");

        //aasert //than //проверка
        Assert.Equal(expected, actual);
    }
    
    [Fact]
    public void CalcExpression_2And3_Return5()
    {
        //arrange //give //подготовка

        //act //when //тестирование
        double expected = 113;
        double actual = Calculator.CalcExpression("80+33");

        //aasert //than //проверка
        Assert.Equal(expected, actual);
    }
}