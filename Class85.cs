using Spire.Doc;
using System;
using System.Collections;
using System.Diagnostics;
using System.Text;

[DebuggerStepThrough]
internal class Class85
{
    public static readonly byte[] byte_0 = new byte[0];

    private Class85()
    {
    }

    public static bool smethod_0(char[] A_0, char[] A_1)
    {
        if (A_0.Length != A_1.Length)
        {
            return false;
        }
        for (int i = 0; i < A_0.Length; i++)
        {
            if (A_0[i] != A_1[i])
            {
                return false;
            }
        }
        return true;
    }

    public static bool smethod_1(byte[] A_0, byte[] A_1)
    {
        if (A_0.Length != A_1.Length)
        {
            return false;
        }
        for (int i = 0; i < A_0.Length; i++)
        {
            if (A_0[i] != A_1[i])
            {
                return false;
            }
        }
        return true;
    }

    public static void smethod_10(byte[] A_0, byte A_1, int A_2, int A_3)
    {
        for (int i = 0; i < A_3; i++)
        {
            A_0[i + A_2] = A_1;
        }
    }

    public static bool smethod_11(byte[] A_0, byte[] A_1, int A_2)
    {
        for (int i = 0; i < A_2; i++)
        {
            if (A_0[i] != A_1[i])
            {
                return false;
            }
        }
        return true;
    }

    public static void smethod_12(char[] A_0, char[] A_1)
    {
        int num = 2;
        int num2 = Math.Min(A_0.Length, A_1.Length);
        for (int i = 0; i < num2; i++)
        {
            if (A_0[i] != A_1[i])
            {
                throw new InvalidOperationException(string.Format(BookmarkStart.b("椧堩師伭䤯ሱ䈳圵吷伹夻䴽怿⍁㙃⍅桇⹉╋⡍㙏㝑♓㍕㙗⹙籛㽝ᑟ䉡ᑣ॥᭧ͩᡫݭὯᱱ味䙵wŹ䱻䑽\ud87f\ub081旅ꪅꢇ몉ꆏꢑ첓꒕뚙벛꺝\ud89f\ud9a1隣鲥颩톫肭", num), i, A_0[i], A_1[i]));
            }
        }
        if (A_0.Length != A_1.Length)
        {
            throw new InvalidOperationException(string.Format(BookmarkStart.b("椧堩師伭䤯ሱ堳匵嘷崹䠻嘽㌿扁╃㑅ⵇ橉⡋❍㙏㑑ㅓ⑕㵗㑙⡛摝䁟ᥡ呣᭥䡧୩ɫ੭偯ॱ䕳୵噷", num), A_0.Length, A_1.Length));
        }
    }

    public static void smethod_13(byte[] A_0, byte[] A_1)
    {
        int num = 9;
        int num2 = Math.Min(A_0.Length, A_1.Length);
        for (int i = 0; i < num2; i++)
        {
            if (A_0[i] != A_1[i])
            {
                throw new InvalidOperationException(string.Format(BookmarkStart.b("渮䌰䄲吴丶ᤸ䴺尼匾㑀♂㙄杆⡈㥊⡌潎㕐㩒㍔ㅖ㱘⥚㡜ㅞᕠ䍢Ѥ፦䥨᭪ɬᱮᡰݲᱴᡶ᝸孺䵼ݾ婢뎂뾄\udf86\ubb88ꆌ꾎ꆐꚖꎘ쎚꾜趠莢閤\udfa6\ud2a8馪鞬莰캲鮴", num), i, A_0[i], A_1[i]));
            }
        }
        if (A_0.Length != A_1.Length)
        {
            throw new InvalidOperationException(string.Format(BookmarkStart.b("渮䌰䄲吴丶ᤸ场堼儾♀㝂ⵄ㑆楈⩊㽌⩎煐㝒㱔ㅖ㽘㹚⽜㩞འᝢ彤䝦ቨ孪ၬ佮ၰᵲᅴ坶ɸ䩺|兾", num), A_0.Length, A_1.Length));
        }
    }

    public static void smethod_14(short[] A_0, short[] A_1)
    {
        int num = 7;
        int num2 = Math.Min(A_0.Length, A_1.Length);
        for (int i = 0; i < num2; i++)
        {
            if (A_0[i] != A_1[i])
            {
                throw new InvalidOperationException(string.Format(BookmarkStart.b("氬崮䌰刲䰴᜶伸娺儼䨾⑀あ敄♆㭈⹊浌⭎㡐㕒㍔㉖⭘㹚㍜⭞䅠ɢᅤ䝦ᥨѪṬٮհᩲᩴ᥶奸䭺ռѾ놀릂\udd84\ub586꞊권뾎꒔궖솘ꦚ뎞膠鎢\udda4\udca6鮨醪鶮첰鶲", num), i, A_0[i], A_1[i]));
            }
        }
        if (A_0.Length != A_1.Length)
        {
            throw new InvalidOperationException(string.Format(BookmarkStart.b("氬崮䌰刲䰴᜶唸帺匼堾㕀⭂㙄杆⡈㥊⡌潎㕐㩒㍔ㅖ㱘⥚㡜ㅞᕠ奢䕤ᱦ奨ᙪ䵬๮ὰᝲ啴౶䡸ٺ卼", num), A_0.Length, A_1.Length));
        }
    }

    public static void smethod_15(float[] A_0, float[] A_1, float A_2)
    {
        int num = 2;
        int num2 = Math.Min(A_0.Length, A_1.Length);
        for (int i = 0; i < num2; i++)
        {
            if ((A_0[i] - A_1[i]) > A_2)
            {
                throw new InvalidOperationException(string.Format(BookmarkStart.b("椧堩師伭䤯ሱ䈳圵吷伹夻䴽怿⍁㙃⍅桇⹉╋⡍㙏㝑♓㍕㙗⹙籛㽝ᑟ䉡ᑣ॥᭧ͩᡫݭὯᱱ味൵䡷ݹ䙻幽ﭿ뎁旅ꚅﺇ黎ꊋ꺍ꂑ뚕肟욡솣쪥\udca7\ucba9貫햭莯쾱骳", num), new object[] { i, A_0[i], A_1[i], A_2 }));
            }
        }
        if (A_0.Length != A_1.Length)
        {
            throw new InvalidOperationException(string.Format(BookmarkStart.b("椧堩師伭䤯ሱ堳匵嘷崹䠻嘽㌿扁╃㑅ⵇ橉⡋❍㙏㑑ㅓ⑕㵗㑙⡛摝䁟ᥡ呣᭥䡧୩ɫ੭偯ॱ䕳୵噷", num), A_0.Length, A_1.Length));
        }
    }

    public static void smethod_16(byte[] A_0, byte[] A_1)
    {
        int num = 14;
        if (A_0.Length != A_1.Length)
        {
            throw new InvalidOperationException(string.Format(BookmarkStart.b("申䐵䨷嬹䔻ḽⰿ❁⩃ⅅ㱇≉㽋湍ㅏ⁑ㅓ癕㱗㍙㩛㡝՟ၡţࡥᱧ偩䱫ᕭ䁯ཱ味᝵ᙷṹ屻ս녿ﾁꪃ", num), A_0.Length, A_1.Length));
        }
        for (int i = 0; i < A_0.Length; i++)
        {
        }
    }

    public static byte[] smethod_17(byte[] A_0, int A_1)
    {
        byte[] destinationArray = new byte[A_1];
        if (A_1 > A_0.Length)
        {
            A_1 = A_0.Length;
        }
        Array.Copy(A_0, destinationArray, A_1);
        return destinationArray;
    }

    public static int[] smethod_18(ArrayList A_0)
    {
        int[] numArray = new int[A_0.Count];
        for (int i = 0; i < numArray.Length; i++)
        {
            numArray[i] = (int) A_0[i];
        }
        return numArray;
    }

    public static bool smethod_19(byte[] A_0)
    {
        return ((A_0 != null) && (A_0.Length > 0));
    }

    public static bool smethod_2(int[] A_0, int[] A_1)
    {
        if (A_0 != A_1)
        {
            if ((A_0 == null) || (A_1 == null))
            {
                return false;
            }
            if (A_0.Length != A_1.Length)
            {
                return false;
            }
            for (int i = 0; i < A_0.Length; i++)
            {
                if (A_0[i] != A_1[i])
                {
                    return false;
                }
            }
        }
        return true;
    }

    public static bool smethod_20(string[] A_0)
    {
        return ((A_0 != null) && (A_0.Length > 0));
    }

    public static string smethod_21(string[] A_0)
    {
        if (!smethod_20(A_0))
        {
            return "";
        }
        return string.Join("", A_0);
    }

    public static bool smethod_3(float[] A_0, float[] A_1)
    {
        if (A_0.Length != A_1.Length)
        {
            return false;
        }
        for (int i = 0; i < A_0.Length; i++)
        {
            if (A_0[i] != A_1[i])
            {
                return false;
            }
        }
        return true;
    }

    public static string smethod_4(byte[] A_0)
    {
        int num = 6;
        if (A_0 != null)
        {
            return smethod_5(A_0, 0, A_0.Length);
        }
        return BookmarkStart.b("戫嬭尯帱", num);
    }

    public static string smethod_5(byte[] A_0, int A_1, int A_2)
    {
        int num = 3;
        if (A_0 == null)
        {
            return BookmarkStart.b("木帪䄬䌮", num);
        }
        StringBuilder builder = new StringBuilder();
        while (A_2 > 0)
        {
            builder.AppendFormat(BookmarkStart.b("刨ᬪᜬ眮̰串ᔴ", num), A_0[A_1]);
            A_1++;
            A_2--;
        }
        return builder.ToString();
    }

    public static string smethod_6(float[] A_0)
    {
        int num = 13;
        StringBuilder builder = new StringBuilder(A_0.Length * 10);
        builder.Append(BookmarkStart.b("栲", 13));
        bool flag = true;
        foreach (float num3 in A_0)
        {
            if (!flag)
            {
                builder.Append(BookmarkStart.b("ἲᔴ", num));
            }
            else
            {
                flag = false;
            }
            builder.Append(num3);
        }
        builder.Append(BookmarkStart.b("渲", num));
        return builder.ToString();
    }

    public static int smethod_7(int[] A_0, int A_1, int A_2, int A_3)
    {
        int num = A_1;
        int num2 = (A_1 + A_2) - 1;
        while (num <= num2)
        {
            int index = (num + num2) >> 1;
            int num4 = A_0[index];
            if (num4 == A_3)
            {
                return index;
            }
            if (num4 < A_3)
            {
                num = index + 1;
            }
            else
            {
                num2 = index - 1;
            }
        }
        return ~num;
    }

    public static int smethod_8(byte[] A_0, int A_1, int A_2, byte A_3)
    {
        int num = A_1;
        int num2 = (A_1 + A_2) - 1;
        while (num <= num2)
        {
            int index = (num + num2) >> 1;
            byte num4 = A_0[index];
            if (num4 == A_3)
            {
                return index;
            }
            if (num4 < A_3)
            {
                num = index + 1;
            }
            else
            {
                num2 = index - 1;
            }
        }
        return ~num;
    }

    public static int smethod_9(float[] A_0, int A_1, int A_2, float A_3)
    {
        int num = A_1;
        int num2 = (A_1 + A_2) - 1;
        while (num <= num2)
        {
            int index = (num + num2) >> 1;
            float num4 = A_0[index];
            if (num4 == A_3)
            {
                return index;
            }
            if (num4 < A_3)
            {
                num = index + 1;
            }
            else
            {
                num2 = index - 1;
            }
        }
        return ~num;
    }
}

