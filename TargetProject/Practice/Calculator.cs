namespace TargetProject.Practice;
/// <summary>
/// テストターゲット:計算結果を返すクラス
/// </summary>
public class Calculator
{
    /// <summary>
    /// 加算した結果を返す
    /// </summary>
    /// <param name="x">加算する値またはnull</param>
    /// <param name="y">加算する値またはnull</param>
    /// <returns>加算結果またはnull</returns>
    public int? Add(int? x, int? y)
    {
        return x + y;
    }
}