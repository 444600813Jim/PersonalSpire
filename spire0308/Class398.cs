using Spire.Doc;
using Spire.Doc.Documents;
using Spire.Doc.Documents.Converters;
using Spire.Doc.Formatting;
using System;
using System.Drawing;
using System.IO;
using System.Text;

internal class Class398 : Class397
{
    private readonly bool bool_0;
    private int int_0;

    public Class398(Class1092 A_0, bool A_1, bool A_2) : base(A_0, A_1)
    {
        this.bool_0 = A_2;
    }

    public Class398(Stream A_0, Encoding A_1, bool A_2, bool A_3) : base(A_0, A_1, A_2)
    {
        this.bool_0 = A_3;
    }

    internal void method_22(string A_0, object A_1)
    {
        if (A_1 != null)
        {
            if (A_1 is bool)
            {
                bool flag = (bool) A_1;
                this.vmethod_0(A_0, flag);
            }
            else if (A_1 is string)
            {
                string str = (string) A_1;
                this.method_24(A_0, str);
            }
            else if (A_1 is int)
            {
                int num = (int) A_1;
                this.method_28(A_0, num);
            }
            else if (A_1 is Color)
            {
                Color color = (Color) A_1;
                this.method_27(A_0, color);
            }
            else
            {
                string str2 = A_1.ToString();
                this.method_24(A_0, str2);
            }
        }
    }

    internal object method_23(object A_0, float A_1)
    {
        if (A_0 == null)
        {
            return null;
        }
        return Convert.ToInt32((float) (((float) A_0) * A_1));
    }

    internal void method_24(string A_0, string A_1)
    {
        int num = 0x12;
        if (Class567.smethod_16(A_1))
        {
            base.method_4(A_0);
            base.method_18(smethod_11(A_0) + BookmarkStart.b("丷嬹倻", num), A_1);
            base.method_5();
        }
    }

    internal void method_25(string A_0, string A_1)
    {
        int num = 7;
        if (A_1 != null)
        {
            base.method_4(A_0);
            base.method_18(smethod_11(A_0) + BookmarkStart.b("嬬丮崰", num), A_1);
            base.method_5();
        }
    }

    internal void method_26(string A_0, string A_1)
    {
        int num = 0x13;
        if (!Class567.smethod_16(A_1))
        {
            throw new InvalidOperationException(BookmarkStart.b("砸伺䤼娾ⱀ㍂ㅄ≆ⵈ歊㥌⁎煐⑒❔㹖ⵘ㹚絜㹞䅠ൢၤ୦ը䭪ɬᵮ兰ᙲᡴݶ൸ɺ嵼ॾꖈꮊ搜뎒ﲔ릘뾞펠욢풤튦삨\ud9aa\uc8ac쮮醰튲횴풶횸즺\ud9bc\ud6be꿀꓂돆ꛈ만꟎듐ꛔ듖뇘뻚냜뻞쿠", num));
        }
        this.method_24(A_0, A_1);
    }

    internal void method_27(string A_0, Color A_1)
    {
        this.method_24(A_0, Class114.smethod_12(A_1));
    }

    internal void method_28(string A_0, int A_1)
    {
        this.method_24(A_0, Class1041.smethod_8(A_1));
    }

    internal void method_29(string A_0, byte[] A_1)
    {
        if ((A_1 != null) && (A_1.Length > 0))
        {
            this.method_24(A_0, Class114.smethod_18(A_1));
        }
    }

    internal void method_30(string A_0, int A_1)
    {
        if (A_1 > 0)
        {
            this.method_24(A_0, Class1041.smethod_8(A_1));
        }
    }

    internal void method_31(string A_0, bool A_1)
    {
        if (A_1)
        {
            base.method_10(A_0);
        }
    }

    internal void method_32(string A_0, int A_1, int A_2)
    {
        if (A_1 != A_2)
        {
            this.method_28(A_0, A_1);
        }
    }

    internal void method_33(string A_0, params object[] A_1)
    {
        if (this.method_34(A_0, A_1))
        {
            base.method_5();
        }
    }

    internal bool method_34(string A_0, params object[] A_1)
    {
        int num = A_1.Length / 2;
        bool flag = false;
        for (int i = 0; i < num; i++)
        {
            object obj2 = A_1[(i * 2) + 1];
            if ((obj2 != null) && (!(obj2 is string) || !(((string) obj2) == "")))
            {
                flag = true;
                break;
            }
        }
        if (!flag)
        {
            return false;
        }
        base.method_4(A_0);
        for (int j = 0; j < num; j++)
        {
            string str = (string) A_1[j * 2];
            object obj3 = A_1[(j * 2) + 1];
            this.method_38(str, obj3);
        }
        return true;
    }

    internal void method_35(string A_0, object A_1, object A_2)
    {
        if ((A_1 != null) && !A_1.Equals(A_2))
        {
            this.method_36(A_0, A_1);
        }
    }

    internal void method_36(string A_0, object A_1)
    {
        int num = 6;
        if (A_1 is bool)
        {
            this.method_40(A_0, ((bool) A_1) ? BookmarkStart.b("堫", num) : BookmarkStart.b("䨫", num));
        }
        else if (A_1 is Color)
        {
            this.method_40(A_0, Class735.smethod_1((Color) A_1));
        }
        else
        {
            this.method_38(A_0, A_1);
        }
    }

    internal void method_37(string A_0, bool A_1, bool A_2)
    {
        int num = 14;
        if (A_1 != A_2)
        {
            base.method_18(A_0, A_1 ? BookmarkStart.b("䀳", num) : BookmarkStart.b("刳", num));
        }
    }

    internal void method_38(string A_0, object A_1)
    {
        int num = 5;
        if (A_1 != null)
        {
            if (A_1 is string)
            {
                string str2 = (string) A_1;
                this.method_40(A_0, str2);
            }
            else if (A_1 is int)
            {
                int num2 = (int) A_1;
                this.method_43(A_0, num2);
            }
            else if (A_1 is short)
            {
                short num4 = (short) A_1;
                this.method_43(A_0, num4);
            }
            else if (A_1 is float)
            {
                string str3 = A_1.ToString();
                this.method_40(A_0, str3);
            }
            else if (A_1 is double)
            {
                double num3 = (double) A_1;
                this.method_45(A_0, num3);
            }
            else if (A_1 is bool)
            {
                bool flag = (bool) A_1;
                this.vmethod_1(A_0, flag);
            }
            else if (A_1 is Color)
            {
                Color color = (Color) A_1;
                this.method_40(A_0, Class114.smethod_12(color));
            }
            else if (A_1 is DateTime)
            {
                DateTime time = (DateTime) A_1;
                this.method_40(A_0, Class1041.smethod_0(time));
            }
            else
            {
                if (A_1 == null)
                {
                    throw new InvalidOperationException(BookmarkStart.b("縪䌬䐮弰尲䈴夶ᤸ吺弼唾⑀⁂ㅄ杆㵈㉊㵌⩎煐㩒㭔睖๘⥚㑜⭞Ѡ≢ᅤ፦᭨ɪཬᩮհᙲ啴᩶ᱸེᕼၾ궂", num));
                }
                string str = A_1.ToString();
                this.method_40(A_0, str);
            }
        }
    }

    internal void method_39(string A_0, object A_1, object A_2)
    {
        if (A_1 == null)
        {
            A_1 = A_2;
        }
        this.method_38(A_0, A_1);
    }

    internal void method_40(string A_0, string A_1)
    {
        if (Class567.smethod_16(A_1))
        {
            base.method_18(A_0, A_1);
        }
    }

    internal void method_41(string A_0, string A_1, string A_2)
    {
        if (A_1 != A_2)
        {
            this.method_40(A_0, A_1);
        }
    }

    internal void method_42(string A_0, Color A_1)
    {
        base.method_18(A_0, Class114.smethod_12(A_1));
    }

    internal void method_43(string A_0, int A_1)
    {
        base.method_18(A_0, Class1041.smethod_8(A_1));
    }

    internal void method_44(string A_0, byte[] A_1)
    {
        base.method_18(A_0, Class114.smethod_18(A_1));
    }

    internal void method_45(string A_0, double A_1)
    {
        base.method_18(A_0, Class1041.smethod_46(A_1));
    }

    internal void method_46(string A_0, bool A_1, params object[] A_2)
    {
        int num = A_2.Length / 2;
        bool flag = false;
        for (int i = 0; i < num; i++)
        {
            Border border = (Border) A_2[(i * 2) + 1];
            if ((border != null) && !border.IsDefault)
            {
                flag = true;
                break;
            }
        }
        if (flag)
        {
            base.method_4(A_0);
            for (int j = 0; j < num; j++)
            {
                this.method_47((string) A_2[j * 2], (Border) A_2[(j * 2) + 1], A_1);
            }
            base.method_5();
        }
    }

    internal void method_47(string A_0, Border A_1, bool A_2)
    {
        int num = 0x13;
        if ((A_1 != null) && (A_1.IsChanged || (A_1.BorderType != BorderStyle.None)))
        {
            if (A_1.BorderType == BorderStyle.Cleared)
            {
                this.method_33(A_0, new object[] { BookmarkStart.b("丸ĺ䬼帾ⵀ", num), BookmarkStart.b("圸刺儼", num) });
            }
            else
            {
                this.vmethod_3(A_0, A_1, A_2);
            }
        }
    }

    internal void method_48(string A_0, string A_1)
    {
        int num = 7;
        if (Class567.smethod_16(A_1))
        {
            this.method_49(A_0, A_1, BookmarkStart.b("䤬圮倰", num));
        }
    }

    protected void method_49(string A_0, string A_1, string A_2)
    {
        this.method_33(A_0, new object[] { BookmarkStart.b("崩ᘫ夭", 4), A_1, BookmarkStart.b("崩ᘫ娭䤯䈱儳", 4), A_2 });
    }

    internal void method_50(string A_0, string A_1, string A_2, string A_3, string A_4)
    {
        int num = 10;
        if ((Class567.smethod_16(A_1) || Class567.smethod_16(A_2)) || (Class567.smethod_16(A_3) || Class567.smethod_16(A_4)))
        {
            base.method_4(A_0);
            this.method_48(BookmarkStart.b("䜯࠱䀳夵䠷", num), A_1);
            this.method_48(BookmarkStart.b("䜯࠱堳匵帷丹", num), A_2);
            this.method_48(BookmarkStart.b("䜯࠱嘳夵䰷丹医匽", num), A_3);
            this.method_48(BookmarkStart.b("䜯࠱䘳張強刹䠻", num), A_4);
            base.method_5();
        }
    }

    internal void method_51(string A_0, string A_1, string A_2)
    {
        this.method_40(A_0, string.Format(BookmarkStart.b("䈸଺䀼ጾ㩀牂㡄", 0x13), A_1, A_2).TrimEnd(new char[] { ',' }));
    }

    internal void method_52(string A_0, string A_1, string A_2, string A_3)
    {
        this.method_40(A_0, string.Format(BookmarkStart.b("倪ᴬ刮ᴰ䠲д䨶ᔸ䀺༼䈾", 5), A_1, A_2, A_3).TrimEnd(new char[] { ',' }));
    }

    internal void method_53(string A_0, Class15 A_1)
    {
        if (A_1 != null)
        {
            int num = (int) A_1.method_49();
            switch (A_1.method_51())
            {
                case FtsWidth.Auto:
                    num = 0;
                    break;

                case FtsWidth.Percentage:
                    num = (int) (A_1.method_49() * 50f);
                    break;

                case FtsWidth.Point:
                    num = (int) (A_1.method_49() * 20f);
                    break;
            }
            this.method_49(A_0, Class1041.smethod_8(num), Class417.smethod_33(A_1.method_51()));
        }
    }

    internal void method_54(string A_0, Class15 A_1)
    {
        if (A_1 != null)
        {
            int num = (int) A_1.method_49();
            switch (A_1.method_51())
            {
                case FtsWidth.Auto:
                    num = 0;
                    break;

                case FtsWidth.Percentage:
                    num = (int) (A_1.method_49() * 50f);
                    break;

                case FtsWidth.Point:
                    num = (int) A_1.method_49();
                    break;
            }
            this.method_49(A_0, Class1041.smethod_8(num), Class417.smethod_33(A_1.method_51()));
        }
    }

    internal void method_55()
    {
        this.int_0++;
    }

    internal void method_56()
    {
        this.int_0--;
    }

    internal bool method_57()
    {
        return (this.int_0 > 0);
    }

    protected static object smethod_10(bool A_0)
    {
        if (A_0)
        {
            return A_0;
        }
        return null;
    }

    internal static string smethod_11(string A_0)
    {
        int index = A_0.IndexOf(':');
        if (index > 0)
        {
            return A_0.Substring(0, index + 1);
        }
        return "";
    }

    internal virtual void vmethod_0(string A_0, bool A_1)
    {
        int num = 0x13;
        if (A_1)
        {
            base.method_10(A_0);
        }
        else
        {
            this.method_24(A_0, BookmarkStart.b("嘸崺嬼", num));
        }
    }

    internal virtual void vmethod_1(string A_0, bool A_1)
    {
        int num = 0x13;
        if (this.bool_0)
        {
            base.method_18(A_0, A_1 ? BookmarkStart.b("嘸唺", num) : BookmarkStart.b("嘸崺嬼", num));
        }
        else
        {
            base.method_18(A_0, A_1 ? BookmarkStart.b("䴸䤺䠼娾", num) : BookmarkStart.b("弸娺儼䰾⑀", num));
        }
    }

    internal virtual void vmethod_10(Class578 A_0, int A_1)
    {
        throw new NotImplementedException(BookmarkStart.b("电圷吹弻䰽┿㙁⅃晅⭇♉ⵋ㵍⍏㝑❓癕⭗㉙㍛⭝౟١䑣ཥէᩩk୭ᵯ᝱ᩳɵ噷", 0x10));
    }

    internal virtual void vmethod_11(Class579 A_0, int A_1)
    {
        throw new NotImplementedException(BookmarkStart.b("猯崱娳唵䨷弹䠻嬽怿⅁⡃❅㭇㥉⥋㵍灏⅑㱓㥕ⵗ㙙㡛繝य़ཡᑣ੥൧ݩ५mѯ山", 10));
    }

    internal virtual void vmethod_12(Class579 A_0, string A_1, bool A_2)
    {
        throw new NotImplementedException(BookmarkStart.b("眳夵嘷夹主嬽㐿❁摃╅⑇⭉㽋㵍㕏⅑瑓╕し㕙⥛㉝џ䉡ൣ୥ᡧ٩५ͭᕯᱱs塵", 14));
    }

    internal virtual bool vmethod_13()
    {
        return false;
    }

    internal virtual void vmethod_2(string A_0, bool A_1)
    {
        int num = 12;
        if (A_1)
        {
            base.method_18(A_0, this.bool_0 ? BookmarkStart.b("崱娳", num) : BookmarkStart.b("䘱䘳䌵崷", num));
        }
    }

    protected virtual void vmethod_3(string A_0, Border A_1, bool A_2)
    {
    }

    internal virtual void vmethod_4(Class16 A_0)
    {
    }

    internal virtual void vmethod_5(Class580 A_0, string A_1, int A_2)
    {
        throw new NotImplementedException(BookmarkStart.b("欧䔩䈫䴭䈯圱䀳匵ᠷ夹倻弽㌿ㅁ⅃㕅桇㥉⑋⅍╏㹑こ癕ㅗ㝙ⱛ㉝՟ཡţࡥᱧ䑩", 2));
    }

    internal virtual void vmethod_6(Class579 A_0, int A_1)
    {
        throw new NotImplementedException(BookmarkStart.b("樨䐪䌬䰮䌰嘲䄴制ᤸ堺儼帾㉀あ⁄㑆楈㡊╌⁎⑐㽒ㅔ睖じ㙚ⵜ㍞Ѡ๢d०ᵨ䕪", 3));
    }

    internal virtual void vmethod_7(Class579 A_0, string A_1, bool A_2)
    {
        throw new NotImplementedException(BookmarkStart.b("瀲娴夶娸䤺堼䬾⑀捂♄⭆⡈㡊㹌⩎≐獒♔㽖㙘⹚ㅜ㭞䅠੢ࡤᝦը๪l੮ὰݲ孴", 13));
    }

    internal virtual void vmethod_8()
    {
        throw new NotImplementedException(BookmarkStart.b("笷唹刻崽㈿❁ぃ⍅桇⥉⁋⽍⍏⅑ㅓ╕硗⥙㑛ㅝᕟ๡c䙥ŧݩᱫɭᕯάᅳᡵ౷呹", 0x12));
    }

    internal virtual void vmethod_9(EditRevisionType A_0, bool A_1)
    {
        throw new NotImplementedException(BookmarkStart.b("焱嬳堵嬷䠹夻䨽┿扁❃⩅⥇㥉㽋⭍⍏牑❓㹕㝗⽙せ㩝䁟ୡॣᙥѧཀྵū୭ṯٱ婳", 12));
    }
}

