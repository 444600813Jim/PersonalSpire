using Spire.Doc;
using Spire.Doc.Documents;
using Spire.Doc.Fields;
using Spire.Layouting;
using System;
using System.Drawing;
using System.Reflection;

[DefaultMember("Item")]
internal class Class65 : Interface3
{
    private int int_0;
    private int int_1;
    private Interface1 interface1_0;
    private Interface3 interface3_0;

    public Class65(Interface3 A_0)
    {
        this.interface3_0 = A_0;
        this.interface1_0 = null;
        this.int_0 = this.interface3_0.imethod_3();
        this.int_1 = 0;
    }

    public Class65(Interface3 A_0, Interface1 A_1, int A_2)
    {
        int num = 0x11;
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("吶嘸唺䤼帾⡀ⵂ⁄㕆", num));
        }
        if (A_1 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("吶䰸䤺似娾⽀㝂ل⽆⁈❊⥌", num));
        }
        if (A_2 < 0)
        {
            throw new ArgumentOutOfRangeException(BookmarkStart.b("儶倸䤺丼䬾ࡀⵂ⅄≆ㅈ", num), A_2, BookmarkStart.b("愶堸场䠼娾慀⁂⑄⥆楈╊≌㭎煐ㅒご睖㕘㹚⹜ⱞ䅠卢", num));
        }
        this.interface3_0 = A_0;
        this.interface1_0 = A_1;
        this.int_0 = A_2;
    }

    public Interface1 imethod_4(int A_0)
    {
        if (A_0 == 0)
        {
            return this.interface1_0;
        }
        return this.interface3_0.imethod_4(A_0 + this.int_0);
    }

    Interface23 Interface1.imethod_0()
    {
        return this.interface3_0.imethod_0();
    }

    void Interface1.imethod_1(Class196 A_0, Class375 A_1)
    {
        if ((A_1.method_73() is Class65) && (A_1.method_74().Count > 0))
        {
            Class375 class5 = A_1.method_74().method_4(0);
            if ((class5.method_73() is Class65) && (class5.method_74().Count > 0))
            {
                Class375 class3 = class5.method_74().method_4(class5.method_74().Count - 1);
                int count = class3.method_74().Count;
                if (((count > 0) && (class3.method_74().method_4(0).method_60() != HorizontalAlignment.Distributed)) && ((class3.method_74().method_4(count - 1).method_73() is Class542) || (class3.method_74().method_4(count - 1).method_73() is TextRange)))
                {
                    for (int i = 0; i < class3.method_74().Count; i++)
                    {
                        class3.method_74().method_4(i).method_55(true);
                    }
                    class3.method_74().method_4(0).method_70(new RectangleF(class3.method_74().method_4(0).method_69().X, class3.method_74().method_4(0).method_69().Y, class3.method_74().method_4(0).method_69().Width - Convert.ToSingle((float) (class3.method_74().method_4(0).method_50() * class3.method_74().method_4(0).method_62())), class3.method_74().method_4(0).method_69().Height));
                    for (int j = 1; j < class3.method_74().Count; j++)
                    {
                        Class375 class4 = class3.method_74().method_4(j - 1);
                        Class375 class2 = class3.method_74().method_4(j);
                        if (((!(class4.method_73() is Table) || ((class4.method_73() as Table).TextBoxFormat.TextWrappingStyle == TextWrappingStyle.Inline)) && (!(class2.method_73() is Table) || ((class2.method_73() as Table).TextBoxFormat.TextWrappingStyle == TextWrappingStyle.Inline))) && ((!(class4.method_73() is DocPicture) || ((class4.method_73() as DocPicture).TextWrappingStyle == TextWrappingStyle.Inline)) && (!(class2.method_73() is DocPicture) || ((class2.method_73() as DocPicture).TextWrappingStyle == TextWrappingStyle.Inline))))
                        {
                            float width = class2.method_69().Width - ((class2.method_58() != 0f) ? Convert.ToSingle((float) (class2.method_50() * class2.method_62())) : 0f);
                            class2.method_70(new RectangleF(class4.method_69().X + class4.method_69().Width, class2.method_69().Y, width, class2.method_69().Height));
                        }
                    }
                }
            }
        }
        this.method_2().imethod_1(A_0, A_1);
    }

    void Interface1.imethod_2(Class196 A_0, Class375 A_1)
    {
        this.method_2().imethod_2(A_0, A_1);
    }

    int Interface3.imethod_3()
    {
        if (this.interface3_0 != null)
        {
            this.int_1 = this.interface3_0.imethod_3() - this.int_0;
        }
        return this.int_1;
    }

    internal Interface1 method_0()
    {
        return this.interface1_0;
    }

    internal void method_1(Interface1 A_0)
    {
        this.interface1_0 = A_0;
    }

    public Interface3 method_2()
    {
        Class65 class2 = this.interface3_0 as Class65;
        if (class2 == null)
        {
            return this.interface3_0;
        }
        return class2.method_2();
    }

    public int method_3()
    {
        return this.int_0;
    }

    internal void method_4(int A_0)
    {
        this.int_0 = A_0;
    }

    private static void smethod_0(Class196 A_0, Class375 A_1)
    {
        if ((A_1.method_73() is Class65) && (A_1.method_74().Count > 0))
        {
            Class375 class5 = A_1.method_74().method_4(0);
            if ((class5.method_73() is Class65) && (class5.method_74().Count > 0))
            {
                Class375 class2 = class5.method_74().method_4(class5.method_74().Count - 1);
                int count = class2.method_74().Count;
                if (((count > 0) && (class2.method_74().method_4(0).method_60() != HorizontalAlignment.Distributed)) && ((class2.method_74().method_4(count - 1).method_73() is Class542) || (class2.method_74().method_4(count - 1).method_73() is TextRange)))
                {
                    for (int i = 0; i < class2.method_74().Count; i++)
                    {
                        class2.method_74().method_4(i).method_55(true);
                    }
                    class2.method_74().method_4(0).method_70(new RectangleF(class2.method_74().method_4(0).method_69().X, class2.method_74().method_4(0).method_69().Y, class2.method_74().method_4(0).method_69().Width - Convert.ToSingle((float) (class2.method_74().method_4(0).method_50() * class2.method_74().method_4(0).method_62())), class2.method_74().method_4(0).method_69().Height));
                    for (int j = 1; j < class2.method_74().Count; j++)
                    {
                        Class375 class3 = class2.method_74().method_4(j - 1);
                        Class375 class4 = class2.method_74().method_4(j);
                        float width = class4.method_69().Width - ((class4.method_58() != 0f) ? Convert.ToSingle((float) (class4.method_50() * class4.method_62())) : 0f);
                        class4.method_70(new RectangleF(class3.method_69().X + class3.method_69().Width, class4.method_69().Y, width, class4.method_69().Height));
                    }
                }
            }
        }
    }
}

