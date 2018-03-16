using Spire.Doc;
using Spire.Doc.Fields.Shape;
using System;
using System.Collections;
using System.IO;
using System.Text;

internal class Class594
{
    private readonly MD5 md5_0 = new MD5();

    internal Class594(Class1089 A_0)
    {
        this.method_0(A_0);
        this.md5_0.FinalUpdate();
    }

    private void method_0(Class1089 A_0)
    {
        int num = 4;
        this.method_1(A_0.method_0().ToByteArray());
        SortedList list = new SortedList(new Class595());
        SortedList list2 = new SortedList(new Class595());
        foreach (DictionaryEntry entry in A_0)
        {
            string key = entry.Key.ToString();
            object obj2 = entry.Value;
            if (entry.Value is Stream)
            {
                if ((key != BookmarkStart.b("甩弫䜭圯就唳䈵䴷䠹夻䴽", num)) && (key != BookmarkStart.b("〈栫簭累焱嬳堵䰷弹刻䨽", num)))
                {
                    list.Add(key, obj2);
                }
            }
            else
            {
                if (!(entry.Value is Class1089))
                {
                    throw new InvalidOperationException(BookmarkStart.b("缩䈫䔭帯崱䌳堵ᠷ唹帻吽┿⅁ぃ桅", num));
                }
                if ((key != BookmarkStart.b("Ⱙ栫伭䐯匱朳䘵夷夹夻䴽", num)) && (key != BookmarkStart.b("⼩渫伭圯匱唳䜵䄷࠹༻唽㔿♁♃⹅⭇≉ോ⽍⅏村⅓摕㭗㉙ቛ㩝", num)))
                {
                    list2.Add(key, obj2);
                }
            }
        }
        foreach (DictionaryEntry entry3 in list)
        {
            this.method_3((string) entry3.Key);
            MemoryStream stream = (MemoryStream) entry3.Value;
            this.method_2(stream.GetBuffer(), (int) stream.Length);
        }
        foreach (DictionaryEntry entry2 in list2)
        {
            this.method_3((string) entry2.Key);
            this.method_0((Class1089) entry2.Value);
        }
    }

    private void method_1(byte[] A_0)
    {
        this.method_2(A_0, A_0.Length);
    }

    private void method_2(byte[] A_0, int A_1)
    {
        this.md5_0.Update(A_0, A_1);
    }

    private void method_3(string A_0)
    {
        this.method_1(Encoding.Unicode.GetBytes(A_0));
    }

    internal byte[] method_4()
    {
        return this.md5_0.Digest;
    }

    private static string smethod_0(string A_0)
    {
        StringBuilder builder = new StringBuilder();
        for (int i = 0; i < A_0.Length; i++)
        {
            char c = A_0[i];
            if (char.IsLetterOrDigit(c) || (c == '_'))
            {
                builder.Append(c);
            }
        }
        return builder.ToString();
    }

    private class Class595 : IComparer
    {
        int IComparer.Compare(object A_0, object A_1)
        {
            string strA = Class594.smethod_0((string) A_0);
            string strB = Class594.smethod_0((string) A_1);
            return string.CompareOrdinal(strA, strB);
        }
    }
}

