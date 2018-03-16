using Spire.CompoundFile.Doc.Native;
using Spire.Doc;
using Spire.Doc.Collections;
using Spire.Doc.Documents;
using Spire.Doc.Documents.Converters;
using Spire.Doc.Documents.Markup;
using Spire.Doc.Fields;
using Spire.Doc.Fields.Shape;
using Spire.Doc.Formatting;
using Spire.Doc.Interface;
using Spire.Layouting;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml;

internal class Class563 : IDisposable
{
    private bool bool_0;
    private bool bool_1;
    private bool bool_10;
    private bool bool_11;
    private bool bool_12 = true;
    private bool bool_13;
    private bool bool_14;
    private bool bool_2;
    private bool bool_3;
    private bool bool_4;
    private bool bool_5;
    private bool bool_6;
    private bool bool_7;
    private bool bool_8;
    private bool bool_9;
    private const char char_0 = '\x001e';
    private const char char_1 = '\x001f';
    private CharacterFormat characterFormat_0;
    private Class771 class771_0;
    private Class822 class822_0;
    private DateTime dateTime_0;
    private Dictionary<string, string> dictionary_0;
    private Dictionary<string, string> dictionary_1;
    private Dictionary<string, string> dictionary_10;
    private Dictionary<string, BookmarkStart> dictionary_11 = new Dictionary<string, BookmarkStart>();
    private Dictionary<string, PermissionStart> dictionary_12 = new Dictionary<string, PermissionStart>();
    private Dictionary<string, PermissionEnd> dictionary_13 = new Dictionary<string, PermissionEnd>();
    private Dictionary<string, Comment> dictionary_14;
    private Dictionary<string, Comment> dictionary_15;
    private Dictionary<string, Comment> dictionary_16;
    private Dictionary<string, int> dictionary_17;
    private Dictionary<string, string> dictionary_18;
    private Dictionary<string, DictionaryEntry> dictionary_2;
    private Dictionary<string, bool> dictionary_3;
    private Dictionary<string, BookmarkStart> dictionary_4;
    private Dictionary<string, Dictionary<string, DictionaryEntry>> dictionary_5;
    private Dictionary<string, DocPicture> dictionary_6;
    private Dictionary<string, string> dictionary_7;
    private Dictionary<string, string> dictionary_8;
    private Dictionary<string, string> dictionary_9;
    private Document document_0;
    private FieldCharType fieldCharType_0;
    private float float_0;
    private float float_1;
    private int int_0 = -1;
    private int int_1;
    private List<string> list_0;
    private List<DictionaryEntry> list_1;
    private List<DictionaryEntry> list_2;
    private List<CommentMark> list_3 = new List<CommentMark>();
    private List<Paragraph> list_4 = new List<Paragraph>();
    private List<string> list_5 = new List<string>();
    private List<Break> list_6 = new List<Break>();
    private Regex regex_0 = new Regex(BookmarkStart.b("栲Դᨶ8昺ᘼ᜾ᵀ浂Ṅ睆摈牊၌摎硐汒灔", 13));
    private Stack<CharacterFormat> stack_0 = new Stack<CharacterFormat>();
    private Stack<Field> stack_1;
    private Stack<Comment> stack_2;
    private Stack<int> stack_3;
    private Stack<string> stack_4 = new Stack<string>();
    private Stack<Class579> stack_5;
    private string string_0;
    private string string_1;
    private string string_2;
    private string string_3 = string.Empty;
    private string string_4 = string.Empty;
    private string string_5 = string.Empty;
    private string string_6 = string.Empty;
    private StringBuilder stringBuilder_0 = new StringBuilder();
    private TrackChangeType trackChangeType_0;
    private XmlReader xmlReader_0;

    internal Dictionary<string, int> method_0()
    {
        if (this.dictionary_17 == null)
        {
            this.dictionary_17 = new Dictionary<string, int>();
        }
        return this.dictionary_17;
    }

    internal Dictionary<string, Comment> method_1()
    {
        if (this.dictionary_14 == null)
        {
            this.method_77();
        }
        return this.dictionary_14;
    }

    private List<DictionaryEntry> method_10()
    {
        if ((this.list_1 == null) || (this.list_1.Count == 0))
        {
            this.list_1 = new List<DictionaryEntry>();
            this.method_170(true);
        }
        return this.list_1;
    }

    private void method_100(XmlReader A_0, TableRow A_1)
    {
        int num = 4;
        if (A_1 == null)
        {
            throw new ArgumentException(BookmarkStart.b("帩䴫䰭尯圱ᐳ䐵圷䴹", num));
        }
        if (A_0.LocalName != BookmarkStart.b("帩師縭䈯", num))
        {
            throw new XmlException(BookmarkStart.b("帩䴫䰭尯圱ᐳ䐵圷䴹᰻嬽ⰿ❁⥃⍅♇㹉", num));
        }
        if (!A_0.IsEmptyElement)
        {
            string localName = A_0.LocalName;
            bool flag = false;
            A_0.Read();
            this.method_485(A_0);
            RowFormat rowFormat = A_1.RowFormat;
            rowFormat.GridBeforeWidth = rowFormat.GridBeforeWidth;
            rowFormat.GridAfterWidth = rowFormat.GridAfterWidth;
            while (A_0.LocalName != localName)
            {
                if (A_0.EOF)
                {
                    break;
                }
                flag = false;
                if (A_0.NodeType != XmlNodeType.Element)
                {
                    goto Label_04D7;
                }
                string key = A_0.LocalName;
                if (key != null)
                {
                    int num2;
                    if (Class1160.dictionary_60 == null)
                    {
                        Dictionary<string, int> dictionary1 = new Dictionary<string, int>(11);
                        dictionary1.Add(BookmarkStart.b("帩師昭唯嬱匳帵䰷", num), 0);
                        dictionary1.Add(BookmarkStart.b("帩丫䈭猯圱堳娵欷䨹崻崽⤿ⱁ⍃", num), 1);
                        dictionary1.Add(BookmarkStart.b("帩丫䈭砯圱唳刵崷䠹", num), 2);
                        dictionary1.Add(BookmarkStart.b("丩䤫䈭", num), 3);
                        dictionary1.Add(BookmarkStart.b("䌩䈫崭", num), 4);
                        dictionary1.Add(BookmarkStart.b("䤩䴫䀭䐯愱䐳娵儷丹", num), 5);
                        dictionary1.Add(BookmarkStart.b("䤩䈫䠭振䘱䴳娵崷", num), 6);
                        dictionary1.Add(BookmarkStart.b("䴩師䜭启瀱儳倵圷䠹夻", num), 7);
                        dictionary1.Add(BookmarkStart.b("䴩師䜭启猱刳䈵崷䠹", num), 8);
                        dictionary1.Add(BookmarkStart.b("崩渫䬭嘯崱䘳匵", num), 9);
                        dictionary1.Add(BookmarkStart.b("崩洫䠭䐯圱䘳", num), 10);
                        Class1160.dictionary_60 = dictionary1;
                    }
                    if (Class1160.dictionary_60.TryGetValue(key, out num2))
                    {
                        switch (num2)
                        {
                            case 0:
                                this.method_102(A_0, A_1);
                                goto Label_04CA;

                            case 1:
                            {
                                rowFormat.HasCellSpacing = true;
                                float num3 = this.method_481(A_0, BookmarkStart.b("崩", num), this.dictionary_18[BookmarkStart.b("崩", num)]);
                                if (num3 != float.MaxValue)
                                {
                                    rowFormat.CellSpacingEx = num3;
                                }
                                goto Label_04CA;
                            }
                            case 2:
                                A_1.IsHeader = true;
                                goto Label_04CA;

                            case 3:
                                A_1.IsDeleteRevision = true;
                                goto Label_04CA;

                            case 4:
                                A_1.IsInsertRevision = true;
                                goto Label_04CA;

                            case 5:
                                rowFormat.IsBreakAcrossPages = false;
                                goto Label_04CA;

                            case 6:
                                goto Label_04CA;

                            case 7:
                                rowFormat.GridBefore = Convert.ToInt32(this.method_101(A_0, BookmarkStart.b("尩䴫䈭", num), this.dictionary_18[BookmarkStart.b("崩", num)]));
                                goto Label_04CA;

                            case 8:
                                rowFormat.GridAfter = Convert.ToInt32(this.method_101(A_0, BookmarkStart.b("尩䴫䈭", num), this.dictionary_18[BookmarkStart.b("崩", num)]));
                                goto Label_04CA;

                            case 9:
                            {
                                string attribute = A_0.GetAttribute(BookmarkStart.b("帩唫席唯", num), this.dictionary_18[BookmarkStart.b("崩", num)]);
                                if (attribute != null)
                                {
                                    if (attribute == BookmarkStart.b("娩伫娭", num))
                                    {
                                        goto Label_0377;
                                    }
                                    if (attribute == BookmarkStart.b("丩含伭", num))
                                    {
                                        rowFormat.GridBeforeWidth.method_52(FtsWidth.Point);
                                        rowFormat.GridBeforeWidth.method_50((float) int.Parse(A_0.GetAttribute(BookmarkStart.b("崩", num), this.dictionary_18[BookmarkStart.b("崩", num)])));
                                    }
                                }
                                goto Label_04CA;
                            }
                            case 10:
                            {
                                string str = A_0.GetAttribute(BookmarkStart.b("帩唫席唯", num), this.dictionary_18[BookmarkStart.b("崩", num)]);
                                if (str != null)
                                {
                                    if (str == BookmarkStart.b("娩伫娭", num))
                                    {
                                        goto Label_045D;
                                    }
                                    if (str == BookmarkStart.b("丩含伭", num))
                                    {
                                        rowFormat.GridAfterWidth.method_52(FtsWidth.Point);
                                        rowFormat.GridAfterWidth.method_50((float) int.Parse(A_0.GetAttribute(BookmarkStart.b("崩", num), this.dictionary_18[BookmarkStart.b("崩", num)])));
                                    }
                                }
                                goto Label_04CA;
                            }
                        }
                    }
                }
                goto Label_04A3;
            Label_0377:
                rowFormat.GridBeforeWidth.method_50((float) int.Parse(A_0.GetAttribute(BookmarkStart.b("崩", num), this.dictionary_18[BookmarkStart.b("崩", num)])));
                rowFormat.GridBeforeWidth.method_52(FtsWidth.Percentage);
                goto Label_04CA;
            Label_045D:
                rowFormat.GridAfterWidth.method_50((float) int.Parse(A_0.GetAttribute(BookmarkStart.b("崩", num), this.dictionary_18[BookmarkStart.b("崩", num)])));
                rowFormat.GridAfterWidth.method_52(FtsWidth.Percentage);
                goto Label_04CA;
            Label_04A3:
                if (A_0.LocalName != string.Empty)
                {
                    rowFormat.XmlProps2010.Add(this.method_484(A_0));
                    flag = true;
                }
            Label_04CA:
                if (!flag)
                {
                    A_0.Read();
                }
                continue;
            Label_04D7:
                A_0.Read();
            }
        }
    }

    private string method_101(XmlReader A_0, string A_1, string A_2)
    {
        if (A_0.AttributeCount == 0)
        {
            return null;
        }
        if (A_2 == null)
        {
            return A_0.GetAttribute(A_1);
        }
        return A_0.GetAttribute(A_1, A_2);
    }

    private void method_102(XmlReader A_0, TableRow A_1)
    {
        int num = 15;
        float num2 = this.method_481(A_0, BookmarkStart.b("䌴嘶唸", 15), this.dictionary_18[BookmarkStart.b("䈴", 15)]);
        if (num2 != float.MaxValue)
        {
            A_1.Height = num2;
        }
        string attribute = A_0.GetAttribute(BookmarkStart.b("崴收䰸场堼", num), this.dictionary_18[BookmarkStart.b("䈴", num)]);
        if ((attribute != null) && (attribute == BookmarkStart.b("倴伶堸堺䤼", num)))
        {
            A_1.HeightType = TableRowHeightType.Exactly;
        }
    }

    private void method_103(TableRow A_0, Table A_1)
    {
        if (A_1.DocxTableFormat.HasFormat)
        {
            A_0.RowFormat.ImportContainer(A_1.DocxTableFormat.Format);
            A_0.RowFormat.Scaling = A_1.DocxTableFormat.Format.Scaling;
            A_0.RowFormat.LayoutType = A_1.DocxTableFormat.Format.LayoutType;
            if (!string.IsNullOrEmpty(A_1.DocxTableFormat.StyleName))
            {
                Borders borders = A_1.DocxTableFormat.Format.Borders;
                Borders borders2 = A_0.RowFormat.Borders;
                if (borders.Bottom.HasValue(2) && (borders.Bottom.BorderType == BorderStyle.None))
                {
                    borders2.Bottom.HasNoneStyle = true;
                }
                if (borders.Left.HasValue(2) && (borders.Left.BorderType == BorderStyle.None))
                {
                    borders2.Left.HasNoneStyle = true;
                }
                if (borders.Right.HasValue(2) && (borders.Right.BorderType == BorderStyle.None))
                {
                    borders2.Right.HasNoneStyle = true;
                }
                if (borders.Top.HasValue(2) && (borders.Top.BorderType == BorderStyle.None))
                {
                    borders2.Top.HasNoneStyle = true;
                }
                if (borders.Horizontal.HasValue(2) && (borders.Horizontal.BorderType == BorderStyle.None))
                {
                    borders2.Horizontal.HasNoneStyle = true;
                }
                if (borders.Vertical.HasValue(2) && (borders.Vertical.BorderType == BorderStyle.None))
                {
                    borders2.Vertical.HasNoneStyle = true;
                }
            }
        }
    }

    private void method_104(XmlTableFormat A_0)
    {
        string.IsNullOrEmpty(A_0.StyleName);
    }

    private void method_105(XmlReader A_0, IDocumentObject A_1)
    {
        int num = 13;
        if (!A_0.IsEmptyElement)
        {
            string localName = A_0.LocalName;
            RowFormat format = this.method_125(A_1);
            bool flag = false;
            A_0.Read();
            this.method_485(A_0);
            Table ownerTable = A_1 as Table;
            if (A_1 is TableRow)
            {
                ownerTable = (A_1 as TableRow).OwnerTable;
            }
            while (A_0.LocalName != localName)
            {
                string attribute;
                Class15 class2;
                if (A_0.EOF)
                {
                    break;
                }
                flag = false;
                if (A_0.NodeType != XmlNodeType.Element)
                {
                    goto Label_0571;
                }
                string key = A_0.LocalName;
                if (key != null)
                {
                    int num2;
                    if (Class1160.dictionary_61 == null)
                    {
                        Dictionary<string, int> dictionary1 = new Dictionary<string, int>(0x13);
                        dictionary1.Add(BookmarkStart.b("儲尴匶倸洺吼䰾㑀≂⥄", num), 0);
                        dictionary1.Add(BookmarkStart.b("䜲圴嬶樸伺䐼匾⑀", num), 1);
                        dictionary1.Add(BookmarkStart.b("䜲圴嬶游", num), 2);
                        dictionary1.Add(BookmarkStart.b("䜲圴嬶笸吺似嬾⑀ㅂ㙄", num), 3);
                        dictionary1.Add(BookmarkStart.b("䜲圴嬶稸帺儼匾ቀ㍂⑄⑆⁈╊⩌", num), 4);
                        dictionary1.Add(BookmarkStart.b("夲嘴", num), 5);
                        dictionary1.Add(BookmarkStart.b("䜲圴嬶稸帺儼匾ీ≂㝄", num), 6);
                        dictionary1.Add(BookmarkStart.b("䜲圴嬶瀸唺夼", num), 7);
                        dictionary1.Add(BookmarkStart.b("䜲圴嬶甸娺䐼倾㑀㝂", num), 8);
                        dictionary1.Add(BookmarkStart.b("䜲圴嬶椸䤺縼圾⁀ⵂ≄≆", num), 9);
                        dictionary1.Add(BookmarkStart.b("䜲圴嬶椸䤺砼䜾ɀ⭂⑄⥆⹈⹊", num), 10);
                        dictionary1.Add(BookmarkStart.b("圲倴嬶", num), 11);
                        dictionary1.Add(BookmarkStart.b("娲嬴䐶", num), 12);
                        dictionary1.Add(BookmarkStart.b("䜲圴嬶䤸欺似", num), 13);
                        dictionary1.Add(BookmarkStart.b("䜲圴嬶瘸䴺堼䴾ⵀ≂㕄", num), 14);
                        dictionary1.Add(BookmarkStart.b("䀲崴匶", num), 15);
                        dictionary1.Add(BookmarkStart.b("䜲圴嬶甸吺刼吾", num), 0x10);
                        dictionary1.Add(BookmarkStart.b("䜲圴嬶稸娺䴼䬾⡀ⱂ⭄", num), 0x11);
                        dictionary1.Add(BookmarkStart.b("䜲圴嬶紸帺丼尾㍀⩂㕄㍆⁈⑊⍌", num), 0x12);
                        Class1160.dictionary_61 = dictionary1;
                    }
                    if (Class1160.dictionary_61.TryGetValue(key, out num2))
                    {
                        switch (num2)
                        {
                            case 0:
                                if (A_0.AttributeCount <= 0)
                                {
                                    goto Label_027B;
                                }
                                format.Bidi = this.method_469(A_0);
                                goto Label_0565;

                            case 1:
                                this.method_124(A_0, ownerTable);
                                goto Label_0565;

                            case 2:
                                class2 = format.method_32(0x1086) as Class15;
                                attribute = A_0.GetAttribute(BookmarkStart.b("䜲䰴䜶尸", num), this.dictionary_18[BookmarkStart.b("䐲", num)]);
                                if (!(attribute == BookmarkStart.b("刲䀴䌶嘸", num)))
                                {
                                    goto Label_02FC;
                                }
                                class2.method_52(FtsWidth.Auto);
                                class2.method_50(0f);
                                goto Label_0565;

                            case 3:
                                this.method_415(A_0, A_1);
                                goto Label_0565;

                            case 4:
                            {
                                format.HasCellSpacing = true;
                                float num5 = this.method_481(A_0, BookmarkStart.b("䐲", num), this.dictionary_18[BookmarkStart.b("䐲", num)]);
                                if (num5 != float.MaxValue)
                                {
                                    format.CellSpacingEx = num5;
                                }
                                goto Label_0565;
                            }
                            case 5:
                                format.HorizontalAlignment = this.method_115(A_0);
                                goto Label_0565;

                            case 6:
                                this.method_113(A_0, A_1);
                                goto Label_0565;

                            case 7:
                            {
                                string s = A_0.GetAttribute(BookmarkStart.b("䐲", num), this.dictionary_18[BookmarkStart.b("䐲", num)]);
                                format.RowIndent = float.Parse(s, NumberStyles.Float, CultureInfo.InvariantCulture) / 20f;
                                goto Label_0565;
                            }
                            case 8:
                                this.method_123(A_0, format);
                                goto Label_0565;

                            case 9:
                            case 10:
                                this.bool_2 = true;
                                A_0.Read();
                                this.method_485(A_0);
                                this.method_105(A_0, ownerTable);
                                this.bool_2 = false;
                                goto Label_0565;

                            case 11:
                                ownerTable.SetDeleteRev(true);
                                goto Label_0565;

                            case 12:
                                ownerTable.SetInsertRev(true);
                                goto Label_0565;

                            case 13:
                                this.method_116(A_0, ownerTable);
                                goto Label_0565;

                            case 14:
                                this.method_117(A_0, ownerTable);
                                goto Label_0565;

                            case 15:
                                this.method_122(A_0, format);
                                goto Label_0565;

                            case 0x10:
                                this.method_109(A_0, ownerTable);
                                goto Label_0565;

                            case 0x11:
                                this.method_107(A_0, ownerTable);
                                goto Label_0565;

                            case 0x12:
                                this.method_108(A_0, ownerTable);
                                goto Label_0565;
                        }
                    }
                }
                goto Label_0511;
            Label_027B:
                format.Bidi = true;
                goto Label_0565;
            Label_02FC:
                if (attribute == BookmarkStart.b("䌲嘴䌶", num))
                {
                    float num4 = float.Parse(A_0.GetAttribute(BookmarkStart.b("䐲", num), this.dictionary_18[BookmarkStart.b("䐲", num)]));
                    class2.method_52(FtsWidth.Percentage);
                    class2.method_50(num4 / 50f);
                }
                else if (attribute == BookmarkStart.b("圲䴴嘶", num))
                {
                    int num3 = Convert.ToInt32(Convert.ToDecimal(this.method_239(A_0.GetAttribute(BookmarkStart.b("䐲", num), this.dictionary_18[BookmarkStart.b("䐲", num)]))));
                    class2.method_50((float) num3);
                    class2.method_52(FtsWidth.Point);
                }
                goto Label_0565;
            Label_0511:
                if ((A_0.LocalName != string.Empty) && !(A_1 is TableRow))
                {
                    if (this.bool_2)
                    {
                        ownerTable.TrackTblFormat.NodeArray2010.Add(this.method_484(A_0));
                    }
                    else
                    {
                        ownerTable.DocxTableFormat.NodeArray2010.Add(this.method_484(A_0));
                    }
                    flag = true;
                }
            Label_0565:
                if (!flag)
                {
                    this.method_106(A_0);
                }
                goto Label_0578;
            Label_0571:
                A_0.Read();
            Label_0578:
                this.method_485(A_0);
            }
        }
    }

    private void method_106(XmlReader A_0)
    {
        string localName = A_0.LocalName;
        A_0.Read();
        this.method_485(A_0);
        string str2 = A_0.LocalName;
        if ((A_0.NodeType == XmlNodeType.EndElement) && (localName == str2))
        {
            A_0.Read();
        }
    }

    private void method_107(XmlReader A_0, Table A_1)
    {
        string attribute = A_0.GetAttribute(BookmarkStart.b("䐱唳娵", 12), this.dictionary_18[BookmarkStart.b("䔱", 12)]);
        if (attribute != null)
        {
            A_1.Title = attribute;
        }
    }

    private void method_108(XmlReader A_0, Table A_1)
    {
        string attribute = A_0.GetAttribute(BookmarkStart.b("䈳圵吷", 14), this.dictionary_18[BookmarkStart.b("䌳", 14)]);
        if (attribute != null)
        {
            A_1.TableDescription = attribute;
        }
    }

    private void method_109(XmlReader A_0, Table A_1)
    {
        string s = this.method_111(A_0, BookmarkStart.b("䄶堸场", 0x11));
        if (s != null)
        {
            TableStyleOptions options = ((TableStyleOptions) int.Parse(s, NumberStyles.HexNumber, CultureInfo.InvariantCulture)) ^ TableStyleOptions.Default2003;
            A_1.DocxTableFormat.Format.TableOption = options;
        }
    }

    private List<DictionaryEntry> method_11()
    {
        if (this.list_2 == null)
        {
            this.list_2 = new List<DictionaryEntry>();
            this.method_170(false);
        }
        return this.list_2;
    }

    private bool method_110(string A_0)
    {
        int num = 0x13;
        if ((!(A_0 == BookmarkStart.b("࠸", 0x13)) && !(A_0 == BookmarkStart.b("䴸䤺䠼娾", num))) && (!(A_0 == BookmarkStart.b("嘸唺", num)) && !(A_0 == BookmarkStart.b("䴸", num))))
        {
            return false;
        }
        return true;
    }

    private string method_111(XmlReader A_0, string A_1)
    {
        int num = 10;
        string attribute = A_0.GetAttribute(A_1, this.dictionary_18[BookmarkStart.b("䜯", 10)]);
        if (attribute != null)
        {
            return attribute;
        }
        string str2 = A_0.GetAttribute(BookmarkStart.b("䘯匱堳", num), this.dictionary_18[BookmarkStart.b("䜯", num)]);
        if (str2 == null)
        {
            return attribute;
        }
        string str3 = Convert.ToString(Convert.ToInt32(str2, 0x10), 2).PadLeft(11, '0');
        string str4 = A_1;
        if (str4 == null)
        {
            return attribute;
        }
        if (str4 != BookmarkStart.b("嘯嬱䘳䔵䰷根医䤽", num))
        {
            if (str4 == BookmarkStart.b("尯匱䜳䈵樷唹䬻", num))
            {
                return str3.Substring(4, 1);
            }
            if (str4 == BookmarkStart.b("嘯嬱䘳䔵䰷礹医刽㔿⽁⩃", num))
            {
                return str3.Substring(3, 1);
            }
            if (str4 != BookmarkStart.b("尯匱䜳䈵笷唹倻䬽ⴿⱁ", num))
            {
                if (!(str4 == BookmarkStart.b("帯崱簳琵夷吹堻", num)))
                {
                    if (str4 == BookmarkStart.b("帯崱戳琵夷吹堻", num))
                    {
                        attribute = str3.Substring(0, 1);
                    }
                    return attribute;
                }
                return str3.Substring(1, 1);
            }
            return str3.Substring(2, 1);
        }
        return str3.Substring(5, 1);
    }

    private void method_112(XmlReader A_0, Paddings A_1)
    {
        int num = 9;
        float maxValue = float.MaxValue;
        if ((A_0.LocalName != BookmarkStart.b("嬮匰弲瘴制唸场瀼帾㍀", 9)) && (A_0.LocalName != BookmarkStart.b("嬮到縲吴䔶", num)))
        {
            throw new XmlException(BookmarkStart.b("笮倰儲头制ᤸ嘺尼䴾♀⩂⭄㑆", num));
        }
        string localName = A_0.LocalName;
        if (!A_0.IsEmptyElement)
        {
            A_0.Read();
            this.method_485(A_0);
            while (A_0.LocalName != localName)
            {
                if (A_0.EOF)
                {
                    break;
                }
                if (A_0.NodeType == XmlNodeType.Element)
                {
                    string str2 = A_0.LocalName;
                    if (str2 != null)
                    {
                        if (str2 != BookmarkStart.b("嬮帰䌲", num))
                        {
                            if (str2 != BookmarkStart.b("䌮吰唲䄴", num))
                            {
                                if (!(str2 == BookmarkStart.b("䴮帰䜲䄴堶吸", num)))
                                {
                                    if (str2 == BookmarkStart.b("崮堰吲崴䌶", num))
                                    {
                                        maxValue = this.method_481(A_0, BookmarkStart.b("堮", num), this.dictionary_18[BookmarkStart.b("堮", num)]);
                                        if (maxValue != float.MaxValue)
                                        {
                                            A_1.Right = maxValue;
                                        }
                                    }
                                }
                                else
                                {
                                    maxValue = this.method_481(A_0, BookmarkStart.b("堮", num), this.dictionary_18[BookmarkStart.b("堮", num)]);
                                    if (maxValue != float.MaxValue)
                                    {
                                        A_1.Bottom = maxValue;
                                    }
                                }
                            }
                            else
                            {
                                maxValue = this.method_481(A_0, BookmarkStart.b("堮", num), this.dictionary_18[BookmarkStart.b("堮", num)]);
                                if (maxValue != float.MaxValue)
                                {
                                    A_1.Left = maxValue;
                                }
                            }
                        }
                        else
                        {
                            maxValue = this.method_481(A_0, BookmarkStart.b("堮", num), this.dictionary_18[BookmarkStart.b("堮", num)]);
                            if (maxValue != float.MaxValue)
                            {
                                A_1.Top = maxValue;
                            }
                        }
                    }
                    A_0.Read();
                }
                else
                {
                    A_0.Read();
                }
            }
        }
    }

    private void method_113(XmlReader A_0, IDocumentObject A_1)
    {
        int num = 1;
        float maxValue = float.MaxValue;
        Paddings paddings = this.method_114(A_1);
        if ((A_0.LocalName != BookmarkStart.b("匦䬨䜪測䨮崰弲破嘶䬸", 1)) && (A_0.LocalName != BookmarkStart.b("匦䨨昪䰬崮", num)))
        {
            throw new XmlException(BookmarkStart.b("猦䠨䤪䄬䨮ᄰ帲吴䔶常刺匼䰾", num));
        }
        string localName = A_0.LocalName;
        if (!A_0.IsEmptyElement)
        {
            A_0.Read();
            this.method_485(A_0);
            while (A_0.LocalName != localName)
            {
                if (A_0.EOF)
                {
                    break;
                }
                if (A_0.NodeType == XmlNodeType.Element)
                {
                    string str2 = A_0.LocalName;
                    if (str2 != null)
                    {
                        if (str2 != BookmarkStart.b("匦䘨嬪", num))
                        {
                            if (str2 != BookmarkStart.b("䬦䰨䴪夬", num))
                            {
                                if (!(str2 == BookmarkStart.b("䔦䘨弪夬䀮尰", num)))
                                {
                                    if (str2 == BookmarkStart.b("唦䀨䰪䔬嬮", num))
                                    {
                                        maxValue = this.method_481(A_0, BookmarkStart.b("倦", num), this.dictionary_18[BookmarkStart.b("倦", num)]);
                                        if (maxValue != float.MaxValue)
                                        {
                                            paddings.Right = maxValue;
                                        }
                                    }
                                }
                                else
                                {
                                    maxValue = this.method_481(A_0, BookmarkStart.b("倦", num), this.dictionary_18[BookmarkStart.b("倦", num)]);
                                    if (maxValue != float.MaxValue)
                                    {
                                        paddings.Bottom = maxValue;
                                    }
                                }
                            }
                            else
                            {
                                maxValue = this.method_481(A_0, BookmarkStart.b("倦", num), this.dictionary_18[BookmarkStart.b("倦", num)]);
                                if (maxValue != float.MaxValue)
                                {
                                    paddings.Left = maxValue;
                                }
                            }
                        }
                        else
                        {
                            maxValue = this.method_481(A_0, BookmarkStart.b("倦", num), this.dictionary_18[BookmarkStart.b("倦", num)]);
                            if (maxValue != float.MaxValue)
                            {
                                paddings.Top = maxValue;
                            }
                        }
                    }
                    this.method_106(A_0);
                }
                else
                {
                    A_0.Read();
                }
            }
        }
    }

    private Paddings method_114(IDocumentObject A_0)
    {
        Paddings paddings = null;
        if (A_0 is Table)
        {
            if (this.bool_2)
            {
                return (A_0 as Table).TrackTblFormat.Format.Paddings;
            }
            return (A_0 as Table).DocxTableFormat.Format.Paddings;
        }
        if (A_0 is TableRow)
        {
            if (this.bool_0)
            {
                return (A_0 as TableRow).TrackRowFormat.Paddings;
            }
            return (A_0 as TableRow).RowFormat.Paddings;
        }
        if (!(A_0 is TableCell))
        {
            return paddings;
        }
        if (this.bool_1)
        {
            return (A_0 as TableCell).TrackCellFormat.Paddings;
        }
        return (A_0 as TableCell).CellFormat.Paddings;
    }

    private RowAlignment method_115(XmlReader A_0)
    {
        string str2;
        int num = 10;
        RowAlignment left = RowAlignment.Left;
        string attribute = A_0.GetAttribute(BookmarkStart.b("䘯匱堳", 10), this.dictionary_18[BookmarkStart.b("䜯", 10)]);
        if ((attribute == null) || ((str2 = attribute) == null))
        {
            return left;
        }
        if (str2 != BookmarkStart.b("尯圱刳䈵", num))
        {
            if (!(str2 == BookmarkStart.b("匯圱娳䈵崷䠹", num)))
            {
                if (str2 == BookmarkStart.b("䈯嬱匳帵䰷", num))
                {
                    left = RowAlignment.Right;
                }
                return left;
            }
            return RowAlignment.Center;
        }
        return RowAlignment.Left;
    }

    private void method_116(XmlReader A_0, Table A_1)
    {
        int num = 0x12;
        RowFormat.TablePositioning positioning = A_1.DocxTableFormat.Format.Positioning;
        string attribute = A_0.GetAttribute(BookmarkStart.b("吷弹娻䨽ؿぁ⭃⭅᱇⽉㑋㩍", 0x12), this.dictionary_18[BookmarkStart.b("伷", 0x12)]);
        if (!string.IsNullOrEmpty(attribute))
        {
            positioning.DistanceFromLeft = float.Parse(attribute, NumberStyles.Float, CultureInfo.InvariantCulture) / 20f;
        }
        attribute = A_0.GetAttribute(BookmarkStart.b("䨷匹嬻嘽㐿с㙃⥅╇ṉ⥋㙍⑏", num), this.dictionary_18[BookmarkStart.b("伷", num)]);
        if (!string.IsNullOrEmpty(attribute))
        {
            positioning.DistanceFromRight = float.Parse(attribute, NumberStyles.Float, CultureInfo.InvariantCulture) / 20f;
        }
        attribute = A_0.GetAttribute(BookmarkStart.b("䰷唹䰻砽㈿ⵁ⥃ቅⵇ㉉㡋", num), this.dictionary_18[BookmarkStart.b("伷", num)]);
        if (!string.IsNullOrEmpty(attribute))
        {
            positioning.DistanceFromTop = float.Parse(attribute, NumberStyles.Float, CultureInfo.InvariantCulture) / 20f;
        }
        attribute = A_0.GetAttribute(BookmarkStart.b("娷唹䠻䨽⼿⽁Ƀ㑅❇❉ᡋ⭍⡏♑", num), this.dictionary_18[BookmarkStart.b("伷", num)]);
        if (!string.IsNullOrEmpty(attribute))
        {
            positioning.DistanceFromBottom = float.Parse(attribute, NumberStyles.Float, CultureInfo.InvariantCulture) / 20f;
        }
        attribute = A_0.GetAttribute(BookmarkStart.b("丷弹主䨽Ŀⱁ❃⹅❇㡉", num), this.dictionary_18[BookmarkStart.b("伷", num)]);
        if (!string.IsNullOrEmpty(attribute))
        {
            this.method_118(positioning, attribute);
        }
        attribute = A_0.GetAttribute(BookmarkStart.b("倷唹主䐽Ŀⱁ❃⹅❇㡉", num), this.dictionary_18[BookmarkStart.b("伷", num)]);
        if (!string.IsNullOrEmpty(attribute))
        {
            this.method_119(positioning, attribute);
        }
        attribute = A_0.GetAttribute(BookmarkStart.b("䰷堹倻丽ᠿᅁ㑃⍅⭇", num), this.dictionary_18[BookmarkStart.b("伷", num)]);
        if (!string.IsNullOrEmpty(attribute))
        {
            this.method_120(positioning, attribute);
        }
        attribute = A_0.GetAttribute(BookmarkStart.b("䰷堹倻丽᤿ᅁ㑃⍅⭇", num), this.dictionary_18[BookmarkStart.b("伷", num)]);
        if (!string.IsNullOrEmpty(attribute))
        {
            this.method_121(positioning, attribute);
        }
        attribute = A_0.GetAttribute(BookmarkStart.b("䰷堹倻丽ᠿ", num), this.dictionary_18[BookmarkStart.b("伷", num)]);
        if (!string.IsNullOrEmpty(attribute))
        {
            positioning.HorizPositionEx = float.Parse(attribute, NumberStyles.Float, CultureInfo.InvariantCulture) / 20f;
        }
        attribute = A_0.GetAttribute(BookmarkStart.b("䰷堹倻丽᤿", num), this.dictionary_18[BookmarkStart.b("伷", num)]);
        if (!string.IsNullOrEmpty(attribute))
        {
            positioning.VertPositionEx = float.Parse(attribute, NumberStyles.Float, CultureInfo.InvariantCulture) / 20f;
        }
    }

    private void method_117(XmlReader A_0, Table A_1)
    {
        int num = 12;
        RowFormat.TablePositioning positioning = A_1.DocxTableFormat.Format.Positioning;
        if (A_1.DocxTableFormat.Format.WrapTextAround)
        {
            string attribute = A_0.GetAttribute(BookmarkStart.b("䐱唳娵", num), this.dictionary_18[BookmarkStart.b("䔱", num)]);
            if (!string.IsNullOrEmpty(attribute) && (attribute == BookmarkStart.b("就儳䀵崷䠹", num)))
            {
                positioning.TableOverlap = false;
            }
        }
    }

    private void method_118(RowFormat.TablePositioning A_0, string A_1)
    {
        int num = 10;
        string str = A_1;
        if (str != null)
        {
            if (str == BookmarkStart.b("䀯匱匳匵", num))
            {
                A_0.VertRelationTo = VerticalRelation.Page;
                return;
            }
            if (str == BookmarkStart.b("䐯圱䰳䈵", num))
            {
                A_0.VertRelationTo = VerticalRelation.Paragraph;
                return;
            }
        }
        A_0.VertRelationTo = VerticalRelation.Margin;
    }

    private void method_119(RowFormat.TablePositioning A_0, string A_1)
    {
        int num = 7;
        string str = A_1;
        if (str != null)
        {
            if (str == BookmarkStart.b("崬丮嘰嘲", num))
            {
                A_0.HorizRelationTo = HorizontalRelation.Page;
                return;
            }
            if (str == BookmarkStart.b("䀬丮䌰吲尴夶", num))
            {
                A_0.HorizRelationTo = HorizontalRelation.Margin;
                return;
            }
        }
        A_0.HorizRelationTo = HorizontalRelation.Column;
    }

    private Dictionary<string, string> method_12()
    {
        if (this.dictionary_9 == null)
        {
            this.dictionary_9 = new Dictionary<string, string>();
        }
        return this.dictionary_9;
    }

    private void method_120(RowFormat.TablePositioning A_0, string A_1)
    {
        int num = 7;
        string str = A_1.ToLower();
        if (str != null)
        {
            if (str == BookmarkStart.b("䐬䄮䈰娲儴制", num))
            {
                A_0.HorizPositionAbs = HorizontalPosition.Inside;
                return;
            }
            if (str == BookmarkStart.b("䈬娮䔰䀲尴匶尸", num))
            {
                A_0.HorizPositionAbs = HorizontalPosition.Outside;
                return;
            }
            if (str == BookmarkStart.b("丬䨮弰䜲倴䔶", num))
            {
                A_0.HorizPositionAbs = HorizontalPosition.Center;
                return;
            }
            if (str == BookmarkStart.b("弬䘮嘰嬲䄴", num))
            {
                A_0.HorizPositionAbs = HorizontalPosition.Right;
                return;
            }
            if (str == BookmarkStart.b("䄬䨮地䜲", num))
            {
                A_0.HorizPositionAbs = HorizontalPosition.Left;
                return;
            }
        }
        A_0.HorizPositionAbs = HorizontalPosition.None;
    }

    private void method_121(RowFormat.TablePositioning A_0, string A_1)
    {
        int num = 10;
        string str = A_1;
        if (str != null)
        {
            if (str == BookmarkStart.b("夯就䜳張尷弹", num))
            {
                A_0.VertPositionAbs = VerticalPosition.Inside;
                return;
            }
            if (str == BookmarkStart.b("弯䜱䀳䔵儷帹夻", num))
            {
                A_0.VertPositionAbs = VerticalPosition.Outside;
                return;
            }
            if (str == BookmarkStart.b("匯圱娳䈵崷䠹", num))
            {
                A_0.VertPositionAbs = VerticalPosition.Center;
                return;
            }
            if (str == BookmarkStart.b("刯崱䀳䈵圷圹", num))
            {
                A_0.VertPositionAbs = VerticalPosition.Bottom;
                return;
            }
            if (str == BookmarkStart.b("䐯崱䐳", num))
            {
                A_0.VertPositionAbs = VerticalPosition.Top;
                return;
            }
        }
        A_0.VertPositionAbs = VerticalPosition.None;
    }

    private void method_122(XmlReader A_0, RowFormat A_1)
    {
        int num = 8;
        string attribute = A_0.GetAttribute(BookmarkStart.b("䠭夯帱堳", 8), this.dictionary_18[BookmarkStart.b("夭", 8)]);
        string str2 = A_0.GetAttribute(BookmarkStart.b("堭儯帱", 8), this.dictionary_18[BookmarkStart.b("夭", 8)]);
        if (str2 != null)
        {
            A_1.TextureStyle = this.method_394(str2);
        }
        if (attribute != null)
        {
            if (attribute == BookmarkStart.b("伭䔯䘱嬳", num))
            {
                A_1.BackColor = Color.Empty;
            }
            else
            {
                A_1.BackColor = this.method_474(attribute);
            }
        }
    }

    private void method_123(XmlReader A_0, RowFormat A_1)
    {
        int num = 10;
        string attribute = A_0.GetAttribute(BookmarkStart.b("䐯䬱䐳匵", 10), this.dictionary_18[BookmarkStart.b("䜯", 10)]);
        if ((attribute != BookmarkStart.b("儯䜱䀳夵", 10)) && (attribute != BookmarkStart.b("儯䜱䀳夵帷匹䠻", num)))
        {
            if (attribute == BookmarkStart.b("嘯嬱䰳匵尷", num))
            {
                A_1.LayoutType = LayoutType.Fixed;
            }
        }
        else
        {
            A_1.LayoutType = LayoutType.AutoFit;
        }
    }

    private void method_124(XmlReader A_0, Table A_1)
    {
        string attribute = A_0.GetAttribute(BookmarkStart.b("䌴嘶唸", 15), this.dictionary_18[BookmarkStart.b("䈴", 15)]);
        if ((!string.IsNullOrEmpty(attribute) && this.method_22().ContainsKey(attribute)) && (this.document_0.Styles.FindByName(this.method_22()[attribute], StyleType.TableStyle) != null))
        {
            A_1.method_45(this.method_22()[attribute]);
        }
        if (this.bool_2)
        {
            A_1.TrackTblFormat.StyleName = attribute;
        }
        else
        {
            A_1.DocxTableFormat.StyleName = attribute;
        }
    }

    private RowFormat method_125(IDocumentObject A_0)
    {
        RowFormat format = null;
        Table ownerTable = null;
        if (A_0 is Table)
        {
            ownerTable = A_0 as Table;
            if (this.bool_2)
            {
                return ownerTable.TrackTblFormat.Format;
            }
            return ownerTable.DocxTableFormat.Format;
        }
        if (!(A_0 is TableRow))
        {
            return format;
        }
        ownerTable = (A_0 as TableRow).OwnerTable;
        if (this.bool_0)
        {
            return (A_0 as TableRow).TrackRowFormat;
        }
        return (A_0 as TableRow).RowFormat;
    }

    private void method_126(XmlReader A_0, Table A_1, bool A_2)
    {
        int num = 0x12;
        if (!(A_0.LocalName == BookmarkStart.b("䰷堹倻礽㈿⭁⁃", 0x12)) && !(A_0.LocalName == BookmarkStart.b("䰷堹倻礽㈿⭁⁃Յ⁇⭉≋⥍㕏", num)))
        {
            throw new XmlException(BookmarkStart.b("䰷嬹帻刽┿扁⍃㑅ⅇ⹉", num));
        }
        string localName = A_0.LocalName;
        bool flag = false;
        List<float> list = A_2 ? A_1.TrackTableGrid : A_1.TableGrid;
        ArrayList list2 = (ArrayList) A_1.TableFormat.method_51(0x13ef);
        A_0.Read();
        this.method_485(A_0);
        while (A_0.NodeType != XmlNodeType.EndElement)
        {
            if (!(A_0.LocalName != localName))
            {
                break;
            }
            flag = false;
            if (A_0.NodeType == XmlNodeType.Element)
            {
                string str2 = A_0.LocalName;
                if (str2 != null)
                {
                    if (!(str2 == BookmarkStart.b("強䠹唻娽̿ⵁ⡃", num)))
                    {
                        if (str2 == BookmarkStart.b("䰷堹倻礽㈿⭁⁃Յ⁇⭉≋⥍㕏", num))
                        {
                            A_1.TrackTableGrid.Add(0f);
                            this.method_126(A_0, A_1, true);
                        }
                    }
                    else
                    {
                        string attribute = A_0.GetAttribute(BookmarkStart.b("伷", num), this.dictionary_18[BookmarkStart.b("伷", num)]);
                        if (!string.IsNullOrEmpty(attribute))
                        {
                            float num2 = list[list.Count - 1];
                            list.Add(float.Parse(attribute) + num2);
                            list2.Add(int.Parse(attribute));
                        }
                    }
                }
                if (!flag)
                {
                    A_0.Read();
                }
            }
            else
            {
                A_0.Read();
            }
            this.method_485(A_0);
        }
    }

    private ITable method_127(IDocumentObject A_0)
    {
        ITable table = null;
        if (A_0 is HeaderFooter)
        {
            table = (A_0 as HeaderFooter).AddTable();
        }
        else if (A_0 is Footnote)
        {
            table = (A_0 as Footnote).TextBody.AddTable();
        }
        else if (A_0 is Comment)
        {
            table = (A_0 as Comment).Body.AddTable();
        }
        else if (A_0 is StructureDocumentTag)
        {
            table = (A_0 as StructureDocumentTag).SDTContent.AddTable();
        }
        else
        {
            table = this.document_0.LastSection.AddTable();
        }
        if ((this.method_9() != null) && !this.method_9().IsFieldRange)
        {
            this.method_9().IsFieldRange = true;
            this.method_129(table as Table);
        }
        return table;
    }

    private void method_128(IDocumentObject A_0, IDocumentObject A_1)
    {
        if ((A_0 is HeaderFooter) && (A_0 as HeaderFooter).Items.Contains(A_1))
        {
            (A_0 as HeaderFooter).Items.Remove(A_1);
        }
        else if ((A_0 is Footnote) && (A_0 as Footnote).TextBody.Items.Contains(A_1))
        {
            (A_0 as Footnote).TextBody.Items.Remove(A_1);
        }
        else if ((A_0 is Comment) && (A_0 as Comment).Body.Items.Contains(A_1))
        {
            (A_0 as Comment).Body.Items.Remove(A_1);
        }
        else if ((A_0 is StructureDocumentTag) && (A_0 as StructureDocumentTag).SDTContent.Items.Contains(A_1))
        {
            (A_0 as StructureDocumentTag).SDTContent.Items.Remove(A_1);
        }
        else if (this.document_0.LastSection.Body.Items.Contains(A_1))
        {
            this.document_0.LastSection.Body.Items.Remove(A_1);
        }
        if (((this.method_9() != null) && this.method_9().IsFieldRange) && this.method_9().Range.method_8().Contains(A_1))
        {
            this.method_9().Range.method_8().Remove(A_1);
        }
    }

    private void method_129(DocumentObject A_0)
    {
        this.method_9().Range.method_8().Add(A_0);
    }

    private Dictionary<string, string> method_13()
    {
        return this.document_0.ListStyles.ListStyleNames;
    }

    private void method_130(XmlReader A_0, ParagraphItemCollection A_1)
    {
        int num = 9;
        string attribute = A_0.GetAttribute(BookmarkStart.b("䘮唰", 9), this.dictionary_18[BookmarkStart.b("崮", 9)]);
        string str2 = A_0.GetAttribute(BookmarkStart.b("丮弰倲崴堶䬸", 9), this.dictionary_18[BookmarkStart.b("堮", 9)]);
        if ((attribute != null) || (str2 != null))
        {
            Field field = new Field(this.document_0) {
                Type = FieldType.FieldHyperlink
            };
            Hyperlink hyperlink = new Hyperlink(field);
            this.method_8().Push(field);
            if (attribute == null)
            {
                hyperlink.Type = HyperlinkType.Bookmark;
                hyperlink.BookmarkName = str2;
                this.method_456(field, A_1);
            }
            else
            {
                DictionaryEntry entry = this.method_131(attribute);
                if ((entry.Key == null) || (entry.Key.ToString() != BookmarkStart.b("䜮䔰䜲䔴ശᘸᐺ丼尾⥀♂⡄♆㩈敊≌㽎㑐㵒ⵔ㩖㕘㵚㉜ⵞౠɢᅤᑦ䝨ѪὬ࡮幰ᱲ፴ᅶၸ᡺᡼㭾歷ꂎꎐꎒꖔꆖ뚘삠힢첤좦잨\ud8aa\uc5ac욮솰삲骴\udfb6\uc0b8쮺\ud8bc\ucdbe귀ꫂꯄ곆", num)))
                {
                    return;
                }
                this.method_456(field, A_1);
                string str3 = (string) entry.Value;
                if (str3.StartsWith(BookmarkStart.b("మ", num)))
                {
                    hyperlink.Type = HyperlinkType.Bookmark;
                    hyperlink.BookmarkName = str3.Replace(BookmarkStart.b("మ", num), string.Empty);
                }
                else
                {
                    field.m_fieldValue = BookmarkStart.b("മ", num) + str3.Replace(BookmarkStart.b("献", num), BookmarkStart.b("献洰", num)) + BookmarkStart.b("മ", num);
                    field.Code = BookmarkStart.b("朮栰挲瀴收甸爺猼琾慀", num) + field.m_fieldValue;
                    if (((this.dictionary_3 != null) && this.dictionary_2.ContainsKey(attribute)) && !this.method_18()[attribute])
                    {
                        field.IsLocal = true;
                    }
                }
            }
            FieldMark mark = new FieldMark(this.document_0, FieldMarkType.FieldSeparator);
            this.method_456(mark, A_1);
            field.Separator = mark;
            if (A_0.LocalName.ToLower() == BookmarkStart.b("䜮䠰䌲倴䔶唸刺匼吾", num))
            {
                this.method_132(A_0, A_1);
                FieldMark mark2 = new FieldMark(this.document_0, FieldMarkType.FieldEnd);
                this.method_456(mark2, A_1);
                field.End = mark2;
                this.method_8().Pop();
            }
        }
    }

    private DictionaryEntry method_131(string A_0)
    {
        DictionaryEntry entry;
        int num = 0x11;
        if (((!this.string_3.StartsWith(BookmarkStart.b("弶尸娺夼娾㍀", 0x11)) && !this.string_3.StartsWith(BookmarkStart.b("儶嘸吺䤼娾㍀", num))) && (!this.string_3.StartsWith(BookmarkStart.b("吶嘸嘺值娾⽀㝂㙄", num)) && !this.bool_4)) && (!this.string_3.StartsWith(BookmarkStart.b("儶嘸吺䤼儾⹀㝂⁄㑆", num)) && !this.string_3.StartsWith(BookmarkStart.b("制圸强匼倾㕀♂㙄", num))))
        {
            if (this.dictionary_2.ContainsKey(A_0))
            {
                entry = this.dictionary_2[A_0];
            }
            return entry;
        }
        string str = string.Empty;
        if (!this.string_3.StartsWith(BookmarkStart.b("弶尸娺夼娾㍀", num)) && !this.string_3.StartsWith(BookmarkStart.b("儶嘸吺䤼娾㍀", num)))
        {
            if (this.string_3.StartsWith(BookmarkStart.b("吶嘸嘺值娾⽀㝂㙄", num)))
            {
                str = BookmarkStart.b("吶嘸嘺值娾⽀㝂㙄楆ㅈ♊⅌慎⍐㙒㥔⑖", num);
            }
            else
            {
                str = this.bool_4 ? BookmarkStart.b("儶嘸吺䤼儾⹀㝂⁄㑆杈㍊⁌⍎罐⅒ご㭖⩘", num) : BookmarkStart.b("制圸强匼倾㕀♂㙄楆ㅈ♊⅌慎⍐㙒㥔⑖", num);
            }
        }
        else
        {
            str = this.string_3;
        }
        Dictionary<string, DictionaryEntry> dictionary = this.method_466(str);
        if ((dictionary != null) && dictionary.ContainsKey(A_0))
        {
            entry = dictionary[A_0];
        }
        return entry;
    }

    private void method_132(XmlReader A_0, ParagraphItemCollection A_1)
    {
        int num = 0x13;
        A_0.MoveToElement();
        if (A_0.LocalName != BookmarkStart.b("儸䈺䴼娾㍀⽂ⱄ⥆≈", 0x13))
        {
            throw new XmlException(BookmarkStart.b("儸䈺䴼娾㍀⽂ⱄ⥆≈", num));
        }
        if (!A_0.IsEmptyElement)
        {
            A_0.Read();
            this.method_485(A_0);
            while (A_0.LocalName != BookmarkStart.b("儸䈺䴼娾㍀⽂ⱄ⥆≈", num))
            {
                string localName = A_0.LocalName;
                if (localName != null)
                {
                    if (!(localName == BookmarkStart.b("弸场夼氾⡀⹂㕄⭆ⱈ", num)))
                    {
                        if (localName == BookmarkStart.b("䬸", num))
                        {
                            this.method_145(A_0, A_1);
                        }
                    }
                    else
                    {
                        this.method_133(A_0, A_1);
                    }
                }
                A_0.Read();
                this.method_485(A_0);
            }
            this.characterFormat_0 = null;
        }
    }

    private bool method_133(XmlReader A_0, ParagraphItemCollection A_1)
    {
        int num = 3;
        string attribute = A_0.GetAttribute(BookmarkStart.b("䀨䔪帬嬮䌰", 3), this.dictionary_18[BookmarkStart.b("帨", 3)]);
        if (string.IsNullOrEmpty(attribute))
        {
            attribute = this.method_294(A_0.ReadInnerXml());
        }
        Field field = this.method_159(attribute);
        field.ParseFieldCode(field.Code);
        if (this.characterFormat_0 != null)
        {
            field.ApplyCharacterFormat(this.characterFormat_0);
        }
        this.method_455(field, A_1);
        if (A_0.IsEmptyElement)
        {
            switch (field.Type)
            {
                case FieldType.FieldNumPages:
                case FieldType.FieldPage:
                {
                    FieldMark mark = new FieldMark(this.document_0, FieldMarkType.FieldSeparator);
                    this.method_455(mark, A_1);
                    field.Separator = mark;
                    TextRange range = new TextRange(this.document_0);
                    range.ApplyCharacterFormat(this.characterFormat_0);
                    this.method_455(range, A_1);
                    mark = new FieldMark(this.document_0, FieldMarkType.FieldEnd);
                    this.method_455(mark, A_1);
                    field.End = mark;
                    break;
                }
            }
            return false;
        }
        if (field.Type == FieldType.FieldMergeField)
        {
            this.method_8().Push(field);
            this.fieldCharType_0 = FieldCharType.SimpleField;
            A_0.Read();
            while (A_0.LocalName != BookmarkStart.b("伨䜪䤬簮堰帲䔴嬶尸", num))
            {
                this.method_145(A_0, A_1);
                A_0.Read();
                this.method_485(A_0);
            }
            this.method_8().Pop();
            this.fieldCharType_0 = FieldCharType.Unknown;
            return true;
        }
        if (field.Type == FieldType.FieldNext)
        {
            Paragraph paragraph = new Paragraph(this.document_0);
            this.method_8().Push(field);
            this.fieldCharType_0 = FieldCharType.SimpleField;
            A_0.Read();
            while (A_0.LocalName != BookmarkStart.b("伨䜪䤬簮堰帲䔴嬶尸", num))
            {
                this.method_145(A_0, paragraph.Items);
                A_0.Read();
                this.method_485(A_0);
            }
            field.m_formattingString = paragraph.Text;
            field.Text = paragraph.Text;
            this.method_8().Pop();
            this.fieldCharType_0 = FieldCharType.Unknown;
            return true;
        }
        FieldMark mark2 = new FieldMark(this.document_0, FieldMarkType.FieldSeparator);
        this.method_455(mark2, A_1);
        field.Separator = mark2;
        bool flag = false;
        A_0.Read();
        while (A_0.LocalName != BookmarkStart.b("伨䜪䤬簮堰帲䔴嬶尸", num))
        {
            if (!(A_0.LocalName != BookmarkStart.b("夨", num)))
            {
                break;
            }
            if (A_0.LocalName == BookmarkStart.b("娨伪夬", num))
            {
                IStructureDocument document = new StructureDocumentTagInline(this.document_0);
                this.method_455(document as ParagraphBase, A_1);
                if (A_1.OwnerBase is Paragraph)
                {
                    (A_1.OwnerBase as Paragraph).bool_6 = true;
                }
                this.method_298(A_0, document as StructureDocumentTagInline);
            }
            else
            {
                this.method_145(A_0, A_1);
            }
            A_0.Read();
            this.method_485(A_0);
            flag = true;
        }
        if (!flag)
        {
            TextRange range2 = new TextRange(this.document_0);
            if (this.characterFormat_0 != null)
            {
                range2.ApplyCharacterFormat(this.characterFormat_0);
            }
            this.method_455(range2, A_1);
        }
        mark2 = new FieldMark(this.document_0, FieldMarkType.FieldEnd);
        this.method_455(mark2, A_1);
        field.End = mark2;
        return true;
    }

    private void method_134(XmlReader A_0, ParagraphItemCollection A_1)
    {
        string attribute = A_0.GetAttribute(BookmarkStart.b("倸强", 0x13), this.dictionary_18[BookmarkStart.b("丸", 0x13)]);
        if (this.method_19().ContainsKey(attribute))
        {
            this.method_136(attribute, A_1);
        }
    }

    private void method_135(XmlReader A_0, IDocumentObject A_1)
    {
        string attribute = A_0.GetAttribute(BookmarkStart.b("並䴨", 1), this.dictionary_18[BookmarkStart.b("倦", 1)]);
        if (this.method_19().ContainsKey(attribute))
        {
            Paragraph lastChild = null;
            if (A_1 is Paragraph)
            {
                lastChild = A_1 as Paragraph;
            }
            else if ((A_1 == null) && (this.document_0.LastSection.Body.LastChild is StructureDocumentTag))
            {
                lastChild = this.document_0.LastSection.Body.LastChild.LastChild as Paragraph;
            }
            else if (A_1 == null)
            {
                lastChild = this.document_0.LastParagraph;
            }
            else if (!this.dictionary_11.ContainsKey(attribute))
            {
                if ((A_1 is Table) && ((A_1 as Table).OwnerTextBody != null))
                {
                    TableRow lastRow = (A_1 as Table).LastRow;
                    if (lastRow != null)
                    {
                        lastChild = this.method_138(lastRow);
                    }
                    else
                    {
                        lastChild = (A_1 as Table).OwnerTextBody.AddParagraph();
                    }
                }
                else if (A_1 is TableCell)
                {
                    lastChild = this.method_137(A_1 as TableCell);
                }
                else if (A_1 is TableRow)
                {
                    lastChild = this.method_138(A_1 as TableRow);
                }
            }
            if (lastChild != null)
            {
                this.method_136(attribute, lastChild.Items);
            }
            else
            {
                this.list_5.Add(attribute);
            }
        }
    }

    private void method_136(string A_0, ParagraphItemCollection A_1)
    {
        if (this.method_19().ContainsKey(A_0))
        {
            BookmarkStart start = this.method_19()[A_0];
            BookmarkEnd entity = new BookmarkEnd(this.document_0, start.Name);
            if ((start.ColumnFirst > -1) && (start.ColumnLast > -1))
            {
                entity.IsCellGroupBkmk = true;
            }
            A_1.Add(entity);
        }
    }

    private Paragraph method_137(TableCell A_0)
    {
        Paragraph lastItem = null;
        if ((A_0.Items != null) && (A_0.Items.Count > 0))
        {
            DocumentObject obj2 = A_0.Items[A_0.Items.Count - 1];
            if (obj2 is Paragraph)
            {
                return (obj2 as Paragraph);
            }
            if (obj2 is StructureDocumentTag)
            {
                lastItem = (obj2 as StructureDocumentTag).ChildObjects.LastItem as Paragraph;
            }
        }
        return lastItem;
    }

    private Paragraph method_138(TableRow A_0)
    {
        Paragraph paragraph = null;
        if (A_0.Cells.Count > 0)
        {
            paragraph = this.method_137(A_0.Cells[A_0.Cells.Count - 1]);
        }
        return paragraph;
    }

    private void method_139(XmlReader A_0, ParagraphItemCollection A_1)
    {
        int num = 10;
        string attribute = A_0.GetAttribute(BookmarkStart.b("帯匱夳匵", 10), this.dictionary_18[BookmarkStart.b("䜯", 10)]);
        string key = A_0.GetAttribute(BookmarkStart.b("夯嘱", 10), this.dictionary_18[BookmarkStart.b("䜯", 10)]);
        BookmarkStart start = new BookmarkStart(this.document_0, attribute);
        string str3 = A_0.GetAttribute(BookmarkStart.b("匯崱堳瀵儷䠹伻䨽", 10), this.dictionary_18[BookmarkStart.b("䜯", 10)]);
        if (!string.IsNullOrEmpty(str3))
        {
            start.ColumnFirst = int.Parse(str3);
        }
        str3 = A_0.GetAttribute(BookmarkStart.b("匯崱堳稵夷䤹䠻", num), this.dictionary_18[BookmarkStart.b("䜯", num)]);
        if (!string.IsNullOrEmpty(str3))
        {
            start.ColumnLast = int.Parse(str3);
        }
        if (!this.method_19().ContainsKey(key))
        {
            this.method_19().Add(key, start);
        }
        else
        {
            this.method_19()[key] = start;
        }
        if (A_1 == null)
        {
            this.dictionary_11.Add(key, start);
        }
        else
        {
            A_1.Add(start);
        }
    }

    private Dictionary<string, string> method_14()
    {
        if (this.dictionary_7 == null)
        {
            this.dictionary_7 = new Dictionary<string, string>();
        }
        return this.dictionary_7;
    }

    private void method_140(XmlReader A_0, ParagraphItemCollection A_1)
    {
        string attribute = A_0.GetAttribute(BookmarkStart.b("䄧丩", 2), this.dictionary_18[BookmarkStart.b("弧", 2)]);
        PermissionStart start = new PermissionStart(this.document_0, attribute) {
            EditorGroup = this.method_143(A_0),
            DisplacedByCustomXml = this.method_144(A_0),
            Editor = A_0.GetAttribute(BookmarkStart.b("䴧丩", 2), this.dictionary_18[BookmarkStart.b("弧", 2)])
        };
        string str2 = A_0.GetAttribute(BookmarkStart.b("䬧䔩䀫栭夯䀱䜳䈵", 2), this.dictionary_18[BookmarkStart.b("弧", 2)]);
        if (!string.IsNullOrEmpty(str2))
        {
            start.ColumnFirst = int.Parse(str2);
        }
        if (!string.IsNullOrEmpty(str2))
        {
            start.ColumnLast = int.Parse(str2);
        }
        if (A_1 == null)
        {
            this.dictionary_12.Add(attribute, start);
        }
        else
        {
            A_1.Add(start);
        }
    }

    private void method_141(XmlReader A_0, IDocumentObject A_1)
    {
        string attribute = A_0.GetAttribute(BookmarkStart.b("䀨伪", 3), this.dictionary_18[BookmarkStart.b("帨", 3)]);
        PermissionEnd entity = new PermissionEnd(this.document_0, attribute) {
            DisplacedByCustomXml = this.method_144(A_0)
        };
        Paragraph lastChild = null;
        if (A_1 is Paragraph)
        {
            lastChild = A_1 as Paragraph;
        }
        else if ((A_1 != null) && (A_1 is StructureDocumentTag))
        {
            lastChild = A_1.Owner.ChildObjects.LastItem.LastChild as Paragraph;
        }
        else if (A_1 == null)
        {
            lastChild = this.document_0.LastParagraph;
        }
        if (lastChild != null)
        {
            lastChild.Items.Add(entity);
        }
        else
        {
            this.dictionary_13.Add(attribute, entity);
        }
    }

    private void method_142(XmlReader A_0, ParagraphItemCollection A_1)
    {
        string attribute = A_0.GetAttribute(BookmarkStart.b("䐬䬮", 7), this.dictionary_18[BookmarkStart.b("娬", 7)]);
        PermissionEnd end = new PermissionEnd(this.document_0, attribute) {
            DisplacedByCustomXml = this.method_144(A_0)
        };
        if (A_1 == null)
        {
            this.dictionary_13.Add(attribute, end);
        }
        else
        {
            A_1.Add(end);
        }
    }

    private EditingGroup method_143(XmlReader A_0)
    {
        int num = 12;
        string attribute = A_0.GetAttribute(BookmarkStart.b("圱倳焵䨷䨹", 12), this.dictionary_18[BookmarkStart.b("䔱", 12)]);
        switch (attribute)
        {
            case null:
            case string.Empty:
                return EditingGroup.None;
        }
        string key = attribute;
        if (key != null)
        {
            int num2;
            if (Class1160.dictionary_62 == null)
            {
                Dictionary<string, int> dictionary1 = new Dictionary<string, int>(6);
                dictionary1.Add(BookmarkStart.b("匱倳嬵儷吹唻䴽㐿ぁ╃㉅❇㡉㽋", num), 0);
                dictionary1.Add(BookmarkStart.b("儱嬳堵䰷䠹唻尽㔿㙁⭃㑅㭇", num), 1);
                dictionary1.Add(BookmarkStart.b("儱䄳䐵䨷弹刻䨽", num), 2);
                dictionary1.Add(BookmarkStart.b("圱倳張䰷唹主䴽", num), 3);
                dictionary1.Add(BookmarkStart.b("圱䈳匵䨷䌹医倽┿", num), 4);
                dictionary1.Add(BookmarkStart.b("崱䌳堵崷䠹伻", num), 5);
                Class1160.dictionary_62 = dictionary1;
            }
            if (Class1160.dictionary_62.TryGetValue(key, out num2))
            {
                switch (num2)
                {
                    case 0:
                        return EditingGroup.Administrators;

                    case 1:
                        return EditingGroup.Contributors;

                    case 2:
                        return EditingGroup.Current;

                    case 3:
                        return EditingGroup.Editors;

                    case 4:
                        return EditingGroup.Everyone;

                    case 5:
                        return EditingGroup.Owners;
                }
            }
        }
        return EditingGroup.None;
    }

    private DisplacedByCustomXml method_144(XmlReader A_0)
    {
        int num = 8;
        string attribute = A_0.GetAttribute(BookmarkStart.b("䨭夯䄱䐳娵夷夹夻娽ȿ㭁݃㍅㭇㹉⍋⍍ࡏ㽑㡓", 8), this.dictionary_18[BookmarkStart.b("夭", 8)]);
        switch (attribute)
        {
            case null:
            case string.Empty:
                return DisplacedByCustomXml.None;
        }
        string str2 = attribute;
        if (str2 != null)
        {
            if (str2 == BookmarkStart.b("席䈯圱䈳", num))
            {
                return DisplacedByCustomXml.Prev;
            }
            if (str2 == BookmarkStart.b("䀭唯䨱䀳", num))
            {
                return DisplacedByCustomXml.Next;
            }
        }
        return DisplacedByCustomXml.None;
    }

    private void method_145(XmlReader A_0, ParagraphItemCollection A_1)
    {
        this.method_146(A_0, A_1, false, false, null);
    }

    private void method_146(XmlReader A_0, ParagraphItemCollection A_1, bool A_2, bool A_3, Class2 A_4)
    {
        int num = 10;
        while (A_0.NodeType != XmlNodeType.Element)
        {
            A_0.Read();
        }
        if (!A_0.IsEmptyElement)
        {
            this.stack_0.Push((this.characterFormat_0 != null) ? ((CharacterFormat) this.characterFormat_0.method_23()) : this.characterFormat_0);
            if (!this.bool_3)
            {
                this.characterFormat_0 = null;
            }
            bool flag = false;
            bool flag2 = false;
            bool flag3 = false;
            A_0.Read();
            MemoryStream stream = null;
            Class6 class2 = null;
            this.method_485(A_0);
            while (A_0.LocalName != BookmarkStart.b("䈯", num))
            {
                Paragraph paragraph;
                CharacterFormat format;
                TabRelativeToPosition position;
                TabJustification justification;
                TabLeader leader;
                Paragraph paragraph2;
                ParagraphBase base2 = null;
                flag = false;
                if (A_0.NodeType != XmlNodeType.Element)
                {
                    goto Label_089F;
                }
                string localName = A_0.LocalName;
                if (localName != null)
                {
                    int num2;
                    if (Class1160.dictionary_63 == null)
                    {
                        Dictionary<string, int> dictionary1 = new Dictionary<string, int>(0x1a);
                        dictionary1.Add(BookmarkStart.b("䈯戱䘳", num), 0);
                        dictionary1.Add(BookmarkStart.b("启圱堳戵崷䈹䠻", num), 1);
                        dictionary1.Add(BookmarkStart.b("䐯", num), 2);
                        dictionary1.Add(BookmarkStart.b("启䀱唳䄵儷吹嬻", num), 3);
                        dictionary1.Add(BookmarkStart.b("弯倱帳匵嬷丹", num), 4);
                        dictionary1.Add(BookmarkStart.b("䀯嬱圳䈵", num), 5);
                        dictionary1.Add(BookmarkStart.b("刯䀱", num), 6);
                        dictionary1.Add(BookmarkStart.b("匯䀱", num), 7);
                        dictionary1.Add(BookmarkStart.b("嘯帱倳电倷嬹主", num), 8);
                        dictionary1.Add(BookmarkStart.b("启圱堳缵嘷䤹䠻䰽ᐿ❁㱃㉅", num), 9);
                        dictionary1.Add(BookmarkStart.b("夯就䜳䈵䨷渹夻䘽㐿", num), 10);
                        dictionary1.Add(BookmarkStart.b("嘯崱嬳䈵嘷唹䠻嬽ሿ❁≃⍅㩇⽉≋ⵍ㕏", num), 11);
                        dictionary1.Add(BookmarkStart.b("唯就倳堵圷丹夻氽┿⑁⅃㑅ⵇ⑉⽋⭍", num), 12);
                        dictionary1.Add(BookmarkStart.b("嘯崱嬳䈵嘷唹䠻嬽ሿ❁≃", num), 13);
                        dictionary1.Add(BookmarkStart.b("唯就倳堵圷丹夻氽┿⑁", num), 14);
                        dictionary1.Add(BookmarkStart.b("䀯䘱唳吵", num), 15);
                        dictionary1.Add(BookmarkStart.b("䐯匱嘳", num), 0x10);
                        dictionary1.Add(BookmarkStart.b("䌯䬱夳", num), 0x11);
                        dictionary1.Add(BookmarkStart.b("帯崱瘳䐵崷嬹圻瘽㤿㉁ⱃ⍅♇", num), 0x12);
                        dictionary1.Add(BookmarkStart.b("䌯崱刳䈵瀷䌹䰻嘽┿ⱁ", num), 0x13);
                        dictionary1.Add(BookmarkStart.b("匯崱夳嬵崷吹䠻氽┿⑁⅃㑅ⵇ⑉⽋⭍", num), 20);
                        dictionary1.Add(BookmarkStart.b("焯帱䀳匵䨷吹崻䨽┿Ł⭃⡅㱇⽉≋㩍", num), 0x15);
                        dictionary1.Add(BookmarkStart.b("猯娱嬳張嬷弹", num), 0x16);
                        dictionary1.Add(BookmarkStart.b("儯帱䀳电倷伹刻唽", num), 0x17);
                        dictionary1.Add(BookmarkStart.b("䈯䜱嘳伵", num), 0x18);
                        dictionary1.Add(BookmarkStart.b("䐯倱堳", num), 0x19);
                        Class1160.dictionary_63 = dictionary1;
                    }
                    if (Class1160.dictionary_63.TryGetValue(localName, out num2))
                    {
                        switch (num2)
                        {
                            case 0:
                                goto Label_0321;

                            case 1:
                            case 2:
                                base2 = this.method_291(A_0, A_1, A_4, A_2, A_3);
                                break;

                            case 3:
                                if (!flag2 || !flag3)
                                {
                                    goto Label_03F7;
                                }
                                base2 = this.method_248(A_0, A_1, ref stream);
                                class2 = (base2 is Class6) ? (base2 as Class6) : null;
                                base2 = null;
                                goto Label_0418;

                            case 4:
                                base2 = this.method_177(A_0);
                                flag = true;
                                break;

                            case 5:
                                base2 = this.method_188(A_0, A_1, stream, class2, this.characterFormat_0);
                                flag = true;
                                stream = null;
                                break;

                            case 6:
                            case 7:
                                this.method_286(A_0, A_1);
                                break;

                            case 8:
                                this.method_154(A_0, A_1);
                                flag = true;
                                break;

                            case 9:
                            case 10:
                                this.method_152(A_0, A_1);
                                this.bool_5 = false;
                                break;

                            case 11:
                            case 12:
                                goto Label_047D;

                            case 13:
                            case 14:
                                base2 = this.method_176();
                                break;

                            case 15:
                                position = this.method_411(A_0.GetAttribute(BookmarkStart.b("䈯圱堳圵䰷匹䨻嬽ᐿⵁ", num), this.dictionary_18[BookmarkStart.b("䜯", num)]));
                                justification = this.method_410(A_0.GetAttribute(BookmarkStart.b("儯帱崳儵嘷圹夻倽㐿", num), this.dictionary_18[BookmarkStart.b("䜯", num)]));
                                leader = this.method_412(A_0.GetAttribute(BookmarkStart.b("尯圱唳刵崷䠹", num), this.dictionary_18[BookmarkStart.b("䜯", num)]));
                                switch (justification)
                                {
                                    case TabJustification.Centered:
                                    case TabJustification.Right:
                                        goto Label_0569;
                                }
                                goto Label_05A5;

                            case 0x10:
                            {
                                base2 = new TextRange(this.document_0);
                                string str3 = '\t'.ToString();
                                this.method_289(base2 as TextRange, str3, this.characterFormat_0);
                                break;
                            }
                            case 0x11:
                                base2 = this.method_288(A_0, A_1);
                                break;

                            case 0x12:
                                base2 = new TextRange(this.document_0);
                                this.method_289(base2 as TextRange, '\x001e'.ToString(), this.characterFormat_0);
                                break;

                            case 0x13:
                                base2 = new TextRange(this.document_0);
                                this.method_289(base2 as TextRange, '\x001f'.ToString(), this.characterFormat_0);
                                break;

                            case 20:
                            {
                                string attribute = A_0.GetAttribute(BookmarkStart.b("夯嘱", num), this.dictionary_18[BookmarkStart.b("䜯", num)]);
                                if (this.method_1().ContainsKey(attribute))
                                {
                                    base2 = this.method_1()[attribute];
                                    int commentId = (base2 as Comment).Format.CommentId;
                                    if (this.method_5().method_7(commentId))
                                    {
                                        Class821 class3 = this.method_5().method_2(commentId);
                                        (base2 as Comment).CommentMarkEnd = class3.method_0();
                                        (base2 as Comment).CommentMarkStart = class3.method_2();
                                    }
                                }
                                break;
                            }
                            case 0x15:
                                flag2 = true;
                                break;

                            case 0x16:
                                if (flag2)
                                {
                                    flag3 = true;
                                }
                                break;

                            case 0x17:
                                this.method_301(A_0, A_1);
                                break;

                            case 0x18:
                                base2 = this.method_147(A_0, A_1);
                                break;

                            case 0x19:
                            {
                                ITable entity = this.method_127(A_1.Owner.Owner);
                                this.method_83(A_0, entity as Table);
                                if ((entity.Rows.Count > 0) || !A_1.Owner.Owner.ChildObjects.Contains(entity))
                                {
                                    goto Label_081C;
                                }
                                A_1.Owner.Owner.ChildObjects.Remove(entity);
                                break;
                            }
                        }
                    }
                }
                goto Label_0837;
            Label_0321:
                paragraph = (A_1.Owner is SDTInlineContent) ? (A_1.Owner as SDTInlineContent).OwnerParagraph : (A_1.Owner as Paragraph);
                if (!A_0.IsEmptyElement || (this.characterFormat_0 == null))
                {
                    this.characterFormat_0 = (this.characterFormat_0 == null) ? new CharacterFormat(this.document_0) : this.characterFormat_0;
                    if ((paragraph != null) && (paragraph.ParaStyle != null))
                    {
                        this.characterFormat_0.ApplyBase(paragraph.ParaStyle.CharacterFormat);
                    }
                    this.method_378(A_0, this.characterFormat_0);
                }
                goto Label_0837;
            Label_03F7:
                base2 = this.method_248(A_0, A_1, ref stream);
                class2 = (base2 is Class6) ? (base2 as Class6) : null;
            Label_0418:
                flag = true;
                goto Label_0837;
            Label_047D:
                format = null;
                if (this.characterFormat_0 != null)
                {
                    format = this.characterFormat_0;
                }
                base2 = this.method_172(A_0);
                if (format != null)
                {
                    (base2 as Footnote).MarkerCharacterFormat.ImportContainer(format);
                }
                goto Label_0837;
            Label_0569:
                base2 = new TextRange(this.document_0);
                (base2 as TextRange).IsPTab = true;
                string str2 = '\t'.ToString();
                this.method_289(base2 as TextRange, str2, this.characterFormat_0);
            Label_05A5:
                paragraph2 = (A_1.Owner is SDTInlineContent) ? (A_1.Owner as SDTInlineContent).OwnerParagraph : (A_1.Owner as Paragraph);
                if ((paragraph2 != null) && (justification != TabJustification.Left))
                {
                    ParagraphFormat format2 = paragraph2.Format;
                    Tab tab = new Tab(this.document_0, 0f, justification, leader) {
                        TabRelativePosition = position,
                        IsPTab = true
                    };
                    format2.Tabs.method_6(tab);
                    if (!this.list_4.Contains(paragraph2))
                    {
                        this.list_4.Add(paragraph2);
                    }
                }
                goto Label_0837;
            Label_081C:
                A_1.Owner.Owner.ChildObjects.Remove(A_1.Owner);
            Label_0837:
                if (!flag)
                {
                    A_0.Read();
                    if ((A_0.LocalName == BookmarkStart.b("䈯", num)) && A_0.IsStartElement())
                    {
                        this.bool_3 = true;
                        MemoryStream stream2 = this.method_484(A_0);
                        stream2.Position = 0L;
                        XmlReader reader = Class57.smethod_18(stream2);
                        this.method_145(reader, A_1);
                        this.bool_3 = false;
                    }
                }
                goto Label_08D5;
            Label_089F:
                if ((A_0.LocalName == BookmarkStart.b("焯帱䀳匵䨷吹崻䨽┿Ł⭃⡅㱇⽉≋㩍", num)) && (A_0.NodeType == XmlNodeType.EndElement))
                {
                    flag2 = false;
                    flag3 = false;
                    A_0.Read();
                }
                else
                {
                    A_0.Read();
                }
            Label_08D5:
                this.method_485(A_0);
                if ((base2 != null) && (A_4 == null))
                {
                    this.method_456(base2, A_1);
                    this.method_414(base2);
                    if (this.bool_14)
                    {
                        FieldMark mark = new FieldMark(this.document_0, FieldMarkType.FieldEnd);
                        if (this.method_8().Count > 0)
                        {
                            this.method_9().End = mark;
                            this.method_8().Pop();
                        }
                        this.method_456(mark, A_1);
                        this.bool_14 = false;
                    }
                }
            }
            this.characterFormat_0 = this.stack_0.Pop();
        }
    }

    private Class2 method_147(XmlReader A_0, ParagraphItemCollection A_1)
    {
        int num = 11;
        if (A_0.IsEmptyElement)
        {
            return null;
        }
        Class2 class2 = new Class2(this.document_0);
        string localName = A_0.LocalName;
        A_0.Read();
        this.method_485(A_0);
        while (A_0.LocalName != localName)
        {
            string str = A_0.LocalName;
            if (str != null)
            {
                if (str != BookmarkStart.b("䌰䘲圴丶椸䤺", num))
                {
                    if (!(str == BookmarkStart.b("䌰䜲", num)))
                    {
                        if (str == BookmarkStart.b("䌰䘲圴丶笸娺丼娾", num))
                        {
                            this.method_151(A_0, class2, A_1);
                        }
                    }
                    else
                    {
                        this.method_150(A_0, class2, A_1);
                    }
                }
                else
                {
                    this.method_148(A_0, class2);
                }
            }
            A_0.Read();
        }
        return class2;
    }

    private void method_148(XmlReader A_0, Class2 A_1)
    {
        int num = 0x11;
        if (!A_0.IsEmptyElement)
        {
            string localName = A_0.LocalName;
            A_0.Read();
            this.method_485(A_0);
            while (A_0.LocalName != localName)
            {
                string str2 = A_0.LocalName;
                if (str2 != null)
                {
                    if (str2 != BookmarkStart.b("䔶䰸夺䐼績ⵀ⩂≄⥆", num))
                    {
                        if (str2 != BookmarkStart.b("弶䤸䠺", num))
                        {
                            if (str2 != BookmarkStart.b("弶䤸䠺漼帾⡀あ⁄", num))
                            {
                                if (!(str2 == BookmarkStart.b("弶䤸䠺缼帾㉀♂ᅄ≆ㅈ㽊", num)))
                                {
                                    if (!(str2 == BookmarkStart.b("嬶倸强", num)) && (str2 == BookmarkStart.b("匶倸䤺䤼䘾", num)))
                                    {
                                        A_1.method_58(this.method_469(A_0));
                                    }
                                }
                                else
                                {
                                    string attribute = A_0.GetAttribute(BookmarkStart.b("䄶堸场", num), this.dictionary_18[BookmarkStart.b("䀶", num)]);
                                    if (!string.IsNullOrEmpty(attribute))
                                    {
                                        A_1.method_54(float.Parse(attribute, NumberStyles.Number, CultureInfo.InvariantCulture) / 2f);
                                    }
                                }
                            }
                            else
                            {
                                string str = A_0.GetAttribute(BookmarkStart.b("䄶堸场", num), this.dictionary_18[BookmarkStart.b("䀶", num)]);
                                if (!string.IsNullOrEmpty(str))
                                {
                                    A_1.method_50(float.Parse(str, NumberStyles.Number, CultureInfo.InvariantCulture) / 2f);
                                }
                            }
                        }
                        else
                        {
                            string str6 = A_0.GetAttribute(BookmarkStart.b("䄶堸场", num), this.dictionary_18[BookmarkStart.b("䀶", num)]);
                            if (!string.IsNullOrEmpty(str6))
                            {
                                A_1.method_48(float.Parse(str6, NumberStyles.Number, CultureInfo.InvariantCulture) / 2f);
                            }
                        }
                    }
                    else
                    {
                        string str3 = A_0.GetAttribute(BookmarkStart.b("䄶堸场", num), this.dictionary_18[BookmarkStart.b("䀶", num)]);
                        if (!string.IsNullOrEmpty(str3))
                        {
                            A_1.method_52(this.method_149(str3));
                        }
                    }
                }
                A_0.Read();
            }
        }
    }

    private RubyAlign method_149(string A_0)
    {
        int num = 1;
        string key = A_0;
        if (key != null)
        {
            int num2;
            if (Class1160.dictionary_64 == null)
            {
                Dictionary<string, int> dictionary1 = new Dictionary<string, int>(6);
                dictionary1.Add(BookmarkStart.b("䌦䀨堪夬崮堰儲䀴䌶尸眺堼䬾㕀♂㝄", num), 0);
                dictionary1.Add(BookmarkStart.b("䌦䀨堪夬崮堰儲䀴䌶尸栺䴼帾≀♂", num), 1);
                dictionary1.Add(BookmarkStart.b("䬦䰨䴪夬", num), 2);
                dictionary1.Add(BookmarkStart.b("唦䀨䰪䔬嬮", num), 3);
                dictionary1.Add(BookmarkStart.b("唦䀨䰪䔬嬮朰嘲䜴䌶倸堺尼匾", num), 4);
                dictionary1.Add(BookmarkStart.b("䐦䰨䔪夬䨮䌰", num), 5);
                Class1160.dictionary_64 = dictionary1;
            }
            if (Class1160.dictionary_64.TryGetValue(key, out num2))
            {
                switch (num2)
                {
                    case 0:
                        return RubyAlign.DistributeLetter;

                    case 1:
                        return RubyAlign.DistributeSpace;

                    case 2:
                        return RubyAlign.Left;

                    case 3:
                        return RubyAlign.Right;

                    case 4:
                        return RubyAlign.RightVertical;
                }
            }
        }
        return RubyAlign.Center;
    }

    internal Dictionary<string, DocPicture> method_15()
    {
        if (this.dictionary_6 == null)
        {
            this.dictionary_6 = new Dictionary<string, DocPicture>();
        }
        return this.dictionary_6;
    }

    private void method_150(XmlReader A_0, Class2 A_1, ParagraphItemCollection A_2)
    {
        int num = 5;
        if (!A_0.IsEmptyElement)
        {
            string localName = A_0.LocalName;
            A_0.Read();
            this.method_485(A_0);
            while (A_0.LocalName != localName)
            {
                if (A_0.LocalName == BookmarkStart.b("太", num))
                {
                    this.method_146(A_0, A_2, true, false, A_1);
                }
                A_0.Read();
            }
        }
    }

    private void method_151(XmlReader A_0, Class2 A_1, ParagraphItemCollection A_2)
    {
        int num = 0x10;
        if (!A_0.IsEmptyElement)
        {
            string localName = A_0.LocalName;
            A_0.Read();
            this.method_485(A_0);
            while (A_0.LocalName != localName)
            {
                if (A_0.LocalName == BookmarkStart.b("䐵", num))
                {
                    this.method_146(A_0, A_2, false, true, A_1);
                }
                A_0.Read();
            }
        }
    }

    private void method_152(XmlReader A_0, ParagraphItemCollection A_1)
    {
        string str = A_0.ReadString();
        switch (str)
        {
            case null:
            case string.Empty:
                return;
        }
        Field field2 = this.method_159(str);
        if ((!this.bool_5 && (this.method_9() != null)) && (!this.method_169() || (field2 != this.method_9())))
        {
            ParagraphBase lastItem = A_1.LastItem as ParagraphBase;
            IDocumentObject obj2 = this.method_153(this.method_9().NextSibling);
            int index = -1;
            if ((this.method_9() != null) && (obj2 == null))
            {
                lastItem = this.method_9();
                if (this.method_9().NextSibling != null)
                {
                    index = A_1.IndexOf(A_1.LastItem);
                }
                else
                {
                    index = A_1.IndexOf(this.method_9());
                }
            }
            if (((this.fieldCharType_0 == FieldCharType.Seperate) || (this.fieldCharType_0 == FieldCharType.SimpleField)) && (lastItem is MergeField))
            {
                Field field4 = this.method_9();
                field4.Text = field4.Text + str;
                if (this.characterFormat_0 != null)
                {
                    this.method_9().ApplyCharacterFormat(this.characterFormat_0);
                }
            }
            else if (((this.method_9() != null) && (((index >= 0) && (index == (A_1.Count - 1))) || this.method_169())) && (this.fieldCharType_0 != FieldCharType.Seperate))
            {
                Field field5 = this.method_9();
                field5.Code = field5.Code + str;
                if (this.method_9().Type != FieldType.FieldUnknown)
                {
                    if (this.method_169())
                    {
                        A_1.Add(this.method_9());
                    }
                }
                else
                {
                    Field entity = this.method_8().Pop();
                    A_1.Remove(entity);
                    entity = this.method_159(entity.Code);
                    if (this.characterFormat_0 != null)
                    {
                        entity.ApplyCharacterFormat(this.characterFormat_0);
                    }
                    entity.IsLocked = this.bool_6;
                    this.bool_6 = false;
                    A_1.Add(entity);
                    if (this.method_9() != entity)
                    {
                        this.method_8().Push(entity);
                    }
                }
            }
            else
            {
                TextRange range = new TextRange(this.document_0);
                if (this.characterFormat_0 != null)
                {
                    range.ApplyCharacterFormat(this.characterFormat_0);
                }
                range.Text = str;
                this.method_456(range, A_1);
            }
        }
        else if (field2.Type == FieldType.FieldMergeField)
        {
            this.stringBuilder_0.Remove(0, this.stringBuilder_0.Length);
            if (this.characterFormat_0 != null)
            {
                field2.ApplyCharacterFormat(this.characterFormat_0);
            }
            field2.IsLocked = this.bool_6;
            this.bool_6 = false;
            this.method_456(field2, A_1);
            this.method_8().Push(field2);
        }
        else
        {
            field2.Code = str;
            if (A_1.LastItem is FormField)
            {
                FormField field3 = A_1.LastItem as FormField;
                if ((field3.Type == field2.Type) && (field3.Code != field2.Code))
                {
                    field3.Code = field3.Code + field2.Code;
                    return;
                }
            }
            this.stringBuilder_0.Remove(0, this.stringBuilder_0.Length);
            if (this.characterFormat_0 != null)
            {
                field2.ApplyCharacterFormat(this.characterFormat_0);
            }
            field2.IsLocked = this.bool_6;
            this.bool_6 = false;
            this.method_456(field2, A_1);
            this.method_414(field2);
            if (!(field2 is FormField))
            {
                this.method_8().Push(field2);
            }
        }
    }

    private IDocumentObject method_153(IDocumentObject A_0)
    {
        while ((A_0 is BookmarkStart) || (A_0 is BookmarkEnd))
        {
            A_0 = A_0.NextSibling;
        }
        return A_0;
    }

    private void method_154(XmlReader A_0, ParagraphItemCollection A_1)
    {
        int num = 3;
        string attribute = A_0.GetAttribute(BookmarkStart.b("伨䜪䤬氮夰刲䜴挶䀸䬺堼", 3), this.dictionary_18[BookmarkStart.b("帨", 3)]);
        string str2 = A_0.GetAttribute(BookmarkStart.b("伨䜪䤬挮帰倲帴", 3), this.dictionary_18[BookmarkStart.b("帨", 3)]);
        if ((attribute == BookmarkStart.b("䬨个䨬䘮弰", 3)) && (str2 != null))
        {
            this.bool_6 = this.method_110(str2);
        }
        if (attribute != null)
        {
            Stream stream = this.method_484(A_0);
            if (this.method_155(stream))
            {
                XmlReader reader = Class57.smethod_18(stream);
                this.method_161(reader, A_1);
            }
            else
            {
                string str3 = attribute;
                if (str3 != null)
                {
                    if (str3 == BookmarkStart.b("䬨个䨬䘮弰", num))
                    {
                        this.method_158();
                    }
                    else if (str3 == BookmarkStart.b("娨个崬丮䌰刲䄴制", num))
                    {
                        this.method_156(A_1);
                    }
                    else if (str3 == BookmarkStart.b("䰨䔪䤬", num))
                    {
                        this.method_157(A_1);
                    }
                }
            }
        }
    }

    private bool method_155(Stream A_0)
    {
        int num = 14;
        XmlReader reader = Class57.smethod_18(A_0);
        while (reader.Read())
        {
            if (reader.LocalName == BookmarkStart.b("刳倵簷嬹䠻弽", num))
            {
                return true;
            }
        }
        return false;
    }

    private void method_156(ParagraphItemCollection A_0)
    {
        this.bool_5 = false;
        this.fieldCharType_0 = FieldCharType.Seperate;
        ParagraphBase lastItem = A_0.LastItem as ParagraphBase;
        if (this.method_9() != null)
        {
            lastItem = this.method_9();
        }
        if (((lastItem is Field) || (lastItem is TextRange)) && !(lastItem is MergeField))
        {
            bool flag2 = (lastItem is Field) ? ((lastItem as Field).Type == FieldType.FieldTOC) : false;
            bool flag = lastItem is TextRange;
            string str2 = this.stringBuilder_0.ToString();
            if (flag2)
            {
                if (lastItem.Owner == null)
                {
                    return;
                }
                (lastItem as Field).ParseFieldCode((lastItem as Field).Code);
                TableOfContent content = new TableOfContent(this.document_0, this.method_9().FormattingString);
                this.document_0.TOC = content;
                content.FormattingString = this.method_9().FormattingString;
                A_0.Remove(lastItem);
                this.method_456(content, A_0);
                if (A_0.OwnerBase is Paragraph)
                {
                    (A_0.OwnerBase as Paragraph).IsTOCPara = true;
                }
                else
                {
                    (A_0.OwnerBase as ParagraphBase).OwnerParagraph.IsTOCPara = true;
                }
                lastItem = content.TOCField;
            }
            else if (!flag)
            {
                Field field2 = lastItem as Field;
                if ((field2 != null) && field2.FormattingString.Contains(str2))
                {
                    field2.m_formattingString = field2.m_formattingString + this.stringBuilder_0;
                }
            }
            FieldMark mark = new FieldMark(this.document_0, FieldMarkType.FieldSeparator);
            this.method_455(mark, A_0);
            if (lastItem is Field)
            {
                (lastItem as Field).Separator = mark;
            }
        }
        else if ((lastItem is MergeField) && (this.stringBuilder_0.Length > 0))
        {
            MergeField field = lastItem as MergeField;
            string fieldName = field.FieldName;
            field.ParseFieldCode(field.Value + this.stringBuilder_0.ToString());
            if (!string.IsNullOrEmpty(fieldName))
            {
                field.FieldName = fieldName;
            }
            this.stringBuilder_0.Remove(0, this.stringBuilder_0.Length);
        }
    }

    private void method_157(ParagraphItemCollection A_0)
    {
        int num = 5;
        this.bool_5 = false;
        this.fieldCharType_0 = FieldCharType.End;
        ParagraphBase lastItem = A_0.LastItem as ParagraphBase;
        if (this.method_9() != null)
        {
            lastItem = this.method_9();
        }
        if (!(lastItem is MergeField))
        {
            if ((((this.method_9() != null) && (A_0.Count > 0)) && (this.method_9() == A_0.LastItem)) && ((this.method_9().Type == FieldType.FieldNumPages) || (this.method_9().Type == FieldType.FieldPage)))
            {
                FieldMark mark = new FieldMark(this.document_0, FieldMarkType.FieldSeparator);
                this.method_455(mark, A_0);
                if (lastItem is Field)
                {
                    (lastItem as Field).Separator = mark;
                }
                TextRange range = new TextRange(this.document_0) {
                    Text = string.Empty
                };
                range.ApplyCharacterFormat(this.method_9().CharacterFormat);
                this.method_455(range, A_0);
            }
            FieldMark mark2 = new FieldMark(this.document_0, FieldMarkType.FieldEnd);
            this.method_455(mark2, A_0);
            if (lastItem is Field)
            {
                (lastItem as Field).End = mark2;
                if ((lastItem as Field).Type == FieldType.FieldUnknown)
                {
                    Paragraph ownerParagraph = lastItem.OwnerParagraph;
                    if (ownerParagraph != null)
                    {
                        string str = (lastItem as Field).Code + (lastItem as Field).method_184(ownerParagraph);
                        Field entity = this.method_159(str);
                        entity.CharacterFormat.method_21((lastItem as Field).CharacterFormat);
                        entity.IsLocked = (lastItem as Field).IsLocked;
                        int index = ownerParagraph.Items.IndexOf(lastItem);
                        if (entity is MergeField)
                        {
                            entity.ParseFieldCode(str);
                            int num3 = ownerParagraph.Items.IndexOf(mark2);
                            string str4 = string.Empty;
                            bool flag = false;
                            List<DocumentObject> list = new List<DocumentObject>();
                            for (int i = index + 1; i <= num3; i++)
                            {
                                DocumentObject item = ownerParagraph.Items[i];
                                if ((item.DocumentObjectType != DocumentObjectType.BookmarkEnd) && (item.DocumentObjectType != DocumentObjectType.BookmarkStart))
                                {
                                    list.Add(item);
                                }
                                if (item is FieldMark)
                                {
                                    if ((item as FieldMark).Type == FieldMarkType.FieldSeparator)
                                    {
                                        flag = true;
                                    }
                                    else
                                    {
                                        flag = false;
                                    }
                                }
                                if ((item is TextRange) && flag)
                                {
                                    str4 = str4 + (item as TextRange).Text;
                                }
                            }
                            foreach (DocumentObject obj3 in list)
                            {
                                if (obj3 is Field)
                                {
                                    ownerParagraph.Items.method_24(obj3);
                                }
                                else
                                {
                                    ownerParagraph.Items.Remove(obj3);
                                }
                            }
                            if (!string.IsNullOrEmpty(str4))
                            {
                                (entity as MergeField).Text = str4;
                            }
                            list.Clear();
                            list = null;
                        }
                        else
                        {
                            entity.Code = (lastItem as Field).Code;
                            entity.End = (lastItem as Field).End;
                            if ((lastItem as Field).Separator != null)
                            {
                                entity.Separator = (lastItem as Field).Separator;
                            }
                        }
                        ownerParagraph.Items.method_23(index);
                        ownerParagraph.Items.Insert(index, entity);
                    }
                }
                else if ((lastItem as Field).Type == FieldType.FieldIncludePicture)
                {
                    Field field3 = lastItem as Field;
                    bool flag2 = this.document_0.bool_3;
                    this.document_0.bool_3 = false;
                    string input = field3.method_177();
                    this.document_0.bool_3 = flag2;
                    Regex regex = new Regex(BookmarkStart.b("̪嘬琮漰串栴ᴶ䐸ሺ", num));
                    string str3 = string.Empty;
                    int num5 = -1;
                    num5 = A_0.IndexOf(field3) + 1;
                    foreach (Match match in regex.Matches(input))
                    {
                        if (string.IsNullOrEmpty(str3))
                        {
                            str3 = input.Substring(0, match.Index);
                        }
                        if (match.Value.Contains(BookmarkStart.b("昪栬紮瘰瘲猴縶簸眺礼", num)))
                        {
                            MergeField field4 = new MergeField(this.document_0) {
                                Type = FieldType.FieldMergeField,
                                Code = match.Value.TrimStart(new char[] { '{' }).TrimEnd(new char[] { '}' }).Split(new char[] { '\\' })[0].Trim()
                            };
                            field4.ParseFieldCode(field4.Code);
                            A_0.Insert(num5, field4);
                            num5++;
                        }
                        TextRange range2 = new TextRange(this.document_0) {
                            Text = input.Substring(match.Index + match.Length)
                        };
                        if (!range2.Text.Contains(BookmarkStart.b("倪", num)))
                        {
                            A_0.Insert(num5, range2);
                        }
                        field3.Code = str3;
                    }
                }
            }
            this.characterFormat_0 = null;
        }
        if ((this.stack_1 != null) && (this.stack_1.Count > 0))
        {
            Field field = this.stack_1.Pop();
            field.ParseFieldCode(field.Code);
            if ((field.Type == FieldType.FieldDate) || (field.Type == FieldType.FieldTime))
            {
                field.method_49();
            }
        }
        this.fieldCharType_0 = FieldCharType.Unknown;
    }

    private void method_158()
    {
        this.bool_5 = true;
        this.fieldCharType_0 = FieldCharType.Begin;
    }

    private Field method_159(string A_0)
    {
        int num = 7;
        Field field = null;
        string str = A_0.Trim();
        FieldType type = Class819.smethod_2(str);
        FieldType type2 = type;
        if (type2 <= FieldType.FieldMergeField)
        {
            if (type2 != FieldType.FieldIf)
            {
                if (type2 != FieldType.FieldMergeField)
                {
                    goto Label_0066;
                }
                field = new MergeField(this.document_0);
            }
            else
            {
                field = new IfField(this.document_0);
            }
            goto Label_013C;
        }
        switch (type2)
        {
            case FieldType.FieldFormTextInput:
            case FieldType.FieldFormCheckBox:
            case FieldType.FieldFormDropDown:
                if (this.method_9() != null)
                {
                    field = this.method_9();
                }
                else
                {
                    string str2 = str.ToUpper();
                    if (str2 != null)
                    {
                        if ((str2 == BookmarkStart.b("礬樮椰朲簴礶椸渺椼", num)) || (str2 == BookmarkStart.b("欬怮挰縲愴父愸漺", num)))
                        {
                            field = new TextFormField(this.document_0);
                        }
                        else if ((str2 == BookmarkStart.b("椬欮細稲昴挶", num)) || (str2 == BookmarkStart.b("欬怮挰縲焴收瘸欺礼瀾ᙀൂ", num)))
                        {
                            field = new DropDownFormField(this.document_0);
                        }
                        else if ((str2 == BookmarkStart.b("測朮琰瀲縴甶瘸挺", num)) || (str2 == BookmarkStart.b("欬怮挰縲瘴缶簸砺瘼紾เᭂ", num)))
                        {
                            field = new CheckBoxFormField(this.document_0);
                        }
                    }
                }
                goto Label_013C;
        }
    Label_0066:
        field = new Field(this.document_0);
    Label_013C:
        field.Code = field.Code + A_0;
        if (!(field is FormField))
        {
            field.Type = type;
        }
        return field;
    }

    internal Dictionary<string, DictionaryEntry> method_16()
    {
        if (this.dictionary_2 == null)
        {
            this.dictionary_2 = new Dictionary<string, DictionaryEntry>();
        }
        return this.dictionary_2;
    }

    private void method_160(ParagraphBase A_0, ParagraphItemCollection A_1)
    {
        int count = A_1.Count;
        if (A_0.PreviousSibling is FieldMark)
        {
            FieldMark mark = new FieldMark(this.document_0, FieldMarkType.FieldEnd);
            this.method_456(mark, A_1);
            (A_1[count - 3] as Field).End = mark;
        }
    }

    private void method_161(XmlReader A_0, ParagraphItemCollection A_1)
    {
        int num = 1;
        if (!A_0.IsEmptyElement)
        {
            A_0.MoveToContent();
            string localName = A_0.LocalName;
            A_0.Read();
            this.method_485(A_0);
            while (A_0.LocalName != localName)
            {
                string str;
                if (((A_0.NodeType == XmlNodeType.Element) && ((str = A_0.LocalName) != null)) && ((str == BookmarkStart.b("䄦伨漪䰬嬮倰", num)) && !A_0.IsEmptyElement))
                {
                    Stream stream = this.method_484(A_0);
                    FormField item = this.method_168(stream);
                    this.method_8().Push(item);
                    stream.Position = 0L;
                    XmlReader reader = Class57.smethod_18(stream);
                    this.method_162(reader, item);
                    if (this.characterFormat_0 != null)
                    {
                        item.ApplyCharacterFormat(this.characterFormat_0);
                    }
                    this.characterFormat_0 = null;
                    if (A_1.OwnerBase is Paragraph)
                    {
                        this.method_456(item, A_1);
                    }
                }
                if (A_0.NodeType == XmlNodeType.Whitespace)
                {
                    this.method_485(A_0);
                }
            }
        }
    }

    private void method_162(XmlReader A_0, FormField A_1)
    {
        int num = 9;
        if (!A_0.IsEmptyElement)
        {
            A_0.MoveToContent();
            string localName = A_0.LocalName;
            A_0.Read();
            this.method_485(A_0);
            while (A_0.LocalName != localName)
            {
                if (A_0.EOF)
                {
                    break;
                }
                if (A_0.NodeType == XmlNodeType.Element)
                {
                    string key = A_0.LocalName;
                    if (key != null)
                    {
                        int num2;
                        if (Class1160.dictionary_65 == null)
                        {
                            Dictionary<string, int> dictionary1 = new Dictionary<string, int>(10);
                            dictionary1.Add(BookmarkStart.b("䰮夰嘲嘴尶笸吺䔼", num), 0);
                            dictionary1.Add(BookmarkStart.b("嬮吰䬲䄴縶圸䬺䠼䬾", num), 1);
                            dictionary1.Add(BookmarkStart.b("䬮唰缲尴䐶䴸", num), 2);
                            dictionary1.Add(BookmarkStart.b("䄮倰帲倴", num), 3);
                            dictionary1.Add(BookmarkStart.b("䨮弰刲圴嬶尸强", num), 4);
                            dictionary1.Add(BookmarkStart.b("䰮倰弲嘴砶圸縺䔼嘾㕀", num), 5);
                            dictionary1.Add(BookmarkStart.b("䜮吰弲䔴挶尸䌺䤼", num), 6);
                            dictionary1.Add(BookmarkStart.b("尮䔰刲䄴䈶䨸漺堼䜾㕀", num), 7);
                            dictionary1.Add(BookmarkStart.b("䨮弰䜲䜴丶琸娺帼䴾⹀", num), 8);
                            dictionary1.Add(BookmarkStart.b("䨮䤰娲䄴稶堸堺似倾", num), 9);
                            Class1160.dictionary_65 = dictionary1;
                        }
                        if (Class1160.dictionary_65.TryGetValue(key, out num2))
                        {
                            switch (num2)
                            {
                                case 0:
                                    this.method_167(A_0, A_1 as CheckBoxFormField);
                                    break;

                                case 1:
                                    this.method_164(A_0, A_1 as TextFormField);
                                    break;

                                case 2:
                                    this.method_163(A_0, A_1 as DropDownFormField);
                                    break;

                                case 3:
                                    A_1.Name = A_0.GetAttribute(BookmarkStart.b("央倰弲", num), this.dictionary_18[BookmarkStart.b("堮", num)]);
                                    break;

                                case 4:
                                    A_1.Enabled = this.method_469(A_0);
                                    break;

                                case 5:
                                    A_1.CalculateOnExit = this.method_469(A_0);
                                    break;

                                case 6:
                                {
                                    string attribute = A_0.GetAttribute(BookmarkStart.b("央倰弲", num), this.dictionary_18[BookmarkStart.b("堮", num)]);
                                    if (attribute != null)
                                    {
                                        A_1.Help = attribute;
                                    }
                                    break;
                                }
                                case 7:
                                {
                                    string str2 = A_0.GetAttribute(BookmarkStart.b("央倰弲", num), this.dictionary_18[BookmarkStart.b("堮", num)]);
                                    if (str2 != null)
                                    {
                                        A_1.StatusBarHelp = str2;
                                    }
                                    break;
                                }
                                case 8:
                                    A_1.MacroOnStart = A_0.GetAttribute(BookmarkStart.b("央倰弲", num), this.dictionary_18[BookmarkStart.b("堮", num)]);
                                    break;

                                case 9:
                                    A_1.MacroOnEnd = A_0.GetAttribute(BookmarkStart.b("央倰弲", num), this.dictionary_18[BookmarkStart.b("堮", num)]);
                                    break;
                            }
                        }
                    }
                    A_0.Read();
                }
                else
                {
                    A_0.Read();
                }
                this.method_485(A_0);
            }
        }
    }

    private void method_163(XmlReader A_0, DropDownFormField A_1)
    {
        int num = 7;
        if (!A_0.IsEmptyElement)
        {
            A_0.MoveToContent();
            string localName = A_0.LocalName;
            A_0.Read();
            this.method_485(A_0);
            while (A_0.LocalName != localName)
            {
                if (A_0.EOF)
                {
                    break;
                }
                if (A_0.NodeType == XmlNodeType.Element)
                {
                    string str2 = A_0.LocalName;
                    if (str2 != null)
                    {
                        if (str2 != BookmarkStart.b("䄬䘮䈰䜲瀴夶䴸䤺䐼", num))
                        {
                            if (!(str2 == BookmarkStart.b("弬䨮䈰䘲头䌶", num)))
                            {
                                if (str2 == BookmarkStart.b("䤬䨮地刲䀴嬶䴸", num))
                                {
                                    int num2 = int.Parse(A_0.GetAttribute(BookmarkStart.b("嬬丮崰", num), this.dictionary_18[BookmarkStart.b("娬", num)]));
                                    A_1.DefaultDropDownValue = num2;
                                }
                            }
                            else
                            {
                                int num3 = int.Parse(A_0.GetAttribute(BookmarkStart.b("嬬丮崰", num), this.dictionary_18[BookmarkStart.b("娬", num)]));
                                A_1.DropDownSelectedIndex = num3;
                            }
                        }
                        else
                        {
                            string attribute = A_0.GetAttribute(BookmarkStart.b("嬬丮崰", num), this.dictionary_18[BookmarkStart.b("娬", num)]);
                            A_1.DropDownItems.Add(attribute);
                        }
                    }
                    A_0.Read();
                }
                else
                {
                    A_0.Read();
                }
                this.method_485(A_0);
            }
        }
    }

    private void method_164(XmlReader A_0, TextFormField A_1)
    {
        int num = 8;
        if (!A_0.IsEmptyElement)
        {
            A_0.MoveToContent();
            string localName = A_0.LocalName;
            A_0.Read();
            this.method_485(A_0);
            while (A_0.LocalName != localName)
            {
                if (A_0.EOF)
                {
                    break;
                }
                if (A_0.NodeType == XmlNodeType.Element)
                {
                    string str2 = A_0.LocalName;
                    if (str2 != null)
                    {
                        if (str2 != BookmarkStart.b("娭䤯䈱儳", num))
                        {
                            if (str2 != BookmarkStart.b("䨭唯吱唳䌵吷丹", num))
                            {
                                if (str2 != BookmarkStart.b("䌭儯䨱砳匵嘷崹䠻嘽", num))
                                {
                                    if (str2 == BookmarkStart.b("䠭弯䀱夳圵䰷", num))
                                    {
                                        string attribute = A_0.GetAttribute(BookmarkStart.b("堭儯帱", num), this.dictionary_18[BookmarkStart.b("夭", num)]);
                                        if (A_1.TextFieldType == TextFormFieldType.RegularText)
                                        {
                                            A_1.TextFormat = this.method_165(attribute);
                                        }
                                        else
                                        {
                                            A_1.StringFormat = attribute;
                                        }
                                    }
                                }
                                else
                                {
                                    A_1.MaximumLength = int.Parse(A_0.GetAttribute(BookmarkStart.b("堭儯帱", num), this.dictionary_18[BookmarkStart.b("夭", num)]));
                                }
                            }
                            else
                            {
                                A_1.DefaultText = A_0.GetAttribute(BookmarkStart.b("堭儯帱", num), this.dictionary_18[BookmarkStart.b("夭", num)]);
                            }
                        }
                        else
                        {
                            string str4 = A_0.GetAttribute(BookmarkStart.b("堭儯帱", num), this.dictionary_18[BookmarkStart.b("夭", num)]);
                            A_1.TextFieldType = this.method_166(str4);
                        }
                    }
                    A_0.Read();
                }
                else
                {
                    A_0.Read();
                }
                this.method_485(A_0);
            }
        }
    }

    private TextFormat method_165(string A_0)
    {
        int num = 2;
        string str = A_0;
        if (str != null)
        {
            if (str == BookmarkStart.b("紧娩尫䬭䈯儱唳䔵崷", num))
            {
                return TextFormat.Uppercase;
            }
            if (str == BookmarkStart.b("搧䔩嬫䬭䈯儱唳䔵崷", num))
            {
                return TextFormat.Lowercase;
            }
            if (str == BookmarkStart.b("渧䌩師崭䐯ሱ圳圵䠷匹䠻弽ⰿ", num))
            {
                return TextFormat.FirstCapital;
            }
            if (str == BookmarkStart.b("簧䌩堫䈭唯ሱ圳圵䬷弹", num))
            {
                return TextFormat.Titlecase;
            }
        }
        return TextFormat.None;
    }

    private TextFormFieldType method_166(string A_0)
    {
        int num = 11;
        string str = A_0;
        if (str != null)
        {
            if (str == BookmarkStart.b("弰䘲場唶尸䤺", num))
            {
                return TextFormFieldType.NumberText;
            }
            if (str == BookmarkStart.b("到䘲䜴䔶尸唺䤼笾⁀㝂⁄", num))
            {
                return TextFormFieldType.CurrentDate;
            }
            if (str == BookmarkStart.b("到䘲䜴䔶尸唺䤼款⡀⹂⁄", num))
            {
                return TextFormFieldType.CurrentTime;
            }
            if (str == BookmarkStart.b("唰刲䄴制", num))
            {
                return TextFormFieldType.DateText;
            }
            if (str == BookmarkStart.b("到刲头吶䰸场尼䬾⑀❂", num))
            {
                return TextFormFieldType.Calculation;
            }
        }
        return TextFormFieldType.RegularText;
    }

    private void method_167(XmlReader A_0, CheckBoxFormField A_1)
    {
        int num = 6;
        if (!A_0.IsEmptyElement)
        {
            A_0.MoveToContent();
            string localName = A_0.LocalName;
            A_0.Read();
            this.method_485(A_0);
            while (A_0.LocalName != localName)
            {
                if (A_0.EOF)
                {
                    break;
                }
                if (A_0.NodeType == XmlNodeType.Element)
                {
                    string str = A_0.LocalName;
                    if (str != null)
                    {
                        if (str != BookmarkStart.b("弫䜭䨯圱申䌵䰷唹", num))
                        {
                            if (str != BookmarkStart.b("䠫䬭嘯匱䄳娵䰷", num))
                            {
                                if (!(str == BookmarkStart.b("伫䘭唯儱弳匵尷", num)))
                                {
                                    if (str == BookmarkStart.b("弫䜭䨯圱", num))
                                    {
                                        A_1.CheckBoxSize = int.Parse(A_0.GetAttribute(BookmarkStart.b("娫伭尯", num), this.dictionary_18[BookmarkStart.b("嬫", num)])) / 2;
                                        A_1.SizeType = CheckBoxSizeType.Exactly;
                                    }
                                }
                                else
                                {
                                    A_1.Checked = this.method_469(A_0);
                                }
                            }
                            else
                            {
                                A_1.DefaultCheckBoxValue = this.method_469(A_0);
                            }
                        }
                        else
                        {
                            bool flag = this.method_469(A_0);
                            A_1.SizeType = flag ? CheckBoxSizeType.Auto : CheckBoxSizeType.Exactly;
                        }
                    }
                    A_0.Read();
                }
                else
                {
                    A_0.Read();
                }
                this.method_485(A_0);
            }
        }
    }

    private FormField method_168(Stream A_0)
    {
        int num = 1;
        A_0.Position = 0L;
        XmlReader reader = Class57.smethod_18(A_0);
        while (reader.Read())
        {
            string localName = reader.LocalName;
            if (localName != null)
            {
                if (localName == BookmarkStart.b("䐦䄨个丬䐮猰尲䴴", num))
                {
                    return new CheckBoxFormField(this.document_0);
                }
                if (localName == BookmarkStart.b("䌦䴨未䐬尮䔰", num))
                {
                    return new DropDownFormField(this.document_0);
                }
                if (localName == BookmarkStart.b("匦䰨匪夬昮弰䌲䀴䌶", num))
                {
                    return new TextFormField(this.document_0);
                }
            }
        }
        return new TextFormField(this.document_0);
    }

    private bool method_169()
    {
        FieldType type = this.method_9().Type;
        if (((type != FieldType.FieldFormCheckBox) && (type != FieldType.FieldFormDropDown)) && (type != FieldType.FieldFormTextInput))
        {
            return false;
        }
        return true;
    }

    private List<string> method_17()
    {
        if (this.list_0 == null)
        {
            this.list_0 = new List<string>();
        }
        return this.list_0;
    }

    private void method_170(bool A_0)
    {
        int num = 3;
        string str = string.Empty;
        str = A_0 ? BookmarkStart.b("伨䐪䈬嬮弰尲䄴制䨸ᔺ䔼刾ⵀ", num) : BookmarkStart.b("䰨䔪䤬䄮帰䜲倴䐶᜸䌺值匾", num);
        Class229 class2 = this.method_465(BookmarkStart.b("帨䐪弬䬮Ḱ", num), str);
        if (class2 != null)
        {
            this.string_3 = str;
            XmlReader reader = Class57.smethod_18(class2.method_4());
            this.method_316(reader, BookmarkStart.b("䄨个䰬䬮吰䄲匴堶嘸伺堼䴾", num));
            string attribute = string.Empty;
            string str3 = string.Empty;
            bool flag = false;
            while (true)
            {
                if (!flag)
                {
                    reader.Read();
                }
                this.method_485(reader);
                attribute = reader.GetAttribute(BookmarkStart.b("䀨伪", num), this.dictionary_18[BookmarkStart.b("帨", num)]);
                str3 = reader.GetAttribute(BookmarkStart.b("崨刪崬䨮", num), this.dictionary_18[BookmarkStart.b("帨", num)]);
                if (!string.IsNullOrEmpty(attribute))
                {
                    if (((attribute == BookmarkStart.b("ᤨ", num)) || (attribute == BookmarkStart.b("ᠨ", num))) && ((str3 != null) && ((str3 != string.Empty) || (str3 != BookmarkStart.b("䜨䐪弬䈮倰弲", num)))))
                    {
                        flag = false;
                    }
                    else if (!string.IsNullOrEmpty(str3))
                    {
                        this.method_171(reader, A_0);
                        flag = true;
                    }
                    else
                    {
                        Footnote footnote = new Footnote(this.document_0);
                        this.method_68(reader, footnote);
                        DictionaryEntry item = new DictionaryEntry(attribute, footnote);
                        if (A_0)
                        {
                            this.list_1.Add(item);
                        }
                        else
                        {
                            footnote.FootnoteType = FootnoteType.Endnote;
                            this.list_2.Add(item);
                        }
                        flag = false;
                    }
                }
                if (reader.EOF)
                {
                    this.method_317();
                    this.string_3 = string.Empty;
                    return;
                }
            }
        }
    }

    private void method_171(XmlReader A_0, bool A_1)
    {
        Stream stream = this.method_484(A_0);
        if (!Class57.smethod_18(stream).IsEmptyElement)
        {
            if (A_1)
            {
                this.document_0.FootnoteNodes2010.Add(stream);
            }
            else
            {
                this.document_0.EndnoteNodes2010.Add(stream);
            }
        }
    }

    private Footnote method_172(XmlReader A_0)
    {
        string attribute = A_0.GetAttribute(BookmarkStart.b("䘮唰", 9), this.dictionary_18[BookmarkStart.b("堮", 9)]);
        string str2 = A_0.GetAttribute(BookmarkStart.b("䰮䐰䀲䄴堶吸瘺尼䴾⩀Ղ⩄⭆╈⑊㩌㱎", 9), this.dictionary_18[BookmarkStart.b("堮", 9)]);
        bool flag = true;
        bool flag2 = A_0.LocalName.StartsWith(BookmarkStart.b("䤮帰尲䄴夶嘸伺堼", 9));
        this.bool_4 = flag2;
        if (attribute == null)
        {
            return null;
        }
        if (!string.IsNullOrEmpty(str2))
        {
            flag = !this.method_110(str2);
        }
        Footnote item = this.method_173(flag2, attribute);
        if (item != null)
        {
            if (item.FootnoteType == FootnoteType.Endnote)
            {
                this.document_0.Endnotes.Add(item);
            }
            else
            {
                this.document_0.Footnotes.Add(item);
            }
        }
        item.IsAutoNumbered = flag;
        if (!flag)
        {
            this.method_174(A_0, item);
        }
        return item;
    }

    private Footnote method_173(bool A_0, string A_1)
    {
        Footnote footnote = null;
        if (!A_0)
        {
            int num3 = 0;
            int num4 = this.method_11().Count;
            while (num3 < num4)
            {
                DictionaryEntry entry = this.method_11()[num3];
                if (entry.Key.ToString() == A_1)
                {
                    DictionaryEntry entry2 = this.method_11()[num3];
                    return (Footnote) entry2.Value;
                }
                num3++;
            }
            return footnote;
        }
        int num = 0;
        int count = this.method_10().Count;
        while (num < count)
        {
            DictionaryEntry entry3 = this.method_10()[num];
            if (entry3.Key.ToString() == A_1)
            {
                DictionaryEntry entry4 = this.method_10()[num];
                return (Footnote) entry4.Value;
            }
            num++;
        }
        return footnote;
    }

    private void method_174(XmlReader A_0, Footnote A_1)
    {
        int num = 4;
        A_1.IsAutoNumbered = false;
        this.method_485(A_0);
        this.method_175(A_0);
        string attribute = A_0.GetAttribute(BookmarkStart.b("䰩䌫䀭䐯", 4), this.dictionary_18[BookmarkStart.b("崩", 4)]);
        string str2 = A_0.GetAttribute(BookmarkStart.b("䤩䐫伭䈯", 4), this.dictionary_18[BookmarkStart.b("崩", 4)]);
        string str3 = A_0.ReadString();
        if ((attribute != null) && (str2 != null))
        {
            A_1.SymbolFontName = attribute;
            byte num2 = byte.Parse(str2.Replace(BookmarkStart.b("氩ᰫ", num), string.Empty), NumberStyles.HexNumber, CultureInfo.InvariantCulture);
            A_1.SymbolCode = num2;
        }
        else if (str3 != null)
        {
            A_1.CustomMarker = str3;
        }
    }

    private void method_175(XmlReader A_0)
    {
        do
        {
            A_0.Read();
        }
        while ((A_0.LocalName == string.Empty) || (A_0.NodeType == XmlNodeType.Whitespace));
    }

    private TextRange method_176()
    {
        TextRange range = new TextRange(this.document_0);
        range.Text = '\x0002'.ToString();
        if (this.characterFormat_0 != null)
        {
            range.ApplyCharacterFormat(this.characterFormat_0);
        }
        return range;
    }

    private ParagraphBase method_177(XmlReader A_0)
    {
        Stream stream = this.method_484(A_0);
        return this.method_178(stream);
    }

    private ParagraphBase method_178(Stream A_0)
    {
        bool flag = this.method_186(A_0, BookmarkStart.b("䬧䔩䈫娭䈯崱堳", 2));
        if (this.method_186(A_0, BookmarkStart.b("朧昩椫愭刯報儳唵䰷", 2)))
        {
            return this.method_180(A_0);
        }
        if (flag)
        {
            A_0.Position = 0L;
            return this.method_257(A_0);
        }
        return null;
    }

    private ParagraphBase method_179(Stream A_0)
    {
        ParagraphBase base2 = this.method_178(A_0);
        if (base2 is DocOleObject)
        {
            DocPicture picture = (DocPicture) (base2 as DocOleObject).Interface49.get_OlePicture().Clone();
            picture.EmbedOleObject = base2 as DocOleObject;
            return picture;
        }
        return base2;
    }

    private Dictionary<string, bool> method_18()
    {
        if (this.dictionary_3 == null)
        {
            this.dictionary_3 = new Dictionary<string, bool>();
        }
        return this.dictionary_3;
    }

    private ParagraphBase method_180(Stream A_0)
    {
        DocOleObject obj2 = new DocOleObject(this.document_0);
        XmlReader reader = Class57.smethod_18(A_0);
        if (reader.IsEmptyElement)
        {
            return null;
        }
        MemoryStream stream = this.method_484(reader);
        stream.Position = 0L;
        return (Class964.smethod_4(new Class466(stream, this.document_0, this)) as ShapeObject).OleFormat;
    }

    private void method_181(XmlReader A_0, DocOleObject A_1)
    {
        int num = 6;
        if ((A_0.LocalName != BookmarkStart.b("弫䘭儯䈱儳", 6)) && (A_0.LocalName != BookmarkStart.b("師䬭匯䘱", num)))
        {
            throw new XmlException(BookmarkStart.b("挫戭甯ሱ崳嬵夷崹夻ḽ␿⍁ぃ❅", num));
        }
        if (!A_0.IsEmptyElement)
        {
            bool flag = this.string_3.StartsWith(BookmarkStart.b("䐫䬭儯嘱儳䐵", num)) || this.string_3.StartsWith(BookmarkStart.b("䨫䄭弯䘱儳䐵", num));
            string attribute = A_0.GetAttribute(BookmarkStart.b("弫娭䤯帱儳", num));
            this.method_247(A_0, BookmarkStart.b("䔫䌭儯唱儳刵夷丹崻", num), BookmarkStart.b("娫", num));
            if (A_0.LocalName == BookmarkStart.b("䔫䌭儯唱儳刵夷丹崻", num))
            {
                string str = A_0.GetAttribute(BookmarkStart.b("䔫䨭", num), this.dictionary_18[BookmarkStart.b("師", num)]);
                DocPicture picture = new DocPicture(this.document_0);
                if (str != null)
                {
                    picture.method_0(A_1);
                    this.method_458(picture, str, flag, false);
                    A_1.SetOlePicture(picture);
                }
                if (attribute != null)
                {
                    this.method_353(picture, attribute);
                    picture.IsShape = true;
                }
            }
        }
    }

    private void method_182(XmlReader A_0, DocOleObject A_1)
    {
        int num = 5;
        if (A_0.LocalName != BookmarkStart.b("搪愬樮縰儲弴制娸伺", 5))
        {
            throw new XmlException(BookmarkStart.b("搪愬樮ᄰ簲圴崶尸堺䤼Ἶ╀≂ㅄ♆", num));
        }
        string attribute = A_0.GetAttribute(BookmarkStart.b("缪听弮吰", num));
        if (attribute != null)
        {
            if (attribute == BookmarkStart.b("未䐬䄮娰", num))
            {
                A_1.method_86(OleLinkType.Link);
            }
            else
            {
                A_1.method_86(OleLinkType.Embed);
            }
        }
        string str3 = A_0.GetAttribute(BookmarkStart.b("笪弬䀮嘰稲焴", num));
        if (str3 != null)
        {
            A_1.Interface49.set_ObjectType(str3);
        }
        string str2 = A_0.GetAttribute(BookmarkStart.b("搪伬䔮吰倲䄴縶紸", num));
        if (str2 != null)
        {
            A_1.Interface49.set_OleStorageName(str2.Replace(BookmarkStart.b("琪", num), string.Empty));
        }
        string str = A_0.GetAttribute(BookmarkStart.b("漪弬丮䘰爲䘴䜶尸堺䤼", num));
        if ((str != null) && (str == BookmarkStart.b("株䈬䄮䔰嘲嬴䌶", num)))
        {
            A_1.Interface49.set_DisplayAsIcon(false);
        }
        string str5 = A_0.GetAttribute(BookmarkStart.b("䈪䤬", num), this.dictionary_18[BookmarkStart.b("太", num)]);
        if (A_1.Interface49.get_LinkType() == OleLinkType.Embed)
        {
            Class229 class3 = this.method_183(str5);
            if (class3 != null)
            {
                byte[] buffer = null;
                class3.method_4().Position = 0L;
                A_1.stream_1 = class3.method_4();
                if (this.method_185(A_1.OleObjectType))
                {
                    buffer = new byte[class3.method_4().Length];
                    class3.method_4().Read(buffer, 0, buffer.Length);
                }
                else
                {
                    Class1004 class2 = null;
                    class2 = new Class1004(class3.method_4());
                    Class1116 class4 = new Class1116();
                    class4.method_4(class2.Interface51.imethod_0());
                    buffer = class4.method_0();
                    if (A_1.OleObjectType == OleObjectType.Package)
                    {
                        A_1.method_105(class4.method_2(), class4.method_3());
                    }
                }
                class3.method_4().Position = 0L;
                A_1.method_75(buffer);
                A_1.method_102(buffer, string.Empty);
            }
        }
        else
        {
            A_1.Interface49.set_LinkPath(this.method_184(str5));
        }
    }

    internal Class229 method_183(string A_0)
    {
        int num = 1;
        bool flag = this.string_3.StartsWith(BookmarkStart.b("伦䰨䨪䤬䨮䌰", 1)) || this.string_3.StartsWith(BookmarkStart.b("䄦䘨䐪夬䨮䌰", num));
        string str = null;
        if (flag)
        {
            DictionaryEntry entry4 = this.method_466(this.string_3)[A_0];
            str = (string) entry4.Value;
        }
        else if (this.string_3.StartsWith(BookmarkStart.b("䐦䘨䘪䀬䨮弰䜲䘴", num)))
        {
            DictionaryEntry entry5 = this.method_466(BookmarkStart.b("䐦䘨䘪䀬䨮弰䜲䘴ᤶ䄸嘺儼ᄾ㍀♂⥄㑆", num))[A_0];
            str = (string) entry5.Value;
        }
        else if (this.string_3.StartsWith(BookmarkStart.b("䈦䜨伪䌬䀮䔰嘲䘴", num)))
        {
            DictionaryEntry entry2 = this.method_466(BookmarkStart.b("䈦䜨伪䌬䀮䔰嘲䘴ᤶ䄸嘺儼ᄾ㍀♂⥄㑆", num))[A_0];
            str = (string) entry2.Value;
        }
        else if (this.string_3.StartsWith(BookmarkStart.b("䄦䘨䐪夬䄮帰䜲倴䐶", num)))
        {
            DictionaryEntry entry = this.method_466(BookmarkStart.b("䄦䘨䐪夬䄮帰䜲倴䐶᜸䌺值匾潀ㅂ⁄⭆㩈", num))[A_0];
            str = (string) entry.Value;
        }
        else
        {
            DictionaryEntry entry3 = this.dictionary_2[A_0];
            str = entry3.Value.ToString();
        }
        if (str == null)
        {
            return null;
        }
        str = str.Replace(BookmarkStart.b("䈦䐨䤪䠬䬮唰娲嬴倶䨸ᐺ", num), null);
        return this.method_465(BookmarkStart.b("倦䘨太䤬.吰帲圴制崸强吼儾♀あ橄", num), str);
    }

    internal string method_184(string A_0)
    {
        int num = 2;
        string input = null;
        DictionaryEntry entry = this.dictionary_2[A_0];
        input = entry.Value.ToString();
        Regex regex = new Regex(BookmarkStart.b("瘧䰩䔫䈭唯࠱ᬳᰵ", 2), RegexOptions.IgnoreCase);
        if (input == null)
        {
            return null;
        }
        if (input.Contains(BookmarkStart.b("丧䌩䀫䬭ਯᴱᬳᤵ", num)))
        {
            return input.Replace(BookmarkStart.b("丧䌩䀫䬭ਯᴱᬳᤵ", num), string.Empty);
        }
        return regex.Replace(input, string.Empty);
    }

    internal bool method_185(OleObjectType A_0)
    {
        bool flag = false;
        if (((((A_0 != OleObjectType.Excel_97_2003_Worksheet) && (A_0 != OleObjectType.ExcelBinaryWorksheet)) && ((A_0 != OleObjectType.ExcelChart) && (A_0 != OleObjectType.ExcelMacroWorksheet))) && (((A_0 != OleObjectType.ExcelWorksheet) && (A_0 != OleObjectType.PowerPoint_97_2003_Presentation)) && ((A_0 != OleObjectType.PowerPoint_97_2003_Slide) && (A_0 != OleObjectType.PowerPointMacroPresentation)))) && ((((A_0 != OleObjectType.PowerPointMacroSlide) && (A_0 != OleObjectType.PowerPointPresentation)) && ((A_0 != OleObjectType.PowerPointSlide) && (A_0 != OleObjectType.VisioDrawing))) && (((A_0 != OleObjectType.Word_97_2003_Document) && (A_0 != OleObjectType.WordDocument)) && ((A_0 != OleObjectType.WordMacroDocument) && (A_0 != OleObjectType.VisioDrawing_2013)))))
        {
            return flag;
        }
        return true;
    }

    private bool method_186(Stream A_0, string A_1)
    {
        A_0.Position = 0L;
        XmlReader reader = Class57.smethod_18(A_0);
        while (reader.Read())
        {
            if (reader.LocalName == A_1)
            {
                A_0.Position = 0L;
                return true;
            }
        }
        A_0.Position = 0L;
        return false;
    }

    private ParagraphBase method_187(XmlReader A_0, ParagraphItemCollection A_1, MemoryStream A_2, Class6 A_3)
    {
        return this.method_188(A_0, A_1, A_2, A_3, null);
    }

    private ParagraphBase method_188(XmlReader A_0, ParagraphItemCollection A_1, MemoryStream A_2, Class6 A_3, CharacterFormat A_4)
    {
        int num = 0x13;
        if (A_0.LocalName != BookmarkStart.b("䤸刺帼䬾", 0x13))
        {
            throw new XmlException(BookmarkStart.b("䤸刺帼䬾㑀ㅂ⁄杆㩈⍊ⱌ㽎㑐獒ご㭖㱘㙚㡜ㅞᕠ", num));
        }
        MemoryStream stream = this.method_484(A_0);
        stream.Position = 0L;
        ShapeBase base2 = this.method_189(stream);
        if (base2 == null)
        {
            return null;
        }
        if (A_3 != null)
        {
            (base2 as ShapeObject).Fill.Stretch = A_3.method_38();
            (base2 as ShapeObject).Fill.Tiled = A_3.method_34();
            (base2 as ShapeObject).Fill.Tile = A_3.method_36();
        }
        if (base2.ShapeType == ShapeType.OleObject)
        {
            return (base2 as ShapeObject).OleFormat;
        }
        if (((base2 is ShapeObject) && (base2.ShapeType == ShapeType.TextBox)) && (base2 as ShapeObject).HasInternalTextbox)
        {
            TextBox internerTextbox = (base2 as ShapeObject).InternerTextbox;
            if (A_2 != null)
            {
                A_2.Position = 0L;
                A_0 = Class57.smethod_18(A_2);
                this.method_210(A_0, internerTextbox);
            }
            return internerTextbox;
        }
        HeaderFooter footer = A_1.method_1();
        if (((footer != null) && (((footer.Type == HeaderFooterType.HeaderOdd) || (footer.Type == HeaderFooterType.HeaderFirstPage)) || (footer.Type == HeaderFooterType.HeaderEven))) && (base2.ShapePr.method_6(0xc0) && base2.Name.StartsWith(BookmarkStart.b("椸吺䨼娾㍀ፂ⥄㉆㩈᱊ⱌ㭎㑐⅒ᡔ㙖⭘ずቜ㵞ୠ٢٤፦", num))))
        {
            if (this.document_0.Watermark.Type == WatermarkType.NoWatermark)
            {
                footer.WriteWatermark = true;
            }
            footer.Watermark = (base2 as ShapeObject).method_61();
            return null;
        }
        if (((base2.ShapeType != ShapeType.Image) && (base2.ShapeType != ShapeType.NonPrimitive)) && (base2.ShapeType != ShapeType.CustomShape))
        {
            return base2;
        }
        if (!(base2 as ShapeObject).HasImage)
        {
            return base2;
        }
        if (((footer != null) && base2.Name.StartsWith(BookmarkStart.b("游吺似嬾ᅀ⩂♄㍆㱈㥊⡌ᡎぐ❒ご╖㑘㩚⽜㑞", num))) && (((footer.Type == HeaderFooterType.HeaderEven) || (footer.Type == HeaderFooterType.HeaderOdd)) || (footer.Type == HeaderFooterType.HeaderFirstPage)))
        {
            if (this.document_0.Watermark.Type == WatermarkType.NoWatermark)
            {
                footer.WriteWatermark = true;
            }
            footer.Watermark = (base2 as ShapeObject).method_62();
            return null;
        }
        DocPicture imageData = (base2 as ShapeObject).ImageData;
        imageData.IsShape = true;
        if (A_4 != null)
        {
            imageData.ApplyCharacterFormat(A_4);
        }
        return imageData;
    }

    private ShapeBase method_189(MemoryStream A_0)
    {
        A_0.Position = 0L;
        return Class964.smethod_4(new Class466(A_0, this.document_0, this));
    }

    private Dictionary<string, BookmarkStart> method_19()
    {
        if (this.dictionary_4 == null)
        {
            this.dictionary_4 = new Dictionary<string, BookmarkStart>();
        }
        return this.dictionary_4;
    }

    private ParagraphBase method_190(MemoryStream A_0)
    {
        int num = 8;
        A_0.Position = 0L;
        XmlReader reader = Class57.smethod_18(A_0);
        if (reader.LocalName != BookmarkStart.b("䤭䈯崱䄳䘵", 8))
        {
            this.method_247(reader, BookmarkStart.b("䤭䈯崱䄳䘵", num), BookmarkStart.b("堭", num));
        }
        if (reader.EOF)
        {
            return null;
        }
        ShapeBase base2 = this.method_189(A_0);
        A_0.Position = 0L;
        Class6 class2 = this.method_258(A_0, true);
        class2.method_33(base2);
        return class2;
    }

    private void method_191(MemoryStream A_0, ParagraphItemCollection A_1)
    {
        int num = 1;
        WatermarkBase base2 = null;
        string str = this.method_198(A_0, BookmarkStart.b("否䄨䨪崬䨮", 1), BookmarkStart.b("並䴨", 1), null);
        if (str.StartsWith(BookmarkStart.b("眦䘨尪䠬崮愰弲䀴䐶游娺䤼娾㍀โ⑄㕆≈ъ⽌╎㑐げ⅔", 1)))
        {
            base2 = this.method_194(A_0);
        }
        else if (str.StartsWith(BookmarkStart.b("瀦䘨太䤬缮堰倲䄴䈶䬸帺樼帾㕀♂㝄⩆⡈㥊♌", num)))
        {
            base2 = this.method_192(A_0);
        }
        if (base2 != null)
        {
            HeaderFooter footer = A_1.method_1();
            if ((footer != null) && !footer.HasWatermark)
            {
                if (this.document_0.Watermark.Type == WatermarkType.NoWatermark)
                {
                    footer.WriteWatermark = true;
                }
                if (((footer.Type == HeaderFooterType.HeaderEven) || (footer.Type == HeaderFooterType.HeaderOdd)) || (footer.Type == HeaderFooterType.HeaderFirstPage))
                {
                    footer.Watermark = base2;
                }
            }
        }
    }

    private WatermarkBase method_192(MemoryStream A_0)
    {
        PictureWatermark watermark = new PictureWatermark(this.document_0);
        string str = this.method_198(A_0, BookmarkStart.b("娲場嘶常帺夼帾㕀≂", 13), BookmarkStart.b("娲儴", 13), this.dictionary_18[BookmarkStart.b("䄲", 13)]);
        DocPicture picture = new DocPicture(this.document_0);
        this.method_458(picture, str, true, false);
        watermark.WordPicture = picture;
        string str2 = this.method_198(A_0, BookmarkStart.b("娲場嘶常帺夼帾㕀≂", 13), BookmarkStart.b("吲吴帶圸", 13), null);
        string str3 = this.method_198(A_0, BookmarkStart.b("娲場嘶常帺夼帾㕀≂", 13), BookmarkStart.b("儲头嘶娸债儼娾㝀♂⥄", 13), null);
        if ((str2 == null) && (str3 == null))
        {
            watermark.IsWashout = false;
        }
        A_0.Position = 0L;
        XmlReader reader = Class57.smethod_18(A_0);
        this.method_193(reader, watermark);
        return watermark;
    }

    private void method_193(XmlReader A_0, PictureWatermark A_1)
    {
        int num = 14;
        if (!A_0.IsEmptyElement)
        {
            string localName = A_0.LocalName;
            A_0.Read();
            this.method_485(A_0);
            while (A_0.LocalName != localName)
            {
                if (A_0.EOF)
                {
                    break;
                }
                if (A_0.NodeType == XmlNodeType.Element)
                {
                    string str;
                    if (((str = A_0.LocalName) != null) && (str == BookmarkStart.b("䜳帵夷䨹夻", num)))
                    {
                        string attribute = A_0.GetAttribute(BookmarkStart.b("䜳䈵䄷嘹夻", num));
                        if (attribute == null)
                        {
                            return;
                        }
                        float maxValue = float.MaxValue;
                        float num6 = float.MaxValue;
                        string[] strArray = attribute.Split(new char[] { ';' });
                        string str4 = null;
                        int index = 0;
                        int length = strArray.Length;
                        while (index < length)
                        {
                            str4 = strArray[index];
                            if (str4.StartsWith(BookmarkStart.b("䌳張尷丹吻н", num)))
                            {
                                str4 = str4.Replace(BookmarkStart.b("䌳張尷丹吻н", num), string.Empty);
                                maxValue = this.method_354(str4);
                            }
                            else if (str4.StartsWith(BookmarkStart.b("尳匵儷崹吻䨽稿", num)))
                            {
                                str4 = str4.Replace(BookmarkStart.b("尳匵儷崹吻䨽稿", num), string.Empty);
                                num6 = this.method_354(str4);
                            }
                            else
                            {
                                string[] strArray2 = str4.Split(new char[] { ':' });
                                this.method_206(A_1.WordPicture, strArray2[0], strArray2[1]);
                            }
                            index++;
                        }
                        if ((maxValue != float.MaxValue) && (num6 != float.MaxValue))
                        {
                            if (A_1.WordPicture.Width != maxValue)
                            {
                                float num5 = (maxValue / A_1.WordPicture.Width) * 100f;
                                A_1.Scaling = num5;
                            }
                            else if (A_1.WordPicture.Height != num6)
                            {
                                float num7 = (num6 / A_1.WordPicture.Height) * 100f;
                                A_1.Scaling = num7;
                            }
                            else
                            {
                                A_1.ScalingAuto = false;
                            }
                        }
                    }
                    A_0.Read();
                }
                else
                {
                    A_0.Read();
                }
            }
        }
    }

    private WatermarkBase method_194(Stream A_0)
    {
        TextWatermark watermark = new TextWatermark(this.document_0);
        if (this.method_198(A_0, BookmarkStart.b("匴帶唸场", 15), BookmarkStart.b("娴䜶堸堺吼䬾㡀", 15), null) == null)
        {
            watermark.Semitransparent = false;
        }
        XmlReader reader = Class57.smethod_18(A_0);
        this.method_195(reader, watermark);
        return watermark;
    }

    private void method_195(XmlReader A_0, TextWatermark A_1)
    {
        int num = 1;
        if (!A_0.IsEmptyElement)
        {
            string localName = A_0.LocalName;
            A_0.Read();
            while (A_0.LocalName != localName)
            {
                if (A_0.NodeType == XmlNodeType.Element)
                {
                    string str = A_0.LocalName;
                    if (str != null)
                    {
                        if (str != BookmarkStart.b("匦䰨匪夬弮倰䜲崴", num))
                        {
                            if (str == BookmarkStart.b("否䄨䨪崬䨮", num))
                            {
                                string attribute = A_0.GetAttribute(BookmarkStart.b("䄦䀨䜪䄬䰮帰弲娴䔶", num));
                                if (attribute == null)
                                {
                                    return;
                                }
                                if (attribute == BookmarkStart.b("䘦尨弪䈬", num))
                                {
                                    A_1.Color = Color.Empty;
                                }
                                else
                                {
                                    A_1.Color = this.method_474(attribute);
                                }
                                this.method_196(A_0, A_1);
                            }
                        }
                        else
                        {
                            if (A_0.GetAttribute(BookmarkStart.b("否崨太䐬䄮嘰", num)) != null)
                            {
                                A_1.Text = A_0.GetAttribute(BookmarkStart.b("否崨太䐬䄮嘰", num));
                            }
                            if (A_0.GetAttribute(BookmarkStart.b("否崨刪䄬䨮", num)) != null)
                            {
                                int shapeHeightInPixels = A_1.ShapeHeightInPixels;
                                int shapeWidthInPixels = A_1.ShapeWidthInPixels;
                                this.method_197(A_0, A_1, shapeHeightInPixels, shapeWidthInPixels);
                            }
                        }
                    }
                    A_0.Read();
                }
                else
                {
                    A_0.Read();
                }
            }
        }
    }

    private void method_196(XmlReader A_0, TextWatermark A_1)
    {
        int num = 14;
        string attribute = A_0.GetAttribute(BookmarkStart.b("䜳䈵䄷嘹夻", 14));
        if (attribute.Length != 0)
        {
            string[] strArray = attribute.Split(new char[] { ';' });
            string str2 = null;
            bool flag = true;
            int index = 0;
            int length = strArray.Length;
            while (index < length)
            {
                str2 = strArray[index];
                if (str2.StartsWith(BookmarkStart.b("䌳張尷丹吻н", num)))
                {
                    str2 = str2.Replace(BookmarkStart.b("䌳張尷丹吻н", num), string.Empty);
                    A_1.ShapeWidthInPixels = (int) (this.method_354(str2) * 20f);
                }
                else if (str2.StartsWith(BookmarkStart.b("尳匵儷崹吻䨽稿", num)))
                {
                    str2 = str2.Replace(BookmarkStart.b("尳匵儷崹吻䨽稿", num), string.Empty);
                    A_1.ShapeHeightInPixels = (int) (this.method_354(str2) * 20f);
                }
                else if (str2.StartsWith(BookmarkStart.b("䘳夵䰷嬹䠻圽⼿ⱁ", num)))
                {
                    flag = false;
                }
                index++;
            }
            if (flag)
            {
                A_1.Layout = WatermarkLayout.Horizontal;
            }
        }
    }

    private void method_197(XmlReader A_0, TextWatermark A_1, int A_2, int A_3)
    {
        int num = 0;
        string attribute = A_0.GetAttribute(BookmarkStart.b("唥尧匩䀫䬭", 0));
        if (attribute.Length != 0)
        {
            string[] strArray = attribute.Split(new char[] { ';' });
            string str3 = strArray[0];
            A_1.FontName = str3.Replace(BookmarkStart.b("Х", num), string.Empty).Replace(BookmarkStart.b("䀥䜧䐩堫̭嘯匱夳張吷䌹ػ", num), string.Empty);
            string str2 = (strArray.Length == 2) ? strArray[1] : string.Empty;
            if (str2 != string.Empty)
            {
                if (str2 == BookmarkStart.b("䀥䜧䐩堫̭䌯嬱丳匵ȷ࠹唻倽", num))
                {
                    A_1.FontSize = 144f;
                }
                else
                {
                    str2 = str2.Replace(BookmarkStart.b("䀥䜧䐩堫̭䌯嬱丳匵ȷ", num), string.Empty);
                    A_1.FontSize = this.method_354(str2);
                }
                A_1.ShapeHeightInPixels = A_2;
                A_1.ShapeWidthInPixels = A_3;
            }
        }
    }

    private string method_198(Stream A_0, string A_1, string A_2, string A_3)
    {
        A_0.Position = 0L;
        XmlReader reader = Class57.smethod_18(A_0);
        while (reader.Read())
        {
            if (reader.LocalName == A_1)
            {
                string attribute = reader.GetAttribute(A_2, A_3);
                if (attribute != null)
                {
                    A_0.Position = 0L;
                    return attribute;
                }
            }
        }
        A_0.Position = 0L;
        return null;
    }

    private DocPicture method_199(MemoryStream A_0)
    {
        XmlReader reader = Class57.smethod_18(A_0);
        DocPicture picture = new DocPicture(this.document_0);
        if (this.characterFormat_0 != null)
        {
            picture.CharacterFormat.ImportContainer(this.characterFormat_0);
        }
        this.characterFormat_0 = null;
        this.method_200(reader, picture);
        return picture;
    }

    internal Dictionary<string, Comment> method_2()
    {
        if (this.dictionary_15 == null)
        {
            this.dictionary_15 = new Dictionary<string, Comment>();
        }
        return this.dictionary_15;
    }

    private Dictionary<string, Dictionary<string, DictionaryEntry>> method_20()
    {
        if (this.dictionary_5 == null)
        {
            this.dictionary_5 = new Dictionary<string, Dictionary<string, DictionaryEntry>>();
        }
        return this.dictionary_5;
    }

    private void method_200(XmlReader A_0, IDocumentObject A_1)
    {
        int num = 0x11;
        if (!A_0.IsEmptyElement)
        {
            string localName = A_0.LocalName;
            A_0.Read();
            while (A_0.LocalName != localName)
            {
                if (A_0.NodeType == XmlNodeType.Element)
                {
                    string str2;
                    if (((str2 = A_0.LocalName) != null) && ((str2 == BookmarkStart.b("䐶儸娺䴼娾", num)) || (str2 == BookmarkStart.b("䔶尸堺䤼", num))))
                    {
                        this.method_205(A_0, A_1);
                        DocPicture picture = A_1 as DocPicture;
                        picture.IsShape = true;
                        this.method_202(A_0, A_1);
                    }
                    A_0.Read();
                }
                else
                {
                    A_0.Read();
                }
            }
        }
    }

    private void method_201(XmlReader A_0)
    {
        int num = 4;
        if (!A_0.IsEmptyElement)
        {
            string localName = A_0.LocalName;
            A_0.Read();
            while (A_0.LocalName != localName)
            {
                if (A_0.NodeType == XmlNodeType.Element)
                {
                    string str2 = A_0.LocalName;
                    if (str2 != null)
                    {
                        bool flag1 = str2 == BookmarkStart.b("䌩䄫伭圯圱倳圵䰷嬹", num);
                    }
                    A_0.Read();
                }
                else
                {
                    A_0.Read();
                }
            }
        }
    }

    private void method_202(XmlReader A_0, IDocumentObject A_1)
    {
        int num = 9;
        if (!A_0.IsEmptyElement)
        {
            string localName = A_0.LocalName;
            A_0.Read();
            DocPicture picture = A_1 as DocPicture;
            while (A_0.LocalName != localName)
            {
                string str;
                string str12;
                if (A_0.NodeType != XmlNodeType.Element)
                {
                    goto Label_04A8;
                }
                string key = A_0.LocalName;
                if (key != null)
                {
                    int num4;
                    if (Class1160.dictionary_66 == null)
                    {
                        Dictionary<string, int> dictionary1 = new Dictionary<string, int>(8);
                        dictionary1.Add(BookmarkStart.b("䘮尰刲刴制崸娺䤼帾", num), 0);
                        dictionary1.Add(BookmarkStart.b("尮䔰䄲娴尶尸", num), 1);
                        dictionary1.Add(BookmarkStart.b("堮䌰刲䔴", num), 2);
                        dictionary1.Add(BookmarkStart.b("䴮帰䄲儴制䬸伺刼伾", num), 3);
                        dictionary1.Add(BookmarkStart.b("䴮帰䄲儴制䬸场堼夾㕀", num), 4);
                        dictionary1.Add(BookmarkStart.b("䴮帰䄲儴制䬸夺刼䬾㕀ⱂ⡄", num), 5);
                        dictionary1.Add(BookmarkStart.b("䴮帰䄲儴制䬸䤺吼堾⥀㝂", num), 6);
                        dictionary1.Add(BookmarkStart.b("䌮帰倲帴", num), 7);
                        Class1160.dictionary_66 = dictionary1;
                    }
                    if (Class1160.dictionary_66.TryGetValue(key, out num4))
                    {
                        switch (num4)
                        {
                            case 0:
                                goto Label_012E;

                            case 1:
                            {
                                string str2 = A_0.GetAttribute(BookmarkStart.b("䌮堰崲倴䐶䴸䈺儼娾", num));
                                if (!picture.Borders.NoBorder)
                                {
                                    picture.Borders.BorderType = this.method_391(str2);
                                }
                                break;
                            }
                            case 2:
                                goto Label_03D6;

                            case 3:
                                this.method_203(A_0, picture.Borders.Top);
                                break;

                            case 4:
                                this.method_203(A_0, picture.Borders.Left);
                                break;

                            case 5:
                                this.method_203(A_0, picture.Borders.Bottom);
                                break;

                            case 6:
                                this.method_203(A_0, picture.Borders.Right);
                                break;

                            case 7:
                            {
                                string str11 = A_0.GetAttribute(BookmarkStart.b("丮䈰䌲倴吶䴸䤺尼䬾⡀ⱂ", num));
                                if (!string.IsNullOrEmpty(str11))
                                {
                                    picture.LockAspectRatio = this.method_110(str11);
                                }
                                break;
                            }
                        }
                    }
                }
                goto Label_049F;
            Label_012E:
                str = A_0.GetAttribute(BookmarkStart.b("䘮唰", num), this.dictionary_18[BookmarkStart.b("崮", num)]);
                if (!string.IsNullOrEmpty(str))
                {
                    bool flag = this.string_3.StartsWith(BookmarkStart.b("䜮吰刲儴制䬸", num)) || this.string_3.StartsWith(BookmarkStart.b("䤮帰尲䄴制䬸", num));
                    float width = picture.Width;
                    float height = picture.Height;
                    this.method_458(picture, str, flag, false);
                    picture.Width = width;
                    picture.Height = height;
                    picture.IsHeaderPicture = flag;
                }
                string attribute = A_0.GetAttribute(BookmarkStart.b("嬮堰䜲头制", num), this.dictionary_18[BookmarkStart.b("䀮", num)]);
                if (attribute != null)
                {
                    picture.Title = attribute;
                }
                string str4 = A_0.GetAttribute(BookmarkStart.b("䰮䌰尲䔴䌶嘸䬺", num));
                if ((str4 != null) && str4.EndsWith(BookmarkStart.b("䤮", num)))
                {
                    picture.CropFromTop = float.Parse(str4.Replace(BookmarkStart.b("䤮", num), ""), NumberStyles.Float, CultureInfo.InvariantCulture) / 65536f;
                }
                string str10 = A_0.GetAttribute(BookmarkStart.b("䰮䌰尲䔴唶嘸伺䤼倾ⱀ", num));
                if ((str10 != null) && str10.EndsWith(BookmarkStart.b("䤮", num)))
                {
                    picture.CropFromBottom = float.Parse(str10.Replace(BookmarkStart.b("䤮", num), ""), NumberStyles.Float, CultureInfo.InvariantCulture) / 65536f;
                }
                string str8 = A_0.GetAttribute(BookmarkStart.b("䰮䌰尲䔴嬶尸崺䤼", num));
                if ((str8 != null) && str8.EndsWith(BookmarkStart.b("䤮", num)))
                {
                    picture.CropFromLeft = float.Parse(str8.Replace(BookmarkStart.b("䤮", num), ""), NumberStyles.Float, CultureInfo.InvariantCulture) / 65536f;
                }
                string str3 = A_0.GetAttribute(BookmarkStart.b("䰮䌰尲䔴䔶倸尺唼䬾", num));
                if ((str3 != null) && str3.EndsWith(BookmarkStart.b("䤮", num)))
                {
                    picture.CropFromRight = float.Parse(str3.Replace(BookmarkStart.b("䤮", num), ""), NumberStyles.Float, CultureInfo.InvariantCulture) / 65536f;
                }
                string str13 = A_0.GetAttribute(BookmarkStart.b("䰮夰䄲娴娶堸债堼䘾", num));
                if (str13 != null)
                {
                    picture.ChromaKey = this.method_474(str13);
                }
                goto Label_049F;
            Label_03D6:
                str12 = A_0.GetAttribute(BookmarkStart.b("嬮䠰䌲倴", num));
                if (str12 != null)
                {
                    picture.TextWrappingStyle = this.method_227(str12);
                }
                string str5 = A_0.GetAttribute(BookmarkStart.b("尮堰圲倴", num));
                if (str5 != null)
                {
                    picture.TextWrappingType = this.method_228(str5);
                }
            Label_049F:
                A_0.Read();
                continue;
            Label_04A8:
                A_0.Read();
            }
        }
    }

    private void method_203(XmlReader A_0, Border A_1)
    {
        int num = 0;
        string attribute = A_0.GetAttribute(BookmarkStart.b("別儧娩䤫", 0));
        if (attribute != null)
        {
            BorderStyle style = this.method_204(attribute);
            A_1.BorderType = style;
        }
        attribute = A_0.GetAttribute(BookmarkStart.b("儥䄧丩堫䘭", num));
        if (attribute != null)
        {
            int num2 = int.Parse(attribute, NumberStyles.Number, CultureInfo.InvariantCulture) / 8;
            A_1.LineWidth = (byte) num2;
        }
        attribute = A_0.GetAttribute(BookmarkStart.b("唥䀧䬩䠫䄭䜯", num));
        if ((attribute != null) && (((attribute == BookmarkStart.b("䤥䘧", num)) || (attribute == BookmarkStart.b("ᜥ", num))) || (attribute == BookmarkStart.b("別娧弩䤫", num))))
        {
            A_1.Shadow = true;
        }
    }

    private BorderStyle method_204(string A_0)
    {
        int num = 0x11;
        BorderStyle none = BorderStyle.None;
        string key = A_0;
        if (key != null)
        {
            int num2;
            if (Class1160.dictionary_67 == null)
            {
                Dictionary<string, int> dictionary1 = new Dictionary<string, int>(0x1a);
                dictionary1.Add(BookmarkStart.b("䐶倸唺娼匾⑀", num), 0);
                dictionary1.Add(BookmarkStart.b("䌶儸刺帼吾", num), 1);
                dictionary1.Add(BookmarkStart.b("匶嘸为弼匾⑀", num), 2);
                dictionary1.Add(BookmarkStart.b("弶堸刺似匾⡀ⵂ⁄", num), 3);
                dictionary1.Add(BookmarkStart.b("匶嘸伺", num), 4);
                dictionary1.Add(BookmarkStart.b("匶堸䠺唼", num), 5);
                dictionary1.Add(BookmarkStart.b("匶嘸伺礼帾㉀⭂", num), 6);
                dictionary1.Add(BookmarkStart.b("匶堸䠺唼笾⹀㝂ń⡆㵈", num), 7);
                dictionary1.Add(BookmarkStart.b("䌶䬸刺䴼匾⑀", num), 8);
                dictionary1.Add(BookmarkStart.b("䌶儸刺匼款⥀⩂♄ⱆᩈ♊ⱌ⍎㵐", num), 9);
                dictionary1.Add(BookmarkStart.b("䌶儸刺帼吾ᕀ⭂ⱄ⥆ᩈ♊ⱌ⍎㵐", num), 10);
                dictionary1.Add(BookmarkStart.b("䌶儸刺帼吾̀♂ㅄうⱈ⹊⍌᭎㥐㩒㭔і㑘㩚ㅜ㍞", num), 11);
                dictionary1.Add(BookmarkStart.b("䌶儸刺匼款⥀⩂♄ⱆ", num), 12);
                dictionary1.Add(BookmarkStart.b("䌶儸刺帼吾ᕀ⭂ⱄ⥆", num), 13);
                dictionary1.Add(BookmarkStart.b("䌶儸刺帼吾̀♂ㅄうⱈ⹊⍌᭎㥐㩒㭔", num), 14);
                dictionary1.Add(BookmarkStart.b("䌶儸刺匼款⥀⩂♄ⱆՈ⩊㽌⡎㑐", num), 15);
                dictionary1.Add(BookmarkStart.b("䌶儸刺帼吾ᕀ⭂ⱄ⥆Ո⩊㽌⡎㑐", num), 0x10);
                dictionary1.Add(BookmarkStart.b("䌶儸刺帼吾̀♂ㅄうⱈ⹊⍌᭎㥐㩒㭔᭖㡘⥚㩜㩞", num), 0x11);
                dictionary1.Add(BookmarkStart.b("䀶堸䴺堼", num), 0x12);
                dictionary1.Add(BookmarkStart.b("匶嘸为弼匾⑀ᑂ⑄ㅆⱈ", num), 0x13);
                dictionary1.Add(BookmarkStart.b("匶堸䠺唼娾╀၂⡄♆╈❊", num), 20);
                dictionary1.Add(BookmarkStart.b("匶堸䠺唼笾⹀㝂ᙄ㍆㭈⑊♌⩎㕐", num), 0x15);
                dictionary1.Add(BookmarkStart.b("䌶儸䤺堼娾Հق⡄╆♈㡊㹌", num), 0x16);
                dictionary1.Add(BookmarkStart.b("䌶儸䤺堼娾Հق⭄⁆㭈⩊㭌⩎", num), 0x17);
                dictionary1.Add(BookmarkStart.b("缶洸瘺焼瀾㑀㝂㙄≆㵈", num), 0x18);
                dictionary1.Add(BookmarkStart.b("缶洸瘺焼瘾⽀あ⁄㍆", num), 0x19);
                Class1160.dictionary_67 = dictionary1;
            }
            if (Class1160.dictionary_67.TryGetValue(key, out num2))
            {
                switch (num2)
                {
                    case 0:
                        return BorderStyle.Single;

                    case 1:
                        return BorderStyle.Thick;

                    case 2:
                        return BorderStyle.Double;

                    case 3:
                        return BorderStyle.Hairline;

                    case 4:
                        return BorderStyle.Dot;

                    case 5:
                        return BorderStyle.DashLargeGap;

                    case 6:
                        return BorderStyle.DotDash;

                    case 7:
                        return BorderStyle.DotDotDash;

                    case 8:
                        return BorderStyle.Triple;

                    case 9:
                        return BorderStyle.ThinThickSmallGap;

                    case 10:
                        return BorderStyle.ThickThinSmallGap;

                    case 11:
                        return BorderStyle.ThinThickThinSmallGap;

                    case 12:
                        return BorderStyle.ThinThickMediumGap;

                    case 13:
                        return BorderStyle.ThickThinMediumGap;

                    case 14:
                        return BorderStyle.ThinThickThinMediumGap;

                    case 15:
                        return BorderStyle.ThinThickLargeGap;

                    case 0x10:
                        return BorderStyle.ThickThinLargeGap;

                    case 0x11:
                        return BorderStyle.ThinThickThinLargeGap;

                    case 0x12:
                        return BorderStyle.Wave;

                    case 0x13:
                        return BorderStyle.DoubleWave;

                    case 20:
                        return BorderStyle.DashSmallGap;

                    case 0x15:
                        return BorderStyle.DashDotStroker;

                    case 0x16:
                        return BorderStyle.Emboss3D;

                    case 0x17:
                        return BorderStyle.Engrave3D;

                    case 0x18:
                        return BorderStyle.Outset;

                    case 0x19:
                        return BorderStyle.Inset;
                }
            }
        }
        return none;
    }

    private void method_205(XmlReader A_0, IDocumentObject A_1)
    {
        int num = 13;
        DocPicture picture = A_1 as DocPicture;
        string attribute = A_0.GetAttribute(BookmarkStart.b("䀲䄴丶唸帺", 13));
        if (attribute != null)
        {
            attribute = attribute.Trim();
            char[] separator = new char[] { ';' };
            string[] strArray = attribute.Split(separator);
            string[] strArray2 = new string[2];
            int index = 0;
            int length = strArray.Length;
            while (index < length)
            {
                strArray2 = this.method_243(strArray[index]);
                if (strArray2 != null)
                {
                    this.method_206(picture, strArray2[0], strArray2[1]);
                }
                index++;
            }
        }
        picture.AlternativeText = A_0.GetAttribute(BookmarkStart.b("刲头䌶", num));
        string str2 = A_0.GetAttribute(BookmarkStart.b("䀲䄴䔶嘸债堼嬾", num));
        if (!string.IsNullOrEmpty(str2) && (str2 == BookmarkStart.b("䜲", num)))
        {
            picture.Borders.BorderType = BorderStyle.Single;
            picture.Borders.LineWidth = 0.5f;
            picture.Borders.Color = Color.Black;
            str2 = A_0.GetAttribute(BookmarkStart.b("䀲䄴䔶嘸债堼尾⹀⽂⩄㕆", num));
            if (!string.IsNullOrEmpty(str2))
            {
                string[] strArray3 = str2.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                if (strArray3.Length > 0)
                {
                    picture.Borders.Color = ColorTranslator.FromHtml(strArray3[0]);
                }
            }
            str2 = A_0.GetAttribute(BookmarkStart.b("䀲䄴䔶嘸债堼䠾⑀⩂≄⽆㵈", num));
            if (!string.IsNullOrEmpty(str2))
            {
                picture.Borders.LineWidth = this.method_238(str2);
            }
        }
        str2 = A_0.GetAttribute(BookmarkStart.b("刲头嬶嘸䰺吼儾≀♂⥄⭆", num), this.dictionary_18[BookmarkStart.b("尲", num)]);
        if (!string.IsNullOrEmpty(str2))
        {
            picture.LayoutInCell = str2 != BookmarkStart.b("唲", num);
        }
        str2 = A_0.GetAttribute(BookmarkStart.b("䐲䜴嘶䤸堺刼倾㍀❂㙄", num));
        if (!string.IsNullOrEmpty(str2))
        {
            picture.WrapPolygon = this.method_245(str2);
        }
        str2 = A_0.GetAttribute(BookmarkStart.b("刲头嬶嘸䰺刼䤾⑀ㅂ⥄♆㥈", num), this.dictionary_18[BookmarkStart.b("尲", num)]);
        if (!string.IsNullOrEmpty(str2))
        {
            picture.AllowOverlap = (str2 != BookmarkStart.b("唲", num)) && (str2 != BookmarkStart.b("̲", num));
        }
    }

    private void method_206(DocPicture A_0, string A_1, string A_2)
    {
        int num = 6;
        string key = A_1;
        if (key != null)
        {
            int num2;
            if (Class1160.dictionary_68 == null)
            {
                Dictionary<string, int> dictionary1 = new Dictionary<string, int>(14);
                dictionary1.Add(BookmarkStart.b("䄫伭䈯唱崳堵ᔷ嘹夻堽㐿", num), 0);
                dictionary1.Add(BookmarkStart.b("䄫伭䈯唱崳堵ᔷ丹医丽", num), 1);
                dictionary1.Add(BookmarkStart.b("嬫䜭启䘱尳", num), 2);
                dictionary1.Add(BookmarkStart.b("䐫䬭夯唱尳䈵", num), 3);
                dictionary1.Add(BookmarkStart.b("嘫̭夯就倳匵䀷", num), 4);
                dictionary1.Add(BookmarkStart.b("䄫崭弯ἱ䐳夵䬷匹䠻圽⼿ⱁ楃⹅❇㡉╋㑍㽏㱑⁓㝕㑗", num), 5);
                dictionary1.Add(BookmarkStart.b("䄫崭弯ἱ䐳夵䬷匹䠻圽⼿ⱁ楃ぅⵇ㡉㡋❍㍏㍑㡓", num), 6);
                dictionary1.Add(BookmarkStart.b("䄫崭弯ἱ䐳夵䬷匹䠻圽⼿ⱁ楃ぅⵇ㡉㡋❍㍏㍑㡓筕⩗㽙せ㽝ᑟୡባͥ", num), 7);
                dictionary1.Add(BookmarkStart.b("䄫崭弯ἱ䐳夵䬷匹䠻圽⼿ⱁ楃⹅❇㡉╋㑍㽏㱑⁓㝕㑗睙⹛㭝౟͡ၣཥṧཀྵ", num), 8);
                dictionary1.Add(BookmarkStart.b("䄫崭弯ἱ䌳䐵夷䨹ᄻ娽⤿ㅁぃ❅♇⥉⥋捍㱏㝑㉓≕", num), 9);
                dictionary1.Add(BookmarkStart.b("䄫崭弯ἱ䌳䐵夷䨹ᄻ娽⤿ㅁぃ❅♇⥉⥋捍≏㭑㍓㹕ⱗ", num), 10);
                dictionary1.Add(BookmarkStart.b("䄫崭弯ἱ䌳䐵夷䨹ᄻ娽⤿ㅁぃ❅♇⥉⥋捍⑏㵑⑓", num), 11);
                dictionary1.Add(BookmarkStart.b("䄫崭弯ἱ䌳䐵夷䨹ᄻ娽⤿ㅁぃ❅♇⥉⥋捍㉏㵑⁓≕㝗㝙", num), 12);
                dictionary1.Add(BookmarkStart.b("尫䄭䌯嬱䀳張圷吹", num), 13);
                Class1160.dictionary_68 = dictionary1;
            }
            if (Class1160.dictionary_68.TryGetValue(key, out num2))
            {
                switch (num2)
                {
                    case 0:
                        A_0.HorizontalPosition = this.method_467(A_2);
                        return;

                    case 1:
                        A_0.VerticalPosition = this.method_467(A_2);
                        return;

                    case 2:
                        A_0.Width = this.method_467(A_2);
                        return;

                    case 3:
                        A_0.Height = this.method_467(A_2);
                        return;

                    case 4:
                    {
                        long num3 = long.Parse(A_2, NumberStyles.Integer, CultureInfo.InvariantCulture);
                        A_0.OrderIndex = num3;
                        A_0.IsUnderText = num3 <= 0L;
                        if (!A_0.IsUnderText)
                        {
                            A_0.TextWrappingStyle = TextWrappingStyle.InFrontOfText;
                            return;
                        }
                        A_0.TextWrappingStyle = TextWrappingStyle.Behind;
                        return;
                    }
                    case 5:
                        A_0.HorizontalAlignment = this.method_279(A_2);
                        return;

                    case 6:
                        A_0.VerticalAlignment = this.method_283(A_2);
                        return;

                    case 7:
                        A_0.VerticalOrigin = this.method_284(A_2);
                        return;

                    case 8:
                        A_0.HorizontalOrigin = this.method_280(A_2);
                        return;

                    case 9:
                        A_0.WrapDistanceLeft = this.method_467(A_2);
                        return;

                    case 10:
                        A_0.WrapDistanceRight = this.method_467(A_2);
                        return;

                    case 11:
                        A_0.WrapDistanceTop = this.method_467(A_2);
                        return;

                    case 12:
                        A_0.WrapDistanceBottom = this.method_467(A_2);
                        return;

                    case 13:
                        if (!string.IsNullOrEmpty(A_2) && (A_2 == BookmarkStart.b("䴫䰭䌯崱堳䌵䰷弹", num)))
                        {
                            A_0.HorizontalOrigin = HorizontalOrigin.Column;
                            A_0.VerticalOrigin = VerticalOrigin.Paragraph;
                        }
                        break;

                    default:
                        return;
                }
            }
        }
    }

    private void method_207(XmlReader A_0, IDocumentObject A_1)
    {
        int num = 10;
        Class1 class2 = A_1 as Class1;
        string attribute = A_0.GetAttribute(BookmarkStart.b("䌯䘱䴳娵崷", 10));
        if (attribute != null)
        {
            attribute = attribute.Trim();
            char[] separator = new char[] { ';' };
            string[] strArray = attribute.Split(separator);
            string[] strArray2 = new string[2];
            int index = 0;
            int length = strArray.Length;
            while (index < length)
            {
                strArray2 = this.method_243(strArray[index]);
                if (strArray2 != null)
                {
                    this.method_208(class2, strArray2[0], strArray2[1]);
                }
                index++;
            }
        }
        class2.AlternativeText = A_0.GetAttribute(BookmarkStart.b("儯帱䀳", num));
        string str4 = A_0.GetAttribute(BookmarkStart.b("䌯䘱䘳夵匷弹堻", num));
        if ((str4 != null) && (str4 == BookmarkStart.b("䐯", num)))
        {
            Borders borders = class2.Borders;
            borders.BorderType = BorderStyle.Single;
            borders.LineWidth = 0.5f;
            borders.Color = Color.Black;
            string str2 = A_0.GetAttribute(BookmarkStart.b("䌯䘱䘳夵匷弹弻儽ⰿⵁ㙃", num));
            if (str2 != null)
            {
                string[] strArray3 = str2.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                if (strArray3.Length > 0)
                {
                    borders.Color = ColorTranslator.FromHtml(strArray3[0]);
                }
            }
            string str3 = A_0.GetAttribute(BookmarkStart.b("䌯䘱䘳夵匷弹䬻嬽⤿╁ⱃ㉅", num));
            if (str3 != null)
            {
                borders.LineWidth = this.method_238(str3);
            }
        }
    }

    private void method_208(Class1 A_0, string A_1, string A_2)
    {
        int num = 0x11;
        string key = A_1;
        if (key != null)
        {
            int num3;
            if (Class1160.dictionary_69 == null)
            {
                Dictionary<string, int> dictionary1 = new Dictionary<string, int>(6);
                dictionary1.Add(BookmarkStart.b("䀶倸强䤼圾", num), 0);
                dictionary1.Add(BookmarkStart.b("弶尸刺娼圾㕀", num), 1);
                dictionary1.Add(BookmarkStart.b("䌶嘸䬺", num), 2);
                dictionary1.Add(BookmarkStart.b("嬶尸崺䤼", num), 3);
                dictionary1.Add(BookmarkStart.b("䴶ᐸ刺匼嬾⑀㭂", num), 4);
                dictionary1.Add(BookmarkStart.b("䜶嘸䠺吼䬾⡀ⱂ⭄", num), 5);
                Class1160.dictionary_69 = dictionary1;
            }
            if (Class1160.dictionary_69.TryGetValue(key, out num3))
            {
                switch (num3)
                {
                    case 0:
                        A_0.method_122(this.method_467(A_2) / 127f);
                        return;

                    case 1:
                        A_0.method_124(this.method_467(A_2) / 127f);
                        return;

                    case 2:
                        A_0.method_116(this.method_467(A_2) / 127f);
                        return;

                    case 3:
                        A_0.method_112(this.method_467(A_2) / 127f);
                        return;

                    case 4:
                    {
                        int num2 = int.Parse(A_2, NumberStyles.Integer, CultureInfo.InvariantCulture);
                        A_0.OrderIndex = num2;
                        A_0.IsUnderText = num2 <= 0;
                        if (!A_0.IsUnderText)
                        {
                            A_0.TextWrappingStyle = TextWrappingStyle.InFrontOfText;
                            return;
                        }
                        A_0.TextWrappingStyle = TextWrappingStyle.Behind;
                        return;
                    }
                    case 5:
                        if (!string.IsNullOrEmpty(A_2))
                        {
                            bool flag1 = A_2 == BookmarkStart.b("嘶嬸䠺刼匾㑀㝂⁄", num);
                        }
                        break;

                    default:
                        return;
                }
            }
        }
    }

    private TextBox method_209(MemoryStream A_0, MemoryStream A_1)
    {
        A_0.Position = 0L;
        XmlReader reader = Class57.smethod_18(A_0);
        TextBox box = new TextBox(this.document_0);
        if (A_1 != null)
        {
            A_1.Position = 0L;
            XmlReader reader2 = Class57.smethod_18(A_1);
            this.method_210(reader2, box);
        }
        this.method_215(reader, box);
        ShapeBase base2 = this.method_189(A_0);
        box.ShapeInfo = base2 as ShapeObject;
        return box;
    }

    private Dictionary<string, string> method_21()
    {
        if (this.dictionary_1 == null)
        {
            this.dictionary_1 = new Dictionary<string, string>();
        }
        return this.dictionary_1;
    }

    private void method_210(XmlReader A_0, TextBox A_1)
    {
        int num = 10;
        while (A_0.NodeType != XmlNodeType.Element)
        {
            A_0.Read();
        }
        if (A_0.LocalName != BookmarkStart.b("启䀱唳䄵儷吹嬻", num))
        {
            throw new XmlException(BookmarkStart.b("支就儳丵䠷弹弻䨽┿♁摃㹅╇♉汋㩍ㅏ㕑瑓", num) + A_0.LocalName);
        }
        if (!A_0.IsEmptyElement)
        {
            string localName = A_0.LocalName;
            A_0.Read();
            this.method_485(A_0);
            while (true)
            {
                if (!(A_0.LocalName != localName) || A_0.EOF)
                {
                    return;
                }
                bool flag = false;
                if (A_0.NodeType != XmlNodeType.Element)
                {
                    A_0.Read();
                }
                else
                {
                    string key = A_0.LocalName;
                    if (key != null)
                    {
                        int num2;
                        if (Class1160.dictionary_70 == null)
                        {
                            Dictionary<string, int> dictionary1 = new Dictionary<string, int>(0x10);
                            dictionary1.Add(BookmarkStart.b("䜯䀱唳䘵欷䬹䤻弽㈿❁", num), 0);
                            dictionary1.Add(BookmarkStart.b("䜯䀱唳䘵氷匹嬻嘽㐿", num), 1);
                            dictionary1.Add(BookmarkStart.b("䜯䀱唳䘵氷刹主儽㔿╁ⱃ", num), 2);
                            dictionary1.Add(BookmarkStart.b("䜯䀱唳䘵氷唹䰻缽⸿♁ك⥅㱇㹉⍋⍍", num), 3);
                            dictionary1.Add(BookmarkStart.b("䜯䀱唳䘵瘷唹刻嬽", num), 4);
                            dictionary1.Add(BookmarkStart.b("夯就堳張嘷弹", num), 5);
                            dictionary1.Add(BookmarkStart.b("儯就圳帵圷䠹", num), 6);
                            dictionary1.Add(BookmarkStart.b("䌯嬱夳䘵吷弹氻儽㌿", num), 7);
                            dictionary1.Add(BookmarkStart.b("䀯崱䜳張䰷匹医倽࠿", num), 8);
                            dictionary1.Add(BookmarkStart.b("䀯崱䜳張䰷匹医倽ᘿ", num), 9);
                            dictionary1.Add(BookmarkStart.b("唯䨱䀳匵嘷丹", num), 10);
                            dictionary1.Add(BookmarkStart.b("唯吱刳匵嬷丹礻䘽㐿❁⩃㉅", num), 11);
                            dictionary1.Add(BookmarkStart.b("启崱圳昵䨷", num), 12);
                            dictionary1.Add(BookmarkStart.b("匯簱䈳焵䨷嬹䰻嘽⤿⅁Ƀ㑅⥇❉⥋ṍ≏", num), 13);
                            dictionary1.Add(BookmarkStart.b("圯䀱唳䘵倷匹弻", num), 14);
                            dictionary1.Add(BookmarkStart.b("刯崱倳伵䠷䠹", num), 15);
                            Class1160.dictionary_70 = dictionary1;
                        }
                        if (Class1160.dictionary_70.TryGetValue(key, out num2))
                        {
                            switch (num2)
                            {
                                case 0:
                                    A_1.Format.TextWrappingStyle = TextWrappingStyle.Square;
                                    A_1.Format.TextWrappingType = this.method_274(A_0);
                                    break;

                                case 1:
                                {
                                    A_1.Format.TextWrappingStyle = TextWrappingStyle.Tight;
                                    A_1.Format.TextWrappingType = this.method_274(A_0);
                                    using (MemoryStream stream = this.method_484(A_0))
                                    {
                                        bool flag2 = true;
                                        A_1.Format.WrapPolygon = this.method_275(stream, ref flag2);
                                        A_1.Format.IsEditWrapPolygonPoint = flag2;
                                        break;
                                    }
                                }
                                case 2:
                                {
                                    A_1.Format.TextWrappingStyle = TextWrappingStyle.Through;
                                    A_1.Format.TextWrappingType = this.method_274(A_0);
                                    using (MemoryStream stream2 = this.method_484(A_0))
                                    {
                                        bool flag3 = true;
                                        A_1.Format.WrapPolygon = this.method_275(stream2, ref flag3);
                                        A_1.Format.IsEditWrapPolygonPoint = flag3;
                                        break;
                                    }
                                }
                                case 3:
                                    A_1.Format.TextWrappingStyle = TextWrappingStyle.TopAndBottom;
                                    A_1.Format.TextWrappingType = this.method_274(A_0);
                                    break;

                                case 4:
                                    if (!A_1.Format.IsBelowText)
                                    {
                                        A_1.Format.TextWrappingStyle = TextWrappingStyle.InFrontOfText;
                                        break;
                                    }
                                    A_1.Format.TextWrappingStyle = TextWrappingStyle.Behind;
                                    break;

                                case 5:
                                    A_1.Format.TextWrappingStyle = TextWrappingStyle.Inline;
                                    break;

                                case 6:
                                    if (A_0.AttributeCount != 0)
                                    {
                                        A_1.Format.OrderIndex = int.Parse(A_0.GetAttribute(BookmarkStart.b("䈯圱堳圵䰷匹䨻嬽࠿❁ⵃⅅ⁇㹉", num)));
                                        string attribute = A_0.GetAttribute(BookmarkStart.b("刯圱尳張嘷帹砻儽⌿", num));
                                        if (!string.IsNullOrEmpty(attribute))
                                        {
                                            A_1.Format.IsBelowText = (attribute == BookmarkStart.b("į", num)) || (attribute == BookmarkStart.b("䐯䀱䄳匵", num));
                                        }
                                        attribute = A_0.GetAttribute(BookmarkStart.b("尯匱䴳夵䴷丹画倽̿❁⡃⩅", num));
                                        if (!string.IsNullOrEmpty(attribute))
                                        {
                                            A_1.Format.IsAllowInCell = (attribute == BookmarkStart.b("į", num)) || (attribute == BookmarkStart.b("䐯䀱䄳匵", num));
                                        }
                                        attribute = A_0.GetAttribute(BookmarkStart.b("儯帱堳夵伷甹䨻嬽㈿⹁╃㙅", num));
                                        if (!string.IsNullOrEmpty(attribute))
                                        {
                                            A_1.Format.AllowOverlap = (attribute == BookmarkStart.b("į", num)) || (attribute == BookmarkStart.b("䐯䀱䄳匵", num));
                                        }
                                    }
                                    break;

                                case 14:
                                    using (MemoryStream stream3 = this.method_484(A_0))
                                    {
                                        this.method_214(stream3, A_1);
                                    }
                                    flag = true;
                                    break;

                                case 15:
                                    this.method_211(A_0, A_1, false);
                                    break;
                            }
                        }
                    }
                    if (!flag)
                    {
                        A_0.Read();
                    }
                }
                this.method_485(A_0);
            }
        }
    }

    private void method_211(XmlReader A_0, TextBox A_1, bool A_2)
    {
        int num = 0x10;
        if (A_0.AttributeCount == 0)
        {
            return;
        }
        string localName = A_0.LocalName;
        string attribute = A_0.GetAttribute(BookmarkStart.b("䀵崷䠹䠻", num));
        if (string.IsNullOrEmpty(attribute))
        {
            goto Label_00C0;
        }
        string str5 = attribute;
        if (str5 != null)
        {
            if (str5 != BookmarkStart.b("䀵崷䠹䠻", num))
            {
                if (!(str5 == BookmarkStart.b("䀵崷䠹䠻ఽ眿牁", num)))
                {
                    if (!(str5 == BookmarkStart.b("匵夷氹夻䰽㐿", num)))
                    {
                        goto Label_00A3;
                    }
                    A_1.Format.LayoutFlowAlt = TextDirection.RightToLeftRotated;
                }
                else
                {
                    A_1.Format.LayoutFlowAlt = TextDirection.LeftToRight;
                }
            }
            else
            {
                A_1.Format.LayoutFlowAlt = TextDirection.RightToLeft;
            }
            goto Label_00C0;
        }
    Label_00A3:
        if (A_2)
        {
            A_1.Format.LayoutFlowAlt = TextDirection.TopToBottomRotated;
        }
        else
        {
            A_1.Format.LayoutFlowAlt = TextDirection.TopToBottom;
        }
    Label_00C0:
        attribute = A_0.GetAttribute(BookmarkStart.b("䄵䨷嬹䰻", num));
        A_1.Format.TextBoxWrapMode = this.method_241(attribute);
        attribute = A_0.GetAttribute(BookmarkStart.b("娵焷吹伻", num));
        if (!string.IsNullOrEmpty(attribute))
        {
            A_1.Format.InternalMargin.Left = float.Parse(attribute, NumberStyles.Float, CultureInfo.InvariantCulture) / 12700f;
        }
        attribute = A_0.GetAttribute(BookmarkStart.b("䈵焷吹伻", num));
        if (!string.IsNullOrEmpty(attribute))
        {
            A_1.Format.InternalMargin.Top = float.Parse(attribute, NumberStyles.Float, CultureInfo.InvariantCulture) / 12700f;
        }
        attribute = A_0.GetAttribute(BookmarkStart.b("䐵焷吹伻", num));
        if (!string.IsNullOrEmpty(attribute))
        {
            A_1.Format.InternalMargin.Right = float.Parse(attribute, NumberStyles.Float, CultureInfo.InvariantCulture) / 12700f;
        }
        attribute = A_0.GetAttribute(BookmarkStart.b("吵焷吹伻", num));
        if (!string.IsNullOrEmpty(attribute))
        {
            A_1.Format.InternalMargin.Bottom = float.Parse(attribute, NumberStyles.Float, CultureInfo.InvariantCulture) / 12700f;
        }
        string str3 = A_0.GetAttribute(BookmarkStart.b("圵嘷夹吻儽㈿", num));
        if (str3 != null)
        {
            if (!(str3 == BookmarkStart.b("吵", num)))
            {
                if (!(str3 == BookmarkStart.b("唵䰷䠹", num)))
                {
                    goto Label_0250;
                }
                A_1.Format.TextAnchor = ShapeVerticalAlignment.Center;
            }
            else
            {
                A_1.Format.TextAnchor = ShapeVerticalAlignment.Bottom;
            }
            goto Label_025C;
        }
    Label_0250:
        A_1.Format.TextAnchor = ShapeVerticalAlignment.Top;
    Label_025C:
        attribute = A_0.GetAttribute(BookmarkStart.b("䌵䠷䠹唻夽⠿㙁", num));
        if (!string.IsNullOrEmpty(attribute))
        {
            A_1.Format.TextUpRight = !this.method_110(attribute);
        }
        while (A_0.NodeType != XmlNodeType.Element)
        {
            A_0.Read();
        }
        if (!A_0.IsEmptyElement)
        {
            A_0.Read();
            this.method_485(A_0);
            while (A_0.LocalName != localName)
            {
                if (A_0.EOF)
                {
                    break;
                }
                bool flag = false;
                if (A_0.NodeType == XmlNodeType.Element)
                {
                    string str = A_0.LocalName;
                    if (str != null)
                    {
                        if (str != BookmarkStart.b("䔵䠷笹䤻䨽⼿сⵃ㉅", num))
                        {
                            if (str != BookmarkStart.b("堵圷笹䤻䨽⼿⑁ⵃ㉅", num))
                            {
                                if (str == BookmarkStart.b("䔵嬷弹刻嬽猿♁", num))
                                {
                                    using (XmlReader reader = this.method_335(A_0))
                                    {
                                        if (this.method_247(reader, BookmarkStart.b("䐵圷丹", num), BookmarkStart.b("圵", num)))
                                        {
                                            string s = reader.GetAttribute(BookmarkStart.b("䐵崷䰹", num));
                                            if (s != null)
                                            {
                                                A_1.Format.Rotation = -(float.Parse(s, NumberStyles.Float, CultureInfo.InvariantCulture) / 60000f);
                                            }
                                        }
                                    }
                                    flag = true;
                                }
                            }
                            else
                            {
                                A_1.Format.IsFitShapeToText = false;
                            }
                        }
                        else
                        {
                            A_1.Format.IsFitShapeToText = true;
                        }
                    }
                    if (!flag)
                    {
                        A_0.Read();
                    }
                }
                else
                {
                    A_0.Read();
                }
                this.method_485(A_0);
            }
        }
    }

    private void method_212(MemoryStream A_0, TextBox A_1)
    {
        int num = 3;
        A_0.Position = 0L;
        XmlReader reader = Class57.smethod_18(A_0);
        while (reader.NodeType != XmlNodeType.Element)
        {
            reader.Read();
        }
        if (reader.LocalName != BookmarkStart.b("娨䐪䄬䘮唰甲尴嬶唸", num))
        {
            throw new XmlException(BookmarkStart.b("簨䔪䠬圮䄰嘲嘴䌶尸强ᴼ䜾ⱀ⽂敄㍆⡈ⱊ浌", num) + reader.LocalName);
        }
        if (!reader.IsEmptyElement)
        {
            int attributeCount = reader.AttributeCount;
            string localName = reader.LocalName;
            reader.Read();
            this.method_485(reader);
            Color empty = Color.Empty;
            while (reader.LocalName != localName)
            {
                if (reader.EOF)
                {
                    break;
                }
                bool flag = false;
                if (reader.NodeType == XmlNodeType.Element)
                {
                    string str4 = reader.LocalName;
                    if (str4 != null)
                    {
                        if (!(str4 == BookmarkStart.b("娨䠪䔬䨮尰嘲瘴嬶䬸", num)))
                        {
                            if (str4 == BookmarkStart.b("娨太䨬䴮爰弲䜴", num))
                            {
                                string attribute = reader.GetAttribute(BookmarkStart.b("弨䨪䄬", num));
                                if (!string.IsNullOrEmpty(attribute))
                                {
                                    empty = this.method_474(attribute);
                                }
                            }
                        }
                        else
                        {
                            string str = reader.GetAttribute(BookmarkStart.b("弨䨪䄬", num));
                            if (!string.IsNullOrEmpty(str) && this.document_0.ColorScheme.ContainsKey(str))
                            {
                                string str2 = this.document_0.ColorScheme[str];
                                empty = this.method_474(str2);
                            }
                        }
                    }
                    if (!flag)
                    {
                        reader.Read();
                    }
                }
                else
                {
                    reader.Read();
                }
                this.method_485(reader);
            }
            if (!empty.IsEmpty)
            {
                A_1.Format.FillEfects.Color = empty;
                A_1.Format.FillEfects.Type = BackgroundType.Color;
            }
        }
    }

    private void method_213(MemoryStream A_0, TextBox A_1)
    {
        int num = 6;
        A_0.Position = 0L;
        XmlReader reader = Class57.smethod_18(A_0);
        while (reader.NodeType != XmlNodeType.Element)
        {
            reader.Read();
        }
        if (reader.LocalName != BookmarkStart.b("弫席怯䀱", num))
        {
            throw new XmlException(BookmarkStart.b("礫䀭唯䨱䐳匵嬷丹夻娽怿㩁⥃⩅桇㹉ⵋ⥍灏", num) + reader.LocalName);
        }
        if (!reader.IsEmptyElement)
        {
            if (reader.AttributeCount > 0)
            {
                reader.GetAttribute(BookmarkStart.b("丫夭累崱倳匵", num));
            }
            string localName = reader.LocalName;
            reader.Read();
            this.method_485(reader);
            while (reader.LocalName != localName)
            {
                if (reader.EOF)
                {
                    break;
                }
                bool flag = false;
                if (reader.NodeType == XmlNodeType.Element)
                {
                    string str2 = reader.LocalName;
                    if (str2 != null)
                    {
                        if (str2 != BookmarkStart.b("含䠭䈯弱", num))
                        {
                            if (str2 != BookmarkStart.b("尫尭䌯䘱猳匵圷圹", num))
                            {
                                if (str2 != BookmarkStart.b("弫䄭尯嬱倳瀵儷嘹倻", num))
                                {
                                    if (str2 != BookmarkStart.b("䀫䀭", num))
                                    {
                                        if (str2 == BookmarkStart.b("䤫嘭䐯縱䜳䈵", num))
                                        {
                                            using (this.method_484(reader))
                                            {
                                            }
                                            flag = true;
                                        }
                                    }
                                    else
                                    {
                                        using (this.method_484(reader))
                                        {
                                        }
                                        flag = true;
                                    }
                                }
                                else
                                {
                                    using (MemoryStream stream3 = this.method_484(reader))
                                    {
                                        this.method_212(stream3, A_1);
                                    }
                                    flag = true;
                                }
                            }
                            else
                            {
                                using (this.method_484(reader))
                                {
                                }
                                flag = true;
                            }
                        }
                        else
                        {
                            using (this.method_484(reader))
                            {
                            }
                            flag = true;
                        }
                    }
                    if (!flag)
                    {
                        reader.Read();
                    }
                }
                else
                {
                    reader.Read();
                }
                this.method_485(reader);
            }
        }
    }

    private void method_214(MemoryStream A_0, TextBox A_1)
    {
        int num = 6;
        A_0.Position = 0L;
        XmlReader reader = Class57.smethod_18(A_0);
        while (reader.NodeType != XmlNodeType.Element)
        {
            reader.Read();
        }
        if (reader.LocalName != BookmarkStart.b("䬫尭儯䈱尳張嬷", num))
        {
            throw new XmlException(BookmarkStart.b("礫䀭唯䨱䐳匵嬷丹夻娽怿㩁⥃⩅桇㹉ⵋ⥍灏", num) + reader.LocalName);
        }
        if (!reader.IsEmptyElement)
        {
            string localName = reader.LocalName;
            bool flag = false;
            reader.Read();
            this.method_485(reader);
            while (reader.LocalName != localName)
            {
                if (reader.EOF)
                {
                    break;
                }
                bool flag2 = false;
                if (reader.NodeType == XmlNodeType.Element)
                {
                    string str3;
                    if (((str3 = reader.LocalName) != null) && (str3 != BookmarkStart.b("伫怭䘯愱䐳昵䨷", num)))
                    {
                        if (str3 != BookmarkStart.b("弫席怯䀱", num))
                        {
                            if (str3 != BookmarkStart.b("堫嘭刯䨱", num))
                            {
                                if (str3 != BookmarkStart.b("丫䄭启䬱搳䐵", num))
                                {
                                    if (str3 == BookmarkStart.b("嬫崭䀯", num))
                                    {
                                        string attribute = reader.GetAttribute(BookmarkStart.b("䈫䄭䈯弱唳娵紷嬹伻䨽Ŀㅁⵃ❅♇౉⁋⅍❏", num));
                                        if (((attribute == BookmarkStart.b("ᴫ", num)) || (attribute == BookmarkStart.b("堫尭䔯圱", num))) || (attribute == BookmarkStart.b("䌫䀭", num)))
                                        {
                                            flag = true;
                                        }
                                    }
                                }
                                else
                                {
                                    this.method_211(reader, A_1, flag);
                                }
                            }
                        }
                        else
                        {
                            using (MemoryStream stream = this.method_484(reader))
                            {
                                this.method_213(stream, A_1);
                            }
                            flag2 = true;
                        }
                    }
                    if (!flag2)
                    {
                        reader.Read();
                    }
                }
                else
                {
                    reader.Read();
                }
                this.method_485(reader);
            }
        }
    }

    private void method_215(XmlReader A_0, IDocumentObject A_1)
    {
        int num = 8;
        if (!A_0.IsEmptyElement)
        {
            string localName = A_0.LocalName;
            A_0.Read();
            this.method_485(A_0);
            while (A_0.LocalName != localName)
            {
                if (A_0.EOF)
                {
                    break;
                }
                if (A_0.NodeType == XmlNodeType.Element)
                {
                    string str2;
                    if (((str2 = A_0.LocalName) != null) && ((str2 == BookmarkStart.b("崭堯匱䐳匵", num)) || (str2 == BookmarkStart.b("尭唯儱䀳", num))))
                    {
                        this.method_236(A_0, A_1);
                        this.method_217(A_0, A_1);
                        this.method_216(A_0, A_1);
                    }
                    A_0.Read();
                }
                else
                {
                    A_0.Read();
                }
            }
        }
    }

    private void method_216(XmlReader A_0, IDocumentObject A_1)
    {
        int num = 15;
        if (!A_0.IsEmptyElement)
        {
            string localName = A_0.LocalName;
            A_0.Read();
            this.method_485(A_0);
            bool flag = false;
            while (A_0.LocalName != localName)
            {
                if (A_0.EOF)
                {
                    break;
                }
                flag = false;
                if (A_0.NodeType == XmlNodeType.Element)
                {
                    string str;
                    if (((str = A_0.LocalName) != null) && (str == BookmarkStart.b("䈴䔶堸䬺", num)))
                    {
                        string attribute = A_0.GetAttribute(BookmarkStart.b("䄴丶䤸帺", num));
                        if (!string.IsNullOrEmpty(attribute))
                        {
                            (A_1 as TextBox).Format.TextWrappingStyle = this.method_227(attribute);
                        }
                    }
                    if (!flag)
                    {
                        A_0.Read();
                    }
                }
                else
                {
                    A_0.Read();
                }
            }
        }
    }

    private void method_217(XmlReader A_0, IDocumentObject A_1)
    {
        int num = 7;
        if (!A_0.IsEmptyElement)
        {
            string localName = A_0.LocalName;
            A_0.Read();
            this.method_485(A_0);
            bool flag = false;
            while (A_0.LocalName != localName)
            {
                if (A_0.EOF)
                {
                    break;
                }
                flag = false;
                if (A_0.NodeType != XmlNodeType.Element)
                {
                    goto Label_013E;
                }
                string str2 = A_0.LocalName;
                if (str2 != null)
                {
                    if (str2 != BookmarkStart.b("帬嬮䌰尲帴制", num))
                    {
                        if (str2 != BookmarkStart.b("夬䨮䤰䜲圴堶䄸", num))
                        {
                            if (str2 != BookmarkStart.b("娬崮倰䌲", num))
                            {
                                if (!(str2 == BookmarkStart.b("䬬䘮崰弲", num)))
                                {
                                    goto Label_0132;
                                }
                                using (MemoryStream stream = this.method_484(A_0))
                                {
                                    this.method_219(stream, A_1 as TextBox);
                                    flag = true;
                                    goto Label_0132;
                                }
                            }
                            string attribute = A_0.GetAttribute(BookmarkStart.b("夬嘮䄰嘲", num));
                            if (attribute != null)
                            {
                                (A_1 as TextBox).Format.TextWrappingStyle = this.method_227(attribute);
                            }
                        }
                        else
                        {
                            this.method_231(A_0, A_1 as TextBox);
                            this.method_230(A_0, A_1 as TextBox);
                            this.characterFormat_0 = null;
                            this.method_229(A_0, A_1);
                        }
                    }
                    else
                    {
                        this.method_233(A_0, A_1 as TextBox);
                    }
                }
            Label_0132:
                if (!flag)
                {
                    A_0.Read();
                }
                continue;
            Label_013E:
                A_0.Read();
            }
        }
    }

    private bool method_218(XmlReader A_0, TextBox A_1)
    {
        string str2;
        int num = 4;
        bool flag = false;
        string attribute = A_0.GetAttribute(BookmarkStart.b("帩唫席唯", 4));
        if ((attribute != null) && ((str2 = attribute) != null))
        {
            if ((str2 != BookmarkStart.b("帩䔫䈭唯", num)) && (str2 != BookmarkStart.b("䰩師伭崯圱", num)))
            {
                if (!(str2 == BookmarkStart.b("䴩師伭启嬱儳堵䰷", num)) && !(str2 == BookmarkStart.b("䴩師伭启嬱儳堵䰷根崻娽⤿⍁⡃", num)))
                {
                    if (str2 == BookmarkStart.b("娩䴫娭䐯圱䘳堵", num))
                    {
                        this.method_225(A_0, A_1.Format.FillEfects);
                        flag = true;
                    }
                }
                else
                {
                    this.method_220(A_0, A_1.Format.FillEfects);
                }
            }
            else
            {
                this.method_226(A_0, A_1, attribute);
            }
        }
        string str3 = A_0.GetAttribute(BookmarkStart.b("䔩尫伭匯嬱䀳伵", num));
        if (!string.IsNullOrEmpty(str3))
        {
            float num2 = this.method_467(str3);
            A_1.Format.Opacity = num2;
        }
        return flag;
    }

    private void method_219(Stream A_0, TextBox A_1)
    {
        if (A_0 != null)
        {
            A_0.Position = 0L;
            XmlReader reader = Class57.smethod_18(A_0);
            this.method_218(reader, A_1);
        }
    }

    private Dictionary<string, string> method_22()
    {
        return this.document_0.StyleNameIds;
    }

    private void method_220(XmlReader A_0, Background A_1)
    {
        int num = 15;
        A_1.Type = BackgroundType.Gradient;
        string attribute = A_0.GetAttribute(BookmarkStart.b("䜴制娸吺儼倾㍀", 15));
        if (!string.IsNullOrEmpty(attribute))
        {
            A_1.Recolor = this.method_110(attribute);
        }
        string str3 = A_0.GetAttribute(BookmarkStart.b("䜴堶䴸娺䤼娾", num));
        if (!string.IsNullOrEmpty(str3))
        {
            A_1.Rotate = this.method_110(str3);
        }
        this.method_221(A_0, A_1);
        if (A_0.GetAttribute(BookmarkStart.b("䄴丶䤸帺", num)) == BookmarkStart.b("刴䔶堸强吼娾⽀㝂ᝄ♆ⵈ≊ⱌ⍎", num))
        {
            this.method_223(A_0, A_1.Gradient);
        }
        else
        {
            this.method_222(A_0, A_1.Gradient);
        }
    }

    private void method_221(XmlReader A_0, Background A_1)
    {
        int num = 13;
        BackgroundGradient gradient = A_1.Gradient;
        if (A_1.Color == Color.Empty)
        {
            gradient.Color1 = Color.White;
        }
        else
        {
            gradient.Color1 = A_1.Color;
        }
        string attribute = A_0.GetAttribute(BookmarkStart.b("倲娴嬶嘸䤺༼", num));
        if (attribute == null)
        {
            gradient.Color2 = Color.Black;
        }
        else
        {
            gradient.Color2 = this.method_474(attribute);
        }
    }

    private void method_222(XmlReader A_0, BackgroundGradient A_1)
    {
        int num = 7;
        string attribute = A_0.GetAttribute(BookmarkStart.b("䬬䀮到䘲䘴", 7));
        string str2 = A_0.GetAttribute(BookmarkStart.b("䰬䄮嘰弲倴", 7));
        if (str2 == null)
        {
            A_1.ShadingStyle = GradientShadingStyle.Horizontal;
        }
        else if (str2 == BookmarkStart.b(",ᘮİ", num))
        {
            A_1.ShadingStyle = GradientShadingStyle.Vertical;
        }
        else if (str2 == BookmarkStart.b(",ḮȰز", num))
        {
            A_1.ShadingStyle = GradientShadingStyle.DiagonalUp;
        }
        else if (str2 == BookmarkStart.b(",ᬮа", num))
        {
            A_1.ShadingStyle = GradientShadingStyle.DiagonalDown;
        }
        A_1.ShadingVariant = this.method_224(attribute);
    }

    private void method_223(XmlReader A_0, BackgroundGradient A_1)
    {
        int num = 0x10;
        string attribute = A_0.GetAttribute(BookmarkStart.b("倵圷夹䤻䴽〿ⵁ㝃⽅㱇⍉⍋⁍", 0x10));
        string str2 = A_0.GetAttribute(BookmarkStart.b("倵圷夹䤻䴽", 0x10));
        if (A_0.ReadInnerXml() != string.Empty)
        {
            A_1.ShadingStyle = GradientShadingStyle.FromCorner;
            if (attribute == null)
            {
                A_1.ShadingVariant = GradientShadingVariant.ShadingUp;
            }
            else if (attribute == BookmarkStart.b("ܵ", num))
            {
                A_1.ShadingVariant = GradientShadingVariant.ShadingDown;
            }
            else if (attribute == BookmarkStart.b("ܵᐷହ", num))
            {
                A_1.ShadingVariant = GradientShadingVariant.ShadingMiddle;
            }
            else if (attribute == BookmarkStart.b("ᨵष", num))
            {
                A_1.ShadingVariant = GradientShadingVariant.ShadingOut;
            }
        }
        else
        {
            A_1.ShadingStyle = GradientShadingStyle.FromCenter;
            A_1.ShadingVariant = this.method_224(str2);
        }
    }

    private GradientShadingVariant method_224(string A_0)
    {
        int num = 7;
        if (A_0 == null)
        {
            return GradientShadingVariant.ShadingDown;
        }
        if (A_0 == BookmarkStart.b("ᰬἮİᘲ", num))
        {
            return GradientShadingVariant.ShadingUp;
        }
        if (A_0 == BookmarkStart.b("ᠬἮᐰ", num))
        {
            return GradientShadingVariant.ShadingMiddle;
        }
        return GradientShadingVariant.ShadingOut;
    }

    private void method_225(XmlReader A_0, Background A_1)
    {
        int num = 1;
        string attribute = A_0.GetAttribute(BookmarkStart.b("並䴨", 1), this.dictionary_18[BookmarkStart.b("唦", 1)]);
        A_1.PatternFill2010 = this.method_484(A_0);
        if (attribute != null)
        {
            bool flag = this.string_3.StartsWith(BookmarkStart.b("伦䰨䨪䤬䨮䌰", num)) || this.string_3.StartsWith(BookmarkStart.b("䄦䘨䐪夬䨮䌰", num));
            string str2 = this.method_459(attribute, flag, false);
            A_1.PatternImageBytes = this.method_460(str2);
        }
    }

    private void method_226(XmlReader A_0, TextBox A_1, string A_2)
    {
        int num = 0x12;
        string attribute = A_0.GetAttribute(BookmarkStart.b("儷帹", 0x12), this.dictionary_18[BookmarkStart.b("䨷", 0x12)]);
        if (attribute != null)
        {
            bool flag = this.string_3.StartsWith(BookmarkStart.b("倷弹崻娽┿ぁ", num)) || this.string_3.StartsWith(BookmarkStart.b("帷唹医䨽┿ぁ", num));
            if (A_2 == BookmarkStart.b("帷䠹崻匽┿", num))
            {
                A_1.Format.FillEfects.Type = BackgroundType.Picture;
            }
            else
            {
                A_1.Format.FillEfects.Type = BackgroundType.Texture;
            }
            string key = this.method_459(attribute, flag, false);
            if (this.method_0().ContainsKey(key))
            {
                A_1.Format.FillEfects.ImageRecord = this.document_0.Images.method_0(this.method_0()[key]);
            }
            else
            {
                Class517 class2 = new Class517(this.method_460(key));
                A_1.Format.FillEfects.ImageRecord = class2;
                this.document_0.Images.method_2(class2);
                this.method_0().Add(key, class2.method_0());
            }
        }
    }

    private TextWrappingStyle method_227(string A_0)
    {
        int num = 15;
        string str = A_0;
        if (str != null)
        {
            if (str == BookmarkStart.b("䘴䘶䰸娺似娾", num))
            {
                return TextWrappingStyle.Square;
            }
            if (str == BookmarkStart.b("䄴帶常区䤼", num))
            {
                return TextWrappingStyle.Tight;
            }
            if (str == BookmarkStart.b("䄴弶䬸吺䠼堾⥀", num))
            {
                return TextWrappingStyle.Through;
            }
            if (str == BookmarkStart.b("䄴堶䤸稺匼嬾̀ⱂㅄ㍆♈♊", num))
            {
                return TextWrappingStyle.TopAndBottom;
            }
            if (str == BookmarkStart.b("嬴堶圸帺", num))
            {
                return TextWrappingStyle.Inline;
            }
        }
        return TextWrappingStyle.InFrontOfText;
    }

    private TextWrappingType method_228(string A_0)
    {
        int num = 4;
        string str = A_0;
        if (str != null)
        {
            if (str == BookmarkStart.b("䘩䤫䠭䐯", num))
            {
                return TextWrappingType.Left;
            }
            if (str == BookmarkStart.b("堩䔫䤭堯䘱", num))
            {
                return TextWrappingType.Right;
            }
        }
        return TextWrappingType.Both;
    }

    internal void method_229(XmlReader A_0, IDocumentObject A_1)
    {
        int num = 3;
        if (((A_0.LocalName == BookmarkStart.b("崨个唬嬮匰尲䴴", 3)) || (A_0.LocalName == BookmarkStart.b("崨匪伬圮爰尲嬴䌶尸唺䤼", num))) && !A_0.IsEmptyElement)
        {
            string localName = A_0.LocalName;
            A_0.Read();
            if (!A_0.IsEmptyElement || (A_0.LocalName.ToLower() != BookmarkStart.b("崨匪伬圮到尲嬴䌶尸唺䤼", num)))
            {
                this.characterFormat_0 = null;
                TextBox internerTextbox = (A_1 as ShapeObject).InternerTextbox;
                if (!this.string_3.StartsWith(BookmarkStart.b("䄨个䰬䬮吰䄲", num)))
                {
                    this.string_3.StartsWith(BookmarkStart.b("伨䐪䈬嬮吰䄲", num));
                }
                while (A_0.LocalName != localName)
                {
                    if (A_0.EOF)
                    {
                        break;
                    }
                    if (A_0.NodeType == XmlNodeType.Element)
                    {
                        string str2 = A_0.LocalName;
                        if (str2 != null)
                        {
                            if (str2 != BookmarkStart.b("夨", num))
                            {
                                if (!(str2 == BookmarkStart.b("崨䤪䄬", num)))
                                {
                                    if (str2 == BookmarkStart.b("娨伪夬", num))
                                    {
                                        IStructureDocument document = internerTextbox.Body.method_21();
                                        this.method_300(A_0, document as StructureDocumentTag);
                                    }
                                }
                                else
                                {
                                    ITable entity = internerTextbox.Body.AddTable();
                                    this.method_83(A_0, entity as Table);
                                    if ((entity.Rows.Count <= 0) && internerTextbox.Body.Items.Contains(entity))
                                    {
                                        internerTextbox.Body.Items.Remove(entity);
                                    }
                                }
                            }
                            else
                            {
                                IParagraph paragraph = internerTextbox.Body.AddParagraph();
                                this.method_74(A_0, paragraph.Items);
                            }
                        }
                        A_0.Read();
                    }
                    else
                    {
                        A_0.Read();
                    }
                    this.method_485(A_0);
                }
            }
        }
    }

    private Dictionary<string, string> method_23()
    {
        if (this.dictionary_0 == null)
        {
            this.dictionary_0 = new Dictionary<string, string>();
        }
        return this.dictionary_0;
    }

    private void method_230(XmlReader A_0, TextBox A_1)
    {
        int num = 9;
        string attribute = A_0.GetAttribute(BookmarkStart.b("尮䔰䨲头制", 9));
        if (attribute != null)
        {
            if (attribute.Contains(BookmarkStart.b("䈮䈰尲ᠴ儶倸伺ြ䰾⥀≂㕄≆摈㽊≌扎═㙒ⵔ⍖捘⽚", num)))
            {
                A_1.Format.IsFitShapeToText = true;
            }
            if (attribute.Contains(BookmarkStart.b("䌮倰䨲娴䈶䴸ᘺ嬼匾⹀㑂罄ㅆⱈ㥊㥌♎㉐㉒㥔汖㑘⡚㉜牞ൠɢᱤࡦᱨὪ䁬८ᵰᱲɴ婶ᡸ᝺ॼ䕾ꂌﮎﺐ뺒", num)))
            {
                A_1.Format.LayoutFlowAlt = TextDirection.LeftToRight;
            }
            else if (attribute.Contains(BookmarkStart.b("䌮倰䨲娴䈶䴸ᘺ嬼匾⹀㑂罄⽆♈㥊⑌㕎㹐㵒⅔㙖㕘癚㑜㭞Ѡౢɤᕦࡨ᭪լٮተ", num)))
            {
                A_1.Format.LayoutFlowAlt = TextDirection.TopToBottomRotated;
            }
            else if (attribute.Contains(BookmarkStart.b("䌮倰䨲娴䈶䴸ᘺ嬼匾⹀㑂罄ㅆⱈ㥊㥌♎㉐㉒㥔", num)))
            {
                A_1.Format.LayoutFlowAlt = TextDirection.RightToLeft;
            }
            else if (attribute.Contains(BookmarkStart.b("䌮倰䨲娴䈶䴸ᘺ嬼匾⹀㑂罄ㅆⱈ㥊㥌♎㉐㉒㥔穖じ㽚㡜ぞ٠ᅢѤᝦŨɪ๬", num)))
            {
                A_1.Format.LayoutFlowAlt = TextDirection.RightToLeftRotated;
            }
        }
    }

    private void method_231(XmlReader A_0, TextBox A_1)
    {
        int num = 2;
        string attribute = A_0.GetAttribute(BookmarkStart.b("䄧䐩弫䬭䐯", 2));
        if (attribute != null)
        {
            string[] strArray = attribute.Replace(BookmarkStart.b("䔧䜩", num), string.Empty).Split(new char[] { ',' });
            int index = 0;
            int length = strArray.Length;
            while (index < length)
            {
                if (strArray[index] != string.Empty)
                {
                    float num3 = this.method_232(strArray[index]);
                    switch (index)
                    {
                        case 0:
                            A_1.Format.InternalMargin.Left = num3;
                            break;

                        case 1:
                            A_1.Format.InternalMargin.Top = num3;
                            break;

                        case 2:
                            A_1.Format.InternalMargin.Right = num3;
                            break;

                        case 3:
                            A_1.Format.InternalMargin.Bottom = num3;
                            break;
                    }
                }
                index++;
            }
        }
    }

    private float method_232(string A_0)
    {
        int num = 11;
        if ((A_0 == string.Empty) || A_0.EndsWith(BookmarkStart.b("吰帲䀴", num)))
        {
            return 0f;
        }
        if (A_0.EndsWith(BookmarkStart.b("䄰䜲", num)))
        {
            A_0 = A_0.Replace(BookmarkStart.b("䄰䜲", num), string.Empty);
            return float.Parse(A_0, NumberStyles.Float, CultureInfo.InvariantCulture);
        }
        if (A_0.EndsWith(BookmarkStart.b("堰崲", num)))
        {
            A_0 = A_0.Replace(BookmarkStart.b("堰崲", num), string.Empty);
            return (float) Class1073.smethod_1().method_1(Convert.ToDouble(A_0), PrintUnits.Inch, PrintUnits.Point);
        }
        float num3 = float.Parse(A_0, NumberStyles.Float, CultureInfo.InvariantCulture);
        return (float) Class1073.smethod_1().method_1((double) num3, PrintUnits.Millimeter, PrintUnits.Point);
    }

    private void method_233(XmlReader A_0, TextBox A_1)
    {
        int num = 0x10;
        string attribute = A_0.GetAttribute(BookmarkStart.b("刵夷䤹吻䴽㐿㭁⡃⍅", 0x10));
        if (attribute != null)
        {
            A_1.Format.LineDashing = this.method_234(attribute);
        }
        string str2 = A_0.GetAttribute(BookmarkStart.b("娵儷吹夻䴽㐿㭁⡃⍅", num));
        if (str2 != null)
        {
            A_1.Format.LineStyle = this.method_235(str2);
        }
    }

    private LineDashing method_234(string A_0)
    {
        int num = 8;
        string key = A_0;
        if (key != null)
        {
            int num2;
            if (Class1160.dictionary_71 == null)
            {
                Dictionary<string, int> dictionary1 = new Dictionary<string, int>(7);
                dictionary1.Add(BookmarkStart.b("Ἥု̱", num), 0);
                dictionary1.Add(BookmarkStart.b("䨭弯䘱", num), 1);
                dictionary1.Add(BookmarkStart.b("䨭儯䄱尳", num), 2);
                dictionary1.Add(BookmarkStart.b("䨭儯䄱尳爵圷丹", num), 3);
                dictionary1.Add(BookmarkStart.b("䈭弯就匳爵夷䤹吻", num), 4);
                dictionary1.Add(BookmarkStart.b("䈭弯就匳爵夷䤹吻稽⼿㙁", num), 5);
                dictionary1.Add(BookmarkStart.b("䈭弯就匳爵夷䤹吻稽⼿㙁C⥅㱇", num), 6);
                Class1160.dictionary_71 = dictionary1;
            }
            if (Class1160.dictionary_71.TryGetValue(key, out num2))
            {
                switch (num2)
                {
                    case 0:
                    case 1:
                        return LineDashing.Dot;

                    case 2:
                        return LineDashing.DashGEL;

                    case 3:
                        return LineDashing.DashDot;

                    case 4:
                        return LineDashing.LongDashGEL;

                    case 5:
                        return LineDashing.LongDashDotGEL;

                    case 6:
                        return LineDashing.LongDashDotDotGEL;
                }
            }
        }
        return LineDashing.Solid;
    }

    private TextBoxLineStyle method_235(string A_0)
    {
        int num = 0x11;
        string str = A_0;
        if (str != null)
        {
            if (str == BookmarkStart.b("䌶儸刺匼款⥀⩂⭄", num))
            {
                return TextBoxLineStyle.Double;
            }
            if (str == BookmarkStart.b("䌶儸刺匼款⥀⩂♄ⱆ", num))
            {
                return TextBoxLineStyle.ThinThick;
            }
            if (str == BookmarkStart.b("䌶儸刺帼吾ᕀ⭂ⱄ⥆", num))
            {
                return TextBoxLineStyle.ThickThin;
            }
            if (str == BookmarkStart.b("䌶儸刺帼吾̀♂ㅄうⱈ⹊⍌᭎㥐㩒㭔", num))
            {
                return TextBoxLineStyle.Triple;
            }
        }
        return TextBoxLineStyle.Simple;
    }

    private void method_236(XmlReader A_0, IDocumentObject A_1)
    {
        TextBox box = A_1 as TextBox;
        string attribute = A_0.GetAttribute(BookmarkStart.b("䔵䰷䌹倻嬽", 0x10));
        if (attribute != null)
        {
            attribute = attribute.Trim();
            char[] separator = new char[] { ';' };
            string[] strArray = attribute.Split(separator);
            string[] strArray2 = new string[2];
            int index = 0;
            int length = strArray.Length;
            while (index < length)
            {
                strArray2 = this.method_243(strArray[index]);
                if (strArray2 != null)
                {
                    this.method_240(box, strArray2[0], strArray2[1]);
                }
                index++;
            }
            this.method_237(A_0, box);
        }
    }

    private void method_237(XmlReader A_0, TextBox A_1)
    {
        int num = 4;
        string attribute = A_0.GetAttribute(BookmarkStart.b("帩唫席唯", 4));
        if (!string.IsNullOrEmpty(attribute))
        {
            A_1.Format.ShapeTypeId = this.method_473(attribute);
        }
        attribute = A_0.GetAttribute(BookmarkStart.b("天堫尭弯失儳唵圷嘹医䰽", num));
        if (!string.IsNullOrEmpty(attribute))
        {
            A_1.Format.LineColor = this.method_474(attribute);
        }
        attribute = A_0.GetAttribute(BookmarkStart.b("天堫尭弯失儳䄵崷匹嬻嘽㐿", num));
        if (!string.IsNullOrEmpty(attribute))
        {
            A_1.Format.LineWidth = this.method_238(attribute);
        }
        attribute = A_0.GetAttribute(BookmarkStart.b("䰩䔫䈭尯圱倳", num));
        if (!string.IsNullOrEmpty(attribute) && (attribute == BookmarkStart.b("䰩", num)))
        {
            A_1.Format.FillColor = Color.Empty;
        }
        else
        {
            attribute = A_0.GetAttribute(BookmarkStart.b("䰩䔫䈭尯儱嬳娵圷䠹", num));
            if (!string.IsNullOrEmpty(attribute))
            {
                A_1.Format.FillEfects.Color = this.method_474(attribute);
                A_1.Format.FillEfects.Type = BackgroundType.Color;
            }
        }
        attribute = A_0.GetAttribute(BookmarkStart.b("天堫尭弯失儳刵", num));
        if (!string.IsNullOrEmpty(attribute))
        {
            A_1.Format.NoLine = ((attribute == BookmarkStart.b("䰩", num)) || (attribute == BookmarkStart.b("ᨩ", num))) || (attribute == BookmarkStart.b("䔩䨫䠭", num));
        }
        attribute = A_0.GetAttribute(BookmarkStart.b("䬩䀫䈭弯䔱崳堵嬷弹倻刽", num), this.dictionary_18[BookmarkStart.b("䔩", num)]);
        if (!string.IsNullOrEmpty(attribute))
        {
            A_1.Format.IsAllowInCell = ((attribute != BookmarkStart.b("䰩", num)) && (attribute != BookmarkStart.b("ᨩ", num))) && (attribute != BookmarkStart.b("䔩䨫䠭", num));
        }
        attribute = A_0.GetAttribute(BookmarkStart.b("崩師伭䀯儱嬳夵䨷帹伻", num));
        if (!string.IsNullOrEmpty(attribute))
        {
            A_1.Format.WrapPolygon = this.method_245(attribute);
        }
        attribute = A_0.GetAttribute(BookmarkStart.b("䬩䠫䐭", num));
        if (!string.IsNullOrEmpty(attribute))
        {
            A_1.Format.Adjustment = this.method_246(attribute);
        }
        attribute = A_0.GetAttribute(BookmarkStart.b("䬩䀫䈭弯䔱嬳䀵崷䠹倻弽〿", num), this.dictionary_18[BookmarkStart.b("䔩", num)]);
        if (!string.IsNullOrEmpty(attribute))
        {
            A_1.Format.AllowOverlap = ((attribute != BookmarkStart.b("䰩", num)) && (attribute != BookmarkStart.b("ᨩ", num))) && (attribute != BookmarkStart.b("䔩䨫䠭", num));
        }
    }

    private float method_238(string A_0)
    {
        float num2;
        int num = 3;
        if (A_0.EndsWith(BookmarkStart.b("夨弪", 3)))
        {
            A_0 = A_0.Replace(BookmarkStart.b("夨弪", num), string.Empty);
            return float.Parse(A_0, NumberStyles.Float, CultureInfo.InvariantCulture);
        }
        if (A_0.EndsWith(BookmarkStart.b("䐨䘪", num)))
        {
            A_0 = A_0.Replace(BookmarkStart.b("䐨䘪", num), string.Empty);
            num2 = float.Parse(A_0, NumberStyles.Float, CultureInfo.InvariantCulture);
            return (float) Class1073.smethod_1().method_1((double) num2, PrintUnits.Millimeter, PrintUnits.Point);
        }
        if (A_0.EndsWith(BookmarkStart.b("夨匪", num)))
        {
            A_0 = A_0.Replace(BookmarkStart.b("夨匪", num), string.Empty);
            num2 = float.Parse(A_0, NumberStyles.Float, CultureInfo.InvariantCulture);
            return (float) Class1073.smethod_1().method_1((double) num2, PrintUnits.Pixel, PrintUnits.Point);
        }
        if (A_0.EndsWith(BookmarkStart.b("䀨䔪", num)))
        {
            A_0 = A_0.Replace(BookmarkStart.b("䀨䔪", num), string.Empty);
            num2 = float.Parse(A_0, NumberStyles.Float, CultureInfo.InvariantCulture);
            return (float) Class1073.smethod_1().method_1((double) num2, PrintUnits.Inch, PrintUnits.Point);
        }
        if (A_0.EndsWith(BookmarkStart.b("䨨䘪", num)))
        {
            A_0 = A_0.Replace(BookmarkStart.b("䨨䘪", num), string.Empty);
            num2 = float.Parse(A_0, NumberStyles.Float, CultureInfo.InvariantCulture);
            return (float) Class1073.smethod_1().method_1((double) num2, PrintUnits.Centimeter, PrintUnits.Point);
        }
        return (float.Parse(A_0, NumberStyles.Float, CultureInfo.InvariantCulture) / 12700f);
    }

    private int method_239(string A_0)
    {
        float num2;
        int num = 9;
        if (A_0.EndsWith(BookmarkStart.b("弮䔰", 9)))
        {
            A_0 = A_0.Replace(BookmarkStart.b("弮䔰", num), string.Empty);
            return (int) (float.Parse(A_0, NumberStyles.Float, CultureInfo.InvariantCulture) * 20f);
        }
        if (A_0.EndsWith(BookmarkStart.b("䈮尰", num)))
        {
            A_0 = A_0.Replace(BookmarkStart.b("䈮尰", num), string.Empty);
            num2 = float.Parse(A_0, NumberStyles.Float, CultureInfo.InvariantCulture);
            return (int) (((float) Class1073.smethod_1().method_1((double) num2, PrintUnits.Millimeter, PrintUnits.Point)) * 20f);
        }
        if (A_0.EndsWith(BookmarkStart.b("弮䤰", num)))
        {
            A_0 = A_0.Replace(BookmarkStart.b("弮䤰", num), string.Empty);
            num2 = float.Parse(A_0, NumberStyles.Float, CultureInfo.InvariantCulture);
            return (int) (((float) Class1073.smethod_1().method_1((double) num2, PrintUnits.Pixel, PrintUnits.Point)) * 20f);
        }
        if (A_0.EndsWith(BookmarkStart.b("䘮弰", num)))
        {
            A_0 = A_0.Replace(BookmarkStart.b("䘮弰", num), string.Empty);
            num2 = float.Parse(A_0, NumberStyles.Float, CultureInfo.InvariantCulture);
            return (int) (((float) Class1073.smethod_1().method_1((double) num2, PrintUnits.Inch, PrintUnits.Point)) * 20f);
        }
        if (A_0.EndsWith(BookmarkStart.b("䰮尰", num)))
        {
            A_0 = A_0.Replace(BookmarkStart.b("䰮尰", num), string.Empty);
            num2 = float.Parse(A_0, NumberStyles.Float, CultureInfo.InvariantCulture);
            return (int) (((float) Class1073.smethod_1().method_1((double) num2, PrintUnits.Centimeter, PrintUnits.Point)) * 20f);
        }
        return (int) float.Parse(A_0, NumberStyles.Float, CultureInfo.InvariantCulture);
    }

    private void method_24(ParagraphBase A_0, IParagraph A_1)
    {
        A_1.Items.Add(A_0);
        if ((((this.method_9() != null) && !this.method_9().IsFieldRange) && ((this.method_9().Owner != A_0) && (this.method_9() != A_0))) && (((this.method_9().Type != FieldType.FieldEmbed) && (this.method_9().Type != FieldType.FieldLink)) && (this.method_9().Type != FieldType.FieldHyperlink)))
        {
            this.method_129(A_0);
        }
    }

    private void method_240(TextBox A_0, string A_1, string A_2)
    {
        int num = 6;
        string key = A_1;
        if (key != null)
        {
            int num4;
            if (Class1160.dictionary_72 == null)
            {
                Dictionary<string, int> dictionary1 = new Dictionary<string, int>(0x16);
                dictionary1.Add(BookmarkStart.b("䄫伭䈯唱崳堵ᔷ嘹夻堽㐿", num), 0);
                dictionary1.Add(BookmarkStart.b("䄫伭䈯唱崳堵ᔷ丹医丽", num), 1);
                dictionary1.Add(BookmarkStart.b("嬫䜭启䘱尳", num), 2);
                dictionary1.Add(BookmarkStart.b("䐫䬭夯唱尳䈵", num), 3);
                dictionary1.Add(BookmarkStart.b("嘫̭夯就倳匵䀷", num), 4);
                dictionary1.Add(BookmarkStart.b("䄫崭弯ἱ䐳夵䬷匹䠻圽⼿ⱁ楃⹅❇㡉╋㑍㽏㱑⁓㝕㑗", num), 5);
                dictionary1.Add(BookmarkStart.b("䄫崭弯ἱ䐳夵䬷匹䠻圽⼿ⱁ楃ぅⵇ㡉㡋❍㍏㍑㡓", num), 6);
                dictionary1.Add(BookmarkStart.b("䄫崭弯ἱ䐳夵䬷匹䠻圽⼿ⱁ楃ぅⵇ㡉㡋❍㍏㍑㡓筕⩗㽙せ㽝ᑟୡባͥ", num), 7);
                dictionary1.Add(BookmarkStart.b("䄫崭弯ἱ䐳夵䬷匹䠻圽⼿ⱁ楃⹅❇㡉╋㑍㽏㱑⁓㝕㑗睙⹛㭝౟͡ၣཥṧཀྵ", num), 8);
                dictionary1.Add(BookmarkStart.b("䄫崭弯ἱ堳匵帷丹ᄻ丽┿ぁ❃⍅♇㹉", num), 9);
                dictionary1.Add(BookmarkStart.b("䄫崭弯ἱ䀳夵䠷᜹䰻嬽㈿⅁⅃⡅㱇", num), 10);
                dictionary1.Add(BookmarkStart.b("䄫崭弯ἱ䌳張尷丹吻ጽ〿❁㙃╅ⵇ⑉㡋", num), 11);
                dictionary1.Add(BookmarkStart.b("䄫崭弯ἱ尳匵儷崹吻䨽洿㉁⅃㑅⭇⽉≋㩍", num), 12);
                dictionary1.Add(BookmarkStart.b("䄫崭弯ἱ䌳張尷丹吻ጽ㈿❁⡃❅㱇⍉㩋⭍", num), 13);
                dictionary1.Add(BookmarkStart.b("䄫崭弯ἱ尳匵儷崹吻䨽洿ぁ⅃⩅⥇㹉╋㡍㕏", num), 14);
                dictionary1.Add(BookmarkStart.b("娫̭䐯圱䰳䈵ᔷ嬹刻崽⠿ⵁ㙃", num), 15);
                dictionary1.Add(BookmarkStart.b("師䄭䐯匱䀳張圷吹", num), 0x10);
                dictionary1.Add(BookmarkStart.b("䄫崭弯ἱ䌳䐵夷䨹ᄻ娽⤿ㅁぃ❅♇⥉⥋捍㱏㝑㉓≕", num), 0x11);
                dictionary1.Add(BookmarkStart.b("䄫崭弯ἱ䌳䐵夷䨹ᄻ娽⤿ㅁぃ❅♇⥉⥋捍≏㭑㍓㹕ⱗ", num), 0x12);
                dictionary1.Add(BookmarkStart.b("䄫崭弯ἱ䌳䐵夷䨹ᄻ娽⤿ㅁぃ❅♇⥉⥋捍⑏㵑⑓", num), 0x13);
                dictionary1.Add(BookmarkStart.b("䄫崭弯ἱ䌳䐵夷䨹ᄻ娽⤿ㅁぃ❅♇⥉⥋捍㉏㵑⁓≕㝗㝙", num), 20);
                dictionary1.Add(BookmarkStart.b("䄫崭弯ἱ䌳䐵夷䨹ᄻ䴽㐿㭁⡃⍅", num), 0x15);
                Class1160.dictionary_72 = dictionary1;
            }
            if (Class1160.dictionary_72.TryGetValue(key, out num4))
            {
                switch (num4)
                {
                    case 0:
                        A_0.Format.HorizontalPosition = this.method_467(A_2);
                        return;

                    case 1:
                        A_0.Format.VerticalPosition = this.method_467(A_2);
                        return;

                    case 2:
                        A_0.Format.Width = this.method_467(A_2);
                        return;

                    case 3:
                        A_0.Format.Height = this.method_467(A_2);
                        return;

                    case 4:
                    {
                        int num2 = int.Parse(A_2, NumberStyles.Integer, CultureInfo.InvariantCulture);
                        A_0.Format.OrderIndex = num2;
                        A_0.Format.IsBelowText = num2 <= 0;
                        if (!A_0.Format.IsBelowText)
                        {
                            A_0.Format.TextWrappingStyle = TextWrappingStyle.InFrontOfText;
                            return;
                        }
                        A_0.Format.TextWrappingStyle = TextWrappingStyle.Behind;
                        return;
                    }
                    case 5:
                        A_0.Format.HorizontalAlignment = this.method_279(A_2);
                        return;

                    case 6:
                        A_0.Format.VerticalAlignment = this.method_283(A_2);
                        return;

                    case 7:
                        A_0.Format.VerticalOrigin = this.method_284(A_2);
                        return;

                    case 8:
                        A_0.Format.HorizontalOrigin = this.method_280(A_2);
                        return;

                    case 9:
                        A_0.Format.LeftPercent = this.method_467(A_2) / 10f;
                        return;

                    case 10:
                        A_0.Format.TopPercent = this.method_467(A_2) / 10f;
                        return;

                    case 11:
                        A_0.Format.WidthPercent = this.method_467(A_2) / 10f;
                        return;

                    case 12:
                        A_0.Format.HeightPercent = this.method_467(A_2) / 10f;
                        return;

                    case 13:
                        A_0.Format.RelationWidth = this.method_280(A_2);
                        return;

                    case 14:
                        A_0.Format.RelationHeight = this.method_284(A_2);
                        return;

                    case 15:
                        A_0.Format.TextAnchor = this.method_242(A_2);
                        return;

                    case 0x10:
                    {
                        int num3 = (int) Math.Round((double) this.method_467(A_2));
                        if (num3 >= 0)
                        {
                            A_0.Format.Rotation = num3;
                            return;
                        }
                        A_0.Format.Rotation = 360 + num3;
                        return;
                    }
                    case 0x11:
                        A_0.Format.WrapDistanceLeft = this.method_467(A_2);
                        return;

                    case 0x12:
                        A_0.Format.WrapDistanceRight = this.method_467(A_2);
                        return;

                    case 0x13:
                        A_0.Format.WrapDistanceTop = this.method_467(A_2);
                        return;

                    case 20:
                        A_0.Format.WrapDistanceBottom = this.method_467(A_2);
                        return;

                    case 0x15:
                        A_0.Format.TextBoxWrapMode = this.method_241(A_2);
                        return;
                }
            }
        }
        A_0.Format.DocxStyleProps.Add(A_1 + BookmarkStart.b("ᘫ", num) + A_2);
    }

    private TextBoxWrapMode method_241(string A_0)
    {
        string str;
        int num = 0x10;
        if (((str = A_0) != null) && (str == BookmarkStart.b("堵圷吹夻", num)))
        {
            return TextBoxWrapMode.None;
        }
        return TextBoxWrapMode.Square;
    }

    private ShapeVerticalAlignment method_242(string A_0)
    {
        int num = 0x13;
        string str = A_0;
        if (str != null)
        {
            if (str == BookmarkStart.b("吸刺夼嬾ⵀ♂", num))
            {
                return ShapeVerticalAlignment.Center;
            }
            if (str == BookmarkStart.b("䴸吺䴼", num))
            {
                return ShapeVerticalAlignment.Top;
            }
            if (str == BookmarkStart.b("嬸吺䤼䬾⹀⹂", num))
            {
                return ShapeVerticalAlignment.Bottom;
            }
        }
        return ShapeVerticalAlignment.None;
    }

    private string[] method_243(string A_0)
    {
        A_0 = A_0.Replace(BookmarkStart.b("䤸伺", 0x13), string.Empty);
        char[] separator = new char[] { ':' };
        string[] strArray = A_0.Split(separator);
        if (strArray.Length == 2)
        {
            return strArray;
        }
        return null;
    }

    private DocxParserShapeType method_244(MemoryStream A_0)
    {
        int num = 14;
        XmlReader reader = Class57.smethod_18(A_0);
        if ((reader.LocalName != BookmarkStart.b("䐳張嬷丹", 14)) && (reader.LocalName != BookmarkStart.b("䜳帵夷䨹夻", num)))
        {
            throw new XmlException(BookmarkStart.b("䐳張嬷丹䤻䰽┿扁㝃⹅⥇㩉⥋湍㕏㹑ㅓ㭕㵗㑙⡛", num));
        }
        string str3 = null;
        string attribute = null;
        string str = null;
        string key = null;
        string str4 = null;
        bool flag5 = false;
        bool flag3 = false;
        bool flag4 = false;
        bool flag2 = false;
        bool flag = false;
        while (reader.Read())
        {
            string str7;
            if ((reader.NodeType == XmlNodeType.Element) && ((str7 = reader.LocalName) != null))
            {
                int num2;
                if (Class1160.dictionary_73 == null)
                {
                    Dictionary<string, int> dictionary1 = new Dictionary<string, int>(12);
                    dictionary1.Add(BookmarkStart.b("匳䐵圷伹䰻", num), 0);
                    dictionary1.Add(BookmarkStart.b("笳稵紷甹帻吽┿⅁ぃ", num), 1);
                    dictionary1.Add(BookmarkStart.b("䜳帵夷䨹夻", num), 2);
                    dictionary1.Add(BookmarkStart.b("䀳匵䀷丹䰻弽㐿⩁", num), 3);
                    dictionary1.Add(BookmarkStart.b("䀳匵䀷丹帻儽㠿", num), 4);
                    dictionary1.Add(BookmarkStart.b("䘳匵嬷丹", num), 5);
                    dictionary1.Add(BookmarkStart.b("䀳丵娷䈹缻儽⸿㙁⅃⡅㱇", num), 6);
                    dictionary1.Add(BookmarkStart.b("䜳帵夷䨹夻䨽㤿㉁⅃", num), 7);
                    dictionary1.Add(BookmarkStart.b("崳嬵夷崹夻娽ℿ㙁╃", num), 8);
                    dictionary1.Add(BookmarkStart.b("䘳夵䴷吹堻䰽┿⅁ぃ", num), 9);
                    dictionary1.Add(BookmarkStart.b("嬳䀵夷嘹", num), 10);
                    dictionary1.Add(BookmarkStart.b("䐳圵䰷刹", num), 11);
                    Class1160.dictionary_73 = dictionary1;
                }
                if (Class1160.dictionary_73.TryGetValue(str7, out num2))
                {
                    switch (num2)
                    {
                        case 0:
                            return DocxParserShapeType.GroupedShape;

                        case 1:
                            return DocxParserShapeType.OleObject;

                        case 2:
                            attribute = reader.GetAttribute(BookmarkStart.b("䀳伵䠷弹", num));
                            str3 = reader.GetAttribute(BookmarkStart.b("崳刵", num));
                            flag2 = true;
                            break;

                        case 3:
                            flag = true;
                            break;

                        case 4:
                        case 5:
                            flag3 = true;
                            break;

                        case 6:
                            flag4 = true;
                            if (!flag3 || !flag4)
                            {
                                break;
                            }
                            return DocxParserShapeType.TextboxShape;

                        case 7:
                            str = reader.GetAttribute(BookmarkStart.b("崳刵", num));
                            break;

                        case 8:
                            flag5 = true;
                            key = reader.GetAttribute(BookmarkStart.b("崳刵", num), this.dictionary_18[BookmarkStart.b("䘳", num)]);
                            str4 = reader.GetAttribute(BookmarkStart.b("尳䐵崷尹", num), this.dictionary_18[BookmarkStart.b("䘳", num)]);
                            break;

                        case 9:
                        case 10:
                            return DocxParserShapeType.XmlParagraphItem;

                        case 11:
                            if (!string.IsNullOrEmpty(reader.GetAttribute(BookmarkStart.b("圳夵嘷吹夻崽㐿⹁⭃╅㭇", num), this.dictionary_18[BookmarkStart.b("嬳", num)])) && flag2)
                            {
                                return DocxParserShapeType.XmlParagraphItem;
                            }
                            break;
                    }
                }
            }
        }
        if (!string.IsNullOrEmpty(str3))
        {
            if (str3.StartsWith(BookmarkStart.b("搳夵伷弹主渽ⰿ㝁㝃ᅅ⥇㹉⥋㱍ᵏ㍑♓㵕᝗㡙㙛㭝͟ᙡ", num)) && flag)
            {
                return DocxParserShapeType.WatermarkText;
            }
            if ((str3.StartsWith(BookmarkStart.b("搳夵伷弹主渽ⰿ㝁㝃ᅅ⥇㹉⥋㱍ᵏ㍑♓㵕᝗㡙㙛㭝͟ᙡ", num)) && !flag) || str3.StartsWith(BookmarkStart.b("挳夵䨷帹氻圽⌿㙁ㅃ㑅ⵇᵉⵋ㩍㕏⁑㥓㝕⩗ㅙ", num)))
            {
                return DocxParserShapeType.WatermarkPicture;
            }
        }
        if (flag3 && (attribute == BookmarkStart.b("ᜳ椵䀷ਹ఻฽瀿ᵁぃ瑅硇硉", num)))
        {
            return DocxParserShapeType.TextboxShape;
        }
        if ((((str == null) || (attribute == null)) || ((str != BookmarkStart.b("欳丵࠷ਹ఻฽Ἷ㙁獃獅", num)) || (attribute != BookmarkStart.b("ᜳ椵䀷ਹ఻฽瀿ᵁぃ煅絇", num)))) || (!flag5 || flag3))
        {
            if (((str == null) && (attribute == BookmarkStart.b("ᜳ椵䀷ਹ఻฽瀿ᵁぃ煅絇", num))) && !flag3)
            {
                return DocxParserShapeType.PictureShape;
            }
            if (((str4 == null) || (str4 == string.Empty)) && ((key == null) || !this.dictionary_2.ContainsKey(key)))
            {
                return DocxParserShapeType.XmlParagraphItem;
            }
        }
        return DocxParserShapeType.PictureShape;
    }

    private Class891[] method_245(string A_0)
    {
        MatchCollection matchs = new Regex(BookmarkStart.b("ἱଳ樵尷ᄹ", 12)).Matches(A_0);
        string[] strArray = new string[matchs.Count];
        for (int i = 0; i < matchs.Count; i++)
        {
            strArray[i] = matchs[i].Value;
        }
        Class891[] classArray = new Class891[strArray.Length / 2];
        for (int j = 0; j < (strArray.Length / 2); j++)
        {
            classArray[j] = new Class891(Class233.smethod_4(strArray[2 * j]), Class233.smethod_4(strArray[(2 * j) + 1]));
        }
        if (classArray.Length == 0)
        {
            return null;
        }
        return classArray;
    }

    private List<int> method_246(string A_0)
    {
        List<int> list = new List<int>();
        foreach (string str in A_0.Split(new char[] { ',' }))
        {
            if (!string.IsNullOrEmpty(str))
            {
                int item = int.Parse(str, NumberStyles.Integer, CultureInfo.InvariantCulture);
                list.Add(item);
            }
        }
        return list;
    }

    private bool method_247(XmlReader A_0, string A_1, string A_2)
    {
        A_0.MoveToContent();
        while (A_0.Read())
        {
            if ((A_0.AttributeCount > 0) && (A_0.Prefix.ToLower() == A_2))
            {
                this.method_65(A_0);
                A_0.MoveToContent();
            }
            if (((A_0.NodeType == XmlNodeType.Element) && (A_0.LocalName == A_1)) && (A_0.NamespaceURI == this.dictionary_18[A_2]))
            {
                return true;
            }
        }
        return false;
    }

    private ParagraphBase method_248(XmlReader A_0, ParagraphItemCollection A_1, ref MemoryStream A_2)
    {
        int num = 8;
        if (A_0.LocalName != BookmarkStart.b("䨭䈯匱䌳張嘷崹", 8))
        {
            throw new XmlException(BookmarkStart.b("樭䈯匱䌳張嘷崹᰻嬽ⰿ❁⥃⍅♇㹉", num));
        }
        A_2 = this.method_484(A_0);
        XmlReader reader = Class57.smethod_18(A_2);
        while (reader.NodeType != XmlNodeType.Element)
        {
            reader.Read();
        }
        this.bool_14 = this.method_253(reader, A_1);
        reader = Class57.smethod_18(A_2);
        while (reader.NodeType != XmlNodeType.Element)
        {
            reader.Read();
        }
        if (!this.method_285(reader))
        {
            A_2.Position = 0L;
            return this.method_257(A_2);
        }
        DocPicture picture = new DocPicture(this.document_0);
        string str11 = null;
        string str7 = null;
        this.method_247(reader, BookmarkStart.b("䰭尯嬱䐳", num), BookmarkStart.b("伭", num));
        MemoryStream stream2 = this.method_484(reader);
        this.method_250(stream2, picture, ref str11, ref str7);
        bool flag2 = this.string_3.StartsWith(BookmarkStart.b("䘭唯匱倳匵䨷", num)) || this.string_3.StartsWith(BookmarkStart.b("䠭弯崱䀳匵䨷", num));
        picture.IsHeaderPicture = flag2;
        if (str11 != null)
        {
            this.method_458(picture, str11, flag2, false);
        }
        else
        {
            if (str7 == null)
            {
                return null;
            }
            Image image = this.method_463(str7, flag2, false);
            if (image == null)
            {
                return null;
            }
            picture.LoadImage(image);
        }
        A_2.Position = 0L;
        reader = Class57.smethod_18(A_2);
        if (this.method_247(reader, BookmarkStart.b("䴭尯䀱眳帵夷吹嬻嬽", num), BookmarkStart.b("伭", num)))
        {
            using (MemoryStream stream = this.method_484(reader))
            {
                this.method_251(stream, picture);
            }
        }
        A_2.Position = 0L;
        reader = Class57.smethod_18(A_2);
        if (this.method_247(reader, BookmarkStart.b("崭䈯儱昳匵嬷丹", num), BookmarkStart.b("伭", num)))
        {
            string attribute = reader.GetAttribute(BookmarkStart.b("䰭", num));
            if ((attribute != null) && (attribute.Trim().Length > 0))
            {
                picture.CropFromBottom = float.Parse(attribute, NumberStyles.Float, CultureInfo.InvariantCulture) / 100000f;
            }
            string s = reader.GetAttribute(BookmarkStart.b("䈭", num));
            if ((s != null) && (s.Trim().Length > 0))
            {
                picture.CropFromLeft = float.Parse(s, NumberStyles.Float, CultureInfo.InvariantCulture) / 100000f;
            }
            string str4 = reader.GetAttribute(BookmarkStart.b("尭", num));
            if ((str4 != null) && (str4.Trim().Length > 0))
            {
                picture.CropFromRight = float.Parse(str4, NumberStyles.Float, CultureInfo.InvariantCulture) / 100000f;
            }
            string str12 = reader.GetAttribute(BookmarkStart.b("娭", num));
            if ((str12 != null) && (str12.Trim().Length > 0))
            {
                picture.CropFromTop = float.Parse(str12, NumberStyles.Float, CultureInfo.InvariantCulture) / 100000f;
            }
        }
        A_2.Position = 0L;
        reader = Class57.smethod_18(A_2);
        if (this.method_247(reader, BookmarkStart.b("嘭嘯䀱夳", num), BookmarkStart.b("伭", num)))
        {
            string str8 = reader.GetAttribute(BookmarkStart.b("尭弯䘱", num));
            if (str8 != null)
            {
                picture.Rotation = float.Parse(str8, NumberStyles.Float, CultureInfo.InvariantCulture) / 60000f;
            }
        }
        A_2.Position = 0L;
        reader = Class57.smethod_18(A_2);
        if (this.method_247(reader, BookmarkStart.b("䈭帯", num), BookmarkStart.b("伭", num)))
        {
            string str3 = reader.GetAttribute(BookmarkStart.b("夭", num));
            string str = reader.GetAttribute(BookmarkStart.b("䴭崯䈱倳", num));
            bool flag = false;
            reader.Read();
            this.method_485(reader);
            while (reader.NodeType == XmlNodeType.Element)
            {
                if (!(reader.LocalName != BookmarkStart.b("䈭帯", num)))
                {
                    break;
                }
                string localName = reader.LocalName;
                if (localName != null)
                {
                    if (localName != BookmarkStart.b("䀭弯琱崳娵吷", num))
                    {
                        if (localName != BookmarkStart.b("崭弯帱崳刵縷匹倻刽", num))
                        {
                            if (localName != BookmarkStart.b("䤭䈯匱倳瀵儷嘹倻", num))
                            {
                                if (!(localName == BookmarkStart.b("崭匯娱儳嬵崷礹倻䰽", num)))
                                {
                                    if (localName == BookmarkStart.b("崭䈯唱嘳电吷䠹", num))
                                    {
                                        string str5 = reader.GetAttribute(BookmarkStart.b("堭儯帱", num));
                                        if ((str5 != null) && flag)
                                        {
                                            Color color = this.method_474(str5);
                                            picture.Borders.Color = color;
                                            picture.SetShapeAttr(0x1c0, color);
                                        }
                                    }
                                }
                                else
                                {
                                    string str9 = reader.GetAttribute(BookmarkStart.b("堭儯帱", num));
                                    string str13 = this.method_249(str9, this.document_0);
                                    if (flag)
                                    {
                                        Color color2 = this.method_474(str13);
                                        if (!color2.IsEmpty)
                                        {
                                            picture.Borders.Color = color2;
                                            picture.SetShapeAttr(0x1c0, color2);
                                        }
                                        picture.Borders.ColorShemeName = str9;
                                    }
                                }
                            }
                            else
                            {
                                flag = true;
                                picture.Borders.BorderType = BorderStyle.Single;
                                picture.Borders.LineWidth = 0.5f;
                                picture.SetShapeAttr(0x1cb, Class59.smethod_8(6350f, 2));
                                picture.SetShapeAttr(0x1fc, true);
                            }
                        }
                        else
                        {
                            flag = true;
                            picture.Borders.BorderType = BorderStyle.Single;
                            picture.Borders.LineWidth = 0.5f;
                            picture.SetShapeAttr(0x1cb, Class59.smethod_8(6350f, 2));
                            picture.SetShapeAttr(0x1fc, true);
                        }
                    }
                    else
                    {
                        flag = false;
                    }
                }
                if (!flag)
                {
                    break;
                }
                reader.Read();
                this.method_485(reader);
            }
            if (flag)
            {
                if (str3 != null)
                {
                    picture.Borders.LineWidth = Convert.ToSingle(str3) / 12700f;
                    picture.SetShapeAttr(0x1cb, Class59.smethod_8(6350f, 2));
                }
                if (str != null)
                {
                    picture.Borders.BorderType = this.method_391(str);
                }
            }
        }
        reader.Close();
        A_2.Position = 0L;
        reader = Class57.smethod_18(A_2);
        picture.ImageData = picture;
        if (!this.bool_14)
        {
            return this.method_263(reader, picture);
        }
        this.method_456(this.method_263(reader, picture), A_1);
        FieldMark mark = new FieldMark(this.document_0, FieldMarkType.FieldEnd);
        if (this.method_8().Count > 0)
        {
            this.method_9().End = mark;
            this.method_8().Pop();
        }
        this.method_456(mark, A_1);
        this.bool_14 = false;
        return null;
    }

    private string method_249(string A_0, Document A_1)
    {
        string str = null;
        if (!string.IsNullOrEmpty(A_0))
        {
            if (A_1.ColorScheme.ContainsKey(A_0))
            {
                return A_1.ColorScheme[A_0];
            }
            string key = Class327.smethod_0(A_0);
            if (A_1.ColorScheme.ContainsKey(key))
            {
                str = A_1.ColorScheme[key];
            }
        }
        return str;
    }

    internal Document method_25(string A_0, Document A_1)
    {
        int num = 2;
        if ((A_0 != null) && (A_0.Length != 0))
        {
            using (FileStream stream = new FileStream(A_0, FileMode.Open, FileAccess.Read))
            {
                return this.method_26(stream, A_1);
            }
        }
        throw new ArgumentOutOfRangeException(BookmarkStart.b("䄧䐩尫嬭䐯ሱ爳張吷弹爻弽ⴿ❁", num));
    }

    private void method_250(MemoryStream A_0, DocPicture A_1, ref string A_2, ref string A_3)
    {
        int num = 5;
        XmlReader reader = Class57.smethod_18(A_0);
        if (reader.LocalName == BookmarkStart.b("䤪䄬䘮䄰", 5))
        {
            A_2 = reader.GetAttribute(BookmarkStart.b("个䀬䴮吰圲", num), this.dictionary_18[BookmarkStart.b("太", num)]);
            A_3 = reader.GetAttribute(BookmarkStart.b("䜪䐬䄮娰", num), this.dictionary_18[BookmarkStart.b("太", num)]);
            reader.Read();
            this.method_485(reader);
            while (reader.LocalName != BookmarkStart.b("䤪䄬䘮䄰", num))
            {
                if (string.IsNullOrEmpty(reader.LocalName))
                {
                    break;
                }
                string localName = reader.LocalName;
                if (localName != null)
                {
                    if (localName != BookmarkStart.b("䨪䄬弮夰刲破堶崸紺吼䜾", num))
                    {
                        if (localName != BookmarkStart.b("䰪弬丮䠰䀲嘴嬶", num))
                        {
                            if (localName != BookmarkStart.b("䤪䐬挮吰䔲倴嬶", num))
                            {
                                if (localName == BookmarkStart.b("䜪堬䈮", num))
                                {
                                    Regex regex = new Regex(BookmarkStart.b("تሬܮᤰȲԴܶး䜺ᔼ搾煀湂籄ᩆቈ筊恌癎౐汒籔繖煘ݚ獜ў兠乢層㩦㉨孪䁬噮Ɒ䱲屴䡶屸", num));
                                    Regex regex2 = new Regex(BookmarkStart.b("تሬ献唰ᜲ", num));
                                    string attribute = reader.GetAttribute(BookmarkStart.b("䤪弬䘮嘰嬲䄴", num));
                                    if (!string.IsNullOrEmpty(attribute) && regex.IsMatch(attribute))
                                    {
                                        A_1.Brightness = float.Parse(attribute.Replace(BookmarkStart.b("ส", num), string.Empty), NumberStyles.Float, CultureInfo.InvariantCulture);
                                    }
                                    else if (!string.IsNullOrEmpty(attribute) && regex2.IsMatch(attribute))
                                    {
                                        A_1.Brightness = float.Parse(attribute, NumberStyles.Float, CultureInfo.InvariantCulture) / 1000f;
                                    }
                                    string str = reader.GetAttribute(BookmarkStart.b("䠪䈬䄮䔰䄲吴䐶䴸", num));
                                    if (!string.IsNullOrEmpty(str) && regex.IsMatch(str))
                                    {
                                        A_1.Contrast = float.Parse(str.Replace(BookmarkStart.b("ส", num), string.Empty), NumberStyles.Float, CultureInfo.InvariantCulture);
                                    }
                                    else if (!string.IsNullOrEmpty(str) && regex2.IsMatch(str))
                                    {
                                        A_1.Contrast = float.Parse(str, NumberStyles.Float, CultureInfo.InvariantCulture) / 1000f;
                                    }
                                }
                            }
                            else
                            {
                                A_1.Color = PictureColor.BlackAndWhite;
                            }
                        }
                        else
                        {
                            A_1.Color = PictureColor.Grayscale;
                        }
                    }
                    else
                    {
                        string str4 = reader.GetAttribute(BookmarkStart.b("䨪䀬嬮", num));
                        if (!string.IsNullOrEmpty(str4))
                        {
                            A_1.AlphaModFix = float.Parse(str4, NumberStyles.Float, CultureInfo.InvariantCulture) / 1000f;
                        }
                    }
                }
                reader.Read();
                this.method_485(reader);
            }
        }
    }

    private void method_251(MemoryStream A_0, IDocumentObject A_1)
    {
        int num = 6;
        XmlReader reader = Class57.smethod_18(A_0);
        if (((A_1 is DocPicture) && this.method_247(reader, BookmarkStart.b("伫䈭䈯昱嬳", num), BookmarkStart.b("䴫", num))) && this.method_247(reader, BookmarkStart.b("弫尭圯倱眳娵䨷", num), BookmarkStart.b("䴫", num)))
        {
            string attribute = reader.GetAttribute(BookmarkStart.b("娫伭尯", num));
            (A_1 as DocPicture).ChromaKey = this.method_474(attribute);
        }
    }

    private void method_252(MemoryStream A_0, IDocumentObject A_1)
    {
        int num = 0x10;
        XmlReader reader = Class57.smethod_18(A_0);
        if ((A_1 is DocPicture) && (reader.LocalName == BookmarkStart.b("娵䴷圹", num)))
        {
            Regex regex = new Regex(BookmarkStart.b("ᬵܷሹᐻ༽瀿牁浃㩅恇ᅉ籋捍楏དན晕畗捙ś慝䥟䭡䱣㩥䙧ㅩ屫䍭䥯⽱⽳䙵啷䍹ⅻ䅽꥿북ꆃ", num));
            Regex regex2 = new Regex(BookmarkStart.b("ᬵܷ昹堻ᨽ", num));
            string attribute = reader.GetAttribute(BookmarkStart.b("吵䨷匹嬻嘽㐿", num));
            if (!string.IsNullOrEmpty(attribute) && regex.IsMatch(attribute))
            {
                (A_1 as DocPicture).Brightness = float.Parse(attribute.Replace(BookmarkStart.b("ጵ", num), string.Empty), NumberStyles.Float, CultureInfo.InvariantCulture);
            }
            else if (!string.IsNullOrEmpty(attribute) && regex2.IsMatch(attribute))
            {
                (A_1 as DocPicture).Brightness = float.Parse(attribute, NumberStyles.Float, CultureInfo.InvariantCulture) / 1000f;
            }
            string str2 = reader.GetAttribute(BookmarkStart.b("唵圷吹䠻䰽ℿㅁぃ", num));
            if (!string.IsNullOrEmpty(str2) && regex.IsMatch(str2))
            {
                (A_1 as DocPicture).Contrast = float.Parse(str2.Replace(BookmarkStart.b("ጵ", num), string.Empty), NumberStyles.Float, CultureInfo.InvariantCulture);
            }
            else if (!string.IsNullOrEmpty(str2) && regex2.IsMatch(str2))
            {
                (A_1 as DocPicture).Contrast = float.Parse(str2, NumberStyles.Float, CultureInfo.InvariantCulture) / 1000f;
            }
        }
    }

    private bool method_253(XmlReader A_0, ParagraphItemCollection A_1)
    {
        this.method_247(A_0, BookmarkStart.b("䜮崰娲嬴尶稸场吼尾⩀", 9), BookmarkStart.b("丮", 9));
        if (A_0.LocalName == BookmarkStart.b("䜮崰娲嬴尶稸场吼尾⩀", 9))
        {
            this.method_130(A_0, A_1);
            return true;
        }
        return false;
    }

    private Image method_254(string A_0)
    {
        int num = 10;
        if (string.IsNullOrEmpty(A_0))
        {
            return null;
        }
        Image image = null;
        try
        {
            if (!A_0.StartsWith(BookmarkStart.b("堯䘱䀳䘵", num)) && !A_0.StartsWith(BookmarkStart.b("䜯䔱䌳", num)))
            {
                if (A_0.StartsWith(BookmarkStart.b("嘯嬱堳匵ȷᔹጻ", num)))
                {
                    string[] strArray = A_0.Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries);
                    if (strArray.Length == 2)
                    {
                        A_0 = strArray[1].Replace(BookmarkStart.b("ᔯ1г", num), BookmarkStart.b("ု", num));
                    }
                }
                return Image.FromFile(A_0);
            }
            HttpWebRequest request = (HttpWebRequest) WebRequest.Create(A_0);
            request.AllowWriteStreamBuffering = true;
            WebResponse response = request.GetResponse();
            image = Image.FromStream(response.GetResponseStream());
            response.Close();
        }
        catch
        {
            new FileLoadException(BookmarkStart.b("猯匱娳ᄵ䰷ᨹ倻儽ℿ♁摃⽅╇⭉⭋⭍籏牑㭓㡕硗⹙㑛㝝፟䉡ᅣᑥѧ偩䱫", num) + A_0);
        }
        return image;
    }

    private void method_255(Stream A_0, Class6 A_1)
    {
        int num = 3;
        A_0.Position = 0L;
        XmlReader reader = Class57.smethod_18(A_0);
        if (this.method_247(reader, BookmarkStart.b("䬨䜪䐬弮眰娲头嬶", 3), BookmarkStart.b("䠨", 3)) && this.method_247(reader, BookmarkStart.b("娨弪弬䨮䔰倲崴", num), BookmarkStart.b("䠨", num)))
        {
            string localName = reader.LocalName;
            reader.Read();
            this.method_485(reader);
            while (reader.LocalName != localName)
            {
                if (reader.NodeType == XmlNodeType.Element)
                {
                    if (reader.LocalName == BookmarkStart.b("伨䈪䄬䌮挰嘲嘴䌶", num))
                    {
                        Struct36 struct2 = new Struct36();
                        string attribute = reader.GetAttribute(BookmarkStart.b("崨", num));
                        string str4 = reader.GetAttribute(BookmarkStart.b("䬨", num));
                        string str2 = reader.GetAttribute(BookmarkStart.b("䔨", num));
                        string str = reader.GetAttribute(BookmarkStart.b("嬨", num));
                        if (!string.IsNullOrEmpty(attribute))
                        {
                            struct2.float_0 = float.Parse(attribute, NumberStyles.Float, CultureInfo.CurrentCulture) / 1000f;
                        }
                        if (!string.IsNullOrEmpty(str4))
                        {
                            struct2.float_1 = float.Parse(str4, NumberStyles.Float, CultureInfo.CurrentCulture) / 1000f;
                        }
                        if (!string.IsNullOrEmpty(str2))
                        {
                            struct2.float_2 = float.Parse(str2, NumberStyles.Float, CultureInfo.CurrentCulture) / 1000f;
                        }
                        if (!string.IsNullOrEmpty(str))
                        {
                            struct2.float_3 = float.Parse(str, NumberStyles.Float, CultureInfo.CurrentCulture) / 1000f;
                        }
                        A_1.method_39(struct2);
                        return;
                    }
                    reader.Read();
                }
            }
        }
    }

    private void method_256(Stream A_0, Class6 A_1)
    {
        int num = 0x11;
        A_0.Position = 0L;
        XmlReader reader = Class57.smethod_18(A_0);
        if (this.method_247(reader, BookmarkStart.b("唶唸刺䴼社⡀⽂⥄", 0x11), BookmarkStart.b("嘶", 0x11)) && this.method_247(reader, BookmarkStart.b("䌶倸场堼", num), BookmarkStart.b("嘶", num)))
        {
            A_1.method_35(true);
            Struct37 struct2 = new Struct37(100f, 100f);
            string attribute = reader.GetAttribute(BookmarkStart.b("䌶䄸", num));
            string str5 = reader.GetAttribute(BookmarkStart.b("䌶䀸", num));
            string str6 = reader.GetAttribute(BookmarkStart.b("䐶䄸", num));
            string str2 = reader.GetAttribute(BookmarkStart.b("䐶䀸", num));
            string str = reader.GetAttribute(BookmarkStart.b("儶唸刺䴼", num));
            string str3 = reader.GetAttribute(BookmarkStart.b("嘶唸尺匼", num));
            if (!string.IsNullOrEmpty(attribute))
            {
                struct2.float_2 = float.Parse(attribute, NumberStyles.Float, CultureInfo.CurrentCulture) / 12700f;
            }
            if (!string.IsNullOrEmpty(str5))
            {
                struct2.float_3 = float.Parse(str5, NumberStyles.Float, CultureInfo.CurrentCulture) / 12700f;
            }
            if (!string.IsNullOrEmpty(str6))
            {
                struct2.float_0 = float.Parse(str6, NumberStyles.Float, CultureInfo.CurrentCulture) / 1000f;
            }
            if (!string.IsNullOrEmpty(str2))
            {
                struct2.float_1 = float.Parse(str2, NumberStyles.Float, CultureInfo.CurrentCulture) / 1000f;
            }
            if (!string.IsNullOrEmpty(str))
            {
                struct2.flipOrientation_0 = Class1085.smethod_67(str);
            }
            if (!string.IsNullOrEmpty(str3))
            {
                struct2.rectAlignment_0 = Class1085.smethod_69(str3);
            }
            A_1.method_37(struct2);
        }
    }

    private Class6 method_257(Stream A_0)
    {
        return this.method_258(A_0, false);
    }

    private Class6 method_258(Stream A_0, bool A_1)
    {
        int num = 13;
        Class6 class2 = new Class6(A_0, this.document_0);
        class2.method_46(this.characterFormat_0);
        List<string> list = this.method_261(A_0);
        if ((list.Count > 0) && (this.dictionary_2 != null))
        {
            this.method_262(class2, list);
            int num2 = 0;
            int count = list.Count;
            while (num2 < count)
            {
                string str = list[num2];
                if (!this.method_260(class2, str))
                {
                    DictionaryEntry entry = new DictionaryEntry();
                    if ((this.string_3 != null) && (this.string_3 != string.Empty))
                    {
                        Dictionary<string, DictionaryEntry> dictionary = this.method_466(this.string_3);
                        if (dictionary != null)
                        {
                            entry = dictionary[str];
                        }
                    }
                    else if (this.dictionary_2.ContainsKey(str))
                    {
                        entry = this.dictionary_2[str];
                    }
                    if (!class2.method_41().ContainsKey(str))
                    {
                        class2.method_41().Add(str, entry);
                    }
                }
                num2++;
            }
            XmlReader reader = Class57.smethod_18(A_0);
            if (class2.method_40().Count <= 0)
            {
                return class2;
            }
            if ((!A_1 && this.method_247(reader, BookmarkStart.b("䀲崴嘶䤸帺", num), BookmarkStart.b("䔲", num))) && (reader.LocalName == BookmarkStart.b("䀲崴嘶䤸帺", num)))
            {
                MemoryStream stream = this.method_484(reader);
                if (this.method_244(stream) == DocxParserShapeType.PictureShape)
                {
                    DocPicture picture = new DocPicture(this.document_0);
                    stream.Position = 0L;
                    XmlReader reader2 = Class57.smethod_18(stream);
                    this.method_205(reader2, picture);
                    DocPicture picture2 = picture;
                    picture2.IsShape = true;
                    this.method_202(reader2, picture);
                    class2.method_31(picture2);
                }
            }
            this.method_255(A_0, class2);
            this.method_256(A_0, class2);
        }
        return class2;
    }

    private Class6 method_259(XmlReader A_0, Stream A_1)
    {
        int num = 0x10;
        Class6 class2 = new Class6(A_1, this.document_0);
        class2.method_46(this.characterFormat_0);
        List<string> list = this.method_261(A_1);
        if ((list.Count > 0) && (this.dictionary_2 != null))
        {
            this.method_262(class2, list);
            int num2 = 0;
            int count = list.Count;
            while (num2 < count)
            {
                string str = list[num2];
                if (!this.method_260(class2, str))
                {
                    DictionaryEntry entry = new DictionaryEntry();
                    if ((this.string_3 != null) && (this.string_3 != string.Empty))
                    {
                        Dictionary<string, DictionaryEntry> dictionary = this.method_466(this.string_3);
                        if (dictionary != null)
                        {
                            entry = dictionary[str];
                        }
                    }
                    else if (this.dictionary_2.ContainsKey(str))
                    {
                        entry = this.dictionary_2[str];
                    }
                    if (!class2.method_41().ContainsKey(str))
                    {
                        class2.method_41().Add(str, entry);
                    }
                }
                num2++;
            }
        }
        if (((class2.method_40().Count > 0) && this.method_247(A_0, BookmarkStart.b("䔵倷嬹䰻嬽", num), BookmarkStart.b("䀵", num))) && (A_0.LocalName == BookmarkStart.b("䔵倷嬹䰻嬽", num)))
        {
            MemoryStream stream = this.method_484(A_0);
            if (this.method_244(stream) == DocxParserShapeType.PictureShape)
            {
                DocPicture picture = new DocPicture(this.document_0);
                stream.Position = 0L;
                XmlReader reader = Class57.smethod_18(stream);
                this.method_205(reader, picture);
                DocPicture picture2 = picture;
                picture2.IsShape = true;
                this.method_202(reader, picture);
                class2.method_31(picture2);
            }
        }
        return class2;
    }

    internal Document method_26(Stream A_0, Document A_1)
    {
        this.class771_0 = new Class771();
        if (A_1.method_155(A_0))
        {
            Stream stream = this.method_30(A_0, A_1);
            this.class771_0.method_27(stream, false);
        }
        else
        {
            this.class771_0.method_27(A_0, false);
        }
        this.document_0 = A_1;
        this.method_31(A_1);
        return A_1;
    }

    private bool method_260(Class6 A_0, string A_1)
    {
        int num = 15;
        Class517 class2 = null;
        bool flag = this.string_3.StartsWith(BookmarkStart.b("崴制堸强堼䴾", 15)) || this.string_3.StartsWith(BookmarkStart.b("匴堶嘸伺堼䴾", num));
        string key = this.method_459(A_1, flag, false);
        if (this.method_0().ContainsKey(key))
        {
            class2 = this.document_0.Images.method_0(this.method_0()[key]);
            class2.method_6(class2.method_5() + 1);
        }
        else
        {
            byte[] buffer = this.method_460(key);
            if ((buffer != null) && (buffer.Length > 0))
            {
                class2 = this.document_0.Images.method_7(buffer);
                this.method_0().Add(key, class2.method_0());
            }
            buffer = null;
        }
        if ((class2 != null) && !A_0.method_40().ContainsKey(A_1))
        {
            A_0.method_40().Add(A_1, class2);
        }
        return (class2 != null);
    }

    private List<string> method_261(Stream A_0)
    {
        int num = 11;
        A_0.Position = 0L;
        XmlReader reader = Class57.smethod_18(A_0);
        List<string> list = new List<string>();
        bool flag = false;
        while (true)
        {
            flag = false;
            reader.Read();
            string attribute = string.Empty;
            string item = string.Empty;
            string localName = reader.LocalName;
            if (localName != null)
            {
                int num2;
                if (Class1160.dictionary_74 == null)
                {
                    Dictionary<string, int> dictionary1 = new Dictionary<string, int>(9);
                    dictionary1.Add(BookmarkStart.b("地娲头嬶", num), 0);
                    dictionary1.Add(BookmarkStart.b("到嬲吴䔶䴸", num), 1);
                    dictionary1.Add(BookmarkStart.b("堰帲吴倶尸强尼䬾⁀", num), 2);
                    dictionary1.Add(BookmarkStart.b("䈰䜲䜴堶券帺", num), 3);
                    dictionary1.Add(BookmarkStart.b("到尲嬴䌶䬸吺儼", num), 4);
                    dictionary1.Add(BookmarkStart.b("縰缲瀴砶嬸儺堼尾㕀", num), 5);
                    dictionary1.Add(BookmarkStart.b("夰䨲䔴制䬸场吼儾⩀", num), 6);
                    dictionary1.Add(BookmarkStart.b("匰弲尴䜶", num), 7);
                    dictionary1.Add(BookmarkStart.b("䌰嘲头縶崸䠺", num), 8);
                    Class1160.dictionary_74 = dictionary1;
                }
                if (Class1160.dictionary_74.TryGetValue(localName, out num2))
                {
                    switch (num2)
                    {
                        case 0:
                        case 1:
                        case 2:
                        case 3:
                        case 4:
                        case 5:
                        case 6:
                            attribute = reader.GetAttribute(BookmarkStart.b("堰圲", num), this.dictionary_18[BookmarkStart.b("䌰", num)]);
                            item = reader.GetAttribute(BookmarkStart.b("夰䄲倴儶", num), this.dictionary_18[BookmarkStart.b("䌰", num)]);
                            break;

                        case 7:
                            attribute = reader.GetAttribute(BookmarkStart.b("吰帲圴制崸", num), this.dictionary_18[BookmarkStart.b("䌰", num)]);
                            break;

                        case 8:
                            attribute = reader.GetAttribute(BookmarkStart.b("唰帲", num), this.dictionary_18[BookmarkStart.b("䌰", num)]);
                            if (!string.IsNullOrEmpty(attribute))
                            {
                                list.Add(attribute);
                            }
                            attribute = reader.GetAttribute(BookmarkStart.b("崰尲", num), this.dictionary_18[BookmarkStart.b("䌰", num)]);
                            if (!string.IsNullOrEmpty(attribute))
                            {
                                list.Add(attribute);
                            }
                            attribute = reader.GetAttribute(BookmarkStart.b("䀰䀲", num), this.dictionary_18[BookmarkStart.b("䌰", num)]);
                            if (!string.IsNullOrEmpty(attribute))
                            {
                                list.Add(attribute);
                            }
                            attribute = reader.GetAttribute(BookmarkStart.b("到䀲", num), this.dictionary_18[BookmarkStart.b("䌰", num)]);
                            if (!string.IsNullOrEmpty(attribute))
                            {
                                list.Add(attribute);
                            }
                            flag = true;
                            break;
                    }
                }
            }
            if (((attribute != null) && (attribute != string.Empty)) && !flag)
            {
                list.Add(attribute);
            }
            if ((item != null) && (item != string.Empty))
            {
                list.Add(item);
            }
            if (reader.EOF)
            {
                return list;
            }
        }
    }

    private void method_262(Class6 A_0, List<string> A_1)
    {
        int num = 0;
        int count = A_1.Count;
        while (num < count)
        {
            string key = A_1[num];
            if (this.method_18().ContainsKey(key))
            {
                A_0.string_8 = key;
            }
            num++;
        }
    }

    private ParagraphBase method_263(XmlReader A_0, DocPicture A_1)
    {
        if (this.characterFormat_0 != null)
        {
            A_1.CharacterFormat.ImportContainer(this.characterFormat_0);
        }
        this.characterFormat_0 = null;
        this.method_264(A_0, A_1);
        return A_1;
    }

    private void method_264(XmlReader A_0, DocPicture A_1)
    {
        int num = 10;
        while (A_0.NodeType != XmlNodeType.Element)
        {
            A_0.Read();
        }
        if (A_0.LocalName != BookmarkStart.b("启䀱唳䄵儷吹嬻", num))
        {
            throw new XmlException(BookmarkStart.b("支就儳丵䠷弹弻䨽┿♁摃㹅╇♉汋㩍ㅏ㕑瑓", num) + A_0.LocalName);
        }
        if (!A_0.IsEmptyElement)
        {
            string localName = A_0.LocalName;
            bool flag = false;
            int num2 = 0x319c;
            A_0.Read();
            this.method_485(A_0);
            A_1.LockAspectRatio = false;
            while (true)
            {
                if (!(A_0.LocalName != localName) || A_0.EOF)
                {
                    return;
                }
                flag = false;
                if (A_0.NodeType != XmlNodeType.Element)
                {
                    A_0.Read();
                }
                else
                {
                    string key = A_0.LocalName;
                    if (key != null)
                    {
                        int num3;
                        if (Class1160.dictionary_75 == null)
                        {
                            Dictionary<string, int> dictionary1 = new Dictionary<string, int>(15);
                            dictionary1.Add(BookmarkStart.b("唯吱刳匵嬷丹礻䘽㐿❁⩃㉅", num), 0);
                            dictionary1.Add(BookmarkStart.b("唯䨱䀳匵嘷丹", num), 1);
                            dictionary1.Add(BookmarkStart.b("䀯崱䜳張䰷匹医倽࠿", num), 2);
                            dictionary1.Add(BookmarkStart.b("䀯崱䜳張䰷匹医倽ᘿ", num), 3);
                            dictionary1.Add(BookmarkStart.b("启崱圳昵䨷", num), 4);
                            dictionary1.Add(BookmarkStart.b("䜯䀱唳䘵欷䬹䤻弽㈿❁", num), 5);
                            dictionary1.Add(BookmarkStart.b("䜯䀱唳䘵氷匹嬻嘽㐿", num), 6);
                            dictionary1.Add(BookmarkStart.b("䜯䀱唳䘵氷刹主儽㔿╁ⱃ", num), 7);
                            dictionary1.Add(BookmarkStart.b("䜯䀱唳䘵氷唹䰻缽⸿♁ك⥅㱇㹉⍋⍍", num), 8);
                            dictionary1.Add(BookmarkStart.b("䜯䀱唳䘵瘷唹刻嬽", num), 9);
                            dictionary1.Add(BookmarkStart.b("儯就圳帵圷䠹", num), 10);
                            dictionary1.Add(BookmarkStart.b("匯簱䈳焵䨷嬹䰻嘽⤿⅁Ƀ㑅⥇❉⥋ṍ≏", num), 11);
                            dictionary1.Add(BookmarkStart.b("䌯嬱丳匵樷弹倻瘽", num), 12);
                            dictionary1.Add(BookmarkStart.b("䌯嬱丳匵樷弹倻栽", num), 13);
                            dictionary1.Add(BookmarkStart.b("圯䀱唳䘵倷匹弻", num), 14);
                            Class1160.dictionary_75 = dictionary1;
                        }
                        if (Class1160.dictionary_75.TryGetValue(key, out num3))
                        {
                            string str7;
                            switch (num3)
                            {
                                case 0:
                                {
                                    string attribute = A_0.GetAttribute(BookmarkStart.b("尯", num));
                                    string str4 = A_0.GetAttribute(BookmarkStart.b("䐯", num));
                                    string str5 = A_0.GetAttribute(BookmarkStart.b("䈯", num));
                                    string str6 = A_0.GetAttribute(BookmarkStart.b("刯", num));
                                    if (!string.IsNullOrEmpty(attribute))
                                    {
                                        A_1.EffectExtentLeft = float.Parse(attribute) / ((float) num2);
                                    }
                                    if (!string.IsNullOrEmpty(str4))
                                    {
                                        A_1.EffectExtentTop = float.Parse(str4) / ((float) num2);
                                    }
                                    if (!string.IsNullOrEmpty(str5))
                                    {
                                        A_1.EffectExtentRight = float.Parse(str5) / ((float) num2);
                                    }
                                    if (!string.IsNullOrEmpty(str6))
                                    {
                                        A_1.EffectExtentBottom = float.Parse(str6) / ((float) num2);
                                    }
                                    break;
                                }
                                case 1:
                                    str7 = A_0.GetAttribute(BookmarkStart.b("匯䨱", num));
                                    if (str7 != null)
                                    {
                                        if ((!A_1.ShapePr.HasKey(0x1023) || float.IsNegativeInfinity(A_1.Width)) || (float.IsPositiveInfinity(A_1.Width) || float.IsNaN(A_1.Width)))
                                        {
                                            A_1.Width = float.Parse(str7) / ((float) num2);
                                        }
                                        else
                                        {
                                            A_1.method_81(((float.Parse(str7) / ((float) num2)) * 100f) / A_1.Width);
                                        }
                                    }
                                    str7 = A_0.GetAttribute(BookmarkStart.b("匯䬱", num));
                                    if (str7 != null)
                                    {
                                        if ((A_1.ShapePr.HasKey(0x1024) && !float.IsNegativeInfinity(A_1.Height)) && (!float.IsPositiveInfinity(A_1.Height) && !float.IsNaN(A_1.Height)))
                                        {
                                            A_1.method_80(((float.Parse(str7) / ((float) num2)) * 100f) / A_1.Height);
                                        }
                                        else
                                        {
                                            A_1.Height = float.Parse(str7) / ((float) num2);
                                        }
                                    }
                                    break;

                                case 2:
                                    this.method_276(A_0, A_1);
                                    break;

                                case 3:
                                    this.method_282(A_0, A_1);
                                    break;

                                case 4:
                                    A_1.Title = A_0.GetAttribute(BookmarkStart.b("䐯嬱䀳娵崷", num));
                                    A_1.AlternativeText = A_0.GetAttribute(BookmarkStart.b("启圱䜳唵䨷", num));
                                    break;

                                case 5:
                                    this.method_270(A_1);
                                    A_1.TextWrappingStyle = TextWrappingStyle.Square;
                                    this.method_273(A_0, A_1);
                                    break;

                                case 6:
                                {
                                    this.method_270(A_1);
                                    A_1.TextWrappingStyle = TextWrappingStyle.Tight;
                                    this.method_273(A_0, A_1);
                                    using (MemoryStream stream = this.method_484(A_0))
                                    {
                                        bool flag2 = true;
                                        A_1.WrapPolygon = this.method_275(stream, ref flag2);
                                        A_1.IsEditWrapPolygonPoint = flag2;
                                        break;
                                    }
                                }
                                case 7:
                                {
                                    this.method_270(A_1);
                                    A_1.TextWrappingStyle = TextWrappingStyle.Through;
                                    this.method_273(A_0, A_1);
                                    using (MemoryStream stream2 = this.method_484(A_0))
                                    {
                                        bool flag3 = true;
                                        A_1.WrapPolygon = this.method_275(stream2, ref flag3);
                                        A_1.IsEditWrapPolygonPoint = flag3;
                                        break;
                                    }
                                }
                                case 8:
                                    this.method_270(A_1);
                                    A_1.TextWrappingStyle = TextWrappingStyle.TopAndBottom;
                                    break;

                                case 9:
                                    if (!A_1.IsUnderText)
                                    {
                                        A_1.TextWrappingStyle = TextWrappingStyle.InFrontOfText;
                                        break;
                                    }
                                    A_1.TextWrappingStyle = TextWrappingStyle.Behind;
                                    break;

                                case 10:
                                    if (A_0.AttributeCount != 0)
                                    {
                                        str7 = A_0.GetAttribute(BookmarkStart.b("启嬱䜳䈵氷", num));
                                        if (!string.IsNullOrEmpty(str7))
                                        {
                                            A_1.WrapDistanceTop = float.Parse(str7) / 12700f;
                                        }
                                        str7 = A_0.GetAttribute(BookmarkStart.b("启嬱䜳䈵稷", num));
                                        if (!string.IsNullOrEmpty(str7))
                                        {
                                            A_1.WrapDistanceBottom = float.Parse(str7) / 12700f;
                                        }
                                        str7 = A_0.GetAttribute(BookmarkStart.b("启嬱䜳䈵琷", num));
                                        if (!string.IsNullOrEmpty(str7))
                                        {
                                            A_1.WrapDistanceLeft = float.Parse(str7) / 12700f;
                                        }
                                        str7 = A_0.GetAttribute(BookmarkStart.b("启嬱䜳䈵樷", num));
                                        if (!string.IsNullOrEmpty(str7))
                                        {
                                            A_1.WrapDistanceRight = float.Parse(str7) / 12700f;
                                        }
                                        str7 = A_0.GetAttribute(BookmarkStart.b("刯圱尳張嘷帹砻儽⌿", num));
                                        if (!string.IsNullOrEmpty(str7))
                                        {
                                            A_1.IsUnderText = (str7 == BookmarkStart.b("į", num)) || (str7 == BookmarkStart.b("䐯䀱䄳匵", num));
                                        }
                                        str7 = A_0.GetAttribute(BookmarkStart.b("䈯圱堳圵䰷匹䨻嬽࠿❁ⵃⅅ⁇㹉", num));
                                        if (!string.IsNullOrEmpty(str7))
                                        {
                                            A_1.OrderIndex = int.Parse(str7);
                                        }
                                        str7 = A_0.GetAttribute(BookmarkStart.b("尯匱䴳夵䴷丹画倽̿❁⡃⩅", num));
                                        if (!string.IsNullOrEmpty(str7))
                                        {
                                            A_1.LayoutInCell = (str7 == BookmarkStart.b("į", num)) || (str7 == BookmarkStart.b("䐯䀱䄳匵", num));
                                        }
                                        str7 = A_0.GetAttribute(BookmarkStart.b("儯帱堳夵伷甹䨻嬽㈿⹁╃㙅", num));
                                        if (!string.IsNullOrEmpty(str7))
                                        {
                                            A_1.AllowOverlap = (str7 == BookmarkStart.b("į", num)) || (str7 == BookmarkStart.b("䐯䀱䄳匵", num));
                                        }
                                    }
                                    break;

                                case 11:
                                    this.method_269(A_0, A_1);
                                    break;

                                case 12:
                                    this.method_271(A_0, A_1);
                                    break;

                                case 13:
                                    this.method_272(A_0, A_1);
                                    break;

                                case 14:
                                    this.method_265(A_0, A_1);
                                    break;
                            }
                        }
                    }
                    if (!flag)
                    {
                        A_0.Read();
                    }
                }
                this.method_485(A_0);
            }
        }
    }

    private void method_265(XmlReader A_0, DocPicture A_1)
    {
        int num = 8;
        if (A_0.LocalName != BookmarkStart.b("䤭䈯匱䐳帵儷夹", 8))
        {
            throw new XmlException(BookmarkStart.b("䤭䈯匱䐳帵儷夹", num));
        }
        if (!A_0.IsEmptyElement)
        {
            string localName = A_0.LocalName;
            bool flag = false;
            A_0.Read();
            this.method_485(A_0);
            while (A_0.LocalName != localName)
            {
                if (A_0.EOF)
                {
                    break;
                }
                flag = false;
                if (A_0.NodeType == XmlNodeType.Element)
                {
                    string str2;
                    if (((str2 = A_0.LocalName) != null) && (str2 == BookmarkStart.b("䤭䈯匱䐳帵儷夹砻弽㐿⍁", num)))
                    {
                        this.method_266(A_0, A_1);
                    }
                    if (!flag)
                    {
                        A_0.Read();
                    }
                }
                else
                {
                    A_0.Read();
                }
                this.method_485(A_0);
            }
        }
    }

    private void method_266(XmlReader A_0, DocPicture A_1)
    {
        int num = 4;
        if (A_0.LocalName != BookmarkStart.b("䴩師伭䀯娱崳唵簷嬹䠻弽", 4))
        {
            throw new XmlException(BookmarkStart.b("䴩師伭䀯娱崳唵簷嬹䠻弽", num));
        }
        if (!A_0.IsEmptyElement)
        {
            string localName = A_0.LocalName;
            bool flag = false;
            A_0.Read();
            this.method_485(A_0);
            while (A_0.LocalName != localName)
            {
                if (A_0.EOF)
                {
                    break;
                }
                flag = false;
                if (A_0.NodeType == XmlNodeType.Element)
                {
                    string str2;
                    if (((str2 = A_0.LocalName) != null) && (str2 == BookmarkStart.b("娩䔫䴭", num)))
                    {
                        this.method_267(A_0, A_1);
                    }
                    if (!flag)
                    {
                        A_0.Read();
                    }
                }
                else
                {
                    A_0.Read();
                }
                this.method_485(A_0);
            }
        }
    }

    private void method_267(XmlReader A_0, DocPicture A_1)
    {
        int num = 6;
        if (A_0.LocalName != BookmarkStart.b("尫䜭匯", 6))
        {
            throw new XmlException(BookmarkStart.b("尫䜭匯", num));
        }
        if (!A_0.IsEmptyElement)
        {
            string localName = A_0.LocalName;
            bool flag = false;
            A_0.Read();
            this.method_485(A_0);
            while (A_0.LocalName != localName)
            {
                if (A_0.EOF)
                {
                    break;
                }
                flag = false;
                if (A_0.NodeType == XmlNodeType.Element)
                {
                    string str2;
                    if (((str2 = A_0.LocalName) != null) && (str2 == BookmarkStart.b("䈫堭怯嬱圳昵䨷", num)))
                    {
                        this.method_268(A_0, A_1);
                    }
                    if (!flag)
                    {
                        A_0.Read();
                    }
                }
                else
                {
                    A_0.Read();
                }
                this.method_485(A_0);
            }
        }
    }

    private void method_268(XmlReader A_0, DocPicture A_1)
    {
        int num = 0x11;
        if (A_0.LocalName != BookmarkStart.b("夶伸欺吼尾ᅀㅂ", 0x11))
        {
            throw new XmlException(BookmarkStart.b("夶伸欺吼尾ᅀㅂ", num));
        }
        if (!A_0.IsEmptyElement)
        {
            string localName = A_0.LocalName;
            bool flag = false;
            A_0.Read();
            this.method_485(A_0);
            while (A_0.LocalName != localName)
            {
                if (A_0.EOF)
                {
                    break;
                }
                flag = false;
                if (A_0.NodeType == XmlNodeType.Element)
                {
                    string str3;
                    if (((str3 = A_0.LocalName) != null) && (str3 == BookmarkStart.b("吶眸䴺洼嘾≀ፂ㝄", num)))
                    {
                        string attribute = A_0.GetAttribute(BookmarkStart.b("䜶䬸帺嬼娾㍀ᅂ⁄⭆⡈㽊⑌㥎㑐Œご⑖じ⅚㡜", num));
                        if (!string.IsNullOrEmpty(attribute) && (attribute == BookmarkStart.b("ܶ", num)))
                        {
                            A_1.PreferRelative = false;
                        }
                    }
                    if (!flag)
                    {
                        A_0.Read();
                    }
                }
                else
                {
                    A_0.Read();
                }
                this.method_485(A_0);
            }
        }
    }

    private void method_269(XmlReader A_0, DocPicture A_1)
    {
        int num = 8;
        if (A_0.LocalName != BookmarkStart.b("䴭縯䐱猳䐵夷䨹吻圽⌿с㙃❅╇⽉᱋㱍", 8))
        {
            throw new XmlException(BookmarkStart.b("䴭縯䐱猳䐵夷䨹吻圽⌿с㙃❅╇⽉᱋㱍", num));
        }
        if (!A_0.IsEmptyElement)
        {
            string localName = A_0.LocalName;
            bool flag = false;
            A_0.Read();
            this.method_485(A_0);
            while (A_0.LocalName != localName)
            {
                if (A_0.EOF)
                {
                    break;
                }
                flag = false;
                if (A_0.NodeType == XmlNodeType.Element)
                {
                    string str3;
                    if (((str3 = A_0.LocalName) != null) && (str3 == BookmarkStart.b("䤭䈯匱䐳帵儷夹稻䰽ℿ⽁⅃੅❇⥉❋㵍", num)))
                    {
                        string attribute = A_0.GetAttribute(BookmarkStart.b("䀭弯焱尳圵嘷崹夻缽㌿㉁⅃╅㱇", num));
                        if ((attribute == null) || ((attribute != null) && (attribute == BookmarkStart.b("Ἥ", num))))
                        {
                            A_1.LockAspectRatio = true;
                        }
                    }
                    if (!flag)
                    {
                        A_0.Read();
                    }
                }
                else
                {
                    A_0.Read();
                }
                this.method_485(A_0);
            }
        }
    }

    internal Document method_27(string A_0, Document A_1)
    {
        int num = 0x12;
        if ((A_0 != null) && (A_0.Length != 0))
        {
            using (FileStream stream = new FileStream(A_0, FileMode.Open, FileAccess.Read))
            {
                return this.method_28(stream, A_1);
            }
        }
        throw new ArgumentOutOfRangeException(BookmarkStart.b("儷吹䰻䬽㐿扁Ƀ⽅⑇⽉ɋ⽍㵏㝑", num));
    }

    private void method_270(DocPicture A_0)
    {
        if ((A_0 != null) && A_0.IsUnderText)
        {
            A_0.OrderIndex = -(A_0.OrderIndex - 6L);
        }
    }

    private void method_271(XmlReader A_0, DocPicture A_1)
    {
        int num = 11;
        if (A_0.LocalName != BookmarkStart.b("䈰娲伴制欸帺儼眾", 11))
        {
            throw new XmlException(BookmarkStart.b("䈰娲伴制欸帺儼眾", num));
        }
        if (!A_0.IsEmptyElement)
        {
            string attribute = A_0.GetAttribute(BookmarkStart.b("䌰嘲头嘶䴸刺䬼娾݀ㅂ⩄⩆", num));
            if (!string.IsNullOrEmpty(attribute))
            {
                A_1.RelationWidth = this.method_280(attribute);
                string localName = A_0.LocalName;
                bool flag = false;
                A_0.Read();
                this.method_485(A_0);
                string str = null;
                while (A_0.LocalName != localName)
                {
                    if (A_0.EOF)
                    {
                        break;
                    }
                    flag = false;
                    if (A_0.NodeType == XmlNodeType.Element)
                    {
                        string str4;
                        if (((str4 = A_0.LocalName) != null) && (str4 == BookmarkStart.b("䄰倲䄴怶倸强䤼圾", num)))
                        {
                            str = A_0.ReadString();
                            if (!string.IsNullOrEmpty(str))
                            {
                                float num2 = float.Parse(str, NumberStyles.Float, CultureInfo.InvariantCulture) / 1000f;
                                A_1.WidthPercent = num2;
                            }
                        }
                        if (!flag)
                        {
                            A_0.Read();
                        }
                    }
                    else
                    {
                        A_0.Read();
                    }
                    this.method_485(A_0);
                }
            }
        }
    }

    private void method_272(XmlReader A_0, DocPicture A_1)
    {
        int num = 3;
        if (A_0.LocalName != BookmarkStart.b("娨䈪圬䨮挰嘲头愶", 3))
        {
            throw new XmlException(BookmarkStart.b("娨䈪圬䨮挰嘲头愶", num));
        }
        if (!A_0.IsEmptyElement)
        {
            string attribute = A_0.GetAttribute(BookmarkStart.b("嬨个䄬丮䔰娲䌴制缸䤺刼刾", num));
            if (!string.IsNullOrEmpty(attribute))
            {
                A_1.RelationHeight = this.method_284(attribute);
                string localName = A_0.LocalName;
                bool flag = false;
                A_0.Read();
                this.method_485(A_0);
                string str = null;
                while (A_0.LocalName != localName)
                {
                    if (A_0.EOF)
                    {
                        break;
                    }
                    flag = false;
                    if (A_0.NodeType == XmlNodeType.Element)
                    {
                        string str4;
                        if (((str4 = A_0.LocalName) != null) && (str4 == BookmarkStart.b("夨䠪夬朮吰娲刴弶䴸", num)))
                        {
                            str = A_0.ReadString();
                            if (!string.IsNullOrEmpty(str))
                            {
                                float num2 = float.Parse(str, NumberStyles.Float, CultureInfo.InvariantCulture) / 1000f;
                                A_1.HeightPercent = num2;
                            }
                        }
                        if (!flag)
                        {
                            A_0.Read();
                        }
                    }
                    else
                    {
                        A_0.Read();
                    }
                    this.method_485(A_0);
                }
            }
        }
    }

    private void method_273(XmlReader A_0, DocPicture A_1)
    {
        string str2;
        int num = 15;
        string attribute = A_0.GetAttribute(BookmarkStart.b("䈴䔶堸䬺椼娾㥀㝂", 15));
        if (!string.IsNullOrEmpty(attribute) && ((str2 = attribute) != null))
        {
            if (str2 == BookmarkStart.b("圴堶䴸区渼嘾╀♂㙄", num))
            {
                A_1.TextWrappingType = TextWrappingType.Both;
            }
            else if (str2 == BookmarkStart.b("头制弸伺", num))
            {
                A_1.TextWrappingType = TextWrappingType.Left;
            }
            else if (str2 == BookmarkStart.b("䜴帶常区䤼", num))
            {
                A_1.TextWrappingType = TextWrappingType.Right;
            }
            else if (str2 == BookmarkStart.b("头嘶䬸尺堼䰾㕀", num))
            {
                A_1.TextWrappingType = TextWrappingType.Largest;
            }
        }
    }

    private TextWrappingType method_274(XmlReader A_0)
    {
        int num = 8;
        string attribute = A_0.GetAttribute(BookmarkStart.b("夭䈯匱䐳戵崷䈹䠻", 8));
        if (attribute != null)
        {
            if (attribute == BookmarkStart.b("䈭唯吱䀳", num))
            {
                return TextWrappingType.Left;
            }
            if (attribute == BookmarkStart.b("尭夯唱尳䈵", num))
            {
                return TextWrappingType.Right;
            }
            if (attribute == BookmarkStart.b("䈭儯䀱匳匵䬷丹", num))
            {
                return TextWrappingType.Largest;
            }
            if (attribute == BookmarkStart.b("䰭弯䘱尳攵儷帹夻䴽", num))
            {
            }
        }
        return TextWrappingType.Both;
    }

    private Class891[] method_275(MemoryStream A_0, ref bool A_1)
    {
        int num = 0x13;
        XmlReader reader = Class57.smethod_18(A_0);
        if (reader.IsEmptyElement)
        {
            return null;
        }
        string localName = reader.LocalName;
        reader.Read();
        this.method_485(reader);
        if (reader.IsEmptyElement)
        {
            return null;
        }
        if (reader.LocalName == BookmarkStart.b("丸䤺尼伾ᅀⱂ⥄㹆⹈⑊⍌", num))
        {
            string attribute = reader.GetAttribute(BookmarkStart.b("尸强吼䬾⑀❂", num));
            if (!string.IsNullOrEmpty(attribute) && ((attribute == BookmarkStart.b("स", num)) || (attribute == BookmarkStart.b("弸", num))))
            {
                A_1 = false;
            }
            else
            {
                A_1 = true;
            }
        }
        Class891[] classArray2 = new Class891[50];
        int index = 0;
        while (reader.NodeType != XmlNodeType.EndElement)
        {
            if (!(reader.LocalName != localName))
            {
                break;
            }
            if (reader.NodeType == XmlNodeType.Element)
            {
                string str4;
                if (((str4 = reader.LocalName) != null) && ((str4 == BookmarkStart.b("䨸伺尼䴾㕀", num)) || (str4 == BookmarkStart.b("唸刺匼娾ᕀⱂ", num))))
                {
                    string str = reader.GetAttribute(BookmarkStart.b("䄸", num));
                    string str2 = reader.GetAttribute(BookmarkStart.b("䀸", num));
                    if (!string.IsNullOrEmpty(str) && !string.IsNullOrEmpty(str2))
                    {
                        classArray2[index] = new Class891(new Class623(int.Parse(str, NumberStyles.Float, CultureInfo.InvariantCulture), false), new Class623(int.Parse(str2, NumberStyles.Float, CultureInfo.InvariantCulture), false));
                        index++;
                    }
                }
                reader.Read();
            }
            else
            {
                reader.Read();
            }
            this.method_485(reader);
        }
        if (index <= 0)
        {
            return null;
        }
        Class891[] classArray = new Class891[index];
        for (int i = 0; i < index; i++)
        {
            classArray[i] = classArray2[i];
        }
        return classArray;
    }

    private void method_276(XmlReader A_0, DocPicture A_1)
    {
        int num = 14;
        if (A_0.LocalName != BookmarkStart.b("䐳夵䬷匹䠻圽⼿ⱁృ", 14))
        {
            throw new XmlException(BookmarkStart.b("䐳夵䬷匹䠻圽⼿ⱁృ", num));
        }
        if (!A_0.IsEmptyElement)
        {
            string localName = A_0.LocalName;
            bool flag = false;
            string attribute = A_0.GetAttribute(BookmarkStart.b("䘳匵吷嬹䠻圽㘿❁Ƀ㑅❇❉", num));
            if (attribute != null)
            {
                A_1.HorizontalOrigin = this.method_280(attribute);
            }
            A_0.Read();
            this.method_485(A_0);
            while (A_0.LocalName != localName)
            {
                if (A_0.EOF)
                {
                    break;
                }
                flag = false;
                if (A_0.NodeType == XmlNodeType.Element)
                {
                    string str3 = A_0.LocalName;
                    if (str3 != null)
                    {
                        if (!(str3 == BookmarkStart.b("唳娵儷崹刻", num)))
                        {
                            if (str3 == BookmarkStart.b("䐳夵䬷甹娻堽㌿❁ぃ", num))
                            {
                                float maxValue = float.MaxValue;
                                maxValue = float.Parse(A_0.ReadString());
                                if (maxValue != float.MaxValue)
                                {
                                    A_1.HorizontalPosition = maxValue / 12700f;
                                }
                            }
                        }
                        else
                        {
                            string str = A_0.ReadString();
                            if (str != null)
                            {
                                A_1.HorizontalAlignment = this.method_279(str);
                            }
                        }
                    }
                    if (!flag)
                    {
                        A_0.Read();
                    }
                }
                else
                {
                    A_0.Read();
                }
                this.method_485(A_0);
            }
        }
    }

    private void method_277(XmlReader A_0, TextBox A_1)
    {
        int num = 7;
        if (A_0.LocalName != BookmarkStart.b("崬䀮䈰娲䄴帶嘸唺甼", 7))
        {
            throw new XmlException(BookmarkStart.b("崬䀮䈰娲䄴帶嘸唺甼", num));
        }
        if (!A_0.IsEmptyElement)
        {
            bool flag = false;
            string attribute = A_0.GetAttribute(BookmarkStart.b("弬䨮崰刲䄴帶伸帺笼䴾⹀⹂", num));
            if (attribute != null)
            {
                A_1.Format.HorizontalOrigin = this.method_280(attribute);
            }
            A_0.Read();
            this.method_485(A_0);
            while (A_0.NodeType != XmlNodeType.EndElement)
            {
                if (!(A_0.LocalName != BookmarkStart.b("崬䀮䈰娲䄴帶嘸唺甼", num)))
                {
                    break;
                }
                flag = false;
                if (A_0.NodeType == XmlNodeType.Element)
                {
                    string localName = A_0.LocalName;
                    if (localName != null)
                    {
                        if (!(localName == BookmarkStart.b("䰬䌮堰吲嬴", num)))
                        {
                            if (localName == BookmarkStart.b("崬䀮䈰簲匴儶䨸帺䤼", num))
                            {
                                float maxValue = float.MaxValue;
                                maxValue = float.Parse(A_0.ReadString());
                                if (maxValue != float.MaxValue)
                                {
                                    A_1.Format.HorizontalPosition = (int) Math.Round((double) (maxValue / 12700f));
                                }
                            }
                        }
                        else
                        {
                            string str = A_0.ReadString();
                            if (str != null)
                            {
                                A_1.Format.HorizontalAlignment = this.method_279(str);
                            }
                        }
                    }
                    if (!flag)
                    {
                        A_0.Read();
                    }
                }
                else
                {
                    A_0.Read();
                }
                this.method_485(A_0);
            }
        }
    }

    private void method_278(XmlReader A_0, TextBox A_1)
    {
        int num = 1;
        if (A_0.LocalName != BookmarkStart.b("圦䘨堪䐬嬮堰尲嬴愶", 1))
        {
            throw new XmlException(BookmarkStart.b("眦䘨堪䐬嬮堰尲嬴愶", num));
        }
        if (!A_0.IsEmptyElement)
        {
            bool flag = false;
            string attribute = A_0.GetAttribute(BookmarkStart.b("唦䰨䜪䰬嬮堰䔲倴然䬸吺值", num));
            A_1.Format.VerticalOrigin = this.method_284(attribute);
            A_0.Read();
            this.method_485(A_0);
            while (A_0.NodeType != XmlNodeType.EndElement)
            {
                if (!(A_0.LocalName != BookmarkStart.b("圦䘨堪䐬嬮堰尲嬴愶", num)))
                {
                    break;
                }
                flag = false;
                if (A_0.NodeType == XmlNodeType.Element)
                {
                    string localName = A_0.LocalName;
                    if (localName != null)
                    {
                        if (!(localName == BookmarkStart.b("䘦䔨䈪䨬䄮", num)))
                        {
                            if (localName == BookmarkStart.b("圦䘨堪戬䤮地䀲倴䌶", num))
                            {
                                float maxValue = float.MaxValue;
                                maxValue = float.Parse(A_0.ReadString());
                                if (maxValue != float.MaxValue)
                                {
                                    A_1.Format.VerticalPosition = (int) Math.Round((double) (maxValue / 12700f));
                                }
                            }
                        }
                        else
                        {
                            string str2 = A_0.ReadString();
                            if (str2 != null)
                            {
                                A_1.Format.VerticalAlignment = this.method_283(str2);
                            }
                        }
                    }
                    if (!flag)
                    {
                        A_0.Read();
                    }
                }
                else
                {
                    A_0.Read();
                }
                this.method_485(A_0);
            }
        }
    }

    private ShapeHorizontalAlignment method_279(string A_0)
    {
        int num = 14;
        string str = A_0;
        if (str != null)
        {
            if (str == BookmarkStart.b("圳匵嘷丹夻䰽", num))
            {
                return ShapeHorizontalAlignment.Center;
            }
            if (str == BookmarkStart.b("堳匵帷丹", num))
            {
                return ShapeHorizontalAlignment.Left;
            }
            if (str == BookmarkStart.b("䘳張強刹䠻", num))
            {
                return ShapeHorizontalAlignment.Right;
            }
            if (str == BookmarkStart.b("崳堵䬷匹堻嬽", num))
            {
                return ShapeHorizontalAlignment.Inside;
            }
            if (str == BookmarkStart.b("嬳䌵䰷䤹唻娽┿", num))
            {
                return ShapeHorizontalAlignment.Outside;
            }
        }
        return ShapeHorizontalAlignment.None;
    }

    internal Document method_28(Stream A_0, Document A_1)
    {
        this.bool_13 = true;
        Class1129 class2 = this.method_29(A_0);
        this.document_0 = A_1;
        this.method_32(class2, A_1);
        return A_1;
    }

    private HorizontalOrigin method_280(string A_0)
    {
        int num = 2;
        string key = A_0;
        if (key != null)
        {
            int num2;
            if (Class1160.dictionary_76 == null)
            {
                Dictionary<string, int> dictionary1 = new Dictionary<string, int>(13);
                dictionary1.Add(BookmarkStart.b("堧䬩䬫䬭", num), 0);
                dictionary1.Add(BookmarkStart.b("䬧䔩䀫嬭崯就", num), 1);
                dictionary1.Add(BookmarkStart.b("尧伩含娭", num), 2);
                dictionary1.Add(BookmarkStart.b("䬧䈩䴫尭", num), 3);
                dictionary1.Add(BookmarkStart.b("䬧䈩䴫尭儯儱䀳匵䨷", num), 4);
                dictionary1.Add(BookmarkStart.b("䐧伩䨫娭累匱䘳儵儷吹", num), 5);
                dictionary1.Add(BookmarkStart.b("䐧伩䨫娭ᴯ弱唳䐵強匹刻ጽℿぁ⅃❅", num), 6);
                dictionary1.Add(BookmarkStart.b("娧䌩䬫䘭䐯缱唳䐵強匹刻", num), 7);
                dictionary1.Add(BookmarkStart.b("娧䌩䬫䘭䐯ἱ夳圵䨷崹唻倽洿⍁㙃⍅⥇", num), 8);
                dictionary1.Add(BookmarkStart.b("䄧䐩弫䜭启圱礳圵䨷崹唻倽", num), 9);
                dictionary1.Add(BookmarkStart.b("䄧䐩䈫䬭䈯ἱ夳圵䨷崹唻倽洿⍁㙃⍅⥇", num), 10);
                dictionary1.Add(BookmarkStart.b("䜧弩堫崭夯嘱儳笵夷䠹嬻圽⸿", num), 11);
                dictionary1.Add(BookmarkStart.b("䜧弩堫䬭䈯ἱ夳圵䨷崹唻倽洿⍁㙃⍅⥇", num), 12);
                Class1160.dictionary_76 = dictionary1;
            }
            if (Class1160.dictionary_76.TryGetValue(key, out num2))
            {
                switch (num2)
                {
                    case 0:
                        return HorizontalOrigin.Page;

                    case 1:
                    case 2:
                        return HorizontalOrigin.Column;

                    case 3:
                    case 4:
                        return HorizontalOrigin.Character;

                    case 5:
                    case 6:
                        return HorizontalOrigin.LeftMarginArea;

                    case 7:
                    case 8:
                        return HorizontalOrigin.RightMarginArea;

                    case 9:
                    case 10:
                        return HorizontalOrigin.InnerMarginArea;

                    case 11:
                    case 12:
                        return HorizontalOrigin.OuterMarginArea;
                }
            }
        }
        return HorizontalOrigin.Margin;
    }

    private LineBreakClear method_281(string A_0)
    {
        int num = 10;
        string str = A_0;
        if (str != null)
        {
            if (str == BookmarkStart.b("尯圱刳䈵", num))
            {
                return LineBreakClear.Left;
            }
            if (str == BookmarkStart.b("䈯嬱匳帵䰷", num))
            {
                return LineBreakClear.Right;
            }
            if (str == BookmarkStart.b("儯帱堳", num))
            {
                return LineBreakClear.All;
            }
            if (str == BookmarkStart.b("帯崱娳匵", num))
            {
            }
        }
        return LineBreakClear.None;
    }

    private void method_282(XmlReader A_0, DocPicture A_1)
    {
        int num = 6;
        if (A_0.LocalName != BookmarkStart.b("尫䄭䌯嬱䀳張圷吹樻", 6))
        {
            throw new XmlException(BookmarkStart.b("簫䄭䌯嬱䀳張圷吹樻", num));
        }
        if (!A_0.IsEmptyElement)
        {
            string localName = A_0.LocalName;
            bool flag = false;
            string attribute = A_0.GetAttribute(BookmarkStart.b("師䬭尯匱䀳張丷弹稻䰽⼿⽁", num));
            A_1.VerticalOrigin = this.method_284(attribute);
            A_0.Read();
            this.method_485(A_0);
            while (A_0.LocalName != localName)
            {
                if (A_0.EOF)
                {
                    break;
                }
                flag = false;
                if (A_0.NodeType == XmlNodeType.Element)
                {
                    string str4 = A_0.LocalName;
                    if (str4 != null)
                    {
                        if (!(str4 == BookmarkStart.b("䴫䈭夯唱娳", num)))
                        {
                            if (str4 == BookmarkStart.b("尫䄭䌯紱刳倵䬷弹䠻", num))
                            {
                                float maxValue = float.MaxValue;
                                maxValue = float.Parse(A_0.ReadString());
                                if (maxValue != float.MaxValue)
                                {
                                    A_1.VerticalPosition = maxValue / 12700f;
                                }
                            }
                        }
                        else
                        {
                            string str3 = A_0.ReadString();
                            if (str3 != null)
                            {
                                A_1.VerticalAlignment = this.method_283(str3);
                            }
                        }
                    }
                    if (!flag)
                    {
                        A_0.Read();
                    }
                }
                else
                {
                    A_0.Read();
                }
                this.method_485(A_0);
            }
        }
    }

    private ShapeVerticalAlignment method_283(string A_0)
    {
        int num = 0x11;
        string key = A_0;
        if (key != null)
        {
            int num2;
            if (Class1160.dictionary_77 == null)
            {
                Dictionary<string, int> dictionary1 = new Dictionary<string, int>(6);
                dictionary1.Add(BookmarkStart.b("䌶嘸䬺", num), 0);
                dictionary1.Add(BookmarkStart.b("唶嘸伺䤼倾ⱀ", num), 1);
                dictionary1.Add(BookmarkStart.b("吶尸唺䤼娾㍀", num), 2);
                dictionary1.Add(BookmarkStart.b("帶圸䠺吼嬾⑀", num), 3);
                dictionary1.Add(BookmarkStart.b("帶圸场吼儾⑀", num), 4);
                dictionary1.Add(BookmarkStart.b("堶䰸伺丼嘾╀♂", num), 5);
                Class1160.dictionary_77 = dictionary1;
            }
            if (Class1160.dictionary_77.TryGetValue(key, out num2))
            {
                switch (num2)
                {
                    case 0:
                        return ShapeVerticalAlignment.Top;

                    case 1:
                        return ShapeVerticalAlignment.Bottom;

                    case 2:
                        return ShapeVerticalAlignment.Center;

                    case 3:
                        return ShapeVerticalAlignment.Inside;

                    case 4:
                        return ShapeVerticalAlignment.Inline;

                    case 5:
                        return ShapeVerticalAlignment.Outside;
                }
            }
        }
        return ShapeVerticalAlignment.None;
    }

    private VerticalOrigin method_284(string A_0)
    {
        int num = 0x11;
        string key = A_0;
        if (key != null)
        {
            int num2;
            if (Class1160.dictionary_78 == null)
            {
                Dictionary<string, int> dictionary1 = new Dictionary<string, int>(12);
                dictionary1.Add(BookmarkStart.b("䜶堸尺堼", num), 0);
                dictionary1.Add(BookmarkStart.b("䜶堸䤺尼堾㍀≂㕄⽆", num), 1);
                dictionary1.Add(BookmarkStart.b("䌶尸䌺䤼", num), 2);
                dictionary1.Add(BookmarkStart.b("嬶倸唺堼", num), 3);
                dictionary1.Add(BookmarkStart.b("䌶嘸䬺瀼帾㍀⑂ⱄ⥆", num), 4);
                dictionary1.Add(BookmarkStart.b("䌶嘸䬺ြ刾⁀ㅂ≄⹆❈晊ⱌ㵎㑐㉒", num), 5);
                dictionary1.Add(BookmarkStart.b("唶嘸伺䤼倾ⱀโ⑄㕆⹈≊⍌", num), 6);
                dictionary1.Add(BookmarkStart.b("唶嘸伺䤼倾ⱀ湂⡄♆㭈ⱊ⑌ⅎ籐㉒❔㉖㡘", num), 7);
                dictionary1.Add(BookmarkStart.b("帶圸䠺吼嬾⑀โ⑄㕆⹈≊⍌", num), 8);
                dictionary1.Add(BookmarkStart.b("帶圸唺堼䴾汀⹂⑄㕆⹈≊⍌扎ぐ⅒ご㙖", num), 9);
                dictionary1.Add(BookmarkStart.b("堶䰸伺丼嘾╀♂ࡄ♆㭈ⱊ⑌ⅎ", num), 10);
                dictionary1.Add(BookmarkStart.b("堶䰸伺堼䴾汀⹂⑄㕆⹈≊⍌扎ぐ⅒ご㙖", num), 11);
                Class1160.dictionary_78 = dictionary1;
            }
            if (Class1160.dictionary_78.TryGetValue(key, out num2))
            {
                switch (num2)
                {
                    case 0:
                        return VerticalOrigin.Page;

                    case 1:
                        return VerticalOrigin.Paragraph;

                    case 2:
                    case 3:
                        return VerticalOrigin.Line;

                    case 4:
                    case 5:
                        return VerticalOrigin.TopMarginArea;

                    case 6:
                    case 7:
                        return VerticalOrigin.BottomMarginArea;

                    case 8:
                    case 9:
                        return VerticalOrigin.InnerMarginArea;

                    case 10:
                    case 11:
                        return VerticalOrigin.OuterMarginArea;
                }
            }
        }
        return VerticalOrigin.Margin;
    }

    private bool method_285(XmlReader A_0)
    {
        int num = 3;
        this.method_247(A_0, BookmarkStart.b("丨太䰬弮夰娲嘴猶堸伺尼", 3), BookmarkStart.b("䠨", 3));
        if (A_0.LocalName != BookmarkStart.b("丨太䰬弮夰娲嘴猶堸伺尼", 3))
        {
            return false;
        }
        string attribute = A_0.GetAttribute(BookmarkStart.b("尨太䐬", num));
        this.method_247(A_0, BookmarkStart.b("夨䈪丬", num), BookmarkStart.b("夨䈪丬", num));
        return ((attribute != null) && (attribute == this.dictionary_18[BookmarkStart.b("夨䈪丬", num)]));
    }

    private void method_286(XmlReader A_0, ParagraphItemCollection A_1)
    {
        int num = 6;
        Break @break = null;
        if ((A_0.LocalName != BookmarkStart.b("丫尭", 6)) && (A_0.LocalName != BookmarkStart.b("伫尭", num)))
        {
            throw new XmlException(BookmarkStart.b("丫尭唯匱弳ᘵ儷丹夻匽", num));
        }
        string attribute = A_0.GetAttribute(BookmarkStart.b("堫圭䀯圱", num), this.dictionary_18[BookmarkStart.b("嬫", num)]);
        if (attribute == BookmarkStart.b("伫䄭尯䜱夳堵", num))
        {
            @break = new Break(this.document_0, BreakType.ColumnBreak);
        }
        else if (attribute == BookmarkStart.b("尫伭圯圱", num))
        {
            @break = new Break(this.document_0, BreakType.PageBreak);
        }
        else
        {
            @break = new Break(this.document_0, BreakType.LineBreak) {
                TextRange = { Text = BookmarkStart.b("✫", num) }
            };
            if (A_0.LocalName == BookmarkStart.b("伫尭", num))
            {
                @break.IsCrBreak = true;
            }
            string str = A_0.GetAttribute(BookmarkStart.b("伫䈭唯匱䘳", num), this.dictionary_18[BookmarkStart.b("嬫", num)]);
            @break.ClearType = this.method_281(str);
            if (this.characterFormat_0 != null)
            {
                @break.TextRange.ApplyCharacterFormat(this.characterFormat_0);
            }
        }
        if (A_1 != null)
        {
            this.method_455(@break, A_1);
        }
        else
        {
            this.list_6.Add(@break);
        }
    }

    private void method_287(ParagraphItemCollection A_0)
    {
        int num = 0;
        while (num < this.list_6.Count)
        {
            this.method_455(this.list_6[num++], A_0);
        }
        this.list_6.Clear();
    }

    private ParagraphBase method_288(XmlReader A_0, ParagraphItemCollection A_1)
    {
        int num = 5;
        if (A_0.LocalName != BookmarkStart.b("堪听䈮", 5))
        {
            throw new XmlException(BookmarkStart.b("渪唬䰮吰䌲䄴帶圸尺ᴼ氾㡀⹂❄⡆╈歊⡌⍎㑐㹒ご㥖ⵘ", num));
        }
        if (A_0.AttributeCount != 2)
        {
            return null;
        }
        string attribute = A_0.GetAttribute(BookmarkStart.b("䴪䈬䄮䔰", num), this.dictionary_18[BookmarkStart.b("尪", num)]);
        string s = A_0.GetAttribute(BookmarkStart.b("䠪䔬丮䌰", num), this.dictionary_18[BookmarkStart.b("尪", num)]);
        if ((attribute == null) || (s == null))
        {
            return null;
        }
        int num2 = int.Parse(s, NumberStyles.HexNumber, CultureInfo.InvariantCulture);
        if (s.StartsWith(BookmarkStart.b("洪ᴬ", num)))
        {
            num2 -= 0xf000;
        }
        if (num2 <= 0xff)
        {
            Symbol symbol = new Symbol(this.document_0) {
                CharacterCode = (byte) num2,
                FontName = attribute
            };
            if (this.characterFormat_0 != null)
            {
                symbol.CharacterFormat.ImportContainer(this.characterFormat_0);
            }
            return symbol;
        }
        TextRange range = new TextRange(this.document_0);
        if (this.characterFormat_0 != null)
        {
            range.CharacterFormat.ImportContainer(this.characterFormat_0);
        }
        range.CharacterFormat.FontName = attribute;
        range.Text = Convert.ToString((char) num2);
        return range;
    }

    private void method_289(TextRange A_0, string A_1, CharacterFormat A_2)
    {
        A_0.ApplyCharacterFormat(A_2);
        A_0.Text = A_1;
    }

    internal Class1129 method_29(Stream A_0)
    {
        int num = 9;
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("尮䔰䄲倴嘶吸", num));
        }
        Class1129 class4 = new Class1129();
        List<Class229> list = new List<Class229>();
        A_0.Position = 0L;
        XmlReader reader = XmlReader.Create(A_0);
        reader.Read();
        while (!reader.EOF)
        {
            if (reader.LocalName == BookmarkStart.b("弮倰䄲䄴", num))
            {
                string attribute = string.Empty;
                string str3 = string.Empty;
                bool flag = false;
                using (MemoryStream stream = this.method_484(reader))
                {
                    stream.Position = 0L;
                    XmlReader reader2 = XmlReader.Create(stream);
                    reader2.Read();
                    while (!reader2.EOF)
                    {
                        string localName = reader2.LocalName;
                        if (localName != null)
                        {
                            if (localName != BookmarkStart.b("弮倰䄲䄴", num))
                            {
                                if (!(localName == BookmarkStart.b("圮尰弲焴嘶䴸娺", num)))
                                {
                                    if (localName == BookmarkStart.b("䴮堰崲吴䔶䀸缺尼䬾⁀", num))
                                    {
                                        MemoryStream stream3 = new MemoryStream(Convert.FromBase64String(reader2.ReadInnerXml().Trim()));
                                        Class229 item = new Class229(stream3);
                                        item.method_8(attribute);
                                        item.method_1(str3);
                                        list.Add(item);
                                    }
                                }
                                else
                                {
                                    string s = reader2.ReadInnerXml();
                                    MemoryStream stream2 = new MemoryStream(Encoding.UTF8.GetBytes(s));
                                    Class229 class2 = new Class229(stream2);
                                    class2.method_8(attribute);
                                    class2.method_1(str3);
                                    list.Add(class2);
                                    s = null;
                                }
                            }
                            else
                            {
                                attribute = reader2.GetAttribute(BookmarkStart.b("䄮倰帲倴", num), reader2.NamespaceURI);
                                str3 = reader2.GetAttribute(BookmarkStart.b("䰮帰崲䄴制圸伺椼䘾ㅀ♂", num), reader2.NamespaceURI);
                            }
                        }
                        if (!flag)
                        {
                            reader2.Read();
                        }
                        this.method_485(reader2);
                    }
                    reader2.Close();
                    goto Label_01E7;
                }
            }
            reader.Read();
        Label_01E7:
            this.method_485(reader);
        }
        class4.method_21(list);
        list.Clear();
        list = null;
        return class4;
    }

    private TextRange method_290(XmlReader A_0, ParagraphItemCollection A_1)
    {
        return this.method_291(A_0, A_1, null, false, false);
    }

    private TextRange method_291(XmlReader A_0, ParagraphItemCollection A_1, Class2 A_2, bool A_3, bool A_4)
    {
        int num = 3;
        TextRange range = null;
        if (this.method_9() is MergeField)
        {
            range = this.method_9();
            string str = this.method_292(A_0);
            if (((this.characterFormat_0 != null) && this.characterFormat_0.Bidi) && (str != null))
            {
                str = this.method_293(str);
                this.characterFormat_0.Bidi = false;
            }
            if (range.Text == string.Empty)
            {
                range.Text = str;
                range.ApplyCharacterFormat(this.characterFormat_0);
            }
            else
            {
                range.Text = range.Text + str;
            }
            return null;
        }
        if (this.bool_5)
        {
            this.method_152(A_0, A_1);
            this.bool_5 = false;
            return range;
        }
        string str2 = this.method_292(A_0);
        if (str2.Length > 0)
        {
            str2 = str2.Replace(BookmarkStart.b("⌨", num), "").Replace(BookmarkStart.b("␨", num), "");
        }
        if (str2.Contains(BookmarkStart.b("∨", num)))
        {
            string[] strArray = str2.Split(new char[] { '\v' });
            int index = 0;
            int length = strArray.Length;
            while (index < length)
            {
                if (!string.IsNullOrEmpty(strArray[index]))
                {
                    range = new TextRange(this.document_0);
                    if (this.characterFormat_0 != null)
                    {
                        range.ApplyCharacterFormat(this.characterFormat_0);
                    }
                    range.Text = strArray[index];
                    this.method_455(range, A_1);
                }
                if ((index + 1) < length)
                {
                    Break @break = new Break(this.document_0, BreakType.LineBreak) {
                        TextRange = { Text = BookmarkStart.b("∨", num) }
                    };
                    if (this.characterFormat_0 != null)
                    {
                        @break.TextRange.ApplyCharacterFormat(this.characterFormat_0);
                    }
                    this.method_455(@break, A_1);
                }
                index++;
            }
            return null;
        }
        if (A_2 != null)
        {
            if (A_3)
            {
                A_2.method_45().ApplyCharacterFormat(this.characterFormat_0);
                A_2.method_45().Text = str2;
            }
            if (A_4)
            {
                A_2.ApplyCharacterFormat(this.characterFormat_0);
                A_2.Text = str2;
            }
            return A_2;
        }
        range = new TextRange(this.document_0);
        if (this.characterFormat_0 != null)
        {
            range.ApplyCharacterFormat(this.characterFormat_0);
        }
        range.Text = str2;
        return range;
    }

    private string method_292(XmlReader A_0)
    {
        int num = 11;
        string str = string.Empty;
        if (!A_0.IsEmptyElement)
        {
            bool flag = this.method_67(A_0);
            int num2 = 0;
            A_0.Read();
            this.method_485(A_0);
            while ((num2 > 0) || (A_0.NodeType != XmlNodeType.EndElement))
            {
                if ((A_0.NodeType != XmlNodeType.Text) && (A_0.NodeType != XmlNodeType.SignificantWhitespace))
                {
                    if ((A_0.NodeType == XmlNodeType.Element) && !A_0.IsEmptyElement)
                    {
                        num2++;
                        string str2 = this.method_292(A_0).Replace(Class816.string_4, BookmarkStart.b("ᄰ", num)).Replace(Class816.string_27, BookmarkStart.b("ᄰ", num)).Replace('\n', ' ');
                        str = str + str2;
                    }
                    else if ((A_0.NodeType == XmlNodeType.Element) && (A_0.LocalName == BookmarkStart.b("匰䄲", num)))
                    {
                        str = str + Class816.string_6;
                    }
                }
                else
                {
                    str = str + A_0.Value;
                }
                if (A_0.NodeType == XmlNodeType.EndElement)
                {
                    if (num2 == 0)
                    {
                        break;
                    }
                    num2--;
                }
                A_0.Read();
                this.method_485(A_0);
            }
            if (this.bool_12 && flag)
            {
                return str.Trim(new char[] { ' ' });
            }
        }
        return str;
    }

    private string method_293(string A_0)
    {
        char[] chArray = A_0.ToCharArray();
        string str = string.Empty;
        for (int i = chArray.Length - 1; i >= 0; i--)
        {
            str = str + chArray[i].ToString();
        }
        return str;
    }

    private string method_294(string A_0)
    {
        A_0 = A_0.Replace(BookmarkStart.b("ᔲ吴娶䤸:", 13), BookmarkStart.b("ᔲ", 13));
        A_0 = A_0.Replace(BookmarkStart.b("ᔲ头䌶ȸ", 13), BookmarkStart.b("༲", 13));
        A_0 = A_0.Replace(BookmarkStart.b("ᔲ刴䌶ȸ", 13), BookmarkStart.b("ല", 13));
        return A_0;
    }

    private void method_295(XmlReader A_0)
    {
        int num = 14;
        if (A_0.LocalName != BookmarkStart.b("嘳圵嬷儹嬻䰽⼿㝁⩃≅", 14))
        {
            throw new XmlException(BookmarkStart.b("嘳圵嬷儹嬻䰽⼿㝁⩃≅", num));
        }
        Stream stream = this.method_484(A_0);
        this.document_0.method_27(new Background(this.document_0, Class964.smethod_0(new Class466(stream, this.document_0, this))));
    }

    private void method_296(XmlReader A_0, Background A_1)
    {
        int num = 9;
        string attribute = A_0.GetAttribute(BookmarkStart.b("嬮䠰䌲倴", 9));
        string str2 = A_0.GetAttribute(BookmarkStart.b("䘮唰", 9), this.dictionary_18[BookmarkStart.b("崮", 9)]);
        if ((attribute != null) && (str2 != null))
        {
            A_1.Type = (attribute == BookmarkStart.b("嬮堰弲倴", num)) ? BackgroundType.Texture : BackgroundType.Picture;
            string key = this.method_459(str2, false, false);
            if (this.method_0().ContainsKey(key))
            {
                A_1.ImageRecord = this.document_0.Images.method_0(this.method_0()[key]);
            }
            else
            {
                A_1.ImageBytes = this.method_460(key);
                this.method_0().Add(key, A_1.ImageRecord.method_0());
            }
        }
    }

    private IStructureDocument method_297(IDocumentObject A_0)
    {
        if (A_0 is HeaderFooter)
        {
            return (A_0 as HeaderFooter).method_21();
        }
        if (A_0 is Footnote)
        {
            return (A_0 as Footnote).TextBody.method_21();
        }
        if (A_0 is Comment)
        {
            return (A_0 as Comment).Body.method_21();
        }
        if (A_0 is StructureDocumentTag)
        {
            return (A_0 as StructureDocumentTag).SDTContent.method_21();
        }
        return this.document_0.LastSection.method_22();
    }

    private void method_298(XmlReader A_0, StructureDocumentTagInline A_1)
    {
        int num = 8;
        while (A_0.NodeType != XmlNodeType.Element)
        {
            A_0.Read();
        }
        if (!A_0.IsEmptyElement)
        {
            bool flag = false;
            string localName = A_0.LocalName;
            A_0.Read();
            this.method_485(A_0);
            while (A_0.LocalName != localName)
            {
                flag = false;
                if (A_0.NodeType == XmlNodeType.Element)
                {
                    string str = A_0.LocalName;
                    if (str != null)
                    {
                        if (str != BookmarkStart.b("崭启䘱搳䐵", num))
                        {
                            if (!(str == BookmarkStart.b("崭启䘱眳夵嘷丹夻倽㐿", num)))
                            {
                                if (str == BookmarkStart.b("崭启䘱焳堵尷樹主", num))
                                {
                                    this.method_303(A_0, A_1.BreakCharacterFormat);
                                }
                            }
                            else
                            {
                                this.method_299(A_0, A_1.SDTContent);
                            }
                        }
                        else
                        {
                            this.method_305(A_0, A_1.SDTProperties);
                        }
                    }
                    if (!flag)
                    {
                        A_0.Read();
                    }
                }
                else
                {
                    A_0.Read();
                }
            }
        }
    }

    private void method_299(XmlReader A_0, SDTInlineContent A_1)
    {
        this.method_74(A_0, A_1.Items);
    }

    internal Dictionary<string, Comment> method_3()
    {
        if (this.dictionary_16 == null)
        {
            this.dictionary_16 = new Dictionary<string, Comment>();
        }
        return this.dictionary_16;
    }

    private Stream method_30(Stream A_0, Document A_1)
    {
        int num = 12;
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("䄱䀳䐵崷嬹儻", num));
        }
        Stream stream = new MemoryStream();
        bool flag = false;
        using (Interface51 interface2 = A_1.method_154(A_0))
        {
            Class1071 class3;
            Class361 class4;
            Interface61 interface3 = interface2.imethod_0();
            Class299 class2 = new Class299();
            switch (class2.method_0(interface3))
            {
                case Class299.EncrytionType.Standard:
                    flag = true;
                    class4 = new Class361();
                    class4.method_1(interface3);
                    if (!class4.method_2(A_1.string_10))
                    {
                        throw new PasswordErrorException(BookmarkStart.b("愱䐳匵嬷匹娻圽┿♁摃㙅⥇㥉㽋㥍㽏⁑こ癕穗", num) + A_1.string_10 + BookmarkStart.b("ေᐳ張䬷ᨹ唻倽⌿ⵁ㙃㑅ⵇ⥉㡋潍", num));
                    }
                    break;

                case Class299.EncrytionType.Agile:
                    flag = true;
                    class3 = new Class1071();
                    class3.method_2(interface3);
                    if (!class3.method_3(A_1.string_10))
                    {
                        throw new PasswordErrorException(BookmarkStart.b("瘱嬳唵䴷圹夻倽㐿扁ⵃ㕅桇⽉≋ⵍ≏⭑⑓≕㵗㹙灛繝⽟ቡţࡥ䡧ṩѫ୭偯ɱᕳյ୷൹፻౽ꊁﾋ꺍瞧躟", num));
                    }
                    goto Label_00DE;

                default:
                    goto Label_00F3;
            }
            stream = class4.method_0();
            goto Label_00F3;
        Label_00DE:
            stream = class3.method_1();
        }
    Label_00F3:
        if (!flag)
        {
            throw new ApplicationException(BookmarkStart.b("攱䘳夵嘷崹᰻椽⼿ぁ⁃晅㹇⽉㹋㵍㥏㵑㩓", num));
        }
        return stream;
    }

    private void method_300(XmlReader A_0, StructureDocumentTag A_1)
    {
        int num = 8;
        while (A_0.NodeType != XmlNodeType.Element)
        {
            A_0.Read();
        }
        if (!A_0.IsEmptyElement)
        {
            bool flag = false;
            string localName = A_0.LocalName;
            A_0.Read();
            this.method_485(A_0);
            while (A_0.LocalName != localName)
            {
                flag = false;
                if (A_0.NodeType == XmlNodeType.Element)
                {
                    string str = A_0.LocalName;
                    if (str != null)
                    {
                        if (str != BookmarkStart.b("崭启䘱搳䐵", num))
                        {
                            if (!(str == BookmarkStart.b("崭启䘱眳夵嘷丹夻倽㐿", num)))
                            {
                                if (str == BookmarkStart.b("崭启䘱焳堵尷樹主", num))
                                {
                                    this.method_303(A_0, A_1.BreakCharacterFormat);
                                }
                            }
                            else
                            {
                                this.method_304(A_0, A_1);
                            }
                        }
                        else
                        {
                            this.method_305(A_0, A_1.SDTProperties);
                        }
                    }
                    if (!flag)
                    {
                        A_0.Read();
                    }
                }
                else
                {
                    A_0.Read();
                }
            }
        }
    }

    private void method_301(XmlReader A_0, DocumentObjectCollection A_1)
    {
        int num = 12;
        while (A_0.NodeType != XmlNodeType.Element)
        {
            A_0.Read();
        }
        Stream stream = null;
        bool flag = false;
        string str4 = string.Empty;
        string localName = A_0.LocalName;
        if (A_0.LocalName == BookmarkStart.b("匱堳䈵笷刹䤻倽⬿", num))
        {
            string attribute = A_0.GetAttribute(BookmarkStart.b("嬱倳", num), this.dictionary_18[BookmarkStart.b("䀱", num)]);
            if (this.method_16().ContainsKey(attribute))
            {
                DictionaryEntry entry = this.method_16()[attribute];
                str4 = entry.Value.ToString();
                stream = this.method_302(str4);
            }
            else
            {
                str4 = attribute;
                stream = this.method_302(attribute);
            }
        }
        if (!A_0.IsEmptyElement)
        {
            A_0.Read();
            while (A_0.LocalName != localName)
            {
                flag = false;
                if (A_0.NodeType == XmlNodeType.Element)
                {
                    string str2;
                    if (((str2 = A_0.LocalName) != null) && (str2 == BookmarkStart.b("弱唳䈵嬷刹漻䰽⌿", num)))
                    {
                        string str5 = A_0.GetAttribute(BookmarkStart.b("䐱唳娵", num), this.dictionary_18[BookmarkStart.b("䔱", num)]);
                        if (!(str5 == BookmarkStart.b("䘱", num)))
                        {
                            bool flag1 = str5 == BookmarkStart.b("䘱䘳䌵崷", num);
                        }
                    }
                    if (!flag)
                    {
                        A_0.Read();
                    }
                }
                else
                {
                    A_0.Read();
                }
            }
        }
        if (stream != null)
        {
            string str7 = str4.Substring(str4.LastIndexOf('.') + 1).ToLower();
            stream.Position = 0L;
            Document document = new Document();
            string str = str7;
            if (str != null)
            {
                if (str != BookmarkStart.b("嘱嬳唵䀷", num))
                {
                    if (str != BookmarkStart.b("嘱嬳唵", num))
                    {
                        if (str != BookmarkStart.b("䀱䀳倵", num))
                        {
                            if ((str == BookmarkStart.b("娱䀳嬵", num)) || (str == BookmarkStart.b("娱䀳嬵吷", num)))
                            {
                                document.LoadFromStream(stream, FileFormat.Html);
                            }
                        }
                        else
                        {
                            document.LoadFromStream(stream, FileFormat.Rtf);
                        }
                    }
                    else
                    {
                        document.LoadFromStream(stream, FileFormat.Doc);
                    }
                }
                else
                {
                    document.LoadFromStream(stream, FileFormat.Docx);
                }
            }
            if (document.Sections.Count > 0)
            {
                Document.IsCloneParagraphCheckFormat = true;
                foreach (Section section in document.Sections)
                {
                    foreach (DocumentObject obj2 in section.Body.Items)
                    {
                        if ((A_1 is ParagraphItemCollection) && (obj2 is Paragraph))
                        {
                            foreach (DocumentObject obj3 in (obj2 as Paragraph).Items)
                            {
                                A_1.Add(obj3.Clone());
                            }
                        }
                        else if (A_1 is BodyRegionCollection)
                        {
                            A_1.Add(obj2.Clone());
                        }
                        else
                        {
                            this.document_0.LastSection.Body.Items.Add(obj2.Clone());
                        }
                    }
                }
                Document.IsCloneParagraphCheckFormat = false;
            }
            document.Close();
            document = null;
        }
        stream.Dispose();
    }

    private Stream method_302(string A_0)
    {
        int num = 9;
        if (A_0.Contains(BookmarkStart.b(".", 9)))
        {
            string str = A_0.Substring(0, A_0.LastIndexOf('/') + 1);
            string str2 = A_0.Substring(A_0.LastIndexOf('/') + 1);
            Class229 class2 = this.method_465(str, str2);
            if (class2 != null)
            {
                return class2.method_4();
            }
            return null;
        }
        Class229 class3 = this.method_465(BookmarkStart.b("堮帰䄲儴ᠶ", num), A_0);
        if (class3 != null)
        {
            return class3.method_4();
        }
        return null;
    }

    private void method_303(XmlReader A_0, CharacterFormat A_1)
    {
        int num = 0x13;
        while (A_0.NodeType != XmlNodeType.Element)
        {
            A_0.Read();
        }
        if (!A_0.IsEmptyElement)
        {
            bool flag = false;
            string localName = A_0.LocalName;
            A_0.Read();
            this.method_485(A_0);
            while (A_0.LocalName != localName)
            {
                if (A_0.EOF)
                {
                    break;
                }
                flag = false;
                if (A_0.NodeType == XmlNodeType.Element)
                {
                    string str;
                    if (((str = A_0.LocalName) != null) && (str == BookmarkStart.b("䬸欺似", num)))
                    {
                        this.method_378(A_0, A_1);
                    }
                    if (!flag)
                    {
                        A_0.Read();
                    }
                }
                else
                {
                    A_0.Read();
                }
                this.method_485(A_0);
            }
        }
    }

    private void method_304(XmlReader A_0, StructureDocumentTag A_1)
    {
        this.method_68(A_0, A_1);
    }

    private void method_305(XmlReader A_0, SDTProperties A_1)
    {
        int num = 14;
        while (A_0.NodeType != XmlNodeType.Element)
        {
            A_0.Read();
            this.method_485(A_0);
        }
        if (!A_0.IsEmptyElement)
        {
            bool flag = false;
            string localName = A_0.LocalName;
            A_0.Read();
            this.method_485(A_0);
            while (A_0.LocalName != localName)
            {
                if (A_0.EOF)
                {
                    break;
                }
                flag = false;
                if (A_0.NodeType != XmlNodeType.Element)
                {
                    goto Label_074A;
                }
                string key = A_0.LocalName;
                if (key != null)
                {
                    int num2;
                    if (Class1160.dictionary_79 == null)
                    {
                        Dictionary<string, int> dictionary1 = new Dictionary<string, int>(0x17);
                        dictionary1.Add(BookmarkStart.b("䘳昵䨷", num), 0);
                        dictionary1.Add(BookmarkStart.b("崳刵", num), 1);
                        dictionary1.Add(BookmarkStart.b("䜳帵圷䴹唻倽✿ቁ⡃╅G⹉㹋", num), 2);
                        dictionary1.Add(BookmarkStart.b("唳娵儷嬹伻", num), 3);
                        dictionary1.Add(BookmarkStart.b("䀳圵強", num), 4);
                        dictionary1.Add(BookmarkStart.b("嘳張娷嘹唻儽✿ぁ╃㙅⁇㍉", num), 5);
                        dictionary1.Add(BookmarkStart.b("圳張䰷嬹䠻圽⼿ⱁ", num), 6);
                        dictionary1.Add(BookmarkStart.b("䀳匵唷䨹医䰽ℿぁ㵃", num), 7);
                        dictionary1.Add(BookmarkStart.b("䘳匵䠷弹崻䨽⤿ⱁ⍃ᕅⵇ⥉㡋❍㽏㱑", num), 8);
                        dictionary1.Add(BookmarkStart.b("䘳匵䠷弹崻䨽⤿ⱁ⍃ᕅⵇ⥉㡋❍㽏㱑ᵓ≕㵗㝙", num), 9);
                        dictionary1.Add(BookmarkStart.b("儳䜵䴷嬹䠻圽⼿ⱁ", num), 10);
                        dictionary1.Add(BookmarkStart.b("䐳張嬷丹䤻䰽┿", num), 11);
                        dictionary1.Add(BookmarkStart.b("䀳匵䀷丹", num), 12);
                        dictionary1.Add(BookmarkStart.b("䘳張嬷刹栻嬽㠿㙁", num), 13);
                        dictionary1.Add(BookmarkStart.b("圳夵唷堹医簽⼿㩁", num), 14);
                        dictionary1.Add(BookmarkStart.b("倳䐵圷䨹砻儽㜿ⱁࡃ⽅㭇㹉", num), 15);
                        dictionary1.Add(BookmarkStart.b("堳夵嬷儹", num), 0x10);
                        dictionary1.Add(BookmarkStart.b("倳圵䰷弹", num), 0x11);
                        dictionary1.Add(BookmarkStart.b("倳圵䰷嬹縻圽⸿♁ⵃ⡅⽇", num), 0x12);
                        dictionary1.Add(BookmarkStart.b("圳帵崷夹圻尽⼿㩁", num), 0x13);
                        dictionary1.Add(BookmarkStart.b("倳夵嬷樹崻䰽㐿ു♃ⱅ", num), 20);
                        dictionary1.Add(BookmarkStart.b("倳夵嬷樹崻䰽㐿แⵃ㕅㱇", num), 0x15);
                        dictionary1.Add(BookmarkStart.b("匳䐵圷伹䰻", num), 0x16);
                        Class1160.dictionary_79 = dictionary1;
                    }
                    if (Class1160.dictionary_79.TryGetValue(key, out num2))
                    {
                        switch (num2)
                        {
                            case 0:
                                this.method_378(A_0, A_1.CharacterFormat);
                                break;

                            case 1:
                            {
                                string attribute = A_0.GetAttribute(BookmarkStart.b("䈳圵吷", num), this.dictionary_18[BookmarkStart.b("䌳", num)]);
                                if (!string.IsNullOrEmpty(attribute))
                                {
                                    A_1.Id = decimal.Parse(attribute, NumberStyles.Integer, CultureInfo.InvariantCulture);
                                }
                                break;
                            }
                            case 2:
                                A_1.IsShowingPlaceHolder = true;
                                break;

                            case 3:
                                A_1.Alias = A_0.GetAttribute(BookmarkStart.b("䈳圵吷", num), this.dictionary_18[BookmarkStart.b("䌳", num)]);
                                break;

                            case 4:
                                A_1.Tag = A_0.GetAttribute(BookmarkStart.b("䈳圵吷", num), this.dictionary_18[BookmarkStart.b("䌳", num)]);
                                break;

                            case 5:
                                A_1.Bibliograph = true;
                                break;

                            case 6:
                            {
                                SdtCitation citation = new SdtCitation();
                                A_1.ControlProperties = citation;
                                break;
                            }
                            case 7:
                                A_1.IsTemporary = true;
                                break;

                            case 8:
                                A_1.RepeatingSection = true;
                                break;

                            case 9:
                                A_1.RepeatingSectionItem = true;
                                break;

                            case 10:
                            {
                                Control0 control = new Control0();
                                A_1.ControlProperties = control;
                                break;
                            }
                            case 11:
                            {
                                SdtPicture picture = new SdtPicture();
                                A_1.ControlProperties = picture;
                                break;
                            }
                            case 12:
                            {
                                SdtText text = new SdtText(false);
                                A_1.ControlProperties = text;
                                if (A_0.AttributeCount > 0)
                                {
                                    string str4 = A_0.GetAttribute(BookmarkStart.b("夳䌵吷丹唻爽⤿ⱁ⅃", num), this.dictionary_18[BookmarkStart.b("䌳", num)]);
                                    text.IsMultiline = this.method_110(str4);
                                }
                                break;
                            }
                            case 13:
                            {
                                SdtText text2 = new SdtText(true);
                                A_1.ControlProperties = text2;
                                if (A_0.AttributeCount > 0)
                                {
                                    string str5 = A_0.GetAttribute(BookmarkStart.b("夳䌵吷丹唻爽⤿ⱁ⅃", num), this.dictionary_18[BookmarkStart.b("䌳", num)]);
                                    text2.IsMultiline = this.method_110(str5);
                                }
                                break;
                            }
                            case 14:
                            {
                                SdtComboBox box = new SdtComboBox();
                                A_1.ControlProperties = box;
                                box.LastValue = A_0.GetAttribute(BookmarkStart.b("堳圵䬷丹樻弽ⰿ㝁⅃", num), this.dictionary_18[BookmarkStart.b("䌳", num)]);
                                this.method_311(A_0, box);
                                break;
                            }
                            case 15:
                            {
                                SdtDropDownList list = new SdtDropDownList();
                                A_1.ControlProperties = list;
                                list.LastValue = A_0.GetAttribute(BookmarkStart.b("堳圵䬷丹樻弽ⰿ㝁⅃", num), this.dictionary_18[BookmarkStart.b("䌳", num)]);
                                this.method_310(A_0, list);
                                break;
                            }
                            case 0x10:
                            {
                                string str6 = A_0.GetAttribute(BookmarkStart.b("䈳圵吷", num), this.dictionary_18[BookmarkStart.b("䌳", num)]);
                                if (str6 != null)
                                {
                                    if (str6 == BookmarkStart.b("䜳刵䰷瘹医崽⬿❁⁃", num))
                                    {
                                        goto Label_05D5;
                                    }
                                    if (str6 == BookmarkStart.b("䜳刵䰷礹医倽㐿❁⩃㉅ч╉⽋╍㕏㙑", num))
                                    {
                                        goto Label_05C9;
                                    }
                                    if (str6 == BookmarkStart.b("圳夵嘷丹夻倽㐿แ⭃╅⍇⽉⡋", num))
                                    {
                                        goto Label_05BD;
                                    }
                                    if (str6 == BookmarkStart.b("䄳堵吷唹弻唽┿♁", num))
                                    {
                                        A_1.LockSettings = LockSettingsType.UnLocked;
                                    }
                                }
                                break;
                            }
                            case 0x11:
                            {
                                SdtDate date = new SdtDate();
                                A_1.ControlProperties = date;
                                string str7 = A_0.GetAttribute(BookmarkStart.b("刳䌵吷嘹砻弽㐿❁", num), this.dictionary_18[BookmarkStart.b("䌳", num)]);
                                date.method_0(SdtDate.smethod_1(str7));
                                this.method_312(A_0, date);
                                break;
                            }
                            case 0x12:
                            {
                                string str8 = A_0.GetAttribute(BookmarkStart.b("䰳䘵夷丹吻", num), this.dictionary_18[BookmarkStart.b("䌳", num)]);
                                string str9 = A_0.GetAttribute(BookmarkStart.b("䜳䈵圷䠹夻眽㐿❁⥃ཅే", num), this.dictionary_18[BookmarkStart.b("䌳", num)]);
                                string str10 = A_0.GetAttribute(BookmarkStart.b("䐳䐵崷尹唻䘽ി⍁㑃㙅ⅇ⑉⭋㵍", num), this.dictionary_18[BookmarkStart.b("䌳", num)]);
                                A_1.DataBinding = ((!string.IsNullOrEmpty(str10) || !string.IsNullOrEmpty(str8)) || !string.IsNullOrEmpty(str9)) ? new Class443(str10, str8, str9) : null;
                                break;
                            }
                            case 0x13:
                            {
                                SdtCheckBox box2 = new SdtCheckBox();
                                A_1.ControlProperties = box2;
                                this.method_309(A_0, box2);
                                break;
                            }
                            case 20:
                            {
                                SdtDocPart part = new SdtDocPartObj();
                                A_1.ControlProperties = part;
                                this.method_308(A_0, part);
                                break;
                            }
                            case 0x15:
                            {
                                SdtDocPart part2 = new SdtBuildingBlockGallery();
                                A_1.ControlProperties = part2;
                                this.method_306(A_0, part2);
                                break;
                            }
                            case 0x16:
                            {
                                Control1 control2 = new Control1();
                                A_1.ControlProperties = control2;
                                break;
                            }
                        }
                    }
                }
                goto Label_073E;
            Label_05BD:
                A_1.LockSettings = LockSettingsType.ContentLocked;
                goto Label_073E;
            Label_05C9:
                A_1.LockSettings = LockSettingsType.SDTContentLocked;
                goto Label_073E;
            Label_05D5:
                A_1.LockSettings = LockSettingsType.SDTLocked;
            Label_073E:
                if (!flag)
                {
                    A_0.Read();
                }
                goto Label_0751;
            Label_074A:
                A_0.Read();
            Label_0751:
                this.method_485(A_0);
            }
        }
    }

    private void method_306(XmlReader A_0, SdtDocPart A_1)
    {
        this.method_307(A_0, A_1);
    }

    private void method_307(XmlReader A_0, SdtDocPart A_1)
    {
        int num = 0;
        while (A_0.NodeType != XmlNodeType.Element)
        {
            A_0.Read();
            this.method_485(A_0);
        }
        if (!A_0.IsEmptyElement)
        {
            bool flag = false;
            string localName = A_0.LocalName;
            A_0.Read();
            this.method_485(A_0);
            while (A_0.LocalName != localName)
            {
                if (A_0.EOF)
                {
                    break;
                }
                flag = false;
                if (A_0.NodeType == XmlNodeType.Element)
                {
                    string str2 = A_0.LocalName;
                    if (str2 != null)
                    {
                        if (str2 != BookmarkStart.b("䈥䜧䤩簫伭䈯䘱愳堵儷䬹䤻嬽", num))
                        {
                            if (!(str2 == BookmarkStart.b("䈥䜧䤩簫伭䈯䘱猳圵吷嘹夻䰽㤿", num)))
                            {
                                if (str2 == BookmarkStart.b("䈥䜧䤩簫伭䈯䘱眳圵䰷弹嬻儽㈿㭁", num))
                                {
                                    A_1.BuildingBlockCategory = A_0.GetAttribute(BookmarkStart.b("倥䤧䘩", num), this.dictionary_18[BookmarkStart.b("儥", num)]);
                                }
                            }
                            else
                            {
                                A_1.BuildingBlockType = A_0.GetAttribute(BookmarkStart.b("倥䤧䘩", num), this.dictionary_18[BookmarkStart.b("儥", num)]);
                            }
                        }
                        else
                        {
                            A_1.IsUnique = true;
                        }
                    }
                    if (!flag)
                    {
                        A_0.Read();
                    }
                }
                else
                {
                    A_0.Read();
                }
                this.method_485(A_0);
            }
        }
    }

    private void method_308(XmlReader A_0, SdtDocPart A_1)
    {
        this.method_307(A_0, A_1);
    }

    private void method_309(XmlReader A_0, SdtCheckBox A_1)
    {
        int num = 11;
        while (A_0.NodeType != XmlNodeType.Element)
        {
            A_0.Read();
            this.method_485(A_0);
        }
        if (!A_0.IsEmptyElement)
        {
            bool flag = false;
            string localName = A_0.LocalName;
            A_0.Read();
            this.method_485(A_0);
            while (A_0.LocalName != localName)
            {
                if (A_0.EOF)
                {
                    break;
                }
                flag = false;
                if (A_0.NodeType == XmlNodeType.Element)
                {
                    string str2 = A_0.LocalName;
                    if (str2 != null)
                    {
                        if (str2 != BookmarkStart.b("到嬲倴吶券帺夼", num))
                        {
                            if (!(str2 == BookmarkStart.b("到嬲倴吶券帺夼氾㕀≂ㅄ≆", num)))
                            {
                                if (str2 == BookmarkStart.b("䐰崲嘴弶尸堺嘼娾╀၂ㅄ♆㵈⹊", num))
                                {
                                    A_1.UncheckedState.method_2(A_0.GetAttribute(BookmarkStart.b("地尲嬴䌶", num), this.dictionary_18[BookmarkStart.b("䘰ȲĴ", num)]));
                                    A_1.UncheckedState.method_4(SdtCheckBox.smethod_0(A_0.GetAttribute(BookmarkStart.b("䜰刲头", num), this.dictionary_18[BookmarkStart.b("䘰ȲĴ", num)])));
                                }
                            }
                            else
                            {
                                A_1.CheckedState.method_4(SdtCheckBox.smethod_0(A_0.GetAttribute(BookmarkStart.b("䜰刲头", num), this.dictionary_18[BookmarkStart.b("䘰ȲĴ", num)])));
                                A_1.CheckedState.method_2(A_0.GetAttribute(BookmarkStart.b("地尲嬴䌶", num), this.dictionary_18[BookmarkStart.b("䘰ȲĴ", num)]));
                            }
                        }
                        else
                        {
                            A_1.method_0(this.method_471(A_0, this.dictionary_18[BookmarkStart.b("䘰ȲĴ", num)]));
                        }
                    }
                    if (!flag)
                    {
                        A_0.Read();
                    }
                }
                else
                {
                    A_0.Read();
                }
                this.method_485(A_0);
            }
        }
    }

    private void method_31(Document A_0)
    {
        Class1129 class2 = new Class1129();
        class2.method_20(this.class771_0);
        A_0.DocxPackage = class2;
        this.method_33(A_0);
        this.method_50(class2);
        this.method_318(class2);
        this.method_319(class2);
        this.method_35(class2);
        this.class771_0.method_28();
    }

    private void method_310(XmlReader A_0, SdtDropDownList A_1)
    {
        int num = 9;
        while (A_0.NodeType != XmlNodeType.Element)
        {
            A_0.Read();
            this.method_485(A_0);
        }
        if (!A_0.IsEmptyElement)
        {
            bool flag = false;
            string localName = A_0.LocalName;
            A_0.Read();
            this.method_485(A_0);
            while (A_0.LocalName != localName)
            {
                if (A_0.EOF)
                {
                    break;
                }
                flag = false;
                if (A_0.NodeType == XmlNodeType.Element)
                {
                    string str;
                    if (((str = A_0.LocalName) != null) && (str == BookmarkStart.b("䌮堰䀲䄴縶䴸帺值", num)))
                    {
                        string attribute = A_0.GetAttribute(BookmarkStart.b("䬮堰䀲䔴嬶堸䈺椼娾㥀㝂", num), this.dictionary_18[BookmarkStart.b("堮", num)]);
                        string str4 = A_0.GetAttribute(BookmarkStart.b("央倰弲䀴制", num), this.dictionary_18[BookmarkStart.b("堮", num)]);
                        SdtListItem item = new SdtListItem(attribute, str4);
                        A_1.ListItems.Add(item);
                    }
                    if (!flag)
                    {
                        A_0.Read();
                    }
                }
                else
                {
                    A_0.Read();
                }
                this.method_485(A_0);
            }
        }
    }

    private void method_311(XmlReader A_0, SdtComboBox A_1)
    {
        int num = 9;
        while (A_0.NodeType != XmlNodeType.Element)
        {
            A_0.Read();
            this.method_485(A_0);
        }
        if (!A_0.IsEmptyElement)
        {
            bool flag = false;
            string localName = A_0.LocalName;
            A_0.Read();
            this.method_485(A_0);
            while (A_0.LocalName != localName)
            {
                if (A_0.EOF)
                {
                    break;
                }
                flag = false;
                if (A_0.NodeType == XmlNodeType.Element)
                {
                    string str;
                    if (((str = A_0.LocalName) != null) && (str == BookmarkStart.b("䌮堰䀲䄴縶䴸帺值", num)))
                    {
                        string attribute = A_0.GetAttribute(BookmarkStart.b("䬮堰䀲䔴嬶堸䈺椼娾㥀㝂", num), this.dictionary_18[BookmarkStart.b("堮", num)]);
                        string str4 = A_0.GetAttribute(BookmarkStart.b("央倰弲䀴制", num), this.dictionary_18[BookmarkStart.b("堮", num)]);
                        SdtListItem item = new SdtListItem(attribute, str4);
                        A_1.ListItems.Add(item);
                    }
                    if (!flag)
                    {
                        A_0.Read();
                    }
                }
                else
                {
                    A_0.Read();
                }
                this.method_485(A_0);
            }
        }
    }

    private void method_312(XmlReader A_0, SdtDate A_1)
    {
        int num = 11;
        while (A_0.NodeType != XmlNodeType.Element)
        {
            A_0.Read();
            this.method_485(A_0);
        }
        if (!A_0.IsEmptyElement)
        {
            bool flag = false;
            string localName = A_0.LocalName;
            A_0.Read();
            this.method_485(A_0);
            while (A_0.LocalName != localName)
            {
                if (A_0.EOF)
                {
                    break;
                }
                flag = false;
                if (A_0.NodeType == XmlNodeType.Element)
                {
                    string str3 = A_0.LocalName;
                    if (str3 != null)
                    {
                        if (str3 != BookmarkStart.b("唰刲䄴制缸吺似刾⁀㝂", num))
                        {
                            if (!(str3 == BookmarkStart.b("崰娲儴", num)))
                            {
                                if (str3 == BookmarkStart.b("到刲头制圸强尼䴾", num))
                                {
                                    A_1.CalendarType = this.method_313(A_0.GetAttribute(BookmarkStart.b("䜰刲头", num), this.dictionary_18[BookmarkStart.b("䘰", num)]));
                                }
                            }
                            else
                            {
                                string attribute = A_0.GetAttribute(BookmarkStart.b("䜰刲头", num), this.dictionary_18[BookmarkStart.b("䘰", num)]);
                                if (!string.IsNullOrEmpty(attribute) && this.method_398(attribute))
                                {
                                    A_1.Lid = this.method_399(attribute);
                                }
                            }
                        }
                        else
                        {
                            A_1.DateFormat = A_0.GetAttribute(BookmarkStart.b("䜰刲头", num), this.dictionary_18[BookmarkStart.b("䘰", num)]);
                        }
                    }
                    if (!flag)
                    {
                        A_0.Read();
                    }
                }
                else
                {
                    A_0.Read();
                }
                this.method_485(A_0);
            }
        }
    }

    private CalendarType method_313(string A_0)
    {
        int num = 0x12;
        string key = A_0;
        if (key != null)
        {
            int num2;
            if (Class1160.dictionary_80 == null)
            {
                Dictionary<string, int> dictionary1 = new Dictionary<string, int>(13);
                dictionary1.Add(BookmarkStart.b("強䠹夻夽⼿ぁⵃ❅♇", num), 0);
                dictionary1.Add(BookmarkStart.b("強䠹夻夽⼿ぁⵃ❅♇୉㹋⽍㉏㭑㝓", num), 1);
                dictionary1.Add(BookmarkStart.b("強䠹夻夽⼿ぁⵃ❅♇݉⥋ࡍ≏㝑㩓㕕し", num), 2);
                dictionary1.Add(BookmarkStart.b("強䠹夻夽⼿ぁⵃ❅♇Ὁ㽋", num), 3);
                dictionary1.Add(BookmarkStart.b("強䠹夻夽⼿ぁⵃ❅♇቉⁋❍⑏ᝑ㩓ㅕ㑗㍙⽛㙝", num), 4);
                dictionary1.Add(BookmarkStart.b("強䠹夻夽⼿ぁⵃ❅♇቉⁋❍⑏ᑑ♓㍕㙗㥙㑛", num), 5);
                dictionary1.Add(BookmarkStart.b("倷弹帻䰽┿㕁", num), 6);
                dictionary1.Add(BookmarkStart.b("倷匹嘻䰽⤿", num), 7);
                dictionary1.Add(BookmarkStart.b("刷嬹䰻弽⸿", num), 8);
                dictionary1.Add(BookmarkStart.b("匷唹主嬽ℿ", num), 9);
                dictionary1.Add(BookmarkStart.b("䬷嬹圻弽", num), 10);
                dictionary1.Add(BookmarkStart.b("䰷嬹唻䤽ℿⱁ", num), 11);
                dictionary1.Add(BookmarkStart.b("䰷刹崻圽", num), 12);
                Class1160.dictionary_80 = dictionary1;
            }
            if (Class1160.dictionary_80.TryGetValue(key, out num2))
            {
                switch (num2)
                {
                    case 0:
                        return CalendarType.Default;

                    case 1:
                        return CalendarType.GregorianArabic;

                    case 2:
                        return CalendarType.GregorianMiddleEastFrench;

                    case 3:
                        return CalendarType.GregorianEnglish;

                    case 4:
                        return CalendarType.GregorianTransliteratedEnglish;

                    case 5:
                        return CalendarType.GregorianTransliteratedFrench;

                    case 6:
                        return CalendarType.Hebrew;

                    case 7:
                        return CalendarType.Hijri;

                    case 8:
                        return CalendarType.Japan;

                    case 9:
                        return CalendarType.Korean;

                    case 10:
                        return CalendarType.Saka;

                    case 11:
                        return CalendarType.Taiwan;

                    case 12:
                        return CalendarType.Thai;
                }
            }
        }
        return CalendarType.None;
    }

    private void method_314(Stream A_0)
    {
        XmlReader reader = Class57.smethod_18(A_0);
        this.method_315(reader, this.method_16());
    }

    private void method_315(XmlReader A_0, Dictionary<string, DictionaryEntry> A_1)
    {
        int num = 4;
        this.method_316(A_0, BookmarkStart.b("砩䤫䈭儯䘱崳夵嘷䤹吻圽〿ㅁ", 4));
        if (A_0.LocalName != BookmarkStart.b("砩䤫䈭儯䘱崳夵嘷䤹吻圽〿ㅁ", 4))
        {
            A_0.ReadInnerXml();
        }
        else if (!A_0.IsEmptyElement)
        {
            string key = null;
            string attribute = null;
            string str3 = null;
            while (true)
            {
                A_0.Read();
                this.method_485(A_0);
                key = A_0.GetAttribute(BookmarkStart.b("挩䠫", num));
                attribute = A_0.GetAttribute(BookmarkStart.b("縩䴫尭圯圱䀳", num));
                str3 = A_0.GetAttribute(BookmarkStart.b("縩唫席唯", num));
                if ((key != null) && ((attribute != null) && (str3 != null)))
                {
                    bool flag;
                    if (attribute.StartsWith(BookmarkStart.b("ԩ", num)))
                    {
                        attribute = attribute.Remove(0, 1);
                    }
                    DictionaryEntry entry = new DictionaryEntry(str3, attribute);
                    A_1.Add(key, entry);
                    if (str3.Equals(BookmarkStart.b("䈩堫娭䀯࠱ᬳᤵ䬷夹吻嬽ⴿ⍁㝃桅❇㩉⥋⁍⡏㽑㡓さ㝗⡙ㅛ㽝ᑟᅡ䩣॥ᩧ൩䍫ŭᙯᑱᵳᕵᵷ㹹፻ᵽﲇꖉ뺋뺍ꂏ꒑뮓ﶗﶛ즟춡쪣향삧쎩\udcab\uddad龯톱솳억첷햹톻궿껁", num)) && !this.method_17().Contains(attribute))
                    {
                        this.method_17().Add(attribute);
                    }
                    if ((flag = A_0.GetAttribute(BookmarkStart.b("縩䴫尭圯圱䀳笵圷帹夻", num)) == BookmarkStart.b("漩含娭唯䀱娳圵吷", num)) && !this.method_18().ContainsKey(key))
                    {
                        this.method_18().Add(key, flag);
                    }
                }
                if (A_0.LocalName == BookmarkStart.b("砩䤫䈭儯䘱崳夵嘷䤹吻圽〿ㅁ", num))
                {
                    this.method_317();
                    return;
                }
            }
        }
    }

    private void method_316(XmlReader A_0, string A_1)
    {
        A_0.MoveToContent();
        this.stack_4.Push(this.string_6);
        this.string_6 = A_1;
        this.method_65(A_0);
        A_0.MoveToContent();
        this.dictionary_18 = this.document_0.DocxNameSpace.method_0()[this.string_6];
    }

    private void method_317()
    {
        this.string_6 = this.stack_4.Pop();
        this.dictionary_18 = string.IsNullOrEmpty(this.string_6) ? null : this.document_0.DocxNameSpace.method_0()[this.string_6];
    }

    private void method_318(Class1129 A_0)
    {
        Class1128 class2 = A_0.method_18(BookmarkStart.b("䀶嘸䤺夼ှ♀⽂⩄㑆㩈⩊㽌㙎繐", 0x11));
        if (class2.method_3().ToLower(CultureInfo.InvariantCulture).Equals(BookmarkStart.b("倶唸吺丼䰾⁀ㅂ㱄框", 0x11)) && (class2.method_0().Count > 0))
        {
            this.document_0.GlossaryContainer = class2;
        }
    }

    private void method_319(Class1129 A_0)
    {
        int num = 7;
        foreach (KeyValuePair<string, Class230> pair in A_0.method_15())
        {
            Dictionary<string, DictionaryEntry> dictionary2 = new Dictionary<string, DictionaryEntry>();
            XmlReader reader = XmlReader.Create(pair.Value.method_4());
            this.method_315(reader, dictionary2);
            reader = null;
            dictionary2 = null;
            pair.Value.method_4().Position = 0L;
        }
        Class1128 class2 = A_0.method_18(BookmarkStart.b("丬娮䈰䜲娴娶永爺ሼ", num));
        if (class2.method_0().ContainsKey(BookmarkStart.b("丬娮䈰䜲娴娶永爺ጼ䜾ⱀ⽂", num)))
        {
            this.document_0.CustomUIPartContainer = class2;
        }
        class2 = A_0.method_18(BookmarkStart.b("丬娮䈰䜲娴娶愸嘺儼ှ", num));
        if (((class2.method_2().Count == 0) && (class2.method_0().Count == 0)) && (class2.method_1().Count == 0))
        {
            class2 = A_0.method_18(BookmarkStart.b("丬娮䈰䜲娴娶愸瘺焼ှ", num));
        }
        if (class2.method_3().ToLower(CultureInfo.InvariantCulture).Equals(BookmarkStart.b("丬娮䈰䜲娴娶䄸嘺儼ှ", num)))
        {
            this.document_0.CustomXMLContainer = class2;
        }
        if (this.method_17().Count > 0)
        {
            foreach (string str in this.method_17())
            {
                this.method_320(A_0, str);
            }
        }
    }

    private void method_32(Class1129 A_0, Document A_1)
    {
        A_1.DocxPackage = A_0;
        this.method_33(A_1);
        this.method_50(A_0);
        this.method_318(A_0);
        this.method_319(A_0);
        this.method_35(A_0);
    }

    private void method_320(Class1129 A_0, string A_1)
    {
        int num = 1;
        A_1 = A_1.Replace(BookmarkStart.b("दܨЪ", 1), string.Empty);
        string str = string.Empty;
        string str2 = A_1;
        int num2 = A_1.LastIndexOf(BookmarkStart.b("ࠦ", 1));
        if (num2 > -1)
        {
            str = A_1.Substring(0, num2 + 1);
            str2 = A_1.Substring(num2 + 1);
        }
        string str4 = str + BookmarkStart.b("砦嬨个䄬尮Ḱ", num) + str2 + BookmarkStart.b("द嬨个䄬尮", num);
        Class1128 class2 = A_0.method_18(str);
        if (class2 == null)
        {
            return;
        }
        Class229 class4 = class2.method_12(str2);
        if (class4 == null)
        {
            return;
        }
        CustomXmlPart part = new CustomXmlPart {
            Data = Class57.smethod_5(class4.method_4())
        };
        Class230 class5 = class2.method_13(str4);
        if (class5 == null)
        {
            goto Label_018E;
        }
        Dictionary<string, DictionaryEntry> dictionary = new Dictionary<string, DictionaryEntry>();
        using (XmlReader reader = XmlReader.Create(class5.method_4()))
        {
            this.method_315(reader, dictionary);
        }
        using (Dictionary<string, DictionaryEntry>.Enumerator enumerator = dictionary.GetEnumerator())
        {
            string str3;
            Class229 class3;
            while (enumerator.MoveNext())
            {
                KeyValuePair<string, DictionaryEntry> current = enumerator.Current;
                if (((string) current.Value.Key).Equals(BookmarkStart.b("伦崨弪崬ᔮḰᰲ䘴吶儸帺值帾㉀浂⩄㝆ⱈ╊㕌≎㵐㕒㩔╖㑘㩚⥜ⱞ你ౢᝤf䙨Ѫ୬८ᡰၲၴ㍶ᙸ᡺ࡼቾꢆ뮈뮊붌릎뺐ﮖ쾠킢춤캦\ud9a8\ud8aa芬첮쒰삲솴\ud8b6\ud4b8킼펾釀뇂꫄럆뫈", num)))
                {
                    str3 = (string) current.Value.Value;
                    if (class2.method_0().ContainsKey(str3))
                    {
                        goto Label_0158;
                    }
                }
            }
            goto Label_018B;
        Label_0158:
            class3 = class2.method_0()[str3];
            if (class3 != null)
            {
                this.method_321(class3.method_4(), part);
            }
        }
    Label_018B:
        dictionary = null;
    Label_018E:
        this.document_0.CustomXmlParts.Add(part);
    }

    private void method_321(Stream A_0, CustomXmlPart A_1)
    {
        int num = 1;
        if (A_0.Length != 0L)
        {
            XmlReader reader2 = XmlReader.Create(A_0);
            reader2.Read();
            this.method_485(reader2);
            while (!reader2.EOF)
            {
                bool flag = false;
                string localName = reader2.LocalName;
                if (localName != null)
                {
                    if (localName != BookmarkStart.b("䌦䠨弪䰬尮䔰尲䜴制瀸伺堼刾", num))
                    {
                        if (localName == BookmarkStart.b("否䨨䌪䠬䈮倰愲倴儶䨸", num))
                        {
                            MemoryStream input = Class57.smethod_22(reader2);
                            input.Position = 0L;
                            using (XmlReader reader = XmlReader.Create(input))
                            {
                                this.method_322(reader, A_1);
                            }
                            flag = true;
                        }
                    }
                    else if (reader2.HasAttributes)
                    {
                        while (reader2.MoveToNextAttribute())
                        {
                            string str2;
                            if (((str2 = reader2.LocalName) != null) && (str2 == BookmarkStart.b("並崨个䀬昮田", num)))
                            {
                                A_1.Id = reader2.Value;
                            }
                        }
                    }
                }
                if (!flag)
                {
                    reader2.Read();
                }
                this.method_485(reader2);
            }
        }
    }

    private void method_322(XmlReader A_0, CustomXmlPart A_1)
    {
        int num = 1;
        if (A_0 != null)
        {
            while (A_0.NodeType != XmlNodeType.Element)
            {
                A_0.Read();
                this.method_485(A_0);
            }
            if (!A_0.IsEmptyElement)
            {
                string localName = A_0.LocalName;
                A_0.Read();
                this.method_485(A_0);
                while (!A_0.LocalName.Equals(localName))
                {
                    string str2;
                    if (((str2 = A_0.LocalName) != null) && (str2 == BookmarkStart.b("否䨨䌪䠬䈮倰愲倴儶", num)))
                    {
                        this.method_323(A_0, A_1);
                    }
                    A_0.Read();
                    this.method_485(A_0);
                }
            }
        }
    }

    private void method_323(XmlReader A_0, CustomXmlPart A_1)
    {
        int num = 12;
        while (A_0.MoveToNextAttribute())
        {
            string str;
            if (((str = A_0.LocalName) != null) && (str == BookmarkStart.b("䜱䘳張", num)))
            {
                A_1.Schemas.method_3(A_0.Value);
            }
        }
    }

    private void method_324(XmlReader A_0)
    {
        int num = 8;
        if (A_0 != null)
        {
            while (A_0.NodeType != XmlNodeType.Element)
            {
                A_0.Read();
            }
            if (A_0.LocalName != BookmarkStart.b("縭䈯崱䐳匵䨷丹唻嬽㌿", num))
            {
                throw new XmlException(BookmarkStart.b("笭帯圱䰳䘵崷夹䠻嬽␿扁㱃⭅⑇橉㡋⽍㝏牑", num) + A_0.LocalName);
            }
            if (A_0.IsEmptyElement)
            {
                return;
            }
            this.method_316(A_0, BookmarkStart.b("䴭䔯䄱䀳昵䨷唹䰻嬽㈿㙁ⵃ⍅㭇", num));
            CustomDocumentProperties customDocumentProperties = this.document_0.CustomDocumentProperties;
            A_0.Read();
            if (A_0.EOF)
            {
                goto Label_00DA;
            }
            while (A_0.NodeType != XmlNodeType.Element)
            {
                A_0.Skip();
            Label_009C:
                this.method_485(A_0);
                if (!A_0.EOF)
                {
                    continue;
                }
                goto Label_00DA;
            Label_00AD:
                if (A_0.LocalName == BookmarkStart.b("席䈯崱䐳匵䨷丹䔻", num))
                {
                    this.method_325(A_0, customDocumentProperties);
                }
                goto Label_009C;
            }
            goto Label_00AD;
        }
        throw new ArgumentNullException(BookmarkStart.b("尭唯匱倳匵䨷", num));
    Label_00DA:
        this.method_317();
    }

    private void method_325(XmlReader A_0, CustomDocumentProperties A_1)
    {
        int num = 7;
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("弬䨮倰圲倴䔶", num));
        }
        if (A_1 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("丬娮䈰䜲娴娶椸䤺刼伾⑀ㅂㅄ⹆ⱈ㡊", num));
        }
        if (A_0.LocalName != BookmarkStart.b("崬崮帰䌲倴䔶䴸䈺", num))
        {
            throw new XmlException(BookmarkStart.b("砬䄮吰䬲䔴制娸伺堼嬾慀㭂⡄⭆楈㽊ⱌ⡎煐", num) + A_0.LocalName);
        }
        A_0.GetAttribute(BookmarkStart.b("䌬丮尰嘲", num));
        A_0.MoveToElement();
        DocumentProperty property = null;
        string str = null;
        if ((A_0.NodeType == XmlNodeType.EndElement) || (A_0.LocalName != BookmarkStart.b("崬崮帰䌲倴䔶䴸䈺", num)))
        {
            return;
        }
        while ((A_0.NodeType != XmlNodeType.Element) || !(A_0.LocalName == BookmarkStart.b("崬崮帰䌲倴䔶䴸䈺", num)))
        {
            if ((!A_0.IsEmptyElement && (A_0.NodeType != XmlNodeType.EndElement)) && !string.IsNullOrEmpty(str))
            {
                if (A_0.HasValue)
                {
                    property = new DocumentProperty(str, this.method_328(A_0.Value));
                }
                else
                {
                    object obj2 = this.method_326(A_0);
                    property = new DocumentProperty(str, obj2);
                }
                if (!this.document_0.CustomDocumentProperties.method_6(property.Name))
                {
                    this.document_0.CustomDocumentProperties.CustomHash.Add(property.Name, property);
                }
            }
        Label_0127:
            A_0.Read();
            this.method_485(A_0);
            if (A_0.EOF || (A_0.LocalName == BookmarkStart.b("崬崮帰䌲倴䔶䴸䈺", num)))
            {
                return;
            }
        }
        if (A_0.MoveToAttribute(BookmarkStart.b("䌬丮尰嘲", num)))
        {
            str = A_0.Value;
        }
        if (A_0.MoveToAttribute(BookmarkStart.b("崬䘮唰", num)))
        {
            int.Parse(A_0.Value, CultureInfo.InvariantCulture);
        }
        goto Label_0127;
    }

    private object method_326(XmlReader A_0)
    {
        int num = 0x13;
        string localName = A_0.LocalName;
        if (localName != null)
        {
            int num2;
            if (Class1160.dictionary_81 == null)
            {
                Dictionary<string, int> dictionary1 = new Dictionary<string, int>(0x12);
                dictionary1.Add(BookmarkStart.b("嬸吺刼匾", num), 0);
                dictionary1.Add(BookmarkStart.b("唸䬺丼䬾㍀", num), 1);
                dictionary1.Add(BookmarkStart.b("唸䬺䨼䰾㕀ㅂ", num), 2);
                dictionary1.Add(BookmarkStart.b("弸刺儼娾㕀⩂⡄≆", num), 3);
                dictionary1.Add(BookmarkStart.b("崸娺䤼娾", num), 4);
                dictionary1.Add(BookmarkStart.b("倸਺", num), 5);
                dictionary1.Add(BookmarkStart.b("倸ऺ", num), 6);
                dictionary1.Add(BookmarkStart.b("倸༺", num), 7);
                dictionary1.Add(BookmarkStart.b("倸唺䤼", num), 8);
                dictionary1.Add(BookmarkStart.b("倸̺", num), 9);
                dictionary1.Add(BookmarkStart.b("䰸刺఼", num), 10);
                dictionary1.Add(BookmarkStart.b("䰸刺༼", num), 11);
                dictionary1.Add(BookmarkStart.b("䰸刺़", num), 12);
                dictionary1.Add(BookmarkStart.b("䰸刺匼䬾", num), 13);
                dictionary1.Add(BookmarkStart.b("䰸刺Լ", num), 14);
                dictionary1.Add(BookmarkStart.b("䬸༺", num), 15);
                dictionary1.Add(BookmarkStart.b("䬸̺", num), 0x10);
                dictionary1.Add(BookmarkStart.b("崸帺帼嘾ⱀ≂⥄", num), 0x11);
                Class1160.dictionary_81 = dictionary1;
            }
            if (Class1160.dictionary_81.TryGetValue(localName, out num2))
            {
                switch (num2)
                {
                    case 0:
                        return this.method_469(A_0);

                    case 1:
                    case 2:
                        return this.method_327(A_0);

                    case 3:
                    case 4:
                        return Convert.ToDateTime(this.method_327(A_0));

                    case 5:
                    case 6:
                    case 7:
                    case 8:
                        return Convert.ToInt32(this.method_327(A_0));

                    case 9:
                        return Convert.ToInt64(this.method_327(A_0));

                    case 10:
                    case 11:
                    case 12:
                    case 13:
                        return Convert.ToUInt32(this.method_327(A_0));

                    case 14:
                        return Convert.ToUInt64(this.method_327(A_0));

                    case 15:
                        return Convert.ToSingle(this.method_327(A_0));

                    case 0x10:
                        return Convert.ToDouble(this.method_327(A_0));

                    case 0x11:
                        return Convert.ToDecimal(this.method_327(A_0));
                }
            }
        }
        return this.method_327(A_0);
    }

    private string method_327(XmlReader A_0)
    {
        if ((A_0 == null) || ((A_0 != null) && A_0.IsEmptyElement))
        {
            return string.Empty;
        }
        return A_0.ReadString();
    }

    private string method_328(string A_0)
    {
        A_0 = XmlConvert.DecodeName(A_0);
        return A_0;
    }

    private void method_329(XmlReader A_0)
    {
        int num = 13;
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("䄲倴嘶崸帺似", num));
        }
        while (A_0.NodeType != XmlNodeType.Element)
        {
            A_0.Read();
        }
        if (A_0.LocalName != BookmarkStart.b("倲娴䔶尸欺似倾ㅀ♂㝄㍆⁈⹊㹌", num))
        {
            throw new XmlException(BookmarkStart.b("昲嬴制䄸䬺堼尾㕀♂⅄杆ㅈ♊⅌潎═㉒㉔睖", num) + A_0.LocalName);
        }
        if (!A_0.IsEmptyElement)
        {
            string localName = A_0.LocalName;
            this.method_316(A_0, BookmarkStart.b("倲娴䔶尸欺似倾ㅀ♂㝄㍆⁈⹊㹌", num));
            BuiltinDocumentProperties builtinDocumentProperties = this.document_0.BuiltinDocumentProperties;
            A_0.Read();
            this.method_485(A_0);
            while (A_0.LocalName != localName)
            {
                if (A_0.EOF)
                {
                    break;
                }
                if (A_0.NodeType == XmlNodeType.Element)
                {
                    string key = A_0.LocalName;
                    if (key != null)
                    {
                        int num2;
                        if (Class1160.dictionary_82 == null)
                        {
                            Dictionary<string, int> dictionary1 = new Dictionary<string, int>(11);
                            dictionary1.Add(BookmarkStart.b("倲吴䌶尸尺刼䴾㡀", num), 0);
                            dictionary1.Add(BookmarkStart.b("倲䜴制堸伺堼嬾", num), 1);
                            dictionary1.Add(BookmarkStart.b("倲䜴制堸伺刼䴾", num), 2);
                            dictionary1.Add(BookmarkStart.b("圲倴䐶娸䤺吼伾㕀⩂⩄⥆", num), 3);
                            dictionary1.Add(BookmarkStart.b("堲倴丶丸吺似嬾㉀", num), 4);
                            dictionary1.Add(BookmarkStart.b("弲吴䐶䴸瘺刼嬾⡀╂ⱄ≆ⵈॊ㑌", num), 5);
                            dictionary1.Add(BookmarkStart.b("弲吴䐶䴸欺似嘾⽀㝂⁄⍆", num), 6);
                            dictionary1.Add(BookmarkStart.b("帲娴匶倸崺吼娾╀", num), 7);
                            dictionary1.Add(BookmarkStart.b("䀲䀴唶匸帺帼䬾", num), 8);
                            dictionary1.Add(BookmarkStart.b("䜲尴䌶唸帺", num), 9);
                            dictionary1.Add(BookmarkStart.b("䄲倴䄶倸䠺吼倾⽀", num), 10);
                            Class1160.dictionary_82 = dictionary1;
                        }
                        if (Class1160.dictionary_82.TryGetValue(key, out num2))
                        {
                            switch (num2)
                            {
                                case 0:
                                {
                                    builtinDocumentProperties.Category = this.method_472(A_0);
                                    continue;
                                }
                                case 1:
                                {
                                    builtinDocumentProperties.CreateDate = DateTime.Parse(this.method_472(A_0));
                                    continue;
                                }
                                case 2:
                                {
                                    builtinDocumentProperties.Author = this.method_472(A_0);
                                    continue;
                                }
                                case 3:
                                {
                                    builtinDocumentProperties.Comments = this.method_472(A_0);
                                    continue;
                                }
                                case 4:
                                {
                                    builtinDocumentProperties.Keywords = this.method_472(A_0);
                                    continue;
                                }
                                case 5:
                                {
                                    builtinDocumentProperties.LastAuthor = this.method_472(A_0);
                                    continue;
                                }
                                case 6:
                                {
                                    builtinDocumentProperties.LastPrinted = DateTime.Parse(this.method_472(A_0));
                                    continue;
                                }
                                case 7:
                                {
                                    builtinDocumentProperties.LastSaveDate = DateTime.Parse(this.method_472(A_0));
                                    continue;
                                }
                                case 8:
                                {
                                    builtinDocumentProperties.Subject = this.method_472(A_0);
                                    continue;
                                }
                                case 9:
                                {
                                    builtinDocumentProperties.Title = this.method_472(A_0);
                                    continue;
                                }
                                case 10:
                                {
                                    builtinDocumentProperties.RevisionNumber = this.method_472(A_0);
                                    continue;
                                }
                            }
                        }
                    }
                    A_0.Skip();
                }
                else
                {
                    A_0.Skip();
                }
            }
            this.method_317();
        }
    }

    private void method_33(Document A_0)
    {
        int num = 5;
        if (this.bool_13)
        {
            A_0.DetectedFormatType = FileFormat.WordXml;
        }
        else
        {
            bool flag = false;
            A_0.DetectedFormatType = FileFormat.Docx;
            XmlReader reader = XmlReader.Create(A_0.DocxPackage.method_0()[BookmarkStart.b("瀪測䀮弰䜲倴夶䴸携椼䘾ㅀ♂㙄ᩆ杈㍊⁌⍎", num)].method_4());
            while (reader.NodeType != XmlNodeType.Element)
            {
                reader.Read();
            }
            if (reader.LocalName != BookmarkStart.b("缪听弮吰䀲", num))
            {
                throw new XmlException(BookmarkStart.b("渪唬弮吰倲䄴制崸ᬺ䔼刾ⵀ捂ㅄ♆⹈歊潌᭎⡐⍒ご⑖筘", num));
            }
            reader.Read();
            while (reader.LocalName != BookmarkStart.b("缪听弮吰䀲", num))
            {
                if ((reader.LocalName == BookmarkStart.b("搪嬬䨮䌰䄲尴匶尸", num)) && reader.HasAttributes)
                {
                    string attribute = reader.GetAttribute(BookmarkStart.b("笪䰬崮䔰紲吴娶尸", num));
                    string str = reader.GetAttribute(BookmarkStart.b("株䈬䄮䔰嘲嬴䌶洸䈺䴼娾", num));
                    if (attribute.StartsWith(BookmarkStart.b("Ъ娬䀮䌰圲ᨴ匶嘸堺䠼刾⑀ⵂㅄ", num)) && str.EndsWith(BookmarkStart.b("Ԫ䀬丮堰崲Ḵ伶吸场", num)))
                    {
                        this.string_5 = attribute;
                        flag = true;
                        if (str == BookmarkStart.b("䨪崬弮崰娲嘴嘶䴸刺刼儾湀㕂⭄⍆杈⑊㵌⩎㽐⭒㡔㭖㽘㑚⽜㉞`ᝢᙤ䩦٨൪୬ٮተᙲᅴᡶ᩸๺ၼ᩾ꮄ力ﾎﲒ욠캢즤覦\udda8\uceaa사\udfae\uddb0튲솴튶鞸횺\udcbc\ud6be꿀뷄꫆ꗈ", num))
                        {
                            A_0.DetectedFormatType = FileFormat.Dotx2010;
                            break;
                        }
                        if (str == BookmarkStart.b("䨪崬弮崰娲嘴嘶䴸刺刼儾湀㕂⭄⍆杈♊㹌扎♐㱒❔㍖睘⽚㡜㉞ᅠརѤ፦౨䕪l๮ተŲᩴ㉶᝸᩺ὼ፾톄ﮊ뮔殺뒞\ud9a0\ucea2즤", num))
                        {
                            A_0.DetectedFormatType = FileFormat.Dotm2010;
                            break;
                        }
                        if (str == BookmarkStart.b("䨪崬弮崰娲嘴嘶䴸刺刼儾湀㕂⭄⍆杈♊㹌扎♐㱒❔㍖睘㽚㉜㱞ᑠ๢d०ᵨ䕪l๮ተŲᩴ㉶᝸᩺ὼ፾ꮄ꒎ﺒ璉", num))
                        {
                            A_0.DetectedFormatType = FileFormat.Docm2010;
                            break;
                        }
                    }
                }
                reader.Read();
            }
            A_0.DocxPackage.method_0()[BookmarkStart.b("瀪測䀮弰䜲倴夶䴸携椼䘾ㅀ♂㙄ᩆ杈㍊⁌⍎", num)].method_4().Position = 0L;
            if (!flag && (A_0.DocxPackage.method_19(BookmarkStart.b("尪䈬崮唰ᰲ儴堶娸为值娾⽀㝂歄㽆⑈❊", num)) != null))
            {
                flag = true;
            }
            if (!flag)
            {
                throw new XmlException(BookmarkStart.b("缪䔬䘮䈰ጲ尴䐶ᤸ唺刼䬾慀≂敄͆♈⡊㕌潎㕐㱒㙔≖㑘㹚㍜⭞你", num));
            }
        }
    }

    private void method_330(XmlReader A_0)
    {
        int num = 9;
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("崮吰刲儴制䬸", num));
        }
        while (A_0.NodeType != XmlNodeType.Element)
        {
            A_0.Read();
        }
        if (A_0.LocalName != BookmarkStart.b("缮䌰尲䔴制䬸伺吼娾㉀", num))
        {
            throw new XmlException(BookmarkStart.b("種弰嘲䴴䜶尸堺䤼娾╀捂㵄⩆╈歊㥌⹎㙐獒", num) + A_0.LocalName);
        }
        if (!A_0.IsEmptyElement)
        {
            string localName = A_0.LocalName;
            this.method_316(A_0, BookmarkStart.b("丮䄰䌲攴䔶嘸䬺堼䴾㕀⩂⁄㑆", num));
            BuiltinDocumentProperties builtinDocumentProperties = this.document_0.BuiltinDocumentProperties;
            A_0.Read();
            while (A_0.LocalName != localName)
            {
                if (A_0.EOF)
                {
                    break;
                }
                if (A_0.NodeType == XmlNodeType.Element)
                {
                    string s = null;
                    string key = A_0.LocalName;
                    if (key != null)
                    {
                        int num2;
                        if (Class1160.dictionary_83 == null)
                        {
                            Dictionary<string, int> dictionary1 = new Dictionary<string, int>(12);
                            dictionary1.Add(BookmarkStart.b("笮吰帲䔴嬶堸伺堼", num), 0);
                            dictionary1.Add(BookmarkStart.b("笮帰䜲吴嬶洸刺值娾", num), 1);
                            dictionary1.Add(BookmarkStart.b("缮倰吲倴䐶", num), 2);
                            dictionary1.Add(BookmarkStart.b("砮帰䄲儴䐶", num), 3);
                            dictionary1.Add(BookmarkStart.b("氮夰刲䜴嘶娸伺堼䴾㉀", num), 4);
                            dictionary1.Add(BookmarkStart.b("氮夰刲䜴嘶娸伺堼䴾㉀ᑂⱄ㍆ⅈᡊ㵌⹎㉐㙒♔", num), 5);
                            dictionary1.Add(BookmarkStart.b("渮䄰䌲头帶娸娺䤼嘾⹀ⵂ", num), 6);
                            dictionary1.Add(BookmarkStart.b("欮帰倲昴制娸为似嘾㕀㩂", num), 7);
                            dictionary1.Add(BookmarkStart.b("挮堰崲倴䐶", num), 8);
                            dictionary1.Add(BookmarkStart.b("缮倰䄲吴倶䬸娺䴼圾㉀", num), 9);
                            dictionary1.Add(BookmarkStart.b("氮帰帲䔴嘶圸䈺", num), 10);
                            dictionary1.Add(BookmarkStart.b("戮倰崲吴倶尸䤺", num), 11);
                            Class1160.dictionary_83 = dictionary1;
                        }
                        if (Class1160.dictionary_83.TryGetValue(key, out num2))
                        {
                            switch (num2)
                            {
                                case 0:
                                {
                                    builtinDocumentProperties.Template = this.method_472(A_0);
                                    continue;
                                }
                                case 1:
                                {
                                    s = this.method_472(A_0).Replace(BookmarkStart.b("̮", num), string.Empty);
                                    builtinDocumentProperties.TotalEditingTime = TimeSpan.FromMinutes(Math.Round((double) XmlConvert.ToSingle(s)));
                                    continue;
                                }
                                case 2:
                                {
                                    s = this.method_472(A_0);
                                    builtinDocumentProperties.method_6(PIDSI.Pagecount, int.Parse(s, NumberStyles.Integer, CultureInfo.InvariantCulture));
                                    continue;
                                }
                                case 3:
                                {
                                    s = this.method_472(A_0);
                                    builtinDocumentProperties.method_6(PIDSI.Wordcount, int.Parse(s, NumberStyles.Integer, CultureInfo.InvariantCulture));
                                    continue;
                                }
                                case 4:
                                {
                                    s = this.method_472(A_0);
                                    builtinDocumentProperties.method_6(PIDSI.Charcount, int.Parse(s, NumberStyles.Integer, CultureInfo.InvariantCulture));
                                    continue;
                                }
                                case 5:
                                {
                                    s = this.method_472(A_0);
                                    builtinDocumentProperties.CharCountWithSpace = int.Parse(s, NumberStyles.Integer, CultureInfo.InvariantCulture);
                                    continue;
                                }
                                case 6:
                                {
                                    builtinDocumentProperties.ApplicationName = this.method_472(A_0);
                                    continue;
                                }
                                case 7:
                                {
                                    s = this.method_472(A_0);
                                    builtinDocumentProperties.DocSecurity = int.Parse(s, NumberStyles.Integer, CultureInfo.InvariantCulture);
                                    continue;
                                }
                                case 8:
                                {
                                    s = this.method_472(A_0);
                                    builtinDocumentProperties.method_9(PIDDSI.LineCount, int.Parse(s, NumberStyles.Integer, CultureInfo.InvariantCulture));
                                    continue;
                                }
                                case 9:
                                {
                                    s = this.method_472(A_0);
                                    builtinDocumentProperties.method_9(PIDDSI.ParCount, int.Parse(s, NumberStyles.Integer, CultureInfo.InvariantCulture));
                                    continue;
                                }
                                case 10:
                                {
                                    builtinDocumentProperties.Company = this.method_472(A_0);
                                    continue;
                                }
                                case 11:
                                {
                                    builtinDocumentProperties.Manager = this.method_472(A_0);
                                    continue;
                                }
                            }
                        }
                    }
                    A_0.Skip();
                }
                else
                {
                    A_0.Skip();
                }
            }
            this.method_317();
        }
    }

    private void method_331(XmlReader A_0, FormatBase A_1)
    {
        int num = 10;
        ParagraphFormat format = A_1 as ParagraphFormat;
        if (format.OwnerBase == null)
        {
            return;
        }
        bool flag = false;
        ListFormat listFormat = null;
        if (format.OwnerBase is Paragraph)
        {
            listFormat = (format.OwnerBase as Paragraph).ListFormat;
        }
        else if (format.OwnerBase is ParagraphStyle)
        {
            listFormat = (format.OwnerBase as ParagraphStyle).ListFormat;
            flag = true;
        }
        else if (format.OwnerBase is Class13)
        {
            listFormat = (format.OwnerBase as Class13).method_23();
        }
        this.method_333(A_0, listFormat);
        if (!flag)
        {
            return;
        }
        string str3 = null;
        if (listFormat.CurrentListLevel == null)
        {
            if ((format.OwnerBase is ParagraphStyle) && (listFormat.ListLevelNumber > 0))
            {
                ListStyle style = this.method_332(format.OwnerBase as ParagraphStyle);
                if ((style != null) && (style.Levels.Count > listFormat.ListLevelNumber))
                {
                    str3 = (format.OwnerBase as ParagraphStyle).StyleId.Replace(BookmarkStart.b("ု", num), string.Empty);
                    style.Levels[listFormat.ListLevelNumber].ParaStyleName = str3;
                }
            }
            return;
        }
        string styleId = (format.OwnerBase as ParagraphStyle).StyleId;
        using (Dictionary<string, string>.KeyCollection.Enumerator enumerator = this.method_22().Keys.GetEnumerator())
        {
            while (enumerator.MoveNext())
            {
                string current = enumerator.Current;
                if (current.Equals(styleId))
                {
                    goto Label_00DF;
                }
            }
            goto Label_00F3;
        Label_00DF:
            str3 = styleId;
        }
    Label_00F3:
        if (listFormat.OwnerParagraph != null)
        {
            listFormat.CurrentListLevel.ParaStyleName = str3;
        }
    }

    private ListStyle method_332(ParagraphStyle A_0)
    {
        ParagraphStyle baseStyle = A_0.BaseStyle;
        if (baseStyle != null)
        {
            while (baseStyle != null)
            {
                if (baseStyle.ListFormat.CurrentListStyle != null)
                {
                    return baseStyle.ListFormat.CurrentListStyle;
                }
                baseStyle = baseStyle.BaseStyle;
            }
            return null;
        }
        return null;
    }

    private void method_333(XmlReader A_0, ListFormat A_1)
    {
        int num = 15;
        string localName = A_0.LocalName;
        A_0.Read();
        while (A_0.LocalName != localName)
        {
            string str4;
            if ((A_0.NodeType == XmlNodeType.Element) && ((str4 = A_0.LocalName) != null))
            {
                if (str4 != BookmarkStart.b("尴嬶伸场", num))
                {
                    if (str4 == BookmarkStart.b("嬴䈶吸爺夼", num))
                    {
                        string attribute = A_0.GetAttribute(BookmarkStart.b("䌴嘶唸", num), this.dictionary_18[BookmarkStart.b("䈴", num)]);
                        if (!string.IsNullOrEmpty(attribute))
                        {
                            if (attribute == BookmarkStart.b("Դ", num))
                            {
                                A_1.IsEmptyList = true;
                            }
                            else if (this.method_13().ContainsKey(attribute))
                            {
                                string name = this.method_13()[attribute];
                                ListStyle style = this.document_0.ListStyles.FindByName(name);
                                if (((this.dictionary_8 != null) && (style.BaseListStyleName != null)) && ((style.BaseListStyleName != string.Empty) && this.dictionary_8.ContainsKey(style.BaseListStyleName)))
                                {
                                    string key = this.dictionary_8[style.BaseListStyleName];
                                    if (this.method_13().ContainsKey(key))
                                    {
                                        name = this.method_13()[key];
                                    }
                                }
                                if (name != null)
                                {
                                    A_1.ApplyStyle(name);
                                }
                                if (this.method_12().ContainsKey(attribute))
                                {
                                    A_1.LFOStyleName = this.method_12()[attribute];
                                }
                            }
                        }
                    }
                }
                else
                {
                    string str6 = A_0.GetAttribute(BookmarkStart.b("䌴嘶唸", num), this.dictionary_18[BookmarkStart.b("䈴", num)]);
                    if (!string.IsNullOrEmpty(str6))
                    {
                        int num2 = int.Parse(str6);
                        if (num2 > 8)
                        {
                            num2 = 8;
                        }
                        A_1.ListLevelNumber = num2;
                    }
                }
            }
            A_0.Read();
        }
    }

    private void method_334(XmlReader A_0)
    {
        int num = 6;
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("師䬭儯嘱儳䐵", num));
        }
        if (!A_0.IsEmptyElement)
        {
            while (A_0.NodeType != XmlNodeType.Element)
            {
                A_0.Read();
            }
            if (A_0.LocalName != BookmarkStart.b("䈫嬭崯倱儳䐵儷吹嬻", num))
            {
                throw new XmlException(BookmarkStart.b("礫䀭唯䨱䐳匵嬷丹夻娽怿㩁⥃⩅桇㹉ⵋ⥍灏", num) + A_0.LocalName);
            }
            string localName = A_0.LocalName;
            this.method_316(A_0, BookmarkStart.b("䈫嬭崯倱儳䐵儷吹嬻", num));
            bool flag = false;
            A_0.Read();
            this.method_485(A_0);
            while (A_0.LocalName != localName)
            {
                if (A_0.EOF)
                {
                    break;
                }
                flag = false;
                if (A_0.NodeType == XmlNodeType.Element)
                {
                    string str2 = A_0.LocalName;
                    if (str2 != null)
                    {
                        if (str2 != BookmarkStart.b("䈫嬭崯戱崳唵稷伹倻刽┿㙁", num))
                        {
                            if (!(str2 == BookmarkStart.b("䴫䰭䌯䘱䘳圵嬷丹爻䬽ⴿ", num)))
                            {
                                if (str2 == BookmarkStart.b("䈫嬭崯", num))
                                {
                                    flag = this.method_336(A_0);
                                }
                            }
                            else
                            {
                                this.method_340(A_0);
                            }
                        }
                        else
                        {
                            this.method_352(this.method_335(A_0));
                            flag = true;
                        }
                    }
                    if (!flag)
                    {
                        A_0.Read();
                    }
                }
                else
                {
                    A_0.Read();
                }
                this.method_485(A_0);
            }
        }
        else
        {
            return;
        }
        this.method_317();
    }

    private XmlReader method_335(XmlReader A_0)
    {
        MemoryStream stream = this.method_484(A_0);
        stream.Position = 0L;
        return Class57.smethod_18(stream);
    }

    private bool method_336(XmlReader A_0)
    {
        int num = 1;
        if (A_0 == null)
        {
            throw new ArgumentException(BookmarkStart.b("唦䰨䨪䤬䨮䌰", num));
        }
        if (A_0.LocalName != BookmarkStart.b("䤦尨䘪", num))
        {
            throw new XmlException(BookmarkStart.b("爦䜨个唬弮吰倲䄴制崸ᬺ䔼刾ⵀ捂ㅄ♆⹈歊", num) + A_0.LocalName);
        }
        if (A_0.IsEmptyElement)
        {
            return false;
        }
        string localName = A_0.LocalName;
        string attribute = A_0.GetAttribute(BookmarkStart.b("䤦尨䘪搬䬮", num), this.dictionary_18[BookmarkStart.b("倦", num)]);
        bool flag = false;
        A_0.Read();
        this.method_485(A_0);
        while (A_0.LocalName != localName)
        {
            if (A_0.EOF)
            {
                break;
            }
            flag = false;
            if (A_0.NodeType == XmlNodeType.Element)
            {
                string str4 = A_0.LocalName;
                if (str4 != null)
                {
                    if (!(str4 == BookmarkStart.b("䘦䬨堪夬崮倰倲䄴礶䰸嘺琼嬾", num)))
                    {
                        if (str4 == BookmarkStart.b("䬦弨䜪戬央吰䄲䜴帶崸帺", num))
                        {
                            flag = this.method_337(A_0, attribute);
                        }
                    }
                    else
                    {
                        string key = A_0.GetAttribute(BookmarkStart.b("儦䠨䜪", num), this.dictionary_18[BookmarkStart.b("倦", num)]);
                        if (this.method_14().ContainsKey(key) && !this.method_13().ContainsKey(attribute))
                        {
                            this.method_13().Add(attribute, this.method_14()[key]);
                        }
                    }
                }
                if (!flag)
                {
                    A_0.Read();
                }
            }
            else
            {
                A_0.Read();
            }
        }
        return ((A_0.LocalName == BookmarkStart.b("䤦尨䘪", num)) && (A_0.NodeType == XmlNodeType.Element));
    }

    private bool method_337(XmlReader A_0, string A_1)
    {
        int num = 7;
        if (A_0 == null)
        {
            throw new ArgumentException(BookmarkStart.b("弬䨮倰圲倴䔶", num));
        }
        if (A_0.LocalName != BookmarkStart.b("䄬央崰簲䌴制䬸䤺吼嬾⑀", num))
        {
            throw new XmlException(BookmarkStart.b("砬䄮吰䬲䔴制娸伺堼嬾慀㭂⡄⭆楈㽊ⱌ⡎煐", num) + A_0.LocalName);
        }
        if (A_0.IsEmptyElement && (A_0.AttributeCount == 0))
        {
            return false;
        }
        bool flag = false;
        Class12 class2 = null;
        if (!this.method_12().ContainsKey(A_1))
        {
            class2 = new Class12(this.document_0, int.Parse(A_1)) {
                Name = BookmarkStart.b("愬䤮帰怲䄴丶唸帺戼", num) + Guid.NewGuid()
            };
            this.method_12().Add(A_1, class2.Name);
            this.document_0.ListOverrides.method_34(class2);
            class2.method_25(this.method_13().Count);
        }
        else
        {
            class2 = this.document_0.ListOverrides.method_35(this.method_12()[A_1]);
        }
        string attribute = A_0.GetAttribute(BookmarkStart.b("䐬䌮䜰弲", num), this.dictionary_18[BookmarkStart.b("娬", num)]);
        if (attribute == null)
        {
            return flag;
        }
        int num2 = int.Parse(attribute);
        OverrideLevelFormat format = new OverrideLevelFormat(this.document_0);
        class2.method_23().method_9(num2, format);
        MemoryStream stream = this.method_484(A_0);
        if (this.method_338(stream))
        {
            stream.Position = 0L;
            XmlReader reader = Class57.smethod_18(stream);
            if (reader.LocalName == BookmarkStart.b("䄬央崰簲䌴制䬸䤺吼嬾⑀", num))
            {
                this.method_339(reader, format);
            }
        }
        return true;
    }

    private bool method_338(MemoryStream A_0)
    {
        int count = 0;
        A_0.Position = 0L;
        XmlReader reader = Class57.smethod_18(A_0);
        XmlDocument document = new XmlDocument();
        document.Load(reader);
        if ((document.ChildNodes.Count == 1) && (document.ChildNodes[0].ChildNodes.Count > 0))
        {
            count = document.ChildNodes[0].ChildNodes.Count;
        }
        return (count > 0);
    }

    private void method_339(XmlReader A_0, OverrideLevelFormat A_1)
    {
        int num = 3;
        if (A_0.LocalName != BookmarkStart.b("䔨崪䄬怮䜰嘲䜴䔶倸强堼", 3))
        {
            throw new XmlException(BookmarkStart.b("簨䔪䠬圮䄰嘲嘴䌶尸强ᴼ䜾ⱀ⽂敄㍆⡈ⱊ浌", num) + A_0.LocalName);
        }
        if (!A_0.IsEmptyElement)
        {
            string localName = A_0.LocalName;
            bool flag = false;
            A_0.Read();
            this.method_485(A_0);
            while (A_0.LocalName != localName)
            {
                if (A_0.EOF)
                {
                    break;
                }
                flag = false;
                if (A_0.NodeType == XmlNodeType.Element)
                {
                    string str3 = A_0.LocalName;
                    if (str3 != null)
                    {
                        if (!(str3 == BookmarkStart.b("娨弪䰬崮䔰簲䌴制䬸䤺吼嬾⑀", num)))
                        {
                            if (str3 == BookmarkStart.b("䔨崪䄬", num))
                            {
                                A_1.OverrideFormatting = true;
                                this.method_342(A_0, A_1.OverrideListLevel);
                            }
                        }
                        else
                        {
                            string attribute = A_0.GetAttribute(BookmarkStart.b("弨䨪䄬", num), this.dictionary_18[BookmarkStart.b("帨", num)]);
                            if (!string.IsNullOrEmpty(attribute))
                            {
                                int num2 = int.Parse(attribute);
                                A_1.StartAt = num2;
                                A_1.OverrideStartAtValue = true;
                            }
                        }
                    }
                    if (!flag)
                    {
                        A_0.Read();
                    }
                }
                else
                {
                    A_0.Read();
                }
                this.method_485(A_0);
            }
        }
    }

    internal void method_34(Class771 A_0, Class1129 A_1, Document A_2)
    {
        this.class771_0 = A_0;
        this.document_0 = A_2;
        this.method_50(A_1);
        this.method_319(A_1);
        this.method_35(A_1);
        this.class771_0.method_28();
    }

    private void method_340(XmlReader A_0)
    {
        int num = 0;
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("吥䴧䬩䠫䬭䈯", num));
        }
        while (A_0.NodeType != XmlNodeType.Element)
        {
            A_0.Read();
        }
        if (A_0.LocalName != BookmarkStart.b("䜥䨧天堫尭儯儱䀳砵䴷圹", num))
        {
            throw new XmlException(BookmarkStart.b("猥䘧伩含席唯儱䀳匵尷ᨹ䐻匽ⰿ扁ぃ❅⽇橉", num) + A_0.LocalName);
        }
        string attribute = A_0.GetAttribute(BookmarkStart.b("䜥䨧天堫尭儯儱䀳砵䴷圹画娽", num), this.dictionary_18[BookmarkStart.b("儥", num)]);
        ListStyle style = new ListStyle(this.document_0);
        this.method_341(A_0, style);
        this.document_0.ListStyles.Add(style);
        this.method_350(style);
        this.method_351(style);
        style.IsSimple = (style.Levels != null) && (style.Levels.Count == 1);
        this.method_14().Add(attribute, style.Name);
    }

    private void method_341(XmlReader A_0, ListStyle A_1)
    {
        int num = 5;
        if (A_1 == null)
        {
            throw new ArgumentException(BookmarkStart.b("䜪䐬尮䔰ጲ䘴䌶䀸场堼", num));
        }
        if (A_0.LocalName != BookmarkStart.b("䨪伬尮䔰䄲吴吶䴸町䠼刾", num))
        {
            throw new XmlException(BookmarkStart.b("縪䌬䨮䤰䌲倴吶䴸帺夼Ἶ㥀⹂⥄杆㵈⩊⩌潎", num) + A_0.LocalName);
        }
        if (!A_0.IsEmptyElement)
        {
            string localName = A_0.LocalName;
            bool flag = false;
            A_0.Read();
            this.method_485(A_0);
            while (A_0.LocalName != localName)
            {
                if (A_0.EOF)
                {
                    break;
                }
                flag = false;
                if (A_0.NodeType == XmlNodeType.Element)
                {
                    string str2 = A_0.LocalName;
                    if (str2 != null)
                    {
                        if (str2 != BookmarkStart.b("䘪堬䌮䔰娲礴制伸帺儼款㡀㍂⁄", num))
                        {
                            if (str2 != BookmarkStart.b("䔪堬䈮戰䜲䰴嬶尸眺吼儾⩀", num))
                            {
                                if (!(str2 == BookmarkStart.b("堪夬嘮崰嘲礴帶圸债", num)))
                                {
                                    if (str2 == BookmarkStart.b("䜪嬬䌮", num))
                                    {
                                        ListLevel level = new ListLevel(A_1);
                                        A_1.Levels.method_5(level);
                                        this.method_342(A_0, level);
                                    }
                                }
                                else
                                {
                                    A_1.StyleLink = A_0.GetAttribute(BookmarkStart.b("崪䰬䌮", num), this.dictionary_18[BookmarkStart.b("尪", num)]);
                                }
                            }
                            else
                            {
                                A_1.BaseListStyleName = A_0.GetAttribute(BookmarkStart.b("崪䰬䌮", num), this.dictionary_18[BookmarkStart.b("尪", num)]);
                            }
                        }
                        else if (A_0.GetAttribute(BookmarkStart.b("崪䰬䌮", num), this.dictionary_18[BookmarkStart.b("尪", num)]) == BookmarkStart.b("䌪听䴮䌰娲儴稶䰸场䤼嘾ⵀ♂㍄≆╈", num))
                        {
                            A_1.IsHybrid = true;
                        }
                    }
                    if (!flag)
                    {
                        A_0.Read();
                    }
                }
                else
                {
                    A_0.Read();
                }
                this.method_485(A_0);
            }
        }
    }

    private void method_342(XmlReader A_0, ListLevel A_1)
    {
        int num = 2;
        if (A_1 == null)
        {
            throw new ArgumentException(BookmarkStart.b("䐧䌩弫娭ု帱儳䀵崷嘹", num));
        }
        if (A_0.LocalName != BookmarkStart.b("䐧尩䀫", num))
        {
            throw new XmlException(BookmarkStart.b("紧䐩䤫嘭䀯圱圳䈵崷帹᰻䘽ⴿ⹁摃㉅⥇ⵉ汋", num) + A_0.LocalName);
        }
        if (!A_0.IsEmptyElement)
        {
            string localName = A_0.LocalName;
            bool flag = false;
            A_0.Read();
            this.method_485(A_0);
            while (A_0.LocalName != localName)
            {
                string attribute;
                if (A_0.EOF)
                {
                    break;
                }
                flag = false;
                if (A_0.NodeType != XmlNodeType.Element)
                {
                    goto Label_0458;
                }
                string key = A_0.LocalName;
                if (key != null)
                {
                    int num2;
                    if (Class1160.dictionary_84 == null)
                    {
                        Dictionary<string, int> dictionary1 = new Dictionary<string, int>(13);
                        dictionary1.Add(BookmarkStart.b("嬧帩䴫尭䐯", num), 0);
                        dictionary1.Add(BookmarkStart.b("堧稩師", num), 1);
                        dictionary1.Add(BookmarkStart.b("娧稩師", num), 2);
                        dictionary1.Add(BookmarkStart.b("䄧天怫䤭尯", num), 3);
                        dictionary1.Add(BookmarkStart.b("䐧尩䀫簭唯䄱䀳圵䨷丹", num), 4);
                        dictionary1.Add(BookmarkStart.b("堧礩堫圭尯圱", num), 5);
                        dictionary1.Add(BookmarkStart.b("䐧尩䀫縭夯儱瘳䌵吷嘹夻䨽ि♁", num), 6);
                        dictionary1.Add(BookmarkStart.b("䘧弩䄫栭崯䘱", num), 7);
                        dictionary1.Add(BookmarkStart.b("椧䘩堫䬭䈯就唳䈵崷礹医倽㐿❁⩃㉅", num), 8);
                        dictionary1.Add(BookmarkStart.b("䐧尩䀫稭唯䨱䀳", num), 9);
                        dictionary1.Add(BookmarkStart.b("䐧尩䀫搭匯", num), 10);
                        dictionary1.Add(BookmarkStart.b("嬧弩䨫䠭", num), 11);
                        dictionary1.Add(BookmarkStart.b("䐧伩䬫伭匯䬱", num), 12);
                        Class1160.dictionary_84 = dictionary1;
                    }
                    if (Class1160.dictionary_84.TryGetValue(key, out num2))
                    {
                        switch (num2)
                        {
                            case 0:
                                A_1.StartAt = int.Parse(A_0.GetAttribute(BookmarkStart.b("帧䬩䀫", num), this.dictionary_18[BookmarkStart.b("弧", num)]));
                                break;

                            case 1:
                                this.method_403(A_0, A_1.ParagraphFormat);
                                break;

                            case 2:
                                this.method_378(A_0, A_1.CharacterFormat);
                                break;

                            case 3:
                                A_1.IsLegalStyleNumbering = true;
                                break;

                            case 4:
                                if (A_0.GetAttribute(BookmarkStart.b("帧䬩䀫", num), this.dictionary_18[BookmarkStart.b("弧", num)]) == BookmarkStart.b("ᠧ", num))
                                {
                                    A_1.NoRestartByHigher = true;
                                }
                                break;

                            case 5:
                                attribute = A_0.GetAttribute(BookmarkStart.b("帧䬩䀫", num), this.dictionary_18[BookmarkStart.b("弧", num)]);
                                if (!this.method_22().ContainsKey(attribute))
                                {
                                    goto Label_02F8;
                                }
                                A_1.ParaStyleName = this.method_22()[attribute];
                                break;

                            case 6:
                            {
                                string str6 = A_0.GetAttribute(BookmarkStart.b("帧䬩䀫", num), this.dictionary_18[BookmarkStart.b("弧", num)]);
                                if (this.method_15().ContainsKey(str6))
                                {
                                    A_1.PicBullet = this.method_15()[str6];
                                }
                                break;
                            }
                            case 7:
                            {
                                string str = A_0.GetAttribute(BookmarkStart.b("帧䬩䀫", num), this.dictionary_18[BookmarkStart.b("弧", num)]);
                                A_1.PatternType = this.method_349(str);
                                break;
                            }
                            case 8:
                                this.method_343(A_0, A_1);
                                break;

                            case 9:
                            {
                                string str9 = A_0.GetAttribute(BookmarkStart.b("帧䬩䀫", num), this.dictionary_18[BookmarkStart.b("弧", num)]);
                                this.method_347(A_1, str9);
                                break;
                            }
                            case 10:
                            {
                                string str5 = A_0.GetAttribute(BookmarkStart.b("帧䬩䀫", num), this.dictionary_18[BookmarkStart.b("弧", num)]);
                                A_1.NumberAlignment = this.method_346(str5);
                                break;
                            }
                            case 11:
                            {
                                string str7 = A_0.GetAttribute(BookmarkStart.b("帧䬩䀫", num), this.dictionary_18[BookmarkStart.b("弧", num)]);
                                A_1.FollowCharacter = this.method_345(str7);
                                break;
                            }
                            case 12:
                                this.method_344(A_0, A_1);
                                break;
                        }
                    }
                }
                goto Label_044C;
            Label_02F8:
                A_1.ParaStyleName = attribute;
            Label_044C:
                if (!flag)
                {
                    A_0.Read();
                }
                goto Label_045F;
            Label_0458:
                A_0.Read();
            Label_045F:
                this.method_485(A_0);
            }
        }
    }

    private void method_343(XmlReader A_0, ListLevel A_1)
    {
        int num = 14;
        if (!A_0.IsEmptyElement)
        {
            string localName = A_0.LocalName;
            bool flag = false;
            A_0.Read();
            this.method_485(A_0);
            while (A_0.LocalName != localName)
            {
                if (A_0.EOF)
                {
                    break;
                }
                flag = false;
                if (A_0.NodeType == XmlNodeType.Element)
                {
                    string str2;
                    if ((((str2 = A_0.LocalName.ToLower()) != null) && (str2 != BookmarkStart.b("圳帵圷匹弻嬽", num))) && ((str2 != BookmarkStart.b("刳圵吷嘹帻弽⌿⥁", num)) && (str2 == BookmarkStart.b("娳䌵唷尹儻䨽", num))))
                    {
                        string attribute = A_0.GetAttribute(BookmarkStart.b("䈳圵吷", num), this.dictionary_18[BookmarkStart.b("䌳", num)]);
                        if (attribute == BookmarkStart.b("圳䌵䬷丹医匽", num))
                        {
                            A_1.PatternType = ListPatternType.CustomType;
                            A_1.CustomPattern = new Class496();
                            string str = A_0.GetAttribute(BookmarkStart.b("刳夵䨷圹崻䨽", num), this.dictionary_18[BookmarkStart.b("䌳", num)]);
                            if (str == BookmarkStart.b("гصषᘹ᰻฽瀿灁桃晅硇穉罋才灏籑穓硕", num))
                            {
                                A_1.CustomPattern.method_1(ListPatternFormat.LeadingTwoZero);
                            }
                            else if (str == BookmarkStart.b("гص࠷ହျḽ瀿牁瑃瑅摇橉籋繍恏慑硓癕癗瑙牛", num))
                            {
                                A_1.CustomPattern.method_1(ListPatternFormat.LeadingThreedZero);
                            }
                            else if (str == BookmarkStart.b("гص࠷ਹ഻ሽ怿牁瑃癅硇硉恋湍恏扑摓晕歗癙籛灝也䱡", num))
                            {
                                A_1.CustomPattern.method_1(ListPatternFormat.LeadingFourZero);
                            }
                        }
                        else if ((attribute != BookmarkStart.b("圳䌵䬷丹医匽", num)) && (A_1.PatternType == ListPatternType.CustomType))
                        {
                            A_1.CustomPattern.method_3(this.method_349(attribute));
                        }
                    }
                    if (!flag)
                    {
                        A_0.Read();
                    }
                }
                else
                {
                    A_0.Read();
                }
                this.method_485(A_0);
            }
        }
    }

    private void method_344(XmlReader A_0, ListLevel A_1)
    {
        int num = 15;
        string attribute = A_0.GetAttribute(BookmarkStart.b("头制常娺帼䘾", 15), this.dictionary_18[BookmarkStart.b("䈴", 15)]);
        if ((!(attribute == BookmarkStart.b("Դ", 15)) && !(attribute == BookmarkStart.b("匴嘶唸䠺堼", num))) && !(attribute == BookmarkStart.b("娴儶弸", num)))
        {
            A_1.Word6Legacy = true;
        }
        else
        {
            A_1.Word6Legacy = false;
        }
        attribute = A_0.GetAttribute(BookmarkStart.b("头制常娺帼䘾ቀ㍂⑄⑆ⱈ", num), this.dictionary_18[BookmarkStart.b("䈴", num)]);
        A_1.LegacySpace = (int) float.Parse(attribute, NumberStyles.Number);
        attribute = A_0.GetAttribute(BookmarkStart.b("头制常娺帼䘾ࡀⵂ⅄≆❈㽊", num), this.dictionary_18[BookmarkStart.b("䈴", num)]);
        A_1.LegacyIndent = (int) float.Parse(attribute, NumberStyles.Number);
    }

    private FollowCharacterType method_345(string A_0)
    {
        int num = 10;
        string str = A_0;
        if (str != null)
        {
            if (str == BookmarkStart.b("䐯匱嘳", num))
            {
                return FollowCharacterType.Tab;
            }
            if (str == BookmarkStart.b("䌯䈱唳唵崷", num))
            {
                return FollowCharacterType.Space;
            }
        }
        return FollowCharacterType.Nothing;
    }

    private ListNumberAlignment method_346(string A_0)
    {
        int num = 11;
        string str = A_0;
        if (str != null)
        {
            if (str == BookmarkStart.b("到嘲嬴䌶尸䤺", num))
            {
                return ListNumberAlignment.Center;
            }
            if (str == BookmarkStart.b("䌰娲刴弶䴸", num))
            {
                return ListNumberAlignment.Right;
            }
        }
        return ListNumberAlignment.Left;
    }

    private void method_347(ListLevel A_0, string A_1)
    {
        int num = 13;
        if (A_0.PatternType == ListPatternType.Bullet)
        {
            A_0.BulletCharacter = A_1;
        }
        else
        {
            A_0.LevelText = A_1;
            string str2 = BookmarkStart.b("ᘲ", num) + ((A_0.LevelNumber + 1)).ToString();
            int index = A_1.IndexOf(str2);
            if (index != -1)
            {
                A_0.NumberPrefix = A_1.Substring(0, index);
                A_0.NumberPrefix = this.method_348(A_0.NumberPrefix);
                int startIndex = index + 2;
                A_0.NumberSufix = A_1.Substring(startIndex, A_1.Length - startIndex);
            }
            else
            {
                A_0.NoPlaceholder = true;
                if (!string.IsNullOrEmpty(A_1))
                {
                    A_0.NumberPrefix = A_1;
                }
                else
                {
                    A_0.NumberPrefix = (string) (A_0.NumberSufix = null);
                }
                A_0.NoLevelText = true;
            }
        }
    }

    private string method_348(string A_0)
    {
        int num = 13;
        if ((A_0 != null) && !(A_0 == string.Empty))
        {
            string str = A_0;
            return str.Replace(BookmarkStart.b("ᘲд", num), BookmarkStart.b("㌲", num)).Replace(BookmarkStart.b("ᘲܴ", num), BookmarkStart.b("㈲", num)).Replace(BookmarkStart.b("ᘲش", num), BookmarkStart.b("ㄲ", num)).Replace(BookmarkStart.b("ᘲĴ", num), BookmarkStart.b("〲", num)).Replace(BookmarkStart.b("ᘲ4", num), BookmarkStart.b("㜲", num)).Replace(BookmarkStart.b("ᘲ̴", num), BookmarkStart.b("㘲", num)).Replace(BookmarkStart.b("ᘲȴ", num), BookmarkStart.b("㔲", num)).Replace(BookmarkStart.b("ᘲഴ", num), BookmarkStart.b("㐲", num)).Replace(BookmarkStart.b("ᘲఴ", num), BookmarkStart.b("㬲", num));
        }
        return A_0;
    }

    private ListPatternType method_349(string A_0)
    {
        int num = 9;
        string key = A_0;
        if (key != null)
        {
            int num2;
            if (Class1160.dictionary_85 == null)
            {
                Dictionary<string, int> dictionary1 = new Dictionary<string, int>(0x24);
                dictionary1.Add(BookmarkStart.b("䄮帰崲倴", num), 0);
                dictionary1.Add(BookmarkStart.b("䬮吰倲尴娶堸场", num), 1);
                dictionary1.Add(BookmarkStart.b("娮䄰䌲倴䔶欸吺值帾⽀", num), 2);
                dictionary1.Add(BookmarkStart.b("䌮帰䐲倴䔶欸吺值帾⽀", num), 3);
                dictionary1.Add(BookmarkStart.b("娮䄰䌲倴䔶甸帺䤼䬾⑀ㅂ", num), 4);
                dictionary1.Add(BookmarkStart.b("䌮帰䐲倴䔶甸帺䤼䬾⑀ㅂ", num), 5);
                dictionary1.Add(BookmarkStart.b("䀮䌰圲尴夶堸场", num), 6);
                dictionary1.Add(BookmarkStart.b("䀮䌰圲尴夶堸场椼娾㥀㝂", num), 7);
                dictionary1.Add(BookmarkStart.b("䬮吰倲尴娶堸场朼娾㍀ⱂ", num), 8);
                dictionary1.Add(BookmarkStart.b("䰮倰䄲儴帶圸娺儼款⑀㭂ㅄ", num), 9);
                dictionary1.Add(BookmarkStart.b("丮堰䘲倴堶缸为儼匾ᙀ⩂⅄㍆ⅈ", num), 10);
                dictionary1.Add(BookmarkStart.b("崮䐰䀲䘴帶堸唺焼倾㙀♂㝄", num), 11);
                dictionary1.Add(BookmarkStart.b("䰮夰娲嬴制䨸帺焼娾♀≂⥄ᑆ⁈♊㵌⍎㡐㕒㱔㉖㵘", num), 12);
                dictionary1.Add(BookmarkStart.b("䰮夰娲嬴制䨸帺縼倾㑀ⵂㅄ⹆❈ⱊ᥌❎㹐♒♔㙖㝘㽚", num), 13);
                dictionary1.Add(BookmarkStart.b("䘮唰嘲娴倶䬸娺䴼圾ᕀㅂ⑄⍆⁈㽊⑌⁎㽐㉒㥔", num), 14);
                dictionary1.Add(BookmarkStart.b("䘮唰嘲娴倶䬸娺䴼圾ᭀⱂ⅄⹆⡈⡊", num), 15);
                dictionary1.Add(BookmarkStart.b("䘮唰嘲娴倶䬸娺䴼圾ᭀⱂ⅄⹆⡈⡊᥌㵎ぐ㝒㱔⍖じ㑚㍜㹞ൠ", num), 0x10);
                dictionary1.Add(BookmarkStart.b("嬮倰娲䈴嘶圸帺丼娾ɀⱂい⥆㵈≊⍌⡎", num), 0x11);
                dictionary1.Add(BookmarkStart.b("䘮唰嘲娴倶䬸娺䴼圾ീ♂≄♆╈Ὂ㽌⹎㕐㩒⅔㹖㙘㕚㱜㍞", num), 0x12);
                dictionary1.Add(BookmarkStart.b("嬮倰娲䈴嘶圸帺丼娾ɀⱂい⥆㵈≊⍌⡎Ր㭒㩔≖⩘㩚㍜㭞", num), 0x13);
                dictionary1.Add(BookmarkStart.b("嬮倰娲䈴嘶圸帺丼娾Հ⩂≄⹆㵈⩊⅌", num), 20);
                dictionary1.Add(BookmarkStart.b("䰮夰娲嬴制䨸帺縼倾㑀ⵂㅄ⹆❈ⱊ", num), 0x15);
                dictionary1.Add(BookmarkStart.b("䔮倰䌲吴夶尸䠺堼簾⹀㙂⭄㍆⁈╊⩌", num), 0x16);
                dictionary1.Add(BookmarkStart.b("䔮倰䌲吴夶尸䠺堼笾⡀⑂ⱄ㍆⡈❊᥌⩎㽐ݒ㵔㡖ⱘ⡚㱜ㅞՠ", num), 0x17);
                dictionary1.Add(BookmarkStart.b("䔮倰䌲吴夶尸䠺堼猾⑀⑂⑄⭆", num), 0x18);
                dictionary1.Add(BookmarkStart.b("䬮吰倲尴娶堸场砼儾≀⽂⩄㑆ⱈ⽊์♎⍐げ㥔㉖", num), 0x19);
                dictionary1.Add(BookmarkStart.b("䬮吰倲尴娶堸场砼儾≀⽂⩄㑆ⱈ⽊์♎⍐げ㥔㉖ᩘ㍚㑜ㅞѠၢd", num), 0x1a);
                dictionary1.Add(BookmarkStart.b("䬮吰倲尴娶堸场砼儾≀⽂⩄㑆ⱈ⽊ୌ㩎㵐㽒♔⍖㙘⭚", num), 0x1b);
                dictionary1.Add(BookmarkStart.b("䐮帰䄲倴嘶圸砺刼䨾⽀㝂ⱄ⥆⹈", num), 0x1c);
                dictionary1.Add(BookmarkStart.b("䐮帰䄲倴嘶圸缺吼堾⡀㝂⑄⭆", num), 0x1d);
                dictionary1.Add(BookmarkStart.b("䐮帰䄲倴嘶圸缺吼堾⡀㝂⑄⭆筈", num), 30);
                dictionary1.Add(BookmarkStart.b("䐮帰䄲倴嘶圸眺堼堾⁀⽂", num), 0x1f);
                dictionary1.Add(BookmarkStart.b("丮堰䘲倴堶", num), 0x20);
                dictionary1.Add(BookmarkStart.b("䘮䌰尲崴嘶", num), 0x21);
                dictionary1.Add(BookmarkStart.b("䘮唰嘲娴倶䬸娺䴼圾Հ⩂≄⹆㵈⩊⅌", num), 0x22);
                dictionary1.Add(BookmarkStart.b("䘮䌰尲崴嘶缸为儼匾ᙀ⩂⅄㍆ⅈ", num), 0x23);
                Class1160.dictionary_85 = dictionary1;
            }
            if (Class1160.dictionary_85.TryGetValue(key, out num2))
            {
                switch (num2)
                {
                    case 0:
                        return ListPatternType.None;

                    case 1:
                        return ListPatternType.Arabic;

                    case 2:
                        return ListPatternType.UpRoman;

                    case 3:
                        return ListPatternType.LowRoman;

                    case 4:
                        return ListPatternType.UpLetter;

                    case 5:
                        return ListPatternType.LowLetter;

                    case 6:
                        return ListPatternType.Ordinal;

                    case 7:
                        return ListPatternType.OrdinalText;

                    case 8:
                        return ListPatternType.LeadingZero;

                    case 9:
                        return ListPatternType.CardinalText;

                    case 10:
                        return ListPatternType.AiueoFullWidth;

                    case 11:
                        return ListPatternType.Special;

                    case 12:
                        return ListPatternType.ChineseLegalSimplified;

                    case 13:
                        return ListPatternType.ChineseCountingThousand;

                    case 14:
                        return ListPatternType.IdeographTraditional;

                    case 15:
                        return ListPatternType.IdeographZodiac;

                    case 0x10:
                        return ListPatternType.IdeographZodiacTraditional;

                    case 0x11:
                        return ListPatternType.TaiwaneseCounting;

                    case 0x12:
                        return ListPatternType.IdeographLegalTraditional;

                    case 0x13:
                        return ListPatternType.TaiwaneseCountingThousand;

                    case 20:
                        return ListPatternType.TaiwaneseDigital;

                    case 0x15:
                        return ListPatternType.ChineseCounting;

                    case 0x16:
                        return ListPatternType.JapaneseCounting;

                    case 0x17:
                        return ListPatternType.JapaneseDigitalTenThousand;

                    case 0x18:
                        return ListPatternType.JapaneseLegal;

                    case 0x19:
                        return ListPatternType.DecimalEnclosedCircle;

                    case 0x1a:
                        return ListPatternType.DecimalEnclosedCircleChinese;

                    case 0x1b:
                        return ListPatternType.DecimalEnclosedFullstop;

                    case 0x1c:
                        return ListPatternType.KoreanCounting;

                    case 0x1d:
                        return ListPatternType.KoreanDigital;

                    case 30:
                        return ListPatternType.KoreanDigital2;

                    case 0x1f:
                        return ListPatternType.KoreanLegal;

                    case 0x20:
                        return ListPatternType.Aiueo;

                    case 0x21:
                        return ListPatternType.Iroha;

                    case 0x22:
                        return ListPatternType.IdeographDigital;

                    case 0x23:
                        return ListPatternType.IrohaFullWidth;
                }
            }
        }
        return ListPatternType.Bullet;
    }

    private void method_35(Class1129 A_0)
    {
        int num = 0x12;
        Class1128 class2 = A_0.method_18(BookmarkStart.b("伷唹主娽漿㙁ⱃ⍅╇⽉捋", 0x12));
        if (class2.method_0().ContainsKey(BookmarkStart.b("䰷刹夻匽┿獁橃㹅╇♉", 0x12)))
        {
            this.method_43(class2.method_0()[BookmarkStart.b("䰷刹夻匽┿獁橃㹅╇♉", num)].method_4());
        }
        class2 = A_0.method_18(BookmarkStart.b("伷唹主娽漿", num));
        if (class2.method_2().ContainsKey(BookmarkStart.b("伷唹主娽漿ᵁ㙃⍅⑇㥉捋⩍㽏ㅑ⅓㭕㵗㑙⡛灝ᡟཡࡣ䡥ᩧཀྵkᵭ", num)))
        {
            this.method_314(class2.method_2()[BookmarkStart.b("伷唹主娽漿ᵁ㙃⍅⑇㥉捋⩍㽏ㅑ⅓㭕㵗㑙⡛灝ᡟཡࡣ䡥ᩧཀྵkᵭ", num)].method_4());
        }
        else if (!string.IsNullOrEmpty(this.string_5))
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(BookmarkStart.b("伷唹主娽漿ᵁ㙃⍅⑇㥉捋", num));
            builder.Append(this.string_5.Replace(BookmarkStart.b("᜷䴹医䰽␿流", num), string.Empty));
            builder.Append(BookmarkStart.b("ᘷ䠹夻刽㌿", num));
            string key = builder.ToString();
            if (class2.method_2().ContainsKey(key))
            {
                this.method_314(class2.method_2()[key].method_4());
            }
        }
        class2 = A_0.method_18(BookmarkStart.b("伷唹主娽漿", num));
        if (this.document_0.Settings != null)
        {
            this.document_0.Settings.method_5().method_156();
        }
        if (class2.method_0().ContainsKey(BookmarkStart.b("䬷弹䠻䨽⤿ⱁ⍃㕅晇㉉⅋≍", num)))
        {
            this.method_443(class2.method_0()[BookmarkStart.b("䬷弹䠻䨽⤿ⱁ⍃㕅晇㉉⅋≍", num)].method_4());
        }
        if (class2.method_0().ContainsKey(BookmarkStart.b("帷唹刻䨽ᐿ⍁♃⩅ⵇ摉㑋⍍㱏", num)))
        {
            this.method_55(class2.method_0()[BookmarkStart.b("帷唹刻䨽ᐿ⍁♃⩅ⵇ摉㑋⍍㱏", num)].method_4());
        }
        if (class2.method_0().ContainsKey(BookmarkStart.b("䬷丹䔻刽┿ㅁ橃㹅╇♉", num)))
        {
            this.method_358(class2.method_0()[BookmarkStart.b("䬷丹䔻刽┿ㅁ橃㹅╇♉", num)].method_4());
        }
        if (class2.method_0().ContainsKey(BookmarkStart.b("嘷伹儻尽┿ぁⵃ⡅⽇摉㑋⍍㱏", num)))
        {
            Class229 class3 = class2.method_0()[BookmarkStart.b("嘷伹儻尽┿ぁⵃ⡅⽇摉㑋⍍㱏", num)];
            if (((class3 != null) && (class3.method_4() != null)) && (class3.method_4().Length > 0L))
            {
                this.xmlReader_0 = Class57.smethod_18(class3.method_4());
                this.method_334(this.xmlReader_0);
                this.xmlReader_0.Close();
            }
        }
        if (class2.method_0().ContainsKey(BookmarkStart.b("䬷丹䔻刽┿ㅁ橃㹅╇♉", num)))
        {
            this.method_357(class2.method_0()[BookmarkStart.b("䬷丹䔻刽┿ㅁ橃㹅╇♉", num)].method_4());
        }
        if (class2.method_0().ContainsKey(BookmarkStart.b("伷弹帻洽┿㙁ぃ⽅♇ⵉ㽋恍⡏㽑㡓", num)))
        {
            this.method_39(class2.method_0()[BookmarkStart.b("伷弹帻洽┿㙁ぃ⽅♇ⵉ㽋恍⡏㽑㡓", num)].method_4());
        }
        foreach (string str in class2.method_0().Keys)
        {
            if (!string.IsNullOrEmpty(this.string_5) && this.string_5.Contains(str))
            {
                this.method_66(class2.method_0()[str].method_4());
            }
            else
            {
                string str2;
                if (((str2 = str) != null) && (str2 == BookmarkStart.b("尷唹弻䬽ⴿ❁⩃㉅晇㉉⅋≍", num)))
                {
                    this.method_66(class2.method_0()[str].method_4());
                }
            }
        }
        this.method_37();
        if (class2.method_0().ContainsKey(BookmarkStart.b("丷堹崻渽㈿ⵁ⹃⍅⭇㹉手ⱍ㥏㱑", num)))
        {
            this.method_51(class2.method_0()[BookmarkStart.b("丷堹崻渽㈿ⵁ⹃⍅⭇㹉手ⱍ㥏㱑", num)].method_4());
        }
        if (class2.method_0().ContainsKey(BookmarkStart.b("丷堹崻稽ℿ㙁╃桅ぇ❉⁋", num)))
        {
            this.method_52(class2.method_0()[BookmarkStart.b("丷堹崻稽ℿ㙁╃桅ぇ❉⁋", num)].method_4());
        }
        this.method_36();
    }

    private void method_350(ListStyle A_0)
    {
        if (A_0.Levels != null)
        {
            A_0.ListType = ListType.Bulleted;
            using (IEnumerator enumerator = A_0.Levels.GetEnumerator())
            {
                while (enumerator.MoveNext())
                {
                    ListLevel current = (ListLevel) enumerator.Current;
                    if (current.PatternType != ListPatternType.Bullet)
                    {
                        goto Label_0040;
                    }
                }
                return;
            Label_0040:
                A_0.ListType = ListType.Numbered;
            }
        }
    }

    private void method_351(ListStyle A_0)
    {
        int num = 1;
        if (A_0.ListType == ListType.Numbered)
        {
            A_0.Name = BookmarkStart.b("椦尨䘪伬䨮䌰嘲儴栶", num) + Guid.NewGuid().ToString();
        }
        else
        {
            A_0.Name = BookmarkStart.b("攦尨䜪䄬䨮䔰嘲儴栶", num) + Guid.NewGuid().ToString();
        }
    }

    private void method_352(XmlReader A_0)
    {
        int num = 7;
        string attribute = A_0.GetAttribute(BookmarkStart.b("䌬娮尰挲尴吶笸为儼匾⑀㝂ౄ⍆", 7), this.dictionary_18[BookmarkStart.b("娬", 7)]);
        if (this.method_247(A_0, BookmarkStart.b("帬䜮倰䌲倴", 7), BookmarkStart.b("嬬", 7)))
        {
            string str2 = this.method_356(A_0);
            bool flag = false;
            A_0.Read();
            this.method_485(A_0);
            while (A_0.LocalName != BookmarkStart.b("䌬娮尰挲尴吶笸为儼匾⑀㝂", num))
            {
                if (A_0.EOF)
                {
                    break;
                }
                flag = false;
                if (A_0.NodeType == XmlNodeType.Element)
                {
                    string str4;
                    if (((str4 = A_0.LocalName) != null) && (str4 == BookmarkStart.b("䐬䈮倰吲倴匶堸伺尼", num)))
                    {
                        string str3 = this.method_355(A_0);
                        if ((str3 == null) || (str3.Length == 0))
                        {
                            return;
                        }
                        DocPicture picture = new DocPicture(this.document_0);
                        this.method_458(picture, str3, false, true);
                        this.method_353(picture, str2);
                        if ((attribute == string.Empty) || (picture.Image == null))
                        {
                            return;
                        }
                        this.method_15().Add(attribute, picture);
                    }
                    if (!flag)
                    {
                        A_0.Read();
                    }
                }
                else
                {
                    A_0.Read();
                }
                this.method_485(A_0);
            }
        }
    }

    private void method_353(DocPicture A_0, string A_1)
    {
        int num = 0;
        A_1 = A_1.Replace(BookmarkStart.b("嘥尧", 0), string.Empty);
        string[] strArray = A_1.Split(new char[] { ';' });
        int index = 0;
        int length = strArray.Length;
        while (index < length)
        {
            string str = strArray[index];
            if (str.StartsWith(BookmarkStart.b("儥䄧丩堫䘭ਯ", num)))
            {
                str = str.Replace(BookmarkStart.b("儥䄧丩堫䘭ਯ", num), string.Empty);
                A_0.Width = this.method_354(str);
            }
            else if (str.StartsWith(BookmarkStart.b("严䴧䌩䬫䘭䐯࠱", num)))
            {
                str = str.Replace(BookmarkStart.b("严䴧䌩䬫䘭䐯࠱", num), string.Empty);
                A_0.Height = this.method_354(str);
            }
            index++;
        }
    }

    private float method_354(string A_0)
    {
        int num2 = 4;
        if (A_0.EndsWith(BookmarkStart.b("䌩䈫", 4)))
        {
            int num = int.Parse(A_0.Replace(BookmarkStart.b("䌩䈫", num2), string.Empty));
            return (float) Class1073.smethod_1().method_1((double) num, PrintUnits.Inch, PrintUnits.Point);
        }
        A_0 = A_0.Replace(BookmarkStart.b("娩堫", num2), string.Empty);
        return this.method_467(A_0);
    }

    private string method_355(XmlReader A_0)
    {
        int num = 7;
        if (A_0.LocalName != BookmarkStart.b("䐬䈮倰吲倴匶堸伺尼", 7))
        {
            throw new XmlException(BookmarkStart.b("䐬䈮倰吲倴匶堸伺尼Ἶ汀捂㝄≆╈⩊㥌♎㹐㵒♔㽖じ⭚絜㙞ՠ䍢੤Ŧ䥨ᡪլ๮Űᙲ", num));
        }
        return A_0.GetAttribute(BookmarkStart.b("䐬䬮", num), this.dictionary_18[BookmarkStart.b("弬", num)]);
    }

    private string method_356(XmlReader A_0)
    {
        int num = 11;
        if (A_0.LocalName != BookmarkStart.b("䈰嬲吴䜶尸", 11))
        {
            throw new XmlException(BookmarkStart.b("䈰嬲吴䜶尸ᬺြἾᅀ⩂♄㍆㱈㥊⡌潎㍐♒㥔㭖㱘⽚", num));
        }
        return A_0.GetAttribute(BookmarkStart.b("䈰䜲䰴嬶尸", num));
    }

    private void method_357(Stream A_0)
    {
        A_0.Position = 0L;
        this.xmlReader_0 = Class57.smethod_18(A_0);
        this.method_359(this.xmlReader_0);
        this.xmlReader_0.Close();
    }

    private void method_358(Stream A_0)
    {
        A_0.Position = 0L;
        XmlReader reader = Class57.smethod_18(A_0);
        this.method_316(reader, BookmarkStart.b("䌯䘱䴳娵崷䤹", 10));
        if (this.method_247(reader, BookmarkStart.b("启崱圳爵崷尹崻䬽ⰿ㙁㝃", 10), BookmarkStart.b("䜯", 10)))
        {
            this.method_367(reader);
        }
        reader.Close();
        this.method_317();
    }

    private void method_359(XmlReader A_0)
    {
        int num = 7;
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("弬䨮倰圲倴䔶", num));
        }
        while (A_0.NodeType != XmlNodeType.Element)
        {
            A_0.Read();
        }
        if (A_0.LocalName != BookmarkStart.b("帬嬮䠰弲倴䐶", num))
        {
            throw new XmlException(BookmarkStart.b("砬䄮吰䬲䔴制娸伺堼嬾慀㭂⡄⭆楈㽊ⱌ⡎煐", num) + A_0.LocalName);
        }
        if (!A_0.IsEmptyElement)
        {
            string localName = A_0.LocalName;
            this.method_316(A_0, BookmarkStart.b("帬嬮䠰弲倴䐶", num));
            bool flag = false;
            A_0.Read();
            this.method_485(A_0);
            while (A_0.LocalName != localName)
            {
                if (A_0.EOF)
                {
                    break;
                }
                flag = false;
                if (A_0.NodeType == XmlNodeType.Element)
                {
                    string str2 = A_0.LocalName;
                    if (str2 != null)
                    {
                        if (str2 != BookmarkStart.b("䤬䀮到眲倴儶堸为儼䬾㉀", num))
                        {
                            if (!(str2 == BookmarkStart.b("䄬丮䔰嘲嬴䌶樸伺䐼匾⑀あ", num)))
                            {
                                if (str2 == BookmarkStart.b("帬嬮䠰弲倴", num))
                                {
                                    flag = this.method_363(A_0);
                                }
                            }
                            else
                            {
                                this.method_366(A_0);
                                flag = true;
                            }
                        }
                        else
                        {
                            this.method_367(A_0);
                        }
                    }
                    if (!flag)
                    {
                        A_0.Read();
                    }
                }
                else
                {
                    A_0.Skip();
                }
                this.method_485(A_0);
            }
            this.method_360();
            this.method_362();
            this.method_361();
            this.method_317();
        }
    }

    private void method_36()
    {
        if ((this.list_4 != null) && (this.list_4.Count > 0))
        {
            Section section = null;
            float clientWidth = 0f;
            foreach (Paragraph paragraph in this.list_4)
            {
                foreach (Tab tab in paragraph.Format.Tabs)
                {
                    if (tab.IsPTab)
                    {
                        if (section == null)
                        {
                            section = paragraph.method_49();
                            clientWidth = section.PageSetup.ClientWidth;
                        }
                        switch (tab.Justification)
                        {
                            case TabJustification.Centered:
                                tab.Position = clientWidth / 2f;
                                break;

                            case TabJustification.Right:
                                tab.Position = clientWidth;
                                break;
                        }
                    }
                }
            }
        }
    }

    private void method_360()
    {
        if (this.dictionary_1 != null)
        {
            foreach (string str in this.dictionary_1.Keys)
            {
                Style style = this.document_0.Styles.FindByName(str);
                if ((style != null) && this.method_22().ContainsKey(this.dictionary_1[str]))
                {
                    style.ApplyBaseStyle(this.method_22()[this.dictionary_1[str]]);
                }
            }
        }
    }

    private void method_361()
    {
        foreach (IStyle style2 in this.document_0.Styles)
        {
            if (style2 is ParagraphStyle)
            {
                ListStyle currentListStyle = (style2 as ParagraphStyle).ListFormat.CurrentListStyle;
                if (((currentListStyle != null) && (currentListStyle.BaseListStyleName != null)) && this.method_13().ContainsKey(currentListStyle.BaseListStyleName))
                {
                    string key = this.method_13()[currentListStyle.BaseListStyleName];
                    if (this.method_13().ContainsKey(key))
                    {
                        string styleName = this.method_13()[key];
                        (style2 as ParagraphStyle).ListFormat.ApplyStyle(styleName);
                    }
                }
            }
        }
    }

    private void method_362()
    {
        if (this.dictionary_0 != null)
        {
            foreach (string str in this.dictionary_0.Keys)
            {
                Style style = this.document_0.Styles.FindByName(str);
                string key = this.dictionary_0[str];
                if (this.method_22().ContainsKey(key))
                {
                    style.LinkStyle = this.method_22()[key];
                }
            }
        }
    }

    private bool method_363(XmlReader A_0)
    {
        int num = 6;
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("師䬭儯嘱儳䐵", num));
        }
        while (A_0.NodeType != XmlNodeType.Element)
        {
            A_0.Read();
        }
        if (A_0.LocalName != BookmarkStart.b("弫娭䤯帱儳", num))
        {
            throw new XmlException(BookmarkStart.b("礫䀭唯䨱䐳匵嬷丹夻娽怿㩁⥃⩅桇㹉ⵋ⥍灏", num) + A_0.LocalName);
        }
        if (!A_0.IsEmptyElement)
        {
            if (!A_0.HasAttributes)
            {
                A_0.Read();
                return false;
            }
            string str = A_0.GetAttribute(BookmarkStart.b("堫圭䀯圱", num), this.dictionary_18[BookmarkStart.b("嬫", num)]).ToLower();
            if (str == BookmarkStart.b("䈫嬭崯倱儳䐵儷吹嬻", num))
            {
                this.method_484(A_0);
                return true;
            }
            Style style = this.method_365(str);
            style.method_5(A_0.GetAttribute(BookmarkStart.b("弫娭䤯帱儳缵尷", num), this.dictionary_18[BookmarkStart.b("嬫", num)]));
            string attribute = A_0.GetAttribute(BookmarkStart.b("伫嬭䌯䘱嬳嬵欷丹䔻刽┿", num), this.dictionary_18[BookmarkStart.b("嬫", num)]);
            string str3 = A_0.GetAttribute(BookmarkStart.b("䠫䬭嘯匱䄳娵䰷", num), this.dictionary_18[BookmarkStart.b("嬫", num)]);
            if (attribute != null)
            {
                style.IsCustomStyle = XmlConvert.ToBoolean(attribute);
            }
            A_0.MoveToElement();
            this.method_364(A_0, style);
            if (this.document_0.Styles.method_9(style.StyleId) == null)
            {
                this.document_0.Styles.Add(style);
                if ((!string.IsNullOrEmpty(str3) && XmlConvert.ToBoolean(str3)) && (style.StyleType == StyleType.ParagraphStyle))
                {
                    this.document_0.Styles.DefaultParaStyle = style as ParagraphStyle;
                }
            }
        }
        return false;
    }

    private void method_364(XmlReader A_0, Style A_1)
    {
        int num = 1;
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("唦䰨䨪䤬䨮䌰", num));
        }
        if (A_1 == null)
        {
            throw new ArgumentException(BookmarkStart.b("否崨刪䄬䨮", num));
        }
        while (A_0.NodeType != XmlNodeType.Element)
        {
            A_0.Read();
        }
        if (A_0.LocalName != BookmarkStart.b("否崨刪䄬䨮", num))
        {
            throw new XmlException(BookmarkStart.b("爦䜨个唬弮吰倲䄴制崸ᬺ䔼刾ⵀ捂ㅄ♆⹈歊", num) + A_0.LocalName);
        }
        if (!A_0.IsEmptyElement)
        {
            string localName = A_0.LocalName;
            bool flag = false;
            A_0.Read();
            this.method_485(A_0);
            while (A_0.LocalName != localName)
            {
                string str;
                string str3;
                string attribute;
                bool flag2 = false;
                if (A_0.NodeType != XmlNodeType.Element)
                {
                    goto Label_0522;
                }
                string key = A_0.LocalName;
                if (key != null)
                {
                    int num2;
                    if (Class1160.dictionary_86 == null)
                    {
                        Dictionary<string, int> dictionary1 = new Dictionary<string, int>(14);
                        dictionary1.Add(BookmarkStart.b("唦礨太", num), 0);
                        dictionary1.Add(BookmarkStart.b("圦礨太", num), 1);
                        dictionary1.Add(BookmarkStart.b("匦䬨䜪紬崮", num), 2);
                        dictionary1.Add(BookmarkStart.b("匦嬨笪弬", num), 3);
                        dictionary1.Add(BookmarkStart.b("匦䨨笪弬", num), 4);
                        dictionary1.Add(BookmarkStart.b("匦䬨䜪縬嬮䠰弲倴朶䬸", num), 5);
                        dictionary1.Add(BookmarkStart.b("否䰨䘪䐬朮堰圲儴制圸", num), 6);
                        dictionary1.Add(BookmarkStart.b("刦䜨䌪䐬䬮吰搲崴制圸渺丼娾╀", num), 7);
                        dictionary1.Add(BookmarkStart.b("嘦漨䐪弬䈮倰䜲", num), 8);
                        dictionary1.Add(BookmarkStart.b("䬦䀨䔪䘬", num), 9);
                        dictionary1.Add(BookmarkStart.b("䤦䰨匪夬", num), 10);
                        dictionary1.Add(BookmarkStart.b("䤦䠨䘪䠬", num), 11);
                        dictionary1.Add(BookmarkStart.b("䔦䠨堪䠬䬮縰崲", num), 12);
                        dictionary1.Add(BookmarkStart.b("䘦尨弪䈬紮吰圲倴儶倸唺堼", num), 13);
                        Class1160.dictionary_86 = dictionary1;
                    }
                    if (Class1160.dictionary_86.TryGetValue(key, out num2))
                    {
                        switch (num2)
                        {
                            case 0:
                            {
                                CharacterFormat format = this.method_369(A_1);
                                this.method_378(A_0, format);
                                break;
                            }
                            case 1:
                            {
                                ParagraphFormat format2 = this.method_370(A_1);
                                this.method_403(A_0, format2);
                                break;
                            }
                            case 2:
                                this.method_373(A_0, (A_1 as Class13).Interface8.imethod_3());
                                break;

                            case 3:
                                this.method_374(A_0, (A_1 as Class13).Interface8.imethod_2());
                                break;

                            case 4:
                                this.method_375(A_0, (A_1 as Class13).Interface8.imethod_1());
                                break;

                            case 5:
                                this.method_371(A_0, A_1);
                                break;

                            case 6:
                                A_1.IsSemiHidden = this.method_469(A_0);
                                break;

                            case 7:
                                A_1.UnhideWhenUsed = this.method_469(A_0);
                                break;

                            case 8:
                                A_1.IsPrimaryStyle = this.method_469(A_0);
                                break;

                            case 9:
                                attribute = A_0.GetAttribute(BookmarkStart.b("儦䠨䜪", num), this.dictionary_18[BookmarkStart.b("倦", num)]);
                                if (!this.method_22().ContainsKey(attribute))
                                {
                                    goto Label_032F;
                                }
                                A_1.LinkStyle = this.method_22()[attribute];
                                break;

                            case 10:
                            {
                                string str2 = A_0.GetAttribute(BookmarkStart.b("儦䠨䜪", num), this.dictionary_18[BookmarkStart.b("倦", num)]);
                                A_1.NextStyle = str2;
                                break;
                            }
                            case 11:
                                goto Label_03A6;

                            case 12:
                                if (A_1.Name.ToLower() != BookmarkStart.b("䤦䘨太䀬丮崰", num))
                                {
                                    str = A_0.GetAttribute(BookmarkStart.b("儦䠨䜪", num), this.dictionary_18[BookmarkStart.b("倦", num)]);
                                    flag = true;
                                    if (this.method_22().ContainsKey(str))
                                    {
                                        goto Label_04BE;
                                    }
                                    if (!this.method_21().ContainsKey(A_1.StyleId))
                                    {
                                        this.method_21().Add(A_1.StyleId, str);
                                    }
                                }
                                break;

                            case 13:
                                A_1.AutomaticallyUpdate = this.method_469(A_0);
                                break;
                        }
                    }
                }
                goto Label_0515;
            Label_032F:
                if (this.method_23().ContainsKey(A_1.Name))
                {
                    this.method_23()[A_1.Name] = attribute;
                }
                else
                {
                    this.method_23().Add(A_1.Name, attribute);
                }
                goto Label_0515;
            Label_03A6:
                str3 = A_0.GetAttribute(BookmarkStart.b("儦䠨䜪", num), this.dictionary_18[BookmarkStart.b("倦", num)]);
                if (!A_1.IsCustomStyle && A_1.BuiltinStyles.ContainsKey(str3.ToLower()))
                {
                    str3 = A_1.BuiltinStyles[str3.ToLower()];
                }
                if (!string.IsNullOrEmpty(A_1.StyleId) && !this.method_22().ContainsKey(A_1.StyleId))
                {
                    this.method_22().Add(A_1.StyleId, str3);
                }
                A_1.Name = str3;
                goto Label_0515;
            Label_04BE:
                if (this.document_0.Styles.FindByName(this.method_22()[str]) == null)
                {
                    this.method_21().Add(A_1.StyleId, str);
                }
                else
                {
                    A_1.ApplyBaseStyle(this.method_22()[str]);
                }
            Label_0515:
                if (!flag2)
                {
                    A_0.Read();
                }
                goto Label_0529;
            Label_0522:
                A_0.Read();
            Label_0529:
                this.method_485(A_0);
            }
            if ((!flag && (A_1.BaseStyle != null)) && (A_1 is ParagraphStyle))
            {
                A_1.method_6();
            }
        }
    }

    private Style method_365(string A_0)
    {
        int num = 0x13;
        Style style = null;
        string str = A_0;
        if (str == null)
        {
            return style;
        }
        if (str != BookmarkStart.b("娸区尼䴾⁀⁂ㅄ≆㭈", num))
        {
            if (!(str == BookmarkStart.b("䤸娺似帾♀ㅂ⑄㝆ⅈ", num)))
            {
                if (str == BookmarkStart.b("䴸娺弼匾⑀", num))
                {
                    style = new Class13(this.document_0);
                }
                return style;
            }
            return new ParagraphStyle(this.document_0, false);
        }
        return new Class11(this.document_0);
    }

    private void method_366(XmlReader A_0)
    {
        this.document_0.LatentStyles2010 = this.method_484(A_0);
    }

    private void method_367(XmlReader A_0)
    {
        int num = 0x10;
        if (A_0.LocalName != BookmarkStart.b("刵圷夹砻嬽☿⍁ㅃ⩅㱇㥉", 0x10))
        {
            throw new XmlException(BookmarkStart.b("刵圷夹砻嬽☿⍁ㅃ⩅㱇㥉", num));
        }
        if (!A_0.IsEmptyElement)
        {
            A_0.Read();
            this.method_485(A_0);
            while (A_0.LocalName != BookmarkStart.b("刵圷夹砻嬽☿⍁ㅃ⩅㱇㥉", num))
            {
                if (A_0.NodeType == XmlNodeType.Element)
                {
                    string localName = A_0.LocalName;
                    if (localName != null)
                    {
                        if (!(localName == BookmarkStart.b("䐵样䠹砻嬽☿⍁ㅃ⩅㱇", num)))
                        {
                            if (localName == BookmarkStart.b("䘵样䠹砻嬽☿⍁ㅃ⩅㱇", num))
                            {
                                this.document_0.paragraphFormat_0 = new ParagraphFormat(this.document_0);
                                if (!A_0.IsEmptyElement)
                                {
                                    A_0.Read();
                                    this.method_485(A_0);
                                    if ((A_0.LocalName == BookmarkStart.b("䘵样䠹", num)) && A_0.IsStartElement())
                                    {
                                        this.method_403(A_0, this.document_0.paragraphFormat_0);
                                        A_0.Read();
                                    }
                                }
                            }
                        }
                        else if (!A_0.IsEmptyElement)
                        {
                            A_0.Read();
                            this.method_485(A_0);
                            this.document_0.DefCharFormat = new CharacterFormat(this.document_0);
                            this.method_378(A_0, this.document_0.DefCharFormat);
                            this.method_368(this.document_0, this.document_0.DefCharFormat);
                            A_0.Read();
                        }
                    }
                    A_0.Read();
                }
                else
                {
                    A_0.Read();
                }
                this.method_485(A_0);
            }
        }
    }

    private void method_368(Document A_0, CharacterFormat A_1)
    {
        A_0.DefaultFontNameTable.method_1(A_1.FontNameAscii);
        A_0.DefaultFontNameTable.method_3(A_1.FontNameFarEast);
        A_0.DefaultFontNameTable.method_7(A_1.FontNameBidi);
        A_0.DefaultFontNameTable.method_5(A_1.FontNameNonFarEast);
    }

    private CharacterFormat method_369(Style A_0)
    {
        if (A_0.StyleType == StyleType.TableStyle)
        {
            return (A_0 as Class13).CharacterFormat;
        }
        if (A_0.StyleType != StyleType.CharacterStyle)
        {
            return (A_0 as ParagraphStyle).CharacterFormat;
        }
        return (A_0 as Class11).CharacterFormat;
    }

    private void method_37()
    {
        int num = 0x13;
        foreach (Section section in this.document_0.Sections)
        {
            section.PageSetup.GutterAtTop = this.bool_11;
            if (section.PageSetup.PageBorderOffsetFrom == PageBorderOffsetFrom.Text)
            {
                section.PageSetup.AlignBordersAndEdges = this.bool_7;
                section.PageSetup.PageBorderIncludeFooter = this.bool_9;
                section.PageSetup.PageBorderIncludeHeader = this.bool_8;
            }
            string str = this.string_4;
            if (str != null)
            {
                if (str != BookmarkStart.b("崸吺猼倾㕀B⩄⩆㥈㥊⡌㱎≐", num))
                {
                    if (!(str == BookmarkStart.b("娸吺值伾㍀♂㙄㑆᥈㹊⍌ⱎ═♒㑔⍖じ㑚㍜", num)))
                    {
                        if (str == BookmarkStart.b("娸吺值伾㍀♂㙄㑆᥈㹊⍌ⱎ═♒㑔⍖じ㑚㍜Ṟའݢ⽤٦ᥨ੪ͬ੮ɰᙲ㹴ᙶ᝸᩺", num))
                        {
                            section.PageSetup.CharacterSpacingControl = CharacterSpacing.compressPunctuationAndJapaneseKana;
                        }
                    }
                    else
                    {
                        section.PageSetup.CharacterSpacingControl = CharacterSpacing.compressPunctuation;
                    }
                }
                else
                {
                    section.PageSetup.CharacterSpacingControl = CharacterSpacing.doNotCompress;
                }
            }
        }
        if (this.bool_10 && (this.document_0.Sections.Count != 0))
        {
            this.document_0.Sections[0].PageSetup.DifferentOddAndEvenPagesHeaderFooter = true;
        }
    }

    private ParagraphFormat method_370(Style A_0)
    {
        if (A_0.StyleType != StyleType.TableStyle)
        {
            return (A_0 as ParagraphStyle).ParagraphFormat;
        }
        return (A_0 as Class13).imethod_0();
    }

    private void method_371(XmlReader A_0, Style A_1)
    {
        int num = 0x11;
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("䔶尸娺夼娾㍀", num));
        }
        if (A_1 == null)
        {
            throw new ArgumentException(BookmarkStart.b("䐶䴸䈺儼娾", num));
        }
        while (A_0.NodeType != XmlNodeType.Element)
        {
            A_0.Read();
        }
        if (A_0.LocalName != BookmarkStart.b("䌶嬸场渼䬾㡀⽂⁄ᝆ㭈", num))
        {
            throw new XmlException(BookmarkStart.b("戶圸帺䔼伾⑀⁂ㅄ≆ⵈ歊㕌≎㵐獒⅔㙖㹘筚", num) + A_0.LocalName);
        }
        if (!A_0.IsEmptyElement)
        {
            string localName = A_0.LocalName;
            string attribute = A_0.GetAttribute(BookmarkStart.b("䌶䀸䬺堼", num), this.dictionary_18[BookmarkStart.b("䀶", num)]);
            ConditionalFormattingCode code = this.method_372(attribute);
            Class10 class2 = (A_1 as Class13).method_26(code);
            A_0.Read();
            this.method_485(A_0);
            while (A_0.LocalName != localName)
            {
                if (A_0.EOF)
                {
                    break;
                }
                if (A_0.NodeType == XmlNodeType.Element)
                {
                    string str = A_0.LocalName;
                    if (str != null)
                    {
                        if (str != BookmarkStart.b("䔶椸䤺", num))
                        {
                            if (str != BookmarkStart.b("䜶椸䤺", num))
                            {
                                if (str != BookmarkStart.b("䌶嬸场洼䴾", num))
                                {
                                    if (!(str == BookmarkStart.b("䌶䬸欺似", num)))
                                    {
                                        if (str == BookmarkStart.b("䌶娸欺似", num))
                                        {
                                            this.method_375(A_0, class2.method_24());
                                        }
                                    }
                                    else
                                    {
                                        this.method_374(A_0, class2.method_25());
                                    }
                                }
                                else
                                {
                                    this.method_373(A_0, class2.method_26());
                                }
                            }
                            else
                            {
                                this.method_403(A_0, class2.method_23());
                            }
                        }
                        else
                        {
                            this.method_378(A_0, class2.CharacterFormat);
                        }
                    }
                    A_0.Read();
                }
                else
                {
                    A_0.Read();
                }
                this.method_485(A_0);
            }
        }
    }

    private ConditionalFormattingCode method_372(string A_0)
    {
        int num = 6;
        ConditionalFormattingCode firstRow = ConditionalFormattingCode.FirstRow;
        string key = A_0;
        if (key != null)
        {
            int num2;
            if (Class1160.dictionary_87 == null)
            {
                Dictionary<string, int> dictionary1 = new Dictionary<string, int>(13);
                dictionary1.Add(BookmarkStart.b("䨫䜭䈯䄱䀳搵圷䴹", num), 0);
                dictionary1.Add(BookmarkStart.b("䀫伭䌯䘱昳夵伷", num), 1);
                dictionary1.Add(BookmarkStart.b("丫伭帯嘱Գ縵圷䠹䘻", num), 2);
                dictionary1.Add(BookmarkStart.b("丫伭帯嘱س縵圷䠹䘻", num), 3);
                dictionary1.Add(BookmarkStart.b("䨫䜭䈯䄱䀳电圷嘹", num), 4);
                dictionary1.Add(BookmarkStart.b("䀫伭䌯䘱眳夵吷", num), 5);
                dictionary1.Add(BookmarkStart.b("丫伭帯嘱Գ怵崷䠹䠻", num), 6);
                dictionary1.Add(BookmarkStart.b("丫伭帯嘱س怵崷䠹䠻", num), 7);
                dictionary1.Add(BookmarkStart.b("䈫䬭猯圱堳娵", num), 8);
                dictionary1.Add(BookmarkStart.b("䈫夭猯圱堳娵", num), 9);
                dictionary1.Add(BookmarkStart.b("弫䬭猯圱堳娵", num), 10);
                dictionary1.Add(BookmarkStart.b("弫夭猯圱堳娵", num), 11);
                dictionary1.Add(BookmarkStart.b("嬫䘭弯帱儳戵夷堹倻嬽", num), 12);
                Class1160.dictionary_87 = dictionary1;
            }
            if (Class1160.dictionary_87.TryGetValue(key, out num2))
            {
                switch (num2)
                {
                    case 0:
                        return ConditionalFormattingCode.FirstRow;

                    case 1:
                        return ConditionalFormattingCode.LastRow;

                    case 2:
                        return ConditionalFormattingCode.OddRowBanding;

                    case 3:
                        return ConditionalFormattingCode.EvenRowBanding;

                    case 4:
                        return ConditionalFormattingCode.FirstColumn;

                    case 5:
                        return ConditionalFormattingCode.LastColumn;

                    case 6:
                        return ConditionalFormattingCode.OddColumnBanding;

                    case 7:
                        return ConditionalFormattingCode.EvenColumnBanding;

                    case 8:
                        return ConditionalFormattingCode.FirstRowLastCell;

                    case 9:
                        return ConditionalFormattingCode.FirstRowFirstCell;

                    case 10:
                        return ConditionalFormattingCode.LastRowLastCell;

                    case 11:
                        return ConditionalFormattingCode.LastRowFirstCell;

                    case 12:
                        return ConditionalFormattingCode.WholeTable;
                }
            }
        }
        return firstRow;
    }

    private void method_373(XmlReader A_0, Form2 A_1)
    {
        int num = 13;
        if (!A_0.IsEmptyElement)
        {
            string localName = A_0.LocalName;
            A_0.Read();
            this.method_485(A_0);
            while (A_0.LocalName != localName)
            {
                if (A_0.EOF)
                {
                    break;
                }
                if (A_0.NodeType == XmlNodeType.Element)
                {
                    string key = A_0.LocalName;
                    if (key != null)
                    {
                        int num3;
                        if (Class1160.dictionary_88 == null)
                        {
                            Dictionary<string, int> dictionary1 = new Dictionary<string, int>(9);
                            dictionary1.Add(BookmarkStart.b("䜲圴嬶樸伺䐼匾⑀ᅂ⩄うୈ⩊⍌⭎ɐ㩒⽔㉖", num), 0);
                            dictionary1.Add(BookmarkStart.b("䜲圴嬶樸伺䐼匾⑀B⩄⭆ୈ⩊⍌⭎ɐ㩒⽔㉖", num), 1);
                            dictionary1.Add(BookmarkStart.b("䜲圴嬶稸帺儼匾ቀ㍂⑄⑆⁈╊⩌", num), 2);
                            dictionary1.Add(BookmarkStart.b("䜲圴嬶瀸唺夼", num), 3);
                            dictionary1.Add(BookmarkStart.b("夲嘴", num), 4);
                            dictionary1.Add(BookmarkStart.b("䜲圴嬶稸帺儼匾ీ≂㝄", num), 5);
                            dictionary1.Add(BookmarkStart.b("䜲圴嬶笸吺似嬾⑀ㅂ㙄", num), 6);
                            dictionary1.Add(BookmarkStart.b("䀲崴匶", num), 7);
                            dictionary1.Add(BookmarkStart.b("䜲圴嬶樸伺䐼匾⑀ፂ㝄", num), 8);
                            Class1160.dictionary_88 = dictionary1;
                        }
                        if (Class1160.dictionary_88.TryGetValue(key, out num3))
                        {
                            switch (num3)
                            {
                                case 0:
                                {
                                    string attribute = A_0.GetAttribute(BookmarkStart.b("䔲吴嬶", num), this.dictionary_18[BookmarkStart.b("䐲", num)]);
                                    A_1.method_83(long.Parse(attribute, NumberStyles.Integer, CultureInfo.InvariantCulture));
                                    break;
                                }
                                case 1:
                                {
                                    string s = A_0.GetAttribute(BookmarkStart.b("䔲吴嬶", num), this.dictionary_18[BookmarkStart.b("䐲", num)]);
                                    A_1.method_81(long.Parse(s, NumberStyles.Integer, CultureInfo.InvariantCulture));
                                    break;
                                }
                                case 2:
                                {
                                    float num4 = this.method_481(A_0, BookmarkStart.b("䐲", num), this.dictionary_18[BookmarkStart.b("䐲", num)]);
                                    if (num4 != float.MaxValue)
                                    {
                                        A_1.method_75(num4);
                                    }
                                    break;
                                }
                                case 3:
                                {
                                    float num2 = this.method_481(A_0, BookmarkStart.b("䐲", num), this.dictionary_18[BookmarkStart.b("䐲", num)]);
                                    if (num2 != float.MaxValue)
                                    {
                                        A_1.method_77(num2);
                                    }
                                    break;
                                }
                                case 4:
                                    A_1.method_79(this.method_115(A_0));
                                    break;

                                case 5:
                                    this.method_112(A_0, A_1.method_73());
                                    break;

                                case 6:
                                    this.method_416(A_0, A_1.method_72());
                                    break;

                                case 7:
                                    this.method_376(A_0, A_1);
                                    break;
                            }
                        }
                    }
                    A_0.Read();
                }
                else
                {
                    A_0.Read();
                }
                this.method_485(A_0);
            }
        }
    }

    private void method_374(XmlReader A_0, Form1 A_1)
    {
        int num = 6;
        if (!A_0.IsEmptyElement)
        {
            string localName = A_0.LocalName;
            A_0.Read();
            this.method_485(A_0);
            while (A_0.LocalName != localName)
            {
                if (A_0.EOF)
                {
                    break;
                }
                if (A_0.NodeType == XmlNodeType.Element)
                {
                    string str = A_0.LocalName;
                    if (str != null)
                    {
                        if (str != BookmarkStart.b("䐫䜭启嘱儳堵", num))
                        {
                            if (str != BookmarkStart.b("堫䰭尯稱儳圵尷弹主", num))
                            {
                                if (str != BookmarkStart.b("伫伭帯䘱朳䘵吷匹䠻", num))
                                {
                                    if (!(str == BookmarkStart.b("堫䰭尯焱儳娵吷椹䰻弽⌿⭁⩃ⅅ", num)))
                                    {
                                        if (str == BookmarkStart.b("䘫䴭", num))
                                        {
                                            A_1.method_74(this.method_115(A_0));
                                        }
                                    }
                                    else
                                    {
                                        float num2 = this.method_481(A_0, BookmarkStart.b("嬫", num), this.dictionary_18[BookmarkStart.b("嬫", num)]);
                                        if (num2 != float.MaxValue)
                                        {
                                            A_1.method_72(num2);
                                        }
                                    }
                                }
                                else
                                {
                                    A_1.method_70(this.method_469(A_0));
                                }
                            }
                            else
                            {
                                A_1.method_68(this.method_469(A_0));
                            }
                        }
                        else
                        {
                            A_1.method_66(this.method_469(A_0));
                        }
                    }
                    A_0.Read();
                }
                else
                {
                    A_0.Read();
                }
                this.method_485(A_0);
            }
        }
    }

    private void method_375(XmlReader A_0, Form3 A_1)
    {
        int num = 0x10;
        if (!A_0.IsEmptyElement)
        {
            string localName = A_0.LocalName;
            A_0.Read();
            this.method_485(A_0);
            while (A_0.LocalName != localName)
            {
                if (A_0.EOF)
                {
                    break;
                }
                if (A_0.NodeType == XmlNodeType.Element)
                {
                    string str = A_0.LocalName;
                    if (str != null)
                    {
                        if (str != BookmarkStart.b("堵圷洹主弽〿", num))
                        {
                            if (str != BookmarkStart.b("䀵礷嘹唻夽⸿", num))
                            {
                                if (str != BookmarkStart.b("䈵嬷眹崻䰽", num))
                                {
                                    if (!(str == BookmarkStart.b("䈵嬷砹医䰽␿❁㙃㕅", num)))
                                    {
                                        if (str == BookmarkStart.b("䔵倷帹", num))
                                        {
                                            this.method_377(A_0, A_1);
                                        }
                                    }
                                    else
                                    {
                                        this.method_416(A_0, A_1.method_66());
                                    }
                                }
                                else
                                {
                                    this.method_112(A_0, A_1.method_67());
                                }
                            }
                            else
                            {
                                A_1.method_69(this.method_94(A_0));
                            }
                        }
                        else
                        {
                            A_1.method_71(!this.method_469(A_0));
                        }
                    }
                    A_0.Read();
                }
                else
                {
                    A_0.Read();
                }
                this.method_485(A_0);
            }
        }
    }

    private void method_376(XmlReader A_0, Form2 A_1)
    {
        int num = 0x13;
        string attribute = A_0.GetAttribute(BookmarkStart.b("弸刺儼匾", 0x13), this.dictionary_18[BookmarkStart.b("丸", 0x13)]);
        if (attribute != null)
        {
            if (attribute == BookmarkStart.b("堸为䤼倾", num))
            {
                A_1.method_66(Color.Empty);
            }
            else
            {
                A_1.method_66(this.method_474(attribute));
            }
        }
        attribute = A_0.GetAttribute(BookmarkStart.b("娸吺儼倾㍀", num), this.dictionary_18[BookmarkStart.b("丸", num)]);
        if (attribute != null)
        {
            if (attribute == BookmarkStart.b("堸为䤼倾", num))
            {
                A_1.method_68(Color.Empty);
            }
            else
            {
                A_1.method_68(this.method_474(attribute));
            }
        }
        attribute = A_0.GetAttribute(BookmarkStart.b("伸娺儼", num), this.dictionary_18[BookmarkStart.b("丸", num)]);
        if (attribute != null)
        {
            A_1.method_70(this.method_394(attribute));
        }
    }

    private void method_377(XmlReader A_0, Form3 A_1)
    {
        int num = 6;
        string attribute = A_0.GetAttribute(BookmarkStart.b("䨫䜭尯帱", 6), this.dictionary_18[BookmarkStart.b("嬫", 6)]);
        if (attribute != null)
        {
            if (attribute == BookmarkStart.b("䴫嬭䐯崱", num))
            {
                A_1.method_61(Color.Empty);
            }
            else
            {
                A_1.method_61(this.method_474(attribute));
            }
        }
        attribute = A_0.GetAttribute(BookmarkStart.b("伫䄭尯崱䘳", num), this.dictionary_18[BookmarkStart.b("嬫", num)]);
        if (attribute != null)
        {
            if (attribute == BookmarkStart.b("䴫嬭䐯崱", num))
            {
                A_1.method_63(Color.Empty);
            }
            else
            {
                A_1.method_63(this.method_474(attribute));
            }
        }
        attribute = A_0.GetAttribute(BookmarkStart.b("娫伭尯", num), this.dictionary_18[BookmarkStart.b("嬫", num)]);
        if (attribute != null)
        {
            A_1.method_65(this.method_394(attribute));
        }
    }

    private void method_378(XmlReader A_0, CharacterFormat A_1)
    {
        int num = 0x11;
        if (A_0.LocalName != BookmarkStart.b("䔶椸䤺", 0x11))
        {
            throw new XmlException(BookmarkStart.b("收䰸唺ᴼ伾㍀ⱂ㕄≆㭈㽊⑌⩎≐", num));
        }
        if (A_1 == null)
        {
            throw new ArgumentException(BookmarkStart.b("琶儸娺似帾≀㝂⁄㕆楈ൊ≌㵎㱐㉒⅔", num));
        }
        if (!A_0.IsEmptyElement)
        {
            string localName = A_0.LocalName;
            bool flag = false;
            A_0.Read();
            this.method_485(A_0);
            while (A_0.LocalName != localName)
            {
                string str8;
                XmlReader reader;
                if (A_0.EOF)
                {
                    break;
                }
                flag = false;
                if (A_0.NodeType != XmlNodeType.Element)
                {
                    goto Label_0C7F;
                }
                string key = A_0.LocalName;
                if (key != null)
                {
                    int num6;
                    if (Class1160.dictionary_89 == null)
                    {
                        Dictionary<string, int> dictionary1 = new Dictionary<string, int>(0x2c);
                        dictionary1.Add(BookmarkStart.b("䔶缸吺匼䬾㉀", num), 0);
                        dictionary1.Add(BookmarkStart.b("吶䨸", num), 1);
                        dictionary1.Add(BookmarkStart.b("䐶䌸", num), 2);
                        dictionary1.Add(BookmarkStart.b("䐶䌸砺丼", num), 3);
                        dictionary1.Add(BookmarkStart.b("嬶堸唺娼", num), 4);
                        dictionary1.Add(BookmarkStart.b("䈶", num), 5);
                        dictionary1.Add(BookmarkStart.b("䄶尸䤺䤼績ⵀ⩂≄⥆", num), 6);
                        dictionary1.Add(BookmarkStart.b("吶嘸场刼䴾", num), 7);
                        dictionary1.Add(BookmarkStart.b("弶倸尺唼匾⡀⑂ⵄ㍆", num), 8);
                        dictionary1.Add(BookmarkStart.b("堶䰸伺儼嘾⽀♂", num), 9);
                        dictionary1.Add(BookmarkStart.b("䜶嘸䠺吼䬾⡀ⱂ⭄", num), 10);
                        dictionary1.Add(BookmarkStart.b("䐶䤸娺帼嘾⽀⑂", num), 11);
                        dictionary1.Add(BookmarkStart.b("䔶樸伺䐼匾⑀", num), 12);
                        dictionary1.Add(BookmarkStart.b("䐶儸强", num), 13);
                        dictionary1.Add(BookmarkStart.b("唶崸䤺", num), 14);
                        dictionary1.Add(BookmarkStart.b("䔶椸䤺縼圾⁀ⵂ≄≆", num), 15);
                        dictionary1.Add(BookmarkStart.b("唶", num), 0x10);
                        dictionary1.Add(BookmarkStart.b("唶稸䠺", num), 0x11);
                        dictionary1.Add(BookmarkStart.b("吶堸䬺丼", num), 0x12);
                        dictionary1.Add(BookmarkStart.b("匶䨸伺似嘾⩀♂", num), 0x13);
                        dictionary1.Add(BookmarkStart.b("䄶堸唺吼䰾⥀", num), 20);
                        dictionary1.Add(BookmarkStart.b("䐶吸娺儼匾ɀ≂㕄㑆", num), 0x15);
                        dictionary1.Add(BookmarkStart.b("帶吸䬺似嘾⽀㝂", num), 0x16);
                        dictionary1.Add(BookmarkStart.b("制吸夺刼䰾㉀", num), 0x17);
                        dictionary1.Add(BookmarkStart.b("帶", num), 0x18);
                        dictionary1.Add(BookmarkStart.b("帶稸䠺", num), 0x19);
                        dictionary1.Add(BookmarkStart.b("䐶䴸䤺吼吾⑀", num), 0x1a);
                        dictionary1.Add(BookmarkStart.b("䐶儸娺夼倾㙀", num), 0x1b);
                        dictionary1.Add(BookmarkStart.b("夶嘸欺似倾⹀╂", num), 0x1c);
                        dictionary1.Add(BookmarkStart.b("䀶尸夺甼嘾╀❂⁄⥆", num), 0x1d);
                        dictionary1.Add(BookmarkStart.b("䐶圸娺䴼款⹀т㝄⹆ⵈ", num), 30);
                        dictionary1.Add(BookmarkStart.b("䔶䴸场", num), 0x1f);
                        dictionary1.Add(BookmarkStart.b("匶尸场", num), 0x20);
                        dictionary1.Add(BookmarkStart.b("帶圸䠺", num), 0x21);
                        dictionary1.Add(BookmarkStart.b("吶圸伺䔼䬾@⽂ㅄ㑆", num), 0x22);
                        dictionary1.Add(BookmarkStart.b("嬶倸尺尼䬾㑀ㅂ⁄㑆", num), 0x23);
                        dictionary1.Add(BookmarkStart.b("夶䰸嘺笼倾㍀⹂", num), 0x24);
                        dictionary1.Add(BookmarkStart.b("夶䰸嘺渼伾⁀⁂ⱄ⥆⹈", num), 0x25);
                        dictionary1.Add(BookmarkStart.b("䐶䴸䈺儼嘾㉀㝂ⱄ⑆ᩈ⹊㥌㱎", num), 0x26);
                        dictionary1.Add(BookmarkStart.b("䀶", num), 0x27);
                        dictionary1.Add(BookmarkStart.b("尶尸䤺匼", num), 40);
                        dictionary1.Add(BookmarkStart.b("制弸崺堼尾㕀", num), 0x29);
                        dictionary1.Add(BookmarkStart.b("制吸", num), 0x2a);
                        dictionary1.Add(BookmarkStart.b("䜶椸䤺", num), 0x2b);
                        Class1160.dictionary_89 = dictionary1;
                    }
                    if (Class1160.dictionary_89.TryGetValue(key, out num6))
                    {
                        switch (num6)
                        {
                            case 0:
                                this.method_397(A_0, A_1);
                                goto Label_0C73;

                            case 1:
                                if (A_0.NodeType == XmlNodeType.Element)
                                {
                                    A_1.ComplexScript = this.method_469(A_0);
                                    this.method_387(A_1, 0x10c, A_1.ComplexScript);
                                }
                                goto Label_0C73;

                            case 2:
                            {
                                string s = A_0.GetAttribute(BookmarkStart.b("䄶堸场", num), this.dictionary_18[BookmarkStart.b("䀶", num)]);
                                if (s != null)
                                {
                                    A_1.FontSize = float.Parse(s, NumberStyles.Number, CultureInfo.InvariantCulture) / 2f;
                                }
                                goto Label_0C73;
                            }
                            case 3:
                            {
                                string str11 = A_0.GetAttribute(BookmarkStart.b("䄶堸场", num), this.dictionary_18[BookmarkStart.b("䀶", num)]);
                                if (str11 != null)
                                {
                                    A_1.FontSizeBidi = float.Parse(str11, NumberStyles.Number, CultureInfo.InvariantCulture) / 2f;
                                }
                                goto Label_0C73;
                            }
                            case 4:
                                this.method_400(A_0, A_1);
                                goto Label_0C73;

                            case 5:
                                this.method_396(A_0, A_1);
                                goto Label_0C73;

                            case 6:
                                this.method_395(A_0, A_1);
                                goto Label_0C73;

                            case 7:
                                goto Label_05B8;

                            case 8:
                                this.method_402(A_0, A_1);
                                goto Label_0C73;

                            case 9:
                                A_1.IsOutLine = this.method_469(A_0);
                                this.method_387(A_1, 90, A_1.IsOutLine);
                                goto Label_0C73;

                            case 10:
                            {
                                float num5 = this.method_483(A_0, BookmarkStart.b("䄶堸场", num), this.dictionary_18[BookmarkStart.b("䀶", num)]);
                                if (num5 != float.MaxValue)
                                {
                                    A_1.Position = num5;
                                }
                                goto Label_0C73;
                            }
                            case 11:
                            {
                                float num2 = this.method_481(A_0, BookmarkStart.b("䄶堸场", num), this.dictionary_18[BookmarkStart.b("䀶", num)]);
                                if (num2 != float.MaxValue)
                                {
                                    A_1.CharacterSpacing = num2;
                                }
                                goto Label_0C73;
                            }
                            case 12:
                            {
                                string str2 = A_0.GetAttribute(BookmarkStart.b("䄶堸场", num), this.dictionary_18[BookmarkStart.b("䀶", num)]);
                                if (this.method_22().ContainsKey(str2))
                                {
                                    A_1.CharStyleName = this.method_22()[str2];
                                }
                                goto Label_0C73;
                            }
                            case 13:
                                this.method_393(A_0, A_1);
                                goto Label_0C73;

                            case 14:
                                this.method_389(A_0, A_1.Border);
                                goto Label_0C73;

                            case 15:
                                this.method_388(A_0, A_1);
                                goto Label_0C73;

                            case 0x10:
                                A_1.Bold = this.method_469(A_0);
                                goto Label_0C73;

                            case 0x11:
                                A_1.BoldBidi = this.method_469(A_0);
                                goto Label_0C73;

                            case 0x12:
                                A_1.AllCaps = this.method_469(A_0);
                                goto Label_0C73;

                            case 0x13:
                                A_1.DoubleStrike = this.method_469(A_0);
                                goto Label_0C73;

                            case 20:
                                A_1.Hidden = this.method_469(A_0);
                                goto Label_0C73;

                            case 0x15:
                                A_1.IsSmallCaps = this.method_469(A_0);
                                goto Label_0C73;

                            case 0x16:
                                A_1.Engrave = this.method_469(A_0);
                                goto Label_0C73;

                            case 0x17:
                                A_1.Emboss = this.method_469(A_0);
                                goto Label_0C73;

                            case 0x18:
                                A_1.Italic = this.method_469(A_0);
                                goto Label_0C73;

                            case 0x19:
                                A_1.ItalicBidi = this.method_469(A_0);
                                goto Label_0C73;

                            case 0x1a:
                                A_1.IsStrikeout = this.method_469(A_0);
                                goto Label_0C73;

                            case 0x1b:
                                A_1.IsShadow = this.method_469(A_0);
                                goto Label_0C73;

                            case 0x1c:
                                A_1.IsNoProof = this.method_469(A_0);
                                goto Label_0C73;

                            case 0x1d:
                                A_1.IsWebHidden = this.method_469(A_0);
                                goto Label_0C73;

                            case 30:
                                A_1.SnapToGrid = this.method_469(A_0);
                                goto Label_0C73;

                            case 0x1f:
                                A_1.Bidi = this.method_469(A_0);
                                goto Label_0C73;

                            case 0x20:
                            {
                                A_1.IsDeleteRevision = true;
                                string str3 = A_0.GetAttribute(BookmarkStart.b("嘶䰸伺唼倾㍀", num), this.dictionary_18[BookmarkStart.b("䀶", num)]);
                                DateTime time = Class1041.smethod_3(A_0.GetAttribute(BookmarkStart.b("匶堸伺堼", num), this.dictionary_18[BookmarkStart.b("䀶", num)]));
                                A_1.DeleteRevision = new Class579(EditRevisionType.Deletion, str3, time);
                                goto Label_0C73;
                            }
                            case 0x21:
                            {
                                A_1.IsInsertRevision = true;
                                string str14 = A_0.GetAttribute(BookmarkStart.b("嘶䰸伺唼倾㍀", num), this.dictionary_18[BookmarkStart.b("䀶", num)]);
                                DateTime time2 = Class1041.smethod_3(A_0.GetAttribute(BookmarkStart.b("匶堸伺堼", num), this.dictionary_18[BookmarkStart.b("䀶", num)]));
                                A_1.InsertRevision = new Class579(EditRevisionType.Insertion, str14, time2);
                                goto Label_0C73;
                            }
                            case 0x22:
                                A_1.AllowContextualAlternates = this.method_471(A_0, this.dictionary_18[BookmarkStart.b("䀶࠸༺", num)]);
                                goto Label_0C73;

                            case 0x23:
                                this.method_381(A_0, A_1);
                                goto Label_0C73;

                            case 0x24:
                                this.method_382(A_0, A_1);
                                goto Label_0C73;

                            case 0x25:
                                this.method_383(A_0, A_1);
                                goto Label_0C73;

                            case 0x26:
                                this.method_384(A_0, A_1);
                                goto Label_0C73;

                            case 0x27:
                            {
                                string str4 = A_0.GetAttribute(BookmarkStart.b("䄶堸场", num), this.dictionary_18[BookmarkStart.b("䀶", num)]);
                                if (!string.IsNullOrEmpty(str4))
                                {
                                    int num3 = int.Parse(str4.Replace(BookmarkStart.b("ሶ", num), string.Empty), NumberStyles.Integer, CultureInfo.InvariantCulture);
                                    A_1.TextScale = (short) num3;
                                }
                                goto Label_0C73;
                            }
                            case 40:
                            {
                                float num4 = float.Parse(A_0.GetAttribute(BookmarkStart.b("䄶堸场", num), this.dictionary_18[BookmarkStart.b("䀶", num)]));
                                A_1.Kerning = num4 / 2f;
                                goto Label_0C73;
                            }
                            case 0x29:
                            {
                                string str6 = A_0.GetAttribute(BookmarkStart.b("䄶堸场", num), this.dictionary_18[BookmarkStart.b("䀶", num)]);
                                if (!string.IsNullOrEmpty(str6))
                                {
                                    A_1.TextEffect = this.method_380(str6);
                                }
                                goto Label_0C73;
                            }
                            case 0x2a:
                            {
                                string str10 = A_0.GetAttribute(BookmarkStart.b("䄶堸场", num), this.dictionary_18[BookmarkStart.b("䀶", num)]);
                                if (!string.IsNullOrEmpty(str10))
                                {
                                    A_1.EmphasisVal = this.method_379(str10);
                                }
                                goto Label_0C73;
                            }
                            case 0x2b:
                            {
                                reader = Class57.smethod_18(this.method_484(A_0));
                                if (!(A_1.OwnerBase is ParagraphStyle))
                                {
                                    goto Label_0C0C;
                                }
                                ParagraphFormat format = this.method_370(A_1.OwnerBase as Style);
                                this.method_403(reader, format);
                                goto Label_0C31;
                            }
                        }
                    }
                }
                goto Label_0C35;
            Label_05B8:
                str8 = A_0.GetAttribute(BookmarkStart.b("䄶堸场", num), this.dictionary_18[BookmarkStart.b("䀶", num)]);
                string attribute = A_0.GetAttribute(BookmarkStart.b("䌶儸帺值娾ɀⱂ⥄⡆㭈", num), this.dictionary_18[BookmarkStart.b("䀶", num)]);
                string str5 = A_0.GetAttribute(BookmarkStart.b("䌶儸帺值娾ቀ⭂⑄⍆ⱈ", num), this.dictionary_18[BookmarkStart.b("䀶", num)]);
                string str7 = A_0.GetAttribute(BookmarkStart.b("䌶儸帺值娾ᕀ⩂⭄㍆", num), this.dictionary_18[BookmarkStart.b("䀶", num)]);
                if (str8 == BookmarkStart.b("嘶䰸伺刼", num))
                {
                    A_1.method_55(Color.Empty);
                }
                if (!string.IsNullOrEmpty(attribute))
                {
                    A_1.TextThemeColor.method_1(attribute);
                    if (!string.IsNullOrEmpty(str5))
                    {
                        A_1.TextThemeColor.method_3(str5);
                    }
                    if (!string.IsNullOrEmpty(str7))
                    {
                        A_1.TextThemeColor.method_5(str7);
                    }
                    Color color = A_1.TextThemeColor.method_6();
                    A_1.method_55(color.IsEmpty ? this.method_474(str8) : color);
                }
                else if (str8 != null)
                {
                    A_1.method_55(this.method_474(str8));
                }
                goto Label_0C73;
            Label_0C0C:
                if (A_1.OwnerBase is Paragraph)
                {
                    this.method_403(reader, (A_1.OwnerBase as Paragraph).Format);
                }
            Label_0C31:
                flag = true;
                goto Label_0C73;
            Label_0C35:
                if ((A_0.LocalName != string.Empty) && (A_0.LocalName != BookmarkStart.b("䔶椸䤺", num)))
                {
                    A_1.XmlProps2010.Add(this.method_484(A_0));
                    flag = true;
                }
            Label_0C73:
                if (!flag)
                {
                    A_0.Read();
                }
                goto Label_0C86;
            Label_0C7F:
                A_0.Read();
            Label_0C86:
                this.method_485(A_0);
            }
            this.method_386(A_1);
        }
    }

    private Emphasis method_379(string A_0)
    {
        int num = 0x12;
        string str = A_0;
        if (str != null)
        {
            if (str == BookmarkStart.b("嬷匹主崽ⰿ❁", num))
            {
                return Emphasis.CircleAbove;
            }
            if (str == BookmarkStart.b("嬷唹儻匽ℿ", num))
            {
                return Emphasis.CommaAbove;
            }
            if (str == BookmarkStart.b("尷唹䠻", num))
            {
                return Emphasis.Dot;
            }
            if ((str == BookmarkStart.b("䴷吹堻嬽㈿ف⭃㉅", num)) || (str == BookmarkStart.b("䴷吹堻嬽㈿潁⁃⥅㱇", num)))
            {
                return Emphasis.DotBelow;
            }
        }
        return Emphasis.None;
    }

    private void method_38(string A_0, string A_1)
    {
        Class1128 class2 = this.document_0.DocxPackage.method_18(A_1);
        if (class2.method_0().ContainsKey(A_0))
        {
            Class229 class3 = class2.method_0()[A_0];
            class2.method_0().Remove(A_0);
            class3.method_4().Close();
            class3 = null;
        }
    }

    private TextEffect method_380(string A_0)
    {
        int num = 0x10;
        string key = A_0;
        if (key != null)
        {
            int num2;
            if (Class1160.dictionary_90 == null)
            {
                Dictionary<string, int> dictionary1 = new Dictionary<string, int>(10);
                dictionary1.Add(BookmarkStart.b("吵吷匹刻唽ȿ⍁❃ⵅ⽇㡉⍋㭍㹏㙑", num), 0);
                dictionary1.Add(BookmarkStart.b("吵吷匹刻唽洿⁁╃╅⍇ⵉ㹋⅍╏㱑こ", num), 1);
                dictionary1.Add(BookmarkStart.b("娵儷崹吻䨽㌿", num), 2);
                dictionary1.Add(BookmarkStart.b("圵嘷丹伻簽ⰿ⍁❃ⵅ", num), 3);
                dictionary1.Add(BookmarkStart.b("圵嘷丹伻ጽ∿⹁╃╅⍇", num), 4);
                dictionary1.Add(BookmarkStart.b("圵嘷丹伻氽┿♁", num), 5);
                dictionary1.Add(BookmarkStart.b("圵嘷丹伻ጽ㈿❁⁃", num), 6);
                dictionary1.Add(BookmarkStart.b("䔵倷匹儻匽┿ぁ", num), 7);
                dictionary1.Add(BookmarkStart.b("䔵䠷嬹主唽ⰿ❁", num), 8);
                dictionary1.Add(BookmarkStart.b("堵圷吹夻", num), 9);
                Class1160.dictionary_90 = dictionary1;
            }
            if (Class1160.dictionary_90.TryGetValue(key, out num2))
            {
                switch (num2)
                {
                    case 0:
                    case 1:
                        return TextEffect.BlinkingBackground;

                    case 2:
                        return TextEffect.LasVegasLights;

                    case 3:
                    case 4:
                        return TextEffect.MarchingBlackAnts;

                    case 5:
                    case 6:
                        return TextEffect.MarchingRedAnts;

                    case 7:
                        return TextEffect.Shimmer;

                    case 8:
                        return TextEffect.SparkleText;
                }
            }
        }
        return TextEffect.None;
    }

    private void method_381(XmlReader A_0, CharacterFormat A_1)
    {
        int num = 6;
        string attribute = A_0.GetAttribute(BookmarkStart.b("娫伭尯", 6), this.dictionary_18[BookmarkStart.b("嬫ἭЯ", 6)]);
        if (attribute != null)
        {
            int num2;
            if (Class1160.dictionary_91 == null)
            {
                Dictionary<string, int> dictionary1 = new Dictionary<string, int>(0x10);
                dictionary1.Add(BookmarkStart.b("䈫䄭帯圱", num), 0);
                dictionary1.Add(BookmarkStart.b("弫娭儯就倳圵䨷帹", num), 1);
                dictionary1.Add(BookmarkStart.b("伫䄭帯䘱儳丵䰷伹崻刽", num), 2);
                dictionary1.Add(BookmarkStart.b("弫娭儯就倳圵䨷帹缻儽⸿㙁⅃㹅㱇㽉ⵋ≍", num), 3);
                dictionary1.Add(BookmarkStart.b("䐫䜭䌯䘱嬳䐵儷夹崻刽", num), 4);
                dictionary1.Add(BookmarkStart.b("弫娭儯就倳圵䨷帹琻圽㌿㙁⭃㑅ⅇ⥉ⵋ≍", num), 5);
                dictionary1.Add(BookmarkStart.b("伫䄭帯䘱儳丵䰷伹崻刽࠿⭁㝃㉅❇㡉╋ⵍㅏ㹑", num), 6);
                dictionary1.Add(BookmarkStart.b("弫娭儯就倳圵䨷帹缻儽⸿㙁⅃㹅㱇㽉ⵋ≍ᡏ㭑❓≕㝗⡙㕛㵝ş๡", num), 7);
                dictionary1.Add(BookmarkStart.b("䠫䜭䌯儱䘳匵䰷匹医倽ℿ⹁", num), 8);
                dictionary1.Add(BookmarkStart.b("弫娭儯就倳圵䨷帹砻圽㌿⅁㙃⍅㱇⍉⍋⁍ㅏ㹑", num), 9);
                dictionary1.Add(BookmarkStart.b("伫䄭帯䘱儳丵䰷伹崻刽п⭁㝃╅㩇⽉㡋❍㽏㱑㕓㩕", num), 10);
                dictionary1.Add(BookmarkStart.b("弫娭儯就倳圵䨷帹缻儽⸿㙁⅃㹅㱇㽉ⵋ≍ᑏ㭑❓㕕⩗㽙⡛㝝ཟౡգ੥", num), 11);
                dictionary1.Add(BookmarkStart.b("䐫䜭䌯䘱嬳䐵儷夹崻刽п⭁㝃╅㩇⽉㡋❍㽏㱑㕓㩕", num), 12);
                dictionary1.Add(BookmarkStart.b("弫娭儯就倳圵䨷帹琻圽㌿㙁⭃㑅ⅇ⥉ⵋ≍ᑏ㭑❓㕕⩗㽙⡛㝝ཟౡգ੥", num), 13);
                dictionary1.Add(BookmarkStart.b("伫䄭帯䘱儳丵䰷伹崻刽࠿⭁㝃㉅❇㡉╋ⵍㅏ㹑ၓ㽕⭗㥙⹛㭝ᑟୡୣࡥ१٩", num), 14);
                dictionary1.Add(BookmarkStart.b("䴫䈭尯", num), 15);
                Class1160.dictionary_91 = dictionary1;
            }
            if (Class1160.dictionary_91.TryGetValue(attribute, out num2))
            {
                switch (num2)
                {
                    case 0:
                        A_1.LigaturesType = LigatureType.None;
                        return;

                    case 1:
                        A_1.LigaturesType = LigatureType.Standard;
                        return;

                    case 2:
                        A_1.LigaturesType = LigatureType.Contextual;
                        return;

                    case 3:
                        A_1.LigaturesType = LigatureType.DefaultContextual;
                        return;

                    case 4:
                        A_1.LigaturesType = LigatureType.Historical;
                        return;

                    case 5:
                        A_1.LigaturesType = LigatureType.DefaultHistorical;
                        return;

                    case 6:
                        A_1.LigaturesType = LigatureType.ContextualHistorical;
                        return;

                    case 7:
                        A_1.LigaturesType = LigatureType.DefaultContextualHistorical;
                        return;

                    case 8:
                        A_1.LigaturesType = LigatureType.Discretional;
                        return;

                    case 9:
                        A_1.LigaturesType = LigatureType.DefaultDiscretional;
                        return;

                    case 10:
                        A_1.LigaturesType = LigatureType.ContextualDiscretional;
                        return;

                    case 11:
                        A_1.LigaturesType = LigatureType.DefaultContextualDiscretional;
                        return;

                    case 12:
                        A_1.LigaturesType = LigatureType.HistoricalDiscretional;
                        return;

                    case 13:
                        A_1.LigaturesType = LigatureType.DefaultHistoricalDiscretional;
                        return;

                    case 14:
                        A_1.LigaturesType = LigatureType.ContextualHistoricalDiscretional;
                        return;

                    case 15:
                        A_1.LigaturesType = LigatureType.All;
                        break;

                    default:
                        return;
                }
            }
        }
    }

    private void method_382(XmlReader A_0, CharacterFormat A_1)
    {
        int num = 2;
        string attribute = A_0.GetAttribute(BookmarkStart.b("帧䬩䀫", 2), this.dictionary_18[BookmarkStart.b("弧ᬩᠫ", 2)]);
        if (attribute != null)
        {
            if (attribute == BookmarkStart.b("䰧伩䨫伭䔯帱䀳", num))
            {
                A_1.NumberFormType = NumberFormType.Default;
            }
            else if (attribute == BookmarkStart.b("䐧䌩䈫䜭帯唱", num))
            {
                A_1.NumberFormType = NumberFormType.Lining;
            }
            else if (attribute == BookmarkStart.b("䜧䘩䠫紭䐯䬱堳匵", num))
            {
                A_1.NumberFormType = NumberFormType.Old;
            }
        }
    }

    private void method_383(XmlReader A_0, CharacterFormat A_1)
    {
        int num = 12;
        string attribute = A_0.GetAttribute(BookmarkStart.b("䐱唳娵", 12), this.dictionary_18[BookmarkStart.b("䔱Գȵ", 12)]);
        if (attribute != null)
        {
            if (attribute == BookmarkStart.b("嘱儳倵夷伹倻䨽", num))
            {
                A_1.NumberSpaceType = NumberSpaceType.Default;
            }
            else if (attribute == BookmarkStart.b("䈱䘳夵䠷唹主䨽⤿ⵁ⩃❅⑇", num))
            {
                A_1.NumberSpaceType = NumberSpaceType.Proportional;
            }
            else if (attribute == BookmarkStart.b("䘱唳吵䴷嘹崻䰽", num))
            {
                A_1.NumberSpaceType = NumberSpaceType.Tabular;
            }
        }
    }

    private void method_384(XmlReader A_0, CharacterFormat A_1)
    {
        int num = 3;
        if (A_0 == null)
        {
            throw new Exception(BookmarkStart.b("嬨个䰬䬮吰䄲ᔴ帶䨸ᬺ匼䨾ⵀ⽂", num));
        }
        while (A_0.NodeType != XmlNodeType.Element)
        {
            A_0.Read();
        }
        if (A_0.LocalName != BookmarkStart.b("娨弪听䌮堰䀲䄴帶娸栺堼䬾㉀", num))
        {
            throw new XmlException(BookmarkStart.b("氨匪崬䨮到䜲倴匶ᤸ䌺值匾慀㝂⑄⁆楈楊㹌㭎⡐㽒㱔⑖ⵘ㉚㹜౞Ѡᝢᙤ䕦", num));
        }
        if (!A_0.IsEmptyElement)
        {
            A_0.Read();
            this.method_485(A_0);
            while (A_0.LocalName != BookmarkStart.b("娨弪听䌮堰䀲䄴帶娸栺堼䬾㉀", num))
            {
                string str;
                if (((A_0.NodeType == XmlNodeType.Element) && ((str = A_0.LocalName) != null)) && (str == BookmarkStart.b("娨弪听䌮吰怲倴䌶", num)))
                {
                    string attribute = A_0.GetAttribute(BookmarkStart.b("䀨伪", num), this.dictionary_18[BookmarkStart.b("帨ᨪ᤬", num)]);
                    A_1.StylisticSetType = this.method_385(attribute);
                }
                A_0.Read();
                this.method_485(A_0);
            }
        }
    }

    private StylisticSetType method_385(string A_0)
    {
        int num = 8;
        StylisticSetType type = StylisticSetType.Default;
        string key = A_0;
        if (key != null)
        {
            int num2;
            if (Class1160.dictionary_92 == null)
            {
                Dictionary<string, int> dictionary1 = new Dictionary<string, int>(0x15);
                dictionary1.Add(BookmarkStart.b("ḭ", num), 0);
                dictionary1.Add(BookmarkStart.b("Ἥ", num), 1);
                dictionary1.Add(BookmarkStart.b("ᰭ", num), 2);
                dictionary1.Add(BookmarkStart.b("ᴭ", num), 3);
                dictionary1.Add(BookmarkStart.b("ᨭ", num), 4);
                dictionary1.Add(BookmarkStart.b("ᬭ", num), 5);
                dictionary1.Add(BookmarkStart.b("ᠭ", num), 6);
                dictionary1.Add(BookmarkStart.b("᤭", num), 7);
                dictionary1.Add(BookmarkStart.b("ᘭ", num), 8);
                dictionary1.Add(BookmarkStart.b("ᜭ", num), 9);
                dictionary1.Add(BookmarkStart.b("Ἥ/", num), 10);
                dictionary1.Add(BookmarkStart.b("Ἥį", num), 11);
                dictionary1.Add(BookmarkStart.b("Ἥȯ", num), 12);
                dictionary1.Add(BookmarkStart.b("Ἥ̯", num), 13);
                dictionary1.Add(BookmarkStart.b("ἭЯ", num), 14);
                dictionary1.Add(BookmarkStart.b("Ἥԯ", num), 15);
                dictionary1.Add(BookmarkStart.b("Ἥد", num), 0x10);
                dictionary1.Add(BookmarkStart.b("Ἥܯ", num), 0x11);
                dictionary1.Add(BookmarkStart.b("Ἥ࠯", num), 0x12);
                dictionary1.Add(BookmarkStart.b("Ἥय", num), 0x13);
                dictionary1.Add(BookmarkStart.b("ᰭ/", num), 20);
                Class1160.dictionary_92 = dictionary1;
            }
            if (Class1160.dictionary_92.TryGetValue(key, out num2))
            {
                switch (num2)
                {
                    case 0:
                        return StylisticSetType.Default;

                    case 1:
                        return StylisticSetType.StylisticSet01;

                    case 2:
                        return StylisticSetType.StylisticSet02;

                    case 3:
                        return StylisticSetType.StylisticSet03;

                    case 4:
                        return StylisticSetType.StylisticSet04;

                    case 5:
                        return StylisticSetType.StylisticSet05;

                    case 6:
                        return StylisticSetType.StylisticSet06;

                    case 7:
                        return StylisticSetType.StylisticSet07;

                    case 8:
                        return StylisticSetType.StylisticSet08;

                    case 9:
                        return StylisticSetType.StylisticSet09;

                    case 10:
                        return StylisticSetType.StylisticSet10;

                    case 11:
                        return StylisticSetType.StylisticSet11;

                    case 12:
                        return StylisticSetType.StylisticSet12;

                    case 13:
                        return StylisticSetType.StylisticSet13;

                    case 14:
                        return StylisticSetType.StylisticSet14;

                    case 15:
                        return StylisticSetType.StylisticSet15;

                    case 0x10:
                        return StylisticSetType.StylisticSet16;

                    case 0x11:
                        return StylisticSetType.StylisticSet17;

                    case 0x12:
                        return StylisticSetType.StylisticSet18;

                    case 0x13:
                        return StylisticSetType.StylisticSet19;

                    case 20:
                        return StylisticSetType.StylisticSet20;
                }
            }
        }
        return type;
    }

    private void method_386(CharacterFormat A_0)
    {
        int num = 3;
        string str = A_0.HasValue(230) ? A_0.method_69(230) : null;
        if (!string.IsNullOrEmpty(str))
        {
            if (str == BookmarkStart.b("搨䐪䌬䀮䔰䨲䔴制ᤸ砺刼䴾㉀⩂㍄♆", num))
            {
                A_0.Italic = true;
            }
            FontStyle regular = FontStyle.Regular;
            if (A_0.HasValue(60) && A_0.Bold)
            {
                regular |= FontStyle.Bold;
            }
            if (A_0.HasValue(70) && A_0.Italic)
            {
                regular |= FontStyle.Italic;
            }
            if (A_0.HasValue(140) && (A_0.UnderlineStyle != UnderlineStyle.None))
            {
                regular |= FontStyle.Underline;
            }
            if (A_0.HasValue(80) && A_0.IsStrikeout)
            {
                regular |= FontStyle.Strikeout;
            }
            Font item = Class58.smethod_1(str, 11f, regular);
            if (!this.document_0.UsedFontNames.Contains(item))
            {
                this.document_0.UsedFontNames.Add(item);
            }
        }
    }

    private void method_387(FormatBase A_0, short A_1, bool A_2)
    {
    }

    private void method_388(XmlReader A_0, CharacterFormat A_1)
    {
        A_1.IsChangedFormat = true;
        string attribute = A_0.GetAttribute(BookmarkStart.b("儯䜱䀳帵圷䠹", 10), this.dictionary_18[BookmarkStart.b("䜯", 10)]);
        DateTime time = Class1041.smethod_3(A_0.GetAttribute(BookmarkStart.b("启匱䀳匵", 10), this.dictionary_18[BookmarkStart.b("䜯", 10)]));
        CharacterFormat format = new CharacterFormat(this.document_0);
        Class580 class2 = new Class580(format, attribute, time);
        A_1.FormatRevision = class2;
        if (!A_0.IsEmptyElement)
        {
            A_0.Read();
            this.method_485(A_0);
            this.method_378(A_0, format);
        }
    }

    private void method_389(XmlReader A_0, Border A_1)
    {
        int num = 0x12;
        A_1.IsRead = true;
        string attribute = A_0.GetAttribute(BookmarkStart.b("䬷䀹", 0x12), this.dictionary_18[BookmarkStart.b("伷", 0x12)]);
        if (attribute != null)
        {
            A_1.LineWidth = float.Parse(attribute, NumberStyles.Float, CultureInfo.InvariantCulture) / 8f;
            A_1.IsChanged = true;
        }
        attribute = A_0.GetAttribute(BookmarkStart.b("丷嬹倻", num), this.dictionary_18[BookmarkStart.b("伷", num)]);
        if (attribute != null)
        {
            A_1.BorderType = this.method_390(attribute, A_1);
            A_1.IsChanged = true;
        }
        attribute = A_0.GetAttribute(BookmarkStart.b("䬷䨹崻崽┿", num), this.dictionary_18[BookmarkStart.b("伷", num)]);
        if (attribute != null)
        {
            A_1.Space = float.Parse(attribute, NumberStyles.Float, CultureInfo.InvariantCulture);
        }
        string str2 = A_0.GetAttribute(BookmarkStart.b("嬷唹倻儽㈿", num), this.dictionary_18[BookmarkStart.b("伷", num)]);
        if (str2 != null)
        {
            if ((str2 == BookmarkStart.b("夷伹䠻儽", num)) && (A_1.BorderType == BorderStyle.None))
            {
                A_1.Color = Color.Empty;
            }
            else
            {
                A_1.Color = this.method_474(str2);
            }
            A_1.IsChanged = true;
        }
        attribute = A_0.GetAttribute(BookmarkStart.b("䬷刹崻娽⼿㕁", num), this.dictionary_18[BookmarkStart.b("伷", num)]);
        if ((attribute != null) && (((attribute == BookmarkStart.b("圷吹", num)) || (attribute == BookmarkStart.b("ष", num))) || (attribute == BookmarkStart.b("䰷䠹䤻嬽", num))))
        {
            A_1.Shadow = true;
        }
        if (((A_1.BorderType == BorderStyle.None) && !A_1.HasNoneStyle) && ((A_1.LineWidth == 0f) && (A_1.Color == Color.Black)))
        {
            A_1.BorderType = BorderStyle.Single;
            A_1.LineWidth = 0.5f;
        }
        A_1.IsRead = false;
    }

    private void method_39(Stream A_0)
    {
        int num = 4;
        A_0.Position = 0L;
        XmlReader reader = Class57.smethod_18(A_0);
        if (reader == null)
        {
            throw new Exception(BookmarkStart.b("堩䤫伭启圱䘳", num));
        }
        while (reader.NodeType != XmlNodeType.Element)
        {
            reader.Read();
        }
        string localName = reader.LocalName;
        if ((reader.LocalName != BookmarkStart.b("崩䤫䰭振圱䀳䈵儷吹嬻䴽", num)) && (reader.LocalName != BookmarkStart.b("丩䌫䴭䔯弱儳堵䰷", num)))
        {
            throw new XmlException(BookmarkStart.b("缩䈫䬭䠯䈱儳唵䰷弹堻ḽ㠿⽁⡃晅㱇⭉⭋湍", num) + reader.LocalName);
        }
        if (!reader.IsEmptyElement)
        {
            this.method_316(reader, BookmarkStart.b("崩䤫䰭振圱䀳䈵儷吹嬻䴽", num));
            if (this.document_0.WebSettings == null)
            {
                this.document_0.WebSettings = new Class50(this.document_0);
            }
            reader.Read();
            this.method_40(reader, BookmarkStart.b("崩䤫䰭振圱䀳䈵儷吹嬻䴽", num));
            this.method_317();
        }
    }

    private BorderStyle method_390(string A_0, Border A_1)
    {
        BorderStyle style = this.method_391(A_0);
        if (style == BorderStyle.None)
        {
            A_1.HasNoneStyle = true;
        }
        return style;
    }

    private BorderStyle method_391(string A_0)
    {
        int num = 3;
        BorderStyle none = BorderStyle.None;
        string key = A_0;
        if (key != null)
        {
            int num2;
            if (Class1160.dictionary_93 == null)
            {
                Dictionary<string, int> dictionary1 = new Dictionary<string, int>(0x23);
                dictionary1.Add(BookmarkStart.b("崨尪䐬尮䔰嘲儴笶倸唺堼䰾灀", num), 0);
                dictionary1.Add(BookmarkStart.b("崨太䐬", num), 1);
                dictionary1.Add(BookmarkStart.b("崨太䐬弮崰嘲", num), 2);
                dictionary1.Add(BookmarkStart.b("䴨䨪帬䜮戰帲吴嬶唸簺尼伾", num), 3);
                dictionary1.Add(BookmarkStart.b("娨䔪䨬", num), 4);
                dictionary1.Add(BookmarkStart.b("娨䈪䌬䠮崰嘲", num), 5);
                dictionary1.Add(BookmarkStart.b("䴨䐪夬嬮吰圲", num), 6);
                dictionary1.Add(BookmarkStart.b("䴨䐪夬欮倰䀲崴", num), 7);
                dictionary1.Add(BookmarkStart.b("䴨䐪夬欮帰䜲焴嘶䨸区", num), 8);
                dictionary1.Add(BookmarkStart.b("䴨䨪帬䜮吰圲", num), 9);
                dictionary1.Add(BookmarkStart.b("䴨䤪䄬", num), 10);
                dictionary1.Add(BookmarkStart.b("䴨䐪堬䴮崰嘲", num), 11);
                dictionary1.Add(BookmarkStart.b("崨䌪䐬䄮攰嬲尴夶", num), 12);
                dictionary1.Add(BookmarkStart.b("崨䌪䐬䰮娰朲崴帶圸栺值帾ⵀ⽂Ʉ♆㥈", num), 13);
                dictionary1.Add(BookmarkStart.b("崨䌪䐬䄮攰嬲尴吶券栺值帾ⵀ⽂Ʉ♆㥈", num), 14);
                dictionary1.Add(BookmarkStart.b("崨䌪䐬䄮攰嬲尴吶券漺唼嘾⽀၂⡄♆╈❊ੌ⹎⅐", num), 15);
                dictionary1.Add(BookmarkStart.b("崨䌪䐬䰮娰焲倴䌶丸帺堼儾ᕀ⭂ⱄ⥆", num), 0x10);
                dictionary1.Add(BookmarkStart.b("崨䌪䐬䄮攰嬲尴吶券漺唼嘾⽀โ⁄⍆⁈㹊⁌ࡎぐ⍒", num), 0x11);
                dictionary1.Add(BookmarkStart.b("崨䌪䐬䰮娰朲崴帶圸", num), 0x12);
                dictionary1.Add(BookmarkStart.b("崨䌪䐬䰮娰朲崴帶圸瘺堼嬾⡀㙂⡄F⡈㭊", num), 0x13);
                dictionary1.Add(BookmarkStart.b("崨䌪䐬䄮攰嬲尴吶券", num), 20);
                dictionary1.Add(BookmarkStart.b("崨䌪䐬䄮攰嬲尴吶券瘺堼嬾⡀㙂⡄F⡈㭊", num), 0x15);
                dictionary1.Add(BookmarkStart.b("崨䌪䐬䰮娰朲崴帶圸眺尼䴾♀♂Ʉ♆㥈", num), 0x16);
                dictionary1.Add(BookmarkStart.b("崨䌪䐬䄮攰嬲尴吶券眺尼䴾♀♂Ʉ♆㥈", num), 0x17);
                dictionary1.Add(BookmarkStart.b("崨䌪䐬䄮攰嬲尴吶券漺唼嘾⽀ག⑄㕆⹈⹊ੌ⹎⅐", num), 0x18);
                dictionary1.Add(BookmarkStart.b("崨䌪䐬䰮娰", num), 0x19);
                dictionary1.Add(BookmarkStart.b("帨䨪嬬䨮", num), 0x1a);
                dictionary1.Add(BookmarkStart.b("䴨䐪堬䴮崰嘲戴嘶伸帺", num), 0x1b);
                dictionary1.Add(BookmarkStart.b("䴨䨪帬䜮田尲䄴搶䴸䤺刼吾⑀❂", num), 0x1c);
                dictionary1.Add(BookmarkStart.b("崨䌪弬䨮吰眲瀴夶常䤺尼䤾⑀", num), 0x1d);
                dictionary1.Add(BookmarkStart.b("崨䌪弬䨮吰眲瀴娶嬸吺丼䰾", num), 30);
                dictionary1.Add(BookmarkStart.b("䘨帪夬尮吰䜲", num), 0x1f);
                dictionary1.Add(BookmarkStart.b("䀨䔪帬䨮䔰", num), 0x20);
                dictionary1.Add(BookmarkStart.b("䜨䈪䄬", num), 0x21);
                dictionary1.Add(BookmarkStart.b("䜨䐪䌬䨮", num), 0x22);
                Class1160.dictionary_93 = dictionary1;
            }
            if (Class1160.dictionary_93.TryGetValue(key, out num2))
            {
                switch (num2)
                {
                    case 0:
                        return BorderStyle.TwistedLines1;

                    case 1:
                    case 2:
                        return BorderStyle.Triple;

                    case 3:
                        return BorderStyle.DashSmallGap;

                    case 4:
                    case 5:
                        return BorderStyle.Single;

                    case 6:
                        return BorderStyle.Dot;

                    case 7:
                        return BorderStyle.DotDash;

                    case 8:
                        return BorderStyle.DotDotDash;

                    case 9:
                        return BorderStyle.DashLargeGap;

                    case 10:
                    case 11:
                        return BorderStyle.Double;

                    case 12:
                        return BorderStyle.ThickThinSmallGap;

                    case 13:
                        return BorderStyle.ThickThinSmallGap;

                    case 14:
                        return BorderStyle.ThinThickSmallGap;

                    case 15:
                        return BorderStyle.ThinThickThinSmallGap;

                    case 0x10:
                    case 0x11:
                        return BorderStyle.ThinThickThinMediumGap;

                    case 0x12:
                    case 0x13:
                        return BorderStyle.ThickThinMediumGap;

                    case 20:
                    case 0x15:
                        return BorderStyle.ThinThickMediumGap;

                    case 0x16:
                        return BorderStyle.ThickThinLargeGap;

                    case 0x17:
                        return BorderStyle.ThinThickLargeGap;

                    case 0x18:
                        return BorderStyle.ThinThickThinLargeGap;

                    case 0x19:
                        return BorderStyle.Thick;

                    case 0x1a:
                        return BorderStyle.Wave;

                    case 0x1b:
                        return BorderStyle.DoubleWave;

                    case 0x1c:
                        return BorderStyle.DashDotStroker;

                    case 0x1d:
                        return BorderStyle.Engrave3D;

                    case 30:
                        return BorderStyle.Emboss3D;

                    case 0x1f:
                        return BorderStyle.Outset;

                    case 0x20:
                        return BorderStyle.Inset;

                    case 0x21:
                        return BorderStyle.Cleared;

                    case 0x22:
                        return BorderStyle.None;
                }
            }
        }
        return none;
    }

    private int method_392(Border A_0)
    {
        FormatBase parentFormat = A_0.ParentFormat;
        if (!(parentFormat is CharacterFormat))
        {
            if (parentFormat is Borders)
            {
                parentFormat = parentFormat.ParentFormat;
            }
            if ((parentFormat != null) && !(parentFormat is ParagraphFormat))
            {
                return 8;
            }
        }
        return 20;
    }

    private void method_393(XmlReader A_0, CharacterFormat A_1)
    {
        int num = 14;
        string attribute = A_0.GetAttribute(BookmarkStart.b("刳張吷嘹", 14), this.dictionary_18[BookmarkStart.b("䌳", 14)]);
        string str2 = A_0.GetAttribute(BookmarkStart.b("䈳圵吷", 14), this.dictionary_18[BookmarkStart.b("䌳", 14)]);
        if (str2 != null)
        {
            A_1.TextureStyle = this.method_394(str2);
        }
        if (attribute != null)
        {
            if (attribute == BookmarkStart.b("唳䌵䰷唹", num))
            {
                A_1.TextBackgroundColor = Color.Empty;
            }
            else
            {
                A_1.TextBackgroundColor = this.method_474(attribute);
            }
        }
    }

    private TextureStyle method_394(string A_0)
    {
        int num = 8;
        string key = A_0;
        if (key != null)
        {
            int num2;
            if (Class1160.dictionary_94 == null)
            {
                Dictionary<string, int> dictionary1 = new Dictionary<string, int>(0x24);
                dictionary1.Add(BookmarkStart.b("席匯䘱ĳ", num), 0);
                dictionary1.Add(BookmarkStart.b("席匯䘱Գص", num), 1);
                dictionary1.Add(BookmarkStart.b("席匯䘱Գе", num), 2);
                dictionary1.Add(BookmarkStart.b("席匯䘱Գ̵", num), 3);
                dictionary1.Add(BookmarkStart.b("席匯䘱سص", num), 4);
                dictionary1.Add(BookmarkStart.b("席匯䘱س̵", num), 5);
                dictionary1.Add(BookmarkStart.b("席匯䘱ܳص", num), 6);
                dictionary1.Add(BookmarkStart.b("席匯䘱̵ܳ", num), 7);
                dictionary1.Add(BookmarkStart.b("席匯䘱ܳĵ", num), 8);
                dictionary1.Add(BookmarkStart.b("席匯䘱3ص", num), 9);
                dictionary1.Add(BookmarkStart.b("席匯䘱3̵", num), 10);
                dictionary1.Add(BookmarkStart.b("席匯䘱ĳص", num), 11);
                dictionary1.Add(BookmarkStart.b("席匯䘱ĳ̵", num), 12);
                dictionary1.Add(BookmarkStart.b("席匯䘱ȳص", num), 13);
                dictionary1.Add(BookmarkStart.b("席匯䘱ȳе", num), 14);
                dictionary1.Add(BookmarkStart.b("席匯䘱ȳ̵", num), 15);
                dictionary1.Add(BookmarkStart.b("席匯䘱̳ص", num), 0x10);
                dictionary1.Add(BookmarkStart.b("席匯䘱̵̳", num), 0x11);
                dictionary1.Add(BookmarkStart.b("席匯䘱ళص", num), 0x12);
                dictionary1.Add(BookmarkStart.b("席匯䘱ళ̵", num), 0x13);
                dictionary1.Add(BookmarkStart.b("席匯䘱ళĵ", num), 20);
                dictionary1.Add(BookmarkStart.b("席匯䘱ളص", num), 0x15);
                dictionary1.Add(BookmarkStart.b("席匯䘱ള̵", num), 0x16);
                dictionary1.Add(BookmarkStart.b("娭堯嬱娳縵圷䠹䘻紽㈿ⵁ㝃㕅", num), 0x17);
                dictionary1.Add(BookmarkStart.b("䘭弯䀱丳电䨷唹伻䴽", num), 0x18);
                dictionary1.Add(BookmarkStart.b("䨭夯匱匳电䨷唹伻䴽", num), 0x19);
                dictionary1.Add(BookmarkStart.b("尭唯䐱儳䐵䬷弹砻圽ℿ╁ᝃ㉅㩇⍉㱋⭍", num), 0x1a);
                dictionary1.Add(BookmarkStart.b("䨭夯匱匳攵䰷䠹唻丽┿", num), 0x1b);
                dictionary1.Add(BookmarkStart.b("䘭弯䀱丳攵䰷䠹唻丽┿", num), 0x1c);
                dictionary1.Add(BookmarkStart.b("堭唯䀱䀳攵䰷䠹唻丽┿", num), 0x1d);
                dictionary1.Add(BookmarkStart.b("娭堯嬱娳爵儷嬹嬻紽㈿ⵁ㝃㕅", num), 30);
                dictionary1.Add(BookmarkStart.b("娭堯嬱娳搵崷䰹夻䰽㌿❁C⽅⥇ⵉὋ㩍≏㭑⑓㍕", num), 0x1f);
                dictionary1.Add(BookmarkStart.b("娭堯嬱娳爵儷嬹嬻洽㐿ぁⵃ㙅ⵇ", num), 0x20);
                dictionary1.Add(BookmarkStart.b("娭堯嬱娳縵圷䠹䘻洽㐿ぁⵃ㙅ⵇ", num), 0x21);
                dictionary1.Add(BookmarkStart.b("崭弯帱崳刵", num), 0x22);
                dictionary1.Add(BookmarkStart.b("娭堯嬱娳怵崷䠹䠻洽㐿ぁⵃ㙅ⵇ", num), 0x23);
                Class1160.dictionary_94 = dictionary1;
            }
            if (Class1160.dictionary_94.TryGetValue(key, out num2))
            {
                switch (num2)
                {
                    case 0:
                        return TextureStyle.Texture5Percent;

                    case 1:
                        return TextureStyle.Texture10Percent;

                    case 2:
                        return TextureStyle.Texture12Pt5Percent;

                    case 3:
                        return TextureStyle.Texture15Percent;

                    case 4:
                        return TextureStyle.Texture20Percent;

                    case 5:
                        return TextureStyle.Texture25Percent;

                    case 6:
                        return TextureStyle.Texture30Percent;

                    case 7:
                        return TextureStyle.Texture35Percent;

                    case 8:
                        return TextureStyle.Texture37Pt5Percent;

                    case 9:
                        return TextureStyle.Texture40Percent;

                    case 10:
                        return TextureStyle.Texture45Percent;

                    case 11:
                        return TextureStyle.Texture50Percent;

                    case 12:
                        return TextureStyle.Texture55Percent;

                    case 13:
                        return TextureStyle.Texture60Percent;

                    case 14:
                        return TextureStyle.Texture62Pt5Percent;

                    case 15:
                        return TextureStyle.Texture65Percent;

                    case 0x10:
                        return TextureStyle.Texture70Percent;

                    case 0x11:
                        return TextureStyle.Texture75Percent;

                    case 0x12:
                        return TextureStyle.Texture80Percent;

                    case 0x13:
                        return TextureStyle.Texture85Percent;

                    case 20:
                        return TextureStyle.Texture87Pt5Percent;

                    case 0x15:
                        return TextureStyle.Texture90Percent;

                    case 0x16:
                        return TextureStyle.Texture95Percent;

                    case 0x17:
                        return TextureStyle.TextureCross;

                    case 0x18:
                        return TextureStyle.TextureDarkCross;

                    case 0x19:
                        return TextureStyle.TextureDarkDiagonalCross;

                    case 0x1a:
                        return TextureStyle.TextureDarkDiagonalDown;

                    case 0x1b:
                        return TextureStyle.TextureDarkDiagonalUp;

                    case 0x1c:
                        return TextureStyle.TextureDarkHorizontal;

                    case 0x1d:
                        return TextureStyle.TextureDarkVertical;

                    case 30:
                        return TextureStyle.TextureDiagonalCross;

                    case 0x1f:
                        return TextureStyle.TextureDiagonalDown;

                    case 0x20:
                        return TextureStyle.TextureDiagonalUp;

                    case 0x21:
                        return TextureStyle.TextureHorizontal;

                    case 0x22:
                        return TextureStyle.TextureSolid;

                    case 0x23:
                        return TextureStyle.TextureVertical;
                }
            }
        }
        return TextureStyle.TextureNone;
    }

    private void method_395(XmlReader A_0, CharacterFormat A_1)
    {
        int num = 14;
        string attribute = A_0.GetAttribute(BookmarkStart.b("䈳圵吷", 14), this.dictionary_18[BookmarkStart.b("䌳", 14)]);
        if (attribute != null)
        {
            if (attribute == BookmarkStart.b("䜳䌵娷䤹弻䰽⤿㉁ぃ", num))
            {
                A_1.SubSuperScript = SubSuperScript.SubScript;
            }
            else if (attribute == BookmarkStart.b("䜳䌵䠷弹主䴽⌿ぁⵃ㙅㱇", num))
            {
                A_1.SubSuperScript = SubSuperScript.SuperScript;
            }
            else if (attribute == BookmarkStart.b("嘳圵䬷弹倻圽⸿❁", num))
            {
                A_1.SubSuperScript = SubSuperScript.None;
            }
        }
    }

    private void method_396(XmlReader A_0, CharacterFormat A_1)
    {
        string str3;
        int num = 6;
        string attribute = A_0.GetAttribute(BookmarkStart.b("娫伭尯", 6), this.dictionary_18[BookmarkStart.b("嬫", 6)]);
        if (attribute == null)
        {
            return;
        }
        string key = attribute;
        if (key != null)
        {
            int num2;
            if (Class1160.dictionary_95 == null)
            {
                Dictionary<string, int> dictionary1 = new Dictionary<string, int>(0x11);
                dictionary1.Add(BookmarkStart.b("弫䜭帯唱堳匵", num), 0);
                dictionary1.Add(BookmarkStart.b("嬫䄭䈯嘱䜳", num), 1);
                dictionary1.Add(BookmarkStart.b("䠫䄭䔯倱堳匵", num), 2);
                dictionary1.Add(BookmarkStart.b("䠫䄭䐯䘱儳刵", num), 3);
                dictionary1.Add(BookmarkStart.b("堫䘭夯儱弳", num), 4);
                dictionary1.Add(BookmarkStart.b("䠫伭䌯娱", num), 5);
                dictionary1.Add(BookmarkStart.b("䠫䄭䐯瘱唳䔵倷", num), 6);
                dictionary1.Add(BookmarkStart.b("䠫䄭䐯瘱嬳䈵簷嬹伻嘽", num), 7);
                dictionary1.Add(BookmarkStart.b("嬫伭䘯圱", num), 8);
                dictionary1.Add(BookmarkStart.b("䠫伭䌯娱砳夵嘷崹", num), 9);
                dictionary1.Add(BookmarkStart.b("䠫䄭䐯䘱儳刵瀷弹崻䠽㤿", num), 10);
                dictionary1.Add(BookmarkStart.b("䠫伭䌯娱儳刵瀷弹崻䠽㤿", num), 11);
                dictionary1.Add(BookmarkStart.b("䠫伭䌯娱砳夵嘷崹琻嬽ℿ㑁㵃", num), 12);
                dictionary1.Add(BookmarkStart.b("䠫伭䌯娱瀳夵䰷爹夻弽㘿㭁", num), 13);
                dictionary1.Add(BookmarkStart.b("䠫伭䌯娱瀳夵䰷縹医䨽࠿❁╃ぅㅇ", num), 14);
                dictionary1.Add(BookmarkStart.b("嬫伭䘯䬱簳匵夷䰹䔻", num), 15);
                dictionary1.Add(BookmarkStart.b("嬫伭䘯䬱瀳夵䴷堹倻嬽", num), 0x10);
                Class1160.dictionary_95 = dictionary1;
            }
            if (Class1160.dictionary_95.TryGetValue(key, out num2))
            {
                switch (num2)
                {
                    case 0:
                        A_1.UnderlineStyle = UnderlineStyle.Single;
                        goto Label_02A8;

                    case 1:
                        A_1.UnderlineStyle = UnderlineStyle.Words;
                        goto Label_02A8;

                    case 2:
                        A_1.UnderlineStyle = UnderlineStyle.Double;
                        goto Label_02A8;

                    case 3:
                        A_1.UnderlineStyle = UnderlineStyle.Dotted;
                        goto Label_02A8;

                    case 4:
                        A_1.UnderlineStyle = UnderlineStyle.Thick;
                        goto Label_02A8;

                    case 5:
                        A_1.UnderlineStyle = UnderlineStyle.Dash;
                        goto Label_02A8;

                    case 6:
                        A_1.UnderlineStyle = UnderlineStyle.DotDash;
                        goto Label_02A8;

                    case 7:
                        A_1.UnderlineStyle = UnderlineStyle.DotDotDash;
                        goto Label_02A8;

                    case 8:
                        A_1.UnderlineStyle = UnderlineStyle.Wavy;
                        goto Label_02A8;

                    case 9:
                        A_1.UnderlineStyle = UnderlineStyle.DashLong;
                        goto Label_02A8;

                    case 10:
                        A_1.UnderlineStyle = UnderlineStyle.DottedHeavy;
                        goto Label_02A8;

                    case 11:
                        A_1.UnderlineStyle = UnderlineStyle.DashHeavy;
                        goto Label_02A8;

                    case 12:
                        A_1.UnderlineStyle = UnderlineStyle.DashLongHeavy;
                        goto Label_02A8;

                    case 13:
                        A_1.UnderlineStyle = UnderlineStyle.DotDashHeavy;
                        goto Label_02A8;

                    case 14:
                        A_1.UnderlineStyle = UnderlineStyle.DotDotDashHeavy;
                        goto Label_02A8;

                    case 15:
                        A_1.UnderlineStyle = UnderlineStyle.WavyHeavy;
                        goto Label_02A8;

                    case 0x10:
                        A_1.UnderlineStyle = UnderlineStyle.WavyDouble;
                        goto Label_02A8;
                }
            }
        }
        A_1.UnderlineStyle = UnderlineStyle.None;
    Label_02A8:
        str3 = A_0.GetAttribute(BookmarkStart.b("伫䄭尯崱䘳", num), this.dictionary_18[BookmarkStart.b("嬫", num)]);
        if (str3 != null)
        {
            A_1.UnderlineColor = this.method_474(str3);
        }
    }

    private void method_397(XmlReader A_0, CharacterFormat A_1)
    {
        int num = 15;
        int i = 0;
        int attributeCount = A_0.AttributeCount;
        while (i < attributeCount)
        {
            A_0.MoveToAttribute(i);
            string localName = A_0.LocalName;
            if (localName != null)
            {
                int num4;
                if (Class1160.dictionary_96 == null)
                {
                    Dictionary<string, int> dictionary1 = new Dictionary<string, int>(9);
                    dictionary1.Add(BookmarkStart.b("吴䐶娸刺吼", num), 0);
                    dictionary1.Add(BookmarkStart.b("崴瘶圸䠺吼", num), 1);
                    dictionary1.Add(BookmarkStart.b("倴嘶䨸伺簼䰾⡀≂", num), 2);
                    dictionary1.Add(BookmarkStart.b("嘴䐶", num), 3);
                    dictionary1.Add(BookmarkStart.b("吴䐶娸刺吼款⥀♂⡄≆", num), 4);
                    dictionary1.Add(BookmarkStart.b("倴嘶䨸伺簼䰾⡀≂ᅄ⽆ⱈ♊⡌", num), 5);
                    dictionary1.Add(BookmarkStart.b("崴瘶圸䠺吼款⥀♂⡄≆", num), 6);
                    dictionary1.Add(BookmarkStart.b("嘴䐶䴸区堼刾⑀", num), 7);
                    dictionary1.Add(BookmarkStart.b("崴帶圸伺", num), 8);
                    Class1160.dictionary_96 = dictionary1;
                }
                if (Class1160.dictionary_96.TryGetValue(localName, out num4))
                {
                    switch (num4)
                    {
                        case 0:
                        {
                            string attribute = A_0.GetAttribute(i);
                            A_1.FontNameAscii = attribute;
                            break;
                        }
                        case 1:
                            A_1.FontNameNonFarEast = A_0.GetAttribute(i);
                            break;

                        case 2:
                            A_1.FontNameFarEast = A_0.GetAttribute(i);
                            break;

                        case 3:
                            A_1.FontNameBidi = A_0.GetAttribute(i);
                            break;

                        case 4:
                        {
                            string str11 = A_0.GetAttribute(i);
                            A_1.AsciiTheme = str11;
                            if (this.document_0.Themes != null)
                            {
                                string str9 = this.document_0.Themes.method_10(str11, FontTypeHint.Default);
                                if (!string.IsNullOrEmpty(str9))
                                {
                                    A_1.FontNameAscii = str9;
                                }
                            }
                            break;
                        }
                        case 5:
                        {
                            string str7 = A_0.GetAttribute(i);
                            A_1.EastAsiaTheme = str7;
                            if (this.document_0.Themes != null)
                            {
                                string str8 = this.document_0.Themes.method_10(str7, FontTypeHint.EastAsia);
                                if (!string.IsNullOrEmpty(str8))
                                {
                                    A_1.FontNameFarEast = str8;
                                }
                            }
                            break;
                        }
                        case 6:
                        {
                            string str5 = A_0.GetAttribute(i);
                            A_1.HAnsiTheme = str5;
                            if (this.document_0.Themes != null)
                            {
                                string str = this.document_0.Themes.method_10(str5, FontTypeHint.Default);
                                if (!string.IsNullOrEmpty(str))
                                {
                                    A_1.FontNameNonFarEast = str;
                                }
                            }
                            break;
                        }
                        case 7:
                        {
                            string str10 = A_0.GetAttribute(i);
                            A_1.CsTheme = str10;
                            if (this.document_0.Themes != null)
                            {
                                string str4 = this.document_0.Themes.method_10(str10, FontTypeHint.ComplexScript);
                                if (!string.IsNullOrEmpty(str4))
                                {
                                    A_1.FontNameBidi = str4;
                                }
                            }
                            break;
                        }
                        case 8:
                        {
                            string str6 = A_0.GetAttribute(i);
                            if (str6 == null)
                            {
                                goto Label_02F0;
                            }
                            if (str6 == BookmarkStart.b("倴嘶䨸伺簼䰾⡀≂", num))
                            {
                                goto Label_02E7;
                            }
                            if (!(str6 == BookmarkStart.b("嘴䐶", num)))
                            {
                                goto Label_02F0;
                            }
                            A_1.FontTypeHint = FontTypeHint.ComplexScript;
                            break;
                        }
                    }
                }
            }
            goto Label_02F7;
        Label_02E7:
            A_1.FontTypeHint = FontTypeHint.EastAsia;
            goto Label_02F7;
        Label_02F0:
            A_1.FontTypeHint = FontTypeHint.Default;
        Label_02F7:
            i++;
        }
    }

    private bool method_398(string A_0)
    {
        if (string.IsNullOrEmpty(A_0))
        {
            return false;
        }
        string str = A_0.Replace('-', '_');
        return Enum.IsDefined(typeof(LocaleIDs), str);
    }

    private int method_399(string A_0)
    {
        if (string.IsNullOrEmpty(A_0))
        {
            return -1;
        }
        string str = A_0.Replace('-', '_');
        return (int) ((LocaleIDs) Enum.Parse(typeof(LocaleIDs), str));
    }

    internal Stack<Comment> method_4()
    {
        if (this.stack_2 == null)
        {
            this.stack_2 = new Stack<Comment>();
        }
        return this.stack_2;
    }

    private void method_40(XmlReader A_0, string A_1)
    {
        int num = 0x10;
        while (A_0.LocalName != A_1)
        {
            if (A_0.NodeType != XmlNodeType.Element)
            {
                goto Label_02E6;
            }
            string localName = A_0.LocalName;
            if (localName != null)
            {
                int num2;
                if (Class1160.dictionary_51 == null)
                {
                    Dictionary<string, int> dictionary1 = new Dictionary<string, int>(10);
                    dictionary1.Add(BookmarkStart.b("刵儷䰹伻", num), 0);
                    dictionary1.Add(BookmarkStart.b("刵儷䰹", num), 1);
                    dictionary1.Add(BookmarkStart.b("夵䠷丹唻匽⤿㡁⅃E❇㡉๋㱍㽏║❓㍕⩗", num), 2);
                    dictionary1.Add(BookmarkStart.b("圵吷嘹医䤽ဿు̓", num), 3);
                    dictionary1.Add(BookmarkStart.b("刵圷琹医䨽ሿ❁⡃㽅݇⑉ཋᵍ͏", num), 4);
                    dictionary1.Add(BookmarkStart.b("刵圷琹医䨽ጿ⍁㉃⍅े㥉Ὃ❍㹏㕑㡓㍕ṗ㍙せ㭝", num), 5);
                    dictionary1.Add(BookmarkStart.b("刵圷琹医䨽༿ぁ⍃❅♇⍉㙋⭍᥏㱑ቓ㥕㑗㹙㥛ⱝ", num), 6);
                    dictionary1.Add(BookmarkStart.b("刵圷琹医䨽ᔿㅁ⅃੅❇⑉⭋ࡍ㥏㹑ㅓᡕ㥗㝙㥛ⵝ", num), 7);
                    dictionary1.Add(BookmarkStart.b("䘵儷䈹夻刽㌿ቁ⅃㑅Ň⑉⽋♍", num), 8);
                    dictionary1.Add(BookmarkStart.b("䈵夷䠹嬻嬽㐿ᅁ❃㑅ⵇ⽉≋ᵍ⩏", num), 9);
                    Class1160.dictionary_51 = dictionary1;
                }
                if (Class1160.dictionary_51.TryGetValue(localName, out num2))
                {
                    switch (num2)
                    {
                        case 0:
                            this.method_247(A_0, BookmarkStart.b("刵儷䰹", num), BookmarkStart.b("䄵", num));
                            this.document_0.WebSettings.method_5().method_6(this.method_42(A_0, 0));
                            break;

                        case 1:
                            this.document_0.WebSettings.method_5().method_6(this.method_42(A_0, 0));
                            break;

                        case 2:
                            this.document_0.WebSettings.method_9(this.method_469(A_0));
                            goto Label_01E9;

                        case 3:
                            this.document_0.WebSettings.method_13(this.method_469(A_0));
                            break;

                        case 4:
                            this.document_0.WebSettings.method_15(this.method_469(A_0));
                            break;

                        case 5:
                            this.document_0.WebSettings.method_17(this.method_469(A_0));
                            break;

                        case 6:
                            this.document_0.WebSettings.method_19(this.method_469(A_0));
                            break;

                        case 7:
                            this.document_0.WebSettings.method_21(this.method_469(A_0));
                            break;

                        case 8:
                            this.document_0.WebSettings.method_23(this.method_470(A_0, 0));
                            break;

                        case 9:
                            this.document_0.WebSettings.method_25(this.document_0.WebSettings.method_27(A_0.GetAttribute(BookmarkStart.b("䀵夷嘹", num), this.dictionary_18[BookmarkStart.b("䄵", num)])));
                            break;
                    }
                }
            }
            goto Label_02DD;
        Label_01B5:
            if (A_0.LocalName == BookmarkStart.b("䈵夷䠹嬻嬽㐿", num))
            {
                this.document_0.WebSettings.method_11(this.method_41(A_0.Value));
            }
        Label_01E9:
            if (A_0.MoveToNextAttribute())
            {
                goto Label_01B5;
            }
        Label_02DD:
            A_0.Read();
            continue;
        Label_02E6:
            A_0.Read();
        }
    }

    private void method_400(XmlReader A_0, CharacterFormat A_1)
    {
        int num = 0;
        string attribute = A_0.GetAttribute(BookmarkStart.b("倥䤧䘩", 0), this.dictionary_18[BookmarkStart.b("儥", 0)]);
        if (!string.IsNullOrEmpty(attribute) && Enum.IsDefined(typeof(LocaleIDs), attribute.Replace('-', '_')))
        {
            A_1.LocaleIdASCII = (short) ((LocaleIDs) Enum.Parse(typeof(LocaleIDs), attribute.Replace('-', '_')));
        }
        attribute = A_0.GetAttribute(BookmarkStart.b("䌥䤧天堫漭䌯嬱唳", num), this.dictionary_18[BookmarkStart.b("儥", num)]);
        if (!string.IsNullOrEmpty(attribute) && Enum.IsDefined(typeof(LocaleIDs), attribute.Replace('-', '_')))
        {
            A_1.LocaleIdFarEast = (short) ((LocaleIDs) Enum.Parse(typeof(LocaleIDs), attribute.Replace('-', '_')));
        }
        string str2 = A_0.GetAttribute(BookmarkStart.b("䐥䄧丩䔫", num), this.dictionary_18[BookmarkStart.b("儥", num)]);
        if (!string.IsNullOrEmpty(str2) && Enum.IsDefined(typeof(LocaleIDs), str2.Replace('-', '_')))
        {
            A_1.LocaleIdBi = (short) ((LocaleIDs) Enum.Parse(typeof(LocaleIDs), str2.Replace('-', '_')));
        }
    }

    private void method_401(XmlReader A_0, Class514 A_1)
    {
        int num = 15;
        string attribute = A_0.GetAttribute(BookmarkStart.b("䌴嘶唸", 15), this.dictionary_18[BookmarkStart.b("䈴", 15)]);
        if (!string.IsNullOrEmpty(attribute) && Enum.IsDefined(typeof(LocaleIDs), attribute.Replace('-', '_')))
        {
            A_1.method_5((short) ((LocaleIDs) Enum.Parse(typeof(LocaleIDs), attribute.Replace('-', '_'))));
        }
        attribute = A_0.GetAttribute(BookmarkStart.b("倴嘶䨸伺簼䰾⡀≂", num), this.dictionary_18[BookmarkStart.b("䈴", num)]);
        if (!string.IsNullOrEmpty(attribute) && Enum.IsDefined(typeof(LocaleIDs), attribute.Replace('-', '_')))
        {
            A_1.method_3((short) ((LocaleIDs) Enum.Parse(typeof(LocaleIDs), attribute.Replace('-', '_'))));
        }
        string str2 = A_0.GetAttribute(BookmarkStart.b("圴帶崸刺", num), this.dictionary_18[BookmarkStart.b("䈴", num)]);
        if (!string.IsNullOrEmpty(str2) && Enum.IsDefined(typeof(LocaleIDs), str2.Replace('-', '_')))
        {
            A_1.method_1((short) ((LocaleIDs) Enum.Parse(typeof(LocaleIDs), str2.Replace('-', '_'))));
        }
    }

    private void method_402(XmlReader A_0, CharacterFormat A_1)
    {
        int num = 0;
        string attribute = A_0.GetAttribute(BookmarkStart.b("倥䤧䘩", 0), this.dictionary_18[BookmarkStart.b("儥", 0)]);
        if (attribute != null)
        {
            if (attribute.ToLower() == BookmarkStart.b("䈥䤧堩䜫圭唯帱堳夵伷", num))
            {
                A_1.HighlightColor = Color.Gold;
            }
            else
            {
                A_1.HighlightColor = this.method_474(attribute);
            }
        }
    }

    private void method_403(XmlReader A_0, ParagraphFormat A_1)
    {
        int num = 10;
        if ((A_0.LocalName != BookmarkStart.b("䀯戱䘳", 10)) && (A_0.LocalName != BookmarkStart.b("䀯戱䘳电倷嬹刻夽┿", num)))
        {
            throw new XmlException(BookmarkStart.b("怯匱䘳圵強䠹崻丽⠿扁㑃㑅❇㩉⥋㱍⑏㭑ㅓ╕", num));
        }
        if (A_1 == null)
        {
            throw new ArgumentException(BookmarkStart.b("怯匱䘳圵強䠹崻丽⠿扁≃⥅㩇❉ⵋ㩍灏⅑㱓㥕ⵗ㙙㡛繝๟ൡၣ䙥੧ཀྵ䱫mկṱᡳ", num));
        }
        if (!A_0.IsEmptyElement)
        {
            string localName = A_0.LocalName;
            bool flag = false;
            A_0.Read();
            this.method_485(A_0);
            if ((A_0.LocalName == BookmarkStart.b("䀯戱䘳", num)) && (A_0.NodeType == XmlNodeType.Element))
            {
                this.method_403(A_0, A_1);
                A_0.Read();
                this.method_485(A_0);
            }
            while (A_0.LocalName != localName)
            {
                IParagraphStyle style;
                if (A_0.EOF)
                {
                    break;
                }
                flag = false;
                if (A_0.NodeType != XmlNodeType.Element)
                {
                    goto Label_0895;
                }
                string key = A_0.LocalName;
                if (key != null)
                {
                    int num2;
                    if (Class1160.dictionary_97 == null)
                    {
                        Dictionary<string, int> dictionary1 = new Dictionary<string, int>(0x21);
                        dictionary1.Add(BookmarkStart.b("䌯圱圳䈵样䠹", num), 0);
                        dictionary1.Add(BookmarkStart.b("䀯愱䀳伵吷弹", num), 1);
                        dictionary1.Add(BookmarkStart.b("嘯䀱唳嬵崷樹主", num), 2);
                        dictionary1.Add(BookmarkStart.b("䈯戱䘳", num), 3);
                        dictionary1.Add(BookmarkStart.b("䐯匱嘳䔵", num), 4);
                        dictionary1.Add(BookmarkStart.b("䀯匱匳匵稷䠹夻弽⬿A⅃⁅❇㡉⥋", num), 5);
                        dictionary1.Add(BookmarkStart.b("嬯圱儳䘵琷匹刻嬽㌿", num), 6);
                        dictionary1.Add(BookmarkStart.b("弯䐱儳䐵帷嘹医䤽ဿ㝁⩃╅㱇", num), 7);
                        dictionary1.Add(BookmarkStart.b("弯䜱䀳娵儷吹夻爽㘿⹁", num), 8);
                        dictionary1.Add(BookmarkStart.b("嬯圱儳䘵瘷弹䐻䨽", num), 9);
                        dictionary1.Add(BookmarkStart.b("娯儱", num), 10);
                        dictionary1.Add(BookmarkStart.b("夯就倳", num), 11);
                        dictionary1.Add(BookmarkStart.b("启嬱䈳缵尷", num), 12);
                        dictionary1.Add(BookmarkStart.b("䌯䈱唳唵儷吹嬻", num), 13);
                        dictionary1.Add(BookmarkStart.b("䌯娱倳", num), 14);
                        dictionary1.Add(BookmarkStart.b("刯嬱倳張", num), 15);
                        dictionary1.Add(BookmarkStart.b("䜯嬱倳夵伷礹医倽㐿ぁ⭃⩅", num), 0x10);
                        dictionary1.Add(BookmarkStart.b("儯䜱䀳夵欷䨹崻崽┿فŃ", num), 0x11);
                        dictionary1.Add(BookmarkStart.b("儯䜱䀳夵欷䨹崻崽┿ف੃", num), 0x12);
                        dictionary1.Add(BookmarkStart.b("儯嘱帳䌵䬷丹渻圽✿⩁ぃཅ♇⹉", num), 0x13);
                        dictionary1.Add(BookmarkStart.b("䌯就唳䘵氷唹笻䰽⤿♁", num), 20);
                        dictionary1.Add(BookmarkStart.b("䐯圱䰳䈵礷嘹唻夽⸿⽁⅃⡅㱇", num), 0x15);
                        dictionary1.Add(BookmarkStart.b("䀯瀱倳䐵", num), 0x16);
                        dictionary1.Add(BookmarkStart.b("帯䜱夳昵䨷", num), 0x17);
                        dictionary1.Add(BookmarkStart.b("匯崱娳䈵崷䈹䠻䬽ℿ⹁ᝃ㙅⥇⥉╋⁍㝏", num), 0x18);
                        dictionary1.Add(BookmarkStart.b("䀯戱䘳电倷嬹刻夽┿", num), 0x19);
                        dictionary1.Add(BookmarkStart.b("匯就刳攵䰷䌹倻嬽", num), 0x1a);
                        dictionary1.Add(BookmarkStart.b("崯嬱䘳䐵圷䠹画倽␿❁⩃㉅㭇", num), 0x1b);
                        dictionary1.Add(BookmarkStart.b("䌯䜱䐳䘵䨷弹伻䴽Ŀ㝁ぃ⥅G㍉㱋♍㕏㱑❓", num), 0x1c);
                        dictionary1.Add(BookmarkStart.b("䜯崱䘳刵漷䠹崻丽", num), 0x1d);
                        dictionary1.Add(BookmarkStart.b("䐯崱䐳稵儷吹夻渽㔿ⱁ❃㉅", num), 30);
                        dictionary1.Add(BookmarkStart.b("䌯䜱䐳䘵䨷弹伻䴽ి⭁⩃⍅ه㽉⅋ⱍ㕏⁑❓", num), 0x1f);
                        dictionary1.Add(BookmarkStart.b("䌯䜱䐳䘵䨷弹伻䴽༿㑁⅃㑅⑇⭉㱋", num), 0x20);
                        Class1160.dictionary_97 = dictionary1;
                    }
                    if (Class1160.dictionary_97.TryGetValue(key, out num2))
                    {
                        switch (num2)
                        {
                            case 0:
                                this.method_423(A_0, this.document_0.LastSection);
                                this.document_0.AddSection();
                                goto Label_0889;

                            case 1:
                            {
                                string attribute = A_0.GetAttribute(BookmarkStart.b("䘯匱堳", num), this.dictionary_18[BookmarkStart.b("䜯", num)]);
                                if (string.IsNullOrEmpty(attribute))
                                {
                                    goto Label_0889;
                                }
                                attribute = attribute.Trim();
                                if (!this.method_22().ContainsKey(attribute))
                                {
                                    goto Label_0889;
                                }
                                style = this.document_0.Styles.method_11(this.method_22()[attribute], attribute, StyleType.ParagraphStyle) as IParagraphStyle;
                                if (style == null)
                                {
                                    goto Label_0889;
                                }
                                if (!(A_1.OwnerBase is Paragraph))
                                {
                                    goto Label_04CE;
                                }
                                (A_1.OwnerBase as Paragraph).method_65(style);
                                goto Label_04DB;
                            }
                            case 2:
                                this.method_404(A_0, A_1);
                                goto Label_0889;

                            case 3:
                                if (A_1.OwnerBase is Paragraph)
                                {
                                    CharacterFormat breakCharacterFormat = (A_1.OwnerBase as Paragraph).BreakCharacterFormat;
                                    this.method_378(A_0, breakCharacterFormat);
                                }
                                goto Label_0889;

                            case 4:
                                this.method_409(A_0, A_1);
                                goto Label_0889;

                            case 5:
                                A_1.PageBreakBefore = this.method_469(A_0);
                                goto Label_0889;

                            case 6:
                                A_1.KeepLines = this.method_469(A_0);
                                goto Label_0889;

                            case 7:
                                A_1.OverflowPunc = this.method_469(A_0);
                                goto Label_0889;

                            case 8:
                            {
                                string s = A_0.GetAttribute(BookmarkStart.b("䘯匱堳", num), this.dictionary_18[BookmarkStart.b("䜯", num)]);
                                if (s != null)
                                {
                                    int num3 = int.Parse(s, NumberStyles.Integer, CultureInfo.InvariantCulture);
                                    A_1.OutlineLevel = ((num3 < 0) || (num3 > 9)) ? OutlineLevel.Body : ((OutlineLevel) Enum.ToObject(typeof(OutlineLevel), num3));
                                }
                                goto Label_0889;
                            }
                            case 9:
                                A_1.KeepFollow = this.method_469(A_0);
                                goto Label_0889;

                            case 10:
                                this.method_421(A_0, A_1);
                                goto Label_0889;

                            case 11:
                                this.method_420(A_0, A_1);
                                goto Label_0889;

                            case 12:
                            {
                                string str5 = A_0.GetAttribute(BookmarkStart.b("䘯匱堳", num), this.dictionary_18[BookmarkStart.b("䜯", num)]);
                                if (!string.IsNullOrEmpty(str5))
                                {
                                    A_1.DivId = int.Parse(str5);
                                }
                                goto Label_0889;
                            }
                            case 13:
                                this.method_418(A_0, A_1);
                                goto Label_0889;

                            case 14:
                                this.method_422(A_0, A_1);
                                goto Label_0889;

                            case 15:
                                A_1.IsBidi = this.method_469(A_0);
                                goto Label_0889;

                            case 0x10:
                                A_1.IsWidowControl = this.method_469(A_0);
                                goto Label_0889;

                            case 0x11:
                                A_1.AutoSpaceDE = this.method_469(A_0);
                                goto Label_0889;

                            case 0x12:
                                A_1.AutoSpaceDN = this.method_469(A_0);
                                goto Label_0889;

                            case 0x13:
                                A_1.AdjustRightIndent = this.method_469(A_0);
                                goto Label_0889;

                            case 20:
                                A_1.SnapToGrid = this.method_469(A_0);
                                goto Label_0889;

                            case 0x15:
                            {
                                string str6 = A_0.GetAttribute(BookmarkStart.b("䘯匱堳", num), this.dictionary_18[BookmarkStart.b("䜯", num)]);
                                A_1.TextAlignment = this.method_44(str6);
                                goto Label_0889;
                            }
                            case 0x16:
                            {
                                if (!(A_1.OwnerBase is IStyle) || A_0.IsEmptyElement)
                                {
                                    goto Label_076C;
                                }
                                ParagraphStyle ownerBase = A_1.OwnerBase as ParagraphStyle;
                                if (ownerBase == null)
                                {
                                    return;
                                }
                                Borders borders = ownerBase.ParagraphFormat.Borders;
                                if (borders != null)
                                {
                                    this.method_416(A_0, borders);
                                }
                                goto Label_0889;
                            }
                            case 0x17:
                                this.method_331(A_0, A_1);
                                goto Label_0889;

                            case 0x18:
                            {
                                string str7 = A_0.GetAttribute(BookmarkStart.b("䘯匱堳", num), this.dictionary_18[BookmarkStart.b("䜯", num)]);
                                if (string.IsNullOrEmpty(str7))
                                {
                                    goto Label_07D5;
                                }
                                A_1.IsContextualSpacing = this.method_110(str7);
                                goto Label_0889;
                            }
                            case 0x19:
                                this.method_413(A_0, A_1);
                                goto Label_0889;

                            case 0x1a:
                                goto Label_0889;

                            case 0x1b:
                                A_1.MirrorIndents = this.method_469(A_0);
                                goto Label_0889;

                            case 0x1c:
                                A_1.SuppressAutoHyphens = this.method_469(A_0);
                                goto Label_0889;

                            case 0x1d:
                                A_1.WordWrap = this.method_469(A_0);
                                goto Label_0889;

                            case 30:
                                A_1.TopLinePunctuation = this.method_469(A_0);
                                goto Label_0889;

                            case 0x1f:
                                A_1.SuppressLineNumbers = this.method_469(A_0);
                                goto Label_0889;

                            case 0x20:
                                A_1.FrameSuppressOverlap = this.method_469(A_0);
                                goto Label_0889;
                        }
                    }
                }
                goto Label_084B;
            Label_04CE:
                A_1.ApplyBase(style.ParagraphFormat);
            Label_04DB:
                A_1.SetAttr(0x3e8, (style as Style).StyleDocId);
                goto Label_0889;
            Label_076C:
                this.method_415(A_0, A_1.OwnerBase as IDocumentObject);
                goto Label_0889;
            Label_07D5:
                A_1.IsContextualSpacing = true;
                goto Label_0889;
            Label_084B:
                if ((A_0.LocalName != string.Empty) && (A_0.LocalName != BookmarkStart.b("䀯戱䘳", num)))
                {
                    A_1.XmlProps2010.Add(this.method_484(A_0));
                    flag = true;
                }
            Label_0889:
                if (!flag)
                {
                    A_0.Read();
                }
                goto Label_089C;
            Label_0895:
                A_0.Read();
            Label_089C:
                this.method_485(A_0);
            }
        }
    }

    private void method_404(XmlReader A_0, ParagraphFormat A_1)
    {
        this.method_408(A_0, A_1);
        this.method_407(A_0, A_1);
        this.method_406(A_0, A_1);
        this.method_405(A_0, A_1);
    }

    private void method_405(XmlReader A_0, ParagraphFormat A_1)
    {
        string str3;
        int num = 13;
        string attribute = A_0.GetAttribute(BookmarkStart.b("圲䜴堶䤸砺尼伾", 13), this.dictionary_18[BookmarkStart.b("䐲", 13)]);
        if (string.IsNullOrEmpty(attribute))
        {
            goto Label_0091;
        }
        string str2 = attribute;
        if (str2 != null)
        {
            if (str2 != BookmarkStart.b("圲䜴堶䤸", num))
            {
                if (!(str2 == BookmarkStart.b("帲吴䔶常刺匼", num)))
                {
                    if (str2 == BookmarkStart.b("崲娴夶尸", num))
                    {
                    }
                    goto Label_008A;
                }
                A_1.DropCapPosition = DropCapPosition.Margin;
            }
            else
            {
                A_1.DropCapPosition = DropCapPosition.Normal;
            }
            goto Label_0091;
        }
    Label_008A:
        A_1.DropCapPosition = DropCapPosition.None;
    Label_0091:
        str3 = A_0.GetAttribute(BookmarkStart.b("弲尴夶尸䠺", num), this.dictionary_18[BookmarkStart.b("䐲", num)]);
        if (!string.IsNullOrEmpty(attribute))
        {
            A_1.DropCapLinesToDrop = int.Parse(str3, NumberStyles.Integer);
        }
    }

    private void method_406(XmlReader A_0, ParagraphFormat A_1)
    {
        int num = 14;
        string attribute = A_0.GetAttribute(BookmarkStart.b("䌳", 14), this.dictionary_18[BookmarkStart.b("䌳", 14)]);
        if ((attribute != null) && (attribute != string.Empty))
        {
            A_1.FrameWidth = (short) this.method_239(attribute);
        }
        string str4 = A_0.GetAttribute(BookmarkStart.b("尳", num), this.dictionary_18[BookmarkStart.b("䌳", num)]);
        short num2 = 0;
        if ((str4 != null) && (str4 != string.Empty))
        {
            num2 = (short) this.method_239(str4);
        }
        string str2 = A_0.GetAttribute(BookmarkStart.b("尳搵䴷嘹夻", num), this.dictionary_18[BookmarkStart.b("䌳", num)]);
        if (((str2 != null) && (str2 == BookmarkStart.b("儳丵夷夹䠻", num))) && !string.IsNullOrEmpty(str4))
        {
            A_1.FrameHeight = num2;
        }
        else if (num2 != 0)
        {
            A_1.FrameHeight = (short) (num2 | 0x8000);
        }
        FrameSizeRule auto = FrameSizeRule.Auto;
        string str3 = str2;
        if (str3 != null)
        {
            if (!(str3 == BookmarkStart.b("儳丵夷夹䠻", num)))
            {
                if (str3 == BookmarkStart.b("唳䈵琷弹崻䴽㐿", num))
                {
                    auto = FrameSizeRule.AtLeast;
                }
            }
            else
            {
                auto = FrameSizeRule.Exact;
            }
        }
        if (!string.IsNullOrEmpty(str2))
        {
            A_1.FrameHeightRule = auto;
        }
        string str5 = A_0.GetAttribute(BookmarkStart.b("唳堵嬷刹医䰽ిⵁ❃ⵅ", num), this.dictionary_18[BookmarkStart.b("䌳", num)]);
        if (!string.IsNullOrEmpty(str5))
        {
            A_1.FrameAnchorLock = this.method_110(str5);
        }
    }

    private void method_407(XmlReader A_0, ParagraphFormat A_1)
    {
        string str2;
        string str4;
        int num = 13;
        string attribute = A_0.GetAttribute(BookmarkStart.b("嬲琴夶娸区刼䴾", 13), this.dictionary_18[BookmarkStart.b("䐲", 13)]);
        if (((attribute != null) && (attribute != string.Empty)) && ((str4 = attribute) != null))
        {
            if (str4 != BookmarkStart.b("帲吴䔶常刺匼", num))
            {
                if (str4 != BookmarkStart.b("䌲吴倶尸", num))
                {
                    if ((str4 == BookmarkStart.b("䜲倴伶䴸", num)) || (str4 == BookmarkStart.b("倲娴嬶䰸嘺匼", num)))
                    {
                        A_1.FrameHorizontalPos = 0;
                    }
                }
                else
                {
                    A_1.FrameHorizontalPos = 2;
                }
            }
            else
            {
                A_1.FrameHorizontalPos = 1;
            }
        }
        string str3 = A_0.GetAttribute(BookmarkStart.b("䔲琴夶娸区刼䴾", num), this.dictionary_18[BookmarkStart.b("䐲", num)]);
        if (((str3 != null) && (str3 != string.Empty)) && ((str2 = str3) != null))
        {
            if (str2 == BookmarkStart.b("帲吴䔶常刺匼", num))
            {
                A_1.FrameVerticalPos = 0;
            }
            else if (str2 == BookmarkStart.b("䌲吴倶尸", num))
            {
                A_1.FrameVerticalPos = 1;
            }
            else if (str2 == BookmarkStart.b("䜲倴伶䴸", num))
            {
                A_1.FrameVerticalPos = 2;
            }
        }
    }

    private void method_408(XmlReader A_0, ParagraphFormat A_1)
    {
        string str2;
        string str5;
        int num = 13;
        string attribute = A_0.GetAttribute(BookmarkStart.b("䬲琴嬶倸尺匼", 13), this.dictionary_18[BookmarkStart.b("䐲", 13)]);
        if (!string.IsNullOrEmpty(attribute) && ((str2 = attribute) != null))
        {
            if (str2 != BookmarkStart.b("䄲尴倶儸伺", num))
            {
                if (str2 != BookmarkStart.b("倲倴夶䴸帺似", num))
                {
                    if (str2 != BookmarkStart.b("娲嬴䐶倸强堼", num))
                    {
                        if (str2 != BookmarkStart.b("尲䀴䌶䨸刺夼娾", num))
                        {
                            if (!(str2 == BookmarkStart.b("弲倴儶䴸", num)))
                            {
                                if (str2 == BookmarkStart.b("崲娴夶尸", num))
                                {
                                    A_1.FrameHorizontalPosition = HorizontalPosition.None;
                                }
                            }
                            else
                            {
                                A_1.FrameHorizontalPosition = HorizontalPosition.Left;
                            }
                        }
                        else
                        {
                            A_1.FrameHorizontalPosition = HorizontalPosition.Outside;
                        }
                    }
                    else
                    {
                        A_1.FrameHorizontalPosition = HorizontalPosition.Inside;
                    }
                }
                else
                {
                    A_1.FrameHorizontalPosition = HorizontalPosition.Center;
                }
            }
            else
            {
                A_1.FrameHorizontalPosition = HorizontalPosition.Right;
            }
        }
        string str7 = A_0.GetAttribute(BookmarkStart.b("䬲", num), this.dictionary_18[BookmarkStart.b("䐲", num)]);
        if (!string.IsNullOrEmpty(str7))
        {
            A_1.FrameX = (short) this.method_239(str7);
        }
        string str6 = A_0.GetAttribute(BookmarkStart.b("䨲琴嬶倸尺匼", num), this.dictionary_18[BookmarkStart.b("䐲", num)]);
        if (!string.IsNullOrEmpty(str6) && ((str5 = str6) != null))
        {
            int num2;
            if (Class1160.dictionary_98 == null)
            {
                Dictionary<string, int> dictionary1 = new Dictionary<string, int>(7);
                dictionary1.Add(BookmarkStart.b("䜲娴䜶", num), 0);
                dictionary1.Add(BookmarkStart.b("儲娴䌶䴸吺值", num), 1);
                dictionary1.Add(BookmarkStart.b("倲倴夶䴸帺似", num), 2);
                dictionary1.Add(BookmarkStart.b("娲嬴䐶倸强堼", num), 3);
                dictionary1.Add(BookmarkStart.b("尲䀴䌶䨸刺夼娾", num), 4);
                dictionary1.Add(BookmarkStart.b("娲嬴嬶倸唺堼", num), 5);
                dictionary1.Add(BookmarkStart.b("崲娴夶尸", num), 6);
                Class1160.dictionary_98 = dictionary1;
            }
            if (Class1160.dictionary_98.TryGetValue(str5, out num2))
            {
                switch (num2)
                {
                    case 0:
                        A_1.FrameVerticalPosition = VerticalPosition.Top;
                        break;

                    case 1:
                        A_1.FrameVerticalPosition = VerticalPosition.Bottom;
                        break;

                    case 2:
                        A_1.FrameVerticalPosition = VerticalPosition.Center;
                        break;

                    case 3:
                        A_1.FrameVerticalPosition = VerticalPosition.Inside;
                        break;

                    case 4:
                        A_1.FrameVerticalPosition = VerticalPosition.Outside;
                        break;

                    case 5:
                        A_1.FrameVerticalPosition = VerticalPosition.Inline;
                        break;

                    case 6:
                        A_1.FrameVerticalPosition = VerticalPosition.None;
                        break;
                }
            }
        }
        string str10 = A_0.GetAttribute(BookmarkStart.b("䨲", num), this.dictionary_18[BookmarkStart.b("䐲", num)]);
        if (!string.IsNullOrEmpty(str10))
        {
            A_1.FrameY = (short) this.method_239(str10);
        }
        string str3 = A_0.GetAttribute(BookmarkStart.b("䐲䜴嘶䤸", num), this.dictionary_18[BookmarkStart.b("䐲", num)]);
        if (str3 != null)
        {
            if (str3 != BookmarkStart.b("刲䜴堶䰸唺夼", num))
            {
                if (str3 != BookmarkStart.b("崲娴夶尸", num))
                {
                    if (str3 != BookmarkStart.b("崲娴䌶笸帺丼嘾╀♂", num))
                    {
                        if (str3 != BookmarkStart.b("䜲崴䔶嘸为娼圾", num))
                        {
                            if (!(str3 == BookmarkStart.b("䜲尴倶儸伺", num)))
                            {
                                if (str3 == BookmarkStart.b("刲䀴䌶嘸", num))
                                {
                                    A_1.FrameWrapType = FrameTextWrap.Auto;
                                }
                            }
                            else
                            {
                                A_1.FrameWrapType = FrameTextWrap.Tight;
                            }
                        }
                        else
                        {
                            A_1.FrameWrapType = FrameTextWrap.Through;
                        }
                    }
                    else
                    {
                        A_1.FrameWrapType = FrameTextWrap.NotBeside;
                    }
                }
                else
                {
                    A_1.FrameWrapType = FrameTextWrap.None;
                }
            }
            else
            {
                A_1.FrameWrapType = FrameTextWrap.Around;
            }
        }
        string str8 = A_0.GetAttribute(BookmarkStart.b("嬲昴䜶堸堺堼", num), this.dictionary_18[BookmarkStart.b("䐲", num)]);
        if (!string.IsNullOrEmpty(str8))
        {
            A_1.FrameHorizontalDistanceFromText = (short) this.method_239(str8);
        }
        string str4 = A_0.GetAttribute(BookmarkStart.b("䔲昴䜶堸堺堼", num), this.dictionary_18[BookmarkStart.b("䐲", num)]);
        if (!string.IsNullOrEmpty(str4))
        {
            A_1.FrameVerticalDistanceFromText = (short) this.method_239(str4);
        }
    }

    private void method_409(XmlReader A_0, ParagraphFormat A_1)
    {
        int num = 8;
        if (A_0.LocalName != BookmarkStart.b("娭儯倱䜳", 8))
        {
            throw new XmlException(BookmarkStart.b("稭儯倱ᐳ唵圷嘹倻嬽⌿㙁ⵃ⥅♇", num));
        }
        if (!A_0.IsEmptyElement)
        {
            string localName = A_0.LocalName;
            bool flag = false;
            A_0.Read();
            this.method_485(A_0);
            while (A_0.LocalName != localName)
            {
                string str;
                if (A_0.EOF)
                {
                    break;
                }
                flag = false;
                if (A_0.NodeType != XmlNodeType.Element)
                {
                    goto Label_0205;
                }
                if (((str = A_0.LocalName) == null) || !(str == BookmarkStart.b("娭儯倱", num)))
                {
                    goto Label_01F9;
                }
                Tab tab = null;
                float num2 = this.method_481(A_0, BookmarkStart.b("席弯䄱", num), this.dictionary_18[BookmarkStart.b("夭", num)]);
                string attribute = A_0.GetAttribute(BookmarkStart.b("堭儯帱", num), this.dictionary_18[BookmarkStart.b("夭", num)]);
                if (num2 == float.MaxValue)
                {
                    goto Label_0196;
                }
                using (IEnumerator enumerator = A_1.Tabs.GetEnumerator())
                {
                    Tab current;
                    while (enumerator.MoveNext())
                    {
                        current = (Tab) enumerator.Current;
                        if (current.Position == num2)
                        {
                            goto Label_0128;
                        }
                    }
                    goto Label_0143;
                Label_0128:
                    tab = current;
                }
            Label_0143:
                if (tab == null)
                {
                    tab = A_1.Tabs.AddTab();
                }
                if (attribute == BookmarkStart.b("䴭尯圱唳䐵", num))
                {
                    tab.Justification = TabJustification.Left;
                    tab.DeletePosition = num2 * 20f;
                    tab.Position = 0f;
                }
                else
                {
                    tab.Position = num2;
                }
            Label_0196:
                if ((attribute != null) && (attribute != BookmarkStart.b("䴭尯圱唳䐵", num)))
                {
                    tab.Justification = this.method_410(attribute);
                }
                string str3 = A_0.GetAttribute(BookmarkStart.b("䈭唯匱倳匵䨷", num), this.dictionary_18[BookmarkStart.b("夭", num)]);
                if (str3 != null)
                {
                    tab.TabLeader = this.method_412(str3);
                }
            Label_01F9:
                if (!flag)
                {
                    A_0.Read();
                }
                goto Label_020C;
            Label_0205:
                A_0.Read();
            Label_020C:
                this.method_485(A_0);
            }
        }
    }

    private WebTarget method_41(string A_0)
    {
        int num = 3;
        string str = A_0;
        if (str != null)
        {
            if (str == BookmarkStart.b("縨ᠪ測༮椰笲愴稶甸်縼氾ቀ牂", num))
            {
                return WebTarget.XhtmlPlusCss1;
            }
            if (str == BookmarkStart.b("縨ᠪ測༮礰朲破笶സ်縼氾ቀ牂", num))
            {
                return WebTarget.Html4PlusCss1;
            }
            if (str == BookmarkStart.b("縨ᠪ測༮椰笲愴稶甸်縼氾ቀ煂", num))
            {
                return WebTarget.XhtmlPlusCss2;
            }
            if (str == BookmarkStart.b("縨ᠪ測༮礰朲破笶സ်縼氾ቀ煂", num))
            {
                return WebTarget.Html4PlusCss2;
            }
        }
        return WebTarget.None;
    }

    private TabJustification method_410(string A_0)
    {
        int num = 7;
        string str = A_0;
        if (str != null)
        {
            if (str == BookmarkStart.b("丬䨮弰䜲倴䔶", num))
            {
                return TabJustification.Centered;
            }
            if (str == BookmarkStart.b("弬䘮嘰嬲䄴", num))
            {
                return TabJustification.Right;
            }
            if (str == BookmarkStart.b("䤬䨮到娲場嘶唸", num))
            {
                return TabJustification.Decimal;
            }
            if (str == BookmarkStart.b("伬丮䌰", num))
            {
                return TabJustification.Bar;
            }
            if (str == BookmarkStart.b("䌬娮尰", num))
            {
                return TabJustification.List;
            }
        }
        return TabJustification.Left;
    }

    private TabRelativeToPosition method_411(string A_0)
    {
        int num = 4;
        string str = A_0;
        if (str != null)
        {
            if (str == BookmarkStart.b("䌩䈫䨭唯就䀳", num))
            {
                return TabRelativeToPosition.Indent;
            }
            if (str == BookmarkStart.b("䜩䴫尭圯嬱娳", num))
            {
                return TabRelativeToPosition.Margin;
            }
        }
        return TabRelativeToPosition.Indent;
    }

    private TabLeader method_412(string A_0)
    {
        int num = 0x13;
        string str = A_0;
        if (str != null)
        {
            if (str == BookmarkStart.b("崸吺䤼", num))
            {
                return TabLeader.Dotted;
            }
            if (str == BookmarkStart.b("儸䈺䴼圾⑀ⵂ", num))
            {
                return TabLeader.Hyphenated;
            }
            if (str == BookmarkStart.b("䰸唺夼娾㍀あ♄⡆㭈⹊", num))
            {
                return TabLeader.Single;
            }
            if (str == BookmarkStart.b("儸帺尼䤾㡀", num))
            {
                return TabLeader.Heavy;
            }
            if (str == BookmarkStart.b("吸刺夼嬾ⵀ♂ń⡆㵈", num))
            {
                return TabLeader.MiddleDot;
            }
        }
        return TabLeader.NoLeader;
    }

    private void method_413(XmlReader A_0, ParagraphFormat A_1)
    {
        A_1.IsChangedFormat = true;
        ParagraphFormat format = new ParagraphFormat(this.document_0);
        string attribute = A_0.GetAttribute(BookmarkStart.b("匱䄳䈵倷唹主", 12), this.dictionary_18[BookmarkStart.b("䔱", 12)]);
        DateTime time = Class1041.smethod_3(A_0.GetAttribute(BookmarkStart.b("嘱唳䈵崷", 12), this.dictionary_18[BookmarkStart.b("䔱", 12)]));
        Class580 class2 = new Class580(format, attribute, time);
        A_1.FormatRevision = class2;
        if (!A_0.IsEmptyElement)
        {
            this.method_485(A_0);
            this.method_403(A_0, format);
        }
    }

    private void method_414(ParagraphBase A_0)
    {
        if ((this.stack_5 != null) && (this.stack_5.Count > 0))
        {
            if (this.stack_5.Peek().method_4() == EditRevisionType.Deletion)
            {
                A_0.method_22(true);
                A_0.CharacterFormat.DeleteRevision = this.stack_5.Peek();
            }
            else if (this.stack_5.Peek().method_4() == EditRevisionType.Insertion)
            {
                A_0.method_21(true);
                A_0.CharacterFormat.InsertRevision = this.stack_5.Peek();
            }
        }
    }

    private void method_415(XmlReader A_0, IDocumentObject A_1)
    {
        Borders borders = null;
        if (A_1 is Table)
        {
            if (this.bool_2)
            {
                borders = (A_1 as Table).TrackTblFormat.Format.Borders;
            }
            else
            {
                borders = (A_1 as Table).DocxTableFormat.Format.Borders;
            }
        }
        else if (A_1 is TableRow)
        {
            if (this.bool_0)
            {
                borders = (A_1 as TableRow).TrackRowFormat.Borders;
            }
            else
            {
                borders = (A_1 as TableRow).RowFormat.Borders;
            }
        }
        else if (A_1 is TableCell)
        {
            if (this.bool_1)
            {
                borders = (A_1 as TableCell).TrackCellFormat.Borders;
            }
            else
            {
                borders = (A_1 as TableCell).CellFormat.Borders;
            }
        }
        else if (A_1 is Section)
        {
            borders = (A_1 as Section).PageSetup.Borders;
        }
        else if (A_1 is Paragraph)
        {
            borders = (A_1 as Paragraph).Format.Borders;
        }
        if (borders != null)
        {
            this.method_417(A_0, borders, A_1);
        }
    }

    private void method_416(XmlReader A_0, Borders A_1)
    {
        int num = 3;
        if (A_1 == null)
        {
            throw new ArgumentException(BookmarkStart.b("欨䐪弬䬮吰䄲䘴᜶䨸区刼䨾ⵀ❂敄⥆♈㽊浌ⵎ㑐獒㭔≖㕘㝚", num));
        }
        if (!A_0.IsEmptyElement)
        {
            string localName = A_0.LocalName;
            A_0.Read();
            this.method_485(A_0);
            while (A_0.LocalName != localName)
            {
                if (A_0.EOF)
                {
                    break;
                }
                if (A_0.NodeType == XmlNodeType.Element)
                {
                    string key = A_0.LocalName;
                    if (key != null)
                    {
                        int num2;
                        if (Class1160.dictionary_99 == null)
                        {
                            Dictionary<string, int> dictionary1 = new Dictionary<string, int>(10);
                            dictionary1.Add(BookmarkStart.b("崨䐪崬", num), 0);
                            dictionary1.Add(BookmarkStart.b("䔨个䬬嬮", num), 1);
                            dictionary1.Add(BookmarkStart.b("䬨䐪夬嬮帰帲", num), 2);
                            dictionary1.Add(BookmarkStart.b("嬨䈪䨬䜮䔰", num), 3);
                            dictionary1.Add(BookmarkStart.b("䬨个夬堮吰嘲嬴", num), 4);
                            dictionary1.Add(BookmarkStart.b("䀨䔪帬䘮唰嘲紴", num), 5);
                            dictionary1.Add(BookmarkStart.b("䬨䨪弬", num), 6);
                            dictionary1.Add(BookmarkStart.b("䀨䔪帬䘮唰嘲挴", num), 7);
                            dictionary1.Add(BookmarkStart.b("崨䜪Ἤ䴮䌰", num), 8);
                            dictionary1.Add(BookmarkStart.b("崨太Ἤ䴮崰", num), 9);
                            Class1160.dictionary_99 = dictionary1;
                        }
                        if (Class1160.dictionary_99.TryGetValue(key, out num2))
                        {
                            switch (num2)
                            {
                                case 0:
                                    this.method_389(A_0, A_1.Top);
                                    break;

                                case 1:
                                    this.method_389(A_0, A_1.Left);
                                    break;

                                case 2:
                                    this.method_389(A_0, A_1.Bottom);
                                    break;

                                case 3:
                                    this.method_389(A_0, A_1.Right);
                                    break;

                                case 4:
                                case 5:
                                    this.method_389(A_0, A_1.Horizontal);
                                    break;

                                case 6:
                                case 7:
                                    this.method_389(A_0, A_1.Vertical);
                                    break;

                                case 8:
                                    this.method_389(A_0, A_1.DiagonalDown);
                                    break;

                                case 9:
                                    this.method_389(A_0, A_1.DiagonalUp);
                                    break;
                            }
                        }
                    }
                    A_0.Read();
                }
                else
                {
                    A_0.Read();
                }
                this.method_485(A_0);
            }
        }
    }

    private void method_417(XmlReader A_0, Borders A_1, IDocumentObject A_2)
    {
        int num = 6;
        if (A_1 == null)
        {
            throw new ArgumentException(BookmarkStart.b("渫䄭䈯嘱儳䐵䬷ᨹ伻嘽⼿㝁⡃≅桇⑉⍋㩍灏けㅓ癕㙗⽙せ㉝", num));
        }
        if (!A_0.IsEmptyElement)
        {
            string localName = A_0.LocalName;
            A_0.Read();
            this.method_485(A_0);
            while (A_0.LocalName != localName)
            {
                if (A_0.EOF)
                {
                    break;
                }
                if (A_0.NodeType == XmlNodeType.Element)
                {
                    string key = A_0.LocalName;
                    if (key != null)
                    {
                        int num2;
                        if (Class1160.dictionary_100 == null)
                        {
                            Dictionary<string, int> dictionary1 = new Dictionary<string, int>(10);
                            dictionary1.Add(BookmarkStart.b("堫䄭䀯", num), 0);
                            dictionary1.Add(BookmarkStart.b("䀫䬭嘯䘱", num), 1);
                            dictionary1.Add(BookmarkStart.b("丫䄭䐯䘱嬳嬵", num), 2);
                            dictionary1.Add(BookmarkStart.b("師䜭圯娱䀳", num), 3);
                            dictionary1.Add(BookmarkStart.b("丫䬭䐯䔱儳匵嘷", num), 4);
                            dictionary1.Add(BookmarkStart.b("䔫䀭䌯嬱倳匵瀷", num), 5);
                            dictionary1.Add(BookmarkStart.b("丫伭䈯", num), 6);
                            dictionary1.Add(BookmarkStart.b("䔫䀭䌯嬱倳匵渷", num), 7);
                            dictionary1.Add(BookmarkStart.b("堫䈭ȯ倱䘳", num), 8);
                            dictionary1.Add(BookmarkStart.b("堫尭ȯ倱堳", num), 9);
                            Class1160.dictionary_100 = dictionary1;
                        }
                        if (Class1160.dictionary_100.TryGetValue(key, out num2))
                        {
                            switch (num2)
                            {
                                case 0:
                                    this.method_389(A_0, A_1.Top);
                                    break;

                                case 1:
                                    this.method_389(A_0, A_1.Left);
                                    break;

                                case 2:
                                    this.method_389(A_0, A_1.Bottom);
                                    break;

                                case 3:
                                    this.method_389(A_0, A_1.Right);
                                    break;

                                case 4:
                                case 5:
                                    this.method_389(A_0, A_1.Horizontal);
                                    break;

                                case 6:
                                case 7:
                                    this.method_389(A_0, A_1.Vertical);
                                    break;

                                case 8:
                                    this.method_389(A_0, A_1.DiagonalDown);
                                    break;

                                case 9:
                                    this.method_389(A_0, A_1.DiagonalUp);
                                    break;
                            }
                        }
                    }
                    A_0.Read();
                }
                else
                {
                    A_0.Read();
                }
                this.method_485(A_0);
            }
        }
    }

    private void method_418(XmlReader A_0, ParagraphFormat A_1)
    {
        int num = 3;
        if (A_0.AttributeCount != 0)
        {
            float num2 = this.method_481(A_0, BookmarkStart.b("䬨个䬬䀮䌰嘲", num), this.dictionary_18[BookmarkStart.b("帨", num)]);
            if (num2 != float.MaxValue)
            {
                A_1.BeforeSpacing = num2;
            }
            num2 = this.method_481(A_0, BookmarkStart.b("䠨䴪夬䨮䌰", num), this.dictionary_18[BookmarkStart.b("帨", num)]);
            if (num2 != float.MaxValue)
            {
                A_1.AfterSpacing = num2;
            }
            string attribute = A_0.GetAttribute(BookmarkStart.b("䬨个䬬䀮䌰嘲琴䈶䴸吺丼伾⁀⁂ⱄ⥆⹈", num), this.dictionary_18[BookmarkStart.b("帨", num)]);
            if (attribute != null)
            {
                A_1.BeforeAutoSpacing = attribute == BookmarkStart.b("ᠨ", num);
            }
            attribute = A_0.GetAttribute(BookmarkStart.b("䠨䴪夬䨮䌰爲䀴䌶嘸䠺䴼帾≀⩂⭄⁆", num), this.dictionary_18[BookmarkStart.b("帨", num)]);
            if (attribute != null)
            {
                A_1.AfterAutoSpacing = attribute == BookmarkStart.b("ᠨ", num);
            }
            num2 = this.method_482(A_0, BookmarkStart.b("䬨个䬬䀮䌰嘲礴帶圸帺丼", num), this.dictionary_18[BookmarkStart.b("帨", num)]);
            if (num2 != float.MaxValue)
            {
                A_1.SpacingBeforeChar = num2;
            }
            num2 = this.method_482(A_0, BookmarkStart.b("䠨䴪夬䨮䌰缲尴夶尸䠺", num), this.dictionary_18[BookmarkStart.b("帨", num)]);
            if (num2 != float.MaxValue)
            {
                A_1.SpacingAfterChar = num2;
            }
            this.method_419(A_0, A_1);
        }
    }

    private void method_419(XmlReader A_0, ParagraphFormat A_1)
    {
        int num = 13;
        float num2 = this.method_481(A_0, BookmarkStart.b("弲尴夶尸", 13), this.dictionary_18[BookmarkStart.b("䐲", 13)]);
        if (num2 != float.MaxValue)
        {
            A_1.LineSpacing = 0f;
            A_1.LineSpacing = num2;
            string attribute = A_0.GetAttribute(BookmarkStart.b("弲尴夶尸椺䠼匾⑀", num), this.dictionary_18[BookmarkStart.b("䐲", num)]);
            if (attribute != null)
            {
                string str2 = attribute;
                if (str2 != null)
                {
                    if (str2 == BookmarkStart.b("刲䄴笶尸娺丼䬾", num))
                    {
                        A_1.LineSpacingRule = LineSpacingRule.AtLeast;
                        return;
                    }
                    if (str2 == BookmarkStart.b("嘲䴴嘶娸伺", num))
                    {
                        A_1.LineSpacingRule = LineSpacingRule.Exactly;
                        return;
                    }
                }
                A_1.LineSpacingRule = LineSpacingRule.Multiple;
            }
        }
    }

    private Class51 method_42(XmlReader A_0, int A_1)
    {
        int num = 15;
        float maxValue = float.MaxValue;
        string localName = A_0.LocalName;
        Class51 class2 = new Class51(this.document_0);
        class2.method_8(int.Parse(A_0.GetAttribute(BookmarkStart.b("尴匶", 15), this.dictionary_18[BookmarkStart.b("䈴", 15)])));
        class2.method_10(A_1);
        A_0.Read();
        while (A_0.NodeType == XmlNodeType.Element)
        {
            if (!(A_0.LocalName != localName))
            {
                return class2;
            }
            string str2 = A_0.LocalName;
            if (str2 == null)
            {
                goto Label_0282;
            }
            if (str2 == BookmarkStart.b("場嘶䬸眺堼夾㕀", num))
            {
                goto Label_0245;
            }
            if (str2 == BookmarkStart.b("場嘶䬸椺吼堾⥀㝂", num))
            {
                goto Label_0206;
            }
            if (str2 == BookmarkStart.b("場嘶䬸漺刼伾", num))
            {
                goto Label_01C4;
            }
            if (str2 == BookmarkStart.b("場嘶䬸示刼䬾㕀ⱂ⡄", num))
            {
                goto Label_017F;
            }
            if (str2 == BookmarkStart.b("儴帶伸示夼䴾", num))
            {
                goto Label_016D;
            }
            if (!(str2 == BookmarkStart.b("儴帶伸䠺縼圾⡀⽂⅄", num)))
            {
                goto Label_0282;
            }
            string str3 = A_0.LocalName;
            A_0.Read();
            goto Label_015F;
        Label_011D:
            if (!(A_0.LocalName != str3))
            {
                goto Label_0282;
            }
            this.document_0.WebSettings.method_5().method_6(this.method_42(A_0, class2.method_7()));
            A_0.Read();
            this.method_485(A_0);
        Label_015F:
            if (A_0.NodeType != XmlNodeType.Element)
            {
                goto Label_0282;
            }
            goto Label_011D;
        Label_016D:
            this.method_416(A_0, class2.method_6());
            goto Label_0282;
        Label_017F:
            maxValue = this.method_481(A_0, BookmarkStart.b("䌴嘶唸", num), this.dictionary_18[BookmarkStart.b("䈴", num)]);
            if (maxValue != float.MaxValue)
            {
                class2.method_5().Bottom = maxValue;
            }
            goto Label_0282;
        Label_01C4:
            maxValue = this.method_481(A_0, BookmarkStart.b("䌴嘶唸", num), this.dictionary_18[BookmarkStart.b("䈴", num)]);
            if (maxValue != float.MaxValue)
            {
                class2.method_5().Top = maxValue;
            }
            goto Label_0282;
        Label_0206:
            maxValue = this.method_481(A_0, BookmarkStart.b("䌴嘶唸", num), this.dictionary_18[BookmarkStart.b("䈴", num)]);
            if (maxValue != float.MaxValue)
            {
                class2.method_5().Right = maxValue;
            }
            goto Label_0282;
        Label_0245:
            maxValue = this.method_481(A_0, BookmarkStart.b("䌴嘶唸", num), this.dictionary_18[BookmarkStart.b("䈴", num)]);
            if (maxValue != float.MaxValue)
            {
                class2.method_5().Left = maxValue;
            }
        Label_0282:
            A_0.Read();
            this.method_485(A_0);
        }
        return class2;
    }

    private void method_420(XmlReader A_0, ParagraphFormat A_1)
    {
        int num = 15;
        if (A_0.AttributeCount != 0)
        {
            float num2 = this.method_481(A_0, BookmarkStart.b("头制弸伺", num), this.dictionary_18[BookmarkStart.b("䈴", num)]);
            if (num2 != float.MaxValue)
            {
                A_1.LeftIndent = num2;
            }
            num2 = this.method_481(A_0, BookmarkStart.b("䜴帶常区䤼", num), this.dictionary_18[BookmarkStart.b("䈴", num)]);
            if (num2 != float.MaxValue)
            {
                A_1.RightIndent = num2;
            }
            num2 = this.method_481(A_0, BookmarkStart.b("匴帶䬸䠺䤼猾⡀ⵂ⁄", num), this.dictionary_18[BookmarkStart.b("䈴", num)]);
            if (num2 != float.MaxValue)
            {
                A_1.FirstLineIndent = num2;
            }
            num2 = this.method_481(A_0, BookmarkStart.b("崴嘶圸尺吼儾♀", num), this.dictionary_18[BookmarkStart.b("䈴", num)]);
            if (num2 != float.MaxValue)
            {
                A_1.FirstLineIndent = -num2;
            }
            num2 = this.method_481(A_0, BookmarkStart.b("头制弸伺縼圾⁀ㅂ㙄", num), this.dictionary_18[BookmarkStart.b("䈴", num)]);
            if (num2 != float.MaxValue)
            {
                A_1.LeftIndentChars = (num2 * 20f) / 100f;
            }
            num2 = this.method_481(A_0, BookmarkStart.b("䜴帶常区䤼簾⥀≂㝄㑆", num), this.dictionary_18[BookmarkStart.b("䈴", num)]);
            if (num2 != float.MaxValue)
            {
                A_1.RightIndentChars = (num2 * 20f) / 100f;
            }
            num2 = this.method_481(A_0, BookmarkStart.b("匴帶䬸䠺䤼猾⡀ⵂ⁄цⅈ⩊㽌㱎", num), this.dictionary_18[BookmarkStart.b("䈴", num)]);
            if (num2 != float.MaxValue)
            {
                A_1.FirstLineIndentChars = (num2 * 20f) / 100f;
            }
            num2 = this.method_481(A_0, BookmarkStart.b("崴嘶圸尺吼儾♀Bⵄ♆㭈㡊", num), this.dictionary_18[BookmarkStart.b("䈴", num)]);
            if (num2 != float.MaxValue)
            {
                A_1.FirstLineIndentChars = -((num2 * 20f) / 100f);
            }
        }
    }

    private void method_421(XmlReader A_0, ParagraphFormat A_1)
    {
        int num = 10;
        string attribute = A_0.GetAttribute(BookmarkStart.b("䘯匱堳", 10), this.dictionary_18[BookmarkStart.b("䜯", 10)]);
        if (attribute != null)
        {
            string key = attribute;
            if (key != null)
            {
                int num2;
                if (Class1160.dictionary_101 == null)
                {
                    Dictionary<string, int> dictionary1 = new Dictionary<string, int>(7);
                    dictionary1.Add(BookmarkStart.b("匯圱娳䈵崷䠹", num), 0);
                    dictionary1.Add(BookmarkStart.b("䈯嬱匳帵䰷", num), 1);
                    dictionary1.Add(BookmarkStart.b("刯崱䀳帵", num), 2);
                    dictionary1.Add(BookmarkStart.b("启嬱䜳䈵䨷匹帻䬽㐿❁", num), 3);
                    dictionary1.Add(BookmarkStart.b("尯崱䌳紵夷䤹吻圽␿⍁", num), 4);
                    dictionary1.Add(BookmarkStart.b("堯嬱匳帵䰷焹崻䴽⠿⭁⁃❅", num), 5);
                    dictionary1.Add(BookmarkStart.b("崯圱倳張䴷圹眻弽㌿⩁ⵃ≅⥇", num), 6);
                    Class1160.dictionary_101 = dictionary1;
                }
                if (Class1160.dictionary_101.TryGetValue(key, out num2))
                {
                    switch (num2)
                    {
                        case 0:
                            A_1.HorizontalAlignment = HorizontalAlignment.Center;
                            return;

                        case 1:
                            A_1.HorizontalAlignment = HorizontalAlignment.Right;
                            return;

                        case 2:
                            A_1.HorizontalAlignment = HorizontalAlignment.Justify;
                            return;

                        case 3:
                            A_1.HorizontalAlignment = HorizontalAlignment.Distribute;
                            return;

                        case 4:
                            A_1.HorizontalAlignment = HorizontalAlignment.LowKashida;
                            return;

                        case 5:
                            A_1.HorizontalAlignment = HorizontalAlignment.HightKashida;
                            return;

                        case 6:
                            A_1.HorizontalAlignment = HorizontalAlignment.MediumKashida;
                            return;
                    }
                }
            }
            A_1.HorizontalAlignment = HorizontalAlignment.Left;
        }
    }

    private void method_422(XmlReader A_0, ParagraphFormat A_1)
    {
        int num = 5;
        string attribute = A_0.GetAttribute(BookmarkStart.b("䠪䈬䌮帰䄲", 5), this.dictionary_18[BookmarkStart.b("尪", 5)]);
        if (attribute != null)
        {
            if (attribute == BookmarkStart.b("䨪堬嬮帰", num))
            {
                A_1.BackColor = Color.Empty;
            }
            else
            {
                A_1.ForeColor = this.method_474(attribute);
            }
        }
        attribute = A_0.GetAttribute(BookmarkStart.b("䴪䐬䌮崰", num), this.dictionary_18[BookmarkStart.b("尪", num)]);
        if (attribute != null)
        {
            if (attribute == BookmarkStart.b("䨪堬嬮帰", num))
            {
                A_1.ForeColor = Color.Empty;
            }
            else
            {
                A_1.BackColor = this.method_474(attribute);
            }
        }
        attribute = A_0.GetAttribute(BookmarkStart.b("崪䰬䌮", num), this.dictionary_18[BookmarkStart.b("尪", num)]);
        if (attribute != null)
        {
            A_1.TextureStyle = this.method_394(attribute);
        }
    }

    private void method_423(XmlReader A_0, IDocumentObject A_1)
    {
        int num = 13;
        if (A_0.LocalName != BookmarkStart.b("䀲倴吶䴸欺似", 13))
        {
            throw new XmlException(BookmarkStart.b("怲倴吶䴸刺刼儾慀㍂㝄⡆㥈⹊㽌㭎㡐㙒♔", num));
        }
        if (A_1 == null)
        {
            throw new ArgumentException(BookmarkStart.b("怲倴吶䴸刺刼儾慀あⵄ⡆㱈❊⥌潎㽐㱒⅔睖㭘㹚絜ㅞᑠར।", num));
        }
        if (!A_0.IsEmptyElement)
        {
            bool flag = false;
            A_0.Read();
            this.method_485(A_0);
            while (A_0.LocalName != BookmarkStart.b("䀲倴吶䴸欺似", num))
            {
                if (A_0.EOF)
                {
                    break;
                }
                flag = false;
                if (A_0.NodeType == XmlNodeType.Element)
                {
                    string localName = A_0.LocalName;
                    if (localName != null)
                    {
                        int num2;
                        if (Class1160.dictionary_102 == null)
                        {
                            Dictionary<string, int> dictionary1 = new Dictionary<string, int>(0x12);
                            dictionary1.Add(BookmarkStart.b("唲娴堶䴸帺似派⑀╂⁄㕆ⱈ╊⹌⩎", num), 0);
                            dictionary1.Add(BookmarkStart.b("嬲倴嘶崸帺似派⑀╂⁄㕆ⱈ╊⹌⩎", num), 1);
                            dictionary1.Add(BookmarkStart.b("䜲䰴䜶尸", num), 2);
                            dictionary1.Add(BookmarkStart.b("䌲刴搶䌸", num), 3);
                            dictionary1.Add(BookmarkStart.b("䌲刴稶堸䤺", num), 4);
                            dictionary1.Add(BookmarkStart.b("倲娴嬶䨸", num), 5);
                            dictionary1.Add(BookmarkStart.b("䜲尴䌶唸帺洼堾", num), 6);
                            dictionary1.Add(BookmarkStart.b("䌲刴甶嘸䤺夼娾㍀あ", num), 7);
                            dictionary1.Add(BookmarkStart.b("圲娴吶縸䤺吼嬾", num), 8);
                            dictionary1.Add(BookmarkStart.b("䔲琴嬶倸尺匼", num), 9);
                            dictionary1.Add(BookmarkStart.b("弲嬴礶䰸嘺椼䘾ㅀ♂", num), 10);
                            dictionary1.Add(BookmarkStart.b("唲娴堶䴸唺刼䬾⑀ፂ㝄", num), 11);
                            dictionary1.Add(BookmarkStart.b("嘲嬴匶圸吺䤼娾ᅀㅂ", num), 12);
                            dictionary1.Add(BookmarkStart.b("䜲倴伶䴸缺吼䴾⑀⁂ㅄ⹆♈╊", num), 13);
                            dictionary1.Add(BookmarkStart.b("䄲䄴嬶縸为䤼䬾⑀ㅂ", num), 14);
                            dictionary1.Add(BookmarkStart.b("䌲刴礶䰸嘺椼䘾ㅀ♂", num), 15);
                            dictionary1.Add(BookmarkStart.b("儲尴匶倸", num), 0x10);
                            dictionary1.Add(BookmarkStart.b("唲娴䔶吸欺似倾㕀", num), 0x11);
                            Class1160.dictionary_102 = dictionary1;
                        }
                        if (Class1160.dictionary_102.TryGetValue(localName, out num2))
                        {
                            switch (num2)
                            {
                                case 0:
                                case 1:
                                {
                                    DictionaryEntry entry = this.dictionary_2[A_0.GetAttribute(BookmarkStart.b("䄲༴帶崸", num))];
                                    string attribute = A_0.GetAttribute(BookmarkStart.b("䜲䰴䜶尸", num), this.dictionary_18[BookmarkStart.b("䐲", num)]);
                                    bool flag2 = ((string) entry.Key) == BookmarkStart.b("嬲䄴䌶䤸ĺሼှ㉀⁂ⵄ≆⑈⩊㹌慎㹐⍒ご㥖⅘㙚ㅜ㥞๠ᅢࡤ٦ᵨᡪ䍬nͰᑲ婴ᡶὸᵺᑼ᱾잂ﲈ벒ꞔꞖꦘ궚늜쒠쾢쒤펦삨쒪쎬\udcae\ud9b0\udab2\uc5b4쒶隸펺\ud8bc\udebeꗀꛂ럄", num);
                                    Class229 class2 = this.method_465(BookmarkStart.b("䐲娴䔶崸ᐺ", num), entry.Value.ToString());
                                    this.string_3 = (entry.Value.ToString() + BookmarkStart.b("ᴲ䜴制唸䠺", num)).Replace(BookmarkStart.b("䐲娴䔶崸ᐺ", num), string.Empty);
                                    this.method_424(this.document_0.LastSection.HeadersFooters, class2, attribute, flag2);
                                    this.string_3 = string.Empty;
                                    break;
                                }
                                case 2:
                                {
                                    string str3 = A_0.GetAttribute(BookmarkStart.b("䔲吴嬶", num), this.dictionary_18[BookmarkStart.b("䐲", num)]);
                                    this.method_442(A_1 as Section, str3);
                                    break;
                                }
                                case 3:
                                    this.method_441(A_0, A_1 as Section);
                                    break;

                                case 4:
                                    this.method_439(A_0, A_1 as Section);
                                    break;

                                case 5:
                                    this.method_435(A_0, A_1 as Section);
                                    break;

                                case 6:
                                    (A_1 as Section).PageSetup.DifferentFirstPageHeaderFooter = true;
                                    break;

                                case 7:
                                    this.method_434(A_0, A_1 as Section);
                                    break;

                                case 8:
                                    this.method_433(A_0, A_1 as Section);
                                    break;

                                case 9:
                                    this.method_432(A_0, A_1 as Section);
                                    break;

                                case 10:
                                    this.method_431(A_0, A_1 as Section);
                                    break;

                                case 11:
                                    this.method_425(A_0, true, true);
                                    break;

                                case 12:
                                    this.method_425(A_0, false, true);
                                    break;

                                case 13:
                                    this.method_430(A_0, A_1 as Section);
                                    break;

                                case 14:
                                    if (this.method_469(A_0))
                                    {
                                        MarginsF margins = (A_1 as Section).PageSetup.Margins;
                                        margins.Right += this.float_0;
                                    }
                                    break;

                                case 15:
                                    this.method_429(A_0, A_1 as Section);
                                    break;

                                case 0x10:
                                    (A_1 as Section).PageSetup.Bidi = this.method_469(A_0);
                                    break;

                                case 0x11:
                                    (A_1 as Section).ProtectForm = this.method_469(A_0);
                                    break;
                            }
                        }
                    }
                    if (!flag)
                    {
                        A_0.Read();
                    }
                }
                else
                {
                    A_0.Read();
                }
                this.method_485(A_0);
            }
        }
    }

    private void method_424(HeadersFooters A_0, Class229 A_1, string A_2, bool A_3)
    {
        int num = 4;
        IDocumentObject evenHeader = null;
        XmlReader reader = Class57.smethod_18(A_1.method_4());
        this.method_316(reader, BookmarkStart.b("䈩䤫伭启圱䘳倵圷唹䠻嬽㈿", 4));
        string str = A_2;
        if (str != null)
        {
            if (str != BookmarkStart.b("䰩䔫尭䌯䘱", num))
            {
                if (!(str == BookmarkStart.b("伩娫䬭帯", num)))
                {
                    if (str == BookmarkStart.b("丩䤫䠭儯䜱堳䈵", num))
                    {
                    }
                    goto Label_0092;
                }
                if (A_3)
                {
                    evenHeader = A_0.EvenHeader;
                }
                else
                {
                    evenHeader = A_0.EvenFooter;
                }
            }
            else if (A_3)
            {
                evenHeader = A_0.FirstPageHeader;
            }
            else
            {
                evenHeader = A_0.FirstPageFooter;
            }
            goto Label_00A6;
        }
    Label_0092:
        if (A_3)
        {
            evenHeader = A_0.OddHeader;
        }
        else
        {
            evenHeader = A_0.OddFooter;
        }
    Label_00A6:
        if (evenHeader != null)
        {
            reader.MoveToContent();
            this.method_68(reader, evenHeader);
        }
        this.method_317();
    }

    private void method_425(XmlReader A_0, bool A_1, bool A_2)
    {
        int num = 0x13;
        if (!A_0.IsEmptyElement)
        {
            this.method_316(A_0, BookmarkStart.b("儸帺尼嬾⑀ㅂ⍄⡆♈㽊⡌㵎", num));
            string localName = A_0.LocalName;
            A_0.Read();
            this.method_485(A_0);
            bool flag = false;
            while (A_0.LocalName != localName)
            {
                flag = false;
                if (A_0.NodeType == XmlNodeType.Element)
                {
                    string str4 = A_0.LocalName;
                    if (str4 != null)
                    {
                        if (str4 != BookmarkStart.b("䤸吺丼", num))
                        {
                            if (str4 != BookmarkStart.b("圸为值社ⱀ㝂", num))
                            {
                                if (!(str4 == BookmarkStart.b("圸为值派⑀あㅄ♆㭈㽊", num)))
                                {
                                    if (str4 == BookmarkStart.b("圸为值氾㕀≂㝄㍆", num))
                                    {
                                        this.method_426(A_0, A_1, A_2);
                                    }
                                }
                                else
                                {
                                    this.method_428(A_0, A_1, A_2);
                                }
                            }
                            else
                            {
                                this.method_427(A_0, A_1, A_2);
                            }
                        }
                        else
                        {
                            string str;
                            string attribute = A_0.GetAttribute(BookmarkStart.b("伸娺儼", num), this.dictionary_18[BookmarkStart.b("丸", num)]);
                            if (!string.IsNullOrEmpty(attribute) && ((str = attribute) != null))
                            {
                                if (str != BookmarkStart.b("嬸帺匼娾⁀㝂ⵄፆⱈ㍊㥌", num))
                                {
                                    if (str != BookmarkStart.b("䤸娺娼娾̀ⱂㅄ㍆♈♊", num))
                                    {
                                        if (str != BookmarkStart.b("崸吺帼稾⽀❂", num))
                                        {
                                            if (str == BookmarkStart.b("䨸帺帼䬾рⵂ⅄", num))
                                            {
                                                if (!A_1 && A_2)
                                                {
                                                    this.document_0.LastSection.EndnoteOptions.method_54(FootnotePosition.PrintAsEndOfSection);
                                                }
                                                else if (!A_1 && !A_2)
                                                {
                                                    this.document_0.EndnoteOptions.method_54(FootnotePosition.PrintAsEndOfSection);
                                                }
                                                else if (A_1 && A_2)
                                                {
                                                    this.document_0.LastSection.FootnoteOptions.method_54(FootnotePosition.PrintAsEndOfSection);
                                                }
                                                else if (A_1 && !A_2)
                                                {
                                                    this.document_0.FootnoteOptions.method_54(FootnotePosition.PrintAsEndOfSection);
                                                }
                                            }
                                        }
                                        else if (!A_1 && A_2)
                                        {
                                            this.document_0.LastSection.EndnoteOptions.method_54(FootnotePosition.PrintAsEndOfDocument);
                                        }
                                        else if (!A_1 && !A_2)
                                        {
                                            this.document_0.EndnoteOptions.method_54(FootnotePosition.PrintAsEndOfDocument);
                                        }
                                        else if (A_1 && A_2)
                                        {
                                            this.document_0.LastSection.FootnoteOptions.method_54(FootnotePosition.PrintAsEndOfDocument);
                                        }
                                        else if (A_1 && !A_2)
                                        {
                                            this.document_0.FootnoteOptions.method_54(FootnotePosition.PrintAsEndOfDocument);
                                        }
                                    }
                                    else if (A_1 && A_2)
                                    {
                                        this.document_0.LastSection.FootnoteOptions.method_54(FootnotePosition.PrintAtBottomOfPage);
                                    }
                                    else if (A_1 && !A_2)
                                    {
                                        this.document_0.FootnoteOptions.method_54(FootnotePosition.PrintAtBottomOfPage);
                                    }
                                }
                                else if (A_1 && A_2)
                                {
                                    this.document_0.LastSection.FootnoteOptions.method_54(FootnotePosition.PrintImmediatelyBeneathText);
                                }
                                else if (A_1 && !A_2)
                                {
                                    this.document_0.FootnoteOptions.method_54(FootnotePosition.PrintImmediatelyBeneathText);
                                }
                            }
                        }
                    }
                    if (!flag)
                    {
                        A_0.Read();
                    }
                }
                else
                {
                    A_0.Read();
                }
                this.method_485(A_0);
            }
            this.method_317();
        }
    }

    private void method_426(XmlReader A_0, bool A_1, bool A_2)
    {
        string attribute = A_0.GetAttribute(BookmarkStart.b("倥䤧䘩", 0), this.dictionary_18[BookmarkStart.b("儥", 0)]);
        if (!string.IsNullOrEmpty(attribute))
        {
            if (A_1 && A_2)
            {
                this.document_0.LastSection.FootnoteOptions.method_56(int.Parse(attribute));
            }
            else if (A_1 && !A_2)
            {
                this.document_0.FootnoteOptions.method_56(int.Parse(attribute));
            }
            else if (!A_1 && A_2)
            {
                this.document_0.LastSection.EndnoteOptions.method_56(int.Parse(attribute));
            }
            else if (!A_1 && !A_2)
            {
                this.document_0.EndnoteOptions.method_56(int.Parse(attribute));
            }
        }
    }

    private void method_427(XmlReader A_0, bool A_1, bool A_2)
    {
        string str2;
        int num = 12;
        string attribute = A_0.GetAttribute(BookmarkStart.b("䐱唳娵", 12), this.dictionary_18[BookmarkStart.b("䔱", 12)]);
        if (!string.IsNullOrEmpty(attribute) && ((str2 = attribute) != null))
        {
            int num2;
            if (Class1160.dictionary_103 == null)
            {
                Dictionary<string, int> dictionary1 = new Dictionary<string, int>(0x11);
                dictionary1.Add(BookmarkStart.b("嘱儳唵儷圹崻刽", num), 0);
                dictionary1.Add(BookmarkStart.b("帱嬳䄵崷䠹瀻嬽㐿㙁⅃㑅", num), 1);
                dictionary1.Add(BookmarkStart.b("䜱䐳䘵崷䠹瀻嬽㐿㙁⅃㑅", num), 2);
                dictionary1.Add(BookmarkStart.b("帱嬳䄵崷䠹渻儽ⴿ⍁⩃", num), 3);
                dictionary1.Add(BookmarkStart.b("䜱䐳䘵崷䠹渻儽ⴿ⍁⩃", num), 4);
                dictionary1.Add(BookmarkStart.b("嘱儳唵儷圹崻刽ؿ㝁⡃⩅὇⍉⡋㩍㡏", num), 5);
                dictionary1.Add(BookmarkStart.b("娱儳吵䨷弹䬻༽", num), 6);
                dictionary1.Add(BookmarkStart.b("娱儳吵䨷弹䬻ఽ", num), 7);
                dictionary1.Add(BookmarkStart.b("匱䘳圵娷匹弻缽ⰿ㉁ⱃ❅", num), 8);
                dictionary1.Add(BookmarkStart.b("匱䘳圵娷匹弻缽∿⡁╃≅", num), 9);
                dictionary1.Add(BookmarkStart.b("儱尳張嬷嬹嬻儽", num), 10);
                dictionary1.Add(BookmarkStart.b("儱尳張嘷弹伻嬽̿ⵁㅃ⡅㱇⍉≋⥍я㩑㭓⍕⭗㭙㉛㩝", num), 11);
                dictionary1.Add(BookmarkStart.b("儱尳張嘷弹伻嬽ి❁⍃❅⑇᥉╋⍍⁏㹑㵓さㅗ㽙㡛", num), 12);
                dictionary1.Add(BookmarkStart.b("嬱倳匵圷崹主弽〿⩁၃㑅⥇⹉╋㩍㥏㵑㩓㝕㑗", num), 13);
                dictionary1.Add(BookmarkStart.b("嬱倳匵圷崹主弽〿⩁ṃ⥅ⱇ⍉ⵋⵍ", num), 14);
                dictionary1.Add(BookmarkStart.b("嘱儳唵儷圹崻刽Կⱁ❃⩅❇㥉⥋⩍ፏ㭑♓㕕㑗㽙Ὓ㙝य़ౡţᕥ൧", num), 15);
                dictionary1.Add(BookmarkStart.b("嬱倳匵圷崹主弽〿⩁Ń⡅⭇♉⍋㵍㕏㙑ᝓ㽕⩗㥙せ㭝", num), 0x10);
                Class1160.dictionary_103 = dictionary1;
            }
            if (Class1160.dictionary_103.TryGetValue(str2, out num2))
            {
                switch (num2)
                {
                    case 0:
                        if (!A_1 || !A_2)
                        {
                            if (A_1 && !A_2)
                            {
                                this.document_0.FootnoteOptions.method_53(FootnoteNumberFormat.Arabic);
                                return;
                            }
                            if (!A_1 && A_2)
                            {
                                this.document_0.LastSection.EndnoteOptions.method_53(FootnoteNumberFormat.Arabic);
                                return;
                            }
                            if (!A_1 && !A_2)
                            {
                                this.document_0.EndnoteOptions.method_53(FootnoteNumberFormat.Arabic);
                            }
                            return;
                        }
                        this.document_0.LastSection.FootnoteOptions.method_53(FootnoteNumberFormat.Arabic);
                        return;

                    case 1:
                        if (!A_1 || !A_2)
                        {
                            if (A_1 && !A_2)
                            {
                                this.document_0.FootnoteOptions.method_53(FootnoteNumberFormat.LowerCaseLetter);
                                return;
                            }
                            if (!A_1 && A_2)
                            {
                                this.document_0.LastSection.EndnoteOptions.method_53(FootnoteNumberFormat.LowerCaseLetter);
                                return;
                            }
                            if (!A_1 && !A_2)
                            {
                                this.document_0.EndnoteOptions.method_53(FootnoteNumberFormat.LowerCaseLetter);
                            }
                            return;
                        }
                        this.document_0.LastSection.FootnoteOptions.method_53(FootnoteNumberFormat.LowerCaseLetter);
                        return;

                    case 2:
                        if (!A_1 || !A_2)
                        {
                            if (A_1 && !A_2)
                            {
                                this.document_0.FootnoteOptions.method_53(FootnoteNumberFormat.UpperCaseLetter);
                                return;
                            }
                            if (!A_1 && A_2)
                            {
                                this.document_0.LastSection.EndnoteOptions.method_53(FootnoteNumberFormat.UpperCaseLetter);
                                return;
                            }
                            if (!A_1 && !A_2)
                            {
                                this.document_0.EndnoteOptions.method_53(FootnoteNumberFormat.UpperCaseLetter);
                            }
                            return;
                        }
                        this.document_0.LastSection.FootnoteOptions.method_53(FootnoteNumberFormat.UpperCaseLetter);
                        return;

                    case 3:
                        if (!A_1 || !A_2)
                        {
                            if (A_1 && !A_2)
                            {
                                this.document_0.FootnoteOptions.method_53(FootnoteNumberFormat.LowerCaseRoman);
                                return;
                            }
                            if (!A_1 && A_2)
                            {
                                this.document_0.LastSection.EndnoteOptions.method_53(FootnoteNumberFormat.LowerCaseRoman);
                                return;
                            }
                            if (!A_1 && !A_2)
                            {
                                this.document_0.EndnoteOptions.method_53(FootnoteNumberFormat.LowerCaseRoman);
                            }
                            return;
                        }
                        this.document_0.LastSection.FootnoteOptions.method_53(FootnoteNumberFormat.LowerCaseRoman);
                        return;

                    case 4:
                        if (!A_1 || !A_2)
                        {
                            if (A_1 && !A_2)
                            {
                                this.document_0.FootnoteOptions.method_53(FootnoteNumberFormat.UpperCaseRoman);
                                return;
                            }
                            if (!A_1 && A_2)
                            {
                                this.document_0.LastSection.EndnoteOptions.method_53(FootnoteNumberFormat.UpperCaseRoman);
                                return;
                            }
                            if (!A_1 && !A_2)
                            {
                                this.document_0.EndnoteOptions.method_53(FootnoteNumberFormat.UpperCaseRoman);
                            }
                            return;
                        }
                        this.document_0.LastSection.FootnoteOptions.method_53(FootnoteNumberFormat.UpperCaseRoman);
                        return;

                    case 5:
                        if (!A_1 || !A_2)
                        {
                            if (A_1 && !A_2)
                            {
                                this.document_0.FootnoteOptions.method_53(FootnoteNumberFormat.DecimalFullWidth);
                                return;
                            }
                            if (!A_1 && A_2)
                            {
                                this.document_0.LastSection.EndnoteOptions.method_53(FootnoteNumberFormat.DecimalFullWidth);
                                return;
                            }
                            if (!A_1 && !A_2)
                            {
                                this.document_0.EndnoteOptions.method_53(FootnoteNumberFormat.DecimalFullWidth);
                            }
                            return;
                        }
                        this.document_0.LastSection.FootnoteOptions.method_53(FootnoteNumberFormat.DecimalFullWidth);
                        return;

                    case 6:
                        if (!A_1 || !A_2)
                        {
                            if (A_1 && !A_2)
                            {
                                this.document_0.FootnoteOptions.method_53(FootnoteNumberFormat.Hebrew1);
                                return;
                            }
                            if (!A_1 && A_2)
                            {
                                this.document_0.LastSection.EndnoteOptions.method_53(FootnoteNumberFormat.Hebrew1);
                                return;
                            }
                            if (!A_1 && !A_2)
                            {
                                this.document_0.EndnoteOptions.method_53(FootnoteNumberFormat.Hebrew1);
                            }
                            return;
                        }
                        this.document_0.LastSection.FootnoteOptions.method_53(FootnoteNumberFormat.Hebrew1);
                        return;

                    case 7:
                        if (!A_1 || !A_2)
                        {
                            if (A_1 && !A_2)
                            {
                                this.document_0.FootnoteOptions.method_53(FootnoteNumberFormat.Hebrew2);
                                return;
                            }
                            if (!A_1 && A_2)
                            {
                                this.document_0.LastSection.EndnoteOptions.method_53(FootnoteNumberFormat.Hebrew2);
                                return;
                            }
                            if (!A_1 && !A_2)
                            {
                                this.document_0.EndnoteOptions.method_53(FootnoteNumberFormat.Hebrew2);
                            }
                            return;
                        }
                        this.document_0.LastSection.FootnoteOptions.method_53(FootnoteNumberFormat.Hebrew2);
                        return;

                    case 8:
                        if (!A_1 || !A_2)
                        {
                            if (A_1 && !A_2)
                            {
                                this.document_0.FootnoteOptions.method_53(FootnoteNumberFormat.ArabicAlpha);
                                return;
                            }
                            if (!A_1 && A_2)
                            {
                                this.document_0.LastSection.EndnoteOptions.method_53(FootnoteNumberFormat.ArabicAlpha);
                                return;
                            }
                            if (!A_1 && !A_2)
                            {
                                this.document_0.EndnoteOptions.method_53(FootnoteNumberFormat.ArabicAlpha);
                            }
                            return;
                        }
                        this.document_0.LastSection.FootnoteOptions.method_53(FootnoteNumberFormat.ArabicAlpha);
                        return;

                    case 9:
                        if (!A_1 || !A_2)
                        {
                            if (A_1 && !A_2)
                            {
                                this.document_0.FootnoteOptions.method_53(FootnoteNumberFormat.ArabicAbjad);
                                return;
                            }
                            if (!A_1 && A_2)
                            {
                                this.document_0.LastSection.EndnoteOptions.method_53(FootnoteNumberFormat.ArabicAbjad);
                                return;
                            }
                            if (!A_1 && !A_2)
                            {
                                this.document_0.EndnoteOptions.method_53(FootnoteNumberFormat.ArabicAbjad);
                            }
                            return;
                        }
                        this.document_0.LastSection.FootnoteOptions.method_53(FootnoteNumberFormat.ArabicAbjad);
                        return;

                    case 10:
                        if (!A_1 || !A_2)
                        {
                            if (A_1 && !A_2)
                            {
                                this.document_0.FootnoteOptions.method_53(FootnoteNumberFormat.Chicago);
                                return;
                            }
                            if (!A_1 && A_2)
                            {
                                this.document_0.LastSection.EndnoteOptions.method_53(FootnoteNumberFormat.Chicago);
                                return;
                            }
                            if (!A_1 && !A_2)
                            {
                                this.document_0.EndnoteOptions.method_53(FootnoteNumberFormat.Chicago);
                            }
                            return;
                        }
                        this.document_0.LastSection.FootnoteOptions.method_53(FootnoteNumberFormat.Chicago);
                        return;

                    case 11:
                        if (!A_1 || !A_2)
                        {
                            if (A_1 && !A_2)
                            {
                                this.document_0.FootnoteOptions.method_53(FootnoteNumberFormat.ChineseCountingThousand);
                                return;
                            }
                            if (!A_1 && A_2)
                            {
                                this.document_0.LastSection.EndnoteOptions.method_53(FootnoteNumberFormat.ChineseCountingThousand);
                                return;
                            }
                            if (!A_1 && !A_2)
                            {
                                this.document_0.EndnoteOptions.method_53(FootnoteNumberFormat.ChineseCountingThousand);
                            }
                            return;
                        }
                        this.document_0.LastSection.FootnoteOptions.method_53(FootnoteNumberFormat.ChineseCountingThousand);
                        return;

                    case 12:
                        if (!A_1 || !A_2)
                        {
                            if (A_1 && !A_2)
                            {
                                this.document_0.FootnoteOptions.method_53(FootnoteNumberFormat.ChineseLegalSimplified);
                                return;
                            }
                            if (!A_1 && A_2)
                            {
                                this.document_0.LastSection.EndnoteOptions.method_53(FootnoteNumberFormat.ChineseLegalSimplified);
                                return;
                            }
                            if (!A_1 && !A_2)
                            {
                                this.document_0.EndnoteOptions.method_53(FootnoteNumberFormat.ChineseLegalSimplified);
                            }
                            return;
                        }
                        this.document_0.LastSection.FootnoteOptions.method_53(FootnoteNumberFormat.ChineseLegalSimplified);
                        return;

                    case 13:
                        if (!A_1 || !A_2)
                        {
                            if (A_1 && !A_2)
                            {
                                this.document_0.FootnoteOptions.method_53(FootnoteNumberFormat.IdeographTraditional);
                                return;
                            }
                            if (!A_1 && A_2)
                            {
                                this.document_0.LastSection.EndnoteOptions.method_53(FootnoteNumberFormat.IdeographTraditional);
                                return;
                            }
                            if (!A_1 && !A_2)
                            {
                                this.document_0.EndnoteOptions.method_53(FootnoteNumberFormat.IdeographTraditional);
                            }
                            return;
                        }
                        this.document_0.LastSection.FootnoteOptions.method_53(FootnoteNumberFormat.IdeographTraditional);
                        return;

                    case 14:
                        if (!A_1 || !A_2)
                        {
                            if (A_1 && !A_2)
                            {
                                this.document_0.FootnoteOptions.method_53(FootnoteNumberFormat.IdeographZodiac);
                                return;
                            }
                            if (!A_1 && A_2)
                            {
                                this.document_0.LastSection.EndnoteOptions.method_53(FootnoteNumberFormat.IdeographZodiac);
                                return;
                            }
                            if (!A_1 && !A_2)
                            {
                                this.document_0.EndnoteOptions.method_53(FootnoteNumberFormat.IdeographZodiac);
                            }
                            return;
                        }
                        this.document_0.LastSection.FootnoteOptions.method_53(FootnoteNumberFormat.IdeographZodiac);
                        return;

                    case 15:
                        if (!A_1 || !A_2)
                        {
                            if (A_1 && !A_2)
                            {
                                this.document_0.FootnoteOptions.method_53(FootnoteNumberFormat.DecimalEnclosedCircleChinese);
                                return;
                            }
                            if (!A_1 && A_2)
                            {
                                this.document_0.LastSection.EndnoteOptions.method_53(FootnoteNumberFormat.DecimalEnclosedCircleChinese);
                                return;
                            }
                            if (!A_1 && !A_2)
                            {
                                this.document_0.EndnoteOptions.method_53(FootnoteNumberFormat.DecimalEnclosedCircleChinese);
                            }
                            return;
                        }
                        this.document_0.LastSection.FootnoteOptions.method_53(FootnoteNumberFormat.DecimalEnclosedCircleChinese);
                        return;

                    case 0x10:
                        if (!A_1 || !A_2)
                        {
                            if (A_1 && !A_2)
                            {
                                this.document_0.FootnoteOptions.method_53(FootnoteNumberFormat.IdeographEnclosedCircle);
                                return;
                            }
                            if (!A_1 && A_2)
                            {
                                this.document_0.LastSection.EndnoteOptions.method_53(FootnoteNumberFormat.IdeographEnclosedCircle);
                                return;
                            }
                            if (!A_1 && !A_2)
                            {
                                this.document_0.EndnoteOptions.method_53(FootnoteNumberFormat.IdeographEnclosedCircle);
                            }
                            return;
                        }
                        this.document_0.LastSection.FootnoteOptions.method_53(FootnoteNumberFormat.IdeographEnclosedCircle);
                        return;
                }
            }
        }
    }

    private void method_428(XmlReader A_0, bool A_1, bool A_2)
    {
        string str2;
        int num = 4;
        string attribute = A_0.GetAttribute(BookmarkStart.b("尩䴫䈭", 4), this.dictionary_18[BookmarkStart.b("崩", 4)]);
        if (!string.IsNullOrEmpty(attribute) && ((str2 = attribute) != null))
        {
            if (str2 == BookmarkStart.b("伩䴫䴭堯戱唳儵崷", num))
            {
                if (A_2)
                {
                    this.document_0.LastSection.FootnoteOptions.method_55(FootnoteRestartRule.RestartPage);
                }
                else
                {
                    this.document_0.FootnoteOptions.method_55(FootnoteRestartRule.RestartPage);
                }
            }
            else if (str2 == BookmarkStart.b("伩䴫䴭堯愱儳唵䰷", num))
            {
                if (A_1 && A_2)
                {
                    this.document_0.LastSection.FootnoteOptions.method_55(FootnoteRestartRule.RestartSection);
                }
                else if (A_1 && !A_2)
                {
                    this.document_0.FootnoteOptions.method_55(FootnoteRestartRule.RestartSection);
                }
                else if (!A_1 && A_2)
                {
                    this.document_0.LastSection.EndnoteOptions.method_55(FootnoteRestartRule.RestartSection);
                }
                else if (!A_1 && !A_2)
                {
                    this.document_0.EndnoteOptions.method_55(FootnoteRestartRule.RestartSection);
                }
            }
            else if (str2 == BookmarkStart.b("䤩䌫䀭䐯嬱娳䌵圷伹伻", num))
            {
                if (A_1 && A_2)
                {
                    this.document_0.LastSection.FootnoteOptions.method_55(FootnoteRestartRule.DoNotRestart);
                }
                else if (A_1 && !A_2)
                {
                    this.document_0.FootnoteOptions.method_55(FootnoteRestartRule.DoNotRestart);
                }
                else if (!A_1 && A_2)
                {
                    this.document_0.LastSection.EndnoteOptions.method_55(FootnoteRestartRule.DoNotRestart);
                }
                else if (!A_1 && !A_2)
                {
                    this.document_0.EndnoteOptions.method_55(FootnoteRestartRule.DoNotRestart);
                }
            }
        }
    }

    private void method_429(XmlReader A_0, Section A_1)
    {
        string str2;
        int num = 12;
        string attribute = A_0.GetAttribute(BookmarkStart.b("吱夳䈵", 12), this.dictionary_18[BookmarkStart.b("䔱", 12)]);
        if (((attribute != null) & (attribute != string.Empty)) && ((str2 = attribute) != null))
        {
            if (str2 != BookmarkStart.b("嘱儳唵儷圹崻刽", num))
            {
                if (str2 != BookmarkStart.b("帱嬳䄵崷䠹渻儽ⴿ⍁⩃", num))
                {
                    if (str2 != BookmarkStart.b("䜱䐳䘵崷䠹渻儽ⴿ⍁⩃", num))
                    {
                        if (!(str2 == BookmarkStart.b("帱嬳䄵崷䠹瀻嬽㐿㙁⅃㑅", num)))
                        {
                            if (str2 == BookmarkStart.b("䜱䐳䘵崷䠹瀻嬽㐿㙁⅃㑅", num))
                            {
                                A_1.PageSetup.PageNumberStyle = PageNumberStyle.LetterUpper;
                            }
                        }
                        else
                        {
                            A_1.PageSetup.PageNumberStyle = PageNumberStyle.LetterLower;
                        }
                    }
                    else
                    {
                        A_1.PageSetup.PageNumberStyle = PageNumberStyle.RomanUpper;
                    }
                }
                else
                {
                    A_1.PageSetup.PageNumberStyle = PageNumberStyle.RomanLower;
                }
            }
            else
            {
                A_1.PageSetup.PageNumberStyle = PageNumberStyle.Arabic;
            }
        }
        string s = A_0.GetAttribute(BookmarkStart.b("䄱䀳圵䨷丹", num), this.dictionary_18[BookmarkStart.b("䔱", num)]);
        if ((s != null) && (s != string.Empty))
        {
            A_1.PageSetup.RestartPageNumbering = true;
            A_1.PageSetup.PageStartingNumber = int.Parse(s);
        }
    }

    private void method_43(Stream A_0)
    {
        this.method_316(XmlReader.Create(A_0), BookmarkStart.b("帩䐫䬭崯圱", 4));
        if (this.document_0.Themes == null)
        {
            this.document_0.Themes = new Class324(this.document_0);
        }
        this.string_0 = this.method_45(A_0, true);
        this.string_2 = this.method_45(A_0, false);
        this.method_46(A_0);
        this.method_47(A_0);
        this.method_48(A_0);
        this.method_317();
    }

    private void method_430(XmlReader A_0, IDocumentObject A_1)
    {
        int num = 9;
        string attribute = A_0.GetAttribute(BookmarkStart.b("央倰弲", 9), this.dictionary_18[BookmarkStart.b("堮", 9)]);
        if (!string.IsNullOrEmpty(attribute))
        {
            string key = attribute;
            if (key != null)
            {
                int num2;
                if (Class1160.dictionary_104 == null)
                {
                    Dictionary<string, int> dictionary1 = new Dictionary<string, int>(6);
                    dictionary1.Add(BookmarkStart.b("䴮䔰缲䜴", num), 0);
                    dictionary1.Add(BookmarkStart.b("䌮䌰朲圴愶", num), 1);
                    dictionary1.Add(BookmarkStart.b("嬮匰愲头", num), 2);
                    dictionary1.Add(BookmarkStart.b("嬮匰愲头愶", num), 3);
                    dictionary1.Add(BookmarkStart.b("嬮匰缲䜴愶", num), 4);
                    dictionary1.Add(BookmarkStart.b("䌮䌰朲圴", num), 5);
                    Class1160.dictionary_104 = dictionary1;
                }
                if (Class1160.dictionary_104.TryGetValue(key, out num2))
                {
                    switch (num2)
                    {
                        case 0:
                            (A_1 as Section).method_26(TextDirection.LeftToRight);
                            return;

                        case 1:
                            (A_1 as Section).method_26(TextDirection.TopToBottomRotated);
                            return;

                        case 2:
                            (A_1 as Section).method_26(TextDirection.RightToLeft);
                            return;

                        case 3:
                            (A_1 as Section).method_26(TextDirection.RightToLeftRotated);
                            return;

                        case 4:
                            (A_1 as Section).method_26(TextDirection.LeftToRightRotated);
                            return;
                    }
                }
            }
            (A_1 as Section).method_26(TextDirection.TopToBottom);
        }
    }

    private void method_431(XmlReader A_0, Section A_1)
    {
        string str2;
        int num = 4;
        PageSetup pageSetup = A_1.PageSetup;
        pageSetup.HasLineNumbering = true;
        string attribute = A_0.GetAttribute(BookmarkStart.b("䤩䌫嬭帯䘱瘳伵", 4), this.dictionary_18[BookmarkStart.b("崩", 4)]);
        if (attribute != null)
        {
            pageSetup.LineNumberingStep = int.Parse(attribute, NumberStyles.Integer, CultureInfo.InvariantCulture);
        }
        attribute = A_0.GetAttribute(BookmarkStart.b("天堫伭䈯䘱", num), this.dictionary_18[BookmarkStart.b("崩", num)]);
        if (attribute != null)
        {
            pageSetup.LineNumberingStartValue = int.Parse(attribute, NumberStyles.Integer, CultureInfo.InvariantCulture) + 1;
        }
        float num2 = this.method_481(A_0, BookmarkStart.b("丩䔫崭䐯匱娳唵崷", num), this.dictionary_18[BookmarkStart.b("崩", num)]);
        if (num2 != float.MaxValue)
        {
            pageSetup.LineNumberingDistanceFromText = num2;
        }
        attribute = A_0.GetAttribute(BookmarkStart.b("堩䤫崭䐯匱䘳䈵", num), this.dictionary_18[BookmarkStart.b("崩", num)]);
        if ((attribute != null) && ((str2 = attribute) != null))
        {
            if (str2 == BookmarkStart.b("䐩䤫夭怯匱匳匵", num))
            {
                pageSetup.LineNumberingRestartMode = LineNumberingRestartMode.RestartPage;
            }
            else if (str2 == BookmarkStart.b("䐩䤫夭振圱圳䈵儷唹刻", num))
            {
                pageSetup.LineNumberingRestartMode = LineNumberingRestartMode.RestartSection;
            }
            else if (str2 == BookmarkStart.b("䤩䌫䀭䐯嬱娳䌵圷伹伻", num))
            {
                pageSetup.LineNumberingRestartMode = LineNumberingRestartMode.Continuous;
            }
        }
    }

    private void method_432(XmlReader A_0, Section A_1)
    {
        string str2;
        int num = 14;
        string attribute = A_0.GetAttribute(BookmarkStart.b("䈳圵吷", 14), this.dictionary_18[BookmarkStart.b("䌳", 14)]);
        if ((attribute != null) && ((str2 = attribute) != null))
        {
            if (str2 == BookmarkStart.b("䀳夵䠷", num))
            {
                A_1.PageSetup.VerticalAlignment = PageAlignment.Top;
            }
            else if (str2 == BookmarkStart.b("圳匵嘷丹夻䰽", num))
            {
                A_1.PageSetup.VerticalAlignment = PageAlignment.Middle;
            }
            else if (str2 == BookmarkStart.b("嘳夵䰷刹", num))
            {
                A_1.PageSetup.VerticalAlignment = PageAlignment.Justified;
            }
            else if (str2 == BookmarkStart.b("嘳夵䰷丹医匽", num))
            {
                A_1.PageSetup.VerticalAlignment = PageAlignment.Bottom;
            }
        }
    }

    private void method_433(XmlReader A_0, Section A_1)
    {
        int num = 0;
        float num2 = this.method_481(A_0, BookmarkStart.b("䨥䄧䐩䤫縭夯䘱圳帵", 0), this.dictionary_18[BookmarkStart.b("儥", 0)]);
        if (num2 != float.MaxValue)
        {
            string str;
            A_1.PageSetup.LinePitch = num2;
            string attribute = A_0.GetAttribute(BookmarkStart.b("別儧娩䤫", num), this.dictionary_18[BookmarkStart.b("儥", num)]);
            if ((attribute != null) && ((str = attribute) != null))
            {
                if (str != BookmarkStart.b("䨥䄧䐩䤫崭", num))
                {
                    if (!(str == BookmarkStart.b("䨥䄧䐩䤫崭焯就倳电倷嬹主䴽", num)))
                    {
                        if (str == BookmarkStart.b("唥䘧䬩尫稭弯焱尳圵䨷䤹", num))
                        {
                            A_1.PageSetup.PitchType = GridPitchType.SnapToChars;
                        }
                    }
                    else
                    {
                        A_1.PageSetup.PitchType = GridPitchType.CharsAndLine;
                    }
                }
                else
                {
                    A_1.PageSetup.PitchType = GridPitchType.LinesOnly;
                }
            }
            float num3 = this.method_481(A_0, BookmarkStart.b("䔥䀧䬩師紭䀯匱圳匵", num), this.dictionary_18[BookmarkStart.b("儥", num)]);
            if (num3 != float.MaxValue)
            {
                A_1.PageSetup.CharsLine = (int) Math.Round((double) (num3 * 20f));
            }
        }
    }

    private void method_434(XmlReader A_0, Section A_1)
    {
        string str4;
        int num = 0x11;
        string attribute = A_0.GetAttribute(BookmarkStart.b("堶弸崺丼娾㕀Ղ㝄⡆⑈", 0x11), this.dictionary_18[BookmarkStart.b("䀶", 0x11)]);
        if (attribute != null)
        {
            A_1.PageSetup.PageBorderOffsetFrom = (attribute == BookmarkStart.b("䜶堸尺堼", num)) ? PageBorderOffsetFrom.PageEdge : PageBorderOffsetFrom.Text;
        }
        string str3 = A_0.GetAttribute(BookmarkStart.b("匶倸䠺䴼匾⁀㩂", num), this.dictionary_18[BookmarkStart.b("䀶", num)]);
        if (str3 == null)
        {
            goto Label_00D3;
        }
        string str2 = str3;
        if (str2 != null)
        {
            if (!(str2 == BookmarkStart.b("儶倸䤺丼䬾ᅀ≂≄≆", num)))
            {
                if (!(str2 == BookmarkStart.b("夶嘸伺笼嘾㍀あㅄᝆ⡈ⱊ⡌", num)))
                {
                    goto Label_00C7;
                }
                A_1.PageSetup.PageBordersApplyType = PageBordersApplyType.AllExceptFirstPage;
            }
            else
            {
                A_1.PageSetup.PageBordersApplyType = PageBordersApplyType.FirstPage;
            }
            goto Label_00D3;
        }
    Label_00C7:
        A_1.PageSetup.PageBordersApplyType = PageBordersApplyType.AllPages;
    Label_00D3:
        str4 = A_0.GetAttribute(BookmarkStart.b("䴶瘸䤺夼娾㍀", num), this.dictionary_18[BookmarkStart.b("䀶", num)]);
        if ((str4 != null) && (str4 == BookmarkStart.b("唶堸堺嘼", num)))
        {
            A_1.PageSetup.IsFrontPageBorder = false;
        }
        this.method_415(A_0, A_1);
    }

    private void method_435(XmlReader A_0, Section A_1)
    {
        int num = 1;
        string attribute = A_0.GetAttribute(BookmarkStart.b("否䰨嬪", 1), this.dictionary_18[BookmarkStart.b("倦", 1)]);
        if ((attribute != null) && (attribute == BookmarkStart.b("ᘦ", num)))
        {
            A_1.PageSetup.ColumnsLineBetween = true;
        }
        if (!this.method_436(A_0))
        {
            A_1.Columns.OwnerSection.PageSetup.EqualColumnWidth = false;
            this.method_438(A_0, A_1);
        }
        else
        {
            A_1.Columns.OwnerSection.PageSetup.EqualColumnWidth = true;
            this.method_437(A_0, A_1);
        }
    }

    private bool method_436(XmlReader A_0)
    {
        int num = 5;
        string attribute = A_0.GetAttribute(BookmarkStart.b("个尬娮倰弲戴帶崸伺唼", 5), this.dictionary_18[BookmarkStart.b("尪", 5)]);
        return ((!(attribute == BookmarkStart.b("ᬪ", 5)) && !(attribute == BookmarkStart.b("䴪䰬䌮䈰嘲", num))) && !(attribute == BookmarkStart.b("䐪䬬䤮", num)));
    }

    private void method_437(XmlReader A_0, Section A_1)
    {
        int num = 12;
        float num2 = A_1.PageSetup.PageSize.Width * 20f;
        float num3 = A_1.PageSetup.Margins.Left * 20f;
        float num4 = A_1.PageSetup.Margins.Right * 20f;
        float num5 = 0f;
        float num6 = 0f;
        int num7 = 1;
        string attribute = A_0.GetAttribute(BookmarkStart.b("就䄳嬵", 12), this.dictionary_18[BookmarkStart.b("䔱", 12)]);
        if (attribute != null)
        {
            num7 = int.Parse(attribute);
        }
        if (A_0.GetAttribute(BookmarkStart.b("䄱䐳圵嬷弹", num), this.dictionary_18[BookmarkStart.b("䔱", num)]) != null)
        {
            num5 = this.method_239(A_0.GetAttribute(BookmarkStart.b("䄱䐳圵嬷弹", num), this.dictionary_18[BookmarkStart.b("䔱", num)]));
            A_1.SectPr.method_121(Class59.smethod_8(num5, 0));
        }
        float num9 = A_1.PageSetup.Margins.Gutter * 20f;
        num6 = ((((num2 - num3) - num4) - (num5 * (num7 - 1))) - num9) / ((float) num7);
        if (A_1.Columns.Count > 0)
        {
            if (string.IsNullOrEmpty(attribute))
            {
                return;
            }
            A_1.Columns.method_5();
        }
        for (int i = 0; i < num7; i++)
        {
            Column column = new Column(this.document_0) {
                Space = num5 / 20f,
                Width = num6 / 20f
            };
            A_1.Columns.Add(column);
        }
    }

    private void method_438(XmlReader A_0, Section A_1)
    {
        int num = 6;
        if (!A_0.IsEmptyElement)
        {
            string localName = A_0.LocalName;
            A_0.Read();
            this.method_485(A_0);
            bool flag2 = false;
            bool flag = false;
            while (A_0.LocalName != localName)
            {
                if (A_0.EOF)
                {
                    break;
                }
                flag2 = false;
                if (A_0.NodeType == XmlNodeType.Element)
                {
                    string str;
                    if (((str = A_0.LocalName) != null) && (str == BookmarkStart.b("伫䄭尯", num)))
                    {
                        float maxValue = float.MaxValue;
                        float num3 = float.MaxValue;
                        if (A_0.GetAttribute(BookmarkStart.b("弫席儯儱儳", num), this.dictionary_18[BookmarkStart.b("嬫", num)]) != null)
                        {
                            maxValue = int.Parse(A_0.GetAttribute(BookmarkStart.b("弫席儯儱儳", num), this.dictionary_18[BookmarkStart.b("嬫", num)]));
                        }
                        if (A_0.GetAttribute(BookmarkStart.b("嬫", num), this.dictionary_18[BookmarkStart.b("嬫", num)]) != null)
                        {
                            num3 = int.Parse(A_0.GetAttribute(BookmarkStart.b("嬫", num), this.dictionary_18[BookmarkStart.b("嬫", num)]));
                        }
                        Column column = new Column(this.document_0);
                        if (maxValue != float.MaxValue)
                        {
                            column.Space = maxValue / 20f;
                        }
                        if (num3 != float.MaxValue)
                        {
                            column.Width = num3 / 20f;
                        }
                        if ((A_1.Columns.Count > 0) && !flag)
                        {
                            A_1.Columns.method_5();
                        }
                        flag = true;
                        A_1.Columns.Add(column);
                    }
                    if (!flag2)
                    {
                        A_0.Read();
                    }
                }
                else
                {
                    A_0.Read();
                }
                this.method_485(A_0);
            }
        }
    }

    private void method_439(XmlReader A_0, Section A_1)
    {
        int num = 10;
        float num2 = this.method_440(A_0, BookmarkStart.b("䐯崱䐳", 10));
        if (num2 != float.MinValue)
        {
            A_1.PageSetup.Margins.Top = num2;
        }
        float num5 = this.method_440(A_0, BookmarkStart.b("䈯嬱匳帵䰷", num));
        if (num5 != float.MinValue)
        {
            A_1.PageSetup.Margins.Right = num5;
        }
        float num7 = this.method_440(A_0, BookmarkStart.b("刯崱䀳䈵圷圹", num));
        if (num7 != float.MinValue)
        {
            A_1.PageSetup.Margins.Bottom = num7;
        }
        float num6 = this.method_440(A_0, BookmarkStart.b("尯圱刳䈵", num));
        if (num6 != float.MinValue)
        {
            A_1.PageSetup.Margins.Left = num6;
        }
        float num8 = this.method_440(A_0, BookmarkStart.b("圯䜱䀳䈵崷䠹", num));
        if (num8 != float.MinValue)
        {
            A_1.PageSetup.Margins.Gutter = num8;
            this.float_0 = num8;
        }
        float num3 = this.method_440(A_0, BookmarkStart.b("嘯崱嬳䈵崷䠹", num));
        if (num3 != -1f)
        {
            A_1.PageSetup.FooterDistance = num3;
        }
        float num4 = this.method_440(A_0, BookmarkStart.b("堯圱唳刵崷䠹", num));
        if (num4 != -1f)
        {
            A_1.PageSetup.HeaderDistance = num4;
        }
    }

    private TextAlignment method_44(string A_0)
    {
        int num = 13;
        string str = A_0;
        if (str != null)
        {
            if (str == BookmarkStart.b("䜲娴䜶", num))
            {
                return TextAlignment.Top;
            }
            if (str == BookmarkStart.b("儲吴䐶尸场吼儾⑀", num))
            {
                return TextAlignment.Baseline;
            }
            if (str == BookmarkStart.b("儲娴䌶䴸吺值", num))
            {
                return TextAlignment.Bottom;
            }
            if (str == BookmarkStart.b("倲倴夶䴸帺似", num))
            {
                return TextAlignment.Center;
            }
        }
        return TextAlignment.Auto;
    }

    private float method_440(XmlReader A_0, string A_1)
    {
        int num = 13;
        float num2 = ((A_1 == BookmarkStart.b("唲娴堶䴸帺似", 13)) || (A_1 == BookmarkStart.b("嬲倴嘶崸帺似", num))) ? ((float) (-1)) : ((float) 0);
        string attribute = A_0.GetAttribute(A_1, this.dictionary_18[BookmarkStart.b("䐲", num)]);
        if (!string.IsNullOrEmpty(attribute))
        {
            if (attribute.EndsWith(BookmarkStart.b("䌲䄴", num)))
            {
                return float.Parse(attribute.Replace(BookmarkStart.b("䌲䄴", num), string.Empty));
            }
            return (float.Parse(attribute) / 20f);
        }
        if (num2 == -1f)
        {
            return num2;
        }
        return float.MinValue;
    }

    private void method_441(XmlReader A_0, Section A_1)
    {
        float height = this.method_481(A_0, BookmarkStart.b("䜮", 9), this.dictionary_18[BookmarkStart.b("堮", 9)]);
        float width = this.method_481(A_0, BookmarkStart.b("堮", 9), this.dictionary_18[BookmarkStart.b("堮", 9)]);
        A_1.PageSetup.PageSize = new SizeF(width, height);
        string attribute = A_0.GetAttribute(BookmarkStart.b("䀮䌰娲倴夶䴸", 9), this.dictionary_18[BookmarkStart.b("堮", 9)]);
        A_1.PageSetup.Orientation = (attribute == BookmarkStart.b("䌮倰崲儴䐶娸娺䴼娾", 9)) ? PageOrientation.Landscape : PageOrientation.Portrait;
        A_1.PageSetup.Orientation = (width > height) ? PageOrientation.Landscape : PageOrientation.Portrait;
    }

    private void method_442(Section A_0, string A_1)
    {
        int num = 5;
        string str = A_1;
        if (str != null)
        {
            if (str == BookmarkStart.b("䔪䠬圮䔰瀲娴嬶䰸嘺匼", num))
            {
                A_0.BreakCode = SectionBreakType.NewColumn;
                return;
            }
            if (str == BookmarkStart.b("䔪䠬圮䔰挲吴倶尸", num))
            {
                A_0.BreakCode = SectionBreakType.NewPage;
                return;
            }
            if (str == BookmarkStart.b("个嬬䨮弰挲吴倶尸", num))
            {
                A_0.BreakCode = SectionBreakType.EvenPage;
                return;
            }
            if (str == BookmarkStart.b("䐪䤬䬮愰刲刴制", num))
            {
                A_0.BreakCode = SectionBreakType.Oddpage;
                return;
            }
        }
        A_0.BreakCode = SectionBreakType.NoBreak;
    }

    private void method_443(Stream A_0)
    {
        int num = 2;
        A_0.Position = 0L;
        XmlReader reader = Class57.smethod_18(A_0);
        if (reader == null)
        {
            throw new Exception(BookmarkStart.b("娧伩䴫䨭唯䀱", num));
        }
        while (reader.NodeType != XmlNodeType.Element)
        {
            reader.Read();
        }
        string localName = reader.LocalName;
        if ((reader.LocalName != BookmarkStart.b("嬧伩堫娭夯就匳䔵", num)) && (reader.LocalName != BookmarkStart.b("䰧䔩伫嬭崯圱娳䈵", num)))
        {
            throw new XmlException(BookmarkStart.b("紧䐩䤫嘭䀯圱圳䈵崷帹᰻䘽ⴿ⹁摃㉅⥇ⵉ汋", num) + reader.LocalName);
        }
        if (!reader.IsEmptyElement)
        {
            this.method_316(reader, BookmarkStart.b("嬧伩堫娭夯就匳䔵", num));
            reader.Read();
            this.method_444(reader, localName);
            this.method_317();
        }
    }

    private void method_444(XmlReader A_0, string A_1)
    {
        int num = 11;
        bool flag = false;
        bool flag2 = false;
    Label_000A:
        if (!(A_0.LocalName != A_1))
        {
            if (!flag2)
            {
                this.document_0.Background.Type = BackgroundType.NoBackground;
            }
            return;
        }
        flag = false;
        if (A_0.NodeType != XmlNodeType.Element)
        {
            A_0.Read();
            goto Label_000A;
        }
        string localName = A_0.LocalName;
        if (localName != null)
        {
            int num3;
            if (Class1160.dictionary_105 == null)
            {
                Dictionary<string, int> dictionary1 = new Dictionary<string, int>(0x24);
                dictionary1.Add(BookmarkStart.b("嘰䘲䄴䌶尸䤺簼䬾ᕀⱂ㕄", num), 0);
                dictionary1.Add(BookmarkStart.b("䬰尲娴娶", num), 1);
                dictionary1.Add(BookmarkStart.b("吰帲圴制崸漺似䨾⑀ᝂ㱄㝆ⱈൊ≌ⅎ═⁒", num), 2);
                dictionary1.Add(BookmarkStart.b("吰帲圴制崸栺䐼䰾㕀♂⡄ņ♈╊㥌㱎", num), 3);
                dictionary1.Add(BookmarkStart.b("䈰刲䌴制樸为弼䰾⑀㝂̈́⡆❈㽊㹌", num), 4);
                dictionary1.Add(BookmarkStart.b("唰嘲匴嘶䰸场䤼款⁀⅂ᙄ㍆♈㭊", num), 5);
                dictionary1.Add(BookmarkStart.b("倰弲尴倶圸示刼䴾╀♂㝄㑆ࡈ╊⥌੎㕐㑒ご⑖", num), 6);
                dictionary1.Add(BookmarkStart.b("匰尲䜴匶尸䤺丼笾⹀ൂ⩄㍆ᩈ㹊㽌㵎㹐♒㭔㍖ᅘ㹚㱜㭞Ѡᅢ", num), 7);
                dictionary1.Add(BookmarkStart.b("匰尲䜴匶尸䤺丼笾⹀ൂ⩄㍆ᩈ㹊㽌㵎㹐♒㭔㍖὘㑚㉜⭞Ѡᅢ", num), 8);
                dictionary1.Add(BookmarkStart.b("䄰䄲娴堶弸栺䤼帾㕀♂", num), 9);
                dictionary1.Add(BookmarkStart.b("到嬲吴䔶堸堺䤼娾㍀၂㕄♆⩈≊⍌⡎ቐ㱒㭔⍖⭘㑚ㅜ", num), 10);
                dictionary1.Add(BookmarkStart.b("尰娲䜴䔶嘸䤺瀼帾㍀⑂ⱄ⥆㩈", num), 11);
                dictionary1.Add(BookmarkStart.b("唰娲䘴䜶唸娺䐼紾⁀⁂⹄⁆㭈⑊㡌ⅎ㕐R㵔㙖⥘㹚", num), 12);
                dictionary1.Add(BookmarkStart.b("唰尲笴堶䴸缺吼䰾ㅀ⽂⑄㹆᥈⩊⩌⩎ፐ㱒⁔㥖㵘㩚⽜㙞Ѡၢ", num), 13);
                dictionary1.Add(BookmarkStart.b("地尲娴䌶圸吺䤼娾ᅀㅂ", num), 14);
                dictionary1.Add(BookmarkStart.b("吰崲儴夶嘸伺堼漾㍀", num), 15);
                dictionary1.Add(BookmarkStart.b("䔰䄲吴吶券椺堼䤾⡀あⱄ⡆❈㡊", num), 0x10);
                dictionary1.Add(BookmarkStart.b("䐰娲瘴堶吸䬺尼䬾础瑂ᅄ⡆筈筊経籎", num), 0x11);
                dictionary1.Add(BookmarkStart.b("到弲䜴搶娸区堼刾⑀โ⑄㝆㥈≊⍌⡎", num), 0x12);
                dictionary1.Add(BookmarkStart.b("夰圲䜴搶儸娺䴼娾Հ♂⍄♆㱈❊㥌㱎", num), 0x13);
                dictionary1.Add(BookmarkStart.b("䌰䀲尴匶䨸", num), 20);
                dictionary1.Add(BookmarkStart.b("尰刲䄴弶椸䤺", num), 0x15);
                dictionary1.Add(BookmarkStart.b("䈰嬲吴䜶尸缺堼夾⁀㙂⥄㍆㩈", num), 0x16);
                dictionary1.Add(BookmarkStart.b("䔰嬲倴娶尸紺刼儾㕀ག⑄⥆⹈", num), 0x17);
                dictionary1.Add(BookmarkStart.b("吰䔲倴夶砸唺夼瀾╀❂ൄ≆⡈⽊⡌㵎≐", num), 0x18);
                dictionary1.Add(BookmarkStart.b("唰尲嘴愶堸䤺丼", num), 0x19);
                dictionary1.Add(BookmarkStart.b("䜰娲倴䀶", num), 0x1a);
                dictionary1.Add(BookmarkStart.b("唰尲嘴䈶吸帺匼䬾ᅀㅂ⩄㍆ⱈ⡊㥌♎㹐㵒", num), 0x1b);
                dictionary1.Add(BookmarkStart.b("到尲場䜶堸伺", num), 0x1c);
                dictionary1.Add(BookmarkStart.b("到尲場䜶堸伺渼娾㕀㝂ⱄ⥆⹈", num), 0x1d);
                dictionary1.Add(BookmarkStart.b("倰䘲䄴堶焸䈺䴼圾⑀ⵂ⑄㍆⁈⑊⍌", num), 30);
                dictionary1.Add(BookmarkStart.b("到尲嬴䐶尸堺䠼䬾⡀㕂⁄ཆえ㭊╌⩎㽐ὒ㱔㩖じ⽚", num), 0x1f);
                dictionary1.Add(BookmarkStart.b("夰䨲䔴弶尸唺尼䬾⡀ⱂ⭄ᵆ♈╊⡌", num), 0x20);
                dictionary1.Add(BookmarkStart.b("唰尲笴堶䴸猺䐼伾⥀♂⭄♆㵈⹊์⹎⅐⁒", num), 0x21);
                dictionary1.Add(BookmarkStart.b("唰尲笴堶䴸栺唼帾╀♂̈́⡆㭈♊ौ⹎═㉒", num), 0x22);
                dictionary1.Add(BookmarkStart.b("弰尲攴䈶圸堺䤼䨾⁀㝂ⱄ⡆❈J⡌㵎㽐㩒㭔ざ", num), 0x23);
                Class1160.dictionary_105 = dictionary1;
            }
            if (Class1160.dictionary_105.TryGetValue(localName, out num3))
            {
                switch (num3)
                {
                    case 0:
                        this.bool_11 = true;
                        foreach (Section section in this.document_0.Sections)
                        {
                            section.PageSetup.GutterAtTop = true;
                        }
                        goto Label_0A21;

                    case 1:
                    {
                        string attribute = A_0.GetAttribute(BookmarkStart.b("䄰嘲䜴吶尸唺䤼", num), this.dictionary_18[BookmarkStart.b("䘰", num)]);
                        if (attribute != null)
                        {
                            int num2 = int.Parse(attribute.TrimEnd(new char[] { '%' }), NumberStyles.Integer, CultureInfo.InvariantCulture);
                            this.document_0.ViewSetup.method_6(num2);
                        }
                        goto Label_0A21;
                    }
                    case 2:
                        this.document_0.EmbedFontsInFile = true;
                        goto Label_0A21;

                    case 3:
                        this.document_0.EmbedSystemFonts = true;
                        goto Label_0A21;

                    case 4:
                        this.document_0.SaveSubsetFonts = true;
                        goto Label_0A21;

                    case 5:
                        this.document_0.Settings.float_0 = this.method_481(A_0, BookmarkStart.b("䜰刲头", num), this.dictionary_18[BookmarkStart.b("䘰", num)]) * 20f;
                        goto Label_0A21;

                    case 6:
                    {
                        string str = this.method_101(A_0, BookmarkStart.b("䜰刲头", num), this.dictionary_18[BookmarkStart.b("䘰", num)]);
                        if (string.IsNullOrEmpty(str) || (!string.IsNullOrEmpty(str) && ((str.ToLower() == BookmarkStart.b("䔰䄲䀴制", num)) || (str == BookmarkStart.b("0", num)))))
                        {
                            this.bool_7 = true;
                        }
                        goto Label_0A21;
                    }
                    case 7:
                    {
                        string str5 = this.method_101(A_0, BookmarkStart.b("䜰刲头", num), this.dictionary_18[BookmarkStart.b("䘰", num)]);
                        if (!string.IsNullOrEmpty(str5) && !this.method_110(str5))
                        {
                            this.bool_8 = true;
                        }
                        goto Label_0A21;
                    }
                    case 8:
                    {
                        string str9 = this.method_101(A_0, BookmarkStart.b("䜰刲头", num), this.dictionary_18[BookmarkStart.b("䘰", num)]);
                        if (!string.IsNullOrEmpty(str9) && !this.method_110(str9))
                        {
                            this.bool_9 = true;
                        }
                        goto Label_0A21;
                    }
                    case 9:
                    {
                        string str4 = this.method_101(A_0, BookmarkStart.b("䈰䌲倴嬶唸刺匼堾", num), this.dictionary_18[BookmarkStart.b("䘰", num)]);
                        if (!string.IsNullOrEmpty(str4) && (str4 == BookmarkStart.b("到弲倴嘶圸", num)))
                        {
                            this.document_0.GrammarSpellingData.method_7(ProofState.Clean);
                        }
                        string str11 = str4 = this.method_101(A_0, BookmarkStart.b("嘰䄲吴娶吸娺似", num), this.dictionary_18[BookmarkStart.b("䘰", num)]);
                        if (!string.IsNullOrEmpty(str11) && (str11 == BookmarkStart.b("到弲倴嘶圸", num)))
                        {
                            this.document_0.GrammarSpellingData.method_5(ProofState.Clean);
                        }
                        goto Label_0A21;
                    }
                    case 10:
                    {
                        string str8 = this.method_101(A_0, BookmarkStart.b("䜰刲头", num), this.dictionary_18[BookmarkStart.b("䘰", num)]);
                        this.string_4 = str8;
                        foreach (Section section2 in this.document_0.Sections)
                        {
                            string str7 = str8;
                            if (str7 != null)
                            {
                                if (str7 != BookmarkStart.b("唰尲笴堶䴸砺刼刾ㅀㅂ⁄㑆㩈", num))
                                {
                                    if (!(str7 == BookmarkStart.b("到尲場䜶䬸帺丼䰾ᅀ㙂⭄⑆㵈㹊ⱌ㭎㡐㱒㭔", num)))
                                    {
                                        if (str7 == BookmarkStart.b("到尲場䜶䬸帺丼䰾ᅀ㙂⭄⑆㵈㹊ⱌ㭎㡐㱒㭔ᙖ㝘㽚᝜㹞ᅠɢ୤ɦᩨ๪♬๮ὰቲ", num))
                                        {
                                            section2.PageSetup.CharacterSpacingControl = CharacterSpacing.compressPunctuationAndJapaneseKana;
                                        }
                                    }
                                    else
                                    {
                                        section2.PageSetup.CharacterSpacingControl = CharacterSpacing.compressPunctuation;
                                    }
                                }
                                else
                                {
                                    section2.PageSetup.CharacterSpacingControl = CharacterSpacing.doNotCompress;
                                }
                            }
                        }
                        goto Label_0A21;
                    }
                    case 11:
                        this.document_0.Settings.bool_11 = true;
                        goto Label_0A21;

                    case 12:
                        flag2 = true;
                        this.document_0.ViewSetup.DisplayBackgroundShape = true;
                        goto Label_0A21;

                    case 13:
                        this.document_0.ViewSetup.DoNotDisplayPageBoundaries = true;
                        goto Label_0A21;

                    case 14:
                        this.method_425(A_0, true, false);
                        goto Label_0A21;

                    case 15:
                        this.method_425(A_0, false, false);
                        goto Label_0A21;

                    case 0x10:
                        this.document_0.TrackChanges = true;
                        goto Label_0A21;

                    case 0x11:
                        goto Label_0A21;

                    case 0x12:
                        this.method_445(A_0);
                        goto Label_0A21;

                    case 0x13:
                    case 20:
                    case 0x15:
                    case 0x16:
                        A_0.Skip();
                        flag = true;
                        goto Label_0A21;

                    case 0x17:
                        if (A_0.AttributeCount > 0)
                        {
                            this.document_0.ThemeFontLanguage = new Class514();
                            this.method_401(A_0, this.document_0.ThemeFontLanguage);
                        }
                        goto Label_0A21;

                    case 0x18:
                        this.bool_10 = true;
                        if (this.document_0.Sections.Count != 0)
                        {
                            this.document_0.Sections[0].PageSetup.DifferentOddAndEvenPagesHeaderFooter = true;
                        }
                        goto Label_0A21;

                    case 0x19:
                        if (!A_0.IsEmptyElement)
                        {
                            this.method_451(A_0);
                        }
                        goto Label_0A21;

                    case 0x1a:
                        this.method_454(A_0);
                        goto Label_0A21;

                    case 0x1b:
                        this.method_453(A_0);
                        goto Label_0A21;

                    case 0x1c:
                        this.method_449(A_0);
                        goto Label_0A21;

                    case 0x1d:
                        this.method_450(A_0);
                        goto Label_0A21;

                    case 30:
                        this.document_0.Settings.bool_27 = this.method_469(A_0);
                        goto Label_0A21;

                    case 0x1f:
                    {
                        string s = A_0.GetAttribute(BookmarkStart.b("䜰刲头", num), this.dictionary_18[BookmarkStart.b("䘰", num)]);
                        if (s != null)
                        {
                            this.document_0.Settings.int_15 = int.Parse(s, NumberStyles.Integer, CultureInfo.InvariantCulture);
                        }
                        goto Label_0A21;
                    }
                    case 0x20:
                    {
                        string str10 = A_0.GetAttribute(BookmarkStart.b("䜰刲头", num), this.dictionary_18[BookmarkStart.b("䘰", num)]);
                        if (str10 != null)
                        {
                            this.document_0.Settings.int_16 = int.Parse(str10, NumberStyles.Integer, CultureInfo.InvariantCulture);
                        }
                        goto Label_0A21;
                    }
                    case 0x21:
                        this.document_0.Settings.bool_28 = !this.method_469(A_0);
                        goto Label_0A21;

                    case 0x22:
                        this.document_0.Settings.bool_41 = this.method_469(A_0);
                        goto Label_0A21;

                    case 0x23:
                        this.document_0.Settings.bool_42 = !this.method_469(A_0);
                        goto Label_0A21;
                }
            }
        }
        this.document_0.DocxProps2010.Add(this.method_484(A_0));
        flag = true;
    Label_0A21:
        if (!flag)
        {
            A_0.Read();
        }
        goto Label_000A;
    }

    private void method_445(XmlReader A_0)
    {
        int num = 15;
        for (int i = 0; i < A_0.AttributeCount; i++)
        {
            A_0.MoveToAttribute(i);
            string localName = A_0.LocalName;
            string attribute = A_0.GetAttribute(localName, this.dictionary_18[BookmarkStart.b("䈴", num)]);
            if (!this.document_0.Settings.method_7().ContainsKey(localName))
            {
                this.document_0.Settings.method_7().Add(localName, attribute);
            }
            else
            {
                this.document_0.Settings.method_7()[localName] = attribute;
            }
        }
    }

    private void method_446(Stream A_0)
    {
        int num = 4;
        A_0.Position = 0L;
        XmlReader reader = Class57.smethod_18(A_0);
        if (reader == null)
        {
            throw new Exception(BookmarkStart.b("堩䤫伭启圱䘳", num));
        }
        while (reader.NodeType != XmlNodeType.Element)
        {
            reader.Read();
        }
        string localName = reader.LocalName;
        if ((reader.LocalName != BookmarkStart.b("天䤫娭䐯嬱娳儵䬷", num)) && (reader.LocalName != BookmarkStart.b("丩䌫䴭䔯弱儳堵䰷", num)))
        {
            throw new XmlException(BookmarkStart.b("缩䈫䬭䠯䈱儳唵䰷弹堻ḽ㠿⽁⡃晅㱇⭉⭋湍", num) + reader.LocalName);
        }
        if (!reader.IsEmptyElement && reader.ReadToNextSibling(BookmarkStart.b("帩䐫䬭崯圱爳夵嘷丹瀻弽⸿╁", num), this.dictionary_18[BookmarkStart.b("崩", num)]))
        {
            this.method_401(reader, this.document_0.ThemeFontLanguage);
        }
    }

    private void method_447(XmlReader A_0)
    {
        int num = 3;
        if (A_0 == null)
        {
            throw new Exception(BookmarkStart.b("嬨个䰬䬮吰䄲", num));
        }
        while (A_0.NodeType != XmlNodeType.Element)
        {
            A_0.Read();
        }
        if (A_0.LocalName != BookmarkStart.b("䨨䐪䀬弮倰䜲", num))
        {
            throw new XmlException(BookmarkStart.b("氨匪崬䨮到䜲倴匶ᤸ䌺值匾慀㝂⑄⁆楈楊⹌⁎㱐⍒㑔⍖筘", num));
        }
        if (!A_0.IsEmptyElement)
        {
            bool flag = false;
            A_0.Read();
            while (A_0.LocalName != BookmarkStart.b("䨨䐪䀬弮倰䜲", num))
            {
                flag = false;
                if (A_0.NodeType != XmlNodeType.Element)
                {
                    goto Label_010B;
                }
                string localName = A_0.LocalName;
                if (localName != null)
                {
                    if (!(localName == BookmarkStart.b("䴨䐪挬䀮䔰昲䘴制焸漺瀼猾ᅀ≂㝄♆⹈㥊ⱌ㽎㥐ቒ⁔⍖㙘࡚ⵜ㹞ɠ੢୤f", num)))
                    {
                        if (!(localName == BookmarkStart.b("䴨䐪挬䀮䔰昲䘴制瀸唺夼娾⽀㝂ф㑆݈㹊⁌ⵎ㑐⅒㱔㥖㹘ཚ㱜㵞㉠ᝢ੤ᝦ", num)))
                        {
                            goto Label_00E6;
                        }
                        this.document_0.Settings.method_5().method_1(CompatibilityOptions.DontUseIndentAsNumberingTabStop, this.method_469(A_0));
                    }
                    else
                    {
                        this.document_0.Settings.method_5().method_72(this.method_469(A_0));
                    }
                    goto Label_00FF;
                }
            Label_00E6:
                this.document_0.DocxPropsCompat2010.Add(this.method_484(A_0));
                flag = true;
            Label_00FF:
                if (!flag)
                {
                    A_0.Read();
                }
                continue;
            Label_010B:
                A_0.Read();
            }
        }
    }

    private bool method_448(XmlReader A_0)
    {
        int num = 2;
        string localName = A_0.LocalName;
        if (localName != null)
        {
            int num2;
            if (Class1160.dictionary_106 == null)
            {
                Dictionary<string, int> dictionary1 = new Dictionary<string, int>(0x42);
                dictionary1.Add(BookmarkStart.b("崧天䤫紭夯就匳娵崷砹医䰽␿❁㙃⁅❇㡉ཋ⅍㹏♑㵓ㅕⵗ㕙⥛ⵝ⍟ݡࡣ੥᭧", num), 0);
                dictionary1.Add(BookmarkStart.b("弧娩昫嬭䌯䘱崳倵儷夹崻䨽⤿ⵁ⩃", num), 1);
                dictionary1.Add(BookmarkStart.b("䘧䔩砫伭刯稱唳堵強猹刻娽", num), 2);
                dictionary1.Add(BookmarkStart.b("䘧䔩怫䬭儯嘱崳堵強", num), 3);
                dictionary1.Add(BookmarkStart.b("嬧娩䴫䴭唯琱嬳䐵洷瘹", num), 4);
                dictionary1.Add(BookmarkStart.b("䘧䔩漫䄭尯䜱夳堵稷嬹倻弽⸿⅁⅃", num), 5);
                dictionary1.Add(BookmarkStart.b("䨧䬩䀫伭帯儱儳攵儷吹嬻刽┿A㵃㉅ⵇ้⍋㭍㉏㹑ㅓᑕ⅗⹙㥛ढ़य़١ၣ๥", num), 6);
                dictionary1.Add(BookmarkStart.b("䘧䔩椫嘭䐯䀱唳稵儷吹夻洽〿⍁❃⽅♇ⵉ", num), 7);
                dictionary1.Add(BookmarkStart.b("䰧䔩戫䄭䐯縱儳圵丷弹縻弽⌿⥁㝃⩅⥇㥉⑋ཌྷ㱏㵑㩓㍕", num), 8);
                dictionary1.Add(BookmarkStart.b("崧䘩砫尭儯嬱堳攵䠷嬹弻嬽", num), 9);
                dictionary1.Add(BookmarkStart.b("䰧䔩戫䄭䐯眱䰳䘵夷吹堻洽⠿⭁≃㉅ᩇ⽉㡋㭍≏㱑", num), 10);
                dictionary1.Add(BookmarkStart.b("嬧娩䴫䴭夯就匳缵嘷洹吻儽ⰿ❁ᑃ⥅ⅇ⑉㡋㵍", num), 11);
                dictionary1.Add(BookmarkStart.b("䐧䌩䈫䬭术䀱唳䘵琷匹圻嬽᜿ⵁ㙃≅繇", num), 12);
                dictionary1.Add(BookmarkStart.b("堧堩䔫䀭䐯瀱嬳刵䄷渹夻䘽㐿A⅃⁅❇㡉⥋ٍ㕏㍑こ㍕⩗", num), 13);
                dictionary1.Add(BookmarkStart.b("堧堩䔫䀭䐯焱嬳娵稷嘹崻崽⬿", num), 14);
                dictionary1.Add(BookmarkStart.b("弧娩缫席儯儱儳愵儷帹䠻嘽", num), 15);
                dictionary1.Add(BookmarkStart.b("嬧䈩䌫夭爯䀱儳圵匷䤹画倽ؿぁ╃⭅ⵇ㥉", num), 0x10);
                dictionary1.Add(BookmarkStart.b("嬧弩丫栭弯就䀳琵䄷椹唻䐽┿", num), 0x11);
                dictionary1.Add(BookmarkStart.b("嬧弩尫席䈯圱䜳䔵稷唹䠻䨽⼿⽁ᝃ㙅⥇⥉╋⁍㝏", num), 0x12);
                dictionary1.Add(BookmarkStart.b("嬧弩尫席䈯圱䜳䔵氷唹䰻洽〿⍁❃⽅♇ⵉ", num), 0x13);
                dictionary1.Add(BookmarkStart.b("嬧弩尫席䈯圱䜳䔵欷䨹崻崽⤿ⱁ⍃݅㱇ṉ⍋㹍὏㑑ѓ㝕㽗㽙", num), 20);
                dictionary1.Add(BookmarkStart.b("嬧弩尫席䈯圱䜳䔵氷唹䰻洽〿⍁❃⽅♇ⵉᭋṍ", num), 0x15);
                dictionary1.Add(BookmarkStart.b("嬧弩尫席䈯圱䜳䔵欷䨹縻堽Ŀ⑁ぃ⍅㩇ᩉ⭋్≏㥑", num), 0x16);
                dictionary1.Add(BookmarkStart.b("嬧崩䴫席爯崱䘳刵崷䠹伻砽ℿ⅁ⵃ⡅⽇ᩉⵋ⥍㕏⅑", num), 0x17);
                dictionary1.Add(BookmarkStart.b("䬧䔩䈫堭累匱崳娵男弹主夽┿݁㝃╅", num), 0x18);
                dictionary1.Add(BookmarkStart.b("尧堩夫䀭匯匱䀳匵縷唹刻䨽࠿❁ⵃⅅ⁇㹉㽋ɍ㥏㥑ㅓŕࡗ汙", num), 0x19);
                dictionary1.Add(BookmarkStart.b("䔧崩缫䌭儯帱堳电夷䨹伻", num), 0x1a);
                dictionary1.Add(BookmarkStart.b("崧天䤫縭䈯嬱娳䈵崷䠹焻嬽㐿ぁⵃ╅㭇", num), 0x1b);
                dictionary1.Add(BookmarkStart.b("䰧䔩戫䄭䐯愱䄳䘵䠷䠹夻䴽㌿ቁ╃㑅⥇ⵉ㹋⽍⁏㩑ᙓ㥕⩗㹙㥛ⱝ፟", num), 0x1c);
                dictionary1.Add(BookmarkStart.b("弧堩䴫席搯䀱唳張吷椹䰻弽⌿❁㝃", num), 0x1d);
                dictionary1.Add(BookmarkStart.b("丧䔩䌫娭帯崱䀳匵琷嬹䔻儽㔿㙁ࡃ⽅⍇⽉ᭋ᥍桏", num), 30);
                dictionary1.Add(BookmarkStart.b("嬧䈩䴫席唯縱唳伵圷伹䠻爽⤿⥁⅃ᅅ὇牉", num), 0x1f);
                dictionary1.Add(BookmarkStart.b("䤧䘩䔫䤭帯昱唳吵吷弹伻氽⼿㕁ك㽅ᩇ╉㭋", num), 0x20);
                dictionary1.Add(BookmarkStart.b("丧䔩師䤭唯䘱砳圵䬷丹栻弽∿́⡃⽅⽇⑉⅋⭍㹏♑", num), 0x21);
                dictionary1.Add(BookmarkStart.b("䤧丩䘫嬭䌯䘱砳張嘷弹琻嬽⤿╁ⱃ㉅Ň⑉ᡋ⽍㉏㹑ㅓ", num), 0x22);
                dictionary1.Add(BookmarkStart.b("䤧弩堫䄭振䈱唳唵崷瘹唻唽┿ᕁ⭃㑅ⱇ獉祋", num), 0x23);
                dictionary1.Add(BookmarkStart.b("䘧䔩缫席儯儱儳搵夷匹伻嬽ిⵁ㍃⍅㩇", num), 0x24);
                dictionary1.Add(BookmarkStart.b("䰧䔩戫䄭䐯朱䜳匵瀷渹焻爽ဿ⍁㙃❅⽇㡉ⵋ㹍㡏ፑ⅓≕㝗ख़ⱛ㽝͟ୡ੣ť", num), 0x25);
                dictionary1.Add(BookmarkStart.b("䐧䬩唫䄭䔯䘱昳圵伷渹崻尽ⰿ❁ፃ⽅ⱇ㹉⑋", num), 0x26);
                dictionary1.Add(BookmarkStart.b("䐧䬩唫䄭䔯䘱怳圵娷嘹夻氽⼿㕁㝃݅㡇⭉㹋㩍", num), 0x27);
                dictionary1.Add(BookmarkStart.b("崧天䤫礭弯䀱倳༵༷瘹唻倽┿A㙃⍅⥇ⅉṋ㭍㱏㝑❓", num), 40);
                dictionary1.Add(BookmarkStart.b("䰧䔩戫䄭䐯瀱䘳匵夷儹欻䰽ℿ㉁㑃⍅ⱇṉⵋⱍ㱏㝑❓", num), 0x29);
                dictionary1.Add(BookmarkStart.b("䰧䔩戫䄭䐯愱娳圵䠷渹医礽㈿⭁⁃ཅ♇ॉ⥋≍㱏", num), 0x2a);
                dictionary1.Add(BookmarkStart.b("嬧伩䀫䬭匯䘱爳娵尷洹唻䨽⠿сⵃ㑅㭇㹉͋㱍ᱏ㍑❓≕᭗㉙㵛ⱝ", num), 0x2b);
                dictionary1.Add(BookmarkStart.b("䤧娩尫䈭䤯瀱䘳匵夷儹唻倽✿၁ㅃ⩅ⵇ㥉", num), 0x2c);
                dictionary1.Add(BookmarkStart.b("䰧䔩戫䄭䐯攱䘳圵䠷渹夻䘽㐿ᕁⵃ㉅⁇ᩉ㥋⁍㍏♑", num), 0x2d);
                dictionary1.Add(BookmarkStart.b("䰧䔩戫䄭䐯朱䜳匵紷嬹伻䨽Ŀㅁⵃ❅♇ࡉ㹋⭍ㅏ㥑ٓ⍕㑗㽙⽛", num), 0x2e);
                dictionary1.Add(BookmarkStart.b("崧天䤫礭弯䀱倳е࠷ਹ฻樽ℿ⁁⡃⍅ᭇ㹉㕋≍㕏Q⅓㩕㵗⥙", num), 0x2f);
                dictionary1.Add(BookmarkStart.b("伧堩䌫夭焯䜱䀳夵帷匹䠻", num), 0x30);
                dictionary1.Add(BookmarkStart.b("崧天䤫怭弯䀱夳圵吷椹䠻䜽ⰿ❁Ƀ⥅㩇ى╋㵍⑏", num), 0x31);
                dictionary1.Add(BookmarkStart.b("䰧䔩戫䄭䐯朱䜳匵焷吹堻嬽⸿㙁Ճ㕅ه㽉⅋ⱍ㕏⁑㵓㡕㽗๙㵛㱝㍟ᙡୣᙥ", num), 50);
                dictionary1.Add(BookmarkStart.b("崧天䤫漭尯䘱缳張嘷䤹医唽㔿แⵃ⡅ⵇࡉ㹋⭍ㅏ㥑ٓ⍕㑗㽙⽛", num), 0x33);
                dictionary1.Add(BookmarkStart.b("䤧䘩䀫䄭䜯愱䐳圵嬷弹猻堽ጿ⍁⥃⍅ᭇ㹉㕋≍㕏᭑㩓ɕ㥗㡙せ㭝", num), 0x34);
                dictionary1.Add(BookmarkStart.b("䰧䔩戫䄭䐯愱䄳䘵䠷䠹夻䴽㌿ୁ⩃≅ⵇ⑉㡋⽍⑏㭑㭓㡕", num), 0x35);
                dictionary1.Add(BookmarkStart.b("䰧䔩戫䄭䐯猱䄳䈵圷尹唻䨽̿ⵁ⩃㕅㱇㡉ⵋ❍㹏㝑こɕ㥗㡙せ㭝፟", num), 0x36);
                dictionary1.Add(BookmarkStart.b("䤧弩堫䄭嘯嬱䀳戵圷簹唻䰽㌿㙁Ƀ⽅ぇ⽉⡋᥍㥏㙑⁓㹕᭗㽙せ㉝", num), 0x37);
                dictionary1.Add(BookmarkStart.b("崧䐩䠫䬭䈯帱崳堵崷渹崻尽िⱁ੃㍅╇ى╋㵍⑏", num), 0x38);
                dictionary1.Add(BookmarkStart.b("䰧䌩弫席尯匱䴳縵夷吹嬻䬽ⰿсⵃ㹅ⵇ⹉ᭋ❍㑏♑㱓", num), 0x39);
                dictionary1.Add(BookmarkStart.b("嬧娩䀫䜭䐯戱匳琵䨷弹崻唽Ŀⱁ⁃ᙅ⥇㡉ⵋ͍ㅏ⁑㽓", num), 0x3a);
                dictionary1.Add(BookmarkStart.b("䰧䔩戫䄭䐯搱儳䐵䰷笹倻圽✿ⱁ݃⍅⑇♉ᭋ❍⑏㩑ݓ♕", num), 0x3b);
                dictionary1.Add(BookmarkStart.b("䰧䔩戫䄭䐯瀱䘳匵夷儹缻儽⸿ㅁぃ㑅⥇⍉≋⭍㑏ᑑ㭓⑕㭗㽙㡛੝şaࡣͥ", num), 60);
                dictionary1.Add(BookmarkStart.b("䰧䔩戫䄭䐯搱儳䐵䰷笹倻圽✿ⱁൃ⡅᱇㉉⹋㙍", num), 0x3d);
                dictionary1.Add(BookmarkStart.b("崧天䤫漭帯䄱崳紵崷䠹刻圽⸿╁ᑃ❅ⅇ㡉㽋", num), 0x3e);
                dictionary1.Add(BookmarkStart.b("䬧䬩伫䘭唯嘱眳夵吷砹崻刽ℿⱁ❃⍅", num), 0x3f);
                dictionary1.Add(BookmarkStart.b("崧天䤫栭甯縱唳伵圷伹䠻", num), 0x40);
                dictionary1.Add(BookmarkStart.b("䬧䔩䄫席儯䘱朳匵䰷丹唻倽✿", num), 0x41);
                Class1160.dictionary_106 = dictionary1;
            }
            if (Class1160.dictionary_106.TryGetValue(localName, out num2))
            {
                switch (num2)
                {
                    case 0:
                        this.document_0.Settings.method_5().method_1(CompatibilityOptions.OrigWordTableRules, this.method_469(A_0));
                        goto Label_0F0A;

                    case 1:
                        this.document_0.Settings.method_5().method_1(CompatibilityOptions.WPJust, this.method_469(A_0));
                        goto Label_0F0A;

                    case 2:
                        this.document_0.Settings.method_5().method_1(CompatibilityOptions.NoTabForInd, this.method_469(A_0));
                        goto Label_0F0A;

                    case 3:
                        this.document_0.Settings.method_5().method_1(CompatibilityOptions.NoExtLeading, this.method_469(A_0));
                        goto Label_0F0A;

                    case 4:
                        this.document_0.Settings.method_5().method_1(CompatibilityOptions.DontMakeSpaceForUL, this.method_469(A_0));
                        goto Label_0F0A;

                    case 5:
                        this.document_0.Settings.method_5().method_1(CompatibilityOptions.NoColumnBalance, this.method_469(A_0));
                        goto Label_0F0A;

                    case 6:
                        this.document_0.Settings.method_5().method_1(CompatibilityOptions.DontBlnSbDbWid, this.method_469(A_0));
                        goto Label_0F0A;

                    case 7:
                        this.document_0.Settings.method_5().method_1(CompatibilityOptions.ExactOnTop, this.method_469(A_0));
                        goto Label_0F0A;

                    case 8:
                        this.document_0.Settings.method_5().method_1(CompatibilityOptions.LeaveBackslashAlone, this.method_469(A_0));
                        goto Label_0F0A;

                    case 9:
                        this.document_0.Settings.method_5().method_1(CompatibilityOptions.DontULTrlSpc, this.method_469(A_0));
                        goto Label_0F0A;

                    case 10:
                        this.document_0.Settings.method_5().method_1(CompatibilityOptions.ExpShRtn, this.method_469(A_0));
                        goto Label_0F0A;

                    case 11:
                        this.document_0.Settings.method_5().method_1(CompatibilityOptions.TruncDxaExpand, this.method_469(A_0));
                        goto Label_0F0A;

                    case 12:
                        this.document_0.Settings.method_5().method_1(CompatibilityOptions.LineWrapLikeWord6, this.method_469(A_0));
                        goto Label_0F0A;

                    case 13:
                        this.document_0.Settings.method_5().method_1(CompatibilityOptions.PrintBodyBeforeHdr, this.method_469(A_0));
                        goto Label_0F0A;

                    case 14:
                        this.document_0.Settings.method_5().method_1(CompatibilityOptions.MapPrintTextColor, this.method_469(A_0));
                        goto Label_0F0A;

                    case 15:
                        this.document_0.Settings.method_5().method_1(CompatibilityOptions.WPSpace, this.method_469(A_0));
                        goto Label_0F0A;

                    case 0x10:
                        this.document_0.Settings.method_5().method_1(CompatibilityOptions.ShowBreaksInFrames, this.method_469(A_0));
                        goto Label_0F0A;

                    case 0x11:
                        this.document_0.Settings.method_5().method_1(CompatibilityOptions.SubOnSize, this.method_469(A_0));
                        goto Label_0F0A;

                    case 0x12:
                        this.document_0.Settings.method_5().method_1(CompatibilityOptions.ExtraAfter, this.method_469(A_0));
                        goto Label_0F0A;

                    case 0x13:
                        this.document_0.Settings.method_5().method_1(CompatibilityOptions.SuppressTopSpacing, this.method_469(A_0));
                        goto Label_0F0A;

                    case 20:
                        this.document_0.Settings.method_5().method_1(CompatibilityOptions.SuppressTopSpacingMac5, this.method_469(A_0));
                        goto Label_0F0A;

                    case 0x15:
                        this.document_0.Settings.method_5().method_1(CompatibilityOptions.F2ptExtLeadingOnly, this.method_469(A_0));
                        goto Label_0F0A;

                    case 0x16:
                        this.document_0.Settings.method_5().method_1(CompatibilityOptions.SuppressSpBfAfterPgBrk, this.method_469(A_0));
                        goto Label_0F0A;

                    case 0x17:
                        this.document_0.Settings.method_5().method_1(CompatibilityOptions.SwapBordersFacingPgs, this.method_469(A_0));
                        goto Label_0F0A;

                    case 0x18:
                        this.document_0.Settings.method_5().method_1(CompatibilityOptions.ConvMailMergeEsc, this.method_469(A_0));
                        goto Label_0F0A;

                    case 0x19:
                        this.document_0.Settings.method_5().method_1(CompatibilityOptions.TruncFontHeight, this.method_469(A_0));
                        goto Label_0F0A;

                    case 0x1a:
                        this.document_0.Settings.method_5().method_1(CompatibilityOptions.MWSmallCaps, this.method_469(A_0));
                        goto Label_0F0A;

                    case 0x1b:
                        this.document_0.Settings.method_5().method_1(CompatibilityOptions.PrintMet, this.method_469(A_0));
                        goto Label_0F0A;

                    case 0x1c:
                        this.document_0.Settings.method_5().method_1(CompatibilityOptions.WW6BorderRules, this.method_469(A_0));
                        goto Label_0F0A;

                    case 0x1d:
                        this.document_0.Settings.method_5().method_1(CompatibilityOptions.WrapTrailSpaces, this.method_469(A_0));
                        goto Label_0F0A;

                    case 30:
                        this.document_0.Settings.method_5().method_1(CompatibilityOptions.FtnLayoutLikeWW8, this.method_469(A_0));
                        goto Label_0F0A;

                    case 0x1f:
                        this.document_0.Settings.method_5().method_1(CompatibilityOptions.SpLayoutLikeWW8, this.method_469(A_0));
                        goto Label_0F0A;

                    case 0x20:
                        this.document_0.Settings.method_5().method_1(CompatibilityOptions.AlignTablesRowByRow, this.method_469(A_0));
                        goto Label_0F0A;

                    case 0x21:
                        this.document_0.Settings.method_5().method_1(CompatibilityOptions.ForgetLastTabAlign, this.method_469(A_0));
                        goto Label_0F0A;

                    case 0x22:
                        this.document_0.Settings.method_5().method_1(CompatibilityOptions.DontAdjustLineHeightInTable, !this.method_469(A_0));
                        goto Label_0F0A;

                    case 0x23:
                        this.document_0.Settings.method_5().method_1(CompatibilityOptions.UseAutospaceForFullWidthAlpha, this.method_469(A_0));
                        goto Label_0F0A;

                    case 0x24:
                        this.document_0.Settings.method_5().method_1(CompatibilityOptions.NoSpaceRaiseLower, this.method_469(A_0));
                        goto Label_0F0A;

                    case 0x25:
                        this.document_0.Settings.method_5().method_1(CompatibilityOptions.DontUseHTMLParagraphAutoSpacing, this.method_469(A_0));
                        goto Label_0F0A;

                    case 0x26:
                        this.document_0.Settings.method_5().method_1(CompatibilityOptions.LayoutRawTableWidth, this.method_469(A_0));
                        goto Label_0F0A;

                    case 0x27:
                        this.document_0.Settings.method_5().method_1(CompatibilityOptions.LayoutTableRowsApart, this.method_469(A_0));
                        goto Label_0F0A;

                    case 40:
                        this.document_0.Settings.method_5().method_1(CompatibilityOptions.UseWord97LineBreakingRules, this.method_469(A_0));
                        goto Label_0F0A;

                    case 0x29:
                        this.document_0.Settings.method_5().method_1(CompatibilityOptions.DontBreakWrappedTables, this.method_469(A_0));
                        goto Label_0F0A;

                    case 0x2a:
                        this.document_0.Settings.method_5().method_1(CompatibilityOptions.DontSnapToGridInCell, this.method_469(A_0));
                        goto Label_0F0A;

                    case 0x2b:
                        this.document_0.Settings.method_5().method_1(CompatibilityOptions.DontAllowFieldEndSelect, this.method_469(A_0));
                        goto Label_0F0A;

                    case 0x2c:
                        this.document_0.Settings.method_5().method_1(CompatibilityOptions.ApplyBreakingRules, this.method_469(A_0));
                        goto Label_0F0A;

                    case 0x2d:
                        this.document_0.Settings.method_5().method_1(CompatibilityOptions.DontWrapTextWithPunct, this.method_469(A_0));
                        goto Label_0F0A;

                    case 0x2e:
                        this.document_0.Settings.method_5().method_1(CompatibilityOptions.DontUseAsianBreakRules, this.method_469(A_0));
                        goto Label_0F0A;

                    case 0x2f:
                        this.document_0.Settings.method_5().method_1(CompatibilityOptions.UseWord2002TableStyleRules, this.method_469(A_0));
                        goto Label_0F0A;

                    case 0x30:
                        this.document_0.Settings.method_5().method_1(CompatibilityOptions.GrowAutoFit, this.method_469(A_0));
                        goto Label_0F0A;

                    case 0x31:
                        this.document_0.Settings.method_5().method_1(CompatibilityOptions.UseNormalStyleForList, this.method_469(A_0));
                        goto Label_0F0A;

                    case 50:
                        this.document_0.Settings.method_5().method_1(CompatibilityOptions.DontUseIndentAsNumberingTabStop, this.method_469(A_0));
                        goto Label_0F0A;

                    case 0x33:
                        this.document_0.Settings.method_5().method_1(CompatibilityOptions.FELineBreak11, this.method_469(A_0));
                        goto Label_0F0A;

                    case 0x34:
                        this.document_0.Settings.method_5().method_1(CompatibilityOptions.AllowSpaceOfSameStyleInTable, this.method_469(A_0));
                        goto Label_0F0A;

                    case 0x35:
                        this.document_0.Settings.method_5().method_1(CompatibilityOptions.WW11IndentRules, this.method_469(A_0));
                        goto Label_0F0A;

                    case 0x36:
                        this.document_0.Settings.method_5().method_1(CompatibilityOptions.DontAutofitConstrainedTables, this.method_469(A_0));
                        goto Label_0F0A;

                    case 0x37:
                        this.document_0.Settings.method_5().method_1(CompatibilityOptions.AutofitLikeWW11, this.method_469(A_0));
                        goto Label_0F0A;

                    case 0x38:
                        this.document_0.Settings.method_5().method_1(CompatibilityOptions.UnderlineTabInNumList, this.method_469(A_0));
                        goto Label_0F0A;

                    case 0x39:
                        this.document_0.Settings.method_5().method_1(CompatibilityOptions.HangulWidthLikeWW11, this.method_469(A_0));
                        goto Label_0F0A;

                    case 0x3a:
                        this.document_0.Settings.method_5().method_1(CompatibilityOptions.SplitPgBreakAndParaMark, this.method_469(A_0));
                        goto Label_0F0A;

                    case 0x3b:
                        this.document_0.Settings.method_5().method_1(CompatibilityOptions.DontVertAlignCellWithSp, this.method_469(A_0));
                        goto Label_0F0A;

                    case 60:
                        this.document_0.Settings.method_5().method_1(CompatibilityOptions.DontBreakConstrainedForcedTables, this.method_469(A_0));
                        goto Label_0F0A;

                    case 0x3d:
                        this.document_0.Settings.method_5().method_1(CompatibilityOptions.DontVertAlignInTxbx, this.method_469(A_0));
                        goto Label_0F0A;

                    case 0x3e:
                        this.document_0.Settings.method_5().method_1(CompatibilityOptions.Word11KerningPairs, this.method_469(A_0));
                        goto Label_0F0A;

                    case 0x3f:
                        this.document_0.Settings.method_5().method_1(CompatibilityOptions.CachedColBalance, this.method_469(A_0));
                        goto Label_0F0A;

                    case 0x40:
                        this.document_0.Settings.method_5().method_1(CompatibilityOptions.UseFELayout, this.method_469(A_0));
                        goto Label_0F0A;

                    case 0x41:
                        this.method_450(A_0);
                        goto Label_0F0A;
                }
            }
        }
        this.document_0.DocxPropsCompat2010.Add(this.method_484(A_0));
        return true;
    Label_0F0A:
        return false;
    }

    private void method_449(XmlReader A_0)
    {
        int num = 0;
        if (A_0 == null)
        {
            throw new Exception(BookmarkStart.b("吥䴧䬩䠫䬭䈯", num));
        }
        while (A_0.NodeType != XmlNodeType.Element)
        {
            A_0.Read();
        }
        if (A_0.LocalName != BookmarkStart.b("䔥䜧䜩尫伭䐯", num))
        {
            throw new XmlException(BookmarkStart.b("挥倧娩䤫䴭䐯圱倳ᘵ䀷圹倻ḽ㐿⍁⍃晅橇⥉⍋⍍⁏㍑⁓瑕", num));
        }
        if (!A_0.IsEmptyElement)
        {
            A_0.Read();
            while (A_0.LocalName != BookmarkStart.b("䔥䜧䜩尫伭䐯", num))
            {
                if (A_0.NodeType == XmlNodeType.Element)
                {
                    if (!this.method_448(A_0))
                    {
                        A_0.Read();
                    }
                }
                else
                {
                    A_0.Read();
                }
            }
        }
    }

    private string method_45(Stream A_0, bool A_1)
    {
        int num = 0x12;
        string str2 = A_1 ? BookmarkStart.b("唷嬹嘻儽㈿с⭃⡅㱇", num) : BookmarkStart.b("唷匹刻儽㈿с⭃⡅㱇", num);
        A_0.Position = 0L;
        XmlReader reader = XmlReader.Create(A_0);
        this.method_247(reader, str2, BookmarkStart.b("夷", num));
        if (!reader.EOF)
        {
            while (reader.Read())
            {
                if (reader.LocalName == BookmarkStart.b("吷嬹䠻圽⸿", num))
                {
                    string attribute = reader.GetAttribute(BookmarkStart.b("䰷䌹䰻嬽☿⍁❃⍅", num));
                    if (attribute != null)
                    {
                        A_0.Position = 0L;
                        return attribute;
                    }
                }
            }
            return null;
        }
        return null;
    }

    private void method_450(XmlReader A_0)
    {
        int num = 11;
        string attribute = A_0.GetAttribute(BookmarkStart.b("弰刲場制", 11), this.dictionary_18[BookmarkStart.b("䘰", 11)]);
        if (attribute != null)
        {
            if (attribute == BookmarkStart.b("帰䔲倴䔶䬸刺夼娾ᕀ≂❄⭆ⱈᡊ㥌㙎㵐㙒ፔ㡖㝘⽚๜㙞᭠٢⑤०൨Ⅺᡬᱮհᩲ፴Ṷ᩸᩺ॼᙾ", num))
            {
                this.document_0.Settings.method_5().method_1(CompatibilityOptions.overrideTableStyleFontSizeAndJustification, this.method_469(A_0));
            }
            else if (attribute == BookmarkStart.b("吰崲吴唶唸帺爼伾⑀ⵂᅄ㹆㥈⹊ୌ⩎ぐ❒⁔╖㱘⡚", num))
            {
                this.document_0.Settings.method_5().method_1(CompatibilityOptions.enableOpenTypeFeatures, this.method_469(A_0));
            }
            else if (attribute == BookmarkStart.b("唰尲笴堶䴸紺儼嘾ㅀโⱄ㕆㭈⑊㽌َ㽐㝒ご㥖ⵘ⡚", num))
            {
                this.document_0.Settings.method_5().method_1(CompatibilityOptions.doNotFlipMirrorIndents, this.method_469(A_0));
            }
            else if (attribute == BookmarkStart.b("唰娲匴儶尸䤺堼儾㕀⩂⑄㍆ⱈي㡌⍎═㩒❔㡖⹘ཚ㱜㵞ൠ٢ⵤɦࡨཪ࡬ᵮ", num))
            {
                this.document_0.Settings.method_5().method_1(CompatibilityOptions.differentiateMultirowTableHeader, this.method_469(A_0));
            }
            else if (attribute == BookmarkStart.b("到尲場䜶堸伺吼崾⡀⽂ⱄ㍆えي≌⭎㑐", num))
            {
                this.document_0.Settings.method_4((byte) this.method_470(A_0, this.document_0.Settings.method_3()));
            }
        }
    }

    private void method_451(XmlReader A_0)
    {
        int num = 0;
        A_0.Read();
        while (true)
        {
            string attribute = A_0.GetAttribute(BookmarkStart.b("䠥䤧䜩䤫", num), this.dictionary_18[BookmarkStart.b("儥", num)]);
            string str2 = A_0.GetAttribute(BookmarkStart.b("倥䤧䘩", num), this.dictionary_18[BookmarkStart.b("儥", num)]);
            if (!string.IsNullOrEmpty(attribute) && !string.IsNullOrEmpty(str2))
            {
                if (!this.document_0.Variables.Items.ContainsKey(attribute))
                {
                    this.document_0.Variables.Items.Add(attribute, this.method_452(str2));
                }
                else
                {
                    this.document_0.Variables.Items[attribute] = this.method_452(str2);
                }
            }
            A_0.Read();
            if (A_0.LocalName == BookmarkStart.b("䈥䜧䤩稫伭䈯䄱", num))
            {
                return;
            }
        }
    }

    private string method_452(string A_0)
    {
        int num4;
        int num = 12;
        StringBuilder builder = new StringBuilder(A_0);
        for (int i = 0; i < A_0.Length; i = num4)
        {
            int index = A_0.IndexOf(BookmarkStart.b("洱䰳", num), i);
            if (index == -1)
            {
                break;
            }
            index += 2;
            num4 = A_0.IndexOf(BookmarkStart.b("洱", num), index);
            if (num4 == -1)
            {
                break;
            }
            int num6 = num4 - index;
            if (num6 == 4)
            {
                int num3;
                string s = A_0.Substring(index, 4);
                if (int.TryParse(s, NumberStyles.HexNumber, CultureInfo.InvariantCulture, out num3))
                {
                    builder.Replace(BookmarkStart.b("洱䰳", num) + s + BookmarkStart.b("洱", num), char.ConvertFromUtf32(num3));
                }
            }
        }
        return builder.ToString();
    }

    private void method_453(XmlReader A_0)
    {
        int num = 0x12;
        string attribute = A_0.GetAttribute(BookmarkStart.b("崷帹唻䨽", 0x12), this.dictionary_18[BookmarkStart.b("伷", 0x12)]);
        switch (attribute)
        {
            case null:
            case string.Empty:
                return;
        }
        string str3 = attribute;
        if (str3 != null)
        {
            if (str3 != BookmarkStart.b("嬷唹儻匽┿ⱁぃ㕅", num))
            {
                if (str3 != BookmarkStart.b("帷唹主匽㌿", num))
                {
                    if (!(str3 == BookmarkStart.b("䰷䠹崻崽⬿❁⁃Յ⁇⭉≋⥍㕏⅑", num)))
                    {
                        if (str3 == BookmarkStart.b("䨷弹崻娽༿ⱁ⡃㽅", num))
                        {
                            this.document_0.ProtectionType = ProtectionType.AllowOnlyReading;
                        }
                    }
                    else
                    {
                        this.document_0.ProtectionType = ProtectionType.AllowOnlyRevisions;
                    }
                }
                else
                {
                    this.document_0.ProtectionType = ProtectionType.AllowOnlyFormFields;
                }
            }
            else
            {
                this.document_0.ProtectionType = ProtectionType.AllowOnlyComments;
            }
        }
        string str2 = A_0.GetAttribute(BookmarkStart.b("崷吹娻儽㈿⅁⅃⭅ⵇ⑉㡋", num), this.dictionary_18[BookmarkStart.b("伷", num)]);
        if (string.IsNullOrEmpty(str2))
        {
            this.document_0.EnforceDocProt = true;
        }
        else
        {
            this.document_0.EnforceDocProt = this.method_110(str2);
        }
        A_0.GetAttribute(BookmarkStart.b("嬷䠹䔻丽㐿ቁ㙃⥅㹇⍉⡋⭍≏ّⵓ♕㵗", num), this.dictionary_18[BookmarkStart.b("伷", num)]);
        A_0.GetAttribute(BookmarkStart.b("嬷䠹䔻丽㐿́⡃ⅅ❇㡉╋㩍㡏㽑ᝓ㩕㥗⥙⽛", num), this.dictionary_18[BookmarkStart.b("伷", num)]);
        A_0.GetAttribute(BookmarkStart.b("嬷䠹䔻丽㐿́⡃ⅅ❇㡉╋㩍㡏㽑S⽕⡗㽙", num), this.dictionary_18[BookmarkStart.b("伷", num)]);
        A_0.GetAttribute(BookmarkStart.b("嬷䠹䔻丽㐿́⡃ⅅ❇㡉╋㩍㡏㽑ݓ㽕㱗", num), this.dictionary_18[BookmarkStart.b("伷", num)]);
        A_0.GetAttribute(BookmarkStart.b("嬷䠹䔻丽㐿ᅁ㑃⽅♇ॉ⍋㭍㹏♑", num), this.dictionary_18[BookmarkStart.b("伷", num)]);
        string str4 = A_0.GetAttribute(BookmarkStart.b("倷嬹伻嘽", num), this.dictionary_18[BookmarkStart.b("伷", num)]);
        string str5 = A_0.GetAttribute(BookmarkStart.b("䬷嬹倻䨽", num), this.dictionary_18[BookmarkStart.b("伷", num)]);
        if (!string.IsNullOrEmpty(str4) && !string.IsNullOrEmpty(str5))
        {
            Convert.FromBase64String(str4);
            Convert.FromBase64String(str5);
        }
    }

    private void method_454(XmlReader A_0)
    {
        string str2;
        int num = 0;
        string attribute = A_0.GetAttribute(BookmarkStart.b("倥䤧䘩", 0), this.dictionary_18[BookmarkStart.b("儥", 0)]);
        if ((attribute != null) && ((str2 = attribute) != null))
        {
            if (str2 == BookmarkStart.b("儥䴧䠩", num))
            {
                this.document_0.ViewSetup.DocumentViewType = DocumentViewType.WebLayout;
            }
            else if (str2 == BookmarkStart.b("䤥崧帩䀫䜭帯圱", num))
            {
                this.document_0.ViewSetup.DocumentViewType = DocumentViewType.OutlineLayout;
            }
        }
    }

    private void method_455(ParagraphBase A_0, ParagraphItemCollection A_1)
    {
        A_1.Add(A_0);
    }

    private void method_456(ParagraphBase A_0, ParagraphItemCollection A_1)
    {
        this.method_455(A_0, A_1);
        this.method_82(A_0);
        if (A_0 is DocOleObject)
        {
            this.method_457(A_0 as DocOleObject, A_1);
        }
    }

    private void method_457(DocOleObject A_0, ParagraphItemCollection A_1)
    {
        FieldMark mark = new FieldMark(this.document_0) {
            Type = FieldMarkType.FieldSeparator
        };
        this.method_456(mark, A_1);
        DocPicture picture = A_0.Interface49.get_OlePicture();
        this.method_456(picture, A_1);
        FieldMark mark2 = new FieldMark(this.document_0) {
            Type = FieldMarkType.FieldEnd
        };
        this.method_456(mark2, A_1);
        if (this.characterFormat_0 != null)
        {
            picture.ApplyCharacterFormat(this.characterFormat_0);
        }
    }

    private void method_458(DocPicture A_0, string A_1, bool A_2, bool A_3)
    {
        string key = this.method_459(A_1, A_2, A_3);
        if (this.method_0().ContainsKey(key))
        {
            A_0.method_86(this.document_0.Images.method_0(this.method_0()[key]));
            Class517 imageRecord = A_0.ImageRecord;
            imageRecord.method_6(imageRecord.method_5() + 1);
        }
        else
        {
            byte[] imageBytes = this.method_460(key);
            if ((imageBytes != null) && (imageBytes.Length > 0))
            {
                A_0.LoadImage(imageBytes);
                this.method_0().Add(key, A_0.ImageRecord.method_0());
            }
            imageBytes = null;
        }
    }

    internal string method_459(string A_0, bool A_1, bool A_2)
    {
        int num = 6;
        string str = string.Empty;
        if (A_1)
        {
            Dictionary<string, DictionaryEntry> dictionary = this.method_466(this.string_3);
            if (dictionary != null)
            {
                DictionaryEntry entry3 = dictionary[A_0];
                str = (string) entry3.Value;
            }
            return str;
        }
        if (A_2)
        {
            Dictionary<string, DictionaryEntry> dictionary3 = this.method_466(BookmarkStart.b("䈫嬭崯倱儳䐵儷吹嬻ွ㠿⽁⡃桅㩇⽉⁋㵍", num));
            if (dictionary3 != null)
            {
                DictionaryEntry entry5 = dictionary3[A_0];
                str = entry5.Value.ToString();
            }
            return str;
        }
        if (this.string_3.StartsWith(BookmarkStart.b("伫䄭崯弱儳堵䰷䤹", num)))
        {
            DictionaryEntry entry4 = this.method_466(BookmarkStart.b("伫䄭崯弱儳堵䰷䤹ሻ䘽ⴿ⹁橃㑅ⵇ♉㽋", num))[A_0];
            return entry4.Value.ToString();
        }
        if (!string.IsNullOrEmpty(this.string_3))
        {
            Dictionary<string, DictionaryEntry> dictionary2 = this.method_466(this.string_3);
            if (dictionary2 != null)
            {
                DictionaryEntry entry = dictionary2[A_0];
                str = entry.Value.ToString();
            }
            return str;
        }
        if (this.dictionary_2 != null)
        {
            DictionaryEntry entry2 = this.dictionary_2[A_0];
            str = entry2.Value.ToString();
        }
        return str;
    }

    private void method_46(Stream A_0)
    {
        int num = 0x13;
        if (this.document_0.Themes == null)
        {
            this.document_0.Themes = new Class324(this.document_0);
        }
        string str6 = BookmarkStart.b("娸场似氾≀⭂⁄⩆ⱈ", num);
        A_0.Position = 0L;
        XmlReader reader = XmlReader.Create(A_0);
        this.method_247(reader, str6, BookmarkStart.b("堸", num));
        if (!reader.EOF)
        {
            reader.Read();
            this.method_485(reader);
            while (reader.NodeType == XmlNodeType.Element)
            {
                if (!(reader.LocalName != BookmarkStart.b("娸场似氾≀⭂⁄⩆ⱈ", num)))
                {
                    break;
                }
                string localName = reader.LocalName;
                reader.Read();
                this.method_485(reader);
                while (reader.NodeType == XmlNodeType.Element)
                {
                    if (!(reader.LocalName != localName))
                    {
                        break;
                    }
                    Class326 class2 = new Class326();
                    string str3 = reader.LocalName;
                    if (str3 != null)
                    {
                        if (str3 != BookmarkStart.b("䨸䈺丼簾ⵀㅂ", num))
                        {
                            if (str3 == BookmarkStart.b("䨸䤺娼崾ɀ⽂㝄", num))
                            {
                                string attribute = reader.GetAttribute(BookmarkStart.b("伸娺儼", num));
                                if (!this.document_0.ColorScheme.ContainsKey(localName))
                                {
                                    this.document_0.ColorScheme.Add(localName, attribute);
                                }
                                class2.method_9(ThemeColorTypes.srgbClr);
                                class2.method_7(localName);
                                class2.method_5(attribute);
                                if (!this.document_0.Themes.method_0().ContainsKey(class2.method_6()))
                                {
                                    this.document_0.Themes.method_0().Add(class2.method_6(), class2);
                                }
                                else
                                {
                                    this.document_0.Themes.method_0()[class2.method_6()] = class2;
                                }
                            }
                        }
                        else
                        {
                            string str5 = reader.GetAttribute(BookmarkStart.b("唸娺丼䬾ɀ⽂㝄", num));
                            string key = reader.GetAttribute(BookmarkStart.b("伸娺儼", num));
                            if (!this.document_0.ColorScheme.ContainsKey(key) && (key != null))
                            {
                                this.document_0.ColorScheme.Add(key, str5);
                            }
                            if (!this.document_0.ColorScheme.ContainsKey(localName))
                            {
                                this.document_0.ColorScheme.Add(localName, str5);
                            }
                            class2.method_9(ThemeColorTypes.sysClr);
                            class2.method_7(localName);
                            class2.method_3(key);
                            class2.method_5(str5);
                            if (!this.document_0.Themes.method_0().ContainsKey(class2.method_2()))
                            {
                                this.document_0.Themes.method_0().Add(class2.method_2(), class2);
                            }
                            else
                            {
                                this.document_0.Themes.method_0()[class2.method_2()] = class2;
                            }
                        }
                    }
                    reader.Read();
                    this.method_485(reader);
                }
                reader.Read();
                this.method_485(reader);
            }
        }
    }

    internal byte[] method_460(string A_0)
    {
        int num = 12;
        string str2 = (A_0.LastIndexOf(BookmarkStart.b("弱儳刵儷嬹ጻ", 12)) > 0) ? A_0.Substring(A_0.LastIndexOf(BookmarkStart.b("弱儳刵儷嬹ጻ", num))) : A_0;
        string str = str2.StartsWith(BookmarkStart.b("ᴱ", num)) ? str2.Replace(BookmarkStart.b("ᴱ夳匵尷匹崻ᄽ", num), string.Empty) : str2.Replace(BookmarkStart.b("弱儳刵儷嬹ጻ", num), string.Empty);
        Class229 class2 = this.method_465(BookmarkStart.b("䔱嬳䐵尷ᔹ儻嬽␿⭁╃楅", num), str);
        byte[] buffer = null;
        if (class2 == null)
        {
            class2 = this.method_465(BookmarkStart.b("弱儳刵儷嬹ጻ", num), str);
            if (class2 != null)
            {
                buffer = this.method_464(class2);
                class2 = null;
                this.method_38(str, BookmarkStart.b("弱儳刵儷嬹ጻ", num));
            }
            return buffer;
        }
        buffer = this.method_464(class2);
        class2 = null;
        this.method_38(str, BookmarkStart.b("䔱嬳䐵尷ᔹ儻嬽␿⭁╃楅", num));
        return buffer;
    }

    internal byte[] method_461(string A_0, string A_1)
    {
        int num = 2;
        A_1 = !A_1.EndsWith(BookmarkStart.b("ܧ", 2)) ? (A_1 + BookmarkStart.b("ܧ", num)) : A_1;
        string str = (A_0.LastIndexOf(A_1) > 0) ? A_0.Substring(A_0.LastIndexOf(A_1)) : A_0;
        string str2 = str.StartsWith(BookmarkStart.b("ܧ", num)) ? str.Replace(A_1, string.Empty) : str.Replace(A_1, string.Empty);
        byte[] buffer = null;
        string str3 = BookmarkStart.b("弧䔩師䨭Ἧ", num) + A_1;
        Class229 class2 = this.method_465(str3, str2);
        if (class2 == null)
        {
            str3 = A_1;
            class2 = this.method_465(str3, str2);
            if (class2 != null)
            {
                buffer = this.method_464(class2);
                class2 = null;
            }
            return buffer;
        }
        buffer = this.method_464(class2);
        class2 = null;
        return buffer;
    }

    internal byte[] method_462(string A_0)
    {
        return this.method_461(A_0, BookmarkStart.b("䠭弯就䀳䔵᜷", 8));
    }

    private Image method_463(string A_0, bool A_1, bool A_2)
    {
        int num = 1;
        string str = null;
        if (A_1)
        {
            DictionaryEntry entry = this.method_466(this.string_3)[A_0];
            str = (string) entry.Value;
        }
        else if (A_2)
        {
            DictionaryEntry entry2 = this.method_466(BookmarkStart.b("䤦尨䘪伬䨮䌰娲嬴倶᜸䌺值匾潀ㅂ⁄⭆㩈", num))[A_0];
            str = entry2.Value.ToString();
        }
        else
        {
            DictionaryEntry entry3 = this.dictionary_2[A_0];
            str = entry3.Value.ToString();
        }
        Image image = this.method_254(str);
        if (image != null)
        {
            return image;
        }
        return null;
    }

    private byte[] method_464(Class229 A_0)
    {
        if (A_0 != null)
        {
            int length = (int) A_0.method_4().Length;
            byte[] buffer = new byte[length];
            A_0.method_4().Position = 0L;
            A_0.method_4().Read(buffer, 0, length);
            return buffer;
        }
        return null;
    }

    private Class229 method_465(string A_0, string A_1)
    {
        A_1 = A_1.Replace(A_0, string.Empty);
        Class1128 class2 = this.document_0.DocxPackage.method_18(A_0);
        if (class2.method_0().ContainsKey(A_1))
        {
            return class2.method_0()[A_1];
        }
        return null;
    }

    private Dictionary<string, DictionaryEntry> method_466(string A_0)
    {
        int num = 9;
        if (this.method_20().ContainsKey(A_0))
        {
            return this.method_20()[A_0];
        }
        Class1128 class2 = this.document_0.DocxPackage.method_18(BookmarkStart.b("堮帰䄲儴ᠶ", num));
        if (class2.method_2().ContainsKey(BookmarkStart.b("堮帰䄲儴ᠶ昸䤺堼匾㉀求", num) + A_0) && (class2.method_2()[BookmarkStart.b("堮帰䄲儴ᠶ昸䤺堼匾㉀求", num) + A_0].method_4() != null))
        {
            Class230 class3 = class2.method_2()[BookmarkStart.b("堮帰䄲儴ᠶ昸䤺堼匾㉀求", num) + A_0];
            class3.method_4().Position = 0L;
            XmlReader reader = Class57.smethod_18(class3.method_4());
            Dictionary<string, DictionaryEntry> dictionary = new Dictionary<string, DictionaryEntry>();
            this.method_315(reader, dictionary);
            this.method_20().Add(A_0, dictionary);
            return this.method_20()[A_0];
        }
        return null;
    }

    private float method_467(string A_0)
    {
        int num = 0x13;
        if (A_0.StartsWith(BookmarkStart.b("᜸", 0x13)))
        {
            A_0 = BookmarkStart.b("स", num) + A_0;
        }
        if (A_0.EndsWith(BookmarkStart.b("倸唺", num)))
        {
            float num3 = float.Parse(A_0.Replace(BookmarkStart.b("倸唺", num), string.Empty), CultureInfo.InvariantCulture);
            return (float) Class1073.smethod_1().method_1((double) num3, PrintUnits.Inch, PrintUnits.Point);
        }
        if (A_0.EndsWith(BookmarkStart.b("弸强", num)))
        {
            return (float) (((double) float.Parse(A_0.Replace(BookmarkStart.b("弸强", num), string.Empty), CultureInfo.InvariantCulture)) / 65536.0);
        }
        if (A_0.EndsWith(BookmarkStart.b("吸嘺", num)))
        {
            float num6 = float.Parse(A_0.Replace(BookmarkStart.b("吸嘺", num), string.Empty), CultureInfo.InvariantCulture);
            return (float) Class1073.smethod_1().method_1((double) num6, PrintUnits.Millimeter, PrintUnits.Point);
        }
        if (A_0.EndsWith(BookmarkStart.b("娸嘺", num)))
        {
            float num7 = float.Parse(A_0.Replace(BookmarkStart.b("娸嘺", num), string.Empty), CultureInfo.InvariantCulture);
            return (float) Class1073.smethod_1().method_1((double) num7, PrintUnits.Centimeter, PrintUnits.Point);
        }
        if (A_0.EndsWith(BookmarkStart.b("䤸䌺", num)))
        {
            float num4 = float.Parse(A_0.Replace(BookmarkStart.b("䤸䌺", num), string.Empty), CultureInfo.InvariantCulture);
            return (float) Class1073.smethod_1().method_1((double) num4, PrintUnits.Pixel, PrintUnits.Point);
        }
        A_0 = this.method_468(A_0);
        try
        {
            return Convert.ToSingle(A_0, CultureInfo.InvariantCulture);
        }
        catch (Exception)
        {
        }
        return float.Parse(A_0, CultureInfo.InvariantCulture);
    }

    private string method_468(string A_0)
    {
        if (string.IsNullOrEmpty(A_0) || !char.IsLetter(A_0, A_0.Length - 1))
        {
            return A_0;
        }
        StringBuilder builder = new StringBuilder();
        foreach (char ch in A_0)
        {
            if (!char.IsLetter(ch))
            {
                builder.Append(ch);
            }
        }
        return builder.ToString();
    }

    private bool method_469(XmlReader A_0)
    {
        int num = 10;
        bool flag = true;
        if (A_0.AttributeCount > 0)
        {
            string attribute = A_0.GetAttribute(BookmarkStart.b("䘯匱堳", num), this.dictionary_18[BookmarkStart.b("䜯", num)]);
            return (((!(attribute == BookmarkStart.b("/", num)) && !(attribute == BookmarkStart.b("嘯匱堳䔵崷", num))) && !(attribute == BookmarkStart.b("弯吱刳", num))) && flag);
        }
        string str2 = A_0.ReadString();
        return (((!(str2 == BookmarkStart.b("/", num)) && !(str2 == BookmarkStart.b("嘯匱堳䔵崷", num))) && !(str2 == BookmarkStart.b("弯吱刳", num))) && flag);
    }

    private void method_47(Stream A_0)
    {
        int num = 13;
        if (this.document_0.Themes == null)
        {
            this.document_0.Themes = new Class324(this.document_0);
        }
        string str = BookmarkStart.b("唲娴夶䴸栺帼圾⑀⹂⁄", num);
        A_0.Position = 0L;
        XmlReader reader = XmlReader.Create(A_0);
        this.method_247(reader, str, BookmarkStart.b("刲", num));
        if (!reader.EOF)
        {
            bool flag = false;
            reader.Read();
            this.method_485(reader);
            while (reader.NodeType == XmlNodeType.Element)
            {
                if (!(reader.LocalName != BookmarkStart.b("唲娴夶䴸栺帼圾⑀⹂⁄", num)))
                {
                    break;
                }
                flag = false;
                string localName = reader.LocalName;
                string str2 = reader.LocalName;
                if (str2 != null)
                {
                    if (!(str2 == BookmarkStart.b("帲吴崶嘸䤺笼倾⽀㝂", num)))
                    {
                        if (str2 == BookmarkStart.b("帲尴夶嘸䤺笼倾⽀㝂", num))
                        {
                            MemoryStream stream2 = this.method_484(reader);
                            this.method_49(stream2, false);
                            flag = true;
                        }
                    }
                    else
                    {
                        MemoryStream stream = this.method_484(reader);
                        this.method_49(stream, true);
                        flag = true;
                    }
                }
                if (!flag)
                {
                    reader.Read();
                }
                this.method_485(reader);
            }
        }
    }

    private int method_470(XmlReader A_0, int A_1)
    {
        int num = 3;
        int result = A_1;
        if (A_0.AttributeCount > 0)
        {
            string attribute = A_0.GetAttribute(BookmarkStart.b("弨䨪䄬", num), this.dictionary_18[BookmarkStart.b("帨", num)]);
            if (!string.IsNullOrEmpty(attribute))
            {
                int.TryParse(attribute, NumberStyles.Integer, CultureInfo.InvariantCulture, out result);
            }
        }
        return result;
    }

    private bool method_471(XmlReader A_0, string A_1)
    {
        int num = 11;
        bool flag = true;
        if (A_0.AttributeCount <= 0)
        {
            return flag;
        }
        string attribute = A_0.GetAttribute(BookmarkStart.b("䜰刲头", num), A_1);
        return (((!(attribute == BookmarkStart.b("İ", num)) && !(attribute == BookmarkStart.b("地刲头䐶尸", num))) && !(attribute == BookmarkStart.b("帰唲匴", num))) && flag);
    }

    private string method_472(XmlReader A_0)
    {
        string str;
        if (A_0.IsEmptyElement)
        {
            A_0.Read();
            return string.Empty;
        }
        A_0.Read();
        if (A_0.NodeType != XmlNodeType.EndElement)
        {
            str = A_0.Value;
            A_0.Skip();
        }
        else
        {
            str = string.Empty;
        }
        A_0.Skip();
        return str;
    }

    private int method_473(string A_0)
    {
        return int.Parse(A_0.Replace(BookmarkStart.b("ᄱ欳丵࠷ਹ఻฽Ἷ㙁", 12), string.Empty), NumberStyles.Integer, CultureInfo.InvariantCulture);
    }

    private Color method_474(string A_0)
    {
        int num = 0;
        if (string.IsNullOrEmpty(A_0))
        {
            return Color.Empty;
        }
        if (A_0 == BookmarkStart.b("䜥崧帩䌫", num))
        {
            return Color.Black;
        }
        if (A_0.StartsWith(BookmarkStart.b("䀥䄧䘩䀫อ启匱䘳崵崷吹", num)) || A_0.StartsWith(BookmarkStart.b("䀥䄧䘩䀫อ尯嬱匳帵䰷弹刻", num)))
        {
            return this.method_476(A_0);
        }
        Color color = this.method_478(A_0);
        if (color == Color.Empty)
        {
            color = this.method_479(A_0);
        }
        return color;
    }

    private string method_475(Color A_0)
    {
        int num4 = 6;
        if (A_0.IsEmpty)
        {
            return string.Empty;
        }
        return (A_0.R.ToString(BookmarkStart.b("琫ᰭ", num4)) + A_0.G.ToString(BookmarkStart.b("琫ᰭ", num4)) + A_0.B.ToString(BookmarkStart.b("琫ᰭ", num4)));
    }

    private Color method_476(string A_0)
    {
        int num = 5;
        int startIndex = A_0.IndexOf(BookmarkStart.b("̪", 5)) + 1;
        int index = A_0.IndexOf(BookmarkStart.b("Ȫ", 5));
        if ((startIndex != -1) && (index != -1))
        {
            int num4 = int.Parse(A_0.Substring(startIndex, index - startIndex));
            string str = A_0.StartsWith(BookmarkStart.b("䴪䐬䌮崰ጲ儴嘶䬸债堼儾", num)) ? BookmarkStart.b("ᨪ", num) : BookmarkStart.b("ᤪ", num);
            int alpha = int.Parse(BookmarkStart.b("个䬬", num), NumberStyles.HexNumber, CultureInfo.InvariantCulture);
            int red = int.Parse(BookmarkStart.b("䴪ᴬ", num), NumberStyles.HexNumber, CultureInfo.InvariantCulture);
            int green = int.Parse(BookmarkStart.b("ᬪ", num) + str, NumberStyles.HexNumber, CultureInfo.InvariantCulture);
            int blue = int.Parse(num4.ToString(BookmarkStart.b("猪Ἤ", num)), NumberStyles.HexNumber, CultureInfo.InvariantCulture);
            return Color.FromArgb(alpha, red, green, blue);
        }
        return Color.White;
    }

    private bool method_477(string A_0)
    {
        int num = 3;
        bool flag = false;
        A_0 = A_0.Replace(BookmarkStart.b("न", 3), string.Empty);
        int num2 = 0;
        int length = A_0.Length;
        while (num2 < length)
        {
            char ch2 = A_0[num2];
            if (!Regex.IsMatch(ch2.ToString(), BookmarkStart.b("爨ᬪ,ᘮ氰", num)))
            {
                char ch3 = A_0[num2];
                if (!Regex.IsMatch(ch3.ToString(), BookmarkStart.b("爨横,椮氰", num)))
                {
                    char ch = A_0[num2];
                    if (!Regex.IsMatch(ch.ToString(), BookmarkStart.b("爨䨪,䤮氰", num)))
                    {
                        return false;
                    }
                }
            }
            flag = true;
            num2++;
        }
        return flag;
    }

    private Color method_478(string A_0)
    {
        int num = 2;
        A_0 = A_0.Replace(BookmarkStart.b("ଧ", 2), string.Empty);
        if (this.method_477(A_0))
        {
            Color color;
            if (A_0.Length > 6)
            {
                A_0 = A_0.Substring(0, 6);
            }
            else if ((A_0.Length < 6) && (A_0.Length != 3))
            {
                int num3 = 6 - A_0.Length;
                for (int i = 0; i < num3; i++)
                {
                    A_0 = A_0.Insert(0, BookmarkStart.b("ᠧ", num));
                }
            }
            else if (A_0.Length == 3)
            {
                A_0 = A_0.Insert(0, A_0[0].ToString());
                A_0 = A_0.Insert(2, A_0[2].ToString());
                A_0 = A_0.Insert(4, A_0[4].ToString());
            }
            try
            {
                string s = A_0.Substring(0, 2);
                string str2 = A_0.Substring(2, 2);
                string str3 = A_0.Substring(4, 2);
                int red = int.Parse(s, NumberStyles.HexNumber, CultureInfo.InvariantCulture);
                int green = int.Parse(str2, NumberStyles.HexNumber, CultureInfo.InvariantCulture);
                int blue = int.Parse(str3, NumberStyles.HexNumber, CultureInfo.InvariantCulture);
                color = Color.FromArgb(red, green, blue);
            }
            catch (Exception)
            {
                goto Label_013F;
            }
            return color;
        }
    Label_013F:
        return Color.Empty;
    }

    private Color method_479(string A_0)
    {
        int index = A_0.IndexOf(BookmarkStart.b("琮", 9));
        if (index != -1)
        {
            A_0 = A_0.Remove(index, A_0.Length - index);
            A_0 = A_0.Trim();
        }
        try
        {
            return ColorTranslator.FromHtml(A_0);
        }
        catch
        {
        }
        return Color.Empty;
    }

    private void method_48(Stream A_0)
    {
        int num = 3;
        if (this.document_0.Themes == null)
        {
            this.document_0.Themes = new Class324(this.document_0);
        }
        string str = BookmarkStart.b("伨䘪夬簮到嬲倴娶尸", num);
        A_0.Position = 0L;
        XmlReader reader = XmlReader.Create(A_0);
        this.method_247(reader, str, BookmarkStart.b("䠨", num));
        if (!reader.EOF)
        {
            MemoryStream stream = this.method_484(reader);
            if (!this.document_0.Themes.method_3().ContainsKey(str))
            {
                this.document_0.Themes.method_3().Add(str, stream);
            }
            else
            {
                this.document_0.Themes.method_3()[str] = stream;
            }
        }
    }

    private int method_480(string A_0)
    {
        int num = 15;
        if (string.IsNullOrEmpty(A_0))
        {
            return -2147483648;
        }
        if (A_0.EndsWith(BookmarkStart.b("䔴䌶", num)))
        {
            return (int) Math.Round((double) (float.Parse(A_0.Replace(BookmarkStart.b("䔴䌶", num), string.Empty), NumberStyles.Float, CultureInfo.InvariantCulture) * 20f), 0);
        }
        return int.Parse(A_0, NumberStyles.Integer, CultureInfo.InvariantCulture);
    }

    private float method_481(XmlReader A_0, string A_1, string A_2)
    {
        string attribute;
        int num = 0x11;
        if ((A_1 == null) || (A_1.Length == 0))
        {
            throw new ArgumentException(BookmarkStart.b("瘶䴸伺似嘾⍀㙂ㅄ≆楈╊ⱌ≎㑐獒㡔≖⩘⽚絜ㅞ๠ᝢ䕤զ౨䭪ͬᩮᵰὲ啴ᡶ୸孺᡼ቾﲄ", num));
        }
        if (A_2 == null)
        {
            attribute = A_0.GetAttribute(A_1);
        }
        else
        {
            attribute = A_0.GetAttribute(A_1, A_2);
        }
        if (string.IsNullOrEmpty(attribute) && (A_0.AttributeCount > 0))
        {
            attribute = A_0.GetAttribute(A_1);
        }
        if (string.IsNullOrEmpty(attribute))
        {
            return float.MaxValue;
        }
        if (attribute.EndsWith(BookmarkStart.b("䜶䴸", num)))
        {
            return float.Parse(attribute.Replace(BookmarkStart.b("䜶䴸", num), string.Empty), NumberStyles.Float, CultureInfo.InvariantCulture);
        }
        return (float.Parse(attribute, NumberStyles.Float, CultureInfo.InvariantCulture) / 20f);
    }

    internal float method_482(XmlReader A_0, string A_1, string A_2)
    {
        string attribute;
        int num = 9;
        if ((A_1 == null) || (A_1.Length == 0))
        {
            throw new ArgumentException(BookmarkStart.b("渮䔰䜲䜴帶嬸为䤼娾慀ⵂ⑄⩆ⱈ歊⁌㩎≐❒畔㥖㙘⽚絜㵞Ѡ䍢୤ቦըݪ䵬nͰ卲ၴ᩶ॸེѼ", num));
        }
        if (A_2 == null)
        {
            attribute = A_0.GetAttribute(A_1);
        }
        else
        {
            attribute = A_0.GetAttribute(A_1, A_2);
        }
        if (string.IsNullOrEmpty(attribute))
        {
            return float.MaxValue;
        }
        return (float.Parse(attribute, NumberStyles.Float, CultureInfo.InvariantCulture) / 100f);
    }

    private float method_483(XmlReader A_0, string A_1, string A_2)
    {
        string attribute;
        int num = 4;
        if ((A_1 == null) || (A_1.Length == 0))
        {
            throw new ArgumentException(BookmarkStart.b("欩堫娭䈯嬱嘳䌵䰷弹᰻倽ℿ⽁⅃晅╇㽉㽋㩍灏㱑㭓≕硗㡙㥛繝๟ᝡࡣ੥䡧թṫ乭ᕯάѳɵŷ", num));
        }
        if (A_2 == null)
        {
            attribute = A_0.GetAttribute(A_1);
        }
        else
        {
            attribute = A_0.GetAttribute(A_1, A_2);
        }
        if (string.IsNullOrEmpty(attribute))
        {
            return float.MaxValue;
        }
        return (float.Parse(attribute, NumberStyles.Float, CultureInfo.InvariantCulture) / 2f);
    }

    internal MemoryStream method_484(XmlReader A_0)
    {
        MemoryStream stream = new MemoryStream();
        XmlWriter writer = Class57.smethod_19(stream, Encoding.UTF8);
        writer.WriteNode(A_0, false);
        writer.Flush();
        return stream;
    }

    private void method_485(XmlReader A_0)
    {
        if (A_0.NodeType != XmlNodeType.Element)
        {
            while (A_0.NodeType == XmlNodeType.Whitespace)
            {
                A_0.Read();
            }
        }
    }

    private void method_486(XmlReader A_0)
    {
        A_0.Read();
        this.method_485(A_0);
    }

    private void method_487(XmlReader A_0, string A_1, Stack<string> A_2)
    {
        if (((A_0 != null) && !string.IsNullOrEmpty(A_1)) && (A_2 != null))
        {
            while (A_0.LocalName == A_1)
            {
                if (A_0.NodeType == XmlNodeType.Element)
                {
                    A_2.Push(A_0.LocalName);
                    this.method_486(A_0);
                }
                else if ((A_0.NodeType == XmlNodeType.EndElement) && (A_2.Count > 0))
                {
                    A_2.Pop();
                    if (A_2.Count == 0)
                    {
                        return;
                    }
                    this.method_486(A_0);
                }
            }
        }
    }

    private void method_49(Stream A_0, bool A_1)
    {
        int num = 13;
        A_0.Position = 0L;
        XmlReader reader = Class57.smethod_18(A_0);
        if (!reader.EOF)
        {
            string localName = reader.LocalName;
            reader.Read();
            this.method_485(reader);
            while (reader.NodeType == XmlNodeType.Element)
            {
                if (!(reader.LocalName != localName))
                {
                    break;
                }
                Class325 class2 = new Class325();
                if (A_1)
                {
                    class2.method_3(ThemeFontTypes.Major);
                }
                else
                {
                    class2.method_3(ThemeFontTypes.Minor);
                }
                string str2 = reader.LocalName;
                if (str2 != null)
                {
                    if (((str2 != BookmarkStart.b("弲吴䌶倸唺", num)) && (str2 != BookmarkStart.b("嘲吴", num))) && (str2 != BookmarkStart.b("倲䘴", num)))
                    {
                        if (str2 == BookmarkStart.b("唲娴夶䴸", num))
                        {
                            string attribute = reader.GetAttribute(BookmarkStart.b("䜲䰴䜶尸崺尼尾⑀", num));
                            string str = reader.GetAttribute(BookmarkStart.b("䀲嘴䔶倸䬺䤼", num));
                            class2.method_7(attribute);
                            class2.method_5(str);
                            class2.method_1(str);
                            if (A_1)
                            {
                                if (!this.document_0.Themes.method_2().ContainsKey(str))
                                {
                                    this.document_0.Themes.method_2().Add(str, class2);
                                }
                                else
                                {
                                    this.document_0.Themes.method_2()[str] = class2;
                                }
                            }
                            else if (!this.document_0.Themes.method_1().ContainsKey(str))
                            {
                                this.document_0.Themes.method_1().Add(str, class2);
                            }
                            else
                            {
                                this.document_0.Themes.method_1()[str] = class2;
                            }
                        }
                    }
                    else
                    {
                        string str4 = reader.GetAttribute(BookmarkStart.b("䜲䰴䜶尸崺尼尾⑀", num));
                        class2.method_7(str4);
                        class2.method_1(reader.LocalName);
                        if (A_1)
                        {
                            if (!this.document_0.Themes.method_2().ContainsKey(reader.LocalName))
                            {
                                this.document_0.Themes.method_2().Add(reader.LocalName, class2);
                            }
                            else
                            {
                                this.document_0.Themes.method_2()[reader.LocalName] = class2;
                            }
                        }
                        else if (!this.document_0.Themes.method_1().ContainsKey(reader.LocalName))
                        {
                            this.document_0.Themes.method_1().Add(reader.LocalName, class2);
                        }
                        else
                        {
                            this.document_0.Themes.method_1()[reader.LocalName] = class2;
                        }
                    }
                }
                reader.Read();
                this.method_485(reader);
            }
        }
    }

    internal Class822 method_5()
    {
        if (this.class822_0 == null)
        {
            this.class822_0 = new Class822();
        }
        return this.class822_0;
    }

    private void method_50(Class1129 A_0)
    {
        int num = 5;
        Class1128 class2 = A_0.method_18(BookmarkStart.b("伪䈬䰮愰䄲娴䜶䨸ᐺ", 5));
        foreach (string str2 in class2.method_0().Keys)
        {
            Stream stream = class2.method_0()[str2].method_4();
            CustomXmlPart part = new CustomXmlPart {
                Data = Class57.smethod_5(stream)
            };
            this.document_0.CustomXmlParts.Add(part);
            string str = str2;
            if (str != null)
            {
                if (str != BookmarkStart.b("䨪崬弮ἰ䬲場嬶", num))
                {
                    if (!(str == BookmarkStart.b("䠪䈬崮吰ᴲ䴴娶唸", num)))
                    {
                        if (str == BookmarkStart.b("䠪堬尮䔰尲場ᤶ䄸嘺儼", num))
                        {
                            this.xmlReader_0 = Class57.smethod_18(stream);
                            this.method_324(this.xmlReader_0);
                            this.xmlReader_0.Close();
                        }
                    }
                    else
                    {
                        this.xmlReader_0 = Class57.smethod_18(stream);
                        this.method_329(this.xmlReader_0);
                        this.xmlReader_0.Close();
                    }
                }
                else
                {
                    this.xmlReader_0 = Class57.smethod_18(stream);
                    this.method_330(this.xmlReader_0);
                    this.xmlReader_0.Close();
                }
            }
        }
    }

    private void method_51(Stream A_0)
    {
        this.document_0.VbaProject = A_0;
    }

    private void method_52(Stream A_0)
    {
        int num = 7;
        XmlReader reader = Class57.smethod_18(A_0);
        if (reader == null)
        {
            throw new Exception(BookmarkStart.b("弬䨮倰圲倴䔶ᤸ刺丼Ἶ⽀㙂⥄⭆", num));
        }
        while (reader.NodeType != XmlNodeType.Element)
        {
            reader.Read();
        }
        if (reader.LocalName != BookmarkStart.b("嬬䴮倰怲䀴䜶䤸缺尼䬾⁀", num))
        {
            throw new XmlException(BookmarkStart.b("栬圮䄰嘲嘴䌶尸强ᴼ䜾ⱀ⽂敄㍆⡈ⱊ浌济❐ㅒ㑔іⱘ⭚ⵜ᭞`ᝢѤ䕦", num));
        }
        if (!reader.IsEmptyElement)
        {
            this.method_316(reader, BookmarkStart.b("嬬䴮倰怲䀴䜶䤸缺尼䬾⁀", num));
            reader.Read();
            this.method_485(reader);
            while (reader.LocalName != BookmarkStart.b("嬬䴮倰怲䀴䜶䤸缺尼䬾⁀", num))
            {
                string str;
                if ((reader.NodeType == XmlNodeType.Element) && ((str = reader.LocalName) != null))
                {
                    if (!(str == BookmarkStart.b("䀬䰮唰䀲", num)))
                    {
                        if (str == BookmarkStart.b("䤬䀮到瘲䌴制圸伺丼", num))
                        {
                            reader.Read();
                            this.method_54(reader);
                        }
                    }
                    else
                    {
                        reader.Read();
                        this.method_53(reader);
                    }
                }
                reader.Read();
                this.method_485(reader);
            }
            this.method_317();
        }
    }

    private void method_53(XmlReader A_0)
    {
        int num = 5;
        if (A_0 == null)
        {
            throw new Exception(BookmarkStart.b("太䠬丮唰嘲䜴᜶倸䠺ᴼ儾㑀⽂⥄", num));
        }
        while (A_0.NodeType != XmlNodeType.Element)
        {
            A_0.Read();
        }
        if (A_0.LocalName != BookmarkStart.b("䘪丬䬮", num))
        {
            throw new XmlException(BookmarkStart.b("渪唬弮吰倲䄴制崸ᬺ䔼刾ⵀ捂ㅄ♆⹈歊潌≎㉐㝒睔", num));
        }
        this.method_485(A_0);
        while (A_0.LocalName != BookmarkStart.b("䘪丬䬮䈰", num))
        {
            string str;
            if (((A_0.NodeType == XmlNodeType.Element) && ((str = A_0.LocalName) != null)) && (str == BookmarkStart.b("䘪丬䬮", num)))
            {
                Class512 item = new Class512();
                item.method_1(A_0.GetAttribute(BookmarkStart.b("䔪䰬䈮吰", num), this.dictionary_18[BookmarkStart.b("尪䌬䨮", num)]));
                item.method_3(A_0.GetAttribute(BookmarkStart.b("䤪栬䄮到䄲䰴䜶䴸", num), this.dictionary_18[BookmarkStart.b("尪䌬䨮", num)]));
                item.method_5(A_0.GetAttribute(BookmarkStart.b("䠪䀬䠮", num), this.dictionary_18[BookmarkStart.b("尪䌬䨮", num)]));
                this.document_0.VbaData.Add(item);
            }
            A_0.Read();
            this.method_485(A_0);
        }
    }

    private void method_54(XmlReader A_0)
    {
        int num = 15;
        if (A_0 == null)
        {
            throw new Exception(BookmarkStart.b("䜴制堸强堼䴾慀⩂㙄杆❈㹊⅌⍎", num));
        }
        while (A_0.NodeType != XmlNodeType.Element)
        {
            A_0.Read();
        }
        this.method_485(A_0);
        while (A_0.LocalName != BookmarkStart.b("儴堶娸縺䬼娾⽀㝂㙄", num))
        {
            if (A_0.NodeType == XmlNodeType.Element)
            {
                this.document_0.DocEvents.Add(A_0.LocalName);
            }
            A_0.Read();
            this.method_485(A_0);
        }
    }

    private void method_55(Stream A_0)
    {
        int num = 0x12;
        XmlReader reader = Class57.smethod_18(A_0);
        if (reader == null)
        {
            throw new Exception(BookmarkStart.b("䨷弹崻娽┿ぁ摃⽅㭇橉≋㭍㱏㹑", num));
        }
        while (reader.NodeType != XmlNodeType.Element)
        {
            reader.Read();
        }
        if (reader.LocalName != BookmarkStart.b("帷唹刻䨽㌿", num))
        {
            throw new XmlException(BookmarkStart.b("紷䈹䰻嬽⌿㙁⅃≅桇㉉⅋≍灏♑㕓ㅕ硗硙㩛ㅝ๟ᙡᝣ䑥", num));
        }
        if (!reader.IsEmptyElement)
        {
            this.method_316(reader, BookmarkStart.b("帷唹刻䨽㌿", num));
            reader.Read();
            this.method_485(reader);
            while (reader.LocalName != BookmarkStart.b("帷唹刻䨽㌿", num))
            {
                string str;
                if (((reader.NodeType == XmlNodeType.Element) && ((str = reader.LocalName) != null)) && (str == BookmarkStart.b("帷唹刻䨽", num)))
                {
                    string attribute = reader.GetAttribute(BookmarkStart.b("嘷嬹儻嬽", num), this.dictionary_18[BookmarkStart.b("伷", num)]);
                    this.method_56(reader, attribute);
                }
                reader.Read();
                this.method_485(reader);
            }
            this.method_317();
        }
    }

    private void method_56(XmlReader A_0, string A_1)
    {
        int num = 0x12;
        if (A_0 == null)
        {
            throw new Exception(BookmarkStart.b("䨷弹崻娽┿ぁ摃⽅㭇橉≋㭍㱏㹑", num));
        }
        while (A_0.NodeType != XmlNodeType.Element)
        {
            A_0.Read();
        }
        if (A_0.LocalName != BookmarkStart.b("帷唹刻䨽", num))
        {
            throw new XmlException(BookmarkStart.b("紷䈹䰻嬽⌿㙁⅃≅桇㉉⅋≍灏♑㕓ㅕ硗硙㩛ㅝ๟ᙡ䙣", num));
        }
        if (!A_0.IsEmptyElement)
        {
            A_0.Read();
            this.method_485(A_0);
            Form4 form = new Form4(this.document_0, A_1);
            while (A_0.LocalName != BookmarkStart.b("帷唹刻䨽", num))
            {
                string attribute;
                string str4;
                string str10;
                if ((A_0.NodeType == XmlNodeType.Element) && ((str4 = A_0.LocalName) != null))
                {
                    int num2;
                    if (Class1160.dictionary_52 == null)
                    {
                        Dictionary<string, int> dictionary1 = new Dictionary<string, int>(11);
                        dictionary1.Add(BookmarkStart.b("夷嘹䠻瀽ℿ⽁⅃", num), 0);
                        dictionary1.Add(BookmarkStart.b("䠷嬹刻儽㌿❁畃", num), 1);
                        dictionary1.Add(BookmarkStart.b("嬷刹崻䰽㌿❁ぃ", num), 2);
                        dictionary1.Add(BookmarkStart.b("嘷唹䠻樽㈿㝁⅃ቅㅇ㩉⥋", num), 3);
                        dictionary1.Add(BookmarkStart.b("帷嬹儻圽ⰿ㭁", num), 4);
                        dictionary1.Add(BookmarkStart.b("䠷匹䠻崽⠿", num), 5);
                        dictionary1.Add(BookmarkStart.b("䬷匹嬻", num), 6);
                        dictionary1.Add(BookmarkStart.b("崷圹帻嬽␿၁⅃ⅅ㵇♉ⵋ㱍", num), 7);
                        dictionary1.Add(BookmarkStart.b("崷圹帻嬽␿A⭃⩅ⱇ", num), 8);
                        dictionary1.Add(BookmarkStart.b("崷圹帻嬽␿ୁぃ❅⑇⍉⽋", num), 9);
                        dictionary1.Add(BookmarkStart.b("崷圹帻嬽␿A⭃⩅ⱇ͉㡋⽍㱏㭑㝓", num), 10);
                        Class1160.dictionary_52 = dictionary1;
                    }
                    if (Class1160.dictionary_52.TryGetValue(str4, out num2))
                    {
                        switch (num2)
                        {
                            case 0:
                                attribute = A_0.GetAttribute(BookmarkStart.b("丷嬹倻", num), this.dictionary_18[BookmarkStart.b("伷", num)]);
                                form.method_34(attribute);
                                if (!this.document_0.FontSubstitutionTable.ContainsKey(A_1))
                                {
                                    goto Label_0221;
                                }
                                this.document_0.FontSubstitutionTable[A_1] = attribute;
                                break;

                            case 1:
                            {
                                string str2 = A_0.GetAttribute(BookmarkStart.b("丷嬹倻", num), this.dictionary_18[BookmarkStart.b("伷", num)]);
                                form.method_36(new byte[10]);
                                this.method_60(str2, form.method_35(), 0);
                                break;
                            }
                            case 2:
                                str10 = A_0.GetAttribute(BookmarkStart.b("丷嬹倻", num), this.dictionary_18[BookmarkStart.b("伷", num)]);
                                if (string.IsNullOrEmpty(str10))
                                {
                                    goto Label_02C6;
                                }
                                form.method_38(this.method_62(str10));
                                break;

                            case 3:
                            {
                                string str = A_0.GetAttribute(BookmarkStart.b("丷嬹倻", num), this.dictionary_18[BookmarkStart.b("伷", num)]);
                                form.method_44(!this.method_110(str));
                                break;
                            }
                            case 4:
                            {
                                string str5 = A_0.GetAttribute(BookmarkStart.b("丷嬹倻", num), this.dictionary_18[BookmarkStart.b("伷", num)]);
                                form.method_40(this.method_63(str5));
                                break;
                            }
                            case 5:
                            {
                                string str11 = A_0.GetAttribute(BookmarkStart.b("丷嬹倻", num), this.dictionary_18[BookmarkStart.b("伷", num)]);
                                form.method_42(this.method_64(str11));
                                break;
                            }
                            case 6:
                            {
                                form.method_46(new byte[0x18]);
                                string str6 = A_0.GetAttribute(BookmarkStart.b("䴷䤹帻฽", num), this.dictionary_18[BookmarkStart.b("伷", num)]);
                                this.method_61(str6, form.method_45(), 0);
                                string str7 = A_0.GetAttribute(BookmarkStart.b("䴷䤹帻༽", num), this.dictionary_18[BookmarkStart.b("伷", num)]);
                                this.method_61(str7, form.method_45(), 4);
                                string str8 = A_0.GetAttribute(BookmarkStart.b("䴷䤹帻ఽ", num), this.dictionary_18[BookmarkStart.b("伷", num)]);
                                this.method_61(str8, form.method_45(), 8);
                                string str9 = A_0.GetAttribute(BookmarkStart.b("䴷䤹帻ഽ", num), this.dictionary_18[BookmarkStart.b("伷", num)]);
                                this.method_61(str9, form.method_45(), 12);
                                A_0.GetAttribute(BookmarkStart.b("嬷䤹帻฽", num), this.dictionary_18[BookmarkStart.b("伷", num)]);
                                this.method_61(str6, form.method_45(), 0x10);
                                A_0.GetAttribute(BookmarkStart.b("嬷䤹帻༽", num), this.dictionary_18[BookmarkStart.b("伷", num)]);
                                this.method_61(str7, form.method_45(), 20);
                                break;
                            }
                            case 7:
                                this.method_58(A_0, form, EmbeddedFontStyle.Regular);
                                break;

                            case 8:
                                this.method_58(A_0, form, EmbeddedFontStyle.Bold);
                                break;

                            case 9:
                                this.method_58(A_0, form, EmbeddedFontStyle.Italic);
                                break;

                            case 10:
                                this.method_58(A_0, form, EmbeddedFontStyle.BoldItalic);
                                break;
                        }
                    }
                }
                goto Label_054D;
            Label_0221:
                this.document_0.FontSubstitutionTable.Add(A_1, attribute);
                goto Label_054D;
            Label_02C6:
                str10 = A_0.GetAttribute(BookmarkStart.b("嬷刹崻䰽ℿ⅁ぃ⍅㩇᥉⥋㩍", num), this.dictionary_18[BookmarkStart.b("伷", num)]);
                if (!string.IsNullOrEmpty(str10))
                {
                    form.method_38(this.method_57(str10));
                }
            Label_054D:
                A_0.Read();
                this.method_485(A_0);
            }
            this.document_0.FontInfoList.method_11(form);
        }
    }

    private int method_57(string A_0)
    {
        int num = 3;
        A_0 = A_0.ToLower();
        string key = A_0;
        if (key != null)
        {
            int num2;
            if (Class1160.dictionary_53 == null)
            {
                Dictionary<string, int> dictionary1 = new Dictionary<string, int>(0x10);
                dictionary1.Add(BookmarkStart.b("䀨堪䈬Ȯरଲ4ึᐸ਺", num), 0);
                dictionary1.Add(BookmarkStart.b("䐨䨪丬䘮弰䜲娴䐶儸", num), 1);
                dictionary1.Add(BookmarkStart.b("娨䌪䐬䤮䔰氲弴帶䨸", num), 2);
                dictionary1.Add(BookmarkStart.b("䈨堪爬䰮渰ز̴ܶ࠸ᘺ఼ؾ祀瑂", num), 3);
                dictionary1.Add(BookmarkStart.b("䈨堪ബ䰮ᰰز̴ܶ࠸ᘺ఼ؾ础煂", num), 4);
                dictionary1.Add(BookmarkStart.b("丨䤪䘬", num), 5);
                dictionary1.Add(BookmarkStart.b("䬨䈪䨬ᨮ", num), 6);
                dictionary1.Add(BookmarkStart.b("帨䈪䌬䬮帰䐲䘴ᨶ࠸ऺ࠼ా", num), 7);
                dictionary1.Add(BookmarkStart.b("䀨堪䈬Ȯरଲ4ึᐸȺ", num), 8);
                dictionary1.Add(BookmarkStart.b("帨䈪䌬䬮帰䐲䘴ᨶ࠸ऺ࠼ܾ", num), 9);
                dictionary1.Add(BookmarkStart.b("帨䈪䌬䬮帰䐲䘴ᨶ࠸ऺ࠼ਾ", num), 10);
                dictionary1.Add(BookmarkStart.b("帨䈪䌬䬮帰䐲䘴ᨶ࠸ऺ࠼ा", num), 11);
                dictionary1.Add(BookmarkStart.b("帨䈪䌬䬮帰䐲䘴ᨶ࠸ऺ࠼࠾", num), 12);
                dictionary1.Add(BookmarkStart.b("帨䈪䌬䬮帰䐲䘴ᨶ࠸ऺ࠼฾", num), 13);
                dictionary1.Add(BookmarkStart.b("帨䈪䌬䬮帰䐲䘴ᨶĸ఺़", num), 14);
                dictionary1.Add(BookmarkStart.b("帨䈪䌬䬮帰䐲䘴ᨶ࠸ऺ࠼༾", num), 15);
                Class1160.dictionary_53 = dictionary1;
            }
            if (Class1160.dictionary_53.TryGetValue(key, out num2))
            {
                switch (num2)
                {
                    case 0:
                        return 0;

                    case 1:
                        return 0x4d;

                    case 2:
                        return 0x80;

                    case 3:
                        return 0x81;

                    case 4:
                        return 130;

                    case 5:
                        return 0x86;

                    case 6:
                        return 0x88;

                    case 7:
                        return 0xa1;

                    case 8:
                        return 0xa2;

                    case 9:
                        return 0xa3;

                    case 10:
                        return 0xb1;

                    case 11:
                        return 0xb2;

                    case 12:
                        return 0xba;

                    case 13:
                        return 0xcc;

                    case 14:
                        return 0xde;

                    case 15:
                        return 0xee;
                }
            }
        }
        return 1;
    }

    private void method_58(XmlReader A_0, Form4 A_1, EmbeddedFontStyle A_2)
    {
        int num = 5;
        string attribute = A_0.GetAttribute(BookmarkStart.b("䈪䤬", 5), this.dictionary_18[BookmarkStart.b("太", 5)]);
        if (!string.IsNullOrEmpty(attribute))
        {
            this.string_3 = BookmarkStart.b("䴪䈬䄮䔰朲吴唶唸帺ጼ䜾ⱀ⽂歄㕆ⱈ❊㹌", num);
        }
        string str2 = A_0.GetAttribute(BookmarkStart.b("䴪䈬䄮䔰砲倴丶", num), this.dictionary_18[BookmarkStart.b("尪", num)]);
        string str3 = A_0.GetAttribute(BookmarkStart.b("堪堬䴮䈰嘲䄴䌶尸强", num), this.dictionary_18[BookmarkStart.b("尪", num)]);
        bool flag = !string.IsNullOrEmpty(str3) ? this.method_110(str3) : false;
        byte[] buffer = this.method_59(attribute);
        if (!string.IsNullOrEmpty(str2))
        {
            Class492.smethod_1(buffer, str2);
        }
        A_1.method_56(buffer, EmbeddedFontFormat.OpenType, A_2, flag);
        if (!string.IsNullOrEmpty(attribute))
        {
            this.string_3 = string.Empty;
        }
    }

    private byte[] method_59(string A_0)
    {
        string str = this.method_459(A_0, false, false);
        if (!string.IsNullOrEmpty(str))
        {
            return this.method_462(str);
        }
        return null;
    }

    private Stack<int> method_6()
    {
        if (this.stack_3 == null)
        {
            this.stack_3 = new Stack<int>();
        }
        return this.stack_3;
    }

    private void method_60(string A_0, byte[] A_1, int A_2)
    {
        for (int i = 0; i < A_0.Length; i += 2)
        {
            A_1[A_2++] = (byte) this.method_62(A_0.Substring(i, 2));
        }
    }

    private void method_61(string A_0, byte[] A_1, int A_2)
    {
        A_2 = (A_2 + (A_0.Length / 2)) - 1;
        for (int i = 0; i < A_0.Length; i += 2)
        {
            A_1[A_2--] = (byte) this.method_62(A_0.Substring(i, 2));
        }
    }

    private int method_62(string A_0)
    {
        return int.Parse(A_0, NumberStyles.HexNumber, CultureInfo.InvariantCulture);
    }

    private FontFamily method_63(string A_0)
    {
        int num = 14;
        string str = A_0;
        if (str != null)
        {
            if (str == BookmarkStart.b("瀳匵嬷唹主弽㐿⭁㉃⍅", num))
            {
                return FontFamily.Decorative;
            }
            if (str == BookmarkStart.b("礳夵尷弹主倽", num))
            {
                return FontFamily.Modern;
            }
            if (str == BookmarkStart.b("昳夵唷嬹刻", num))
            {
                return FontFamily.Roman;
            }
            if (str == BookmarkStart.b("朳唵䨷匹䰻䨽", num))
            {
                return FontFamily.Script;
            }
            if (str == BookmarkStart.b("朳䄵儷䤹伻", num))
            {
                return FontFamily.Swiss;
            }
        }
        return FontFamily.Auto;
    }

    private FontPitch method_64(string A_0)
    {
        int num = 15;
        string str = A_0;
        if (str != null)
        {
            if (str == BookmarkStart.b("匴帶䄸帺夼", num))
            {
                return FontPitch.Fixed;
            }
            if (str == BookmarkStart.b("䌴嘶䬸刺尼崾ⵀ♂", num))
            {
                return FontPitch.Variable;
            }
        }
        return FontPitch.Default;
    }

    private void method_65(XmlReader A_0)
    {
        int num = 3;
        if ((A_0 != null) && !string.IsNullOrEmpty(this.string_6))
        {
            for (int i = 0; i < A_0.AttributeCount; i++)
            {
                A_0.MoveToAttribute(i);
                if ((A_0.Prefix == BookmarkStart.b("儨䘪䄬䄮䈰", num)) || (A_0.LocalName == BookmarkStart.b("尨太䐬", num)))
                {
                    this.document_0.DocxNameSpace.method_4(this.string_6, A_0.LocalName, A_0.Value);
                }
            }
        }
    }

    private void method_66(Stream A_0)
    {
        int num = 13;
        XmlReader reader = Class57.smethod_18(A_0);
        if (reader == null)
        {
            throw new Exception(BookmarkStart.b("䄲倴嘶崸帺似", num));
        }
        while (reader.NodeType != XmlNodeType.Element)
        {
            reader.Read();
        }
        if (reader.LocalName != BookmarkStart.b("圲娴吶䰸嘺堼儾㕀", num))
        {
            throw new XmlException(BookmarkStart.b("昲嬴制䄸䬺堼尾㕀♂⅄杆ㅈ♊⅌潎═㉒㉔睖", num) + reader.LocalName);
        }
        if (!reader.IsEmptyElement)
        {
            this.method_316(reader, BookmarkStart.b("圲娴吶䰸嘺堼儾㕀", num));
            this.bool_12 = this.method_67(reader);
            string localName = reader.LocalName;
            bool flag = false;
            bool flag2 = true;
            reader.Read();
            this.method_485(reader);
            while (reader.LocalName != localName)
            {
                if (reader.EOF)
                {
                    break;
                }
                flag = false;
                if (reader.NodeType == XmlNodeType.Element)
                {
                    string str2 = reader.LocalName;
                    if (str2 != null)
                    {
                        if (str2 != BookmarkStart.b("儲吴吶券尺似倾㑀ⵂ⅄", num))
                        {
                            if (str2 == BookmarkStart.b("儲娴匶䀸", num))
                            {
                                if (flag2)
                                {
                                    this.document_0.AddSection();
                                    flag2 = false;
                                }
                                this.method_68(reader, null);
                            }
                        }
                        else
                        {
                            this.method_295(reader);
                            flag = true;
                        }
                    }
                    if (!flag)
                    {
                        reader.Read();
                    }
                }
                else
                {
                    reader.Read();
                }
                this.method_485(reader);
            }
            this.method_317();
        }
    }

    private bool method_67(XmlReader A_0)
    {
        int num = 0x12;
        if (!this.dictionary_18.ContainsKey(BookmarkStart.b("䀷圹倻", 0x12)))
        {
            this.dictionary_18.Add(BookmarkStart.b("䀷圹倻", num), BookmarkStart.b("倷丹䠻丽稿流歃ㅅ㽇㵉手㥍捏籑㭓⑕㽗留ћ፝ⱟ䵡啣彥內剩䍫mᅯάᅳյࡷ᭹ύ᭽", num));
        }
        string attribute = A_0.GetAttribute(BookmarkStart.b("䬷䨹崻崽┿", num), this.dictionary_18[BookmarkStart.b("䀷圹倻", num)]);
        if (!string.IsNullOrEmpty(attribute) && (attribute == BookmarkStart.b("䠷䠹夻䴽┿ぁ㉃⍅", num)))
        {
            return false;
        }
        return true;
    }

    private void method_68(XmlReader A_0, IDocumentObject A_1)
    {
        int num = 0x12;
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("䨷弹崻娽┿ぁ", num));
        }
        while (A_0.NodeType != XmlNodeType.Element)
        {
            A_0.Read();
        }
        if (!A_0.IsEmptyElement)
        {
            string localName = A_0.LocalName;
            bool flag2 = false;
            bool flag3 = false;
            this.method_486(A_0);
            Stack<string> stack = new Stack<string>();
            stack.Push(A_0.LocalName);
            this.method_487(A_0, localName, stack);
            while (A_0.LocalName != localName)
            {
                ITable table;
                if (A_0.EOF)
                {
                    break;
                }
                if (A_0.NodeType != XmlNodeType.Element)
                {
                    goto Label_061C;
                }
                bool flag = false;
                string key = A_0.LocalName;
                if (key != null)
                {
                    int num2;
                    if (Class1160.dictionary_54 == null)
                    {
                        Dictionary<string, int> dictionary1 = new Dictionary<string, int>(14);
                        dictionary1.Add(BookmarkStart.b("䠷", num), 0);
                        dictionary1.Add(BookmarkStart.b("䰷堹倻", num), 1);
                        dictionary1.Add(BookmarkStart.b("䬷弹弻䨽ဿぁ", num), 2);
                        dictionary1.Add(BookmarkStart.b("娷唹医唽ⴿ⍁㙃ⵅᭇ㹉ⵋ㱍⑏", num), 3);
                        dictionary1.Add(BookmarkStart.b("娷唹医唽ⴿ⍁㙃ⵅേ⑉⡋", num), 4);
                        dictionary1.Add(BookmarkStart.b("䠷弹主匽ጿ㙁╃㑅㱇", num), 5);
                        dictionary1.Add(BookmarkStart.b("䠷弹主匽Կⱁ⁃", num), 6);
                        dictionary1.Add(BookmarkStart.b("嬷唹儻匽┿ⱁぃ", num), 7);
                        dictionary1.Add(BookmarkStart.b("嬷唹儻匽┿ⱁぃᑅ⥇⑉⭋⭍͏♑㕓⑕ⱗ", num), 8);
                        dictionary1.Add(BookmarkStart.b("嬷唹儻匽┿ⱁぃᑅ⥇⑉⭋⭍ᕏ㱑こ", num), 9);
                        dictionary1.Add(BookmarkStart.b("䬷帹䠻", num), 10);
                        dictionary1.Add(BookmarkStart.b("夷嘹䠻紽⠿㝁⩃ⵅ", num), 11);
                        dictionary1.Add(BookmarkStart.b("娷䠹", num), 12);
                        dictionary1.Add(BookmarkStart.b("嬷䠹", num), 13);
                        Class1160.dictionary_54 = dictionary1;
                    }
                    if (Class1160.dictionary_54.TryGetValue(key, out num2))
                    {
                        switch (num2)
                        {
                            case 0:
                                goto Label_0206;

                            case 1:
                                goto Label_049E;

                            case 2:
                                this.method_423(A_0, this.document_0.LastSection);
                                break;

                            case 3:
                                this.method_139(A_0, null);
                                break;

                            case 4:
                                this.method_135(A_0, A_1);
                                break;

                            case 5:
                                this.method_140(A_0, null);
                                break;

                            case 6:
                                this.method_141(A_0, A_1);
                                break;

                            case 7:
                                this.method_76(A_0);
                                break;

                            case 8:
                                this.method_80(A_0, null);
                                break;

                            case 9:
                                this.method_81(A_0, null);
                                break;

                            case 10:
                            {
                                IStructureDocument document = this.method_297(A_1);
                                this.method_300(A_0, document as StructureDocumentTag);
                                break;
                            }
                            case 11:
                                if (!(A_1 is StructureDocumentTag))
                                {
                                    goto Label_05FD;
                                }
                                this.method_301(A_0, (A_1 as StructureDocumentTag).ChildObjects);
                                break;

                            case 12:
                            case 13:
                                this.method_286(A_0, null);
                                break;
                        }
                    }
                }
                goto Label_060F;
            Label_0206:
                if (A_1 is Comment)
                {
                    string attribute = A_0.GetAttribute(BookmarkStart.b("䠷嬹主弽ि♁", num), this.dictionary_18[BookmarkStart.b("伷ହ࠻", num)]);
                    if (!string.IsNullOrEmpty(attribute) && !this.method_2().ContainsKey(attribute))
                    {
                        this.method_2().Add(attribute, A_1 as Comment);
                    }
                    string str = A_0.GetAttribute(BookmarkStart.b("䰷弹䐻䨽ि♁", num), this.dictionary_18[BookmarkStart.b("伷ହ࠻", num)]);
                    if (!string.IsNullOrEmpty(str) && !this.method_3().ContainsKey(str))
                    {
                        this.method_3().Add(str, A_1 as Comment);
                    }
                }
                IParagraph paragraph = this.method_69(A_1);
                if (this.document_0.Styles.DefaultParaStyle != null)
                {
                    (paragraph as Paragraph).method_65(this.document_0.Styles.DefaultParaStyle);
                }
                Field field = this.method_9();
                if ((field != null) && field.Range.method_8().Contains(paragraph))
                {
                    flag = true;
                }
                this.method_70(paragraph);
                this.method_71(paragraph);
                this.method_73(paragraph);
                this.method_287(paragraph.Items);
                this.method_74(A_0, paragraph.Items);
                if (((field != null) && field.IsFieldRange) && flag)
                {
                    field.IsFieldRange = false;
                }
                if (!string.IsNullOrEmpty(paragraph.StyleName))
                {
                    paragraph.ApplyStyle(paragraph.StyleName);
                }
                Section section = (paragraph as Paragraph).method_49();
                if ((((paragraph.Items == null) || (paragraph.Items.Count <= 0)) || ((paragraph.Owner is HeaderFooter) || !(paragraph.Owner is Body))) || (!(paragraph.Owner.Owner is Section) || (section == this.document_0.LastSection)))
                {
                    goto Label_0454;
                }
                for (int i = 0; i < paragraph.Items.Count; i++)
                {
                    if ((paragraph.Items[i] is Break) && ((paragraph.Items[i] as Break).BreakType != BreakType.LineBreak))
                    {
                        goto Label_0429;
                    }
                }
                goto Label_060F;
            Label_0429:
                if (paragraph.Items.Count == 0)
                {
                    (paragraph.Owner as Body).ChildObjects.Remove(paragraph);
                }
                goto Label_060F;
            Label_0454:
                if ((section != this.document_0.LastSection) && (paragraph.Owner is SDTContent))
                {
                    if (flag3)
                    {
                        this.document_0.LastSection.Body.ChildObjects.Add(paragraph);
                    }
                    flag3 = true;
                }
                goto Label_060F;
            Label_049E:
                table = this.method_127(A_1);
                field = this.method_9();
                if ((field != null) && field.Range.method_8().Contains(table))
                {
                    flag = true;
                }
                this.method_83(A_0, table as Table);
                if (((field != null) && field.IsFieldRange) && flag)
                {
                    field.IsFieldRange = false;
                }
                if (table.Rows.Count <= 0)
                {
                    this.method_128(A_1, table);
                }
                else if (((table as Table).method_55() != this.document_0.LastSection) && (table.Owner is SDTContent))
                {
                    if (flag3)
                    {
                        this.document_0.LastSection.Body.ChildObjects.Add(table);
                    }
                    flag3 = true;
                }
                goto Label_060F;
            Label_05FD:
                this.method_301(A_0, null);
            Label_060F:
                if (!flag2)
                {
                    A_0.Read();
                }
                goto Label_0623;
            Label_061C:
                A_0.Read();
            Label_0623:
                this.method_485(A_0);
                this.method_487(A_0, localName, stack);
            }
            stack = null;
        }
    }

    private IParagraph method_69(IDocumentObject A_0)
    {
        IParagraph paragraph = null;
        if (A_0 is HeaderFooter)
        {
            paragraph = (A_0 as HeaderFooter).AddParagraph();
        }
        else if (A_0 is Footnote)
        {
            paragraph = (A_0 as Footnote).TextBody.AddParagraph();
        }
        else if (A_0 is Comment)
        {
            paragraph = (A_0 as Comment).Body.AddParagraph();
        }
        else if (A_0 is StructureDocumentTag)
        {
            paragraph = (A_0 as StructureDocumentTag).SDTContent.AddParagraph();
        }
        else
        {
            paragraph = this.document_0.LastSection.AddParagraph();
        }
        if ((this.method_9() != null) && !this.method_9().IsFieldRange)
        {
            this.method_9().IsFieldRange = true;
            this.method_129(paragraph as Paragraph);
        }
        return paragraph;
    }

    private Comment method_7()
    {
        if ((this.stack_2 != null) && (this.stack_2.Count > 0))
        {
            return this.stack_2.Peek();
        }
        return null;
    }

    private void method_70(IParagraph A_0)
    {
        if (this.dictionary_11.Count > 0)
        {
            foreach (KeyValuePair<string, BookmarkStart> pair in this.dictionary_11)
            {
                A_0.Items.Add(pair.Value);
            }
            this.dictionary_11.Clear();
        }
        if (((this.list_3.Count > 0) && (A_0.Owner != null)) && !(A_0.Owner.Owner is Comment))
        {
            for (int i = 0; i < this.list_3.Count; i++)
            {
                A_0.Items.Add(this.list_3[i]);
            }
            if ((this.stack_2 != null) && (this.stack_2.Count > 0))
            {
                this.stack_2.Pop();
            }
            this.list_3.Clear();
        }
    }

    private void method_71(IParagraph A_0)
    {
        if (this.dictionary_12.Count > 0)
        {
            foreach (KeyValuePair<string, PermissionStart> pair in this.dictionary_12)
            {
                A_0.Items.Add(pair.Value);
            }
            this.dictionary_12.Clear();
        }
    }

    private void method_72(IParagraph A_0)
    {
        if (this.dictionary_13.Count > 0)
        {
            foreach (KeyValuePair<string, PermissionEnd> pair in this.dictionary_13)
            {
                A_0.Items.Add(pair.Value);
            }
            this.dictionary_13.Clear();
        }
    }

    private void method_73(IParagraph A_0)
    {
        foreach (string str in this.list_5)
        {
            if (this.method_19().ContainsKey(str))
            {
                this.method_136(str, A_0.Items);
            }
        }
        this.list_5.Clear();
    }

    private void method_74(XmlReader A_0, ParagraphItemCollection A_1)
    {
        int num = 10;
        while (A_0.NodeType != XmlNodeType.Element)
        {
            A_0.Read();
        }
        if (!A_0.IsEmptyElement)
        {
            bool flag = false;
            string localName = A_0.LocalName;
            A_0.Read();
            MemoryStream stream2 = null;
            this.method_485(A_0);
            while (A_0.LocalName != localName)
            {
                IStructureDocument document;
                Paragraph owner;
                if (A_0.EOF)
                {
                    break;
                }
                flag = false;
                if (A_0.NodeType != XmlNodeType.Element)
                {
                    goto Label_05A2;
                }
                string key = A_0.LocalName;
                if (key != null)
                {
                    int num2;
                    if (Class1160.dictionary_55 == null)
                    {
                        Dictionary<string, int> dictionary1 = new Dictionary<string, int>(0x12);
                        dictionary1.Add(BookmarkStart.b("䀯戱䘳", num), 0);
                        dictionary1.Add(BookmarkStart.b("䈯䜱嘳伵", num), 1);
                        dictionary1.Add(BookmarkStart.b("䈯", num), 2);
                        dictionary1.Add(BookmarkStart.b("刯崱嬳崵唷嬹主唽ጿ㙁╃㑅㱇", num), 3);
                        dictionary1.Add(BookmarkStart.b("刯崱嬳崵唷嬹主唽Կⱁ⁃", num), 4);
                        dictionary1.Add(BookmarkStart.b("䀯圱䘳嬵欷丹崻䰽㐿", num), 5);
                        dictionary1.Add(BookmarkStart.b("䀯圱䘳嬵紷吹堻", num), 6);
                        dictionary1.Add(BookmarkStart.b("匯崱夳嬵崷吹䠻氽ℿⱁ⍃⍅ᭇ㹉ⵋ㱍⑏", num), 7);
                        dictionary1.Add(BookmarkStart.b("匯崱夳嬵崷吹䠻氽ℿⱁ⍃⍅േ⑉⡋", num), 8);
                        dictionary1.Add(BookmarkStart.b("启圱堳", num), 9);
                        dictionary1.Add(BookmarkStart.b("夯就䜳", num), 10);
                        dictionary1.Add(BookmarkStart.b("堯䬱䐳匵䨷嘹唻倽⬿", num), 11);
                        dictionary1.Add(BookmarkStart.b("嘯帱倳攵儷圹䰻刽┿", num), 12);
                        dictionary1.Add(BookmarkStart.b("启䀱唳䄵儷吹嬻", num), 13);
                        dictionary1.Add(BookmarkStart.b("䌯嘱䀳", num), 14);
                        dictionary1.Add(BookmarkStart.b("弯缱唳䈵倷樹崻䰽ℿ", num), 15);
                        dictionary1.Add(BookmarkStart.b("弯缱唳䈵倷", num), 0x10);
                        dictionary1.Add(BookmarkStart.b("䀯嬱圳䈵", num), 0x11);
                        Class1160.dictionary_55 = dictionary1;
                    }
                    if (Class1160.dictionary_55.TryGetValue(key, out num2))
                    {
                        switch (num2)
                        {
                            case 0:
                                goto Label_023A;

                            case 1:
                            {
                                Class2 class3 = this.method_147(A_0, A_1);
                                this.method_456(class3, A_1);
                                break;
                            }
                            case 2:
                                this.method_145(A_0, A_1);
                                this.characterFormat_0 = null;
                                break;

                            case 3:
                                this.method_139(A_0, A_1);
                                break;

                            case 4:
                                this.method_134(A_0, A_1);
                                break;

                            case 5:
                                this.method_140(A_0, A_1);
                                break;

                            case 6:
                                this.method_142(A_0, A_1);
                                break;

                            case 7:
                                this.method_80(A_0, A_1);
                                break;

                            case 8:
                                this.method_81(A_0, A_1);
                                break;

                            case 9:
                                goto Label_035C;

                            case 10:
                                goto Label_0418;

                            case 11:
                                this.method_130(A_0, A_1);
                                break;

                            case 12:
                                flag = this.method_133(A_0, A_1);
                                break;

                            case 13:
                            {
                                ParagraphBase entity = this.method_248(A_0, A_1, ref stream2);
                                A_1.Add(entity);
                                this.characterFormat_0 = null;
                                flag = true;
                                break;
                            }
                            case 14:
                                goto Label_0510;

                            case 15:
                            case 0x10:
                            {
                                Class6 class2 = new Class6(this.method_484(A_0), this.document_0);
                                A_1.Add(class2);
                                flag = true;
                                break;
                            }
                            case 0x11:
                            {
                                ParagraphBase base2 = this.method_187(A_0, A_1, stream2, null);
                                A_1.Add(base2);
                                flag = true;
                                break;
                            }
                        }
                    }
                }
                goto Label_0595;
            Label_023A:
                owner = A_1.OwnerBase as Paragraph;
                if (A_1.Owner is SDTInlineContent)
                {
                    owner = A_1.Owner.Owner.Owner as Paragraph;
                }
                if ((owner != null) && this.method_75(A_1))
                {
                    this.method_403(A_0, owner.Format);
                    if (((owner.StyleName == null) || (owner.StyleName == string.Empty)) && (this.document_0.Styles.FindByName(BookmarkStart.b("縯崱䘳嬵夷嘹", num)) != null))
                    {
                        owner.ApplyStyle(BookmarkStart.b("縯崱䘳嬵夷嘹", num));
                    }
                }
                goto Label_0595;
            Label_035C:
                this.trackChangeType_0 = TrackChangeType.IsDelete;
                if (this.stack_5 == null)
                {
                    this.stack_5 = new Stack<Class579>();
                }
                string attribute = A_0.GetAttribute(BookmarkStart.b("儯䜱䀳帵圷䠹", num), this.dictionary_18[BookmarkStart.b("䜯", num)]);
                DateTime time2 = Class1041.smethod_3(A_0.GetAttribute(BookmarkStart.b("启匱䀳匵", num), this.dictionary_18[BookmarkStart.b("䜯", num)]));
                this.stack_5.Push(new Class579(EditRevisionType.Deletion, attribute, time2));
                this.method_74(A_0, A_1);
                if ((this.stack_5 != null) && (this.stack_5.Count > 0))
                {
                    this.stack_5.Pop();
                }
                this.trackChangeType_0 = TrackChangeType.None;
                goto Label_0595;
            Label_0418:
                this.trackChangeType_0 = TrackChangeType.IsInsert;
                if (this.stack_5 == null)
                {
                    this.stack_5 = new Stack<Class579>();
                }
                string str = A_0.GetAttribute(BookmarkStart.b("儯䜱䀳帵圷䠹", num), this.dictionary_18[BookmarkStart.b("䜯", num)]);
                DateTime time = Class1041.smethod_3(A_0.GetAttribute(BookmarkStart.b("启匱䀳匵", num), this.dictionary_18[BookmarkStart.b("䜯", num)]));
                this.stack_5.Push(new Class579(EditRevisionType.Insertion, str, time));
                this.method_74(A_0, A_1);
                if ((this.stack_5 != null) && (this.stack_5.Count > 0))
                {
                    this.stack_5.Pop();
                }
                this.trackChangeType_0 = TrackChangeType.None;
                goto Label_0595;
            Label_0510:
                document = new StructureDocumentTagInline(this.document_0);
                this.method_455(document as ParagraphBase, A_1);
                if (A_1.OwnerBase is Paragraph)
                {
                    (A_1.OwnerBase as Paragraph).bool_6 = true;
                }
                this.method_298(A_0, document as StructureDocumentTagInline);
            Label_0595:
                if (!flag)
                {
                    A_0.Read();
                }
                continue;
            Label_05A2:
                A_0.Read();
            }
        }
    }

    private bool method_75(ParagraphItemCollection A_0)
    {
        bool flag = true;
        using (IEnumerator enumerator = A_0.GetEnumerator())
        {
            while (enumerator.MoveNext())
            {
                ParagraphBase current = (ParagraphBase) enumerator.Current;
                if ((!(current is BookmarkStart) && !(current is BookmarkEnd)) && !(current is Break))
                {
                    goto Label_003A;
                }
            }
            return flag;
        Label_003A:
            flag = false;
        }
        return flag;
    }

    private void method_76(XmlReader A_0)
    {
        DateTime time;
        int num = 0x12;
        if (this.dictionary_14 == null)
        {
            this.dictionary_14 = new Dictionary<string, Comment>();
        }
        Comment comment = new Comment(this.document_0);
        string attribute = A_0.GetAttribute(BookmarkStart.b("儷帹", num), this.dictionary_18[BookmarkStart.b("伷", num)]);
        comment.Format.CommentId = int.Parse(A_0.GetAttribute(BookmarkStart.b("儷帹", num), this.dictionary_18[BookmarkStart.b("伷", num)]));
        string str2 = A_0.GetAttribute(BookmarkStart.b("夷伹䠻嘽⼿ぁ", num), this.dictionary_18[BookmarkStart.b("伷", num)]);
        if (str2 != null)
        {
            comment.Format.Author = str2;
        }
        string str4 = A_0.GetAttribute(BookmarkStart.b("尷嬹䠻嬽", num), this.dictionary_18[BookmarkStart.b("伷", num)]);
        if (!string.IsNullOrEmpty(str4) && DateTime.TryParse(str4, DateTimeFormatInfo.InvariantInfo, DateTimeStyles.AdjustToUniversal, out time))
        {
            comment.Format.DateTime = time;
        }
        string str3 = A_0.GetAttribute(BookmarkStart.b("儷吹唻䨽⤿⍁⡃㕅", num), this.dictionary_18[BookmarkStart.b("伷", num)]);
        if (str3 != null)
        {
            comment.Format.Initial = str3;
        }
        this.dictionary_14.Add(attribute, comment);
        this.method_68(A_0, comment);
    }

    private void method_77()
    {
        int num = 8;
        Class229 class2 = this.method_465(BookmarkStart.b("夭弯䀱倳ᤵ", 8), BookmarkStart.b("䴭弯弱夳匵嘷丹伻ွ㠿⽁⡃", 8));
        if (((class2 != null) && (class2.method_4() != null)) && (class2.method_4().Length != 0L))
        {
            class2.method_4().Position = 0L;
            XmlReader reader = Class57.smethod_18(class2.method_4());
            this.string_3 = BookmarkStart.b("䴭弯弱夳匵嘷丹伻ွ㠿⽁⡃", num);
            this.method_316(reader, BookmarkStart.b("䘭唯匱倳匵䨷尹医儽㐿❁㙃", num));
            this.method_68(reader, null);
            this.method_317();
            this.string_3 = string.Empty;
            this.method_78();
        }
    }

    private void method_78()
    {
        int num = 14;
        Class229 class2 = this.method_465(BookmarkStart.b("䌳夵䨷帹ጻ", 14), BookmarkStart.b("圳夵唷圹夻倽㐿ㅁŃ㹅㱇⽉≋⩍㕏㙑穓⹕㕗㙙", 14));
        if (((class2 != null) && (class2.method_4() != null)) && (class2.method_4().Length != 0L))
        {
            class2.method_4().Position = 0L;
            XmlReader reader = Class57.smethod_18(class2.method_4());
            this.string_3 = BookmarkStart.b("圳夵唷圹夻倽㐿ㅁŃ㹅㱇⽉≋⩍㕏㙑穓⹕㕗㙙", num);
            this.method_316(reader, BookmarkStart.b("尳匵夷帹夻䰽☿ⵁ⭃㉅ⵇ㡉", num));
            this.method_79(reader);
            this.method_317();
            this.string_3 = string.Empty;
        }
    }

    private void method_79(XmlReader A_0)
    {
        int num = 4;
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("堩䤫伭启圱䘳", num));
        }
        while (A_0.NodeType != XmlNodeType.Element)
        {
            A_0.Read();
        }
        if (!A_0.IsEmptyElement)
        {
            string localName = A_0.LocalName;
            bool flag = false;
            this.method_486(A_0);
            while (A_0.LocalName != localName)
            {
                if (A_0.EOF)
                {
                    break;
                }
                if (A_0.NodeType == XmlNodeType.Element)
                {
                    string str5;
                    if (((str5 = A_0.LocalName) != null) && (str5 == BookmarkStart.b("䤩䌫䌭崯圱娳䈵紷䈹", num)))
                    {
                        string attribute = A_0.GetAttribute(BookmarkStart.b("娩䴫尭儯笱倳", num), this.dictionary_18[BookmarkStart.b("崩ᴫᬭ", num)]);
                        string str3 = A_0.GetAttribute(BookmarkStart.b("娩䴫尭儯笱倳昵夷䠹夻倽㐿", num), this.dictionary_18[BookmarkStart.b("崩ᴫᬭ", num)]);
                        string str2 = A_0.GetAttribute(BookmarkStart.b("丩䌫䀭唯", num), this.dictionary_18[BookmarkStart.b("崩ᴫᬭ", num)]);
                        if (!string.IsNullOrEmpty(attribute) && this.method_2().ContainsKey(attribute))
                        {
                            this.method_2()[attribute].MarkCommentDone(this.method_110(str2));
                            if (!string.IsNullOrEmpty(str3) && this.method_2().ContainsKey(str3))
                            {
                                Comment comment = this.method_2()[str3];
                                Comment replyComment = this.method_2()[attribute];
                                comment.ReplyToComment(replyComment);
                            }
                        }
                    }
                    if (!flag)
                    {
                        A_0.Read();
                    }
                }
                else
                {
                    A_0.Read();
                }
                this.method_485(A_0);
            }
        }
    }

    private Stack<Field> method_8()
    {
        if (this.stack_1 == null)
        {
            this.stack_1 = new Stack<Field>();
        }
        return this.stack_1;
    }

    private void method_80(XmlReader A_0, ParagraphItemCollection A_1)
    {
        string attribute = A_0.GetAttribute(BookmarkStart.b("䄧丩", 2), this.dictionary_18[BookmarkStart.b("弧", 2)]);
        int num = int.Parse(attribute);
        CommentMark entity = new CommentMark(this.document_0, num);
        if ((A_1 != null) && (A_1.OwnerBase != null))
        {
            A_1.Add(entity);
        }
        else
        {
            this.list_3.Add(entity);
        }
        if (this.method_1().ContainsKey(attribute))
        {
            this.method_4().Push(this.method_1()[attribute]);
        }
        if (!this.method_5().method_7(num))
        {
            Class821 class2 = new Class821();
            class2.method_3(entity);
            this.method_5().method_5(num, class2);
        }
    }

    private void method_81(XmlReader A_0, ParagraphItemCollection A_1)
    {
        int num = int.Parse(A_0.GetAttribute(BookmarkStart.b("䄧丩", 2), this.dictionary_18[BookmarkStart.b("弧", 2)]));
        CommentMark entity = new CommentMark(this.document_0, num, CommentMarkType.CommentEnd);
        if ((A_1 != null) && (A_1.OwnerBase != null))
        {
            A_1.Add(entity);
        }
        else
        {
            this.list_3.Add(entity);
        }
        if ((this.stack_2 != null) && (this.stack_2.Count > 0))
        {
            this.stack_2.Pop();
        }
        if (this.method_5().method_7(num))
        {
            this.class822_0.method_2(num).method_1(entity);
        }
    }

    private void method_82(ParagraphBase A_0)
    {
        if (this.method_7() != null)
        {
            this.method_7().Items.Add(A_0);
        }
    }

    private void method_83(XmlReader A_0, Table A_1)
    {
        int num = 3;
        if (A_0.LocalName != BookmarkStart.b("崨䤪䄬", 3))
        {
            throw new XmlException(BookmarkStart.b("崨䨪伬䌮吰ጲ倴嬶尸嘺堼儾㕀", num));
        }
        if (!A_0.IsEmptyElement)
        {
            if (A_1 == null)
            {
                throw new ArgumentException(BookmarkStart.b("崨䨪伬䌮吰", num));
            }
            bool flag = false;
            A_0.Read();
            this.method_485(A_0);
            A_1.DocxTableFormat.Format.Paddings.method_51();
            while (A_0.LocalName != BookmarkStart.b("崨䤪䄬", num))
            {
                flag = false;
                if (A_0.NodeType == XmlNodeType.Element)
                {
                    string localName = A_0.LocalName;
                    if (localName != null)
                    {
                        if (localName != BookmarkStart.b("崨䤪䄬缮䌰", num))
                        {
                            if (localName != BookmarkStart.b("崨䤪䄬栮䌰娲儴", num))
                            {
                                if (localName != BookmarkStart.b("崨太", num))
                                {
                                    if (localName != BookmarkStart.b("娨伪夬", num))
                                    {
                                        if (!(localName == BookmarkStart.b("䬨䐪䈬䐮尰刲䜴尶樸伺尼䴾㕀", num)))
                                        {
                                            if (localName == BookmarkStart.b("䬨䐪䈬䐮尰刲䜴尶簸唺夼", num))
                                            {
                                                this.method_135(A_0, A_1);
                                            }
                                        }
                                        else
                                        {
                                            this.method_139(A_0, null);
                                        }
                                    }
                                    else
                                    {
                                        StructureDocumentTagRow row2 = new StructureDocumentTagRow(A_1);
                                        this.method_87(A_0, row2, A_1);
                                        if (row2.Cells.Count <= 0)
                                        {
                                            A_1.Rows.Remove(row2);
                                        }
                                    }
                                }
                                else
                                {
                                    TableRow row = new TableRow(this.document_0);
                                    A_1.Rows.Add(row);
                                    this.method_103(row, A_1);
                                    this.int_0 = -1;
                                    this.int_1 = 0;
                                    this.method_84(A_0, row);
                                    if (row.Cells.Count <= 0)
                                    {
                                        A_1.Rows.Remove(row);
                                    }
                                    row.method_26();
                                }
                            }
                            else
                            {
                                ArrayList list = new ArrayList();
                                A_1.TableFormat.SetAttr(0x13ef, list);
                                if (!A_0.IsEmptyElement)
                                {
                                    A_1.TableGrid.Add(0f);
                                    this.method_126(A_0, A_1, false);
                                }
                            }
                        }
                        else
                        {
                            this.method_105(A_0, A_1);
                            this.method_104(A_1.DocxTableFormat);
                            A_1.TableFormat.ImportContainer(A_1.DocxTableFormat.Format);
                        }
                    }
                    if (!flag)
                    {
                        A_0.Read();
                    }
                }
                else
                {
                    A_0.Read();
                }
            }
        }
    }

    private void method_84(XmlReader A_0, TableRow A_1)
    {
        int num = 4;
        if (A_0.LocalName != BookmarkStart.b("帩師", 4))
        {
            throw new XmlException(BookmarkStart.b("帩䴫䰭尯圱ᐳ䐵圷䴹᰻嬽ⰿ❁⥃⍅♇㹉", num));
        }
        if (!A_0.IsEmptyElement)
        {
            if (A_1 == null)
            {
                throw new ArgumentException(BookmarkStart.b("帩䴫䰭尯圱ᐳ䐵圷䴹", num));
            }
            bool flag = false;
            A_0.Read();
            this.method_485(A_0);
            while (A_0.LocalName != BookmarkStart.b("帩師", num))
            {
                flag = false;
                if (A_0.NodeType == XmlNodeType.Element)
                {
                    string localName = A_0.LocalName;
                    if (localName != null)
                    {
                        int num2;
                        if (Class1160.dictionary_56 == null)
                        {
                            Dictionary<string, int> dictionary1 = new Dictionary<string, int>(6);
                            dictionary1.Add(BookmarkStart.b("帩師縭䈯", num), 0);
                            dictionary1.Add(BookmarkStart.b("帩丫䈭怯䀱焳丵", num), 1);
                            dictionary1.Add(BookmarkStart.b("天䠫娭", num), 2);
                            dictionary1.Add(BookmarkStart.b("帩伫", num), 3);
                            dictionary1.Add(BookmarkStart.b("䠩䌫䄭嬯弱唳䐵匷椹䠻弽㈿㙁", num), 4);
                            dictionary1.Add(BookmarkStart.b("䠩䌫䄭嬯弱唳䐵匷缹刻娽", num), 5);
                            Class1160.dictionary_56 = dictionary1;
                        }
                        if (Class1160.dictionary_56.TryGetValue(localName, out num2))
                        {
                            switch (num2)
                            {
                                case 0:
                                    this.method_100(A_0, A_1);
                                    break;

                                case 1:
                                    A_1.HasTblPrEx = true;
                                    this.method_105(A_0, A_1);
                                    break;

                                case 2:
                                {
                                    StructureDocumentTagCell cell = new StructureDocumentTagCell(A_1);
                                    this.method_85(A_0, cell, A_1);
                                    break;
                                }
                                case 3:
                                {
                                    TableCell cell2 = A_1.AddCell(false);
                                    this.int_0++;
                                    this.method_89(A_0, cell2);
                                    this.int_1 += cell2.GridSpan;
                                    break;
                                }
                                case 4:
                                    this.method_139(A_0, null);
                                    break;

                                case 5:
                                    this.method_135(A_0, A_1);
                                    break;
                            }
                        }
                    }
                    if (!flag)
                    {
                        A_0.Read();
                    }
                }
                else
                {
                    A_0.Read();
                }
                this.method_485(A_0);
            }
            if (!(A_1 is StructureDocumentTagRow))
            {
                Class532.smethod_2(A_1);
            }
        }
    }

    private void method_85(XmlReader A_0, StructureDocumentTagCell A_1, TableRow A_2)
    {
        int num = 8;
        while (A_0.NodeType != XmlNodeType.Element)
        {
            A_0.Read();
        }
        if (!A_0.IsEmptyElement)
        {
            bool flag = false;
            string localName = A_0.LocalName;
            A_0.Read();
            this.method_485(A_0);
            while (A_0.LocalName != localName)
            {
                flag = false;
                if (A_0.NodeType == XmlNodeType.Element)
                {
                    string str = A_0.LocalName;
                    if (str != null)
                    {
                        if (str != BookmarkStart.b("崭启䘱搳䐵", num))
                        {
                            if (!(str == BookmarkStart.b("崭启䘱眳夵嘷丹夻倽㐿", num)))
                            {
                                if (str == BookmarkStart.b("崭启䘱焳堵尷樹主", num))
                                {
                                    this.method_303(A_0, A_1.BreakCharacterFormat);
                                }
                            }
                            else
                            {
                                this.method_86(A_0, A_1, A_2);
                            }
                        }
                        else
                        {
                            this.method_305(A_0, A_1.SDTProperties);
                        }
                    }
                    if (!flag)
                    {
                        A_0.Read();
                    }
                }
                else
                {
                    A_0.Read();
                }
            }
        }
    }

    private void method_86(XmlReader A_0, StructureDocumentTagCell A_1, TableRow A_2)
    {
        int num = 0x10;
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("䐵崷嬹堻嬽㈿", num));
        }
        while (A_0.NodeType != XmlNodeType.Element)
        {
            A_0.Read();
        }
        string localName = A_0.LocalName;
        if (!A_0.IsEmptyElement)
        {
            bool flag = false;
            A_0.Read();
            this.method_485(A_0);
            while (A_0.LocalName != localName)
            {
                if (A_0.NodeType == XmlNodeType.Element)
                {
                    string str = A_0.LocalName;
                    if (str != null)
                    {
                        if (!(str == BookmarkStart.b("䈵嬷", num)))
                        {
                            if (str == BookmarkStart.b("䔵尷丹", num))
                            {
                                StructureDocumentTagCell cell = new StructureDocumentTagCell(A_2);
                                this.method_85(A_0, cell, A_2);
                            }
                        }
                        else
                        {
                            this.int_0++;
                            this.method_89(A_0, A_1);
                        }
                    }
                    if (!flag)
                    {
                        A_0.Read();
                    }
                }
                else
                {
                    A_0.Read();
                }
            }
        }
    }

    private void method_87(XmlReader A_0, StructureDocumentTagRow A_1, Table A_2)
    {
        int num = 2;
        while (A_0.NodeType != XmlNodeType.Element)
        {
            A_0.Read();
        }
        if (!A_0.IsEmptyElement)
        {
            bool flag2 = false;
            string localName = A_0.LocalName;
            A_0.Read();
            this.method_485(A_0);
            bool flag = true;
            while (A_0.LocalName != localName)
            {
                flag2 = false;
                if (A_0.NodeType == XmlNodeType.Element)
                {
                    string str = A_0.LocalName;
                    if (str != null)
                    {
                        if (str != BookmarkStart.b("嬧丩堫縭䈯", num))
                        {
                            if (!(str == BookmarkStart.b("嬧丩堫洭弯就䀳匵嘷丹", num)))
                            {
                                if (str == BookmarkStart.b("嬧丩堫欭帯嘱搳䐵", num))
                                {
                                    this.method_303(A_0, A_1.BreakCharacterFormat);
                                }
                            }
                            else
                            {
                                this.method_88(A_0, A_1, A_2, ref flag);
                            }
                        }
                        else
                        {
                            this.method_305(A_0, A_1.SDTProperties);
                        }
                    }
                    if (!flag2)
                    {
                        A_0.Read();
                    }
                }
                else
                {
                    A_0.Read();
                }
            }
        }
    }

    private void method_88(XmlReader A_0, StructureDocumentTagRow A_1, Table A_2, ref bool A_3)
    {
        int num = 9;
        if (A_0 == null)
        {
            throw new ArgumentNullException(BookmarkStart.b("崮吰刲儴制䬸", num));
        }
        while (A_0.NodeType != XmlNodeType.Element)
        {
            A_0.Read();
        }
        string localName = A_0.LocalName;
        if (!A_0.IsEmptyElement)
        {
            bool flag = false;
            A_0.Read();
            this.method_485(A_0);
            while (A_0.LocalName != localName)
            {
                if (A_0.NodeType == XmlNodeType.Element)
                {
                    string str = A_0.LocalName;
                    if (str != null)
                    {
                        if (!(str == BookmarkStart.b("嬮䌰", num)))
                        {
                            if (str == BookmarkStart.b("尮唰䜲", num))
                            {
                                StructureDocumentTagRow row = new StructureDocumentTagRow(A_1);
                                this.method_87(A_0, row, A_2);
                            }
                        }
                        else
                        {
                            this.method_103(A_1, A_2);
                            this.int_0 = -1;
                            this.int_1 = 0;
                            this.method_84(A_0, A_1);
                            if (A_3)
                            {
                                A_3 = false;
                            }
                        }
                    }
                    if (!flag)
                    {
                        A_0.Read();
                    }
                }
                else
                {
                    A_0.Read();
                }
            }
        }
    }

    private void method_89(XmlReader A_0, TableCell A_1)
    {
        int num = 7;
        if (A_0.LocalName != BookmarkStart.b("夬䰮", 7))
        {
            throw new XmlException(BookmarkStart.b("夬丮匰弲倴᜶娸帺儼匾慀♂⥄≆⑈⹊⍌㭎", num));
        }
        if (!A_0.IsEmptyElement)
        {
            if (A_1 == null)
            {
                throw new ArgumentException(BookmarkStart.b("夬丮匰弲倴᜶娸帺儼匾", num));
            }
            bool flag2 = false;
            A_0.Read();
            this.method_485(A_0);
            while (A_0.LocalName != BookmarkStart.b("夬䰮", num))
            {
                IParagraph paragraph;
                flag2 = false;
                bool flag = false;
                if (A_0.NodeType != XmlNodeType.Element)
                {
                    goto Label_0373;
                }
                string localName = A_0.LocalName;
                if (localName != null)
                {
                    int num2;
                    if (Class1160.dictionary_57 == null)
                    {
                        Dictionary<string, int> dictionary1 = new Dictionary<string, int>(7);
                        dictionary1.Add(BookmarkStart.b("夬䰮愰䄲", num), 0);
                        dictionary1.Add(BookmarkStart.b("崬缮䌰", num), 1);
                        dictionary1.Add(BookmarkStart.b("崬", num), 2);
                        dictionary1.Add(BookmarkStart.b("帬䬮䔰", num), 3);
                        dictionary1.Add(BookmarkStart.b("夬䴮崰", num), 4);
                        dictionary1.Add(BookmarkStart.b("伬䀮帰堲場嘶䬸债渼䬾⁀ㅂㅄ", num), 5);
                        dictionary1.Add(BookmarkStart.b("伬䀮帰堲場嘶䬸债砼儾╀", num), 6);
                        Class1160.dictionary_57 = dictionary1;
                    }
                    if (Class1160.dictionary_57.TryGetValue(localName, out num2))
                    {
                        switch (num2)
                        {
                            case 0:
                                if (!A_0.IsEmptyElement)
                                {
                                    A_1.CellFormat.Borders.IsDefault = false;
                                    this.method_90(A_0, A_1);
                                }
                                break;

                            case 1:
                                A_1.ParagraphFormat = new ParagraphFormat(A_1.Document);
                                A_1.ParagraphFormat.method_0(A_1);
                                this.method_403(A_0, A_1.ParagraphFormat);
                                break;

                            case 2:
                                goto Label_01AB;

                            case 3:
                            {
                                IStructureDocument document = A_1.method_21();
                                this.method_300(A_0, document as StructureDocumentTag);
                                break;
                            }
                            case 4:
                                goto Label_028B;

                            case 5:
                                this.method_139(A_0, null);
                                break;

                            case 6:
                                this.method_135(A_0, A_1);
                                break;
                        }
                    }
                }
                goto Label_0366;
            Label_01AB:
                paragraph = A_1.AddParagraph();
                if ((this.method_9() != null) && !this.method_9().IsFieldRange)
                {
                    this.method_9().IsFieldRange = true;
                    flag = true;
                    this.method_129(paragraph as Paragraph);
                }
                Field field = this.method_9();
                this.method_70(paragraph);
                this.method_73(paragraph);
                this.method_74(A_0, paragraph.Items);
                if ((A_1.ParagraphFormat != null) && !A_1.ParagraphFormat.IsDefault)
                {
                    paragraph.Format.method_63(A_1.ParagraphFormat);
                }
                if (!string.IsNullOrEmpty(paragraph.StyleName))
                {
                    paragraph.ApplyStyle(paragraph.StyleName);
                }
                if (((field != null) && field.IsFieldRange) && flag)
                {
                    field.IsFieldRange = false;
                }
                goto Label_0366;
            Label_028B:
                if (this.int_0 >= 0)
                {
                    this.method_6().Push(this.int_0);
                    this.int_0 = -1;
                }
                Table table = A_1.AddTable();
                if ((this.method_9() != null) && !this.method_9().IsFieldRange)
                {
                    this.method_9().IsFieldRange = true;
                    flag = true;
                    this.method_129(table);
                }
                field = this.method_9();
                this.method_83(A_0, table);
                if (((field != null) && field.IsFieldRange) && flag)
                {
                    field.IsFieldRange = false;
                }
                if (this.method_6().Count > 0)
                {
                    this.int_0 = this.method_6().Pop();
                }
                if ((table.Rows.Count <= 0) && A_1.Items.Contains(table))
                {
                    A_1.Items.Remove(table);
                }
            Label_0366:
                if (!flag2)
                {
                    A_0.Read();
                }
                goto Label_037A;
            Label_0373:
                A_0.Read();
            Label_037A:
                this.method_485(A_0);
            }
        }
    }

    private Field method_9()
    {
        if ((this.stack_1 != null) && (this.stack_1.Count > 0))
        {
            return this.stack_1.Peek();
        }
        return null;
    }

    private void method_90(XmlReader A_0, TableCell A_1)
    {
        int num = 0x13;
        if (A_0.LocalName != BookmarkStart.b("䴸堺洼䴾", 0x13))
        {
            throw new XmlException(BookmarkStart.b("䴸娺弼匾⑀捂♄≆╈❊浌㽎⍐㱒╔㉖⭘⽚㑜㩞በ䍢d୦౨٪࡬Ůհ", num));
        }
        if (!A_0.IsEmptyElement)
        {
            if (A_1 == null)
            {
                throw new ArgumentException(BookmarkStart.b("䴸娺弼匾⑀捂♄≆╈❊", num));
            }
            bool flag = false;
            A_0.Read();
            this.method_485(A_0);
            CellFormat format = this.bool_1 ? A_1.TrackCellFormat : A_1.CellFormat;
            while (A_0.LocalName != BookmarkStart.b("䴸堺洼䴾", num))
            {
                short num2;
                flag = false;
                if (A_0.NodeType != XmlNodeType.Element)
                {
                    goto Label_0371;
                }
                string localName = A_0.LocalName;
                if (localName != null)
                {
                    int num3;
                    if (Class1160.dictionary_58 == null)
                    {
                        Dictionary<string, int> dictionary1 = new Dictionary<string, int>(14);
                        dictionary1.Add(BookmarkStart.b("圸吺樼䴾⁀㍂", num), 0);
                        dictionary1.Add(BookmarkStart.b("䴸堺笼嘾㕀ᝂ⁄㽆㵈", num), 1);
                        dictionary1.Add(BookmarkStart.b("儸刺夼娾ీ≂㝄ⱆ", num), 2);
                        dictionary1.Add(BookmarkStart.b("䴸堺樼", num), 3);
                        dictionary1.Add(BookmarkStart.b("䴸帺䔼䬾Հ⩂㝄≆⩈㽊⑌⁎㽐", num), 4);
                        dictionary1.Add(BookmarkStart.b("伸稺儼嘾♀ⵂ", num), 5);
                        dictionary1.Add(BookmarkStart.b("伸瘺堼䴾♀♂", num), 6);
                        dictionary1.Add(BookmarkStart.b("儸瘺堼䴾♀♂", num), 7);
                        dictionary1.Add(BookmarkStart.b("䴸堺瀼帾㍀", num), 8);
                        dictionary1.Add(BookmarkStart.b("䴸堺缼倾㍀❂⁄㕆㩈", num), 9);
                        dictionary1.Add(BookmarkStart.b("䨸区夼", num), 10);
                        dictionary1.Add(BookmarkStart.b("常䤺吼嬾ቀ㍂⑄⥆", num), 11);
                        dictionary1.Add(BookmarkStart.b("䴸堺洼䴾ɀ⭂⑄⥆⹈⹊", num), 12);
                        dictionary1.Add(BookmarkStart.b("娸唺嬼氾㕀㩂⥄≆", num), 13);
                        Class1160.dictionary_58 = dictionary1;
                    }
                    if (Class1160.dictionary_58.TryGetValue(localName, out num3))
                    {
                        switch (num3)
                        {
                            case 0:
                                format.TextWrap = false;
                                goto Label_0365;

                            case 1:
                                format.FitText = true;
                                goto Label_0365;

                            case 2:
                                format.HideMark = true;
                                goto Label_0365;

                            case 3:
                                this.method_96(A_0, A_1);
                                goto Label_0365;

                            case 4:
                                this.method_95(A_0, format);
                                goto Label_0365;

                            case 5:
                                format.VerticalAlignment = this.method_94(A_0);
                                goto Label_0365;

                            case 6:
                                this.method_92(A_0, format);
                                goto Label_0365;

                            case 7:
                                this.method_93(A_0, format);
                                goto Label_0365;

                            case 8:
                                format.SamePaddingsAsTable = false;
                                this.method_113(A_0, A_1);
                                goto Label_0365;

                            case 9:
                                this.method_415(A_0, A_1);
                                goto Label_0365;

                            case 10:
                                this.method_91(A_0, A_1);
                                goto Label_0365;

                            case 11:
                                goto Label_029F;

                            case 12:
                                this.bool_1 = true;
                                A_0.Read();
                                this.method_485(A_0);
                                this.method_90(A_0, A_1);
                                this.bool_1 = false;
                                goto Label_0365;

                            case 13:
                                goto Label_0365;
                        }
                    }
                }
                goto Label_0351;
            Label_029F:
                num2 = short.Parse(A_0.GetAttribute(BookmarkStart.b("伸娺儼", num), this.dictionary_18[BookmarkStart.b("丸", num)]));
                if (A_1.GridSpan == 1)
                {
                    A_1.GridSpan = num2;
                    A_0.MoveToContent();
                    if (A_1.CellFormat.IsAutoResized)
                    {
                        this.method_99(A_1, this.int_0, num2);
                        this.int_0 += num2 - 1;
                    }
                    format.XmlProps2010.Add(this.method_484(A_0));
                    flag = true;
                }
                goto Label_0365;
            Label_0351:
                format.XmlProps2010.Add(this.method_484(A_0));
                flag = true;
            Label_0365:
                if (!flag)
                {
                    A_0.Read();
                }
                goto Label_0378;
            Label_0371:
                A_0.Read();
            Label_0378:
                this.method_485(A_0);
            }
        }
    }

    private void method_91(XmlReader A_0, TableCell A_1)
    {
        Color empty;
        int num = 0;
        string attribute = A_0.GetAttribute(BookmarkStart.b("倥䤧䘩", 0), this.dictionary_18[BookmarkStart.b("儥", 0)]);
        if (this.bool_1)
        {
            A_1.TrackCellFormat.TextureStyle = this.method_394(attribute);
        }
        else
        {
            A_1.CellFormat.TextureStyle = this.method_394(attribute);
        }
        string str3 = A_0.GetAttribute(BookmarkStart.b("䀥䄧䘩䀫", num), this.dictionary_18[BookmarkStart.b("儥", num)]);
        if (str3 == BookmarkStart.b("䜥崧帩䌫", num))
        {
            A_1.CellFormat.BackColor = Color.Empty;
        }
        else
        {
            A_1.CellFormat.BackColor = this.method_474(str3);
        }
        string str2 = A_0.GetAttribute(BookmarkStart.b("䔥䜧䘩䌫尭", num), this.dictionary_18[BookmarkStart.b("儥", num)]);
        if (str2 == BookmarkStart.b("䜥崧帩䌫", num))
        {
            empty = Color.Empty;
        }
        else
        {
            empty = this.method_474(str2);
        }
        if (this.bool_1)
        {
            A_1.TrackCellFormat.ForeColor = empty;
        }
        else
        {
            A_1.CellFormat.ForeColor = empty;
        }
    }

    private void method_92(XmlReader A_0, CellFormat A_1)
    {
        if (A_0.GetAttribute(BookmarkStart.b("䔲吴嬶", 13), this.dictionary_18[BookmarkStart.b("䐲", 13)]) == BookmarkStart.b("䄲倴䐶䴸娺似䬾", 13))
        {
            A_1.VerticalMerge = CellMerge.Start;
        }
        else
        {
            A_1.VerticalMerge = CellMerge.Continue;
        }
    }

    private void method_93(XmlReader A_0, CellFormat A_1)
    {
        if (A_0.GetAttribute(BookmarkStart.b("䌴嘶唸", 15), this.dictionary_18[BookmarkStart.b("䈴", 15)]) == BookmarkStart.b("䜴制䨸伺尼䴾㕀", 15))
        {
            A_1.HorizontalMerge = CellMerge.Start;
        }
        else
        {
            A_1.HorizontalMerge = CellMerge.Continue;
        }
    }

    private VerticalAlignment method_94(XmlReader A_0)
    {
        string str2;
        int num = 11;
        VerticalAlignment top = VerticalAlignment.Top;
        string attribute = A_0.GetAttribute(BookmarkStart.b("䜰刲头", 11), this.dictionary_18[BookmarkStart.b("䘰", 11)]);
        if ((attribute == null) || ((str2 = attribute) == null))
        {
            return top;
        }
        if (str2 != BookmarkStart.b("䔰尲䔴", num))
        {
            if (!(str2 == BookmarkStart.b("匰尲䄴䌶嘸嘺", num)))
            {
                if (str2 == BookmarkStart.b("到嘲嬴䌶尸䤺", num))
                {
                    top = VerticalAlignment.Middle;
                }
                return top;
            }
            return VerticalAlignment.Bottom;
        }
        return VerticalAlignment.Top;
    }

    private void method_95(XmlReader A_0, CellFormat A_1)
    {
        int num = 3;
        string attribute = A_0.GetAttribute(BookmarkStart.b("弨䨪䄬", 3), this.dictionary_18[BookmarkStart.b("帨", 3)]);
        if (!string.IsNullOrEmpty(attribute))
        {
            string key = attribute;
            if (key != null)
            {
                int num2;
                if (Class1160.dictionary_59 == null)
                {
                    Dictionary<string, int> dictionary1 = new Dictionary<string, int>(6);
                    dictionary1.Add(BookmarkStart.b("䬨弪愬崮", num), 0);
                    dictionary1.Add(BookmarkStart.b("崨䤪愬崮朰", num), 1);
                    dictionary1.Add(BookmarkStart.b("崨䤪缬䌮", num), 2);
                    dictionary1.Add(BookmarkStart.b("崨䤪缬䌮朰", num), 3);
                    dictionary1.Add(BookmarkStart.b("䔨太礬䴮朰", num), 4);
                    dictionary1.Add(BookmarkStart.b("䔨太礬䴮", num), 5);
                    Class1160.dictionary_59 = dictionary1;
                }
                if (Class1160.dictionary_59.TryGetValue(key, out num2))
                {
                    switch (num2)
                    {
                        case 0:
                            A_1.TextDirection = TextDirection.LeftToRight;
                            return;

                        case 1:
                            A_1.TextDirection = TextDirection.LeftToRightRotated;
                            return;

                        case 2:
                            A_1.TextDirection = TextDirection.RightToLeft;
                            return;

                        case 3:
                            A_1.TextDirection = TextDirection.RightToLeftRotated;
                            return;

                        case 4:
                            A_1.TextDirection = TextDirection.TopToBottomRotated;
                            return;
                    }
                }
            }
            A_1.TextDirection = TextDirection.TopToBottom;
        }
    }

    private void method_96(XmlReader A_0, TableCell A_1)
    {
        int num = 8;
        string attribute = A_0.GetAttribute(BookmarkStart.b("娭䤯䈱儳", 8), this.dictionary_18[BookmarkStart.b("夭", 8)]);
        if (attribute != null)
        {
            string str3 = attribute;
            if (str3 != null)
            {
                if (str3 == BookmarkStart.b("伭䔯䘱嬳", num))
                {
                    A_1.CellFormat.IsAutoResized = true;
                    return;
                }
                if (str3 == BookmarkStart.b("席匯䘱", num))
                {
                    string input = A_0.GetAttribute(BookmarkStart.b("夭", num), this.dictionary_18[BookmarkStart.b("夭", num)]);
                    Regex regex = new Regex(BookmarkStart.b("̭༯椱гᬵķ朹᜻ᘽ᰿汁ὃ癅敇獉ᅋ敍祏浑煓", num));
                    if (regex.IsMatch(input))
                    {
                        float num3 = float.Parse(input.Replace(BookmarkStart.b("ଭ", num), string.Empty), NumberStyles.Float, CultureInfo.InvariantCulture);
                        A_1.Scaling = num3;
                        A_1.WidthType = FtsWidth.Percentage;
                        return;
                    }
                    float num2 = ((float) int.Parse(input, NumberStyles.Integer, CultureInfo.InvariantCulture)) / 50f;
                    A_1.Scaling = num2;
                    A_1.WidthType = FtsWidth.Percentage;
                    return;
                }
            }
            string str4 = A_0.GetAttribute(BookmarkStart.b("夭", num), this.dictionary_18[BookmarkStart.b("夭", num)]);
            float num4 = ((float) this.method_239(str4)) / 20f;
            if (this.bool_1)
            {
                A_1.TrackCellFormat.CellWidth = num4;
            }
            else
            {
                A_1.CellFormat.CellWidth = num4;
            }
            A_1.WidthType = FtsWidth.Point;
        }
    }

    private void method_97(TableCell A_0)
    {
        if ((A_0.OwnerRow != null) && (A_0.OwnerRow.OwnerTable != null))
        {
            List<float> tableGrid = A_0.OwnerRow.OwnerTable.TableGrid;
            float num = tableGrid[tableGrid.Count - 1];
            num = (num * A_0.OwnerRow.OwnerTable.DocxTableFormat.Format.Scaling) / 100f;
            if (this.bool_1)
            {
                A_0.TrackCellFormat.CellWidth = (num * A_0.Scaling) / 100f;
            }
            else
            {
                A_0.CellFormat.CellWidth = (num * A_0.Scaling) / 100f;
            }
        }
    }

    private void method_98(TableCell A_0, int A_1)
    {
        if ((A_0.OwnerRow != null) && (A_0.OwnerRow.OwnerTable != null))
        {
            List<float> tableGrid = A_0.OwnerRow.OwnerTable.TableGrid;
            float num = 0f;
            if ((tableGrid != null) && (tableGrid.Count != 0))
            {
                if ((A_1 + 1) >= tableGrid.Count)
                {
                    return;
                }
                num = tableGrid[A_1 + 1] - tableGrid[A_1];
            }
            else
            {
                float width = A_0.OwnerRow.OwnerTable.Width;
                if (width != 0f)
                {
                    num = width / ((float) A_0.OwnerRow.Cells.Count);
                }
            }
            if (this.bool_1)
            {
                A_0.TrackCellFormat.CellWidth = num / 20f;
            }
            else
            {
                A_0.CellFormat.CellWidth = num / 20f;
            }
        }
    }

    private void method_99(TableCell A_0, int A_1, int A_2)
    {
        if ((A_0.OwnerRow != null) && (A_0.OwnerRow.OwnerTable != null))
        {
            List<float> tableGrid = A_0.OwnerRow.OwnerTable.TableGrid;
            if ((tableGrid != null) && (tableGrid.Count != 0))
            {
                float num = 0f;
                if ((A_1 + A_2) < tableGrid.Count)
                {
                    num = tableGrid[A_1 + A_2] - tableGrid[A_1];
                    if (this.bool_1)
                    {
                        A_0.TrackCellFormat.CellWidth = num / 20f;
                    }
                    else
                    {
                        A_0.CellFormat.CellWidth = num / 20f;
                    }
                }
            }
        }
    }

    void IDisposable.Dispose()
    {
        if (this.class771_0 != null)
        {
            this.class771_0.System.IDisposable.Dispose();
            this.class771_0 = null;
        }
        if (this.xmlReader_0 != null)
        {
            this.xmlReader_0.Close();
            this.xmlReader_0 = null;
        }
        if (this.dictionary_0 != null)
        {
            this.dictionary_0.Clear();
            this.dictionary_0 = null;
        }
        if (this.dictionary_1 != null)
        {
            this.dictionary_1.Clear();
            this.dictionary_1 = null;
        }
        if (this.dictionary_2 != null)
        {
            this.dictionary_2.Clear();
            this.dictionary_2 = null;
        }
        if (this.dictionary_3 != null)
        {
            this.dictionary_3.Clear();
            this.dictionary_3 = null;
        }
        if (this.dictionary_4 != null)
        {
            this.dictionary_4.Clear();
            this.dictionary_4 = null;
        }
        if (this.dictionary_5 != null)
        {
            this.dictionary_5.Clear();
            this.dictionary_5 = null;
        }
        if (this.dictionary_6 != null)
        {
            this.dictionary_6.Clear();
            this.dictionary_6 = null;
        }
        if (this.dictionary_7 != null)
        {
            this.dictionary_7.Clear();
            this.dictionary_7 = null;
        }
        if (this.dictionary_9 != null)
        {
            this.dictionary_9.Clear();
            this.dictionary_9 = null;
        }
        if (this.dictionary_10 != null)
        {
            this.dictionary_10.Clear();
            this.dictionary_10 = null;
        }
        this.characterFormat_0 = null;
        if (this.list_1 != null)
        {
            this.list_1.Clear();
            this.list_1 = null;
        }
        if (this.list_2 != null)
        {
            this.list_2.Clear();
            this.list_2 = null;
        }
        if (this.stringBuilder_0 != null)
        {
            this.stringBuilder_0 = null;
        }
        if (this.stack_1 != null)
        {
            this.stack_1.Clear();
            this.stack_1 = null;
        }
        if (this.stack_1 != null)
        {
            this.stack_1.Clear();
            this.stack_1 = null;
        }
        if (this.dictionary_17 != null)
        {
            this.dictionary_17.Clear();
            this.dictionary_17 = null;
        }
        if (this.stack_3 != null)
        {
            this.stack_3.Clear();
            this.stack_3 = null;
        }
        if (this.regex_0 != null)
        {
            this.regex_0 = null;
        }
        if (this.list_4 != null)
        {
            this.list_4.Clear();
            this.list_4 = null;
        }
        if (this.list_5 != null)
        {
            this.list_5.Clear();
            this.list_5 = null;
        }
        if (this.class822_0 != null)
        {
            this.class822_0 = null;
        }
        this.dictionary_11 = null;
        this.list_3 = null;
        this.dictionary_14 = null;
        this.dictionary_15 = null;
        this.dictionary_16 = null;
        this.stack_2 = null;
        this.dictionary_18 = null;
        this.stack_4 = null;
        this.list_6 = null;
    }
}

