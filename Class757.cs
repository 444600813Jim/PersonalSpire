using Spire.Doc;
using Spire.Doc.Collections;
using Spire.Doc.Documents;
using Spire.Doc.Documents.Converters.BinaryDoc;
using System;
using System.IO;

internal class Class757
{
    internal static TabCollection smethod_0(BinaryReader A_0, TabCollection A_1, bool A_2)
    {
        int num = A_0.ReadByte();
        int[] numArray = new int[num];
        for (int i = 0; i < num; i++)
        {
            numArray[i] = A_0.ReadInt16();
        }
        int[] numArray3 = null;
        if (A_2)
        {
            numArray3 = new int[num];
            for (int n = 0; n < num; n++)
            {
                numArray3[n] = A_0.ReadInt16();
            }
        }
        for (int j = 0; j < num; j++)
        {
            Tab tab2 = new Tab(A_1.Document, ((float) numArray[j]) / 20f, TabJustification.Clear, TabLeader.NoLeader) {
                DeletePosition = numArray[j],
                Position = 0f
            };
            A_1.method_6(tab2);
        }
        int num6 = A_0.ReadByte();
        int[] numArray2 = new int[num6];
        for (int k = 0; k < num6; k++)
        {
            numArray2[k] = A_0.ReadInt16();
        }
        byte[] buffer = new byte[num6];
        Stream baseStream = A_0.BaseStream;
        int num8 = (int) (baseStream.Length - baseStream.Position);
        baseStream.Read(buffer, 0, Math.Min(num6, num8));
        for (int m = 0; m < num6; m++)
        {
            if ((m > 0) && (numArray2[m] <= numArray2[m - 1]))
            {
                return A_1;
            }
            Tab tab = A_1.AddTab(((float) numArray2[m]) / 20f, ((TabJustification) buffer[m]) & TabJustification.Clear, (TabLeader) ((buffer[m] & 0x38) >> 3));
            if (tab.Justification == (TabJustification.Bar | TabJustification.Centered))
            {
                tab.Justification = TabJustification.Left;
            }
            tab.Undocumented40 = (buffer[m] & 0x40) != 0;
        }
        return A_1;
    }

    internal static void smethod_1(TabCollection A_0, Class345 A_1)
    {
        if (A_0.Count != 0)
        {
            int num = 0;
            int num2 = 0;
            for (int i = 0; i < A_0.Count; i++)
            {
                if (!A_0[i].IsClear && ((A_0[i].Position != 0f) || (A_0[i].DeletePosition == 0f)))
                {
                    num2++;
                }
                else
                {
                    num++;
                }
            }
            A_1.method_5(SprmCode.PChgTabs);
            int num4 = ((((1 + (num * 2)) + 0) + 1) + (num2 * 2)) + num2;
            A_1.Write((byte) num4);
            A_1.Write((byte) num);
            for (int j = 0; j < A_0.Count; j++)
            {
                if (A_0[j].IsClear || ((A_0[j].Position == 0f) && (A_0[j].DeletePosition != 0f)))
                {
                    A_1.Write((short) A_0[j].DeletePosition);
                }
            }
            A_1.Write((byte) num2);
            for (int k = 0; k < A_0.Count; k++)
            {
                if (!A_0[k].IsClear && ((A_0[k].Position != 0f) || (A_0[k].DeletePosition == 0f)))
                {
                    A_1.Write((short) Class59.smethod_8(A_0[k].Position * 20f, 0));
                }
            }
            for (int m = 0; m < A_0.Count; m++)
            {
                Tab tab = A_0[m];
                if (!A_0[m].IsClear && ((A_0[m].Position != 0f) || (A_0[m].DeletePosition == 0f)))
                {
                    int num8 = 0;
                    num8 = (int) (TabJustification.Left | tab.Justification);
                    num8 |= ((int) tab.TabLeader) << 3;
                    num8 |= tab.Undocumented40 ? 0x40 : 0;
                    A_1.Write((byte) num8);
                }
            }
        }
    }
}

