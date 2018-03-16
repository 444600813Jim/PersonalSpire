using System;
using System.Runtime.Serialization;

[Serializable]
internal class Exception3 : ApplicationException
{
    private const string string_0 = "Incorrect layouting process";

    public Exception3() : base(BookmarkStart.b("昮弰倲娴䔶䬸帺帼䬾慀⽂⑄㹆♈㹊㥌♎㽐㑒畔❖⭘㑚㹜㩞በၢ", 9))
    {
    }

    public Exception3(Exception A_0) : this(BookmarkStart.b("縶圸堺刼䴾㍀♂♄㍆楈❊ⱌ㙎㹐♒⅔㹖㝘㱚絜⽞፠ౢ٤ɦᩨᡪ", 0x11), A_0)
    {
    }

    public Exception3(string A_0) : base(A_0)
    {
    }

    public Exception3(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
    {
    }

    public Exception3(string A_0, Exception A_1) : base(A_0, A_1)
    {
    }
}

