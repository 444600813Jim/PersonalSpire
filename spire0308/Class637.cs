using Spire.Doc;
using Spire.Doc.Converters.Sgml;
using System;
using System.Globalization;

internal class Class637
{
    private Class638 class638_0 = new Class638(null);
    private DeclaredContent declaredContent_0;
    private int int_0;

    public int method_0()
    {
        return this.int_0;
    }

    public DeclaredContent method_1()
    {
        return this.declaredContent_0;
    }

    public void method_2()
    {
        this.class638_0 = new Class638(this.class638_0);
        this.int_0++;
    }

    public int method_3()
    {
        if (this.int_0 == 0)
        {
            return -1;
        }
        this.int_0--;
        this.class638_0.method_2().method_3(this.class638_0);
        this.class638_0 = this.class638_0.method_2();
        return this.int_0;
    }

    public void method_4(string A_0)
    {
        this.class638_0.method_4(A_0);
    }

    public void method_5(char A_0)
    {
        this.class638_0.method_5(A_0);
    }

    public void method_6(char A_0)
    {
        this.class638_0.method_6(A_0);
    }

    public void method_7(string A_0)
    {
        int num = 0x12;
        string str = A_0;
        if (str != null)
        {
            if (str != BookmarkStart.b("紷眹氻樽᤿", num))
            {
                if (str == BookmarkStart.b("樷礹砻缽ᐿ́", num))
                {
                    this.declaredContent_0 = DeclaredContent.RCDATA;
                    return;
                }
                if (str == BookmarkStart.b("笷縹紻樽Ŀ", num))
                {
                    this.declaredContent_0 = DeclaredContent.CDATA;
                    return;
                }
            }
            else
            {
                this.declaredContent_0 = DeclaredContent.EMPTY;
                return;
            }
        }
        throw new Exception1(string.Format(CultureInfo.CurrentUICulture, BookmarkStart.b("簷弹弻刽ℿぁ⅃≅桇⥉⍋⁍⑏㝑㩓≕硗⹙╛⹝՟䉡䍣ᵥ塧ᝩ䭫乭᥯ű味ᡵ᝷๹屻ൽ慎ﺉ", num), new object[] { A_0 }));
    }

    public bool method_8(string A_0, Class640 A_1)
    {
        if (this.declaredContent_0 != DeclaredContent.Default)
        {
            return false;
        }
        return this.class638_0.method_7(A_0, A_1);
    }
}

