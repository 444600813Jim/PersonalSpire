using Spire.Doc;
using System;
using System.Collections;

internal class Class1035
{
    private bool bool_0;
    private char char_0;
    private Class1034 class1034_0 = new Class1034();
    private OdsoDataSourceType odsoDataSourceType_0 = OdsoDataSourceType.None;
    private OdsoRecipientDataCollection odsoRecipientDataCollection_0 = new OdsoRecipientDataCollection();
    private string string_0 = "";
    private string string_1 = "";
    private string string_2 = "";

    public Class1035 method_0()
    {
        Class1035 class2 = (Class1035) base.MemberwiseClone();
        class2.class1034_0 = new Class1034();
        using (IEnumerator enumerator = this.class1034_0.System.Collections.IEnumerable.GetEnumerator())
        {
            while (enumerator.MoveNext())
            {
                class2.class1034_0.method_3(((Class228) enumerator.Current).method_0());
            }
        }
        class2.odsoRecipientDataCollection_0 = new OdsoRecipientDataCollection();
        foreach (OdsoRecipientData data in this.odsoRecipientDataCollection_0)
        {
            class2.odsoRecipientDataCollection_0.Add(data.Clone());
        }
        return class2;
    }

    public char method_1()
    {
        return this.char_0;
    }

    public void method_10(OdsoDataSourceType A_0)
    {
        this.odsoDataSourceType_0 = A_0;
    }

    public string method_11()
    {
        return this.string_2;
    }

    public void method_12(string A_0)
    {
        int num = 6;
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("娫伭尯䜱儳", num));
        }
        this.string_2 = A_0;
    }

    public Class1034 method_13()
    {
        return this.class1034_0;
    }

    public void method_14(Class1034 A_0)
    {
        int num = 0x13;
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("伸娺儼䨾⑀", num));
        }
        this.class1034_0 = A_0;
    }

    public OdsoRecipientDataCollection method_15()
    {
        return this.odsoRecipientDataCollection_0;
    }

    public void method_16(OdsoRecipientDataCollection A_0)
    {
        int num = 0x10;
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("䀵夷嘹䤻嬽", num));
        }
        this.odsoRecipientDataCollection_0 = A_0;
    }

    public void method_2(char A_0)
    {
        this.char_0 = A_0;
    }

    public bool method_3()
    {
        return this.bool_0;
    }

    public void method_4(bool A_0)
    {
        this.bool_0 = A_0;
    }

    public string method_5()
    {
        return this.string_0;
    }

    public void method_6(string A_0)
    {
        int num = 0x12;
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("丷嬹倻䬽┿", num));
        }
        this.string_0 = A_0;
    }

    public string method_7()
    {
        return this.string_1;
    }

    public void method_8(string A_0)
    {
        int num = 5;
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("崪䰬䌮䐰嘲", num));
        }
        this.string_1 = A_0;
    }

    public OdsoDataSourceType method_9()
    {
        return this.odsoDataSourceType_0;
    }
}

