namespace TargetProject.Chap02;
/// <summary>
///     演習-02 ユニットテストターゲット
/// </summary>
public class GreetingService
{
    /// <summary>
    ///     指定された時刻(hour)に応じて、時間帯に適した挨拶メッセージを返します。
    /// </summary>
    /// <param name="hour">
    ///     時刻(0～23を想定)
    /// </param>
    /// <returns>
    ///     時間帯に応じた挨拶文字列
    /// </returns>
    public string Greet(int hour)
    {
        // 朝の時間帯(7時～11時)の場合
        // hour > 6  ＝ 7時以降 、hour < 12 ＝ 11時まで
        if (hour > 6 && hour < 12)
        {
            return "Good Morning";
        }
        // 昼の時間帯(12時～17時)の場合
        // hour >= 12 ＝ 12時以降 、hour < 18   ＝ 17時まで
        else if (hour >= 12 && hour < 18)
        {
            return "Hello";
        }
        // 夕方の時間帯(18時～20時)の場合
        // hour >= 18 ＝ 18時以降 、hour < 21   ＝ 20時まで
        else if (hour >= 18 && hour < 21)
        {
            return "Good Evening";
        }
        // 上記以外の時間帯
        // 深夜・早朝(0～6時、21～23時)の場合
        else
        {
            return "Good Night";
        }
    }
}