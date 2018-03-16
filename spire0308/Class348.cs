using Spire.Doc;
using Spire.Doc.Documents.Converters.BinaryDoc;
using System;
using System.IO;

internal class Class348
{
    private readonly Class152 class152_0;
    private readonly Class156 class156_0;
    private readonly Class166 class166_0;
    private readonly SubDocumentType subDocumentType_0;

    internal Class348(SubDocumentType A_0)
    {
        int num = 0x13;
        if ((A_0 != SubDocumentType.Main) && (A_0 != SubDocumentType.Header))
        {
            throw new ArgumentException(BookmarkStart.b("䨸为弼笾⹀⁂ᅄ㹆㥈⹊", num));
        }
        this.subDocumentType_0 = A_0;
        this.class152_0 = new Class152();
        this.class166_0 = new Class166();
        this.class156_0 = new Class156();
    }

    internal Class348(SubDocumentType A_0, Class703 A_1, BinaryReader A_2) : this(A_0)
    {
        bool flag;
        Class1111 class2 = (flag = this.subDocumentType_0 == SubDocumentType.Main) ? A_1.class597_0.class1111_40 : A_1.class597_0.class1111_41;
        this.class152_0.method_23(A_2, class2);
        Class1111 class3 = flag ? A_1.class597_0.class1111_56 : A_1.class597_0.class1111_58;
        this.class166_0.method_23(A_2, class3);
        Class1111 class4 = flag ? A_1.class597_0.class1111_75 : A_1.class597_0.class1111_76;
        this.class156_0.method_23(A_2, class4);
    }

    internal Class152 method_0()
    {
        return this.class152_0;
    }

    internal Class166 method_1()
    {
        return this.class166_0;
    }

    internal Class156 method_2()
    {
        return this.class156_0;
    }

    internal void method_3(Class703 A_0, BinaryWriter A_1)
    {
        int position = (int) A_1.BaseStream.Position;
        int num2 = this.class152_0.vmethod_1(A_1);
        Class1111 class2 = new Class1111(position, num2);
        position = (int) A_1.BaseStream.Position;
        num2 = this.class166_0.vmethod_1(A_1);
        Class1111 class3 = new Class1111(position, num2);
        position = (int) A_1.BaseStream.Position;
        num2 = this.class156_0.vmethod_1(A_1);
        Class1111 class4 = new Class1111(position, num2);
        if (this.subDocumentType_0 == SubDocumentType.Main)
        {
            A_0.class597_0.class1111_40 = class2;
            A_0.class597_0.class1111_56 = class3;
            A_0.class597_0.class1111_75 = class4;
        }
        else
        {
            A_0.class597_0.class1111_41 = class2;
            A_0.class597_0.class1111_58 = class3;
            A_0.class597_0.class1111_76 = class4;
        }
    }

    internal Class347 method_4(int A_0)
    {
        int num = this.class152_0.method_12(A_0);
        if (num < 0)
        {
            return null;
        }
        return this.class152_0.method_25(num);
    }

    internal Class347 method_5(int A_0)
    {
        int num = 0x10;
        for (int i = 0; i < this.class152_0.method_4(); i++)
        {
            Class347 class2 = this.class152_0.method_25(i);
            if (class2.int_1 == A_0)
            {
                return class2;
            }
        }
        throw new InvalidOperationException(BookmarkStart.b("电夷吹刻儽㐿扁≃⽅♇⹉汋⽍㹏牑ቓՕࡗ᭙牛", num));
    }

    internal Class761 method_6(int A_0)
    {
        for (int i = 0; i < this.class166_0.method_4(); i++)
        {
            Class480 class2 = this.class166_0.method_25(i);
            if (class2.int_4 == A_0)
            {
                return new Class761(this.class166_0.method_16(i), this.class166_0.method_16(i + 1), class2);
            }
        }
        return null;
    }
}

