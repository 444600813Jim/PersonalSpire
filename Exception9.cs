using System;

[Serializable]
internal class Exception9 : ApplicationException
{
    private const string string_0 = "Access denied because another caller has the file open and locked.";
    private const string string_1 = "Access denied because another caller has the file open and locked. {0}.";

    public Exception9() : base(BookmarkStart.b("瘶娸堺堼䰾㉀捂⅄≆❈≊⡌⭎煐ㅒご㑖㡘⹚⹜㩞䅠ɢ୤ࡦᵨͪ࡬ᵮ兰ၲᑴ᭶ᕸṺོ彾Ꞇﶈ꾎朗璉릘爵쾠莢쒤즦춨讪솬삮튰\ud8b2\ud0b4펶鞸", 0x11))
    {
    }

    public Exception9(string A_0) : base(string.Format(BookmarkStart.b("眵嬷夹夻䴽㌿扁⁃⍅♇⍉⥋⩍灏けㅓ㕕㥗⽙⽛㭝䁟͡੣॥ᱧɩ५ᱭ偯ᅱᕳ᩵ᑷό๻幽ꚅﲇ꺍ﮑ뢗ﮝ캟芡얣좥첧誩삫솭펯\ud9b1\ud1b3튵隷骹잻躽붿", 0x10), A_0))
    {
    }

    public Exception9(string A_0, Exception A_1) : base(A_0, A_1)
    {
    }
}

