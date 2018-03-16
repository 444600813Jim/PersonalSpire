using Spire.Doc.Collections;
using Spire.Doc.Documents;
using Spire.Doc.Documents.Converters.BinaryDoc.Dofr;
using Spire.Doc.Formatting;
using System;
using System.Collections;
using System.IO;

internal class Class1152
{
    private const int int_0 = 0;
    private const int int_1 = 0x7bc0;

    private Class1152()
    {
    }

    internal static Class14 smethod_0(Class703 A_0, BinaryReader A_1, ListStyleCollection A_2)
    {
        Class1111 class2 = A_0.class1057_0.class1111_6;
        if (class2.int_1 == 0)
        {
            return null;
        }
        A_1.BaseStream.Position = class2.int_0;
        Stack stack = new Stack();
        Class14 class3 = null;
        Class14 class4 = null;
        while ((A_1.BaseStream.Position - class2.int_0) < class2.int_1)
        {
            bool flag;
            int num;
            int num2;
            int num3;
            A_1.ReadInt32();
            switch (A_1.ReadInt32())
            {
                case 0:
                {
                    class3 = new Class14();
                    class4 = class3;
                    continue;
                }
                case 1:
                {
                    if (stack.Count > 0)
                    {
                        class4 = new Class14();
                        ((Class14) stack.Peek()).method_121().method_2(class4);
                    }
                    class4.method_56((FrameDividerPositionType) A_1.ReadInt32());
                    class4.method_58(A_1.ReadInt32());
                    class4.method_60((FrameLayoutType) A_1.ReadInt32());
                    A_1.ReadInt32();
                    class4.method_62(A_1.ReadInt32());
                    class4.method_67(A_1.ReadInt32());
                    class4.method_115((FrameScrollType) A_1.ReadInt32());
                    int num6 = A_1.ReadInt32();
                    class4.method_117((num6 & 1) != 0);
                    class4.method_119((num6 & 2) != 0);
                    A_1.ReadInt32();
                    continue;
                }
                case 2:
                {
                    if ((A_1.ReadInt32() & 1) == 0)
                    {
                        break;
                    }
                    stack.Push(class4);
                    continue;
                }
                case 3:
                {
                    class4.method_52(Class813.smethod_1(A_1, true, true));
                    continue;
                }
                case 4:
                {
                    class4.method_54(Class813.smethod_1(A_1, true, true));
                    continue;
                }
                case 5:
                {
                    class3.method_127(A_1.ReadInt32());
                    class3.method_125(Class624.smethod_7(A_1.ReadInt32()));
                    int num7 = A_1.ReadInt32();
                    bool flag2 = (num7 & 1) != 0;
                    flag = (num7 & 2) != 0;
                    if (!flag2)
                    {
                        goto Label_01D3;
                    }
                    class3.method_123(FramesetBorderType.None);
                    continue;
                }
                case 6:
                    num = A_1.ReadInt32();
                    num2 = 0;
                    goto Label_0228;

                default:
                {
                    continue;
                }
            }
            class4 = (Class14) stack.Pop();
            continue;
        Label_01D3:
            if (flag)
            {
                class3.method_123(FramesetBorderType.Raised);
            }
            else
            {
                class3.method_123(FramesetBorderType.Simple);
            }
            continue;
        Label_01F5:
            num3 = A_1.ReadInt16();
            int num5 = A_1.ReadUInt16() & 0xfff;
            ListStyle style = A_2[num3];
            style.ListStyleIstd = num5;
            num2++;
        Label_0228:
            if (num2 < num)
            {
                goto Label_01F5;
            }
        }
        return class3;
    }

    internal static void smethod_1(Class703 A_0, BinaryWriter A_1, ListStyleCollection A_2, Class14 A_3)
    {
        if ((A_3 != null) || (A_2.Count != 0))
        {
            A_0.class1057_0.class1111_6.int_0 = (int) A_1.BaseStream.Position;
            if ((A_3 != null) && A_3.method_120())
            {
                smethod_3(A_1, A_3, true);
            }
            if ((A_2.ilist_0 != null) && (A_2.ilist_0.Count > 0))
            {
                smethod_2(A_1, A_2);
            }
            A_0.class1057_0.class1111_6.int_1 = ((int) A_1.BaseStream.Position) - A_0.class1057_0.class1111_6.int_0;
        }
    }

    private static void smethod_10(BinaryWriter A_0, bool A_1)
    {
        long position = A_0.BaseStream.Position;
        smethod_4(A_0, 0);
        smethod_4(A_0, 2);
        smethod_4(A_0, A_1 ? 1 : 0);
        smethod_5(A_0, position);
    }

    private static bool smethod_11(int A_0, int A_1, int A_2)
    {
        return ((A_1 <= A_0) && (A_0 <= A_2));
    }

    private static void smethod_2(BinaryWriter A_0, ListStyleCollection A_1)
    {
        long position = A_0.BaseStream.Position;
        smethod_4(A_0, 0);
        smethod_4(A_0, 6);
        smethod_4(A_0, A_1.ilist_0.Count);
        for (int i = 0; i < A_1.ilist_0.Count; i++)
        {
            ListStyle style = A_1.ilist_0[i];
            A_0.Write((short) (i + 1));
            int listStyleIstd = style.ListStyleIstd;
            A_0.Write((short) listStyleIstd);
        }
        smethod_5(A_0, position);
    }

    private static void smethod_3(BinaryWriter A_0, Class14 A_1, bool A_2)
    {
        if (A_2)
        {
            smethod_6(A_0);
        }
        smethod_8(A_0, A_1);
        smethod_7(A_0, Dofrt.DofrtFsnName, A_1.method_51());
        smethod_7(A_0, Dofrt.DofrtFsnFnm, A_1.method_53());
        if (A_2)
        {
            smethod_9(A_0, A_1);
        }
        if (A_1.method_120())
        {
            smethod_10(A_0, true);
            using (IEnumerator enumerator = A_1.method_121().System.Collections.IEnumerable.GetEnumerator())
            {
                while (enumerator.MoveNext())
                {
                    Class14 current = (Class14) enumerator.Current;
                    smethod_3(A_0, current, false);
                }
            }
            smethod_10(A_0, false);
        }
    }

    private static void smethod_4(BinaryWriter A_0, int A_1)
    {
        A_0.Write(A_1);
    }

    private static void smethod_5(BinaryWriter A_0, long A_1)
    {
        long position = A_0.BaseStream.Position;
        A_0.BaseStream.Position = A_1;
        smethod_4(A_0, (int) (position - A_1));
        A_0.BaseStream.Position = position;
    }

    private static void smethod_6(BinaryWriter A_0)
    {
        long position = A_0.BaseStream.Position;
        smethod_4(A_0, 0);
        smethod_4(A_0, 0);
        smethod_5(A_0, position);
    }

    private static void smethod_7(BinaryWriter A_0, Dofrt A_1, string A_2)
    {
        if (Class567.smethod_16(A_2))
        {
            long position = A_0.BaseStream.Position;
            smethod_4(A_0, 0);
            smethod_4(A_0, (int) A_1);
            Class813.smethod_2(A_2, 0x7fffffff, A_0, true, true);
            smethod_5(A_0, position);
        }
    }

    private static void smethod_8(BinaryWriter A_0, Class14 A_1)
    {
        long position = A_0.BaseStream.Position;
        smethod_4(A_0, 0);
        smethod_4(A_0, 1);
        smethod_4(A_0, (int) A_1.method_55());
        smethod_4(A_0, A_1.method_57());
        smethod_4(A_0, (int) A_1.method_59());
        smethod_4(A_0, A_1.method_120() ? 1 : 2);
        smethod_4(A_0, A_1.method_61());
        smethod_4(A_0, A_1.method_66());
        smethod_4(A_0, (int) A_1.method_114());
        int num2 = 0;
        num2 = 0 | (A_1.method_116() ? 1 : 0);
        num2 |= A_1.method_118() ? 2 : 0;
        smethod_4(A_0, num2);
        smethod_4(A_0, 6);
        smethod_5(A_0, position);
    }

    private static void smethod_9(BinaryWriter A_0, Class14 A_1)
    {
        if ((!A_1.method_124().IsEmpty || (A_1.method_126() != 0)) || (A_1.method_122() != FramesetBorderType.Simple))
        {
            int position = (int) A_0.BaseStream.Position;
            smethod_4(A_0, 0);
            smethod_4(A_0, 5);
            smethod_4(A_0, smethod_11(A_1.method_126(), 0, 0x7bc0) ? A_1.method_126() : 0);
            smethod_4(A_0, Class624.smethod_6(A_1.method_124()));
            switch (A_1.method_122())
            {
                case FramesetBorderType.None:
                    smethod_4(A_0, 1);
                    break;

                case FramesetBorderType.Raised:
                    smethod_4(A_0, 2);
                    break;

                default:
                    smethod_4(A_0, 0);
                    break;
            }
            smethod_5(A_0, (long) position);
        }
    }
}

