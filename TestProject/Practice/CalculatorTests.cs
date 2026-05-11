using TargetProject.Practice;
/// <summary>
/// Calculatorクラスに実装されたメソッドの単体テストドライバ
/// </summary>
namespace TestProject.Practice;

[TestClass]
public class CalculatorTests
{
    [TestMethod("テストケース1:両方に値がある場合、加算結果を返す")]
    public void Add_ShouldReturnSum_WhenBothHaveValues()
    {
        // Arrange(準備)
        var calculator = new Calculator();
        int? x = 1;
        int? y = 2;
        // Act(実行)
        var result = calculator.Add(x, y);
        // Assert(確認)
        Assert.AreEqual(3, result);
    }
    [TestMethod("テストケース2:xがnullの場合、結果はnullになる")]
    public void Add_ShouldReturnNull_WhenXIsNull()
    {
        // Arrange(準備)
        var calculator = new Calculator();
        int? x = null;
        int? y = 2;
        // Act(実行)
        var result = calculator.Add(x, y);
        // Assert(確認)
        Assert.IsNull(result);
    }
    [TestMethod("テストケース3:yがnullの場合、結果はnullになる")]
    public void Add_ShouldReturnNull_WhenYIsNull()
    {
        // Arrange(準備)
        var calculator = new Calculator();
        int? x = 1;
        int? y = null;
        // Act(実行)
        var result = calculator.Add(x, y);
        // Assert(確認)
        Assert.IsNull(result);
    }
    [TestMethod("テストケース4:両方がnullの場合、結果はnullになる")]
    public void Add_ShouldReturnNull_WhenBothAreNull()
    {
        // Arrange(準備)
        var calculator = new Calculator();
        int? x = null;
        int? y = null;
        // Act(実行)
        var result = calculator.Add(x, y);
        // Assert(確認)
        Assert.IsNull(result);
    }
    [TestMethod("テストケース5:_____")]
    public void Add_ShouldReturnY_WhenXIs0()
    {
        // Arrange(準備)
        var calculator = new Calculator();
        int? x = 0;
        int? y = 2;
        // Act(実行)
        var result = calculator.Add(x, y);
        // Assert(確認)
        Assert.AreEqual(2, result);
    }
}