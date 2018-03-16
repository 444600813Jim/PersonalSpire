using Spire.Doc;
using Spire.Doc.Fields;
using Spire.Doc.Formatting;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

internal class Class840
{
    private bool bool_0;
    private bool bool_1;
    private FieldType fieldType_0 = FieldType.FieldUnknown;
    private List<object> list_0 = new List<object>();
    private List<object> list_1 = new List<object>();
    private List<Class834.Class835> list_2 = new List<Class834.Class835>();
    private ParagraphFormat paragraphFormat_0 = new ParagraphFormat();
    private Regex regex_0 = new Regex(BookmarkStart.b("琧瘩弫爭䌯ᠱ栳樵䴷䨹总䴽樿ṁ⁃汅ᑇ扉手摍౏筑ࡓ╕牗癙[ⵝ䩟㥡㩣㩥㑧㝩䙫", 2));
    private string string_0 = string.Empty;

    public bool method_0()
    {
        return this.regex_0.IsMatch(this.method_1());
    }

    public string method_1()
    {
        if (this.list_0.Count > 0)
        {
            return this.list_0[0].ToString();
        }
        return string.Empty;
    }

    public void method_10(ParagraphFormat A_0)
    {
        this.paragraphFormat_0 = A_0;
    }

    public string method_11()
    {
        return this.string_0;
    }

    public void method_12(string A_0)
    {
        this.string_0 = A_0;
    }

    public bool method_13()
    {
        return this.bool_0;
    }

    public void method_14(bool A_0)
    {
        this.bool_0 = A_0;
    }

    public bool method_15()
    {
        return this.bool_1;
    }

    public void method_16(bool A_0)
    {
        this.bool_1 = A_0;
    }

    public Class840 method_17()
    {
        return (Class840) base.MemberwiseClone();
    }

    public DocPicture method_18()
    {
        DocPicture picture;
        if ((this.method_6() != FieldType.FieldIncludePicture) || (this.method_4().Count <= 0))
        {
            return null;
        }
        using (List<object>.Enumerator enumerator = this.method_4().GetEnumerator())
        {
            object current;
            while (enumerator.MoveNext())
            {
                current = enumerator.Current;
                if (current is Class840)
                {
                    goto Label_009E;
                }
                if (current is Class841)
                {
                    foreach (object obj2 in (current as Class841).method_0())
                    {
                        if (obj2 is DocPicture)
                        {
                            return (obj2 as DocPicture);
                        }
                    }
                }
            }
            return null;
        Label_009E:
            picture = (current as Class840).method_18();
        }
        return picture;
    }

    public List<object> method_2()
    {
        return this.list_0;
    }

    public void method_3(List<object> A_0)
    {
        this.list_0 = A_0;
    }

    public List<object> method_4()
    {
        return this.list_1;
    }

    public void method_5(List<object> A_0)
    {
        this.list_1 = A_0;
    }

    public FieldType method_6()
    {
        if ((this.list_0.Count > 0) && (this.list_0[0].ToString().Length > 0))
        {
            this.fieldType_0 = Class819.smethod_2(this.list_0[0].ToString());
        }
        return this.fieldType_0;
    }

    public List<Class834.Class835> method_7()
    {
        return this.list_2;
    }

    public void method_8(List<Class834.Class835> A_0)
    {
        this.list_2 = A_0;
    }

    public ParagraphFormat method_9()
    {
        return this.paragraphFormat_0;
    }
}

