using Spire.CompoundFile.Doc;
using Spire.Compression;
using Spire.Doc;
using Spire.Doc.Collections;
using Spire.Doc.Core.Biff_Records;
using Spire.Doc.Core.DataStreamParser.Escher;
using Spire.Doc.Documents;
using Spire.Doc.Fields;
using Spire.Doc.Fields.Shape;
using Spire.Doc.Formatting;
using Spire.Doc.Interface;
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

internal class Class465 : IDisposable
{
    private bool bool_0;
    private bool bool_1;
    private bool bool_10;
    private bool bool_11;
    private bool bool_12;
    private bool bool_13;
    private bool bool_14;
    private bool bool_15;
    private bool bool_16;
    private bool bool_17;
    private bool bool_18;
    private bool bool_19;
    private bool bool_2;
    private bool bool_20;
    private bool bool_21;
    private bool bool_22;
    private bool bool_23;
    private bool bool_24;
    private bool bool_25;
    private bool bool_3;
    private bool bool_4;
    private bool bool_5;
    private bool bool_6;
    private bool bool_7;
    private bool bool_8;
    private bool bool_9;
    internal const char char_0 = '\r';
    internal const char char_1 = '\n';
    private static readonly char[] char_2 = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
    private Class1092 class1092_0;
    private Class771 class771_0 = new Class771();
    private Comment comment_0;
    private Dictionary<int, Dictionary<int, string>> dictionary_0;
    private Dictionary<string, Class517> dictionary_1;
    private Dictionary<HeaderFooterType, Dictionary<string, HeaderFooter>> dictionary_10;
    private Dictionary<string, string> dictionary_11;
    internal Dictionary<string, Stream> dictionary_12;
    internal Dictionary<string, Dictionary<string, Stream>> dictionary_13;
    private Dictionary<string, DictionaryEntry> dictionary_14;
    private Dictionary<string, DictionaryEntry> dictionary_15;
    private Dictionary<string, DictionaryEntry> dictionary_16;
    private Dictionary<string, DictionaryEntry> dictionary_17;
    private Dictionary<int, string> dictionary_18;
    private Dictionary<string, Comment> dictionary_19;
    private Dictionary<string, byte[]> dictionary_2;
    private Dictionary<int, Footnote> dictionary_20;
    private Dictionary<int, Footnote> dictionary_21;
    private Dictionary<string, string> dictionary_22;
    private Dictionary<string, string> dictionary_23;
    private Dictionary<string, string> dictionary_24;
    private Dictionary<string, Dictionary<string, string>> dictionary_25;
    private Dictionary<string, string> dictionary_26;
    private Dictionary<string, string> dictionary_27;
    private Dictionary<string, string> dictionary_28;
    private Dictionary<string, Dictionary<string, string>> dictionary_29;
    private Dictionary<string, Class517> dictionary_3;
    private Dictionary<string, Dictionary<string, DictionaryEntry>> dictionary_30;
    private Dictionary<string, string> dictionary_31;
    private Dictionary<string, string> dictionary_32;
    private Dictionary<Comment, string> dictionary_33;
    private Dictionary<string, Class517> dictionary_4;
    private Dictionary<string, Class517> dictionary_5;
    private Dictionary<string, Class517> dictionary_6;
    private Dictionary<string, Dictionary<string, Class517>> dictionary_7;
    private Dictionary<string, int> dictionary_8 = new Dictionary<string, int>();
    private Dictionary<string, int> dictionary_9 = new Dictionary<string, int>();
    private Document document_0;
    private FieldMark fieldMark_0;
    private HeaderFooterType headerFooterType_0;
    private IDocumentObject idocumentObject_0;
    private int int_0;
    private int int_1;
    private int int_10;
    private int int_11;
    private int int_12;
    private int int_2 = 2;
    private int int_3 = 1;
    private int int_4 = 1;
    private int int_5;
    private int int_6 = 0x400;
    private int int_7 = 0x133;
    private int int_8;
    private int int_9 = 2;
    private List<int> list_0 = new List<int>();
    private List<int> list_1 = new List<int>();
    private List<int> list_2 = new List<int>();
    private List<int> list_3 = new List<int>();
    private List<string> list_4;
    private List<string> list_5;
    private List<string> list_6;
    private List<string> list_7;
    private List<string> list_8;
    private Paragraph paragraph_0;
    private Random random_0 = new Random();
    private Stack<Field> stack_0;
    private Stack<Field> stack_1;
    internal readonly string string_0 = '\\'.ToString();
    internal readonly string string_1 = '"'.ToString();
    internal readonly string string_2 = '\0'.ToString();
    private string string_3 = string.Empty;
    private string[] string_4;
    private TextRange textRange_0;

    public Class465()
    {
        this.class771_0.method_6(CompressionLevel.Normal);
    }

    private List<string> method_0()
    {
        if (this.list_8 == null)
        {
            this.list_8 = new List<string>();
        }
        return this.list_8;
    }

    internal Dictionary<HeaderFooterType, Dictionary<string, HeaderFooter>> method_1()
    {
        if (this.dictionary_10 == null)
        {
            this.dictionary_10 = new Dictionary<HeaderFooterType, Dictionary<string, HeaderFooter>>();
        }
        return this.dictionary_10;
    }

    internal Dictionary<string, string> method_10()
    {
        if (this.dictionary_22 == null)
        {
            this.dictionary_22 = new Dictionary<string, string>();
        }
        return this.dictionary_22;
    }

    private void method_100()
    {
        int num = 12;
        this.dictionary_32 = this.document_0.DocxNameSpace.method_0()[BookmarkStart.b("怱儳娵夷丹唻儽⸿ㅁⱃ⽅㡇㥉", 12)];
        MemoryStream stream = new MemoryStream();
        this.class1092_0 = this.method_524(stream);
        this.class1092_0.method_10(BookmarkStart.b("怱儳娵夷丹唻儽⸿ㅁⱃ⽅㡇㥉", 12), this.dictionary_32[BookmarkStart.b("䨱夳娵嘷䤹", 12)]);
        this.method_512(stream, this.method_527(), BookmarkStart.b("娱䀳䈵䠷9ጻᄽ㌿⅁ⱃ⍅╇⭉㽋恍㽏≑ㅓ㡕⁗㝙せ㡝ཟၡॣݥᱧᥩ䉫ŭɯᕱ孳᥵ṷᱹᕻᵽ욁ﶇ붑ꚓꚕꢗ겙뎛얟캡얣튥솧얩슫\uddad\ud8af\udbb1\uc4b3억鞷즹좻잽겿ꟁ럃", 12), BookmarkStart.b("䄱䀳伵吷弹伻ွ㠿⽁⡃", 12));
        this.method_512(stream, this.method_527(), BookmarkStart.b("娱䀳䈵䠷9ጻᄽ㌿⅁ⱃ⍅╇⭉㽋恍㽏≑ㅓ㡕⁗㝙せ㡝ཟၡॣݥᱧᥩ䉫ŭɯᕱ孳᥵ṷᱹᕻᵽ욁ﶇ붑ꚓꚕꢗ겙뎛얟캡얣튥솧얩슫\uddad\ud8af\udbb1\uc4b3억鞷즹\ud9bb\ucabd뒿ꯁ꫃ꇅ믇", 12), BookmarkStart.b("䄱儳䈵䰷匹刻夽㌿汁㱃⭅⑇", 12));
        this.method_512(stream, this.method_527(), BookmarkStart.b("娱䀳䈵䠷9ጻᄽ㌿⅁ⱃ⍅╇⭉㽋恍㽏≑ㅓ㡕⁗㝙せ㡝ཟၡॣݥᱧᥩ䉫ŭɯᕱ孳᥵ṷᱹᕻᵽ욁ﶇ붑ꚓꚕꢗ겙뎛얟캡얣튥솧얩슫\uddad\ud8af\udbb1\uc4b3억鞷춹\ud9bb\udcbd鎿ꟁ냃닅ꇇ꓉ꯋ뷍", 12), BookmarkStart.b("䔱儳吵欷弹䠻䨽⤿ⱁ⍃㕅晇㉉⅋≍", 12));
        if (this.method_32())
        {
            this.method_512(stream, this.method_527(), BookmarkStart.b("娱䀳䈵䠷9ጻᄽ㌿⅁ⱃ⍅╇⭉㽋恍㽏≑ㅓ㡕⁗㝙せ㡝ཟၡॣݥᱧᥩ䉫ŭɯᕱ孳᥵ṷᱹᕻᵽ욁ﶇ붑ꚓꚕꢗ겙뎛얟캡얣튥솧얩슫\uddad\ud8af\udbb1\uc4b3억鞷풹즻펽ꊿꟁ뛃꿅ꛇ귉", num), BookmarkStart.b("就䄳嬵娷弹主圽⸿╁橃㹅╇♉", num));
        }
        if (this.bool_8)
        {
            this.method_512(stream, this.method_527(), BookmarkStart.b("娱䀳䈵䠷9ጻᄽ㌿⅁ⱃ⍅╇⭉㽋恍㽏≑ㅓ㡕⁗㝙せ㡝ཟၡॣݥᱧᥩ䉫ŭɯᕱ孳᥵ṷᱹᕻᵽ욁ﶇ붑ꚓꚕꢗ겙뎛얟캡얣튥솧얩슫\uddad\ud8af\udbb1\uc4b3억鞷\ud9b9\ud3bb펽궿ꟁ꫃닅믇", num), BookmarkStart.b("儱嬳嬵唷弹刻䨽㌿汁㱃⭅⑇", num));
        }
        if (this.bool_9)
        {
            this.method_512(stream, this.method_527(), BookmarkStart.b("娱䀳䈵䠷9ጻᄽ㌿⅁ⱃ⍅╇⭉㽋恍㵏㭑㝓⑕㝗⥙㍛㡝ᑟ䱡ݣ॥է䕩ͫ࡭ᙯ᭱ᝳ፵坷䡹䱻佽녿궁ﾏﲑﺕ놝쎟춡즣쮥춧쒩\ud8ab\uddad쪱삳펵횷\udeb9\ud9bb\udabd", num), BookmarkStart.b("儱嬳嬵唷弹刻䨽㌿݁㱃㉅ⵇ⑉⡋⭍㑏籑ⱓ㭕㑗", num));
        }
        if (this.method_30())
        {
            this.method_512(stream, this.method_527(), BookmarkStart.b("娱䀳䈵䠷9ጻᄽ㌿⅁ⱃ⍅╇⭉㽋恍㽏≑ㅓ㡕⁗㝙せ㡝ཟၡॣݥᱧᥩ䉫ŭɯᕱ孳᥵ṷᱹᕻᵽ욁ﶇ붑ꚓꚕꢗ겙뎛얟캡얣튥솧얩슫\uddad\ud8af\udbb1\uc4b3억鞷\udfb9\ud2bb\udabd\uaebf귁냃ꏅ믇", num), BookmarkStart.b("圱娳刵嘷唹䠻嬽㌿汁㱃⭅⑇", num));
        }
        if (this.method_28())
        {
            this.method_512(stream, this.method_527(), BookmarkStart.b("娱䀳䈵䠷9ጻᄽ㌿⅁ⱃ⍅╇⭉㽋恍㽏≑ㅓ㡕⁗㝙せ㡝ཟၡॣݥᱧᥩ䉫ŭɯᕱ孳᥵ṷᱹᕻᵽ욁ﶇ붑ꚓꚕꢗ겙뎛얟캡얣튥솧얩슫\uddad\ud8af\udbb1\uc4b3억鞷\udcb9\ud3bb톽뒿곁ꯃ닅귇막", num), BookmarkStart.b("吱嬳夵䰷吹医䨽┿ㅁ橃㹅╇♉", num));
        }
        this.method_104(stream);
        if (this.method_26())
        {
            this.method_512(stream, this.method_527(), BookmarkStart.b("娱䀳䈵䠷9ጻᄽ㌿⅁ⱃ⍅╇⭉㽋恍㽏≑ㅓ㡕⁗㝙せ㡝ཟၡॣݥᱧᥩ䉫ŭɯᕱ孳᥵ṷᱹᕻᵽ욁ﶇ붑ꚓꚕꢗ겙뎛얟캡얣튥솧얩슫\uddad\ud8af\udbb1\uc4b3억鞷\udcb9\ud3bb킽뒿雁ꗃ꓅꓇꿉", num), BookmarkStart.b("吱嬳堵䰷渹崻尽ⰿ❁橃㹅╇♉", num));
        }
        if (this.method_34())
        {
            this.method_512(stream, this.method_527(), BookmarkStart.b("娱䀳䈵䠷9ጻᄽ㌿⅁ⱃ⍅╇⭉㽋恍㽏≑ㅓ㡕⁗㝙せ㡝ཟၡॣݥᱧᥩ䉫ŭɯᕱ孳᥵ṷᱹᕻᵽ욁ﶇ붑ꚓꚕꢗ겙뎛얟캡얣튥솧얩슫\uddad\ud8af\udbb1\uc4b3억鞷캹풻\udbbd\uadbfꟁ", num), BookmarkStart.b("䘱尳匵唷弹ጻ䨽⠿❁⥃⍅祇摉㑋⍍㱏", num));
        }
        this.method_106(stream, this.method_7());
        this.method_103(stream, this.method_38());
        if (this.bool_14 && (this.method_10().Count > 0))
        {
            this.method_102(stream, this.method_10());
        }
        this.method_108(this.method_16());
        this.method_107(stream, this.method_20());
        if (this.document_0.CustomXMLContainer != null)
        {
            string[] array = new string[this.document_0.CustomXMLContainer.method_0().Count];
            this.document_0.CustomXMLContainer.method_0().Keys.CopyTo(array, 0);
            for (int i = 0; i < array.Length; i++)
            {
                string str2 = this.document_0.CustomXMLContainer.method_0()[array[i]].method_7();
                str2 = str2.StartsWith(BookmarkStart.b("儱䄳䔵䰷唹儻昽ⴿ⹁歃", num)) ? str2.Replace(BookmarkStart.b("儱䄳䔵䰷唹儻昽ⴿ⹁歃", num), string.Empty) : str2;
                if (!str2.Contains(BookmarkStart.b("戱䘳夵䠷䤹", num)))
                {
                    this.method_512(stream, this.method_527(), BookmarkStart.b("娱䀳䈵䠷9ጻᄽ㌿⅁ⱃ⍅╇⭉㽋恍㽏≑ㅓ㡕⁗㝙せ㡝ཟၡॣݥᱧᥩ䉫ŭɯᕱ孳᥵ṷᱹᕻᵽ욁ﶇ붑ꚓꚕꢗ겙뎛얟캡얣튥솧얩슫\uddad\ud8af\udbb1\uc4b3억鞷\ud9b9\uc9bb춽뒿귁꧃黅ꗇꛉ", num), BookmarkStart.b("ᰱᨳᤵ嬷伹伻䨽⼿⽁᱃⭅⑇敉", num) + str2);
                }
            }
        }
        if (this.document_0.IsSaveTemplate && (this.document_0.GlossaryContainer != null))
        {
            string[] strArray3 = new string[this.document_0.GlossaryContainer.method_0().Count];
            this.document_0.GlossaryContainer.method_0().Keys.CopyTo(strArray3, 0);
            foreach (string str in strArray3)
            {
                if (str.ToLower() == BookmarkStart.b("嘱嬳唵䴷圹夻倽㐿汁㱃⭅⑇", num))
                {
                    this.method_512(stream, this.method_527(), BookmarkStart.b("娱䀳䈵䠷9ጻᄽ㌿⅁ⱃ⍅╇⭉㽋恍㽏≑ㅓ㡕⁗㝙せ㡝ཟၡॣݥᱧᥩ䉫ŭɯᕱ孳᥵ṷᱹᕻᵽ욁ﶇ붑ꚓꚕꢗ겙뎛얟캡얣튥솧얩슫\uddad\ud8af\udbb1\uc4b3억鞷\uddb9\ud0bb톽뎿뇁ꗃ듅뇇軉ꏋ귍ꗏ뿑뇓룕곗", num), BookmarkStart.b("唱堳夵䬷䤹崻䰽㤿流⁃⥅⭇㽉⅋⭍㹏♑穓⹕㕗㙙", num));
                    break;
                }
            }
        }
        if (this.document_0.IsContainMacro && this.document_0.IsMacroEnabled)
        {
            this.method_512(stream, this.method_527(), BookmarkStart.b("娱䀳䈵䠷9ጻᄽ㌿⅁ⱃ⍅╇⭉㽋恍㵏㭑㝓⑕㝗⥙㍛㡝ᑟ䱡ݣ॥է䕩ͫ࡭ᙯ᭱ᝳ፵坷䡹䱻乽뙿궁ﾏﲑﺕ놝횟삡얣\udaa7\uc5a9욫쮭펯욱", num), BookmarkStart.b("䐱嘳圵样䠹医吽┿⅁ぃ桅⩇⍉≋", num));
        }
        this.class1092_0.method_12();
        this.class1092_0.method_15();
        this.class771_0.method_14(BookmarkStart.b("䔱嬳䐵尷昹挻䰽┿⹁㝃ᩅⱇ╉⽋㭍㵏㝑㩓≕癗≙ㅛ㉝也ၡţ੥᭧", num), stream, false, FileAttributes.Archive);
    }

    private void method_101()
    {
        this.dictionary_32 = this.document_0.DocxNameSpace.method_0()[BookmarkStart.b("琥䴧䘩䴫娭夯崱娳䔵倷匹䰻䴽", 0)];
        MemoryStream stream = new MemoryStream();
        this.class1092_0 = this.method_524(stream);
        this.class1092_0.method_10(BookmarkStart.b("琥䴧䘩䴫娭夯崱娳䔵倷匹䰻䴽", 0), this.dictionary_32[BookmarkStart.b("帥䔧䘩䈫崭", 0)]);
        this.method_103(stream, this.method_25());
        this.class1092_0.method_12();
        this.class1092_0.method_15();
        this.class771_0.method_14(BookmarkStart.b("儥䜧堩䠫爭漯䀱儳娵䬷昹刻䬽ⴿ⁁⅃㑅ⅇ⑉⭋恍⡏㽑㡓硕⩗㽙せⵝ", 0), stream, false, FileAttributes.Archive);
    }

    private void method_102(MemoryStream A_0, Dictionary<string, string> A_1)
    {
        int num = 15;
        if (A_1 != null)
        {
            string str = string.Empty;
            foreach (string str2 in A_1.Keys)
            {
                str = A_1[str2];
                this.method_512(A_0, str2, BookmarkStart.b("崴䌶䴸䬺ܼှ湀あ♄⽆ⱈ♊ⱌ㱎罐㱒╔㉖㝘⍚ぜ㍞ݠౢᝤ੦ࡨὪṬ䅮ṰŲቴ塶ᙸᵺ᭼ᙾ솄ﺊﾐ몔ꖖꦘꮚꮜ낞펠욢즤욦\udda8\uc2aa슬솮슰\udbb2\udcb4잶쪸钺햼욾뇀ꛂ럄ꯆꃈꗊꛌ", num), str);
            }
        }
    }

    private void method_103(MemoryStream A_0, Dictionary<string, Class517> A_1)
    {
        int num = 0x10;
        if (A_1 != null)
        {
            if (this.dictionary_31 == null)
            {
                this.dictionary_31 = new Dictionary<string, string>();
            }
            string str2 = string.Empty;
            foreach (string str in A_1.Keys)
            {
                Class517 class2 = A_1[str];
                if (class2 == null)
                {
                    str2 = BookmarkStart.b("䄵圷䠹堻戽ⴿ❁⁃⽅⥇ᙉ╋⍍ㅏ㕑ㅓ晕癗すⱛ㭝ݟ", num);
                    this.method_512(A_0, str, BookmarkStart.b("帵䰷丹䰻н漿流㝃╅⁇⽉⅋⽍⍏籑㭓♕㵗㑙⑛㍝౟ѡୣᑥէ୩ᡫᵭ幯ᵱٳᅵ坷ᕹ᩻᡽슅曆ﲑ릕ꪗꪙ겛ꢝ辟킡솣쪥즧\udea9\uc5ab솭\udeaf\uc1b1\udcb3\udfb5좷즹鎻ힽ궿ꏁꏃꏅ", num), str2.Replace(BookmarkStart.b("䄵圷䠹堻戽", num), ""));
                }
                else
                {
                    string key = Class1009.smethod_2(class2.method_3());
                    if (this.dictionary_31.ContainsKey(key))
                    {
                        str2 = this.dictionary_31[key];
                    }
                    else if (class2.method_3() != null)
                    {
                        str2 = BookmarkStart.b("䄵圷䠹堻戽ⴿ❁⁃⽅⥇ᙉ╋⍍ㅏ㕑ㅓ", num) + str.Replace(BookmarkStart.b("䐵焷帹", num), "") + (class2.method_7() ? BookmarkStart.b("ᠵ伷圹娻", num) : BookmarkStart.b("ᠵ刷䨹夻夽", num));
                        this.dictionary_31.Add(key, str2);
                        if (this.class771_0.method_29(str2.Replace(BookmarkStart.b("樵", num), BookmarkStart.b("ᤵ", num))) == -1)
                        {
                            this.class771_0.method_14(str2, new MemoryStream(class2.method_3()), false, FileAttributes.Archive);
                        }
                    }
                    this.method_512(A_0, str, BookmarkStart.b("帵䰷丹䰻н漿流㝃╅⁇⽉⅋⽍⍏籑㭓♕㵗㑙⑛㍝౟ѡୣᑥէ୩ᡫᵭ幯ᵱٳᅵ坷ᕹ᩻᡽슅曆ﲑ릕ꪗꪙ겛ꢝ辟킡솣쪥즧\udea9\uc5ab솭\udeaf\uc1b1\udcb3\udfb5좷즹鎻ힽ궿ꏁꏃꏅ", num), str2.Replace(BookmarkStart.b("䄵圷䠹堻戽", num), ""));
                }
            }
        }
    }

    private void method_104(MemoryStream A_0)
    {
        this.method_105(HeaderFooterType.FooterEven, A_0);
        this.method_105(HeaderFooterType.HeaderEven, A_0);
        this.method_105(HeaderFooterType.FooterFirstPage, A_0);
        this.method_105(HeaderFooterType.HeaderFirstPage, A_0);
        this.method_105(HeaderFooterType.FooterOdd, A_0);
        this.method_105(HeaderFooterType.HeaderOdd, A_0);
    }

    private void method_105(HeaderFooterType A_0, MemoryStream A_1)
    {
        int num = 1;
        string str = string.Empty;
        if (this.method_1().ContainsKey(A_0))
        {
            Dictionary<string, HeaderFooter> dictionary = this.method_1()[A_0];
            foreach (string str2 in dictionary.Keys)
            {
                string str3;
                if (((A_0 != HeaderFooterType.HeaderEven) && (A_0 != HeaderFooterType.HeaderFirstPage)) && (A_0 != HeaderFooterType.HeaderOdd))
                {
                    str = BookmarkStart.b("䄦䘨䐪夬䨮䌰", num) + str2.Replace(BookmarkStart.b("唦怨伪", num), "") + BookmarkStart.b("द儨䘪䄬", num);
                    str3 = BookmarkStart.b("伦崨弪崬ᔮḰᰲ䘴吶儸帺值帾㉀浂⩄㝆ⱈ╊㕌≎㵐㕒㩔╖㑘㩚⥜ⱞ你ౢᝤf䙨Ѫ୬८ᡰၲၴ㍶ᙸ᡺ࡼቾꢆ뮈뮊붌릎뺐ﮖ쾠킢춤캦\ud9a8\ud8aa芬즮\udeb0\udcb2솴튶쮸", num);
                }
                else
                {
                    str = BookmarkStart.b("伦䰨䨪䤬䨮䌰", num) + str2.Replace(BookmarkStart.b("唦怨伪", num), "") + BookmarkStart.b("द儨䘪䄬", num);
                    str3 = BookmarkStart.b("伦崨弪崬ᔮḰᰲ䘴吶儸帺值帾㉀浂⩄㝆ⱈ╊㕌≎㵐㕒㩔╖㑘㩚⥜ⱞ你ౢᝤf䙨Ѫ୬८ᡰၲၴ㍶ᙸ᡺ࡼቾꢆ뮈뮊붌릎뺐ﮖ쾠킢춤캦\ud9a8\ud8aa芬잮풰튲톴튶쮸", num);
                }
                this.method_512(A_1, str2, str3, str);
            }
        }
    }

    private void method_106(MemoryStream A_0, Dictionary<string, string> A_1)
    {
        int num = 0;
        if ((A_1 != null) && (A_1.Count > 0))
        {
            foreach (string str in A_1.Keys)
            {
                string str2 = A_1[str];
                this.method_512(A_0, str, BookmarkStart.b("严尧帩尫ᐭἯᴱ䜳唵倷弹儻弽㌿汁⭃㙅ⵇ⑉㑋⍍㱏㑑㭓⑕㕗㭙⡛ⵝ也ൡᙣť䝧թ੫࡭᥯ᅱᅳ㉵᝷᥹ॻ፽ꦅ몇몉벋뢍뾏歹聯캟톡첣쾥\ud8a7\ud9a9莫잭\uddaf\ud3b1펳펵", num), str2);
            }
        }
    }

    private void method_107(MemoryStream A_0, Dictionary<string, DictionaryEntry> A_1)
    {
        if (A_1.Count != 0)
        {
            string str3 = string.Empty;
            string key = string.Empty;
            foreach (string str in A_1.Keys)
            {
                DictionaryEntry entry = A_1[str];
                key = (string) entry.Key;
                str3 = (string) entry.Value;
                this.method_512(A_0, str, key, str3);
            }
        }
    }

    private void method_108(Dictionary<string, Stream> A_0)
    {
        int num = 0x11;
        string str = null;
        if (A_0.Count > 0)
        {
            foreach (KeyValuePair<string, Stream> pair in A_0)
            {
                str = BookmarkStart.b("䀶嘸䤺夼挾⑀⹂❄≆ⵈ⽊⑌ⅎ㙐⁒॔", num) + pair.Key;
                this.class771_0.method_14(str, pair.Value, false, FileAttributes.Archive);
            }
        }
    }

    private void method_109(Background A_0)
    {
        int num = 0x11;
        if (A_0.Type != BackgroundType.NoBackground)
        {
            this.class1092_0.method_10(BookmarkStart.b("唶堸堺嘼堾㍀ⱂい⥆ⵈ", num), this.dictionary_32[BookmarkStart.b("䀶", num)]);
            switch (A_0.Type)
            {
                case BackgroundType.Gradient:
                {
                    BackgroundGradient gradient = A_0.Gradient;
                    this.class1092_0.method_5(BookmarkStart.b("吶嘸场刼䴾", num), this.dictionary_32[BookmarkStart.b("䀶", num)], this.method_535(gradient.Color1));
                    this.method_110(gradient);
                    break;
                }
                case BackgroundType.Picture:
                case BackgroundType.Texture:
                    if (A_0.ImageBytes != null)
                    {
                        this.class1092_0.method_5(BookmarkStart.b("吶嘸场刼䴾", num), this.dictionary_32[BookmarkStart.b("䀶", num)], this.method_535(A_0.Color));
                        this.class1092_0.method_10(BookmarkStart.b("唶堸堺嘼堾㍀ⱂい⥆ⵈ", num), this.dictionary_32[BookmarkStart.b("䄶", num)]);
                        if (A_0.FillType != BackgroundFillType.msofillPicture)
                        {
                            this.class1092_0.method_4(BookmarkStart.b("儶倸场儼尾⹀⽂⩄㕆", num), this.method_535(A_0.Color));
                        }
                        this.class1092_0.method_10(BookmarkStart.b("儶倸场儼", num), this.dictionary_32[BookmarkStart.b("䄶", num)]);
                        DocPicture picture = new DocPicture(A_0.Document);
                        picture.LoadImage(A_0.ImageBytes);
                        this.method_113(picture);
                        string str = this.method_336(this.method_38(), picture.ImageRecord);
                        this.class1092_0.method_5(BookmarkStart.b("帶崸", num), this.dictionary_32[BookmarkStart.b("䔶", num)], str);
                        this.class1092_0.method_5(BookmarkStart.b("䌶倸伺儼娾", num), this.dictionary_32[BookmarkStart.b("堶", num)], A_0.FillBlipName);
                        this.class1092_0.method_4(BookmarkStart.b("吶嘸场刼䴾獀", num), BookmarkStart.b("ᐶ", num) + this.method_535(A_0.Gradient.Color2));
                        if (A_0.FillType == BackgroundFillType.msofillPattern)
                        {
                            this.class1092_0.method_4(BookmarkStart.b("䌶䀸䬺堼", num), BookmarkStart.b("䜶堸伺䤼娾㍀ⵂ", num));
                        }
                        else
                        {
                            this.class1092_0.method_4(BookmarkStart.b("䌶䀸䬺堼", num), (A_0.Type == BackgroundType.Picture) ? BookmarkStart.b("儶䬸娺值娾", num) : BookmarkStart.b("䌶倸场堼", num));
                        }
                        this.class1092_0.method_12();
                        this.class1092_0.method_12();
                    }
                    break;

                case BackgroundType.Color:
                    this.class1092_0.method_5(BookmarkStart.b("吶嘸场刼䴾", num), this.dictionary_32[BookmarkStart.b("䀶", num)], this.method_535(A_0.Color));
                    break;
            }
            this.class1092_0.method_12();
        }
    }

    internal Dictionary<string, string> method_11()
    {
        if (this.dictionary_23 == null)
        {
            this.dictionary_23 = new Dictionary<string, string>();
        }
        return this.dictionary_23;
    }

    private void method_110(BackgroundGradient A_0)
    {
        int num = 13;
        this.class1092_0.method_10(BookmarkStart.b("儲吴吶券尺似倾㑀ⵂ⅄", 13), this.dictionary_32[BookmarkStart.b("䔲", 13)]);
        if (A_0.Color1 != Color.White)
        {
            this.class1092_0.method_4(BookmarkStart.b("唲尴嬶唸堺刼匾⹀ㅂ", num), BookmarkStart.b("ဲ", num) + this.method_535(A_0.Color1));
        }
        this.class1092_0.method_10(BookmarkStart.b("唲尴嬶唸", num), this.dictionary_32[BookmarkStart.b("䔲", num)]);
        this.method_112(A_0);
        this.method_111(A_0);
        this.class1092_0.method_12();
        this.class1092_0.method_12();
    }

    private void method_111(BackgroundGradient A_0)
    {
        int num = 15;
        switch (A_0.ShadingStyle)
        {
            case GradientShadingStyle.Vertical:
                this.class1092_0.method_4(BookmarkStart.b("吴夶常场堼", num), BookmarkStart.b("ᠴึस", num));
                break;

            case GradientShadingStyle.DiagonalUp:
                this.class1092_0.method_4(BookmarkStart.b("吴夶常场堼", num), BookmarkStart.b("ᠴضਸฺ", num));
                break;

            case GradientShadingStyle.DiagonalDown:
            case GradientShadingStyle.FromCorner:
            case GradientShadingStyle.FromCenter:
                this.class1092_0.method_4(BookmarkStart.b("吴夶常场堼", num), BookmarkStart.b("ᠴ̶స", num));
                break;
        }
        this.class1092_0.method_4(BookmarkStart.b("場制䴸区刼嬾", num), BookmarkStart.b("头帶圸帺尼䴾慀あⱄ⁆⑈⩊", num));
        if (A_0.ShadingStyle == GradientShadingStyle.FromCorner)
        {
            this.class1092_0.method_4(BookmarkStart.b("匴堶娸为丼", num), BookmarkStart.b("дܶसḺ", num));
        }
        else if (A_0.ShadingVariant == GradientShadingVariant.ShadingMiddle)
        {
            this.class1092_0.method_4(BookmarkStart.b("匴堶娸为丼", num), BookmarkStart.b("4ܶ᰸", num));
        }
        else if (A_0.ShadingVariant == GradientShadingVariant.ShadingOut)
        {
            this.class1092_0.method_4(BookmarkStart.b("匴堶娸为丼", num), BookmarkStart.b("ᠴȶसḺ", num));
        }
        else if (A_0.ShadingVariant == GradientShadingVariant.ShadingUp)
        {
            this.class1092_0.method_4(BookmarkStart.b("匴堶娸为丼", num), BookmarkStart.b("дܶसḺ", num));
        }
        if (A_0.ShadingStyle == GradientShadingStyle.FromCenter)
        {
            this.class1092_0.method_4(BookmarkStart.b("䄴丶䤸帺", num), BookmarkStart.b("刴䔶堸强吼娾⽀㝂ᝄ♆ⵈ≊ⱌ⍎", num));
        }
        else
        {
            this.class1092_0.method_4(BookmarkStart.b("䄴丶䤸帺", num), BookmarkStart.b("刴䔶堸强吼娾⽀㝂", num));
        }
        if (((A_0.ShadingStyle == GradientShadingStyle.FromCorner) && ((A_0.FocusLeft != 0.0) || (A_0.FocusTop != 0.0))) || (A_0.ShadingStyle == GradientShadingStyle.FromCenter))
        {
            if (A_0.ShadingStyle == GradientShadingStyle.FromCorner)
            {
                if ((A_0.FocusLeft == 1.0) && (A_0.FocusTop == 1.0))
                {
                    this.class1092_0.method_4(BookmarkStart.b("匴堶娸为丼伾⹀あⱄ㍆⁈⑊⍌", num), BookmarkStart.b("дᬶ࠸", num));
                }
                else if (A_0.FocusLeft == 1.0)
                {
                    this.class1092_0.method_4(BookmarkStart.b("匴堶娸为丼伾⹀あⱄ㍆⁈⑊⍌", num), BookmarkStart.b("д", num));
                }
                else if (A_0.FocusTop == 1.0)
                {
                    this.class1092_0.method_4(BookmarkStart.b("匴堶娸为丼伾⹀あⱄ㍆⁈⑊⍌", num), BookmarkStart.b("ᤴض", num));
                }
            }
            else
            {
                this.class1092_0.method_4(BookmarkStart.b("匴堶娸为丼伾⹀あⱄ㍆⁈⑊⍌", num), BookmarkStart.b("᬴ȶᔸᔺ࠼", num));
            }
            this.class1092_0.method_4(BookmarkStart.b("匴堶娸为丼䰾⡀㥂⁄", num), "");
        }
        if ((A_0.ShadingStyle == GradientShadingStyle.FromCorner) || ((A_0.ShadingStyle == GradientShadingStyle.FromCenter) && (A_0.ShadingVariant == GradientShadingVariant.ShadingDown)))
        {
            this.class1092_0.method_10(BookmarkStart.b("匴帶唸场", num), this.dictionary_32[BookmarkStart.b("娴", num)]);
            this.class1092_0.method_4(BookmarkStart.b("倴伶䴸", num), BookmarkStart.b("䌴帶尸䰺", num));
            this.class1092_0.method_4(BookmarkStart.b("䄴丶䤸帺", num), BookmarkStart.b("刴䔶堸强吼娾⽀㝂ل≆❈㽊⡌㵎", num));
            this.class1092_0.method_12();
        }
    }

    private void method_112(BackgroundGradient A_0)
    {
        int num = 0x10;
        if (A_0.Color2 != Color.White)
        {
            if (A_0.Color2.Name[0] == 'e')
            {
                int num2 = int.Parse(A_0.Color2.Name.Substring(6), NumberStyles.HexNumber);
                if (A_0.Color2.Name[5] == '1')
                {
                    this.class1092_0.method_4(BookmarkStart.b("唵圷嘹医䰽爿", num), BookmarkStart.b("倵儷嘹倻ḽ␿⍁㙃ⵅⵇ⑉摋", num) + num2 + BookmarkStart.b("ἵ", num));
                }
                else
                {
                    this.class1092_0.method_4(BookmarkStart.b("唵圷嘹医䰽爿", num), BookmarkStart.b("倵儷嘹倻ḽⰿ⭁⍃⹅㱇⽉≋晍", num) + num2 + BookmarkStart.b("ἵ", num));
                }
            }
            else
            {
                this.class1092_0.method_4(BookmarkStart.b("唵圷嘹医䰽爿", num), BookmarkStart.b("ᔵ", num) + this.method_535(A_0.Color2));
            }
        }
    }

    private void method_113(DocPicture A_0)
    {
        if (A_0.IsMetaFile)
        {
            this.bool_6 = true;
        }
        else
        {
            this.bool_0 = true;
        }
    }

    private void method_114()
    {
        int num = 15;
        if (this.document_0.Sections.Count == 0)
        {
            throw new Exception(BookmarkStart.b("愴弶尸䤺堼Ἶ⁀ㅂ⁄杆❈⑊浌㱎㑐げ⅔㹖㙘㕚⹜罞ᅠᅢdᑦ౨ժᥬ佮ᡰᵲ啴ͶᅸṺ嵼᭾歷", num));
        }
        this.class1092_0.method_10(BookmarkStart.b("圴堶崸䈺", num), this.dictionary_32[BookmarkStart.b("䈴", num)]);
        foreach (Section section in this.document_0.Sections)
        {
            this.method_115(section);
        }
        this.class1092_0.method_12();
    }

    private void method_115(Section A_0)
    {
        bool flag = false;
        if (A_0.NextSibling == null)
        {
            flag = true;
        }
        if ((A_0.Body.ChildObjects.Count == 0) && !flag)
        {
            A_0.AddParagraph();
        }
        if ((A_0.Body.ChildObjects.LastItem is Table) && !flag)
        {
            A_0.AddParagraph();
        }
        this.method_116(A_0.Body.Items, flag);
        if (flag)
        {
            this.method_387(A_0);
        }
    }

    internal void method_116(BodyRegionCollection A_0, bool A_1)
    {
        for (int i = 0; i < A_0.Count; i++)
        {
            this.method_117(A_0[i], A_1);
        }
    }

    private void method_117(BodyRegion A_0, bool A_1)
    {
        int num = 13;
        if (A_0 == null)
        {
            throw new ArgumentException(BookmarkStart.b("焲娴匶䀸爺䤼娾ⱀ捂㙄⽆♈㹊⅌⭎煐㵒㩔⍖祘㥚㡜罞འᙢ।୦", num));
        }
        switch (A_0.DocumentObjectType)
        {
            case DocumentObjectType.Paragraph:
                this.method_185(A_0 as Paragraph, A_1);
                return;

            case DocumentObjectType.StructureDocumentTag:
                this.method_124(A_0 as StructureDocumentTag);
                return;

            case DocumentObjectType.Table:
                this.method_137(A_0 as Table);
                return;
        }
    }

    private void method_118(StructureDocumentTagInline A_0)
    {
        int num = 4;
        this.class1092_0.method_10(BookmarkStart.b("天䠫娭", 4), this.dictionary_32[BookmarkStart.b("崩", 4)]);
        this.method_125(A_0.SDTProperties);
        if (A_0.BreakCharacterFormat != null)
        {
            this.class1092_0.method_10(BookmarkStart.b("天䠫娭甯就倳昵䨷", num), this.dictionary_32[BookmarkStart.b("崩", num)]);
            this.method_463(A_0.BreakCharacterFormat);
            this.class1092_0.method_12();
        }
        this.method_123(A_0.SDTContent.Items);
        this.class1092_0.method_12();
    }

    internal void method_119(PermissionStart A_0)
    {
        int num = 0x10;
        string id = A_0.Id;
        int num2 = this.method_544();
        if (!this.dictionary_9.ContainsKey(id))
        {
            this.dictionary_9.Add(id, num2);
        }
        else
        {
            this.dictionary_9[id] = num2;
        }
        this.class1092_0.method_11(BookmarkStart.b("䄵", num), BookmarkStart.b("䘵崷䠹儻洽㐿⍁㙃㉅", num), this.dictionary_32[BookmarkStart.b("䄵", num)]);
        this.class1092_0.method_6(BookmarkStart.b("䄵", num), BookmarkStart.b("張尷", num), this.dictionary_32[BookmarkStart.b("䄵", num)], num2.ToString());
        if (A_0.ColumnFirst >= 0)
        {
            this.class1092_0.method_6(BookmarkStart.b("䄵", num), BookmarkStart.b("唵圷嘹稻圽㈿ㅁぃ", num), this.dictionary_32[BookmarkStart.b("䄵", num)], A_0.ColumnFirst.ToString());
        }
        if (A_0.ColumnLast >= 0)
        {
            this.class1092_0.method_6(BookmarkStart.b("䄵", num), BookmarkStart.b("唵圷嘹瀻弽㌿㙁", num), this.dictionary_32[BookmarkStart.b("䄵", num)], A_0.ColumnLast.ToString());
        }
        if (A_0.EditorGroup != EditingGroup.None)
        {
            this.class1092_0.method_6(BookmarkStart.b("䄵", num), BookmarkStart.b("匵尷紹主丽", num), this.dictionary_32[BookmarkStart.b("䄵", num)], this.method_121(A_0.EditorGroup));
        }
        if (A_0.DisplacedByCustomXml != DisplacedByCustomXml.None)
        {
            this.class1092_0.method_6(BookmarkStart.b("䄵", num), BookmarkStart.b("刵儷䤹䰻刽ℿ⅁⅃≅ੇ㍉ཋ㭍⍏♑㭓㭕W㝙せ", num), this.dictionary_32[BookmarkStart.b("䄵", num)], this.method_122(A_0.DisplacedByCustomXml));
        }
        if (!string.IsNullOrEmpty(A_0.Editor) && !A_0.Editor.Equals(""))
        {
            this.class1092_0.method_6(BookmarkStart.b("䄵", num), BookmarkStart.b("匵尷", num), this.dictionary_32[BookmarkStart.b("䄵", num)], A_0.Editor);
        }
        this.class1092_0.method_12();
    }

    internal Dictionary<string, string> method_12()
    {
        if (this.dictionary_24 == null)
        {
            this.dictionary_24 = new Dictionary<string, string>();
        }
        return this.dictionary_24;
    }

    internal void method_120(PermissionEnd A_0)
    {
        int num = 14;
        if (this.dictionary_9.ContainsKey(A_0.Id))
        {
            int num2 = this.dictionary_9[A_0.Id];
            this.class1092_0.method_11(BookmarkStart.b("䌳", num), BookmarkStart.b("䐳匵䨷圹礻倽␿", num), this.dictionary_32[BookmarkStart.b("䌳", num)]);
            this.class1092_0.method_6(BookmarkStart.b("䌳", num), BookmarkStart.b("崳刵", num), this.dictionary_32[BookmarkStart.b("䌳", num)], num2.ToString());
            if (A_0.DisplacedByCustomXml != DisplacedByCustomXml.None)
            {
                this.class1092_0.method_6(BookmarkStart.b("䌳", num), BookmarkStart.b("倳張䬷䨹倻弽⌿❁⁃хㅇॉ㥋㵍⑏㵑㥓๕㕗㙙", num), this.dictionary_32[BookmarkStart.b("䌳", num)], this.method_122(A_0.DisplacedByCustomXml));
            }
        }
        this.class1092_0.method_12();
    }

    private string method_121(EditingGroup A_0)
    {
        int num = 6;
        switch (A_0)
        {
            case EditingGroup.Administrators:
                return BookmarkStart.b("䴫䨭崯嬱娳張䬷丹主弽㐿ⵁ㙃㕅", num);

            case EditingGroup.Contributors:
                return BookmarkStart.b("伫䄭帯䘱䘳張娷伹䠻儽㈿ㅁ", num);

            case EditingGroup.Current:
                return BookmarkStart.b("伫嬭䈯䀱儳堵䰷", num);

            case EditingGroup.Editors:
                return BookmarkStart.b("䤫䨭夯䘱嬳䐵䬷", num);

            case EditingGroup.Everyone:
                return BookmarkStart.b("䤫堭唯䀱䴳夵嘷弹", num);

            case EditingGroup.Owners:
                return BookmarkStart.b("䌫夭帯圱䘳䔵", num);
        }
        return "";
    }

    private string method_122(DisplacedByCustomXml A_0)
    {
        int num = 0;
        switch (A_0)
        {
            case DisplacedByCustomXml.Next:
                return BookmarkStart.b("䠥䴧利堫", num);

            case DisplacedByCustomXml.Prev:
                return BookmarkStart.b("嘥娧伩娫", num);
        }
        return "";
    }

    private void method_123(ParagraphItemCollection A_0)
    {
        this.class1092_0.method_10(BookmarkStart.b("尮唰䜲瘴堶圸伺堼儾㕀", 9), this.dictionary_32[BookmarkStart.b("堮", 9)]);
        this.method_189(A_0);
        this.class1092_0.method_12();
    }

    private void method_124(StructureDocumentTag A_0)
    {
        int num = 15;
        if ((A_0.SDTProperties.SDTType != SdtType.None) && (A_0.SDTProperties.SDTType != SdtType.RichText))
        {
            BookmarkStart start = A_0.method_23() as BookmarkStart;
            if (start != null)
            {
                this.bool_23 = true;
                this.method_366(start);
            }
        }
        this.class1092_0.method_10(BookmarkStart.b("䘴匶䴸", num), this.dictionary_32[BookmarkStart.b("䈴", num)]);
        this.method_125(A_0.SDTProperties);
        if (A_0.BreakCharacterFormat != null)
        {
            this.class1092_0.method_10(BookmarkStart.b("䘴匶䴸縺匼嬾ᅀㅂ", num), this.dictionary_32[BookmarkStart.b("䈴", num)]);
            this.method_463(A_0.BreakCharacterFormat);
            this.class1092_0.method_12();
        }
        this.method_136(A_0.SDTContent);
        this.class1092_0.method_12();
        if ((A_0.SDTProperties.SDTType != SdtType.None) && (A_0.SDTProperties.SDTType != SdtType.RichText))
        {
            BookmarkEnd end = A_0.method_24() as BookmarkEnd;
            if (end != null)
            {
                this.method_364(end);
            }
        }
        this.bool_23 = false;
    }

    private void method_125(SDTProperties A_0)
    {
        int num = 1;
        this.class1092_0.method_10(BookmarkStart.b("否䴨弪紬崮", 1), this.dictionary_32[BookmarkStart.b("倦", 1)]);
        this.method_463(A_0.CharacterFormat);
        if (A_0.Id != 0M)
        {
            this.class1092_0.method_10(BookmarkStart.b("並䴨", num), this.dictionary_32[BookmarkStart.b("倦", num)]);
            this.class1092_0.method_6(BookmarkStart.b("倦", num), BookmarkStart.b("儦䠨䜪", num), this.dictionary_32[BookmarkStart.b("倦", num)], A_0.Id.ToString());
            this.class1092_0.method_12();
        }
        if ((A_0.Alias != null) && (A_0.Alias != string.Empty))
        {
            this.class1092_0.method_10(BookmarkStart.b("䘦䔨䈪䰬尮", num), this.dictionary_32[BookmarkStart.b("倦", num)]);
            this.class1092_0.method_6(BookmarkStart.b("倦", num), BookmarkStart.b("儦䠨䜪", num), this.dictionary_32[BookmarkStart.b("倦", num)], A_0.Alias);
            this.class1092_0.method_12();
        }
        if (!string.IsNullOrEmpty(A_0.Tag))
        {
            this.class1092_0.method_10(BookmarkStart.b("匦䠨䰪", num), this.dictionary_32[BookmarkStart.b("倦", num)]);
            this.class1092_0.method_6(BookmarkStart.b("倦", num), BookmarkStart.b("儦䠨䜪", num), this.dictionary_32[BookmarkStart.b("倦", num)], A_0.Tag);
            this.class1092_0.method_12();
        }
        if (A_0.IsShowingPlaceHolder)
        {
            this.class1092_0.method_10(BookmarkStart.b("否䄨䐪娬䘮弰吲攴嬶娸猺夼䴾", num), this.dictionary_32[BookmarkStart.b("倦", num)]);
            this.class1092_0.method_12();
        }
        if (A_0.Bibliograph)
        {
            this.class1092_0.method_10(BookmarkStart.b("䔦䀨䤪䄬䘮帰吲䜴嘶䤸区䐼", num), this.dictionary_32[BookmarkStart.b("倦", num)]);
            this.class1092_0.method_12();
        }
        if (A_0.LockSettings != LockSettingsType.UnLocked)
        {
            this.method_129(A_0.LockSettings);
        }
        this.method_127(A_0);
        if (A_0.SDTType != SdtType.None)
        {
            this.method_130(A_0);
        }
        this.class1092_0.method_12();
    }

    private void method_126(SdtDocPart A_0)
    {
        int num = 15;
        if (!string.IsNullOrEmpty(A_0.BuildingBlockType))
        {
            this.class1092_0.method_10(BookmarkStart.b("儴堶娸欺尼䴾㕀т⑄⭆╈⹊㽌㙎", num), this.dictionary_32[BookmarkStart.b("䈴", num)]);
            this.class1092_0.method_5(BookmarkStart.b("䌴嘶唸", num), this.dictionary_32[BookmarkStart.b("䈴", num)], A_0.BuildingBlockType);
            this.class1092_0.method_12();
        }
        if (!string.IsNullOrEmpty(A_0.BuildingBlockCategory))
        {
            this.class1092_0.method_10(BookmarkStart.b("儴堶娸欺尼䴾㕀B⑄㍆ⱈⱊ≌㵎⡐", num), this.dictionary_32[BookmarkStart.b("䈴", num)]);
            this.class1092_0.method_5(BookmarkStart.b("䌴嘶唸", num), this.dictionary_32[BookmarkStart.b("䈴", num)], A_0.BuildingBlockCategory);
            this.class1092_0.method_12();
        }
        if (A_0.IsUnique)
        {
            this.class1092_0.method_10(BookmarkStart.b("儴堶娸欺尼䴾㕀ᙂ⭄⹆㡈㹊⡌", num), this.dictionary_32[BookmarkStart.b("䈴", num)]);
            this.class1092_0.method_12();
        }
    }

    private void method_127(SDTProperties A_0)
    {
        int num = 0x11;
        int num2 = this.document_0.method_159();
        if ((A_0.DataBinding != null) && (A_0.SDTType != SdtType.RichText))
        {
            Class443 dataBinding = A_0.DataBinding;
            if (((A_0.SDTType == SdtType.None) && (num2 < 15)) && this.method_128(A_0.Owner))
            {
                return;
            }
            string str = ((A_0.SDTType != SdtType.None) || (num2 < 15)) ? this.dictionary_32[BookmarkStart.b("䀶", num)] : this.dictionary_32[BookmarkStart.b("䀶࠸ฺ", num)];
            this.class1092_0.method_10(BookmarkStart.b("匶堸伺尼紾⡀ⵂ⅄⹆❈ⱊ", num), str);
            if (!string.IsNullOrEmpty(dataBinding.method_12()))
            {
                this.class1092_0.method_6(BookmarkStart.b("䀶", num), BookmarkStart.b("䜶䬸帺嬼嘾㥀โ⑄㝆㥈≊⍌⡎≐", num), this.dictionary_32[BookmarkStart.b("䀶", num)], dataBinding.method_12());
            }
            if (!string.IsNullOrEmpty(dataBinding.method_13()))
            {
                this.class1092_0.method_6(BookmarkStart.b("䀶", num), BookmarkStart.b("伶䤸娺䤼圾", num), this.dictionary_32[BookmarkStart.b("䀶", num)], dataBinding.method_13());
            }
            if (!string.IsNullOrEmpty(dataBinding.method_14()))
            {
                this.class1092_0.method_6(BookmarkStart.b("䀶", num), BookmarkStart.b("䐶䴸吺似娾ࡀ㝂⁄⩆Hཊ", num), this.dictionary_32[BookmarkStart.b("䀶", num)], dataBinding.method_14());
            }
            this.class1092_0.method_12();
        }
        if (num2 >= 15)
        {
            if (A_0.RepeatingSection)
            {
                this.class1092_0.method_10(BookmarkStart.b("䔶尸䬺堼帾㕀⩂⭄⁆ᩈ⹊⹌㭎㡐㱒㭔", num), this.dictionary_32[BookmarkStart.b("䀶࠸ฺ", num)]);
                this.class1092_0.method_12();
            }
            if (A_0.RepeatingSectionItem)
            {
                this.class1092_0.method_10(BookmarkStart.b("䔶尸䬺堼帾㕀⩂⭄⁆ᩈ⹊⹌㭎㡐㱒㭔Ṗⵘ㹚ぜ", num), this.dictionary_32[BookmarkStart.b("䀶࠸ฺ", num)]);
                this.class1092_0.method_12();
            }
        }
    }

    private bool method_128(DocumentObject A_0)
    {
        bool flag = false;
        if (A_0 != null)
        {
            using (IEnumerator enumerator = A_0.ChildObjects.GetEnumerator())
            {
                while (enumerator.MoveNext())
                {
                    DocumentObject current = (DocumentObject) enumerator.Current;
                    if ((current is IStructureDocument) && ((current as IStructureDocument).SDTProperties.DataBinding != null))
                    {
                        goto Label_005F;
                    }
                    if ((current.ChildObjects.Count > 0) && (flag = this.method_128(current)))
                    {
                        return flag;
                    }
                }
                return flag;
            Label_005F:
                flag = true;
            }
        }
        return flag;
    }

    private void method_129(LockSettingsType A_0)
    {
        int num = 0x11;
        this.class1092_0.method_10(BookmarkStart.b("嬶嘸堺嘼", 0x11), this.dictionary_32[BookmarkStart.b("䀶", 0x11)]);
        switch (A_0)
        {
            case LockSettingsType.ContentLocked:
                this.class1092_0.method_6(BookmarkStart.b("䀶", num), BookmarkStart.b("䄶堸场", num), this.dictionary_32[BookmarkStart.b("䀶", num)], BookmarkStart.b("吶嘸唺䤼娾⽀㝂ॄ⡆⩈⁊⡌⭎", num));
                break;

            case LockSettingsType.SDTContentLocked:
                this.class1092_0.method_6(BookmarkStart.b("䀶", num), BookmarkStart.b("䄶堸场", num), this.dictionary_32[BookmarkStart.b("䀶", num)], BookmarkStart.b("䐶崸伺縼倾⽀㝂⁄⥆㵈݊≌ⱎ㩐㙒ㅔ", num));
                break;

            case LockSettingsType.SDTLocked:
                this.class1092_0.method_6(BookmarkStart.b("䀶", num), BookmarkStart.b("䄶堸场", num), this.dictionary_32[BookmarkStart.b("䀶", num)], BookmarkStart.b("䐶崸伺焼倾≀⡂⁄⍆", num));
                break;
        }
        this.class1092_0.method_12();
    }

    internal Dictionary<string, Dictionary<string, string>> method_13()
    {
        if (this.dictionary_25 == null)
        {
            this.dictionary_25 = new Dictionary<string, Dictionary<string, string>>();
        }
        return this.dictionary_25;
    }

    private void method_130(SDTProperties A_0)
    {
        int num = 0;
        switch (A_0.SDTType)
        {
            case SdtType.Citation:
                this.class1092_0.method_10(BookmarkStart.b("䔥䄧帩䴫娭夯崱娳", num), this.dictionary_32[BookmarkStart.b("儥", num)]);
                this.class1092_0.method_12();
                return;

            case SdtType.ComboBox:
                this.class1092_0.method_10(BookmarkStart.b("䔥䜧䜩丫䄭爯崱䰳", num), this.dictionary_32[BookmarkStart.b("儥", num)]);
                this.method_133(A_0.ControlProperties as SdtComboBox);
                this.class1092_0.method_12();
                return;

            case SdtType.DropDownList:
                this.class1092_0.method_10(BookmarkStart.b("䈥娧䔩尫樭弯䔱娳稵儷䤹䠻", num), this.dictionary_32[BookmarkStart.b("儥", num)]);
                this.method_132(A_0.ControlProperties as SdtDropDownList);
                this.class1092_0.method_12();
                return;

            case SdtType.Picture:
                this.class1092_0.method_10(BookmarkStart.b("嘥䄧䤩堫嬭䈯圱", num), this.dictionary_32[BookmarkStart.b("儥", num)]);
                this.class1092_0.method_12();
                return;

            case SdtType.RichText:
                this.class1092_0.method_10(BookmarkStart.b("吥䄧䤩䐫稭唯䨱䀳", num), this.dictionary_32[BookmarkStart.b("儥", num)]);
                if ((A_0.ControlProperties is SdtText) && (A_0.ControlProperties as SdtText).IsMultiline)
                {
                    this.class1092_0.method_6(BookmarkStart.b("儥", num), BookmarkStart.b("䬥崧䘩堫䜭簯嬱娳匵", num), this.dictionary_32[BookmarkStart.b("儥", num)], BookmarkStart.b("ᜥ", num));
                }
                this.class1092_0.method_12();
                return;

            case SdtType.Text:
                this.class1092_0.method_10(BookmarkStart.b("別䴧利堫", num), this.dictionary_32[BookmarkStart.b("儥", num)]);
                if ((A_0.ControlProperties is SdtText) && (A_0.ControlProperties as SdtText).IsMultiline)
                {
                    this.class1092_0.method_6(BookmarkStart.b("儥", num), BookmarkStart.b("䬥崧䘩堫䜭簯嬱娳匵", num), this.dictionary_32[BookmarkStart.b("儥", num)], BookmarkStart.b("ᜥ", num));
                }
                this.class1092_0.method_12();
                return;

            case SdtType.Equation:
                this.class1092_0.method_10(BookmarkStart.b("䌥大弩䴫娭夯崱娳", num), this.dictionary_32[BookmarkStart.b("儥", num)]);
                this.class1092_0.method_12();
                return;

            case SdtType.DatePicker:
                this.method_134(A_0.ControlProperties as SdtDate);
                return;

            case SdtType.BuildingBlockGallery:
                this.class1092_0.method_10(BookmarkStart.b("䈥䜧䤩簫伭䈯䘱砳張䬷丹", num), this.dictionary_32[BookmarkStart.b("儥", num)]);
                this.method_126(A_0.ControlProperties as SdtDocPart);
                this.class1092_0.method_12();
                return;

            case SdtType.DocPartObj:
                this.class1092_0.method_10(BookmarkStart.b("䈥䜧䤩簫伭䈯䘱笳吵刷", num), this.dictionary_32[BookmarkStart.b("儥", num)]);
                this.method_126(A_0.ControlProperties as SdtDocPart);
                this.class1092_0.method_12();
                return;

            case SdtType.Group:
                this.class1092_0.method_10(BookmarkStart.b("䄥娧䔩夫席", num), this.dictionary_32[BookmarkStart.b("儥", num)]);
                this.class1092_0.method_12();
                return;

            case SdtType.CheckBox:
                this.class1092_0.method_10(BookmarkStart.b("䔥䀧伩伫䔭刯崱䰳", num), this.dictionary_32[BookmarkStart.b("儥ᤧḩ", num)]);
                this.method_131(A_0.ControlProperties as SdtCheckBox);
                this.class1092_0.method_12();
                return;
        }
    }

    private void method_131(SdtCheckBox A_0)
    {
        int num = 0;
        if (A_0 != null)
        {
            this.class1092_0.method_10(BookmarkStart.b("䔥䀧伩伫䔭唯嘱", num), this.dictionary_32[BookmarkStart.b("儥ᤧḩ", num)]);
            if (A_0.Checked)
            {
                this.class1092_0.method_5(BookmarkStart.b("倥䤧䘩", num), this.dictionary_32[BookmarkStart.b("儥ᤧḩ", num)], BookmarkStart.b("ᜥ", num));
            }
            else
            {
                this.class1092_0.method_5(BookmarkStart.b("倥䤧䘩", num), this.dictionary_32[BookmarkStart.b("儥ᤧḩ", num)], BookmarkStart.b("ᘥ", num));
            }
            this.class1092_0.method_12();
            this.class1092_0.method_10(BookmarkStart.b("䔥䀧伩伫䔭唯嘱朳䈵夷丹夻", num), this.dictionary_32[BookmarkStart.b("儥ᤧḩ", num)]);
            A_0.CheckedState.method_3();
            this.class1092_0.method_5(BookmarkStart.b("倥䤧䘩", num), this.dictionary_32[BookmarkStart.b("儥ᤧḩ", num)], string.Format(BookmarkStart.b("崥ᠧဩ含ᨭ䴯", num), A_0.CheckedState.method_3()));
            if (!string.IsNullOrEmpty(A_0.CheckedState.method_1()))
            {
                this.class1092_0.method_5(BookmarkStart.b("䀥䜧䐩堫", num), this.dictionary_32[BookmarkStart.b("儥ᤧḩ", num)], A_0.CheckedState.method_1());
            }
            this.class1092_0.method_12();
            this.class1092_0.method_10(BookmarkStart.b("匥䘧䤩䐫䬭匯失儳刵欷丹崻䨽┿", num), this.dictionary_32[BookmarkStart.b("儥ᤧḩ", num)]);
            A_0.UncheckedState.method_3();
            this.class1092_0.method_5(BookmarkStart.b("倥䤧䘩", num), this.dictionary_32[BookmarkStart.b("儥ᤧḩ", num)], string.Format(BookmarkStart.b("崥ᠧဩ含ᨭ䴯", num), A_0.UncheckedState.method_3()));
            if (A_0.UncheckedState.method_1() != null)
            {
                this.class1092_0.method_5(BookmarkStart.b("䀥䜧䐩堫", num), this.dictionary_32[BookmarkStart.b("儥ᤧḩ", num)], A_0.UncheckedState.method_1());
            }
            this.class1092_0.method_12();
        }
    }

    private void method_132(SdtDropDownList A_0)
    {
        int num = 6;
        if (!string.IsNullOrEmpty(A_0.LastValue))
        {
            this.class1092_0.method_6(BookmarkStart.b("嬫", num), BookmarkStart.b("䀫伭䌯䘱戳圵吷伹夻", num), this.dictionary_32[BookmarkStart.b("嬫", num)], A_0.LastValue);
        }
        foreach (SdtListItem item in A_0.ListItems)
        {
            this.class1092_0.method_10(BookmarkStart.b("䀫䜭䌯䘱紳䈵崷圹", num), this.dictionary_32[BookmarkStart.b("嬫", num)]);
            if ((item.DisplayText != null) && (item.DisplayText != string.Empty))
            {
                this.class1092_0.method_6(BookmarkStart.b("嬫", num), BookmarkStart.b("䠫䜭䌯䈱堳圵䄷渹夻䘽㐿", num), this.dictionary_32[BookmarkStart.b("嬫", num)], item.DisplayText);
            }
            this.class1092_0.method_6(BookmarkStart.b("嬫", num), BookmarkStart.b("娫伭尯䜱儳", num), this.dictionary_32[BookmarkStart.b("嬫", num)], item.Value);
            this.class1092_0.method_12();
        }
    }

    private void method_133(SdtComboBox A_0)
    {
        int num = 0x12;
        if ((A_0.LastValue != null) && (A_0.LastValue != string.Empty))
        {
            this.class1092_0.method_6(BookmarkStart.b("伷", num), BookmarkStart.b("吷嬹伻䨽ᘿ⍁⡃㍅ⵇ", num), this.dictionary_32[BookmarkStart.b("伷", num)], A_0.LastValue);
        }
        foreach (SdtListItem item in A_0.ListItems)
        {
            this.class1092_0.method_10(BookmarkStart.b("吷匹伻䨽ि㙁⅃⭅", num), this.dictionary_32[BookmarkStart.b("伷", num)]);
            if ((item.DisplayText != null) && (item.DisplayText != string.Empty))
            {
                this.class1092_0.method_6(BookmarkStart.b("伷", num), BookmarkStart.b("尷匹伻丽ⰿ⍁㵃ቅⵇ㉉㡋", num), this.dictionary_32[BookmarkStart.b("伷", num)], item.DisplayText);
            }
            this.class1092_0.method_6(BookmarkStart.b("伷", num), BookmarkStart.b("丷嬹倻䬽┿", num), this.dictionary_32[BookmarkStart.b("伷", num)], item.Value);
            this.class1092_0.method_12();
        }
    }

    private void method_134(SdtDate A_0)
    {
        int num = 0x11;
        this.class1092_0.method_10(BookmarkStart.b("匶堸伺堼", 0x11), this.dictionary_32[BookmarkStart.b("䀶", 0x11)]);
        if (A_0.FullDate != DateTime.MinValue)
        {
            this.class1092_0.method_6(BookmarkStart.b("䀶", num), BookmarkStart.b("䄶堸场", num), this.dictionary_32[BookmarkStart.b("䀶", num)], SdtDate.smethod_0(A_0.FullDate));
        }
        if (A_0.CalendarType != CalendarType.None)
        {
            this.class1092_0.method_10(BookmarkStart.b("吶堸场堼儾╀≂㝄", num), this.dictionary_32[BookmarkStart.b("䀶", num)]);
            this.class1092_0.method_6(BookmarkStart.b("䀶", num), BookmarkStart.b("䄶堸场", num), this.dictionary_32[BookmarkStart.b("䀶", num)], this.method_135(A_0.CalendarType));
            this.class1092_0.method_12();
        }
        if (!string.IsNullOrEmpty(A_0.DateFormat))
        {
            this.class1092_0.method_10(BookmarkStart.b("匶堸伺堼社⹀ㅂ⡄♆㵈", num), this.dictionary_32[BookmarkStart.b("䀶", num)]);
            this.class1092_0.method_6(BookmarkStart.b("䀶", num), BookmarkStart.b("䄶堸场", num), this.dictionary_32[BookmarkStart.b("䀶", num)], A_0.DateFormat);
            this.class1092_0.method_12();
        }
        if (A_0.Lid != -1)
        {
            this.class1092_0.method_10(BookmarkStart.b("嬶倸强", num), this.dictionary_32[BookmarkStart.b("䀶", num)]);
            this.class1092_0.method_6(BookmarkStart.b("䀶", num), BookmarkStart.b("䄶堸场", num), this.dictionary_32[BookmarkStart.b("䀶", num)], this.method_499(A_0.Lid));
            this.class1092_0.method_12();
        }
        this.class1092_0.method_12();
    }

    private string method_135(CalendarType A_0)
    {
        int num = 11;
        switch (A_0)
        {
            case CalendarType.Default:
                return BookmarkStart.b("嘰䄲倴倶嘸䤺吼帾⽀", num);

            case CalendarType.GregorianArabic:
                return BookmarkStart.b("嘰䄲倴倶嘸䤺吼帾⽀ɂ㝄♆⭈≊⹌", num);

            case CalendarType.GregorianMiddleEastFrench:
                return BookmarkStart.b("嘰䄲倴倶嘸䤺吼帾⽀โ⁄ņ㭈⹊⍌ⱎ㥐", num);

            case CalendarType.GregorianEnglish:
                return BookmarkStart.b("嘰䄲倴倶嘸䤺吼帾⽀ᙂ㙄", num);

            case CalendarType.GregorianTransliteratedEnglish:
                return BookmarkStart.b("嘰䄲倴倶嘸䤺吼帾⽀ᭂ⥄⹆㵈๊⍌⡎㵐㩒♔㽖", num);

            case CalendarType.GregorianTransliteratedFrench:
                return BookmarkStart.b("嘰䄲倴倶嘸䤺吼帾⽀ᭂ⥄⹆㵈ൊ㽌⩎㽐げ㵔", num);

            case CalendarType.Hebrew:
                return BookmarkStart.b("夰嘲圴䔶尸䰺", num);

            case CalendarType.Hijri:
                return BookmarkStart.b("夰娲弴䔶倸", num);

            case CalendarType.Japan:
                return BookmarkStart.b("嬰刲䔴嘶圸", num);

            case CalendarType.Korean:
                return BookmarkStart.b("娰尲䜴制堸", num);

            case CalendarType.Saka:
                return BookmarkStart.b("䈰刲帴嘶", num);

            case CalendarType.Taiwan:
                return BookmarkStart.b("䔰刲尴䀶堸唺", num);

            case CalendarType.Thai:
                return BookmarkStart.b("䔰嬲吴帶", num);
        }
        return null;
    }

    private void method_136(Body A_0)
    {
        this.class1092_0.method_10(BookmarkStart.b("崭启䘱眳夵嘷丹夻倽㐿", 8), this.dictionary_32[BookmarkStart.b("夭", 8)]);
        BodyRegion region = null;
        if (A_0 != null)
        {
            PermissionStart start = A_0.method_42() as PermissionStart;
            if (start != null)
            {
                this.bool_24 = true;
                this.method_119(start);
            }
        }
        for (int i = 0; i < A_0.Items.Count; i++)
        {
            region = A_0.Items[i];
            this.method_117(region, false);
        }
        if (A_0 != null)
        {
            PermissionEnd end = A_0.method_43() as PermissionEnd;
            if (end != null)
            {
                this.method_120(end);
            }
        }
        this.bool_24 = false;
        this.class1092_0.method_12();
    }

    private void method_137(Table A_0)
    {
        int num = 15;
        if ((A_0 != null) && (A_0.Rows.Count > 0))
        {
            A_0.method_75();
            this.class1092_0.method_10(BookmarkStart.b("䄴唶唸", num), this.dictionary_32[BookmarkStart.b("䈴", num)]);
            if ((A_0 != null) && !A_0.IsHasCaculatedCellWidth)
            {
                A_0.method_46();
            }
            if (A_0.Rows.Count > 0)
            {
                RowFormat format = A_0.DocxTableFormat.HasFormat ? A_0.DocxTableFormat.Format : A_0.Rows[0].RowFormat;
                format = A_0.TableFormat.Borders.NoBorder ? format : A_0.TableFormat;
                this.method_160(format, A_0);
            }
            else
            {
                this.method_160(A_0.DocxTableFormat.Format, A_0);
            }
            this.method_181(A_0);
            this.method_138(A_0.Rows);
            this.class1092_0.method_12();
        }
    }

    private void method_138(RowCollection A_0)
    {
        if (A_0.Count > 0)
        {
            bool flag = (A_0[0].OwnerTable != null) && A_0[0].OwnerTable.IsInsertRevision;
            bool flag2 = (A_0[0].OwnerTable != null) && A_0[0].OwnerTable.IsDeleteRevision;
            foreach (TableRow row in A_0)
            {
                if (row is StructureDocumentTagRow)
                {
                    this.method_139(row as StructureDocumentTagRow, flag, flag2);
                }
                else
                {
                    this.method_141(row, flag, flag2);
                }
                this.method_140();
                this.list_3.Clear();
            }
        }
    }

    private void method_139(StructureDocumentTagRow A_0, bool A_1, bool A_2)
    {
        int num = 1;
        if (A_0 != null)
        {
            this.class1092_0.method_10(BookmarkStart.b("否䴨弪", num), this.dictionary_32[BookmarkStart.b("倦", num)]);
            this.method_125(A_0.SDTProperties);
            if ((A_0.BreakCharacterFormat != null) && !A_0.BreakCharacterFormat.IsDefault)
            {
                this.class1092_0.method_10(BookmarkStart.b("否䴨弪栬䄮唰挲䜴", num), this.dictionary_32[BookmarkStart.b("倦", num)]);
                this.method_463(A_0.BreakCharacterFormat);
                this.class1092_0.method_12();
            }
            this.class1092_0.method_10(BookmarkStart.b("否䴨弪測䀮弰䜲倴夶䴸", num), this.dictionary_32[BookmarkStart.b("倦", num)]);
            if (A_0.SdtRows.Count > 0)
            {
                this.method_139(A_0.SdtRows.method_13(0), A_1, A_2);
            }
            else
            {
                this.method_141(A_0, A_1, A_2);
            }
            this.class1092_0.method_12();
            this.class1092_0.method_12();
        }
    }

    internal Dictionary<string, Comment> method_14()
    {
        if (this.dictionary_19 == null)
        {
            this.dictionary_19 = new Dictionary<string, Comment>();
        }
        return this.dictionary_19;
    }

    private void method_140()
    {
        if (this.list_2.Count > 0)
        {
            int num = 0;
            int count = this.list_2.Count;
            while (num < count)
            {
                this.method_365(this.list_2[num]);
                num++;
            }
            this.list_2.Clear();
        }
    }

    private void method_141(TableRow A_0, bool A_1, bool A_2)
    {
        this.class1092_0.method_10(BookmarkStart.b("䄴䔶", 15), this.dictionary_32[BookmarkStart.b("䈴", 15)]);
        this.method_155(A_0);
        this.method_142(A_0.Cells);
        this.class1092_0.method_12();
    }

    private void method_142(CellCollection A_0)
    {
        foreach (TableCell cell in A_0)
        {
            if (cell is StructureDocumentTagCell)
            {
                this.method_143(cell as StructureDocumentTagCell);
            }
            else
            {
                this.method_144(cell);
            }
        }
    }

    private void method_143(StructureDocumentTagCell A_0)
    {
        int num = 11;
        if (A_0 != null)
        {
            if ((A_0.SDTProperties.SDTType != SdtType.None) && (A_0.SDTProperties.SDTType != SdtType.RichText))
            {
                BookmarkStart start = A_0.method_56() as BookmarkStart;
                if (start != null)
                {
                    this.bool_23 = true;
                    this.method_366(start);
                }
            }
            this.class1092_0.method_10(BookmarkStart.b("䈰圲䄴", num), this.dictionary_32[BookmarkStart.b("䘰", num)]);
            this.method_125(A_0.SDTProperties);
            if (A_0.BreakCharacterFormat != null)
            {
                this.class1092_0.method_10(BookmarkStart.b("䈰圲䄴父圸强洼䴾", num), this.dictionary_32[BookmarkStart.b("䘰", num)]);
                this.method_463(A_0.BreakCharacterFormat);
                this.class1092_0.method_12();
            }
            this.class1092_0.method_10(BookmarkStart.b("䈰圲䄴琶嘸唺䤼娾⽀㝂", num), this.dictionary_32[BookmarkStart.b("䘰", num)]);
            this.method_144(A_0);
            this.class1092_0.method_12();
            this.class1092_0.method_12();
            if ((A_0.SDTProperties.SDTType != SdtType.None) && (A_0.SDTProperties.SDTType != SdtType.RichText))
            {
                BookmarkEnd end = A_0.method_58() as BookmarkEnd;
                if (end != null)
                {
                    this.method_364(end);
                }
            }
            this.bool_23 = false;
        }
    }

    private void method_144(TableCell A_0)
    {
        int num = 10;
        this.class1092_0.method_10(BookmarkStart.b("䐯儱", 10), this.dictionary_32[BookmarkStart.b("䜯", 10)]);
        this.method_146(A_0.CellFormat);
        if (A_0.Items.Count > 0)
        {
            int num2 = 0;
            BodyRegion region = null;
            while (num2 < A_0.Items.Count)
            {
                region = A_0.Items[num2];
                if (region is Paragraph)
                {
                    int num1 = A_0.Items.Count - 1;
                }
                this.method_117(region, false);
                num2++;
            }
            if (A_0.Items.LastItem.DocumentObjectType == DocumentObjectType.Table)
            {
                this.class1092_0.method_10(BookmarkStart.b("䀯", num), this.dictionary_32[BookmarkStart.b("䜯", num)]);
                this.class1092_0.method_12();
            }
        }
        else
        {
            this.class1092_0.method_10(BookmarkStart.b("䀯", num), this.dictionary_32[BookmarkStart.b("䜯", num)]);
            this.class1092_0.method_10(BookmarkStart.b("䀯戱䘳", num), this.dictionary_32[BookmarkStart.b("䜯", num)]);
            this.class1092_0.method_10(BookmarkStart.b("䀯愱䀳伵吷弹", num), this.dictionary_32[BookmarkStart.b("䜯", num)]);
            this.class1092_0.method_6(BookmarkStart.b("䜯", num), BookmarkStart.b("䘯匱堳", num), this.dictionary_32[BookmarkStart.b("䜯", num)], BookmarkStart.b("縯崱䘳嬵夷嘹", num));
            this.class1092_0.method_12();
            this.method_463(A_0.CharacterFormat);
            this.class1092_0.method_12();
            this.class1092_0.method_12();
        }
        this.class1092_0.method_12();
    }

    private void method_145(CharacterFormat A_0, CharacterFormat A_1)
    {
    }

    private void method_146(CellFormat A_0)
    {
        int num = 8;
        TableCell ownerBase = A_0.OwnerBase as TableCell;
        RowFormat tableFormat = ownerBase.OwnerRow.OwnerTable.TableFormat;
        RowFormat rowFormat = ownerBase.OwnerRow.RowFormat;
        this.class1092_0.method_10(BookmarkStart.b("娭匯戱䘳", 8), this.dictionary_32[BookmarkStart.b("夭", 8)]);
        this.method_157(ownerBase);
        this.method_154(ownerBase);
        this.method_152(ownerBase);
        this.method_150(A_0);
        this.class1092_0.method_10(BookmarkStart.b("娭匯瀱嬳䐵尷弹主䴽", 8), this.dictionary_32[BookmarkStart.b("夭", 8)]);
        this.method_395(A_0.Borders, 8);
        this.class1092_0.method_12();
        this.method_149(ownerBase, tableFormat, rowFormat);
        if ((ownerBase.cellFormat_1 != null) && !this.bool_17)
        {
            this.bool_17 = true;
            this.method_479(BookmarkStart.b("娭匯戱䘳电倷嬹刻夽┿", num));
            this.method_146(ownerBase.TrackCellFormat);
            this.class1092_0.method_12();
            this.bool_17 = false;
        }
        this.method_484(A_0);
        if (A_0.XmlProps2010.Count > 0)
        {
            for (int i = 0; i < A_0.XmlProps2010.Count; i++)
            {
                if (this.method_525(A_0.XmlProps2010[i]).LocalName != BookmarkStart.b("䤭䈯嬱倳攵䠷嬹刻", num))
                {
                    this.method_272(A_0.XmlProps2010[i]);
                }
            }
        }
        if (!A_0.TextWrap)
        {
            this.class1092_0.method_10(BookmarkStart.b("䀭弯攱䘳圵䠷", num), this.dictionary_32[BookmarkStart.b("夭", num)]);
            this.class1092_0.method_6(BookmarkStart.b("夭", num), BookmarkStart.b("堭儯帱", num), this.dictionary_32[BookmarkStart.b("夭", num)], BookmarkStart.b("䠭儯帱䜳匵", num));
            this.class1092_0.method_12();
        }
        if (!A_0.SamePaddingsAsTable)
        {
            this.class1092_0.method_10(BookmarkStart.b("娭匯缱唳䐵", num), this.dictionary_32[BookmarkStart.b("夭", num)]);
            this.method_165(A_0.Paddings);
            this.class1092_0.method_12();
        }
        this.method_148(A_0);
        if (A_0.FitText)
        {
            this.class1092_0.method_10(BookmarkStart.b("娭匯琱崳䈵氷弹䐻䨽", num), this.dictionary_32[BookmarkStart.b("夭", num)]);
            this.class1092_0.method_6(BookmarkStart.b("夭", num), BookmarkStart.b("堭儯帱", num), this.dictionary_32[BookmarkStart.b("夭", num)], BookmarkStart.b("娭䈯䜱儳", num));
            this.class1092_0.method_12();
        }
        this.method_147(A_0.VerticalAlignment);
        if (A_0.HideMark)
        {
            this.class1092_0.method_10(BookmarkStart.b("䘭夯嘱儳笵夷䠹圻", num), this.dictionary_32[BookmarkStart.b("夭", num)]);
            this.class1092_0.method_12();
        }
        this.class1092_0.method_12();
    }

    private void method_147(VerticalAlignment A_0)
    {
        int num = 10;
        if (A_0 != VerticalAlignment.Top)
        {
            this.class1092_0.method_10(BookmarkStart.b("䘯猱堳張強吹", num), this.dictionary_32[BookmarkStart.b("䜯", num)]);
            switch (A_0)
            {
                case VerticalAlignment.Top:
                    this.class1092_0.method_6(BookmarkStart.b("䜯", num), BookmarkStart.b("䘯匱堳", num), this.dictionary_32[BookmarkStart.b("䜯", num)], BookmarkStart.b("䐯崱䐳", num));
                    break;

                case VerticalAlignment.Middle:
                    this.class1092_0.method_6(BookmarkStart.b("䜯", num), BookmarkStart.b("䘯匱堳", num), this.dictionary_32[BookmarkStart.b("䜯", num)], BookmarkStart.b("匯圱娳䈵崷䠹", num));
                    break;

                case VerticalAlignment.Bottom:
                    this.class1092_0.method_6(BookmarkStart.b("䜯", num), BookmarkStart.b("䘯匱堳", num), this.dictionary_32[BookmarkStart.b("䜯", num)], BookmarkStart.b("刯崱䀳䈵圷圹", num));
                    break;
            }
            this.class1092_0.method_12();
        }
    }

    private void method_148(CellFormat A_0)
    {
        int num = 1;
        if (A_0.TextDirection != TextDirection.TopToBottom)
        {
            this.class1092_0.method_10(BookmarkStart.b("匦䰨匪夬欮堰䄲倴吶䴸刺刼儾", num), this.dictionary_32[BookmarkStart.b("倦", num)]);
            switch (A_0.TextDirection)
            {
                case TextDirection.RightToLeft:
                    this.class1092_0.method_6(BookmarkStart.b("倦", num), BookmarkStart.b("儦䠨䜪", num), this.dictionary_32[BookmarkStart.b("倦", num)], BookmarkStart.b("匦䬨礪䄬", num));
                    break;

                case TextDirection.LeftToRight:
                    this.class1092_0.method_6(BookmarkStart.b("倦", num), BookmarkStart.b("儦䠨䜪", num), this.dictionary_32[BookmarkStart.b("倦", num)], BookmarkStart.b("䔦崨未弬", num));
                    break;

                case TextDirection.TopToBottomRotated:
                    this.class1092_0.method_6(BookmarkStart.b("倦", num), BookmarkStart.b("儦䠨䜪", num), this.dictionary_32[BookmarkStart.b("倦", num)], BookmarkStart.b("䬦嬨缪伬礮", num));
                    break;

                case TextDirection.RightToLeftRotated:
                    this.class1092_0.method_6(BookmarkStart.b("倦", num), BookmarkStart.b("儦䠨䜪", num), this.dictionary_32[BookmarkStart.b("倦", num)], BookmarkStart.b("匦䬨礪䄬礮", num));
                    break;

                default:
                    this.class1092_0.method_6(BookmarkStart.b("倦", num), BookmarkStart.b("儦䠨䜪", num), this.dictionary_32[BookmarkStart.b("倦", num)], BookmarkStart.b("䬦嬨缪伬", num));
                    break;
            }
            this.class1092_0.method_12();
        }
    }

    private void method_149(TableCell A_0, RowFormat A_1, RowFormat A_2)
    {
        int num = 2;
        CellFormat cellFormat = A_0.CellFormat;
        if ((cellFormat.HasValue(3) || cellFormat.HasValue(4)) || cellFormat.HasValue(5))
        {
            this.class1092_0.method_10(BookmarkStart.b("嬧䈩䠫", num), this.dictionary_32[BookmarkStart.b("弧", num)]);
            if ((cellFormat.BackColor == Color.Empty) && cellFormat.HasKey(3))
            {
                this.class1092_0.method_5(BookmarkStart.b("丧䌩䀫䈭", num), this.dictionary_32[BookmarkStart.b("弧", num)], BookmarkStart.b("䤧弩堫䄭", num));
            }
            else if (cellFormat.BackColor != Color.Empty)
            {
                this.class1092_0.method_5(BookmarkStart.b("丧䌩䀫䈭", num), this.dictionary_32[BookmarkStart.b("弧", num)], this.method_535(cellFormat.BackColor));
            }
            if ((A_0.ForeColor == Color.Empty) && A_0.CellFormat.HasKey(4))
            {
                this.class1092_0.method_5(BookmarkStart.b("䬧䔩䀫䄭䈯", num), this.dictionary_32[BookmarkStart.b("弧", num)], BookmarkStart.b("䤧弩堫䄭", num));
            }
            else if (A_0.ForeColor != Color.Empty)
            {
                this.class1092_0.method_5(BookmarkStart.b("䬧䔩䀫䄭䈯", num), this.dictionary_32[BookmarkStart.b("弧", num)], this.method_535(A_0.ForeColor));
            }
            string str = this.method_529(A_0.TextureStyle);
            this.class1092_0.method_6(BookmarkStart.b("弧", num), BookmarkStart.b("帧䬩䀫", num), this.dictionary_32[BookmarkStart.b("弧", num)], str);
            this.class1092_0.method_12();
        }
    }

    private Dictionary<int, string> method_15()
    {
        if (this.dictionary_18 == null)
        {
            this.dictionary_18 = new Dictionary<int, string>();
        }
        return this.dictionary_18;
    }

    private void method_150(CellFormat A_0)
    {
        int num = 3;
        if (A_0.HorizontalMerge != CellMerge.None)
        {
            this.class1092_0.method_10(BookmarkStart.b("䄨昪䠬崮嘰嘲", num), this.dictionary_32[BookmarkStart.b("帨", num)]);
            switch (A_0.HorizontalMerge)
            {
                case CellMerge.Start:
                    this.class1092_0.method_6(BookmarkStart.b("帨", num), BookmarkStart.b("弨䨪䄬", num), this.dictionary_32[BookmarkStart.b("帨", num)], BookmarkStart.b("嬨个帬嬮倰䄲䄴", num));
                    break;

                case CellMerge.Continue:
                    this.class1092_0.method_6(BookmarkStart.b("帨", num), BookmarkStart.b("弨䨪䄬", num), this.dictionary_32[BookmarkStart.b("帨", num)], BookmarkStart.b("䨨䐪䌬嬮堰崲䀴制", num));
                    break;
            }
            this.class1092_0.method_12();
        }
        if (A_0.VerticalMerge != CellMerge.None)
        {
            this.class1092_0.method_10(BookmarkStart.b("弨昪䠬崮嘰嘲", num), this.dictionary_32[BookmarkStart.b("帨", num)]);
            switch (A_0.VerticalMerge)
            {
                case CellMerge.Start:
                    this.class1092_0.method_6(BookmarkStart.b("帨", num), BookmarkStart.b("弨䨪䄬", num), this.dictionary_32[BookmarkStart.b("帨", num)], BookmarkStart.b("嬨个帬嬮倰䄲䄴", num));
                    break;

                case CellMerge.Continue:
                    this.class1092_0.method_6(BookmarkStart.b("帨", num), BookmarkStart.b("弨䨪䄬", num), this.dictionary_32[BookmarkStart.b("帨", num)], BookmarkStart.b("䨨䐪䌬嬮堰崲䀴制", num));
                    break;
            }
            this.class1092_0.method_12();
        }
    }

    private void method_151(CellFormat A_0)
    {
        int num = 8;
        if (!A_0.Borders.IsDefault)
        {
            this.class1092_0.method_10(BookmarkStart.b("娭匯瀱嬳䐵尷弹主䴽", num), this.dictionary_32[BookmarkStart.b("夭", num)]);
            this.method_395(A_0.Borders, 8);
            this.class1092_0.method_12();
        }
    }

    private void method_152(TableCell A_0)
    {
        int num = 3;
        int gridBefore = A_0.OwnerRow.RowFormat.GridBefore;
        if (gridBefore < 0)
        {
            gridBefore = 0;
        }
        if (A_0.GridSpan > 1)
        {
            this.class1092_0.method_10(BookmarkStart.b("丨太䐬䬮戰䌲吴夶", num), this.dictionary_32[BookmarkStart.b("帨", num)]);
            this.class1092_0.method_6(BookmarkStart.b("帨", num), BookmarkStart.b("弨䨪䄬", num), this.dictionary_32[BookmarkStart.b("帨", num)], A_0.GridSpan.ToString());
            this.class1092_0.method_12();
        }
        else if (((A_0 != null) && (A_0.OwnerRow != null)) && ((A_0.OwnerRow.OwnerTable != null) && !A_0.OwnerRow.OwnerTable.DocxTableFormat.HasFormat))
        {
            int num3 = this.method_153(A_0, gridBefore);
            if (num3 > 1)
            {
                this.class1092_0.method_10(BookmarkStart.b("丨太䐬䬮戰䌲吴夶", num), this.dictionary_32[BookmarkStart.b("帨", num)]);
                this.class1092_0.method_6(BookmarkStart.b("帨", num), BookmarkStart.b("弨䨪䄬", num), this.dictionary_32[BookmarkStart.b("帨", num)], num3.ToString());
                this.class1092_0.method_12();
            }
        }
    }

    private int method_153(TableCell A_0, int A_1)
    {
        if (A_0 == null)
        {
            return 1;
        }
        int num5 = A_0.method_5();
        Table ownerTable = A_0.OwnerRow.OwnerTable;
        float num11 = ownerTable.method_71(ownerTable);
        float num7 = num11 * 20f;
        float num6 = ownerTable.method_70(A_0, num11, false);
        if (A_0.CellFormat.VerticalMerge == CellMerge.Continue)
        {
            num6 = ownerTable.method_69(A_0.OwnerRow, A_0, num11);
        }
        if (num6 == num7)
        {
            return ((ownerTable.TableGrid.Count - 1) - A_1);
        }
        int num4 = A_1 + 1;
        for (TableCell cell = A_0.PreviousSibling as TableCell; cell != null; cell = cell.PreviousSibling as TableCell)
        {
            num4 += cell.int_7;
        }
        float num = num6;
        float num3 = 0f;
        if (num4 >= ownerTable.TableGrid.Count)
        {
            return 1;
        }
        float num2 = ownerTable.TableGrid[num4];
        if (num5 > 0)
        {
            num3 = ownerTable.TableGrid[num4 - 1];
        }
        else
        {
            num3 = ownerTable.TableGrid[A_1];
        }
        if (Class59.smethod_2((double) num, (double) (num2 - num3)) <= 10f)
        {
            A_0.int_7 = 1;
            return 1;
        }
        int num8 = num4 + 1;
        int num9 = 1;
        int count = ownerTable.TableGrid.Count;
        while (Class59.smethod_2((double) num, (double) (num2 - num3)) > 0)
        {
            if (num8 == count)
            {
                break;
            }
            num2 = ownerTable.TableGrid[num8];
            num9++;
            num8++;
        }
        A_0.int_7 = num9;
        return num9;
    }

    private void method_154(TableCell A_0)
    {
        int num2;
        int num = 5;
        switch (A_0.WidthType)
        {
            case FtsWidth.Auto:
                this.class1092_0.method_10(BookmarkStart.b("弪丬砮", num), this.dictionary_32[BookmarkStart.b("尪", num)]);
                this.class1092_0.method_5(BookmarkStart.b("弪听弮吰", num), this.dictionary_32[BookmarkStart.b("尪", num)], BookmarkStart.b("䨪堬嬮帰", num));
                this.class1092_0.method_5(BookmarkStart.b("尪", num), this.dictionary_32[BookmarkStart.b("尪", num)], BookmarkStart.b("ᬪ", num));
                this.class1092_0.method_12();
                return;

            case FtsWidth.Percentage:
                this.class1092_0.method_10(BookmarkStart.b("弪丬砮", num), this.dictionary_32[BookmarkStart.b("尪", num)]);
                this.class1092_0.method_5(BookmarkStart.b("弪听弮吰", num), this.dictionary_32[BookmarkStart.b("尪", num)], BookmarkStart.b("嬪丬嬮", num));
                this.class1092_0.method_5(BookmarkStart.b("尪", num), this.dictionary_32[BookmarkStart.b("尪", num)], this.method_534(A_0.Scaling * 50f));
                this.class1092_0.method_12();
                return;

            case FtsWidth.Point:
                this.class1092_0.method_10(BookmarkStart.b("弪丬砮", num), this.dictionary_32[BookmarkStart.b("尪", num)]);
                this.class1092_0.method_5(BookmarkStart.b("弪听弮吰", num), this.dictionary_32[BookmarkStart.b("尪", num)], BookmarkStart.b("伪唬丮", num));
                if (!this.bool_17)
                {
                    num2 = (int) Math.Round((double) (A_0.Width * 20f));
                    break;
                }
                num2 = (int) Math.Round((double) (A_0.TrackCellFormat.CellWidth * 20f));
                break;

            case FtsWidth.None:
                return;

            default:
                return;
        }
        this.class1092_0.method_5(BookmarkStart.b("尪", num), this.dictionary_32[BookmarkStart.b("尪", num)], num2.ToString());
        this.class1092_0.method_12();
    }

    private void method_155(TableRow A_0)
    {
        int num = 6;
        if (((A_0.OwnerTable.Owner != null) && ((A_0.OwnerTable.Owner.DocumentObjectType == DocumentObjectType.Table) || (A_0.OwnerTable.Owner.DocumentObjectType == DocumentObjectType.TableRow))) || A_0.HasTblPrEx)
        {
            this.class1092_0.method_10(BookmarkStart.b("堫䰭尯戱䘳猵䀷", num), this.dictionary_32[BookmarkStart.b("嬫", num)]);
            this.method_160(A_0.RowFormat, null);
            this.class1092_0.method_12();
        }
        this.class1092_0.method_10(BookmarkStart.b("堫尭怯䀱", num), this.dictionary_32[BookmarkStart.b("嬫", num)]);
        this.method_156(A_0);
        if (A_0.RowFormat.HasValue(0x7b))
        {
            this.class1092_0.method_10(BookmarkStart.b("䠫䜭䘯笱倳", num), this.dictionary_32[BookmarkStart.b("嬫", num)]);
            this.class1092_0.method_6(BookmarkStart.b("嬫", num), BookmarkStart.b("娫伭尯", num), this.dictionary_32[BookmarkStart.b("嬫", num)], A_0.RowFormat.DivId.ToString());
            this.class1092_0.method_12();
        }
        if (A_0.Height != 0f)
        {
            this.class1092_0.method_10(BookmarkStart.b("堫尭砯圱崳儵倷丹", num), this.dictionary_32[BookmarkStart.b("嬫", num)]);
            this.class1092_0.method_6(BookmarkStart.b("嬫", num), BookmarkStart.b("娫伭尯", num), this.dictionary_32[BookmarkStart.b("嬫", num)], this.method_534(Math.Abs(A_0.Height) * 20f));
            switch (A_0.HeightType)
            {
                case TableRowHeightType.AtLeast:
                    this.class1092_0.method_5(BookmarkStart.b("䐫簭䔯帱儳", num), this.dictionary_32[BookmarkStart.b("嬫", num)], BookmarkStart.b("䴫娭簯圱唳䔵䰷", num));
                    break;

                case TableRowHeightType.Exactly:
                    this.class1092_0.method_5(BookmarkStart.b("䐫簭䔯帱儳", num), this.dictionary_32[BookmarkStart.b("嬫", num)], BookmarkStart.b("䤫嘭儯儱䀳", num));
                    break;
            }
            this.class1092_0.method_12();
        }
        if (A_0.IsHeader)
        {
            this.class1092_0.method_10(BookmarkStart.b("堫䰭尯稱儳圵尷弹主", num), this.dictionary_32[BookmarkStart.b("嬫", num)]);
            this.class1092_0.method_12();
        }
        this.method_484(A_0.RowFormat);
        for (int i = 0; i < A_0.RowFormat.XmlProps2010.Count; i++)
        {
            this.method_272(A_0.RowFormat.XmlProps2010[i]);
        }
        if (A_0.RowFormat.GridBefore > 0)
        {
            this.class1092_0.method_10(BookmarkStart.b("䬫尭夯嘱瘳匵帷唹主嬽", num), this.dictionary_32[BookmarkStart.b("嬫", num)]);
            this.class1092_0.method_5(BookmarkStart.b("娫伭尯", num), this.dictionary_32[BookmarkStart.b("嬫", num)], A_0.RowFormat.GridBefore.ToString());
            this.class1092_0.method_12();
            this.class1092_0.method_10(BookmarkStart.b("嬫氭唯吱嬳䐵崷", num), this.dictionary_32[BookmarkStart.b("嬫", num)]);
            switch (A_0.RowFormat.GridBeforeWidth.method_51())
            {
                case FtsWidth.Percentage:
                    this.class1092_0.method_5(BookmarkStart.b("堫圭䀯圱", num), this.dictionary_32[BookmarkStart.b("嬫", num)], BookmarkStart.b("尫䴭䐯", num));
                    break;

                case FtsWidth.Point:
                    this.class1092_0.method_5(BookmarkStart.b("堫圭䀯圱", num), this.dictionary_32[BookmarkStart.b("嬫", num)], BookmarkStart.b("䠫嘭儯", num));
                    break;
            }
            this.class1092_0.method_5(BookmarkStart.b("嬫", num), this.dictionary_32[BookmarkStart.b("嬫", num)], A_0.RowFormat.GridBeforeWidth.method_49().ToString());
            this.class1092_0.method_12();
        }
        if (A_0.RowFormat.GridAfter > 0)
        {
            this.class1092_0.method_10(BookmarkStart.b("䬫尭夯嘱申倵䰷弹主", num), this.dictionary_32[BookmarkStart.b("嬫", num)]);
            this.class1092_0.method_5(BookmarkStart.b("娫伭尯", num), this.dictionary_32[BookmarkStart.b("嬫", num)], A_0.RowFormat.GridAfter.ToString());
            this.class1092_0.method_12();
            this.class1092_0.method_10(BookmarkStart.b("嬫漭嘯䘱儳䐵", num), this.dictionary_32[BookmarkStart.b("嬫", num)]);
            switch (A_0.RowFormat.GridAfterWidth.method_51())
            {
                case FtsWidth.Percentage:
                    this.class1092_0.method_5(BookmarkStart.b("堫圭䀯圱", num), this.dictionary_32[BookmarkStart.b("嬫", num)], BookmarkStart.b("尫䴭䐯", num));
                    break;

                case FtsWidth.Point:
                    this.class1092_0.method_5(BookmarkStart.b("堫圭䀯圱", num), this.dictionary_32[BookmarkStart.b("嬫", num)], BookmarkStart.b("䠫嘭儯", num));
                    break;
            }
            this.class1092_0.method_5(BookmarkStart.b("嬫", num), this.dictionary_32[BookmarkStart.b("嬫", num)], A_0.RowFormat.GridAfterWidth.method_49().ToString());
            this.class1092_0.method_12();
        }
        if (A_0.RowFormat.HasValue(0x1108) && !A_0.RowFormat.IsBreakAcrossPages)
        {
            this.class1092_0.method_10(BookmarkStart.b("伫伭帯䘱朳䘵吷匹䠻", num), this.dictionary_32[BookmarkStart.b("嬫", num)]);
            this.class1092_0.method_12();
        }
        if (A_0.RowFormat.HasValue(0xfaa))
        {
            if (A_0.RowFormat.Bidi)
            {
                this.class1092_0.method_10(BookmarkStart.b("丫䜭启嬱戳張䬷伹崻刽", num), this.dictionary_32[BookmarkStart.b("嬫", num)]);
                this.class1092_0.method_12();
            }
            this.class1092_0.method_10(BookmarkStart.b("䘫䴭", num), this.dictionary_32[BookmarkStart.b("嬫", num)]);
            switch (A_0.RowFormat.HorizontalAlignment)
            {
                case RowAlignment.Center:
                    this.class1092_0.method_6(BookmarkStart.b("嬫", num), BookmarkStart.b("娫伭尯", num), this.dictionary_32[BookmarkStart.b("嬫", num)], BookmarkStart.b("伫䬭帯䘱儳䐵", num));
                    break;

                case RowAlignment.Right:
                    this.class1092_0.method_6(BookmarkStart.b("嬫", num), BookmarkStart.b("娫伭尯", num), this.dictionary_32[BookmarkStart.b("嬫", num)], BookmarkStart.b("師䜭圯娱䀳", num));
                    break;

                default:
                    this.class1092_0.method_6(BookmarkStart.b("嬫", num), BookmarkStart.b("娫伭尯", num), this.dictionary_32[BookmarkStart.b("嬫", num)], BookmarkStart.b("䀫䬭嘯䘱", num));
                    break;
            }
            this.class1092_0.method_12();
        }
        if (A_0.IsInsertRevision)
        {
            this.method_479(BookmarkStart.b("䔫䀭䌯", num));
            this.class1092_0.method_12();
        }
        if (A_0.IsDeleteRevision)
        {
            this.method_479(BookmarkStart.b("䠫䬭尯", num));
            this.class1092_0.method_12();
        }
        this.class1092_0.method_12();
    }

    private void method_156(TableRow A_0)
    {
        int num = 0;
        IStyle style = this.document_0.Styles.FindByName(A_0.OwnerTable.TableStyleName, StyleType.TableStyle);
        if ((style != null) && ((style as Class13).method_25().Count > 0))
        {
            int rowIndex = A_0.GetRowIndex();
            Table ownerTable = A_0.OwnerTable;
            string str = BookmarkStart.b("ᘥ", num);
            string str2 = BookmarkStart.b("ᘥ", num);
            string str3 = BookmarkStart.b("ᘥ", num);
            string str4 = BookmarkStart.b("ᘥ", num);
            string str5 = BookmarkStart.b("ᘥ", num);
            string str6 = BookmarkStart.b("ᘥ", num);
            string str7 = BookmarkStart.b("ᘥ", num);
            string str8 = BookmarkStart.b("ᘥ", num);
            string str10 = BookmarkStart.b("ᘥ", num);
            string str9 = BookmarkStart.b("ᘥ", num);
            string str12 = BookmarkStart.b("ᘥ", num);
            string str11 = BookmarkStart.b("ᘥ", num);
            foreach (ConditionalFormattingCode code in (style as Class13).method_25().Keys)
            {
                switch (code)
                {
                    case ConditionalFormattingCode.OddRowBanding:
                        if (((rowIndex != (ownerTable.Rows.Count - 1)) && ((rowIndex % 2) == 1)) && ownerTable.ApplyStyleForBandedRows)
                        {
                            str7 = BookmarkStart.b("ᜥ", num);
                        }
                        break;

                    case ConditionalFormattingCode.EvenRowBanding:
                        if (((rowIndex != 0) && (rowIndex != (ownerTable.Rows.Count - 1))) && (((rowIndex % 2) == 0) && ownerTable.ApplyStyleForBandedRows))
                        {
                            str8 = BookmarkStart.b("ᜥ", num);
                        }
                        break;

                    case ConditionalFormattingCode.FirstRow:
                        if ((rowIndex == 0) && ownerTable.ApplyStyleForHeaderRow)
                        {
                            str = BookmarkStart.b("ᜥ", num);
                        }
                        break;

                    case ConditionalFormattingCode.LastRow:
                        if (((rowIndex != 0) && (rowIndex == (ownerTable.Rows.Count - 1))) && ownerTable.ApplyStyleForLastRow)
                        {
                            str2 = BookmarkStart.b("ᜥ", num);
                        }
                        break;
                }
            }
            string str13 = str + str2 + str3 + str4 + str5 + str6 + str7 + str8 + str9 + str10 + str11 + str12;
            if (str13 != BookmarkStart.b("ᘥᠧᨩᰫḭ/ȱгص࠷ਹ఻", num))
            {
                this.class1092_0.method_10(BookmarkStart.b("䔥䘧䰩缫娭䤯帱儳", num), this.dictionary_32[BookmarkStart.b("儥", num)]);
                this.class1092_0.method_6(BookmarkStart.b("儥", num), BookmarkStart.b("倥䤧䘩", num), this.dictionary_32[BookmarkStart.b("儥", num)], str13);
                this.class1092_0.method_6(BookmarkStart.b("儥", num), BookmarkStart.b("䀥䄧堩弫娭戯崱䌳", num), this.dictionary_32[BookmarkStart.b("儥", num)], str);
                this.class1092_0.method_6(BookmarkStart.b("儥", num), BookmarkStart.b("䨥䤧天堫簭弯䔱", num), this.dictionary_32[BookmarkStart.b("儥", num)], str2);
                this.class1092_0.method_6(BookmarkStart.b("儥", num), BookmarkStart.b("䀥䄧堩弫娭猯崱堳䌵唷吹", num), this.dictionary_32[BookmarkStart.b("儥", num)], str3);
                this.class1092_0.method_6(BookmarkStart.b("儥", num), BookmarkStart.b("䨥䤧天堫洭弯帱䄳嬵嘷", num), this.dictionary_32[BookmarkStart.b("儥", num)], str4);
                this.class1092_0.method_6(BookmarkStart.b("儥", num), BookmarkStart.b("䤥䰧丩稫氭儯就倳", num), this.dictionary_32[BookmarkStart.b("儥", num)], str5);
                this.class1092_0.method_6(BookmarkStart.b("儥", num), BookmarkStart.b("䌥帧伩䈫砭爯匱娳刵", num), this.dictionary_32[BookmarkStart.b("儥", num)], str6);
                this.class1092_0.method_6(BookmarkStart.b("儥", num), BookmarkStart.b("䤥䰧丩搫氭儯就倳", num), this.dictionary_32[BookmarkStart.b("儥", num)], str7);
                this.class1092_0.method_6(BookmarkStart.b("儥", num), BookmarkStart.b("䌥帧伩䈫昭爯匱娳刵", num), this.dictionary_32[BookmarkStart.b("儥", num)], str8);
                this.class1092_0.method_6(BookmarkStart.b("儥", num), BookmarkStart.b("䀥䄧堩弫娭戯崱䌳瀵儷䠹伻䨽̿ⵁ⡃㍅╇⑉", num), this.dictionary_32[BookmarkStart.b("儥", num)], str10);
                this.class1092_0.method_6(BookmarkStart.b("儥", num), BookmarkStart.b("䀥䄧堩弫娭戯崱䌳稵夷䤹䠻紽⼿⹁ㅃ⭅♇", num), this.dictionary_32[BookmarkStart.b("儥", num)], str9);
                this.class1092_0.method_6(BookmarkStart.b("儥", num), BookmarkStart.b("䨥䤧天堫簭弯䔱爳張䨷䤹䠻紽⼿⹁ㅃ⭅♇", num), this.dictionary_32[BookmarkStart.b("儥", num)], str12);
                this.class1092_0.method_6(BookmarkStart.b("儥", num), BookmarkStart.b("䨥䤧天堫簭弯䔱砳圵䬷丹缻儽ⰿ㝁⥃⡅", num), this.dictionary_32[BookmarkStart.b("儥", num)], str11);
                this.class1092_0.method_12();
            }
        }
    }

    private void method_157(TableCell A_0)
    {
        int num = 5;
        IStyle style = this.document_0.Styles.FindByName(A_0.OwnerRow.OwnerTable.TableStyleName, StyleType.TableStyle);
        if ((style != null) && ((style as Class13).method_25().Count > 0))
        {
            int cellIndex = A_0.GetCellIndex();
            int rowIndex = A_0.OwnerRow.GetRowIndex();
            Table ownerTable = A_0.OwnerRow.OwnerTable;
            string str = BookmarkStart.b("ᬪ", num);
            string str2 = BookmarkStart.b("ᬪ", num);
            string str3 = BookmarkStart.b("ᬪ", num);
            string str4 = BookmarkStart.b("ᬪ", num);
            string str5 = BookmarkStart.b("ᬪ", num);
            string str6 = BookmarkStart.b("ᬪ", num);
            string str7 = BookmarkStart.b("ᬪ", num);
            string str8 = BookmarkStart.b("ᬪ", num);
            string str10 = BookmarkStart.b("ᬪ", num);
            string str9 = BookmarkStart.b("ᬪ", num);
            string str12 = BookmarkStart.b("ᬪ", num);
            string str11 = BookmarkStart.b("ᬪ", num);
            using (Dictionary<ConditionalFormattingCode, Class10>.KeyCollection.Enumerator enumerator = (style as Class13).method_25().Keys.GetEnumerator())
            {
                while (enumerator.MoveNext())
                {
                    switch (enumerator.Current)
                    {
                        case ConditionalFormattingCode.OddColumnBanding:
                            if (((cellIndex != (A_0.OwnerRow.Cells.Count - 1)) && ((cellIndex % 2) == 1)) && ownerTable.ApplyStyleForBandedColumns)
                            {
                                str5 = BookmarkStart.b("ᨪ", num);
                            }
                            break;

                        case ConditionalFormattingCode.EvenColumnBanding:
                            if (((cellIndex != 0) && (cellIndex != (A_0.OwnerRow.Cells.Count - 1))) && (((cellIndex % 2) == 0) && ownerTable.ApplyStyleForBandedColumns))
                            {
                                str6 = BookmarkStart.b("ᨪ", num);
                            }
                            break;

                        case ConditionalFormattingCode.FirstColumn:
                            if ((cellIndex == 0) && ownerTable.ApplyStyleForFirstColumn)
                            {
                                str3 = BookmarkStart.b("ᨪ", num);
                            }
                            break;

                        case ConditionalFormattingCode.LastColumn:
                            if (((cellIndex != 0) && (cellIndex == (A_0.OwnerRow.Cells.Count - 1))) && ownerTable.ApplyStyleForLastColumn)
                            {
                                str4 = BookmarkStart.b("ᨪ", num);
                            }
                            break;

                        case ConditionalFormattingCode.FirstRowLastCell:
                            if ((((rowIndex == 0) && (cellIndex != 0)) && ((cellIndex == (A_0.OwnerRow.Cells.Count - 1)) && ownerTable.ApplyStyleForHeaderRow)) && ownerTable.ApplyStyleForLastColumn)
                            {
                                str9 = BookmarkStart.b("ᨪ", num);
                            }
                            break;

                        case ConditionalFormattingCode.FirstRowFirstCell:
                            if (((rowIndex == 0) && (cellIndex == 0)) && (ownerTable.ApplyStyleForHeaderRow && ownerTable.ApplyStyleForFirstColumn))
                            {
                                str10 = BookmarkStart.b("ᨪ", num);
                            }
                            break;

                        case ConditionalFormattingCode.LastRowLastCell:
                            if ((((rowIndex != 0) && (rowIndex == (ownerTable.Rows.Count - 1))) && ((cellIndex != 0) && (cellIndex == (A_0.OwnerRow.Cells.Count - 1)))) && (ownerTable.ApplyStyleForLastRow && ownerTable.ApplyStyleForLastColumn))
                            {
                                str11 = BookmarkStart.b("ᨪ", num);
                            }
                            break;

                        case ConditionalFormattingCode.LastRowFirstCell:
                            if ((((rowIndex != 0) && (rowIndex == (ownerTable.Rows.Count - 1))) && ((cellIndex == 0) && ownerTable.ApplyStyleForLastRow)) && ownerTable.ApplyStyleForFirstColumn)
                            {
                                str12 = BookmarkStart.b("ᨪ", num);
                            }
                            break;
                    }
                }
            }
            string str13 = str + str2 + str3 + str4 + str5 + str6 + str7 + str8 + str9 + str10 + str11 + str12;
            if (str13 != BookmarkStart.b("ᬪᴬἮİ̲Դܶस଺഼༾煀", num))
            {
                this.class1092_0.method_10(BookmarkStart.b("䠪䌬䤮戰䜲䰴嬶尸", num), this.dictionary_32[BookmarkStart.b("尪", num)]);
                this.class1092_0.method_6(BookmarkStart.b("尪", num), BookmarkStart.b("崪䰬䌮", num), this.dictionary_32[BookmarkStart.b("尪", num)], str13);
                this.class1092_0.method_6(BookmarkStart.b("尪", num), BookmarkStart.b("䴪䐬崮䈰䜲朴堶丸", num), this.dictionary_32[BookmarkStart.b("尪", num)], str);
                this.class1092_0.method_6(BookmarkStart.b("尪", num), BookmarkStart.b("䜪䰬尮䔰愲娴䀶", num), this.dictionary_32[BookmarkStart.b("尪", num)], str2);
                this.class1092_0.method_6(BookmarkStart.b("尪", num), BookmarkStart.b("䴪䐬崮䈰䜲瘴堶唸为值儾", num), this.dictionary_32[BookmarkStart.b("尪", num)], str3);
                this.class1092_0.method_6(BookmarkStart.b("尪", num), BookmarkStart.b("䜪䰬尮䔰瀲娴嬶䰸嘺匼", num), this.dictionary_32[BookmarkStart.b("尪", num)], str4);
                this.class1092_0.method_6(BookmarkStart.b("尪", num), BookmarkStart.b("䐪䤬䬮朰焲吴夶崸", num), this.dictionary_32[BookmarkStart.b("尪", num)], str5);
                this.class1092_0.method_6(BookmarkStart.b("尪", num), BookmarkStart.b("个嬬䨮弰攲眴嘶圸强", num), this.dictionary_32[BookmarkStart.b("尪", num)], str6);
                this.class1092_0.method_6(BookmarkStart.b("尪", num), BookmarkStart.b("䐪䤬䬮礰焲吴夶崸", num), this.dictionary_32[BookmarkStart.b("尪", num)], str7);
                this.class1092_0.method_6(BookmarkStart.b("尪", num), BookmarkStart.b("个嬬䨮弰笲眴嘶圸强", num), this.dictionary_32[BookmarkStart.b("尪", num)], str8);
                this.class1092_0.method_6(BookmarkStart.b("尪", num), BookmarkStart.b("䴪䐬崮䈰䜲朴堶丸紺吼䴾㉀㝂ل⡆╈㹊⁌ⅎ", num), this.dictionary_32[BookmarkStart.b("尪", num)], str10);
                this.class1092_0.method_6(BookmarkStart.b("尪", num), BookmarkStart.b("䴪䐬崮䈰䜲朴堶丸眺尼䰾㕀B⩄⭆㱈♊⍌", num), this.dictionary_32[BookmarkStart.b("尪", num)], str9);
                this.class1092_0.method_6(BookmarkStart.b("尪", num), BookmarkStart.b("䜪䰬尮䔰愲娴䀶缸刺似䰾㕀B⩄⭆㱈♊⍌", num), this.dictionary_32[BookmarkStart.b("尪", num)], str12);
                this.class1092_0.method_6(BookmarkStart.b("尪", num), BookmarkStart.b("䜪䰬尮䔰愲娴䀶甸娺丼䬾ɀⱂ⥄㉆⑈╊", num), this.dictionary_32[BookmarkStart.b("尪", num)], str11);
                this.class1092_0.method_12();
            }
            else
            {
                this.bool_13 = true;
            }
        }
    }

    private void method_158(Paragraph A_0)
    {
        int num = 0;
        TableCell ownerTextBody = A_0.OwnerTextBody as TableCell;
        IStyle style = this.document_0.Styles.FindByName(ownerTextBody.OwnerRow.OwnerTable.TableStyleName, StyleType.TableStyle);
        if ((style != null) && ((style as Class13).method_25().Count > 0))
        {
            ownerTextBody.GetCellIndex();
            int rowIndex = ownerTextBody.OwnerRow.GetRowIndex();
            Table ownerTable = ownerTextBody.OwnerRow.OwnerTable;
            if (this.method_159(style, rowIndex, ownerTable))
            {
                string str = BookmarkStart.b("ᘥ", num);
                string str2 = BookmarkStart.b("ᘥ", num);
                string str3 = BookmarkStart.b("ᘥ", num);
                string str4 = BookmarkStart.b("ᘥ", num);
                string str5 = BookmarkStart.b("ᘥ", num);
                string str6 = BookmarkStart.b("ᘥ", num);
                string str7 = BookmarkStart.b("ᘥ", num);
                string str8 = BookmarkStart.b("ᘥ", num);
                string str10 = BookmarkStart.b("ᘥ", num);
                string str9 = BookmarkStart.b("ᘥ", num);
                string str12 = BookmarkStart.b("ᘥ", num);
                string str11 = BookmarkStart.b("ᘥ", num);
                foreach (ConditionalFormattingCode code in (style as Class13).method_25().Keys)
                {
                    switch (code)
                    {
                        case ConditionalFormattingCode.OddRowBanding:
                            if (((rowIndex != (ownerTable.Rows.Count - 1)) && ((rowIndex % 2) == 1)) && ownerTable.ApplyStyleForBandedRows)
                            {
                                str7 = BookmarkStart.b("ᜥ", num);
                            }
                            break;

                        case ConditionalFormattingCode.EvenRowBanding:
                            if (((rowIndex != 0) && (rowIndex != (ownerTable.Rows.Count - 1))) && (((rowIndex % 2) == 0) && ownerTable.ApplyStyleForBandedRows))
                            {
                                str8 = BookmarkStart.b("ᜥ", num);
                            }
                            break;

                        case ConditionalFormattingCode.FirstRow:
                            if ((rowIndex == 0) && ownerTable.ApplyStyleForHeaderRow)
                            {
                                str = BookmarkStart.b("ᜥ", num);
                            }
                            break;

                        case ConditionalFormattingCode.LastRow:
                            if (((rowIndex != 0) && (rowIndex == (ownerTable.Rows.Count - 1))) && ownerTable.ApplyStyleForLastRow)
                            {
                                str2 = BookmarkStart.b("ᜥ", num);
                            }
                            break;
                    }
                }
                string str13 = str + str2 + str3 + str4 + str5 + str6 + str7 + str8 + str9 + str10 + str11 + str12;
                this.class1092_0.method_10(BookmarkStart.b("䔥䘧䰩缫娭䤯帱儳", num), this.dictionary_32[BookmarkStart.b("儥", num)]);
                this.class1092_0.method_6(BookmarkStart.b("儥", num), BookmarkStart.b("倥䤧䘩", num), this.dictionary_32[BookmarkStart.b("儥", num)], str13);
                this.class1092_0.method_6(BookmarkStart.b("儥", num), BookmarkStart.b("䀥䄧堩弫娭戯崱䌳", num), this.dictionary_32[BookmarkStart.b("儥", num)], str);
                this.class1092_0.method_6(BookmarkStart.b("儥", num), BookmarkStart.b("䨥䤧天堫簭弯䔱", num), this.dictionary_32[BookmarkStart.b("儥", num)], str2);
                this.class1092_0.method_6(BookmarkStart.b("儥", num), BookmarkStart.b("䀥䄧堩弫娭猯崱堳䌵唷吹", num), this.dictionary_32[BookmarkStart.b("儥", num)], str3);
                this.class1092_0.method_6(BookmarkStart.b("儥", num), BookmarkStart.b("䨥䤧天堫洭弯帱䄳嬵嘷", num), this.dictionary_32[BookmarkStart.b("儥", num)], str4);
                this.class1092_0.method_6(BookmarkStart.b("儥", num), BookmarkStart.b("䤥䰧丩稫氭儯就倳", num), this.dictionary_32[BookmarkStart.b("儥", num)], str5);
                this.class1092_0.method_6(BookmarkStart.b("儥", num), BookmarkStart.b("䌥帧伩䈫砭爯匱娳刵", num), this.dictionary_32[BookmarkStart.b("儥", num)], str6);
                this.class1092_0.method_6(BookmarkStart.b("儥", num), BookmarkStart.b("䤥䰧丩搫氭儯就倳", num), this.dictionary_32[BookmarkStart.b("儥", num)], str7);
                this.class1092_0.method_6(BookmarkStart.b("儥", num), BookmarkStart.b("䌥帧伩䈫昭爯匱娳刵", num), this.dictionary_32[BookmarkStart.b("儥", num)], str8);
                this.class1092_0.method_6(BookmarkStart.b("儥", num), BookmarkStart.b("䀥䄧堩弫娭戯崱䌳瀵儷䠹伻䨽̿ⵁ⡃㍅╇⑉", num), this.dictionary_32[BookmarkStart.b("儥", num)], str10);
                this.class1092_0.method_6(BookmarkStart.b("儥", num), BookmarkStart.b("䀥䄧堩弫娭戯崱䌳稵夷䤹䠻紽⼿⹁ㅃ⭅♇", num), this.dictionary_32[BookmarkStart.b("儥", num)], str9);
                this.class1092_0.method_6(BookmarkStart.b("儥", num), BookmarkStart.b("䨥䤧天堫簭弯䔱爳張䨷䤹䠻紽⼿⹁ㅃ⭅♇", num), this.dictionary_32[BookmarkStart.b("儥", num)], str12);
                this.class1092_0.method_6(BookmarkStart.b("儥", num), BookmarkStart.b("䨥䤧天堫簭弯䔱砳圵䬷丹缻儽ⰿ㝁⥃⡅", num), this.dictionary_32[BookmarkStart.b("儥", num)], str11);
                this.class1092_0.method_12();
            }
        }
    }

    private bool method_159(IStyle A_0, int A_1, Table A_2)
    {
        return (((((A_0 as Class13).method_25().ContainsKey(ConditionalFormattingCode.FirstColumn) && A_2.ApplyStyleForFirstColumn) || ((A_0 as Class13).method_25().ContainsKey(ConditionalFormattingCode.LastColumn) && A_2.ApplyStyleForLastColumn)) || ((((A_0 as Class13).method_25().ContainsKey(ConditionalFormattingCode.OddColumnBanding) && A_2.ApplyStyleForBandedColumns) || ((A_0 as Class13).method_25().ContainsKey(ConditionalFormattingCode.EvenColumnBanding) && A_2.ApplyStyleForBandedColumns)) || (((A_1 == 0) && (A_0 as Class13).method_25().ContainsKey(ConditionalFormattingCode.FirstRowFirstCell)) && (A_2.ApplyStyleForHeaderRow && A_2.ApplyStyleForFirstColumn)))) || ((((A_1 != 0) && (A_1 == (A_2.Rows.Count - 1))) && ((A_0 as Class13).method_25().ContainsKey(ConditionalFormattingCode.LastRowFirstCell) && A_2.ApplyStyleForLastRow)) && A_2.ApplyStyleForFirstColumn));
    }

    internal Dictionary<string, Stream> method_16()
    {
        if (this.dictionary_12 == null)
        {
            this.dictionary_12 = new Dictionary<string, Stream>();
        }
        return this.dictionary_12;
    }

    private void method_160(RowFormat A_0, Table A_1)
    {
        int num = 6;
        if (A_1 != null)
        {
            this.class1092_0.method_10(BookmarkStart.b("堫䰭尯戱䘳", num), this.dictionary_32[BookmarkStart.b("嬫", num)]);
            this.method_178(A_0);
            this.method_180(A_1);
            this.method_161(A_1);
            this.method_162(A_1);
            if (A_0.WrapTextAround)
            {
                this.method_173(A_0.Positioning);
            }
            if (A_1 != null)
            {
                this.method_171(A_1);
            }
            this.method_172(A_0);
        }
        this.method_170(A_0);
        this.method_169(A_0);
        if (!A_0.Borders.IsDefault || A_0.Borders.NoBorder)
        {
            this.method_168(A_0);
        }
        this.method_167(A_0);
        this.method_166(A_0, A_1);
        this.method_164(A_0);
        if ((A_1 != null) && (A_1.DocxTableFormat.NodeArray.Count > 0))
        {
            int num6 = 0;
            int count = A_1.DocxTableFormat.NodeArray.Count;
            while (num6 < count)
            {
                A_1.DocxTableFormat.NodeArray[num6].WriteTo(this.class1092_0.method_0());
                num6++;
            }
        }
        else if ((A_1 != null) && (A_1.DocxTableFormat.NodeArray2010.Count > 0))
        {
            int num4 = 0;
            int num5 = A_1.DocxTableFormat.NodeArray2010.Count;
            while (num4 < num5)
            {
                this.method_272(A_1.DocxTableFormat.NodeArray2010[num4]);
                num4++;
            }
        }
        if ((A_1 != null) && (A_1.DocxTableFormat.NodeArray2010.Count > 0))
        {
            int num2 = 0;
            int num3 = A_1.DocxTableFormat.NodeArray2010.Count;
            while (num2 < num3)
            {
                this.method_272(A_1.DocxTableFormat.NodeArray2010[num2]);
                num2++;
            }
        }
        this.method_484(A_0);
        if ((A_0.OwnerRow != null) && (A_0.OwnerRow.rowFormat_1 != null))
        {
            this.method_479(BookmarkStart.b("堫䰭尯戱䘳猵䀷礹吻弽⸿╁⅃", num));
            this.method_160(A_0.OwnerRow.TrackRowFormat, null);
            this.class1092_0.method_12();
        }
        if (((A_0.OwnerBase != null) && (A_0.OwnerBase is Table)) && (((A_0.OwnerBase as Table).xmlTableFormat_1 != null) && !this.bool_16))
        {
            this.bool_16 = true;
            this.method_479(BookmarkStart.b("堫䰭尯戱䘳电倷嬹刻夽┿", num));
            this.method_160((A_0.OwnerBase as Table).TrackTblFormat.Format, null);
            this.class1092_0.method_12();
            this.bool_16 = false;
        }
        this.method_163(A_0);
        if (A_1 != null)
        {
            this.class1092_0.method_12();
        }
    }

    private void method_161(Table A_0)
    {
        int num = 3;
        if (!string.IsNullOrEmpty(A_0.Title))
        {
            this.class1092_0.method_10(BookmarkStart.b("崨䤪䄬氮倰䌲䄴帶嘸唺", num), this.dictionary_32[BookmarkStart.b("帨", num)]);
            this.class1092_0.method_6(BookmarkStart.b("帨", num), BookmarkStart.b("弨䨪䄬", num), this.dictionary_32[BookmarkStart.b("帨", num)], A_0.Title);
            this.class1092_0.method_12();
        }
    }

    private void method_162(Table A_0)
    {
        int num = 0x10;
        if (!string.IsNullOrEmpty(A_0.TableDescription))
        {
            this.class1092_0.method_10(BookmarkStart.b("䈵娷嘹砻嬽㌿⅁㙃⽅㡇㹉╋⅍㹏", num), this.dictionary_32[BookmarkStart.b("䄵", num)]);
            this.class1092_0.method_6(BookmarkStart.b("䄵", num), BookmarkStart.b("䀵夷嘹", num), this.dictionary_32[BookmarkStart.b("䄵", num)], A_0.TableDescription);
            this.class1092_0.method_12();
        }
    }

    private void method_163(RowFormat A_0)
    {
        int num = 0;
        if ((A_0.OwnerRow != null) && (A_0.OwnerRow.OwnerTable != null))
        {
            Table ownerTable = A_0.OwnerRow.OwnerTable;
            if (ownerTable.IsDeleteRevision)
            {
                this.method_479(BookmarkStart.b("䈥䴧䘩", num));
                this.class1092_0.method_12();
            }
            else if (ownerTable.IsInsertRevision)
            {
                this.method_479(BookmarkStart.b("伥䘧天", num));
                this.class1092_0.method_12();
            }
        }
        if ((A_0.OwnerBase != null) && (A_0.OwnerBase is TableRow))
        {
            TableRow ownerBase = A_0.OwnerBase as TableRow;
            if (ownerBase.IsDeleteRevision)
            {
                this.method_479(BookmarkStart.b("䈥䴧䘩", num));
                this.class1092_0.method_12();
            }
            else if (ownerBase.IsInsertRevision)
            {
                this.method_479(BookmarkStart.b("伥䘧天", num));
                this.class1092_0.method_12();
            }
        }
    }

    private void method_164(RowFormat A_0)
    {
        int num = 0x10;
        if (!A_0.Paddings.IsDefault || A_0.HasValue(3))
        {
            this.class1092_0.method_10(BookmarkStart.b("䈵娷嘹缻嬽ⰿ⹁ृ❅㩇", num), this.dictionary_32[BookmarkStart.b("䄵", num)]);
            this.method_165(A_0.Paddings);
            this.class1092_0.method_12();
        }
    }

    private void method_165(Paddings A_0)
    {
        int num = 13;
        if ((A_0.Top >= 0f) && A_0.HasKey(2))
        {
            this.class1092_0.method_10(BookmarkStart.b("䜲娴䜶", num), this.dictionary_32[BookmarkStart.b("䐲", num)]);
            this.class1092_0.method_5(BookmarkStart.b("䐲", num), this.dictionary_32[BookmarkStart.b("䐲", num)], this.method_534(A_0.Top * 20f));
            this.class1092_0.method_5(BookmarkStart.b("䜲䰴䜶尸", num), this.dictionary_32[BookmarkStart.b("䐲", num)], BookmarkStart.b("圲䴴嘶", num));
            this.class1092_0.method_12();
        }
        if ((A_0.Left >= 0f) && A_0.HasKey(1))
        {
            this.class1092_0.method_10(BookmarkStart.b("弲倴儶䴸", num), this.dictionary_32[BookmarkStart.b("䐲", num)]);
            this.class1092_0.method_5(BookmarkStart.b("䐲", num), this.dictionary_32[BookmarkStart.b("䐲", num)], this.method_534(A_0.Left * 20f));
            this.class1092_0.method_5(BookmarkStart.b("䜲䰴䜶尸", num), this.dictionary_32[BookmarkStart.b("䐲", num)], BookmarkStart.b("圲䴴嘶", num));
            this.class1092_0.method_12();
        }
        if ((A_0.Bottom >= 0f) && A_0.HasKey(3))
        {
            this.class1092_0.method_10(BookmarkStart.b("儲娴䌶䴸吺值", num), this.dictionary_32[BookmarkStart.b("䐲", num)]);
            this.class1092_0.method_5(BookmarkStart.b("䐲", num), this.dictionary_32[BookmarkStart.b("䐲", num)], this.method_534(A_0.Bottom * 20f));
            this.class1092_0.method_5(BookmarkStart.b("䜲䰴䜶尸", num), this.dictionary_32[BookmarkStart.b("䐲", num)], BookmarkStart.b("圲䴴嘶", num));
            this.class1092_0.method_12();
        }
        if ((A_0.Right >= 0f) && A_0.HasKey(4))
        {
            this.class1092_0.method_10(BookmarkStart.b("䄲尴倶儸伺", num), this.dictionary_32[BookmarkStart.b("䐲", num)]);
            this.class1092_0.method_5(BookmarkStart.b("䐲", num), this.dictionary_32[BookmarkStart.b("䐲", num)], this.method_534(A_0.Right * 20f));
            this.class1092_0.method_5(BookmarkStart.b("䜲䰴䜶尸", num), this.dictionary_32[BookmarkStart.b("䐲", num)], BookmarkStart.b("圲䴴嘶", num));
            this.class1092_0.method_12();
        }
    }

    private void method_166(RowFormat A_0, Table A_1)
    {
        int num = 8;
        if ((A_1 != null) && !A_1.DocxTableFormat.HasFormat)
        {
            if (A_1.PreferredTableWidth.method_51() == FtsWidth.Percentage)
            {
                A_1.PreferredTableWidth.method_49();
            }
        }
        else if (!A_0.IsAutoResized)
        {
            float scaling = A_0.Scaling;
        }
        if (A_0.LayoutType == LayoutType.Fixed)
        {
            this.class1092_0.method_10(BookmarkStart.b("娭刯帱砳圵䄷唹䤻䨽", num), this.dictionary_32[BookmarkStart.b("夭", num)]);
            this.class1092_0.method_5(BookmarkStart.b("娭䤯䈱儳", num), this.dictionary_32[BookmarkStart.b("夭", num)], BookmarkStart.b("䠭夯䨱儳刵", num));
            this.class1092_0.method_12();
        }
    }

    private void method_167(RowFormat A_0)
    {
        int num = 0x12;
        if (A_0.HasValue(0x6c) || A_0.HasValue(110))
        {
            this.class1092_0.method_10(BookmarkStart.b("䬷刹堻", num), this.dictionary_32[BookmarkStart.b("伷", num)]);
            if (A_0.BackColor == Color.Empty)
            {
                this.class1092_0.method_5(BookmarkStart.b("帷匹倻刽", num), this.dictionary_32[BookmarkStart.b("伷", num)], BookmarkStart.b("夷伹䠻儽", num));
            }
            else
            {
                this.class1092_0.method_5(BookmarkStart.b("帷匹倻刽", num), this.dictionary_32[BookmarkStart.b("伷", num)], this.method_535(A_0.BackColor));
            }
            string str = this.method_529(A_0.TextureStyle);
            this.class1092_0.method_6(BookmarkStart.b("伷", num), BookmarkStart.b("丷嬹倻", num), this.dictionary_32[BookmarkStart.b("伷", num)], str);
            this.class1092_0.method_12();
        }
    }

    private void method_168(RowFormat A_0)
    {
        this.class1092_0.method_10(BookmarkStart.b("尧䠩䀫氭弯䀱倳匵䨷䤹", 2), this.dictionary_32[BookmarkStart.b("弧", 2)]);
        this.method_395(A_0.Borders, 8);
        this.class1092_0.method_12();
    }

    private void method_169(RowFormat A_0)
    {
        int num = 3;
        if (A_0.RowIndent != 0f)
        {
            this.class1092_0.method_10(BookmarkStart.b("崨䤪䄬昮弰圲", num), this.dictionary_32[BookmarkStart.b("帨", num)]);
            int num2 = 0;
            if (!A_0.HasKey(0x10f4) && (A_0.RowIndent == 0f))
            {
                num2 = (int) Math.Round((double) (A_0.LeftIndent * 20f));
            }
            else
            {
                num2 = (int) Math.Round((double) (A_0.RowIndent * 20f));
            }
            this.class1092_0.method_5(BookmarkStart.b("帨", num), this.dictionary_32[BookmarkStart.b("帨", num)], num2.ToString());
            this.class1092_0.method_5(BookmarkStart.b("崨刪崬䨮", num), this.dictionary_32[BookmarkStart.b("帨", num)], BookmarkStart.b("䴨匪䰬", num));
            this.class1092_0.method_12();
        }
    }

    internal Dictionary<string, Dictionary<string, Stream>> method_17()
    {
        if (this.dictionary_13 == null)
        {
            this.dictionary_13 = new Dictionary<string, Dictionary<string, Stream>>();
        }
        return this.dictionary_13;
    }

    private void method_170(RowFormat A_0)
    {
        int num = 0x13;
        if (A_0.CellSpacingEx > -1f)
        {
            this.class1092_0.method_10(BookmarkStart.b("䴸夺儼簾⑀⽂⥄ᑆ㥈⩊⹌♎㽐㑒", num), this.dictionary_32[BookmarkStart.b("丸", num)]);
            this.class1092_0.method_5(BookmarkStart.b("丸", num), this.dictionary_32[BookmarkStart.b("丸", num)], this.method_534(A_0.CellSpacingEx * 20f));
            this.class1092_0.method_5(BookmarkStart.b("䴸䈺䴼娾", num), this.dictionary_32[BookmarkStart.b("丸", num)], BookmarkStart.b("崸䌺尼", num));
            this.class1092_0.method_12();
        }
    }

    private void method_171(Table A_0)
    {
        int num = 2;
        this.class1092_0.method_10(BookmarkStart.b("尧䠩䀫礭", 2), this.dictionary_32[BookmarkStart.b("弧", 2)]);
        switch (A_0.PreferredTableWidth.method_51())
        {
            case FtsWidth.None:
            case FtsWidth.Auto:
                this.class1092_0.method_5(BookmarkStart.b("弧", num), this.dictionary_32[BookmarkStart.b("弧", num)], BookmarkStart.b("ᠧ", num));
                this.class1092_0.method_5(BookmarkStart.b("尧匩尫䬭", num), this.dictionary_32[BookmarkStart.b("弧", num)], BookmarkStart.b("䤧弩堫䄭", num));
                break;

            case FtsWidth.Percentage:
                this.class1092_0.method_5(BookmarkStart.b("弧", num), this.dictionary_32[BookmarkStart.b("弧", num)], this.method_534(A_0.PreferredTableWidth.method_49() * 50f));
                this.class1092_0.method_5(BookmarkStart.b("尧匩尫䬭", num), this.dictionary_32[BookmarkStart.b("弧", num)], BookmarkStart.b("堧䤩堫", num));
                break;

            case FtsWidth.Point:
                this.class1092_0.method_5(BookmarkStart.b("弧", num), this.dictionary_32[BookmarkStart.b("弧", num)], this.method_534(A_0.PreferredTableWidth.method_49()));
                this.class1092_0.method_5(BookmarkStart.b("尧匩尫䬭", num), this.dictionary_32[BookmarkStart.b("弧", num)], BookmarkStart.b("䰧利䴫", num));
                break;
        }
        this.class1092_0.method_12();
    }

    private void method_172(RowFormat A_0)
    {
        int num = 5;
        if (A_0.Bidi)
        {
            this.class1092_0.method_10(BookmarkStart.b("䤪䐬䬮堰攲尴䐶䰸娺儼", num), this.dictionary_32[BookmarkStart.b("尪", num)]);
            this.class1092_0.method_12();
        }
        this.class1092_0.method_10(BookmarkStart.b("䄪丬", num), this.dictionary_32[BookmarkStart.b("尪", num)]);
        switch (A_0.HorizontalAlignment)
        {
            case RowAlignment.Center:
                this.class1092_0.method_6(BookmarkStart.b("尪", num), BookmarkStart.b("崪䰬䌮", num), this.dictionary_32[BookmarkStart.b("尪", num)], BookmarkStart.b("䠪䠬䄮䔰嘲䜴", num));
                break;

            case RowAlignment.Right:
                this.class1092_0.method_6(BookmarkStart.b("尪", num), BookmarkStart.b("崪䰬䌮", num), this.dictionary_32[BookmarkStart.b("尪", num)], BookmarkStart.b("太䐬䠮夰䜲", num));
                break;

            default:
                this.class1092_0.method_6(BookmarkStart.b("尪", num), BookmarkStart.b("崪䰬䌮", num), this.dictionary_32[BookmarkStart.b("尪", num)], BookmarkStart.b("䜪䠬䤮䔰", num));
                break;
        }
        this.class1092_0.method_12();
    }

    private void method_173(RowFormat.TablePositioning A_0)
    {
        int num = 3;
        this.class1092_0.method_10(BookmarkStart.b("崨䤪䄬弮愰䄲", 3), this.dictionary_32[BookmarkStart.b("帨", 3)]);
        string str = null;
        if (A_0.method_6(0x3d))
        {
            str = this.method_534(A_0.HorizPositionEx * 20f);
            this.class1092_0.method_5(BookmarkStart.b("崨䤪䄬弮椰", num), this.dictionary_32[BookmarkStart.b("帨", num)], str);
        }
        if (A_0.method_6(0x3e))
        {
            str = this.method_534(A_0.VertPositionEx * 20f);
            this.class1092_0.method_5(BookmarkStart.b("崨䤪䄬弮栰", num), this.dictionary_32[BookmarkStart.b("帨", num)], str);
        }
        if (A_0.DistanceFromTop != 0f)
        {
            str = this.method_534(A_0.DistanceFromTop * 20f);
            this.class1092_0.method_5(BookmarkStart.b("崨䐪崬椮䌰尲場挶尸䌺䤼", num), this.dictionary_32[BookmarkStart.b("帨", num)], str);
        }
        if (A_0.DistanceFromBottom != 0f)
        {
            str = this.method_534(A_0.DistanceFromBottom * 20f);
            this.class1092_0.method_5(BookmarkStart.b("䬨䐪夬嬮帰帲猴䔶嘸嘺椼娾㥀㝂", num), this.dictionary_32[BookmarkStart.b("帨", num)], str);
        }
        str = this.method_534(A_0.DistanceFromLeft * 20f);
        this.class1092_0.method_5(BookmarkStart.b("䔨个䬬嬮眰䄲娴娶洸帺䔼䬾", num), this.dictionary_32[BookmarkStart.b("帨", num)], str);
        str = this.method_534(A_0.DistanceFromRight * 20f);
        this.class1092_0.method_5(BookmarkStart.b("嬨䈪䨬䜮䔰甲䜴堶吸漺堼䜾㕀", num), this.dictionary_32[BookmarkStart.b("帨", num)], str);
        this.method_176(A_0.VertRelationTo);
        if (A_0.HorizRelationTo != HorizontalRelation.Column)
        {
            this.method_177(A_0.HorizRelationTo);
        }
        if (A_0.HorizPositionAbs != HorizontalPosition.Left)
        {
            this.method_174(A_0.HorizPositionAbs);
        }
        if (A_0.VertPositionAbs != VerticalPosition.None)
        {
            this.method_175(A_0.VertPositionAbs);
        }
        this.class1092_0.method_12();
        if (!A_0.TableOverlap)
        {
            this.class1092_0.method_10(BookmarkStart.b("崨䤪䄬怮䜰嘲䜴嬶堸䬺", num), this.dictionary_32[BookmarkStart.b("帨", num)]);
            this.class1092_0.method_5(BookmarkStart.b("弨䨪䄬", num), this.dictionary_32[BookmarkStart.b("帨", num)], BookmarkStart.b("䜨个嬬䨮䌰", num));
            this.class1092_0.method_12();
        }
    }

    private void method_174(HorizontalPosition A_0)
    {
        int num = 1;
        string str = null;
        switch (A_0)
        {
            case HorizontalPosition.Center:
                str = BookmarkStart.b("䐦䰨䔪夬䨮䌰", num);
                break;

            case HorizontalPosition.Right:
                str = BookmarkStart.b("唦䀨䰪䔬嬮", num);
                break;

            case HorizontalPosition.Inside:
                str = BookmarkStart.b("並䜨堪䐬䬮吰", num);
                break;

            case HorizontalPosition.Outside:
                str = BookmarkStart.b("䠦尨弪帬䘮唰嘲", num);
                break;
        }
        this.class1092_0.method_5(BookmarkStart.b("匦䬨䜪崬眮戰䌲倴吶", num), this.dictionary_32[BookmarkStart.b("倦", num)], str);
    }

    private void method_175(VerticalPosition A_0)
    {
        int num = 0x13;
        string str = null;
        switch (A_0)
        {
            case VerticalPosition.Top:
                str = BookmarkStart.b("䴸吺䴼", num);
                break;

            case VerticalPosition.Center:
                str = BookmarkStart.b("娸帺匼䬾⑀ㅂ", num);
                break;

            case VerticalPosition.Bottom:
                str = BookmarkStart.b("嬸吺䤼䬾⹀⹂", num);
                break;

            case VerticalPosition.Inside:
                str = BookmarkStart.b("倸唺丼嘾╀♂", num);
                break;

            case VerticalPosition.Outside:
                str = BookmarkStart.b("嘸为䤼䰾⡀❂⁄", num);
                break;
        }
        this.class1092_0.method_5(BookmarkStart.b("䴸夺儼伾ᡀ၂㕄≆⩈", num), this.dictionary_32[BookmarkStart.b("丸", num)], str);
    }

    private void method_176(VerticalRelation A_0)
    {
        int num = 0;
        string str = null;
        switch (A_0)
        {
            case VerticalRelation.Margin:
                str = BookmarkStart.b("䬥䤧堩䬫䜭帯", num);
                break;

            case VerticalRelation.Page:
                str = BookmarkStart.b("嘥䤧䴩䤫", num);
                break;

            case VerticalRelation.Paragraph:
                str = BookmarkStart.b("別䴧利堫", num);
                break;
        }
        this.class1092_0.method_5(BookmarkStart.b("倥䴧堩堫漭帯儱尳夵䨷", num), this.dictionary_32[BookmarkStart.b("儥", num)], str);
    }

    private void method_177(HorizontalRelation A_0)
    {
        int num = 8;
        string str = null;
        switch (A_0)
        {
            case HorizontalRelation.Column:
                str = BookmarkStart.b("娭唯䨱䀳", num);
                break;

            case HorizontalRelation.Margin:
                str = BookmarkStart.b("䌭儯䀱匳張嘷", num);
                break;

            case HorizontalRelation.Page:
                str = BookmarkStart.b("席儯唱儳", num);
                break;
        }
        this.class1092_0.method_5(BookmarkStart.b("䘭弯䀱丳眵嘷夹吻儽㈿", num), this.dictionary_32[BookmarkStart.b("夭", num)], str);
    }

    private void method_178(RowFormat A_0)
    {
        int num = 0x13;
        Table ownerBase = null;
        if ((A_0.OwnerBase != null) && (A_0.OwnerBase is Table))
        {
            ownerBase = A_0.OwnerBase as Table;
            if ((ownerBase.DocxTableFormat.HasFormat && !ownerBase.DocxTableFormat.Format.IsDefault) && string.IsNullOrEmpty(ownerBase.DocxTableFormat.StyleName))
            {
                return;
            }
        }
        string styleId = string.Empty;
        if (ownerBase != null)
        {
            if (ownerBase.TableStyle != null)
            {
                styleId = ownerBase.TableStyle.StyleId;
            }
            if (string.IsNullOrEmpty(styleId) && !string.IsNullOrEmpty(ownerBase.DocxTableFormat.StyleName))
            {
                styleId = (A_0.OwnerBase as Table).DocxTableFormat.StyleName;
            }
            if (string.IsNullOrEmpty(styleId) && (ownerBase.TableStyleName != null))
            {
                styleId = this.method_179(ownerBase.TableStyleName);
            }
        }
        else if ((A_0.OwnerBase is TableRow) && ((A_0.OwnerBase as TableRow).OwnerTable != null))
        {
            ownerBase = (A_0.OwnerBase as TableRow).OwnerTable;
            if (ownerBase.TableStyle != null)
            {
                styleId = ownerBase.TableStyle.StyleId;
            }
            if (string.IsNullOrEmpty(styleId) && !string.IsNullOrEmpty(ownerBase.DocxTableFormat.StyleName))
            {
                styleId = (A_0.OwnerBase as Table).DocxTableFormat.StyleName;
            }
            if (string.IsNullOrEmpty(styleId) && (ownerBase.TableStyleName != null))
            {
                styleId = this.method_179(ownerBase.TableStyleName);
            }
        }
        styleId = string.IsNullOrEmpty(styleId) ? BookmarkStart.b("洸娺弼匾⑀т㝄⹆ⵈ", num) : styleId;
        this.class1092_0.method_10(BookmarkStart.b("䴸夺儼氾㕀㩂⥄≆", num), this.dictionary_32[BookmarkStart.b("丸", num)]);
        this.class1092_0.method_6(BookmarkStart.b("丸", num), BookmarkStart.b("伸娺儼", num), this.dictionary_32[BookmarkStart.b("丸", num)], styleId);
        this.class1092_0.method_12();
    }

    private string method_179(string A_0)
    {
        int num = 5;
        string str = "";
        if (!this.document_0.StyleNameIds.ContainsValue(A_0))
        {
            return A_0.Replace(BookmarkStart.b("ପ", num), string.Empty);
        }
        using (Dictionary<string, string>.Enumerator enumerator = this.document_0.StyleNameIds.GetEnumerator())
        {
            KeyValuePair<string, string> current;
            while (enumerator.MoveNext())
            {
                current = enumerator.Current;
                if (current.Value == A_0)
                {
                    goto Label_006C;
                }
            }
            return str;
        Label_006C:
            str = current.Key;
        }
        return str;
    }

    private Dictionary<string, string> method_18()
    {
        if (this.dictionary_11 == null)
        {
            this.dictionary_11 = new Dictionary<string, string>();
        }
        return this.dictionary_11;
    }

    private void method_180(Table A_0)
    {
        int num = 13;
        string str = BookmarkStart.b("̲", 13);
        string str2 = BookmarkStart.b("̲", 13);
        string str3 = BookmarkStart.b("̲", 13);
        string str4 = BookmarkStart.b("̲", 13);
        string str5 = BookmarkStart.b("̲", 13);
        string str6 = BookmarkStart.b("̲", 13);
        if (A_0.ApplyStyleForHeaderRow)
        {
            str = BookmarkStart.b("Ȳ", num);
        }
        if (A_0.ApplyStyleForLastRow)
        {
            str2 = BookmarkStart.b("Ȳ", num);
        }
        if (A_0.ApplyStyleForFirstColumn)
        {
            str3 = BookmarkStart.b("Ȳ", num);
        }
        if (A_0.ApplyStyleForLastColumn)
        {
            str4 = BookmarkStart.b("Ȳ", num);
        }
        if (!A_0.ApplyStyleForBandedRows)
        {
            str5 = BookmarkStart.b("Ȳ", num);
        }
        if (!A_0.ApplyStyleForBandedColumns)
        {
            str6 = BookmarkStart.b("Ȳ", num);
        }
        string str7 = str6 + str5 + str4 + str3 + str2 + str + BookmarkStart.b("̲Դܶस଺", num);
        str7 = string.Format(BookmarkStart.b("䠲Դശ愸䘺", num), Convert.ToInt64(str7, 2)).PadLeft(4, '0');
        this.class1092_0.method_10(BookmarkStart.b("䜲圴嬶甸吺刼吾", num), this.dictionary_32[BookmarkStart.b("䐲", num)]);
        this.class1092_0.method_6(BookmarkStart.b("䐲", num), BookmarkStart.b("䔲吴嬶", num), this.dictionary_32[BookmarkStart.b("䐲", num)], str7);
        this.class1092_0.method_6(BookmarkStart.b("䐲", num), BookmarkStart.b("唲尴䔶䨸伺漼倾㙀", num), this.dictionary_32[BookmarkStart.b("䐲", num)], str);
        this.class1092_0.method_6(BookmarkStart.b("䐲", num), BookmarkStart.b("弲吴䐶䴸椺刼䠾", num), this.dictionary_32[BookmarkStart.b("䐲", num)], str2);
        this.class1092_0.method_6(BookmarkStart.b("䐲", num), BookmarkStart.b("唲尴䔶䨸伺縼倾ⵀ㙂⡄⥆", num), this.dictionary_32[BookmarkStart.b("䐲", num)], str3);
        this.class1092_0.method_6(BookmarkStart.b("䐲", num), BookmarkStart.b("弲吴䐶䴸砺刼匾㑀⹂⭄", num), this.dictionary_32[BookmarkStart.b("䐲", num)], str4);
        this.class1092_0.method_6(BookmarkStart.b("䐲", num), BookmarkStart.b("崲娴缶笸娺匼嬾", num), this.dictionary_32[BookmarkStart.b("䐲", num)], str5);
        this.class1092_0.method_6(BookmarkStart.b("䐲", num), BookmarkStart.b("崲娴愶笸娺匼嬾", num), this.dictionary_32[BookmarkStart.b("䐲", num)], str6);
        this.class1092_0.method_12();
    }

    private void method_181(Table A_0)
    {
        int num = 5;
        this.class1092_0.method_10(BookmarkStart.b("弪伬䌮瘰䄲尴匶", 5), this.dictionary_32[BookmarkStart.b("尪", 5)]);
        if (A_0._ColumnWidths.Count != 0)
        {
            this.method_183(A_0._ColumnWidths);
        }
        else if (A_0.TableGrid.Count != 0)
        {
            this.method_182(A_0.TableGrid);
        }
        if ((A_0.list_1 != null) && (A_0.TrackTableGrid.Count != 0))
        {
            this.class1092_0.method_10(BookmarkStart.b("弪伬䌮瘰䄲尴匶稸区尼儾♀♂", num), this.dictionary_32[BookmarkStart.b("尪", num)]);
            this.class1092_0.method_5(BookmarkStart.b("䈪䤬", num), this.dictionary_32[BookmarkStart.b("尪", num)], this.method_476());
            this.class1092_0.method_10(BookmarkStart.b("弪伬䌮瘰䄲尴匶", num), this.dictionary_32[BookmarkStart.b("尪", num)]);
            this.method_182(A_0.TrackTableGrid);
            this.class1092_0.method_12();
            this.class1092_0.method_12();
        }
        this.class1092_0.method_12();
    }

    private void method_182(List<float> A_0)
    {
        float num = A_0[0];
        float num2 = 0f;
        int num3 = 1;
        int count = A_0.Count;
        while (num3 < count)
        {
            num2 = A_0[num3];
            this.method_184(num2 - num);
            num = num2;
            num3++;
        }
    }

    private void method_183(ArrayList A_0)
    {
        foreach (object obj2 in A_0)
        {
            int num = Convert.ToInt32(obj2);
            this.method_184((float) num);
        }
    }

    private void method_184(float A_0)
    {
        int num = (int) Math.Round((double) A_0);
        this.class1092_0.method_10(BookmarkStart.b("吲䜴帶崸砺刼匾", 13), this.dictionary_32[BookmarkStart.b("䐲", 13)]);
        this.class1092_0.method_5(BookmarkStart.b("䐲", 13), this.dictionary_32[BookmarkStart.b("䐲", 13)], num.ToString());
        this.class1092_0.method_12();
    }

    private void method_185(Paragraph A_0, bool A_1)
    {
        int num = 11;
        if (A_0 == null)
        {
            throw new ArgumentException(BookmarkStart.b("愰刲䜴嘶常䤺尼伾⥀捂㙄⽆♈㹊⅌⭎煐㵒㩔⍖祘㥚㡜罞འᙢ।୦", num));
        }
        if (!string.IsNullOrEmpty(A_0.Text) || !A_0.RemoveEmpty)
        {
            if (A_0.Format.PageBreakAfter && !this.method_549(A_0))
            {
                this.method_370(A_0);
            }
            this.class1092_0.method_11(BookmarkStart.b("䘰", num), BookmarkStart.b("䄰", num), this.dictionary_32[BookmarkStart.b("䘰", num)]);
            if (this.bool_25)
            {
                string str = this.method_186();
                string str2 = this.method_187();
                this.class1092_0.method_6(BookmarkStart.b("䘰ȲĴ", num), BookmarkStart.b("䄰刲䜴嘶瀸强", num), this.dictionary_32[BookmarkStart.b("䘰ȲĴ", num)], str);
                this.class1092_0.method_6(BookmarkStart.b("䘰ȲĴ", num), BookmarkStart.b("䔰嘲䴴䌶瀸强", num), this.dictionary_32[BookmarkStart.b("䘰ȲĴ", num)], str2);
                if (this.comment_0 != null)
                {
                    if (this.method_6().ContainsKey(this.comment_0))
                    {
                        this.method_6()[this.comment_0] = str;
                    }
                    else
                    {
                        this.method_6().Add(this.comment_0, str);
                    }
                }
            }
            this.class1092_0.method_10(BookmarkStart.b("䄰挲䜴", num), this.dictionary_32[BookmarkStart.b("䘰", num)]);
            this.method_472(A_0.Format, A_0);
            this.class1092_0.method_12();
            this.method_189(A_0.Items);
            this.class1092_0.method_12();
            if ((this.textRange_0 != null) || ((this.string_4 != null) && (this.string_4.Length > 0)))
            {
                this.method_381();
                this.textRange_0 = null;
                this.string_4 = null;
            }
            this.method_188(A_0);
        }
    }

    private string method_186()
    {
        return this.random_0.Next(0, 0x7fffffff).ToString(BookmarkStart.b("丵਷", 0x10)).ToUpper().PadLeft(8, '0');
    }

    private string method_187()
    {
        return this.random_0.Next(0, 0x7fffffff).ToString(BookmarkStart.b("伶ସ", 0x11)).ToUpper().PadLeft(8, '0');
    }

    private void method_188(IDocumentObject A_0)
    {
        int num = 12;
        if ((A_0 is Paragraph) && (A_0 as Paragraph).Format.IsColumnBreakAfter)
        {
            if (A_0.NextSibling is Paragraph)
            {
                Paragraph nextSibling = A_0.NextSibling as Paragraph;
                nextSibling.Items.Insert(0, new Break(nextSibling.Document, BreakType.ColumnBreak));
            }
            else
            {
                this.class1092_0.method_10(BookmarkStart.b("䈱", num), this.dictionary_32[BookmarkStart.b("䔱", num)]);
                this.method_367(BreakType.ColumnBreak);
                this.class1092_0.method_12();
            }
        }
    }

    private void method_189(ParagraphItemCollection A_0)
    {
        if ((A_0 != null) && (A_0.Count > 0))
        {
            for (int i = 0; i < A_0.Count; i++)
            {
                this.method_190(A_0[i]);
                if (this.fieldMark_0 != null)
                {
                    int index = A_0.IndexOf(this.fieldMark_0);
                    if (index >= i)
                    {
                        i = index;
                    }
                    this.fieldMark_0 = null;
                }
                if (this.idocumentObject_0 != null)
                {
                    int num2 = A_0.IndexOf(this.idocumentObject_0);
                    if (num2 >= i)
                    {
                        i = num2 - 1;
                    }
                    this.idocumentObject_0 = null;
                }
            }
        }
    }

    internal List<string> method_19()
    {
        if (this.list_5 == null)
        {
            this.list_5 = new List<string>();
        }
        return this.list_5;
    }

    internal void method_190(ParagraphBase A_0)
    {
        if (((A_0 is WatermarkBase) && this.method_196(A_0)) && (!this.bool_21 && (this.paragraph_0 == A_0.OwnerParagraph)))
        {
            this.method_197(A_0 as WatermarkBase);
            this.bool_21 = true;
        }
        if (!this.method_269(A_0))
        {
            bool flag = this.method_477(A_0);
            switch (A_0.DocumentObjectType)
            {
                case DocumentObjectType.StructureDocumentTagInline:
                    this.method_118(A_0 as StructureDocumentTagInline);
                    break;

                case DocumentObjectType.Picture:
                    this.method_313(A_0 as DocPicture);
                    break;

                case DocumentObjectType.Field:
                    this.method_47().Push(A_0 as Field);
                    this.method_202(A_0 as Field);
                    break;

                case DocumentObjectType.FieldMark:
                    this.method_310(A_0 as FieldMark);
                    break;

                case DocumentObjectType.MergeField:
                    this.method_304(A_0 as MergeField);
                    break;

                case DocumentObjectType.SeqField:
                    this.method_229(A_0 as SequenceField);
                    break;

                case DocumentObjectType.TextFormField:
                    this.method_235(A_0 as TextFormField);
                    break;

                case DocumentObjectType.DropDownFormField:
                    this.method_233(A_0 as DropDownFormField);
                    break;

                case DocumentObjectType.CheckBox:
                    this.method_234(A_0 as CheckBoxFormField);
                    break;

                case DocumentObjectType.BookmarkStart:
                    if (!this.bool_23)
                    {
                        this.method_366(A_0 as BookmarkStart);
                    }
                    break;

                case DocumentObjectType.BookmarkEnd:
                    if (!this.bool_23)
                    {
                        this.method_364(A_0 as BookmarkEnd);
                    }
                    break;

                case DocumentObjectType.PermissionStart:
                    if (!this.bool_24)
                    {
                        this.method_119(A_0 as PermissionStart);
                    }
                    break;

                case DocumentObjectType.PermissionEnd:
                    if (!this.bool_24)
                    {
                        this.method_120(A_0 as PermissionEnd);
                    }
                    break;

                case DocumentObjectType.Shape:
                    if ((A_0.OwnerParagraph != null) && (this.method_548(A_0.OwnerParagraph) is HeaderFooter))
                    {
                        this.headerFooterType_0 = (this.method_548(A_0.OwnerParagraph) as HeaderFooter).Type;
                        this.bool_19 = true;
                    }
                    this.method_342(A_0 as ShapeObject);
                    this.bool_19 = false;
                    break;

                case DocumentObjectType.ShapeGroup:
                    this.method_359(A_0 as ShapeGroup);
                    break;

                case DocumentObjectType.Comment:
                    this.method_371(A_0 as Comment);
                    break;

                case DocumentObjectType.Footnote:
                    this.method_223(A_0 as Footnote);
                    break;

                case DocumentObjectType.TextBox:
                    this.method_239(A_0 as TextBox);
                    break;

                case DocumentObjectType.Break:
                {
                    Break @break = A_0 as Break;
                    if ((@break.BreakType != BreakType.PageBreak) || !this.method_549(A_0))
                    {
                        this.method_369(@break);
                    }
                    break;
                }
                case DocumentObjectType.Symbol:
                    this.method_303(A_0 as Symbol);
                    break;

                case DocumentObjectType.TOC:
                    this.method_385(A_0 as TableOfContent);
                    break;

                case DocumentObjectType.XmlParaItem:
                    this.method_270(A_0 as Class6);
                    break;

                case DocumentObjectType.CommentMark:
                    this.method_377(A_0 as CommentMark);
                    break;

                case DocumentObjectType.OleObject:
                    this.method_289(A_0 as DocOleObject);
                    break;

                case DocumentObjectType.Ruby:
                    this.method_191(A_0 as Class2);
                    break;

                default:
                    this.method_380(A_0);
                    break;
            }
            if (flag)
            {
                this.class1092_0.method_12();
            }
        }
    }

    private void method_191(Class2 A_0)
    {
        int num = 3;
        if (A_0 != null)
        {
            this.class1092_0.method_11(BookmarkStart.b("帨", num), BookmarkStart.b("嬨", num), this.dictionary_32[BookmarkStart.b("帨", num)]);
            this.class1092_0.method_10(BookmarkStart.b("嬨帪伬嘮", num), this.dictionary_32[BookmarkStart.b("帨", num)]);
            this.method_192(A_0);
            this.method_194(A_0);
            this.method_195(A_0);
            this.class1092_0.method_12();
            this.class1092_0.method_12();
        }
    }

    private void method_192(Class2 A_0)
    {
        int num4 = 14;
        if (A_0 != null)
        {
            this.class1092_0.method_10(BookmarkStart.b("䘳䌵娷䌹氻䰽", num4), this.dictionary_32[BookmarkStart.b("䌳", num4)]);
            this.class1092_0.method_10(BookmarkStart.b("䘳䌵娷䌹紻刽⤿╁⩃", num4), this.dictionary_32[BookmarkStart.b("䌳", num4)]);
            this.class1092_0.method_5(BookmarkStart.b("䈳圵吷", num4), this.dictionary_32[BookmarkStart.b("䌳", num4)], this.method_193(A_0.method_51()));
            this.class1092_0.method_12();
            this.class1092_0.method_10(BookmarkStart.b("尳䘵䬷", num4), this.dictionary_32[BookmarkStart.b("䌳", num4)]);
            this.class1092_0.method_5(BookmarkStart.b("䈳圵吷", num4), this.dictionary_32[BookmarkStart.b("䌳", num4)], (A_0.method_47() * 2f).ToString());
            this.class1092_0.method_12();
            this.class1092_0.method_10(BookmarkStart.b("尳䘵䬷根崻圽㌿❁", num4), this.dictionary_32[BookmarkStart.b("䌳", num4)]);
            this.class1092_0.method_5(BookmarkStart.b("䈳圵吷", num4), this.dictionary_32[BookmarkStart.b("䌳", num4)], (A_0.method_49() * 2f).ToString());
            this.class1092_0.method_12();
            this.class1092_0.method_10(BookmarkStart.b("尳䘵䬷砹崻䴽┿ᙁ⅃㹅㱇", num4), this.dictionary_32[BookmarkStart.b("䌳", num4)]);
            this.class1092_0.method_5(BookmarkStart.b("䈳圵吷", num4), this.dictionary_32[BookmarkStart.b("䌳", num4)], (A_0.method_53() * 2f).ToString());
            this.class1092_0.method_12();
            this.class1092_0.method_12();
        }
    }

    private string method_193(RubyAlign A_0)
    {
        int num = 2;
        switch (A_0)
        {
            case RubyAlign.DistributeLetter:
                return BookmarkStart.b("䰧䌩弫娭䈯嬱嘳䌵䰷弹瀻嬽㐿㙁⅃㑅", num);

            case RubyAlign.DistributeSpace:
                return BookmarkStart.b("䰧䌩弫娭䈯嬱嘳䌵䰷弹漻丽ℿ⅁⅃", num);

            case RubyAlign.Left:
                return BookmarkStart.b("䐧伩䨫娭", num);

            case RubyAlign.Right:
                return BookmarkStart.b("娧䌩䬫䘭䐯", num);

            case RubyAlign.RightVertical:
                return BookmarkStart.b("娧䌩䬫䘭䐯搱儳䐵䰷匹弻弽ⰿ", num);
        }
        return BookmarkStart.b("䬧伩䈫娭唯䀱", num);
    }

    private void method_194(Class2 A_0)
    {
        int num = 15;
        if (A_0 != null)
        {
            this.class1092_0.method_10(BookmarkStart.b("䜴䌶", num), this.dictionary_32[BookmarkStart.b("䈴", num)]);
            this.method_380(A_0.method_45());
            this.class1092_0.method_12();
        }
    }

    private void method_195(TextRange A_0)
    {
        int num = 11;
        if (A_0 != null)
        {
            this.class1092_0.method_10(BookmarkStart.b("䌰䘲圴丶笸娺丼娾", num), this.dictionary_32[BookmarkStart.b("䘰", num)]);
            this.method_380(A_0);
            this.class1092_0.method_12();
        }
    }

    private bool method_196(ParagraphBase A_0)
    {
        if (A_0.OwnerParagraph != null)
        {
            HeaderFooter footer;
            TableCell ownerTextBody = A_0.OwnerParagraph.OwnerTextBody as TableCell;
            if (ownerTextBody != null)
            {
                footer = ownerTextBody.OwnerRow.OwnerTable.OwnerTextBody as HeaderFooter;
            }
            else
            {
                footer = A_0.OwnerParagraph.OwnerTextBody as HeaderFooter;
            }
            if (footer != null)
            {
                Section owner = footer.Owner as Section;
                if (((owner.HeadersFooters[HeaderFooterType.FooterEven] == footer) || (owner.HeadersFooters[HeaderFooterType.FooterFirstPage] == footer)) || (owner.HeadersFooters[HeaderFooterType.FooterOdd] == footer))
                {
                    return false;
                }
                if (A_0.PreviousSibling == null)
                {
                    return true;
                }
            }
        }
        return false;
    }

    private void method_197(WatermarkBase A_0)
    {
        if (A_0.Type == WatermarkType.TextWatermark)
        {
            this.method_198(A_0 as TextWatermark);
        }
        else
        {
            this.method_199(A_0 as PictureWatermark);
        }
    }

    private void method_198(TextWatermark A_0)
    {
        int num = 14;
        this.class1092_0.method_10(BookmarkStart.b("䘳", 14), this.dictionary_32[BookmarkStart.b("䌳", 14)]);
        this.class1092_0.method_10(BookmarkStart.b("䐳張嬷丹", 14), this.dictionary_32[BookmarkStart.b("䌳", 14)]);
        this.class1092_0.method_10(BookmarkStart.b("䜳帵夷䨹夻", 14), this.dictionary_32[BookmarkStart.b("䈳", 14)]);
        this.class1092_0.method_4(BookmarkStart.b("崳刵", 14), BookmarkStart.b("搳夵伷弹主渽ⰿ㝁㝃ᅅ⥇㹉⥋㱍ᵏ㍑♓㵕᝗㡙㙛㭝͟ᙡ坣坥", 14) + Guid.NewGuid().ToString());
        this.class1092_0.method_4(BookmarkStart.b("䀳伵䠷弹", 14), BookmarkStart.b("ᜳ椵䀷ਹ఻฽瀿ᵁぃ睅筇籉", 14));
        this.class1092_0.method_5(BookmarkStart.b("唳娵吷唹䬻圽⸿⅁⅃⩅⑇", 14), this.dictionary_32[BookmarkStart.b("嬳", 14)], BookmarkStart.b("刳", 14));
        string str = this.method_200(A_0);
        this.class1092_0.method_4(BookmarkStart.b("䜳䈵䄷嘹夻", 14), str);
        StringBuilder builder = new StringBuilder();
        this.class1092_0.method_4(BookmarkStart.b("刳張吷嘹弻儽ⰿⵁ㙃", 14), BookmarkStart.b("ᜳ", 14) + this.method_535(A_0.Color));
        this.class1092_0.method_4(BookmarkStart.b("䜳䈵䨷唹圻嬽␿", 14), BookmarkStart.b("刳", 14));
        if (A_0.Semitransparent)
        {
            this.class1092_0.method_10(BookmarkStart.b("刳張吷嘹", num), this.dictionary_32[BookmarkStart.b("䈳", num)]);
            this.class1092_0.method_4(BookmarkStart.b("嬳䘵夷夹唻䨽㤿", num), BookmarkStart.b("ᨳ̵", num));
            this.class1092_0.method_12();
        }
        this.class1092_0.method_10(BookmarkStart.b("䀳匵䀷丹䰻弽㐿⩁", num), this.dictionary_32[BookmarkStart.b("䈳", num)]);
        builder.Remove(0, builder.Length);
        builder.Append(BookmarkStart.b("刳夵嘷丹ᄻ堽ℿ⽁ⵃ⩅ㅇ灉", num) + this.string_1);
        builder.Append(A_0.FontName.Replace(this.string_2, string.Empty));
        builder.Append(this.string_1);
        if ((A_0.FontSize != 36f) && (A_0.FontSize != 144f))
        {
            builder.Append(BookmarkStart.b("༳倵圷吹䠻ጽ㌿⭁㹃⍅片", num));
            builder.Append(A_0.FontSize);
            builder.Append(BookmarkStart.b("䐳䈵", num));
        }
        else
        {
            builder.Append(BookmarkStart.b("༳倵圷吹䠻ጽ㌿⭁㹃⍅片硉╋⁍", num));
        }
        this.class1092_0.method_4(BookmarkStart.b("䜳䈵䄷嘹夻", num), builder.ToString());
        this.class1092_0.method_4(BookmarkStart.b("䜳䈵䨷匹刻夽", num), A_0.Text.Replace(this.string_2, string.Empty));
        this.class1092_0.method_12();
        this.class1092_0.method_12();
        this.class1092_0.method_12();
        this.class1092_0.method_12();
    }

    private void method_199(PictureWatermark A_0)
    {
        int num = 0x10;
        this.class1092_0.method_10(BookmarkStart.b("䐵", 0x10), this.dictionary_32[BookmarkStart.b("䄵", 0x10)]);
        this.class1092_0.method_10(BookmarkStart.b("䘵儷夹䠻", 0x10), this.dictionary_32[BookmarkStart.b("䄵", 0x10)]);
        this.class1092_0.method_10(BookmarkStart.b("䔵倷嬹䰻嬽", 0x10), this.dictionary_32[BookmarkStart.b("䀵", 0x10)]);
        this.class1092_0.method_4(BookmarkStart.b("張尷", 0x10), BookmarkStart.b("愵圷䠹堻渽⤿⅁ぃ㍅㩇⽉ᭋ⽍⑏㝑♓㭕㥗⡙㝛潝", 0x10) + Guid.NewGuid().ToString());
        this.class1092_0.method_4(BookmarkStart.b("䈵䄷䨹夻", 0x10), BookmarkStart.b("ᔵᬷ改䐻฽瀿牁瑃᥅㱇絉祋", 0x10));
        this.class1092_0.method_5(BookmarkStart.b("圵吷嘹医䤽⤿ⱁ❃⍅⑇♉", 0x10), this.dictionary_32[BookmarkStart.b("夵", 0x10)], BookmarkStart.b("倵", 0x10));
        string str = this.method_201(A_0);
        this.class1092_0.method_4(BookmarkStart.b("䔵䰷䌹倻嬽", 0x10), str);
        this.class1092_0.method_10(BookmarkStart.b("張唷嬹嬻嬽␿⍁ぃ❅", 0x10), this.dictionary_32[BookmarkStart.b("䀵", 0x10)]);
        this.string_3 = this.method_527();
        this.class1092_0.method_5(BookmarkStart.b("張尷", 0x10), this.dictionary_32[BookmarkStart.b("䐵", 0x10)], this.string_3);
        if (A_0.IsWashout)
        {
            this.class1092_0.method_4(BookmarkStart.b("儵夷匹刻", num), BookmarkStart.b("ܵķహ਻༽☿", num));
            this.class1092_0.method_4(BookmarkStart.b("吵吷嬹弻唽ⰿ❁㉃⍅⑇", num), BookmarkStart.b("е਷̹༻ؽ☿", num));
        }
        this.class1092_0.method_12();
        this.class1092_0.method_12();
        this.class1092_0.method_12();
        this.class1092_0.method_12();
    }

    internal List<string> method_2()
    {
        if (this.list_7 == null)
        {
            this.list_7 = new List<string>();
        }
        return this.list_7;
    }

    internal Dictionary<string, DictionaryEntry> method_20()
    {
        if (this.dictionary_14 == null)
        {
            this.dictionary_14 = new Dictionary<string, DictionaryEntry>();
        }
        return this.dictionary_14;
    }

    private string method_200(TextWatermark A_0)
    {
        int num = 1;
        StringBuilder builder = new StringBuilder();
        builder.Append(BookmarkStart.b("圦䘨堪䐬嬮堰尲嬴ശ堸夺丼倾ⵀ㙂ㅄ≆版❊⡌⥎═楒敔汖ⵘ㹚╜⭞䱠ɢ।๦๨ժ坬ͮᑰᕲŴ䱶ᑸོ᩺᡾ꢄ歷떎ꆐꢒﲚ負힢쪤힦鎨鮪隬\ud8ae\ud8b0ힲ솴\udfb6\u83b8", 1));
        if (A_0.ShapeWidthInPixels != -1)
        {
            float num2 = ((float) A_0.ShapeWidthInPixels) / 20f;
            builder.Append(XmlConvert.ToString(num2));
        }
        else
        {
            builder.Append(XmlConvert.ToString((float) (A_0.ShapeSize.Width * 0.6934f)));
        }
        builder.Append(BookmarkStart.b("圦崨ဪ䔬䨮堰吲崴䌶̸", num));
        if (A_0.ShapeHeightInPixels != -1)
        {
            float num3 = A_0.ShapeHeightInPixels / 20;
            builder.Append(XmlConvert.ToString(num3));
        }
        else
        {
            builder.Append(XmlConvert.ToString((float) (A_0.ShapeSize.Height * 0.67f)));
        }
        builder.Append(BookmarkStart.b("圦崨ဪ", num));
        if (A_0.Layout == WatermarkLayout.Diagonal)
        {
            builder.Append(BookmarkStart.b("唦䘨弪䰬嬮堰尲嬴ശਸ਺࠼о", num));
        }
        builder.Append(BookmarkStart.b("崦Ш䈪䌬䬮吰䬲༴ᨶସ఼ฺा瑀療瑄煆煈灊⁌㱎㹐繒╔㡖⩘㉚⥜㙞๠ൢ䡤ས٨ᥪѬᕮṰᵲŴᙶᕸ䅺Ṽ᩾늈ﺌ벐杖쾠躢춤좦\udba8\uc2aa힬삮\udfb0\uc7b2풴\udbb6\u94b8즺\ud8bc\ud3beꃀ럂계뇆곈ꃌ껎ꏐ듒볔맖뛚껜냞쳠鏢諤铦胨鿪蓬胮鿰\udef2\u83f4鋶诸迺铼鳾怀漂㼄搆氈攊礌樎挐⠒研搖瘘㘚洜瀞删䨢儤並䘨䔪,央吰䄲䄴帶娸娺儼ሾ㍀♂⥄♆㵈≊㭌⩎歐㹒㑔╖㹘㉚㍜", num));
        return builder.ToString();
    }

    private string method_201(PictureWatermark A_0)
    {
        float width;
        float height;
        int num = 10;
        StringBuilder builder = new StringBuilder();
        if (A_0.WordPicture.TextWrappingStyle != TextWrappingStyle.Inline)
        {
            builder.Append(BookmarkStart.b("䀯崱䜳張䰷匹医倽稿⍁♃㕅❇♉㥋㩍㕏楑㡓㍕㹗⹙晛湝孟ᙡţṥᱧ䝩൫ɭ᥯ᕱᩳ䱵ᑷό᩻੽", num));
            if (A_0.WordPicture.HorizontalAlignment != ShapeHorizontalAlignment.None)
            {
                builder.Append(BookmarkStart.b("ଯ弱唳䐵強匹刻ጽⰿ❁≃㉅片穉", num));
                builder.Append(BookmarkStart.b("ଯ弱䜳夵ᔷ䨹医䴽⤿㙁ⵃ⥅♇杉⑋⅍≏㭑⹓㥕㙗⹙㵛㉝婟", num) + this.method_261(A_0.WordPicture.HorizontalAlignment));
            }
            else
            {
                builder.Append(BookmarkStart.b("ଯ弱唳䐵強匹刻ጽⰿ❁≃㉅片", num) + A_0.WordPicture.HorizontalPosition + BookmarkStart.b("䀯䘱", num));
            }
            if (A_0.WordPicture.VerticalAlignment != ShapeVerticalAlignment.None)
            {
                builder.Append(BookmarkStart.b("ଯ弱唳䐵強匹刻ጽ㐿ⵁ㑃籅硇", num));
                builder.Append(BookmarkStart.b("ଯ弱䜳夵ᔷ䨹医䴽⤿㙁ⵃ⥅♇杉㩋⭍≏♑㵓㕕㥗㙙晛", num) + this.method_262(A_0.WordPicture.VerticalAlignment));
            }
            else
            {
                builder.Append(BookmarkStart.b("ଯ弱唳䐵強匹刻ጽ㐿ⵁ㑃籅", num) + A_0.WordPicture.VerticalPosition + BookmarkStart.b("䀯䘱", num));
            }
            builder.Append(BookmarkStart.b("ଯ䔱崳刵䰷刹ػ", num));
        }
        else
        {
            builder.Append(BookmarkStart.b("䀯崱䜳張䰷匹医倽稿⍁♃㕅❇♉㥋㩍㕏楑㡓㍕㹗⹙晛湝孟ᙡţṥᱧ䝩൫ɭ᥯ᕱᩳ䱵ᑷό᩻੽뭿ꎍﲏꊗꪙꞛ솟킡쎣쾥욧螩\ud8ab\uc1ad삯袱蒳趵쾷펹\ud8bb\ucabdꢿ", num));
        }
        if (A_0.ScalingAuto)
        {
            float num4 = (this.document_0.LastSection.PageSetup.ClientWidth / A_0.WordPicture.Width) * 100f;
            if (A_0.WordPicture.Width < A_0.WordPicture.Height)
            {
                num4 = (this.document_0.LastSection.PageSetup.ClientHeight / A_0.WordPicture.Height) * 100f;
            }
            A_0.WordPicture.WidthScale = num4;
            A_0.WordPicture.HeightScale = num4;
            A_0.ScalingAuto = false;
        }
        if ((A_0.Scaling != 0f) && (A_0.Scaling != 100f))
        {
            width = A_0.WordPicture.Width * (A_0.Scaling / 100f);
        }
        else
        {
            width = A_0.WordPicture.Width;
        }
        builder.Append(width.ToString().Replace(BookmarkStart.b("ᰯ", num), BookmarkStart.b("ḯ", num)));
        builder.Append(BookmarkStart.b("䀯䘱༳帵崷匹嬻嘽㐿硁", num));
        if ((A_0.Scaling != 0f) && (A_0.Scaling != 100f))
        {
            height = A_0.WordPicture.Height * (A_0.Scaling / 100f);
        }
        else
        {
            height = A_0.WordPicture.Height;
        }
        builder.Append(height.ToString().Replace(BookmarkStart.b("ᰯ", num), BookmarkStart.b("ḯ", num)));
        if (A_0.WordPicture.TextWrappingStyle != TextWrappingStyle.Inline)
        {
            builder.Append(BookmarkStart.b("䀯䘱༳䰵ᔷ匹刻娽┿㩁繃歅穇罉絋硍敏村敓恕恗慙", num));
            builder.Append(BookmarkStart.b("ଯ弱䜳夵ᔷ䨹医䴽⤿㙁ⵃ⥅♇杉⑋⅍≏㭑⹓㥕㙗⹙㵛㉝䵟ၡţ੥१ṩիᡭᕯ䡱", num) + this.method_257(A_0.WordPicture.HorizontalOrigin));
            builder.Append(BookmarkStart.b("ଯ弱䜳夵ᔷ䨹医䴽⤿㙁ⵃ⥅♇杉㩋⭍≏♑㵓㕕㥗㙙煛ⱝ՟๡գብŧᱩ५呭", num) + this.method_259(A_0.WordPicture.VerticalOrigin));
        }
        else
        {
            builder.Append(BookmarkStart.b("䀯䘱༳䰵ᔷ匹刻娽┿㩁繃歅穇罉絋硍敏村敓恕恗慙ㅛⵝཟ佡ᑣ॥᭧ͩᡫݭὯᱱ女ṵ᝷ࡹᕻѽ낉ﺏꎗ趟튡쮣향솧\udea9\uc5ab솭\udeaf\u9fb1\udcb3\ud9b5쪷펹욻톽꺿뛁ꗃ꫅룉꧋ꋍ뇏ꛑ뷓ꃕ뷗뇛뿝鋟藡跣裥폧蟩鿫臭\uddef\u82f1鯳藵釷軹闻釽滿⼁爃挅稇縉攋洍焏縑⸓甕紗琙栛笝刟ᤡ䤣唥䜧ܩ尫䄭䌯嬱䀳張圷吹ᄻ䠽┿ぁぃ⽅⭇⭉⁋捍≏㝑㡓㝕ⱗ㍙⩛㭝婟ཡգᑥཧͩɫ", num));
        }
        return builder.ToString();
    }

    private void method_202(Field A_0)
    {
        int num = 7;
        if (!this.method_222(A_0.Type))
        {
            this.method_46().Push(A_0);
        }
        else
        {
            switch (A_0.Type)
            {
                case FieldType.FieldFileName:
                    this.method_211(A_0);
                    return;

                case FieldType.FieldNext:
                    if (!A_0.ConvertedToText)
                    {
                        this.method_212(A_0);
                        return;
                    }
                    return;

                case FieldType.FieldIncludePicture:
                    this.method_205(A_0);
                    return;

                case FieldType.FieldAdvance:
                case FieldType.FieldAddressBlock:
                    this.method_210(A_0);
                    return;

                case FieldType.FieldHyperlink:
                    this.bool_14 = true;
                    this.method_217(A_0);
                    return;
            }
            this.method_215(A_0);
            this.class1092_0.method_10(BookmarkStart.b("弬", num), this.dictionary_32[BookmarkStart.b("娬", num)]);
            this.method_463(A_0.CharacterFormat);
            if (A_0.CharacterFormat.IsDeleteRevision)
            {
                this.class1092_0.method_10(BookmarkStart.b("䤬䨮崰稲嬴䐶䴸䤺椼娾㥀㝂", num), this.dictionary_32[BookmarkStart.b("娬", num)]);
            }
            else
            {
                this.class1092_0.method_10(BookmarkStart.b("䐬䄮䈰䜲䜴挶尸䌺䤼", num), this.dictionary_32[BookmarkStart.b("娬", num)]);
            }
            if ((((A_0.Type != FieldType.FieldIndexEntry) && (A_0.Type != FieldType.FieldIndex)) && ((A_0.Type != FieldType.FieldUnknown) && (A_0.Type != FieldType.FieldPage))) && ((A_0.Type != FieldType.FieldPageRef) && (A_0.Type != FieldType.FieldMacroButton)))
            {
                this.class1092_0.method_6(BookmarkStart.b("唬䈮崰", num), BookmarkStart.b("帬弮倰倲倴", num), BookmarkStart.b("䔬嬮䔰䌲༴ᠶᘸ䰺䨼䠾潀㑂癄楆♈㥊⩌恎ॐṒᥔ硖桘扚摜杞习ൢѤ੦౨ᡪᵬ๮ተᙲ", num), BookmarkStart.b("崬崮吰䀲倴䔶伸帺", num));
            }
            if (!string.IsNullOrEmpty(A_0.Code))
            {
                this.class1092_0.method_21(this.method_203(A_0.Code));
            }
            else
            {
                string str = this.method_386(A_0.Type);
                this.class1092_0.method_21(str);
                string str2 = this.method_231(A_0.TextFormat);
                this.class1092_0.method_21(str2);
                if (A_0.Value == BookmarkStart.b("ബ", num))
                {
                    A_0.m_fieldValue = this.string_1;
                }
                else if ((((A_0.Value != string.Empty) && A_0.Value.Contains(BookmarkStart.b("ബ", num))) && ((A_0.Value.Length > 1) && !A_0.Value.StartsWith(BookmarkStart.b("爬", num)))) && ((!A_0.Value.Contains(this.string_1) && (A_0.Type != FieldType.FieldFormula)) && (A_0.Type != FieldType.FieldExpression)))
                {
                    A_0.m_fieldValue = this.string_1 + A_0.Value + this.string_1;
                }
                this.method_204(A_0.Value);
                this.method_204(A_0.m_formattingString);
            }
            this.class1092_0.method_12();
            this.class1092_0.method_12();
        }
    }

    private string method_203(string A_0)
    {
        A_0 = A_0.Replace('\x0001', ' ');
        A_0 = A_0.Replace('\v', ' ');
        return A_0;
    }

    private void method_204(string A_0)
    {
        if ((A_0 != null) && (A_0 != string.Empty))
        {
            int index = A_0.IndexOf('\x0001');
            if (index == -1)
            {
                this.class1092_0.method_21(A_0);
            }
            else
            {
                this.class1092_0.method_21(A_0.Substring(0, index));
            }
        }
    }

    private void method_205(Field A_0)
    {
        bool flag;
        int num = 1;
        string str = A_0.method_177().Trim();
        string[] strArray = str.Split(new char[] { '"' });
        string str2 = string.Empty;
        string str3 = string.Empty;
        if (!(flag = A_0.method_66()))
        {
            if (strArray.Length <= 1)
            {
                strArray = str.Split(new char[] { ' ' });
                str2 = strArray[1];
            }
            else
            {
                str2 = strArray[1];
            }
            for (int i = 2; i < strArray.Length; i++)
            {
                str3 = str3 + strArray[i];
            }
            if (string.IsNullOrEmpty(str2))
            {
                return;
            }
        }
        this.method_216();
        this.class1092_0.method_10(BookmarkStart.b("唦", num), this.dictionary_32[BookmarkStart.b("倦", num)]);
        this.method_463(A_0.CharacterFormat);
        this.class1092_0.method_10(BookmarkStart.b("並䜨堪夬崮攰嘲䴴䌶", num), this.dictionary_32[BookmarkStart.b("倦", num)]);
        this.class1092_0.method_6(BookmarkStart.b("弦䐨䜪", num), BookmarkStart.b("否夨䨪丬䨮", num), BookmarkStart.b("伦崨弪崬ᔮḰᰲ䈴䀶丸ᔺ䨼ా潀ⱂ㝄⁆晈ፊL͎繐扒汔湖慘瑚㍜㹞ౠ٢ᙤᝦࡨࡪ࡬", num), BookmarkStart.b("圦嬨个帬䨮䌰䔲倴", num));
        if (flag)
        {
            this.class1092_0.method_21(A_0.Code);
            this.class1092_0.method_12();
            this.class1092_0.method_12();
            return;
        }
        this.class1092_0.method_21(BookmarkStart.b("渦木株愬種田瘲攴縶稸漺格派р捂杄", num) + str2 + BookmarkStart.b("Ԧ", num) + str3);
        this.class1092_0.method_12();
        this.class1092_0.method_12();
        this.method_213();
        this.idocumentObject_0 = A_0.End;
        bool flag2 = false;
        DocPicture picture = null;
        using (IEnumerator enumerator = A_0.Range.GetEnumerator())
        {
            DocumentObject current;
            while (enumerator.MoveNext())
            {
                current = (DocumentObject) enumerator.Current;
                if (current is DocPicture)
                {
                    goto Label_01EA;
                }
            }
            goto Label_021A;
        Label_01EA:
            picture = current as DocPicture;
            picture.method_0(A_0.Owner);
            flag2 = true;
        }
    Label_021A:
        if (!flag2)
        {
            Image image = this.method_206(str2);
            if (image == null)
            {
                return;
            }
            picture = new DocPicture(A_0.Document);
            picture.LoadImage(image);
            picture.method_0(A_0.Owner);
        }
        string str4 = this.method_335(picture, false, null);
        string str5 = this.method_208(str2, A_0);
        string str6 = (BookmarkStart.b("倦䀨伪夬䜮ର", num) + picture.Width.ToString() + BookmarkStart.b("圦崨ဪ䔬䨮堰吲崴䌶̸", num) + picture.Height.ToString() + BookmarkStart.b("圦崨", num)).Replace(BookmarkStart.b("ଦ", num), BookmarkStart.b("द", num));
        this.class1092_0.method_10(BookmarkStart.b("唦", num), this.dictionary_32[BookmarkStart.b("倦", num)]);
        this.class1092_0.method_10(BookmarkStart.b("圦䀨䠪夬", num), this.dictionary_32[BookmarkStart.b("倦", num)]);
        this.class1092_0.method_10(BookmarkStart.b("否䄨䨪崬䨮", num), this.dictionary_32[BookmarkStart.b("儦", num)]);
        this.class1092_0.method_4(BookmarkStart.b("否崨刪䄬䨮", num), str6);
        this.class1092_0.method_10(BookmarkStart.b("並䐨䨪䨬䨮唰刲䄴嘶", num), this.dictionary_32[BookmarkStart.b("儦", num)]);
        this.class1092_0.method_5(BookmarkStart.b("並䴨", num), this.dictionary_32[BookmarkStart.b("唦", num)], str4);
        this.class1092_0.method_5(BookmarkStart.b("伦嬨个䬬", num), this.dictionary_32[BookmarkStart.b("唦", num)], str5);
        this.class1092_0.method_12();
        this.class1092_0.method_12();
        this.class1092_0.method_12();
        this.class1092_0.method_12();
    }

    public Image method_206(string A_0)
    {
        Image image = null;
        if (Uri.IsWellFormedUriString(A_0, UriKind.RelativeOrAbsolute))
        {
            try
            {
                HttpWebRequest request = (HttpWebRequest) WebRequest.Create(A_0);
                request.Timeout = 0x1388;
                request.AllowWriteStreamBuffering = true;
                WebResponse response = request.GetResponse();
                image = Image.FromStream(response.GetResponseStream() as MemoryStream);
                response.Close();
            }
            catch (Exception)
            {
            }
            return image;
        }
        if (File.Exists(A_0))
        {
            image = Image.FromFile(A_0);
        }
        return image;
    }

    private void method_207(Field A_0)
    {
        ParagraphBase base2 = this.method_209(A_0);
        ParagraphBase base3 = null;
        if (((base2 != null) && (base2 is FieldMark)) && ((base2 as FieldMark).Type == FieldMarkType.FieldSeparator))
        {
            ParagraphBase base4 = this.method_209(base2);
            while (base4 != null)
            {
                if (base4 is DocPicture)
                {
                    break;
                }
                base4 = this.method_209(base4);
            }
            if ((base4 != null) && (base4 is DocPicture))
            {
                base3 = this.method_209(base4);
                while (base3 != null)
                {
                    if ((base3 is FieldMark) && ((base3 as FieldMark).Type == FieldMarkType.FieldEnd))
                    {
                        break;
                    }
                    base3 = this.method_209(base3);
                }
                if (((base3 != null) && (base3 is FieldMark)) && ((base3 as FieldMark).Type == FieldMarkType.FieldEnd))
                {
                    base2.SkipDocxItem = true;
                    base4.SkipDocxItem = true;
                    base3.SkipDocxItem = true;
                }
            }
        }
    }

    private string method_208(string A_0, Field A_1)
    {
        A_0 = BookmarkStart.b("䬬䘮崰嘲༴ᠶᘸ", 7) + A_0;
        string key = this.method_527();
        HeaderFooter footer = A_1.OwnerParagraph.method_1();
        if (footer != null)
        {
            Dictionary<string, string> dictionary;
            string str2 = string.Empty;
            foreach (HeaderFooterType type in this.dictionary_10.Keys)
            {
                Dictionary<string, HeaderFooter> dictionary2 = this.dictionary_10[type];
                foreach (string str3 in dictionary2.Keys)
                {
                    if (dictionary2[str3] == footer)
                    {
                        str2 = str3;
                    }
                }
            }
            if (this.method_5().ContainsKey(str2))
            {
                dictionary = this.dictionary_29[str2];
                dictionary.Add(key, A_0);
                return key;
            }
            dictionary = new Dictionary<string, string>();
            dictionary.Add(key, A_0);
            this.method_5().Add(str2, dictionary);
            return key;
        }
        this.method_7().Add(key, A_0);
        return key;
    }

    private ParagraphBase method_209(ParagraphBase A_0)
    {
        if (A_0.NextSibling != null)
        {
            return (A_0.NextSibling as ParagraphBase);
        }
        Paragraph ownerParagraph = A_0.OwnerParagraph;
        int num = ownerParagraph.method_5();
        while (num < ownerParagraph.OwnerTextBody.Items.Count)
        {
            BodyRegion region = ownerParagraph.OwnerTextBody.Items[num++];
            if (!(region is Paragraph))
            {
                return null;
            }
            if ((region as Paragraph).Items.Count > 0)
            {
                return (region as Paragraph).Items[0];
            }
        }
        return null;
    }

    private Dictionary<string, DictionaryEntry> method_21()
    {
        if (this.dictionary_15 == null)
        {
            this.dictionary_15 = new Dictionary<string, DictionaryEntry>();
        }
        return this.dictionary_15;
    }

    private void method_210(Field A_0)
    {
        int num = 6;
        string str = (A_0.Type == FieldType.FieldAddressBlock) ? BookmarkStart.b("ఫ漭琯瘱昳猵欷椹縻爽༿Łགྷ晅", num) : BookmarkStart.b("ఫ漭琯搱申砵笷缹᰻", num);
        this.class1092_0.method_10(BookmarkStart.b("師", num), this.dictionary_32[BookmarkStart.b("嬫", num)]);
        this.method_463(A_0.CharacterFormat);
        this.class1092_0.method_10(BookmarkStart.b("䨫䈭启焱尳圵䨷", num), this.dictionary_32[BookmarkStart.b("嬫", num)]);
        this.class1092_0.method_5(BookmarkStart.b("䨫䈭启焱尳圵䨷渹䔻丽┿", num), this.dictionary_32[BookmarkStart.b("嬫", num)], BookmarkStart.b("丫䬭圯嬱娳", num));
        if (A_0.IsLocked)
        {
            this.class1092_0.method_6(BookmarkStart.b("嬫", num), BookmarkStart.b("䨫䈭启縱嬳唵匷", num), this.dictionary_32[BookmarkStart.b("嬫", num)], BookmarkStart.b("ᴫ", num));
        }
        this.class1092_0.method_12();
        this.class1092_0.method_12();
        this.class1092_0.method_10(BookmarkStart.b("師", num), this.dictionary_32[BookmarkStart.b("嬫", num)]);
        this.class1092_0.method_10(BookmarkStart.b("䔫䀭䌯䘱䘳戵崷䈹䠻", num), this.dictionary_32[BookmarkStart.b("嬫", num)]);
        this.class1092_0.method_6(BookmarkStart.b("含䌭尯", num), BookmarkStart.b("弫席儯儱儳", num), BookmarkStart.b("䐫娭䐯䈱ำᤵ᜷䴹䬻䤽渿㕁睃桅❇㡉⭋慍ࡏὑᡓ祕楗捙敛晝佟ౡգ୥൧ᥩᱫ཭፯᝱", num), BookmarkStart.b("尫尭唯䄱儳䐵丷弹", num));
        this.class1092_0.method_21(str + A_0.Value + A_0.FormattingString);
        this.class1092_0.method_22(BookmarkStart.b("ఫ", num));
        this.class1092_0.method_12();
        this.class1092_0.method_12();
    }

    private void method_211(Field A_0)
    {
        int num = 11;
        this.class1092_0.method_10(BookmarkStart.b("地弲儴搶倸嘺䴼匾⑀", 11), this.dictionary_32[BookmarkStart.b("䘰", 11)]);
        string str = string.IsNullOrEmpty(A_0.Code) ? Class819.smethod_3(A_0.Type) : A_0.Code;
        this.class1092_0.method_5(BookmarkStart.b("堰崲䘴䌶䬸", num), this.dictionary_32[BookmarkStart.b("䘰", num)], str);
        this.class1092_0.method_10(BookmarkStart.b("䌰", num), this.dictionary_32[BookmarkStart.b("䘰", num)]);
        TextRange nextSibling = A_0.NextSibling.NextSibling as TextRange;
        if (nextSibling != null)
        {
            this.method_463(nextSibling.CharacterFormat);
            this.method_382(nextSibling.Text, nextSibling.CharacterFormat.IsDeleteRevision);
        }
        this.class1092_0.method_12();
        this.class1092_0.method_12();
    }

    private void method_212(Field A_0)
    {
        int num = 5;
        this.class1092_0.method_10(BookmarkStart.b("太", 5), this.dictionary_32[BookmarkStart.b("尪", 5)]);
        this.method_463(A_0.CharacterFormat);
        this.class1092_0.method_10(BookmarkStart.b("䴪䄬䬮爰嬲吴䔶", 5), this.dictionary_32[BookmarkStart.b("尪", 5)]);
        this.class1092_0.method_5(BookmarkStart.b("䴪䄬䬮爰嬲吴䔶洸䈺䴼娾", 5), this.dictionary_32[BookmarkStart.b("尪", 5)], BookmarkStart.b("䤪䠬䠮堰崲", 5));
        if (A_0.IsLocked)
        {
            this.class1092_0.method_6(BookmarkStart.b("尪", num), BookmarkStart.b("䴪䄬䬮細尲嘴尶", num), this.dictionary_32[BookmarkStart.b("尪", num)], BookmarkStart.b("ᨪ", num));
        }
        this.class1092_0.method_12();
        this.class1092_0.method_12();
        this.class1092_0.method_10(BookmarkStart.b("太", num), this.dictionary_32[BookmarkStart.b("尪", num)]);
        this.class1092_0.method_10(BookmarkStart.b("䈪䌬尮䔰䄲愴制䄸伺", num), this.dictionary_32[BookmarkStart.b("尪", num)]);
        this.class1092_0.method_6(BookmarkStart.b("匪䀬䌮", num), BookmarkStart.b("堪崬丮到嘲", num), BookmarkStart.b("䌪夬嬮䄰लᨴᠶ丸䰺䨼ᄾ㙀灂歄⡆㭈ⱊ扌ᝎ᱐ὒ穔晖恘扚敜灞འɢࡤɦᩨ᭪౬౮ᑰ", num), BookmarkStart.b("嬪弬䨮䈰嘲䜴䄶尸", num));
        this.class1092_0.method_21(BookmarkStart.b("ପ挬樮椰朲ᔴ", num) + A_0.Value + A_0.FormattingString);
        this.class1092_0.method_12();
        this.class1092_0.method_12();
        this.method_213();
        this.class1092_0.method_10(BookmarkStart.b("太", num), this.dictionary_32[BookmarkStart.b("尪", num)]);
        this.class1092_0.method_10(BookmarkStart.b("弪", num), this.dictionary_32[BookmarkStart.b("尪", num)]);
        this.class1092_0.method_5(BookmarkStart.b("堪崬丮到嘲", num), BookmarkStart.b("䌪夬嬮䄰लᨴᠶ丸䰺䨼ᄾ㙀灂歄⡆㭈ⱊ扌ᝎ᱐ὒ穔晖恘扚敜灞འɢࡤɦᩨ᭪౬౮ᑰ", num), BookmarkStart.b("嬪弬䨮䈰嘲䜴䄶尸", num));
        this.class1092_0.method_21(A_0.Text);
        this.class1092_0.method_12();
        this.class1092_0.method_12();
        this.method_214();
    }

    private void method_213()
    {
        this.class1092_0.method_10(BookmarkStart.b("䜴", 15), this.dictionary_32[BookmarkStart.b("䈴", 15)]);
        this.class1092_0.method_10(BookmarkStart.b("匴嬶崸砺唼帾㍀", 15), this.dictionary_32[BookmarkStart.b("䈴", 15)]);
        this.class1092_0.method_5(BookmarkStart.b("匴嬶崸砺唼帾㍀ᝂ㱄㝆ⱈ", 15), this.dictionary_32[BookmarkStart.b("䈴", 15)], BookmarkStart.b("䘴制䤸娺似帾㕀♂", 15));
        this.class1092_0.method_12();
        this.class1092_0.method_12();
    }

    private void method_214()
    {
        this.class1092_0.method_10(BookmarkStart.b("䀱", 12), this.dictionary_32[BookmarkStart.b("䔱", 12)]);
        this.class1092_0.method_10(BookmarkStart.b("吱堳刵笷刹崻䰽", 12), this.dictionary_32[BookmarkStart.b("䔱", 12)]);
        this.class1092_0.method_5(BookmarkStart.b("吱堳刵笷刹崻䰽ᐿ㭁㑃⍅", 12), this.dictionary_32[BookmarkStart.b("䔱", 12)], BookmarkStart.b("圱娳刵", 12));
        this.class1092_0.method_12();
        this.class1092_0.method_12();
    }

    private void method_215(Field A_0)
    {
        int num = 0;
        this.class1092_0.method_10(BookmarkStart.b("吥", 0), this.dictionary_32[BookmarkStart.b("儥", 0)]);
        if (A_0 != null)
        {
            this.method_463(A_0.CharacterFormat);
        }
        this.class1092_0.method_10(BookmarkStart.b("䀥䐧丩漫䘭儯䀱", num), this.dictionary_32[BookmarkStart.b("儥", num)]);
        this.class1092_0.method_5(BookmarkStart.b("䀥䐧丩漫䘭儯䀱怳伵䠷弹", num), this.dictionary_32[BookmarkStart.b("儥", num)], BookmarkStart.b("䐥䴧䴩䔫䀭", num));
        if ((A_0 != null) && A_0.IsLocked)
        {
            this.class1092_0.method_6(BookmarkStart.b("儥", num), BookmarkStart.b("䀥䐧丩怫䄭匯失", num), this.dictionary_32[BookmarkStart.b("儥", num)], BookmarkStart.b("ᜥ", num));
        }
        this.class1092_0.method_12();
        this.class1092_0.method_12();
    }

    private void method_216()
    {
        this.method_215(null);
    }

    private void method_217(Field A_0)
    {
        int num = 10;
        if (this.method_221(A_0))
        {
            string str = A_0.method_177();
            if ((A_0.Code == str) && A_0.IsInSamePara)
            {
                Hyperlink hyperlink = new Hyperlink(A_0);
                this.class1092_0.method_10(BookmarkStart.b("堯䬱䐳匵䨷嘹唻倽⬿", num), this.dictionary_32[BookmarkStart.b("䜯", num)]);
                this.method_220(A_0);
                this.class1092_0.method_5(BookmarkStart.b("堯嬱䜳䈵圷䠹䔻", num), this.dictionary_32[BookmarkStart.b("䜯", num)], BookmarkStart.b("į", num));
                if (!string.IsNullOrEmpty(hyperlink.ToolTip))
                {
                    this.class1092_0.method_5(BookmarkStart.b("䐯崱嬳娵䰷匹䰻", num), this.dictionary_32[BookmarkStart.b("䜯", num)], hyperlink.ToolTip);
                }
                this.method_218(A_0.NextSibling as ParagraphBase);
                this.class1092_0.method_12();
            }
            else
            {
                this.method_216();
                this.class1092_0.method_10(BookmarkStart.b("䈯", num), this.dictionary_32[BookmarkStart.b("䜯", num)]);
                this.method_463(A_0.CharacterFormat);
                if (A_0.CharacterFormat.IsDeleteRevision)
                {
                    this.class1092_0.method_10(BookmarkStart.b("启圱堳缵嘷䤹䠻䰽ᐿ❁㱃㉅", num), this.dictionary_32[BookmarkStart.b("䜯", num)]);
                }
                else
                {
                    this.class1092_0.method_10(BookmarkStart.b("夯就䜳䈵䨷渹夻䘽㐿", num), this.dictionary_32[BookmarkStart.b("䜯", num)]);
                }
                this.class1092_0.method_6(BookmarkStart.b("䠯弱堳", num), BookmarkStart.b("䌯䈱唳唵崷", num), BookmarkStart.b("堯䘱䀳䘵ȷᔹጻ䤽㜿㕁橃ㅅ筇摉⍋㱍㝏絑౓᭕ᑗ留浛杝奟婡䭣ࡥ१ݩ५ᵭo፱ᝳ፵", num), BookmarkStart.b("䀯䀱儳䔵崷䠹䨻嬽", num));
                string str2 = (!string.IsNullOrEmpty(A_0.Code) || str.StartsWith(BookmarkStart.b("砯欱搳猵樷瘹画瀽ି", num))) ? A_0.Code : (BookmarkStart.b("砯欱搳猵樷瘹画瀽ି扁", num) + A_0.Value);
                this.class1092_0.method_21(this.method_203(str2));
                this.class1092_0.method_12();
                this.class1092_0.method_12();
            }
        }
    }

    private void method_218(ParagraphBase A_0)
    {
        int num = 6;
        int num2 = 0;
        if (A_0 != null)
        {
            if (A_0 is Field)
            {
                num2++;
                this.method_202(A_0 as Field);
                if (((A_0 as Field).Type == FieldType.FieldHyperlink) && (this.fieldMark_0 != null))
                {
                    A_0 = this.fieldMark_0;
                    this.fieldMark_0 = null;
                }
            }
            else if (A_0 is FieldMark)
            {
                this.method_310(A_0 as FieldMark);
                if (((A_0 as FieldMark).Type == FieldMarkType.FieldEnd) && (num2 == 0))
                {
                    this.fieldMark_0 = A_0 as FieldMark;
                    return;
                }
            }
            else if (A_0 is TextRange)
            {
                TextRange range = A_0 as TextRange;
                bool flag = this.method_477(range);
                this.class1092_0.method_11(BookmarkStart.b("嬫", num), BookmarkStart.b("師", num), this.dictionary_32[BookmarkStart.b("嬫", num)]);
                this.method_463(range.CharacterFormat);
                this.method_382(range.Text, range.CharacterFormat.IsDeleteRevision);
                this.class1092_0.method_12();
                if (flag)
                {
                    this.class1092_0.method_12();
                }
            }
            else
            {
                this.method_190(A_0);
            }
            this.method_218(A_0.NextSibling as ParagraphBase);
        }
    }

    private string method_219(string A_0)
    {
        int num = 4;
        if (string.IsNullOrEmpty(A_0))
        {
            return null;
        }
        Match match = new Regex(BookmarkStart.b("ȩ搫眭怯眱昳稵焷琹眻攽᰿ㅁᡃᕅᕇ慉獋杍硏๑ࡓൕ㑗㝙㉛ㅝᑟ㽡䵣㩥᭧䅩卫", num)).Match(A_0);
        string str = null;
        if (match.Success)
        {
            str = match.Groups[1].Value.Replace(BookmarkStart.b("戩甫縭甯怱砳缵瘷焹", num), string.Empty).Trim();
            char[] trimChars = new char[] { '"', '\'' };
            return str.TrimStart(trimChars).TrimEnd(trimChars);
        }
        int startIndex = A_0.IndexOf(this.string_1) + 1;
        int num2 = A_0.LastIndexOf(this.string_1);
        if ((startIndex == 0) && (num2 == -1))
        {
            return A_0.Replace(BookmarkStart.b("戩甫縭甯怱砳缵瘷焹", num), string.Empty).Trim();
        }
        if (num2 > startIndex)
        {
            return A_0.Substring(startIndex, num2 - startIndex);
        }
        return A_0.Substring(startIndex);
    }

    private Dictionary<string, DictionaryEntry> method_22()
    {
        if (this.dictionary_16 == null)
        {
            this.dictionary_16 = new Dictionary<string, DictionaryEntry>();
        }
        return this.dictionary_16;
    }

    private void method_220(Field A_0)
    {
        int num = 0x10;
        string key = this.method_527();
        string str2 = A_0.Value.Replace(this.string_1, string.Empty);
        string str3 = A_0.method_177();
        string str4 = this.method_219(str3);
        str2 = (string.IsNullOrEmpty(str4) || str2.Equals(str4)) ? str2 : str4;
        DocumentObject owner = A_0.method_28().OwnerTextBody.Owner;
        str2 = str2.Replace(BookmarkStart.b("ᘵ", num), BookmarkStart.b("ጵ਷ਹ", num));
        bool flag = str2.StartsWith(BookmarkStart.b("椵氷唹弻", num)) || ((A_0.IsLocal && string.IsNullOrEmpty(str3)) && string.IsNullOrEmpty(str4));
        if ((((str2.IndexOf(BookmarkStart.b("帵䰷丹䰻", num)) == -1) && (str2.IndexOf(BookmarkStart.b("䄵伷䴹", num)) == -1)) && ((str2.IndexOf(BookmarkStart.b("嬵夷匹倻䨽⼿", num)) == -1) && (str2.IndexOf(BookmarkStart.b("尵夷䰹崻䴽⌿ぁⵃ㙅㱇", num)) == -1))) && (str2.IndexOf(BookmarkStart.b("倵䰷䨹ػ", num)) == -1))
        {
            str2 = str2.Replace(this.string_0 + this.string_0, BookmarkStart.b("ᤵ", num));
            if ((str2.Length > 2) && (str2.Substring(0, 3) == BookmarkStart.b("ᠵᘷᔹ", num)))
            {
                str2 = str2.Remove(0, 3);
            }
            else if (A_0.IsLocal || (A_0.FormattingString.IndexOf(this.string_0 + this.string_0 + BookmarkStart.b("娵", num)) != -1))
            {
                str2 = str2.Insert(0, BookmarkStart.b("ᔵ", num));
            }
        }
        if (!(this.method_548(A_0.method_28()) is HeaderFooter) && !this.bool_19)
        {
            if (!flag)
            {
                if (((owner is Section) || (owner is TextBox)) || (owner is TableRow))
                {
                    this.method_10().Add(key, str2);
                }
                else if (owner is Footnote)
                {
                    if ((owner as Footnote).FootnoteType == FootnoteType.Footnote)
                    {
                        this.method_11().Add(key, str2);
                    }
                    else
                    {
                        this.method_12().Add(key, str2);
                    }
                }
                if (owner is Comment)
                {
                    this.method_9().Add(key, str2);
                }
            }
        }
        else
        {
            Dictionary<string, string> dictionary;
            string str5 = string.Empty;
            foreach (HeaderFooterType type in this.dictionary_10.Keys)
            {
                Dictionary<string, HeaderFooter> dictionary2 = this.dictionary_10[type];
                foreach (string str6 in dictionary2.Keys)
                {
                    if ((dictionary2[str6] == (this.method_548(A_0) as HeaderFooter)) || ((dictionary2[str6].Type == this.headerFooterType_0) && this.bool_19))
                    {
                        str5 = str6;
                    }
                }
            }
            if (this.method_13().ContainsKey(str5))
            {
                dictionary = this.dictionary_25[str5];
                dictionary.Add(key, str2);
            }
            else
            {
                dictionary = new Dictionary<string, string>();
                dictionary.Add(key, str2);
                this.method_13().Add(str5, dictionary);
            }
        }
        if (flag)
        {
            this.class1092_0.method_5(BookmarkStart.b("圵嘷夹吻儽㈿", num), this.dictionary_32[BookmarkStart.b("䄵", num)], A_0.Value.Replace(this.string_1, string.Empty));
        }
        else
        {
            this.class1092_0.method_6(BookmarkStart.b("䐵", num), BookmarkStart.b("張尷", num), this.dictionary_32[BookmarkStart.b("䐵", num)], key);
        }
    }

    private bool method_221(Field A_0)
    {
        if (A_0.Type != FieldType.FieldHyperlink)
        {
            return false;
        }
        IDocumentObject nextSibling = A_0;
        for (int i = 0; i < 2; i++)
        {
            nextSibling = nextSibling.NextSibling;
            if (nextSibling == null)
            {
                break;
            }
        }
        if (nextSibling is ShapeObject)
        {
            return false;
        }
        return true;
    }

    private bool method_222(FieldType A_0)
    {
        return (((A_0 != FieldType.FieldDatabase) && (A_0 != FieldType.FieldSkipIf)) && (A_0 != FieldType.FieldShape));
    }

    private void method_223(Footnote A_0)
    {
        bool flag;
        int num = 11;
        A_0.method_34();
        if (flag = A_0.FootnoteType == FootnoteType.Endnote)
        {
            this.method_31(true);
            this.bool_11 = true;
            this.method_44().Add(this.int_9, A_0);
        }
        else
        {
            this.method_29(true);
            this.bool_12 = true;
            this.method_43().Add(this.int_9, A_0);
        }
        this.class1092_0.method_10(BookmarkStart.b("䌰", num), this.dictionary_32[BookmarkStart.b("䘰", num)]);
        this.method_463(A_0.MarkerCharacterFormat);
        string str2 = flag ? BookmarkStart.b("吰崲儴夶嘸伺堼派⑀╂⁄㕆ⱈ╊⹌⩎", num) : BookmarkStart.b("地尲娴䌶圸吺䤼娾ፀ♂⍄≆㭈⹊⍌ⱎ㑐", num);
        this.class1092_0.method_10(str2, this.dictionary_32[BookmarkStart.b("䘰", num)]);
        string str = A_0.IsAutoNumbered ? BookmarkStart.b("İ", num) : BookmarkStart.b("0", num);
        this.class1092_0.method_5(BookmarkStart.b("到䘲䘴䌶嘸嘺瀼帾㍀⡂̈́⡆╈❊≌㡎≐", num), this.dictionary_32[BookmarkStart.b("䘰", num)], str);
        this.class1092_0.method_5(BookmarkStart.b("堰圲", num), this.dictionary_32[BookmarkStart.b("䘰", num)], this.int_9.ToString());
        this.class1092_0.method_12();
        this.int_9++;
        if (!A_0.IsAutoNumbered)
        {
            if (A_0.SymbolCode != 0)
            {
                this.class1092_0.method_10(BookmarkStart.b("䈰䨲場", num), this.dictionary_32[BookmarkStart.b("䘰", num)]);
                this.class1092_0.method_5(BookmarkStart.b("到嬲吴䔶", num), this.dictionary_32[BookmarkStart.b("䘰", num)], BookmarkStart.b("眰̲", num) + Convert.ToString(A_0.SymbolCode, 0x10).ToUpper());
                this.class1092_0.method_5(BookmarkStart.b("地尲嬴䌶", num), this.dictionary_32[BookmarkStart.b("䘰", num)], A_0.SymbolFontName);
                this.class1092_0.method_12();
            }
            else if ((A_0.CustomMarker != string.Empty) && (A_0.CustomMarker != BookmarkStart.b("ᤰ", num)))
            {
                this.class1092_0.method_8(BookmarkStart.b("䔰", num), this.dictionary_32[BookmarkStart.b("䘰", num)], A_0.CustomMarker);
            }
        }
        this.class1092_0.method_12();
    }

    private void method_224(bool A_0)
    {
        int num = 12;
        MemoryStream stream = new MemoryStream();
        string str = string.Empty;
        string str2 = string.Empty;
        this.class1092_0 = this.method_524(stream);
        Dictionary<int, Footnote> dictionary = null;
        if (A_0)
        {
            if (this.dictionary_21 != null)
            {
                dictionary = this.dictionary_21;
            }
        }
        else if (this.dictionary_20 != null)
        {
            dictionary = this.dictionary_20;
        }
        if (dictionary != null)
        {
            if (A_0)
            {
                str = BookmarkStart.b("圱娳刵嘷唹䠻嬽㌿", num);
                str2 = BookmarkStart.b("圱娳刵嘷唹䠻嬽", num);
            }
            else
            {
                str = BookmarkStart.b("吱嬳夵䰷吹医䨽┿ㅁ", num);
                str2 = BookmarkStart.b("吱嬳夵䰷吹医䨽┿", num);
            }
            this.method_227(str, str2);
            if ((this.document_0.FootnoteNodes2010.Count > 0) || (this.document_0.EndnoteNodes2010.Count > 0))
            {
                this.method_225(A_0);
            }
            foreach (int num2 in dictionary.Keys)
            {
                this.method_228(dictionary[num2], A_0, num2);
            }
        }
        this.class1092_0.method_12();
        this.class1092_0.method_15();
        if (A_0)
        {
            this.class771_0.method_14(BookmarkStart.b("䔱嬳䐵尷昹夻倽␿ⱁ⭃㉅ⵇ㥉手㙍㵏㹑", num), stream, false, FileAttributes.Archive);
        }
        else
        {
            this.class771_0.method_14(BookmarkStart.b("䔱嬳䐵尷昹娻儽⼿㙁⩃⥅㱇⽉㽋恍⡏㽑㡓", num), stream, false, FileAttributes.Archive);
        }
    }

    private void method_225(bool A_0)
    {
        if (A_0)
        {
            int num = 0;
            int count = this.document_0.EndnoteNodes2010.Count;
            while (num < count)
            {
                if (num < this.list_0.Count)
                {
                    this.method_226(this.document_0.EndnoteNodes2010[num], this.list_0[num].ToString());
                }
                num++;
            }
        }
        else
        {
            int num3 = 0;
            int num6 = this.document_0.FootnoteNodes2010.Count;
            while (num3 < num6)
            {
                if (num3 < this.list_1.Count)
                {
                    this.method_226(this.document_0.FootnoteNodes2010[num3], this.list_1[num3].ToString());
                }
                num3++;
            }
        }
    }

    private void method_226(Stream A_0, string A_1)
    {
        XmlNodeType type;
        int num = 8;
        A_0.Position = 0L;
        XmlReader reader = Class57.smethod_18(A_0);
        goto Label_017F;
    Label_0032:
        if (!reader.Read())
        {
            return;
        }
    Label_017F:
        switch (reader.NodeType)
        {
            case XmlNodeType.Element:
                this.class1092_0.method_11(reader.Prefix, reader.LocalName, reader.NamespaceURI);
                if ((reader.LocalName == BookmarkStart.b("䠭弯崱䀳堵圷丹夻", num)) || (reader.LocalName == BookmarkStart.b("䬭帯嘱娳夵䰷弹", num)))
                {
                    for (int i = 0; i < reader.AttributeCount; i++)
                    {
                        string str;
                        reader.MoveToAttribute(i);
                        if (((str = reader.LocalName) != null) && (str == BookmarkStart.b("䜭启", num)))
                        {
                            if ((reader.Value != null) && (reader.Value.Length > 0))
                            {
                                this.class1092_0.method_6(reader.Prefix, reader.LocalName, reader.NamespaceURI, A_1);
                            }
                        }
                        else
                        {
                            this.class1092_0.method_6(reader.Prefix, reader.LocalName, reader.NamespaceURI, reader.Value);
                        }
                    }
                }
                if (reader.IsEmptyElement)
                {
                    this.class1092_0.method_12();
                }
                goto Label_0032;

            case XmlNodeType.Attribute:
                goto Label_0032;

            case XmlNodeType.Text:
                this.class1092_0.method_21(reader.Value);
                goto Label_0032;
        }
        switch (type)
        {
            case XmlNodeType.SignificantWhitespace:
                this.class1092_0.method_22(reader.Value);
                break;

            case XmlNodeType.EndElement:
                this.class1092_0.method_12();
                break;
        }
        goto Label_0032;
    }

    private void method_227(string A_0, string A_1)
    {
        this.dictionary_32 = this.document_0.DocxNameSpace.method_0()[BookmarkStart.b("䀧伩䴫䨭唯䀱刳夵圷丹夻䰽", 2)];
        this.class1092_0.method_11(BookmarkStart.b("弧", 2), A_0, this.dictionary_32[BookmarkStart.b("弧", 2)]);
        this.class1092_0.method_6(BookmarkStart.b("倧䜩䀫䀭䌯", 2), BookmarkStart.b("帧", 2), null, this.dictionary_32[BookmarkStart.b("帧", 2)]);
        this.class1092_0.method_6(BookmarkStart.b("倧䜩䀫䀭䌯", 2), BookmarkStart.b("弧ᬩᰫ", 2), null, this.dictionary_32[BookmarkStart.b("弧ᬩᰫ", 2)]);
        this.class1092_0.method_6(BookmarkStart.b("倧䜩䀫䀭䌯", 2), BookmarkStart.b("䜧", 2), null, this.dictionary_32[BookmarkStart.b("䜧", 2)]);
        this.class1092_0.method_6(BookmarkStart.b("倧䜩䀫䀭䌯", 2), BookmarkStart.b("帧伩", 2), null, this.dictionary_32[BookmarkStart.b("帧伩", 2)]);
        this.class1092_0.method_6(BookmarkStart.b("倧䜩䀫䀭䌯", 2), BookmarkStart.b("娧", 2), null, this.dictionary_32[BookmarkStart.b("娧", 2)]);
        this.class1092_0.method_6(BookmarkStart.b("倧䜩䀫䀭䌯", 2), BookmarkStart.b("䔧", 2), null, this.dictionary_32[BookmarkStart.b("䔧", 2)]);
        this.class1092_0.method_6(BookmarkStart.b("倧䜩䀫䀭䌯", 2), BookmarkStart.b("弧䐩䤫", 2), null, this.dictionary_32[BookmarkStart.b("弧䐩䤫", 2)]);
        this.class1092_0.method_6(BookmarkStart.b("倧䜩䀫䀭䌯", 2), BookmarkStart.b("䤧", 2), null, this.dictionary_32[BookmarkStart.b("䤧", 2)]);
        this.class1092_0.method_6(BookmarkStart.b("倧䜩䀫䀭䌯", 2), BookmarkStart.b("堧䌩伫", 2), null, this.dictionary_32[BookmarkStart.b("堧䌩伫", 2)]);
        this.class1092_0.method_6(BookmarkStart.b("倧䜩䀫䀭䌯", 2), BookmarkStart.b("弧娩", 2), null, this.dictionary_32[BookmarkStart.b("弧娩", 2)]);
        this.class1092_0.method_11(BookmarkStart.b("弧", 2), A_1, this.dictionary_32[BookmarkStart.b("弧", 2)]);
        this.class1092_0.method_5(BookmarkStart.b("尧匩尫䬭", 2), this.dictionary_32[BookmarkStart.b("弧", 2)], BookmarkStart.b("嬧伩尫伭䈯匱䀳夵䨷", 2));
        this.class1092_0.method_5(BookmarkStart.b("䄧丩", 2), this.dictionary_32[BookmarkStart.b("弧", 2)], BookmarkStart.b("ᠧ", 2));
        this.class1092_0.method_10(BookmarkStart.b("堧", 2), this.dictionary_32[BookmarkStart.b("弧", 2)]);
        this.class1092_0.method_10(BookmarkStart.b("娧", 2), this.dictionary_32[BookmarkStart.b("弧", 2)]);
        this.class1092_0.method_10(BookmarkStart.b("嬧伩尫伭䈯匱䀳夵䨷", 2), this.dictionary_32[BookmarkStart.b("弧", 2)]);
        this.class1092_0.method_12();
        this.class1092_0.method_12();
        this.class1092_0.method_12();
        this.class1092_0.method_12();
        this.class1092_0.method_11(BookmarkStart.b("弧", 2), A_1, this.dictionary_32[BookmarkStart.b("弧", 2)]);
        this.class1092_0.method_5(BookmarkStart.b("尧匩尫䬭", 2), this.dictionary_32[BookmarkStart.b("弧", 2)], BookmarkStart.b("䬧䔩䈫娭夯就䄳圵䰷匹医倽ጿ❁㑃❅㩇⭉㡋⅍≏", 2));
        this.class1092_0.method_5(BookmarkStart.b("䄧丩", 2), this.dictionary_32[BookmarkStart.b("弧", 2)], BookmarkStart.b("ᤧ", 2));
        this.class1092_0.method_10(BookmarkStart.b("堧", 2), this.dictionary_32[BookmarkStart.b("弧", 2)]);
        this.class1092_0.method_10(BookmarkStart.b("娧", 2), this.dictionary_32[BookmarkStart.b("弧", 2)]);
        this.class1092_0.method_10(BookmarkStart.b("䬧䔩䈫娭夯就䄳圵䰷匹医倽ጿ❁㑃❅㩇⭉㡋⅍≏", 2), this.dictionary_32[BookmarkStart.b("弧", 2)]);
        this.class1092_0.method_12();
        this.class1092_0.method_12();
        this.class1092_0.method_12();
        this.class1092_0.method_12();
    }

    private void method_228(Footnote A_0, bool A_1, int A_2)
    {
        int num = 7;
        if (A_1)
        {
            this.class1092_0.method_10(BookmarkStart.b("䠬䄮唰崲娴䌶尸", num), this.dictionary_32[BookmarkStart.b("娬", num)]);
        }
        else
        {
            this.class1092_0.method_10(BookmarkStart.b("䬬䀮帰䜲嬴堶䴸帺", num), this.dictionary_32[BookmarkStart.b("娬", num)]);
        }
        this.class1092_0.method_5(BookmarkStart.b("䐬䬮", num), this.dictionary_32[BookmarkStart.b("娬", num)], A_2.ToString());
        foreach (BodyRegion region in A_0.TextBody.Items)
        {
            this.method_117(region, false);
        }
        this.class1092_0.method_12();
    }

    private void method_229(SequenceField A_0)
    {
        int num = 9;
        this.class1092_0.method_11(BookmarkStart.b("堮", 9), BookmarkStart.b("崮", 9), this.dictionary_32[BookmarkStart.b("堮", 9)]);
        this.class1092_0.method_11(BookmarkStart.b("堮", 9), BookmarkStart.b("䤮崰圲瘴弶堸䤺", 9), this.dictionary_32[BookmarkStart.b("堮", 9)]);
        this.class1092_0.method_6(BookmarkStart.b("堮", 9), BookmarkStart.b("䤮崰圲瘴弶堸䤺椼䘾ㅀ♂", 9), this.dictionary_32[BookmarkStart.b("堮", 9)], BookmarkStart.b("䴮吰吲尴夶", 9));
        if (A_0.IsLocked)
        {
            this.class1092_0.method_6(BookmarkStart.b("堮", num), BookmarkStart.b("䤮崰圲礴堶娸债", num), this.dictionary_32[BookmarkStart.b("堮", num)], BookmarkStart.b("Ḯ", num));
        }
        this.class1092_0.method_12();
        this.class1092_0.method_12();
        this.class1092_0.method_11(BookmarkStart.b("堮", num), BookmarkStart.b("崮", num), this.dictionary_32[BookmarkStart.b("堮", num)]);
        this.method_230(A_0);
        this.class1092_0.method_12();
    }

    private Dictionary<string, DictionaryEntry> method_23()
    {
        if (this.dictionary_17 == null)
        {
            this.dictionary_17 = new Dictionary<string, DictionaryEntry>();
        }
        return this.dictionary_17;
    }

    private void method_230(SequenceField A_0)
    {
        StringBuilder builder = new StringBuilder();
        builder.Append(BookmarkStart.b("ᤸ栺砼渾慀", 0x13));
        builder.Append(A_0.CaptionName + BookmarkStart.b("ᤸ", 0x13));
        builder.Append(this.method_231(A_0.TextFormat) + BookmarkStart.b("ᤸ", 0x13));
        builder.Append(this.method_232(A_0.NumberFormat) + BookmarkStart.b("ᤸ", 0x13));
        this.class1092_0.method_11(BookmarkStart.b("丸", 0x13), BookmarkStart.b("倸唺丼䬾㍀ᝂ⁄㽆㵈", 0x13), this.dictionary_32[BookmarkStart.b("丸", 0x13)]);
        this.class1092_0.method_6(BookmarkStart.b("䄸嘺儼", 0x13), BookmarkStart.b("䨸䬺尼尾⑀", 0x13), null, BookmarkStart.b("䤸䤺堼䰾⑀ㅂ㍄≆", 0x13));
        this.class1092_0.method_21(builder.ToString());
        this.class1092_0.method_12();
    }

    private string method_231(TextFormat A_0)
    {
        int num = 14;
        switch (A_0)
        {
            case TextFormat.Uppercase:
                return (this.string_0 + BookmarkStart.b("ḳᘵ洷䨹䰻嬽㈿", num));

            case TextFormat.Lowercase:
                return (this.string_0 + BookmarkStart.b("ḳᘵ琷唹䬻嬽㈿", num));

            case TextFormat.FirstCapital:
                return (this.string_0 + BookmarkStart.b("ḳᘵ縷匹主䴽㐿Ł╃㙅", num));

            case TextFormat.Titlecase:
                return (this.string_0 + BookmarkStart.b("ḳᘵ笷嬹䰻䴽", num));
        }
        return string.Empty;
    }

    private string method_232(CaptionNumberingFormat A_0)
    {
        int num = 13;
        switch (A_0)
        {
            case CaptionNumberingFormat.Number:
                return (this.string_0 + BookmarkStart.b("ᤲᔴ瘶欸稺缼瘾ɀ", num));

            case CaptionNumberingFormat.Roman:
                return (this.string_0 + BookmarkStart.b("ᤲᔴ收嘸嘺尼儾", num));

            case CaptionNumberingFormat.Alphabetic:
                return (this.string_0 + BookmarkStart.b("ᤲᔴ瘶甸欺甼績̀قᅄๆੈ", num));
        }
        return string.Empty;
    }

    private void method_233(DropDownFormField A_0)
    {
        int num = 2;
        this.method_47().Push(A_0);
        this.class1092_0.method_10(BookmarkStart.b("娧", 2), this.dictionary_32[BookmarkStart.b("弧", 2)]);
        this.method_463(A_0.CharacterFormat);
        this.class1092_0.method_10(BookmarkStart.b("丧䘩䠫洭堯匱䘳", 2), this.dictionary_32[BookmarkStart.b("弧", 2)]);
        this.class1092_0.method_6(BookmarkStart.b("弧", 2), BookmarkStart.b("丧䘩䠫洭堯匱䘳戵䄷䨹夻", 2), this.dictionary_32[BookmarkStart.b("弧", 2)], BookmarkStart.b("䨧伩䬫䜭帯", 2));
        if (A_0.IsLocked)
        {
            this.class1092_0.method_6(BookmarkStart.b("弧", num), BookmarkStart.b("丧䘩䠫戭弯儱弳", num), this.dictionary_32[BookmarkStart.b("弧", num)], BookmarkStart.b("ᤧ", num));
        }
        if (A_0.HasFFData)
        {
            this.class1092_0.method_10(BookmarkStart.b("丧䰩栫伭䐯匱", num), this.dictionary_32[BookmarkStart.b("弧", num)]);
            this.method_237(A_0);
            this.class1092_0.method_10(BookmarkStart.b("䰧丩怫䜭䌯䘱", num), this.dictionary_32[BookmarkStart.b("弧", num)]);
            this.class1092_0.method_10(BookmarkStart.b("䰧伩䨫伭䔯帱䀳", num), this.dictionary_32[BookmarkStart.b("弧", num)]);
            this.class1092_0.method_6(BookmarkStart.b("弧", num), BookmarkStart.b("帧䬩䀫", num), this.dictionary_32[BookmarkStart.b("弧", num)], A_0.DefaultDropDownValue.ToString());
            this.class1092_0.method_12();
            if (A_0.DropDownSelectedIndex > 0)
            {
                this.class1092_0.method_10(BookmarkStart.b("娧伩弫嬭尯䘱", num), this.dictionary_32[BookmarkStart.b("弧", num)]);
                this.class1092_0.method_6(BookmarkStart.b("弧", num), BookmarkStart.b("帧䬩䀫", num), this.dictionary_32[BookmarkStart.b("弧", num)], A_0.DropDownSelectedIndex.ToString());
                this.class1092_0.method_12();
            }
            foreach (DropDownItem item in A_0.DropDownItems)
            {
                this.class1092_0.method_10(BookmarkStart.b("䐧䌩弫娭甯就䀳䐵䄷", num), this.dictionary_32[BookmarkStart.b("弧", num)]);
                this.class1092_0.method_5(BookmarkStart.b("帧䬩䀫", num), this.dictionary_32[BookmarkStart.b("弧", num)], item.Text);
                this.class1092_0.method_12();
            }
            this.class1092_0.method_12();
            this.class1092_0.method_12();
        }
        this.class1092_0.method_12();
        this.class1092_0.method_12();
        this.class1092_0.method_10(BookmarkStart.b("娧", num), this.dictionary_32[BookmarkStart.b("弧", num)]);
        this.method_463(A_0.CharacterFormat);
        this.class1092_0.method_10(BookmarkStart.b("䄧䐩弫娭䈯昱儳丵䰷", num), this.dictionary_32[BookmarkStart.b("弧", num)]);
        this.class1092_0.method_21(BookmarkStart.b("渧攩縫挭琯怱笳昵簷甹欻瀽", num));
        this.class1092_0.method_12();
        this.class1092_0.method_12();
    }

    private void method_234(CheckBoxFormField A_0)
    {
        int num = 3;
        this.method_47().Push(A_0);
        this.class1092_0.method_10(BookmarkStart.b("嬨", 3), this.dictionary_32[BookmarkStart.b("帨", 3)]);
        this.method_463(A_0.CharacterFormat);
        this.class1092_0.method_10(BookmarkStart.b("伨䜪䤬氮夰刲䜴", 3), this.dictionary_32[BookmarkStart.b("帨", 3)]);
        this.class1092_0.method_6(BookmarkStart.b("帨", 3), BookmarkStart.b("伨䜪䤬氮夰刲䜴挶䀸䬺堼", 3), this.dictionary_32[BookmarkStart.b("帨", 3)], BookmarkStart.b("䬨个䨬䘮弰", 3));
        if (A_0.IsLocked)
        {
            this.class1092_0.method_6(BookmarkStart.b("帨", num), BookmarkStart.b("伨䜪䤬挮帰倲帴", num), this.dictionary_32[BookmarkStart.b("帨", num)], BookmarkStart.b("ᠨ", num));
        }
        if (A_0.HasFFData)
        {
            this.class1092_0.method_10(BookmarkStart.b("伨䴪椬丮䔰刲", num), this.dictionary_32[BookmarkStart.b("帨", num)]);
            this.method_237(A_0);
            this.class1092_0.method_12();
        }
        this.class1092_0.method_12();
        this.class1092_0.method_12();
        this.class1092_0.method_10(BookmarkStart.b("嬨", num), this.dictionary_32[BookmarkStart.b("帨", num)]);
        this.method_463(A_0.CharacterFormat);
        this.class1092_0.method_10(BookmarkStart.b("䀨䔪帬嬮䌰朲倴伶䴸", num), this.dictionary_32[BookmarkStart.b("帨", num)]);
        this.class1092_0.method_21(BookmarkStart.b("漨搪缬戮爰笲瀴琶爸示爼朾", num));
        this.class1092_0.method_12();
        this.class1092_0.method_12();
    }

    private void method_235(TextFormField A_0)
    {
        int num = 2;
        this.method_47().Push(A_0);
        this.class1092_0.method_10(BookmarkStart.b("娧", 2), this.dictionary_32[BookmarkStart.b("弧", 2)]);
        this.method_463(A_0.CharacterFormat);
        this.class1092_0.method_10(BookmarkStart.b("丧䘩䠫洭堯匱䘳", 2), this.dictionary_32[BookmarkStart.b("弧", 2)]);
        this.class1092_0.method_6(BookmarkStart.b("弧", 2), BookmarkStart.b("丧䘩䠫洭堯匱䘳戵䄷䨹夻", 2), this.dictionary_32[BookmarkStart.b("弧", 2)], BookmarkStart.b("䨧伩䬫䜭帯", 2));
        if (A_0.IsLocked)
        {
            this.class1092_0.method_6(BookmarkStart.b("弧", num), BookmarkStart.b("丧䘩䠫戭弯儱弳", num), this.dictionary_32[BookmarkStart.b("弧", num)], BookmarkStart.b("ᤧ", num));
        }
        if (A_0.HasFFData)
        {
            this.class1092_0.method_10(BookmarkStart.b("丧䰩栫伭䐯匱", num), this.dictionary_32[BookmarkStart.b("弧", num)]);
            this.method_237(A_0);
            this.class1092_0.method_12();
        }
        this.class1092_0.method_12();
        this.class1092_0.method_12();
        this.class1092_0.method_10(BookmarkStart.b("娧", num), this.dictionary_32[BookmarkStart.b("弧", num)]);
        this.method_463(A_0.CharacterFormat);
        this.class1092_0.method_10(BookmarkStart.b("䄧䐩弫娭䈯昱儳丵䰷", num), this.dictionary_32[BookmarkStart.b("弧", num)]);
        this.class1092_0.method_21(BookmarkStart.b("渧攩縫挭搯眱氳戵", num));
        this.class1092_0.method_12();
        this.class1092_0.method_12();
    }

    private void method_236(TextFormField A_0)
    {
        int num = 0x11;
        string text = string.Empty;
        bool flag = false;
        if ((A_0.TextRange.Text.Length != 0) && !A_0.IsDefaultText)
        {
            if (A_0.TextFieldType == TextFormFieldType.RegularText)
            {
                A_0.TextRange.Text = FormField.smethod_6(A_0.TextFormat, A_0.TextRange.Text);
            }
        }
        else
        {
            if (A_0.DefaultText.Length > 0)
            {
                if (A_0.TextFieldType == TextFormFieldType.RegularText)
                {
                    A_0.TextRange.Text = FormField.smethod_6(A_0.TextFormat, A_0.DefaultText);
                }
                else
                {
                    A_0.TextRange.Text = A_0.DefaultText;
                }
            }
            flag = true;
        }
        if (!flag)
        {
            this.class1092_0.method_10(BookmarkStart.b("䔶", num), this.dictionary_32[BookmarkStart.b("䀶", num)]);
            this.method_463(A_0.TextRange.CharacterFormat);
            if (A_0.TextRange.Text != string.Empty)
            {
                this.method_382(A_0.TextRange.Text, false);
            }
            this.class1092_0.method_12();
        }
        else
        {
            text = A_0.TextRange.Text;
            int length = text.Length;
            for (int i = 0; i < length; i++)
            {
                this.class1092_0.method_10(BookmarkStart.b("䔶", num), this.dictionary_32[BookmarkStart.b("䀶", num)]);
                this.method_463(A_0.CharacterFormat);
                string str2 = text.Substring(i, 1);
                this.method_382(str2, false);
                this.class1092_0.method_12();
            }
        }
        this.idocumentObject_0 = A_0.End;
    }

    private void method_237(FormField A_0)
    {
        TextFormField field2;
        int num = 0x12;
        if ((A_0.MacroOnStart != null) && (A_0.MacroOnStart.Length > 0))
        {
            this.class1092_0.method_10(BookmarkStart.b("崷吹䠻䰽㤿ཁ╃╅㩇╉", num), this.dictionary_32[BookmarkStart.b("伷", num)]);
            this.class1092_0.method_5(BookmarkStart.b("丷嬹倻", num), this.dictionary_32[BookmarkStart.b("伷", num)], A_0.MacroOnStart);
            this.class1092_0.method_12();
        }
        if ((A_0.MacroOnEnd != null) && (A_0.MacroOnEnd.Length > 0))
        {
            this.class1092_0.method_10(BookmarkStart.b("崷䈹唻䨽ി⍁❃㑅❇", num), this.dictionary_32[BookmarkStart.b("伷", num)]);
            this.class1092_0.method_5(BookmarkStart.b("丷嬹倻", num), this.dictionary_32[BookmarkStart.b("伷", num)], A_0.MacroOnEnd);
            this.class1092_0.method_12();
        }
        if (A_0.Help != "")
        {
            this.class1092_0.method_10(BookmarkStart.b("倷弹倻丽ᐿ❁㱃㉅", num), this.dictionary_32[BookmarkStart.b("伷", num)]);
            if ((A_0.Params & 0x80) == 0x80)
            {
                this.class1092_0.method_5(BookmarkStart.b("䰷䌹䰻嬽", num), this.dictionary_32[BookmarkStart.b("伷", num)], BookmarkStart.b("䰷弹䐻䨽", num));
            }
            else
            {
                this.class1092_0.method_5(BookmarkStart.b("䰷䌹䰻嬽", num), this.dictionary_32[BookmarkStart.b("伷", num)], BookmarkStart.b("夷伹䠻儽ᐿ❁㱃㉅", num));
            }
            this.class1092_0.method_5(BookmarkStart.b("丷嬹倻", num), this.dictionary_32[BookmarkStart.b("伷", num)], A_0.Help);
            this.class1092_0.method_12();
        }
        if (A_0.StatusBarHelp != "")
        {
            this.class1092_0.method_10(BookmarkStart.b("䬷丹崻䨽㔿ㅁ၃⍅ぇ㹉", num), this.dictionary_32[BookmarkStart.b("伷", num)]);
            if ((A_0.Params & 0x100) == 0x100)
            {
                this.class1092_0.method_5(BookmarkStart.b("䰷䌹䰻嬽", num), this.dictionary_32[BookmarkStart.b("伷", num)], BookmarkStart.b("䰷弹䐻䨽", num));
            }
            else
            {
                this.class1092_0.method_5(BookmarkStart.b("䰷䌹䰻嬽", num), this.dictionary_32[BookmarkStart.b("伷", num)], BookmarkStart.b("夷伹䠻儽ᐿ❁㱃㉅", num));
            }
            this.class1092_0.method_5(BookmarkStart.b("丷嬹倻", num), this.dictionary_32[BookmarkStart.b("伷", num)], A_0.StatusBarHelp);
            this.class1092_0.method_12();
        }
        if (!A_0.Enabled)
        {
            this.class1092_0.method_10(BookmarkStart.b("崷吹崻尽ⰿ❁⁃", num), this.dictionary_32[BookmarkStart.b("伷", num)]);
            this.class1092_0.method_5(BookmarkStart.b("丷嬹倻", num), this.dictionary_32[BookmarkStart.b("伷", num)], BookmarkStart.b("࠷", num));
            this.class1092_0.method_12();
        }
        if (A_0.CalculateOnExit)
        {
            this.class1092_0.method_10(BookmarkStart.b("嬷嬹倻崽༿ⱁŃ㹅ⅇ㹉", num), this.dictionary_32[BookmarkStart.b("伷", num)]);
            this.class1092_0.method_12();
        }
        if (A_0.Name != "")
        {
            this.class1092_0.method_10(BookmarkStart.b("嘷嬹儻嬽", num), this.dictionary_32[BookmarkStart.b("伷", num)]);
            this.class1092_0.method_5(BookmarkStart.b("丷嬹倻", num), this.dictionary_32[BookmarkStart.b("伷", num)], A_0.Name);
            this.class1092_0.method_12();
        }
        switch (A_0.Type)
        {
            case FieldType.FieldFormTextInput:
                field2 = A_0 as TextFormField;
                this.class1092_0.method_10(BookmarkStart.b("䰷弹䐻䨽िⱁ㑃㍅㱇", num), this.dictionary_32[BookmarkStart.b("伷", num)]);
                if (field2.MaximumLength > 0)
                {
                    this.class1092_0.method_10(BookmarkStart.b("唷嬹䐻爽┿ⱁ⍃㉅⁇", num), this.dictionary_32[BookmarkStart.b("伷", num)]);
                    this.class1092_0.method_5(BookmarkStart.b("丷嬹倻", num), this.dictionary_32[BookmarkStart.b("伷", num)], field2.MaximumLength.ToString());
                    this.class1092_0.method_12();
                }
                switch (field2.TextFieldType)
                {
                    case TextFormFieldType.RegularText:
                        this.class1092_0.method_10(BookmarkStart.b("䰷䌹䰻嬽", num), this.dictionary_32[BookmarkStart.b("伷", num)]);
                        this.class1092_0.method_5(BookmarkStart.b("丷嬹倻", num), this.dictionary_32[BookmarkStart.b("伷", num)], BookmarkStart.b("䨷弹嬻䬽ⰿ⍁㙃", num));
                        this.class1092_0.method_12();
                        goto Label_07D3;

                    case TextFormFieldType.NumberText:
                        this.class1092_0.method_10(BookmarkStart.b("䰷䌹䰻嬽", num), this.dictionary_32[BookmarkStart.b("伷", num)]);
                        this.class1092_0.method_5(BookmarkStart.b("丷嬹倻", num), this.dictionary_32[BookmarkStart.b("伷", num)], BookmarkStart.b("嘷伹儻尽┿ぁ", num));
                        this.class1092_0.method_12();
                        goto Label_07D3;

                    case TextFormFieldType.DateText:
                        this.class1092_0.method_10(BookmarkStart.b("䰷䌹䰻嬽", num), this.dictionary_32[BookmarkStart.b("伷", num)]);
                        this.class1092_0.method_5(BookmarkStart.b("丷嬹倻", num), this.dictionary_32[BookmarkStart.b("伷", num)], BookmarkStart.b("尷嬹䠻嬽", num));
                        this.class1092_0.method_12();
                        goto Label_07D3;

                    case TextFormFieldType.CurrentDate:
                        this.class1092_0.method_10(BookmarkStart.b("䰷䌹䰻嬽", num), this.dictionary_32[BookmarkStart.b("伷", num)]);
                        this.class1092_0.method_5(BookmarkStart.b("丷嬹倻", num), this.dictionary_32[BookmarkStart.b("伷", num)], BookmarkStart.b("嬷伹主䰽┿ⱁぃɅ⥇㹉⥋", num));
                        this.class1092_0.method_12();
                        goto Label_07D3;

                    case TextFormFieldType.CurrentTime:
                        this.class1092_0.method_10(BookmarkStart.b("䰷䌹䰻嬽", num), this.dictionary_32[BookmarkStart.b("伷", num)]);
                        this.class1092_0.method_5(BookmarkStart.b("丷嬹倻", num), this.dictionary_32[BookmarkStart.b("伷", num)], BookmarkStart.b("嬷伹主䰽┿ⱁぃቅⅇ❉⥋", num));
                        this.class1092_0.method_12();
                        goto Label_07D3;

                    case TextFormFieldType.Calculation:
                        this.class1092_0.method_10(BookmarkStart.b("䰷䌹䰻嬽", num), this.dictionary_32[BookmarkStart.b("伷", num)]);
                        this.class1092_0.method_5(BookmarkStart.b("丷嬹倻", num), this.dictionary_32[BookmarkStart.b("伷", num)], BookmarkStart.b("嬷嬹倻崽㔿⹁╃㉅ⵇ⹉", num));
                        this.class1092_0.method_12();
                        goto Label_07D3;
                }
                break;

            case FieldType.FieldFormCheckBox:
            {
                CheckBoxFormField field = A_0 as CheckBoxFormField;
                this.class1092_0.method_10(BookmarkStart.b("嬷刹夻崽⬿A⭃㹅", num), this.dictionary_32[BookmarkStart.b("伷", num)]);
                if (field.SizeType != CheckBoxSizeType.Auto)
                {
                    this.class1092_0.method_10(BookmarkStart.b("䬷匹䘻嬽", num), this.dictionary_32[BookmarkStart.b("伷", num)]);
                    this.class1092_0.method_5(BookmarkStart.b("丷嬹倻", num), this.dictionary_32[BookmarkStart.b("伷", num)], (field.CheckBoxSize * 2).ToString());
                    this.class1092_0.method_12();
                }
                else
                {
                    this.class1092_0.method_10(BookmarkStart.b("䬷匹䘻嬽Ŀ㝁ぃ⥅", num), this.dictionary_32[BookmarkStart.b("伷", num)]);
                    this.class1092_0.method_12();
                }
                this.class1092_0.method_10(BookmarkStart.b("尷弹娻弽㔿⹁ぃ", num), this.dictionary_32[BookmarkStart.b("伷", num)]);
                string str = field.DefaultCheckBoxValue ? BookmarkStart.b("䰷䠹䤻嬽", num) : BookmarkStart.b("帷嬹倻䴽┿", num);
                this.class1092_0.method_5(BookmarkStart.b("丷嬹倻", num), this.dictionary_32[BookmarkStart.b("伷", num)], str);
                this.class1092_0.method_12();
                if (field.Checked)
                {
                    this.class1092_0.method_10(BookmarkStart.b("嬷刹夻崽⬿❁⁃", num), this.dictionary_32[BookmarkStart.b("伷", num)]);
                    this.class1092_0.method_12();
                }
                else if (field.DefaultCheckBoxValue && !field.Checked)
                {
                    this.class1092_0.method_10(BookmarkStart.b("嬷刹夻崽⬿❁⁃", num), this.dictionary_32[BookmarkStart.b("伷", num)]);
                    this.class1092_0.method_5(BookmarkStart.b("丷嬹倻", num), this.dictionary_32[BookmarkStart.b("伷", num)], BookmarkStart.b("࠷", num));
                    this.class1092_0.method_12();
                }
                this.class1092_0.method_12();
                return;
            }
            default:
                return;
        }
    Label_07D3:
        this.class1092_0.method_10(BookmarkStart.b("尷弹娻弽㔿⹁ぃ", num), this.dictionary_32[BookmarkStart.b("伷", num)]);
        this.class1092_0.method_5(BookmarkStart.b("丷嬹倻", num), this.dictionary_32[BookmarkStart.b("伷", num)], field2.DefaultText);
        this.class1092_0.method_12();
        this.class1092_0.method_10(BookmarkStart.b("帷唹主匽ℿ㙁", num), this.dictionary_32[BookmarkStart.b("伷", num)]);
        if (field2.TextFieldType == TextFormFieldType.RegularText)
        {
            if (field2.TextFormat != TextFormat.None)
            {
                this.class1092_0.method_5(BookmarkStart.b("丷嬹倻", num), this.dictionary_32[BookmarkStart.b("伷", num)], field2.TextFormat.ToString());
            }
        }
        else
        {
            this.class1092_0.method_5(BookmarkStart.b("丷嬹倻", num), this.dictionary_32[BookmarkStart.b("伷", num)], field2.StringFormat);
        }
        this.class1092_0.method_12();
        this.class1092_0.method_12();
    }

    private void method_238(TextBoxItemCollection A_0)
    {
        foreach (TextBox box in A_0)
        {
            this.method_239(box);
        }
    }

    private void method_239(TextBox A_0)
    {
        if (A_0.Format.Rotation != 0f)
        {
            this.method_241(A_0);
        }
        else
        {
            this.method_342(A_0);
        }
    }

    private Dictionary<int, Dictionary<int, string>> method_24()
    {
        if (this.dictionary_0 == null)
        {
            this.dictionary_0 = new Dictionary<int, Dictionary<int, string>>();
        }
        return this.dictionary_0;
    }

    private void method_240(TextBox A_0, bool A_1)
    {
        int num = 8;
        if (A_1)
        {
            this.class1092_0.method_10(BookmarkStart.b("尭", num), this.dictionary_32[BookmarkStart.b("夭", num)]);
            this.method_463(A_0.CharacterFormat);
        }
        this.class1092_0.method_10(BookmarkStart.b("席夯儱䀳", num), this.dictionary_32[BookmarkStart.b("夭", num)]);
        this.class1092_0.method_10(BookmarkStart.b("崭堯匱䐳匵", num), this.dictionary_32[BookmarkStart.b("堭", num)]);
        this.class1092_0.method_4(BookmarkStart.b("娭䤯䈱儳", num), string.Format(BookmarkStart.b("ഭ漯䨱гص࠷ਹ挻䨽㬿牁㥃", num), A_0.Format.ShapeTypeId));
        this.method_251(A_0.Format);
        this.method_245(A_0);
        this.class1092_0.method_10(BookmarkStart.b("娭唯䨱䀳吵圷䈹", num), this.dictionary_32[BookmarkStart.b("堭", num)]);
        StringBuilder builder = new StringBuilder();
        if (A_0.Format.IsFitShapeToText)
        {
            builder.Append(BookmarkStart.b("䌭䌯崱ᤳ倵儷丹ᄻ䴽⠿⍁㑃⍅敇㹉⍋捍⑏㝑ⱓ≕扗⹙", num));
        }
        if (A_0.Format.LayoutFlowAlt == TextDirection.LeftToRight)
        {
            builder.Append(BookmarkStart.b("䈭儯䬱嬳䌵䰷᜹娻刽⼿㕁繃ぅⵇ㡉㡋❍㍏㍑㡓浕㕗⥙㍛獝౟͡ᵣ॥ᵧṩ䅫࡭ᱯᵱͳ孵᥷ᙹࡻ䑽ꆋ揄ﾏ뾑秊", num));
        }
        else if (A_0.Format.LayoutFlowAlt == TextDirection.TopToBottomRotated)
        {
            builder.Append(BookmarkStart.b("䈭儯䬱嬳䌵䰷᜹娻刽⼿㕁繃⹅❇㡉╋㑍㽏㱑⁓㝕㑗睙㕛㩝՟ൡͣᑥ१ᩩѫݭ፯", num));
        }
        else if (A_0.Format.LayoutFlowAlt == TextDirection.RightToLeft)
        {
            builder.Append(BookmarkStart.b("䈭儯䬱嬳䌵䰷᜹娻刽⼿㕁繃ぅⵇ㡉㡋❍㍏㍑㡓", num));
        }
        else if (A_0.Format.LayoutFlowAlt == TextDirection.RightToLeftRotated)
        {
            builder.Append(BookmarkStart.b("䈭儯䬱嬳䌵䰷᜹娻刽⼿㕁繃ぅⵇ㡉㡋❍㍏㍑㡓筕ㅗ㹙㥛ㅝݟၡգᙥgͩཫ", num));
        }
        if (!string.IsNullOrEmpty(builder.ToString()))
        {
            this.class1092_0.method_4(BookmarkStart.b("崭䐯䬱堳匵", num), builder.ToString());
        }
        if (!A_0.Format.IsFitShapeToText)
        {
            this.method_268(A_0);
        }
        this.class1092_0.method_10(BookmarkStart.b("娭䠯倱䰳电圷吹䠻嬽⸿㙁", num), this.dictionary_32[BookmarkStart.b("夭", num)]);
        for (int i = 0; i < A_0.Body.Items.Count; i++)
        {
            this.method_117(A_0.Body.Items[i], false);
        }
        this.class1092_0.method_12();
        this.class1092_0.method_12();
        this.method_351(A_0.Format.TextWrappingStyle, A_0.Format.TextWrappingType);
        this.class1092_0.method_12();
        this.class1092_0.method_12();
        if (A_1)
        {
            this.class1092_0.method_12();
        }
    }

    private void method_241(TextBox A_0)
    {
        this.class1092_0.method_10(BookmarkStart.b("䐵", 0x10), this.dictionary_32[BookmarkStart.b("䄵", 0x10)]);
        this.method_463(A_0.CharacterFormat);
        this.class1092_0.method_10(BookmarkStart.b("眵吷丹夻䰽⸿⍁ぃ⍅େ╉≋㩍㕏㱑⁓", 0x10), this.dictionary_32[BookmarkStart.b("嬵嬷", 0x10)]);
        this.class1092_0.method_10(BookmarkStart.b("电倷唹唻崽┿", 0x10), this.dictionary_32[BookmarkStart.b("嬵嬷", 0x10)]);
        this.class1092_0.method_4(BookmarkStart.b("搵崷䬹䤻圽㈿❁㝃", 0x10), BookmarkStart.b("䄵䠷䤹", 0x10));
        this.method_242(A_0);
        this.class1092_0.method_12();
        this.class1092_0.method_10(BookmarkStart.b("瀵夷嘹倻尽ℿ⅁⽃", 0x10), this.dictionary_32[BookmarkStart.b("嬵嬷", 0x10)]);
        this.method_342(A_0);
        this.class1092_0.method_12();
        this.class1092_0.method_12();
        this.class1092_0.method_12();
    }

    private void method_242(TextBox A_0)
    {
        int num = 9;
        this.class1092_0.method_10(BookmarkStart.b("䬮䌰刲䈴帶圸尺", 9), this.dictionary_32[BookmarkStart.b("堮", 9)]);
        if (A_0.Format.TextWrappingStyle != TextWrappingStyle.Inline)
        {
            this.class1092_0.method_10(BookmarkStart.b("丮弰倲崴堶䬸", num), this.dictionary_32[BookmarkStart.b("堮䄰", num)]);
            this.class1092_0.method_4(BookmarkStart.b("䬮堰䀲䄴挶", num), (A_0.Format.WrapDistanceTop * 12700f).ToString());
            this.class1092_0.method_4(BookmarkStart.b("䬮堰䀲䄴甶", num), (A_0.Format.WrapDistanceBottom * 12700f).ToString());
            this.class1092_0.method_4(BookmarkStart.b("䬮堰䀲䄴笶", num), (A_0.Format.WrapDistanceLeft * 12700f).ToString());
            this.class1092_0.method_4(BookmarkStart.b("䬮堰䀲䄴收", num), (A_0.Format.WrapDistanceRight * 12700f).ToString());
            this.class1092_0.method_4(BookmarkStart.b("尮堰帲䔴嬶尸欺刼䰾", num), BookmarkStart.b("Ἦ", num));
            this.class1092_0.method_4(BookmarkStart.b("崮吰弲吴䌶倸䴺堼眾⑀⩂≄⽆㵈", num), this.method_318(A_0.Format.OrderIndex));
            string str4 = (A_0.Format.IsBelowText || (A_0.Format.OrderIndex < 0L)) ? BookmarkStart.b("Ḯ", num) : BookmarkStart.b("Ἦ", num);
            this.class1092_0.method_4(BookmarkStart.b("䴮吰嬲尴夶崸缺刼尾", num), str4);
            this.class1092_0.method_4(BookmarkStart.b("䌮帰倲帴制崸", num), BookmarkStart.b("Ἦ", num));
            if (A_0.Format.IsAllowInCell)
            {
                this.class1092_0.method_4(BookmarkStart.b("䌮倰䨲娴䈶䴸爺匼簾⑀⽂⥄", num), BookmarkStart.b("Ḯ", num));
            }
            else
            {
                this.class1092_0.method_4(BookmarkStart.b("䌮倰䨲娴䈶䴸爺匼簾⑀⽂⥄", num), BookmarkStart.b("Ἦ", num));
            }
            if (A_0.Format.AllowOverlap)
            {
                this.class1092_0.method_4(BookmarkStart.b("丮崰弲娴䀶瘸䴺堼䴾ⵀ≂㕄", num), BookmarkStart.b("Ḯ", num));
            }
            else
            {
                this.class1092_0.method_4(BookmarkStart.b("丮崰弲娴䀶瘸䴺堼䴾ⵀ≂㕄", num), BookmarkStart.b("Ἦ", num));
            }
            this.class1092_0.method_10(BookmarkStart.b("尮堰帲䔴嬶尸欺刼䰾", num), this.dictionary_32[BookmarkStart.b("堮䄰", num)]);
            this.class1092_0.method_4(BookmarkStart.b("圮", num), BookmarkStart.b("Ἦ", num));
            this.class1092_0.method_4(BookmarkStart.b("嘮", num), BookmarkStart.b("Ἦ", num));
            this.class1092_0.method_12();
            this.class1092_0.method_10(BookmarkStart.b("弮帰䀲尴䌶倸吺匼眾", num), this.dictionary_32[BookmarkStart.b("堮䄰", num)]);
            this.class1092_0.method_4(BookmarkStart.b("崮吰弲吴䌶倸䴺堼社㍀ⱂ⡄", num), this.method_258(A_0.Format.HorizontalOrigin));
            if (A_0.Format.HorizontalAlignment == ShapeHorizontalAlignment.None)
            {
                this.class1092_0.method_10(BookmarkStart.b("弮帰䀲稴儶弸䠺堼䬾", num), this.dictionary_32[BookmarkStart.b("堮䄰", num)]);
                this.class1092_0.method_21(((int) Math.Round((double) (A_0.Format.HorizontalPosition * 12700f))).ToString());
                this.class1092_0.method_12();
            }
            else
            {
                this.class1092_0.method_10(BookmarkStart.b("丮崰娲刴夶", num), this.dictionary_32[BookmarkStart.b("堮䄰", num)]);
                string str3 = this.method_261(A_0.Format.HorizontalAlignment);
                this.class1092_0.method_21(str3);
                this.class1092_0.method_12();
            }
            this.class1092_0.method_12();
            this.class1092_0.method_10(BookmarkStart.b("弮帰䀲尴䌶倸吺匼椾", num), this.dictionary_32[BookmarkStart.b("堮䄰", num)]);
            this.class1092_0.method_4(BookmarkStart.b("崮吰弲吴䌶倸䴺堼社㍀ⱂ⡄", num), this.method_260(A_0.Format.VerticalOrigin));
            if (A_0.Format.VerticalAlignment == ShapeVerticalAlignment.None)
            {
                this.class1092_0.method_10(BookmarkStart.b("弮帰䀲稴儶弸䠺堼䬾", num), this.dictionary_32[BookmarkStart.b("堮䄰", num)]);
                this.class1092_0.method_21(((int) Math.Round((double) (A_0.Format.VerticalPosition * 12700f))).ToString());
                this.class1092_0.method_12();
            }
            else
            {
                this.class1092_0.method_10(BookmarkStart.b("丮崰娲刴夶", num), this.dictionary_32[BookmarkStart.b("堮䄰", num)]);
                string str2 = this.method_262(A_0.Format.VerticalAlignment);
                this.class1092_0.method_21(str2);
                this.class1092_0.method_12();
            }
            this.class1092_0.method_12();
        }
        else
        {
            this.class1092_0.method_10(BookmarkStart.b("䘮弰弲尴夶尸", num), this.dictionary_32[BookmarkStart.b("堮䄰", num)]);
            this.class1092_0.method_4(BookmarkStart.b("䬮堰䀲䄴挶", num), BookmarkStart.b("Ἦ", num));
            this.class1092_0.method_4(BookmarkStart.b("䬮堰䀲䄴甶", num), BookmarkStart.b("Ἦ", num));
            this.class1092_0.method_4(BookmarkStart.b("䬮堰䀲䄴笶", num), BookmarkStart.b("Ἦ", num));
            this.class1092_0.method_4(BookmarkStart.b("䬮堰䀲䄴收", num), BookmarkStart.b("Ἦ", num));
        }
        this.class1092_0.method_10(BookmarkStart.b("䨮䤰䜲倴夶䴸", num), this.dictionary_32[BookmarkStart.b("堮䄰", num)]);
        this.class1092_0.method_4(BookmarkStart.b("䰮䤰", num), ((int) Math.Round((double) (A_0.Format.Width * 12700f))).ToString());
        this.class1092_0.method_4(BookmarkStart.b("䰮䠰", num), ((int) Math.Round((double) (A_0.Format.Height * 12700f))).ToString());
        this.class1092_0.method_12();
        if (A_0.Format.TextWrappingStyle != TextWrappingStyle.Inline)
        {
            switch (((TextWrappingStyle) A_0.GetShapeAttribute(0x1001)))
            {
                case TextWrappingStyle.TopAndBottom:
                    this.class1092_0.method_10(BookmarkStart.b("堮䌰刲䔴挶嘸䬺簼儾╀ł⩄㍆㵈⑊⁌", num), this.dictionary_32[BookmarkStart.b("堮䄰", num)]);
                    this.class1092_0.method_12();
                    goto Label_0904;

                case TextWrappingStyle.Square:
                    this.class1092_0.method_10(BookmarkStart.b("堮䌰刲䔴搶䠸为尼䴾⑀", num), this.dictionary_32[BookmarkStart.b("堮䄰", num)]);
                    this.class1092_0.method_4(BookmarkStart.b("堮䌰刲䔴挶尸䌺䤼", num), this.method_354(A_0.Format.TextWrappingType));
                    this.class1092_0.method_12();
                    goto Label_0904;

                case TextWrappingStyle.Tight:
                    this.class1092_0.method_10(BookmarkStart.b("堮䌰刲䔴挶倸尺唼䬾", num), this.dictionary_32[BookmarkStart.b("堮䄰", num)]);
                    this.class1092_0.method_4(BookmarkStart.b("堮䌰刲䔴挶尸䌺䤼", num), this.method_354(A_0.Format.TextWrappingType));
                    if ((A_0.Format.WrapPolygon != null) && (A_0.Format.WrapPolygon.Length > 0))
                    {
                        this.method_243(A_0.Format.WrapPolygon, A_0.Format.IsEditWrapPolygonPoint);
                    }
                    this.class1092_0.method_12();
                    goto Label_0904;

                case TextWrappingStyle.Through:
                    this.class1092_0.method_10(BookmarkStart.b("堮䌰刲䔴挶儸䤺刼䨾♀⭂", num), this.dictionary_32[BookmarkStart.b("堮䄰", num)]);
                    this.class1092_0.method_4(BookmarkStart.b("堮䌰刲䔴挶尸䌺䤼", num), this.method_354(A_0.Format.TextWrappingType));
                    if ((A_0.Format.WrapPolygon != null) && (A_0.Format.WrapPolygon.Length > 0))
                    {
                        this.method_243(A_0.Format.WrapPolygon, A_0.Format.IsEditWrapPolygonPoint);
                    }
                    this.class1092_0.method_12();
                    goto Label_0904;
            }
            this.class1092_0.method_10(BookmarkStart.b("堮䌰刲䔴礶嘸唺堼", num), this.dictionary_32[BookmarkStart.b("堮䄰", num)]);
            this.class1092_0.method_12();
        }
    Label_0904:
        this.class1092_0.method_11(BookmarkStart.b("堮䄰", num), BookmarkStart.b("䬮帰倲攴䔶", num), this.dictionary_32[BookmarkStart.b("堮䄰", num)]);
        this.class1092_0.method_4(BookmarkStart.b("䘮唰", num), this.method_244());
        this.class1092_0.method_4(BookmarkStart.b("䄮倰帲倴", num), "");
        this.class1092_0.method_12();
        this.class1092_0.method_11(BookmarkStart.b("堮䄰", num), BookmarkStart.b("䰮缰䔲爴䔶堸䬺唼嘾≀Ղ㝄♆⑈⹊ᵌ㵎", num), this.dictionary_32[BookmarkStart.b("堮䄰", num)]);
        this.class1092_0.method_11(BookmarkStart.b("丮", num), BookmarkStart.b("䠮䌰刲䔴弶倸堺笼䴾⁀⹂⁄୆♈⡊♌㱎", num), this.dictionary_32[BookmarkStart.b("丮", num)]);
        this.class1092_0.method_12();
        this.class1092_0.method_12();
        this.class1092_0.method_11(BookmarkStart.b("丮", num), BookmarkStart.b("䠮䌰刲䔴弶倸堺", num), this.dictionary_32[BookmarkStart.b("丮", num)]);
        this.class1092_0.method_11(BookmarkStart.b("丮", num), BookmarkStart.b("䠮䌰刲䔴弶倸堺礼帾㕀≂", num), this.dictionary_32[BookmarkStart.b("丮", num)]);
        this.class1092_0.method_4(BookmarkStart.b("娮䌰娲", num), this.dictionary_32[BookmarkStart.b("堮䄰䀲", num)]);
        this.class1092_0.method_11(BookmarkStart.b("堮䄰䀲", num), BookmarkStart.b("堮䈰䌲", num), this.dictionary_32[BookmarkStart.b("堮䄰䀲", num)]);
        if (A_0.Format.LayoutFlowAlt == TextDirection.TopToBottomRotated)
        {
            this.class1092_0.method_4(BookmarkStart.b("䄮帰䄲場嘶唸縺尼䰾㕀ɂ㙄⹆⡈╊ୌ⍎㹐⑒", num), BookmarkStart.b("Ḯ", num));
        }
        this.class1092_0.method_11(BookmarkStart.b("堮䄰䀲", num), BookmarkStart.b("䰮缰䔲昴䜶椸䤺", num), this.dictionary_32[BookmarkStart.b("堮䄰䀲", num)]);
        this.class1092_0.method_4(BookmarkStart.b("嬮䤰焲娴伶", num), BookmarkStart.b("Ḯ", num));
        this.class1092_0.method_11(BookmarkStart.b("丮", num), BookmarkStart.b("尮䄰缲娴吶券䠺", num), this.dictionary_32[BookmarkStart.b("丮", num)]);
        this.class1092_0.method_4(BookmarkStart.b("䄮帰瀲崴嘶圸尺堼績㍀ㅂ⩄うⅈ⹊ⱌ⭎≐", num), BookmarkStart.b("Ḯ", num));
        this.class1092_0.method_12();
        this.class1092_0.method_12();
        this.class1092_0.method_11(BookmarkStart.b("堮䄰䀲", num), BookmarkStart.b("尮䄰挲䜴", num), this.dictionary_32[BookmarkStart.b("堮䄰䀲", num)]);
        this.class1092_0.method_4(BookmarkStart.b("䴮䘰縲娴匶尸", num), BookmarkStart.b("丮䐰䜲娴", num));
        this.class1092_0.method_11(BookmarkStart.b("丮", num), BookmarkStart.b("圮地䄲場", num), this.dictionary_32[BookmarkStart.b("丮", num)]);
        if (A_0.Format.Rotation != 0f)
        {
            this.class1092_0.method_4(BookmarkStart.b("崮帰䜲", num), Math.Round((double) (A_0.Format.Rotation * 60000f)).ToString());
        }
        this.class1092_0.method_11(BookmarkStart.b("丮", num), BookmarkStart.b("䀮地唲", num), this.dictionary_32[BookmarkStart.b("丮", num)]);
        this.class1092_0.method_4(BookmarkStart.b("圮", num), BookmarkStart.b("Ἦ", num));
        this.class1092_0.method_4(BookmarkStart.b("嘮", num), BookmarkStart.b("Ἦ", num));
        this.class1092_0.method_12();
        this.class1092_0.method_11(BookmarkStart.b("丮", num), BookmarkStart.b("䨮䤰䜲", num), this.dictionary_32[BookmarkStart.b("丮", num)]);
        this.class1092_0.method_4(BookmarkStart.b("䰮䤰", num), ((int) Math.Round((double) (A_0.Format.Width * 12700f))).ToString());
        this.class1092_0.method_4(BookmarkStart.b("䰮䠰", num), ((int) Math.Round((double) (A_0.Format.Height * 12700f))).ToString());
        this.class1092_0.method_12();
        this.class1092_0.method_12();
        this.class1092_0.method_11(BookmarkStart.b("丮", num), BookmarkStart.b("弮䌰䀲䄴瀶尸吺值", num), this.dictionary_32[BookmarkStart.b("丮", num)]);
        this.class1092_0.method_4(BookmarkStart.b("弮䌰䀲䄴", num), A_0.Format.DrawingShapeType);
        this.class1092_0.method_11(BookmarkStart.b("丮", num), BookmarkStart.b("丮䜰缲䘴䌶", num), this.dictionary_32[BookmarkStart.b("丮", num)]);
        this.class1092_0.method_12();
        this.class1092_0.method_12();
        if (A_0.Fill.FillType == FillType.Picture)
        {
            DocPicture picture = new DocPicture(A_0.Document);
            if ((A_0.Fill.ImageBytes != null) && (A_0.Fill.ImageBytes.Length > 0))
            {
                picture.LoadImage(A_0.Fill.ImageBytes);
            }
            picture.documentObject_1 = A_0.Owner;
            string str = string.Empty;
            str = this.method_335(picture, false, null);
            this.class1092_0.method_11(BookmarkStart.b("丮", num), BookmarkStart.b("䴮崰娲䔴然倸场儼", num), this.dictionary_32[BookmarkStart.b("弮堰倲", num)]);
            this.class1092_0.method_11(BookmarkStart.b("丮", num), BookmarkStart.b("䴮崰娲䔴", num), this.dictionary_32[BookmarkStart.b("丮", num)]);
            this.class1092_0.method_6(BookmarkStart.b("崮", num), BookmarkStart.b("䨮尰儲倴匶", num), this.dictionary_32[BookmarkStart.b("崮", num)], str);
            this.class1092_0.method_12();
            this.class1092_0.method_12();
        }
        else if ((A_0.Fill.FillType == FillType.Solid) && !A_0.Format.FillColor.IsEmpty)
        {
            this.class1092_0.method_11(BookmarkStart.b("丮", num), BookmarkStart.b("尮帰弲尴匶缸刺儼匾", num), this.dictionary_32[BookmarkStart.b("丮", num)]);
            this.class1092_0.method_11(BookmarkStart.b("丮", num), BookmarkStart.b("尮䌰吲圴琶唸䤺", num), this.dictionary_32[BookmarkStart.b("丮", num)]);
            this.class1092_0.method_4(BookmarkStart.b("央倰弲", num), this.method_535(A_0.Format.FillColor));
            this.class1092_0.method_12();
            this.class1092_0.method_12();
        }
        if (!A_0.Format.NoLine)
        {
            this.class1092_0.method_11(BookmarkStart.b("丮", num), BookmarkStart.b("䌮弰", num), this.dictionary_32[BookmarkStart.b("丮", num)]);
            this.class1092_0.method_4(BookmarkStart.b("堮", num), Math.Round((double) (A_0.Format.LineWidth * 12700f)).ToString());
            this.class1092_0.method_4(BookmarkStart.b("䰮尰䌲儴", num), this.method_348(A_0.Format.LineStyle));
            if (!A_0.Format.LineColor.IsEmpty)
            {
                this.class1092_0.method_11(BookmarkStart.b("丮", num), BookmarkStart.b("尮帰弲尴匶缸刺儼匾", num), this.dictionary_32[BookmarkStart.b("丮", num)]);
                this.class1092_0.method_11(BookmarkStart.b("丮", num), BookmarkStart.b("尮䌰吲圴琶唸䤺", num), this.dictionary_32[BookmarkStart.b("丮", num)]);
                this.class1092_0.method_4(BookmarkStart.b("央倰弲", num), this.method_535(A_0.Format.LineColor));
                this.class1092_0.method_12();
                this.class1092_0.method_12();
                this.class1092_0.method_11(BookmarkStart.b("丮", num), BookmarkStart.b("弮䌰䀲䄴猶堸䠺唼", num), this.dictionary_32[BookmarkStart.b("丮", num)]);
                this.class1092_0.method_4(BookmarkStart.b("央倰弲", num), this.method_350(A_0.Format.LineDashing));
                this.class1092_0.method_12();
            }
            this.class1092_0.method_12();
        }
        this.class1092_0.method_12();
        this.class1092_0.method_11(BookmarkStart.b("堮䄰䀲", num), BookmarkStart.b("嬮䤰儲䴴", num), this.dictionary_32[BookmarkStart.b("堮䄰䀲", num)]);
        this.class1092_0.method_11(BookmarkStart.b("堮", num), BookmarkStart.b("嬮䤰儲䴴琶嘸唺䤼娾⽀㝂", num), this.dictionary_32[BookmarkStart.b("堮", num)]);
        for (int i = 0; i < A_0.Body.Items.Count; i++)
        {
            this.method_117(A_0.Body.Items[i], false);
        }
        this.class1092_0.method_12();
        this.class1092_0.method_12();
        this.class1092_0.method_11(BookmarkStart.b("堮䄰䀲", num), BookmarkStart.b("䴮帰圲䰴朶䬸", num), this.dictionary_32[BookmarkStart.b("堮䄰䀲", num)]);
        this.class1092_0.method_4(BookmarkStart.b("崮帰䜲", num), BookmarkStart.b("Ἦ", num));
        switch (A_0.Format.LayoutFlowAlt)
        {
            case TextDirection.RightToLeft:
                this.class1092_0.method_4(BookmarkStart.b("央吰䄲䄴", num), BookmarkStart.b("央吰䄲䄴", num));
                break;

            case TextDirection.LeftToRight:
                this.class1092_0.method_4(BookmarkStart.b("央吰䄲䄴", num), BookmarkStart.b("央吰䄲䄴Զุ଺", num));
                break;

            case TextDirection.RightToLeftRotated:
                this.class1092_0.method_4(BookmarkStart.b("央吰䄲䄴", num), BookmarkStart.b("䨮倰攲倴䔶䴸", num));
                break;

            default:
                this.class1092_0.method_4(BookmarkStart.b("央吰䄲䄴", num), BookmarkStart.b("䜮帰䄲伴", num));
                break;
        }
        this.class1092_0.method_4(BookmarkStart.b("堮䌰刲䔴", num), this.method_254(A_0.Format.TextBoxWrapMode));
        this.class1092_0.method_4(BookmarkStart.b("䌮砰崲䘴", num), Math.Round((double) (A_0.Format.InternalMargin.Left * 12700f)).ToString());
        this.class1092_0.method_4(BookmarkStart.b("嬮砰崲䘴", num), Math.Round((double) (A_0.Format.InternalMargin.Top * 12700f)).ToString());
        this.class1092_0.method_4(BookmarkStart.b("崮砰崲䘴", num), Math.Round((double) (A_0.Format.InternalMargin.Right * 12700f)).ToString());
        this.class1092_0.method_4(BookmarkStart.b("䴮砰崲䘴", num), Math.Round((double) (A_0.Format.InternalMargin.Bottom * 12700f)).ToString());
        switch (A_0.Format.TextAnchor)
        {
            case ShapeVerticalAlignment.Center:
                this.class1092_0.method_4(BookmarkStart.b("丮弰倲崴堶䬸", num), BookmarkStart.b("䰮䔰䄲", num));
                break;

            case ShapeVerticalAlignment.Bottom:
                this.class1092_0.method_4(BookmarkStart.b("丮弰倲崴堶䬸", num), BookmarkStart.b("䴮", num));
                break;

            default:
                this.class1092_0.method_4(BookmarkStart.b("丮弰倲崴堶䬸", num), BookmarkStart.b("嬮", num));
                break;
        }
        this.class1092_0.method_4(BookmarkStart.b("丮弰倲崴堶䬸砺䤼䴾", num), BookmarkStart.b("Ἦ", num));
        if (!A_0.Format.TextUpRight)
        {
            this.class1092_0.method_4(BookmarkStart.b("娮䄰䄲尴倶儸伺", num), BookmarkStart.b("Ḯ", num));
        }
        if (A_0.Format.IsFitShapeToText)
        {
            this.class1092_0.method_11(BookmarkStart.b("丮", num), BookmarkStart.b("尮䄰爲䀴䌶嘸紺吼䬾", num), this.dictionary_32[BookmarkStart.b("丮", num)]);
            this.class1092_0.method_12();
        }
        else
        {
            this.class1092_0.method_11(BookmarkStart.b("丮", num), BookmarkStart.b("䄮帰爲䀴䌶嘸紺吼䬾", num), this.dictionary_32[BookmarkStart.b("丮", num)]);
            this.class1092_0.method_12();
        }
        this.class1092_0.method_12();
        this.class1092_0.method_12();
        this.class1092_0.method_12();
        this.class1092_0.method_12();
        if (A_0.Format.WidthPercent != 0f)
        {
            this.class1092_0.method_11(BookmarkStart.b("堮䄰ȲĴ", num), BookmarkStart.b("尮堰䤲倴收尸场甼", num), BookmarkStart.b("䜮䔰䜲䔴ശᘸᐺ丼尾⥀♂⡄♆㩈敊⁌♎㉐⅒㩔⑖㙘㵚⥜煞ɠౢࡤ䡦٨൪୬ٮተᙲ婴vᙸॺ᥼偾뎀뎂뒄랆Ꚉﲊﶎ滛ﺚ좠춢스\udba8\ucaaa\udaac\uc6ae\udfb0\ud4b2", num));
            this.class1092_0.method_4(BookmarkStart.b("崮吰弲吴䌶倸䴺堼社㍀ⱂ⡄", num), this.method_257(A_0.Format.RelationWidth));
            this.class1092_0.method_8(BookmarkStart.b("弮到䜲戴帶崸伺唼", num), BookmarkStart.b("䜮䔰䜲䔴ശᘸᐺ丼尾⥀♂⡄♆㩈敊⁌♎㉐⅒㩔⑖㙘㵚⥜煞ɠౢࡤ䡦٨൪୬ٮተᙲ婴vᙸॺ᥼偾뎀뎂뒄랆Ꚉﲊﶎ滛ﺚ좠춢스\udba8\ucaaa\udaac\uc6ae\udfb0\ud4b2", num), (A_0.Format.WidthPercent * 1000f).ToString());
            this.class1092_0.method_12();
        }
        if (A_0.Format.HeightPercent != 0f)
        {
            this.class1092_0.method_11(BookmarkStart.b("堮䄰ȲĴ", num), BookmarkStart.b("尮堰䤲倴收尸场欼", num), BookmarkStart.b("䜮䔰䜲䔴ശᘸᐺ丼尾⥀♂⡄♆㩈敊⁌♎㉐⅒㩔⑖㙘㵚⥜煞ɠౢࡤ䡦٨൪୬ٮተᙲ婴vᙸॺ᥼偾뎀뎂뒄랆Ꚉﲊﶎ滛ﺚ좠춢스\udba8\ucaaa\udaac\uc6ae\udfb0\ud4b2", num));
            this.class1092_0.method_4(BookmarkStart.b("崮吰弲吴䌶倸䴺堼社㍀ⱂ⡄", num), this.method_259(A_0.Format.RelationHeight));
            this.class1092_0.method_8(BookmarkStart.b("弮到䜲紴制倸尺唼䬾", num), BookmarkStart.b("䜮䔰䜲䔴ശᘸᐺ丼尾⥀♂⡄♆㩈敊⁌♎㉐⅒㩔⑖㙘㵚⥜煞ɠౢࡤ䡦٨൪୬ٮተᙲ婴vᙸॺ᥼偾뎀뎂뒄랆Ꚉﲊﶎ滛ﺚ좠춢스\udba8\ucaaa\udaac\uc6ae\udfb0\ud4b2", num), (A_0.Format.HeightPercent * 1000f).ToString());
            this.class1092_0.method_12();
        }
        this.class1092_0.method_12();
        this.class1092_0.method_12();
    }

    private void method_243(Class891[] A_0, bool A_1)
    {
        int num = 6;
        this.class1092_0.method_10(BookmarkStart.b("嬫尭儯䈱搳夵吷䌹嬻儽⸿", 6), this.dictionary_32[BookmarkStart.b("嬫席", 6)]);
        this.class1092_0.method_4(BookmarkStart.b("䤫䨭夯䘱儳刵", 6), A_1 ? BookmarkStart.b("ᴫ", num) : BookmarkStart.b("ᰫ", num));
        int index = 0;
        int length = A_0.Length;
        while (index < length)
        {
            if (index == 0)
            {
                this.class1092_0.method_10(BookmarkStart.b("弫娭儯䀱䀳", num), this.dictionary_32[BookmarkStart.b("嬫席", num)]);
                this.class1092_0.method_4(BookmarkStart.b("含", num), A_0[index].method_0().ToString());
                this.class1092_0.method_4(BookmarkStart.b("唫", num), A_0[index].method_1().ToString());
                this.class1092_0.method_12();
            }
            else
            {
                this.class1092_0.method_10(BookmarkStart.b("䀫䜭帯圱怳夵", num), this.dictionary_32[BookmarkStart.b("嬫席", num)]);
                this.class1092_0.method_4(BookmarkStart.b("含", num), A_0[index].method_0().ToString());
                this.class1092_0.method_4(BookmarkStart.b("唫", num), A_0[index].method_1().ToString());
                this.class1092_0.method_12();
            }
            index++;
        }
        this.class1092_0.method_12();
    }

    private string method_244()
    {
        string str = this.int_7.ToString();
        this.int_7++;
        return str;
    }

    private void method_245(TextBox A_0)
    {
        int num = 0x13;
        Background fillEfects = A_0.Format.FillEfects;
        if (fillEfects.PatternFill != null)
        {
            bool flag = false;
            if (A_0.OwnerParagraph != null)
            {
                flag = A_0.OwnerParagraph.Owner is HeaderFooter;
            }
            this.method_248(A_0, flag);
        }
        else if ((fillEfects.Type != BackgroundType.NoBackground) && ((fillEfects.Type != BackgroundType.Color) || (fillEfects.Opacity != 1f)))
        {
            this.class1092_0.method_10(BookmarkStart.b("弸刺儼匾", num), this.dictionary_32[BookmarkStart.b("伸", num)]);
            if (fillEfects.Opacity != 1f)
            {
                this.class1092_0.method_4(BookmarkStart.b("嘸䬺尼尾⡀㝂㱄", num), fillEfects.Opacity.ToString());
            }
            if (A_0.Format.FillEfects.Recolor)
            {
                this.class1092_0.method_4(BookmarkStart.b("䬸帺帼倾ⵀⱂ㝄", num), BookmarkStart.b("䴸", num));
            }
            if (A_0.Format.FillEfects.Rotate)
            {
                this.class1092_0.method_4(BookmarkStart.b("䬸吺䤼帾㕀♂", num), BookmarkStart.b("䴸", num));
            }
            if (((fillEfects.Type == BackgroundType.Picture) || (fillEfects.Type == BackgroundType.Texture)) && (fillEfects.ImageBytes != null))
            {
                this.method_247(A_0);
            }
            else if (fillEfects.Type == BackgroundType.Gradient)
            {
                this.method_246(A_0.Format.FillEfects.Gradient);
            }
            this.class1092_0.method_12();
        }
    }

    private void method_246(BackgroundGradient A_0)
    {
        this.method_112(A_0);
        this.method_111(A_0);
    }

    private void method_247(TextBox A_0)
    {
        int num = 0x12;
        DocumentObject obj2 = this.method_548(A_0);
        Background fillEfects = A_0.Format.FillEfects;
        string key = this.method_527();
        DocPicture picture = new DocPicture(A_0.Document);
        if (fillEfects.ImageBytes != null)
        {
            picture.LoadImage(fillEfects.ImageBytes);
        }
        this.method_113(picture);
        if (obj2 is Section)
        {
            this.method_38().Add(key, picture.ImageRecord);
        }
        else if (obj2 is HeaderFooter)
        {
            this.method_338(obj2 as HeaderFooter, picture);
        }
        this.class1092_0.method_5(BookmarkStart.b("儷帹", num), this.dictionary_32[BookmarkStart.b("䨷", num)], key);
        if (fillEfects.Type == BackgroundType.Picture)
        {
            this.class1092_0.method_4(BookmarkStart.b("䰷䌹䰻嬽", num), BookmarkStart.b("帷䠹崻匽┿", num));
        }
        else
        {
            this.class1092_0.method_4(BookmarkStart.b("䰷䌹䰻嬽", num), BookmarkStart.b("䰷匹倻嬽", num));
        }
    }

    private void method_248(TextBox A_0, bool A_1)
    {
        Background fillEfects = A_0.Format.FillEfects;
        string str = string.Empty;
        if (fillEfects.PatternImageBytes != null)
        {
            DocPicture picture = new DocPicture(this.document_0);
            picture.LoadImage(fillEfects.PatternImageBytes);
            if (A_1)
            {
                HeaderFooter owner = A_0.OwnerParagraph.Owner as HeaderFooter;
                this.method_338(owner, picture);
            }
            else
            {
                str = this.method_336(this.method_38(), picture.ImageRecord);
            }
            this.bool_0 = true;
            Stream stream = this.method_249(fillEfects.PatternFill, str);
            this.method_272(stream);
        }
        else
        {
            this.method_272(fillEfects.PatternFill);
        }
    }

    private Stream method_249(Stream A_0, string A_1)
    {
        XmlNodeType type;
        A_0.Position = 0L;
        XmlReader reader = Class57.smethod_18(A_0);
        MemoryStream stream = new MemoryStream((int) A_0.Length);
        XmlWriter writer = Class57.smethod_19(stream, Encoding.UTF8);
        goto Label_00A8;
    Label_003D:
        if (!reader.Read())
        {
            writer.Flush();
            stream.Flush();
            return stream;
        }
    Label_00A8:
        switch (reader.NodeType)
        {
            case XmlNodeType.Element:
                writer.WriteStartElement(reader.Prefix, reader.LocalName, reader.NamespaceURI);
                this.method_250(reader, writer, A_1);
                reader.MoveToElement();
                if (reader.IsEmptyElement)
                {
                    writer.WriteEndElement();
                }
                goto Label_003D;

            case XmlNodeType.Attribute:
                goto Label_003D;

            case XmlNodeType.Text:
                writer.WriteString(reader.Value);
                goto Label_003D;
        }
        switch (type)
        {
            case XmlNodeType.SignificantWhitespace:
                writer.WriteWhitespace(reader.Value);
                break;

            case XmlNodeType.EndElement:
                writer.WriteEndElement();
                break;
        }
        goto Label_003D;
    }

    private Dictionary<string, Class517> method_25()
    {
        if (this.dictionary_1 == null)
        {
            this.dictionary_1 = new Dictionary<string, Class517>();
        }
        return this.dictionary_1;
    }

    private void method_250(XmlReader A_0, XmlWriter A_1, string A_2)
    {
        int num = 4;
        for (int i = 0; i < A_0.AttributeCount; i++)
        {
            string str;
            A_0.MoveToAttribute(i);
            if (((str = A_0.LocalName) != null) && ((str == BookmarkStart.b("䌩䠫", num)) || (str == BookmarkStart.b("䈩師䬭嘯", num))))
            {
                if ((A_0.Value != null) && (A_0.Value.Length > 0))
                {
                    A_1.WriteAttributeString(A_0.Prefix, A_0.LocalName, A_0.NamespaceURI, A_2);
                }
                else
                {
                    A_1.WriteAttributeString(A_0.Prefix, A_0.LocalName, A_0.NamespaceURI, A_0.Value);
                }
            }
            else
            {
                A_1.WriteAttributeString(A_0.Prefix, A_0.LocalName, A_0.NamespaceURI, A_0.Value);
            }
        }
    }

    private void method_251(TextBoxFormat A_0)
    {
        int num = 9;
        string str = string.Empty;
        string str2 = string.Empty;
        string str3 = string.Empty;
        string str4 = string.Empty;
        StringBuilder builder = new StringBuilder();
        if (A_0.HorizontalOrigin != HorizontalOrigin.Column)
        {
            str = this.method_257(A_0.HorizontalOrigin);
        }
        if (A_0.VerticalOrigin != VerticalOrigin.Paragraph)
        {
            str3 = this.method_259(A_0.VerticalOrigin);
        }
        if (A_0.HorizontalAlignment != ShapeHorizontalAlignment.None)
        {
            str2 = A_0.HorizontalAlignment.ToString().ToLower();
        }
        if (A_0.VerticalAlignment != ShapeVerticalAlignment.None)
        {
            str4 = A_0.VerticalAlignment.ToString().ToLower();
        }
        if (A_0.TextWrappingStyle != TextWrappingStyle.Inline)
        {
            builder.Append(BookmarkStart.b("弮帰䀲尴䌶倸吺匼Ծ⁀⅂㙄⡆╈㹊㥌⩎橐", num));
        }
        builder.Append(BookmarkStart.b("䈮倰䄲刴帶圸ᘺ儼娾❀㝂罄", num));
        builder.Append(A_0.HorizontalPosition.ToString().Replace(BookmarkStart.b("̮", num), BookmarkStart.b("Į", num)));
        builder.Append(BookmarkStart.b("弮䔰࠲場嘶䬸尺吼儾汀㝂⩄㝆獈", num));
        builder.Append(A_0.VerticalPosition.ToString().Replace(BookmarkStart.b("̮", num), BookmarkStart.b("Į", num)));
        builder.Append(BookmarkStart.b("弮䔰࠲䈴帶崸伺唼Ծ", num));
        builder.Append(A_0.Width.ToString().Replace(BookmarkStart.b("̮", num), BookmarkStart.b("Į", num)));
        builder.Append(BookmarkStart.b("弮䔰࠲崴制倸尺唼䬾筀", num));
        builder.Append(A_0.Height.ToString().Replace(BookmarkStart.b("̮", num), BookmarkStart.b("Į", num)));
        builder.Append(BookmarkStart.b("弮䔰࠲", num));
        if (A_0.OrderIndex != 0L)
        {
            builder.Append(BookmarkStart.b("售ᰰ娲嬴匶尸䌺ܼ", num) + A_0.OrderIndex.ToString() + BookmarkStart.b("ᐮ", num));
        }
        else if (A_0.IsBelowText)
        {
            builder.Append(BookmarkStart.b("售ᰰ娲嬴匶尸䌺ܼሾ獀療瑄煆籈獊穌穎捐桒", num));
        }
        if (str.Length != 0)
        {
            builder.Append(BookmarkStart.b("䈮䈰尲ᠴ䜶嘸䠺吼䬾⡀ⱂ⭄橆ⅈ⑊㽌♎⭐㱒㭔⍖㡘㝚灜ⵞѠརѤ፦hᵪ࡬啮", num));
            builder.Append(str);
        }
        if (str3.Length != 0)
        {
            builder.Append(BookmarkStart.b("ᐮ尰䀲娴ᨶ䤸吺丼嘾㕀⩂⩄⥆摈㵊⡌㵎═㩒㙔㙖㕘癚⽜㩞ൠɢᅤ๦Ὠ๪坬", num));
            builder.Append(str3);
        }
        if (str2.Length != 0)
        {
            builder.Append(BookmarkStart.b("ᐮ尰䀲娴ᨶ䤸吺丼嘾㕀⩂⩄⥆摈⍊≌㵎㡐⥒㩔㥖ⵘ㩚ㅜ敞", num));
            builder.Append(str2);
        }
        if (str4.Length != 0)
        {
            builder.Append(BookmarkStart.b("ᐮ尰䀲娴ᨶ䤸吺丼嘾㕀⩂⩄⥆摈㵊⡌㵎═㩒㙔㙖㕘慚", num));
            builder.Append(str4);
        }
        if (A_0.ParentTextBox.ShapePr.HasKey(0x7c2))
        {
            builder.Append(BookmarkStart.b("ᐮ尰䀲娴ᨶ唸帺嬼䬾汀㍂⁄㕆⩈⹊⍌㭎歐", num));
            builder.Append((float) (A_0.LeftPercent * 10f));
        }
        if (A_0.ParentTextBox.ShapePr.HasKey(0x7c3))
        {
            builder.Append(BookmarkStart.b("ᐮ尰䀲娴ᨶ䴸吺䴼ሾㅀ♂㝄⑆ⱈ╊㥌畎", num));
            builder.Append((float) (A_0.TopPercent * 10f));
        }
        if (A_0.TextAnchor != ShapeVerticalAlignment.None)
        {
            builder.Append(BookmarkStart.b("ᐮ䜰Ḳ䄴制䄸伺ြ帾⽀⁂ⵄ⡆㭈煊", num));
            builder.Append(this.method_255(A_0.TextAnchor));
        }
        if (A_0.Rotation != 0f)
        {
            builder.Append(BookmarkStart.b("ᐮ䌰尲䄴嘶䴸刺刼儾筀", num));
            builder.Append(A_0.Rotation.ToString(CultureInfo.InvariantCulture));
        }
        builder.Append(BookmarkStart.b("ᐮ尰䀲娴ᨶ丸䤺尼伾汀あㅄ㹆╈⹊睌", num));
        builder.Append(this.method_254(A_0.TextBoxWrapMode));
        if (A_0.WidthPercent > 0f)
        {
            builder.Append(BookmarkStart.b("ᐮ尰䀲娴ᨶ丸刺夼䬾⥀湂㕄≆㭈⡊⡌ⅎ═楒", num));
            float num10 = A_0.WidthPercent * 10f;
            builder.Append(num10.ToString().ToLower());
            builder.Append(BookmarkStart.b("ᐮ尰䀲娴ᨶ丸刺夼䬾⥀湂㝄≆╈⩊㥌♎❐㙒潔", num));
            builder.Append(this.method_257(A_0.RelationWidth).ToLower());
        }
        if (A_0.HeightPercent > 0f)
        {
            builder.Append(BookmarkStart.b("ᐮ尰䀲娴ᨶ儸帺吼堾⥀㝂桄㝆ⱈ㥊⹌⩎㽐❒潔", num));
            float num8 = A_0.HeightPercent * 10f;
            builder.Append(num8.ToString().ToLower());
            builder.Append(BookmarkStart.b("ᐮ尰䀲娴ᨶ儸帺吼堾⥀㝂桄㕆ⱈ❊ⱌ㭎㡐╒ご浖", num));
            builder.Append(this.method_259(A_0.RelationHeight).ToLower());
        }
        if (A_0.HasDocxProps)
        {
            foreach (string str5 in A_0.DocxStyleProps)
            {
                builder.Append(BookmarkStart.b("ᐮ", num) + str5);
            }
        }
        this.class1092_0.method_4(BookmarkStart.b("尮䔰䨲头制", num), builder.ToString());
        if ((A_0.WrapPolygon != null) && (A_0.WrapPolygon.Length > 0))
        {
            string str7 = this.method_252(A_0.WrapPolygon);
            this.class1092_0.method_4(BookmarkStart.b("堮䌰刲䔴吶嘸吺似嬾㉀", num), str7);
        }
        if (A_0.Adjustment.Count > 0)
        {
            string str6 = this.method_253(A_0.Adjustment);
            this.class1092_0.method_4(BookmarkStart.b("丮唰夲", num), str6);
        }
        if (A_0.FillEfects.Type == BackgroundType.NoBackground)
        {
            this.class1092_0.method_4(BookmarkStart.b("䤮堰弲头制崸", num), BookmarkStart.b("䤮", num));
        }
        else
        {
            this.class1092_0.method_4(BookmarkStart.b("䤮堰弲头制崸", num), BookmarkStart.b("嬮", num));
        }
        if ((A_0.FillEfects.Type == BackgroundType.Color) || (A_0.FillEfects.Type == BackgroundType.Gradient))
        {
            Color empty = Color.Empty;
            if (A_0.FillEfects.Type == BackgroundType.Gradient)
            {
                empty = A_0.FillEfects.Gradient.Color1;
            }
            else
            {
                empty = A_0.FillColor;
            }
            if (!empty.IsEmpty)
            {
                this.class1092_0.method_4(BookmarkStart.b("䤮堰弲头吶嘸场刼䴾", num), BookmarkStart.b("మ", num) + this.method_535(empty));
            }
        }
        if (A_0.LineColor != Color.Empty)
        {
            this.class1092_0.method_4(BookmarkStart.b("尮䔰䄲娴尶尸堺刼匾⹀ㅂ", num), BookmarkStart.b("మ", num) + this.method_535(A_0.LineColor));
        }
        if (A_0.LineWidth > 0f)
        {
            this.class1092_0.method_4(BookmarkStart.b("尮䔰䄲娴尶尸䰺堼嘾♀⭂ㅄ", num), A_0.LineWidth.ToString().Replace(BookmarkStart.b("̮", num), BookmarkStart.b("Į", num)) + BookmarkStart.b("弮䔰", num));
        }
        if (!A_0.IsAllowInCell)
        {
            this.class1092_0.method_5(BookmarkStart.b("丮崰弲娴䀶倸唺帼娾ⵀ⽂", num), this.dictionary_32[BookmarkStart.b("䀮", num)], BookmarkStart.b("䤮", num));
        }
        if (!A_0.AllowOverlap)
        {
            this.class1092_0.method_5(BookmarkStart.b("丮崰弲娴䀶嘸䴺堼䴾ⵀ≂㕄", num), this.dictionary_32[BookmarkStart.b("䀮", num)], BookmarkStart.b("䤮", num));
        }
        if (A_0.NoLine)
        {
            this.class1092_0.method_4(BookmarkStart.b("尮䔰䄲娴尶尸强", num), BookmarkStart.b("䤮", num));
        }
        else
        {
            this.method_264(A_0);
        }
    }

    private string method_252(Class891[] A_0)
    {
        int num = 0x13;
        StringBuilder builder = new StringBuilder();
        int index = 0;
        int length = A_0.Length;
        while (index < length)
        {
            if ((index + 1) == length)
            {
                builder.Append(A_0[index].method_0() + BookmarkStart.b("ᤸ", num) + A_0[index].method_1());
            }
            else
            {
                builder.Append(string.Concat(new object[] { A_0[index].method_0(), BookmarkStart.b("ᤸ", num), A_0[index].method_1(), BookmarkStart.b("ᤸ", num) }));
            }
            index++;
        }
        return builder.ToString();
    }

    private string method_253(List<int> A_0)
    {
        int num = 9;
        StringBuilder builder = new StringBuilder();
        int num2 = 0;
        int count = A_0.Count;
        while (num2 < count)
        {
            if ((num2 + 1) == count)
            {
                builder.Append(A_0[num2]);
            }
            else
            {
                builder.Append(A_0[num2] + BookmarkStart.b("̮", num));
            }
            num2++;
        }
        return builder.ToString();
    }

    private string method_254(TextBoxWrapMode A_0)
    {
        int num = 0;
        if (A_0 == TextBoxWrapMode.None)
        {
            return BookmarkStart.b("䠥䜧䐩䤫", num);
        }
        return BookmarkStart.b("唥大弩䴫尭唯", num);
    }

    private string method_255(ShapeVerticalAlignment A_0)
    {
        int num = 9;
        switch (A_0)
        {
            case ShapeVerticalAlignment.Center:
                return BookmarkStart.b("䈮堰圲儴嬶尸", num);

            case ShapeVerticalAlignment.Bottom:
                return BookmarkStart.b("䴮帰䜲䄴堶吸", num);
        }
        return BookmarkStart.b("嬮帰䌲", num);
    }

    private string method_256(LineBreakClear A_0)
    {
        int num = 5;
        switch (A_0)
        {
            case LineBreakClear.Left:
                return BookmarkStart.b("䜪䠬䤮䔰", num);

            case LineBreakClear.Right:
                return BookmarkStart.b("太䐬䠮夰䜲", num);

            case LineBreakClear.All:
                return BookmarkStart.b("䨪䄬䌮", num);
        }
        return BookmarkStart.b("䔪䈬䄮吰", num);
    }

    private string method_257(HorizontalOrigin A_0)
    {
        int num = 0x10;
        switch (A_0)
        {
            case HorizontalOrigin.Page:
                return BookmarkStart.b("䘵夷崹夻", num);

            case HorizontalOrigin.Column:
                return BookmarkStart.b("唵圷嘹䤻匽⸿", num);

            case HorizontalOrigin.Character:
                return BookmarkStart.b("唵倷嬹主", num);

            case HorizontalOrigin.LeftMarginArea:
                return BookmarkStart.b("娵崷尹䠻ጽⴿ⍁㙃ⅅⅇ⑉態⽍≏㝑㕓", num);

            case HorizontalOrigin.RightMarginArea:
                return BookmarkStart.b("䐵儷崹吻䨽洿⽁╃㑅⽇⍉≋捍ㅏ⁑ㅓ㝕", num);

            case HorizontalOrigin.InnerMarginArea:
                return BookmarkStart.b("張嘷吹夻䰽洿⽁╃㑅⽇⍉≋捍ㅏ⁑ㅓ㝕", num);

            case HorizontalOrigin.OuterMarginArea:
                return BookmarkStart.b("夵䴷丹夻䰽洿⽁╃㑅⽇⍉≋捍ㅏ⁑ㅓ㝕", num);
        }
        return BookmarkStart.b("嬵夷䠹嬻圽⸿", num);
    }

    private string method_258(HorizontalOrigin A_0)
    {
        int num = 5;
        switch (A_0)
        {
            case HorizontalOrigin.Page:
                return BookmarkStart.b("嬪䰬䠮吰", num);

            case HorizontalOrigin.Column:
                return BookmarkStart.b("䠪䈬䌮䐰帲嬴", num);

            case HorizontalOrigin.Character:
                return BookmarkStart.b("䠪䔬丮䌰刲嘴䌶尸䤺", num);

            case HorizontalOrigin.LeftMarginArea:
                return BookmarkStart.b("䜪䠬䤮䔰縲吴䔶常刺匼", num);

            case HorizontalOrigin.RightMarginArea:
                return BookmarkStart.b("太䐬䠮夰䜲破嘶䬸尺吼儾", num);

            case HorizontalOrigin.InnerMarginArea:
                return BookmarkStart.b("䈪䌬尮堰圲倴稶堸䤺娼嘾⽀", num);

            case HorizontalOrigin.OuterMarginArea:
                return BookmarkStart.b("䐪堬嬮䈰娲儴制琸娺似堾⡀ⵂ", num);
        }
        return BookmarkStart.b("䘪䰬崮嘰娲嬴", num);
    }

    private string method_259(VerticalOrigin A_0)
    {
        int num = 7;
        switch (A_0)
        {
            case VerticalOrigin.Page:
                return BookmarkStart.b("崬丮嘰嘲", num);

            case VerticalOrigin.Paragraph:
                return BookmarkStart.b("崬丮䌰刲刴䔶堸䬺唼", num);

            case VerticalOrigin.Line:
                return BookmarkStart.b("䄬䘮弰嘲", num);

            case VerticalOrigin.TopMarginArea:
                return BookmarkStart.b("夬䀮䄰Ḳ場嘶䬸尺吼儾汀≂㝄≆⡈", num);

            case VerticalOrigin.BottomMarginArea:
                return BookmarkStart.b("伬䀮䔰䜲娴娶ᐸ嘺尼䴾♀⩂⭄橆⡈㥊⡌⹎", num);

            case VerticalOrigin.InnerMarginArea:
                return BookmarkStart.b("䐬䄮弰嘲䜴ᨶ吸娺似堾⡀ⵂ桄♆㭈⹊ⱌ", num);

            case VerticalOrigin.OuterMarginArea:
                return BookmarkStart.b("䈬娮䔰嘲䜴ᨶ吸娺似堾⡀ⵂ桄♆㭈⹊ⱌ", num);
        }
        return BookmarkStart.b("䀬丮䌰吲尴夶", num);
    }

    public bool method_26()
    {
        return this.bool_3;
    }

    private string method_260(VerticalOrigin A_0)
    {
        int num = 13;
        switch (A_0)
        {
            case VerticalOrigin.Page:
                return BookmarkStart.b("䌲吴倶尸", num);

            case VerticalOrigin.Paragraph:
                return BookmarkStart.b("䌲吴䔶堸尺似帾ㅀ⭂", num);

            case VerticalOrigin.Line:
                return BookmarkStart.b("弲尴夶尸", num);

            case VerticalOrigin.TopMarginArea:
                return BookmarkStart.b("䜲娴䜶琸娺似堾⡀ⵂ", num);

            case VerticalOrigin.BottomMarginArea:
                return BookmarkStart.b("儲娴䌶䴸吺值爾⁀ㅂ≄⹆❈", num);

            case VerticalOrigin.InnerMarginArea:
                return BookmarkStart.b("娲嬴䐶倸强堼爾⁀ㅂ≄⹆❈", num);

            case VerticalOrigin.OuterMarginArea:
                return BookmarkStart.b("尲䀴䌶䨸刺夼娾ీ≂㝄⁆⁈╊", num);
        }
        return BookmarkStart.b("帲吴䔶常刺匼", num);
    }

    private string method_261(ShapeHorizontalAlignment A_0)
    {
        int num = 0;
        switch (A_0)
        {
            case ShapeHorizontalAlignment.Center:
                return BookmarkStart.b("䔥䴧䐩堫䬭䈯", num);

            case ShapeHorizontalAlignment.Right:
                return BookmarkStart.b("吥䄧䴩䐫娭", num);

            case ShapeHorizontalAlignment.Inside:
                return BookmarkStart.b("伥䘧天䔫䨭唯", num);

            case ShapeHorizontalAlignment.Outside:
                return BookmarkStart.b("䤥崧帩弫䜭启圱", num);
        }
        return BookmarkStart.b("䨥䴧䰩堫", num);
    }

    private string method_262(ShapeVerticalAlignment A_0)
    {
        int num = 13;
        switch (A_0)
        {
            case ShapeVerticalAlignment.Center:
                return BookmarkStart.b("倲倴夶䴸帺似", num);

            case ShapeVerticalAlignment.Bottom:
                return BookmarkStart.b("儲娴䌶䴸吺值", num);

            case ShapeVerticalAlignment.Inside:
                return BookmarkStart.b("娲嬴䐶倸强堼", num);

            case ShapeVerticalAlignment.Outside:
                return BookmarkStart.b("尲䀴䌶䨸刺夼娾", num);
        }
        return BookmarkStart.b("䜲娴䜶", num);
    }

    private string method_263(TextWrappingStyle A_0)
    {
        int num = 0x11;
        switch (A_0)
        {
            case TextWrappingStyle.Inline:
                return BookmarkStart.b("夶嘸唺堼", num);

            case TextWrappingStyle.TopAndBottom:
                return BookmarkStart.b("䌶嘸䬺簼儾╀ł⩄㍆㵈⑊⁌", num);

            case TextWrappingStyle.Tight:
                return BookmarkStart.b("䌶倸尺唼䬾", num);

            case TextWrappingStyle.Through:
                return BookmarkStart.b("䌶儸䤺刼䨾♀⭂", num);
        }
        return BookmarkStart.b("䐶䠸为尼䴾⑀", num);
    }

    private void method_264(TextBoxFormat A_0)
    {
        int num = 7;
        string str = this.method_265(A_0.LineDashing);
        string str2 = this.method_266(A_0.LineStyle);
        if ((str != null) || (str2 != null))
        {
            this.class1092_0.method_10(BookmarkStart.b("帬嬮䌰尲帴制", num), this.dictionary_32[BookmarkStart.b("嬬", num)]);
            if (str != null)
            {
                this.class1092_0.method_4(BookmarkStart.b("䤬丮䈰嬲䘴䌶䀸场堼", num), str);
            }
            if (str2 != null)
            {
                this.class1092_0.method_4(BookmarkStart.b("䄬䘮弰嘲䘴䌶䀸场堼", num), str2);
            }
            this.class1092_0.method_12();
        }
    }

    private string method_265(LineDashing A_0)
    {
        int num = 11;
        switch (A_0)
        {
            case LineDashing.Dot:
                return BookmarkStart.b("0ጲд", num);

            case LineDashing.DashGEL:
                return BookmarkStart.b("唰刲䘴弶", num);

            case LineDashing.LongDashGEL:
                return BookmarkStart.b("崰尲嬴倶紸娺丼圾", num);

            case LineDashing.DashDotGEL:
                return BookmarkStart.b("唰刲䘴弶紸吺䤼", num);

            case LineDashing.LongDashDotGEL:
                return BookmarkStart.b("崰尲嬴倶紸娺丼圾Հⱂㅄ", num);

            case LineDashing.LongDashDotDotGEL:
                return BookmarkStart.b("崰尲嬴倶紸娺丼圾Հⱂㅄ͆♈㽊", num);
        }
        return null;
    }

    private string method_266(TextBoxLineStyle A_0)
    {
        int num = 0x11;
        switch (A_0)
        {
            case TextBoxLineStyle.Double:
                return BookmarkStart.b("䌶儸刺匼款⥀⩂⭄", num);

            case TextBoxLineStyle.ThickThin:
                return BookmarkStart.b("䌶儸刺帼吾ᕀ⭂ⱄ⥆", num);

            case TextBoxLineStyle.ThinThick:
                return BookmarkStart.b("䌶儸刺匼款⥀⩂♄ⱆ", num);

            case TextBoxLineStyle.Triple:
                return BookmarkStart.b("䌶儸刺帼吾̀♂ㅄうⱈ⹊⍌᭎㥐㩒㭔", num);
        }
        return null;
    }

    private string method_267(BorderStyle A_0)
    {
        int num = 2;
        switch (A_0)
        {
            case BorderStyle.Single:
                return BookmarkStart.b("嬧䐩䬫", num);

            case BorderStyle.Double:
                return BookmarkStart.b("䰧䠩䀫", num);

            case BorderStyle.Triple:
                return BookmarkStart.b("尧堩䔫", num);

            case BorderStyle.ThinThickMediumGap:
                return BookmarkStart.b("尧䈩䔫䀭搯娱崳唵匷", num);

            case BorderStyle.ThickThinMediumGap:
                return BookmarkStart.b("尧䈩䔫䴭嬯昱尳張嘷", num);
        }
        return BookmarkStart.b("嬧䐩䬫", num);
    }

    private void method_268(TextBox A_0)
    {
        int num = 11;
        float left = A_0.Format.InternalMargin.Left;
        if (left != 0f)
        {
            left = (float) Math.Round((double) left, 3);
        }
        float right = A_0.Format.InternalMargin.Right;
        if (right != 0f)
        {
            right = (float) Math.Round((double) right, 3);
        }
        float top = A_0.Format.InternalMargin.Top;
        if (top != 0f)
        {
            top = (float) Math.Round((double) top, 3);
        }
        float bottom = A_0.Format.InternalMargin.Bottom;
        if (bottom != 0f)
        {
            bottom = (float) Math.Round((double) bottom, 3);
        }
        string str = (((string.Empty + XmlConvert.ToString(left) + BookmarkStart.b("䄰䜲ᤴ", num)) + XmlConvert.ToString(top) + BookmarkStart.b("䄰䜲ᤴ", num)) + XmlConvert.ToString(right) + BookmarkStart.b("䄰䜲ᤴ", num)) + XmlConvert.ToString(bottom) + BookmarkStart.b("䄰䜲", num);
        this.class1092_0.method_4(BookmarkStart.b("堰崲䘴制䴸", num), str);
    }

    private bool method_269(ParagraphBase A_0)
    {
        if ((((A_0 is DocPicture) || (A_0 is TextBox)) || ((A_0 is ShapeObject) || (A_0 is ShapeGroup))) && ((this.stack_0 != null) && (this.stack_0.Count > 0)))
        {
            Field field2 = this.stack_0.Peek();
            if ((field2 != null) && (field2.Type == FieldType.FieldEmbed))
            {
                return true;
            }
            if ((field2 != null) && (field2.Type == FieldType.FieldShape))
            {
                this.bool_22 = false;
                return false;
            }
        }
        if (!(A_0 is Field) && !(A_0 is FieldMark))
        {
            return (this.bool_22 && ((this.stack_0 != null) && (this.stack_0.Count != 0)));
        }
        if ((this.stack_0 != null) && (this.stack_0.Count > 0))
        {
            Field field = this.stack_0.Peek();
            if ((field != null) && (field.Type == FieldType.FieldEmbed))
            {
                if ((A_0 is FieldMark) && ((A_0 as FieldMark).Type == FieldMarkType.FieldEnd))
                {
                    this.stack_0.Pop();
                    this.bool_22 = true;
                }
                return true;
            }
        }
        return false;
    }

    public void method_27(bool A_0)
    {
        this.bool_3 = A_0;
    }

    private void method_270(Class6 A_0)
    {
        int num = 2;
        if (this.document_0.DocxPackage != null)
        {
            Stream stream;
            this.class1092_0.method_10(BookmarkStart.b("娧", num), this.dictionary_32[BookmarkStart.b("弧", num)]);
            this.method_463(A_0.method_45());
            if (((A_0.method_42() != null) && (A_0.method_43() != null)) && (A_0.method_42() != A_0.method_43()))
            {
                this.class1092_0.method_10(BookmarkStart.b("椧䘩堫䬭䈯就唳䈵崷礹医倽㐿❁⩃㉅", num), this.dictionary_32[BookmarkStart.b("䔧䤩", num)]);
                this.class1092_0.method_10(BookmarkStart.b("欧䈩䌫䜭匯圱", num), this.dictionary_32[BookmarkStart.b("䔧䤩", num)]);
                this.class1092_0.method_4(BookmarkStart.b("稧伩崫嬭夯䀱儳䔵", num), BookmarkStart.b("弧娩弫", num));
                stream = this.method_271(A_0, false);
                this.method_272(stream);
                this.class1092_0.method_12();
                this.class1092_0.method_10(BookmarkStart.b("渧䬩䀫䈭刯匱圳崵", num), this.dictionary_32[BookmarkStart.b("䔧䤩", num)]);
                stream = this.method_271(A_0, true);
                this.method_272(stream);
                this.class1092_0.method_12();
                this.class1092_0.method_12();
            }
            else
            {
                stream = this.method_271(A_0, false);
                this.method_272(stream);
            }
            this.class1092_0.method_12();
        }
    }

    private Stream method_271(Class6 A_0, bool A_1)
    {
        if ((A_0.method_41().Count == 0) && (A_0.method_40().Count == 0))
        {
            List<string> list = new List<string>();
            if (!A_1)
            {
                return this.method_279(A_0.method_42(), ref list);
            }
            return this.method_279(A_0.method_43(), ref list);
        }
        return this.method_275(A_0, A_1);
    }

    private void method_272(Stream A_0)
    {
        this.method_273(A_0, false);
    }

    private void method_273(Stream A_0, bool A_1)
    {
        XmlNodeType type;
        int num = 14;
        A_0.Position = 0L;
        XmlReader reader = Class57.smethod_18(A_0);
        if (A_1 && (reader.LocalName == BookmarkStart.b("夳圵儷嘹焻嬽㈿╁⅃", num)))
        {
            return;
        }
        new MemoryStream((int) A_0.Length);
        goto Label_021C;
    Label_005B:
        if (!reader.Read())
        {
            return;
        }
    Label_021C:
        switch (reader.NodeType)
        {
            case XmlNodeType.Element:
            {
                if (this.dictionary_32.ContainsKey(reader.Prefix))
                {
                    this.class1092_0.method_11(reader.Prefix, reader.LocalName, this.dictionary_32[reader.Prefix]);
                }
                else
                {
                    this.class1092_0.method_11(reader.Prefix, reader.LocalName, reader.NamespaceURI);
                }
                string localName = reader.LocalName;
                if (reader.HasAttributes)
                {
                    while (reader.MoveToNextAttribute())
                    {
                        if (reader.Prefix != BookmarkStart.b("䰳嬵吷吹伻", num))
                        {
                            if (this.dictionary_32.ContainsKey(reader.Prefix))
                            {
                                this.class1092_0.method_6(reader.Prefix, reader.LocalName, this.dictionary_32[reader.Prefix], reader.Value);
                            }
                            else
                            {
                                if (localName.Equals(BookmarkStart.b("匳䐵夷䨹吻圽⌿ف╃㉅⥇", num)) && reader.LocalName.Equals(BookmarkStart.b("䄳䐵儷", num)))
                                {
                                    this.class1092_0.method_6(reader.Prefix, reader.LocalName, reader.NamespaceURI, this.method_274(reader.Value));
                                    continue;
                                }
                                this.class1092_0.method_6(reader.Prefix, reader.LocalName, reader.NamespaceURI, reader.Value);
                            }
                        }
                    }
                }
                reader.MoveToElement();
                if (reader.IsEmptyElement)
                {
                    this.class1092_0.method_12();
                }
                goto Label_005B;
            }
            case XmlNodeType.Attribute:
                goto Label_005B;

            case XmlNodeType.Text:
                this.class1092_0.method_21(reader.Value);
                goto Label_005B;
        }
        switch (type)
        {
            case XmlNodeType.SignificantWhitespace:
                this.class1092_0.method_22(reader.Value);
                break;

            case XmlNodeType.EndElement:
                this.class1092_0.method_12();
                break;
        }
        goto Label_005B;
    }

    private string method_274(string A_0)
    {
        int num = 0x10;
        if (string.IsNullOrEmpty(A_0))
        {
            return string.Empty;
        }
        if (A_0.EndsWith(BookmarkStart.b("䘵儷夹䠻䬽㈿❁", num)))
        {
            return this.dictionary_32[BookmarkStart.b("䘵儷夹", num)];
        }
        if (A_0.EndsWith(BookmarkStart.b("刵儷嬹嬻䰽ℿ⽁", num)))
        {
            return this.dictionary_32[BookmarkStart.b("刵強圹", num)];
        }
        return A_0;
    }

    private Stream method_275(Class6 A_0, bool A_1)
    {
        int num = 0;
        List<string> list = new List<string>();
        List<string> list2 = !A_1 ? this.method_552(A_0.method_42()) : this.method_552(A_0.method_43());
        Stream stream = !A_1 ? this.method_279(A_0.method_42(), ref list) : this.method_279(A_0.method_43(), ref list);
        int num2 = 0;
        int count = list2.Count;
        while (num2 < count)
        {
            string key = list2[num2];
            string str3 = list[num2];
            if (A_0.method_40().ContainsKey(key))
            {
                this.method_276(A_0, key, str3);
            }
            else
            {
                DictionaryEntry entry = A_0.method_41()[key];
                string str = entry.Key.ToString();
                this.method_550(A_0, str3, entry);
                if ((str != BookmarkStart.b("严尧帩尫ᐭἯᴱ䜳唵倷弹儻弽㌿汁⭃㙅ⵇ⑉㑋⍍㱏㑑㭓⑕㕗㭙⡛ⵝ也ൡᙣť䝧թ੫࡭᥯ᅱᅳ㉵᝷᥹ॻ፽ꦅ몇몉벋뢍뾏歹聯캟톡첣쾥\ud8a7\ud9a9莫춭\ud8af\ud3b1욳습", num)) && (str != BookmarkStart.b("严尧帩尫ᐭἯᴱ䜳唵倷弹儻弽㌿汁⭃㙅ⵇ⑉㑋⍍㱏㑑㭓⑕㕗㭙⡛ⵝ也ൡᙣť䝧թ੫࡭᥯ᅱᅳ㉵᝷᥹ॻ፽ꦅ몇몉벋뢍뾏歹聯캟톡첣쾥\ud8a7\ud9a9莫춭\udfaf\udcb1삳쒵ힷ횹", num)))
                {
                    if (!(str == BookmarkStart.b("严尧帩尫ᐭἯᴱ䜳唵倷弹儻弽㌿汁⭃㙅ⵇ⑉㑋⍍㱏㑑㭓⑕㕗㭙⡛ⵝ也ൡᙣť䝧թ੫࡭᥯ᅱᅳ㉵᝷᥹ॻ፽ꦅ몇몉벋뢍뾏歹聯캟톡첣쾥\ud8a7\ud9a9莫솭\udcaf\ud7b1﮳풵튷\udfb9\udfbb쪽", num)) && !(str == BookmarkStart.b("严尧帩尫ᐭἯᴱ䜳唵倷弹儻弽㌿汁⭃㙅ⵇ⑉㑋⍍㱏㑑㭓⑕㕗㭙⡛ⵝ也ൡᙣť䝧թ੫࡭᥯ᅱᅳ㉵᝷᥹ॻ፽ꦅ몇몉벋뢍뾏歹聯캟톡첣쾥\ud8a7\ud9a9莫\udead\ud1af톱\udfb3\ud7b5\udfb7\udfb9", num)))
                    {
                        this.bool_15 = true;
                    }
                    else
                    {
                        this.bool_7 = true;
                        this.method_301(A_0.method_42());
                    }
                }
                else
                {
                    this.method_286(str, entry.Value.ToString());
                }
            }
            num2++;
        }
        return stream;
    }

    private void method_276(Class6 A_0, string A_1, string A_2)
    {
        Class517 class2 = null;
        if (A_0.method_40().ContainsKey(A_1))
        {
            class2 = A_0.method_40()[A_1];
            DocumentObject obj2 = this.method_277(A_0);
            if (obj2 is HeaderFooter)
            {
                HeaderFooter footer = obj2 as HeaderFooter;
                this.method_337(A_2, footer, class2);
            }
            else if ((obj2.Owner != null) && (obj2.Owner is HeaderFooter))
            {
                HeaderFooter owner = obj2.Owner as HeaderFooter;
                this.method_337(A_2, owner, class2);
            }
            else if (obj2 is Footnote)
            {
                if ((obj2 as Footnote).FootnoteType == FootnoteType.Footnote)
                {
                    this.method_40().Add(A_2, class2);
                }
                else
                {
                    this.method_41().Add(A_2, class2);
                }
            }
            else if (obj2 is Comment)
            {
                this.method_42().Add(A_2, class2);
            }
            else
            {
                this.method_38().Add(A_2, class2);
            }
            if (class2.method_7())
            {
                this.bool_6 = true;
            }
            else
            {
                this.bool_0 = true;
            }
        }
    }

    private DocumentObject method_277(Class6 A_0)
    {
        HeaderFooter footer;
        DocumentObject ownerTextBody;
        DocumentObject owner = A_0.Owner;
        Paragraph paragraph = null;
        if (A_0.Owner is DocOleObject)
        {
            owner = (A_0.Owner as DocOleObject).OwnerParagraph;
        }
        if (owner.DocumentObjectType == DocumentObjectType.SDTInlineContent)
        {
            paragraph = owner.Owner.Owner as Paragraph;
        }
        else if (owner.DocumentObjectType == DocumentObjectType.Paragraph)
        {
            paragraph = owner as Paragraph;
        }
        TableCell cell = paragraph.Owner as TableCell;
        DocumentObject obj3 = paragraph.Owner.Owner;
        if (cell != null)
        {
            ownerTextBody = cell.OwnerRow.OwnerTable.OwnerTextBody;
        }
        else
        {
            ownerTextBody = paragraph.Owner;
        }
        obj3 = ownerTextBody.Owner;
        if ((obj3 is TextBox) && ((obj3 as TextBox).OwnerParagraph != null))
        {
            footer = (obj3 as TextBox).OwnerParagraph.OwnerTextBody as HeaderFooter;
        }
        else
        {
            footer = ownerTextBody as HeaderFooter;
        }
        if (footer != null)
        {
            return footer;
        }
        return obj3;
    }

    private void method_278(string A_0, HeaderFooter A_1, DictionaryEntry A_2)
    {
        string key = this.method_339(A_1);
        if (key != null)
        {
            Dictionary<string, DictionaryEntry> dictionary = null;
            if (!this.method_4().ContainsKey(key))
            {
                dictionary = new Dictionary<string, DictionaryEntry>();
                this.method_4().Add(key, dictionary);
            }
            else
            {
                dictionary = this.method_4()[key];
            }
            dictionary.Add(A_0, A_2);
        }
    }

    private Stream method_279(Stream A_0, ref List<string> A_1)
    {
        XmlNodeType type;
        A_0.Position = 0L;
        XmlReader reader = Class57.smethod_18(A_0);
        MemoryStream stream = new MemoryStream((int) A_0.Length);
        XmlWriter writer = Class57.smethod_19(stream, Encoding.UTF8);
        goto Label_00A8;
    Label_003D:
        if (!reader.Read())
        {
            writer.Flush();
            stream.Flush();
            return stream;
        }
    Label_00A8:
        switch (reader.NodeType)
        {
            case XmlNodeType.Element:
                writer.WriteStartElement(reader.Prefix, reader.LocalName, reader.NamespaceURI);
                this.method_280(reader, writer, ref A_1);
                reader.MoveToElement();
                if (reader.IsEmptyElement)
                {
                    writer.WriteEndElement();
                }
                goto Label_003D;

            case XmlNodeType.Attribute:
                goto Label_003D;

            case XmlNodeType.Text:
                writer.WriteString(reader.Value);
                goto Label_003D;
        }
        switch (type)
        {
            case XmlNodeType.SignificantWhitespace:
                writer.WriteWhitespace(reader.Value);
                break;

            case XmlNodeType.EndElement:
                writer.WriteEndElement();
                break;
        }
        goto Label_003D;
    }

    public bool method_28()
    {
        return this.bool_4;
    }

    private void method_280(XmlReader A_0, XmlWriter A_1, ref List<string> A_2)
    {
        int num = 0x12;
        if ((((A_0.LocalName != BookmarkStart.b("帷匹倻刽", 0x12)) && (A_0.LocalName != BookmarkStart.b("嬷刹崻䰽㐿", num))) && ((A_0.LocalName != BookmarkStart.b("儷圹崻夽┿♁╃㉅⥇", num)) && (A_0.LocalName != BookmarkStart.b("䬷丹主儽⬿❁", num)))) && (((A_0.LocalName != BookmarkStart.b("嬷唹刻䨽㈿ⵁ⡃", num)) && (A_0.LocalName != BookmarkStart.b("眷瘹礻焽∿⡁⅃╅㱇", num))) && (A_0.LocalName != BookmarkStart.b("倷䌹䰻嬽㈿⹁ⵃ⡅⍇", num))))
        {
            if (A_0.LocalName == BookmarkStart.b("娷嘹唻丽", num))
            {
                this.method_282(A_0, A_1, ref A_2);
            }
            else if (A_0.LocalName == BookmarkStart.b("䨷弹倻眽␿ㅁ", num))
            {
                this.method_283(A_0, A_1, ref A_2);
            }
            else if (A_0.LocalName == BookmarkStart.b("尷唹弻渽㈿", num))
            {
                this.method_284(A_0, A_1);
            }
            else
            {
                for (int i = 0; i < A_0.AttributeCount; i++)
                {
                    A_0.MoveToAttribute(i);
                    A_1.WriteAttributeString(A_0.Prefix, A_0.LocalName, A_0.NamespaceURI, A_0.Value);
                }
            }
        }
        else
        {
            this.method_281(A_0, A_1, ref A_2);
        }
    }

    private void method_281(XmlReader A_0, XmlWriter A_1, ref List<string> A_2)
    {
        int num = 9;
        for (int i = 0; i < A_0.AttributeCount; i++)
        {
            string str;
            A_0.MoveToAttribute(i);
            if (((str = A_0.LocalName) != null) && ((str == BookmarkStart.b("䘮唰", num)) || (str == BookmarkStart.b("䜮䌰嘲匴", num))))
            {
                if ((A_0.Value != null) && (A_0.Value.Length > 0))
                {
                    string str2 = this.method_527();
                    A_1.WriteAttributeString(A_0.Prefix, A_0.LocalName, A_0.NamespaceURI, str2);
                    A_2.Add(str2);
                }
                else
                {
                    A_1.WriteAttributeString(A_0.Prefix, A_0.LocalName, A_0.NamespaceURI, A_0.Value);
                }
            }
            else
            {
                A_1.WriteAttributeString(A_0.Prefix, A_0.LocalName, A_0.NamespaceURI, A_0.Value);
            }
        }
    }

    private void method_282(XmlReader A_0, XmlWriter A_1, ref List<string> A_2)
    {
        int num = 12;
        for (int i = 0; i < A_0.AttributeCount; i++)
        {
            string str;
            A_0.MoveToAttribute(i);
            if (((str = A_0.LocalName) != null) && (str == BookmarkStart.b("圱夳吵崷帹", num)))
            {
                if ((A_0.Value != null) && (A_0.Value.Length > 0))
                {
                    string str2 = this.method_527();
                    A_1.WriteAttributeString(A_0.Prefix, A_0.LocalName, A_0.NamespaceURI, str2);
                    A_2.Add(str2);
                }
                else
                {
                    A_1.WriteAttributeString(A_0.Prefix, A_0.LocalName, A_0.NamespaceURI, A_0.Value);
                }
            }
            else
            {
                A_1.WriteAttributeString(A_0.Prefix, A_0.LocalName, A_0.NamespaceURI, A_0.Value);
            }
        }
    }

    private void method_283(XmlReader A_0, XmlWriter A_1, ref List<string> A_2)
    {
        int num = 12;
        for (int i = 0; i < A_0.AttributeCount; i++)
        {
            string str2;
            A_0.MoveToAttribute(i);
            if (((str2 = A_0.LocalName) != null) && (((str2 == BookmarkStart.b("嘱夳", num)) || (str2 == BookmarkStart.b("帱嬳", num))) || ((str2 == BookmarkStart.b("䌱䜳", num)) || (str2 == BookmarkStart.b("儱䜳", num)))))
            {
                if ((A_0.Value != null) && (A_0.Value.Length > 0))
                {
                    string str = this.method_527();
                    A_1.WriteAttributeString(A_0.Prefix, A_0.LocalName, A_0.NamespaceURI, str);
                    A_2.Add(str);
                }
                else
                {
                    A_1.WriteAttributeString(A_0.Prefix, A_0.LocalName, A_0.NamespaceURI, A_0.Value);
                }
            }
            else
            {
                A_1.WriteAttributeString(A_0.Prefix, A_0.LocalName, A_0.NamespaceURI, A_0.Value);
            }
        }
    }

    private void method_284(XmlReader A_0, XmlWriter A_1)
    {
        int num = 5;
        for (int i = 0; i < A_0.AttributeCount; i++)
        {
            string str;
            A_0.MoveToAttribute(i);
            if (((str = A_0.LocalName) != null) && (str == BookmarkStart.b("䈪䤬", num)))
            {
                if ((A_0.Value != null) && (A_0.Value.Length > 0))
                {
                    string str2 = this.method_545().ToString();
                    A_1.WriteAttributeString(A_0.Prefix, A_0.LocalName, A_0.NamespaceURI, str2);
                }
                else
                {
                    A_1.WriteAttributeString(A_0.Prefix, A_0.LocalName, A_0.NamespaceURI, A_0.Value);
                }
            }
            else
            {
                A_1.WriteAttributeString(A_0.Prefix, A_0.LocalName, A_0.NamespaceURI, A_0.Value);
            }
        }
    }

    private void method_285(XmlNode A_0, List<string> A_1)
    {
        int num = 9;
        XmlAttribute attribute = null;
        for (int i = 0; i < 4; i++)
        {
            switch (i)
            {
                case 0:
                    attribute = A_0.Attributes[BookmarkStart.b("䬮尰", num), this.dictionary_32[BookmarkStart.b("崮", num)]];
                    break;

                case 1:
                    attribute = A_0.Attributes[BookmarkStart.b("䌮帰", num), this.dictionary_32[BookmarkStart.b("崮", num)]];
                    break;

                case 2:
                    attribute = A_0.Attributes[BookmarkStart.b("帮䈰", num), this.dictionary_32[BookmarkStart.b("崮", num)]];
                    break;

                case 3:
                    attribute = A_0.Attributes[BookmarkStart.b("䰮䈰", num), this.dictionary_32[BookmarkStart.b("崮", num)]];
                    break;
            }
            if (attribute != null)
            {
                attribute.Value = this.method_527();
                A_1.Add(attribute.Value);
            }
        }
    }

    private void method_286(string A_0, string A_1)
    {
        int num = 15;
        if (A_0 == BookmarkStart.b("崴䌶䴸䬺ܼှ湀あ♄⽆ⱈ♊ⱌ㱎罐㱒╔㉖㝘⍚ぜ㍞ݠౢᝤ੦ࡨὪṬ䅮ṰŲቴ塶ᙸᵺ᭼ᙾ솄ﺊﾐ몔ꖖꦘꮚꮜ낞펠욢즤욦\udda8\uc2aa슬솮슰\udbb2\udcb4잶쪸钺\udebc\ud7beꃀ뇂뇄", 15))
        {
            this.method_3().Add(BookmarkStart.b("䈴堶䬸强ሼ", num) + A_1);
        }
        else if (A_0 == BookmarkStart.b("崴䌶䴸䬺ܼှ湀あ♄⽆ⱈ♊ⱌ㱎罐㱒╔㉖㝘⍚ぜ㍞ݠౢᝤ੦ࡨὪṬ䅮ṰŲቴ塶ᙸᵺ᭼ᙾ솄ﺊﾐ몔ꖖꦘꮚꮜ낞펠욢즤욦\udda8\uc2aa슬솮슰\udbb2\udcb4잶쪸钺\udebc\ud0be꿀럂럄꣆ꗈ", num))
        {
            this.method_2().Add(BookmarkStart.b("䈴堶䬸强ሼ", num) + A_1);
        }
    }

    private DocPicture method_287(string A_0, Class6 A_1)
    {
        int num = 4;
        if (A_1.Document.DocxPackage != null)
        {
            DictionaryEntry entry = A_1.method_41()[A_0];
            string key = entry.Value.ToString().Replace(BookmarkStart.b("䜩䤫䨭夯匱ᬳ", num), null);
            Class1128 class2 = A_1.Document.DocxPackage.method_18(BookmarkStart.b("崩䌫尭启ᴱ夳匵尷匹崻ᄽ", num));
            if ((class2 != null) && class2.method_0().ContainsKey(key))
            {
                return this.method_288(class2.method_0()[key]);
            }
        }
        return null;
    }

    private DocPicture method_288(Class229 A_0)
    {
        int length = (int) A_0.method_4().Length;
        byte[] buffer = new byte[length];
        A_0.method_4().Position = 0L;
        A_0.method_4().Read(buffer, 0, length);
        DocPicture picture = new DocPicture(this.document_0);
        picture.LoadImage(buffer);
        return picture;
    }

    private void method_289(DocOleObject A_0)
    {
        if (A_0.OleXmlItem != null)
        {
            A_0.OleXmlItem.method_0(A_0.Owner);
            this.method_270(A_0.OleXmlItem);
        }
        else if (((A_0.Interface49.get_Container() != null) || (A_0.Interface49.get_LinkType() != OleLinkType.Embed)) && (A_0.Interface49.get_OlePicture() != null))
        {
            Field item = new Field(this.document_0) {
                Type = FieldType.FieldEmbed
            };
            this.method_46().Push(item);
            this.bool_7 = true;
            this.method_342(A_0);
        }
    }

    public void method_29(bool A_0)
    {
        this.bool_4 = A_0;
    }

    internal void method_290(DocOleObject A_0, string A_1)
    {
        int num = 0x11;
        this.class1092_0.method_10(BookmarkStart.b("砶甸縺爼崾⭀♂♄㍆", 0x11), this.dictionary_32[BookmarkStart.b("堶", 0x11)]);
        string str5 = (A_0.Interface49.get_LinkType() == OleLinkType.Embed) ? BookmarkStart.b("父吸夺堼嬾", num) : BookmarkStart.b("笶倸唺嘼", num);
        this.class1092_0.method_4(BookmarkStart.b("挶䀸䬺堼", num), str5);
        this.class1092_0.method_4(BookmarkStart.b("朶䬸吺娼瘾Հ", num), A_0.Interface49.get_ObjectType());
        this.class1092_0.method_4(BookmarkStart.b("搶儸娺䴼娾ࡀ݂", num), A_1);
        if (A_0.Interface49.get_DisplayAsIcon())
        {
            this.class1092_0.method_4(BookmarkStart.b("猶䬸娺䨼績㉀㍂⁄⑆㵈", num), BookmarkStart.b("縶娸吺匼", num));
        }
        else
        {
            this.class1092_0.method_4(BookmarkStart.b("猶䬸娺䨼績㉀㍂⁄⑆㵈", num), BookmarkStart.b("琶嘸唺䤼娾⽀㝂", num));
        }
        string str = null;
        string key = null;
        IDocumentObject obj2 = this.method_548(A_0);
        if (obj2.DocumentObjectType == DocumentObjectType.HeaderFooter)
        {
            key = this.method_339(obj2 as HeaderFooter);
        }
        if (((key == null) || this.method_17().ContainsKey(key)) && (this.method_18().ContainsKey(A_0.Interface49.get_OleStorageName()) && (A_0.Interface49.get_LinkType() == OleLinkType.Embed)))
        {
            str = this.method_18()[A_0.Interface49.get_OleStorageName()];
            this.class1092_0.method_4(BookmarkStart.b("砶嬸儺堼尾㕀ੂń", num), BookmarkStart.b("栶", num) + A_0.Interface49.get_OleStorageName());
            this.class1092_0.method_5(BookmarkStart.b("帶崸", num), this.dictionary_32[BookmarkStart.b("䔶", num)], str);
        }
        else
        {
            str = this.method_527();
            this.class1092_0.method_5(BookmarkStart.b("帶崸", num), this.dictionary_32[BookmarkStart.b("䔶", num)], str);
            if (!this.method_18().ContainsKey(A_0.Interface49.get_OleStorageName()) && (A_0.Interface49.get_LinkType() == OleLinkType.Embed))
            {
                this.method_18().Add(A_0.Interface49.get_OleStorageName(), str);
            }
            string str3 = null;
            if (A_0.Interface49.get_LinkType() == OleLinkType.Embed)
            {
                this.class1092_0.method_4(BookmarkStart.b("砶嬸儺堼尾㕀ੂń", num), BookmarkStart.b("栶", num) + A_0.Interface49.get_OleStorageName());
                string str2 = this.method_297(A_0.OleObjectType);
                if (obj2.DocumentObjectType == DocumentObjectType.HeaderFooter)
                {
                    if (this.method_17().ContainsKey(key))
                    {
                        this.method_17()[key].Add(str2, this.method_293(A_0));
                    }
                    else
                    {
                        this.method_17().Add(key, new Dictionary<string, Stream>());
                        this.method_17()[key].Add(str2, this.method_293(A_0));
                    }
                }
                else
                {
                    this.method_16().Add(str2, this.method_293(A_0));
                }
                str3 = BookmarkStart.b("制吸夺堼嬾╀⩂⭄⁆㩈摊", num) + str2;
            }
            else
            {
                this.class1092_0.method_4(BookmarkStart.b("戶䤸强尼䬾⑀โ⩄⍆ⱈ", num), BookmarkStart.b("瘶唸䰺尼䘾㉀", num));
                this.method_296();
                str3 = A_0.Interface49.get_LinkPath().Replace(BookmarkStart.b("᜶", num), BookmarkStart.b("ሶସ଺", num));
                if (!string.IsNullOrEmpty(str3) && !str3.Contains(BookmarkStart.b("儶倸场堼Ծ湀求", num)))
                {
                    str3 = BookmarkStart.b("儶倸场堼Ծ湀求", num) + str3;
                }
            }
            string str6 = this.method_298(A_0.OleObjectType);
            DictionaryEntry entry = new DictionaryEntry(str6, str3);
            this.method_550(A_0, str, entry);
            this.method_302(A_0.Interface49.get_ObjectType());
        }
        this.class1092_0.method_12();
    }

    private void method_291(DocOleObject A_0)
    {
        DocPicture picture = A_0.Interface49.get_OlePicture();
        string str = this.method_335(picture, true, A_0);
        this.method_292(str, picture, true);
        if (picture.IsMetaFile)
        {
            this.bool_6 = true;
        }
        else
        {
            this.bool_0 = true;
        }
    }

    private void method_292(string A_0, DocPicture A_1, bool A_2)
    {
        int num = 12;
        this.class1092_0.method_10(BookmarkStart.b("嬱夳圵強弹堻弽㐿⍁", 12), this.dictionary_32[BookmarkStart.b("䐱", 12)]);
        if (!string.IsNullOrEmpty(A_0))
        {
            this.class1092_0.method_5(BookmarkStart.b("嬱倳", num), this.dictionary_32[BookmarkStart.b("䀱", num)], A_0);
        }
        if (A_2)
        {
            this.class1092_0.method_5(BookmarkStart.b("䘱崳䈵吷弹", num), this.dictionary_32[BookmarkStart.b("崱", num)], "");
        }
        else if (A_1.Title != null)
        {
            this.class1092_0.method_5(BookmarkStart.b("䘱崳䈵吷弹", num), this.dictionary_32[BookmarkStart.b("崱", num)], A_1.Title);
        }
        if (A_1.CropFromBottom != 0f)
        {
            this.class1092_0.method_4(BookmarkStart.b("儱䘳夵䠷堹医䨽㐿ⵁ⥃", num), ((A_1.CropFromBottom * 65536f)).ToString() + BookmarkStart.b("吱", num));
        }
        if (A_1.CropFromTop != 0f)
        {
            this.class1092_0.method_4(BookmarkStart.b("儱䘳夵䠷丹医丽", num), ((A_1.CropFromTop * 65536f)).ToString() + BookmarkStart.b("吱", num));
        }
        if (A_1.CropFromLeft != 0f)
        {
            this.class1092_0.method_4(BookmarkStart.b("儱䘳夵䠷嘹夻堽㐿", num), ((A_1.CropFromLeft * 65536f)).ToString() + BookmarkStart.b("吱", num));
        }
        if (A_1.CropFromRight != 0f)
        {
            this.class1092_0.method_4(BookmarkStart.b("儱䘳夵䠷䠹唻夽⠿㙁", num), ((A_1.CropFromRight * 65536f)).ToString() + BookmarkStart.b("吱", num));
        }
        Color chromaKey = A_1.ChromaKey;
        if (!A_1.ChromaKey.IsEmpty)
        {
            this.class1092_0.method_4(BookmarkStart.b("儱尳䐵圷圹崻唽┿㭁", num), BookmarkStart.b("ᄱ", num) + this.method_535(A_1.ChromaKey));
        }
        this.class1092_0.method_12();
    }

    private Stream method_293(DocOleObject A_0)
    {
        switch (A_0.OleObjectType)
        {
            case OleObjectType.Undefined:
                if (A_0.stream_1 == null)
                {
                    return this.method_294(A_0);
                }
                return A_0.stream_1;

            case OleObjectType.Excel_97_2003_Worksheet:
            case OleObjectType.ExcelBinaryWorksheet:
            case OleObjectType.ExcelChart:
            case OleObjectType.ExcelMacroWorksheet:
            case OleObjectType.ExcelWorksheet:
            case OleObjectType.PowerPoint_97_2003_Presentation:
            case OleObjectType.PowerPointMacroPresentation:
            case OleObjectType.PowerPointMacroSlide:
            case OleObjectType.PowerPointPresentation:
            case OleObjectType.PowerPointSlide:
            case OleObjectType.Word_97_2003_Document:
            case OleObjectType.WordDocument:
            case OleObjectType.WordMacroDocument:
            case OleObjectType.VisioDrawing_2013:
                return new MemoryStream(A_0.Interface49.get_NativeData());
        }
        return this.method_294(A_0);
    }

    private Stream method_294(DocOleObject A_0)
    {
        Class1004 class2;
        int num = 0x12;
        if (A_0.Interface49.get_Container().Position == A_0.Interface49.get_Container().Length)
        {
            A_0.Interface49.get_Container().Position = 0L;
        }
        Class1004 class3 = new Class1004(A_0.Interface49.get_Container());
        Interface61 interface2 = class3.Interface51.imethod_0().imethod_5(BookmarkStart.b("朷", num) + A_0.Interface49.get_OleStorageName());
        if (A_0.OleObjectType == OleObjectType.Undefined)
        {
            class2 = new Class1004();
            class2.Interface51.imethod_1().method_0()[0].method_13(this.method_295(class3, A_0));
        }
        else
        {
            class2 = new Class1004(BookmarkStart.b("朷", num) + A_0.Interface49.get_OleStorageName(), true);
            class2.Interface51.imethod_1().method_0()[0].method_13(Class1117.smethod_2(A_0.OleObjectType));
        }
        int index = 0;
        int length = interface2.imethod_9().Length;
        while (index < length)
        {
            Stream1 stream2 = class2.Interface51.imethod_0().imethod_2(interface2.imethod_9()[index]);
            Stream1 stream3 = interface2.imethod_0(interface2.imethod_9()[index]);
            stream3.vmethod_0(stream2);
            stream3.Close();
            stream3.Dispose();
            stream2.Close();
            stream2.Dispose();
            index++;
        }
        class3.System.IDisposable.Dispose();
        MemoryStream stream = new MemoryStream();
        class2.Interface51.imethod_3(stream);
        class2.System.IDisposable.Dispose();
        return stream;
    }

    private Guid method_295(Class1004 A_0, DocOleObject A_1)
    {
        int num = 7;
        Guid guid = Class1117.smethod_2(A_1.OleObjectType);
        using (List<Class297>.Enumerator enumerator = A_0.Interface51.imethod_1().method_0().GetEnumerator())
        {
            Class297 current;
            while (enumerator.MoveNext())
            {
                current = enumerator.Current;
                if (current.method_0() == (BookmarkStart.b("爬", num) + A_1.Interface49.get_OleStorageName()))
                {
                    goto Label_005C;
                }
            }
            return guid;
        Label_005C:
            guid = current.method_12();
        }
        return guid;
    }

    private void method_296()
    {
        this.class1092_0.method_10(BookmarkStart.b("攨䈪䌬䐮攰䨲䔴制", 3), this.dictionary_32[BookmarkStart.b("䘨", 3)]);
        this.class1092_0.method_21(BookmarkStart.b("氨䔪䔬丮弰倲倴匶琸帺䤼帾݀⩂⥄≆", 3));
        this.class1092_0.method_12();
        this.class1092_0.method_10(BookmarkStart.b("攨䐪丬䐮吰圲猴帶尸场夼", 3), this.dictionary_32[BookmarkStart.b("䘨", 3)]);
        this.class1092_0.method_21(BookmarkStart.b("伨䨪䄬尮吰", 3));
        this.class1092_0.method_12();
        this.class1092_0.method_10(BookmarkStart.b("漨䈪䠬䌮唰瀲娴匶尸䠺", 3), this.dictionary_32[BookmarkStart.b("䘨", 3)]);
        this.class1092_0.method_21(this.string_0 + BookmarkStart.b("伨ପᴬ", 3));
        this.class1092_0.method_12();
    }

    private string method_297(OleObjectType A_0)
    {
        int num = 11;
        string key = Class1117.smethod_1(A_0, false);
        if (key != null)
        {
            int num5;
            if (Class1160.dictionary_39 == null)
            {
                Dictionary<string, int> dictionary1 = new Dictionary<string, int>(14);
                dictionary1.Add(BookmarkStart.b("琰䬲嘴制唸ᔺ縼圾⁀ㅂㅄ楆煈", num), 0);
                dictionary1.Add(BookmarkStart.b("琰䬲嘴制唸ᔺ渼圾⑀♂ㅄ楆煈", num), 1);
                dictionary1.Add(BookmarkStart.b("琰䬲嘴制唸ᔺ渼圾⑀♂ㅄ楆硈祊", num), 2);
                dictionary1.Add(BookmarkStart.b("琰䬲嘴制唸ᔺ渼圾⑀♂ㅄ੆⡈⡊㽌⁎ᑐ㵒㑔㕖㕘㹚㥜煞偠兢", num), 3);
                dictionary1.Add(BookmarkStart.b("琰䬲嘴制唸ᔺ渼圾⑀♂ㅄՆ⁈╊ⱌ㵎⡐Ṓ㑔㑖⭘㑚ᡜㅞ`Ţ।ɦ൨䕪屬嵮", num), 4);
                dictionary1.Add(BookmarkStart.b("愰尲䈴制䬸欺刼嘾⽀㝂歄ᑆⅈ⑊㩌慎楐", num), 5);
                dictionary1.Add(BookmarkStart.b("愰尲䈴制䬸欺刼嘾⽀㝂歄ᑆⅈ⑊㩌慎恐慒", num), 6);
                dictionary1.Add(BookmarkStart.b("昰尲䜴匶᜸缺刼尾㑀⹂⁄⥆㵈敊界", num), 7);
                dictionary1.Add(BookmarkStart.b("昰尲䜴匶᜸缺刼尾㑀⹂⁄⥆㵈敊籌絎", num), 8);
                dictionary1.Add(BookmarkStart.b("昰尲䜴匶᜸缺刼尾㑀⹂⁄⥆㵈يⱌⱎ⍐㱒ၔ㥖㡘㥚ㅜ㩞ՠ䵢呤啦", num), 9);
                dictionary1.Add(BookmarkStart.b("愰尲䈴制䬸欺刼嘾⽀㝂歄ᑆⅈ⑊㩌Ɏぐげ❔㡖᱘㕚㱜㵞ൠ٢Ť䥦塨奪", num), 10);
                dictionary1.Add(BookmarkStart.b("愰尲䈴制䬸欺刼嘾⽀㝂歄ᑆ╈≊⥌⩎᱐㉒㙔╖㙘Ṛ㍜㹞͠རdͦ䝨婪彬", num), 11);
                dictionary1.Add(BookmarkStart.b("愰尲䈴制䬸欺刼嘾⽀㝂歄ᑆ╈≊⥌⩎罐扒杔", num), 12);
                dictionary1.Add(BookmarkStart.b("朰娲䘴帶嘸ᔺ礼䴾⁀㑂ⱄ⥆⹈敊籌穎", num), 13);
                Class1160.dictionary_39 = dictionary1;
            }
            if (Class1160.dictionary_39.TryGetValue(key, out num5))
            {
                switch (num5)
                {
                    case 0:
                    case 1:
                        return (BookmarkStart.b("簰娲嘴䔶嘸䠺刼夾㕀᱂੄ⅆ⽈≊⹌⩎๐ᙒⵔ㑖㱘㝚ɜ晞噠乢坤坦奨塪㉬㡮ṰŲṴѶᅸṺ᡼୾", num) + this.method_528().ToString() + BookmarkStart.b("ἰ䬲头䐶", num));

                    case 2:
                        return (BookmarkStart.b("簰娲嘴䔶嘸䠺刼夾㕀᱂੄ⅆ⽈≊⹌⩎๐ᙒⵔ㑖㱘㝚ɜ࡞๠ᅢ๤ᑦŨ๪࡬᭮", num) + this.method_528().ToString() + BookmarkStart.b("ἰ䬲头䐶䄸", num));

                    case 3:
                        return (BookmarkStart.b("簰娲嘴䔶嘸䠺刼夾㕀᱂੄ⅆ⽈≊⹌⩎๐ᙒⵔ㑖㱘㝚ɜ቞`bᝤࡦ䑨⹪ͬ๮፰ὲၴ፶♸ⱺቼൾﾊ", num) + this.method_528().ToString() + BookmarkStart.b("ἰ䬲头䐶吸", num));

                    case 4:
                        return (BookmarkStart.b("簰娲嘴䔶嘸䠺刼夾㕀᱂੄ⅆ⽈≊⹌⩎๐ᙒⵔ㑖㱘㝚ɜᵞࡠൢѤᕦၨ㑪㩬nͰᡲٴὶᱸṺॼ", num) + this.method_528().ToString() + BookmarkStart.b("ἰ䬲头䐶嬸", num));

                    case 5:
                        return (BookmarkStart.b("簰娲嘴䔶嘸䠺刼夾㕀᱂੄ⅆ⽈≊⹌⩎๐͒㩔⁖㱘⥚൜ぞࡠൢᅤ㡦偨屪䁬嵮䅰䍲䙴⡶⥸ॺ᡼౾ﶈ", num) + this.method_528().ToString() + BookmarkStart.b("ἰ䌲䔴䌶", num));

                    case 6:
                        return (BookmarkStart.b("簰娲嘴䔶嘸䠺刼夾㕀᱂੄ⅆ⽈≊⹌⩎๐͒㩔⁖㱘⥚൜ぞࡠൢᅤ㡦㥨ᥪ࡬ᱮᑰᵲŴᙶ൸ቺቼᅾ", num) + this.method_528().ToString() + BookmarkStart.b("ἰ䌲䔴䌶䄸", num));

                    case 7:
                        return (BookmarkStart.b("簰娲嘴䔶嘸䠺刼夾㕀᱂੄ⅆ⽈≊⹌⩎๐ђ㩔╖㵘њ摜桞䱠兢啤坦婨㑪⥬nተٲᡴቶ᝸ེ", num) + this.method_528().ToString() + BookmarkStart.b("ἰ圲娴吶", num));

                    case 8:
                        return (BookmarkStart.b("簰娲嘴䔶嘸䠺刼夾㕀᱂੄ⅆ⽈≊⹌⩎๐ђ㩔╖㵘њᥜぞɠᙢࡤɦݨὪ", num) + this.method_528().ToString() + BookmarkStart.b("ἰ圲娴吶䄸", num));

                    case 9:
                        return (BookmarkStart.b("簰娲嘴䔶嘸䠺刼夾㕀᱂੄ⅆ⽈≊⹌⩎๐ђ㩔╖㵘њၜ㹞ɠᅢ੤䩦ⱨժ౬൮ᵰᙲᅴ⡶㵸ᑺṼ੾", num) + this.method_528().ToString() + BookmarkStart.b("ἰ圲娴吶吸", num));

                    case 10:
                        return (BookmarkStart.b("簰娲嘴䔶嘸䠺刼夾㕀᱂੄ⅆ⽈≊⹌⩎๐͒㩔⁖㱘⥚൜ぞࡠൢᅤ㡦⑨੪๬ᵮṰ干ぴ᥶ᡸ᥺ᅼ᩾\udc82\ud584ﺖ", num) + this.method_528().ToString() + BookmarkStart.b("ἰ䌲䔴䌶吸", num));

                    case 11:
                        return (BookmarkStart.b("簰娲嘴䔶嘸䠺刼夾㕀᱂੄ⅆ⽈≊⹌⩎๐͒㩔⁖㱘⥚൜ぞࡠൢᅤ㡦⑨੪๬ᵮṰ干ぴ᥶ᡸ᥺ᅼ᩾\udc82\ud684", num) + this.method_528().ToString() + BookmarkStart.b("ἰ䀲头匶吸", num));

                    case 12:
                        return (BookmarkStart.b("簰娲嘴䔶嘸䠺刼夾㕀᱂੄ⅆ⽈≊⹌⩎๐͒㩔⁖㱘⥚൜ぞࡠൢᅤ㡦㩨ݪѬ୮ᑰ", num) + this.method_528().ToString() + BookmarkStart.b("ἰ䀲头匶䄸", num));

                    case 13:
                        return (BookmarkStart.b("簰娲嘴䔶嘸䠺刼夾㕀᱂ፄ⹆㩈≊≌၎๐౒", num) + this.method_528().ToString() + BookmarkStart.b("ἰ䔲䘴匶䄸", num));
                }
            }
        }
        return (BookmarkStart.b("帰弲倴砶嬸儺堼尾㕀", num) + this.method_528().ToString() + BookmarkStart.b("ἰ儲尴夶", num));
    }

    private string method_298(OleObjectType A_0)
    {
        int num = 0x12;
        string key = Class1117.smethod_1(A_0, false);
        if (key != null)
        {
            int num2;
            if (Class1160.dictionary_40 == null)
            {
                Dictionary<string, int> dictionary1 = new Dictionary<string, int>(10);
                dictionary1.Add(BookmarkStart.b("紷䈹弻嬽ⰿ汁ᝃ⹅ⵇ⽉㡋恍慏恑", num), 0);
                dictionary1.Add(BookmarkStart.b("紷䈹弻嬽ⰿ汁ᝃ⹅ⵇ⽉㡋్㥏㱑㕓⑕⅗᝙㵛㵝቟ൡⅣࡥ१ࡩk୭ᑯ山䕳䑵", num), 1);
                dictionary1.Add(BookmarkStart.b("样唹䬻嬽㈿ቁ⭃⽅♇㹉手ᵍ㡏㵑⍓硕楗桙", num), 2);
                dictionary1.Add(BookmarkStart.b("漷唹主娽渿ف⭃╅㵇❉⥋⁍⑏籑敓摕", num), 3);
                dictionary1.Add(BookmarkStart.b("漷唹主娽渿ف⭃╅㵇❉⥋⁍⑏ὑ㕓㕕⩗㕙ᥛそşaࡣͥ౧䑩嵫屭", num), 4);
                dictionary1.Add(BookmarkStart.b("紷䈹弻嬽ⰿ汁ᝃ⹅ⵇ⽉㡋͍ㅏㅑ♓㥕ᵗ㑙㵛㱝౟ݡc䡥奧塩", num), 5);
                dictionary1.Add(BookmarkStart.b("样唹䬻嬽㈿ቁ⭃⽅♇㹉手ᵍ㡏㵑⍓᭕㥗㥙⹛ㅝ╟ౡգѥѧཀྵ࡫䁭䅯䁱", num), 6);
                dictionary1.Add(BookmarkStart.b("样唹䬻嬽㈿ቁ⭃⽅♇㹉手ᵍ㱏㭑こ㍕ᕗ㭙㽛ⱝཟ❡੣ݥ੧٩५੭幯䍱䙳", num), 7);
                dictionary1.Add(BookmarkStart.b("样唹䬻嬽㈿ቁ⭃⽅♇㹉手ᵍ㱏㭑こ㍕癗歙湛", num), 8);
                dictionary1.Add(BookmarkStart.b("渷匹伻圽⼿汁C㑅⥇㵉╋⁍㝏籑敓捕", num), 9);
                Class1160.dictionary_40 = dictionary1;
            }
            if (Class1160.dictionary_40.TryGetValue(key, out num2))
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
                    case 7:
                    case 8:
                    case 9:
                        return BookmarkStart.b("倷丹䠻丽稿流歃㕅⭇≉⥋⍍ㅏ⅑穓㥕⡗㽙㉛♝ൟ๡ɣ॥ᩧݩ൫ᩭͯ山᭳ѵί啹፻᡽첇ﮍﶏ望랗ꢙ겛꺝隟趡횣쎥쒧쮩\ud8ab\uc7ad\udfaf\udcb1잳\udeb5\ud1b7쪹쾻醽낿ꏁꟃ귅꧇귉꧋", num);
                }
            }
        }
        return BookmarkStart.b("倷丹䠻丽稿流歃㕅⭇≉⥋⍍ㅏ⅑穓㥕⡗㽙㉛♝ൟ๡ɣ॥ᩧݩ൫ᩭͯ山᭳ѵί啹፻᡽첇ﮍﶏ望랗ꢙ겛꺝隟趡횣쎥쒧쮩\ud8ab\uc7ad\udfaf\udcb1잳\udeb5\ud1b7쪹쾻醽꾿껁ꇃ觅꫇ꃉ꧋귍꓏", num);
    }

    private string method_299(DocPicture A_0)
    {
        int num2 = 13;
        if (A_0.TextWrappingStyle == TextWrappingStyle.Inline)
        {
            string str = string.Empty;
            float num = (A_0.Width * A_0.WidthScale) / 100f;
            str = (BookmarkStart.b("䐲尴匶䴸区ܼ", num2) + num.ToString().Replace(BookmarkStart.b("ἲ", num2), BookmarkStart.b("ᴲ", num2)) + BookmarkStart.b("䌲䄴", num2)) + BookmarkStart.b("࠲", num2);
            num = (A_0.Height * A_0.HeightScale) / 100f;
            return (str + BookmarkStart.b("嬲倴帶常区䤼Ծ", num2) + num.ToString().Replace(BookmarkStart.b("ἲ", num2), BookmarkStart.b("ᴲ", num2)) + BookmarkStart.b("䌲䄴", num2));
        }
        return this.method_358(A_0);
    }

    internal List<string> method_3()
    {
        if (this.list_6 == null)
        {
            this.list_6 = new List<string>();
        }
        return this.list_6;
    }

    public bool method_30()
    {
        return this.bool_5;
    }

    private void method_300(XmlNode A_0)
    {
        int num = 1;
        XmlNode node = Class865.smethod_0(A_0, BookmarkStart.b("栦攨渪戬䴮嬰嘲嘴䌶", 1));
        if (A_0 != null)
        {
            XmlAttribute attribute = node.Attributes[BookmarkStart.b("眦嬨䐪䨬昮田", num)];
            if (attribute != null)
            {
                this.method_302(attribute.Value);
            }
        }
    }

    private void method_301(Stream A_0)
    {
        int num = 15;
        XmlReader reader = Class57.smethod_18(A_0);
        reader.ReadToFollowing(BookmarkStart.b("稴笶簸琺弼唾⑀⁂ㅄ", 15), this.dictionary_32[BookmarkStart.b("娴", 15)]);
        if (reader.LocalName == BookmarkStart.b("稴笶簸琺弼唾⑀⁂ㅄ", 15))
        {
            string attribute = reader.GetAttribute(BookmarkStart.b("攴䔶嘸尺琼笾", num));
            if (attribute != null)
            {
                reader.ReadOuterXml();
                this.method_302(attribute);
            }
        }
    }

    private void method_302(string A_0)
    {
        int num = 6;
        string item = null;
        string key = A_0;
        if (key != null)
        {
            int num2;
            if (Class1160.dictionary_41 == null)
            {
                Dictionary<string, int> dictionary1 = new Dictionary<string, int>(14);
                dictionary1.Add(BookmarkStart.b("椫嘭匯圱堳ᠵ笷刹崻䰽㐿汁籃", num), 0);
                dictionary1.Add(BookmarkStart.b("椫嘭匯圱堳ᠵ欷刹夻嬽㐿汁籃", num), 1);
                dictionary1.Add(BookmarkStart.b("椫嘭匯圱堳ᠵ欷刹夻嬽㐿汁畃瑅", num), 2);
                dictionary1.Add(BookmarkStart.b("椫嘭匯圱堳ᠵ欷刹夻嬽㐿Aⵃ⡅⥇㡉㕋͍ㅏㅑ♓㥕ᵗ㑙㵛㱝౟ݡc䡥奧塩", num), 3);
                dictionary1.Add(BookmarkStart.b("椫嘭匯圱堳ᠵ欷刹夻嬽㐿ཁ╃╅㩇╉ो⁍ㅏけ㡓㍕㱗瑙浛汝", num), 4);
                dictionary1.Add(BookmarkStart.b("簫䄭䜯圱䘳昵圷匹刻䨽渿ᅁⱃ⥅㽇摉瑋", num), 5);
                dictionary1.Add(BookmarkStart.b("簫䄭䜯圱䘳昵圷匹刻䨽渿ᅁⱃ⥅㽇摉絋籍", num), 6);
                dictionary1.Add(BookmarkStart.b("笫䄭䈯嘱ᨳ爵圷夹䤻匽┿ⱁぃ桅灇", num), 7);
                dictionary1.Add(BookmarkStart.b("笫䄭䈯嘱ᨳ爵圷夹䤻匽┿ⱁぃ桅祇硉", num), 8);
                dictionary1.Add(BookmarkStart.b("笫䄭䈯嘱ᨳ爵圷夹䤻匽┿ⱁぃ୅⥇⥉㹋⅍ᕏ㱑㕓㑕㑗㽙㡛灝兟偡", num), 9);
                dictionary1.Add(BookmarkStart.b("簫䄭䜯圱䘳昵圷匹刻䨽渿ᅁⱃ⥅㽇݉ⵋⵍ≏㵑ᅓ㡕㥗㡙せ㭝џ䱡啣呥", num), 10);
                dictionary1.Add(BookmarkStart.b("簫䄭䜯圱䘳昵圷匹刻䨽渿ᅁ⡃⽅ⱇ⽉ŋ⽍㍏⁑㭓ፕ㙗㭙㹛㉝՟١䩣坥婧", num), 11);
                dictionary1.Add(BookmarkStart.b("簫䄭䜯圱䘳昵圷匹刻䨽渿ᅁ⡃⽅ⱇ⽉手罍扏", num), 12);
                dictionary1.Add(BookmarkStart.b("稫䜭䌯嬱嬳ᠵ簷䠹崻䤽⤿ⱁ⍃桅祇罉", num), 13);
                Class1160.dictionary_41 = dictionary1;
            }
            if (Class1160.dictionary_41.TryGetValue(key, out num2))
            {
                switch (num2)
                {
                    case 0:
                    case 1:
                        item = BookmarkStart.b("䴫席䀯帱崳唵夷丹唻儽⸿流㉃⡅ⱇ摉⅋㵍絏㝑ⱓ㕕㵗㙙", num);
                        goto Label_0250;

                    case 2:
                        item = BookmarkStart.b("䴫席䀯帱崳唵夷丹唻儽⸿流㉃⡅ⱇ摉⍋㹍㕏㱑ⱓ㭕㑗㱙㍛ⱝൟ͡ၣᕥ䕧թ੫࡭᥯ᅱᅳት᝷᥹ॻ፽ꢅﮇ憎ﺋﺕﶗﾙ첟財힣캥춧쾩\ud8ab", num);
                        goto Label_0250;

                    case 3:
                        item = BookmarkStart.b("䴫席䀯帱崳唵夷丹唻儽⸿流㉃⡅ⱇ摉⅋㵍絏㝑ⱓ㕕㵗㙙牛ⵝ࡟ݡţብ䙧ࡩիmᅯq൳塵ᕷ᭹ύ౽잁뺏ꎑꚓ", num);
                        goto Label_0250;

                    case 4:
                        item = BookmarkStart.b("䴫席䀯帱崳唵夷丹唻儽⸿流㉃⡅ⱇ摉⅋㵍絏㝑ⱓ㕕㵗㙙牛ⵝ࡟ݡţብ䙧ݩ൫൭ɯᵱㅳᡵ᥷᡹ၻ᭽겁떃뒅", num);
                        goto Label_0250;

                    case 5:
                        item = BookmarkStart.b("䴫席䀯帱崳唵夷丹唻儽⸿流㉃⡅ⱇ摉⅋㵍絏≑㭓⅕㵗⡙ⱛㅝय़ౡၣ", num);
                        goto Label_0250;

                    case 6:
                        item = BookmarkStart.b("䴫席䀯帱崳唵夷丹唻儽⸿流㉃⡅ⱇ摉⍋㹍㕏㱑ⱓ㭕㑗㱙㍛ⱝൟ͡ၣᕥ䕧թ੫࡭᥯ᅱᅳት᝷᥹ॻ፽ꢅﶍﲑ춟캡誣횥\udaa7\ucfa9\udfab\ucbad\udeaf\uc6b1햳습톷햹튻", num);
                        goto Label_0250;

                    case 7:
                        item = BookmarkStart.b("䴫席䀯帱崳唵夷丹唻儽⸿流⥃㕅㽇╉㹋⩍", num);
                        goto Label_0250;

                    case 8:
                        item = BookmarkStart.b("䴫席䀯帱崳唵夷丹唻儽⸿流㉃⡅ⱇ摉⍋㹍㕏㱑ⱓ㭕㑗㱙㍛ⱝൟ͡ၣᕥ䕧թ੫࡭᥯ᅱᅳት᝷᥹ॻ፽ꢅﾇﺋﮓﶗ캟얡즣쪥蚧캩쎫춭얯\udfb1\ud1b3\ud8b5\uccb7", num);
                        goto Label_0250;

                    case 9:
                        item = BookmarkStart.b("䴫席䀯帱崳唵夷丹唻儽⸿流㉃⡅ⱇ摉⅋㵍絏║㭓⑕㱗瑙㡛ㅝ͟ᝡॣͥ٧ṩ䉫ͭᅯᅱٳ᥵㵷ᑹᵻᱽꢅ릇뢉", num);
                        goto Label_0250;

                    case 10:
                        item = BookmarkStart.b("䴫席䀯帱崳唵夷丹唻儽⸿流㉃⡅ⱇ摉⅋㵍絏≑㭓⅕㵗⡙ⱛㅝय़ౡၣ䡥ᡧᡩ५ᵭᕯᱱs᝵౷፹፻ၽ깿慎즋ﲗ뒙궛겝", num);
                        goto Label_0250;

                    case 11:
                        item = BookmarkStart.b("䴫席䀯帱崳唵夷丹唻儽⸿流㉃⡅ⱇ摉⅋㵍絏≑㭓⅕㵗⡙ⱛㅝय़ౡၣ䡥᭧٩ի੭ᕯ山ᥳ᝵᭷ࡹ፻㭽ꊋ뾍ꊏ", num);
                        goto Label_0250;

                    case 12:
                        item = BookmarkStart.b("䴫席䀯帱崳唵夷丹唻儽⸿流㉃⡅ⱇ摉⍋㹍㕏㱑ⱓ㭕㑗㱙㍛ⱝൟ͡ၣᕥ䕧թ੫࡭᥯ᅱᅳት᝷᥹ॻ፽ꢅﶍﲑ춟캡誣향쒧쎩좫쮭", num);
                        goto Label_0250;

                    case 13:
                        item = BookmarkStart.b("䴫席䀯帱崳唵夷丹唻儽⸿流㉃⡅ⱇ摉⅋㵍絏⑑㵓╕ㅗ㕙牛㩝቟͡፣ཥ٧൩", num);
                        goto Label_0250;
                }
            }
        }
        item = BookmarkStart.b("䴫席䀯帱崳唵夷丹唻儽⸿流㉃⡅ⱇ摉⍋㹍㕏㱑ⱓ㭕㑗㱙㍛ⱝൟ͡ၣᕥ䕧թ੫࡭᥯ᅱᅳት᝷᥹ॻ፽ꢅ속", num);
    Label_0250:
        if ((item != null) && !this.method_19().Contains(item))
        {
            this.method_19().Add(item);
        }
    }

    private void method_303(Symbol A_0)
    {
        this.class1092_0.method_10(BookmarkStart.b("䬸", 0x13), this.dictionary_32[BookmarkStart.b("丸", 0x13)]);
        this.method_463(A_0.CharacterFormat);
        this.class1092_0.method_10(BookmarkStart.b("䨸䈺值", 0x13), this.dictionary_32[BookmarkStart.b("丸", 0x13)]);
        this.class1092_0.method_5(BookmarkStart.b("娸区尼䴾", 0x13), this.dictionary_32[BookmarkStart.b("丸", 0x13)], BookmarkStart.b("缸଺", 0x13) + Convert.ToString(A_0.CharacterCode, 0x10).ToUpper());
        this.class1092_0.method_5(BookmarkStart.b("弸吺匼䬾", 0x13), this.dictionary_32[BookmarkStart.b("丸", 0x13)], A_0.FontName);
        if (this.list_4 == null)
        {
            this.list_4 = new List<string>();
        }
        if (!this.list_4.Contains(A_0.FontName))
        {
            this.list_4.Add(A_0.FontName);
        }
        this.class1092_0.method_12();
        this.class1092_0.method_12();
    }

    private void method_304(MergeField A_0)
    {
        int num = 12;
        if (!A_0.IsSkip)
        {
            if ((A_0.IsToTextOfMergeFieldEvent && A_0.ConvertedToText) && (A_0.Text != null))
            {
                this.method_308(A_0);
            }
            else if (A_0.ConvertedToText && (A_0.Text != null))
            {
                this.method_309(A_0);
            }
            else if (A_0.CharacterFormat.IsDefault)
            {
                this.class1092_0.method_10(BookmarkStart.b("吱堳刵欷匹儻丽ⰿ❁", num), this.dictionary_32[BookmarkStart.b("䔱", num)]);
                this.method_306(A_0);
                if (A_0.TextItems.Count > 0)
                {
                    int num2 = 0;
                    int count = A_0.TextItems.Count;
                    while (num2 < count)
                    {
                        this.method_380(A_0.TextItems[num2]);
                        num2++;
                    }
                }
                else
                {
                    this.class1092_0.method_10(BookmarkStart.b("䀱", num), this.dictionary_32[BookmarkStart.b("䔱", num)]);
                    this.method_463(A_0.CharacterFormat);
                    this.method_382(A_0.Text, false);
                    this.class1092_0.method_12();
                }
                this.class1092_0.method_12();
            }
            else
            {
                this.method_216();
                this.class1092_0.method_10(BookmarkStart.b("䀱", num), this.dictionary_32[BookmarkStart.b("䔱", num)]);
                this.method_463(A_0.CharacterFormat);
                if (A_0.CharacterFormat.IsDeleteRevision)
                {
                    this.class1092_0.method_10(BookmarkStart.b("嘱儳娵焷吹伻䨽㈿ᙁ⅃㹅㱇", num), this.dictionary_32[BookmarkStart.b("䔱", num)]);
                }
                else
                {
                    this.class1092_0.method_10(BookmarkStart.b("嬱娳䔵䰷䠹栻嬽㠿㙁", num), this.dictionary_32[BookmarkStart.b("䔱", num)]);
                }
                this.class1092_0.method_6(BookmarkStart.b("䨱夳娵", num), BookmarkStart.b("䄱䐳圵嬷弹", num), BookmarkStart.b("娱䀳䈵䠷9ጻᄽ㜿㕁㍃桅㽇祉手⅍≏㕑筓๕ᕗᙙ獛潝奟孡屣䥥٧୩ū୭ͯɱᕳᕵᵷ", num), BookmarkStart.b("䈱䘳匵䬷弹主䠽┿", num));
                this.class1092_0.method_21(this.method_305(A_0));
                this.class1092_0.method_12();
                this.class1092_0.method_12();
                this.method_213();
                if (A_0.TextItems.Count > 0)
                {
                    int num4 = 0;
                    int num5 = A_0.TextItems.Count;
                    while (num4 < num5)
                    {
                        this.method_380(A_0.TextItems[num4]);
                        num4++;
                    }
                }
                else
                {
                    this.class1092_0.method_10(BookmarkStart.b("䀱", num), this.dictionary_32[BookmarkStart.b("䔱", num)]);
                    this.method_463(A_0.CharacterFormat);
                    this.method_382(A_0.Text, false);
                    this.class1092_0.method_12();
                }
                this.method_214();
            }
        }
    }

    private string method_305(MergeField A_0)
    {
        int num = 14;
        StringBuilder builder = new StringBuilder();
        builder.Append(BookmarkStart.b("ᐳ笵紷根笻笽ؿୁŃ੅ే橉", 14));
        if (A_0.Prefix != string.Empty)
        {
            builder.AppendFormat(A_0.Prefix, new object[0]);
            builder.Append(BookmarkStart.b("ำ", num));
        }
        builder.Append(A_0.FieldName);
        if (A_0.TextBefore != string.Empty)
        {
            builder.Append(BookmarkStart.b("ᐳ", num) + this.string_0 + BookmarkStart.b("嘳ᘵ", num));
            builder.Append(A_0.TextBefore);
        }
        if (A_0.TextAfter != string.Empty)
        {
            builder.Append(BookmarkStart.b("ᐳ", num) + this.string_0 + BookmarkStart.b("刳ᘵ", num));
            builder.Append(A_0.TextAfter);
        }
        if (!string.IsNullOrEmpty(A_0.DateFormat))
        {
            builder.Append(BookmarkStart.b("ᐳ", num) + this.string_0 + BookmarkStart.b("琳ᘵ", num));
            builder.Append(this.string_1 + A_0.DateFormat + this.string_1);
        }
        if (!string.IsNullOrEmpty(A_0.NumberFormat))
        {
            builder.Append(BookmarkStart.b("ᐳ", num) + this.string_0 + BookmarkStart.b("ᜳᘵ", num));
            builder.Append(this.string_1 + A_0.NumberFormat + this.string_1);
        }
        if (A_0.TextFormat != TextFormat.None)
        {
            builder.Append(BookmarkStart.b("ᐳ", num) + this.string_0 + BookmarkStart.b("ḳᘵ", num));
            builder.Append(this.method_307(A_0.TextFormat));
        }
        builder.Append(A_0.FormattingString);
        return builder.ToString();
    }

    private void method_306(MergeField A_0)
    {
        this.class1092_0.method_5(BookmarkStart.b("䄧䐩弫娭䈯", 2), this.dictionary_32[BookmarkStart.b("弧", 2)], this.method_305(A_0));
    }

    private string method_307(TextFormat A_0)
    {
        int num = 4;
        switch (A_0)
        {
            case TextFormat.Uppercase:
                return BookmarkStart.b("缩尫席唯䀱", num);

            case TextFormat.Lowercase:
                return BookmarkStart.b("昩䌫夭唯䀱", num);

            case TextFormat.FirstCapital:
                return BookmarkStart.b("氩䔫尭䌯䘱眳圵䠷", num);

            case TextFormat.Titlecase:
                return BookmarkStart.b("椩䴫席䌯", num);
        }
        return "";
    }

    private void method_308(MergeField A_0)
    {
        int num = 13;
        if (!string.IsNullOrEmpty(A_0.Text))
        {
            this.class1092_0.method_10(BookmarkStart.b("䄲", num), this.dictionary_32[BookmarkStart.b("䐲", num)]);
            this.method_463(A_0.CharacterFormat);
            if (!string.IsNullOrEmpty(A_0.TextBefore))
            {
                this.class1092_0.method_10(BookmarkStart.b("䜲", num), this.dictionary_32[BookmarkStart.b("䐲", num)]);
                this.class1092_0.method_6(BookmarkStart.b("䬲場嬶", num), BookmarkStart.b("䀲䔴嘶娸帺", num), BookmarkStart.b("嬲䄴䌶䤸ĺሼှ㙀㑂㉄楆㹈硊捌⁎⍐㑒穔བᑘ᝚牜湞塠婢嵤䡦ݨ੪l੮ɰͲᑴᑶᱸ", num), BookmarkStart.b("䌲䜴制䨸帺似䤾⑀", num));
                this.class1092_0.method_21(A_0.TextBefore);
                this.class1092_0.method_12();
            }
            this.class1092_0.method_10(BookmarkStart.b("䜲", num), this.dictionary_32[BookmarkStart.b("䐲", num)]);
            this.class1092_0.method_6(BookmarkStart.b("䬲場嬶", num), BookmarkStart.b("䀲䔴嘶娸帺", num), BookmarkStart.b("嬲䄴䌶䤸ĺሼှ㙀㑂㉄楆㹈硊捌⁎⍐㑒穔བᑘ᝚牜湞塠婢嵤䡦ݨ੪l੮ɰͲᑴᑶᱸ", num), BookmarkStart.b("䌲䜴制䨸帺似䤾⑀", num));
            this.class1092_0.method_21(A_0.Text);
            this.class1092_0.method_12();
            if (!string.IsNullOrEmpty(A_0.TextAfter))
            {
                this.class1092_0.method_10(BookmarkStart.b("䜲", num), this.dictionary_32[BookmarkStart.b("䐲", num)]);
                this.class1092_0.method_6(BookmarkStart.b("䬲場嬶", num), BookmarkStart.b("䀲䔴嘶娸帺", num), BookmarkStart.b("嬲䄴䌶䤸ĺሼှ㙀㑂㉄楆㹈硊捌⁎⍐㑒穔བᑘ᝚牜湞塠婢嵤䡦ݨ੪l੮ɰͲᑴᑶᱸ", num), BookmarkStart.b("䌲䜴制䨸帺似䤾⑀", num));
                this.class1092_0.method_21(A_0.TextAfter);
                this.class1092_0.method_12();
            }
            this.class1092_0.method_12();
        }
    }

    private void method_309(MergeField A_0)
    {
        int num = 0;
        if (!string.IsNullOrEmpty(A_0.Text))
        {
            if (this.method_547(A_0.Text).IndexOf(Class816.string_27) != -1)
            {
                A_0.Text = A_0.method_241();
                if (!string.IsNullOrEmpty(A_0.TextBefore))
                {
                    this.class1092_0.method_10(BookmarkStart.b("吥", num), this.dictionary_32[BookmarkStart.b("儥", num)]);
                    this.method_463(A_0.CharacterFormat);
                    this.class1092_0.method_10(BookmarkStart.b("別", num), this.dictionary_32[BookmarkStart.b("儥", num)]);
                    this.class1092_0.method_6(BookmarkStart.b("帥䔧䘩", num), BookmarkStart.b("唥堧䬩伫䬭", num), BookmarkStart.b("严尧帩尫ᐭἯᴱ䌳䄵伷ᐹ䬻ഽ渿ⵁ㙃ⅅ杇቉ŋɍ罏捑浓潕恗留㉛㽝ൟݡᝣᙥ१३५", num), BookmarkStart.b("嘥娧伩弫䬭䈯䐱儳", num));
                    this.class1092_0.method_21(A_0.TextBefore);
                    this.class1092_0.method_12();
                    this.class1092_0.method_12();
                }
                if (!string.IsNullOrEmpty(A_0.TextAfter))
                {
                    A_0.Text = A_0.Text + A_0.TextAfter;
                    A_0.TextAfter = string.Empty;
                }
                this.method_380(A_0);
            }
            else
            {
                string str2 = A_0.TextBefore + A_0.Text + A_0.TextAfter;
                str2 = A_0.method_240(str2);
                this.class1092_0.method_10(BookmarkStart.b("吥", num), this.dictionary_32[BookmarkStart.b("儥", num)]);
                this.method_463(A_0.CharacterFormat);
                this.method_382(str2, A_0.CharacterFormat.IsDeleteRevision);
                this.class1092_0.method_12();
            }
        }
    }

    public void method_31(bool A_0)
    {
        this.bool_5 = A_0;
    }

    private void method_310(FieldMark A_0)
    {
        int num = 7;
        Field field = this.method_551(A_0) as Field;
        if ((field == null) || ((field != null) && (((((field.Type != FieldType.FieldDatabase) && (field.Type != FieldType.FieldNext)) && ((field.Type != FieldType.FieldSkipIf) && (field.Type != FieldType.FieldShape))) && ((field.Type != FieldType.FieldHyperlink) && (field.Type != FieldType.FieldFileName))) || ((field.Type == FieldType.FieldHyperlink) && !this.method_312(field)))))
        {
            this.class1092_0.method_11(BookmarkStart.b("娬", num), BookmarkStart.b("弬", num), this.dictionary_32[BookmarkStart.b("娬", num)]);
            if (A_0.CharacterFormat.IsDefault && (field != null))
            {
                A_0.CharacterFormat.ImportContainer(field.CharacterFormat);
                A_0.CharacterFormat.method_21(field.CharacterFormat);
            }
            CharacterFormat format = (this.method_48() != null) ? this.method_48().CharacterFormat : A_0.CharacterFormat;
            this.method_463(format);
            this.class1092_0.method_11(BookmarkStart.b("娬", num), BookmarkStart.b("䬬䌮唰瀲崴嘶䬸", num), this.dictionary_32[BookmarkStart.b("娬", num)]);
            string str = (A_0.Type == FieldMarkType.FieldSeparator) ? BookmarkStart.b("帬䨮䄰刲䜴嘶䴸帺", num) : BookmarkStart.b("䠬䄮唰", num);
            this.class1092_0.method_6(BookmarkStart.b("娬", num), BookmarkStart.b("䬬䌮唰瀲崴嘶䬸漺䐼伾⑀", num), this.dictionary_32[BookmarkStart.b("娬", num)], str);
            this.class1092_0.method_12();
            this.class1092_0.method_12();
            if (((field != null) && (field.Type == FieldType.FieldFormTextInput)) && (A_0.Type == FieldMarkType.FieldSeparator))
            {
                TextFormField field2 = field as TextFormField;
                if (((field2 != null) && (this.method_48().Document.DetectedFormatType != FileFormat.Rtf)) && ((field2.Range.Count < 3) || ((field2.Range.Count == 3) && field2.IsDefaultText)))
                {
                    this.method_236(field2);
                }
            }
        }
        if (((A_0.Type == FieldMarkType.FieldEnd) && (this.stack_0 != null)) && (this.stack_0.Count > 0))
        {
            this.stack_0.Pop();
        }
        if ((A_0.Type == FieldMarkType.FieldEnd) && (this.method_48() != null))
        {
            this.method_47().Pop();
        }
    }

    private bool method_311(ParagraphBase A_0)
    {
        Field field = this.method_551(A_0) as Field;
        if (field == null)
        {
            return false;
        }
        if ((field.Type == FieldType.FieldHyperlink) && field.IsInSamePara)
        {
            return (field.Code == field.method_177());
        }
        return this.method_311(field);
    }

    private bool method_312(ParagraphBase A_0)
    {
        Field field = A_0 as Field;
        if (((field == null) || (field.Type != FieldType.FieldHyperlink)) || !field.IsInSamePara)
        {
            return false;
        }
        string b = field.method_177();
        return string.Equals(field.Code, b);
    }

    private void method_313(DocPicture A_0)
    {
        int num = 12;
        if ((!A_0.SkipDocxItem && A_0.HasImage) && ((!this.method_314(A_0) && (A_0.Width > 0f)) && (A_0.Height > 0f)))
        {
            this.class1092_0.method_10(BookmarkStart.b("䀱", num), this.dictionary_32[BookmarkStart.b("䔱", num)]);
            this.method_463(A_0.CharacterFormat);
            if (A_0.IsShape)
            {
                this.class1092_0.method_10(BookmarkStart.b("猱堳䈵崷䠹刻弽㐿❁݃⥅♇㹉⥋⁍⑏", num), this.dictionary_32[BookmarkStart.b("䐱儳", num)]);
                this.class1092_0.method_10(BookmarkStart.b("焱尳夵儷夹夻", num), this.dictionary_32[BookmarkStart.b("䐱儳", num)]);
                this.class1092_0.method_4(BookmarkStart.b("怱儳䜵䴷匹主嬽㌿", num), BookmarkStart.b("䔱䐳䔵", num));
            }
            this.method_315(A_0);
            if (A_0.IsShape)
            {
                this.class1092_0.method_12();
                this.class1092_0.method_10(BookmarkStart.b("琱唳娵吷堹崻崽⬿", num), this.dictionary_32[BookmarkStart.b("䐱儳", num)]);
                this.method_344(A_0);
                this.class1092_0.method_12();
                this.class1092_0.method_12();
            }
            this.class1092_0.method_12();
        }
    }

    private bool method_314(DocPicture A_0)
    {
        int num = 9;
        ParagraphItemCollection items = null;
        if (A_0.Owner is Paragraph)
        {
            items = (A_0.Owner as Paragraph).Items;
        }
        else if (A_0.Owner is SDTInlineContent)
        {
            items = (A_0.Owner as SDTInlineContent).Items;
        }
        if (items != null)
        {
            bool flag;
            using (IEnumerator enumerator = items.GetEnumerator())
            {
                while (enumerator.MoveNext())
                {
                    ParagraphBase current = (ParagraphBase) enumerator.Current;
                    BookmarkStart start = current as BookmarkStart;
                    if ((start != null) && (start.Name == BookmarkStart.b("瀮愰娲嘴䌶䰸䤺堼紾㑀⽂⥄≆㵈㡊", num)))
                    {
                        goto Label_008E;
                    }
                }
                goto Label_00AA;
            Label_008E:
                flag = true;
            }
            return flag;
        }
    Label_00AA:
        return false;
    }

    private void method_315(DocPicture A_0)
    {
        int num = 4;
        if (A_0.ImageBytes != null)
        {
            this.class1092_0.method_10(BookmarkStart.b("丩師伭䜯嬱娳儵", num), this.dictionary_32[BookmarkStart.b("崩", num)]);
            if (A_0.TextWrappingStyle == TextWrappingStyle.Behind)
            {
                A_0.IsUnderText = true;
            }
            if (A_0.TextWrappingStyle != TextWrappingStyle.Inline)
            {
                this.method_319(A_0);
            }
            else
            {
                this.method_316(A_0);
            }
            this.class1092_0.method_12();
        }
    }

    private void method_316(DocPicture A_0)
    {
        this.class1092_0.method_10(BookmarkStart.b("䐬䄮崰娲嬴制", 7), this.dictionary_32[BookmarkStart.b("娬弮", 7)]);
        this.class1092_0.method_10(BookmarkStart.b("䠬圮䔰嘲嬴䌶", 7), this.dictionary_32[BookmarkStart.b("娬弮", 7)]);
        this.class1092_0.method_4(BookmarkStart.b("丬圮", 7), ((int) Math.Round((double) (((A_0.Width * A_0.WidthScale) / 100f) * 12700f))).ToString());
        this.class1092_0.method_4(BookmarkStart.b("丬嘮", 7), ((int) Math.Round((double) (((A_0.Height * A_0.HeightScale) / 100f) * 12700f))).ToString());
        this.class1092_0.method_12();
        this.class1092_0.method_10(BookmarkStart.b("䠬䤮地嘲嘴䌶簸䌺䤼娾⽀㝂", 7), this.dictionary_32[BookmarkStart.b("娬弮", 7)]);
        this.class1092_0.method_4(BookmarkStart.b("䄬", 7), ((int) Math.Round((double) (A_0.EffectExtentLeft * 12700f))).ToString());
        this.class1092_0.method_4(BookmarkStart.b("夬", 7), ((int) Math.Round((double) (A_0.EffectExtentTop * 12700f))).ToString());
        this.class1092_0.method_4(BookmarkStart.b("弬", 7), ((int) Math.Round((double) (A_0.EffectExtentRight * 12700f))).ToString());
        this.class1092_0.method_4(BookmarkStart.b("伬", 7), ((int) Math.Round((double) (A_0.EffectExtentBottom * 12700f))).ToString());
        this.class1092_0.method_12();
        this.method_321(A_0);
        this.method_322(A_0);
        this.method_320(A_0);
        this.class1092_0.method_12();
    }

    private void method_317(DocPicture A_0)
    {
        int num = 1;
        if (A_0 != null)
        {
            this.class1092_0.method_11(BookmarkStart.b("倦夨", num), BookmarkStart.b("䐦木崪樬崮倰䌲崴帶娸紺似帾ⱀ♂ᕄ㕆", num), this.dictionary_32[BookmarkStart.b("倦夨", num)]);
            this.class1092_0.method_11(BookmarkStart.b("䘦", num), BookmarkStart.b("䀦嬨䨪崬䜮堰倲猴䔶堸嘺堼猾⹀⁂⹄㑆", num), this.dictionary_32[BookmarkStart.b("䘦", num)]);
            this.class1092_0.method_4(BookmarkStart.b("䤦䘨株䔬丮弰吲倴瘶䨸䬺堼尾㕀", num), A_0.LockAspectRatio ? BookmarkStart.b("ᘦ", num) : BookmarkStart.b("ᜦ", num));
            this.class1092_0.method_12();
            this.class1092_0.method_12();
        }
    }

    private string method_318(long A_0)
    {
        A_0 = (A_0 < 0L) ? (Math.Abs(A_0) + 6L) : A_0;
        A_0 = (A_0 > 0xffffffffL) ? 0xffffffffL : A_0;
        return A_0.ToString(CultureInfo.InvariantCulture);
    }

    private void method_319(DocPicture A_0)
    {
        int num = 0x11;
        this.class1092_0.method_10(BookmarkStart.b("嘶圸堺唼倾㍀", 0x11), this.dictionary_32[BookmarkStart.b("䀶䤸", 0x11)]);
        this.class1092_0.method_4(BookmarkStart.b("匶倸䠺䤼款", 0x11), (A_0.WrapDistanceTop * 12700f).ToString());
        this.class1092_0.method_4(BookmarkStart.b("匶倸䠺䤼紾", 0x11), (A_0.WrapDistanceBottom * 12700f).ToString());
        this.class1092_0.method_4(BookmarkStart.b("匶倸䠺䤼猾", 0x11), (A_0.WrapDistanceLeft * 12700f).ToString());
        this.class1092_0.method_4(BookmarkStart.b("匶倸䠺䤼派", 0x11), (A_0.WrapDistanceRight * 12700f).ToString());
        this.class1092_0.method_4(BookmarkStart.b("䐶倸嘺䴼匾⑀ፂ⩄㑆", 0x11), BookmarkStart.b("ܶ", 0x11));
        this.class1092_0.method_4(BookmarkStart.b("䔶尸场尼䬾⡀㕂⁄ཆⱈ≊⩌❎═", 0x11), this.method_318(A_0.OrderIndex));
        string str = (A_0.IsUnderText || (A_0.OrderIndex < 0L)) ? BookmarkStart.b("ض", num) : BookmarkStart.b("ܶ", num);
        this.class1092_0.method_4(BookmarkStart.b("唶尸区吼儾╀݂⩄⑆", num), str);
        this.class1092_0.method_4(BookmarkStart.b("嬶嘸堺嘼娾╀", num), BookmarkStart.b("ܶ", num));
        if (A_0.LayoutInCell)
        {
            this.class1092_0.method_4(BookmarkStart.b("嬶堸䈺刼䨾㕀ੂ⭄цⱈ❊⅌", num), BookmarkStart.b("ض", num));
        }
        else
        {
            this.class1092_0.method_4(BookmarkStart.b("嬶堸䈺刼䨾㕀ੂ⭄цⱈ❊⅌", num), BookmarkStart.b("ܶ", num));
        }
        if (A_0.AllowOverlap)
        {
            this.class1092_0.method_4(BookmarkStart.b("嘶唸场刼䠾เ㕂⁄㕆╈⩊㵌", num), BookmarkStart.b("ض", num));
        }
        else
        {
            this.class1092_0.method_4(BookmarkStart.b("嘶唸场刼䠾เ㕂⁄㕆╈⩊㵌", num), BookmarkStart.b("ܶ", num));
        }
        this.class1092_0.method_10(BookmarkStart.b("䐶倸嘺䴼匾⑀ፂ⩄㑆", num), this.dictionary_32[BookmarkStart.b("䀶䤸", num)]);
        this.class1092_0.method_4(BookmarkStart.b("伶", num), BookmarkStart.b("ܶ", num));
        this.class1092_0.method_4(BookmarkStart.b("丶", num), BookmarkStart.b("ܶ", num));
        this.class1092_0.method_12();
        this.class1092_0.method_10(BookmarkStart.b("䜶嘸䠺吼䬾⡀ⱂ⭄ཆ", num), this.dictionary_32[BookmarkStart.b("䀶䤸", num)]);
        this.class1092_0.method_4(BookmarkStart.b("䔶尸场尼䬾⡀㕂⁄ņ㭈⑊⁌", num), this.method_258(A_0.HorizontalOrigin));
        if (A_0.HorizontalAlignment == ShapeHorizontalAlignment.None)
        {
            this.class1092_0.method_10(BookmarkStart.b("䜶嘸䠺爼夾❀あ⁄㍆", num), this.dictionary_32[BookmarkStart.b("䀶䤸", num)]);
            this.class1092_0.method_21(((int) Math.Round((double) (A_0.HorizontalPosition * 12700f))).ToString());
            this.class1092_0.method_12();
        }
        else
        {
            this.class1092_0.method_10(BookmarkStart.b("嘶唸刺娼儾", num), this.dictionary_32[BookmarkStart.b("䀶䤸", num)]);
            string str2 = this.method_261(A_0.HorizontalAlignment);
            this.class1092_0.method_21(str2);
            this.class1092_0.method_12();
        }
        this.class1092_0.method_12();
        this.class1092_0.method_10(BookmarkStart.b("䜶嘸䠺吼䬾⡀ⱂ⭄ᅆ", num), this.dictionary_32[BookmarkStart.b("䀶䤸", num)]);
        this.class1092_0.method_4(BookmarkStart.b("䔶尸场尼䬾⡀㕂⁄ņ㭈⑊⁌", num), this.method_260(A_0.VerticalOrigin));
        if (A_0.VerticalAlignment == ShapeVerticalAlignment.None)
        {
            this.class1092_0.method_10(BookmarkStart.b("䜶嘸䠺爼夾❀あ⁄㍆", num), this.dictionary_32[BookmarkStart.b("䀶䤸", num)]);
            this.class1092_0.method_21(((int) Math.Round((double) (A_0.VerticalPosition * 12700f))).ToString());
            this.class1092_0.method_12();
        }
        else
        {
            this.class1092_0.method_10(BookmarkStart.b("嘶唸刺娼儾", num), this.dictionary_32[BookmarkStart.b("䀶䤸", num)]);
            string str3 = this.method_262(A_0.VerticalAlignment);
            this.class1092_0.method_21(str3);
            this.class1092_0.method_12();
        }
        this.class1092_0.method_12();
        this.class1092_0.method_10(BookmarkStart.b("制䄸伺堼儾㕀", num), this.dictionary_32[BookmarkStart.b("䀶䤸", num)]);
        this.class1092_0.method_4(BookmarkStart.b("吶䄸", num), ((int) Math.Round((double) (((A_0.Width * A_0.WidthScale) / 100f) * 12700f))).ToString());
        this.class1092_0.method_4(BookmarkStart.b("吶䀸", num), ((int) Math.Round((double) (((A_0.Height * A_0.HeightScale) / 100f) * 12700f))).ToString());
        this.class1092_0.method_12();
        this.class1092_0.method_10(BookmarkStart.b("制弸崺堼尾㕀ق㵄㍆ⱈ╊㥌", num), this.dictionary_32[BookmarkStart.b("䀶䤸", num)]);
        this.class1092_0.method_4(BookmarkStart.b("嬶", num), ((int) Math.Round((double) (A_0.EffectExtentLeft * 12700f))).ToString());
        this.class1092_0.method_4(BookmarkStart.b("䌶", num), ((int) Math.Round((double) (A_0.EffectExtentTop * 12700f))).ToString());
        this.class1092_0.method_4(BookmarkStart.b("䔶", num), ((int) Math.Round((double) (A_0.EffectExtentRight * 12700f))).ToString());
        this.class1092_0.method_4(BookmarkStart.b("唶", num), ((int) Math.Round((double) (A_0.EffectExtentBottom * 12700f))).ToString());
        this.class1092_0.method_12();
        this.method_321(A_0);
        switch (A_0.TextWrappingStyle)
        {
            case TextWrappingStyle.TopAndBottom:
                this.class1092_0.method_10(BookmarkStart.b("䀶䬸娺䴼款⹀㍂ф⥆ⵈॊ≌㭎═㱒㡔", num), this.dictionary_32[BookmarkStart.b("䀶䤸", num)]);
                this.class1092_0.method_12();
                break;

            case TextWrappingStyle.Square:
                this.class1092_0.method_10(BookmarkStart.b("䀶䬸娺䴼氾぀㙂⑄㕆ⱈ", num), this.dictionary_32[BookmarkStart.b("䀶䤸", num)]);
                this.class1092_0.method_4(BookmarkStart.b("䀶䬸娺䴼款⑀㭂ㅄ", num), this.method_354(A_0.TextWrappingType));
                this.class1092_0.method_12();
                break;

            case TextWrappingStyle.Tight:
                this.class1092_0.method_10(BookmarkStart.b("䀶䬸娺䴼款⡀⑂ⵄ㍆", num), this.dictionary_32[BookmarkStart.b("䀶䤸", num)]);
                this.class1092_0.method_4(BookmarkStart.b("䀶䬸娺䴼款⑀㭂ㅄ", num), this.method_354(A_0.TextWrappingType));
                if ((A_0.WrapPolygon != null) && (A_0.WrapPolygon.Length > 0))
                {
                    this.method_243(A_0.WrapPolygon, A_0.IsEditWrapPolygonPoint);
                }
                this.class1092_0.method_12();
                break;

            case TextWrappingStyle.Through:
                this.class1092_0.method_10(BookmarkStart.b("䀶䬸娺䴼款⥀ㅂ⩄㉆⹈⍊", num), this.dictionary_32[BookmarkStart.b("䀶䤸", num)]);
                this.class1092_0.method_4(BookmarkStart.b("䀶䬸娺䴼款⑀㭂ㅄ", num), this.method_354(A_0.TextWrappingType));
                if ((A_0.WrapPolygon != null) && (A_0.WrapPolygon.Length > 0))
                {
                    this.method_243(A_0.WrapPolygon, A_0.IsEditWrapPolygonPoint);
                }
                this.class1092_0.method_12();
                break;

            default:
                this.class1092_0.method_10(BookmarkStart.b("䀶䬸娺䴼焾⹀ⵂ⁄", num), this.dictionary_32[BookmarkStart.b("䀶䤸", num)]);
                this.class1092_0.method_12();
                break;
        }
        this.method_322(A_0);
        this.method_320(A_0);
        this.class1092_0.method_12();
    }

    public bool method_32()
    {
        return this.bool_1;
    }

    private void method_320(DocPicture A_0)
    {
        int num = 0x10;
        if (A_0.WidthPercent > 0f)
        {
            this.class1092_0.method_10(BookmarkStart.b("䔵儷䀹夻氽┿⹁ృ", num), this.dictionary_32[BookmarkStart.b("䄵䠷ହ࠻", num)]);
            this.class1092_0.method_4(BookmarkStart.b("䐵崷嘹崻䨽⤿㑁⅃E㩇╉⅋", num), this.method_257(A_0.RelationWidth));
            this.class1092_0.method_10(BookmarkStart.b("䘵嬷丹欻圽␿㙁ⱃ", num), this.dictionary_32[BookmarkStart.b("䄵䠷ହ࠻", num)]);
            this.class1092_0.method_21((A_0.WidthPercent * 1000f).ToString());
            this.class1092_0.method_12();
            this.class1092_0.method_12();
        }
        if (A_0.HeightPercent > 0f)
        {
            this.class1092_0.method_10(BookmarkStart.b("䔵儷䀹夻氽┿⹁ቃ", num), this.dictionary_32[BookmarkStart.b("䄵䠷ହ࠻", num)]);
            this.class1092_0.method_4(BookmarkStart.b("䐵崷嘹崻䨽⤿㑁⅃E㩇╉⅋", num), this.method_259(A_0.RelationHeight));
            this.class1092_0.method_10(BookmarkStart.b("䘵嬷丹琻嬽⤿╁ⱃ㉅", num), this.dictionary_32[BookmarkStart.b("䄵䠷ହ࠻", num)]);
            this.class1092_0.method_21((A_0.HeightPercent * 1000f).ToString());
            this.class1092_0.method_12();
            this.class1092_0.method_12();
        }
    }

    private void method_321(DocPicture A_0)
    {
        if (A_0.DocxProps.Count > 0)
        {
            foreach (Stream stream in A_0.DocxProps)
            {
                this.method_272(stream);
            }
        }
    }

    private void method_322(DocPicture A_0)
    {
        int num = 0;
        string str = string.Empty;
        str = this.method_335(A_0, false, null);
        int num2 = this.method_545();
        this.class1092_0.method_11(BookmarkStart.b("儥堧", 0), BookmarkStart.b("䈥䜧䤩簫尭", 0), this.dictionary_32[BookmarkStart.b("儥堧", 0)]);
        this.class1092_0.method_4(BookmarkStart.b("伥䰧", 0), num2.ToString());
        this.class1092_0.method_4(BookmarkStart.b("䠥䤧䜩䤫", 0), "");
        if (A_0.AlternativeText != null)
        {
            this.class1092_0.method_4(BookmarkStart.b("䈥䴧天伫尭", num), A_0.AlternativeText);
        }
        this.method_334(A_0);
        this.class1092_0.method_12();
        this.method_317(A_0);
        this.class1092_0.method_11(BookmarkStart.b("䜥", num), BookmarkStart.b("䄥娧䬩尫䘭夯儱", num), this.dictionary_32[BookmarkStart.b("䜥", num)]);
        this.class1092_0.method_11(BookmarkStart.b("䜥", num), BookmarkStart.b("䄥娧䬩尫䘭夯儱瀳圵䰷嬹", num), this.dictionary_32[BookmarkStart.b("䜥", num)]);
        this.class1092_0.method_4(BookmarkStart.b("匥娧䌩", num), this.dictionary_32[BookmarkStart.b("匥娧䌩", num)]);
        this.class1092_0.method_11(BookmarkStart.b("嘥䄧䤩", num), BookmarkStart.b("嘥䄧䤩", num), this.dictionary_32[BookmarkStart.b("嘥䄧䤩", num)]);
        this.class1092_0.method_11(BookmarkStart.b("嘥䄧䤩", num), BookmarkStart.b("䠥帧稩䔫䴭怯䀱", num), this.dictionary_32[BookmarkStart.b("嘥䄧䤩", num)]);
        if (!A_0.PreferRelative)
        {
            this.class1092_0.method_4(BookmarkStart.b("嘥娧伩䨫䬭䈯怱儳娵夷丹唻䠽┿၁⅃㕅ⅇぉ⥋", num), BookmarkStart.b("ᘥ", num));
        }
        this.class1092_0.method_11(BookmarkStart.b("嘥䄧䤩", num), BookmarkStart.b("䔥昧尩簫尭", num), this.dictionary_32[BookmarkStart.b("嘥䄧䤩", num)]);
        this.class1092_0.method_4(BookmarkStart.b("伥䰧", num), BookmarkStart.b("ᘥ", num));
        this.class1092_0.method_4(BookmarkStart.b("䠥䤧䜩䤫", num), "");
        this.class1092_0.method_4(BookmarkStart.b("䈥䴧天伫尭", num), "");
        this.class1092_0.method_12();
        this.class1092_0.method_11(BookmarkStart.b("嘥䄧䤩", num), BookmarkStart.b("䔥昧尩簫䜭匯戱䘳", num), this.dictionary_32[BookmarkStart.b("嘥䄧䤩", num)]);
        if (!A_0.PreferRelative)
        {
            this.class1092_0.method_4(BookmarkStart.b("嘥娧伩䨫䬭䈯怱儳娵夷丹唻䠽┿၁⅃㕅ⅇぉ⥋", num), BookmarkStart.b("ᘥ", num));
        }
        this.class1092_0.method_11(BookmarkStart.b("䜥", num), BookmarkStart.b("嘥䄧䤩怫䄭匯失䜳", num), this.dictionary_32[BookmarkStart.b("䜥", num)]);
        this.class1092_0.method_4(BookmarkStart.b("䠥䜧椩䐫伭帯唱儳眵䬷䨹夻崽㐿", num), BookmarkStart.b("ᜥ", num));
        this.class1092_0.method_4(BookmarkStart.b("䠥䜧椩䐫伭帯唱儳眵䨷䠹医䤽⠿❁╃≅㭇", num), BookmarkStart.b("ᜥ", num));
        this.class1092_0.method_12();
        this.class1092_0.method_12();
        this.class1092_0.method_12();
        this.class1092_0.method_11(BookmarkStart.b("嘥䄧䤩", num), BookmarkStart.b("䐥䐧䌩尫栭夯帱堳", num), this.dictionary_32[BookmarkStart.b("嘥䄧䤩", num)]);
        this.class1092_0.method_11(BookmarkStart.b("䜥", num), BookmarkStart.b("䐥䐧䌩尫", num), this.dictionary_32[BookmarkStart.b("䜥", num)]);
        this.class1092_0.method_6(BookmarkStart.b("吥", num), BookmarkStart.b("䌥䔧䠩䤫䨭", num), this.dictionary_32[BookmarkStart.b("吥", num)], str);
        if ((A_0.AlphaModFix >= 0f) && (A_0.AlphaModFix < 100f))
        {
            this.class1092_0.method_11(BookmarkStart.b("䜥", num), BookmarkStart.b("䜥䐧娩䐫伭累崱倳瀵儷䈹", num), this.dictionary_32[BookmarkStart.b("䜥", num)]);
            this.class1092_0.method_4(BookmarkStart.b("䜥䔧帩", num), (A_0.AlphaModFix * 1000f).ToString());
            this.class1092_0.method_12();
        }
        if ((A_0.Contrast != 0f) || (A_0.Brightness != 0f))
        {
            this.class1092_0.method_11(BookmarkStart.b("䜥", num), BookmarkStart.b("䨥崧䜩", num), this.dictionary_32[BookmarkStart.b("䜥", num)]);
            if (A_0.Brightness != 0f)
            {
                this.class1092_0.method_4(BookmarkStart.b("䐥娧䌩䬫䘭䐯", num), A_0.Brightness.ToString() + BookmarkStart.b("̥", num));
            }
            if (A_0.Contrast != 0f)
            {
                this.class1092_0.method_4(BookmarkStart.b("䔥䜧䐩堫尭儯䄱䀳", num), A_0.Contrast.ToString() + BookmarkStart.b("̥", num));
            }
            this.class1092_0.method_12();
        }
        Color chromaKey = A_0.ChromaKey;
        if (!A_0.ChromaKey.IsEmpty)
        {
            string str2 = this.method_535(A_0.ChromaKey);
            this.class1092_0.method_11(BookmarkStart.b("䜥", num), BookmarkStart.b("䔥䐧堩漫䘭儯就匳匵", num), this.dictionary_32[BookmarkStart.b("䜥", num)]);
            this.class1092_0.method_11(BookmarkStart.b("䜥", num), BookmarkStart.b("䔥䐧堩樫尭弯弱", num), this.dictionary_32[BookmarkStart.b("䜥", num)]);
            this.class1092_0.method_11(BookmarkStart.b("䜥", num), BookmarkStart.b("唥娧䴩丫洭尯䀱", num), this.dictionary_32[BookmarkStart.b("䜥", num)]);
            this.class1092_0.method_4(BookmarkStart.b("倥䤧䘩", num), str2);
            this.class1092_0.method_12();
            this.class1092_0.method_12();
            this.class1092_0.method_11(BookmarkStart.b("䜥", num), BookmarkStart.b("䔥䐧堩砫䄭", num), this.dictionary_32[BookmarkStart.b("䜥", num)]);
            this.class1092_0.method_11(BookmarkStart.b("䜥", num), BookmarkStart.b("唥娧䴩丫洭尯䀱", num), this.dictionary_32[BookmarkStart.b("䜥", num)]);
            this.class1092_0.method_4(BookmarkStart.b("倥䤧䘩", num), str2);
            this.class1092_0.method_11(BookmarkStart.b("䜥", num), BookmarkStart.b("䜥䐧娩䐫伭", num), this.dictionary_32[BookmarkStart.b("䜥", num)]);
            this.class1092_0.method_4(BookmarkStart.b("倥䤧䘩", num), BookmarkStart.b("ᘥ", num));
            this.class1092_0.method_12();
            this.class1092_0.method_12();
            this.class1092_0.method_12();
            this.class1092_0.method_12();
        }
        this.class1092_0.method_12();
        this.class1092_0.method_11(BookmarkStart.b("䜥", num), BookmarkStart.b("唥娧䤩縫䬭匯䘱", num), this.dictionary_32[BookmarkStart.b("䜥", num)]);
        if (A_0.CropFromLeft != 0f)
        {
            this.class1092_0.method_4(BookmarkStart.b("䨥", num), ((int) Math.Round((double) (A_0.CropFromLeft * 100000f))).ToString());
        }
        if (A_0.CropFromTop != 0f)
        {
            this.class1092_0.method_4(BookmarkStart.b("別", num), ((int) Math.Round((double) (A_0.CropFromTop * 100000f))).ToString());
        }
        if (A_0.CropFromRight != 0f)
        {
            this.class1092_0.method_4(BookmarkStart.b("吥", num), ((int) Math.Round((double) (A_0.CropFromRight * 100000f))).ToString());
        }
        if (A_0.CropFromBottom != 0f)
        {
            this.class1092_0.method_4(BookmarkStart.b("䐥", num), ((int) Math.Round((double) (A_0.CropFromBottom * 100000f))).ToString());
        }
        this.class1092_0.method_12();
        this.method_323(A_0);
        this.class1092_0.method_12();
        this.class1092_0.method_11(BookmarkStart.b("嘥䄧䤩", num), BookmarkStart.b("唥堧稩師", num), this.dictionary_32[BookmarkStart.b("嘥䄧䤩", num)]);
        this.class1092_0.method_4(BookmarkStart.b("䐥弧朩䌫䨭唯", num), BookmarkStart.b("䜥崧帩䌫", num));
        this.class1092_0.method_11(BookmarkStart.b("䜥", num), BookmarkStart.b("帥丧堩䄫", num), this.dictionary_32[BookmarkStart.b("䜥", num)]);
        if (A_0.Rotation != 0f)
        {
            this.class1092_0.method_4(BookmarkStart.b("吥䜧帩", num), Math.Round((double) (A_0.Rotation * 60000f)).ToString());
        }
        this.class1092_0.method_11(BookmarkStart.b("䜥", num), BookmarkStart.b("䤥丧䰩", num), this.dictionary_32[BookmarkStart.b("䜥", num)]);
        this.class1092_0.method_4(BookmarkStart.b("帥", num), BookmarkStart.b("ᘥ", num));
        this.class1092_0.method_4(BookmarkStart.b("弥", num), BookmarkStart.b("ᘥ", num));
        this.class1092_0.method_12();
        this.class1092_0.method_11(BookmarkStart.b("䜥", num), BookmarkStart.b("䌥倧帩", num), this.dictionary_32[BookmarkStart.b("䜥", num)]);
        this.class1092_0.method_4(BookmarkStart.b("䔥倧", num), ((int) Math.Round((double) (((A_0.Width * A_0.WidthScale) / 100f) * 12700f))).ToString());
        this.class1092_0.method_4(BookmarkStart.b("䔥儧", num), ((int) Math.Round((double) (((A_0.Height * A_0.HeightScale) / 100f) * 12700f))).ToString());
        this.class1092_0.method_12();
        this.class1092_0.method_12();
        this.class1092_0.method_11(BookmarkStart.b("䜥", num), BookmarkStart.b("嘥娧天堫椭唯崱夳", num), this.dictionary_32[BookmarkStart.b("䜥", num)]);
        this.class1092_0.method_4(BookmarkStart.b("嘥娧天堫", num), BookmarkStart.b("吥䴧䤩堫", num));
        this.class1092_0.method_11(BookmarkStart.b("䜥", num), BookmarkStart.b("䜥帧昩弫娭", num), this.dictionary_32[BookmarkStart.b("䜥", num)]);
        this.class1092_0.method_12();
        this.class1092_0.method_12();
        if (!A_0.Borders.IsDefault && (A_0.Borders.Left.BorderType != BorderStyle.None))
        {
            this.class1092_0.method_10(BookmarkStart.b("䨥䘧", num), this.dictionary_32[BookmarkStart.b("䜥", num)]);
            this.class1092_0.method_4(BookmarkStart.b("䔥䔧娩䠫", num), this.method_267(A_0.Borders.Left.BorderType));
            this.class1092_0.method_4(BookmarkStart.b("儥", num), (A_0.Borders.Left.LineWidth * 12700f).ToString());
            this.class1092_0.method_10(BookmarkStart.b("唥䜧䘩䔫䨭瘯嬱堳娵", num), this.dictionary_32[BookmarkStart.b("䜥", num)]);
            this.class1092_0.method_10(BookmarkStart.b("唥娧䴩丫洭尯䀱", num), this.dictionary_32[BookmarkStart.b("䜥", num)]);
            this.class1092_0.method_4(BookmarkStart.b("倥䤧䘩", num), this.method_535(A_0.Borders.Left.Color));
            this.class1092_0.method_12();
            this.class1092_0.method_12();
            this.class1092_0.method_12();
        }
        this.class1092_0.method_12();
        this.class1092_0.method_12();
        this.class1092_0.method_12();
        this.class1092_0.method_12();
    }

    private void method_323(DocPicture A_0)
    {
        int num = 0x11;
        Struct36 stretch = A_0.Fill.Stretch;
        this.class1092_0.method_11(BookmarkStart.b("嘶", 0x11), BookmarkStart.b("䐶䴸䤺堼䬾≀⭂", 0x11), this.dictionary_32[BookmarkStart.b("嘶", 0x11)]);
        this.class1092_0.method_11(BookmarkStart.b("嘶", 0x11), BookmarkStart.b("儶倸场儼派⑀⁂ㅄ", 0x11), this.dictionary_32[BookmarkStart.b("嘶", 0x11)]);
        if (stretch.float_2 != 0f)
        {
            this.class1092_0.method_4(BookmarkStart.b("嬶", num), (stretch.float_2 * 1000f).ToString());
        }
        if (stretch.float_0 != 0f)
        {
            this.class1092_0.method_4(BookmarkStart.b("䌶", num), (stretch.float_0 * 1000f).ToString());
        }
        if (stretch.float_3 != 0f)
        {
            this.class1092_0.method_4(BookmarkStart.b("䔶", num), (stretch.float_3 * 1000f).ToString());
        }
        if (stretch.float_1 != 0f)
        {
            this.class1092_0.method_4(BookmarkStart.b("唶", num), (stretch.float_1 * 1000f).ToString());
        }
        this.class1092_0.method_12();
        this.class1092_0.method_12();
    }

    private string method_324(LineCap A_0)
    {
        int num = 12;
        switch (A_0)
        {
            case LineCap.Round:
                return BookmarkStart.b("䀱娳刵", num);

            case LineCap.Flat:
                return BookmarkStart.b("吱堳圵䰷", num);
        }
        return BookmarkStart.b("䄱䔳", num);
    }

    private string method_325(LineJoin A_0)
    {
        int num = 0;
        switch (A_0)
        {
            case LineJoin.Bevel:
                return BookmarkStart.b("䐥䴧尩䤫䈭", num);

            case LineJoin.Round:
                return BookmarkStart.b("吥䜧弩䈫䨭", num);
        }
        return BookmarkStart.b("䬥䄧帩䤫尭", num);
    }

    private string method_326(LineEnd A_0)
    {
        int num = 0x10;
        switch (A_0)
        {
            case LineEnd.ArrowEnd:
                return BookmarkStart.b("䈵䨷匹崻倽✿⹁⅃", num);

            case LineEnd.ArrowStealthEnd:
                return BookmarkStart.b("䔵䰷弹崻刽㐿⩁", num);

            case LineEnd.ArrowDiamondEnd:
                return BookmarkStart.b("刵儷嬹儻儽⸿♁", num);

            case LineEnd.ArrowOvalEnd:
                return BookmarkStart.b("夵丷嬹倻", num);

            case LineEnd.ArrowOpenEnd:
                return BookmarkStart.b("圵䨷䠹医䤽", num);
        }
        return BookmarkStart.b("堵圷吹夻", num);
    }

    private string method_327(LineEndWidth A_0)
    {
        int num = 12;
        switch (A_0)
        {
            case LineEndWidth.NarrowArrow:
                return BookmarkStart.b("就唳䐵䨷唹䬻", num);

            case LineEndWidth.WideArrow:
                return BookmarkStart.b("䔱崳刵崷", num);
        }
        return BookmarkStart.b("弱儳刵儷伹儻", num);
    }

    private string method_328(LineEndLength A_0)
    {
        int num = 0x10;
        switch (A_0)
        {
            case LineEndLength.ShortArrow:
                return BookmarkStart.b("䔵倷唹主䨽", num);

            case LineEndLength.LongArrow:
                return BookmarkStart.b("娵圷吹嬻", num);
        }
        return BookmarkStart.b("嬵崷帹唻䬽ⴿ", num);
    }

    private string method_329(LineType A_0)
    {
        int num = 8;
        switch (A_0)
        {
            case LineType.Pattern:
                return BookmarkStart.b("席儯䘱䀳匵䨷吹", num);

            case LineType.Texture:
                return BookmarkStart.b("娭夯帱儳", num);

            case LineType.Picture:
                return BookmarkStart.b("䠭䈯匱夳匵", num);
        }
        return BookmarkStart.b("崭弯帱崳刵", num);
    }

    public void method_33(bool A_0)
    {
        this.bool_1 = A_0;
    }

    private void method_330(Class892 A_0)
    {
        int num = 0x10;
        this.class1092_0.method_10(BookmarkStart.b("儵䨷嬹堻砽⤿⹁⡃", 0x10), this.dictionary_32[BookmarkStart.b("圵", 0x10)]);
        if (A_0.method_2() != FlipOrientation.None)
        {
            this.class1092_0.method_4(BookmarkStart.b("倵吷匹䰻", num), this.method_332(A_0.method_2()));
        }
        this.class1092_0.method_4(BookmarkStart.b("䐵圷丹欻圽㐿⩁ᝃ⹅⥇㩉⥋", num), A_0.method_0() ? BookmarkStart.b("ܵ", num) : BookmarkStart.b("ص", num));
        this.class1092_0.method_10(BookmarkStart.b("儵䬷瘹伻䨽", num), this.dictionary_32[BookmarkStart.b("圵", num)]);
        foreach (Class893 class2 in A_0.method_4())
        {
            this.method_331(class2);
        }
        this.class1092_0.method_12();
        if (A_0.method_5() != null)
        {
            this.class1092_0.method_10(BookmarkStart.b("娵儷吹", num), this.dictionary_32[BookmarkStart.b("圵", num)]);
            this.class1092_0.method_4(BookmarkStart.b("圵嘷崹", num), (A_0.method_5().method_0() * 0xea60).ToString());
            this.class1092_0.method_4(BookmarkStart.b("䔵嬷嬹倻嬽␿", num), A_0.method_5().method_2() ? BookmarkStart.b("ܵ", num) : BookmarkStart.b("ص", num));
            this.class1092_0.method_12();
        }
        if (A_0.method_7() != null)
        {
            this.class1092_0.method_10(BookmarkStart.b("䘵夷丹吻", num), this.dictionary_32[BookmarkStart.b("圵", num)]);
            this.class1092_0.method_4(BookmarkStart.b("䘵夷丹吻", num), this.method_333(A_0.method_7().method_0()));
            this.class1092_0.method_10(BookmarkStart.b("倵儷嘹倻樽⼿၁⅃╅㱇", num), this.dictionary_32[BookmarkStart.b("圵", num)]);
            if (A_0.method_7().method_4() != 0)
            {
                this.class1092_0.method_4(BookmarkStart.b("娵", num), (A_0.method_7().method_4() * 0x3e8).ToString());
            }
            if (A_0.method_7().method_8() != 0)
            {
                this.class1092_0.method_4(BookmarkStart.b("䈵", num), (A_0.method_7().method_8() * 0x3e8).ToString());
            }
            if (A_0.method_7().method_6() != 0)
            {
                this.class1092_0.method_4(BookmarkStart.b("䐵", num), (A_0.method_7().method_6() * 0x3e8).ToString());
            }
            if (A_0.method_7().method_2() != 0)
            {
                this.class1092_0.method_4(BookmarkStart.b("吵", num), (A_0.method_7().method_2() * 0x3e8).ToString());
            }
            this.class1092_0.method_12();
            this.class1092_0.method_12();
        }
        this.class1092_0.method_10(BookmarkStart.b("䈵儷嘹夻氽┿⅁ぃ", num), this.dictionary_32[BookmarkStart.b("圵", num)]);
        if (A_0.method_9().method_2() != 0)
        {
            this.class1092_0.method_4(BookmarkStart.b("娵", num), (A_0.method_9().method_2() * 0x3e8).ToString());
        }
        if (A_0.method_9().method_6() != 0)
        {
            this.class1092_0.method_4(BookmarkStart.b("䈵", num), (A_0.method_9().method_6() * 0x3e8).ToString());
        }
        if (A_0.method_9().method_4() != 0)
        {
            this.class1092_0.method_4(BookmarkStart.b("䐵", num), (A_0.method_9().method_4() * 0x3e8).ToString());
        }
        if (A_0.method_9().method_0() != 0)
        {
            this.class1092_0.method_4(BookmarkStart.b("吵", num), (A_0.method_9().method_0() * 0x3e8).ToString());
        }
        this.class1092_0.method_12();
        this.class1092_0.method_12();
    }

    private void method_331(Class893 A_0)
    {
        int num = 11;
        this.class1092_0.method_10(BookmarkStart.b("嘰䀲", 11), this.dictionary_32[BookmarkStart.b("倰", 11)]);
        this.class1092_0.method_4(BookmarkStart.b("䄰尲䘴", 11), (A_0.method_0() * 0x3e8).ToString());
        A_0.method_2();
        this.class1092_0.method_10(BookmarkStart.b("䈰䄲刴唶稸场似", 11), this.dictionary_32[BookmarkStart.b("倰", 11)]);
        this.class1092_0.method_4(BookmarkStart.b("䜰刲头", 11), this.method_535(A_0.method_2()));
        if (A_0.method_4() != 0xff)
        {
            this.class1092_0.method_10(BookmarkStart.b("倰弲䔴弶堸", num), this.dictionary_32[BookmarkStart.b("倰", num)]);
            this.class1092_0.method_4(BookmarkStart.b("䜰刲头", num), ((A_0.method_4() * 0x3e8)).ToString() + BookmarkStart.b("ᐰ", num));
            this.class1092_0.method_12();
        }
        this.class1092_0.method_12();
        this.class1092_0.method_12();
    }

    private string method_332(FlipOrientation A_0)
    {
        int num = 0;
        switch (A_0)
        {
            case FlipOrientation.Horizontal:
                return BookmarkStart.b("帥", num);

            case FlipOrientation.Vertical:
                return BookmarkStart.b("弥", num);

            case FlipOrientation.Both:
                return BookmarkStart.b("帥儧", num);
        }
        return BookmarkStart.b("䠥䜧䐩䤫", num);
    }

    private string method_333(GradientShadeType A_0)
    {
        int num = 13;
        switch (A_0)
        {
            case GradientShadeType.Circle:
                return BookmarkStart.b("倲尴䔶娸场堼", num);

            case GradientShadeType.Rectangle:
                return BookmarkStart.b("䄲倴吶䴸", num);
        }
        return BookmarkStart.b("䀲崴嘶䤸帺", num);
    }

    private void method_334(DocPicture A_0)
    {
        int num = 12;
        IDocumentObject previousSibling = A_0;
        for (int i = 0; i < 2; i++)
        {
            previousSibling = previousSibling.PreviousSibling;
            if (previousSibling == null)
            {
                break;
            }
        }
        if ((previousSibling != null) && (previousSibling is Field))
        {
            Field field = previousSibling as Field;
            if (field.Type == FieldType.FieldHyperlink)
            {
                this.class1092_0.method_10(BookmarkStart.b("娱堳張嘷儹缻刽⤿⅁⽃", num), this.dictionary_32[BookmarkStart.b("匱", num)]);
                this.class1092_0.method_6(BookmarkStart.b("䨱夳娵嘷䤹", num), BookmarkStart.b("匱", num), null, this.dictionary_32[BookmarkStart.b("匱", num)]);
                this.method_220(field);
                this.class1092_0.method_12();
            }
        }
    }

    internal string method_335(DocPicture A_0, bool A_1, DocOleObject A_2)
    {
        IDocumentObject obj2;
        string str = this.method_527();
        if (!A_1)
        {
            obj2 = this.method_340(A_0);
        }
        else
        {
            obj2 = this.method_341(A_2);
        }
        this.method_113(A_0);
        if (obj2 is HeaderFooter)
        {
            return this.method_338(obj2 as HeaderFooter, A_0);
        }
        if ((obj2.Owner != null) && (obj2.Owner is HeaderFooter))
        {
            HeaderFooter owner = obj2.Owner as HeaderFooter;
            return this.method_338(owner, A_0);
        }
        if ((((obj2 is Section) || (obj2 is TextBox)) || ((obj2 is TableRow) || (obj2 is Paragraph))) || ((obj2 is SDTContent) || (obj2 is StructureDocumentTag)))
        {
            str = this.method_336(this.method_38(), A_0.ImageRecord);
        }
        if (obj2 is Footnote)
        {
            if ((obj2 as Footnote).FootnoteType == FootnoteType.Footnote)
            {
                str = this.method_336(this.method_40(), A_0.ImageRecord);
            }
            else
            {
                str = this.method_336(this.method_41(), A_0.ImageRecord);
            }
        }
        if (obj2 is Comment)
        {
            str = this.method_336(this.method_42(), A_0.ImageRecord);
        }
        return str;
    }

    private string method_336(Dictionary<string, Class517> A_0, Class517 A_1)
    {
        string key = string.Empty;
        if (A_0.ContainsValue(A_1))
        {
            foreach (string str2 in A_0.Keys)
            {
                if (A_1 == A_0[str2])
                {
                    return str2;
                }
            }
            return key;
        }
        key = this.method_527();
        A_0.Add(key, A_1);
        return key;
    }

    private void method_337(string A_0, HeaderFooter A_1, Class517 A_2)
    {
        string key = string.Empty;
        foreach (HeaderFooterType type in this.dictionary_10.Keys)
        {
            Dictionary<string, HeaderFooter> dictionary = this.dictionary_10[type];
            foreach (string str2 in dictionary.Keys)
            {
                if (dictionary[str2] == A_1)
                {
                    key = str2;
                    Dictionary<string, Class517> dictionary2 = null;
                    if (this.method_45().ContainsKey(key))
                    {
                        dictionary2 = this.method_45()[key];
                        dictionary2.Add(A_0, A_2);
                    }
                    else
                    {
                        dictionary2 = new Dictionary<string, Class517>();
                        dictionary2.Add(A_0, A_2);
                        this.method_45().Add(key, dictionary2);
                    }
                }
            }
        }
    }

    private string method_338(HeaderFooter A_0, DocPicture A_1)
    {
        this.method_113(A_1);
        string str = string.Empty;
        string key = string.Empty;
        foreach (HeaderFooterType type in this.dictionary_10.Keys)
        {
            Dictionary<string, HeaderFooter> dictionary = this.dictionary_10[type];
            foreach (string str3 in dictionary.Keys)
            {
                if (dictionary[str3] == A_0)
                {
                    key = str3;
                    Dictionary<string, Class517> dictionary2 = null;
                    if (this.method_45().ContainsKey(key))
                    {
                        dictionary2 = this.method_45()[key];
                        str = this.method_336(dictionary2, A_1.ImageRecord);
                    }
                    else
                    {
                        dictionary2 = new Dictionary<string, Class517>();
                        str = this.method_336(dictionary2, A_1.ImageRecord);
                        this.method_45().Add(key, dictionary2);
                    }
                }
            }
        }
        return str;
    }

    private string method_339(HeaderFooter A_0)
    {
        foreach (HeaderFooterType type in this.dictionary_10.Keys)
        {
            Dictionary<string, HeaderFooter> dictionary = this.dictionary_10[type];
            foreach (string str in dictionary.Keys)
            {
                if (dictionary[str] == A_0)
                {
                    return str;
                }
            }
        }
        return null;
    }

    public bool method_34()
    {
        return this.bool_2;
    }

    private IDocumentObject method_340(DocPicture A_0)
    {
        DocumentObject owner = A_0.Owner;
        if ((owner == null) && (A_0.documentObject_1 != null))
        {
            owner = A_0.documentObject_1;
        }
        Paragraph ownerParagraph = null;
        if (A_0.Owner is DocOleObject)
        {
            owner = (A_0.Owner as DocOleObject).OwnerParagraph;
        }
        if (owner is SDTInlineContent)
        {
            if (owner.Owner is SDTInlineContent)
            {
                ownerParagraph = (owner.Owner as SDTInlineContent).OwnerParagraph;
            }
            if (owner.Owner is StructureDocumentTagInline)
            {
                ownerParagraph = (owner.Owner as StructureDocumentTagInline).OwnerParagraph;
            }
        }
        else if (owner is Paragraph)
        {
            ownerParagraph = owner as Paragraph;
        }
        else if (owner is ShapeGroup)
        {
            ownerParagraph = (owner as ParagraphBase).method_28();
        }
        DocumentObject obj3 = ownerParagraph.Owner;
        while (obj3 != null)
        {
            if (obj3 is HeaderFooter)
            {
                break;
            }
            obj3 = obj3.Owner;
        }
        if (obj3 is HeaderFooter)
        {
            return obj3;
        }
        TableCell cell = ownerParagraph.Owner as TableCell;
        DocumentObject obj4 = ownerParagraph.Owner.Owner;
        IDocumentObject ownerTextBody = ownerParagraph.Owner;
        if (cell != null)
        {
            ownerTextBody = cell.OwnerRow.OwnerTable.OwnerTextBody;
        }
        else
        {
            ownerTextBody = ownerParagraph.Owner;
        }
        return ownerTextBody.Owner;
    }

    private IDocumentObject method_341(DocOleObject A_0)
    {
        IDocumentObject ownerTextBody;
        HeaderFooter footer;
        Paragraph ownerParagraph = A_0.OwnerParagraph;
        TableCell owner = ownerParagraph.Owner as TableCell;
        DocumentObject obj2 = ownerParagraph.Owner.Owner;
        if (owner != null)
        {
            ownerTextBody = owner.OwnerRow.OwnerTable.OwnerTextBody;
        }
        else
        {
            ownerTextBody = A_0.OwnerParagraph.Owner;
        }
        obj2 = ownerTextBody.Owner;
        if ((obj2 is TextBox) && ((obj2 as TextBox).OwnerParagraph != null))
        {
            footer = (obj2 as TextBox).OwnerParagraph.OwnerTextBody as HeaderFooter;
        }
        else
        {
            footer = ownerTextBody as HeaderFooter;
        }
        if (footer != null)
        {
            return footer;
        }
        return obj2;
    }

    private void method_342(ShapeObject A_0)
    {
        this.class1092_0.method_10(BookmarkStart.b("䈯", 10), this.dictionary_32[BookmarkStart.b("䜯", 10)]);
        this.method_463(A_0.CharacterFormat);
        Stream stream = new MemoryStream();
        Class421 visitor = new Class421(this.document_0, stream, this);
        ((Interface52) visitor).imethod_3(true);
        visitor.Interface52.imethod_1().method_1(this.class1092_0);
        Class734.smethod_7(this.int_6);
        A_0.Accept(visitor);
        this.int_6 = Class734.smethod_6();
        visitor.Interface52.imethod_1().method_0().method_15();
        this.class1092_0.method_12();
    }

    private void method_343(ShapeObject A_0, Class398 A_1, Class685 A_2)
    {
        new Class685(this.class1092_0, this.document_0, this);
        if (A_0.IsGroup)
        {
            foreach (DocumentObject obj2 in A_0.ChildObjects)
            {
                this.method_343(obj2 as ShapeObject, A_1, A_2);
                A_1.method_0().method_12();
                A_1.method_0().method_15();
            }
        }
    }

    private void method_344(DocPicture A_0)
    {
        int num = 6;
        string str = string.Empty;
        str = this.method_335(A_0, false, null);
        this.class1092_0.method_10(BookmarkStart.b("尫䜭匯䘱", 6), this.dictionary_32[BookmarkStart.b("嬫", 6)]);
        if (!A_0.LockAspectRatio)
        {
            this.class1092_0.method_10(BookmarkStart.b("弫䘭儯䈱儳䈵䄷䨹夻", num), this.dictionary_32[BookmarkStart.b("娫", num)]);
            this.class1092_0.method_4(BookmarkStart.b("䔫䨭", num), BookmarkStart.b("猫嘭/ȱгص朷丹଻ଽ", num));
            this.class1092_0.method_6(BookmarkStart.b("䌫", num), BookmarkStart.b("尫尭唯吱儳䐵䨷弹倻弽㐿⭁㉃⍅", num), this.dictionary_32[BookmarkStart.b("䌫", num)], BookmarkStart.b("堫", num));
            this.class1092_0.method_10(BookmarkStart.b("䀫䄭匯失", num), this.dictionary_32[BookmarkStart.b("䌫", num)]);
            this.class1092_0.method_6(BookmarkStart.b("娫", num), BookmarkStart.b("䤫嘭䐯", num), this.dictionary_32[BookmarkStart.b("娫", num)], BookmarkStart.b("䤫䨭夯䘱", num));
            this.class1092_0.method_4(BookmarkStart.b("䴫崭䀯圱圳䈵䨷嬹䠻圽⼿", num), BookmarkStart.b("䨫", num));
            this.class1092_0.method_12();
            this.class1092_0.method_12();
        }
        this.class1092_0.method_10(BookmarkStart.b("弫䘭儯䈱儳", num), this.dictionary_32[BookmarkStart.b("娫", num)]);
        string str3 = BookmarkStart.b("猫嘭/ȱгص朷匹", num) + this.method_546().ToString();
        if (A_0.EmbedOleObject != null)
        {
            this.class1092_0.method_4(BookmarkStart.b("䔫䨭", num), str3);
        }
        this.class1092_0.method_4(BookmarkStart.b("堫圭䀯圱", num), BookmarkStart.b("༫焭䠯ȱгص࠷改䠻ऽ甿", num));
        string str4 = this.method_358(A_0);
        this.class1092_0.method_4(BookmarkStart.b("弫娭䤯帱儳", num), str4);
        if ((A_0.WrapPolygon != null) && (A_0.WrapPolygon.Length > 0))
        {
            string str2 = this.method_252(A_0.WrapPolygon);
            this.class1092_0.method_4(BookmarkStart.b("嬫尭儯䈱圳夵圷䠹堻䴽", num), str2);
        }
        if (!A_0.LayoutInCell)
        {
            this.class1092_0.method_5(BookmarkStart.b("䴫䈭尯崱䌳張嘷夹夻刽ⰿ", num), this.dictionary_32[BookmarkStart.b("䌫", num)], BookmarkStart.b("䨫", num));
        }
        if (!A_0.AllowOverlap)
        {
            this.class1092_0.method_5(BookmarkStart.b("䴫䈭尯崱䌳夵丷弹主刽ℿ㉁", num), this.dictionary_32[BookmarkStart.b("䌫", num)], BookmarkStart.b("䨫", num));
        }
        this.class1092_0.method_10(BookmarkStart.b("䔫䌭儯唱儳刵夷丹崻", num), this.dictionary_32[BookmarkStart.b("娫", num)]);
        if (str != null)
        {
            this.class1092_0.method_5(BookmarkStart.b("䔫䨭", num), this.dictionary_32[BookmarkStart.b("師", num)], str);
        }
        if (A_0.Title != null)
        {
            this.class1092_0.method_5(BookmarkStart.b("堫䜭䐯帱儳", num), this.dictionary_32[BookmarkStart.b("䌫", num)], A_0.Title);
        }
        int shapeAttribute = (int) A_0.GetShapeAttribute(0x108);
        if (A_0.Contrast != Class969.smethod_71(1.0))
        {
            this.class1092_0.method_4(BookmarkStart.b("䬫伭夯就", num), shapeAttribute.ToString() + BookmarkStart.b("䨫", num));
        }
        int num3 = (int) A_0.GetShapeAttribute(0x109);
        if (A_0.Brightness != 0f)
        {
            this.class1092_0.method_4(BookmarkStart.b("丫䈭儯儱弳娵崷䰹夻刽", num), num3.ToString() + BookmarkStart.b("䨫", num));
        }
        if ((A_0.Color != PictureColor.Automatic) || A_0.GrayScale)
        {
            this.class1092_0.method_4(BookmarkStart.b("䬫尭儯䬱䜳唵夷嘹夻", num), BookmarkStart.b("堫", num));
        }
        if ((A_0.Color == PictureColor.BlackAndWhite) || A_0.BiLevel)
        {
            this.class1092_0.method_4(BookmarkStart.b("丫䈭儯儱弳娵崷䰹夻刽", num), BookmarkStart.b("堫", num));
        }
        if (A_0.CropFromBottom != 0f)
        {
            this.class1092_0.method_5(BookmarkStart.b("伫尭弯䈱嘳夵䰷丹医匽", num), this.dictionary_32[BookmarkStart.b("䌫", num)], ((A_0.CropFromBottom * 65536f)).ToString() + BookmarkStart.b("䨫", num));
        }
        if (A_0.CropFromTop != 0f)
        {
            this.class1092_0.method_5(BookmarkStart.b("伫尭弯䈱䀳夵䠷", num), this.dictionary_32[BookmarkStart.b("䌫", num)], ((A_0.CropFromTop * 65536f)).ToString() + BookmarkStart.b("䨫", num));
        }
        if (A_0.CropFromLeft != 0f)
        {
            this.class1092_0.method_5(BookmarkStart.b("伫尭弯䈱堳匵帷丹", num), this.dictionary_32[BookmarkStart.b("䌫", num)], ((A_0.CropFromLeft * 65536f)).ToString() + BookmarkStart.b("䨫", num));
        }
        if (A_0.CropFromRight != 0f)
        {
            this.class1092_0.method_5(BookmarkStart.b("伫尭弯䈱䘳張強刹䠻", num), this.dictionary_32[BookmarkStart.b("䌫", num)], ((A_0.CropFromRight * 65536f)).ToString() + BookmarkStart.b("䨫", num));
        }
        Color chromaKey = A_0.ChromaKey;
        if (!A_0.ChromaKey.IsEmpty)
        {
            this.class1092_0.method_5(BookmarkStart.b("伫䘭䈯崱夳圵匷弹䔻", num), this.dictionary_32[BookmarkStart.b("䌫", num)], BookmarkStart.b("༫", num) + this.method_535(A_0.ChromaKey));
        }
        this.class1092_0.method_12();
        if (A_0.HasBorder)
        {
            if (A_0.TextWrappingStyle == TextWrappingStyle.Inline)
            {
                this.method_355(A_0.Borders);
            }
            else
            {
                this.method_345(A_0);
            }
        }
        this.method_351(A_0.TextWrappingStyle, A_0.TextWrappingType);
        this.class1092_0.method_12();
        if (A_0.EmbedOleObject != null)
        {
            this.bool_7 = true;
            this.method_290(A_0.EmbedOleObject, str3);
        }
        this.class1092_0.method_12();
    }

    private void method_345(ShapeObject A_0)
    {
        object shapeAttribute;
        int num = 11;
        this.class1092_0.method_10(BookmarkStart.b("䈰䜲䜴堶券帺", 11), this.dictionary_32[BookmarkStart.b("䜰", 11)]);
        if (A_0.ShapePr.HasKey(470))
        {
            shapeAttribute = A_0.GetShapeAttribute(470);
            this.class1092_0.method_4(BookmarkStart.b("嬰尲尴夶䨸伺䐼匾⑀", num), this.method_325((LineJoin) shapeAttribute));
        }
        if (A_0.ShapePr.HasKey(0x1ce))
        {
            shapeAttribute = A_0.GetShapeAttribute(0x1ce);
            this.class1092_0.method_4(BookmarkStart.b("唰刲䘴弶䨸伺䐼匾⑀", num), this.method_350((LineDashing) shapeAttribute));
        }
        if (A_0.ShapePr.HasKey(0x1cd))
        {
            shapeAttribute = A_0.GetShapeAttribute(0x1cd);
            this.class1092_0.method_4(BookmarkStart.b("崰娲嬴制䨸伺䐼匾⑀", num), this.method_347((ShapeLineStyle) shapeAttribute));
        }
        if (A_0.ShapePr.HasKey(0x1d7))
        {
            shapeAttribute = A_0.GetShapeAttribute(0x1d7);
            this.class1092_0.method_4(BookmarkStart.b("吰崲儴吶堸䬺", num), this.method_349((StrokeEndCap) shapeAttribute));
        }
        if (A_0.ShapePr.HasKey(0x1d0))
        {
            shapeAttribute = A_0.GetShapeAttribute(0x1d0);
            this.class1092_0.method_4(BookmarkStart.b("䈰䜲吴䔶䴸娺似䴾⹀㑂", num), this.method_326((LineEnd) shapeAttribute));
        }
        if (A_0.ShapePr.HasKey(0x1d2))
        {
            shapeAttribute = A_0.GetShapeAttribute(0x1d2);
            this.class1092_0.method_4(BookmarkStart.b("䈰䜲吴䔶䴸娺似䴾⹀㑂㉄⹆ⵈ㽊╌", num), this.method_327((LineEndWidth) shapeAttribute));
        }
        if (A_0.ShapePr.HasKey(0x1d3))
        {
            shapeAttribute = A_0.GetShapeAttribute(0x1d3);
            this.class1092_0.method_4(BookmarkStart.b("䈰䜲吴䔶䴸娺似䴾⹀㑂⥄≆❈ⱊ㥌❎", num), this.method_328((LineEndLength) shapeAttribute));
        }
        if (A_0.ShapePr.HasKey(0x1d1))
        {
            shapeAttribute = A_0.GetShapeAttribute(0x1d1);
            this.class1092_0.method_4(BookmarkStart.b("吰崲儴嘶䬸䤺刼䠾", num), this.method_326((LineEnd) shapeAttribute));
        }
        if (A_0.ShapePr.HasKey(0x1d4))
        {
            shapeAttribute = A_0.GetShapeAttribute(0x1d4);
            this.class1092_0.method_4(BookmarkStart.b("吰崲儴嘶䬸䤺刼䠾㙀⩂⅄㍆ⅈ", num), this.method_327((LineEndWidth) shapeAttribute));
        }
        if (A_0.ShapePr.HasKey(0x1d5))
        {
            shapeAttribute = A_0.GetShapeAttribute(0x1d5);
            this.class1092_0.method_4(BookmarkStart.b("吰崲儴嘶䬸䤺刼䠾ⵀ♂⭄⁆㵈⍊", num), this.method_328((LineEndLength) shapeAttribute));
        }
        if (A_0.ShapePr.HasKey(0x1c1))
        {
            shapeAttribute = A_0.GetShapeAttribute(0x1c1);
            this.class1092_0.method_4(BookmarkStart.b("帰䌲吴吶倸伺䐼", num), shapeAttribute.ToString() + BookmarkStart.b("地", num));
        }
        if (A_0.ShapePr.HasKey(450))
        {
            shapeAttribute = A_0.GetShapeAttribute(450);
            this.class1092_0.method_4(BookmarkStart.b("到尲头堶䬸ऺ", num), BookmarkStart.b("ሰ", num) + this.method_535((Color) shapeAttribute));
        }
        if (A_0.ShapePr.HasKey(0x1c4))
        {
            shapeAttribute = A_0.GetShapeAttribute(0x1c4);
            this.class1092_0.method_4(BookmarkStart.b("地娲头嬶䴸䈺䴼娾", num), this.method_329((LineType) shapeAttribute));
        }
        this.class1092_0.method_12();
    }

    private string method_346(TextBoxLineStyle A_0)
    {
        int num = 11;
        switch (A_0)
        {
            case TextBoxLineStyle.Double:
                return BookmarkStart.b("䔰嬲尴夶洸区吼儾", num);

            case TextBoxLineStyle.ThickThin:
                return BookmarkStart.b("䔰嬲尴吶券漺唼嘾⽀", num);

            case TextBoxLineStyle.ThinThick:
                return BookmarkStart.b("䔰嬲尴夶洸区吼尾⩀", num);

            case TextBoxLineStyle.Triple:
                return BookmarkStart.b("䔰嬲尴吶券示堼䬾㙀♂⁄⥆ᵈ⍊⑌ⅎ", num);
        }
        return BookmarkStart.b("䈰娲嬴倶唸帺", num);
    }

    private string method_347(ShapeLineStyle A_0)
    {
        int num = 0;
        switch (A_0)
        {
            case ShapeLineStyle.Double:
                return BookmarkStart.b("別䀧䌩䈫稭堯嬱娳", num);

            case ShapeLineStyle.ThickThin:
                return BookmarkStart.b("別䀧䌩伫䔭搯娱崳堵", num);

            case ShapeLineStyle.ThinThick:
                return BookmarkStart.b("別䀧䌩䈫稭堯嬱圳崵", num);

            case ShapeLineStyle.Triple:
                return BookmarkStart.b("別䀧䌩伫䔭爯圱䀳䄵崷弹刻樽⠿⭁⩃", num);
        }
        return BookmarkStart.b("唥䄧䐩䬫䈭唯", num);
    }

    private string method_348(TextBoxLineStyle A_0)
    {
        int num = 5;
        switch (A_0)
        {
            case TextBoxLineStyle.Double:
                return BookmarkStart.b("伪伬䌮", num);

            case TextBoxLineStyle.ThickThin:
                return BookmarkStart.b("弪䔬䘮到堲愴弶倸唺", num);

            case TextBoxLineStyle.ThinThick:
                return BookmarkStart.b("弪䔬䘮弰朲崴帶娸债", num);

            case TextBoxLineStyle.Triple:
                return BookmarkStart.b("弪弬䘮", num);
        }
        return BookmarkStart.b("堪䌬䠮", num);
    }

    private string method_349(StrokeEndCap A_0)
    {
        int num = 13;
        switch (A_0)
        {
            case StrokeEndCap.Round:
                return BookmarkStart.b("䄲娴䈶圸强", num);

            case StrokeEndCap.Square:
                return BookmarkStart.b("䀲䐴䈶堸䤺堼", num);
        }
        return BookmarkStart.b("唲头嘶䴸", num);
    }

    public void method_35(bool A_0)
    {
        this.bool_2 = A_0;
    }

    private string method_350(LineDashing A_0)
    {
        int num = 0x13;
        switch (A_0)
        {
            case LineDashing.Dash:
            case LineDashing.DashGEL:
                return BookmarkStart.b("崸娺丼圾", num);

            case LineDashing.Dot:
            case LineDashing.DotGEL:
                return BookmarkStart.b("࠸ᬺ఼", num);

            case LineDashing.DashDot:
            case LineDashing.LongDashDotGEL:
                return BookmarkStart.b("唸吺匼堾Հ≂㙄⽆ൈ⑊㥌", num);

            case LineDashing.DashDotDot:
            case LineDashing.LongDashDotDotGEL:
                return BookmarkStart.b("唸吺匼堾Հ≂㙄⽆ൈ⑊㥌୎㹐❒", num);

            case LineDashing.LongDashGEL:
                return BookmarkStart.b("唸吺匼堾Հ≂㙄⽆", num);

            case LineDashing.DashDotGEL:
                return BookmarkStart.b("崸娺丼圾Հⱂㅄ", num);
        }
        return BookmarkStart.b("䨸吺儼嘾╀", num);
    }

    private void method_351(TextWrappingStyle A_0, TextWrappingType A_1)
    {
        int num = 2;
        if ((A_0 != TextWrappingStyle.InFrontOfText) && (A_0 != TextWrappingStyle.Behind))
        {
            this.class1092_0.method_10(BookmarkStart.b("弧堩䴫席", num), this.dictionary_32[BookmarkStart.b("弧ᬩᰫ", num)]);
            this.class1092_0.method_4(BookmarkStart.b("尧匩尫䬭", num), this.method_352(A_0));
            if (A_1 != TextWrappingType.Both)
            {
                this.class1092_0.method_4(BookmarkStart.b("嬧䌩䠫䬭", num), this.method_353(A_1));
            }
            this.class1092_0.method_12();
        }
    }

    private string method_352(TextWrappingStyle A_0)
    {
        int num = 0x13;
        switch (A_0)
        {
            case TextWrappingStyle.TopAndBottom:
                return BookmarkStart.b("䴸吺䴼績⽀❂݄⡆㵈㽊≌≎", num);

            case TextWrappingStyle.Square:
                return BookmarkStart.b("䨸䨺䠼帾㍀♂", num);

            case TextWrappingStyle.Tight:
                return BookmarkStart.b("䴸刺娼圾㕀", num);

            case TextWrappingStyle.Through:
                return BookmarkStart.b("䴸区似倾㑀⑂ⵄ", num);
        }
        return BookmarkStart.b("圸吺匼娾", num);
    }

    private string method_353(TextWrappingType A_0)
    {
        int num = 1;
        switch (A_0)
        {
            case TextWrappingType.Left:
                return BookmarkStart.b("䬦䰨䴪夬", num);

            case TextWrappingType.Right:
                return BookmarkStart.b("唦䀨䰪䔬嬮", num);

            case TextWrappingType.Largest:
                return BookmarkStart.b("䬦䠨太䨬䨮䈰䜲", num);
        }
        return BookmarkStart.b("䔦䘨弪䔬", num);
    }

    private string method_354(TextWrappingType A_0)
    {
        int num = 0x10;
        switch (A_0)
        {
            case TextWrappingType.Left:
                return BookmarkStart.b("娵崷尹䠻", num);

            case TextWrappingType.Right:
                return BookmarkStart.b("䐵儷崹吻䨽", num);

            case TextWrappingType.Largest:
                return BookmarkStart.b("娵夷䠹嬻嬽㌿㙁", num);
        }
        return BookmarkStart.b("吵圷丹吻洽⤿♁⅃㕅", num);
    }

    private void method_355(Borders A_0)
    {
        int num = 7;
        if (A_0.Top.BorderType != BorderStyle.None)
        {
            this.method_356(A_0.Top, BookmarkStart.b("伬䀮䌰圲倴䔶䴸吺䴼", num));
        }
        if (A_0.Bottom.BorderType != BorderStyle.None)
        {
            this.method_356(A_0.Bottom, BookmarkStart.b("伬䀮䌰圲倴䔶嬸吺䤼䬾⹀⹂", num));
        }
        if (A_0.Right.BorderType != BorderStyle.None)
        {
            this.method_356(A_0.Right, BookmarkStart.b("伬䀮䌰圲倴䔶䬸刺娼圾㕀", num));
        }
        if (A_0.Left.BorderType != BorderStyle.None)
        {
            this.method_356(A_0.Left, BookmarkStart.b("伬䀮䌰圲倴䔶唸帺嬼䬾", num));
        }
    }

    private void method_356(Border A_0, string A_1)
    {
        int num = 15;
        this.class1092_0.method_10(A_1, this.dictionary_32[BookmarkStart.b("䈴ضस", 15)]);
        this.class1092_0.method_4(BookmarkStart.b("䄴丶䤸帺", 15), this.method_357(A_0.BorderType, false));
        this.class1092_0.method_4(BookmarkStart.b("䈴帶崸伺唼", 15), A_0.LineWidth.ToString());
        if (A_0.Shadow)
        {
            this.class1092_0.method_4(BookmarkStart.b("䘴弶堸强刼䠾", num), A_0.Shadow.ToString());
        }
        this.class1092_0.method_12();
    }

    private string method_357(BorderStyle A_0, bool A_1)
    {
        int num = 9;
        switch (A_0)
        {
            case BorderStyle.Single:
            case BorderStyle.Hairline:
                return BookmarkStart.b("尮堰崲刴嬶尸", num);

            case BorderStyle.Thick:
                return BookmarkStart.b("嬮夰娲嘴尶", num);

            case BorderStyle.Double:
                return BookmarkStart.b("䬮帰䘲圴嬶尸", num);

            case BorderStyle.Dot:
                return BookmarkStart.b("䬮帰䜲䄴制崸", num);

            case BorderStyle.DashLargeGap:
                return BookmarkStart.b("䬮倰䀲崴制崸", num);

            case BorderStyle.DotDash:
                return BookmarkStart.b("䬮帰䜲焴嘶䨸区", num);

            case BorderStyle.DotDotDash:
                return BookmarkStart.b("䬮帰䜲焴堶䴸缺尼䰾⥀", num);

            case BorderStyle.Triple:
                return BookmarkStart.b("嬮䌰娲䔴嬶尸", num);

            case BorderStyle.ThinThickSmallGap:
                return BookmarkStart.b("嬮夰娲嬴挶儸刺帼吾ቀ⹂⑄⭆╈ొⱌ㽎", num);

            case BorderStyle.ThickThinSmallGap:
                if (A_1)
                {
                    return BookmarkStart.b("嬮夰娲嬴挶儸刺匼", num);
                }
                return BookmarkStart.b("嬮夰娲嘴尶洸区吼儾ቀ⹂⑄⭆╈ొⱌ㽎", num);

            case BorderStyle.ThinThickThinSmallGap:
                return BookmarkStart.b("嬮夰娲嬴挶儸刺帼吾ᕀ⭂ⱄ⥆ᩈ♊ⱌ⍎㵐ᑒ㑔❖", num);

            case BorderStyle.ThinThickMediumGap:
                if (!A_1)
                {
                    return BookmarkStart.b("嬮夰娲嬴挶儸刺帼吾ీ♂⅄⹆㱈♊ੌ⹎⅐", num);
                }
                return BookmarkStart.b("嬮夰娲嬴挶儸刺帼吾", num);

            case BorderStyle.ThickThinMediumGap:
                if (!A_1)
                {
                    return BookmarkStart.b("嬮夰娲嘴尶洸区吼儾ీ♂⅄⹆㱈♊ੌ⹎⅐", num);
                }
                return BookmarkStart.b("嬮夰娲嘴尶洸区吼儾", num);

            case BorderStyle.ThinThickThinMediumGap:
                if (!A_1)
                {
                    return BookmarkStart.b("嬮夰娲嬴挶儸刺帼吾ᕀ⭂ⱄ⥆ш⹊⥌♎⑐㹒ቔ㙖⥘", num);
                }
                return BookmarkStart.b("嬮夰娲嘴尶笸帺䤼䠾⑀♂⭄ፆⅈ≊⍌", num);

            case BorderStyle.ThinThickLargeGap:
                return BookmarkStart.b("嬮夰娲嬴挶儸刺帼吾ീ≂㝄⁆ⱈొⱌ㽎", num);

            case BorderStyle.ThickThinLargeGap:
                return BookmarkStart.b("嬮夰娲嘴尶洸区吼儾ീ≂㝄⁆ⱈొⱌ㽎", num);

            case BorderStyle.ThinThickThinLargeGap:
                return BookmarkStart.b("嬮夰娲嬴挶儸刺帼吾ᕀ⭂ⱄ⥆Ո⩊㽌⡎㑐ᑒ㑔❖", num);

            case BorderStyle.Wave:
                return BookmarkStart.b("堮倰䔲倴", num);

            case BorderStyle.DoubleWave:
                return BookmarkStart.b("䬮帰䘲圴嬶尸氺尼䤾⑀", num);

            case BorderStyle.DashSmallGap:
                return BookmarkStart.b("䬮倰䀲崴搶吸娺儼匾ـ≂㕄", num);

            case BorderStyle.DashDotStroker:
                return BookmarkStart.b("䬮倰䀲崴猶嘸伺渼䬾㍀ⱂ⹄≆ⵈ", num);

            case BorderStyle.Emboss3D:
                return BookmarkStart.b("嬮夰䄲倴制紸縺值崾⹀あ㙄", num);

            case BorderStyle.Engrave3D:
                return BookmarkStart.b("嬮夰䄲倴制紸縺匼堾㍀≂㍄≆", num);

            case BorderStyle.Outset:
                return BookmarkStart.b("䀮䐰䜲䘴制䴸", num);

            case BorderStyle.Inset:
                return BookmarkStart.b("䘮弰䀲倴䌶", num);

            case BorderStyle.TwistedLines1:
                return BookmarkStart.b("嬮䘰娲䘴䌶尸强焼嘾⽀♂㙄癆", num);

            case BorderStyle.Cleared:
                return BookmarkStart.b("䄮堰弲", num);
        }
        return BookmarkStart.b("䄮帰崲倴", num);
    }

    private string method_358(DocPicture A_0)
    {
        int num = 6;
        StringBuilder builder = new StringBuilder();
        if (A_0.TextWrappingStyle != TextWrappingStyle.Inline)
        {
            builder.Append(BookmarkStart.b("尫䄭䌯嬱䀳張圷吹ػ弽∿ㅁ⭃⩅㵇㹉⥋畍", num));
        }
        builder.Append(BookmarkStart.b("䄫伭䈯唱崳堵ᔷ嘹夻堽㐿硁", num));
        builder.Append(A_0.HorizontalPosition.ToString().Replace(BookmarkStart.b("+", num), BookmarkStart.b("ȫ", num)));
        builder.Append(BookmarkStart.b("尫娭ଯ弱唳䐵強匹刻ጽ㐿ⵁ㑃籅", num));
        builder.Append(A_0.VerticalPosition.ToString().Replace(BookmarkStart.b("+", num), BookmarkStart.b("ȫ", num)));
        builder.Append(BookmarkStart.b("尫娭ଯ䔱崳刵䰷刹ػ", num));
        int num4 = (int) Math.Round((double) ((A_0.Width * A_0.WidthScale) / 100f));
        builder.Append(num4);
        builder.Append(BookmarkStart.b("尫娭ଯ娱儳張強刹䠻н", num));
        int num5 = (int) Math.Round((double) ((A_0.Height * A_0.HeightScale) / 100f));
        builder.Append(num5);
        builder.Append(BookmarkStart.b("尫娭", num));
        if (A_0.HorizontalOrigin != HorizontalOrigin.Column)
        {
            builder.Append(BookmarkStart.b("ᜫ䌭䌯崱ᤳ䘵圷䤹唻䨽⤿ⵁ⩃歅⁇╉㹋❍⩏㵑㩓≕㥗㙙煛ⱝ՟๡գብŧᱩ५呭", num));
            builder.Append(this.method_257(A_0.HorizontalOrigin));
        }
        if (A_0.VerticalOrigin != VerticalOrigin.Paragraph)
        {
            builder.Append(BookmarkStart.b("ᜫ䌭䌯崱ᤳ䘵圷䤹唻䨽⤿ⵁ⩃歅㹇⽉㹋㩍㥏ㅑ㕓㩕畗⡙㥛㉝şᙡൣၥ൧偩", num));
            builder.Append(this.method_259(A_0.VerticalOrigin));
        }
        if (A_0.HorizontalAlignment != ShapeHorizontalAlignment.None)
        {
            builder.Append(BookmarkStart.b("ᜫ䌭䌯崱ᤳ䘵圷䤹唻䨽⤿ⵁ⩃歅⁇╉㹋❍⩏㵑㩓≕㥗㙙晛", num));
            builder.Append(A_0.HorizontalAlignment.ToString().ToLower());
        }
        if (A_0.VerticalAlignment != ShapeVerticalAlignment.None)
        {
            builder.Append(BookmarkStart.b("ᜫ䌭䌯崱ᤳ䘵圷䤹唻䨽⤿ⵁ⩃歅㹇⽉㹋㩍㥏ㅑ㕓㩕扗", num));
            builder.Append(A_0.VerticalAlignment.ToString().ToLower());
        }
        if (A_0.OrderIndex != 0x7fffffffL)
        {
            builder.Append(BookmarkStart.b("ᜫ吭ᴯ嬱娳刵崷䈹ػ", num) + ((A_0.TextWrappingStyleEx == TextWrappingStyle.Behind) ? -Math.Abs(A_0.OrderIndex) : Math.Abs(A_0.OrderIndex)).ToString());
        }
        builder.Append(BookmarkStart.b("ᜫ堭夯䄱崳吵儷嘹唻䨽㤿硁㉃⽅㭇⍉⹋≍㕏", num));
        return builder.ToString();
    }

    private void method_359(ShapeGroup A_0)
    {
        if (A_0 != null)
        {
            this.method_342(A_0);
        }
    }

    private List<int> method_36()
    {
        if (this.list_1 == null)
        {
            this.list_1 = new List<int>();
        }
        return this.list_1;
    }

    private string method_360(IDocumentObject A_0)
    {
        StringBuilder builder = new StringBuilder();
        return builder.ToString();
    }

    private string method_361(ShapeObject A_0)
    {
        int num = 10;
        StringBuilder builder = new StringBuilder();
        if (A_0.TextWrappingStyle != TextWrappingStyle.Inline)
        {
            builder.Append(BookmarkStart.b("䀯崱䜳張䰷匹医倽稿⍁♃㕅❇♉㥋㩍㕏楑", num));
        }
        builder.Append(BookmarkStart.b("崯匱䘳儵儷吹ᄻ刽┿⑁ぃ籅", num));
        builder.Append(A_0.HorizontalAlignment.ToString().Replace(BookmarkStart.b("ᰯ", num), BookmarkStart.b("ḯ", num)));
        builder.Append(BookmarkStart.b("䀯䘱༳嬵夷䠹嬻圽⸿潁ぃ⥅㡇灉", num));
        builder.Append(A_0.VerticalAlignment.ToString().Replace(BookmarkStart.b("ᰯ", num), BookmarkStart.b("ḯ", num)));
        builder.Append(BookmarkStart.b("䀯䘱༳䄵儷帹䠻嘽稿", num));
        builder.Append(A_0.Width.ToString());
        builder.Append(BookmarkStart.b("䀯䘱༳帵崷匹嬻嘽㐿硁", num));
        builder.Append(A_0.Height.ToString());
        builder.Append(BookmarkStart.b("䀯䘱", num));
        if (A_0.HorizontalOrigin != HorizontalOrigin.Column)
        {
            builder.Append(BookmarkStart.b("ଯ弱䜳夵ᔷ䨹医䴽⤿㙁ⵃ⥅♇杉⑋⅍≏㭑⹓㥕㙗⹙㵛㉝䵟ၡţ੥१ṩիᡭᕯ䡱", num));
            builder.Append(this.method_257(A_0.HorizontalOrigin));
        }
        if (A_0.VerticalOrigin != VerticalOrigin.Paragraph)
        {
            builder.Append(BookmarkStart.b("ଯ弱䜳夵ᔷ䨹医䴽⤿㙁ⵃ⥅♇杉㩋⭍≏♑㵓㕕㥗㙙煛ⱝ՟๡գብŧᱩ५呭", num));
            builder.Append(this.method_259(A_0.VerticalOrigin));
        }
        if (A_0.HorizontalAlignment != ShapeHorizontalAlignment.None)
        {
            builder.Append(BookmarkStart.b("ଯ弱䜳夵ᔷ䨹医䴽⤿㙁ⵃ⥅♇杉⑋⅍≏㭑⹓㥕㙗⹙㵛㉝婟", num));
            builder.Append(A_0.HorizontalAlignment.ToString().ToLower());
        }
        if (A_0.VerticalAlignment != ShapeVerticalAlignment.None)
        {
            builder.Append(BookmarkStart.b("ଯ弱䜳夵ᔷ䨹医䴽⤿㙁ⵃ⥅♇杉㩋⭍≏♑㵓㕕㥗㙙晛", num));
            builder.Append(A_0.VerticalAlignment.ToString().ToLower());
        }
        if (A_0.ZOrder != 0x7fffffffL)
        {
            builder.Append(BookmarkStart.b("ଯ䠱ᤳ張嘷帹夻䘽稿", num) + A_0.ZOrder.ToString());
        }
        builder.Append(BookmarkStart.b("ଯ䐱崳䔵儷堹唻刽⤿㙁㵃籅㹇⍉㽋❍㉏㹑ㅓ", num));
        return builder.ToString();
    }

    private void method_362(Class1 A_0)
    {
        int num = 8;
        string str = string.Empty;
        str = this.method_335(A_0, false, null);
        this.class1092_0.method_10(BookmarkStart.b("崭堯匱䐳匵", 8), this.dictionary_32[BookmarkStart.b("堭", 8)]);
        this.class1092_0.method_4(BookmarkStart.b("娭䤯䈱儳", 8), BookmarkStart.b("ഭ漯䨱гص࠷ਹ挻䨽眿睁", 8));
        string str2 = this.method_363(A_0);
        this.class1092_0.method_4(BookmarkStart.b("崭䐯䬱堳匵", 8), str2);
        if (!A_0.Borders.NoBorder)
        {
            this.class1092_0.method_4(BookmarkStart.b("崭䐯䀱嬳崵崷帹", num), BookmarkStart.b("娭", num));
            if (((A_0.Borders.Left.BorderType != BorderStyle.None) && !A_0.Borders.Left.Color.IsEmpty) && (A_0.Borders.Left.Color != Color.Black))
            {
                string str3 = ColorTranslator.ToHtml(A_0.Borders.Left.Color);
                this.class1092_0.method_4(BookmarkStart.b("崭䐯䀱嬳崵崷夹医刽⼿ぁ", num), str3);
            }
            if ((A_0.Borders.Left.BorderType != BorderStyle.None) && (A_0.Borders.Left.LineWidth > 0f))
            {
                this.class1092_0.method_4(BookmarkStart.b("崭䐯䀱嬳崵崷䴹夻圽✿⩁ぃ", num), A_0.Borders.Left.LineWidth.ToString() + BookmarkStart.b("席䐯", num));
            }
            if ((A_0.Borders.Left.BorderType != BorderStyle.None) && (A_0.Borders.Left.BorderType != BorderStyle.Single))
            {
                this.class1092_0.method_10(BookmarkStart.b("崭䐯䀱嬳崵崷", num), this.dictionary_32[BookmarkStart.b("堭", num)]);
                this.class1092_0.method_4(BookmarkStart.b("䈭夯就儳䔵䰷䌹倻嬽", num), this.method_357(A_0.Borders.Left.BorderType, true));
                this.class1092_0.method_12();
            }
        }
        this.class1092_0.method_10(BookmarkStart.b("䜭崯匱匳匵尷嬹䠻弽", num), this.dictionary_32[BookmarkStart.b("堭", num)]);
        if (str != null)
        {
            this.class1092_0.method_5(BookmarkStart.b("䜭启", num), this.dictionary_32[BookmarkStart.b("尭", num)], str);
        }
        if (A_0.Title != null)
        {
            this.class1092_0.method_5(BookmarkStart.b("娭夯䘱堳匵", num), this.dictionary_32[BookmarkStart.b("䄭", num)], A_0.Title);
        }
        this.class1092_0.method_12();
        this.class1092_0.method_12();
    }

    private string method_363(Class1 A_0)
    {
        int num = 4;
        StringBuilder builder = new StringBuilder();
        builder.Append(BookmarkStart.b("娩䌫崭夯䘱崳夵嘷9崻尽㌿ⵁ⡃㍅㱇⽉睋", 4));
        if (A_0.method_111() != 0f)
        {
            builder.Append(BookmarkStart.b("䘩䤫䠭䐯࠱", num));
            builder.Append(((int) Math.Round((double) A_0.method_111())).ToString() + BookmarkStart.b("ᄩ", num));
        }
        if (A_0.method_115() != 0f)
        {
            builder.Append(BookmarkStart.b("帩䌫席ਯ", num));
            builder.Append(((int) Math.Round((double) A_0.method_115())).ToString() + BookmarkStart.b("ᄩ", num));
        }
        builder.Append(BookmarkStart.b("崩䔫䨭䐯娱ำ", num));
        int num4 = (int) Math.Round((double) A_0.method_121());
        builder.Append(num4);
        builder.Append(BookmarkStart.b("ᄩ䐫䬭夯唱尳䈵ȷ", num));
        int num5 = (int) Math.Round((double) A_0.method_123());
        builder.Append(num5);
        builder.Append(BookmarkStart.b("ᄩ娫䜭䌯嬱嘳張吷匹䠻䜽稿㑁ⵃ㕅ⅇ⡉⁋⭍歏㽑❓㥕畗ⵙ⹛㽝ၟ佡ᝣብᅧ٩५呭ͯͱų᝵੷ό", num));
        return builder.ToString();
    }

    internal void method_364(BookmarkEnd A_0)
    {
        if (this.dictionary_8.ContainsKey(A_0.Name))
        {
            int item = this.dictionary_8[A_0.Name];
            if (!A_0.IsCellGroupBkmk || (A_0.IsCellGroupBkmk && !this.list_3.Contains(item)))
            {
                this.method_365(item);
            }
            else
            {
                this.list_2.Add(item);
            }
        }
    }

    private void method_365(int A_0)
    {
        this.class1092_0.method_11(BookmarkStart.b("䈴", 15), BookmarkStart.b("圴堶嘸债值帾㍀⡂D⥆ⵈ", 15), this.dictionary_32[BookmarkStart.b("䈴", 15)]);
        this.class1092_0.method_6(BookmarkStart.b("䈴", 15), BookmarkStart.b("尴匶", 15), this.dictionary_32[BookmarkStart.b("䈴", 15)], A_0.ToString());
        this.class1092_0.method_12();
    }

    internal void method_366(BookmarkStart A_0)
    {
        int num = 5;
        string name = A_0.Name;
        int num2 = this.method_543();
        if (!this.dictionary_8.ContainsKey(name))
        {
            this.dictionary_8.Add(name, num2);
        }
        else
        {
            this.dictionary_8[name] = num2;
        }
        if ((A_0.ColumnFirst >= 0) && (A_0.ColumnLast >= 0))
        {
            this.list_3.Add(num2);
        }
        this.class1092_0.method_11(BookmarkStart.b("尪", num), BookmarkStart.b("䤪䈬䀮娰帲吴䔶券栺䤼帾㍀㝂", num), this.dictionary_32[BookmarkStart.b("尪", num)]);
        if (A_0.ColumnFirst >= 0)
        {
            this.class1092_0.method_6(BookmarkStart.b("尪", num), BookmarkStart.b("䠪䈬䌮眰娲䜴䐶䴸", num), this.dictionary_32[BookmarkStart.b("尪", num)], A_0.ColumnFirst.ToString());
        }
        if (A_0.ColumnLast >= 0)
        {
            this.class1092_0.method_6(BookmarkStart.b("尪", num), BookmarkStart.b("䠪䈬䌮細刲䘴䌶", num), this.dictionary_32[BookmarkStart.b("尪", num)], A_0.ColumnLast.ToString());
        }
        this.class1092_0.method_6(BookmarkStart.b("尪", num), BookmarkStart.b("䈪䤬", num), this.dictionary_32[BookmarkStart.b("尪", num)], num2.ToString());
        this.class1092_0.method_6(BookmarkStart.b("尪", num), BookmarkStart.b("䔪䰬䈮吰", num), this.dictionary_32[BookmarkStart.b("尪", num)], name);
        this.class1092_0.method_12();
    }

    private void method_367(BreakType A_0)
    {
        this.method_368(null, A_0, LineBreakClear.None);
    }

    private void method_368(TextRange A_0, BreakType A_1, LineBreakClear A_2)
    {
        int num = 0;
        this.class1092_0.method_10(BookmarkStart.b("吥", 0), this.dictionary_32[BookmarkStart.b("儥", 0)]);
        if ((A_0 != null) && (A_1 == BreakType.LineBreak))
        {
            this.method_463(A_0.CharacterFormat);
        }
        this.class1092_0.method_10(BookmarkStart.b("䐥娧", num), this.dictionary_32[BookmarkStart.b("儥", num)]);
        if (A_1 == BreakType.ColumnBreak)
        {
            this.class1092_0.method_5(BookmarkStart.b("別儧娩䤫", num), this.dictionary_32[BookmarkStart.b("儥", num)], BookmarkStart.b("䔥䜧䘩夫䌭帯", num));
        }
        else if (A_1 == BreakType.PageBreak)
        {
            this.class1092_0.method_5(BookmarkStart.b("別儧娩䤫", num), this.dictionary_32[BookmarkStart.b("儥", num)], BookmarkStart.b("嘥䤧䴩䤫", num));
        }
        else if (A_2 != LineBreakClear.None)
        {
            this.class1092_0.method_5(BookmarkStart.b("䔥䐧伩䴫尭", num), this.dictionary_32[BookmarkStart.b("儥", num)], this.method_256(A_2));
        }
        this.class1092_0.method_12();
        this.class1092_0.method_12();
    }

    private void method_369(Break A_0)
    {
        int num = 6;
        if (!A_0.IsCrBreak)
        {
            this.method_368(A_0.TextRange, A_0.BreakType, A_0.ClearType);
        }
        else
        {
            this.class1092_0.method_10(BookmarkStart.b("師", num), this.dictionary_32[BookmarkStart.b("嬫", num)]);
            this.class1092_0.method_10(BookmarkStart.b("伫尭", num), this.dictionary_32[BookmarkStart.b("嬫", num)]);
            this.class1092_0.method_12();
            this.class1092_0.method_12();
        }
    }

    private List<int> method_37()
    {
        if (this.list_0 == null)
        {
            this.list_0 = new List<int>();
        }
        return this.list_0;
    }

    private void method_370(Paragraph A_0)
    {
        int num = 2;
        if (A_0.Owner != null)
        {
            A_0.Format.PageBreakAfter = false;
            if (A_0.NextSibling is Paragraph)
            {
                Paragraph nextSibling = A_0.NextSibling as Paragraph;
                nextSibling.Items.Insert(0, new Break(A_0.Document, BreakType.PageBreak));
            }
            else
            {
                int num2 = A_0.method_5();
                Paragraph entity = new Paragraph(A_0.Document);
                entity.AppendBreak(BreakType.PageBreak);
                entity.AppendText(BookmarkStart.b("ࠧ", num));
                ICompositeObject owner = A_0.Owner as ICompositeObject;
                if (owner.ChildObjects.Count == (num2 + 1))
                {
                    owner.ChildObjects.Add(entity);
                }
                else
                {
                    owner.ChildObjects.Insert(num2 + 1, entity);
                }
            }
        }
    }

    private void method_371(Comment A_0)
    {
        int num = 14;
        string key = null;
        if ((this.dictionary_18 != null) && this.dictionary_18.ContainsKey(A_0.Format.CommentId))
        {
            key = this.dictionary_18[A_0.Format.CommentId];
        }
        else
        {
            key = this.method_528().ToString();
        }
        this.method_14().Add(key, A_0);
        this.bool_8 = true;
        if (A_0.AppendItems)
        {
            this.method_372(A_0, key);
        }
        this.class1092_0.method_10(BookmarkStart.b("䘳", num), this.dictionary_32[BookmarkStart.b("䌳", num)]);
        this.class1092_0.method_10(BookmarkStart.b("圳夵唷圹夻倽㐿၁⅃⁅ⵇ㡉⥋⁍㍏㝑", num), this.dictionary_32[BookmarkStart.b("䌳", num)]);
        this.class1092_0.method_5(BookmarkStart.b("崳刵", num), this.dictionary_32[BookmarkStart.b("䌳", num)], key);
        this.class1092_0.method_12();
        this.class1092_0.method_12();
    }

    private void method_372(Comment A_0, string A_1)
    {
        int num = 1;
        if (A_0.BodyPart != null)
        {
            this.class1092_0.method_12();
            this.method_373(A_1);
            this.method_116(A_0.BodyPart.BodyItems, false);
            this.method_374(A_1);
            this.class1092_0.method_10(BookmarkStart.b("圦", num), this.dictionary_32[BookmarkStart.b("倦", num)]);
            this.class1092_0.method_10(BookmarkStart.b("圦礨太", num), this.dictionary_32[BookmarkStart.b("倦", num)]);
            this.method_472(A_0.OwnerParagraph.Format, A_0.OwnerParagraph);
            this.class1092_0.method_12();
        }
        else if (A_0.Items.Count > 0)
        {
            this.method_373(A_1);
            this.method_189(A_0.Items);
            this.method_374(A_1);
        }
    }

    private void method_373(string A_0)
    {
        this.class1092_0.method_10(BookmarkStart.b("䔥䜧䜩䄫䬭帯䘱昳圵嘷崹夻洽㐿⍁㙃㉅", 0), this.dictionary_32[BookmarkStart.b("儥", 0)]);
        this.class1092_0.method_5(BookmarkStart.b("伥䰧", 0), this.dictionary_32[BookmarkStart.b("儥", 0)], A_0);
        this.class1092_0.method_12();
    }

    private void method_374(string A_0)
    {
        this.class1092_0.method_10(BookmarkStart.b("䰮帰帲場制圸伺漼帾⽀⑂⁄Ɇ❈⽊", 9), this.dictionary_32[BookmarkStart.b("堮", 9)]);
        this.class1092_0.method_5(BookmarkStart.b("䘮唰", 9), this.dictionary_32[BookmarkStart.b("堮", 9)], A_0);
        this.class1092_0.method_12();
    }

    private void method_375()
    {
        int num = 6;
        this.dictionary_32 = this.document_0.DocxNameSpace.method_0()[BookmarkStart.b("䐫䬭儯嘱儳䐵帷唹医䨽┿ぁ", 6)];
        MemoryStream stream = new MemoryStream();
        this.class1092_0 = this.method_524(stream);
        this.class1092_0.method_11(BookmarkStart.b("嬫", 6), BookmarkStart.b("伫䄭崯弱儳堵䰷䤹", 6), this.dictionary_32[BookmarkStart.b("嬫", 6)]);
        this.class1092_0.method_6(BookmarkStart.b("含䌭尯就䜳", 6), BookmarkStart.b("娫", 6), null, this.dictionary_32[BookmarkStart.b("娫", 6)]);
        this.class1092_0.method_6(BookmarkStart.b("含䌭尯就䜳", 6), BookmarkStart.b("嬫Ἥ/", 6), null, this.dictionary_32[BookmarkStart.b("嬫Ἥ/", 6)]);
        this.class1092_0.method_6(BookmarkStart.b("含䌭尯就䜳", 6), BookmarkStart.b("䌫", 6), null, this.dictionary_32[BookmarkStart.b("䌫", 6)]);
        this.class1092_0.method_6(BookmarkStart.b("含䌭尯就䜳", 6), BookmarkStart.b("䄫䴭", 6), null, this.dictionary_32[BookmarkStart.b("䄫䴭", 6)]);
        this.class1092_0.method_6(BookmarkStart.b("含䌭尯就䜳", 6), BookmarkStart.b("師", 6), null, this.dictionary_32[BookmarkStart.b("師", 6)]);
        this.class1092_0.method_6(BookmarkStart.b("含䌭尯就䜳", 6), BookmarkStart.b("䄫", 6), null, this.dictionary_32[BookmarkStart.b("䄫", 6)]);
        this.class1092_0.method_6(BookmarkStart.b("含䌭尯就䜳", 6), BookmarkStart.b("嬫䀭唯", 6), null, this.dictionary_32[BookmarkStart.b("嬫䀭唯", 6)]);
        this.class1092_0.method_6(BookmarkStart.b("含䌭尯就䜳", 6), BookmarkStart.b("䴫", 6), null, this.dictionary_32[BookmarkStart.b("䴫", 6)]);
        this.class1092_0.method_6(BookmarkStart.b("含䌭尯就䜳", 6), BookmarkStart.b("尫䜭匯", 6), null, this.dictionary_32[BookmarkStart.b("尫䜭匯", 6)]);
        this.class1092_0.method_6(BookmarkStart.b("含䌭尯就䜳", 6), BookmarkStart.b("嬫席", 6), null, this.dictionary_32[BookmarkStart.b("嬫席", 6)]);
        this.class1092_0.method_6(BookmarkStart.b("含䌭尯就䜳", 6), BookmarkStart.b("娫䬭", 6), null, this.dictionary_32[BookmarkStart.b("娫䬭", 6)]);
        if (this.document_0.method_159() >= 15)
        {
            this.class1092_0.method_6(BookmarkStart.b("含䌭尯就䜳", num), BookmarkStart.b("嬫ἭЯ", num), null, this.dictionary_32[BookmarkStart.b("嬫ἭЯ", num)]);
            this.bool_25 = true;
        }
        foreach (string str in this.method_14().Keys)
        {
            Comment comment = this.method_14()[str];
            this.comment_0 = comment;
            this.method_376(comment, str);
        }
        this.bool_25 = false;
        this.comment_0 = null;
        this.class1092_0.method_12();
        this.class1092_0.method_15();
        this.class771_0.method_14(BookmarkStart.b("嬫䄭䈯嘱栳唵圷圹儻嬽⸿㙁㝃桅ぇ❉⁋", num), stream, false, FileAttributes.Archive);
    }

    internal void method_376(Comment A_0, string A_1)
    {
        this.class1092_0.method_11(BookmarkStart.b("帨", 3), BookmarkStart.b("䨨䐪䀬䈮吰崲䄴", 3), this.dictionary_32[BookmarkStart.b("帨", 3)]);
        this.class1092_0.method_6(BookmarkStart.b("帨", 3), BookmarkStart.b("䀨伪", 3), this.dictionary_32[BookmarkStart.b("帨", 3)], A_1);
        this.class1092_0.method_6(BookmarkStart.b("帨", 3), BookmarkStart.b("䠨帪夬䜮帰䄲", 3), this.dictionary_32[BookmarkStart.b("帨", 3)], A_0.Format.Author);
        this.class1092_0.method_6(BookmarkStart.b("帨", 3), BookmarkStart.b("䴨䨪夬䨮", 3), this.dictionary_32[BookmarkStart.b("帨", 3)], A_0.Format.DateTime.ToString(BookmarkStart.b("娨", 3)) + BookmarkStart.b("猨", 3));
        this.class1092_0.method_6(BookmarkStart.b("帨", 3), BookmarkStart.b("䀨䔪䐬嬮堰刲头䐶", 3), this.dictionary_32[BookmarkStart.b("帨", 3)], A_0.Format.Initial);
        for (int i = 0; i < A_0.Body.Items.Count; i++)
        {
            this.method_117(A_0.Body.Items[i], true);
        }
        this.class1092_0.method_12();
    }

    private void method_377(CommentMark A_0)
    {
        string str = null;
        if (A_0.Type == CommentMarkType.CommentStart)
        {
            Class323.smethod_3().Add(A_0.CommentId);
            str = this.method_528().ToString();
            this.method_15().Add(A_0.CommentId, str);
            this.method_373(str);
        }
        else if ((this.dictionary_18 != null) && this.dictionary_18.ContainsKey(A_0.CommentId))
        {
            str = this.dictionary_18[A_0.CommentId];
            this.method_374(str);
        }
    }

    private void method_378()
    {
        int num = 10;
        if ((this.document_0.method_159() >= 15) && (this.method_6().Count > 0))
        {
            this.bool_9 = true;
            this.dictionary_32 = this.document_0.DocxNameSpace.method_0()[BookmarkStart.b("堯圱唳刵崷䠹娻儽⼿㙁⅃㑅", num)];
            MemoryStream stream = new MemoryStream();
            this.class1092_0 = this.method_524(stream);
            this.class1092_0.method_11(BookmarkStart.b("䜯̱ĳ", num), BookmarkStart.b("匯崱夳嬵崷吹䠻䴽Կ㩁", num), this.dictionary_32[BookmarkStart.b("䜯̱ĳ", num)]);
            this.class1092_0.method_6(BookmarkStart.b("䠯弱堳堵䬷", num), BookmarkStart.b("䘯", num), null, this.dictionary_32[BookmarkStart.b("䘯", num)]);
            this.class1092_0.method_6(BookmarkStart.b("䠯弱堳堵䬷", num), BookmarkStart.b("䜯̱г", num), null, this.dictionary_32[BookmarkStart.b("䜯̱г", num)]);
            this.class1092_0.method_6(BookmarkStart.b("䠯弱堳堵䬷", num), BookmarkStart.b("弯", num), null, this.dictionary_32[BookmarkStart.b("弯", num)]);
            this.class1092_0.method_6(BookmarkStart.b("䠯弱堳堵䬷", num), BookmarkStart.b("崯儱", num), null, this.dictionary_32[BookmarkStart.b("崯儱", num)]);
            this.class1092_0.method_6(BookmarkStart.b("䠯弱堳堵䬷", num), BookmarkStart.b("䈯", num), null, this.dictionary_32[BookmarkStart.b("䈯", num)]);
            this.class1092_0.method_6(BookmarkStart.b("䠯弱堳堵䬷", num), BookmarkStart.b("崯", num), null, this.dictionary_32[BookmarkStart.b("崯", num)]);
            this.class1092_0.method_6(BookmarkStart.b("䠯弱堳堵䬷", num), BookmarkStart.b("䜯就儳", num), null, this.dictionary_32[BookmarkStart.b("䜯就儳", num)]);
            this.class1092_0.method_6(BookmarkStart.b("䠯弱堳堵䬷", num), BookmarkStart.b("儯", num), null, this.dictionary_32[BookmarkStart.b("儯", num)]);
            this.class1092_0.method_6(BookmarkStart.b("䠯弱堳堵䬷", num), BookmarkStart.b("䀯嬱圳", num), null, this.dictionary_32[BookmarkStart.b("䀯嬱圳", num)]);
            this.class1092_0.method_6(BookmarkStart.b("䠯弱堳堵䬷", num), BookmarkStart.b("䜯䈱", num), null, this.dictionary_32[BookmarkStart.b("䜯䈱", num)]);
            this.class1092_0.method_6(BookmarkStart.b("䠯弱堳堵䬷", num), BookmarkStart.b("䘯圱", num), null, this.dictionary_32[BookmarkStart.b("䘯圱", num)]);
            this.class1092_0.method_6(BookmarkStart.b("䠯弱堳堵䬷", num), BookmarkStart.b("䜯̱3", num), null, this.dictionary_32[BookmarkStart.b("䜯̱3", num)]);
            this.class1092_0.method_6(BookmarkStart.b("䠯弱堳堵䬷", num), BookmarkStart.b("䜯̱ĳ", num), null, this.dictionary_32[BookmarkStart.b("䜯̱ĳ", num)]);
            Dictionary<Comment, string> dictionary = new Dictionary<Comment, string>();
            foreach (Comment comment in this.method_6().Keys)
            {
                string str = this.method_6()[comment];
                this.method_379(comment, str, dictionary);
                string str2 = dictionary.ContainsKey(comment) ? dictionary[comment] : string.Empty;
                this.class1092_0.method_11(BookmarkStart.b("䜯̱ĳ", num), BookmarkStart.b("匯崱夳嬵崷吹䠻笽㠿", num), this.dictionary_32[BookmarkStart.b("䜯̱ĳ", num)]);
                this.class1092_0.method_6(BookmarkStart.b("䜯̱ĳ", num), BookmarkStart.b("䀯匱䘳圵焷帹", num), this.dictionary_32[BookmarkStart.b("䜯̱ĳ", num)], str);
                if (!string.IsNullOrEmpty(str2))
                {
                    this.class1092_0.method_6(BookmarkStart.b("䜯̱ĳ", num), BookmarkStart.b("䀯匱䘳圵焷帹氻弽㈿❁⩃㉅", num), this.dictionary_32[BookmarkStart.b("䜯̱ĳ", num)], str2);
                }
                this.class1092_0.method_6(BookmarkStart.b("䜯̱ĳ", num), BookmarkStart.b("启崱娳匵", num), this.dictionary_32[BookmarkStart.b("䜯̱ĳ", num)], comment.MarkDone ? BookmarkStart.b("į", num) : BookmarkStart.b("/", num));
                this.class1092_0.method_12();
            }
            this.class1092_0.method_12();
            this.class1092_0.method_15();
            this.class771_0.method_14(BookmarkStart.b("䜯崱䘳刵搷夹医匽ⴿ❁⩃㉅㭇ཉ㑋㩍㕏㱑こ㍕㱗瑙⑛㍝౟", num), stream, false, FileAttributes.Archive);
        }
    }

    private void method_379(Comment A_0, string A_1, Dictionary<Comment, string> A_2)
    {
        if ((((A_0 != null) && (A_0.ReplyCommentItems.Count > 0)) && !string.IsNullOrEmpty(A_1)) && (A_2 != null))
        {
            int num = 0;
            int count = A_0.ReplyCommentItems.Count;
            while (num < count)
            {
                ParagraphBase base2 = A_0.ReplyCommentItems[num];
                if (base2 is Comment)
                {
                    Comment key = base2 as Comment;
                    if (A_2.ContainsKey(key))
                    {
                        break;
                    }
                    A_2.Add(key, A_1);
                    this.method_379(key, A_1, A_2);
                }
                num++;
            }
        }
    }

    internal Dictionary<string, Class517> method_38()
    {
        if (this.dictionary_3 == null)
        {
            this.dictionary_3 = new Dictionary<string, Class517>();
        }
        return this.dictionary_3;
    }

    private void method_380(ParagraphBase A_0)
    {
        int num = 8;
        if (A_0 is TextRange)
        {
            if ((A_0.PreviousSibling != null) && (A_0.PreviousSibling.PreviousSibling != null))
            {
                Field previousSibling = A_0.PreviousSibling.PreviousSibling as Field;
                if ((previousSibling != null) && (previousSibling.Type == FieldType.FieldFileName))
                {
                    return;
                }
            }
            if (!this.method_311(A_0))
            {
                TextRange range = A_0 as TextRange;
                if (!string.IsNullOrEmpty(range.Text))
                {
                    Footnote owner = null;
                    Comment comment = null;
                    if ((range.OwnerParagraph != null) && (range.OwnerParagraph.OwnerTextBody != null))
                    {
                        owner = range.OwnerParagraph.OwnerTextBody.Owner as Footnote;
                        comment = range.OwnerParagraph.OwnerTextBody.Owner as Comment;
                    }
                    if (owner != null)
                    {
                        char ch2 = '\x0002';
                        if (range.Text == ch2.ToString())
                        {
                            this.class1092_0.method_11(BookmarkStart.b("夭", num), BookmarkStart.b("尭", num), this.dictionary_32[BookmarkStart.b("夭", num)]);
                            this.method_463(range.CharacterFormat);
                            if (owner.FootnoteType == FootnoteType.Endnote)
                            {
                                this.class1092_0.method_10(BookmarkStart.b("䬭帯嘱娳夵䰷弹渻嬽☿", num), this.dictionary_32[BookmarkStart.b("夭", num)]);
                                this.class1092_0.method_12();
                            }
                            else
                            {
                                this.class1092_0.method_10(BookmarkStart.b("䠭弯崱䀳堵圷丹夻氽┿⑁", num), this.dictionary_32[BookmarkStart.b("夭", num)]);
                                this.class1092_0.method_12();
                            }
                            this.class1092_0.method_12();
                            return;
                        }
                    }
                    if (owner == null)
                    {
                        char ch3 = '\x0002';
                        if (range.Text == ch3.ToString())
                        {
                            this.class1092_0.method_11(BookmarkStart.b("夭", num), BookmarkStart.b("尭", num), this.dictionary_32[BookmarkStart.b("夭", num)]);
                            this.method_463(range.CharacterFormat);
                            this.class1092_0.method_10(BookmarkStart.b("䠭弯崱䀳堵圷丹夻氽┿⑁", num), this.dictionary_32[BookmarkStart.b("夭", num)]);
                            this.class1092_0.method_12();
                            this.class1092_0.method_12();
                            return;
                        }
                    }
                    if (comment != null)
                    {
                        char ch = '\x0005';
                        if (range.Text == ch.ToString())
                        {
                            this.class1092_0.method_11(BookmarkStart.b("夭", num), BookmarkStart.b("尭", num), this.dictionary_32[BookmarkStart.b("夭", num)]);
                            this.method_463(range.CharacterFormat);
                            this.class1092_0.method_10(BookmarkStart.b("伭帯就嬳䈵夷丹唻儽⸿၁⅃⁅", num), this.dictionary_32[BookmarkStart.b("夭", num)]);
                            this.class1092_0.method_12();
                            this.class1092_0.method_12();
                            return;
                        }
                    }
                    string text = range.Text;
                    string str = this.method_547(range.Text);
                    int index = str.IndexOf('\r');
                    if ((index != -1) && (range.OwnerParagraph != null))
                    {
                        string str2 = str.Substring(0, index);
                        string str3 = str.Substring(index + 1);
                        this.class1092_0.method_11(BookmarkStart.b("夭", num), BookmarkStart.b("尭", num), this.dictionary_32[BookmarkStart.b("夭", num)]);
                        this.method_463(range.CharacterFormat);
                        this.method_382(str2, range.CharacterFormat.IsDeleteRevision);
                        this.class1092_0.method_12();
                        range.Text = str2;
                        Paragraph entity = new Paragraph(this.document_0);
                        TextRange range2 = new TextRange(this.document_0);
                        Paragraph ownerParagraph = range.OwnerParagraph;
                        Body body = range.OwnerParagraph.Owner as Body;
                        entity.Format.ImportContainer(ownerParagraph.Format);
                        entity.Format.method_21(ownerParagraph.Format);
                        entity.ListFormat.ImportContainer(ownerParagraph.ListFormat);
                        if (ownerParagraph.StyleName != null)
                        {
                            entity.ApplyStyle(ownerParagraph.StyleName);
                        }
                        entity.BreakCharacterFormat.ImportContainer(ownerParagraph.BreakCharacterFormat);
                        entity.BreakCharacterFormat.method_21(ownerParagraph.BreakCharacterFormat);
                        int num3 = ownerParagraph.method_5() + 1;
                        body.ChildObjects.Insert(num3, entity);
                        range2.Text = str3;
                        range2.CharacterFormat.ImportContainer(range.CharacterFormat);
                        range2.CharacterFormat.method_21(range.CharacterFormat);
                        entity.Items.Insert(0, range2);
                        this.method_383(entity, ownerParagraph, range.method_5() + 1);
                    }
                    else
                    {
                        this.class1092_0.method_11(BookmarkStart.b("夭", num), BookmarkStart.b("尭", num), this.dictionary_32[BookmarkStart.b("夭", num)]);
                        this.method_463(range.CharacterFormat);
                        this.method_382(str, range.CharacterFormat.IsDeleteRevision);
                        this.class1092_0.method_12();
                    }
                }
            }
        }
    }

    private void method_381()
    {
        int num = 15;
        CharacterFormat characterFormat = this.textRange_0.CharacterFormat;
        Paragraph ownerParagraph = this.textRange_0.OwnerParagraph;
        string str = string.Empty;
        int index = 1;
        int length = this.string_4.Length;
        while (index < length)
        {
            str = this.string_4[index];
            if ((index == (length - 1)) && string.IsNullOrEmpty(str))
            {
                char ch = '\n';
                if (!ownerParagraph.Text.EndsWith(ch.ToString()))
                {
                    goto Label_0153;
                }
            }
            ownerParagraph.Format.PageBreakAfter = false;
            ownerParagraph.Format.PageBreakBefore = false;
            this.class1092_0.method_10(BookmarkStart.b("䔴", num), this.dictionary_32[BookmarkStart.b("䈴", num)]);
            this.class1092_0.method_10(BookmarkStart.b("䔴朶䬸", num), this.dictionary_32[BookmarkStart.b("䈴", num)]);
            this.method_472(ownerParagraph.Format, ownerParagraph);
            this.class1092_0.method_12();
            this.class1092_0.method_10(BookmarkStart.b("䜴", num), this.dictionary_32[BookmarkStart.b("䈴", num)]);
            this.method_463(characterFormat);
            bool isDeleteRevision = characterFormat.IsDeleteRevision;
            this.method_382(str, isDeleteRevision);
            this.class1092_0.method_12();
            this.class1092_0.method_12();
        Label_0153:
            index++;
        }
    }

    private void method_382(string A_0, bool A_1)
    {
        int num = 6;
        char[] anyOf = new char[] { '\f', '\v', '\t', '\0', '\x001e', '\x001f', '\x0003' };
        int startIndex = 0;
        for (int i = A_0.IndexOfAny(anyOf); i != -1; i = A_0.IndexOfAny(anyOf))
        {
            string str = A_0.Substring(startIndex, i);
            char ch2 = A_0[i];
            if (str != string.Empty)
            {
                this.method_384(str, A_1);
            }
            switch (ch2)
            {
                case '\0':
                    this.class1092_0.method_10(BookmarkStart.b("尫䤭縯䜱夳", num), this.dictionary_32[BookmarkStart.b("嬫", num)]);
                    this.class1092_0.method_12();
                    break;

                case '\x0003':
                    this.class1092_0.method_10(BookmarkStart.b("弫䬭䀯匱䘳圵䰷唹主", num), this.dictionary_32[BookmarkStart.b("嬫", num)]);
                    this.class1092_0.method_12();
                    break;

                case '\t':
                    this.class1092_0.method_11(BookmarkStart.b("嬫", num), BookmarkStart.b("堫伭刯", num), this.dictionary_32[BookmarkStart.b("嬫", num)]);
                    this.class1092_0.method_12();
                    break;

                case '\v':
                    this.class1092_0.method_11(BookmarkStart.b("嬫", num), BookmarkStart.b("丫尭", num), this.dictionary_32[BookmarkStart.b("嬫", num)]);
                    this.class1092_0.method_12();
                    break;

                case '\f':
                    this.class1092_0.method_11(BookmarkStart.b("嬫", num), BookmarkStart.b("丫尭", num), this.dictionary_32[BookmarkStart.b("嬫", num)]);
                    this.class1092_0.method_6(BookmarkStart.b("嬫", num), BookmarkStart.b("堫圭䀯圱", num), this.dictionary_32[BookmarkStart.b("嬫", num)], BookmarkStart.b("尫伭圯圱", num));
                    this.class1092_0.method_12();
                    break;

                case '\x001e':
                    this.class1092_0.method_10(BookmarkStart.b("䈫䄭爯䀱儳圵匷爹䔻丽⠿❁⩃", num), this.dictionary_32[BookmarkStart.b("嬫", num)]);
                    this.class1092_0.method_12();
                    break;

                case '\x001f':
                    this.class1092_0.method_10(BookmarkStart.b("弫䄭嘯䘱簳伵䠷刹夻倽", num), this.dictionary_32[BookmarkStart.b("嬫", num)]);
                    this.class1092_0.method_12();
                    break;
            }
            A_0 = A_0.Substring(i + 1);
        }
        if (A_0 != string.Empty)
        {
            this.method_384(A_0, A_1);
        }
    }

    private void method_383(Paragraph A_0, Paragraph A_1, int A_2)
    {
        int num = A_1.Items.Count - A_2;
        for (int i = 0; i < num; i++)
        {
            IDocumentObject obj2 = A_1.ChildObjects[A_2];
            if (((obj2 is Field) && !(obj2 is MergeField)) || (obj2 is FormField))
            {
                A_0.ChildObjects.InnerList.Add(obj2);
                A_1.ChildObjects.InnerList.RemoveAt(A_2);
                A_0.LastChild.method_0(A_0);
                (obj2 as ParagraphBase).StartPos = (A_0.ChildObjects.Count > 1) ? (A_0.ChildObjects.InnerList[A_0.ChildObjects.InnerList.Count - 2] as ParagraphBase).EndPos : 0;
            }
            else
            {
                A_0.ChildObjects.Add(obj2);
            }
        }
    }

    private void method_384(string A_0, bool A_1)
    {
        int num = 8;
        if (A_1)
        {
            this.class1092_0.method_10(BookmarkStart.b("䨭唯帱怳匵䀷丹", num), this.dictionary_32[BookmarkStart.b("夭", num)]);
        }
        else
        {
            this.class1092_0.method_10(BookmarkStart.b("娭", num), this.dictionary_32[BookmarkStart.b("夭", num)]);
        }
        this.class1092_0.method_6(BookmarkStart.b("嘭崯帱", num), BookmarkStart.b("崭䀯匱圳匵", num), BookmarkStart.b("䘭䐯䘱䐳వ᜷ᔹ䬻䤽㜿汁㍃畅晇╉㹋⥍罏ੑᥓᩕ睗歙敛杝塟䵡੣ݥէཀྵὫṭᅯᅱᅳ", num), BookmarkStart.b("席䈯圱䜳匵䨷䰹夻", num));
        this.class1092_0.method_21(A_0);
        this.class1092_0.method_12();
    }

    private void method_385(TableOfContent A_0)
    {
        int num = 14;
        this.class1092_0.method_11(BookmarkStart.b("䌳", 14), BookmarkStart.b("䘳", 14), this.dictionary_32[BookmarkStart.b("䌳", 14)]);
        this.method_463(A_0.TOCField.CharacterFormat);
        this.class1092_0.method_11(BookmarkStart.b("䌳", 14), BookmarkStart.b("刳娵尷礹吻弽㈿", 14), this.dictionary_32[BookmarkStart.b("䌳", 14)]);
        this.class1092_0.method_6(BookmarkStart.b("䌳", 14), BookmarkStart.b("刳娵尷礹吻弽㈿ᙁ㵃㙅ⵇ", 14), this.dictionary_32[BookmarkStart.b("䌳", 14)], BookmarkStart.b("嘳匵強匹刻", 14));
        if (A_0.TOCField.IsLocked)
        {
            this.class1092_0.method_6(BookmarkStart.b("䌳", num), BookmarkStart.b("刳娵尷瘹医崽⬿", num), this.dictionary_32[BookmarkStart.b("䌳", num)], BookmarkStart.b("Գ", num));
        }
        this.class1092_0.method_12();
        this.class1092_0.method_12();
        this.class1092_0.method_11(BookmarkStart.b("䌳", num), BookmarkStart.b("䘳", num), this.dictionary_32[BookmarkStart.b("䌳", num)]);
        this.method_463(A_0.TOCField.CharacterFormat);
        this.class1092_0.method_11(BookmarkStart.b("䌳", num), BookmarkStart.b("崳堵䬷丹主樽┿㩁ぃ", num), this.dictionary_32[BookmarkStart.b("䌳", num)]);
        this.class1092_0.method_21(this.method_386(FieldType.FieldTOC));
        A_0.method_33();
        this.class1092_0.method_21(BookmarkStart.b("ᐳ", num) + A_0.FormattingString);
        this.class1092_0.method_12();
        this.class1092_0.method_12();
    }

    private string method_386(FieldType A_0)
    {
        int num = 12;
        switch (A_0)
        {
            case FieldType.FieldRef:
                return BookmarkStart.b("怱焳瀵ᠷ", num);

            case FieldType.FieldIndexEntry:
                return BookmarkStart.b("樱焳ᘵ", num);

            case FieldType.FieldSet:
                return BookmarkStart.b("愱焳戵ᠷ", num);

            case FieldType.FieldIf:
                return BookmarkStart.b("笱爳ᘵ", num);

            case FieldType.FieldIndex:
                return BookmarkStart.b("笱稳爵紷戹᰻", num);

            case FieldType.FieldStyleRef:
                return BookmarkStart.b("愱怳漵琷缹渻笽ؿ扁", num);

            case FieldType.FieldSequence:
                return BookmarkStart.b("愱焳朵ᠷ", num);

            case FieldType.FieldTOC:
                return BookmarkStart.b("昱笳电ᠷ", num);

            case FieldType.FieldInfo:
                return BookmarkStart.b("笱稳瀵眷ᨹ", num);

            case FieldType.FieldTitle:
                return BookmarkStart.b("昱紳戵琷缹᰻", num);

            case FieldType.FieldSubject:
                return BookmarkStart.b("愱愳琵爷缹缻樽怿", num);

            case FieldType.FieldAuthor:
                return BookmarkStart.b("猱愳戵瀷甹渻ḽ", num);

            case FieldType.FieldKeyWord:
                return BookmarkStart.b("礱焳漵漷甹渻稽ጿ扁", num);

            case FieldType.FieldComments:
                return BookmarkStart.b("焱笳笵男缹爻樽ጿ扁", num);

            case FieldType.FieldLastSavedBy:
                return BookmarkStart.b("縱申攵氷椹紻栽Կفكὅ桇", num);

            case FieldType.FieldCreateDate:
                return BookmarkStart.b("焱昳猵礷渹礻稽ĿᙁŃ晅", num);

            case FieldType.FieldSaveDate:
                return BookmarkStart.b("愱申怵紷縹紻樽Կ扁", num);

            case FieldType.FieldPrintDate:
                return BookmarkStart.b("戱昳缵瘷渹砻缽ᐿ݁摃", num);

            case FieldType.FieldRevisionNum:
                return BookmarkStart.b("怱焳怵瘷漹焻ḽ", num);

            case FieldType.FieldEditTime:
                return BookmarkStart.b("眱瀳缵氷渹画猽Կ扁", num);

            case FieldType.FieldNumPages:
                return BookmarkStart.b("簱愳笵样笹笻笽ጿ扁", num);

            case FieldType.FieldNumWords:
                return BookmarkStart.b("簱愳笵漷甹渻稽ጿ扁", num);

            case FieldType.FieldNumChars:
                return BookmarkStart.b("簱愳笵笷爹紻氽ጿ扁", num);

            case FieldType.FieldFileName:
                return BookmarkStart.b("琱紳稵紷琹紻猽Կ扁", num);

            case FieldType.FieldTemplate:
                return BookmarkStart.b("昱焳笵样瘹紻樽Կ扁", num);

            case FieldType.FieldDate:
                return BookmarkStart.b("瘱申戵紷ᨹ", num);

            case FieldType.FieldTime:
                return BookmarkStart.b("昱紳笵紷ᨹ", num);

            case FieldType.FieldPage:
                return BookmarkStart.b("戱申焵紷ᨹ", num);

            case FieldType.FieldQuote:
                return BookmarkStart.b("挱愳礵氷缹᰻", num);

            case FieldType.FieldPageRef:
                return BookmarkStart.b("戱申焵紷根礻砽怿", num);

            case FieldType.FieldAsk:
                return BookmarkStart.b("猱朳紵ᠷ", num);

            case FieldType.FieldFillIn:
                return BookmarkStart.b("琱紳稵琷猹爻ḽ", num);

            case FieldType.FieldPrint:
                return BookmarkStart.b("戱昳缵瘷渹᰻", num);

            case FieldType.FieldFormula:
                return BookmarkStart.b("༱ᐳ", num);

            case FieldType.FieldGoToButton:
                return BookmarkStart.b("由笳戵眷砹椻樽ᐿു੃晅", num);

            case FieldType.FieldMacroButton:
                return BookmarkStart.b("缱申电樷甹縻欽ᐿᙁୃࡅ桇", num);

            case FieldType.FieldAutoNumOutline:
                return BookmarkStart.b("猱愳戵眷琹椻猽༿ᝁ၃晅", num);

            case FieldType.FieldAutoNumLegal:
                return BookmarkStart.b("猱愳戵眷琹椻猽ిՁࡃ晅", num);

            case FieldType.FieldAutoNum:
                return BookmarkStart.b("猱愳戵眷琹椻猽怿", num);

            case FieldType.FieldLink:
                return BookmarkStart.b("縱紳砵猷ᨹ", num);

            case FieldType.FieldSymbol:
                return BookmarkStart.b("愱洳笵稷甹瀻ḽ", num);

            case FieldType.FieldMergeField:
                return BookmarkStart.b("缱焳搵缷缹稻眽ԿแC晅", num);

            case FieldType.FieldUserName:
                return BookmarkStart.b("朱朳猵樷琹紻猽Կ扁", num);

            case FieldType.FieldUserInitials:
                return BookmarkStart.b("朱朳猵樷猹爻眽ᐿୁՃ੅ᭇ橉", num);

            case FieldType.FieldUserAddress:
                return BookmarkStart.b("朱朳猵樷笹砻稽ሿ݁ᝃᕅ桇", num);

            case FieldType.FieldBarCode:
                return BookmarkStart.b("瀱申搵笷甹砻笽怿", num);

            case FieldType.FieldDocVariable:
                return BookmarkStart.b("瘱笳电渷笹渻眽ĿAࡃͅ桇", num);

            case FieldType.FieldSection:
                return BookmarkStart.b("愱焳电氷猹猻瀽怿", num);

            case FieldType.FieldSectionPages:
                return BookmarkStart.b("愱焳电氷猹猻瀽ဿ́̓ͅᭇ橉", num);

            case FieldType.FieldIncludePicture:
                return BookmarkStart.b("笱稳电琷漹砻笽ဿୁ݃ቅᵇᡉो湍", num);

            case FieldType.FieldIncludeText:
                return BookmarkStart.b("笱稳电琷漹砻笽ᐿ݁᱃ቅ桇", num);

            case FieldType.FieldFileSize:
                return BookmarkStart.b("琱紳稵紷椹画搽Կ扁", num);

            case FieldType.FieldFormTextInput:
                return BookmarkStart.b("琱笳搵男渹礻昽ᐿ扁", num);

            case FieldType.FieldFormCheckBox:
                return BookmarkStart.b("琱笳搵男礹琻笽̿ुكॅ၇橉", num);

            case FieldType.FieldNoteRef:
                return BookmarkStart.b("簱笳戵紷根礻砽怿", num);

            case FieldType.FieldTOA:
                return BookmarkStart.b("昱笳眵ᠷ", num);

            case FieldType.FieldPrivate:
                return BookmarkStart.b("戱昳缵渷笹栻笽怿", num);

            case FieldType.FieldAutoText:
                return BookmarkStart.b("猱愳戵眷渹礻昽ᐿ扁", num);

            case FieldType.FieldAddin:
                return BookmarkStart.b("猱瀳爵焷琹᰻", num);

            case FieldType.FieldFormDropDown:
                return BookmarkStart.b("琱笳搵男縹渻焽ဿفୃᅅه橉", num);

            case FieldType.FieldAdvance:
                return BookmarkStart.b("猱瀳怵礷琹缻笽怿", num);

            case FieldType.FieldDocProperty:
                return BookmarkStart.b("瘱笳电样根猻渽Կ၁၃ὅ桇", num);

            case FieldType.FieldHyperlink:
                return BookmarkStart.b("稱洳昵紷根瀻眽฿ु摃", num);

            case FieldType.FieldAutoTextList:
                return BookmarkStart.b("猱愳戵眷渹礻昽ᐿแൃᕅ᱇橉", num);

            case FieldType.FieldListNum:
                return BookmarkStart.b("縱紳攵氷琹椻猽怿", num);

            case FieldType.FieldBidiOutline:
                return BookmarkStart.b("瀱紳爵焷甹椻樽ిୁ੃ͅ", num);

            case FieldType.FieldAddressBlock:
                return BookmarkStart.b("猱瀳爵樷缹漻洽ȿแୃՅ͇", num);
        }
        return string.Empty;
    }

    private void method_387(Section A_0)
    {
        int num = 0x13;
        this.class1092_0.method_11(BookmarkStart.b("丸", 0x13), BookmarkStart.b("䨸帺帼䬾ᅀㅂ", 0x13), this.dictionary_32[BookmarkStart.b("丸", 0x13)]);
        this.method_388(A_0.HeadersFooters);
        this.method_402(A_0, true);
        this.method_400(A_0.BreakCode);
        this.method_394(A_0.PageSetup);
        this.method_392(A_0);
        this.method_390(A_0);
        if (A_0.PageSetup.VerticalAlignment != PageAlignment.Top)
        {
            this.class1092_0.method_10(BookmarkStart.b("伸稺儼嘾♀ⵂ", num), this.dictionary_32[BookmarkStart.b("丸", num)]);
            switch (A_0.PageSetup.VerticalAlignment)
            {
                case PageAlignment.Top:
                    this.class1092_0.method_5(BookmarkStart.b("伸娺儼", num), this.dictionary_32[BookmarkStart.b("丸", num)], BookmarkStart.b("䴸吺䴼", num));
                    break;

                case PageAlignment.Middle:
                    this.class1092_0.method_5(BookmarkStart.b("伸娺儼", num), this.dictionary_32[BookmarkStart.b("丸", num)], BookmarkStart.b("娸帺匼䬾⑀ㅂ", num));
                    break;

                case PageAlignment.Justified:
                    this.class1092_0.method_5(BookmarkStart.b("伸娺儼", num), this.dictionary_32[BookmarkStart.b("丸", num)], BookmarkStart.b("嬸吺䤼圾", num));
                    break;

                case PageAlignment.Bottom:
                    this.class1092_0.method_5(BookmarkStart.b("伸娺儼", num), this.dictionary_32[BookmarkStart.b("丸", num)], BookmarkStart.b("嬸吺䤼䬾⹀⹂", num));
                    break;
            }
            this.class1092_0.method_12();
        }
        if (A_0.PageSetup.DifferentFirstPageHeaderFooter)
        {
            this.class1092_0.method_10(BookmarkStart.b("䴸刺䤼匾⑀ፂ≄", num), this.dictionary_32[BookmarkStart.b("丸", num)]);
            this.class1092_0.method_12();
        }
        this.method_391(A_0);
        if (A_0.PageSetup.Bidi)
        {
            this.class1092_0.method_10(BookmarkStart.b("嬸刺夼嘾", num), this.dictionary_32[BookmarkStart.b("丸", num)]);
            this.class1092_0.method_12();
        }
        this.method_389(A_0);
        this.class1092_0.method_12();
    }

    private void method_388(HeadersFooters A_0)
    {
        int num = 0x10;
        bool linkToPrevious = A_0.LinkToPrevious;
        string str = string.Empty;
        if (!linkToPrevious)
        {
            bool flag2 = false;
            Paragraph entity = null;
            if ((A_0.OwnerBase is Section) && ((A_0.OwnerBase as Section).PreviousSibling != null))
            {
                flag2 = true;
            }
            if ((A_0.FirstPageHeader.Items.Count > 0) || A_0.FirstPageHeader.HasWatermark)
            {
                flag2 = false;
                this.class1092_0.method_10(BookmarkStart.b("帵崷嬹堻嬽㈿၁⅃⁅ⵇ㡉⥋⁍㍏㝑", num), this.dictionary_32[BookmarkStart.b("䄵", num)]);
                this.class1092_0.method_5(BookmarkStart.b("䈵䄷䨹夻", num), this.dictionary_32[BookmarkStart.b("䄵", num)], BookmarkStart.b("倵儷䠹伻䨽", num));
                str = this.method_527();
                this.class1092_0.method_5(BookmarkStart.b("張尷", num), this.dictionary_32[BookmarkStart.b("䐵", num)], str);
                this.method_412(A_0.FirstPageHeader, HeaderFooterType.HeaderFirstPage, str);
                this.class1092_0.method_12();
            }
            if (A_0.FirstPageFooter.Items.Count > 0)
            {
                flag2 = false;
                this.class1092_0.method_10(BookmarkStart.b("倵圷唹䠻嬽㈿၁⅃⁅ⵇ㡉⥋⁍㍏㝑", num), this.dictionary_32[BookmarkStart.b("䄵", num)]);
                this.class1092_0.method_5(BookmarkStart.b("䈵䄷䨹夻", num), this.dictionary_32[BookmarkStart.b("䄵", num)], BookmarkStart.b("倵儷䠹伻䨽", num));
                str = this.method_527();
                this.class1092_0.method_5(BookmarkStart.b("張尷", num), this.dictionary_32[BookmarkStart.b("䐵", num)], str);
                this.method_412(A_0.FirstPageFooter, HeaderFooterType.FooterFirstPage, str);
                this.class1092_0.method_12();
            }
            if ((A_0.EvenHeader.Items.Count > 0) || A_0.EvenHeader.HasWatermark)
            {
                flag2 = false;
                this.class1092_0.method_10(BookmarkStart.b("帵崷嬹堻嬽㈿၁⅃⁅ⵇ㡉⥋⁍㍏㝑", num), this.dictionary_32[BookmarkStart.b("䄵", num)]);
                this.class1092_0.method_5(BookmarkStart.b("䈵䄷䨹夻", num), this.dictionary_32[BookmarkStart.b("䄵", num)], BookmarkStart.b("匵丷弹刻", num));
                str = this.method_527();
                this.class1092_0.method_5(BookmarkStart.b("張尷", num), this.dictionary_32[BookmarkStart.b("䐵", num)], str);
                this.method_412(A_0.EvenHeader, HeaderFooterType.HeaderEven, str);
                this.class1092_0.method_12();
            }
            if (A_0.EvenFooter.Items.Count > 0)
            {
                flag2 = false;
                this.class1092_0.method_10(BookmarkStart.b("倵圷唹䠻嬽㈿၁⅃⁅ⵇ㡉⥋⁍㍏㝑", num), this.dictionary_32[BookmarkStart.b("䄵", num)]);
                this.class1092_0.method_5(BookmarkStart.b("䈵䄷䨹夻", num), this.dictionary_32[BookmarkStart.b("䄵", num)], BookmarkStart.b("匵丷弹刻", num));
                str = this.method_527();
                this.class1092_0.method_5(BookmarkStart.b("張尷", num), this.dictionary_32[BookmarkStart.b("䐵", num)], str);
                this.method_412(A_0.EvenFooter, HeaderFooterType.FooterEven, str);
                this.class1092_0.method_12();
            }
            if ((flag2 && (A_0.OddHeader.Items.Count == 0)) && (A_0.OddFooter.Items.Count == 0))
            {
                entity = A_0.OddHeader.AddParagraph();
            }
            if ((A_0.OddHeader.Items.Count > 0) || A_0.OddHeader.HasWatermark)
            {
                flag2 = false;
                this.class1092_0.method_10(BookmarkStart.b("帵崷嬹堻嬽㈿၁⅃⁅ⵇ㡉⥋⁍㍏㝑", num), this.dictionary_32[BookmarkStart.b("䄵", num)]);
                this.class1092_0.method_5(BookmarkStart.b("䈵䄷䨹夻", num), this.dictionary_32[BookmarkStart.b("䄵", num)], BookmarkStart.b("刵崷尹崻䬽ⰿ㙁", num));
                str = this.method_527();
                this.class1092_0.method_5(BookmarkStart.b("張尷", num), this.dictionary_32[BookmarkStart.b("䐵", num)], str);
                this.method_412(A_0.OddHeader, HeaderFooterType.HeaderOdd, str);
                this.class1092_0.method_12();
                if (entity != null)
                {
                    A_0.OddHeader.ChildObjects.Remove(entity);
                    entity = null;
                }
            }
            if (flag2 && (A_0.OddFooter.Items.Count == 0))
            {
                A_0.OddFooter.AddParagraph();
            }
            if (A_0.OddFooter.Items.Count > 0)
            {
                this.class1092_0.method_10(BookmarkStart.b("倵圷唹䠻嬽㈿၁⅃⁅ⵇ㡉⥋⁍㍏㝑", num), this.dictionary_32[BookmarkStart.b("䄵", num)]);
                this.class1092_0.method_5(BookmarkStart.b("䈵䄷䨹夻", num), this.dictionary_32[BookmarkStart.b("䄵", num)], BookmarkStart.b("刵崷尹崻䬽ⰿ㙁", num));
                str = this.method_527();
                this.class1092_0.method_5(BookmarkStart.b("張尷", num), this.dictionary_32[BookmarkStart.b("䐵", num)], str);
                this.method_412(A_0.OddFooter, HeaderFooterType.FooterOdd, str);
                this.class1092_0.method_12();
                if (entity != null)
                {
                    A_0.OddFooter.ChildObjects.Remove(entity);
                    entity = null;
                }
            }
        }
    }

    private void method_389(Section A_0)
    {
        int num = 4;
        if (A_0.PageSetup.LinePitch > 0f)
        {
            this.class1092_0.method_10(BookmarkStart.b("丩䌫䴭眯䀱崳刵", num), this.dictionary_32[BookmarkStart.b("崩", num)]);
            switch (A_0.PageSetup.PitchType)
            {
                case GridPitchType.CharsAndLine:
                    this.class1092_0.method_5(BookmarkStart.b("帩唫席唯", num), this.dictionary_32[BookmarkStart.b("崩", num)], BookmarkStart.b("䘩䔫䀭唯䄱申堵尷礹吻弽㈿ㅁ", num));
                    break;

                case GridPitchType.LinesOnly:
                    this.class1092_0.method_5(BookmarkStart.b("帩唫席唯", num), this.dictionary_32[BookmarkStart.b("崩", num)], BookmarkStart.b("䘩䔫䀭唯䄱", num));
                    break;

                case GridPitchType.SnapToChars:
                    this.class1092_0.method_5(BookmarkStart.b("帩唫席唯", num), this.dictionary_32[BookmarkStart.b("崩", num)], BookmarkStart.b("天䈫伭䀯昱嬳电倷嬹主䴽", num));
                    break;
            }
            this.class1092_0.method_5(BookmarkStart.b("䘩䔫䀭唯戱崳䈵嬷刹", num), this.dictionary_32[BookmarkStart.b("崩", num)], ((ushort) Math.Round((double) (A_0.PageSetup.LinePitch * 20f))).ToString());
            if (A_0.PageSetup.CharsLine != 0)
            {
                this.class1092_0.method_5(BookmarkStart.b("䤩䐫伭䈯愱䐳圵嬷弹", num), this.dictionary_32[BookmarkStart.b("崩", num)], A_0.PageSetup.CharsLine.ToString());
            }
            this.class1092_0.method_12();
        }
    }

    private Dictionary<string, byte[]> method_39()
    {
        if (this.dictionary_2 == null)
        {
            this.dictionary_2 = new Dictionary<string, byte[]>();
        }
        return this.dictionary_2;
    }

    private void method_390(Section A_0)
    {
        int num = 7;
        if (!A_0.ProtectForm)
        {
            this.class1092_0.method_11(BookmarkStart.b("娬", num), BookmarkStart.b("䬬䀮䌰帲攴䔶嘸伺", num), this.dictionary_32[BookmarkStart.b("娬", num)]);
            this.class1092_0.method_6(BookmarkStart.b("娬", num), BookmarkStart.b("嬬丮崰", num), this.dictionary_32[BookmarkStart.b("娬", num)], BookmarkStart.b("ᴬ", num));
            this.class1092_0.method_12();
        }
    }

    private void method_391(Section A_0)
    {
        int num = 13;
        if (A_0.TextDirection != TextDirection.TopToBottom)
        {
            this.class1092_0.method_11(BookmarkStart.b("䐲", num), BookmarkStart.b("䜲倴伶䴸缺吼䴾⑀⁂ㅄ⹆♈╊", num), this.dictionary_32[BookmarkStart.b("䐲", num)]);
            TextDirection textDirection = A_0.TextDirection;
            if (textDirection != TextDirection.RightToLeft)
            {
                if (textDirection != TextDirection.TopToBottomRotated)
                {
                    this.class1092_0.method_5(BookmarkStart.b("䔲吴嬶", num), this.dictionary_32[BookmarkStart.b("䐲", num)], BookmarkStart.b("弲䜴挶嬸", num));
                }
                else
                {
                    this.class1092_0.method_5(BookmarkStart.b("䔲吴嬶", num), this.dictionary_32[BookmarkStart.b("䐲", num)], BookmarkStart.b("弲䜴挶嬸洺", num));
                }
            }
            else
            {
                this.class1092_0.method_5(BookmarkStart.b("䔲吴嬶", num), this.dictionary_32[BookmarkStart.b("䐲", num)], BookmarkStart.b("䜲圴收唸", num));
            }
            this.class1092_0.method_12();
        }
    }

    private void method_392(Section A_0)
    {
        int num = 6;
        ColumnCollection columns = A_0.Columns;
        this.class1092_0.method_10(BookmarkStart.b("伫䄭尯䄱", 6), this.dictionary_32[BookmarkStart.b("嬫", 6)]);
        if (columns.Count > 0)
        {
            this.class1092_0.method_5(BookmarkStart.b("䈫嬭崯", num), this.dictionary_32[BookmarkStart.b("嬫", num)], columns.Count.ToString());
        }
        if (A_0.PageSetup.ColumnsLineBetween)
        {
            this.class1092_0.method_5(BookmarkStart.b("弫䬭䀯", num), this.dictionary_32[BookmarkStart.b("嬫", num)], BookmarkStart.b("ᴫ", num));
        }
        if (columns.OwnerSection.PageSetup.EqualColumnWidth)
        {
            this.class1092_0.method_5(BookmarkStart.b("䤫弭䔯匱堳愵儷帹䠻嘽", num), this.dictionary_32[BookmarkStart.b("嬫", num)], BookmarkStart.b("ᴫ", num));
            if (columns.Count > 0)
            {
                this.class1092_0.method_5(BookmarkStart.b("弫席儯儱儳", num), this.dictionary_32[BookmarkStart.b("嬫", num)], this.method_534(columns[0].Space * 20f));
            }
        }
        else if (columns.Count > 0)
        {
            this.class1092_0.method_5(BookmarkStart.b("䤫弭䔯匱堳愵儷帹䠻嘽", num), this.dictionary_32[BookmarkStart.b("嬫", num)], BookmarkStart.b("ᰫ", num));
            foreach (Column column in columns)
            {
                this.class1092_0.method_10(BookmarkStart.b("伫䄭尯", num), this.dictionary_32[BookmarkStart.b("嬫", num)]);
                this.class1092_0.method_5(BookmarkStart.b("嬫", num), this.dictionary_32[BookmarkStart.b("嬫", num)], this.method_534(column.Width * 20f));
                this.class1092_0.method_5(BookmarkStart.b("弫席儯儱儳", num), this.dictionary_32[BookmarkStart.b("嬫", num)], this.method_534(column.Space * 20f));
                this.class1092_0.method_12();
            }
        }
        this.class1092_0.method_12();
    }

    private void method_393(PageSetup A_0)
    {
        int num = 7;
        if (((A_0.PageBorderOffsetFrom == PageBorderOffsetFrom.PageEdge) || (A_0.PageBordersApplyType == PageBordersApplyType.FirstPage)) || (!A_0.IsFrontPageBorder || !A_0.Borders.IsDefault))
        {
            this.class1092_0.method_10(BookmarkStart.b("崬䠮猰尲䜴匶尸䤺丼", num), this.dictionary_32[BookmarkStart.b("娬", num)]);
            if (A_0.PageBorderOffsetFrom == PageBorderOffsetFrom.PageEdge)
            {
                this.class1092_0.method_5(BookmarkStart.b("䈬䤮地䀲倴䌶缸䤺刼刾", num), this.dictionary_32[BookmarkStart.b("娬", num)], BookmarkStart.b("崬丮嘰嘲", num));
            }
            if (A_0.PageBordersApplyType == PageBordersApplyType.FirstPage)
            {
                this.class1092_0.method_5(BookmarkStart.b("䤬䘮䈰䌲头嘶䀸", num), this.dictionary_32[BookmarkStart.b("娬", num)], BookmarkStart.b("䬬䘮䌰䀲䄴朶堸尺堼", num));
            }
            if (!A_0.IsFrontPageBorder)
            {
                this.class1092_0.method_5(BookmarkStart.b("圬怮䌰圲倴䔶", num), this.dictionary_32[BookmarkStart.b("娬", num)], BookmarkStart.b("伬丮到堲", num));
            }
            if (!A_0.Borders.IsDefault)
            {
                this.method_395(A_0.Borders, 8);
            }
            this.class1092_0.method_12();
        }
    }

    private void method_394(PageSetup A_0)
    {
        this.method_397(A_0);
        this.method_396(A_0);
        this.method_393(A_0);
        this.method_399(A_0);
        this.method_398(A_0);
    }

    private void method_395(Borders A_0, int A_1)
    {
        this.method_496(A_0.Top, BookmarkStart.b("䌶嘸䬺", 0x11), A_1);
        this.method_496(A_0.Left, BookmarkStart.b("嬶尸崺䤼", 0x11), A_1);
        this.method_496(A_0.Bottom, BookmarkStart.b("唶嘸伺䤼倾ⱀ", 0x11), A_1);
        this.method_496(A_0.Right, BookmarkStart.b("䔶倸尺唼䬾", 0x11), A_1);
        this.method_496(A_0.Horizontal, BookmarkStart.b("帶圸䠺吼嬾⑀ୂ", 0x11), 8);
        this.method_496(A_0.Vertical, BookmarkStart.b("帶圸䠺吼嬾⑀ᕂ", 0x11), 8);
        this.method_496(A_0.DiagonalDown, BookmarkStart.b("䌶唸ऺ弼䴾", 0x11), 8);
        this.method_496(A_0.DiagonalUp, BookmarkStart.b("䌶䬸ऺ弼匾", 0x11), 8);
    }

    private void method_396(PageSetup A_0)
    {
        int num = 2;
        this.class1092_0.method_10(BookmarkStart.b("堧䴩愫伭䈯", 2), this.dictionary_32[BookmarkStart.b("弧", 2)]);
        this.class1092_0.method_5(BookmarkStart.b("尧䔩尫", 2), this.dictionary_32[BookmarkStart.b("弧", 2)], ((int) Math.Round((double) (A_0.Margins.Top * 20f))).ToString());
        this.class1092_0.method_5(BookmarkStart.b("娧䌩䬫䘭䐯", 2), this.dictionary_32[BookmarkStart.b("弧", 2)], ((int) Math.Round((double) (A_0.Margins.Right * 20f))).ToString());
        this.class1092_0.method_5(BookmarkStart.b("䨧䔩堫娭弯弱", 2), this.dictionary_32[BookmarkStart.b("弧", 2)], ((int) Math.Round((double) (A_0.Margins.Bottom * 20f))).ToString());
        this.class1092_0.method_5(BookmarkStart.b("䐧伩䨫娭", 2), this.dictionary_32[BookmarkStart.b("弧", 2)], ((int) Math.Round((double) (A_0.Margins.Left * 20f))).ToString());
        if (A_0.OwnerSection.SectPr.HasKey(0x91a))
        {
            this.class1092_0.method_5(BookmarkStart.b("丧䔩䌫娭唯䀱", num), this.dictionary_32[BookmarkStart.b("弧", num)], this.method_534(A_0.FooterDistance * 20f));
        }
        if (A_0.OwnerSection.SectPr.HasKey(0x910))
        {
            this.class1092_0.method_5(BookmarkStart.b("䀧伩䴫䨭唯䀱", num), this.dictionary_32[BookmarkStart.b("弧", num)], this.method_534(A_0.HeaderDistance * 20f));
        }
        this.class1092_0.method_5(BookmarkStart.b("伧弩堫娭唯䀱", num), this.dictionary_32[BookmarkStart.b("弧", num)], ((int) Math.Round((double) (A_0.Margins.Gutter * 20f))).ToString());
        this.class1092_0.method_12();
    }

    private void method_397(PageSetup A_0)
    {
        int num = 6;
        bool flag = A_0.Orientation == PageOrientation.Landscape;
        float num4 = A_0.PageSize.Width * 20f;
        float num2 = A_0.PageSize.Height * 20f;
        float num3 = num4;
        float num5 = num2;
        if (flag && (num4 < num2))
        {
            num3 = num2;
            num5 = num4;
        }
        this.class1092_0.method_10(BookmarkStart.b("尫䤭振䠱", num), this.dictionary_32[BookmarkStart.b("嬫", num)]);
        this.class1092_0.method_5(BookmarkStart.b("嬫", num), this.dictionary_32[BookmarkStart.b("嬫", num)], this.method_534(num3));
        this.class1092_0.method_5(BookmarkStart.b("䐫", num), this.dictionary_32[BookmarkStart.b("嬫", num)], this.method_534(num5));
        if (flag)
        {
            this.class1092_0.method_5(BookmarkStart.b("䌫尭夯圱娳䈵", num), this.dictionary_32[BookmarkStart.b("嬫", num)], BookmarkStart.b("䀫伭帯嘱䜳唵夷䨹夻", num));
        }
        this.class1092_0.method_12();
    }

    private void method_398(PageSetup A_0)
    {
        int num = 0x12;
        this.class1092_0.method_10(BookmarkStart.b("䠷崹爻䬽ⴿᙁ㵃㙅ⵇ", 0x12), this.dictionary_32[BookmarkStart.b("伷", 0x12)]);
        string str = this.method_542(A_0.PageNumberStyle);
        this.class1092_0.method_5(BookmarkStart.b("帷圹䠻", 0x12), this.dictionary_32[BookmarkStart.b("伷", 0x12)], str);
        if (A_0.RestartPageNumbering)
        {
            this.class1092_0.method_5(BookmarkStart.b("䬷丹崻䰽㐿", num), this.dictionary_32[BookmarkStart.b("伷", num)], A_0.PageStartingNumber.ToString());
        }
        this.class1092_0.method_12();
    }

    private void method_399(PageSetup A_0)
    {
        int num = 11;
        if (((A_0.HasLineNumbering || (A_0.LineNumberingRestartMode != LineNumberingRestartMode.None)) || ((A_0.LineNumberingStartValue != 0) && (A_0.LineNumberingStep != 0))) || (A_0.LineNumberingDistanceFromText != 0f))
        {
            this.class1092_0.method_10(BookmarkStart.b("崰崲笴䈶吸漺䐼伾⑀", num), this.dictionary_32[BookmarkStart.b("䘰", num)]);
            if (A_0.LineNumberingStartValue != 0)
            {
                this.class1092_0.method_5(BookmarkStart.b("䈰䜲吴䔶䴸", num), this.dictionary_32[BookmarkStart.b("䘰", num)], (A_0.LineNumberingStartValue - 1).ToString());
            }
            if (A_0.LineNumberingDistanceFromText != 0f)
            {
                this.class1092_0.method_5(BookmarkStart.b("唰娲䘴䌶堸唺帼娾", num), this.dictionary_32[BookmarkStart.b("䘰", num)], this.method_534(A_0.LineNumberingDistanceFromText * 20f));
            }
            if (A_0.LineNumberingStep != 0)
            {
                this.class1092_0.method_5(BookmarkStart.b("到尲䀴夶䴸示䐼", num), this.dictionary_32[BookmarkStart.b("䘰", num)], A_0.LineNumberingStep.ToString());
            }
            switch (A_0.LineNumberingRestartMode)
            {
                case LineNumberingRestartMode.RestartPage:
                    this.class1092_0.method_5(BookmarkStart.b("䌰嘲䘴䌶堸䤺䤼", num), this.dictionary_32[BookmarkStart.b("䘰", num)], BookmarkStart.b("弰嘲䈴朶堸尺堼", num));
                    break;

                case LineNumberingRestartMode.RestartSection:
                    this.class1092_0.method_5(BookmarkStart.b("䌰嘲䘴䌶堸䤺䤼", num), this.dictionary_32[BookmarkStart.b("䘰", num)], BookmarkStart.b("弰嘲䈴搶尸堺䤼嘾⹀ⵂ", num));
                    break;

                case LineNumberingRestartMode.Continuous:
                    this.class1092_0.method_5(BookmarkStart.b("䌰嘲䘴䌶堸䤺䤼", num), this.dictionary_32[BookmarkStart.b("䘰", num)], BookmarkStart.b("到尲嬴䌶倸唺䠼倾㑀あ", num));
                    break;
            }
            this.class1092_0.method_12();
        }
    }

    internal Dictionary<string, Dictionary<string, DictionaryEntry>> method_4()
    {
        if (this.dictionary_30 == null)
        {
            this.dictionary_30 = new Dictionary<string, Dictionary<string, DictionaryEntry>>();
        }
        return this.dictionary_30;
    }

    private Dictionary<string, Class517> method_40()
    {
        if (this.dictionary_4 == null)
        {
            this.dictionary_4 = new Dictionary<string, Class517>();
        }
        return this.dictionary_4;
    }

    private void method_400(SectionBreakType A_0)
    {
        this.class1092_0.method_11(BookmarkStart.b("尪", 5), BookmarkStart.b("弪听弮吰", 5), this.dictionary_32[BookmarkStart.b("尪", 5)]);
        this.class1092_0.method_6(BookmarkStart.b("尪", 5), BookmarkStart.b("崪䰬䌮", 5), this.dictionary_32[BookmarkStart.b("尪", 5)], this.method_401(A_0));
        this.class1092_0.method_12();
    }

    private string method_401(SectionBreakType A_0)
    {
        int num = 15;
        switch (A_0)
        {
            case SectionBreakType.NewColumn:
                return BookmarkStart.b("嬴制䄸伺縼倾ⵀ㙂⡄⥆", num);

            case SectionBreakType.NewPage:
                return BookmarkStart.b("嬴制䄸伺洼帾♀♂", num);

            case SectionBreakType.EvenPage:
                return BookmarkStart.b("倴䄶尸唺洼帾♀♂", num);

            case SectionBreakType.Oddpage:
                return BookmarkStart.b("娴匶崸欺尼堾⑀", num);
        }
        return BookmarkStart.b("嘴堶圸伺吼儾㑀ⱂい㑆", num);
    }

    private void method_402(Section A_0, bool A_1)
    {
        FootEndnoteOptions footnoteOptions = null;
        FootEndnoteOptions endnoteOptions = null;
        bool flag = false;
        if (A_0 != null)
        {
            footnoteOptions = A_0.FootnoteOptions;
            endnoteOptions = A_0.EndnoteOptions;
            flag = true;
        }
        else
        {
            footnoteOptions = this.document_0.FootnoteOptions;
            endnoteOptions = this.document_0.EndnoteOptions;
            flag = false;
        }
        if (flag)
        {
            if (!footnoteOptions.IsDefault)
            {
                this.method_403(footnoteOptions);
            }
            this.bool_12 = false;
            if (!endnoteOptions.IsDefault)
            {
                this.method_403(endnoteOptions);
            }
            this.bool_11 = false;
        }
        else
        {
            if (!footnoteOptions.IsDefault)
            {
                this.method_403(footnoteOptions);
            }
            if (!endnoteOptions.IsDefault)
            {
                this.method_403(endnoteOptions);
            }
        }
    }

    private void method_403(FootEndnoteOptions A_0)
    {
        int num = 0x13;
        if (A_0 != null)
        {
            switch (A_0.OptionsType)
            {
                case FootnoteType.Footnote:
                    this.class1092_0.method_10(BookmarkStart.b("弸吺刼䬾⽀ⱂㅄ≆᥈㥊", num), this.dictionary_32[BookmarkStart.b("丸", num)]);
                    this.method_406(A_0);
                    this.method_404(A_0);
                    this.method_405(A_0);
                    this.class1092_0.method_12();
                    return;

                case FootnoteType.Endnote:
                    this.class1092_0.method_10(BookmarkStart.b("尸唺夼儾⹀㝂⁄ᝆ㭈", num), this.dictionary_32[BookmarkStart.b("丸", num)]);
                    this.method_406(A_0);
                    this.method_404(A_0);
                    this.method_405(A_0);
                    this.class1092_0.method_12();
                    return;
            }
        }
    }

    private void method_404(FootEndnoteOptions A_0)
    {
        int num = 11;
        if ((A_0 != null) && A_0.HasValue(1))
        {
            FootnoteNumberFormat numberFormat = A_0.NumberFormat;
            if (numberFormat <= FootnoteNumberFormat.DecimalFullWidth)
            {
                switch (numberFormat)
                {
                    case FootnoteNumberFormat.Arabic:
                        this.method_407(BookmarkStart.b("弰䘲場然吸伺", num), BookmarkStart.b("唰嘲嘴帶吸娺儼", num));
                        return;

                    case FootnoteNumberFormat.UpperCaseRoman:
                        this.method_407(BookmarkStart.b("弰䘲場然吸伺", num), BookmarkStart.b("䐰䌲䔴制䬸椺刼刾⁀ⵂ", num));
                        return;

                    case FootnoteNumberFormat.LowerCaseRoman:
                        this.method_407(BookmarkStart.b("弰䘲場然吸伺", num), BookmarkStart.b("崰尲䈴制䬸椺刼刾⁀ⵂ", num));
                        return;

                    case FootnoteNumberFormat.UpperCaseLetter:
                        this.method_407(BookmarkStart.b("弰䘲場然吸伺", num), BookmarkStart.b("䐰䌲䔴制䬸眺堼䬾㕀♂㝄", num));
                        return;

                    case FootnoteNumberFormat.LowerCaseLetter:
                        this.method_407(BookmarkStart.b("弰䘲場然吸伺", num), BookmarkStart.b("崰尲䈴制䬸眺堼䬾㕀♂㝄", num));
                        return;

                    case (FootnoteNumberFormat.LowerCaseLetter | FootnoteNumberFormat.UpperCaseRoman):
                    case (FootnoteNumberFormat.LowerCaseLetter | FootnoteNumberFormat.LowerCaseRoman):
                    case (FootnoteNumberFormat.LowerCaseLetter | FootnoteNumberFormat.UpperCaseLetter):
                    case ((FootnoteNumberFormat) 8):
                        return;

                    case FootnoteNumberFormat.Chicago:
                        this.method_407(BookmarkStart.b("弰䘲場然吸伺", num), BookmarkStart.b("到嬲尴吶堸尺刼", num));
                        return;

                    case FootnoteNumberFormat.DecimalFullWidth:
                        this.method_407(BookmarkStart.b("弰䘲場然吸伺", num), BookmarkStart.b("唰嘲嘴帶吸娺儼社㑀⽂⥄၆⁈⽊㥌❎", num));
                        return;
                }
            }
            else
            {
                switch (numberFormat)
                {
                    case FootnoteNumberFormat.DecimalEnclosedCircleChinese:
                        this.method_407(BookmarkStart.b("弰䘲場然吸伺", num), BookmarkStart.b("唰嘲嘴帶吸娺儼稾⽀⁂⥄⡆㩈⹊⥌౎㡐⅒㙔㭖㱘ᡚ㕜㙞འ٢ᙤɦ", num));
                        return;

                    case FootnoteNumberFormat.IdeographEnclosedCircle:
                        this.method_407(BookmarkStart.b("弰䘲場然吸伺", num), BookmarkStart.b("堰圲倴堶常䤺尼伾⥀ق⭄⑆╈⑊㹌⩎㕐ၒ㱔╖㩘㝚㡜", num));
                        return;

                    case FootnoteNumberFormat.IdeographTraditional:
                        this.method_407(BookmarkStart.b("弰䘲場然吸伺", num), BookmarkStart.b("堰圲倴堶常䤺尼伾⥀ᝂ㝄♆ⵈ≊㥌♎㹐㵒㑔㭖", num));
                        return;

                    case FootnoteNumberFormat.IdeographZodiac:
                        this.method_407(BookmarkStart.b("弰䘲場然吸伺", num), BookmarkStart.b("堰圲倴堶常䤺尼伾⥀᥂⩄⍆⁈⩊⹌", num));
                        return;

                    case FootnoteNumberFormat.ChineseLegalSimplified:
                        this.method_407(BookmarkStart.b("弰䘲場然吸伺", num), BookmarkStart.b("到嬲尴夶尸䠺堼猾⑀⑂⑄⭆ᩈ≊⁌㽎㵐㩒㍔㹖㱘㽚", num));
                        return;

                    case FootnoteNumberFormat.ChineseCountingThousand:
                        this.method_407(BookmarkStart.b("弰䘲場然吸伺", num), BookmarkStart.b("到嬲尴夶尸䠺堼簾⹀㙂⭄㍆⁈╊⩌᭎㥐㱒⁔⑖㡘㕚㥜", num));
                        return;

                    case ((FootnoteNumberFormat) 40):
                    case ((FootnoteNumberFormat) 0x29):
                    case ((FootnoteNumberFormat) 0x2a):
                    case ((FootnoteNumberFormat) 0x2b):
                    case ((FootnoteNumberFormat) 0x2c):
                        return;

                    case FootnoteNumberFormat.Hebrew1:
                        this.method_407(BookmarkStart.b("弰䘲場然吸伺", num), BookmarkStart.b("夰嘲圴䔶尸䰺఼", num));
                        return;

                    case FootnoteNumberFormat.ArabicAlpha:
                        this.method_407(BookmarkStart.b("弰䘲場然吸伺", num), BookmarkStart.b("倰䄲吴唶倸堺簼匾ㅀ⭂⑄", num));
                        return;

                    case FootnoteNumberFormat.Hebrew2:
                        this.method_407(BookmarkStart.b("弰䘲場然吸伺", num), BookmarkStart.b("夰嘲圴䔶尸䰺༼", num));
                        return;

                    case FootnoteNumberFormat.ArabicAbjad:
                        this.method_407(BookmarkStart.b("弰䘲場然吸伺", num), BookmarkStart.b("倰䄲吴唶倸堺簼崾⭀≂⅄", num));
                        return;
                }
            }
        }
    }

    private void method_405(FootEndnoteOptions A_0)
    {
        int num = 4;
        if (A_0 != null)
        {
            if (A_0.HasValue(3))
            {
                switch (A_0.RestartRule)
                {
                    case FootnoteRestartRule.DoNotRestart:
                        this.method_407(BookmarkStart.b("䐩夫䌭戯圱䜳䈵夷䠹䠻", num), BookmarkStart.b("䤩䌫䀭䐯嬱娳䌵圷伹伻", num));
                        break;

                    case FootnoteRestartRule.RestartSection:
                        this.method_407(BookmarkStart.b("䐩夫䌭戯圱䜳䈵夷䠹䠻", num), BookmarkStart.b("伩䴫䴭堯愱儳唵䰷", num));
                        break;

                    case FootnoteRestartRule.RestartPage:
                        if (A_0.OptionsType == FootnoteType.Footnote)
                        {
                            this.method_407(BookmarkStart.b("䐩夫䌭戯圱䜳䈵夷䠹䠻", num), BookmarkStart.b("伩䴫䴭堯戱唳儵崷", num));
                        }
                        break;
                }
            }
            if (A_0.HasValue(4) && A_0.HasValue(4))
            {
                this.method_407(BookmarkStart.b("䐩夫䌭振䘱唳䐵䰷", num), A_0.StartNumber.ToString());
            }
        }
    }

    private void method_406(FootEndnoteOptions A_0)
    {
        int num = 0;
        if ((A_0 != null) && A_0.HasValue(2))
        {
            switch (A_0.Position)
            {
                case FootnotePosition.PrintAsEndOfSection:
                    if (A_0.OptionsType == FootnoteType.Endnote)
                    {
                        this.method_407(BookmarkStart.b("嘥䜧天", num), BookmarkStart.b("唥䴧䤩堫欭帯嘱", num));
                    }
                    return;

                case FootnotePosition.PrintAtBottomOfPage:
                    if (A_0.OptionsType == FootnoteType.Footnote)
                    {
                        this.method_407(BookmarkStart.b("嘥䜧天", num), BookmarkStart.b("嘥䤧䴩䤫氭弯䘱䀳夵唷", num));
                    }
                    return;

                case FootnotePosition.PrintImmediatelyBeneathText:
                    if (A_0.OptionsType == FootnoteType.Footnote)
                    {
                        this.method_407(BookmarkStart.b("嘥䜧天", num), BookmarkStart.b("䐥䴧䐩䤫伭䐯娱怳匵䀷丹", num));
                    }
                    return;

                case FootnotePosition.PrintAsEndOfDocument:
                    if (A_0.OptionsType == FootnoteType.Endnote)
                    {
                        this.method_407(BookmarkStart.b("嘥䜧天", num), BookmarkStart.b("䈥䜧䤩椫䀭启", num));
                    }
                    return;
            }
        }
    }

    private void method_407(string A_0, string A_1)
    {
        this.class1092_0.method_10(A_0, this.dictionary_32[BookmarkStart.b("伷", 0x12)]);
        this.class1092_0.method_6(BookmarkStart.b("伷", 0x12), BookmarkStart.b("丷嬹倻", 0x12), this.dictionary_32[BookmarkStart.b("伷", 0x12)], A_1);
        this.class1092_0.method_12();
    }

    private void method_408(Section A_0)
    {
        int num = 11;
        this.class1092_0.method_10(BookmarkStart.b("吰崲儴夶嘸伺堼漾㍀", 11), this.dictionary_32[BookmarkStart.b("䘰", 11)]);
        this.method_411(A_0, false);
        if (A_0.Document.EndnoteOptions.RestartRule == FootnoteRestartRule.RestartSection)
        {
            this.method_410(BookmarkStart.b("弰䘲場收尸䠺䤼帾㍀㝂", num), BookmarkStart.b("吰刲嘴弶樸帺帼䬾", num));
        }
        this.method_410(BookmarkStart.b("弰䘲場搶䴸娺似䬾", num), A_0.Document.EndnoteOptions.StartNumber.ToString());
        this.class1092_0.method_12();
    }

    private void method_409(Section A_0)
    {
        int num = 10;
        this.class1092_0.method_10(BookmarkStart.b("嘯崱嬳䈵嘷唹䠻嬽ဿぁ", 10), this.dictionary_32[BookmarkStart.b("䜯", 10)]);
        this.method_411(A_0, true);
        this.method_422();
        if (A_0.Document.FootnoteOptions.RestartRule == FootnoteRestartRule.RestartPage)
        {
            this.method_410(BookmarkStart.b("帯䜱夳搵崷䤹䠻弽㈿㙁", num), BookmarkStart.b("唯匱圳帵样嬹嬻嬽", num));
        }
        else if (A_0.Document.FootnoteOptions.RestartRule == FootnoteRestartRule.RestartSection)
        {
            this.method_410(BookmarkStart.b("帯䜱夳搵崷䤹䠻弽㈿㙁", num), BookmarkStart.b("唯匱圳帵欷弹弻䨽", num));
        }
        this.method_410(BookmarkStart.b("帯䜱夳攵䰷嬹主䨽", num), A_0.Document.FootnoteOptions.StartNumber.ToString());
        this.class1092_0.method_12();
    }

    private Dictionary<string, Class517> method_41()
    {
        if (this.dictionary_5 == null)
        {
            this.dictionary_5 = new Dictionary<string, Class517>();
        }
        return this.dictionary_5;
    }

    private void method_410(string A_0, string A_1)
    {
        this.class1092_0.method_10(A_0, this.dictionary_32[BookmarkStart.b("帨", 3)]);
        this.class1092_0.method_6(BookmarkStart.b("帨", 3), BookmarkStart.b("弨䨪䄬", 3), this.dictionary_32[BookmarkStart.b("帨", 3)], A_1);
        this.class1092_0.method_12();
    }

    private void method_411(Section A_0, bool A_1)
    {
        int num = 0x11;
        switch ((A_1 ? A_0.Document.FootnoteOptions.NumberFormat : A_0.Document.EndnoteOptions.NumberFormat))
        {
            case FootnoteNumberFormat.Arabic:
                this.method_410(BookmarkStart.b("夶䰸嘺笼刾㕀", num), BookmarkStart.b("匶尸堺吼刾⁀⽂", num));
                return;

            case FootnoteNumberFormat.UpperCaseRoman:
                this.method_410(BookmarkStart.b("夶䰸嘺笼刾㕀", num), BookmarkStart.b("䈶䤸䬺堼䴾ፀⱂ⡄♆❈", num));
                return;

            case FootnoteNumberFormat.LowerCaseRoman:
                this.method_410(BookmarkStart.b("夶䰸嘺笼刾㕀", num), BookmarkStart.b("嬶嘸䰺堼䴾ፀⱂ⡄♆❈", num));
                return;

            case FootnoteNumberFormat.UpperCaseLetter:
                this.method_410(BookmarkStart.b("夶䰸嘺笼刾㕀", num), BookmarkStart.b("䈶䤸䬺堼䴾ീ♂ㅄ㍆ⱈ㥊", num));
                return;

            case FootnoteNumberFormat.LowerCaseLetter:
                this.method_410(BookmarkStart.b("夶䰸嘺笼刾㕀", num), BookmarkStart.b("嬶嘸䰺堼䴾ീ♂ㅄ㍆ⱈ㥊", num));
                return;
        }
    }

    private void method_412(HeaderFooter A_0, HeaderFooterType A_1, string A_2)
    {
        if (!this.method_1().ContainsKey(A_1))
        {
            Dictionary<string, HeaderFooter> dictionary = new Dictionary<string, HeaderFooter>();
            this.method_1().Add(A_1, dictionary);
        }
        this.method_1()[A_1].Add(A_2, A_0);
    }

    private void method_413()
    {
        int num = 5;
        this.dictionary_32 = this.document_0.DocxNameSpace.method_0()[BookmarkStart.b("堪䠬嬮䔰娲嬴倶䨸", 5)];
        MemoryStream stream = new MemoryStream();
        this.class1092_0 = this.method_524(stream);
        this.class1092_0.method_11(BookmarkStart.b("尪", 5), BookmarkStart.b("堪䠬嬮䔰娲嬴倶䨸", 5), this.dictionary_32[BookmarkStart.b("尪", 5)]);
        this.class1092_0.method_6(BookmarkStart.b("匪䀬䌮弰䀲", 5), BookmarkStart.b("䘪丬", 5), null, this.dictionary_32[BookmarkStart.b("䘪丬", 5)]);
        this.class1092_0.method_6(BookmarkStart.b("匪䀬䌮弰䀲", 5), BookmarkStart.b("䐪", 5), null, this.dictionary_32[BookmarkStart.b("䐪", 5)]);
        this.class1092_0.method_6(BookmarkStart.b("匪䀬䌮弰䀲", 5), BookmarkStart.b("太", 5), null, this.dictionary_32[BookmarkStart.b("太", 5)]);
        this.class1092_0.method_6(BookmarkStart.b("匪䀬䌮弰䀲", 5), BookmarkStart.b("䘪", 5), null, this.dictionary_32[BookmarkStart.b("䘪", 5)]);
        this.class1092_0.method_6(BookmarkStart.b("匪䀬䌮弰䀲", 5), BookmarkStart.b("崪", 5), null, this.dictionary_32[BookmarkStart.b("崪", 5)]);
        this.class1092_0.method_6(BookmarkStart.b("匪䀬䌮弰䀲", 5), BookmarkStart.b("尪ᰬἮ", 5), null, this.dictionary_32[BookmarkStart.b("尪ᰬἮ", 5)]);
        this.class1092_0.method_6(BookmarkStart.b("匪䀬䌮弰䀲", 5), BookmarkStart.b("尪ᰬᬮ", 5), null, this.dictionary_32[BookmarkStart.b("尪ᰬᬮ", 5)]);
        this.class1092_0.method_6(BookmarkStart.b("匪䀬䌮弰䀲", 5), BookmarkStart.b("尪ᰬᨮ", 5), null, this.dictionary_32[BookmarkStart.b("尪ᰬᨮ", 5)]);
        this.class1092_0.method_6(BookmarkStart.b("匪䀬䌮弰䀲", 5), BookmarkStart.b("堪䄬", 5), null, this.dictionary_32[BookmarkStart.b("堪䄬", 5)]);
        this.class1092_0.method_6(BookmarkStart.b("䘪丬", 5), BookmarkStart.b("截䨬䄮帰䄲吴唶唸帺", 5), null, BookmarkStart.b("尪ᰬᬮᄰ䐲дȶ", 5));
        bool flag = false;
        if (this.document_0.WriteProtected)
        {
            this.class1092_0.method_11(BookmarkStart.b("尪", num), BookmarkStart.b("尪弬䘮䔰嘲攴䔶嘸伺堼尾㕀⩂⩄⥆", num), this.dictionary_32[BookmarkStart.b("尪", num)]);
            this.class1092_0.method_5(BookmarkStart.b("太䠬䰮帰帲場制圸强堼嬾", num), this.dictionary_32[BookmarkStart.b("尪", num)], BookmarkStart.b("ᨪ", num));
            this.class1092_0.method_12();
        }
        if ((this.document_0.ViewSetup.DocumentViewType != DocumentViewType.PrintLayout) && (this.document_0.ViewSetup.DocumentViewType != DocumentViewType.NormalLayout))
        {
            this.class1092_0.method_10(BookmarkStart.b("崪䐬䨮䘰", num), this.dictionary_32[BookmarkStart.b("尪", num)]);
            string str = string.Empty;
            if (this.document_0.ViewSetup.DocumentViewType == DocumentViewType.OutlineLayout)
            {
                str = BookmarkStart.b("䐪堬嬮崰娲嬴制", num);
            }
            else if (this.document_0.ViewSetup.DocumentViewType == DocumentViewType.WebLayout)
            {
                str = BookmarkStart.b("尪䠬䴮", num);
            }
            this.class1092_0.method_5(BookmarkStart.b("崪䰬䌮", num), this.dictionary_32[BookmarkStart.b("尪", num)], str);
            this.class1092_0.method_12();
        }
        this.class1092_0.method_10(BookmarkStart.b("優䈬䀮尰", num), this.dictionary_32[BookmarkStart.b("尪", num)]);
        this.class1092_0.method_5(BookmarkStart.b("嬪䠬崮到嘲嬴䌶", num), this.dictionary_32[BookmarkStart.b("尪", num)], this.document_0.ViewSetup.ZoomPercent.ToString());
        this.class1092_0.method_12();
        if (this.document_0.EmbedFontsInFile)
        {
            this.class1092_0.method_10(BookmarkStart.b("个䀬䴮吰圲愴䔶䰸帺椼䘾ㅀ♂̈́⡆❈㽊㹌", num), this.dictionary_32[BookmarkStart.b("尪", num)]);
            this.class1092_0.method_12();
        }
        if (this.document_0.EmbedSystemFonts)
        {
            this.class1092_0.method_10(BookmarkStart.b("个䀬䴮吰圲昴丶䨸伺堼刾݀ⱂ⭄㍆㩈", num), this.dictionary_32[BookmarkStart.b("尪", num)]);
            this.class1092_0.method_12();
        }
        if (this.document_0.SaveSubsetFonts)
        {
            this.class1092_0.method_10(BookmarkStart.b("堪䰬央吰怲䀴唶䨸帺䤼社⹀ⵂㅄ㑆", num), this.dictionary_32[BookmarkStart.b("尪", num)]);
            this.class1092_0.method_12();
        }
        if (this.document_0.ViewSetup.DoNotDisplayPageBoundaries)
        {
            this.class1092_0.method_10(BookmarkStart.b("伪䈬愮帰䜲焴帶䨸䬺儼帾㡀ፂ⑄⁆ⱈॊ≌㩎㽐㝒㑔╖じ㹚⹜", num), this.dictionary_32[BookmarkStart.b("尪", num)]);
            this.class1092_0.method_12();
        }
        if (this.document_0.ViewSetup.DisplayBackgroundShape)
        {
            this.class1092_0.method_10(BookmarkStart.b("伪䐬尮䄰弲吴丶笸娺帼吾♀ㅂ⩄㉆❈⽊Ṍ❎ぐ⍒ご", num), this.dictionary_32[BookmarkStart.b("尪", num)]);
            this.class1092_0.method_12();
        }
        if (this.document_0.Settings.bool_11)
        {
            this.class1092_0.method_10(BookmarkStart.b("䘪䐬崮䌰尲䜴稶堸䤺娼嘾⽀あ", num), this.dictionary_32[BookmarkStart.b("尪", num)]);
            this.class1092_0.method_12();
        }
        if ((this.document_0.GrammarSpellingData != null) && (this.document_0.GrammarSpellingData.method_4() == ProofState.Clean))
        {
            flag = true;
            this.class1092_0.method_10(BookmarkStart.b("嬪弬䀮帰唲昴䌶堸伺堼", num), this.dictionary_32[BookmarkStart.b("尪", num)]);
            this.class1092_0.method_6(BookmarkStart.b("尪", num), BookmarkStart.b("䰪弬丮尰帲吴䔶", num), this.dictionary_32[BookmarkStart.b("尪", num)], BookmarkStart.b("䠪䄬䨮倰崲", num));
            this.class1092_0.method_12();
        }
        if (this.document_0.TrackChanges)
        {
            this.class1092_0.method_10(BookmarkStart.b("弪弬丮到堲朴制伸刺丼嘾⹀ⵂ㙄", num), this.dictionary_32[BookmarkStart.b("尪", num)]);
            this.class1092_0.method_12();
        }
        if (this.document_0.ProtectionType != ProtectionType.NoProtection)
        {
            this.method_418(this.document_0.ProtectionType, this.document_0.EnforceDocProt);
        }
        if (this.document_0.Sections[0].PageSetup.GutterAtTop)
        {
            this.class1092_0.method_10(BookmarkStart.b("䰪堬嬮䔰嘲䜴瘶䴸漺刼伾", num), this.dictionary_32[BookmarkStart.b("尪", num)]);
            this.class1092_0.method_12();
        }
        this.class1092_0.method_10(BookmarkStart.b("伪䠬䤮倰䘲头䌶洸娺弼氾㕀ⱂ㕄", num), this.dictionary_32[BookmarkStart.b("尪", num)]);
        this.class1092_0.method_5(BookmarkStart.b("崪䰬䌮", num), this.dictionary_32[BookmarkStart.b("尪", num)], ((int) Math.Round((double) (this.document_0.Sections[0].PageSetup.DefaultTabWidth * 20f))).ToString());
        this.class1092_0.method_12();
        if (this.document_0.Sections[0].PageSetup.PageBorderOffsetFrom == PageBorderOffsetFrom.Text)
        {
            if (this.document_0.Sections[0].PageSetup.AlignBordersAndEdges)
            {
                this.class1092_0.method_10(BookmarkStart.b("䨪䄬䘮嘰崲眴堶䬸强堼䴾㉀ɂ⭄⍆ై⽊⩌⩎≐", num), this.dictionary_32[BookmarkStart.b("尪", num)]);
                this.class1092_0.method_12();
            }
            this.class1092_0.method_10(BookmarkStart.b("䤪䈬崮唰嘲䜴䐶紸吺猼倾㕀၂い㕆㭈⑊㡌ⅎ㕐ᕒ㩔㡖ⵘ㹚⽜", num), this.dictionary_32[BookmarkStart.b("尪", num)]);
            if (this.document_0.Sections[0].PageSetup.PageBorderIncludeFooter)
            {
                this.class1092_0.method_4(BookmarkStart.b("尪ᜬ央倰弲", num), BookmarkStart.b("ᬪ", num));
            }
            this.class1092_0.method_12();
            this.class1092_0.method_10(BookmarkStart.b("䤪䈬崮唰嘲䜴䐶紸吺猼倾㕀၂い㕆㭈⑊㡌ⅎ㕐᭒ご㙖㵘㹚⽜", num), this.dictionary_32[BookmarkStart.b("尪", num)]);
            if (this.document_0.Sections[0].PageSetup.PageBorderIncludeHeader)
            {
                this.class1092_0.method_4(BookmarkStart.b("尪ᜬ央倰弲", num), BookmarkStart.b("ᬪ", num));
            }
            this.class1092_0.method_12();
        }
        this.class1092_0.method_10(BookmarkStart.b("䠪䔬丮䌰刲嘴䌶尸䤺渼伾⁀⁂ⱄ⥆⹈ࡊ≌ⅎ═⅒㩔㭖", num), this.dictionary_32[BookmarkStart.b("尪", num)]);
        switch (this.document_0.Sections[0].PageSetup.CharacterSpacingControl)
        {
            case CharacterSpacing.doNotCompress:
                this.class1092_0.method_5(BookmarkStart.b("崪䰬䌮", num), this.dictionary_32[BookmarkStart.b("尪", num)], BookmarkStart.b("伪䈬愮帰䜲瘴堶吸䬺似娾㉀あ", num));
                break;

            case CharacterSpacing.compressPunctuation:
                this.class1092_0.method_5(BookmarkStart.b("崪䰬䌮", num), this.dictionary_32[BookmarkStart.b("尪", num)], BookmarkStart.b("䠪䈬䈮䄰䄲倴䐶䨸欺䠼儾≀㝂い♆㵈≊≌ⅎ", num));
                break;

            case CharacterSpacing.compressPunctuationAndJapaneseKana:
                this.class1092_0.method_5(BookmarkStart.b("崪䰬䌮", num), this.dictionary_32[BookmarkStart.b("尪", num)], BookmarkStart.b("䠪䈬䈮䄰䄲倴䐶䨸欺䠼儾≀㝂い♆㵈≊≌ⅎၐ㵒ㅔᵖ㡘⭚㱜ㅞѠၢdⱦࡨժ౬", num));
                break;
        }
        this.class1092_0.method_12();
        if (this.document_0.Settings.bool_27)
        {
            this.class1092_0.method_10(BookmarkStart.b("䨪堬嬮帰笲䰴䜶儸帺匼帾㕀⩂⩄⥆", num), this.dictionary_32[BookmarkStart.b("尪", num)]);
            this.class1092_0.method_12();
        }
        if (this.document_0.Settings.int_15 > 0)
        {
            this.class1092_0.method_10(BookmarkStart.b("䠪䈬䄮䈰嘲嘴䈶䴸刺䬼娾ी㩂㕄⽆ⱈ╊Ō♎㱐㩒⅔", num), this.dictionary_32[BookmarkStart.b("尪", num)]);
            this.class1092_0.method_5(BookmarkStart.b("崪䰬䌮", num), this.dictionary_32[BookmarkStart.b("尪", num)], this.document_0.Settings.int_15.ToString());
            this.class1092_0.method_12();
        }
        if (this.document_0.Settings.int_16 != 360)
        {
            this.class1092_0.method_10(BookmarkStart.b("䌪听弮夰嘲嬴嘶䴸刺刼儾ᭀⱂ⭄≆", num), this.dictionary_32[BookmarkStart.b("尪", num)]);
            this.class1092_0.method_5(BookmarkStart.b("崪䰬䌮", num), this.dictionary_32[BookmarkStart.b("尪", num)], this.document_0.Settings.int_16.ToString());
            this.class1092_0.method_12();
        }
        if (!this.document_0.Settings.bool_28)
        {
            this.class1092_0.method_10(BookmarkStart.b("伪䈬愮帰䜲紴丶䤸区堼儾⁀㝂⁄ц⡈㭊㹌", num), this.dictionary_32[BookmarkStart.b("尪", num)]);
            this.class1092_0.method_12();
        }
        if (this.document_0.Sections[0].PageSetup.DifferentOddAndEvenPagesHeaderFooter)
        {
            this.class1092_0.method_10(BookmarkStart.b("个嬬䨮弰爲嬴匶瘸强夼眾⑀≂⅄≆㭈㡊", num), this.dictionary_32[BookmarkStart.b("尪", num)]);
            this.class1092_0.method_12();
        }
        if (this.document_0.Settings.bool_41)
        {
            this.class1092_0.method_10(BookmarkStart.b("伪䈬愮帰䜲昴弶堸强堼社⹀ㅂ⡄͆⡈㽊ⱌ", num), this.dictionary_32[BookmarkStart.b("尪", num)]);
            this.class1092_0.method_12();
        }
        if (!this.document_0.Settings.bool_42)
        {
            this.class1092_0.method_10(BookmarkStart.b("䔪䈬缮䐰崲嘴䌶䰸娺䤼嘾⹀ⵂไ≆㭈╊⑌ⅎ㙐", num), this.dictionary_32[BookmarkStart.b("尪", num)]);
            this.class1092_0.method_12();
        }
        this.method_420();
        if (this.document_0.HasDocxProps)
        {
            int num5 = 0;
            int num7 = this.document_0.DocxProps.Count;
            while (num5 < num7)
            {
                if (!this.document_0.DocxProps[num5].Name.Contains(BookmarkStart.b("嬪弬䀮帰唲昴䌶堸伺堼", num)) || !flag)
                {
                    this.document_0.DocxProps[num5].WriteTo(this.class1092_0.method_0());
                }
                num5++;
            }
        }
        int num2 = 0;
        int count = this.document_0.DocxProps2010.Count;
        while (num2 < count)
        {
            XmlReader reader = this.method_525(this.document_0.DocxProps2010[num2]);
            reader.MoveToContent();
            if ((reader.LocalName != BookmarkStart.b("嬪弬䀮帰唲昴䌶堸伺堼", num)) || !flag)
            {
                this.method_273(this.document_0.DocxProps2010[num2], true);
            }
            num2++;
        }
        this.method_416();
        this.method_414();
        if (this.document_0.ThemeFontLanguage != null)
        {
            this.method_498(this.document_0.ThemeFontLanguage);
        }
        if (this.document_0.Variables.Count > 0)
        {
            this.method_419(this.document_0.Variables);
        }
        this.class1092_0.method_12();
        this.class1092_0.method_15();
        this.class771_0.method_14(BookmarkStart.b("尪䈬崮唰漲䘴制䴸伺吼儾♀あ歄㽆⑈❊", num), stream, false, FileAttributes.Archive);
    }

    private void method_414()
    {
        int num = 2;
        this.class1092_0.method_10(BookmarkStart.b("䬧䘩師紭匯娱儳嬵崷眹崻丽〿⭁⩃ⅅ", 2), this.dictionary_32[BookmarkStart.b("弧", 2)]);
        foreach (KeyValuePair<string, string> pair in this.document_0.Settings.method_7())
        {
            this.class1092_0.method_6(BookmarkStart.b("弧", num), pair.Key, this.dictionary_32[BookmarkStart.b("弧", num)], pair.Value);
        }
        this.class1092_0.method_12();
    }

    private void method_415()
    {
        int num = 1;
        if (this.document_0.DocxPackage != null)
        {
            Class1128 class2 = this.document_0.DocxPackage.method_18(BookmarkStart.b("倦䘨太䤬.", num));
            if (class2.method_2().ContainsKey(BookmarkStart.b("倦䘨太䤬.渰䄲倴嬶䨸ᐺ丼娾㕀㝂ⱄ⥆⹈㡊捌㝎㱐㽒答╖㱘㝚⹜", num)))
            {
                this.class771_0.method_14(BookmarkStart.b("倦䘨太䤬献渰䄲倴嬶䨸机丼娾㕀㝂ⱄ⥆⹈㡊捌㝎㱐㽒答╖㱘㝚⹜", num), class2.method_2()[BookmarkStart.b("倦䘨太䤬.渰䄲倴嬶䨸ᐺ丼娾㕀㝂ⱄ⥆⹈㡊捌㝎㱐㽒答╖㱘㝚⹜", num)].method_4(), false, FileAttributes.Archive);
            }
        }
    }

    private void method_416()
    {
        int num = 4;
        this.class1092_0.method_10(BookmarkStart.b("䤩䌫䌭䀯匱䀳", 4), this.dictionary_32[BookmarkStart.b("崩", 4)]);
        this.method_417(this.document_0.Settings.method_5());
        List<string> list = new List<string>();
        int num2 = 0;
        int count = this.document_0.DocxPropsCompat2010.Count;
        while (num2 < count)
        {
            XmlReader reader = this.method_525(this.document_0.DocxPropsCompat2010[num2]);
            reader.MoveToContent();
            if (reader.LocalName != BookmarkStart.b("娩師䄭弯吱朳䈵夷丹夻", num))
            {
                if (reader.LocalName == BookmarkStart.b("䤩䌫䌭䀯匱䀳攵崷丹䠻圽⸿╁", num))
                {
                    string attribute = reader.GetAttribute(BookmarkStart.b("䐩䴫䌭唯", num), this.dictionary_32[BookmarkStart.b("崩", num)]);
                    list.Add(attribute);
                }
                this.method_272(this.document_0.DocxPropsCompat2010[num2]);
            }
            num2++;
        }
        if (!list.Contains(BookmarkStart.b("䤩䌫䌭䀯匱䀳張娷匹倻圽㐿㭁ृ⥅ⱇ⽉", num)))
        {
            this.class1092_0.method_10(BookmarkStart.b("䤩䌫䌭䀯匱䀳攵崷丹䠻圽⸿╁", num), this.dictionary_32[BookmarkStart.b("崩", num)]);
            this.class1092_0.method_6(BookmarkStart.b("崩", num), BookmarkStart.b("䐩䴫䌭唯", num), this.dictionary_32[BookmarkStart.b("崩", num)], BookmarkStart.b("䤩䌫䌭䀯匱䀳張娷匹倻圽㐿㭁ृ⥅ⱇ⽉", num));
            this.class1092_0.method_6(BookmarkStart.b("崩", num), BookmarkStart.b("弩師䜭", num), this.dictionary_32[BookmarkStart.b("崩", num)], BookmarkStart.b("䈩堫娭䀯࠱ᬳᤵ䬷夹吻嬽ⴿ⍁㝃桅╇⍉⽋㱍㽏⅑㭓さⱗ瑙㽛ㅝൟ䵡ୣe๧ͩཫ୭彯ձ᭳ѵᱷ", num));
            this.class1092_0.method_6(BookmarkStart.b("崩", num), BookmarkStart.b("尩䴫䈭", num), this.dictionary_32[BookmarkStart.b("崩", num)], this.method_540());
            this.class1092_0.method_12();
        }
        list.Clear();
        list = null;
        this.class1092_0.method_12();
    }

    private void method_417(Class908 A_0)
    {
        int num = 5;
        this.class1092_0.method_25(BookmarkStart.b("帪帬䨮戰娲嬴倶唸帺缼倾㍀❂⁄㕆⽈⑊㽌౎㹐㵒⅔㹖㹘⹚㉜⩞በ⁢d୦ըᡪ", 5), this.dictionary_32[BookmarkStart.b("尪", 5)], A_0.method_19());
        this.class1092_0.method_25(BookmarkStart.b("尪崬攮䐰䀲䄴帶弸刺帼帾㕀⩂⩄⥆", 5), this.dictionary_32[BookmarkStart.b("尪", 5)], A_0.method_63());
        this.class1092_0.method_25(BookmarkStart.b("䔪䈬笮倰儲紴嘶圸尺琼儾╀", 5), this.dictionary_32[BookmarkStart.b("尪", 5)], A_0.method_3());
        this.class1092_0.method_25(BookmarkStart.b("䔪䈬挮吰刲儴帶圸尺", 5), this.dictionary_32[BookmarkStart.b("尪", 5)], A_0.method_41());
        this.class1092_0.method_25(BookmarkStart.b("堪崬丮到嘲猴堶䬸渺焼", 5), this.dictionary_32[BookmarkStart.b("尪", 5)], A_0.method_43());
        this.class1092_0.method_25(BookmarkStart.b("䔪䈬氮帰弲䀴娶圸示尼匾⁀ⵂ♄≆", 5), this.dictionary_32[BookmarkStart.b("尪", 5)], A_0.method_13());
        this.class1092_0.method_25(BookmarkStart.b("䤪䰬䌮倰崲嘴制樸刺匼堾ⵀ♂݄㹆㵈⹊ौ⁎⑐ㅒ㥔㉖᭘≚⥜㩞㙠੢Ť፦Ũ", 5), this.dictionary_32[BookmarkStart.b("尪", 5)], A_0.method_33());
        this.class1092_0.method_25(BookmarkStart.b("䔪䈬樮䤰䜲䜴嘶甸刺匼娾ቀ㍂⑄⑆⁈╊⩌", 5), this.dictionary_32[BookmarkStart.b("尪", 5)], A_0.method_57());
        this.class1092_0.method_25(BookmarkStart.b("伪䈬愮帰䜲礴制堸䴺堼紾⁀⁂⹄㑆╈⩊㹌❎ၐ㽒㩔㥖㱘", 5), this.dictionary_32[BookmarkStart.b("尪", 5)], A_0.method_27());
        this.class1092_0.method_25(BookmarkStart.b("帪䄬笮䌰刲尴嬶樸䬺尼尾⑀", 5), this.dictionary_32[BookmarkStart.b("尪", 5)], A_0.method_31());
        this.class1092_0.method_25(BookmarkStart.b("伪䈬愮帰䜲瀴伶䤸娺匼嬾ቀ⭂ⱄⅆ㵈᥊⡌㭎⑐⅒㭔", 5), this.dictionary_32[BookmarkStart.b("尪", 5)], A_0.method_29());
        this.class1092_0.method_25(BookmarkStart.b("堪崬丮到娲嬴倶瀸唺樼圾⹀⽂⁄ᝆ♈≊⍌㭎≐", 5), this.dictionary_32[BookmarkStart.b("尪", 5)], A_0.method_37());
        this.class1092_0.method_25(BookmarkStart.b("䜪䐬䄮吰搲䜴嘶䤸眺吼吾⑀ᑂ⩄㕆ⵈ絊", 5), this.dictionary_32[BookmarkStart.b("尪", 5)], A_0.method_53());
        this.class1092_0.method_25(BookmarkStart.b("嬪弬䘮弰䜲眴堶崸䈺椼娾㥀㝂݄≆⽈⑊㽌⩎ᥐ㙒㑔㍖㱘⥚", 5), this.dictionary_32[BookmarkStart.b("尪", 5)], A_0.method_39());
        this.class1092_0.method_25(BookmarkStart.b("嬪弬䘮弰䜲瘴堶唸示儼帾≀⡂", 5), this.dictionary_32[BookmarkStart.b("尪", 5)], A_0.method_11());
        this.class1092_0.method_25(BookmarkStart.b("堪䔬䀮䘰焲䜴制堸债丼瘾⽀Ղ㝄♆⑈⹊㹌", 5), this.dictionary_32[BookmarkStart.b("尪", 5)], A_0.method_23());
        this.class1092_0.method_25(BookmarkStart.b("堪堬䴮眰尲嬴䌶笸䈺渼嘾㭀♂", 5), this.dictionary_32[BookmarkStart.b("尪", 5)], A_0.method_51());
        this.class1092_0.method_25(BookmarkStart.b("堪堬弮䄰䄲倴䐶䨸示刼䬾㕀ⱂ⡄ᑆ㥈⩊⹌♎㽐㑒", 5), this.dictionary_32[BookmarkStart.b("尪", 5)], A_0.method_59());
        this.class1092_0.method_25(BookmarkStart.b("堪堬弮䄰䄲倴䐶䨸漺刼伾ቀ㍂⑄⑆⁈╊⩌", 5), this.dictionary_32[BookmarkStart.b("尪", 5)], A_0.method_17());
        this.class1092_0.method_25(BookmarkStart.b("堪堬弮䄰䄲倴䐶䨸栺䴼帾≀⩂⭄⁆ࡈ㽊᥌⁎⅐᱒㍔ݖ㡘㱚㡜", 5), this.dictionary_32[BookmarkStart.b("尪", 5)], A_0.method_35());
        this.class1092_0.method_25(BookmarkStart.b("堪堬弮䄰䄲倴䐶䨸漺刼伾ቀ㍂⑄⑆⁈╊⩌ᡎŐ", 5), this.dictionary_32[BookmarkStart.b("尪", 5)], A_0.method_47());
        this.class1092_0.method_25(BookmarkStart.b("堪堬弮䄰䄲倴䐶䨸栺䴼紾❀ɂ⍄㍆ⱈ㥊ᵌ⡎ፐ⅒㹔", 5), this.dictionary_32[BookmarkStart.b("尪", 5)], A_0.method_7());
        this.class1092_0.method_25(BookmarkStart.b("堪娬丮䄰焲娴䔶崸帺似䰾݀≂♄⹆❈ⱊᵌ⹎㙐㙒♔", 5), this.dictionary_32[BookmarkStart.b("尪", 5)], A_0.method_25());
        this.class1092_0.method_25(BookmarkStart.b("䠪䈬䄮䜰縲吴帶唸瘺堼䴾♀♂D㑆⩈", 5), this.dictionary_32[BookmarkStart.b("尪", 5)], A_0.method_15());
        this.class1092_0.method_25(BookmarkStart.b("弪弬娮弰倲吴䌶尸紺刼儾㕀ୂ⁄⹆⹈⍊㥌㱎ᵐ㩒㹔㉖๘୚歜", 5), this.dictionary_32[BookmarkStart.b("尪", 5)], A_0.method_49());
        this.class1092_0.method_25(BookmarkStart.b("䘪娬簮尰刲头嬶稸娺䴼䰾", 5), this.dictionary_32[BookmarkStart.b("尪", 5)], A_0.method_45());
        this.class1092_0.method_25(BookmarkStart.b("帪帬䨮愰䄲尴夶䴸帺似爾⑀㝂㝄⹆⩈㡊", 5), this.dictionary_32[BookmarkStart.b("尪", 5)], A_0.method_65());
        this.class1092_0.method_25(BookmarkStart.b("伪䈬愮帰䜲昴䈶䤸䬺似娾㉀あᕄ♆㭈⩊⩌㵎ぐ⍒㵔ᕖ㙘⥚㥜㩞፠ၢ", 5), this.dictionary_32[BookmarkStart.b("尪", 5)], A_0.method_55());
        this.class1092_0.method_25(BookmarkStart.b("尪弬丮䄰朲䜴嘶倸场渼伾⁀⁂⁄㑆", 5), this.dictionary_32[BookmarkStart.b("尪", 5)], A_0.method_9());
        this.class1092_0.method_25(BookmarkStart.b("䴪䈬䀮䔰崲娴䌶尸眺尼䘾⹀㙂ㅄ୆⁈⁊⡌ᡎِ歒", 5), this.dictionary_32[BookmarkStart.b("尪", 5)], A_0.method_69());
        this.class1092_0.method_25(BookmarkStart.b("堪䔬丮䄰嘲礴嘶䀸吺䠼䬾ീ⩂⹄≆Ṉ᱊界", 5), this.dictionary_32[BookmarkStart.b("尪", 5)], A_0.method_67());
        this.class1092_0.method_25(BookmarkStart.b("䨪䄬䘮嘰崲愴嘶嬸场堼䰾ፀⱂ㉄Նえ᥊≌㡎", 5), this.dictionary_32[BookmarkStart.b("尪", 5)], A_0.method_79());
        this.class1092_0.method_25(BookmarkStart.b("䴪䈬崮嘰嘲䄴笶堸䠺䤼款⁀⅂ф⭆⁈ⱊ⍌≎㑐㵒⅔", 5), this.dictionary_32[BookmarkStart.b("尪", 5)], A_0.method_75());
        this.class1092_0.method_25(BookmarkStart.b("䨪䤬䔮䐰䀲䄴笶倸唺堼眾⑀⩂≄⽆㵈Ɋ⍌᭎ぐㅒ㥔㉖", 5), this.dictionary_32[BookmarkStart.b("尪", 5)], !A_0.method_73());
        this.class1092_0.method_25(BookmarkStart.b("䨪堬嬮帰怲䔴嘶娸帺焼嘾⩀♂ቄ⡆㭈⽊瑌穎", 5), this.dictionary_32[BookmarkStart.b("尪", 5)], A_0.method_77());
        this.class1092_0.method_25(BookmarkStart.b("䔪䈬簮䄰刲嘴制欸娺吼䰾⑀ག⩄うⱈ㥊", 5), this.dictionary_32[BookmarkStart.b("尪", 5)], A_0.method_5());
        this.class1092_0.method_25(BookmarkStart.b("伪䈬愮帰䜲怴䐶尸猺椼爾ീፂ⑄㕆⡈ⱊ㽌⹎⅐㭒ᑔ≖ⵘ㑚๜⽞`b౤०๨", 5), this.dictionary_32[BookmarkStart.b("尪", 5)], A_0.method_71());
        this.class1092_0.method_25(BookmarkStart.b("䜪䰬嘮帰䘲䄴收堸䰺椼帾⍀⽂⁄၆⁈⽊㥌❎", 5), this.dictionary_32[BookmarkStart.b("尪", 5)], A_0.method_81());
        this.class1092_0.method_25(BookmarkStart.b("䜪䰬嘮帰䘲䄴挶堸夺儼娾ፀⱂ㉄㑆ࡈ㭊ⱌ㵎═", 5), this.dictionary_32[BookmarkStart.b("尪", 5)], A_0.method_83());
        this.class1092_0.method_25(BookmarkStart.b("帪帬䨮昰尲䜴匶8఺焼嘾⽀♂݄㕆ⱈ⩊♌ᵎ⑐㽒ご⑖", 5), this.dictionary_32[BookmarkStart.b("尪", 5)], A_0.method_85());
        this.class1092_0.method_25(BookmarkStart.b("伪䈬愮帰䜲眴䔶尸娺嘼栾㍀≂㕄㝆ⱈ⽊᥌⹎㍐㽒ご⑖", 5), this.dictionary_32[BookmarkStart.b("尪", 5)], A_0.method_87());
        this.class1092_0.method_25(BookmarkStart.b("伪䈬愮帰䜲昴夶堸䬺椼倾ـㅂⱄ⍆H╊์⩎㵐㽒", 5), this.dictionary_32[BookmarkStart.b("尪", 5)], A_0.method_89());
        this.class1092_0.method_25(BookmarkStart.b("堪䠬䌮吰倲䄴然唸强樼嘾㕀⭂̈́⹆㭈㡊㥌N⍐ὒ㑔⑖ⵘᡚ㕜㹞፠", 5), this.dictionary_32[BookmarkStart.b("尪", 5)], A_0.method_91());
        this.class1092_0.method_25(BookmarkStart.b("䨪崬弮崰䨲眴䔶尸娺嘼嘾⽀⑂ᝄ㉆╈⹊㹌", 5), this.dictionary_32[BookmarkStart.b("尪", 5)], A_0.method_93());
        this.class1092_0.method_25(BookmarkStart.b("伪䈬愮帰䜲戴䔶堸䬺椼娾㥀㝂ቄ⹆㵈⍊ᵌ㩎㽐げ⅔", 5), this.dictionary_32[BookmarkStart.b("尪", 5)], A_0.method_95());
        this.class1092_0.method_25(BookmarkStart.b("伪䈬愮帰䜲怴䐶尸縺尼䰾㕀ɂ㙄⹆⡈╊ཌ㵎㑐㉒㹔Ֆⱘ㝚㡜ⱞ", 5), this.dictionary_32[BookmarkStart.b("尪", 5)], A_0.method_97());
        this.class1092_0.method_25(BookmarkStart.b("帪帬䨮昰尲䜴匶ସ଺഼ാᕀ≂❄⭆ⱈᡊ㥌㙎㵐㙒ݔ≖㕘㹚⹜", 5), this.dictionary_32[BookmarkStart.b("尪", 5)], A_0.method_99());
        this.class1092_0.method_25(BookmarkStart.b("䰪弬䀮䘰爲䀴䌶嘸崺吼䬾", 5), this.dictionary_32[BookmarkStart.b("尪", 5)], A_0.method_101());
        this.class1092_0.method_25(BookmarkStart.b("帪帬䨮眰瘲礴嘶䀸吺䠼䬾", 5), this.dictionary_32[BookmarkStart.b("尪", 5)], A_0.method_133());
        this.class1092_0.method_25(BookmarkStart.b("帪帬䨮缰尲䜴娶堸场渼䬾㡀⽂⁄ņ♈㥊Ō♎≐❒", 5), this.dictionary_32[BookmarkStart.b("尪", 5)], A_0.method_103());
        this.class1092_0.method_25(BookmarkStart.b("伪䈬愮帰䜲怴䐶尸爺匼嬾⑀ⵂㅄن㩈Պ㡌≎㍐㙒❔㹖㝘㱚ड़㹞͠ぢᅤࡦᥨ", 5), this.dictionary_32[BookmarkStart.b("尪", 5)], A_0.method_105());
        this.class1092_0.method_25(BookmarkStart.b("帪帬䨮瀰弲䄴簶倸唺丼倾⩀㙂ॄ⹆❈⹊ཌ㵎㑐㉒㹔Ֆⱘ㝚㡜ⱞ", 5), this.dictionary_32[BookmarkStart.b("尪", 5)], A_0.method_107());
        this.class1092_0.method_25(BookmarkStart.b("䨪䄬䌮帰䐲昴䜶堸堺堼瀾❀၂⑄⩆ⱈᡊ㥌㙎㵐㙒᱔㥖൘㩚㽜㍞Ѡ", 5), this.dictionary_32[BookmarkStart.b("尪", 5)], A_0.method_109());
        this.class1092_0.method_25(BookmarkStart.b("伪䈬愮帰䜲昴䈶䤸䬺似娾㉀あౄ⥆ⵈ⹊⍌㭎ぐ❒㱔㡖㝘", 5), this.dictionary_32[BookmarkStart.b("尪", 5)], A_0.method_111());
        this.class1092_0.method_25(BookmarkStart.b("伪䈬愮帰䜲琴䈶䴸吺嬼嘾㕀B⩄⥆㩈㽊㽌⹎㡐㵒ご㍖൘㩚㽜㍞Ѡၢ", 5), this.dictionary_32[BookmarkStart.b("尪", 5)], A_0.method_113());
        this.class1092_0.method_25(BookmarkStart.b("䨪堬嬮帰唲尴䌶洸吺笼嘾㍀あㅄņ⁈㍊⡌⭎ِ㩒ㅔ⍖ㅘᡚ㡜㍞ൠ", 5), this.dictionary_32[BookmarkStart.b("尪", 5)], A_0.method_115());
        this.class1092_0.method_25(BookmarkStart.b("帪䌬䬮吰䄲头帶圸帺椼帾⍀ੂ⭄ॆ㱈♊Ō♎≐❒", 5), this.dictionary_32[BookmarkStart.b("尪", 5)], A_0.method_117());
        this.class1092_0.method_25(BookmarkStart.b("伪䐬尮䄰弲吴丶焸娺匼堾㑀⽂̈́⹆ㅈ⹊⥌ᡎ㡐㝒⅔㽖", 5), this.dictionary_32[BookmarkStart.b("尪", 5)], A_0.method_119());
        this.class1092_0.method_25(BookmarkStart.b("堪崬䌮堰䜲攴倶笸䤺堼帾⩀ɂ⭄⍆᥈⩊㽌⹎᱐㉒❔㱖", 5), this.dictionary_32[BookmarkStart.b("尪", 5)], A_0.method_121());
        this.class1092_0.method_25(BookmarkStart.b("伪䈬愮帰䜲挴制䬸伺簼匾⡀⑂⭄цⱈ❊⅌ᡎ㡐❒㵔і⥘", 5), this.dictionary_32[BookmarkStart.b("尪", 5)], A_0.method_123());
        this.class1092_0.method_25(BookmarkStart.b("伪䈬愮帰䜲眴䔶尸娺嘼簾⹀ⵂ㙄㍆㭈⩊⑌ⅎ㑐㝒ፔ㡖⭘㡚㡜㭞㕠ɢݤ୦౨", 5), this.dictionary_32[BookmarkStart.b("尪", 5)], A_0.method_125());
        this.class1092_0.method_25(BookmarkStart.b("伪䈬愮帰䜲挴制䬸伺簼匾⡀⑂⭄ๆ❈Ὂ㕌ⵎ⥐", 5), this.dictionary_32[BookmarkStart.b("尪", 5)], A_0.method_127());
        this.class1092_0.method_25(BookmarkStart.b("帪帬䨮瀰崲䘴帶爸帺似儾⡀ⵂ≄ᝆ⡈≊㽌㱎", 5), this.dictionary_32[BookmarkStart.b("尪", 5)], A_0.method_129());
        this.class1092_0.method_25(BookmarkStart.b("䠪䰬䰮夰嘲儴琶嘸场缼帾ⵀ≂⭄⑆ⱈ", 5), this.dictionary_32[BookmarkStart.b("尪", 5)], A_0.method_131());
        this.class1092_0.method_25(BookmarkStart.b("尪崬簮䄰刲嘴制游刺夼䬾⥀", 5), this.dictionary_32[BookmarkStart.b("尪", 5)], A_0.method_61());
        if (A_0.method_135())
        {
            this.class1092_0.method_10(BookmarkStart.b("䠪䈬䈮䄰刲䄴搶尸伺䤼嘾⽀⑂", num), this.dictionary_32[BookmarkStart.b("尪", num)]);
            this.class1092_0.method_6(BookmarkStart.b("尪", num), BookmarkStart.b("䔪䰬䈮吰", num), this.dictionary_32[BookmarkStart.b("尪", num)], BookmarkStart.b("伪䈬愮帰䜲猴嬶倸䬺瀼嘾㍀ㅂ⩄㕆H╊⥌⩎㽐❒♔", num));
            this.class1092_0.method_6(BookmarkStart.b("尪", num), BookmarkStart.b("帪弬䘮", num), this.dictionary_32[BookmarkStart.b("尪", num)], BookmarkStart.b("䌪夬嬮䄰लᨴᠶ䨸堺唼娾ⱀ≂㙄楆⑈≊⹌㵎㹐⁒㩔ㅖⵘ畚㹜ぞౠ䱢੤Ŧཨɪ๬੮幰Ѳᩴնᵸ", num));
            this.class1092_0.method_6(BookmarkStart.b("尪", num), BookmarkStart.b("崪䰬䌮", num), this.dictionary_32[BookmarkStart.b("尪", num)], BookmarkStart.b("ᨪ", num));
            this.class1092_0.method_12();
        }
        if (A_0.method_0(CompatibilityOptions.enableOpenTypeFeatures))
        {
            this.class1092_0.method_10(BookmarkStart.b("䠪䈬䈮䄰刲䄴搶尸伺䤼嘾⽀⑂", num), this.dictionary_32[BookmarkStart.b("尪", num)]);
            this.class1092_0.method_6(BookmarkStart.b("尪", num), BookmarkStart.b("䔪䰬䈮吰", num), this.dictionary_32[BookmarkStart.b("尪", num)], BookmarkStart.b("个䌬丮匰弲倴砶䤸帺匼款㡀㍂⁄ņⱈ⩊㥌㩎⍐㙒♔", num));
            this.class1092_0.method_6(BookmarkStart.b("尪", num), BookmarkStart.b("帪弬䘮", num), this.dictionary_32[BookmarkStart.b("尪", num)], BookmarkStart.b("䌪夬嬮䄰लᨴᠶ䨸堺唼娾ⱀ≂㙄楆⑈≊⹌㵎㹐⁒㩔ㅖⵘ畚㹜ぞౠ䱢੤Ŧཨɪ๬੮幰Ѳᩴնᵸ", num));
            this.class1092_0.method_6(BookmarkStart.b("尪", num), BookmarkStart.b("崪䰬䌮", num), this.dictionary_32[BookmarkStart.b("尪", num)], BookmarkStart.b("ᨪ", num));
            this.class1092_0.method_12();
        }
        if (A_0.method_0(CompatibilityOptions.overrideTableStyleFontSizeAndJustification))
        {
            this.class1092_0.method_10(BookmarkStart.b("䠪䈬䈮䄰刲䄴搶尸伺䤼嘾⽀⑂", num), this.dictionary_32[BookmarkStart.b("尪", num)]);
            this.class1092_0.method_6(BookmarkStart.b("尪", num), BookmarkStart.b("䔪䰬䈮吰", num), this.dictionary_32[BookmarkStart.b("尪", num)], BookmarkStart.b("䐪嬬䨮䌰䄲尴匶尸漺尼崾ⵀ♂ᙄ㍆え❊⡌ॎ㹐㵒⅔іじ⅚㡜Ṟའݢ⽤ቦᩨὪѬ८ᡰၲᑴͶၸᑺ፼", num));
            this.class1092_0.method_6(BookmarkStart.b("尪", num), BookmarkStart.b("帪弬䘮", num), this.dictionary_32[BookmarkStart.b("尪", num)], BookmarkStart.b("䌪夬嬮䄰लᨴᠶ䨸堺唼娾ⱀ≂㙄楆⑈≊⹌㵎㹐⁒㩔ㅖⵘ畚㹜ぞౠ䱢੤Ŧཨɪ๬੮幰Ѳᩴնᵸ", num));
            this.class1092_0.method_6(BookmarkStart.b("尪", num), BookmarkStart.b("崪䰬䌮", num), this.dictionary_32[BookmarkStart.b("尪", num)], BookmarkStart.b("ᨪ", num));
            this.class1092_0.method_12();
        }
    }

    private void method_418(ProtectionType A_0, bool A_1)
    {
        int num = 15;
        string str = string.Empty;
        switch (A_0)
        {
            case ProtectionType.AllowOnlyRevisions:
                str = BookmarkStart.b("䄴䔶堸堺嘼娾╀Bⵄ♆❈ⱊ⡌㱎", num);
                break;

            case ProtectionType.AllowOnlyComments:
                str = BookmarkStart.b("嘴堶吸嘺堼儾㕀あ", num);
                break;

            case ProtectionType.AllowOnlyFormFields:
                str = BookmarkStart.b("匴堶䬸嘺丼", num);
                break;

            case ProtectionType.AllowOnlyReading:
                str = BookmarkStart.b("䜴制堸强爼儾ⵀ㩂", num);
                break;
        }
        if (str != string.Empty)
        {
            this.class1092_0.method_10(BookmarkStart.b("儴堶娸为值娾⽀㝂ᕄ㕆♈㽊⡌ⱎ═㩒㩔㥖", num), this.dictionary_32[BookmarkStart.b("䈴", num)]);
            this.class1092_0.method_5(BookmarkStart.b("倴匶倸伺", num), this.dictionary_32[BookmarkStart.b("䈴", num)], str);
            this.class1092_0.method_5(BookmarkStart.b("倴夶弸吺似尾⑀⹂⁄⥆㵈", num), this.dictionary_32[BookmarkStart.b("䈴", num)], A_1 ? BookmarkStart.b("д", num) : BookmarkStart.b("Դ", num));
            if (this.document_0.LegacyHash != 0)
            {
                Class63 class2 = new Class63();
                this.class1092_0.method_5(BookmarkStart.b("嘴䔶䀸䬺䤼漾㍀ⱂ㍄⹆ⵈ⹊㽌᭎⡐⍒ご", num), this.dictionary_32[BookmarkStart.b("䈴", num)], BookmarkStart.b("䜴䐶堸紺䠼匾ⵀ", num));
                this.class1092_0.method_5(BookmarkStart.b("嘴䔶䀸䬺䤼績ⵀ⑂⩄㕆⁈㽊╌≎ቐ㽒㑔⑖⩘", num), this.dictionary_32[BookmarkStart.b("䈴", num)], BookmarkStart.b("崴嘶䨸区", num));
                this.class1092_0.method_5(BookmarkStart.b("嘴䔶䀸䬺䤼績ⵀ⑂⩄㕆⁈㽊╌≎Ր⩒╔㉖", num), this.dictionary_32[BookmarkStart.b("䈴", num)], BookmarkStart.b("䄴丶䤸帺簼儾㡀", num));
                this.class1092_0.method_5(BookmarkStart.b("嘴䔶䀸䬺䤼績ⵀ⑂⩄㕆⁈㽊╌≎ɐ㩒ㅔ", num), this.dictionary_32[BookmarkStart.b("䈴", num)], 4.ToString());
                this.class1092_0.method_5(BookmarkStart.b("嘴䔶䀸䬺䤼氾ㅀ⩂⭄ц♈㹊⍌㭎", num), this.dictionary_32[BookmarkStart.b("䈴", num)], 0x186a0.ToString());
                byte[] buffer = class2.method_2(0x10);
                byte[] inArray = class2.method_0(buffer, this.document_0.LegacyHash);
                this.class1092_0.method_5(BookmarkStart.b("崴嘶䨸区", num), this.dictionary_32[BookmarkStart.b("䈴", num)], Convert.ToBase64String(inArray));
                this.class1092_0.method_5(BookmarkStart.b("䘴嘶唸伺", num), this.dictionary_32[BookmarkStart.b("䈴", num)], Convert.ToBase64String(buffer));
            }
            this.class1092_0.method_12();
        }
    }

    private void method_419(VariableCollection A_0)
    {
        int num = 8;
        this.class1092_0.method_10(BookmarkStart.b("䨭弯儱戳圵䨷䤹", 8), this.dictionary_32[BookmarkStart.b("夭", 8)]);
        string str = string.Empty;
        foreach (string str2 in A_0.Items.Keys)
        {
            if (A_0.Items.ContainsKey(str2))
            {
                str = A_0.Items[str2];
            }
            this.class1092_0.method_10(BookmarkStart.b("䨭弯儱戳圵䨷", num), this.dictionary_32[BookmarkStart.b("夭", num)]);
            this.class1092_0.method_5(BookmarkStart.b("䀭儯弱儳", num), this.dictionary_32[BookmarkStart.b("夭", num)], str2);
            this.class1092_0.method_5(BookmarkStart.b("堭儯帱", num), this.dictionary_32[BookmarkStart.b("夭", num)], str);
            this.class1092_0.method_12();
        }
        this.class1092_0.method_12();
    }

    private Dictionary<string, Class517> method_42()
    {
        if (this.dictionary_6 == null)
        {
            this.dictionary_6 = new Dictionary<string, Class517>();
        }
        return this.dictionary_6;
    }

    private void method_420()
    {
        this.method_402(null, false);
    }

    private void method_421()
    {
        int num = 6;
        if (this.document_0.EndnoteOptions.Position == FootnotePosition.PrintAsEndOfSection)
        {
            this.class1092_0.method_10(BookmarkStart.b("尫䄭䌯", num), this.dictionary_32[BookmarkStart.b("嬫", num)]);
            this.class1092_0.method_5(BookmarkStart.b("娫伭尯", num), this.dictionary_32[BookmarkStart.b("嬫", num)], BookmarkStart.b("弫䬭匯䘱焳堵尷", num));
            this.class1092_0.method_12();
        }
    }

    private void method_422()
    {
        int num = 0x13;
        if (this.document_0.FootnoteOptions.Position == FootnotePosition.PrintImmediatelyBeneathText)
        {
            this.class1092_0.method_10(BookmarkStart.b("䤸吺丼", num), this.dictionary_32[BookmarkStart.b("丸", num)]);
            this.class1092_0.method_5(BookmarkStart.b("伸娺儼", num), this.dictionary_32[BookmarkStart.b("丸", num)], BookmarkStart.b("嬸帺匼娾⁀㝂ⵄፆⱈ㍊㥌", num));
            this.class1092_0.method_12();
        }
        else if (this.document_0.FootnoteOptions.Position == FootnotePosition.PrintAsEndOfSection)
        {
            this.method_421();
        }
    }

    private void method_423(bool A_0, int A_1)
    {
        int num = 15;
        string str = A_0 ? BookmarkStart.b("匴堶嘸伺匼倾㕀♂", num) : BookmarkStart.b("倴夶崸唺刼䬾⑀", num);
        this.class1092_0.method_10(str, this.dictionary_32[BookmarkStart.b("䈴", num)]);
        this.class1092_0.method_5(BookmarkStart.b("尴匶", num), this.dictionary_32[BookmarkStart.b("䈴", num)], A_1.ToString());
        this.class1092_0.method_12();
    }

    private void method_424()
    {
        int num = 0x12;
        this.dictionary_32 = this.document_0.DocxNameSpace.method_0()[BookmarkStart.b("伷弹帻洽┿㙁ぃ⽅♇ⵉ㽋", 0x12)];
        MemoryStream stream = new MemoryStream();
        this.class1092_0 = this.method_524(stream);
        this.class1092_0.method_11(BookmarkStart.b("伷", 0x12), BookmarkStart.b("伷弹帻洽┿㙁ぃ⽅♇ⵉ㽋", 0x12), this.dictionary_32[BookmarkStart.b("伷", 0x12)]);
        this.class1092_0.method_6(BookmarkStart.b("䀷圹倻倽㌿", 0x12), BookmarkStart.b("唷夹", 0x12), null, this.dictionary_32[BookmarkStart.b("唷夹", 0x12)]);
        this.class1092_0.method_6(BookmarkStart.b("䀷圹倻倽㌿", 0x12), BookmarkStart.b("䨷", 0x12), null, this.dictionary_32[BookmarkStart.b("䨷", 0x12)]);
        this.class1092_0.method_6(BookmarkStart.b("䀷圹倻倽㌿", 0x12), BookmarkStart.b("伷", 0x12), null, this.dictionary_32[BookmarkStart.b("伷", 0x12)]);
        this.class1092_0.method_6(BookmarkStart.b("䀷圹倻倽㌿", 0x12), BookmarkStart.b("伷ହ࠻", 0x12), null, this.dictionary_32[BookmarkStart.b("伷ହ࠻", 0x12)]);
        this.class1092_0.method_6(BookmarkStart.b("䀷圹倻倽㌿", 0x12), BookmarkStart.b("伷ହऻ", 0x12), null, this.dictionary_32[BookmarkStart.b("伷ହऻ", 0x12)]);
        this.class1092_0.method_6(BookmarkStart.b("唷夹", 0x12), BookmarkStart.b("焷崹刻儽㈿⍁♃⩅ⵇ", 0x12), null, BookmarkStart.b("伷ହ࠻ḽ㜿獁煃", 0x12));
        if (this.document_0.WebSettings.method_5().Count > 0)
        {
            this.class1092_0.method_11(BookmarkStart.b("伷", num), BookmarkStart.b("尷匹䨻䴽", num), this.dictionary_32[BookmarkStart.b("伷", num)]);
            foreach (Class51 class2 in this.document_0.WebSettings.method_5())
            {
                this.method_425(class2);
            }
            this.class1092_0.method_12();
        }
        if (this.document_0.WebSettings.method_8())
        {
            this.class1092_0.method_11(BookmarkStart.b("伷", num), BookmarkStart.b("圷䨹䠻圽ⴿ⭁㹃⍅็╉㹋్≏㵑⍓╕㵗⡙", num), this.dictionary_32[BookmarkStart.b("伷", num)]);
            if (this.document_0.WebSettings.method_10() != WebTarget.None)
            {
                this.class1092_0.method_5(BookmarkStart.b("䰷嬹主夽┿㙁", num), this.dictionary_32[BookmarkStart.b("伷", num)], this.method_427(this.document_0.WebSettings.method_10()));
            }
            this.class1092_0.method_12();
        }
        if (this.document_0.WebSettings.method_12())
        {
            this.class1092_0.method_10(BookmarkStart.b("夷嘹倻儽㜿ቁ੃Ņ", num), this.dictionary_32[BookmarkStart.b("伷", num)]);
            this.class1092_0.method_12();
        }
        if (this.document_0.WebSettings.method_14())
        {
            this.class1092_0.method_10(BookmarkStart.b("尷唹爻儽㐿၁⅃⩅ㅇՉ≋്͏ő", num), this.dictionary_32[BookmarkStart.b("伷", num)]);
            this.class1092_0.method_12();
        }
        if (this.document_0.WebSettings.method_16())
        {
            this.class1092_0.method_10(BookmarkStart.b("尷唹爻儽㐿ᅁ╃ぅⵇ୉㽋ᵍ㥏㱑㍓㩕㵗᱙㕛㉝՟", num), this.dictionary_32[BookmarkStart.b("伷", num)]);
            this.class1092_0.method_12();
        }
        if (this.document_0.WebSettings.method_18())
        {
            this.class1092_0.method_10(BookmarkStart.b("尷唹爻儽㐿ു㙃ⅅ⥇⑉╋㑍㕏᭑㩓ၕ㝗㙙㡛㭝቟", num), this.dictionary_32[BookmarkStart.b("伷", num)]);
            this.class1092_0.method_12();
        }
        if (this.document_0.WebSettings.method_20())
        {
            this.class1092_0.method_10(BookmarkStart.b("尷唹爻儽㐿ᝁ㝃⍅ч╉≋⥍ᙏ㭑㡓㍕ᙗ㭙ㅛ㭝፟", num), this.dictionary_32[BookmarkStart.b("伷", num)]);
            this.class1092_0.method_12();
        }
        if (this.document_0.WebSettings.method_22() != 0x60)
        {
            this.class1092_0.method_10(BookmarkStart.b("䠷匹䐻嬽ⰿㅁᑃ⍅㩇͉≋ⵍ㡏", num), this.dictionary_32[BookmarkStart.b("伷", num)]);
            this.class1092_0.method_4(BookmarkStart.b("丷嬹倻", num), this.document_0.WebSettings.method_22().ToString());
            this.class1092_0.method_12();
        }
        if (this.document_0.WebSettings.method_24() != ScreenSize.Size800x600)
        {
            this.class1092_0.method_10(BookmarkStart.b("䰷嬹主夽┿㙁ᝃ╅㩇⽉⥋⁍͏⡑", num), this.dictionary_32[BookmarkStart.b("伷", num)]);
            this.class1092_0.method_4(BookmarkStart.b("丷嬹倻", num), this.document_0.WebSettings.method_28(this.document_0.WebSettings.method_24()));
            this.class1092_0.method_12();
        }
        this.class1092_0.method_12();
        this.class1092_0.method_15();
        this.class771_0.method_14(BookmarkStart.b("伷唹主娽᰿㕁⅃⑅ᭇ⽉㡋㩍㥏㱑㍓╕癗≙ㅛ㉝", num), stream, false, FileAttributes.Archive);
    }

    private void method_425(Class51 A_0)
    {
        int num = 8;
        this.class1092_0.method_11(BookmarkStart.b("夭", 8), BookmarkStart.b("䨭夯䐱", 8), this.dictionary_32[BookmarkStart.b("夭", 8)]);
        this.class1092_0.method_5(BookmarkStart.b("䜭启", 8), this.dictionary_32[BookmarkStart.b("夭", 8)], A_0.method_7().ToString());
        this.class1092_0.method_11(BookmarkStart.b("夭", 8), BookmarkStart.b("䌭儯䀱砳匵帷丹", 8), this.dictionary_32[BookmarkStart.b("夭", 8)]);
        this.class1092_0.method_5(BookmarkStart.b("堭儯帱", 8), this.dictionary_32[BookmarkStart.b("夭", 8)], this.method_534(A_0.method_5().Left * 20f));
        this.class1092_0.method_12();
        this.class1092_0.method_11(BookmarkStart.b("夭", 8), BookmarkStart.b("䌭儯䀱昳張強刹䠻", 8), this.dictionary_32[BookmarkStart.b("夭", 8)]);
        this.class1092_0.method_5(BookmarkStart.b("堭儯帱", 8), this.dictionary_32[BookmarkStart.b("夭", 8)], this.method_534(A_0.method_5().Right * 20f));
        this.class1092_0.method_12();
        this.class1092_0.method_11(BookmarkStart.b("夭", 8), BookmarkStart.b("䌭儯䀱怳夵䠷", 8), this.dictionary_32[BookmarkStart.b("夭", 8)]);
        this.class1092_0.method_5(BookmarkStart.b("堭儯帱", 8), this.dictionary_32[BookmarkStart.b("夭", 8)], this.method_534(A_0.method_5().Top * 20f));
        this.class1092_0.method_12();
        this.class1092_0.method_11(BookmarkStart.b("夭", 8), BookmarkStart.b("䌭儯䀱瘳夵䰷丹医匽", 8), this.dictionary_32[BookmarkStart.b("夭", 8)]);
        this.class1092_0.method_5(BookmarkStart.b("堭儯帱", 8), this.dictionary_32[BookmarkStart.b("夭", 8)], this.method_534(A_0.method_5().Bottom * 20f));
        this.class1092_0.method_12();
        this.class1092_0.method_11(BookmarkStart.b("夭", 8), BookmarkStart.b("䨭夯䐱瘳刵䨷", 8), this.dictionary_32[BookmarkStart.b("夭", 8)]);
        this.method_496(A_0.method_6().Top, BookmarkStart.b("娭弯䈱", 8), 8);
        this.method_496(A_0.method_6().Left, BookmarkStart.b("䈭唯吱䀳", 8), 8);
        this.method_496(A_0.method_6().Bottom, BookmarkStart.b("䰭弯䘱䀳夵唷", 8), 8);
        this.method_496(A_0.method_6().Right, BookmarkStart.b("尭夯唱尳䈵", 8), 8);
        this.class1092_0.method_12();
        if (A_0.method_13().Count > 0)
        {
            this.class1092_0.method_11(BookmarkStart.b("夭", num), BookmarkStart.b("䨭夯䐱䜳电倷匹倻娽", num), this.dictionary_32[BookmarkStart.b("夭", num)]);
            foreach (Class51 class2 in A_0.method_13())
            {
                this.method_425(class2);
            }
            this.class1092_0.method_12();
        }
        this.class1092_0.method_12();
    }

    private void method_426()
    {
        int num = 8;
        if (this.document_0.DocxPackage != null)
        {
            Class1128 class2 = this.document_0.DocxPackage.method_18(BookmarkStart.b("夭弯䀱倳ᤵ", num));
            if (class2.method_2().ContainsKey(BookmarkStart.b("夭弯䀱倳ᤵ朷䠹夻刽㌿流㍃⍅⩇᥉⥋㩍⑏㭑㩓ㅕ⭗瑙⑛㍝౟䱡ᙣͥѧᥩ", num)))
            {
                this.class771_0.method_14(BookmarkStart.b("夭弯䀱倳樵朷䠹夻刽㌿ṁ㍃⍅⩇᥉⥋㩍⑏㭑㩓ㅕ⭗瑙⑛㍝౟䱡ᙣͥѧᥩ", num), class2.method_2()[BookmarkStart.b("夭弯䀱倳ᤵ朷䠹夻刽㌿流㍃⍅⩇᥉⥋㩍⑏㭑㩓ㅕ⭗瑙⑛㍝౟䱡ᙣͥѧᥩ", num)].method_4(), false, FileAttributes.Archive);
            }
        }
    }

    private string method_427(WebTarget A_0)
    {
        int num = 14;
        switch (A_0)
        {
            case WebTarget.XhtmlPlusCss1:
                return BookmarkStart.b("挳Ե笷ᨹ搻瘽ᐿཁࡃ浅େ᥉Ὃ罍", num);

            case WebTarget.Html4PlusCss1:
                return BookmarkStart.b("挳Ե笷ᨹ琻樽ിแ灃浅େ᥉Ὃ罍", num);

            case WebTarget.XhtmlPlusCss2:
                return BookmarkStart.b("挳Ե笷ᨹ搻瘽ᐿཁࡃ浅େ᥉Ὃ籍", num);

            case WebTarget.Html4PlusCss2:
                return BookmarkStart.b("挳Ե笷ᨹ琻樽ിแ灃浅େ᥉Ὃ籍", num);
        }
        return "";
    }

    private void method_428()
    {
        int num = 7;
        if ((this.document_0.ListStyles.Count != 0) || (this.document_0.ListOverrides.Count != 0))
        {
            this.dictionary_32 = this.document_0.DocxNameSpace.method_0()[BookmarkStart.b("䌬娮尰儲倴䔶倸唺娼", num)];
            MemoryStream stream = new MemoryStream();
            this.class1092_0 = this.method_524(stream);
            this.method_33(true);
            this.class1092_0.method_11(BookmarkStart.b("娬", num), BookmarkStart.b("䌬娮尰儲倴䔶倸唺娼", num), this.dictionary_32[BookmarkStart.b("娬", num)]);
            this.class1092_0.method_6(BookmarkStart.b("唬䈮崰崲䘴", num), BookmarkStart.b("娬弮到", num), null, this.dictionary_32[BookmarkStart.b("娬弮到", num)]);
            this.class1092_0.method_6(BookmarkStart.b("唬䈮崰崲䘴", num), BookmarkStart.b("䀬䰮", num), null, this.dictionary_32[BookmarkStart.b("䀬䰮", num)]);
            this.class1092_0.method_6(BookmarkStart.b("唬䈮崰崲䘴", num), BookmarkStart.b("䈬", num), null, this.dictionary_32[BookmarkStart.b("䈬", num)]);
            this.class1092_0.method_6(BookmarkStart.b("唬䈮崰崲䘴", num), BookmarkStart.b("弬", num), null, this.dictionary_32[BookmarkStart.b("弬", num)]);
            this.class1092_0.method_6(BookmarkStart.b("唬䈮崰崲䘴", num), BookmarkStart.b("䀬", num), null, this.dictionary_32[BookmarkStart.b("䀬", num)]);
            this.class1092_0.method_6(BookmarkStart.b("唬䈮崰崲䘴", num), BookmarkStart.b("嬬", num), null, this.dictionary_32[BookmarkStart.b("嬬", num)]);
            this.class1092_0.method_6(BookmarkStart.b("唬䈮崰崲䘴", num), BookmarkStart.b("娬弮0ܲ", num), null, this.dictionary_32[BookmarkStart.b("娬弮0ܲ", num)]);
            this.class1092_0.method_6(BookmarkStart.b("唬䈮崰崲䘴", num), BookmarkStart.b("娬弮", num), null, this.dictionary_32[BookmarkStart.b("娬弮", num)]);
            this.class1092_0.method_6(BookmarkStart.b("唬䈮崰崲䘴", num), BookmarkStart.b("娬Ḯİ", num), null, this.dictionary_32[BookmarkStart.b("娬Ḯİ", num)]);
            this.class1092_0.method_6(BookmarkStart.b("唬䈮崰崲䘴", num), BookmarkStart.b("娬", num), null, this.dictionary_32[BookmarkStart.b("娬", num)]);
            this.class1092_0.method_6(BookmarkStart.b("唬䈮崰崲䘴", num), BookmarkStart.b("娬Ḯ԰", num), null, this.dictionary_32[BookmarkStart.b("娬Ḯ԰", num)]);
            this.class1092_0.method_6(BookmarkStart.b("唬䈮崰崲䘴", num), BookmarkStart.b("娬弮嘰", num), null, this.dictionary_32[BookmarkStart.b("娬弮嘰", num)]);
            this.class1092_0.method_6(BookmarkStart.b("唬䈮崰崲䘴", num), BookmarkStart.b("娬弮堰", num), null, this.dictionary_32[BookmarkStart.b("娬弮堰", num)]);
            this.class1092_0.method_6(BookmarkStart.b("唬䈮崰崲䘴", num), BookmarkStart.b("娬䄮吰", num), null, this.dictionary_32[BookmarkStart.b("娬䄮吰", num)]);
            this.class1092_0.method_6(BookmarkStart.b("唬䈮崰崲䘴", num), BookmarkStart.b("娬弮䈰", num), null, this.dictionary_32[BookmarkStart.b("娬弮䈰", num)]);
            this.class1092_0.method_6(BookmarkStart.b("䀬䰮", num), BookmarkStart.b("搬䠮弰尲䜴嘶嬸场堼", num), null, BookmarkStart.b("娬Ḯ԰ጲ䈴䜶࠸༺", num));
            if (this.document_0.ListStyles.Count > 0)
            {
                this.method_438(this.document_0.ListStyles);
                this.method_433(this.document_0.ListStyles);
                this.method_432(this.document_0.ListStyles);
                this.method_429(this.document_0.ListOverrides);
            }
            this.class1092_0.method_12();
            this.class1092_0.method_15();
            this.class771_0.method_14(BookmarkStart.b("娬䀮䌰圲椴夶䰸嘺弼娾㍀⩂⭄⁆杈㍊⁌⍎", num), stream, false, FileAttributes.Archive);
        }
    }

    private void method_429(Class48 A_0)
    {
        int num = 11;
        if ((this.dictionary_0 != null) && (this.dictionary_0.Count != 0))
        {
            foreach (int num3 in this.dictionary_0.Keys)
            {
                Dictionary<int, string> dictionary = this.dictionary_0[num3];
                string str = string.Empty;
                foreach (int num2 in dictionary.Keys)
                {
                    str = dictionary[num2];
                    this.class1092_0.method_10(BookmarkStart.b("弰䘲場", num), this.dictionary_32[BookmarkStart.b("䘰", num)]);
                    this.class1092_0.method_5(BookmarkStart.b("弰䘲場縶崸", num), this.dictionary_32[BookmarkStart.b("䘰", num)], num2.ToString());
                    this.class1092_0.method_10(BookmarkStart.b("倰儲䘴䌶䬸娺帼䬾ཀ㙂⡄ๆⵈ", num), this.dictionary_32[BookmarkStart.b("䘰", num)]);
                    this.class1092_0.method_5(BookmarkStart.b("䜰刲头", num), this.dictionary_32[BookmarkStart.b("䘰", num)], num3.ToString());
                    this.class1092_0.method_12();
                    Class12 class2 = A_0.method_35(str);
                    if (class2 != null)
                    {
                        this.method_430(class2);
                    }
                    this.class1092_0.method_12();
                }
            }
        }
    }

    private Dictionary<int, Footnote> method_43()
    {
        if (this.dictionary_20 == null)
        {
            this.dictionary_20 = new Dictionary<int, Footnote>();
        }
        return this.dictionary_20;
    }

    private void method_430(Class12 A_0)
    {
        foreach (KeyValuePair<int, int> pair in A_0.method_23().method_7())
        {
            this.method_431(pair.Key, A_0.method_23().method_5(pair.Key));
        }
    }

    private void method_431(int A_0, OverrideLevelFormat A_1)
    {
        int num = 0x11;
        this.class1092_0.method_10(BookmarkStart.b("嬶伸场爼䤾⑀ㅂ㝄⹆ⵈ⹊", 0x11), this.dictionary_32[BookmarkStart.b("䀶", 0x11)]);
        this.class1092_0.method_5(BookmarkStart.b("帶唸䴺儼", 0x11), this.dictionary_32[BookmarkStart.b("䀶", 0x11)], A_0.ToString());
        if (A_1.OverrideStartAtValue)
        {
            this.class1092_0.method_10(BookmarkStart.b("䐶䴸娺似䬾เ㕂⁄㕆㭈≊⥌⩎", num), this.dictionary_32[BookmarkStart.b("䀶", num)]);
            this.class1092_0.method_5(BookmarkStart.b("䄶堸场", num), this.dictionary_32[BookmarkStart.b("䀶", num)], A_1.StartAt.ToString());
            this.class1092_0.method_12();
        }
        if (A_1.OverrideFormatting)
        {
            this.method_434(A_1.OverrideListLevel, A_0);
        }
        this.class1092_0.method_12();
    }

    private void method_432(ListStyleCollection A_0)
    {
        int num = 0x13;
        for (int i = 0; i < A_0.Count; i++)
        {
            this.class1092_0.method_10(BookmarkStart.b("圸为值", num), this.dictionary_32[BookmarkStart.b("丸", num)]);
            this.class1092_0.method_5(BookmarkStart.b("圸为值瘾╀", num), this.dictionary_32[BookmarkStart.b("丸", num)], (i + 1).ToString());
            this.class1092_0.method_10(BookmarkStart.b("堸夺丼䬾㍀≂♄㍆݈㹊⁌َ㕐", num), this.dictionary_32[BookmarkStart.b("丸", num)]);
            this.class1092_0.method_5(BookmarkStart.b("伸娺儼", num), this.dictionary_32[BookmarkStart.b("丸", num)], i.ToString());
            this.class1092_0.method_12();
            this.class1092_0.method_12();
        }
    }

    private void method_433(ListStyleCollection A_0)
    {
        int num = 0x13;
        int num2 = 0;
        foreach (ListStyle style in A_0)
        {
            this.class1092_0.method_10(BookmarkStart.b("堸夺丼䬾㍀≂♄㍆݈㹊⁌", num), this.dictionary_32[BookmarkStart.b("丸", num)]);
            this.class1092_0.method_5(BookmarkStart.b("堸夺丼䬾㍀≂♄㍆݈㹊⁌َ㕐", num), this.dictionary_32[BookmarkStart.b("丸", num)], num2.ToString());
            if (style.IsHybrid)
            {
                this.class1092_0.method_10(BookmarkStart.b("吸为儼䬾⡀ག⁄ㅆⱈ❊᥌㙎⅐㙒", num), this.dictionary_32[BookmarkStart.b("丸", num)]);
                this.class1092_0.method_5(BookmarkStart.b("伸娺儼", num), this.dictionary_32[BookmarkStart.b("丸", num)], BookmarkStart.b("儸䈺弼䴾⡀❂ࡄ㉆╈㽊⑌⍎㑐╒ご㭖", num));
                this.class1092_0.method_12();
            }
            else if (style.IsSimple && (style.Levels.Count == 1))
            {
                this.class1092_0.method_10(BookmarkStart.b("吸为儼䬾⡀ག⁄ㅆⱈ❊᥌㙎⅐㙒", num), this.dictionary_32[BookmarkStart.b("丸", num)]);
                this.class1092_0.method_5(BookmarkStart.b("伸娺儼", num), this.dictionary_32[BookmarkStart.b("丸", num)], BookmarkStart.b("䨸刺匼堾ⵀ♂ॄ≆㽈⹊⅌", num));
                this.class1092_0.method_12();
            }
            else if (!style.IsSimple && (style.Levels.Count > 1))
            {
                this.class1092_0.method_10(BookmarkStart.b("吸为儼䬾⡀ག⁄ㅆⱈ❊᥌㙎⅐㙒", num), this.dictionary_32[BookmarkStart.b("丸", num)]);
                this.class1092_0.method_5(BookmarkStart.b("伸娺儼", num), this.dictionary_32[BookmarkStart.b("丸", num)], BookmarkStart.b("吸为儼䬾⡀⽂⁄ㅆⱈ❊", num));
                this.class1092_0.method_12();
            }
            int num3 = 0;
            int count = style.Levels.Count;
            while (num3 < count)
            {
                this.method_434(style.Levels[num3], num3);
                num3++;
            }
            this.class1092_0.method_12();
            num2++;
        }
    }

    private void method_434(ListLevel A_0, int A_1)
    {
        int num = 15;
        this.class1092_0.method_10(BookmarkStart.b("头䄶唸", 15), this.dictionary_32[BookmarkStart.b("䈴", 15)]);
        this.class1092_0.method_5(BookmarkStart.b("尴嬶伸场", 15), this.dictionary_32[BookmarkStart.b("䈴", 15)], A_1.ToString());
        this.class1092_0.method_10(BookmarkStart.b("䘴䌶堸䤺䤼", 15), this.dictionary_32[BookmarkStart.b("䈴", 15)]);
        this.class1092_0.method_5(BookmarkStart.b("䌴嘶唸", 15), this.dictionary_32[BookmarkStart.b("䈴", 15)], A_0.StartAt.ToString());
        this.class1092_0.method_12();
        if (A_0.PatternType == ListPatternType.CustomType)
        {
            this.class1092_0.method_10(BookmarkStart.b("琴嬶䴸帺似儾⁀㝂⁄ц♈╊㥌⩎㽐❒", num), this.dictionary_32[BookmarkStart.b("場吶", num)]);
            this.class1092_0.method_10(BookmarkStart.b("瘴弶嘸刺帼娾", num), this.dictionary_32[BookmarkStart.b("場吶", num)]);
            this.class1092_0.method_4(BookmarkStart.b("朴制䠸为吼䴾⑀あ", num), BookmarkStart.b("䈴ضസ", num));
            this.class1092_0.method_10(BookmarkStart.b("嬴䈶吸紺值䬾", num), this.dictionary_32[BookmarkStart.b("䈴", num)]);
            this.class1092_0.method_5(BookmarkStart.b("䌴嘶唸", num), this.dictionary_32[BookmarkStart.b("䈴", num)], BookmarkStart.b("嘴䈶䨸伺刼刾", num));
            if (A_0.CustomPattern.method_0() == ListPatternFormat.LeadingTwoZero)
            {
                this.class1092_0.method_5(BookmarkStart.b("匴堶䬸嘺尼䬾", num), this.dictionary_32[BookmarkStart.b("䈴", num)], BookmarkStart.b("Դܶ࠸᜺ᴼ༾煀煂楄杆祈筊繌捎煐絒答祖", num));
            }
            else if (A_0.CustomPattern.method_0() == ListPatternFormat.LeadingThreedZero)
            {
                this.class1092_0.method_5(BookmarkStart.b("匴堶䬸嘺尼䬾", num), this.dictionary_32[BookmarkStart.b("䈴", num)], BookmarkStart.b("Դܶस਺ᄼἾ煀獂畄畆效歊経罎慐恒祔睖睘畚獜", num));
            }
            else if (A_0.CustomPattern.method_0() == ListPatternFormat.LeadingFourZero)
            {
                this.class1092_0.method_5(BookmarkStart.b("匴堶䬸嘺尼䬾", num), this.dictionary_32[BookmarkStart.b("䈴", num)], BookmarkStart.b("Դܶस଺఼ጾ慀獂畄睆祈祊慌潎慐捒敔杖橘睚絜煞你䵢", num));
            }
            this.class1092_0.method_12();
            this.class1092_0.method_12();
            this.class1092_0.method_10(BookmarkStart.b("猴嘶唸场弼帾≀⡂", num), this.dictionary_32[BookmarkStart.b("場吶", num)]);
            this.class1092_0.method_10(BookmarkStart.b("嬴䈶吸紺值䬾", num), this.dictionary_32[BookmarkStart.b("䈴", num)]);
            this.class1092_0.method_5(BookmarkStart.b("䌴嘶唸", num), this.dictionary_32[BookmarkStart.b("䈴", num)], this.method_538(A_0.CustomPattern.method_2()));
            this.class1092_0.method_12();
            this.class1092_0.method_12();
            this.class1092_0.method_12();
        }
        else
        {
            this.class1092_0.method_10(BookmarkStart.b("嬴䈶吸紺值䬾", num), this.dictionary_32[BookmarkStart.b("䈴", num)]);
            this.class1092_0.method_5(BookmarkStart.b("䌴嘶唸", num), this.dictionary_32[BookmarkStart.b("䈴", num)], this.method_538(A_0.PatternType));
            this.class1092_0.method_12();
        }
        if (A_0.NoRestartByHigher)
        {
            this.class1092_0.method_10(BookmarkStart.b("头䄶唸椺堼䰾㕀≂㝄㍆", num), this.dictionary_32[BookmarkStart.b("䈴", num)]);
            this.class1092_0.method_5(BookmarkStart.b("䌴嘶唸", num), this.dictionary_32[BookmarkStart.b("䈴", num)], BookmarkStart.b("Դ", num));
            this.class1092_0.method_12();
        }
        if (!string.IsNullOrEmpty(A_0.ParaStyleName))
        {
            this.class1092_0.method_10(BookmarkStart.b("䔴搶䴸䈺儼娾", num), this.dictionary_32[BookmarkStart.b("䈴", num)]);
            this.class1092_0.method_5(BookmarkStart.b("䌴嘶唸", num), this.dictionary_32[BookmarkStart.b("䈴", num)], A_0.ParaStyleName);
            this.class1092_0.method_12();
        }
        if (A_0.IsLegalStyleNumbering)
        {
            this.class1092_0.method_10(BookmarkStart.b("尴䐶甸尺儼", num), this.dictionary_32[BookmarkStart.b("䈴", num)]);
            this.class1092_0.method_12();
        }
        this.method_436(A_0);
        this.method_437(A_0, A_1 + 1);
        this.method_435(A_0);
        if (A_0.PicBulletId > 0)
        {
            this.class1092_0.method_10(BookmarkStart.b("头䄶唸欺吼尾̀㙂⥄⭆ⱈ㽊ь⭎", num), this.dictionary_32[BookmarkStart.b("䈴", num)]);
            this.class1092_0.method_5(BookmarkStart.b("䌴嘶唸", num), this.dictionary_32[BookmarkStart.b("䈴", num)], A_0.PicBulletId.ToString());
            this.class1092_0.method_12();
        }
        if (A_0.NumberAlignment != ListNumberAlignment.Left)
        {
            this.class1092_0.method_10(BookmarkStart.b("头䄶唸焺帼", num), this.dictionary_32[BookmarkStart.b("䈴", num)]);
            string str = string.Empty;
            if (A_0.NumberAlignment == ListNumberAlignment.Right)
            {
                str = BookmarkStart.b("䜴帶常区䤼", num);
            }
            else
            {
                str = BookmarkStart.b("嘴制圸伺堼䴾", num);
            }
            this.class1092_0.method_5(BookmarkStart.b("䌴嘶唸", num), this.dictionary_32[BookmarkStart.b("䈴", num)], str);
            this.class1092_0.method_12();
        }
        this.class1092_0.method_10(BookmarkStart.b("䔴朶䬸", num), this.dictionary_32[BookmarkStart.b("䈴", num)]);
        this.method_472(A_0.ParagraphFormat, null);
        this.class1092_0.method_12();
        this.method_463(A_0.CharacterFormat);
        this.class1092_0.method_12();
    }

    private void method_435(ListLevel A_0)
    {
        int num = 13;
        if (A_0.Word6Legacy)
        {
            this.class1092_0.method_10(BookmarkStart.b("弲倴倶堸堺䐼", num), this.dictionary_32[BookmarkStart.b("䐲", num)]);
            this.class1092_0.method_5(BookmarkStart.b("弲倴倶堸堺䐼", num), this.dictionary_32[BookmarkStart.b("䐲", num)], BookmarkStart.b("Ȳ", num));
            this.class1092_0.method_5(BookmarkStart.b("弲倴倶堸堺䐼氾ㅀ≂♄≆", num), this.dictionary_32[BookmarkStart.b("䐲", num)], A_0.LegacySpace.ToString());
            this.class1092_0.method_5(BookmarkStart.b("弲倴倶堸堺䐼瘾⽀❂⁄⥆㵈", num), this.dictionary_32[BookmarkStart.b("䐲", num)], A_0.LegacyIndent.ToString());
            this.class1092_0.method_12();
        }
    }

    private void method_436(ListLevel A_0)
    {
        int num = 15;
        string str = string.Empty;
        if (A_0.FollowCharacter == FollowCharacterType.Space)
        {
            str = BookmarkStart.b("䘴䜶堸堺堼", num);
        }
        else if (A_0.FollowCharacter == FollowCharacterType.Tab)
        {
            str = BookmarkStart.b("䄴嘶嬸", num);
        }
        else
        {
            str = BookmarkStart.b("嬴堶䴸区吼儾♀", num);
        }
        this.class1092_0.method_10(BookmarkStart.b("䘴䈶弸崺", num), this.dictionary_32[BookmarkStart.b("䈴", num)]);
        this.class1092_0.method_5(BookmarkStart.b("䌴嘶唸", num), this.dictionary_32[BookmarkStart.b("䈴", num)], str);
        this.class1092_0.method_12();
    }

    private void method_437(ListLevel A_0, int A_1)
    {
        int num = 6;
        this.class1092_0.method_10(BookmarkStart.b("䀫堭尯昱儳丵䰷", 6), this.dictionary_32[BookmarkStart.b("嬫", 6)]);
        if (A_0.PatternType == ListPatternType.Bullet)
        {
            this.class1092_0.method_5(BookmarkStart.b("娫伭尯", num), this.dictionary_32[BookmarkStart.b("嬫", num)], A_0.BulletCharacter);
        }
        else
        {
            string str2 = string.Empty;
            if ((A_0.NumberPrefix != null) && (A_0.NumberPrefix.Length > 0))
            {
                str2 = this.method_541(A_0.NumberPrefix);
            }
            string levelText = str2;
            if (!A_0.NoLevelText && (A_0.NumberSufix != null))
            {
                char ch = this.method_539(A_0.LevelNumber);
                A_0.NumberSufix = A_0.NumberSufix.Replace(ch.ToString(), string.Empty);
                char[] trimChars = new char[1];
                levelText = levelText + BookmarkStart.b("फ", num) + A_1.ToString() + A_0.NumberSufix.Trim(trimChars);
            }
            else if (A_0.PatternType == ListPatternType.None)
            {
                levelText = A_0.LevelText;
            }
            this.class1092_0.method_5(BookmarkStart.b("娫伭尯", num), this.dictionary_32[BookmarkStart.b("嬫", num)], levelText);
        }
        this.class1092_0.method_12();
    }

    private void method_438(ListStyleCollection A_0)
    {
        foreach (ListStyle style in A_0)
        {
            int num = 0;
            int count = style.Levels.Count;
            while (num < count)
            {
                ListLevel level = style.Levels[num];
                if ((level.PicBullet != null) && (level.PicBullet.ImageBytes != null))
                {
                    this.method_439(level);
                }
                num++;
            }
        }
    }

    private void method_439(ListLevel A_0)
    {
        int num = 3;
        DocPicture picBullet = A_0.PicBullet;
        string str = this.method_336(this.method_25(), picBullet.ImageRecord);
        this.bool_0 = true;
        int num2 = this.method_528();
        A_0.PicBulletId = (short) num2;
        StringBuilder builder = new StringBuilder(BookmarkStart.b("帨䈪䤬嬮夰ल", 3));
        builder.Append(picBullet.Width.ToString());
        builder.Append(BookmarkStart.b("夨弪ᘬ䜮吰娲刴弶䴸ĺ", 3));
        builder.Append(picBullet.Height.ToString());
        builder.Append(BookmarkStart.b("夨弪", 3));
        builder.Replace(BookmarkStart.b("Ԩ", 3), BookmarkStart.b("ܨ", 3));
        this.class1092_0.method_10(BookmarkStart.b("䜨帪䀬缮堰倲眴䈶唸场堼䬾", 3), this.dictionary_32[BookmarkStart.b("帨", 3)]);
        this.class1092_0.method_5(BookmarkStart.b("䜨帪䀬缮堰倲眴䈶唸场堼䬾ࡀ❂", 3), this.dictionary_32[BookmarkStart.b("帨", 3)], num2.ToString());
        this.class1092_0.method_10(BookmarkStart.b("夨䈪丬嬮", 3), this.dictionary_32[BookmarkStart.b("帨", 3)]);
        this.class1092_0.method_10(BookmarkStart.b("娨䌪䰬弮吰", 3), this.dictionary_32[BookmarkStart.b("弨", 3)]);
        this.class1092_0.method_4(BookmarkStart.b("崨刪崬䨮", 3), BookmarkStart.b("ਨ琪唬Ἦİ̲Դ栶䴸఺࠼", 3));
        this.class1092_0.method_4(BookmarkStart.b("娨弪听䌮吰", 3), builder.ToString());
        this.class1092_0.method_5(BookmarkStart.b("䬨帪䄬䌮吰䜲", 3), this.dictionary_32[BookmarkStart.b("䘨", 3)], BookmarkStart.b("崨", 3));
        if (!A_0.IsEmptyPicture)
        {
            this.class1092_0.method_10(BookmarkStart.b("䀨䘪䰬䠮吰圲吴䌶堸", num), this.dictionary_32[BookmarkStart.b("弨", num)]);
            this.class1092_0.method_5(BookmarkStart.b("䀨伪", num), this.dictionary_32[BookmarkStart.b("嬨", num)], str);
            this.class1092_0.method_5(BookmarkStart.b("崨䈪夬䌮吰", num), this.dictionary_32[BookmarkStart.b("䘨", num)], string.Empty);
            this.class1092_0.method_12();
        }
        this.class1092_0.method_12();
        this.class1092_0.method_12();
        this.class1092_0.method_12();
    }

    private Dictionary<int, Footnote> method_44()
    {
        if (this.dictionary_21 == null)
        {
            this.dictionary_21 = new Dictionary<int, Footnote>();
        }
        return this.dictionary_21;
    }

    private void method_440()
    {
        int num = 14;
        if (this.document_0.Themes != null)
        {
            this.dictionary_32 = this.document_0.DocxNameSpace.method_0()[BookmarkStart.b("䀳帵崷圹夻", num)];
            MemoryStream stream = new MemoryStream();
            this.class1092_0 = this.method_524(stream);
            this.method_35(true);
            this.class1092_0.method_11(BookmarkStart.b("唳", num), BookmarkStart.b("䀳帵崷圹夻", num), this.dictionary_32[BookmarkStart.b("唳", num)]);
            this.class1092_0.method_6(BookmarkStart.b("䰳嬵吷吹伻", num), BookmarkStart.b("唳", num), null, this.dictionary_32[BookmarkStart.b("唳", num)]);
            this.class1092_0.method_4(BookmarkStart.b("娳圵唷弹", num), BookmarkStart.b("笳倵帷匹弻嬽怿ᙁⱃ⍅╇⽉", num));
            this.class1092_0.method_11(BookmarkStart.b("唳", num), BookmarkStart.b("䀳帵崷圹夻笽ⰿ❁⥃⍅♇㹉㽋", num), this.dictionary_32[BookmarkStart.b("唳", num)]);
            this.class1092_0.method_11(BookmarkStart.b("唳", num), BookmarkStart.b("圳娵䨷椹弻嘽┿⽁⅃", num), this.dictionary_32[BookmarkStart.b("唳", num)]);
            this.class1092_0.method_4(BookmarkStart.b("娳圵唷弹", num), BookmarkStart.b("笳倵帷匹弻嬽", num));
            if (this.document_0.Themes.method_0().Count > 0)
            {
                this.method_441();
            }
            this.class1092_0.method_12();
            this.class1092_0.method_11(BookmarkStart.b("唳", num), BookmarkStart.b("刳夵嘷丹漻崽⠿❁⥃⍅", num), this.dictionary_32[BookmarkStart.b("唳", num)]);
            this.class1092_0.method_4(BookmarkStart.b("娳圵唷弹", num), BookmarkStart.b("笳倵帷匹弻嬽", num));
            if (this.document_0.Themes.method_2().Count > 0)
            {
                this.method_442(true);
            }
            if (this.document_0.Themes.method_1().Count > 0)
            {
                this.method_442(false);
            }
            this.class1092_0.method_12();
            if ((this.document_0.Themes.method_3().Count > 0) && this.document_0.Themes.method_3().ContainsKey(BookmarkStart.b("刳嬵䰷椹弻嘽┿⽁⅃", num)))
            {
                Stream stream2 = this.document_0.Themes.method_3()[BookmarkStart.b("刳嬵䰷椹弻嘽┿⽁⅃", num)];
                this.method_272(stream2);
            }
            this.class1092_0.method_12();
            this.class1092_0.method_11(BookmarkStart.b("唳", num), BookmarkStart.b("嬳吵刷弹弻䨽п❁≃❅㵇♉㡋㵍", num), this.dictionary_32[BookmarkStart.b("唳", num)]);
            this.class1092_0.method_12();
            this.class1092_0.method_11(BookmarkStart.b("唳", num), BookmarkStart.b("儳丵䰷䠹崻紽ⰿぁᝃ╅⁇⽉⅋⭍ᱏ⅑⁓", num), this.dictionary_32[BookmarkStart.b("唳", num)]);
            this.class1092_0.method_12();
            this.class1092_0.method_12();
            this.class1092_0.method_15();
            this.class771_0.method_14(BookmarkStart.b("䌳夵䨷帹总䨽⠿❁⥃⍅ᑇ㹉⑋⭍㵏㝑敓硕⁗㝙せ", num), stream, false, FileAttributes.Archive);
        }
    }

    private void method_441()
    {
        int num = 13;
        foreach (KeyValuePair<string, Class326> pair in this.document_0.Themes.method_0())
        {
            switch (pair.Value.method_8())
            {
                case ThemeColorTypes.sysClr:
                    this.class1092_0.method_11(BookmarkStart.b("刲", num), pair.Value.method_6(), this.dictionary_32[BookmarkStart.b("刲", num)]);
                    this.class1092_0.method_11(BookmarkStart.b("刲", num), BookmarkStart.b("䀲䰴䐶稸场似", num), this.dictionary_32[BookmarkStart.b("刲", num)]);
                    this.class1092_0.method_4(BookmarkStart.b("䔲吴嬶", num), pair.Value.method_2());
                    this.class1092_0.method_4(BookmarkStart.b("弲吴䐶䴸砺儼䴾", num), pair.Value.method_4());
                    this.class1092_0.method_12();
                    this.class1092_0.method_12();
                    break;

                case ThemeColorTypes.srgbClr:
                    this.class1092_0.method_11(BookmarkStart.b("刲", num), pair.Value.method_6(), this.dictionary_32[BookmarkStart.b("刲", num)]);
                    this.class1092_0.method_11(BookmarkStart.b("刲", num), BookmarkStart.b("䀲䜴倶嬸砺儼䴾", num), this.dictionary_32[BookmarkStart.b("刲", num)]);
                    this.class1092_0.method_4(BookmarkStart.b("䔲吴嬶", num), pair.Value.method_4());
                    this.class1092_0.method_12();
                    this.class1092_0.method_12();
                    break;
            }
        }
    }

    private void method_442(bool A_0)
    {
        int num = 7;
        string str2 = A_0 ? BookmarkStart.b("䀬丮嬰尲䜴然嘸唺䤼", num) : BookmarkStart.b("䀬䘮弰尲䜴然嘸唺䤼", num);
        this.class1092_0.method_11(BookmarkStart.b("䰬", num), str2, this.dictionary_32[BookmarkStart.b("䰬", num)]);
        Dictionary<string, Class325> dictionary = A_0 ? this.document_0.Themes.method_2() : this.document_0.Themes.method_1();
        foreach (KeyValuePair<string, Class325> pair in dictionary)
        {
            string str;
            if (((str = pair.Value.method_0()) != null) && (((str == BookmarkStart.b("䄬丮䔰娲嬴", num)) || (str == BookmarkStart.b("䠬丮", num))) || (str == BookmarkStart.b("丬尮", num))))
            {
                this.class1092_0.method_11(BookmarkStart.b("䰬", num), pair.Value.method_0(), this.dictionary_32[BookmarkStart.b("䰬", num)]);
                this.class1092_0.method_4(BookmarkStart.b("夬嘮䄰嘲匴嘶娸帺", num), pair.Value.method_6());
                this.class1092_0.method_12();
            }
            else
            {
                this.class1092_0.method_11(BookmarkStart.b("䰬", num), BookmarkStart.b("䬬䀮弰䜲", num), this.dictionary_32[BookmarkStart.b("䰬", num)]);
                this.class1092_0.method_4(BookmarkStart.b("帬䰮䌰娲䔴䌶", num), pair.Value.method_4());
                this.class1092_0.method_4(BookmarkStart.b("夬嘮䄰嘲匴嘶娸帺", num), pair.Value.method_6());
                this.class1092_0.method_12();
            }
        }
        this.class1092_0.method_12();
    }

    private void method_443()
    {
        this.dictionary_32 = this.document_0.DocxNameSpace.method_0()[BookmarkStart.b("弫娭䤯帱儳䔵", 6)];
        MemoryStream stream = new MemoryStream();
        this.class1092_0 = this.method_524(stream);
        this.class1092_0.method_11(BookmarkStart.b("嬫", 6), BookmarkStart.b("弫娭䤯帱儳䔵", 6), this.dictionary_32[BookmarkStart.b("嬫", 6)]);
        this.class1092_0.method_6(BookmarkStart.b("含䌭尯就䜳", 6), BookmarkStart.b("䄫䴭", 6), null, this.dictionary_32[BookmarkStart.b("䄫䴭", 6)]);
        this.class1092_0.method_6(BookmarkStart.b("含䌭尯就䜳", 6), BookmarkStart.b("師", 6), null, this.dictionary_32[BookmarkStart.b("師", 6)]);
        this.class1092_0.method_6(BookmarkStart.b("含䌭尯就䜳", 6), BookmarkStart.b("嬫", 6), null, this.dictionary_32[BookmarkStart.b("嬫", 6)]);
        this.class1092_0.method_6(BookmarkStart.b("含䌭尯就䜳", 6), BookmarkStart.b("嬫ἭЯ", 6), null, this.dictionary_32[BookmarkStart.b("嬫ἭЯ", 6)]);
        this.class1092_0.method_6(BookmarkStart.b("䄫䴭", 6), BookmarkStart.b("攫䤭帯崱䘳圵娷嘹夻", 6), null, BookmarkStart.b("嬫ἭЯ", 6));
        this.method_455();
        this.method_444();
        this.class1092_0.method_12();
        this.class1092_0.method_15();
        this.class771_0.method_14(BookmarkStart.b("嬫䄭䈯嘱栳䔵䰷䌹倻嬽㌿汁㱃⭅⑇", 6), stream, false, FileAttributes.Archive);
    }

    private void method_444()
    {
        int num = 0;
        Dictionary<string, int> dictionary = new Dictionary<string, int>();
        foreach (Style style in this.document_0.Styles)
        {
            while (dictionary.ContainsKey(style.Name))
            {
                Dictionary<string, int> dictionary2;
                string str2;
                style.IsCustomStyle = true;
                string name = style.Name;
                style.method_7(style.Name + BookmarkStart.b("礥", num) + dictionary[style.Name].ToString());
                (dictionary2 = dictionary)[str2 = name] = dictionary2[str2] + 1;
            }
            this.method_445(style, this.document_0);
            dictionary.Add(style.Name, 0);
        }
        this.document_0.Styles.method_5();
    }

    private void method_445(Style A_0, Document A_1)
    {
        int num = 10;
        string name = A_0.Name;
        string str2 = string.Empty;
        string str3 = string.Empty;
        switch (A_0.TypeCode)
        {
            case WordStyleType.TableStyle:
                if (((name == BookmarkStart.b("搯匱嘳娵崷琹医䰽ⴿ⍁⡃", num)) || (name == BookmarkStart.b("搯匱嘳娵崷ᨹ爻儽㈿⽁╃⩅", num))) || ((name == BookmarkStart.b("縯崱䘳嬵夷嘹栻弽∿⹁⅃", num)) || (name == BookmarkStart.b("縯崱䘳嬵夷嘹᰻樽ℿ⁁⡃⍅", num))))
                {
                    return;
                }
                str3 = BookmarkStart.b("䐯匱嘳娵崷", num);
                break;

            case WordStyleType.ListStyle:
                str3 = BookmarkStart.b("帯䜱夳吵崷䠹唻倽✿", num);
                break;

            default:
                str3 = (A_0 is Class13) ? BookmarkStart.b("䐯匱嘳娵崷", num) : ((A_0 is ParagraphStyle) ? BookmarkStart.b("䀯匱䘳圵強䠹崻丽⠿", num) : BookmarkStart.b("匯娱唳䐵夷夹䠻嬽㈿", num));
                break;
        }
        this.class1092_0.method_11(BookmarkStart.b("䜯", num), BookmarkStart.b("䌯䘱䴳娵崷", num), this.dictionary_32[BookmarkStart.b("䜯", num)]);
        this.class1092_0.method_5(BookmarkStart.b("䐯䬱䐳匵", num), this.dictionary_32[BookmarkStart.b("䜯", num)], str3);
        string styleId = A_0.StyleId;
        Dictionary<string, string> styleNameIds = A_1.StyleNameIds;
        if (styleNameIds.ContainsValue(name))
        {
            using (Dictionary<string, string>.KeyCollection.Enumerator enumerator = styleNameIds.Keys.GetEnumerator())
            {
                string current;
                while (enumerator.MoveNext())
                {
                    current = enumerator.Current;
                    if (styleNameIds[current] == name)
                    {
                        goto Label_0185;
                    }
                }
                goto Label_0227;
            Label_0185:
                this.class1092_0.method_5(BookmarkStart.b("䌯䘱䴳娵崷猹堻", num), this.dictionary_32[BookmarkStart.b("䜯", num)], current);
                goto Label_0227;
            }
        }
        if (styleId == BookmarkStart.b("縯崱䘳嬵夷嘹᰻樽ℿ⁁⡃⍅", num))
        {
            styleId = BookmarkStart.b("搯匱嘳娵崷琹医䰽ⴿ⍁⡃", num);
        }
        this.class1092_0.method_5(BookmarkStart.b("䌯䘱䴳娵崷猹堻", num), this.dictionary_32[BookmarkStart.b("䜯", num)], styleId.Replace(BookmarkStart.b("ု", num), string.Empty));
    Label_0227:
        if (A_0.IsCustomStyle)
        {
            this.class1092_0.method_5(BookmarkStart.b("匯䜱䜳䈵圷圹漻䨽㤿⹁⅃", num), this.dictionary_32[BookmarkStart.b("䜯", num)], BookmarkStart.b("į", num));
        }
        else if (this.method_517(A_0))
        {
            this.class1092_0.method_5(BookmarkStart.b("启圱刳圵䴷嘹䠻", num), this.dictionary_32[BookmarkStart.b("䜯", num)], BookmarkStart.b("į", num));
        }
        this.class1092_0.method_10(BookmarkStart.b("帯匱夳匵", num), this.dictionary_32[BookmarkStart.b("䜯", num)]);
        this.class1092_0.method_5(BookmarkStart.b("䘯匱堳", num), this.dictionary_32[BookmarkStart.b("䜯", num)], name);
        this.class1092_0.method_12();
        if (A_0.BaseStyle == null)
        {
            goto Label_0441;
        }
        str2 = A_0.BaseStyle.Name;
        this.class1092_0.method_10(BookmarkStart.b("刯匱䜳匵尷甹刻", num), this.dictionary_32[BookmarkStart.b("䜯", num)]);
        Dictionary<string, string> dictionary2 = A_1.StyleNameIds;
        if (styleNameIds.ContainsValue(str2))
        {
            using (Dictionary<string, string>.KeyCollection.Enumerator enumerator2 = dictionary2.Keys.GetEnumerator())
            {
                string str5;
                while (enumerator2.MoveNext())
                {
                    str5 = enumerator2.Current;
                    if (styleNameIds[str5] == str2)
                    {
                        goto Label_0397;
                    }
                }
                goto Label_0436;
            Label_0397:
                this.class1092_0.method_5(BookmarkStart.b("䘯匱堳", num), this.dictionary_32[BookmarkStart.b("䜯", num)], str5);
                goto Label_0436;
            }
        }
        if (str2 == BookmarkStart.b("縯崱䘳嬵夷嘹᰻樽ℿ⁁⡃⍅", num))
        {
            str2 = BookmarkStart.b("搯匱嘳娵崷琹医䰽ⴿ⍁⡃", num);
        }
        this.class1092_0.method_5(BookmarkStart.b("䘯匱堳", num), this.dictionary_32[BookmarkStart.b("䜯", num)], str2.Replace(BookmarkStart.b("ု", num), string.Empty));
    Label_0436:
        this.class1092_0.method_12();
    Label_0441:
        if (A_0.AutomaticallyUpdate)
        {
            this.class1092_0.method_10(BookmarkStart.b("儯䜱䀳夵樷弹堻嬽☿⭁⩃⍅", num), this.dictionary_32[BookmarkStart.b("䜯", num)]);
            this.class1092_0.method_12();
        }
        if (!string.IsNullOrEmpty(A_0.LinkStyle))
        {
            this.class1092_0.method_10(BookmarkStart.b("尯嬱娳崵", num), this.dictionary_32[BookmarkStart.b("䜯", num)]);
            this.class1092_0.method_5(BookmarkStart.b("䘯匱堳", num), this.dictionary_32[BookmarkStart.b("䜯", num)], A_0.LinkStyle.Replace(BookmarkStart.b("ု", num), string.Empty));
            this.class1092_0.method_12();
        }
        if (!string.IsNullOrEmpty(A_0.NextStyle))
        {
            string str7 = A_0.NextStyle.Replace(BookmarkStart.b("ု", num), string.Empty);
            this.class1092_0.method_10(BookmarkStart.b("帯圱䰳䈵", num), this.dictionary_32[BookmarkStart.b("䜯", num)]);
            this.class1092_0.method_5(BookmarkStart.b("䘯匱堳", num), this.dictionary_32[BookmarkStart.b("䜯", num)], str7);
            this.class1092_0.method_12();
        }
        if (A_0.IsSemiHidden)
        {
            this.class1092_0.method_10(BookmarkStart.b("䌯圱夳張瀷匹堻娽┿ⱁ", num), this.dictionary_32[BookmarkStart.b("䜯", num)]);
            this.class1092_0.method_12();
        }
        if (A_0.UnhideWhenUsed)
        {
            this.class1092_0.method_10(BookmarkStart.b("䔯就尳張尷弹欻嘽┿ⱁᅃ㕅ⵇ⹉", num), this.dictionary_32[BookmarkStart.b("䜯", num)]);
            this.class1092_0.method_12();
        }
        if (A_0.IsPrimaryStyle)
        {
            this.class1092_0.method_10(BookmarkStart.b("䄯琱嬳䐵唷嬹䠻", num), this.dictionary_32[BookmarkStart.b("䜯", num)]);
            this.class1092_0.method_12();
        }
        if (A_0 is ParagraphStyle)
        {
            ParagraphStyle style = A_0 as ParagraphStyle;
            this.class1092_0.method_10(BookmarkStart.b("䀯戱䘳", num), this.dictionary_32[BookmarkStart.b("䜯", num)]);
            if (style.ListIndex >= 0)
            {
                this.method_522(style.ListIndex, style.ListLevel);
            }
            else if ((style.ListFormat.CurrentListStyle == null) && !style.ListFormat.IsEmptyList)
            {
                if ((style.ListFormat.ListLevelNumber > 0) || (!style.ListFormat.IsDefault && style.ListFormat.HasKey(0)))
                {
                    this.method_522(-1, style.ListFormat.ListLevelNumber);
                }
            }
            else
            {
                int num2 = 0;
                int listLevelNumber = -1;
                if (!style.ListFormat.IsEmptyList)
                {
                    num2 = this.method_520(style.ListFormat);
                    OutlineLevel outlineLevel = style.ParagraphFormat.OutlineLevel;
                    if (style.ListFormat.HasKey(0))
                    {
                        listLevelNumber = style.ListFormat.ListLevelNumber;
                    }
                }
                this.method_522(num2, listLevelNumber);
            }
            this.method_472(style.ParagraphFormat, null);
            this.class1092_0.method_12();
            this.method_463(A_0.CharacterFormat);
        }
        else if (A_0 is Class13)
        {
            this.method_446(A_0 as Class13);
        }
        else
        {
            this.method_463(A_0.CharacterFormat);
        }
        this.class1092_0.method_12();
    }

    private void method_446(Class13 A_0)
    {
        int num = 15;
        if (!A_0.imethod_0().IsDefault)
        {
            this.class1092_0.method_10(BookmarkStart.b("䔴朶䬸", num), this.dictionary_32[BookmarkStart.b("䈴", num)]);
            if ((A_0.method_23().CurrentListStyle == null) && !A_0.method_23().IsEmptyList)
            {
                if (A_0.method_23().ListLevelNumber > 0)
                {
                    this.method_522(-1, A_0.method_23().ListLevelNumber);
                }
            }
            else
            {
                int num2 = 0;
                int listLevelNumber = -1;
                if (!A_0.method_23().IsEmptyList)
                {
                    num2 = this.method_520(A_0.method_23());
                    listLevelNumber = A_0.method_23().ListLevelNumber;
                }
                this.method_522(num2, listLevelNumber);
            }
            this.method_472(A_0.imethod_0(), null);
            this.class1092_0.method_12();
        }
        if (!A_0.CharacterFormat.IsDefault)
        {
            this.method_463(A_0.CharacterFormat);
        }
        if (!A_0.Interface8.imethod_3().IsDefault)
        {
            this.method_451(A_0.Interface8.imethod_3());
        }
        if (!A_0.Interface8.imethod_2().IsDefault)
        {
            this.method_450(A_0.Interface8.imethod_2());
        }
        if (!A_0.Interface8.imethod_1().IsDefault)
        {
            this.method_449(A_0.Interface8.imethod_1());
        }
        foreach (KeyValuePair<ConditionalFormattingCode, Class10> pair in A_0.method_25())
        {
            this.method_447(pair.Key, pair.Value);
        }
    }

    private void method_447(ConditionalFormattingCode A_0, Class10 A_1)
    {
        int num = 0;
        this.class1092_0.method_11(BookmarkStart.b("儥", 0), BookmarkStart.b("別䨧䘩缫娭䤯帱儳昵䨷", 0), this.dictionary_32[BookmarkStart.b("儥", 0)]);
        this.class1092_0.method_5(BookmarkStart.b("別儧娩䤫", 0), this.dictionary_32[BookmarkStart.b("儥", 0)], this.method_448(A_0));
        if (!A_1.method_23().IsDefault)
        {
            this.class1092_0.method_10(BookmarkStart.b("嘥砧堩", num), this.dictionary_32[BookmarkStart.b("儥", num)]);
            this.method_472(A_1.method_23(), null);
            this.class1092_0.method_12();
        }
        if (!A_1.CharacterFormat.IsDefault)
        {
            this.method_463(A_1.CharacterFormat);
        }
        if (!A_1.method_26().IsDefault)
        {
            this.method_451(A_1.method_26());
        }
        if (!A_1.method_25().IsDefault)
        {
            this.method_450(A_1.method_25());
        }
        if (!A_1.method_24().IsDefault)
        {
            this.method_449(A_1.method_24());
        }
        this.class1092_0.method_12();
    }

    private string method_448(ConditionalFormattingCode A_0)
    {
        int num = 4;
        switch (A_0)
        {
            case ConditionalFormattingCode.OddRowBanding:
                return BookmarkStart.b("䠩䴫䀭启̱簳夵䨷䀹", num);

            case ConditionalFormattingCode.OddColumnBanding:
                return BookmarkStart.b("䠩䴫䀭启̱戳匵䨷丹", num);

            case ConditionalFormattingCode.EvenRowBanding:
                return BookmarkStart.b("䠩䴫䀭启1簳夵䨷䀹", num);

            case ConditionalFormattingCode.EvenColumnBanding:
                return BookmarkStart.b("䠩䴫䀭启1戳匵䨷丹", num);

            case ConditionalFormattingCode.FirstColumn:
                return BookmarkStart.b("䰩䔫尭䌯䘱眳夵吷", num);

            case ConditionalFormattingCode.FirstRow:
                return BookmarkStart.b("䰩䔫尭䌯䘱昳夵伷", num);

            case ConditionalFormattingCode.LastColumn:
                return BookmarkStart.b("䘩䴫崭䐯焱嬳娵", num);

            case ConditionalFormattingCode.LastRow:
                return BookmarkStart.b("䘩䴫崭䐯怱嬳䄵", num);

            case ConditionalFormattingCode.FirstRowLastCell:
                return BookmarkStart.b("䐩䤫洭唯帱堳", num);

            case ConditionalFormattingCode.FirstRowFirstCell:
                return BookmarkStart.b("䐩嬫洭唯帱堳", num);

            case ConditionalFormattingCode.LastRowLastCell:
                return BookmarkStart.b("天䤫洭唯帱堳", num);

            case ConditionalFormattingCode.LastRowFirstCell:
                return BookmarkStart.b("天嬫洭唯帱堳", num);
        }
        return "";
    }

    private void method_449(Form3 A_0)
    {
        int num = 11;
        this.class1092_0.method_10(BookmarkStart.b("䔰倲攴䔶", 11), this.dictionary_32[BookmarkStart.b("䘰", 11)]);
        if (!A_0.method_66().IsDefault && A_0.HasValue(1))
        {
            this.class1092_0.method_10(BookmarkStart.b("䔰倲眴堶䬸强堼䴾㉀", num), this.dictionary_32[BookmarkStart.b("䘰", num)]);
            this.method_395(A_0.method_66(), 8);
            this.class1092_0.method_12();
        }
        this.method_452(A_0);
        if (!A_0.method_70())
        {
            this.class1092_0.method_10(BookmarkStart.b("弰尲戴䔶堸䬺", num), this.dictionary_32[BookmarkStart.b("䘰", num)]);
            this.class1092_0.method_12();
        }
        if (!A_0.method_67().IsDefault && A_0.HasValue(2))
        {
            this.class1092_0.method_10(BookmarkStart.b("䔰倲破嘶䬸", num), this.dictionary_32[BookmarkStart.b("䘰", num)]);
            this.method_165(A_0.method_67());
            this.class1092_0.method_12();
        }
        this.method_147(A_0.method_68());
        this.class1092_0.method_12();
    }

    internal Dictionary<string, Dictionary<string, Class517>> method_45()
    {
        if (this.dictionary_7 == null)
        {
            this.dictionary_7 = new Dictionary<string, Dictionary<string, Class517>>();
        }
        return this.dictionary_7;
    }

    private void method_450(Form1 A_0)
    {
        int num = 13;
        this.class1092_0.method_10(BookmarkStart.b("䜲䜴朶䬸", 13), this.dictionary_32[BookmarkStart.b("䐲", 13)]);
        if (A_0.method_65())
        {
            this.class1092_0.method_10(BookmarkStart.b("嬲尴匶崸帺匼", num), this.dictionary_32[BookmarkStart.b("䐲", num)]);
            this.class1092_0.method_12();
        }
        if (A_0.method_67())
        {
            this.class1092_0.method_10(BookmarkStart.b("䜲圴嬶焸帺尼嬾⑀ㅂ", num), this.dictionary_32[BookmarkStart.b("䐲", num)]);
            this.class1092_0.method_12();
        }
        if (!A_0.method_69())
        {
            this.class1092_0.method_10(BookmarkStart.b("倲吴夶䴸栺䴼匾⡀㝂", num), this.dictionary_32[BookmarkStart.b("䐲", num)]);
            this.class1092_0.method_12();
        }
        if (A_0.HasValue(0x10c2))
        {
            this.class1092_0.method_10(BookmarkStart.b("䜲圴嬶稸帺儼匾ቀ㍂⑄⑆⁈╊⩌", num), this.dictionary_32[BookmarkStart.b("䐲", num)]);
            this.class1092_0.method_5(BookmarkStart.b("䐲", num), this.dictionary_32[BookmarkStart.b("䐲", num)], this.method_534(A_0.method_71() * 20f));
            this.class1092_0.method_5(BookmarkStart.b("䜲䰴䜶尸", num), this.dictionary_32[BookmarkStart.b("䐲", num)], BookmarkStart.b("圲䴴嘶", num));
            this.class1092_0.method_12();
        }
        if (A_0.HasValue(0xfaa))
        {
            this.class1092_0.method_10(BookmarkStart.b("夲嘴", num), this.dictionary_32[BookmarkStart.b("䐲", num)]);
            switch (A_0.method_73())
            {
                case RowAlignment.Center:
                    this.class1092_0.method_6(BookmarkStart.b("䐲", num), BookmarkStart.b("䔲吴嬶", num), this.dictionary_32[BookmarkStart.b("䐲", num)], BookmarkStart.b("倲倴夶䴸帺似", num));
                    break;

                case RowAlignment.Right:
                    this.class1092_0.method_6(BookmarkStart.b("䐲", num), BookmarkStart.b("䔲吴嬶", num), this.dictionary_32[BookmarkStart.b("䐲", num)], BookmarkStart.b("䄲尴倶儸伺", num));
                    break;

                default:
                    this.class1092_0.method_6(BookmarkStart.b("䐲", num), BookmarkStart.b("䔲吴嬶", num), this.dictionary_32[BookmarkStart.b("䐲", num)], BookmarkStart.b("弲倴儶䴸", num));
                    break;
            }
            this.class1092_0.method_12();
        }
        this.class1092_0.method_12();
    }

    private void method_451(Form2 A_0)
    {
        int num = 0x10;
        this.class1092_0.method_10(BookmarkStart.b("䈵娷嘹氻䰽", 0x10), this.dictionary_32[BookmarkStart.b("䄵", 0x10)]);
        if ((A_0.OwnerBase is Class13) && A_0.HasValue(0x1194))
        {
            this.class1092_0.method_10(BookmarkStart.b("䈵娷嘹漻䨽㤿⹁⅃ᑅ❇㵉๋⽍㹏㙑ݓ㽕≗㽙", num), this.dictionary_32[BookmarkStart.b("䄵", num)]);
            this.class1092_0.method_6(BookmarkStart.b("䄵", num), BookmarkStart.b("䀵夷嘹", num), this.dictionary_32[BookmarkStart.b("䄵", num)], A_0.method_82().ToString());
            this.class1092_0.method_12();
        }
        if ((A_0.OwnerBase is Class13) && A_0.HasValue(0x119e))
        {
            this.class1092_0.method_10(BookmarkStart.b("䈵娷嘹漻䨽㤿⹁⅃Յ❇♉๋⽍㹏㙑ݓ㽕≗㽙", num), this.dictionary_32[BookmarkStart.b("䄵", num)]);
            this.class1092_0.method_6(BookmarkStart.b("䄵", num), BookmarkStart.b("䀵夷嘹", num), this.dictionary_32[BookmarkStart.b("䄵", num)], A_0.method_80().ToString());
            this.class1092_0.method_12();
        }
        if (A_0.HasValue(0xfaa))
        {
            this.class1092_0.method_10(BookmarkStart.b("尵嬷", num), this.dictionary_32[BookmarkStart.b("䄵", num)]);
            switch (A_0.method_78())
            {
                case RowAlignment.Center:
                    this.class1092_0.method_6(BookmarkStart.b("䄵", num), BookmarkStart.b("䀵夷嘹", num), this.dictionary_32[BookmarkStart.b("䄵", num)], BookmarkStart.b("唵崷吹䠻嬽㈿", num));
                    break;

                case RowAlignment.Right:
                    this.class1092_0.method_6(BookmarkStart.b("䄵", num), BookmarkStart.b("䀵夷嘹", num), this.dictionary_32[BookmarkStart.b("䄵", num)], BookmarkStart.b("䐵儷崹吻䨽", num));
                    break;

                default:
                    this.class1092_0.method_6(BookmarkStart.b("䄵", num), BookmarkStart.b("䀵夷嘹", num), this.dictionary_32[BookmarkStart.b("䄵", num)], BookmarkStart.b("娵崷尹䠻", num));
                    break;
            }
            this.class1092_0.method_12();
        }
        if (A_0.HasValue(0x10c2))
        {
            this.class1092_0.method_10(BookmarkStart.b("䈵娷嘹缻嬽ⰿ⹁ᝃ㙅⥇⥉╋⁍㝏", num), this.dictionary_32[BookmarkStart.b("䄵", num)]);
            this.class1092_0.method_5(BookmarkStart.b("䄵", num), this.dictionary_32[BookmarkStart.b("䄵", num)], this.method_534(A_0.method_74() * 20f));
            this.class1092_0.method_5(BookmarkStart.b("䈵䄷䨹夻", num), this.dictionary_32[BookmarkStart.b("䄵", num)], BookmarkStart.b("刵䀷嬹", num));
            this.class1092_0.method_12();
        }
        if (A_0.HasValue(0x10f4))
        {
            this.class1092_0.method_10(BookmarkStart.b("䈵娷嘹画倽␿", num), this.dictionary_32[BookmarkStart.b("䄵", num)]);
            this.class1092_0.method_5(BookmarkStart.b("䄵", num), this.dictionary_32[BookmarkStart.b("䄵", num)], this.method_534(A_0.method_76() * 20f));
            this.class1092_0.method_5(BookmarkStart.b("䈵䄷䨹夻", num), this.dictionary_32[BookmarkStart.b("䄵", num)], BookmarkStart.b("刵䀷嬹", num));
            this.class1092_0.method_12();
        }
        if (!A_0.method_72().IsDefault && A_0.HasValue(1))
        {
            this.class1092_0.method_10(BookmarkStart.b("䈵娷嘹縻儽㈿♁⅃㑅㭇", num), this.dictionary_32[BookmarkStart.b("䄵", num)]);
            this.method_395(A_0.method_72(), 8);
            this.class1092_0.method_12();
        }
        if (!A_0.method_73().IsDefault && A_0.HasValue(3))
        {
            this.class1092_0.method_10(BookmarkStart.b("䈵娷嘹缻嬽ⰿ⹁ृ❅㩇", num), this.dictionary_32[BookmarkStart.b("䄵", num)]);
            this.method_165(A_0.method_73());
            this.class1092_0.method_12();
        }
        this.method_453(A_0);
        this.class1092_0.method_12();
    }

    private void method_452(Form3 A_0)
    {
        int num = 10;
        if ((A_0.HasValue(3) || A_0.HasValue(4)) || A_0.HasValue(5))
        {
            this.class1092_0.method_10(BookmarkStart.b("䌯娱倳", num), this.dictionary_32[BookmarkStart.b("䜯", num)]);
            string str = this.method_529(A_0.method_64());
            this.class1092_0.method_6(BookmarkStart.b("䜯", num), BookmarkStart.b("䘯匱堳", num), this.dictionary_32[BookmarkStart.b("䜯", num)], str);
            if ((A_0.method_62() == Color.Empty) && A_0.HasKey(4))
            {
                this.class1092_0.method_5(BookmarkStart.b("匯崱堳夵䨷", num), this.dictionary_32[BookmarkStart.b("䜯", num)], BookmarkStart.b("儯䜱䀳夵", num));
            }
            else if (A_0.method_62() != Color.Empty)
            {
                this.class1092_0.method_5(BookmarkStart.b("匯崱堳夵䨷", num), this.dictionary_32[BookmarkStart.b("䜯", num)], this.method_535(A_0.method_62()));
            }
            if ((A_0.method_60() == Color.Empty) && A_0.HasKey(3))
            {
                this.class1092_0.method_5(BookmarkStart.b("嘯嬱堳娵", num), this.dictionary_32[BookmarkStart.b("䜯", num)], BookmarkStart.b("儯䜱䀳夵", num));
            }
            else if (A_0.method_60() != Color.Empty)
            {
                this.class1092_0.method_5(BookmarkStart.b("嘯嬱堳娵", num), this.dictionary_32[BookmarkStart.b("䜯", num)], this.method_535(A_0.method_60()));
            }
            this.class1092_0.method_12();
        }
    }

    private void method_453(Form2 A_0)
    {
        int num = 10;
        if ((A_0.HasValue(0x6c) || A_0.HasValue(0x6f)) || A_0.HasValue(110))
        {
            this.class1092_0.method_10(BookmarkStart.b("䌯娱倳", num), this.dictionary_32[BookmarkStart.b("䜯", num)]);
            string str = this.method_529(A_0.method_69());
            this.class1092_0.method_6(BookmarkStart.b("䜯", num), BookmarkStart.b("䘯匱堳", num), this.dictionary_32[BookmarkStart.b("䜯", num)], str);
            if ((A_0.method_67() == Color.Empty) && A_0.HasKey(0x6f))
            {
                this.class1092_0.method_5(BookmarkStart.b("匯崱堳夵䨷", num), this.dictionary_32[BookmarkStart.b("䜯", num)], BookmarkStart.b("儯䜱䀳夵", num));
            }
            else if (A_0.method_67() != Color.Empty)
            {
                this.class1092_0.method_5(BookmarkStart.b("匯崱堳夵䨷", num), this.dictionary_32[BookmarkStart.b("䜯", num)], this.method_535(A_0.method_67()));
            }
            if ((A_0.method_65() == Color.Empty) && A_0.HasKey(0x6c))
            {
                this.class1092_0.method_5(BookmarkStart.b("嘯嬱堳娵", num), this.dictionary_32[BookmarkStart.b("䜯", num)], BookmarkStart.b("儯䜱䀳夵", num));
            }
            else if (A_0.method_65() != Color.Empty)
            {
                this.class1092_0.method_5(BookmarkStart.b("嘯嬱堳娵", num), this.dictionary_32[BookmarkStart.b("䜯", num)], this.method_535(A_0.method_65()));
            }
            this.class1092_0.method_12();
        }
    }

    private void method_454()
    {
        if (this.document_0.LatentStyles != null)
        {
            this.document_0.LatentStyles.WriteTo(this.class1092_0.method_0());
        }
        else if (this.document_0.LatentStyles2010 != null)
        {
            this.method_272(this.document_0.LatentStyles2010);
        }
    }

    private void method_455()
    {
        int num = 0x13;
        this.class1092_0.method_10(BookmarkStart.b("崸吺帼笾⑀╂⑄㉆╈㽊㹌", 0x13), this.dictionary_32[BookmarkStart.b("丸", 0x13)]);
        this.class1092_0.method_10(BookmarkStart.b("䬸欺似笾⑀╂⑄㉆╈㽊", 0x13), this.dictionary_32[BookmarkStart.b("丸", 0x13)]);
        if (this.document_0.DefCharFormat != null)
        {
            this.method_463(this.document_0.DefCharFormat);
        }
        else
        {
            this.class1092_0.method_10(BookmarkStart.b("䬸欺似", num), this.dictionary_32[BookmarkStart.b("丸", num)]);
            if ((!string.IsNullOrEmpty(this.document_0.StandardAsciiFont) || !string.IsNullOrEmpty(this.document_0.StandardFarEastFont)) || (!string.IsNullOrEmpty(this.document_0.StandardNonFarEastFont) || !string.IsNullOrEmpty(this.document_0.StandardBidiFont)))
            {
                this.class1092_0.method_10(BookmarkStart.b("䬸紺刼儾㕀あ", num), this.dictionary_32[BookmarkStart.b("丸", num)]);
                if (!string.IsNullOrEmpty(this.document_0.StandardAsciiFont))
                {
                    this.class1092_0.method_5(BookmarkStart.b("堸䠺帼嘾⡀", num), this.dictionary_32[BookmarkStart.b("丸", num)], this.document_0.StandardAsciiFont);
                }
                if (!string.IsNullOrEmpty(this.document_0.StandardFarEastFont))
                {
                    this.class1092_0.method_5(BookmarkStart.b("尸娺丼䬾@あⱄ♆", num), this.dictionary_32[BookmarkStart.b("丸", num)], this.document_0.StandardFarEastFont);
                }
                if (!string.IsNullOrEmpty(this.document_0.StandardNonFarEastFont))
                {
                    this.class1092_0.method_5(BookmarkStart.b("儸稺匼䰾⡀", num), this.dictionary_32[BookmarkStart.b("丸", num)], this.document_0.StandardNonFarEastFont);
                }
                if (!string.IsNullOrEmpty(this.document_0.StandardBidiFont))
                {
                    this.class1092_0.method_5(BookmarkStart.b("娸䠺", num), this.dictionary_32[BookmarkStart.b("丸", num)], this.document_0.StandardBidiFont);
                }
                this.class1092_0.method_12();
            }
            float num2 = this.method_537(this.document_0, 190);
            if (num2 != 0f)
            {
                this.class1092_0.method_10(BookmarkStart.b("䨸䄺", num), this.dictionary_32[BookmarkStart.b("丸", num)]);
                this.class1092_0.method_5(BookmarkStart.b("伸娺儼", num), this.dictionary_32[BookmarkStart.b("丸", num)], (num2 * 2f).ToString());
                this.class1092_0.method_12();
            }
            num2 = this.method_537(this.document_0, 350);
            if (num2 != 0f)
            {
                this.class1092_0.method_10(BookmarkStart.b("䨸䄺縼䰾", num), this.dictionary_32[BookmarkStart.b("丸", num)]);
                this.class1092_0.method_5(BookmarkStart.b("伸娺儼", num), this.dictionary_32[BookmarkStart.b("丸", num)], (num2 * 2f).ToString());
                this.class1092_0.method_12();
            }
            this.class1092_0.method_12();
        }
        this.class1092_0.method_12();
        this.class1092_0.method_10(BookmarkStart.b("䤸欺似笾⑀╂⑄㉆╈㽊", num), this.dictionary_32[BookmarkStart.b("丸", num)]);
        if (this.document_0.paragraphFormat_0 != null)
        {
            this.class1092_0.method_10(BookmarkStart.b("䤸欺似", num), this.dictionary_32[BookmarkStart.b("丸", num)]);
            this.method_472(this.document_0.paragraphFormat_0, null);
            this.class1092_0.method_12();
        }
        this.class1092_0.method_12();
        this.class1092_0.method_12();
        this.method_454();
        if ((this.document_0.Styles.Count == 0) || (this.document_0.Styles.FindByName(BookmarkStart.b("眸吺似刾⁀⽂", num)) == null))
        {
            this.method_462();
        }
        if (!this.method_553())
        {
            this.method_461();
        }
        if ((this.document_0.Styles.FindByName(BookmarkStart.b("眸吺ᴼ猾⡀あㅄ", num)) == null) && (this.document_0.Styles.FindByName(BookmarkStart.b("眸吺焼嘾㉀㝂", num)) == null))
        {
            this.method_460();
        }
        if ((this.document_0.Styles.FindByName(BookmarkStart.b("洸娺弼匾⑀捂Ʉ㕆⁈⽊", num)) == null) && (this.document_0.Styles.FindByName(BookmarkStart.b("洸娺弼匾⑀т㝄⹆ⵈ", num)) == null))
        {
            this.method_459();
        }
    }

    private void method_456(CharacterFormat A_0)
    {
        int num = 0x10;
        if (this.method_458(A_0))
        {
            this.class1092_0.method_10(BookmarkStart.b("䐵縷唹刻䨽㌿", num), this.dictionary_32[BookmarkStart.b("䄵", num)]);
            if (A_0.HasKey(530))
            {
                this.class1092_0.method_5(BookmarkStart.b("圵䬷夹唻圽ᐿ⩁⅃⭅ⵇ", num), this.dictionary_32[BookmarkStart.b("䄵", num)], A_0.AsciiTheme);
            }
            if (A_0.HasKey(550))
            {
                this.class1092_0.method_5(BookmarkStart.b("匵夷䤹䠻缽㌿⭁╃ቅ⁇⽉⅋⭍", num), this.dictionary_32[BookmarkStart.b("䄵", num)], A_0.EastAsiaTheme);
            }
            if (A_0.HasKey(540))
            {
                this.class1092_0.method_5(BookmarkStart.b("帵礷吹伻圽ᐿ⩁⅃⭅ⵇ", num), this.dictionary_32[BookmarkStart.b("䄵", num)], A_0.HAnsiTheme);
            }
            if (A_0.HasKey(560))
            {
                this.class1092_0.method_5(BookmarkStart.b("唵䬷丹吻嬽ⴿ❁", num), this.dictionary_32[BookmarkStart.b("䄵", num)], A_0.CsTheme);
            }
            if (A_0.HasKey(230))
            {
                this.class1092_0.method_5(BookmarkStart.b("圵䬷夹唻圽", num), this.dictionary_32[BookmarkStart.b("䄵", num)], A_0.FontNameAscii);
                this.method_457(A_0.FontNameAscii, A_0.HasKey(60), A_0.HasKey(70));
            }
            if (A_0.HasKey(0xeb))
            {
                this.class1092_0.method_5(BookmarkStart.b("匵夷䤹䠻缽㌿⭁╃", num), this.dictionary_32[BookmarkStart.b("䄵", num)], A_0.FontNameFarEast);
                this.method_457(A_0.FontNameFarEast, A_0.HasKey(60), A_0.HasKey(70));
            }
            if (A_0.HasKey(240))
            {
                this.class1092_0.method_5(BookmarkStart.b("帵礷吹伻圽", num), this.dictionary_32[BookmarkStart.b("䄵", num)], A_0.FontNameNonFarEast);
                this.method_457(A_0.FontNameNonFarEast, A_0.HasKey(60), A_0.HasKey(70));
            }
            if (A_0.HasKey(270))
            {
                this.class1092_0.method_5(BookmarkStart.b("唵䬷", num), this.dictionary_32[BookmarkStart.b("䄵", num)], A_0.FontNameBidi);
                this.method_457(A_0.FontNameBidi, A_0.HasKey(250), A_0.HasKey(250));
            }
            if (A_0.HasKey(400))
            {
                switch (A_0.FontTypeHint)
                {
                    case FontTypeHint.Default:
                        this.class1092_0.method_5(BookmarkStart.b("帵儷吹䠻", num), this.dictionary_32[BookmarkStart.b("䄵", num)], BookmarkStart.b("刵崷尹崻䬽ⰿ㙁", num));
                        break;

                    case FontTypeHint.EastAsia:
                        this.class1092_0.method_5(BookmarkStart.b("帵儷吹䠻", num), this.dictionary_32[BookmarkStart.b("䄵", num)], BookmarkStart.b("匵夷䤹䠻缽㌿⭁╃", num));
                        break;

                    case FontTypeHint.ComplexScript:
                        this.class1092_0.method_5(BookmarkStart.b("帵儷吹䠻", num), this.dictionary_32[BookmarkStart.b("䄵", num)], BookmarkStart.b("唵䬷", num));
                        break;
                }
            }
            this.class1092_0.method_12();
        }
    }

    private void method_457(string A_0, bool A_1, bool A_2)
    {
        int num = 5;
        string item = A_0.ToLower();
        if (A_1 && A_2)
        {
            item = item + BookmarkStart.b("琪伬䀮崰圲尴䌶堸场吼尾", num);
        }
        else if (A_1)
        {
            item = item + BookmarkStart.b("琪伬䀮崰圲", num);
        }
        else if (A_2)
        {
            item = item + BookmarkStart.b("琪䐬嬮倰弲尴吶", num);
        }
        if (!this.method_0().Contains(item))
        {
            this.method_0().Add(item);
        }
    }

    private bool method_458(CharacterFormat A_0)
    {
        if ((A_0 == null) || (((!A_0.HasValue(230) && !A_0.HasValue(0xeb)) && (!A_0.HasValue(240) && !A_0.HasValue(270))) && ((!A_0.HasValue(530) && !A_0.HasValue(550)) && ((!A_0.HasValue(540) && !A_0.HasValue(560)) && !A_0.HasValue(400)))))
        {
            return false;
        }
        return true;
    }

    private void method_459()
    {
        this.class1092_0.method_11(BookmarkStart.b("帨", 3), BookmarkStart.b("娨弪听䌮吰", 3), this.dictionary_32[BookmarkStart.b("帨", 3)]);
        this.class1092_0.method_5(BookmarkStart.b("崨刪崬䨮", 3), this.dictionary_32[BookmarkStart.b("帨", 3)], BookmarkStart.b("崨䨪伬䌮吰", 3));
        this.class1092_0.method_5(BookmarkStart.b("娨弪听䌮吰稲儴", 3), this.dictionary_32[BookmarkStart.b("帨", 3)], BookmarkStart.b("紨䨪伬䌮吰琲䜴帶崸", 3));
        this.class1092_0.method_10(BookmarkStart.b("䜨䨪䀬䨮", 3), this.dictionary_32[BookmarkStart.b("帨", 3)]);
        this.class1092_0.method_5(BookmarkStart.b("弨䨪䄬", 3), this.dictionary_32[BookmarkStart.b("帨", 3)], BookmarkStart.b("紨䨪伬䌮吰ጲ爴䔶倸强", 3));
        this.class1092_0.method_12();
        this.class1092_0.method_10(BookmarkStart.b("䬨䨪帬䨮唰簲嬴", 3), this.dictionary_32[BookmarkStart.b("帨", 3)]);
        this.class1092_0.method_5(BookmarkStart.b("弨䨪䄬", 3), this.dictionary_32[BookmarkStart.b("帨", 3)], BookmarkStart.b("紨䨪伬䌮吰紲娴䔶吸娺儼", 3));
        this.class1092_0.method_12();
        this.class1092_0.method_10(BookmarkStart.b("崨䤪䄬缮䌰", 3), this.dictionary_32[BookmarkStart.b("帨", 3)]);
        this.class1092_0.method_10(BookmarkStart.b("崨䤪䄬昮弰圲", 3), this.dictionary_32[BookmarkStart.b("帨", 3)]);
        this.class1092_0.method_5(BookmarkStart.b("帨", 3), this.dictionary_32[BookmarkStart.b("帨", 3)], BookmarkStart.b("ᤨ", 3));
        this.class1092_0.method_5(BookmarkStart.b("崨刪崬䨮", 3), this.dictionary_32[BookmarkStart.b("帨", 3)], BookmarkStart.b("䴨匪䰬", 3));
        this.class1092_0.method_12();
        this.class1092_0.method_10(BookmarkStart.b("崨䤪䄬洮帰䄲儴制䬸䠺", 3), this.dictionary_32[BookmarkStart.b("帨", 3)]);
        this.class1092_0.method_10(BookmarkStart.b("崨䐪崬", 3), this.dictionary_32[BookmarkStart.b("帨", 3)]);
        this.class1092_0.method_5(BookmarkStart.b("弨䨪䄬", 3), this.dictionary_32[BookmarkStart.b("帨", 3)], BookmarkStart.b("娨䈪䌬䠮崰嘲", 3));
        this.class1092_0.method_5(BookmarkStart.b("娨優", 3), this.dictionary_32[BookmarkStart.b("帨", 3)], BookmarkStart.b("ᴨ", 3));
        this.class1092_0.method_5(BookmarkStart.b("娨嬪䰬䰮吰", 3), this.dictionary_32[BookmarkStart.b("帨", 3)], BookmarkStart.b("ᤨ", 3));
        this.class1092_0.method_5(BookmarkStart.b("䨨䐪䄬䀮䌰", 3), this.dictionary_32[BookmarkStart.b("帨", 3)], BookmarkStart.b("ᤨᬪᴬἮİ̲", 3));
        this.class1092_0.method_12();
        this.class1092_0.method_10(BookmarkStart.b("䔨个䬬嬮", 3), this.dictionary_32[BookmarkStart.b("帨", 3)]);
        this.class1092_0.method_5(BookmarkStart.b("弨䨪䄬", 3), this.dictionary_32[BookmarkStart.b("帨", 3)], BookmarkStart.b("娨䈪䌬䠮崰嘲", 3));
        this.class1092_0.method_5(BookmarkStart.b("娨優", 3), this.dictionary_32[BookmarkStart.b("帨", 3)], BookmarkStart.b("ᴨ", 3));
        this.class1092_0.method_5(BookmarkStart.b("娨嬪䰬䰮吰", 3), this.dictionary_32[BookmarkStart.b("帨", 3)], BookmarkStart.b("ᤨ", 3));
        this.class1092_0.method_5(BookmarkStart.b("䨨䐪䄬䀮䌰", 3), this.dictionary_32[BookmarkStart.b("帨", 3)], BookmarkStart.b("ᤨᬪᴬἮİ̲", 3));
        this.class1092_0.method_12();
        this.class1092_0.method_10(BookmarkStart.b("䬨䐪夬嬮帰帲", 3), this.dictionary_32[BookmarkStart.b("帨", 3)]);
        this.class1092_0.method_5(BookmarkStart.b("弨䨪䄬", 3), this.dictionary_32[BookmarkStart.b("帨", 3)], BookmarkStart.b("娨䈪䌬䠮崰嘲", 3));
        this.class1092_0.method_5(BookmarkStart.b("娨優", 3), this.dictionary_32[BookmarkStart.b("帨", 3)], BookmarkStart.b("ᴨ", 3));
        this.class1092_0.method_5(BookmarkStart.b("娨嬪䰬䰮吰", 3), this.dictionary_32[BookmarkStart.b("帨", 3)], BookmarkStart.b("ᤨ", 3));
        this.class1092_0.method_5(BookmarkStart.b("䨨䐪䄬䀮䌰", 3), this.dictionary_32[BookmarkStart.b("帨", 3)], BookmarkStart.b("ᤨᬪᴬἮİ̲", 3));
        this.class1092_0.method_12();
        this.class1092_0.method_10(BookmarkStart.b("嬨䈪䨬䜮䔰", 3), this.dictionary_32[BookmarkStart.b("帨", 3)]);
        this.class1092_0.method_5(BookmarkStart.b("弨䨪䄬", 3), this.dictionary_32[BookmarkStart.b("帨", 3)], BookmarkStart.b("娨䈪䌬䠮崰嘲", 3));
        this.class1092_0.method_5(BookmarkStart.b("娨優", 3), this.dictionary_32[BookmarkStart.b("帨", 3)], BookmarkStart.b("ᴨ", 3));
        this.class1092_0.method_5(BookmarkStart.b("娨嬪䰬䰮吰", 3), this.dictionary_32[BookmarkStart.b("帨", 3)], BookmarkStart.b("ᤨ", 3));
        this.class1092_0.method_5(BookmarkStart.b("䨨䐪䄬䀮䌰", 3), this.dictionary_32[BookmarkStart.b("帨", 3)], BookmarkStart.b("ᤨᬪᴬἮİ̲", 3));
        this.class1092_0.method_12();
        this.class1092_0.method_10(BookmarkStart.b("䀨䔪帬䘮唰嘲紴", 3), this.dictionary_32[BookmarkStart.b("帨", 3)]);
        this.class1092_0.method_5(BookmarkStart.b("弨䨪䄬", 3), this.dictionary_32[BookmarkStart.b("帨", 3)], BookmarkStart.b("娨䈪䌬䠮崰嘲", 3));
        this.class1092_0.method_5(BookmarkStart.b("娨優", 3), this.dictionary_32[BookmarkStart.b("帨", 3)], BookmarkStart.b("ᴨ", 3));
        this.class1092_0.method_5(BookmarkStart.b("娨嬪䰬䰮吰", 3), this.dictionary_32[BookmarkStart.b("帨", 3)], BookmarkStart.b("ᤨ", 3));
        this.class1092_0.method_5(BookmarkStart.b("䨨䐪䄬䀮䌰", 3), this.dictionary_32[BookmarkStart.b("帨", 3)], BookmarkStart.b("ᤨᬪᴬἮİ̲", 3));
        this.class1092_0.method_12();
        this.class1092_0.method_10(BookmarkStart.b("䀨䔪帬䘮唰嘲挴", 3), this.dictionary_32[BookmarkStart.b("帨", 3)]);
        this.class1092_0.method_5(BookmarkStart.b("弨䨪䄬", 3), this.dictionary_32[BookmarkStart.b("帨", 3)], BookmarkStart.b("娨䈪䌬䠮崰嘲", 3));
        this.class1092_0.method_5(BookmarkStart.b("娨優", 3), this.dictionary_32[BookmarkStart.b("帨", 3)], BookmarkStart.b("ᴨ", 3));
        this.class1092_0.method_5(BookmarkStart.b("娨嬪䰬䰮吰", 3), this.dictionary_32[BookmarkStart.b("帨", 3)], BookmarkStart.b("ᤨ", 3));
        this.class1092_0.method_5(BookmarkStart.b("䨨䐪䄬䀮䌰", 3), this.dictionary_32[BookmarkStart.b("帨", 3)], BookmarkStart.b("ᤨᬪᴬἮİ̲", 3));
        this.class1092_0.method_12();
        this.class1092_0.method_12();
        this.class1092_0.method_12();
        this.class1092_0.method_12();
    }

    private Stack<Field> method_46()
    {
        if (this.stack_0 == null)
        {
            this.stack_0 = new Stack<Field>();
        }
        return this.stack_0;
    }

    private void method_460()
    {
        this.class1092_0.method_11(BookmarkStart.b("䄵", 0x10), BookmarkStart.b("䔵䰷䌹倻嬽", 0x10), this.dictionary_32[BookmarkStart.b("䄵", 0x10)]);
        this.class1092_0.method_5(BookmarkStart.b("䈵䄷䨹夻", 0x10), this.dictionary_32[BookmarkStart.b("䄵", 0x10)], BookmarkStart.b("堵䴷圹帻嬽㈿⭁⩃ⅅ", 0x10));
        this.class1092_0.method_5(BookmarkStart.b("刵崷尹崻䬽ⰿ㙁", 0x10), this.dictionary_32[BookmarkStart.b("䄵", 0x10)], BookmarkStart.b("ܵ", 0x10));
        this.class1092_0.method_5(BookmarkStart.b("䔵䰷䌹倻嬽ि♁", 0x10), this.dictionary_32[BookmarkStart.b("䄵", 0x10)], BookmarkStart.b("砵圷瘹唻䴽㐿", 0x10));
        this.class1092_0.method_10(BookmarkStart.b("堵夷圹夻", 0x10), this.dictionary_32[BookmarkStart.b("䄵", 0x10)]);
        this.class1092_0.method_5(BookmarkStart.b("䀵夷嘹", 0x10), this.dictionary_32[BookmarkStart.b("䄵", 0x10)], BookmarkStart.b("砵圷ᨹ瀻圽㌿㙁", 0x10));
        this.class1092_0.method_12();
        this.class1092_0.method_10(BookmarkStart.b("䌵儷樹主圽⼿ぁⵃ㉅ㅇ", 0x10), this.dictionary_32[BookmarkStart.b("䄵", 0x10)]);
        this.class1092_0.method_5(BookmarkStart.b("䀵夷嘹", 0x10), this.dictionary_32[BookmarkStart.b("䄵", 0x10)], BookmarkStart.b("༵ķ", 0x10));
        this.class1092_0.method_12();
        this.class1092_0.method_10(BookmarkStart.b("䔵崷圹唻瘽⤿♁⁃⍅♇", 0x10), this.dictionary_32[BookmarkStart.b("䄵", 0x10)]);
        this.class1092_0.method_12();
        this.class1092_0.method_10(BookmarkStart.b("䌵嘷刹唻娽┿ᕁⱃ⍅♇Ὁ㽋⭍㑏", 0x10), this.dictionary_32[BookmarkStart.b("䄵", 0x10)]);
        this.class1092_0.method_12();
        this.class1092_0.method_12();
    }

    private void method_461()
    {
        this.class1092_0.method_11(BookmarkStart.b("嬫", 6), BookmarkStart.b("弫娭䤯帱儳", 6), this.dictionary_32[BookmarkStart.b("嬫", 6)]);
        this.class1092_0.method_5(BookmarkStart.b("堫圭䀯圱", 6), this.dictionary_32[BookmarkStart.b("嬫", 6)], BookmarkStart.b("堫伭刯帱儳", 6));
        this.class1092_0.method_5(BookmarkStart.b("䠫䬭嘯匱䄳娵䰷", 6), this.dictionary_32[BookmarkStart.b("嬫", 6)], BookmarkStart.b("ᴫ", 6));
        this.class1092_0.method_5(BookmarkStart.b("弫娭䤯帱儳缵尷", 6), this.dictionary_32[BookmarkStart.b("嬫", 6)], BookmarkStart.b("砫伭刯帱儳砵圷䠹儻弽ⰿ", 6));
        this.class1092_0.method_10(BookmarkStart.b("䈫伭崯圱", 6), this.dictionary_32[BookmarkStart.b("嬫", 6)]);
        this.class1092_0.method_5(BookmarkStart.b("娫伭尯", 6), this.dictionary_32[BookmarkStart.b("嬫", 6)], BookmarkStart.b("戫䄭䈯弱唳娵ᠷ渹崻尽ⰿ❁", 6));
        this.class1092_0.method_12();
        this.class1092_0.method_10(BookmarkStart.b("夫䜭怯䀱崳夵䨷匹䠻䜽", 6), this.dictionary_32[BookmarkStart.b("嬫", 6)]);
        this.class1092_0.method_5(BookmarkStart.b("娫伭尯", 6), this.dictionary_32[BookmarkStart.b("嬫", 6)], BookmarkStart.b("ᔫᜭ", 6));
        this.class1092_0.method_12();
        this.class1092_0.method_10(BookmarkStart.b("弫䬭崯嬱簳張尷帹夻倽", 6), this.dictionary_32[BookmarkStart.b("嬫", 6)]);
        this.class1092_0.method_12();
        this.class1092_0.method_10(BookmarkStart.b("夫䀭堯嬱倳匵漷刹夻倽ᔿㅁ⅃≅", 6), this.dictionary_32[BookmarkStart.b("嬫", 6)]);
        this.class1092_0.method_12();
        this.class1092_0.method_10(BookmarkStart.b("崫栭弯䀱夳圵䰷", 6), this.dictionary_32[BookmarkStart.b("嬫", 6)]);
        this.class1092_0.method_12();
        this.class1092_0.method_10(BookmarkStart.b("堫䰭尯戱䘳", 6), this.dictionary_32[BookmarkStart.b("嬫", 6)]);
        this.class1092_0.method_10(BookmarkStart.b("堫䰭尯笱娳刵", 6), this.dictionary_32[BookmarkStart.b("嬫", 6)]);
        this.class1092_0.method_5(BookmarkStart.b("嬫", 6), this.dictionary_32[BookmarkStart.b("嬫", 6)], BookmarkStart.b("ᰫ", 6));
        this.class1092_0.method_5(BookmarkStart.b("堫圭䀯圱", 6), this.dictionary_32[BookmarkStart.b("嬫", 6)], BookmarkStart.b("䠫嘭儯", 6));
        this.class1092_0.method_12();
        this.class1092_0.method_10(BookmarkStart.b("堫䰭尯焱儳娵吷眹崻䰽", 6), this.dictionary_32[BookmarkStart.b("嬫", 6)]);
        this.class1092_0.method_10(BookmarkStart.b("堫䄭䀯", 6), this.dictionary_32[BookmarkStart.b("嬫", 6)]);
        this.class1092_0.method_5(BookmarkStart.b("嬫", 6), this.dictionary_32[BookmarkStart.b("嬫", 6)], BookmarkStart.b("ᰫ", 6));
        this.class1092_0.method_5(BookmarkStart.b("堫圭䀯圱", 6), this.dictionary_32[BookmarkStart.b("嬫", 6)], BookmarkStart.b("䠫嘭儯", 6));
        this.class1092_0.method_12();
        this.class1092_0.method_10(BookmarkStart.b("䀫䬭嘯䘱", 6), this.dictionary_32[BookmarkStart.b("嬫", 6)]);
        this.class1092_0.method_5(BookmarkStart.b("嬫", 6), this.dictionary_32[BookmarkStart.b("嬫", 6)], BookmarkStart.b("ᴫḭ࠯", 6));
        this.class1092_0.method_5(BookmarkStart.b("堫圭䀯圱", 6), this.dictionary_32[BookmarkStart.b("嬫", 6)], BookmarkStart.b("䠫嘭儯", 6));
        this.class1092_0.method_12();
        this.class1092_0.method_10(BookmarkStart.b("丫䄭䐯䘱嬳嬵", 6), this.dictionary_32[BookmarkStart.b("嬫", 6)]);
        this.class1092_0.method_5(BookmarkStart.b("嬫", 6), this.dictionary_32[BookmarkStart.b("嬫", 6)], BookmarkStart.b("ᰫ", 6));
        this.class1092_0.method_5(BookmarkStart.b("堫圭䀯圱", 6), this.dictionary_32[BookmarkStart.b("嬫", 6)], BookmarkStart.b("䠫嘭儯", 6));
        this.class1092_0.method_12();
        this.class1092_0.method_10(BookmarkStart.b("師䜭圯娱䀳", 6), this.dictionary_32[BookmarkStart.b("嬫", 6)]);
        this.class1092_0.method_5(BookmarkStart.b("嬫", 6), this.dictionary_32[BookmarkStart.b("嬫", 6)], BookmarkStart.b("ᴫḭ࠯", 6));
        this.class1092_0.method_5(BookmarkStart.b("堫圭䀯圱", 6), this.dictionary_32[BookmarkStart.b("嬫", 6)], BookmarkStart.b("䠫嘭儯", 6));
        this.class1092_0.method_12();
        this.class1092_0.method_12();
        this.class1092_0.method_12();
        this.class1092_0.method_12();
    }

    private void method_462()
    {
        this.class1092_0.method_11(BookmarkStart.b("䘰", 11), BookmarkStart.b("䈰䜲䰴嬶尸", 11), this.dictionary_32[BookmarkStart.b("䘰", 11)]);
        this.class1092_0.method_5(BookmarkStart.b("䔰䨲䔴制", 11), this.dictionary_32[BookmarkStart.b("䘰", 11)], BookmarkStart.b("䄰刲䜴嘶常䤺尼伾⥀", 11));
        this.class1092_0.method_5(BookmarkStart.b("唰嘲匴嘶䰸场䤼", 11), this.dictionary_32[BookmarkStart.b("䘰", 11)], BookmarkStart.b("0", 11));
        this.class1092_0.method_5(BookmarkStart.b("䈰䜲䰴嬶尸爺夼", 11), this.dictionary_32[BookmarkStart.b("䘰", 11)], BookmarkStart.b("缰尲䜴娶堸场", 11));
        this.class1092_0.method_10(BookmarkStart.b("弰刲場制", 11), this.dictionary_32[BookmarkStart.b("䘰", 11)]);
        this.class1092_0.method_5(BookmarkStart.b("䜰刲头", 11), this.dictionary_32[BookmarkStart.b("䘰", 11)], BookmarkStart.b("缰尲䜴娶堸场", 11));
        this.class1092_0.method_12();
        this.class1092_0.method_10(BookmarkStart.b("䀰甲娴䔶吸娺䤼", 11), this.dictionary_32[BookmarkStart.b("䘰", 11)]);
        this.class1092_0.method_12();
        this.class1092_0.method_12();
        this.class1092_0.method_11(BookmarkStart.b("䘰", 11), BookmarkStart.b("䈰䜲䰴嬶尸", 11), this.dictionary_32[BookmarkStart.b("䘰", 11)]);
        this.class1092_0.method_5(BookmarkStart.b("䔰䨲䔴制", 11), this.dictionary_32[BookmarkStart.b("䘰", 11)], BookmarkStart.b("到嬲吴䔶堸堺䤼娾㍀", 11));
        this.class1092_0.method_5(BookmarkStart.b("唰嘲匴嘶䰸场䤼", 11), this.dictionary_32[BookmarkStart.b("䘰", 11)], BookmarkStart.b("0", 11));
        this.class1092_0.method_5(BookmarkStart.b("䈰䜲䰴嬶尸爺夼", 11), this.dictionary_32[BookmarkStart.b("䘰", 11)], BookmarkStart.b("田嘲匴嘶䰸场䤼漾⁀ㅂ⑄⁆㭈⩊㵌❎ᝐ㱒㭔⍖", 11));
        this.class1092_0.method_10(BookmarkStart.b("弰刲場制", 11), this.dictionary_32[BookmarkStart.b("䘰", 11)]);
        this.class1092_0.method_5(BookmarkStart.b("䜰刲头", 11), this.dictionary_32[BookmarkStart.b("䘰", 11)], BookmarkStart.b("田嘲匴嘶䰸场䤼漾⁀ㅂ⑄⁆㭈⩊㵌❎ᝐ㱒㭔⍖", 11));
        this.class1092_0.method_12();
        this.class1092_0.method_10(BookmarkStart.b("䐰娲攴䔶倸吺似嘾㕀㩂", 11), this.dictionary_32[BookmarkStart.b("䘰", 11)]);
        this.class1092_0.method_5(BookmarkStart.b("䜰刲头", 11), this.dictionary_32[BookmarkStart.b("䘰", 11)], BookmarkStart.b("0", 11));
        this.class1092_0.method_12();
        this.class1092_0.method_10(BookmarkStart.b("䈰嘲場帶焸刺夼嬾⑀ⵂ", 11), this.dictionary_32[BookmarkStart.b("䘰", 11)]);
        this.class1092_0.method_12();
        this.class1092_0.method_10(BookmarkStart.b("䐰崲崴帶崸帺樼圾⑀ⵂ၄㑆ⱈ⽊", 11), this.dictionary_32[BookmarkStart.b("䘰", 11)]);
        this.class1092_0.method_12();
        this.class1092_0.method_12();
    }

    private void method_463(CharacterFormat A_0)
    {
        int num = 0x13;
        this.class1092_0.method_10(BookmarkStart.b("䬸欺似", 0x13), this.dictionary_32[BookmarkStart.b("丸", 0x13)]);
        if (string.IsNullOrEmpty(A_0.CharStyleName))
        {
            goto Label_013E;
        }
        string str2 = (A_0.CharStyle == null) ? A_0.CharStyleName : A_0.CharStyle.StyleId;
        Dictionary<string, string> styleNameIds = this.document_0.StyleNameIds;
        if (styleNameIds.ContainsValue(str2))
        {
            using (Dictionary<string, string>.KeyCollection.Enumerator enumerator = styleNameIds.Keys.GetEnumerator())
            {
                string current;
                while (enumerator.MoveNext())
                {
                    current = enumerator.Current;
                    if (styleNameIds[current] == str2)
                    {
                        goto Label_00B0;
                    }
                }
                goto Label_00C4;
            Label_00B0:
                str2 = current;
            }
        }
    Label_00C4:
        this.class1092_0.method_10(BookmarkStart.b("䬸栺䤼䘾ⵀ♂", num), this.dictionary_32[BookmarkStart.b("丸", num)]);
        this.class1092_0.method_5(BookmarkStart.b("伸娺儼", num), this.dictionary_32[BookmarkStart.b("丸", num)], str2.Replace(BookmarkStart.b("ᤸ", num), string.Empty));
        this.class1092_0.method_12();
    Label_013E:
        this.method_456(A_0);
        if (A_0.HasKey(0x10c))
        {
            this.method_500(0x10c, BookmarkStart.b("娸䠺", num), A_0);
        }
        if (A_0.HasKey(60))
        {
            this.method_500(60, BookmarkStart.b("嬸", num), A_0);
        }
        if (A_0.HasKey(250))
        {
            this.method_500(250, BookmarkStart.b("嬸砺丼", num), A_0);
        }
        else if (A_0.Bidi && A_0.Bold)
        {
            this.class1092_0.method_10(BookmarkStart.b("嬸砺丼", num), this.dictionary_32[BookmarkStart.b("丸", num)]);
            this.class1092_0.method_12();
        }
        if (A_0.HasKey(70))
        {
            this.method_500(70, BookmarkStart.b("倸", num), A_0);
        }
        if (A_0.HasKey(260))
        {
            this.method_500(260, BookmarkStart.b("倸砺丼", num), A_0);
        }
        else if (A_0.Bidi && A_0.Italic)
        {
            this.class1092_0.method_10(BookmarkStart.b("倸砺丼", num), this.dictionary_32[BookmarkStart.b("丸", num)]);
            this.class1092_0.method_12();
        }
        if (A_0.HasKey(120))
        {
            this.method_500(120, BookmarkStart.b("娸娺䴼䰾", num), A_0);
        }
        if (A_0.HasKey(110))
        {
            this.method_500(110, BookmarkStart.b("䨸嘺尼匾ⵀB⑄㝆㩈", num), A_0);
        }
        if (A_0.HasKey(80))
        {
            this.method_500(80, BookmarkStart.b("䨸伺似嘾⩀♂", num), A_0);
        }
        if (A_0.HasKey(300))
        {
            this.method_500(300, BookmarkStart.b("崸䠺䤼䴾⡀⡂⁄", num), A_0);
        }
        if (A_0.HasKey(90))
        {
            this.method_500(90, BookmarkStart.b("嘸为䤼匾⡀ⵂ⁄", num), A_0);
        }
        if (A_0.HasKey(100))
        {
            this.method_500(100, BookmarkStart.b("䨸区尼嬾⹀㑂", num), A_0);
        }
        if (A_0.HasKey(170))
        {
            this.method_500(170, BookmarkStart.b("尸嘺弼倾㉀あ", num), A_0);
        }
        if (A_0.HasKey(180))
        {
            this.method_500(180, BookmarkStart.b("倸嘺䴼䴾⡀ⵂㅄ", num), A_0);
        }
        if (A_0.HasKey(440))
        {
            this.method_500(440, BookmarkStart.b("圸吺洼䴾⹀ⱂ⍄", num), A_0);
        }
        if (A_0.HasKey(0x84))
        {
            this.method_500(0x84, BookmarkStart.b("丸帺弼眾⡀❂⅄≆❈", num), A_0);
        }
        if (A_0.HasKey(330))
        {
            this.method_500(330, BookmarkStart.b("䨸唺尼伾ᕀⱂɄ㕆⁈⽊", num), A_0);
        }
        if (A_0.HasKey(130))
        {
            this.method_500(130, BookmarkStart.b("伸娺匼嘾㉀⭂", num), A_0);
        }
        if (!string.IsNullOrEmpty(A_0.TextThemeColor.method_0()))
        {
            this.class1092_0.method_10(BookmarkStart.b("娸吺儼倾㍀", num), this.dictionary_32[BookmarkStart.b("丸", num)]);
            this.class1092_0.method_6(BookmarkStart.b("丸", num), BookmarkStart.b("䴸区堼刾⑀B⩄⭆♈㥊", num), this.dictionary_32[BookmarkStart.b("丸", num)], A_0.TextThemeColor.method_0());
            if (!string.IsNullOrEmpty(A_0.TextThemeColor.method_2()))
            {
                this.class1092_0.method_6(BookmarkStart.b("丸", num), BookmarkStart.b("䴸区堼刾⑀၂ⵄ♆ⵈ⹊", num), this.dictionary_32[BookmarkStart.b("丸", num)], A_0.TextThemeColor.method_2());
            }
            else if (!string.IsNullOrEmpty(A_0.TextThemeColor.method_4()))
            {
                this.class1092_0.method_6(BookmarkStart.b("丸", num), BookmarkStart.b("䴸区堼刾⑀ᝂⱄ⥆㵈", num), this.dictionary_32[BookmarkStart.b("丸", num)], A_0.TextThemeColor.method_4());
            }
            this.class1092_0.method_12();
        }
        else if (A_0.HasKey(160) || A_0.HasKey(0x59))
        {
            this.class1092_0.method_10(BookmarkStart.b("娸吺儼倾㍀", num), this.dictionary_32[BookmarkStart.b("丸", num)]);
            if ((A_0.TextColor == Color.Empty) && A_0.HasKey(160))
            {
                this.class1092_0.method_6(BookmarkStart.b("丸", num), BookmarkStart.b("伸娺儼", num), this.dictionary_32[BookmarkStart.b("丸", num)], BookmarkStart.b("堸为䤼倾", num));
            }
            else if (A_0.TextColor != Color.Empty)
            {
                this.class1092_0.method_6(BookmarkStart.b("丸", num), BookmarkStart.b("伸娺儼", num), this.dictionary_32[BookmarkStart.b("丸", num)], this.method_535(A_0.TextColor));
            }
            this.class1092_0.method_12();
        }
        if (A_0.HasKey(150))
        {
            this.class1092_0.method_10(BookmarkStart.b("䨸䬺尼尾⡀ⵂ≄", num), this.dictionary_32[BookmarkStart.b("丸", num)]);
            this.class1092_0.method_6(BookmarkStart.b("丸", num), BookmarkStart.b("伸娺儼", num), this.dictionary_32[BookmarkStart.b("丸", num)], this.method_534(A_0.CharacterSpacing * 20f));
            this.class1092_0.method_12();
        }
        if (A_0.HasKey(200))
        {
            this.class1092_0.method_10(BookmarkStart.b("䤸吺丼嘾㕀⩂⩄⥆", num), this.dictionary_32[BookmarkStart.b("丸", num)]);
            this.class1092_0.method_6(BookmarkStart.b("丸", num), BookmarkStart.b("伸娺儼", num), this.dictionary_32[BookmarkStart.b("丸", num)], this.method_534(A_0.Position * 2f));
            this.class1092_0.method_12();
        }
        if (A_0.HasKey(290) && (A_0.TextScale != 100))
        {
            this.class1092_0.method_10(BookmarkStart.b("丸", num), this.dictionary_32[BookmarkStart.b("丸", num)]);
            this.class1092_0.method_6(BookmarkStart.b("丸", num), BookmarkStart.b("伸娺儼", num), this.dictionary_32[BookmarkStart.b("丸", num)], this.method_534((float) A_0.TextScale));
            this.class1092_0.method_12();
        }
        bool flag = false;
        int num3 = 0;
        int count = A_0.XmlProps.Count;
        while (num3 < count)
        {
            XmlNode node2 = A_0.XmlProps[num3];
            if (node2.OuterXml.Contains(BookmarkStart.b("券帺似儾", num)))
            {
                flag = true;
                if (node2.NodeType == XmlNodeType.Element)
                {
                    node2.WriteTo(this.class1092_0.method_0());
                }
            }
            num3++;
        }
        if (A_0.HasKey(310))
        {
            this.class1092_0.method_10(BookmarkStart.b("尸崺嬼娾≀㝂", num), this.dictionary_32[BookmarkStart.b("丸", num)]);
            this.class1092_0.method_6(BookmarkStart.b("丸", num), BookmarkStart.b("伸娺儼", num), this.dictionary_32[BookmarkStart.b("丸", num)], this.method_465(A_0.TextEffect));
            this.class1092_0.method_12();
        }
        if (A_0.HasKey(770))
        {
            this.class1092_0.method_10(BookmarkStart.b("尸嘺", num), this.dictionary_32[BookmarkStart.b("丸", num)]);
            this.class1092_0.method_6(BookmarkStart.b("丸", num), BookmarkStart.b("伸娺儼", num), this.dictionary_32[BookmarkStart.b("丸", num)], this.method_464(A_0.EmphasisVal));
            this.class1092_0.method_12();
        }
        if (A_0.HasKey(220))
        {
            this.class1092_0.method_10(BookmarkStart.b("券帺似儾", num), this.dictionary_32[BookmarkStart.b("丸", num)]);
            this.class1092_0.method_6(BookmarkStart.b("丸", num), BookmarkStart.b("伸娺儼", num), this.dictionary_32[BookmarkStart.b("丸", num)], this.method_534(A_0.Kerning * 2f));
            this.class1092_0.method_12();
        }
        if (A_0.HasKey(190))
        {
            this.class1092_0.method_10(BookmarkStart.b("䨸䄺", num), this.dictionary_32[BookmarkStart.b("丸", num)]);
            this.class1092_0.method_6(BookmarkStart.b("丸", num), BookmarkStart.b("伸娺儼", num), this.dictionary_32[BookmarkStart.b("丸", num)], this.method_534(A_0.FontSize * 2f));
            this.class1092_0.method_12();
        }
        if (A_0.HasKey(350))
        {
            this.class1092_0.method_10(BookmarkStart.b("䨸䄺縼䰾", num), this.dictionary_32[BookmarkStart.b("丸", num)]);
            this.class1092_0.method_6(BookmarkStart.b("丸", num), BookmarkStart.b("伸娺儼", num), this.dictionary_32[BookmarkStart.b("丸", num)], this.method_534(A_0.FontSizeBidi * 2f));
            this.class1092_0.method_12();
        }
        if (A_0.HasKey(20) && (A_0.HighlightColor != Color.Empty))
        {
            this.class1092_0.method_10(BookmarkStart.b("儸刺娼圾ⵀ⩂≄⽆㵈", num), this.dictionary_32[BookmarkStart.b("丸", num)]);
            this.class1092_0.method_6(BookmarkStart.b("丸", num), BookmarkStart.b("伸娺儼", num), this.dictionary_32[BookmarkStart.b("丸", num)], this.method_533(A_0.HighlightColor));
            this.class1092_0.method_12();
        }
        if (A_0.HasKey(140))
        {
            this.class1092_0.method_10(BookmarkStart.b("䰸", num), this.dictionary_32[BookmarkStart.b("丸", num)]);
            this.class1092_0.method_6(BookmarkStart.b("丸", num), BookmarkStart.b("伸娺儼", num), this.dictionary_32[BookmarkStart.b("丸", num)], this.method_531(A_0.UnderlineStyle));
            if (A_0.HasKey(450) && (A_0.UnderlineColor != Color.Empty))
            {
                this.class1092_0.method_6(BookmarkStart.b("丸", num), BookmarkStart.b("娸吺儼倾㍀", num), this.dictionary_32[BookmarkStart.b("丸", num)], this.method_535(A_0.UnderlineColor));
            }
            this.class1092_0.method_12();
        }
        if ((A_0.Border.BorderType != BorderStyle.None) || A_0.Border.IsChanged)
        {
            this.method_496(A_0.Border, BookmarkStart.b("嬸强似", num), 8);
        }
        if (!A_0.Shading.IsDefault)
        {
            this.method_471(A_0);
        }
        if (A_0.HasKey(210))
        {
            this.class1092_0.method_10(BookmarkStart.b("伸帺似䬾@⽂ⱄ⁆❈", num), this.dictionary_32[BookmarkStart.b("丸", num)]);
            switch (A_0.SubSuperScript)
            {
                case SubSuperScript.SuperScript:
                    this.class1092_0.method_6(BookmarkStart.b("丸", num), BookmarkStart.b("伸娺儼", num), this.dictionary_32[BookmarkStart.b("丸", num)], BookmarkStart.b("䨸为䴼娾㍀あ♄㕆⁈㭊㥌", num));
                    break;

                case SubSuperScript.SubScript:
                    this.class1092_0.method_6(BookmarkStart.b("丸", num), BookmarkStart.b("伸娺儼", num), this.dictionary_32[BookmarkStart.b("丸", num)], BookmarkStart.b("䨸为弼䰾≀ㅂⱄ㝆㵈", num));
                    break;

                default:
                    this.class1092_0.method_6(BookmarkStart.b("丸", num), BookmarkStart.b("伸娺儼", num), this.dictionary_32[BookmarkStart.b("丸", num)], BookmarkStart.b("嬸娺丼娾ⵀ⩂⭄≆", num));
                    break;
            }
            this.class1092_0.method_12();
        }
        if (A_0.HasKey(0x109))
        {
            this.method_500(0x109, BookmarkStart.b("䬸伺儼", num), A_0);
        }
        if (A_0.HasKey(380) || A_0.HasKey(390))
        {
            this.method_497(A_0);
        }
        this.method_466(A_0);
        this.method_467(A_0);
        this.method_468(A_0);
        this.method_469(A_0);
        this.method_470(A_0);
        if (A_0.IsChangedFormat)
        {
            this.method_482(A_0);
        }
        int num2 = 0;
        int num5 = A_0.XmlProps.Count;
        while (num2 < num5)
        {
            XmlNode node = A_0.XmlProps[num2];
            if ((!node.OuterXml.Contains(BookmarkStart.b("券帺似儾", num)) || !flag) && (node.NodeType == XmlNodeType.Element))
            {
                node.WriteTo(this.class1092_0.method_0());
            }
            num2++;
        }
        this.class1092_0.method_12();
    }

    private string method_464(Emphasis A_0)
    {
        int num = 6;
        switch (A_0)
        {
            case Emphasis.Dot:
                return BookmarkStart.b("䠫䄭䐯", num);

            case Emphasis.CommaAbove:
                return BookmarkStart.b("伫䄭崯弱唳", num);

            case Emphasis.CircleAbove:
                return BookmarkStart.b("伫䜭䈯儱堳匵", num);

            case Emphasis.DotBelow:
                return BookmarkStart.b("夫䀭启圱䘳爵圷丹", num);
        }
        return BookmarkStart.b("䈫䄭帯圱", num);
    }

    private string method_465(TextEffect A_0)
    {
        int num = 6;
        switch (A_0)
        {
            case TextEffect.LasVegasLights:
                return BookmarkStart.b("䀫䜭圯娱䀳䔵", num);

            case TextEffect.BlinkingBackground:
                return BookmarkStart.b("丫䈭夯就弳琵夷夹圻夽㈿ⵁㅃ⡅ⱇ", num);

            case TextEffect.SparkleText:
                return BookmarkStart.b("弫席儯䀱弳娵崷", num);

            case TextEffect.MarchingBlackAnts:
                return BookmarkStart.b("䴫䀭䐯䄱瘳娵夷夹圻", num);

            case TextEffect.MarchingRedAnts:
                return BookmarkStart.b("䴫䀭䐯䄱昳匵尷", num);

            case TextEffect.Shimmer:
                return BookmarkStart.b("弫䘭夯弱夳匵䨷", num);
        }
        return BookmarkStart.b("䈫䄭帯圱", num);
    }

    private void method_466(CharacterFormat A_0)
    {
        int num = 0x12;
        if (A_0.HasKey(0x79))
        {
            this.class1092_0.method_10(BookmarkStart.b("吷匹嬻弽㐿㝁㙃⍅㭇", num), this.dictionary_32[BookmarkStart.b("伷ହ࠻", num)]);
            switch (A_0.LigaturesType)
            {
                case LigatureType.None:
                    this.class1092_0.method_6(BookmarkStart.b("伷ହ࠻", num), BookmarkStart.b("丷嬹倻", num), this.dictionary_32[BookmarkStart.b("伷ହ࠻", num)], BookmarkStart.b("嘷唹刻嬽", num));
                    break;

                case LigatureType.Standard:
                    this.class1092_0.method_6(BookmarkStart.b("伷ହ࠻", num), BookmarkStart.b("丷嬹倻", num), this.dictionary_32[BookmarkStart.b("伷ହ࠻", num)], BookmarkStart.b("䬷丹崻倽␿⍁㙃≅", num));
                    break;

                case LigatureType.Contextual:
                    this.class1092_0.method_6(BookmarkStart.b("伷ହ࠻", num), BookmarkStart.b("丷嬹倻", num), this.dictionary_32[BookmarkStart.b("伷ହ࠻", num)], BookmarkStart.b("嬷唹刻䨽┿㩁ぃ㍅⥇♉", num));
                    break;

                case LigatureType.DefaultContextual:
                    this.class1092_0.method_6(BookmarkStart.b("伷ହ࠻", num), BookmarkStart.b("丷嬹倻", num), this.dictionary_32[BookmarkStart.b("伷ହ࠻", num)], BookmarkStart.b("䬷丹崻倽␿⍁㙃≅େ╉≋㩍㕏⩑⁓⍕㥗㙙", num));
                    break;

                case LigatureType.Historical:
                    this.class1092_0.method_6(BookmarkStart.b("伷ହ࠻", num), BookmarkStart.b("丷嬹倻", num), this.dictionary_32[BookmarkStart.b("伷ହ࠻", num)], BookmarkStart.b("倷匹伻䨽⼿ぁⵃ╅⥇♉", num));
                    break;

                case LigatureType.DefaultHistorical:
                    this.class1092_0.method_6(BookmarkStart.b("伷ହ࠻", num), BookmarkStart.b("丷嬹倻", num), this.dictionary_32[BookmarkStart.b("伷ହ࠻", num)], BookmarkStart.b("䬷丹崻倽␿⍁㙃≅G⍉㽋㩍㽏⁑㵓㕕㥗㙙", num));
                    break;

                case LigatureType.ContextualHistorical:
                    this.class1092_0.method_6(BookmarkStart.b("伷ହ࠻", num), BookmarkStart.b("丷嬹倻", num), this.dictionary_32[BookmarkStart.b("伷ହ࠻", num)], BookmarkStart.b("嬷唹刻䨽┿㩁ぃ㍅⥇♉ы❍⍏♑㭓⑕ㅗ㥙㵛㉝", num));
                    break;

                case LigatureType.DefaultContextualHistorical:
                    this.class1092_0.method_6(BookmarkStart.b("伷ହ࠻", num), BookmarkStart.b("丷嬹倻", num), this.dictionary_32[BookmarkStart.b("伷ହ࠻", num)], BookmarkStart.b("䬷丹崻倽␿⍁㙃≅େ╉≋㩍㕏⩑⁓⍕㥗㙙ᑛ㝝፟ᙡୣᑥŧ३൫ɭ", num));
                    break;

                case LigatureType.Discretional:
                    this.class1092_0.method_6(BookmarkStart.b("伷ହ࠻", num), BookmarkStart.b("丷嬹倻", num), this.dictionary_32[BookmarkStart.b("伷ହ࠻", num)], BookmarkStart.b("尷匹伻崽㈿❁ぃ⽅❇⑉ⵋ≍", num));
                    break;

                case LigatureType.DefaultDiscretional:
                    this.class1092_0.method_6(BookmarkStart.b("伷ହ࠻", num), BookmarkStart.b("丷嬹倻", num), this.dictionary_32[BookmarkStart.b("伷ହ࠻", num)], BookmarkStart.b("䬷丹崻倽␿⍁㙃≅ే⍉㽋ⵍ≏㝑⁓㽕㝗㑙㵛㉝", num));
                    break;

                case LigatureType.ContextualDiscretional:
                    this.class1092_0.method_6(BookmarkStart.b("伷ହ࠻", num), BookmarkStart.b("丷嬹倻", num), this.dictionary_32[BookmarkStart.b("伷ହ࠻", num)], BookmarkStart.b("嬷唹刻䨽┿㩁ぃ㍅⥇♉ࡋ❍⍏ㅑ♓㍕ⱗ㍙㍛そş๡", num));
                    break;

                case LigatureType.DefaultContextualDiscretional:
                    this.class1092_0.method_6(BookmarkStart.b("伷ହ࠻", num), BookmarkStart.b("丷嬹倻", num), this.dictionary_32[BookmarkStart.b("伷ହ࠻", num)], BookmarkStart.b("䬷丹崻倽␿⍁㙃≅େ╉≋㩍㕏⩑⁓⍕㥗㙙ᡛ㝝፟šᙣͥᱧͩͫmᅯṱ", num));
                    break;

                case LigatureType.HistoricalDiscretional:
                    this.class1092_0.method_6(BookmarkStart.b("伷ହ࠻", num), BookmarkStart.b("丷嬹倻", num), this.dictionary_32[BookmarkStart.b("伷ହ࠻", num)], BookmarkStart.b("倷匹伻䨽⼿ぁⵃ╅⥇♉ࡋ❍⍏ㅑ♓㍕ⱗ㍙㍛そş๡", num));
                    break;

                case LigatureType.DefaultHistoricalDiscretional:
                    this.class1092_0.method_6(BookmarkStart.b("伷ହ࠻", num), BookmarkStart.b("丷嬹倻", num), this.dictionary_32[BookmarkStart.b("伷ହ࠻", num)], BookmarkStart.b("䬷丹崻倽␿⍁㙃≅G⍉㽋㩍㽏⁑㵓㕕㥗㙙ᡛ㝝፟šᙣͥᱧͩͫmᅯṱ", num));
                    break;

                case LigatureType.ContextualHistoricalDiscretional:
                    this.class1092_0.method_6(BookmarkStart.b("伷ହ࠻", num), BookmarkStart.b("丷嬹倻", num), this.dictionary_32[BookmarkStart.b("伷ହ࠻", num)], BookmarkStart.b("嬷唹刻䨽┿㩁ぃ㍅⥇♉ы❍⍏♑㭓⑕ㅗ㥙㵛㉝⑟ୡᝣեᩧཀྵᡫݭὯᱱᕳ᩵", num));
                    break;

                case LigatureType.All:
                    this.class1092_0.method_6(BookmarkStart.b("伷ହ࠻", num), BookmarkStart.b("丷嬹倻", num), this.dictionary_32[BookmarkStart.b("伷ହ࠻", num)], BookmarkStart.b("夷嘹倻", num));
                    break;
            }
            this.class1092_0.method_12();
        }
    }

    private void method_467(CharacterFormat A_0)
    {
        int num = 0x12;
        if (A_0.HasKey(0x7a))
        {
            this.class1092_0.method_10(BookmarkStart.b("嘷伹儻砽⼿ぁ⥃", num), this.dictionary_32[BookmarkStart.b("伷ହ࠻", num)]);
            switch (A_0.NumberFormType)
            {
                case NumberFormType.Default:
                    this.class1092_0.method_6(BookmarkStart.b("伷ହ࠻", num), BookmarkStart.b("丷嬹倻", num), this.dictionary_32[BookmarkStart.b("伷ହ࠻", num)], BookmarkStart.b("尷弹娻弽㔿⹁ぃ", num));
                    break;

                case NumberFormType.Lining:
                    this.class1092_0.method_6(BookmarkStart.b("伷ହ࠻", num), BookmarkStart.b("丷嬹倻", num), this.dictionary_32[BookmarkStart.b("伷ହ࠻", num)], BookmarkStart.b("吷匹刻圽⸿╁", num));
                    break;

                case NumberFormType.Old:
                    this.class1092_0.method_6(BookmarkStart.b("伷ହ࠻", num), BookmarkStart.b("丷嬹倻", num), this.dictionary_32[BookmarkStart.b("伷ହ࠻", num)], BookmarkStart.b("圷嘹堻洽㐿㭁⡃⍅", num));
                    break;
            }
            this.class1092_0.method_12();
        }
    }

    private void method_468(CharacterFormat A_0)
    {
        int num = 9;
        if (A_0.HasKey(0x7b))
        {
            this.class1092_0.method_10(BookmarkStart.b("䄮䐰帲昴䜶堸堺吼儾♀", num), this.dictionary_32[BookmarkStart.b("堮0ܲ", num)]);
            switch (A_0.NumberSpaceType)
            {
                case NumberSpaceType.Default:
                    this.class1092_0.method_6(BookmarkStart.b("堮0ܲ", num), BookmarkStart.b("央倰弲", num), this.dictionary_32[BookmarkStart.b("堮0ܲ", num)], BookmarkStart.b("䬮吰唲吴䈶唸伺", num));
                    break;

                case NumberSpaceType.Proportional:
                    this.class1092_0.method_6(BookmarkStart.b("堮0ܲ", num), BookmarkStart.b("央倰弲", num), this.dictionary_32[BookmarkStart.b("堮0ܲ", num)], BookmarkStart.b("弮䌰尲䔴堶䬸伺吼倾⽀≂⥄", num));
                    break;

                case NumberSpaceType.Tabular:
                    this.class1092_0.method_6(BookmarkStart.b("堮0ܲ", num), BookmarkStart.b("央倰弲", num), this.dictionary_32[BookmarkStart.b("堮0ܲ", num)], BookmarkStart.b("嬮倰儲䀴嬶堸䤺", num));
                    break;
            }
            this.class1092_0.method_12();
        }
    }

    private void method_469(CharacterFormat A_0)
    {
        int num = 9;
        if (A_0.HasKey(0x7c))
        {
            this.class1092_0.method_10(BookmarkStart.b("尮䔰䨲头帶䨸伺吼尾ቀ♂ㅄ㑆", num), this.dictionary_32[BookmarkStart.b("堮0ܲ", num)]);
            this.class1092_0.method_10(BookmarkStart.b("尮䔰䨲头制樸帺䤼", num), this.dictionary_32[BookmarkStart.b("堮0ܲ", num)]);
            switch (A_0.StylisticSetType)
            {
                case StylisticSetType.Default:
                    this.class1092_0.method_6(BookmarkStart.b("堮0ܲ", num), BookmarkStart.b("䘮唰", num), this.dictionary_32[BookmarkStart.b("堮0ܲ", num)], BookmarkStart.b("Ἦ", num));
                    break;

                case StylisticSetType.StylisticSet01:
                    this.class1092_0.method_6(BookmarkStart.b("堮0ܲ", num), BookmarkStart.b("䘮唰", num), this.dictionary_32[BookmarkStart.b("堮0ܲ", num)], BookmarkStart.b("Ḯ", num));
                    break;

                case StylisticSetType.StylisticSet02:
                    this.class1092_0.method_6(BookmarkStart.b("堮0ܲ", num), BookmarkStart.b("䘮唰", num), this.dictionary_32[BookmarkStart.b("堮0ܲ", num)], BookmarkStart.b("ᴮ", num));
                    break;

                case StylisticSetType.StylisticSet03:
                    this.class1092_0.method_6(BookmarkStart.b("堮0ܲ", num), BookmarkStart.b("䘮唰", num), this.dictionary_32[BookmarkStart.b("堮0ܲ", num)], BookmarkStart.b("ᰮ", num));
                    break;

                case StylisticSetType.StylisticSet04:
                    this.class1092_0.method_6(BookmarkStart.b("堮0ܲ", num), BookmarkStart.b("䘮唰", num), this.dictionary_32[BookmarkStart.b("堮0ܲ", num)], BookmarkStart.b("ᬮ", num));
                    break;

                case StylisticSetType.StylisticSet05:
                    this.class1092_0.method_6(BookmarkStart.b("堮0ܲ", num), BookmarkStart.b("䘮唰", num), this.dictionary_32[BookmarkStart.b("堮0ܲ", num)], BookmarkStart.b("ᨮ", num));
                    break;

                case StylisticSetType.StylisticSet06:
                    this.class1092_0.method_6(BookmarkStart.b("堮0ܲ", num), BookmarkStart.b("䘮唰", num), this.dictionary_32[BookmarkStart.b("堮0ܲ", num)], BookmarkStart.b("᤮", num));
                    break;

                case StylisticSetType.StylisticSet07:
                    this.class1092_0.method_6(BookmarkStart.b("堮0ܲ", num), BookmarkStart.b("䘮唰", num), this.dictionary_32[BookmarkStart.b("堮0ܲ", num)], BookmarkStart.b("ᠮ", num));
                    break;

                case StylisticSetType.StylisticSet08:
                    this.class1092_0.method_6(BookmarkStart.b("堮0ܲ", num), BookmarkStart.b("䘮唰", num), this.dictionary_32[BookmarkStart.b("堮0ܲ", num)], BookmarkStart.b("ᜮ", num));
                    break;

                case StylisticSetType.StylisticSet09:
                    this.class1092_0.method_6(BookmarkStart.b("堮0ܲ", num), BookmarkStart.b("䘮唰", num), this.dictionary_32[BookmarkStart.b("堮0ܲ", num)], BookmarkStart.b("ᘮ", num));
                    break;

                case StylisticSetType.StylisticSet10:
                    this.class1092_0.method_6(BookmarkStart.b("堮0ܲ", num), BookmarkStart.b("䘮唰", num), this.dictionary_32[BookmarkStart.b("堮0ܲ", num)], BookmarkStart.b("Ḯİ", num));
                    break;

                case StylisticSetType.StylisticSet11:
                    this.class1092_0.method_6(BookmarkStart.b("堮0ܲ", num), BookmarkStart.b("䘮唰", num), this.dictionary_32[BookmarkStart.b("堮0ܲ", num)], BookmarkStart.b("Ḯ0", num));
                    break;

                case StylisticSetType.StylisticSet12:
                    this.class1092_0.method_6(BookmarkStart.b("堮0ܲ", num), BookmarkStart.b("䘮唰", num), this.dictionary_32[BookmarkStart.b("堮0ܲ", num)], BookmarkStart.b("Ḭ̈́", num));
                    break;

                case StylisticSetType.StylisticSet13:
                    this.class1092_0.method_6(BookmarkStart.b("堮0ܲ", num), BookmarkStart.b("䘮唰", num), this.dictionary_32[BookmarkStart.b("堮0ܲ", num)], BookmarkStart.b("ḮȰ", num));
                    break;

                case StylisticSetType.StylisticSet14:
                    this.class1092_0.method_6(BookmarkStart.b("堮0ܲ", num), BookmarkStart.b("䘮唰", num), this.dictionary_32[BookmarkStart.b("堮0ܲ", num)], BookmarkStart.b("Ḯ԰", num));
                    break;

                case StylisticSetType.StylisticSet15:
                    this.class1092_0.method_6(BookmarkStart.b("堮0ܲ", num), BookmarkStart.b("䘮唰", num), this.dictionary_32[BookmarkStart.b("堮0ܲ", num)], BookmarkStart.b("Ḯа", num));
                    break;

                case StylisticSetType.StylisticSet16:
                    this.class1092_0.method_6(BookmarkStart.b("堮0ܲ", num), BookmarkStart.b("䘮唰", num), this.dictionary_32[BookmarkStart.b("堮0ܲ", num)], BookmarkStart.b("Ḯܰ", num));
                    break;

                case StylisticSetType.StylisticSet17:
                    this.class1092_0.method_6(BookmarkStart.b("堮0ܲ", num), BookmarkStart.b("䘮唰", num), this.dictionary_32[BookmarkStart.b("堮0ܲ", num)], BookmarkStart.b("Ḯذ", num));
                    break;

                case StylisticSetType.StylisticSet18:
                    this.class1092_0.method_6(BookmarkStart.b("堮0ܲ", num), BookmarkStart.b("䘮唰", num), this.dictionary_32[BookmarkStart.b("堮0ܲ", num)], BookmarkStart.b("Ḯर", num));
                    break;

                case StylisticSetType.StylisticSet19:
                    this.class1092_0.method_6(BookmarkStart.b("堮0ܲ", num), BookmarkStart.b("䘮唰", num), this.dictionary_32[BookmarkStart.b("堮0ܲ", num)], BookmarkStart.b("Ḯ࠰", num));
                    break;

                case StylisticSetType.StylisticSet20:
                    this.class1092_0.method_6(BookmarkStart.b("堮0ܲ", num), BookmarkStart.b("䘮唰", num), this.dictionary_32[BookmarkStart.b("堮0ܲ", num)], BookmarkStart.b("ᴮİ", num));
                    break;
            }
            this.class1092_0.method_12();
            this.class1092_0.method_12();
        }
    }

    private Stack<Field> method_47()
    {
        if (this.stack_1 == null)
        {
            this.stack_1 = new Stack<Field>();
        }
        return this.stack_1;
    }

    private void method_470(CharacterFormat A_0)
    {
        int num = 6;
        if (A_0.HasKey(0x36))
        {
            this.class1092_0.method_10(BookmarkStart.b("伫䀭䐯䨱䀳眵吷丹伻", num), this.dictionary_32[BookmarkStart.b("嬫ἭЯ", num)]);
            if (!A_0.AllowContextualAlternates)
            {
                this.class1092_0.method_6(BookmarkStart.b("嬫ἭЯ", num), BookmarkStart.b("娫伭尯", num), this.dictionary_32[BookmarkStart.b("嬫ἭЯ", num)], BookmarkStart.b("䨫伭尯䄱儳", num));
            }
            this.class1092_0.method_12();
        }
    }

    private void method_471(CharacterFormat A_0)
    {
        int num = 0x11;
        this.class1092_0.method_10(BookmarkStart.b("䐶儸强", 0x11), this.dictionary_32[BookmarkStart.b("䀶", 0x11)]);
        this.class1092_0.method_6(BookmarkStart.b("䀶", 0x11), BookmarkStart.b("䄶堸场", 0x11), this.dictionary_32[BookmarkStart.b("䀶", 0x11)], this.method_529(A_0.TextureStyle));
        if (A_0.ForeColor != Color.Empty)
        {
            this.class1092_0.method_5(BookmarkStart.b("吶嘸场刼䴾", num), this.dictionary_32[BookmarkStart.b("䀶", num)], this.method_535(A_0.ForeColor));
        }
        else if ((A_0.ForeColor == Color.Empty) && A_0.HasKey(6))
        {
            this.class1092_0.method_5(BookmarkStart.b("吶嘸场刼䴾", num), this.dictionary_32[BookmarkStart.b("䀶", num)], BookmarkStart.b("嘶䰸伺刼", num));
        }
        if (A_0.TextBackgroundColor != Color.Empty)
        {
            this.class1092_0.method_5(BookmarkStart.b("儶倸场儼", num), this.dictionary_32[BookmarkStart.b("䀶", num)], this.method_535(A_0.TextBackgroundColor));
        }
        else if ((A_0.TextBackgroundColor == Color.Empty) && A_0.HasKey(9))
        {
            this.class1092_0.method_5(BookmarkStart.b("儶倸场儼", num), this.dictionary_32[BookmarkStart.b("䀶", num)], BookmarkStart.b("嘶䰸伺刼", num));
        }
        this.class1092_0.method_12();
    }

    private void method_472(ParagraphFormat A_0, Paragraph A_1)
    {
        this.method_473(A_0, A_1, false);
    }

    private void method_473(ParagraphFormat A_0, Paragraph A_1, bool A_2)
    {
        int num = 12;
        IParagraphStyle ownerBase = null;
        if ((A_1 != null) || (A_2 && (A_0.BaseFormat != null)))
        {
            if (A_2)
            {
                ownerBase = A_0.BaseFormat.OwnerBase as IParagraphStyle;
            }
            else
            {
                ownerBase = A_1.GetStyle();
            }
            if ((ownerBase != null) && (ownerBase.Name != BookmarkStart.b("簱嬳䐵唷嬹倻", num)))
            {
                Dictionary<string, string> styleNameIds = this.document_0.StyleNameIds;
                if (styleNameIds.ContainsValue(ownerBase.Name))
                {
                    using (Dictionary<string, string>.KeyCollection.Enumerator enumerator = styleNameIds.Keys.GetEnumerator())
                    {
                        string current;
                        while (enumerator.MoveNext())
                        {
                            current = enumerator.Current;
                            if ((styleNameIds[current] == ownerBase.Name) && ((current == ownerBase.StyleId) || (styleNameIds[current].Replace(BookmarkStart.b("ሱ", num), string.Empty) == ownerBase.StyleId)))
                            {
                                goto Label_00E9;
                            }
                        }
                        goto Label_020E;
                    Label_00E9:
                        this.class1092_0.method_10(BookmarkStart.b("䈱朳䈵䄷嘹夻", num), this.dictionary_32[BookmarkStart.b("䔱", num)]);
                        this.class1092_0.method_6(BookmarkStart.b("䔱", num), BookmarkStart.b("䐱唳娵", num), this.dictionary_32[BookmarkStart.b("䔱", num)], current);
                        this.class1092_0.method_12();
                        goto Label_020E;
                    }
                }
                this.class1092_0.method_10(BookmarkStart.b("䈱朳䈵䄷嘹夻", num), this.dictionary_32[BookmarkStart.b("䔱", num)]);
                string str3 = !string.IsNullOrEmpty(ownerBase.StyleId) ? ownerBase.StyleId : ownerBase.Name;
                this.class1092_0.method_6(BookmarkStart.b("䔱", num), BookmarkStart.b("䐱唳娵", num), this.dictionary_32[BookmarkStart.b("䔱", num)], str3.Replace(BookmarkStart.b("ሱ", num), string.Empty));
                this.class1092_0.method_12();
            }
        }
    Label_020E:
        if (((A_1 != null) && A_1.IsInCell) && this.bool_13)
        {
            this.bool_13 = false;
            this.method_158(A_1);
        }
        if (A_0.HasValue(0x5b5))
        {
            this.class1092_0.method_10(BookmarkStart.b("嘱崳䀵焷帹", num), this.dictionary_32[BookmarkStart.b("䔱", num)]);
            this.class1092_0.method_6(BookmarkStart.b("䔱", num), BookmarkStart.b("䐱唳娵", num), this.dictionary_32[BookmarkStart.b("䔱", num)], A_0.DivId.ToString());
            this.class1092_0.method_12();
        }
        if (A_0.HasKey(0x41a))
        {
            this.class1092_0.method_10(BookmarkStart.b("失儳匵䠷琹夻䘽㐿", num), this.dictionary_32[BookmarkStart.b("䔱", num)]);
            if (!A_0.KeepFollow)
            {
                this.class1092_0.method_6(BookmarkStart.b("䔱", num), BookmarkStart.b("䐱唳娵", num), this.dictionary_32[BookmarkStart.b("䔱", num)], BookmarkStart.b("ȱ", num));
            }
            this.class1092_0.method_12();
        }
        if (A_0.HasKey(0x410))
        {
            this.class1092_0.method_10(BookmarkStart.b("失儳匵䠷瘹唻倽┿ㅁ", num), this.dictionary_32[BookmarkStart.b("䔱", num)]);
            if (!A_0.KeepLines)
            {
                this.class1092_0.method_6(BookmarkStart.b("䔱", num), BookmarkStart.b("䐱唳娵", num), this.dictionary_32[BookmarkStart.b("䔱", num)], BookmarkStart.b("ȱ", num));
            }
            this.class1092_0.method_12();
        }
        if (A_0.HasKey(0x442) && !A_0.OverflowPunc)
        {
            this.class1092_0.method_10(BookmarkStart.b("崱䈳匵䨷尹倻儽㜿ቁㅃ⡅⭇㹉", num), this.dictionary_32[BookmarkStart.b("䔱", num)]);
            this.class1092_0.method_6(BookmarkStart.b("䔱", num), BookmarkStart.b("䐱唳娵", num), this.dictionary_32[BookmarkStart.b("䔱", num)], BookmarkStart.b("ȱ", num));
            this.class1092_0.method_12();
        }
        if (A_0.HasKey(0x424))
        {
            this.class1092_0.method_10(BookmarkStart.b("䈱唳儵崷砹主嬽ℿ⥁ك⍅⹇╉㹋⭍", num), this.dictionary_32[BookmarkStart.b("䔱", num)]);
            if (!A_0.PageBreakBefore)
            {
                this.class1092_0.method_6(BookmarkStart.b("䔱", num), BookmarkStart.b("䐱唳娵", num), this.dictionary_32[BookmarkStart.b("䔱", num)], BookmarkStart.b("ȱ", num));
            }
            this.class1092_0.method_12();
        }
        if (!A_0.Frame.IsDefault)
        {
            this.method_494(A_0);
        }
        else if ((((A_1 != null) && (A_1.ParaStyle != null)) && ((A_1.ParaStyle.ParagraphFormat != null) && A_1.ParaStyle.ParagraphFormat.IsFrame)) && ((!A_0.IsFrame && A_1.IsInCell) && ((A_1.OwnerTextBody.Owner.Owner is Table) && !(A_1.OwnerTextBody.Owner.Owner as Table).IsFrame)))
        {
            this.method_495(A_0, true);
        }
        if (A_0.HasKey(0x438) && A_0.WordWrap)
        {
            this.class1092_0.method_10(BookmarkStart.b("䔱嬳䐵尷洹主弽〿", num), this.dictionary_32[BookmarkStart.b("䔱", num)]);
            this.class1092_0.method_12();
        }
        if (A_0.HasKey(0x44c) && A_0.TopLinePunctuation)
        {
            this.class1092_0.method_10(BookmarkStart.b("䘱嬳䘵琷匹刻嬽ဿ㝁⩃╅㱇", num), this.dictionary_32[BookmarkStart.b("䔱", num)]);
            this.class1092_0.method_12();
        }
        if (A_0.HasKey(0x46a) && A_0.SuppressLineNumbers)
        {
            this.class1092_0.method_10(BookmarkStart.b("䄱䄳䘵䠷䠹夻䴽㌿แⵃ⡅ⵇщ㥋⍍㉏㝑♓╕", num), this.dictionary_32[BookmarkStart.b("䔱", num)]);
            this.class1092_0.method_12();
        }
        if (A_0.HasKey(0x67c) && A_0.FrameSuppressOverlap)
        {
            this.class1092_0.method_10(BookmarkStart.b("䄱䄳䘵䠷䠹夻䴽㌿ു㉃⍅㩇♉ⵋ㹍", num), this.dictionary_32[BookmarkStart.b("䔱", num)]);
            this.class1092_0.method_12();
        }
        if (A_0.HasKey(0x5be))
        {
            this.class1092_0.method_10(BookmarkStart.b("䔱崳刵圷䴹缻儽⸿㙁㙃⥅⑇", num), this.dictionary_32[BookmarkStart.b("䔱", num)]);
            if (A_0.IsWidowControl)
            {
                this.class1092_0.method_6(BookmarkStart.b("䔱", num), BookmarkStart.b("䐱唳娵", num), this.dictionary_32[BookmarkStart.b("䔱", num)], BookmarkStart.b("̱", num));
            }
            else
            {
                this.class1092_0.method_6(BookmarkStart.b("䔱", num), BookmarkStart.b("䐱唳娵", num), this.dictionary_32[BookmarkStart.b("䔱", num)], BookmarkStart.b("ȱ", num));
            }
            this.class1092_0.method_12();
        }
        if (A_0.HasKey(0x4d8))
        {
            this.class1092_0.method_10(BookmarkStart.b("匱䄳䈵圷椹䰻弽⌿❁Cͅ", num), this.dictionary_32[BookmarkStart.b("䔱", num)]);
            if (A_0.AutoSpaceDE)
            {
                this.class1092_0.method_6(BookmarkStart.b("䔱", num), BookmarkStart.b("䐱唳娵", num), this.dictionary_32[BookmarkStart.b("䔱", num)], BookmarkStart.b("̱", num));
            }
            else
            {
                this.class1092_0.method_6(BookmarkStart.b("䔱", num), BookmarkStart.b("䐱唳娵", num), this.dictionary_32[BookmarkStart.b("䔱", num)], BookmarkStart.b("ȱ", num));
            }
            this.class1092_0.method_12();
        }
        if (A_0.HasKey(0x4e2))
        {
            this.class1092_0.method_10(BookmarkStart.b("匱䄳䈵圷椹䰻弽⌿❁Cࡅ", num), this.dictionary_32[BookmarkStart.b("䔱", num)]);
            if (A_0.AutoSpaceDN)
            {
                this.class1092_0.method_6(BookmarkStart.b("䔱", num), BookmarkStart.b("䐱唳娵", num), this.dictionary_32[BookmarkStart.b("䔱", num)], BookmarkStart.b("̱", num));
            }
            else
            {
                this.class1092_0.method_6(BookmarkStart.b("䔱", num), BookmarkStart.b("䐱唳娵", num), this.dictionary_32[BookmarkStart.b("䔱", num)], BookmarkStart.b("ȱ", num));
            }
            this.class1092_0.method_12();
        }
        if (A_0.HasKey(0x4f6))
        {
            this.class1092_0.method_10(BookmarkStart.b("匱倳尵䴷䤹䠻氽⤿╁ⱃ㉅Ň⑉⡋", num), this.dictionary_32[BookmarkStart.b("䔱", num)]);
            if (A_0.AdjustRightIndent)
            {
                this.class1092_0.method_6(BookmarkStart.b("䔱", num), BookmarkStart.b("䐱唳娵", num), this.dictionary_32[BookmarkStart.b("䔱", num)], BookmarkStart.b("̱", num));
            }
            else
            {
                this.class1092_0.method_6(BookmarkStart.b("䔱", num), BookmarkStart.b("䐱唳娵", num), this.dictionary_32[BookmarkStart.b("䔱", num)], BookmarkStart.b("ȱ", num));
            }
            this.class1092_0.method_12();
        }
        if (A_0.HasKey(0x4ec))
        {
            this.class1092_0.method_10(BookmarkStart.b("䄱娳圵䠷渹医礽㈿⭁⁃", num), this.dictionary_32[BookmarkStart.b("䔱", num)]);
            if (A_0.SnapToGrid)
            {
                this.class1092_0.method_6(BookmarkStart.b("䔱", num), BookmarkStart.b("䐱唳娵", num), this.dictionary_32[BookmarkStart.b("䔱", num)], BookmarkStart.b("̱", num));
            }
            else
            {
                this.class1092_0.method_6(BookmarkStart.b("䔱", num), BookmarkStart.b("䐱唳娵", num), this.dictionary_32[BookmarkStart.b("䔱", num)], BookmarkStart.b("ȱ", num));
            }
            this.class1092_0.method_12();
        }
        if (A_0.TextAlignment != TextAlignment.Auto)
        {
            this.class1092_0.method_10(BookmarkStart.b("䘱儳丵䰷笹倻圽✿ⱁ⥃⍅♇㹉", num), this.dictionary_32[BookmarkStart.b("䔱", num)]);
            this.class1092_0.method_6(BookmarkStart.b("䔱", num), BookmarkStart.b("䐱唳娵", num), this.dictionary_32[BookmarkStart.b("䔱", num)], A_0.TextAlignment.ToString().ToLower());
            this.class1092_0.method_12();
        }
        this.method_492(A_1);
        this.method_491(A_0, 8);
        this.method_490(A_0);
        this.method_488(A_0);
        if (A_0.HasKey(0x618))
        {
            this.class1092_0.method_10(BookmarkStart.b("倱崳刵儷", num), this.dictionary_32[BookmarkStart.b("䔱", num)]);
            if (!A_0.IsBidi)
            {
                this.class1092_0.method_6(BookmarkStart.b("䔱", num), BookmarkStart.b("䐱唳娵", num), this.dictionary_32[BookmarkStart.b("䔱", num)], A_0.IsBidi.ToString().ToLower());
            }
            this.class1092_0.method_12();
        }
        this.method_487(A_0);
        this.method_486(A_0);
        if (A_0.HasKey(0x3fe) && A_0.IsContextualSpacing)
        {
            this.class1092_0.method_10(BookmarkStart.b("儱嬳堵䰷弹䐻䨽㔿⍁⡃ᕅ㡇⭉⽋❍㹏㕑", num), this.dictionary_32[BookmarkStart.b("䔱", num)]);
            if (!A_0.IsContextualSpacing)
            {
                this.class1092_0.method_6(BookmarkStart.b("䔱", num), BookmarkStart.b("䐱唳娵", num), this.dictionary_32[BookmarkStart.b("䔱", num)], BookmarkStart.b("吱唳娵䬷弹", num));
            }
            this.class1092_0.method_12();
        }
        this.method_475(A_0);
        this.method_474(A_0);
        this.method_485(A_0, ownerBase);
        if ((A_0.HasKey(0x500) && (((byte) A_0.OutlineLevel) >= 0)) && (((byte) A_0.OutlineLevel) < 9))
        {
            this.class1092_0.method_10(BookmarkStart.b("崱䄳䈵吷匹刻嬽ి㑁⡃", num), this.dictionary_32[BookmarkStart.b("䔱", num)]);
            this.class1092_0.method_5(BookmarkStart.b("䐱唳娵", num), this.dictionary_32[BookmarkStart.b("䔱", num)], ((byte) A_0.OutlineLevel).ToString());
            this.class1092_0.method_12();
        }
        if (A_1 != null)
        {
            this.method_463(A_1.BreakCharacterFormat);
        }
        if ((((A_1 != null) && (A_1.NextSibling == null)) && ((A_1.OwnerTextBody != null) && A_1.IsEndOfSection)) && (A_1.method_1() == null))
        {
            Section section = A_1.method_49();
            if ((section != null) && (section.NextSibling != null))
            {
                string str = this.method_547(A_1.Text);
                if (section != null)
                {
                    char ch = '\r';
                    if (!str.Contains(ch.ToString()))
                    {
                        this.method_387(section);
                    }
                }
            }
        }
        if (A_0.IsChangedFormat)
        {
            this.method_481(A_0);
        }
        this.method_484(A_0);
    }

    private void method_474(ParagraphFormat A_0)
    {
        int num = 14;
        if (A_0.HasValue(0x479))
        {
            this.class1092_0.method_10(BookmarkStart.b("夳張䨷䠹医䰽िⱁ⁃⍅♇㹉㽋", num), this.dictionary_32[BookmarkStart.b("䌳", num)]);
            if (!A_0.MirrorIndents)
            {
                this.class1092_0.method_6(BookmarkStart.b("䌳", num), BookmarkStart.b("䈳圵吷", num), this.dictionary_32[BookmarkStart.b("䌳", num)], BookmarkStart.b("刳圵吷䤹夻", num));
            }
            this.class1092_0.method_12();
        }
    }

    private void method_475(ParagraphFormat A_0)
    {
        int num = 9;
        if (A_0.HasValue(0x582))
        {
            this.class1092_0.method_10(BookmarkStart.b("尮䐰䌲䔴䔶尸䠺丼績㑀㝂⩄ཆえ㭊╌⩎㽐⁒", num), this.dictionary_32[BookmarkStart.b("堮", num)]);
            if (!A_0.SuppressAutoHyphens)
            {
                this.class1092_0.method_6(BookmarkStart.b("堮", num), BookmarkStart.b("央倰弲", num), this.dictionary_32[BookmarkStart.b("堮", num)], BookmarkStart.b("䤮倰弲䘴制", num));
            }
            this.class1092_0.method_12();
        }
    }

    internal string method_476()
    {
        int num2 = this.int_10++;
        return num2.ToString();
    }

    private bool method_477(ParagraphBase A_0)
    {
        int num = 13;
        if (A_0.IsInsertRevision)
        {
            this.method_478(BookmarkStart.b("娲嬴䐶", num), A_0);
            return true;
        }
        if (A_0.IsDeleteRevision)
        {
            this.method_478(BookmarkStart.b("圲倴嬶", num), A_0);
            return true;
        }
        return false;
    }

    private void method_478(string A_0, ParagraphBase A_1)
    {
        int num = 14;
        this.class1092_0.method_10(A_0, this.dictionary_32[BookmarkStart.b("䌳", 14)]);
        this.class1092_0.method_5(BookmarkStart.b("崳刵", 14), this.dictionary_32[BookmarkStart.b("䌳", 14)], this.method_476());
        bool flag = (A_1 != null) ? A_1.CharacterFormat.IsInsertRevision : false;
        string str = ((A_1 == null) || string.IsNullOrEmpty(flag ? A_1.CharacterFormat.InsertRevision.method_0() : A_1.CharacterFormat.DeleteRevision.method_0())) ? ((this.document_0.BuiltinDocumentProperties != null) ? this.document_0.BuiltinDocumentProperties.Author : string.Empty) : (flag ? A_1.CharacterFormat.InsertRevision.method_0() : A_1.CharacterFormat.DeleteRevision.method_0());
        if (!string.IsNullOrEmpty(str))
        {
            this.class1092_0.method_5(BookmarkStart.b("唳䌵䰷刹医䰽", num), this.dictionary_32[BookmarkStart.b("䌳", num)], str);
        }
        if (A_1 != null)
        {
            DateTime time = (A_1 != null) ? (flag ? A_1.CharacterFormat.InsertRevision.method_2() : A_1.CharacterFormat.DeleteRevision.method_2()) : DateTime.Now;
            this.class1092_0.method_5(BookmarkStart.b("倳圵䰷弹", num), this.dictionary_32[BookmarkStart.b("䌳", num)], Class1041.smethod_0(time));
        }
    }

    private void method_479(string A_0)
    {
        this.method_478(A_0, null);
    }

    private Field method_48()
    {
        if ((this.stack_1 != null) && (this.stack_1.Count > 0))
        {
            return this.stack_1.Peek();
        }
        return null;
    }

    private void method_480(string A_0, Class580 A_1)
    {
        this.class1092_0.method_10(A_0, this.dictionary_32[BookmarkStart.b("䐲", 13)]);
        this.class1092_0.method_5(BookmarkStart.b("娲儴", 13), this.dictionary_32[BookmarkStart.b("䐲", 13)], this.method_476());
        this.class1092_0.method_5(BookmarkStart.b("刲䀴䌶儸吺似", 13), this.dictionary_32[BookmarkStart.b("䐲", 13)], A_1.method_0());
        this.class1092_0.method_5(BookmarkStart.b("圲吴䌶尸", 13), this.dictionary_32[BookmarkStart.b("䐲", 13)], Class1041.smethod_0(A_1.method_2()));
    }

    private void method_481(ParagraphFormat A_0)
    {
        this.method_480(BookmarkStart.b("席怯䀱眳帵夷吹嬻嬽", 8), A_0.FormatRevision);
        this.class1092_0.method_10(BookmarkStart.b("席怯䀱", 8), this.dictionary_32[BookmarkStart.b("夭", 8)]);
        this.method_473(A_0.FormatRevision.method_4() as ParagraphFormat, null, true);
        this.class1092_0.method_12();
        this.class1092_0.method_12();
    }

    private void method_482(CharacterFormat A_0)
    {
        this.method_480(BookmarkStart.b("崮愰䄲瘴弶堸唺娼娾", 9), A_0.FormatRevision);
        this.method_463(A_0.FormatRevision.method_4() as CharacterFormat);
        this.class1092_0.method_12();
    }

    private void method_483(CharacterFormat A_0)
    {
        this.method_479(BookmarkStart.b("䜴朶䬸砺唼帾⽀⑂⁄", 15));
        this.class1092_0.method_10(BookmarkStart.b("䜴朶䬸", 15), this.dictionary_32[BookmarkStart.b("䈴", 15)]);
        if (A_0.HasValue(380) || A_0.HasValue(390))
        {
            this.method_497(A_0);
        }
        this.class1092_0.method_12();
        this.class1092_0.method_12();
    }

    private void method_484(FormatBase A_0)
    {
        if (A_0.method_14())
        {
            int num = 0;
            int count = A_0.XmlProps.Count;
            while (num < count)
            {
                XmlNode node = A_0.XmlProps[num];
                if (node.NodeType == XmlNodeType.Element)
                {
                    node.WriteTo(this.class1092_0.method_0());
                }
                num++;
            }
        }
    }

    private void method_485(ParagraphFormat A_0, IParagraphStyle A_1)
    {
        int num = 7;
        if (A_0.HasKey(0x3fc))
        {
            this.class1092_0.method_10(BookmarkStart.b("䜬䰮", num), this.dictionary_32[BookmarkStart.b("娬", num)]);
            switch (A_0.HorizontalAlignment)
            {
                case HorizontalAlignment.Center:
                    this.class1092_0.method_6(BookmarkStart.b("娬", num), BookmarkStart.b("嬬丮崰", num), this.dictionary_32[BookmarkStart.b("娬", num)], BookmarkStart.b("丬䨮弰䜲倴䔶", num));
                    break;

                case HorizontalAlignment.Right:
                    this.class1092_0.method_6(BookmarkStart.b("娬", num), BookmarkStart.b("嬬丮崰", num), this.dictionary_32[BookmarkStart.b("娬", num)], BookmarkStart.b("弬䘮嘰嬲䄴", num));
                    break;

                case HorizontalAlignment.Justify:
                    this.class1092_0.method_6(BookmarkStart.b("娬", num), BookmarkStart.b("嬬丮崰", num), this.dictionary_32[BookmarkStart.b("娬", num)], BookmarkStart.b("伬䀮䔰嬲", num));
                    break;

                case HorizontalAlignment.Distribute:
                    this.class1092_0.method_6(BookmarkStart.b("娬", num), BookmarkStart.b("嬬丮崰", num), this.dictionary_32[BookmarkStart.b("娬", num)], BookmarkStart.b("䤬䘮䈰䜲䜴帶嬸为䤼娾", num));
                    break;

                case HorizontalAlignment.HightKashida:
                    this.class1092_0.method_6(BookmarkStart.b("娬", num), BookmarkStart.b("嬬丮崰", num), this.dictionary_32[BookmarkStart.b("娬", num)], BookmarkStart.b("䔬䘮嘰嬲䄴簶堸䠺唼嘾╀≂", num));
                    break;

                case HorizontalAlignment.LowKashida:
                    this.class1092_0.method_6(BookmarkStart.b("娬", num), BookmarkStart.b("嬬丮崰", num), this.dictionary_32[BookmarkStart.b("娬", num)], BookmarkStart.b("䄬䀮䘰砲吴䐶儸刺夼帾", num));
                    break;

                case HorizontalAlignment.MediumKashida:
                    this.class1092_0.method_6(BookmarkStart.b("娬", num), BookmarkStart.b("嬬丮崰", num), this.dictionary_32[BookmarkStart.b("娬", num)], BookmarkStart.b("䀬䨮唰娲䀴娶爸娺丼圾⡀❂⑄", num));
                    break;

                default:
                    this.class1092_0.method_6(BookmarkStart.b("娬", num), BookmarkStart.b("嬬丮崰", num), this.dictionary_32[BookmarkStart.b("娬", num)], BookmarkStart.b("䄬䨮地䜲", num));
                    break;
            }
            this.class1092_0.method_12();
        }
    }

    private void method_486(ParagraphFormat A_0)
    {
        int num = 7;
        if (((A_0.HasKey(0x488) || A_0.HasKey(0x47e)) || (A_0.HasKey(0x492) || A_0.HasKey(0x48d))) || (A_0.HasKey(0x483) || A_0.HasKey(0x497)))
        {
            this.class1092_0.method_10(BookmarkStart.b("䐬䄮唰", num), this.dictionary_32[BookmarkStart.b("娬", num)]);
            if (A_0.HasKey(0x48d))
            {
                this.class1092_0.method_5(BookmarkStart.b("䄬䨮地䜲瘴弶堸䤺丼", num), this.dictionary_32[BookmarkStart.b("娬", num)], this.method_534(A_0.LeftIndentChars * 100f));
            }
            if (A_0.HasKey(0x488))
            {
                this.class1092_0.method_5(BookmarkStart.b("䄬䨮地䜲", num), this.dictionary_32[BookmarkStart.b("娬", num)], this.method_534(A_0.LeftIndent * 20f));
            }
            if (A_0.HasKey(0x483))
            {
                this.class1092_0.method_5(BookmarkStart.b("弬䘮嘰嬲䄴琶儸娺似䰾", num), this.dictionary_32[BookmarkStart.b("娬", num)], this.method_534(A_0.RightIndentChars * 100f));
            }
            if (A_0.HasKey(0x47e))
            {
                this.class1092_0.method_5(BookmarkStart.b("弬䘮嘰嬲䄴", num), this.dictionary_32[BookmarkStart.b("娬", num)], this.method_534(A_0.RightIndent * 20f));
            }
            if (A_0.HasKey(0x497))
            {
                if (A_0.FirstLineIndentChars < 0f)
                {
                    this.class1092_0.method_5(BookmarkStart.b("䔬丮弰吲尴夶常砺唼帾㍀あ", num), this.dictionary_32[BookmarkStart.b("娬", num)], this.method_534((-1f * A_0.FirstLineIndentChars) * 100f));
                }
                else
                {
                    this.class1092_0.method_5(BookmarkStart.b("䬬䘮䌰䀲䄴笶倸唺堼簾⥀≂㝄㑆", num), this.dictionary_32[BookmarkStart.b("娬", num)], this.method_534(A_0.FirstLineIndentChars * 100f));
                }
            }
            if (A_0.HasKey(0x492))
            {
                if (A_0.FirstLineIndent < 0f)
                {
                    this.class1092_0.method_5(BookmarkStart.b("䔬丮弰吲尴夶常", num), this.dictionary_32[BookmarkStart.b("娬", num)], this.method_534((-1f * A_0.FirstLineIndent) * 20f));
                }
                else
                {
                    this.class1092_0.method_5(BookmarkStart.b("䬬䘮䌰䀲䄴笶倸唺堼", num), this.dictionary_32[BookmarkStart.b("娬", num)], this.method_534(A_0.FirstLineIndent * 20f));
                }
            }
            this.class1092_0.method_12();
        }
    }

    private void method_487(ParagraphFormat A_0)
    {
        int num = 8;
        if (((!A_0.HasKey(0x4b0) && !A_0.HasKey(0x4ba)) && (!A_0.HasKey(0x4c4) && !A_0.HasKey(0x4ce))) && ((!A_0.HasKey(0x4c9) && !A_0.HasKey(0x4b5)) && !A_0.HasKey(0x672)))
        {
            return;
        }
        this.class1092_0.method_10(BookmarkStart.b("崭䀯匱圳張嘷崹", num), this.dictionary_32[BookmarkStart.b("夭", num)]);
        if (A_0.HasKey(0x4b0))
        {
            this.class1092_0.method_5(BookmarkStart.b("䰭唯吱嬳䐵崷", num), this.dictionary_32[BookmarkStart.b("夭", num)], this.method_534(A_0.BeforeSpacing * 20f));
        }
        if (A_0.HasKey(0x4ba))
        {
            if (A_0.BeforeAutoSpacing)
            {
                this.class1092_0.method_5(BookmarkStart.b("䰭唯吱嬳䐵崷笹䤻䨽⼿ㅁ㑃❅⭇⍉≋⥍", num), this.dictionary_32[BookmarkStart.b("夭", num)], BookmarkStart.b("Ἥ", num));
            }
            else
            {
                this.class1092_0.method_5(BookmarkStart.b("䰭唯吱嬳䐵崷笹䤻䨽⼿ㅁ㑃❅⭇⍉≋⥍", num), this.dictionary_32[BookmarkStart.b("夭", num)], BookmarkStart.b("ḭ", num));
            }
        }
        if (A_0.HasKey(0x4c4))
        {
            this.class1092_0.method_5(BookmarkStart.b("伭嘯䘱儳䐵", num), this.dictionary_32[BookmarkStart.b("夭", num)], this.method_534(A_0.AfterSpacing * 20f));
        }
        if (A_0.HasKey(0x4ce))
        {
            if (A_0.AfterAutoSpacing)
            {
                this.class1092_0.method_5(BookmarkStart.b("伭嘯䘱儳䐵礷伹䠻儽㌿㉁╃╅ⅇ⑉⭋", num), this.dictionary_32[BookmarkStart.b("夭", num)], BookmarkStart.b("Ἥ", num));
            }
            else
            {
                this.class1092_0.method_5(BookmarkStart.b("伭嘯䘱儳䐵礷伹䠻儽㌿㉁╃╅ⅇ⑉⭋", num), this.dictionary_32[BookmarkStart.b("夭", num)], BookmarkStart.b("ḭ", num));
            }
        }
        if (A_0.HasKey(0x4c9))
        {
            float num3 = A_0.SpacingAfterChar * 100f;
            this.class1092_0.method_5(BookmarkStart.b("伭嘯䘱儳䐵琷匹刻嬽㌿", num), this.dictionary_32[BookmarkStart.b("夭", num)], this.method_534(num3));
        }
        if (A_0.HasKey(0x4b5))
        {
            float num2 = A_0.SpacingBeforeChar * 100f;
            this.class1092_0.method_5(BookmarkStart.b("䰭唯吱嬳䐵崷瘹唻倽┿ㅁ", num), this.dictionary_32[BookmarkStart.b("夭", num)], this.method_534(num2));
        }
        if (A_0.HasKey(0x672))
        {
            this.class1092_0.method_5(BookmarkStart.b("䈭夯就儳", num), this.dictionary_32[BookmarkStart.b("夭", num)], this.method_534(Math.Abs(A_0.LineSpacing) * 20f));
            switch (A_0.LineSpacingRule)
            {
                case LineSpacingRule.AtLeast:
                    this.class1092_0.method_5(BookmarkStart.b("䈭夯就儳搵䴷嘹夻", num), this.dictionary_32[BookmarkStart.b("夭", num)], BookmarkStart.b("伭䐯縱儳圵䬷丹", num));
                    goto Label_03DC;

                case LineSpacingRule.Exactly:
                    this.class1092_0.method_5(BookmarkStart.b("䈭夯就儳搵䴷嘹夻", num), this.dictionary_32[BookmarkStart.b("夭", num)], BookmarkStart.b("䬭䠯匱圳䈵", num));
                    goto Label_03DC;
            }
            this.class1092_0.method_5(BookmarkStart.b("䈭夯就儳搵䴷嘹夻", num), this.dictionary_32[BookmarkStart.b("夭", num)], BookmarkStart.b("伭䔯䘱嬳", num));
        }
    Label_03DC:
        this.class1092_0.method_12();
    }

    private void method_488(ParagraphFormat A_0)
    {
        int num = 11;
        if (A_0.Tabs.Count > 0)
        {
            this.class1092_0.method_10(BookmarkStart.b("䔰刲圴䐶", num), this.dictionary_32[BookmarkStart.b("䘰", num)]);
            foreach (Tab tab in A_0.Tabs)
            {
                this.method_489(tab);
            }
            this.class1092_0.method_12();
        }
    }

    private void method_489(Tab A_0)
    {
        int num = 15;
        int num2 = 0;
        this.class1092_0.method_10(BookmarkStart.b("䄴嘶嬸", 15), this.dictionary_32[BookmarkStart.b("䈴", 15)]);
        if ((A_0.Position == 0f) && (A_0.DeletePosition != 0f))
        {
            num2 = (int) Math.Round((double) A_0.DeletePosition);
            this.class1092_0.method_5(BookmarkStart.b("䔴堶䨸", num), this.dictionary_32[BookmarkStart.b("䈴", num)], num2.ToString());
            this.class1092_0.method_6(BookmarkStart.b("䈴", num), BookmarkStart.b("䌴嘶唸", num), this.dictionary_32[BookmarkStart.b("䈴", num)], BookmarkStart.b("嘴嬶尸娺似", num));
        }
        else
        {
            this.class1092_0.method_5(BookmarkStart.b("䔴堶䨸", num), this.dictionary_32[BookmarkStart.b("䈴", num)], ((int) Math.Round((double) (A_0.Position * 20f))).ToString());
            this.class1092_0.method_6(BookmarkStart.b("䈴", num), BookmarkStart.b("䌴嘶唸", num), this.dictionary_32[BookmarkStart.b("䈴", num)], this.method_519(A_0.Justification));
        }
        if (A_0.TabLeader != TabLeader.NoLeader)
        {
            this.class1092_0.method_5(BookmarkStart.b("头制堸强堼䴾", num), this.dictionary_32[BookmarkStart.b("䈴", num)], this.method_518(A_0.TabLeader));
        }
        this.class1092_0.method_12();
    }

    internal void method_49(string A_0, Document A_1)
    {
        using (FileStream stream = new FileStream(A_0, FileMode.Create))
        {
            if (A_1.method_159() == 15)
            {
                A_1.DocxNameSpace.method_3(true);
            }
            else
            {
                A_1.DocxNameSpace.method_3(false);
            }
            this.method_50(stream, A_1);
            stream.Close();
        }
    }

    private void method_490(ParagraphFormat A_0)
    {
        int num = 0x10;
        if (A_0.method_60())
        {
            this.class1092_0.method_10(BookmarkStart.b("䔵倷帹", num), this.dictionary_32[BookmarkStart.b("䄵", num)]);
            if (A_0.BackColor != Color.Empty)
            {
                this.class1092_0.method_5(BookmarkStart.b("倵儷嘹倻", num), this.dictionary_32[BookmarkStart.b("䄵", num)], this.method_535(A_0.BackColor));
            }
            else if ((A_0.BackColor == Color.Empty) && A_0.HasKey(0x15))
            {
                this.class1092_0.method_5(BookmarkStart.b("倵儷嘹倻", num), this.dictionary_32[BookmarkStart.b("䄵", num)], BookmarkStart.b("圵䴷丹医", num));
            }
            if (A_0.ForeColor != Color.Empty)
            {
                this.class1092_0.method_5(BookmarkStart.b("唵圷嘹医䰽", num), this.dictionary_32[BookmarkStart.b("䄵", num)], this.method_535(A_0.ForeColor));
            }
            else if ((A_0.ForeColor == Color.Empty) && A_0.HasKey(0x20))
            {
                this.class1092_0.method_5(BookmarkStart.b("唵圷嘹医䰽", num), this.dictionary_32[BookmarkStart.b("䄵", num)], BookmarkStart.b("圵䴷丹医", num));
            }
            string str = this.method_529(A_0.TextureStyle);
            this.class1092_0.method_6(BookmarkStart.b("䄵", num), BookmarkStart.b("䀵夷嘹", num), this.dictionary_32[BookmarkStart.b("䄵", num)], str);
            this.class1092_0.method_12();
        }
    }

    private void method_491(ParagraphFormat A_0, int A_1)
    {
        int num = 9;
        Borders borders = A_0.Borders;
        if (!borders.IsDefault)
        {
            this.class1092_0.method_10(BookmarkStart.b("弮猰圲䜴", num), this.dictionary_32[BookmarkStart.b("堮", num)]);
            if ((!borders.Top.IsDefault || (A_0.HasValue(0x546) && (borders.Top.IsChanged || (borders.Top.BorderType != BorderStyle.None)))) || (A_0.HasValue(0x3f) && (borders.Top.IsChanged || (borders.Top.BorderType != BorderStyle.None))))
            {
                this.method_496(borders.Top, BookmarkStart.b("嬮帰䌲", num), A_1);
            }
            if ((!borders.Left.IsDefault || (A_0.HasValue(0x550) && (borders.Left.IsChanged || (borders.Left.BorderType != BorderStyle.None)))) || (A_0.HasValue(0x3d) && (borders.Left.IsChanged || (borders.Left.BorderType != BorderStyle.None))))
            {
                this.method_496(borders.Left, BookmarkStart.b("䌮吰唲䄴", num), A_1);
            }
            if ((!borders.Bottom.IsDefault || (A_0.HasValue(0x55a) && (borders.Bottom.IsChanged || (borders.Bottom.BorderType != BorderStyle.None)))) || (A_0.HasValue(0x40) && (borders.Bottom.IsChanged || (borders.Bottom.BorderType != BorderStyle.None))))
            {
                this.method_496(borders.Bottom, BookmarkStart.b("䴮帰䜲䄴堶吸", num), A_1);
            }
            if (((!borders.Right.IsDefault || (A_0.HasValue(0x564) && (borders.Right.IsChanged || (borders.Right.BorderType != BorderStyle.None)))) || (A_0.HasValue(0x3e) && borders.Right.IsChanged)) || (borders.Right.BorderType != BorderStyle.None))
            {
                this.method_496(borders.Right, BookmarkStart.b("崮堰吲崴䌶", num), A_1);
            }
            if (!borders.Horizontal.IsDefault)
            {
                this.method_496(borders.Horizontal, BookmarkStart.b("䴮吰䜲䈴制尸唺", num), A_1);
            }
            if (!borders.Vertical.IsDefault)
            {
                this.method_496(borders.Vertical, BookmarkStart.b("䴮倰䄲", num), A_1);
            }
            this.class1092_0.method_12();
        }
    }

    private void method_492(Paragraph A_0)
    {
        if (A_0 != null)
        {
            if ((A_0.ListFormat.ListType != ListType.NoList) && A_0.ListFormat.HasKey(1))
            {
                this.method_493(A_0.ListFormat);
            }
            else if (A_0.ListFormat.IsEmptyList)
            {
                this.method_522(0, 0);
            }
        }
    }

    private void method_493(ListFormat A_0)
    {
        int num = 7;
        string name = null;
        if (A_0.CurrentListStyle.IsBuiltInStyle && (A_0.OwnerParagraph != null))
        {
            name = A_0.OwnerParagraph.StyleName;
        }
        int num2 = this.method_520(A_0);
        if ((name != null) && !A_0.OwnerParagraph.Format.HasListReference)
        {
            Document document = A_0.OwnerParagraph.Document;
            ParagraphStyle style2 = document.Styles.FindByName(name, StyleType.ParagraphStyle) as ParagraphStyle;
            if (style2.ListIndex == -1)
            {
                ListStyle style = A_0.OwnerParagraph.Document.ListStyles.FindByName(A_0.CustomStyleName);
                style2.ListIndex = num2;
                document.Styles.method_6(style2);
                if (style.Levels.Count > 1)
                {
                    style2.ListLevel = A_0.ListLevelNumber;
                }
                name = name.Replace(BookmarkStart.b("ബ", num), "");
                style.Levels[A_0.ListLevelNumber].ParaStyleName = name;
            }
        }
        else
        {
            this.method_522(num2, A_0.ListLevelNumber);
        }
    }

    private void method_494(ParagraphFormat A_0)
    {
        this.method_495(A_0, false);
    }

    private void method_495(ParagraphFormat A_0, bool A_1)
    {
        int num = 8;
        this.class1092_0.method_10(BookmarkStart.b("䠭䈯匱夳匵样䠹", 8), this.dictionary_32[BookmarkStart.b("夭", 8)]);
        if (A_0.HasKey(0x5a0) && (A_0.DropCapPosition != DropCapPosition.None))
        {
            string str3 = (A_0.DropCapPosition == DropCapPosition.Normal) ? BookmarkStart.b("䨭䈯崱䐳", num) : BookmarkStart.b("䌭儯䀱匳張嘷", num);
            this.class1092_0.method_6(BookmarkStart.b("夭", num), BookmarkStart.b("䨭䈯崱䐳电夷䨹", num), this.dictionary_32[BookmarkStart.b("夭", num)], str3);
        }
        if (A_0.HasKey(0x5aa) && (A_0.DropCapLinesToDrop > 0))
        {
            this.class1092_0.method_6(BookmarkStart.b("夭", num), BookmarkStart.b("䈭夯就儳䔵", num), this.dictionary_32[BookmarkStart.b("夭", num)], A_0.DropCapLinesToDrop.ToString());
        }
        if (A_0.Frame.HasKey(11))
        {
            string str2 = null;
            if (A_0.FrameHorizontalAnchor == FrameHorzAnchor.Column)
            {
                str2 = BookmarkStart.b("娭唯䨱䀳", num);
            }
            else
            {
                str2 = A_0.FrameHorizontalAnchor.ToString().ToLower();
            }
            this.class1092_0.method_6(BookmarkStart.b("夭", num), BookmarkStart.b("䘭焯就圳帵圷䠹", num), this.dictionary_32[BookmarkStart.b("夭", num)], str2);
        }
        if (A_0.Frame.HasKey(12))
        {
            this.class1092_0.method_6(BookmarkStart.b("夭", num), BookmarkStart.b("堭焯就圳帵圷䠹", num), this.dictionary_32[BookmarkStart.b("夭", num)], A_0.FrameVerticalAnchor.ToString().ToLower());
        }
        if (A_0.Frame.HasKey(3))
        {
            this.class1092_0.method_6(BookmarkStart.b("夭", num), BookmarkStart.b("嘭", num), this.dictionary_32[BookmarkStart.b("夭", num)], this.method_534((float) A_0.FrameX));
        }
        if (A_0.Frame.HasKey(8))
        {
            this.class1092_0.method_6(BookmarkStart.b("夭", num), BookmarkStart.b("嘭焯帱崳儵嘷", num), this.dictionary_32[BookmarkStart.b("夭", num)], A_0.FrameHorizontalPosition.ToString().ToLower());
        }
        if (A_0.Frame.HasKey(4))
        {
            this.class1092_0.method_6(BookmarkStart.b("夭", num), BookmarkStart.b("圭", num), this.dictionary_32[BookmarkStart.b("夭", num)], this.method_534((float) A_0.FrameY));
        }
        if (A_0.Frame.HasKey(15))
        {
            this.class1092_0.method_6(BookmarkStart.b("夭", num), BookmarkStart.b("圭焯帱崳儵嘷", num), this.dictionary_32[BookmarkStart.b("夭", num)], A_0.FrameVerticalPosition.ToString().ToLower());
        }
        if (A_0.Frame.HasKey(0x11) && (A_0.FrameWidth != 0))
        {
            this.class1092_0.method_6(BookmarkStart.b("夭", num), BookmarkStart.b("夭", num), this.dictionary_32[BookmarkStart.b("夭", num)], this.method_534((float) A_0.FrameWidth));
        }
        if (A_0.Frame.HasKey(6))
        {
            this.class1092_0.method_6(BookmarkStart.b("夭", num), BookmarkStart.b("䘭", num), this.dictionary_32[BookmarkStart.b("夭", num)], this.method_534((float) A_0.FrameHeight));
        }
        if (A_0.Frame.HasKey(7))
        {
            switch (A_0.Frame.method_95())
            {
                case FrameSizeRule.Auto:
                    this.class1092_0.method_6(BookmarkStart.b("夭", num), BookmarkStart.b("䘭戯䜱堳匵", num), this.dictionary_32[BookmarkStart.b("夭", num)], BookmarkStart.b("伭䔯䘱嬳", num));
                    break;

                case FrameSizeRule.AtLeast:
                    this.class1092_0.method_6(BookmarkStart.b("夭", num), BookmarkStart.b("䘭戯䜱堳匵", num), this.dictionary_32[BookmarkStart.b("夭", num)], BookmarkStart.b("伭䐯縱儳圵䬷丹", num));
                    break;

                case FrameSizeRule.Exact:
                    this.class1092_0.method_6(BookmarkStart.b("夭", num), BookmarkStart.b("䘭戯䜱堳匵", num), this.dictionary_32[BookmarkStart.b("夭", num)], BookmarkStart.b("䬭䠯匱圳䈵", num));
                    break;
            }
        }
        string str = string.Empty;
        if (A_0.Frame.HasKey(0x12))
        {
            switch (A_0.FrameWrapType)
            {
                case FrameTextWrap.Auto:
                    str = BookmarkStart.b("伭䔯䘱嬳", num);
                    break;

                case FrameTextWrap.NotBeside:
                    str = BookmarkStart.b("䀭弯䘱瘳匵䬷匹堻嬽", num);
                    break;

                case FrameTextWrap.Around:
                    str = BookmarkStart.b("伭䈯崱䄳堵尷", num);
                    break;

                case FrameTextWrap.None:
                    str = BookmarkStart.b("䀭弯就儳", num);
                    break;

                case FrameTextWrap.Tight:
                    str = BookmarkStart.b("娭夯唱尳䈵", num);
                    break;

                case FrameTextWrap.Through:
                    str = BookmarkStart.b("娭堯䀱嬳䌵強刹", num);
                    break;
            }
        }
        if (!string.IsNullOrEmpty(str))
        {
            this.class1092_0.method_5(BookmarkStart.b("夭䈯匱䐳", num), this.dictionary_32[BookmarkStart.b("夭", num)], str);
        }
        if (A_0.Frame.HasKey(9))
        {
            this.class1092_0.method_6(BookmarkStart.b("夭", num), BookmarkStart.b("䘭振䈱唳唵崷", num), this.dictionary_32[BookmarkStart.b("夭", num)], this.method_534((float) A_0.FrameHorizontalDistanceFromText));
        }
        if (A_0.Frame.HasKey(0x10))
        {
            this.class1092_0.method_6(BookmarkStart.b("夭", num), BookmarkStart.b("堭振䈱唳唵崷", num), this.dictionary_32[BookmarkStart.b("夭", num)], this.method_534((float) A_0.FrameVerticalDistanceFromText));
        }
        if (A_0.Frame.HasKey(5))
        {
            string str4 = A_0.FrameAnchorLock ? BookmarkStart.b("Ἥ", num) : BookmarkStart.b("ḭ", num);
            this.class1092_0.method_6(BookmarkStart.b("夭", num), BookmarkStart.b("伭帯儱尳夵䨷瘹医崽⬿", num), this.dictionary_32[BookmarkStart.b("夭", num)], str4);
        }
        this.class1092_0.method_12();
    }

    private void method_496(Border A_0, string A_1, int A_2)
    {
        int num = 2;
        BorderStyle borderType = A_0.BorderType;
        int num2 = (int) (A_0.LineWidth * A_2);
        float space = A_0.Space;
        if (borderType == BorderStyle.Cleared)
        {
            this.class1092_0.method_10(A_1, this.dictionary_32[BookmarkStart.b("弧", num)]);
            this.class1092_0.method_6(BookmarkStart.b("弧", num), BookmarkStart.b("帧䬩䀫", num), this.dictionary_32[BookmarkStart.b("弧", num)], BookmarkStart.b("䘧䌩䀫", num));
            this.class1092_0.method_12();
        }
        else
        {
            this.class1092_0.method_10(A_1, this.dictionary_32[BookmarkStart.b("弧", num)]);
            this.class1092_0.method_6(BookmarkStart.b("弧", num), BookmarkStart.b("帧䬩䀫", num), this.dictionary_32[BookmarkStart.b("弧", num)], this.method_530(borderType));
            if (borderType != BorderStyle.Cleared)
            {
                this.class1092_0.method_5(BookmarkStart.b("嬧倩", num), this.dictionary_32[BookmarkStart.b("弧", num)], num2.ToString());
                this.class1092_0.method_5(BookmarkStart.b("嬧娩䴫䴭唯", num), this.dictionary_32[BookmarkStart.b("弧", num)], space.ToString());
                if (!A_0.Color.IsEmpty && !(A_0.Color == Color.Black))
                {
                    this.class1092_0.method_5(BookmarkStart.b("䬧䔩䀫䄭䈯", num), this.dictionary_32[BookmarkStart.b("弧", num)], this.method_535(A_0.Color));
                }
                else
                {
                    this.class1092_0.method_5(BookmarkStart.b("䬧䔩䀫䄭䈯", num), this.dictionary_32[BookmarkStart.b("弧", num)], BookmarkStart.b("䤧弩堫䄭", num));
                }
                if (A_0.Shadow)
                {
                    this.class1092_0.method_5(BookmarkStart.b("嬧䈩䴫䨭弯䔱", num), this.dictionary_32[BookmarkStart.b("弧", num)], BookmarkStart.b("䜧䐩", num));
                }
            }
            this.class1092_0.method_12();
        }
    }

    private void method_497(CharacterFormat A_0)
    {
        int num = 7;
        this.class1092_0.method_10(BookmarkStart.b("䄬丮弰吲", 7), this.dictionary_32[BookmarkStart.b("娬", 7)]);
        if (A_0.HasValue(380))
        {
            string str = this.method_499(A_0.LocaleIdASCII);
            this.class1092_0.method_6(BookmarkStart.b("娬", num), BookmarkStart.b("嬬丮崰", num), this.dictionary_32[BookmarkStart.b("娬", num)], str);
        }
        if (A_0.HasValue(390))
        {
            string str3 = this.method_499(A_0.LocaleIdFarEast);
            this.class1092_0.method_6(BookmarkStart.b("娬", num), BookmarkStart.b("䠬丮䈰䜲琴䐶倸娺", num), this.dictionary_32[BookmarkStart.b("娬", num)], str3);
        }
        if (A_0.HasValue(340))
        {
            string str2 = this.method_499(A_0.LocaleIdBi);
            this.class1092_0.method_6(BookmarkStart.b("娬", num), BookmarkStart.b("伬䘮唰娲", num), this.dictionary_32[BookmarkStart.b("娬", num)], str2);
        }
        this.class1092_0.method_12();
    }

    private void method_498(Class514 A_0)
    {
        this.class1092_0.method_10(BookmarkStart.b("䴸区堼刾⑀Ղ⩄⥆㵈݊ⱌⅎ㙐", 0x13), this.dictionary_32[BookmarkStart.b("丸", 0x13)]);
        string str = this.method_499(A_0.method_4());
        this.class1092_0.method_6(BookmarkStart.b("丸", 0x13), BookmarkStart.b("伸娺儼", 0x13), this.dictionary_32[BookmarkStart.b("丸", 0x13)], str);
        string str2 = this.method_499(A_0.method_2());
        this.class1092_0.method_6(BookmarkStart.b("丸", 0x13), BookmarkStart.b("尸娺丼䬾@あⱄ♆", 0x13), this.dictionary_32[BookmarkStart.b("丸", 0x13)], str2);
        string str3 = this.method_499(A_0.method_0());
        this.class1092_0.method_6(BookmarkStart.b("丸", 0x13), BookmarkStart.b("嬸刺夼嘾", 0x13), this.dictionary_32[BookmarkStart.b("丸", 0x13)], str3);
        this.class1092_0.method_12();
    }

    private string method_499(int A_0)
    {
        int num = 13;
        if (A_0 == 0x40a)
        {
            return BookmarkStart.b("嘲䘴ᨶ簸栺", num);
        }
        return ((LocaleIDs) A_0).ToString().Replace('_', '-');
    }

    internal Dictionary<string, Dictionary<string, string>> method_5()
    {
        if (this.dictionary_29 == null)
        {
            this.dictionary_29 = new Dictionary<string, Dictionary<string, string>>();
        }
        return this.dictionary_29;
    }

    internal void method_50(Stream A_0, Document A_1)
    {
        if (A_1.method_159() == 15)
        {
            A_1.DocxNameSpace.method_3(true);
        }
        else
        {
            A_1.DocxNameSpace.method_3(false);
        }
        this.method_51(A_1);
        if (A_1.IsEncrypted)
        {
            MemoryStream stream = new MemoryStream();
            this.class771_0.method_25(stream, false);
            using (Interface51 interface2 = A_1.method_153())
            {
                Class440 class2 = new Class440();
                stream.Position = 0L;
                string str = A_1.string_10;
                class2.method_0(stream, str, interface2.imethod_0());
                interface2.imethod_3(A_0);
                return;
            }
        }
        this.class771_0.method_25(A_0, false);
    }

    private void method_500(short A_0, string A_1, CharacterFormat A_2)
    {
        int num = 12;
        if (A_2.method_62(A_0))
        {
            this.class1092_0.method_10(A_1, this.dictionary_32[BookmarkStart.b("䔱", num)]);
            this.class1092_0.method_12();
        }
        else if (A_2.HasValue(A_0))
        {
            this.class1092_0.method_10(A_1, this.dictionary_32[BookmarkStart.b("䔱", num)]);
            this.class1092_0.method_5(BookmarkStart.b("䐱唳娵", num), this.dictionary_32[BookmarkStart.b("䔱", num)], BookmarkStart.b("ȱ", num));
            this.class1092_0.method_12();
        }
    }

    private void method_501()
    {
        int num = 0x10;
        this.dictionary_32 = this.document_0.DocxNameSpace.method_0()[BookmarkStart.b("戵䄷䨹夻䴽", 0x10)];
        MemoryStream stream = new MemoryStream();
        this.class1092_0 = this.method_524(stream);
        this.class1092_0.method_10(BookmarkStart.b("戵䄷䨹夻䴽", 0x10), this.dictionary_32[BookmarkStart.b("丵唷嘹刻䴽", 0x10)]);
        this.method_509(stream, BookmarkStart.b("䐵崷嘹伻", 0x10), BookmarkStart.b("圵䠷䨹倻圽⌿⍁ぃ⽅❇⑉捋㡍㹏㙑穓㥕⡗㽙㉛♝ൟ๡ɣ॥ᩧݩ൫ᩭͯ影ѳ᝵᭷ᅹᵻ᥽겁ﾏﲑﺕ떝\ud89f\ucfa1좣", 0x10));
        this.method_509(stream, BookmarkStart.b("丵唷嘹", 0x10), BookmarkStart.b("圵䠷䨹倻圽⌿⍁ぃ⽅❇⑉捋㙍㵏㹑", 0x10));
        if ((this.bool_0 || (this.method_25().Count > 0)) || (this.bool_7 || this.bool_6))
        {
            this.method_509(stream, BookmarkStart.b("儵儷尹", num), BookmarkStart.b("張唷嬹嬻嬽漿╁ⵃ⁅", num));
            this.method_509(stream, BookmarkStart.b("尵䠷弹嬻", num), BookmarkStart.b("張唷嬹嬻嬽漿⡁㑃⍅⽇", num));
            this.method_509(stream, BookmarkStart.b("䄵唷尹", num), BookmarkStart.b("張唷嬹嬻嬽漿㩁楃ㅅ╇ⱉ", num));
            this.method_509(stream, BookmarkStart.b("䘵嘷崹", num), BookmarkStart.b("張唷嬹嬻嬽漿汁㑃⡅⽇", num));
        }
        if (this.bool_10)
        {
            this.method_509(stream, BookmarkStart.b("夵尷丹䠻堽", num), BookmarkStart.b("圵䠷䨹倻圽⌿⍁ぃ⽅❇⑉捋㡍㹏㙑穓㥕⡗㽙㉛♝ൟ๡ɣ॥ᩧݩ൫ᩭͯ影᭳ၵṷ፹ύ᭽揄뺏﶑ﾛﾝ풟잡삣잧쒩\ud8ab", num));
        }
        if (this.document_0.IsContainMacro && this.document_0.IsMacroEnabled)
        {
            this.method_509(stream, BookmarkStart.b("吵儷吹", num), BookmarkStart.b("圵䠷䨹倻圽⌿⍁ぃ⽅❇⑉捋㡍㹏㙑穓㭕⭗睙㍛㡝ٟୡݣͥ䙧ᱩ๫཭⁯q᭳ᱵᵷ᥹ࡻ", num));
        }
        if (this.bool_7)
        {
            this.method_505(stream);
        }
        if (this.document_0.IsMacroEnabled)
        {
            if (this.document_0.IsSaveTemplate)
            {
                this.method_510(stream, BookmarkStart.b("䄵圷䠹堻戽␿ⵁ❃㍅╇⽉≋㩍繏⩑㥓㩕", num), BookmarkStart.b("圵䠷䨹倻圽⌿⍁ぃ⽅❇⑉捋㡍㹏㙑穓㭕⭗睙⭛ㅝ቟١䩣ብ൧ݩᱫɭᅯٱᅳ塵ᕷ᭹ύ౽잁쒏煉ﮙﮝ躟쾡얣쾥욧膩풫쎭\udcaf", num));
            }
            else
            {
                this.method_510(stream, BookmarkStart.b("䄵圷䠹堻戽␿ⵁ❃㍅╇⽉≋㩍繏⩑㥓㩕", num), BookmarkStart.b("圵䠷䨹倻圽⌿⍁ぃ⽅❇⑉捋㡍㹏㙑穓㭕⭗睙⭛ㅝ቟١䩣ɥݧ३ᥫͭᕯᱱs塵ᕷ᭹ύ౽잁뺏ﾑﾕ놙첟", num));
            }
            if (this.document_0.IsContainMacro)
            {
                this.method_510(stream, BookmarkStart.b("䄵圷䠹堻戽㘿⁁╃Ʌ⥇㹉ⵋ恍⡏㽑㡓", num), BookmarkStart.b("圵䠷䨹倻圽⌿⍁ぃ⽅❇⑉捋㡍㹏㙑穓㭕⭗睙⭛ㅝ቟١䩣ၥ੧୩⡫཭ѯ፱彳๵ᕷᙹ", num));
            }
        }
        else if (this.document_0.IsSaveTemplate)
        {
            this.method_510(stream, BookmarkStart.b("䄵圷䠹堻戽␿ⵁ❃㍅╇⽉≋㩍繏⩑㥓㩕", num), BookmarkStart.b("圵䠷䨹倻圽⌿⍁ぃ⽅❇⑉捋㡍㹏㙑穓㥕⡗㽙㉛♝ൟ๡ɣ॥ᩧݩ൫ᩭͯ影᭳ၵṷ፹ύ᭽揄뺏ﮓﲗ쎟잡힣향솧쒩쮫쎭\udcaf\u9cb1삳펵햷쪹킻\udfbd\ub4bfꟁꯅ꧇ꏉꋋ꣏뿑룓", num));
        }
        else
        {
            this.method_510(stream, BookmarkStart.b("䄵圷䠹堻戽␿ⵁ❃㍅╇⽉≋㩍繏⩑㥓㩕", num), BookmarkStart.b("圵䠷䨹倻圽⌿⍁ぃ⽅❇⑉捋㡍㹏㙑穓㥕⡗㽙㉛♝ൟ๡ɣ॥ᩧݩ൫ᩭͯ影᭳ၵṷ፹ύ᭽揄뺏ﮓﲗ쎟잡힣향솧쒩쮫쎭\udcaf\u9cb1킳\ud9b5\udbb7쾹톻\udbbd\uaebf뛁ꯅ꧇ꏉꋋ꣏뿑룓", num));
        }
        if (this.document_0.CustomXMLContainer != null)
        {
            foreach (Class229 class2 in this.document_0.CustomXMLContainer.method_0().Values)
            {
                if (class2.method_7().StartsWith(BookmarkStart.b("張䰷弹儻渽㈿ⵁ㑃㕅", num)))
                {
                    string str2 = BookmarkStart.b("唵䴷䤹䠻儽ⴿᩁ⥃⩅ᑇ", num) + class2.method_7();
                    string str3 = this.method_503(class2.method_7());
                    this.method_510(stream, str2, str3);
                }
            }
        }
        if (this.document_0.IsSaveTemplate && (this.document_0.GlossaryContainer != null))
        {
            foreach (Class229 class3 in this.document_0.GlossaryContainer.method_0().Values)
            {
                string str4 = BookmarkStart.b("䄵圷䠹堻ᄽ✿⹁⭃㕅㭇⭉㹋㝍罏", num) + class3.method_7();
                string str5 = this.method_504(class3.method_7());
                this.method_510(stream, str4, str5);
            }
        }
        if (this.method_32())
        {
            this.method_510(stream, BookmarkStart.b("䄵圷䠹堻戽⸿㝁⥃⑅ⵇ㡉╋⁍㝏籑ⱓ㭕㑗", num), BookmarkStart.b("圵䠷䨹倻圽⌿⍁ぃ⽅❇⑉捋㡍㹏㙑穓㥕⡗㽙㉛♝ൟ๡ɣ॥ᩧݩ൫ᩭͯ影᭳ၵṷ፹ύ᭽揄뺏ﮓﲗ쎟잡힣향솧쒩쮫쎭\udcaf\u9cb1\udab3\uc3b5햷\ud8b9\ud9bb첽ꦿ곁ꏃ냇Ꟊꃋ", num));
        }
        if (this.bool_8)
        {
            this.method_510(stream, BookmarkStart.b("䄵圷䠹堻戽⌿ⵁ⥃⭅ⵇ⑉㡋㵍繏⩑㥓㩕", num), BookmarkStart.b("圵䠷䨹倻圽⌿⍁ぃ⽅❇⑉捋㡍㹏㙑穓㥕⡗㽙㉛♝ൟ๡ɣ॥ᩧݩ൫ᩭͯ影᭳ၵṷ፹ύ᭽揄뺏ﮓﲗ쎟잡힣향솧쒩쮫쎭\udcaf\u9cb1ힳ\ud9b5\ud5b7ힹ\ud9bb\ud0bd뒿뇁뻅ꗇꛉ", num));
        }
        if (this.bool_9)
        {
            this.method_510(stream, BookmarkStart.b("䄵圷䠹堻戽⌿ⵁ⥃⭅ⵇ⑉㡋㵍ᕏ⩑⁓㍕㙗㹙㥛㩝也ᩡॣ੥", num), BookmarkStart.b("圵䠷䨹倻圽⌿⍁ぃ⽅❇⑉捋㡍㹏㙑穓㥕⡗㽙㉛♝ൟ๡ɣ॥ᩧݩ൫ᩭͯ影᭳ၵṷ፹ύ᭽揄뺏ﮓﲗ쎟잡힣향솧쒩쮫쎭\udcaf\u9cb1ힳ\ud9b5\ud5b7ힹ\ud9bb\ud0bd뒿뇁臃뻅볇꿉ꋋ꫍뗏뛑ￓ껕뗗뛙", num));
        }
        if (this.method_30())
        {
            this.method_510(stream, BookmarkStart.b("䄵圷䠹堻戽┿ⱁ⁃⡅❇㹉⥋㵍繏⩑㥓㩕", num), BookmarkStart.b("圵䠷䨹倻圽⌿⍁ぃ⽅❇⑉捋㡍㹏㙑穓㥕⡗㽙㉛♝ൟ๡ɣ॥ᩧݩ൫ᩭͯ影᭳ၵṷ፹ύ᭽揄뺏ﮓﲗ쎟잡힣향솧쒩쮫쎭\udcaf\u9cb1톳\ud8b5\udcb7풹펻쪽ꖿ뇁뻅ꗇꛉ", num));
        }
        if (this.method_28())
        {
            this.method_510(stream, BookmarkStart.b("䄵圷䠹堻戽☿ⵁ⭃㉅♇╉㡋⭍⍏籑ⱓ㭕㑗", num), BookmarkStart.b("圵䠷䨹倻圽⌿⍁ぃ⽅❇⑉捋㡍㹏㙑穓㥕⡗㽙㉛♝ൟ๡ɣ॥ᩧݩ൫ᩭͯ影᭳ၵṷ፹ύ᭽揄뺏ﮓﲗ쎟잡힣향솧쒩쮫쎭\udcaf\u9cb1튳\ud9b5\ud7b7캹튻톽뒿ꟁ럃냇Ꟊꃋ", num));
        }
        if (this.method_26())
        {
            this.method_510(stream, BookmarkStart.b("䄵圷䠹堻戽☿ⵁ⩃㉅᱇⭉⹋≍㕏籑ⱓ㭕㑗", num), BookmarkStart.b("圵䠷䨹倻圽⌿⍁ぃ⽅❇⑉捋㡍㹏㙑穓㥕⡗㽙㉛♝ൟ๡ɣ॥ᩧݩ൫ᩭͯ影᭳ၵṷ፹ύ᭽揄뺏ﮓﲗ쎟잡힣향솧쒩쮫쎭\udcaf\u9cb1튳\ud9b5\ud6b7캹\udfbd\ua2bf껁ꇃ냇Ꟊꃋ", num));
        }
        if (this.bool_15)
        {
            this.method_502(this.document_0.DocxPackage, stream);
        }
        if (this.bool_2)
        {
            this.method_510(stream, BookmarkStart.b("䄵圷䠹堻戽㐿⩁⅃⭅ⵇᙉ㡋♍㕏㽑ㅓ杕癗≙ㅛ㉝", num), BookmarkStart.b("圵䠷䨹倻圽⌿⍁ぃ⽅❇⑉捋㡍㹏㙑穓㥕⡗㽙㉛♝ൟ๡ɣ॥ᩧݩ൫ᩭͯ影᭳ၵṷ፹ύ᭽揄뺏ﲓﾙ랛춟캡", num));
        }
        this.method_510(stream, BookmarkStart.b("䄵圷䠹堻戽㌿㙁㵃⩅ⵇ㥉手㙍㵏㹑", num), BookmarkStart.b("圵䠷䨹倻圽⌿⍁ぃ⽅❇⑉捋㡍㹏㙑穓㥕⡗㽙㉛♝ൟ๡ɣ॥ᩧݩ൫ᩭͯ影᭳ၵṷ፹ύ᭽揄뺏ﮓﲗ쎟잡힣향솧쒩쮫쎭\udcaf\u9cb1잳습솷횹\ud9bb\ucdbd뫁꧃꫅", num));
        this.method_510(stream, BookmarkStart.b("䄵圷䠹堻戽㌿❁ぃ㉅ⅇ⑉⭋㵍繏⩑㥓㩕", num), BookmarkStart.b("圵䠷䨹倻圽⌿⍁ぃ⽅❇⑉捋㡍㹏㙑穓㥕⡗㽙㉛♝ൟ๡ɣ॥ᩧݩ൫ᩭͯ影᭳ၵṷ፹ύ᭽揄뺏ﮓﲗ쎟잡힣향솧쒩쮫쎭\udcaf\u9cb1잳펵첷캹햻킽ꞿ뇁뻅ꗇꛉ", num));
        this.method_510(stream, BookmarkStart.b("䄵圷䠹堻戽㜿❁♃ᕅⵇ㹉㡋❍㹏㕑❓硕⁗㝙せ", num), BookmarkStart.b("圵䠷䨹倻圽⌿⍁ぃ⽅❇⑉捋㡍㹏㙑穓㥕⡗㽙㉛♝ൟ๡ɣ॥ᩧݩ൫ᩭͯ影᭳ၵṷ፹ύ᭽揄뺏ﮓﲗ쎟잡힣향솧쒩쮫쎭\udcaf\u9cb1쎳펵\udab7\ue9b9\ud9bb\ucabd뒿ꯁ꫃ꇅ믇듋ꏍ볏", num));
        this.method_510(stream, BookmarkStart.b("刵圷夹氻䰽⼿㉁㝃ᩅ⭇╉㹋⭍繏⩑㥓㩕", num), BookmarkStart.b("圵䠷䨹倻圽⌿⍁ぃ⽅❇⑉捋㡍㹏㙑穓㥕⡗㽙㉛♝ൟ๡ɣ॥ᩧݩ൫ᩭͯ影ѳ᝵᭷ᅹᵻ᥽겁慎ꆋﺍ﶑ﮝ펟覡\udca3\ucba5쒧", num));
        this.method_510(stream, BookmarkStart.b("刵圷夹氻䰽⼿㉁㝃ᩅ⥇㩉㱋恍⡏㽑㡓", num), BookmarkStart.b("圵䠷䨹倻圽⌿⍁ぃ⽅❇⑉捋㡍㹏㙑穓㥕⡗㽙㉛♝ൟ๡ɣ॥ᩧݩ൫ᩭͯ影᭳ၵṷ፹ύ᭽揄뺏ﶗﮝ쒟辡풣풥잧\udaa9\uc9ab\udcad\uc4af\udbb1\ud1b3억鎷승톻튽", num));
        if ((this.document_0.CustomDocumentProperties != null) && (this.document_0.CustomDocumentProperties.Count > 0))
        {
            this.method_510(stream, BookmarkStart.b("刵圷夹氻䰽⼿㉁㝃ᩅ⭇㽉㽋㩍㽏㽑穓⹕㕗㙙", num), BookmarkStart.b("圵䠷䨹倻圽⌿⍁ぃ⽅❇⑉捋㡍㹏㙑穓㥕⡗㽙㉛♝ൟ๡ɣ॥ᩧݩ൫ᩭͯ影᭳ၵṷ፹ύ᭽揄뺏뎝킟킡쮣횥춧\ud8a9\ud8ab잭햯솱龳캵햷횹", num));
        }
        this.method_506(stream);
        if (this.bool_18 && (this.int_11 > 0))
        {
            string str = BookmarkStart.b("䄵圷䠹堻戽␿ぁ╃ㅅⅇ⑉⭋㵍౏㙑♓㝕⽗㍙㉛㥝", num);
            for (int i = 1; i <= this.int_11; i++)
            {
                this.method_510(stream, str + i.ToString() + BookmarkStart.b("ᠵ䀷圹倻", num), BookmarkStart.b("圵䠷䨹倻圽⌿⍁ぃ⽅❇⑉捋㡍㹏㙑穓㥕⡗㽙㉛♝ൟ๡ɣ॥ᩧݩ൫ᩭͯ影᭳ၵṷ፹ύ᭽揄뺏劣춟캡誣얥삧쮩\udeab\udaad쎯\udab1\ud5b3욵\uddb7\uc9b9鞻욽궿껁", num));
            }
        }
        this.method_508(stream);
        this.class1092_0.method_12();
        this.class1092_0.method_15();
        this.class771_0.method_14(BookmarkStart.b("洵笷唹刻䨽┿ⱁぃ᥅᱇㍉㱋⭍⍏ད穓⹕㕗㙙", num), stream, false, FileAttributes.Archive);
    }

    private void method_502(Class1129 A_0, MemoryStream A_1)
    {
        int num = 11;
        if (this.bool_15)
        {
            Class1128 class2 = A_0.method_18(BookmarkStart.b("䘰尲䜴匶ᘸ强吼帾♀ㅂ⑄⩆㩈摊", num));
            if (class2 != null)
            {
                foreach (Class229 class3 in class2.method_0().Values)
                {
                    string str = BookmarkStart.b("䘰尲䜴匶ᘸ强吼帾♀ㅂ⑄⩆㩈摊", num) + class3.method_7();
                    string str2 = this.method_503(class3.method_7());
                    this.method_510(A_1, str, str2);
                }
            }
        }
    }

    private string method_503(string A_0)
    {
        int num = 14;
        if (A_0.StartsWith(BookmarkStart.b("倳圵䰷嬹", 14)))
        {
            return BookmarkStart.b("唳䘵䠷嘹唻崽ℿ㙁ⵃ⥅♇敉㩋⁍㑏籑㭓♕㵗㑙⑛㍝౟ѡୣᑥէ୩ᡫᵭ嵯ᵱታၵᅷ᥹᥻᩽ꂍﮛ첟財삣쾥즧충\udeab\ucfad\uddaf\uf6b1햳습\ud9b7\u91b9쒻펽겿", num);
        }
        if (A_0.StartsWith(BookmarkStart.b("圳夵吷唹主䴽", num)))
        {
            return BookmarkStart.b("唳䘵䠷嘹唻崽ℿ㙁ⵃ⥅♇敉㩋⁍㑏籑㭓♕㵗㑙⑛㍝౟ѡୣᑥէ୩ᡫᵭ嵯ᵱታၵᅷ᥹᥻᩽ꂍﮛ첟財삣쾥즧충\udeab\ucfad\uddaf\uf1b1\udbb3\udab5ힷ좹쾻閽뢿꿁ꣃ", num);
        }
        if (A_0.StartsWith(BookmarkStart.b("䔳䌵儷夹圻洽㐿㭁⡃⍅", num)))
        {
            return BookmarkStart.b("唳䘵䠷嘹唻崽ℿ㙁ⵃ⥅♇敉㩋⁍㑏籑㭓♕㵗㑙⑛㍝౟ѡୣᑥէ୩ᡫᵭ嵯ᵱታၵᅷ᥹᥻᩽ꂍﮛ첟財삣쾥즧충\udeab\ucfad\uddaf\uf1b1\udbb3\udab5ힷ좹쾻閽뢿꿁ꣃ", num);
        }
        if (A_0.StartsWith(BookmarkStart.b("崳䈵崷圹", num)))
        {
            return BookmarkStart.b("唳䘵䠷嘹唻崽ℿ㙁ⵃ⥅♇敉㩋⁍㑏籑㭓♕㵗㑙⑛㍝౟ѡୣᑥէ୩ᡫᵭ嵯ᵱታၵᅷ᥹᥻᩽ꂍ쒛첟횣즥\ud8a7\ucfa9\udeab\udaad\ud9af\ud7b1잳鶵삷ힹ킻", num);
        }
        return BookmarkStart.b("唳䘵䠷嘹唻崽ℿ㙁ⵃ⥅♇敉㩋⁍㑏籑㭓♕㵗㑙⑛㍝౟ѡୣᑥէ୩ᡫᵭ嵯ᵱታၵᅷ᥹᥻᩽ꂍﮛ첟財삣쾥즧충\udeab\ucfad\uddaf\ufeb1햳쾵ힷ쾹좻閽뢿꿁ꣃ", num);
    }

    private string method_504(string A_0)
    {
        int num = 4;
        if (A_0.ToLower().StartsWith(BookmarkStart.b("丩䌫䴭䔯弱儳堵䰷", 4)))
        {
            return BookmarkStart.b("䬩尫席尯嬱圳圵䰷匹医倽漿㑁⩃≅晇╉㱋⭍㹏⩑㥓㩕㹗㕙⹛㍝şᙡᝣ䭥ݧ౩੫ݭ፯᝱ၳ᥵᭷ཹᅻ᭽ꪃﺍ﶑잟쾡좣袥첧얩쾫\udbad\uddafힱ\udab3\uc2b5隷\uddb9\ud0bb톽뎿뇁ꗃ듅뇇듋ꏍ볏", num);
        }
        if (A_0.ToLower().StartsWith(BookmarkStart.b("天䤫娭䐯嬱娳儵䬷", num)))
        {
            return BookmarkStart.b("䬩尫席尯嬱圳圵䰷匹医倽漿㑁⩃≅晇╉㱋⭍㹏⩑㥓㩕㹗㕙⹛㍝şᙡᝣ䭥ݧ౩੫ݭ፯᝱ၳ᥵᭷ཹᅻ᭽ꪃﺍ﶑잟쾡좣袥\udba7\ucfa9\ud8ab\udaad\ud9af\udcb1펳억鎷승톻튽", num);
        }
        if (A_0.ToLower().StartsWith(BookmarkStart.b("天堫圭尯圱䜳䄵儷丹吻嬽☿⑁⅃╅㱇㥉", num)))
        {
            return BookmarkStart.b("䬩尫席尯嬱圳圵䰷匹医倽漿㑁⩃≅晇❉㽋捍❏㵑♓㉕癗⥙⡛❝౟ݡᝣㅥŧṩѫ⭭ᙯᑱᅳᕵ౷ॹ坻ٽ", num);
        }
        if (A_0.ToLower().StartsWith(BookmarkStart.b("崩䤫䰭䌯圱䀳䈵儷吹嬻䴽", num)))
        {
            return BookmarkStart.b("䬩尫席尯嬱圳圵䰷匹医倽漿㑁⩃≅晇╉㱋⭍㹏⩑㥓㩕㹗㕙⹛㍝şᙡᝣ䭥ݧ౩੫ݭ፯᝱ၳ᥵᭷ཹᅻ᭽ꪃﺍ﶑잟쾡좣袥\udfa7\ucfa9캫ﶭ햯욱삳\udfb5\ud6b7\uddb9\ucfbb閽뢿꿁ꣃ", num);
        }
        if (A_0.ToLower().StartsWith(BookmarkStart.b("䰩䌫䀭䐯䘱唳吵吷弹", num)))
        {
            return BookmarkStart.b("䬩尫席尯嬱圳圵䰷匹医倽漿㑁⩃≅晇╉㱋⭍㹏⩑㥓㩕㹗㕙⹛㍝şᙡᝣ䭥ݧ౩੫ݭ፯᝱ၳ᥵᭷ཹᅻ᭽ꪃﺍ﶑잟쾡좣袥캧얩슫\udaad\ue4af펱횳\udab5\uddb7醹쒻펽겿", num);
        }
        if (A_0.ToLower().StartsWith(BookmarkStart.b("天堫圭尯圱", num)))
        {
            return BookmarkStart.b("䬩尫席尯嬱圳圵䰷匹医倽漿㑁⩃≅晇╉㱋⭍㹏⩑㥓㩕㹗㕙⹛㍝şᙡᝣ䭥ݧ౩੫ݭ፯᝱ၳ᥵᭷ཹᅻ᭽ꪃﺍ﶑잟쾡좣袥\udba7\udea9햫슭햯솱龳캵햷횹", num);
        }
        return string.Empty;
    }

    private void method_505(MemoryStream A_0)
    {
        int num = 0x10;
        foreach (string str in this.method_19())
        {
            string key = str;
            if (key != null)
            {
                int num2;
                if (Class1160.dictionary_42 == null)
                {
                    Dictionary<string, int> dictionary1 = new Dictionary<string, int>(13);
                    dictionary1.Add(BookmarkStart.b("圵䠷䨹倻圽⌿⍁ぃ⽅❇⑉捋㡍㹏㙑穓㭕⭗睙㥛♝͟ݡࡣ", num), 0);
                    dictionary1.Add(BookmarkStart.b("圵䠷䨹倻圽⌿⍁ぃ⽅❇⑉捋㡍㹏㙑穓㥕⡗㽙㉛♝ൟ๡ɣ॥ᩧݩ൫ᩭͯ影᭳ၵṷ፹ύ᭽揄뺏ﶗﮙ좟잡솣튥얧용芫\uddad\ud8afힱ톳습", num), 1);
                    dictionary1.Add(BookmarkStart.b("圵䠷䨹倻圽⌿⍁ぃ⽅❇⑉捋㡍㹏㙑穓㭕⭗睙ⱛㅝ᝟ݡᙣᙥݧͩɫᩭ", num), 2);
                    dictionary1.Add(BookmarkStart.b("圵䠷䨹倻圽⌿⍁ぃ⽅❇⑉捋㡍㹏㙑穓㥕⡗㽙㉛♝ൟ๡ɣ॥ᩧݩ൫ᩭͯ影᭳ၵṷ፹ύ᭽揄뺏ﾙ솟횡춣즥욧잩삫肭삯삱톳억\uddb7\ud4b9좻\udfbd\ub4bfꯁꯃꣅ", num), 3);
                    dictionary1.Add(BookmarkStart.b("圵䠷䨹倻圽⌿⍁ぃ⽅❇⑉捋⍍⍏║㭓⑕㱗", num), 4);
                    dictionary1.Add(BookmarkStart.b("圵䠷䨹倻圽⌿⍁ぃ⽅❇⑉捋㡍㹏㙑穓㥕⡗㽙㉛♝ൟ๡ɣ॥ᩧݩ൫ᩭͯ影᭳ၵṷ፹ύ᭽揄뺏ﮓﲗ쎟잡힣향솧쒩쮫쎭\udcaf\u9cb1킳\ud9b5\udbb7쾹톻\udbbd\uaebf뛁", num), 5);
                    dictionary1.Add(BookmarkStart.b("圵䠷䨹倻圽⌿⍁ぃ⽅❇⑉捋㡍㹏㙑穓㭕⭗睙⭛ㅝ቟١䩣ɥݧ३ᥫͭᕯᱱs塵ᕷ᭹ύ౽잁뺏ꎑꚓ", num), 6);
                    dictionary1.Add(BookmarkStart.b("圵䠷䨹倻圽⌿⍁ぃ⽅❇⑉捋㡍㹏㙑穓㭕⭗睙㥛♝͟ݡࡣ䡥᭧ɩ५୭ѯ山ᙳήᙷ᭹๻ݽ깿慎즋ﲗ뒙궛겝", num), 7);
                    dictionary1.Add(BookmarkStart.b("圵䠷䨹倻圽⌿⍁ぃ⽅❇⑉捋㡍㹏㙑穓㭕⭗睙㥛♝͟ݡࡣ䡥᭧ɩ५୭ѯ山ᥳ᝵᭷ࡹ፻㭽ꊋ뾍ꊏ", num), 8);
                    dictionary1.Add(BookmarkStart.b("圵䠷䨹倻圽⌿⍁ぃ⽅❇⑉捋㡍㹏㙑穓㭕⭗睙ⱛㅝ᝟ݡᙣᙥݧͩɫᩭ幯ɱٳ፵୷όቻ੽ꒉﮓ펕ﮙﺛ얟욡誣鞥骧", num), 9);
                    dictionary1.Add(BookmarkStart.b("圵䠷䨹倻圽⌿⍁ぃ⽅❇⑉捋㡍㹏㙑穓㭕⭗睙ⱛㅝ᝟ݡᙣᙥݧͩɫᩭ幯űᡳήᱷό剻፽춇ﲏ뢕ꦗꢙ", num), 10);
                    dictionary1.Add(BookmarkStart.b("圵䠷䨹倻圽⌿⍁ぃ⽅❇⑉捋㡍㹏㙑穓㥕⡗㽙㉛♝ൟ๡ɣ॥ᩧݩ൫ᩭͯ影᭳ၵṷ፹ύ᭽揄뺏ﾙ솟횡춣즥욧잩삫肭쎯\udeb1\uddb3튵\uddb7", num), 11);
                    dictionary1.Add(BookmarkStart.b("圵䠷䨹倻圽⌿⍁ぃ⽅❇⑉捋㡍㹏㙑穓㭕⭗睙⩛㝝፟ୡୣ䡥౧ᡩ൫ᥭ᥯ᱱ፳", num), 12);
                    Class1160.dictionary_42 = dictionary1;
                }
                if (Class1160.dictionary_42.TryGetValue(key, out num2))
                {
                    switch (num2)
                    {
                        case 0:
                        {
                            this.method_509(A_0, BookmarkStart.b("丵吷䤹", num), str);
                            continue;
                        }
                        case 1:
                        {
                            this.method_509(A_0, BookmarkStart.b("丵吷䤹䐻", num), str);
                            continue;
                        }
                        case 2:
                        {
                            this.method_509(A_0, BookmarkStart.b("䘵䠷丹", num), str);
                            continue;
                        }
                        case 3:
                        {
                            this.method_509(A_0, BookmarkStart.b("䘵䠷丹䐻", num), str);
                            continue;
                        }
                        case 4:
                        {
                            this.method_509(A_0, BookmarkStart.b("刵圷夹", num), str);
                            continue;
                        }
                        case 5:
                        {
                            this.method_509(A_0, BookmarkStart.b("刵圷夹䐻", num), str);
                            continue;
                        }
                        case 6:
                        {
                            this.method_509(A_0, BookmarkStart.b("刵圷夹儻", num), str);
                            continue;
                        }
                        case 7:
                        {
                            this.method_509(A_0, BookmarkStart.b("丵吷䤹帻", num), str);
                            continue;
                        }
                        case 8:
                        {
                            this.method_509(A_0, BookmarkStart.b("丵吷䤹儻", num), str);
                            continue;
                        }
                        case 9:
                        {
                            this.method_509(A_0, BookmarkStart.b("䘵䠷丹儻", num), str);
                            continue;
                        }
                        case 10:
                        {
                            this.method_509(A_0, BookmarkStart.b("䔵吷帹儻", num), str);
                            continue;
                        }
                        case 11:
                        {
                            this.method_509(A_0, BookmarkStart.b("䔵吷帹䐻", num), str);
                            continue;
                        }
                        case 12:
                        {
                            this.method_509(A_0, BookmarkStart.b("䀵䬷帹䐻", num), str);
                            continue;
                        }
                    }
                }
            }
            this.method_509(A_0, BookmarkStart.b("吵儷吹", num), str);
        }
    }

    private void method_506(MemoryStream A_0)
    {
        this.method_507(HeaderFooterType.FooterEven, A_0);
        this.method_507(HeaderFooterType.HeaderEven, A_0);
        this.method_507(HeaderFooterType.FooterFirstPage, A_0);
        this.method_507(HeaderFooterType.HeaderFirstPage, A_0);
        this.method_507(HeaderFooterType.FooterOdd, A_0);
        this.method_507(HeaderFooterType.HeaderOdd, A_0);
    }

    private void method_507(HeaderFooterType A_0, MemoryStream A_1)
    {
        int num = 0x11;
        if (this.method_1().ContainsKey(A_0))
        {
            Dictionary<string, HeaderFooter> dictionary = this.method_1()[A_0];
            foreach (string str in dictionary.Keys)
            {
                string str2;
                string str3;
                if (((A_0 != HeaderFooterType.HeaderEven) && (A_0 != HeaderFooterType.HeaderFirstPage)) && (A_0 != HeaderFooterType.HeaderOdd))
                {
                    str2 = BookmarkStart.b("䀶嘸䤺夼挾❀ⱂ⩄㍆ⱈ㥊", num) + str.Replace(BookmarkStart.b("䔶瀸强", num), "") + BookmarkStart.b("ᤶ䄸嘺儼", num);
                    str3 = BookmarkStart.b("嘶䤸䬺儼嘾≀≂ㅄ⹆♈╊扌㥎㽐㝒答㡖⥘㹚㍜❞ౠརͤࡦ᭨٪౬᭮ɰ干ᩴᅶὸቺṼ᩾ﮎ뾐杖ﶘ슠욢횤풦삨얪쪬슮\uddb0\u9db2펴\ud8b6\ud6b8쾺\ud8bc\ucdbe믂꣄ꯆ", num);
                }
                else
                {
                    str2 = BookmarkStart.b("䀶嘸䤺夼挾⥀♂⑄⍆ⱈ㥊", num) + str.Replace(BookmarkStart.b("䔶瀸强", num), "") + BookmarkStart.b("ᤶ䄸嘺儼", num);
                    str3 = BookmarkStart.b("嘶䤸䬺儼嘾≀≂ㅄ⹆♈╊扌㥎㽐㝒答㡖⥘㹚㍜❞ౠརͤࡦ᭨٪౬᭮ɰ干ᩴᅶὸቺṼ᩾ﮎ뾐杖ﶘ슠욢횤풦삨얪쪬슮\uddb0\u9db2\uddb4\ud2b6\ud8b8\udfba\ud8bc\ucdbe믂꣄ꯆ", num);
                }
                this.method_510(A_1, str2, str3);
            }
        }
    }

    private void method_508(MemoryStream A_0)
    {
        int num = 0x10;
        if (this.method_3().Count > 0)
        {
            if (!this.bool_7 || !this.method_19().Contains(BookmarkStart.b("圵䠷䨹倻圽⌿⍁ぃ⽅❇⑉捋㡍㹏㙑穓㥕⡗㽙㉛♝ൟ๡ɣ॥ᩧݩ൫ᩭͯ影᭳ၵṷ፹ύ᭽揄뺏ﶗﮙ좟잡솣튥얧용芫\uddad\ud8afힱ톳습", num)))
            {
                this.method_509(A_0, BookmarkStart.b("丵吷䤹䐻", num), BookmarkStart.b("圵䠷䨹倻圽⌿⍁ぃ⽅❇⑉捋㡍㹏㙑穓㥕⡗㽙㉛♝ൟ๡ɣ॥ᩧݩ൫ᩭͯ影᭳ၵṷ፹ύ᭽揄뺏ﶗﮙ좟잡솣튥얧용芫\uddad\ud8afힱ톳습", num));
            }
            int count = this.method_3().Count;
            for (int i = 0; i < count; i++)
            {
                this.method_510(A_0, this.method_3()[i], BookmarkStart.b("圵䠷䨹倻圽⌿⍁ぃ⽅❇⑉捋㡍㹏㙑穓㥕⡗㽙㉛♝ൟ๡ɣ॥ᩧݩ൫ᩭͯ影᭳ၵṷ፹ύ᭽揄뺏劣춟캡誣얥삧쮩\udeab\udaad鮯쪱\ud9b3\udab5", num));
            }
        }
        if (this.method_2().Count > 0)
        {
            if (!this.document_0.IsContainMacro)
            {
                this.method_509(A_0, BookmarkStart.b("吵儷吹", num), BookmarkStart.b("圵䠷䨹倻圽⌿⍁ぃ⽅❇⑉捋㡍㹏㙑穓㭕⭗睙㍛㡝ٟୡݣͥ䙧୩ཫᩭ᥯ѱᅳ⹵", num));
            }
            int num2 = 0;
            int num3 = this.method_2().Count;
            while (num2 < num3)
            {
                if (this.method_2()[num2].EndsWith(BookmarkStart.b("吵儷吹", num)))
                {
                    this.method_510(A_0, this.method_2()[num2], BookmarkStart.b("圵䠷䨹倻圽⌿⍁ぃ⽅❇⑉捋㡍㹏㙑穓㭕⭗睙㍛㡝ٟୡݣͥ䙧୩ཫᩭ᥯ѱᅳ⹵", num));
                }
                else
                {
                    this.method_510(A_0, this.method_2()[num2], BookmarkStart.b("圵䠷䨹倻圽⌿⍁ぃ⽅❇⑉捋㡍㹏㙑穓㭕⭗睙㍛㡝ٟୡݣͥ䙧୩ཫᩭ᥯ѱᅳ⹵卷ɹᅻች", num));
                }
                num2++;
            }
        }
    }

    private void method_509(MemoryStream A_0, string A_1, string A_2)
    {
        this.class1092_0.method_9(BookmarkStart.b("簷弹娻弽㔿⹁ぃ", 0x12));
        this.class1092_0.method_4(BookmarkStart.b("紷䈹䠻嬽⸿ㅁⵃ⥅♇", 0x12), A_1);
        this.class1092_0.method_4(BookmarkStart.b("笷唹刻䨽┿ⱁぃቅㅇ㩉⥋", 0x12), A_2);
        this.class1092_0.method_12();
    }

    private void method_51(Document A_0)
    {
        this.document_0 = A_0;
        this.method_73();
        this.method_443();
        this.method_428();
        this.method_413();
        this.method_424();
        this.method_513();
        this.method_516();
        this.method_57();
        this.method_440();
        if ((this.document_0.CustomDocumentProperties != null) && (this.document_0.CustomDocumentProperties.Count > 0))
        {
            this.method_514();
        }
        if (this.document_0.IsContainMacro && this.document_0.IsMacroEnabled)
        {
            this.method_75();
            this.method_76();
        }
        this.method_415();
        this.method_426();
        if (this.method_25().Count > 0)
        {
            this.method_101();
        }
        this.method_77();
        if (this.bool_8)
        {
            this.method_375();
            if (((this.method_42().Count > 0) || (this.method_9().Count > 0)) || (this.method_21().Count > 0))
            {
                this.method_99();
            }
            this.method_378();
        }
        if (this.method_30())
        {
            this.method_224(true);
            if (((this.method_41().Count > 0) || (this.method_12().Count > 0)) || (this.method_23().Count > 0))
            {
                this.method_97();
            }
        }
        if (this.method_28())
        {
            this.method_224(false);
            if (((this.method_40().Count > 0) || (this.method_11().Count > 0)) || (this.method_22().Count > 0))
            {
                this.method_98();
            }
        }
        if (this.bool_15)
        {
            this.method_88(this.document_0.DocxPackage);
        }
        this.method_100();
        if (this.method_3().Count > 0)
        {
            this.method_87(this.document_0.DocxPackage);
        }
        if (this.method_2().Count > 0)
        {
            this.method_89(this.document_0.DocxPackage);
        }
        if (this.document_0.CustomUIPartContainer != null)
        {
            this.method_55(this.document_0.CustomUIPartContainer);
        }
        if (this.document_0.CustomXMLContainer != null)
        {
            this.method_55(this.document_0.CustomXMLContainer);
        }
        if (this.document_0.IsSaveTemplate && (this.document_0.GlossaryContainer != null))
        {
            this.method_55(this.document_0.GlossaryContainer);
        }
        this.method_511();
        if (this.document_0.IsContainMacro && this.document_0.IsMacroEnabled)
        {
            this.method_74();
        }
        this.method_501();
    }

    private void method_510(MemoryStream A_0, string A_1, string A_2)
    {
        this.class1092_0.method_9(BookmarkStart.b("栦弨个弬崮堰圲倴", 1));
        this.class1092_0.method_4(BookmarkStart.b("眦䠨太夬愮倰帲倴", 1), BookmarkStart.b("ࠦ", 1) + A_1.Replace(BookmarkStart.b("符", 1), BookmarkStart.b("ࠦ", 1)));
        this.class1092_0.method_4(BookmarkStart.b("搦䘨䔪夬䨮弰䜲愴丶䤸帺", 1), A_2);
        this.class1092_0.method_12();
    }

    private void method_511()
    {
        int num = 3;
        this.dictionary_32 = this.document_0.DocxNameSpace.method_0()[BookmarkStart.b("笨个䄬丮䔰娲娴夶䨸区吼伾㉀", 3)];
        MemoryStream stream = new MemoryStream();
        this.class1092_0 = this.method_524(stream);
        this.method_526();
        this.class1092_0.method_10(BookmarkStart.b("笨个䄬丮䔰娲娴夶䨸区吼伾㉀", 3), this.dictionary_32[BookmarkStart.b("儨䘪䄬䄮䈰", 3)]);
        this.method_512(stream, this.method_527(), BookmarkStart.b("䄨弪夬弮ରᰲᨴ䐶娸区堼刾⁀あ歄⡆㥈⹊⍌㝎㱐㽒㍔㡖⭘㙚㱜⭞በ䵢੤ᕦ๨䑪ɬ८ᝰᩲᙴቶ㵸ᑺṼ੾Ꚉ릊붌뾎Ꞑ벒漢캠춢횤쾦삨\udbaa\udeac肮\udeb0\ud5b2펴\udeb6\udab8\udeba\uf9bc킾ꋀ뛂꣄ꋆꟈ뿊", 3), BookmarkStart.b("帨䐪弬䬮洰圲娴吶䰸嘺堼儾㕀浂㵄⩆╈", 3));
        this.method_512(stream, this.method_527(), BookmarkStart.b("䄨弪夬弮ରᰲᨴ䐶娸区堼刾⁀あ歄⡆㥈⹊⍌㝎㱐㽒㍔㡖⭘㙚㱜⭞በ䵢੤ᕦ๨䑪ɬ८ᝰᩲᙴቶ㵸ᑺṼ੾Ꚉ릊붌뾎Ꞑ벒漢캠춢횤쾦삨\udbaa\udeac肮풰쮲솴튶ힸ\udfba\ud8bc\udbbe\uecc0돂럄꣆마껊뿌믎룐뛒ꛔ", 3), BookmarkStart.b("䴨䐪丬缮䌰尲䔴䐶攸娺䴼伾潀㭂⡄⭆", 3));
        this.method_512(stream, this.method_527(), BookmarkStart.b("䄨弪夬弮ରᰲᨴ䐶娸区堼刾⁀あ歄⡆㥈⹊⍌㝎㱐㽒㍔㡖⭘㙚㱜⭞በ䵢੤ᕦ๨䑪ᵬ๮ተᡲᑴၶᱸ呺佼佾놀떂ꪄﮎﲒﮔ躠캢삤펦좨쾪첬\udbae\ud0b0鲲횴\ud8b6\ucbb8\udeba\u90bc쾾돀곂뗄ꋆ믈뿊꓌꫎ꋐ", 3), BookmarkStart.b("䴨䐪丬缮䌰尲䔴䐶攸堺刼䴾⑀浂㵄⩆╈", 3));
        if ((this.document_0.CustomDocumentProperties != null) && (this.document_0.CustomDocumentProperties.Count > 0))
        {
            this.method_512(stream, this.method_527(), BookmarkStart.b("䄨弪夬弮ରᰲᨴ䐶娸区堼刾⁀あ歄⡆㥈⹊⍌㝎㱐㽒㍔㡖⭘㙚㱜⭞በ䵢੤ᕦ๨䑪ɬ८ᝰᩲᙴቶ㵸ᑺṼ੾Ꚉ릊붌뾎Ꞑ벒漢캠춢횤쾦삨\udbaa\udeac肮튰욲운쎶횸횺邼쾾돀곂뗄ꋆ믈뿊꓌꫎ꋐ", num), BookmarkStart.b("䴨䐪丬缮䌰尲䔴䐶攸堺䠼䰾㕀ⱂ⡄楆ㅈ♊⅌", num));
        }
        if (this.document_0.CustomUIPartContainer != null)
        {
            this.method_512(stream, this.method_527(), BookmarkStart.b("䄨弪夬弮ରᰲᨴ䐶娸区堼刾⁀あ歄⩆⁈⡊㽌⁎≐㱒㍔⍖睘㡚㉜㉞习ౢͤŦhࡪ࡬䁮䍰䍲䕴䅶噸ॺ᡼፾몔뒚햠욢쮤풦삨즪쒬쎮\ud8b0\uc7b2체", num), BookmarkStart.b("䨨帪帬嬮帰帲怴縶ᘸ堺䠼䰾㕀ⱂ⡄ቆH敊㕌≎㵐", num));
        }
        this.class1092_0.method_12();
        this.class1092_0.method_15();
        this.class771_0.method_14(BookmarkStart.b("瘨太䠬䌮䈰漲᬴䔶尸场丼", num), stream, false, FileAttributes.Archive);
    }

    private void method_512(Stream A_0, string A_1, string A_2, string A_3)
    {
        int num = 10;
        this.class1092_0.method_9(BookmarkStart.b("戯圱堳圵䰷匹医倽㌿⩁ⵃ㙅", 10));
        this.class1092_0.method_4(BookmarkStart.b("礯嘱", 10), A_1);
        this.class1092_0.method_4(BookmarkStart.b("搯䬱䐳匵", 10), A_2);
        char ch = '\v';
        this.class1092_0.method_4(BookmarkStart.b("搯匱䘳儵崷丹", 10), A_3.Replace(BookmarkStart.b("氯", 10), BookmarkStart.b("Ἧ", 10)).Replace(ch.ToString(), string.Empty).Replace(BookmarkStart.b("య", 10), BookmarkStart.b("ᔯı圳", 10)).Replace(BookmarkStart.b("ฯ", 10), BookmarkStart.b("ᔯı儳", 10)));
        if (((A_2 == BookmarkStart.b("堯䘱䀳䘵ȷᔹጻ䴽⌿⩁⅃⭅⥇㥉手⅍⁏㝑㩓⹕㕗㙙㩛ㅝ቟ཡգብ᭧䑩ͫᱭᝯ嵱᭳ၵṷ፹ύ᭽쑿揄뾏ꂑ꒓ꚕ꺗떙ﮝ첟쎡킣쾥잧쒩\udfab\uc6ad\ud9af\uc2b1잳馵킷쎹첻\udbbd\ub2bf껁귃ꣅꏇ", 10)) || A_3.StartsWith(BookmarkStart.b("堯䘱䀳䘵ȷᔹጻ", num))) || (A_3.StartsWith(BookmarkStart.b("嘯嬱堳匵ȷᔹጻ", num)) || string.IsNullOrEmpty(A_3)))
        {
            this.class1092_0.method_4(BookmarkStart.b("搯匱䘳儵崷丹焻儽␿❁", num), BookmarkStart.b("甯䨱䀳匵䨷吹崻刽", num));
        }
        this.class1092_0.method_12();
    }

    private void method_513()
    {
        int num = 13;
        this.dictionary_32 = this.document_0.DocxNameSpace.method_0()[BookmarkStart.b("倲娴䔶尸欺似倾ㅀ♂㝄㍆⁈⹊㹌", 13)];
        MemoryStream stream = new MemoryStream();
        this.class1092_0 = this.method_524(stream);
        BuiltinDocumentProperties builtinDocumentProperties = this.document_0.BuiltinDocumentProperties;
        this.class1092_0.method_11(BookmarkStart.b("倲䔴", 13), BookmarkStart.b("倲娴䔶尸欺似倾ㅀ♂㝄㍆⁈⹊㹌", 13), this.dictionary_32[BookmarkStart.b("倲䔴", 13)]);
        this.class1092_0.method_6(BookmarkStart.b("䬲場嬶圸䠺", 13), BookmarkStart.b("倲䔴", 13), null, this.dictionary_32[BookmarkStart.b("倲䔴", 13)]);
        this.class1092_0.method_6(BookmarkStart.b("䬲場嬶圸䠺", 13), BookmarkStart.b("圲嘴", 13), null, this.dictionary_32[BookmarkStart.b("圲嘴", 13)]);
        this.class1092_0.method_6(BookmarkStart.b("䬲場嬶圸䠺", 13), BookmarkStart.b("圲嘴䌶尸䤺值䰾", 13), null, this.dictionary_32[BookmarkStart.b("圲嘴䌶尸䤺值䰾", 13)]);
        this.class1092_0.method_6(BookmarkStart.b("䬲場嬶圸䠺", 13), BookmarkStart.b("圲嘴娶倸伺䐼伾⑀", 13), null, this.dictionary_32[BookmarkStart.b("圲嘴娶倸伺䐼伾⑀", 13)]);
        this.class1092_0.method_6(BookmarkStart.b("䬲場嬶圸䠺", 13), BookmarkStart.b("䬲䘴帶", 13), null, this.dictionary_32[BookmarkStart.b("䬲䘴帶", 13)]);
        if (builtinDocumentProperties != null)
        {
            if (builtinDocumentProperties.Title != null)
            {
                this.class1092_0.method_11(BookmarkStart.b("圲嘴", num), BookmarkStart.b("䜲尴䌶唸帺", num), this.dictionary_32[BookmarkStart.b("圲嘴", num)]);
                this.class1092_0.method_21(this.method_515(builtinDocumentProperties.Title));
                this.class1092_0.method_12();
            }
            if (builtinDocumentProperties.Subject != null)
            {
                this.class1092_0.method_11(BookmarkStart.b("圲嘴", num), BookmarkStart.b("䀲䀴唶匸帺帼䬾", num), this.dictionary_32[BookmarkStart.b("圲嘴", num)]);
                this.class1092_0.method_21(this.method_515(builtinDocumentProperties.Subject));
                this.class1092_0.method_12();
            }
            if (builtinDocumentProperties.Author != null)
            {
                this.class1092_0.method_11(BookmarkStart.b("圲嘴", num), BookmarkStart.b("倲䜴制堸伺刼䴾", num), this.dictionary_32[BookmarkStart.b("圲嘴", num)]);
                this.class1092_0.method_21(this.method_515(builtinDocumentProperties.Author));
                this.class1092_0.method_12();
            }
            if (builtinDocumentProperties.Keywords != null)
            {
                this.class1092_0.method_10(BookmarkStart.b("堲倴丶丸吺似嬾㉀", num), this.dictionary_32[BookmarkStart.b("倲䔴", num)]);
                this.class1092_0.method_21(builtinDocumentProperties.Keywords);
                this.class1092_0.method_12();
            }
            if (builtinDocumentProperties.Comments != null)
            {
                this.class1092_0.method_11(BookmarkStart.b("圲嘴", num), BookmarkStart.b("圲倴䐶娸䤺吼伾㕀⩂⩄⥆", num), this.dictionary_32[BookmarkStart.b("圲嘴", num)]);
                this.class1092_0.method_21(builtinDocumentProperties.Comments);
                this.class1092_0.method_12();
            }
            if (builtinDocumentProperties.LastAuthor != null)
            {
                this.class1092_0.method_10(BookmarkStart.b("弲吴䐶䴸瘺刼嬾⡀╂ⱄ≆ⵈॊ㑌", num), this.dictionary_32[BookmarkStart.b("倲䔴", num)]);
                this.class1092_0.method_21(builtinDocumentProperties.LastAuthor);
                this.class1092_0.method_12();
            }
            DateTime lastPrinted = builtinDocumentProperties.LastPrinted;
            if (builtinDocumentProperties.LastPrinted != DateTime.MinValue)
            {
                this.class1092_0.method_10(BookmarkStart.b("弲吴䐶䴸欺似嘾⽀㝂⁄⍆", num), this.dictionary_32[BookmarkStart.b("倲䔴", num)]);
                string str = XmlConvert.ToString(builtinDocumentProperties.LastPrinted, XmlDateTimeSerializationMode.Utc);
                this.class1092_0.method_21(str);
                this.class1092_0.method_12();
            }
            if (builtinDocumentProperties.RevisionNumber != null)
            {
                this.class1092_0.method_10(BookmarkStart.b("䄲倴䄶倸䠺吼倾⽀", num), this.dictionary_32[BookmarkStart.b("倲䔴", num)]);
                int num2 = 1;
                if (builtinDocumentProperties.RevisionNumber != BookmarkStart.b("紲吴礶", num))
                {
                    try
                    {
                        num2 = int.Parse(builtinDocumentProperties.RevisionNumber);
                    }
                    catch
                    {
                    }
                }
                this.class1092_0.method_21(num2.ToString());
                this.class1092_0.method_12();
            }
            string str2 = null;
            if (builtinDocumentProperties.CreateDate != DateTime.Now)
            {
                this.class1092_0.method_11(BookmarkStart.b("圲嘴䌶尸䤺值䰾", num), BookmarkStart.b("倲䜴制堸伺堼嬾", num), this.dictionary_32[BookmarkStart.b("圲嘴䌶尸䤺值䰾", num)]);
                this.class1092_0.method_6(BookmarkStart.b("䬲䘴帶", num), BookmarkStart.b("䜲䰴䜶尸", num), this.dictionary_32[BookmarkStart.b("䬲䘴帶", num)], BookmarkStart.b("圲嘴䌶尸䤺值䰾筀ᑂ癄цൈὊୌ", num));
                str2 = null;
                str2 = XmlConvert.ToString(builtinDocumentProperties.CreateDate, XmlDateTimeSerializationMode.Utc);
                this.class1092_0.method_21(str2);
                this.class1092_0.method_12();
            }
            if (builtinDocumentProperties.LastSaveDate != DateTime.Now)
            {
                this.class1092_0.method_11(BookmarkStart.b("圲嘴䌶尸䤺值䰾", num), BookmarkStart.b("帲娴匶倸崺吼娾╀", num), this.dictionary_32[BookmarkStart.b("圲嘴䌶尸䤺值䰾", num)]);
                this.class1092_0.method_6(BookmarkStart.b("䬲䘴帶", num), BookmarkStart.b("䜲䰴䜶尸", num), this.dictionary_32[BookmarkStart.b("䬲䘴帶", num)], BookmarkStart.b("圲嘴䌶尸䤺值䰾筀ᑂ癄цൈὊୌ", num));
                str2 = XmlConvert.ToString(builtinDocumentProperties.LastSaveDate, XmlDateTimeSerializationMode.Utc);
                this.class1092_0.method_21(str2);
                this.class1092_0.method_12();
            }
            if (builtinDocumentProperties.Category != null)
            {
                this.class1092_0.method_10(BookmarkStart.b("倲吴䌶尸尺刼䴾㡀", num), this.dictionary_32[BookmarkStart.b("倲䔴", num)]);
                this.class1092_0.method_21(this.method_515(builtinDocumentProperties.Category));
                this.class1092_0.method_12();
            }
        }
        this.class1092_0.method_12();
        this.class1092_0.method_15();
        this.class771_0.method_14(BookmarkStart.b("圲娴吶椸䤺刼伾㉀ὂ♄⡆㭈⹊捌㝎㱐㽒", num), stream, false, FileAttributes.Archive);
    }

    private void method_514()
    {
        int num = 9;
        this.dictionary_32 = this.document_0.DocxNameSpace.method_0()[BookmarkStart.b("䰮䐰䀲䄴朶䬸吺䴼娾㍀㝂ⱄ≆㩈", 9)];
        MemoryStream stream = new MemoryStream();
        this.class1092_0 = this.method_524(stream);
        CustomDocumentProperties customDocumentProperties = this.document_0.CustomDocumentProperties;
        this.class1092_0.method_10(BookmarkStart.b("缮䌰尲䔴制䬸伺吼娾㉀", 9), this.dictionary_32[BookmarkStart.b("圮尰弲嬴䐶", 9)]);
        this.class1092_0.method_6(BookmarkStart.b("圮尰弲嬴䐶", 9), BookmarkStart.b("央䔰", 9), null, this.dictionary_32[BookmarkStart.b("央䔰", 9)]);
        int num2 = 1;
        string str = string.Empty;
        if (customDocumentProperties != null)
        {
            foreach (string str3 in customDocumentProperties.CustomHash.Keys)
            {
                str = str3;
                if (Class863.smethod_8(customDocumentProperties.CustomHash[str]))
                {
                    this.class1092_0.method_9(BookmarkStart.b("弮䌰尲䔴制䬸伺䐼", num));
                    this.class1092_0.method_4(BookmarkStart.b("䤮尰䜲尴匶", num), BookmarkStart.b("吮田ز瘴猶紸ฺ഼ਾ汀煂D繆ੈ晊籌罎恐ᅒ硔湖橘扚橜牞兠孢啤坦孨⥪彬Ɱ㝰䩲㑴㉶Ѹ", num));
                    string str4 = string.Empty;
                    str4 = str3;
                    this.class1092_0.method_4(BookmarkStart.b("䄮倰帲倴", num), str4);
                    this.class1092_0.method_4(BookmarkStart.b("弮堰圲", num), ++num2.ToString());
                    DocumentProperty property = customDocumentProperties.method_7(str3);
                    switch (property.PropertyType)
                    {
                        case PropertyType.Int32:
                            this.class1092_0.method_10(BookmarkStart.b("䘮԰", num), this.dictionary_32[BookmarkStart.b("央䔰", num)]);
                            this.class1092_0.method_21(XmlConvert.ToString(property.Int32));
                            this.class1092_0.method_12();
                            break;

                        case PropertyType.Double:
                            this.class1092_0.method_10(BookmarkStart.b("崮र", num), this.dictionary_32[BookmarkStart.b("央䔰", num)]);
                            this.class1092_0.method_21(XmlConvert.ToString(property.Double));
                            this.class1092_0.method_12();
                            break;

                        case PropertyType.Bool:
                            this.class1092_0.method_10(BookmarkStart.b("䴮帰尲头", num), this.dictionary_32[BookmarkStart.b("央䔰", num)]);
                            this.class1092_0.method_21(XmlConvert.ToString(property.Boolean));
                            this.class1092_0.method_12();
                            break;

                        case PropertyType.AsciiString:
                            this.class1092_0.method_10(BookmarkStart.b("䌮䄰䀲䄴䔶", num), this.dictionary_32[BookmarkStart.b("央䔰", num)]);
                            this.class1092_0.method_21(this.method_515(property.Text));
                            this.class1092_0.method_12();
                            break;

                        case PropertyType.String:
                            this.class1092_0.method_10(BookmarkStart.b("䌮䄰䐲䘴䌶䬸", num), this.dictionary_32[BookmarkStart.b("央䔰", num)]);
                            this.class1092_0.method_21(this.method_515(property.Text));
                            this.class1092_0.method_12();
                            break;

                        case PropertyType.DateTime:
                        {
                            this.class1092_0.method_10(BookmarkStart.b("䤮堰弲倴䌶倸嘺堼", num), this.dictionary_32[BookmarkStart.b("央䔰", num)]);
                            string str2 = string.Empty;
                            str2 = XmlConvert.ToString(property.ToDateTime(), XmlDateTimeSerializationMode.Utc);
                            this.class1092_0.method_21(str2);
                            this.class1092_0.method_12();
                            break;
                        }
                        case PropertyType.Int:
                            this.class1092_0.method_10(BookmarkStart.b("䘮԰", num), this.dictionary_32[BookmarkStart.b("央䔰", num)]);
                            this.class1092_0.method_21(XmlConvert.ToString(property.Integer));
                            this.class1092_0.method_12();
                            break;
                    }
                    this.class1092_0.method_12();
                }
            }
        }
        this.class1092_0.method_12();
        this.class1092_0.method_15();
        this.class771_0.method_14(BookmarkStart.b("䬮帰倲攴䔶嘸䬺丼挾≀㙂㙄㍆♈♊捌㝎㱐㽒", num), stream, true, FileAttributes.Archive);
    }

    private string method_515(string A_0)
    {
        int num = 7;
        A_0 = string.IsNullOrEmpty(A_0) ? string.Empty : XmlConvert.EncodeNmToken(A_0);
        A_0 = A_0.Replace(BookmarkStart.b("爬圮İ̲ܴܶ昸", num), BookmarkStart.b("ബ", num));
        return A_0;
    }

    private void method_516()
    {
        int num = 0x10;
        this.dictionary_32 = this.document_0.DocxNameSpace.method_0()[BookmarkStart.b("圵䠷䨹氻䰽⼿㉁⅃㑅㱇⍉⥋㵍", 0x10)];
        MemoryStream stream = new MemoryStream();
        BuiltinDocumentProperties builtinDocumentProperties = this.document_0.BuiltinDocumentProperties;
        this.class1092_0 = this.method_524(stream);
        this.class1092_0.method_10(BookmarkStart.b("昵䨷唹䰻嬽㈿㙁ⵃ⍅㭇", 0x10), this.dictionary_32[BookmarkStart.b("丵唷嘹刻䴽", 0x10)]);
        this.class1092_0.method_6(BookmarkStart.b("丵唷嘹刻䴽", 0x10), BookmarkStart.b("䀵䰷", 0x10), null, this.dictionary_32[BookmarkStart.b("䀵䰷", 0x10)]);
        if (builtinDocumentProperties != null)
        {
            if (builtinDocumentProperties.Template != null)
            {
                this.class1092_0.method_9(BookmarkStart.b("戵崷圹䰻刽ℿ㙁⅃", num));
                this.class1092_0.method_21(builtinDocumentProperties.Template);
                this.class1092_0.method_12();
            }
            if (builtinDocumentProperties.TotalEditingTime != TimeSpan.MinValue)
            {
                this.class1092_0.method_9(BookmarkStart.b("戵圷丹崻刽ᐿ⭁⥃⍅", num));
                this.class1092_0.method_21(builtinDocumentProperties.TotalEditingTime.TotalMinutes.ToString());
                this.class1092_0.method_12();
            }
            if (builtinDocumentProperties.PageCount != -2147483648)
            {
                this.class1092_0.method_9(BookmarkStart.b("昵夷崹夻䴽", num));
                this.class1092_0.method_21(builtinDocumentProperties.PageCount.ToString());
                this.class1092_0.method_12();
            }
            if (builtinDocumentProperties.WordCount != -2147483648)
            {
                this.class1092_0.method_9(BookmarkStart.b("愵圷䠹堻䴽", num));
                this.class1092_0.method_21(builtinDocumentProperties.WordCount.ToString());
                this.class1092_0.method_12();
            }
            if (builtinDocumentProperties.CharCount != -2147483648)
            {
                this.class1092_0.method_9(BookmarkStart.b("电倷嬹主弽⌿㙁⅃㑅㭇", num));
                this.class1092_0.method_21(builtinDocumentProperties.CharCount.ToString());
                this.class1092_0.method_12();
            }
            if (builtinDocumentProperties.CharCountWithSpace != -2147483648)
            {
                this.class1092_0.method_9(BookmarkStart.b("电倷嬹主弽⌿㙁⅃㑅㭇ᵉ╋㩍㡏ő⑓㝕㭗㽙⽛", num));
                this.class1092_0.method_21(builtinDocumentProperties.CharCountWithSpace.ToString());
                this.class1092_0.method_12();
            }
            if (builtinDocumentProperties.ApplicationName != null)
            {
                this.class1092_0.method_9(BookmarkStart.b("眵䠷䨹倻圽⌿⍁ぃ⽅❇⑉", num));
                this.class1092_0.method_21(builtinDocumentProperties.ApplicationName);
                this.class1092_0.method_12();
            }
            if (builtinDocumentProperties.DocSecurity != -2147483648)
            {
                this.class1092_0.method_9(BookmarkStart.b("爵圷夹漻嬽⌿㝁㙃⽅㱇㍉", num));
                this.class1092_0.method_21(builtinDocumentProperties.DocSecurity.ToString());
                this.class1092_0.method_12();
            }
            if (builtinDocumentProperties.LinesCount != -2147483648)
            {
                this.class1092_0.method_9(BookmarkStart.b("稵儷吹夻䴽", num));
                this.class1092_0.method_21(builtinDocumentProperties.LinesCount.ToString());
                this.class1092_0.method_12();
            }
            if (builtinDocumentProperties.ParagraphCount != -2147483648)
            {
                this.class1092_0.method_9(BookmarkStart.b("昵夷䠹崻夽㈿⍁㑃⹅㭇", num));
                this.class1092_0.method_21(builtinDocumentProperties.ParagraphCount.ToString());
                this.class1092_0.method_12();
            }
            if (builtinDocumentProperties.Manager != null)
            {
                this.class1092_0.method_9(BookmarkStart.b("笵夷吹崻夽┿ぁ", num));
                this.class1092_0.method_21(builtinDocumentProperties.Manager);
                this.class1092_0.method_12();
            }
            if (builtinDocumentProperties.Company != null)
            {
                this.class1092_0.method_9(BookmarkStart.b("电圷圹䰻弽⸿㭁", num));
                this.class1092_0.method_21(builtinDocumentProperties.Company);
                this.class1092_0.method_12();
            }
            this.class1092_0.method_9(BookmarkStart.b("眵䠷䨹樻嬽㈿ㅁⵃ⥅♇", num));
            this.class1092_0.method_21(this.method_540() + BookmarkStart.b("ᠵ࠷ਹ఻฽", num));
            this.class1092_0.method_12();
        }
        this.class1092_0.method_12();
        this.class1092_0.method_15();
        this.class771_0.method_14(BookmarkStart.b("刵圷夹氻䰽⼿㉁㝃ᩅ⥇㩉㱋恍⡏㽑㡓", num), stream, true, FileAttributes.Archive);
    }

    private bool method_517(Style A_0)
    {
        int num = 0x10;
        string name = A_0.Name;
        if (((((name != BookmarkStart.b("砵圷䠹儻弽ⰿ", 0x10)) || (A_0.StyleType != StyleType.ParagraphStyle)) && ((name != BookmarkStart.b("爵崷尹崻䬽ⰿ㙁摃ᙅ⥇㡉ⵋ⥍≏㍑⑓㹕硗᱙㍛そᑟ", num)) || (A_0.StyleType != StyleType.CharacterStyle))) && (((name != BookmarkStart.b("戵夷堹倻嬽怿ు⭃㑅╇⭉⁋", num)) && (name != BookmarkStart.b("砵圷䠹儻弽ⰿ扁၃❅⩇♉⥋", num))) || (A_0.StyleType != StyleType.TableStyle))) && ((name != BookmarkStart.b("砵圷ᨹ瀻圽㌿㙁", num)) || (A_0.TypeCode != WordStyleType.ListStyle)))
        {
            return (A_0.StyleDocId == 0);
        }
        return true;
    }

    private string method_518(TabLeader A_0)
    {
        int num = 1;
        switch (A_0)
        {
            case TabLeader.Dotted:
                return BookmarkStart.b("䌦䘨弪", num);

            case TabLeader.Hyphenated:
                return BookmarkStart.b("伦倨嬪䔬䨮弰", num);

            case TabLeader.Single:
                return BookmarkStart.b("刦䜨伪䠬崮䈰倲娴䔶尸", num);

            case TabLeader.Heavy:
                return BookmarkStart.b("伦䰨䨪嬬嘮", num);

            case TabLeader.MiddleDot:
                return BookmarkStart.b("䨦䀨伪䤬䌮吰眲娴䌶", num);
        }
        return BookmarkStart.b("䤦䘨䔪䠬", num);
    }

    private string method_519(TabJustification A_0)
    {
        int num = 0x13;
        switch (A_0)
        {
            case TabJustification.Left:
                return BookmarkStart.b("唸帺嬼䬾", num);

            case TabJustification.Centered:
                return BookmarkStart.b("娸帺匼䬾⑀ㅂ", num);

            case TabJustification.Right:
                return BookmarkStart.b("䬸刺娼圾㕀", num);

            case TabJustification.Decimal:
                return BookmarkStart.b("崸帺帼嘾ⱀ≂⥄", num);

            case TabJustification.Bar:
                return BookmarkStart.b("嬸娺似", num);

            case TabJustification.List:
                return BookmarkStart.b("圸为值", num);
        }
        return BookmarkStart.b("娸场堼帾㍀", num);
    }

    internal void method_52(string A_0, Document A_1)
    {
        using (FileStream stream = new FileStream(A_0, FileMode.Create))
        {
            this.method_53(stream, A_1);
            stream.Close();
        }
    }

    internal int method_520(ListFormat A_0)
    {
        int key = 0;
        if ((A_0.LFOStyleName == string.Empty) || (A_0.CurrentListStyle.Name != string.Empty))
        {
            foreach (ListStyle style in A_0.Document.ListStyles)
            {
                if (style.Name == A_0.CustomStyleName)
                {
                    break;
                }
                key++;
            }
        }
        if (A_0.LFOStyleName == null)
        {
            key++;
            return key;
        }
        if (this.int_8 == 0)
        {
            this.int_8 = A_0.Document.ListStyles.Count + 1;
        }
        if (!this.method_24().ContainsKey(key))
        {
            return this.method_521(key, A_0.LFOStyleName);
        }
        Dictionary<int, string> dictionary = this.method_24()[key];
        bool flag = false;
        using (Dictionary<int, string>.KeyCollection.Enumerator enumerator = dictionary.Keys.GetEnumerator())
        {
            int current;
            while (enumerator.MoveNext())
            {
                current = enumerator.Current;
                if (dictionary[current] == A_0.LFOStyleName)
                {
                    goto Label_0115;
                }
            }
            goto Label_012A;
        Label_0115:
            key = current;
            flag = true;
        }
    Label_012A:
        if (!flag)
        {
            key = this.method_521(key, A_0.LFOStyleName);
        }
        return key;
    }

    private int method_521(int A_0, string A_1)
    {
        if (!this.method_24().ContainsKey(A_0))
        {
            this.method_24().Add(A_0, new Dictionary<int, string>());
        }
        this.method_24()[A_0].Add(this.int_8, A_1);
        int num = this.int_8;
        this.int_8++;
        return num;
    }

    private void method_522(int A_0, int A_1)
    {
        int num = 7;
        this.class1092_0.method_10(BookmarkStart.b("䌬娮尰挲䜴", 7), this.dictionary_32[BookmarkStart.b("娬", 7)]);
        if (A_1 != -1)
        {
            this.class1092_0.method_10(BookmarkStart.b("䐬䌮䜰弲", num), this.dictionary_32[BookmarkStart.b("娬", num)]);
            this.class1092_0.method_6(BookmarkStart.b("娬", num), BookmarkStart.b("嬬丮崰", num), this.dictionary_32[BookmarkStart.b("娬", num)], A_1.ToString());
            this.class1092_0.method_12();
        }
        if (A_0 != -1)
        {
            this.class1092_0.method_10(BookmarkStart.b("䌬娮尰稲儴", num), this.dictionary_32[BookmarkStart.b("娬", num)]);
            this.class1092_0.method_6(BookmarkStart.b("娬", num), BookmarkStart.b("嬬丮崰", num), this.dictionary_32[BookmarkStart.b("娬", num)], A_0.ToString());
            this.class1092_0.method_12();
        }
        this.class1092_0.method_12();
    }

    private bool method_523(CharacterFormat A_0)
    {
        return (A_0.HasValue(2) || (((A_0.Document != null) && (A_0.Document.GrammarSpellingData == null)) && A_0.HasKey(0)));
    }

    private Class1092 method_524(Stream A_0)
    {
        XmlWriterSettings settings = new XmlWriterSettings();
        Class1092 class2 = new Class1092(A_0, settings, this.dictionary_32);
        class2.method_19(BookmarkStart.b("䬲場嬶", 13), BookmarkStart.b("䔲倴䔶䨸刺刼儾籀慂瑄楆祈楊浌⩎㽐げ㩔㍖じ㕚㩜扞䍠ᙢᅤŦ䑨卪佬佮ɰݲᑴ᥶ᵸ᩺ᅼၾ뢄ꖆﺌ궎", 13));
        return class2;
    }

    private XmlReader method_525(Stream A_0)
    {
        A_0.Position = 0L;
        XmlReader reader = XmlReader.Create(A_0);
        reader.Read();
        while ((reader.NodeType == XmlNodeType.XmlDeclaration) || (reader.NodeType == XmlNodeType.Whitespace))
        {
            reader.Read();
        }
        return reader;
    }

    private void method_526()
    {
        this.int_0 = 0;
    }

    private string method_527()
    {
        return string.Format(BookmarkStart.b("弬昮唰䠲Դ䨶", 7), ++this.int_0);
    }

    private int method_528()
    {
        return ++this.int_2;
    }

    private string method_529(TextureStyle A_0)
    {
        int num = 5;
        switch (A_0)
        {
            case TextureStyle.TextureSolid:
                return BookmarkStart.b("堪䈬䌮堰圲", num);

            case TextureStyle.Texture5Percent:
            case TextureStyle.Texture2Pt5Percent:
            case TextureStyle.Texture7Pt5Percent:
                return BookmarkStart.b("嬪丬嬮а", num);

            case TextureStyle.Texture10Percent:
                return BookmarkStart.b("嬪丬嬮0̲", num);

            case TextureStyle.Texture20Percent:
                return BookmarkStart.b("嬪丬嬮̰̲", num);

            case TextureStyle.Texture25Percent:
            case TextureStyle.Texture27Pt5Percent:
                return BookmarkStart.b("嬪丬嬮̰ز", num);

            case TextureStyle.Texture30Percent:
            case TextureStyle.Texture32Pt5Percent:
                return BookmarkStart.b("嬪丬嬮Ȱ̲", num);

            case TextureStyle.Texture40Percent:
            case TextureStyle.Texture42Pt5Percent:
                return BookmarkStart.b("嬪丬嬮԰̲", num);

            case TextureStyle.Texture50Percent:
            case TextureStyle.Texture52Pt5Percent:
                return BookmarkStart.b("嬪丬嬮а̲", num);

            case TextureStyle.Texture60Percent:
                return BookmarkStart.b("嬪丬嬮̲ܰ", num);

            case TextureStyle.Texture70Percent:
            case TextureStyle.Texture72Pt5Percent:
                return BookmarkStart.b("嬪丬嬮ذ̲", num);

            case TextureStyle.Texture75Percent:
            case TextureStyle.Texture77Pt5Percent:
                return BookmarkStart.b("嬪丬嬮ذز", num);

            case TextureStyle.Texture80Percent:
            case TextureStyle.Texture82Pt5Percent:
                return BookmarkStart.b("嬪丬嬮र̲", num);

            case TextureStyle.Texture90Percent:
            case TextureStyle.Texture92Pt5Percent:
                return BookmarkStart.b("嬪丬嬮࠰̲", num);

            case TextureStyle.TextureDarkHorizontal:
                return BookmarkStart.b("䌪䈬崮䬰怲䄴䔶倸䬺堼", num);

            case TextureStyle.TextureDarkVertical:
                return BookmarkStart.b("崪䠬崮䔰怲䄴䔶倸䬺堼", num);

            case TextureStyle.TextureDarkDiagonalDown:
                return BookmarkStart.b("太䠬央吰䄲䘴制紸刺尼堾ቀ㝂㝄⹆㥈⹊", num);

            case TextureStyle.TextureDarkDiagonalUp:
                return BookmarkStart.b("伪䐬丮嘰怲䄴䔶倸䬺堼", num);

            case TextureStyle.TextureDarkCross:
                return BookmarkStart.b("䌪䈬崮䬰瀲䜴堶䨸䠺", num);

            case TextureStyle.TextureDarkDiagonalCross:
                return BookmarkStart.b("伪䐬丮嘰瀲䜴堶䨸䠺", num);

            case TextureStyle.TextureHorizontal:
                return BookmarkStart.b("弪䔬䘮弰笲娴䔶䌸栺䤼䴾⡀㍂⁄", num);

            case TextureStyle.TextureVertical:
                return BookmarkStart.b("弪䔬䘮弰攲倴䔶䴸栺䤼䴾⡀㍂⁄", num);

            case TextureStyle.TextureDiagonalDown:
                return BookmarkStart.b("弪䔬䘮弰愲倴䄶尸䤺丼娾Հ⩂⑄⁆ᩈ㽊㽌♎⅐㙒", num);

            case TextureStyle.TextureDiagonalUp:
                return BookmarkStart.b("弪䔬䘮弰眲尴嘶常栺䤼䴾⡀㍂⁄", num);

            case TextureStyle.TextureCross:
                return BookmarkStart.b("弪䔬䘮弰笲娴䔶䌸砺似倾㉀あ", num);

            case TextureStyle.TextureDiagonalCross:
                return BookmarkStart.b("弪䔬䘮弰眲尴嘶常砺似倾㉀あ", num);

            case TextureStyle.Texture12Pt5Percent:
                return BookmarkStart.b("嬪丬嬮0Ĳ", num);

            case TextureStyle.Texture15Percent:
                return BookmarkStart.b("嬪丬嬮0ز", num);

            case TextureStyle.Texture17Pt5Percent:
                return BookmarkStart.b("嬪丬嬮0ز", num);

            case TextureStyle.Texture35Percent:
                return BookmarkStart.b("嬪丬嬮Ȱز", num);

            case TextureStyle.Texture37Pt5Percent:
                return BookmarkStart.b("嬪丬嬮Ȱв", num);

            case TextureStyle.Texture45Percent:
            case TextureStyle.Texture47Pt5Percent:
                return BookmarkStart.b("嬪丬嬮԰ز", num);

            case TextureStyle.Texture55Percent:
            case TextureStyle.Texture57Pt5Percent:
                return BookmarkStart.b("嬪丬嬮аز", num);

            case TextureStyle.Texture62Pt5Percent:
                return BookmarkStart.b("嬪丬嬮ܰĲ", num);

            case TextureStyle.Texture65Percent:
            case TextureStyle.Texture67Pt5Percent:
                return BookmarkStart.b("嬪丬嬮ܰز", num);

            case TextureStyle.Texture85Percent:
                return BookmarkStart.b("嬪丬嬮रز", num);

            case TextureStyle.Texture87Pt5Percent:
                return BookmarkStart.b("嬪丬嬮रв", num);

            case TextureStyle.Texture95Percent:
            case TextureStyle.Texture97Pt5Percent:
                return BookmarkStart.b("嬪丬嬮࠰ز", num);
        }
        return BookmarkStart.b("䠪䄬䨮倰䄲", num);
    }

    internal void method_53(Stream A_0, Document A_1)
    {
        int num = 0x10;
        this.bool_20 = true;
        A_1.DocxNameSpace.method_3(false);
        this.method_51(A_1);
        List<Class229> list = new List<Class229>();
        if (this.class771_0 != null)
        {
            Class1129 class2 = new Class1129();
            class2.method_20(this.class771_0);
            list.AddRange(class2.method_24());
            class2 = null;
        }
        XmlWriterSettings settings = new XmlWriterSettings();
        XmlWriter writer = XmlWriter.Create(A_0, settings);
        writer.WriteProcessingInstruction(BookmarkStart.b("丵唷嘹", num), BookmarkStart.b("䀵崷䠹伻圽⼿ⱁ祃摅祇摉籋汍灏㝑㩓㕕㝗㹙㕛そݟ彡䙣፥ᱧ౩䅫噭副剱ݳɵ᥷ᑹ᡻ώ떇ꢉ낑", num));
        writer.WriteProcessingInstruction(BookmarkStart.b("嬵䬷唹ᄻ弽〿㉁⡃⽅⭇⭉㡋❍㽏㱑", num), BookmarkStart.b("䘵䨷唹嬻圽␿罁晃ᅅ❇㡉⡋恍ᑏ㵑㝓⍕㕗㽙㉛⩝䉟", num));
        writer.WriteStartElement(BookmarkStart.b("䘵匷崹", num), BookmarkStart.b("䘵夷夹圻弽✿❁", num), BookmarkStart.b("帵䰷丹䰻н漿流㝃╅⁇⽉⅋⽍⍏籑㥓㽕㭗⡙㍛ⵝཟѡၣ䡥୧թū䅭Ὧᑱታή᭷ό卻䱽끿늁늃ꦅ\ude8d\uf18fﾓﾗﾙ", num));
        foreach (Class229 class3 in list)
        {
            writer.WriteStartElement(BookmarkStart.b("䘵匷崹", num), BookmarkStart.b("䘵夷䠹䠻", num), BookmarkStart.b("帵䰷丹䰻н漿流㝃╅⁇⽉⅋⽍⍏籑㥓㽕㭗⡙㍛ⵝཟѡၣ䡥୧թū䅭Ὧᑱታή᭷ό卻䱽끿늁늃ꦅ\ude8d\uf18fﾓﾗﾙ", num));
            writer.WriteAttributeString(BookmarkStart.b("䘵匷崹", num), BookmarkStart.b("堵夷圹夻", num), BookmarkStart.b("帵䰷丹䰻н漿流㝃╅⁇⽉⅋⽍⍏籑㥓㽕㭗⡙㍛ⵝཟѡၣ䡥୧թū䅭Ὧᑱታή᭷ό卻䱽끿늁늃ꦅ\ude8d\uf18fﾓﾗﾙ", num), class3.method_7());
            writer.WriteAttributeString(BookmarkStart.b("䘵匷崹", num), BookmarkStart.b("唵圷吹䠻嬽⸿㙁၃㽅㡇⽉", num), BookmarkStart.b("帵䰷丹䰻н漿流㝃╅⁇⽉⅋⽍⍏籑㥓㽕㭗⡙㍛ⵝཟѡၣ䡥୧թū䅭Ὧᑱታή᭷ό卻䱽끿늁늃ꦅ\ude8d\uf18fﾓﾗﾙ", num), class3.method_0());
            if (!class3.method_7().EndsWith(BookmarkStart.b("ᠵ䨷弹倻䴽", num)) && !class3.method_7().EndsWith(BookmarkStart.b("ᠵ䀷圹倻", num)))
            {
                writer.WriteStartElement(BookmarkStart.b("䘵匷崹", num), BookmarkStart.b("吵儷吹崻䰽㤿ف╃㉅⥇", num), BookmarkStart.b("帵䰷丹䰻н漿流㝃╅⁇⽉⅋⽍⍏籑㥓㽕㭗⡙㍛ⵝཟѡၣ䡥୧թū䅭Ὧᑱታή᭷ό卻䱽끿늁늃ꦅ\ude8d\uf18fﾓﾗﾙ", num));
                string text = this.method_54(class3.method_4());
                writer.WriteString(text);
                text = null;
                writer.WriteEndElement();
            }
            else
            {
                writer.WriteStartElement(BookmarkStart.b("䘵匷崹", num), BookmarkStart.b("丵唷嘹砻弽㐿⍁", num), BookmarkStart.b("帵䰷丹䰻н漿流㝃╅⁇⽉⅋⽍⍏籑㥓㽕㭗⡙㍛ⵝཟѡၣ䡥୧թū䅭Ὧᑱታή᭷ό卻䱽끿늁늃ꦅ\ude8d\uf18fﾓﾗﾙ", num));
                XmlReader reader = this.method_525(class3.method_4());
                while (!reader.EOF)
                {
                    writer.WriteNode(reader, false);
                }
                reader.Close();
                reader = null;
                writer.WriteEndElement();
            }
            writer.WriteEndElement();
            class3.System.IDisposable.Dispose();
        }
        writer.WriteEndElement();
        writer.Flush();
        list.Clear();
        list = null;
    }

    private string method_530(BorderStyle A_0)
    {
        int num = 7;
        switch (A_0)
        {
            case BorderStyle.None:
                return BookmarkStart.b("䌬䀮弰嘲", num);

            case BorderStyle.Single:
            case BorderStyle.Hairline:
                return BookmarkStart.b("帬䘮弰吲头制", num);

            case BorderStyle.Thick:
                return BookmarkStart.b("夬䜮堰倲帴", num);

            case BorderStyle.Double:
                return BookmarkStart.b("䤬䀮䐰儲头制", num);

            case BorderStyle.Dot:
                return BookmarkStart.b("䤬䀮䔰䜲倴匶", num);

            case BorderStyle.DashLargeGap:
                return BookmarkStart.b("䤬丮䈰嬲倴匶", num);

            case BorderStyle.DotDash:
                return BookmarkStart.b("䤬䀮䔰眲吴䐶儸", num);

            case BorderStyle.DotDotDash:
                return BookmarkStart.b("䤬䀮䔰眲娴䌶紸娺丼圾", num);

            case BorderStyle.Triple:
                return BookmarkStart.b("夬崮堰䌲头制", num);

            case BorderStyle.ThinThickSmallGap:
                return BookmarkStart.b("夬䜮堰崲愴弶倸堺嘼氾ⱀ≂⥄⭆่⩊㵌", num);

            case BorderStyle.ThickThinSmallGap:
                return BookmarkStart.b("夬䜮堰倲帴挶儸刺匼氾ⱀ≂⥄⭆่⩊㵌", num);

            case BorderStyle.ThinThickThinSmallGap:
                return BookmarkStart.b("夬䜮堰崲愴弶倸堺嘼款⥀⩂⭄ᑆ⑈⩊⅌⍎ᙐ㉒╔", num);

            case BorderStyle.ThinThickMediumGap:
                return BookmarkStart.b("夬䜮堰崲愴弶倸堺嘼爾⑀❂ⱄ㉆⑈ొⱌ㽎", num);

            case BorderStyle.ThickThinMediumGap:
                return BookmarkStart.b("夬䜮堰倲帴挶儸刺匼爾⑀❂ⱄ㉆⑈ొⱌ㽎", num);

            case BorderStyle.ThinThickThinMediumGap:
                return BookmarkStart.b("夬䜮堰崲愴弶倸堺嘼款⥀⩂⭄੆ⱈ⽊⑌㩎㱐ᑒ㑔❖", num);

            case BorderStyle.ThinThickLargeGap:
                return BookmarkStart.b("夬䜮堰崲愴弶倸堺嘼猾⁀ㅂ≄≆่⩊㵌", num);

            case BorderStyle.ThickThinLargeGap:
                return BookmarkStart.b("夬䜮堰倲帴挶儸刺匼猾⁀ㅂ≄≆่⩊㵌", num);

            case BorderStyle.ThinThickThinLargeGap:
                return BookmarkStart.b("夬䜮堰崲愴弶倸堺嘼款⥀⩂⭄୆⡈㥊⩌⩎ᙐ㉒╔", num);

            case BorderStyle.Wave:
                return BookmarkStart.b("娬丮䜰嘲", num);

            case BorderStyle.DoubleWave:
                return BookmarkStart.b("䤬䀮䐰儲头制游娺䬼娾", num);

            case BorderStyle.DashSmallGap:
                return BookmarkStart.b("䤬丮䈰嬲昴娶堸场儼砾⁀㍂", num);

            case BorderStyle.DashDotStroker:
                return BookmarkStart.b("䤬丮䈰嬲焴堶䴸栺䤼䴾⹀⡂⁄⍆", num);

            case BorderStyle.Emboss3D:
                return BookmarkStart.b("夬䜮䌰嘲倴猶簸嘺弼倾㉀あ", num);

            case BorderStyle.Engrave3D:
                return BookmarkStart.b("夬䜮䌰嘲倴猶簸唺娼䴾⁀㕂⁄", num);

            case BorderStyle.Outset:
                return BookmarkStart.b("䈬娮䔰䀲倴䌶", num);

            case BorderStyle.Inset:
                return BookmarkStart.b("䐬䄮䈰嘲䄴", num);

            case BorderStyle.TwistedLines1:
                return BookmarkStart.b("夬堮堰䀲䄴制崸眺吼儾⑀あ瑄", num);

            case BorderStyle.Cleared:
                return BookmarkStart.b("䌬䘮崰", num);
        }
        return BookmarkStart.b("帬䘮弰吲头制", num);
    }

    private string method_531(UnderlineStyle A_0)
    {
        int num = 11;
        switch (A_0)
        {
            case UnderlineStyle.Single:
                return BookmarkStart.b("䈰娲嬴倶唸帺", num);

            case UnderlineStyle.Words:
                return BookmarkStart.b("䘰尲䜴匶䨸", num);

            case UnderlineStyle.Double:
                return BookmarkStart.b("唰尲䀴唶唸帺", num);

            case UnderlineStyle.Dotted:
                return BookmarkStart.b("唰尲䄴䌶尸强", num);

            case UnderlineStyle.Thick:
                return BookmarkStart.b("䔰嬲尴吶券", num);

            case UnderlineStyle.Dash:
                return BookmarkStart.b("唰刲䘴弶", num);

            case UnderlineStyle.DotDash:
                return BookmarkStart.b("唰尲䄴猶堸䠺唼", num);

            case UnderlineStyle.DotDotDash:
                return BookmarkStart.b("唰尲䄴猶嘸伺礼帾㉀⭂", num);

            case UnderlineStyle.Wavy:
                return BookmarkStart.b("䘰刲䌴制", num);

            case UnderlineStyle.DottedHeavy:
                return BookmarkStart.b("唰尲䄴䌶尸强甼娾⁀㕂㱄", num);

            case UnderlineStyle.DashHeavy:
                return BookmarkStart.b("唰刲䘴弶尸强甼娾⁀㕂㱄", num);

            case UnderlineStyle.DotDashHeavy:
                return BookmarkStart.b("唰刲䘴弶紸吺䤼眾⑀≂㍄㹆", num);

            case UnderlineStyle.DotDotDashHeavy:
                return BookmarkStart.b("唰刲䘴弶紸吺䤼笾⹀㝂ൄ≆⡈㵊㑌", num);

            case UnderlineStyle.WavyHeavy:
                return BookmarkStart.b("䘰刲䌴丶焸帺尼䤾㡀", num);

            case UnderlineStyle.DashLong:
                return BookmarkStart.b("唰刲䘴弶甸吺匼堾", num);

            case UnderlineStyle.WavyDouble:
                return BookmarkStart.b("䘰刲䌴丶紸吺䠼崾ⵀ♂", num);

            case UnderlineStyle.DashLongHeavy:
                return BookmarkStart.b("唰刲䘴弶甸吺匼堾ी♂⑄ㅆえ", num);
        }
        return BookmarkStart.b("弰尲嬴制", num);
    }

    private bool method_532(Color A_0, Color A_1)
    {
        return (((A_0.B == A_1.B) && (A_0.R == A_1.R)) && (A_0.G == A_1.G));
    }

    private string method_533(Color A_0)
    {
        int num = 0;
        if (this.method_532(A_0, Color.Black))
        {
            return BookmarkStart.b("䐥䐧䬩伫䔭", num);
        }
        if (this.method_532(A_0, Color.Blue))
        {
            return BookmarkStart.b("䐥䐧弩䤫", num);
        }
        if (this.method_532(A_0, Color.Cyan))
        {
            return BookmarkStart.b("䔥儧䬩䈫", num);
        }
        if (this.method_532(A_0, Color.DarkBlue))
        {
            return BookmarkStart.b("䈥䤧堩䜫氭尯䜱儳", num);
        }
        if (this.method_532(A_0, Color.DarkCyan))
        {
            return BookmarkStart.b("䈥䤧堩䜫洭䤯匱娳", num);
        }
        if (this.method_532(A_0, Color.DarkGray))
        {
            return BookmarkStart.b("䈥䤧堩䜫椭䈯匱䴳", num);
        }
        if (this.method_532(A_0, Color.DarkGreen))
        {
            return BookmarkStart.b("䈥䤧堩䜫椭䈯圱儳堵", num);
        }
        if (this.method_532(A_0, Color.DarkMagenta))
        {
            return BookmarkStart.b("䈥䤧堩䜫挭儯唱儳堵䰷嬹", num);
        }
        if (this.method_532(A_0, Color.DarkRed))
        {
            return BookmarkStart.b("䈥䤧堩䜫簭唯嘱", num);
        }
        if (this.method_532(A_0, Color.Green))
        {
            return BookmarkStart.b("䄥娧伩䤫䀭", num);
        }
        if (this.method_532(A_0, Color.Gold))
        {
            return BookmarkStart.b("䈥䤧堩䜫眭唯帱堳夵伷", num);
        }
        if (this.method_532(A_0, Color.YellowGreen))
        {
            return BookmarkStart.b("䈥䤧堩䜫眭唯帱堳夵伷", num);
        }
        if (this.method_532(A_0, Color.LightGray))
        {
            return BookmarkStart.b("䨥䄧䴩䐫娭眯䀱唳伵", num);
        }
        if (this.method_532(A_0, Color.Magenta))
        {
            return BookmarkStart.b("䬥䤧䴩䤫䀭䐯匱", num);
        }
        if (this.method_532(A_0, Color.Red))
        {
            return BookmarkStart.b("吥䴧丩", num);
        }
        if (this.method_532(A_0, Color.White))
        {
            return BookmarkStart.b("儥䀧䌩堫䬭", num);
        }
        if (this.method_532(A_0, Color.Yellow))
        {
            return BookmarkStart.b("弥䴧䘩䀫䄭䜯", num);
        }
        return BookmarkStart.b("䠥䜧䐩䤫", num);
    }

    public string method_534(float A_0)
    {
        int num = (int) Math.Round((double) A_0);
        return num.ToString(CultureInfo.InvariantCulture);
    }

    private string method_535(Color A_0)
    {
        int num4 = 0x11;
        if (A_0.IsEmpty)
        {
            return string.Empty;
        }
        return (A_0.R.ToString(BookmarkStart.b("漶ସ", num4)) + A_0.G.ToString(BookmarkStart.b("漶ସ", num4)) + A_0.B.ToString(BookmarkStart.b("漶ସ", num4)));
    }

    private bool method_536(IParagraphStyle A_0, ParagraphFormat A_1)
    {
        if (A_1.HasValue(0x618))
        {
            if (!A_1.IsBidi)
            {
                return false;
            }
            return true;
        }
        if (A_0 != null)
        {
            if ((A_0 != null) && A_0.ParagraphFormat.HasValue(0x618))
            {
                if (!A_0.ParagraphFormat.IsBidi)
                {
                    return false;
                }
                return true;
            }
            for (ParagraphFormat format = A_0.ParagraphFormat.BaseFormat as ParagraphFormat; format != null; format = format.BaseFormat as ParagraphFormat)
            {
                if (format.HasValue(0x618))
                {
                    if (!format.IsBidi)
                    {
                        return false;
                    }
                    return true;
                }
            }
        }
        return false;
    }

    private float method_537(Document A_0, short A_1)
    {
        Style style = A_0.Styles.FindByName(BookmarkStart.b("瀳匵帷嬹䤻刽㐿扁ᑃ❅㩇⭉⭋㱍ㅏ≑㱓癕ṗ㕙㉛⩝", 14));
        A_0.Styles.FindByName(BookmarkStart.b("稳夵䨷圹崻刽", 14));
        float fontSize = 0f;
        if ((style != null) && style.CharacterFormat.HasValue(A_1))
        {
            fontSize = style.CharacterFormat.FontSize;
        }
        return fontSize;
    }

    private string method_538(ListPatternType A_0)
    {
        int num = 10;
        switch (A_0)
        {
            case ListPatternType.Arabic:
                return BookmarkStart.b("启圱圳張唷嬹倻", num);

            case ListPatternType.UpRoman:
                return BookmarkStart.b("䔯䈱䐳匵䨷根医匽ℿⱁ", num);

            case ListPatternType.LowRoman:
                return BookmarkStart.b("尯崱䌳匵䨷根医匽ℿⱁ", num);

            case ListPatternType.UpLetter:
                return BookmarkStart.b("䔯䈱䐳匵䨷瘹夻䨽㐿❁㙃", num);

            case ListPatternType.LowLetter:
                return BookmarkStart.b("尯崱䌳匵䨷瘹夻䨽㐿❁㙃", num);

            case ListPatternType.Ordinal:
                return BookmarkStart.b("弯䀱倳張嘷嬹倻", num);

            case ListPatternType.CardinalText:
                return BookmarkStart.b("匯匱䘳刵儷吹崻刽ᐿ❁㱃㉅", num);

            case ListPatternType.OrdinalText:
                return BookmarkStart.b("弯䀱倳張嘷嬹倻樽┿㩁ぃ", num);

            case ListPatternType.IdeographDigital:
                return BookmarkStart.b("夯嘱儳夵強䠹崻丽⠿فⵃⅅⅇ㹉ⵋ≍", num);

            case ListPatternType.JapaneseCounting:
                return BookmarkStart.b("娯匱䐳圵嘷弹伻嬽̿ⵁㅃ⡅㱇⍉≋⥍", num);

            case ListPatternType.Aiueo:
                return BookmarkStart.b("儯嬱䄳匵圷", num);

            case ListPatternType.Iroha:
                return BookmarkStart.b("夯䀱嬳帵夷", num);

            case ListPatternType.JapaneseLegal:
                return BookmarkStart.b("娯匱䐳圵嘷弹伻嬽ి❁⍃❅⑇", num);

            case ListPatternType.JapaneseDigitalTenThousand:
                return BookmarkStart.b("娯匱䐳圵嘷弹伻嬽п⭁⍃⽅㱇⭉⁋ᩍ㕏㱑S㹕㝗⽙⽛㽝๟١", num);

            case ListPatternType.DecimalEnclosedCircle:
                return BookmarkStart.b("启圱圳張唷嬹倻笽⸿⅁⡃⥅㭇⽉⡋്㥏⁑㝓㩕㵗", num);

            case ListPatternType.AiueoFullWidth:
                return BookmarkStart.b("儯嬱䄳匵圷簹䤻刽ⰿᕁⵃ≅㱇≉", num);

            case ListPatternType.IrohaFullWidth:
                return BookmarkStart.b("夯䀱嬳帵夷簹䤻刽ⰿᕁⵃ≅㱇≉", num);

            case ListPatternType.LeadingZero:
                return BookmarkStart.b("启圱圳張唷嬹倻搽┿ぁ⭃", num);

            case ListPatternType.Bullet:
                return BookmarkStart.b("刯䜱堳娵崷丹", num);

            case ListPatternType.DecimalEnclosedFullstop:
                return BookmarkStart.b("启圱圳張唷嬹倻笽⸿⅁⡃⥅㭇⽉⡋ࡍ╏㹑㡓╕ⱗ㕙ⱛ", num);

            case ListPatternType.DecimalEnclosedCircleChinese:
                return BookmarkStart.b("启圱圳張唷嬹倻笽⸿⅁⡃⥅㭇⽉⡋്㥏⁑㝓㩕㵗ᥙ㑛㝝๟ݡᝣͥ", num);

            case ListPatternType.IdeographTraditional:
                return BookmarkStart.b("夯嘱儳夵強䠹崻丽⠿ᙁ㙃❅ⱇ⍉㡋❍㽏㱑㕓㩕", num);

            case ListPatternType.IdeographZodiac:
                return BookmarkStart.b("夯嘱儳夵強䠹崻丽⠿ᡁ⭃≅ⅇ⭉⽋", num);

            case ListPatternType.IdeographZodiacTraditional:
                return BookmarkStart.b("夯嘱儳夵強䠹崻丽⠿ᡁ⭃≅ⅇ⭉⽋ᩍ≏㍑こ㽕ⱗ㍙㍛そş๡", num);

            case ListPatternType.TaiwaneseCounting:
                return BookmarkStart.b("䐯匱崳䄵夷吹夻䴽┿Ł⭃㍅♇㹉╋⁍㝏", num);

            case ListPatternType.IdeographLegalTraditional:
                return BookmarkStart.b("夯嘱儳夵強䠹崻丽⠿แ⅃ⅅ⥇♉ᡋ㱍ㅏ㙑㵓≕ㅗ㕙㉛㽝౟", num);

            case ListPatternType.TaiwaneseCountingThousand:
                return BookmarkStart.b("䐯匱崳䄵夷吹夻䴽┿Ł⭃㍅♇㹉╋⁍㝏ّ㱓㥕ⵗ⥙㵛そџ", num);

            case ListPatternType.TaiwaneseDigital:
                return BookmarkStart.b("䐯匱崳䄵夷吹夻䴽┿فⵃⅅⅇ㹉ⵋ≍", num);

            case ListPatternType.ChineseCounting:
                return BookmarkStart.b("匯娱崳堵崷䤹夻紽⼿㝁⩃㉅ⅇ⑉⭋", num);

            case ListPatternType.ChineseLegalSimplified:
                return BookmarkStart.b("匯娱崳堵崷䤹夻爽┿╁╃⩅ᭇ⍉⅋㹍㱏㭑㉓㽕㵗㹙", num);

            case ListPatternType.ChineseCountingThousand:
                return BookmarkStart.b("匯娱崳堵崷䤹夻紽⼿㝁⩃㉅ⅇ⑉⭋ᩍ㡏㵑⅓╕㥗㑙㡛", num);

            case ListPatternType.KoreanDigital:
                return BookmarkStart.b("嬯崱䘳匵夷吹砻圽✿⭁ぃ❅⑇", num);

            case ListPatternType.KoreanCounting:
                return BookmarkStart.b("嬯崱䘳匵夷吹缻儽㔿ⱁぃ⽅♇ⵉ", num);

            case ListPatternType.KoreanLegal:
                return BookmarkStart.b("嬯崱䘳匵夷吹瀻嬽✿⍁⡃", num);

            case ListPatternType.KoreanDigital2:
                return BookmarkStart.b("嬯崱䘳匵夷吹砻圽✿⭁ぃ❅⑇硉", num);

            case ListPatternType.Hebrew1:
                return BookmarkStart.b("堯圱嘳䐵崷䴹഻", num);

            case ListPatternType.Special:
                return BookmarkStart.b("䈯䜱䜳䔵儷嬹刻爽⼿㕁⅃㑅", num);
        }
        return BookmarkStart.b("帯崱娳匵", num);
    }

    private char method_539(int A_0)
    {
        switch (A_0)
        {
            case 1:
                return '\0';

            case 2:
                return '\x0001';

            case 3:
                return '\x0002';

            case 4:
                return '\x0003';

            case 5:
                return '\x0004';

            case 6:
                return '\x0005';

            case 7:
                return '\x0006';

            case 8:
                return '\a';
        }
        return '\b';
    }

    private string method_54(Stream A_0)
    {
        A_0.Position = 0L;
        byte[] buffer = new byte[A_0.Length];
        A_0.Read(buffer, 0, (int) A_0.Length);
        string str = Convert.ToBase64String(buffer);
        buffer = null;
        A_0.Position = 0L;
        return str;
    }

    private string method_540()
    {
        int num = 5;
        if (this.document_0 == null)
        {
            return BookmarkStart.b("ᨪ᤬", num);
        }
        int num2 = this.document_0.Settings.method_3();
        int num3 = this.document_0.method_159();
        if (num3 < num2)
        {
            return num2.ToString(CultureInfo.InvariantCulture);
        }
        return num3.ToString(CultureInfo.InvariantCulture);
    }

    private string method_541(string A_0)
    {
        string str = A_0;
        return str.Replace(BookmarkStart.b("⼮", 9), BookmarkStart.b("ਮ0", 9)).Replace(BookmarkStart.b("⸮", 9), BookmarkStart.b("ਮ̰", 9)).Replace(BookmarkStart.b("⴮", 9), BookmarkStart.b("ਮȰ", 9)).Replace(BookmarkStart.b("Ⱞ", 9), BookmarkStart.b("ਮ԰", 9)).Replace(BookmarkStart.b("⬮", 9), BookmarkStart.b("ਮа", 9)).Replace(BookmarkStart.b("⨮", 9), BookmarkStart.b("ਮܰ", 9)).Replace(BookmarkStart.b("⤮", 9), BookmarkStart.b("ਮذ", 9)).Replace(BookmarkStart.b("⠮", 9), BookmarkStart.b("ਮर", 9)).Replace(BookmarkStart.b("✮", 9), BookmarkStart.b("ਮ࠰", 9));
    }

    private string method_542(PageNumberStyle A_0)
    {
        int num = 12;
        switch (A_0)
        {
            case PageNumberStyle.RomanUpper:
                return BookmarkStart.b("䜱䐳䘵崷䠹渻儽ⴿ⍁⩃", num);

            case PageNumberStyle.RomanLower:
                return BookmarkStart.b("帱嬳䄵崷䠹渻儽ⴿ⍁⩃", num);

            case PageNumberStyle.LetterUpper:
                return BookmarkStart.b("䜱䐳䘵崷䠹瀻嬽㐿㙁⅃㑅", num);

            case PageNumberStyle.LetterLower:
                return BookmarkStart.b("帱嬳䄵崷䠹瀻嬽㐿㙁⅃㑅", num);
        }
        return BookmarkStart.b("嘱儳唵儷圹崻刽", num);
    }

    private int method_543()
    {
        return ++this.int_3;
    }

    private int method_544()
    {
        return ++this.int_4;
    }

    private int method_545()
    {
        return ++this.int_5;
    }

    private int method_546()
    {
        return ++this.int_6;
    }

    private string method_547(string A_0)
    {
        A_0 = A_0.Replace(Environment.NewLine, '\r'.ToString());
        A_0 = A_0.Replace('\n', '\r');
        A_0 = A_0.Replace('\a'.ToString(), string.Empty);
        A_0 = A_0.Replace('\b'.ToString(), string.Empty);
        return A_0;
    }

    private DocumentObject method_548(DocumentObject A_0)
    {
        DocumentObject owner = A_0;
        while (owner.Owner != null)
        {
            owner = owner.Owner;
            if (((owner is Section) || (owner is HeaderFooter)) || ((owner is Comment) || (owner is Footnote)))
            {
                return owner;
            }
        }
        return owner;
    }

    private bool method_549(DocumentObject A_0)
    {
        DocumentObject owner = A_0;
        while (owner.Owner != null)
        {
            owner = owner.Owner;
            if (((owner is TextBox) || (owner is Footnote)) || (owner is HeaderFooter))
            {
                return true;
            }
        }
        return false;
    }

    private void method_55(Class1128 A_0)
    {
        int num = 2;
        string str = A_0.method_3();
        string[] array = new string[A_0.method_2().Count];
        A_0.method_2().Keys.CopyTo(array, 0);
        for (int i = 0; i < array.Length; i++)
        {
            str = array[i];
            this.class771_0.method_14(str, A_0.method_2()[array[i]].method_4(), false, FileAttributes.Archive);
        }
        str = A_0.method_3();
        if (str == BookmarkStart.b("伧䘩䌫崭䌯匱䘳伵᜷", num))
        {
            str = BookmarkStart.b("弧䔩師䨭Ἧ", num) + str;
        }
        this.method_56(str, A_0.method_1());
        string[] strArray2 = new string[A_0.method_0().Count];
        A_0.method_0().Keys.CopyTo(strArray2, 0);
        for (int j = 0; j < strArray2.Length; j++)
        {
            string str2 = str + strArray2[j];
            this.class771_0.method_14(str2, A_0.method_0()[strArray2[j]].method_4(), false, FileAttributes.Archive);
        }
    }

    private void method_550(ParagraphBase A_0, string A_1, DictionaryEntry A_2)
    {
        DocumentObject obj2 = this.method_548(A_0);
        if (obj2 is HeaderFooter)
        {
            HeaderFooter footer = obj2 as HeaderFooter;
            this.method_278(A_1, footer, A_2);
        }
        else if (obj2 is Comment)
        {
            this.method_21().Add(A_1, A_2);
        }
        else if (obj2 is Footnote)
        {
            Footnote footnote = obj2 as Footnote;
            if (footnote.FootnoteType == FootnoteType.Footnote)
            {
                this.method_22().Add(A_1, A_2);
            }
            else
            {
                this.method_23().Add(A_1, A_2);
            }
        }
        else
        {
            this.method_20().Add(A_1, A_2);
        }
    }

    private ParagraphBase method_551(ParagraphBase A_0)
    {
        int num = 0;
        for (IDocumentObject obj2 = A_0.PreviousSibling; obj2 != null; obj2 = obj2.PreviousSibling)
        {
            Field field = obj2 as Field;
            TableOfContent content = obj2 as TableOfContent;
            FieldMark mark = obj2 as FieldMark;
            if ((field != null) || (content != null))
            {
                if (num == 0)
                {
                    if (content != null)
                    {
                        return content.TOCField;
                    }
                    return field;
                }
                num--;
            }
            if ((mark != null) && (mark.Type == FieldMarkType.FieldEnd))
            {
                num++;
            }
        }
        return null;
    }

    private List<string> method_552(Stream A_0)
    {
        int num = 5;
        A_0.Position = 0L;
        XmlReader reader = Class57.smethod_18(A_0);
        List<string> list = new List<string>();
        bool flag = false;
        while (true)
        {
            string str3;
            flag = false;
            reader.Read();
            string str = string.Empty;
            string item = string.Empty;
            if ((reader.NodeType == XmlNodeType.Element) && ((str3 = reader.LocalName) != null))
            {
                int num8;
                if (Class1160.dictionary_43 == null)
                {
                    Dictionary<string, int> dictionary1 = new Dictionary<string, int>(9);
                    dictionary1.Add(BookmarkStart.b("䴪䐬䌮崰", num), 0);
                    dictionary1.Add(BookmarkStart.b("䠪䔬丮䌰䜲", num), 1);
                    dictionary1.Add(BookmarkStart.b("䈪䀬丮嘰嘲儴嘶䴸娺", num), 2);
                    dictionary1.Add(BookmarkStart.b("堪夬崮帰堲倴", num), 3);
                    dictionary1.Add(BookmarkStart.b("䠪䈬䄮䔰䄲娴嬶", num), 4);
                    dictionary1.Add(BookmarkStart.b("搪愬樮縰儲弴制娸伺", num), 5);
                    dictionary1.Add(BookmarkStart.b("䌪听弮吰䄲头帶圸债", num), 6);
                    dictionary1.Add(BookmarkStart.b("䤪䄬䘮䄰", num), 7);
                    dictionary1.Add(BookmarkStart.b("太䠬䌮砰圲䘴", num), 8);
                    Class1160.dictionary_43 = dictionary1;
                }
                if (Class1160.dictionary_43.TryGetValue(str3, out num8))
                {
                    switch (num8)
                    {
                        case 0:
                        case 1:
                        case 2:
                        case 3:
                        case 4:
                        case 5:
                        case 6:
                        {
                            int i = 0;
                            int attributeCount = reader.AttributeCount;
                            while (i < attributeCount)
                            {
                                reader.MoveToAttribute(i);
                                if (reader.Prefix == BookmarkStart.b("太", num))
                                {
                                    if (reader.LocalName == BookmarkStart.b("䈪䤬", num))
                                    {
                                        str = reader.Value;
                                    }
                                    else if (reader.LocalName == BookmarkStart.b("䌪弬䨮地", num))
                                    {
                                        item = reader.Value;
                                    }
                                }
                                i++;
                            }
                            break;
                        }
                        case 7:
                        {
                            int num4 = 0;
                            int num7 = reader.AttributeCount;
                            while (num4 < num7)
                            {
                                reader.MoveToAttribute(num4);
                                if ((reader.Prefix == BookmarkStart.b("太", num)) && (reader.LocalName == BookmarkStart.b("个䀬䴮吰圲", num)))
                                {
                                    str = reader.Value;
                                }
                                num4++;
                            }
                            break;
                        }
                        case 8:
                        {
                            int num5 = 0;
                            int num6 = reader.AttributeCount;
                            while (num5 < num6)
                            {
                                reader.MoveToAttribute(num5);
                                if (reader.Prefix == BookmarkStart.b("太", num))
                                {
                                    if (reader.LocalName == BookmarkStart.b("伪䀬", num))
                                    {
                                        str = reader.Value;
                                        if (!string.IsNullOrEmpty(str))
                                        {
                                            list.Add(str);
                                        }
                                    }
                                    else if (reader.LocalName == BookmarkStart.b("䜪䈬", num))
                                    {
                                        str = reader.Value;
                                        if (!string.IsNullOrEmpty(str))
                                        {
                                            list.Add(str);
                                        }
                                    }
                                    else if (reader.LocalName == BookmarkStart.b("娪帬", num))
                                    {
                                        str = reader.Value;
                                        if (!string.IsNullOrEmpty(str))
                                        {
                                            list.Add(str);
                                        }
                                    }
                                    else if (reader.LocalName == BookmarkStart.b("䠪帬", num))
                                    {
                                        str = reader.Value;
                                        if (!string.IsNullOrEmpty(str))
                                        {
                                            list.Add(str);
                                        }
                                    }
                                }
                                num5++;
                            }
                            flag = true;
                            break;
                        }
                    }
                }
            }
            if (((str != null) && (str != string.Empty)) && !flag)
            {
                list.Add(str);
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

    private bool method_553()
    {
        Style style;
        int num = 0x13;
        if (((((style = this.document_0.Styles.FindByName(BookmarkStart.b("眸吺似刾⁀⽂敄ፆ⡈⥊⅌⩎", 0x13))) == null) || ((style != null) && (style.StyleType != StyleType.TableStyle))) && (((style = this.document_0.Styles.FindByName(BookmarkStart.b("眸吺似刾⁀⽂ᅄ♆⭈❊⡌", num))) == null) || ((style != null) && (style.StyleType != StyleType.TableStyle)))) && ((((style = this.document_0.Styles.FindByName(BookmarkStart.b("洸娺弼匾⑀捂ୄ⡆㭈♊ⱌ⍎", num))) == null) || ((style != null) && (style.StyleType != StyleType.TableStyle))) && (((style = this.document_0.Styles.FindByName(BookmarkStart.b("洸娺弼匾⑀ൂ⩄㕆⑈⩊⅌", num))) == null) || ((style != null) && (style.StyleType != StyleType.TableStyle)))))
        {
            return false;
        }
        return true;
    }

    private void method_56(string A_0, Dictionary<string, Class1128> A_1)
    {
        string str = A_0;
        string[] array = new string[A_1.Count];
        A_1.Keys.CopyTo(array, 0);
        for (int i = 0; i < array.Length; i++)
        {
            str = A_0 + array[i];
            string[] strArray3 = new string[A_1[array[i]].method_2().Count];
            A_1[array[i]].method_2().Keys.CopyTo(strArray3, 0);
            for (int m = 0; m < strArray3.Length; m++)
            {
                string str2 = str + strArray3[m];
                this.class771_0.method_14(str2, A_1[array[i]].method_2()[strArray3[m]].method_4(), false, FileAttributes.Archive);
            }
        }
        for (int j = 0; j < array.Length; j++)
        {
            str = A_0 + array[j];
            string[] strArray4 = new string[A_1[array[j]].method_0().Count];
            A_1[array[j]].method_0().Keys.CopyTo(strArray4, 0);
            for (int n = 0; n < strArray4.Length; n++)
            {
                string str3 = str + strArray4[n];
                this.class771_0.method_14(str3, A_1[array[j]].method_0()[strArray4[n]].method_4(), false, FileAttributes.Archive);
            }
        }
        for (int k = 0; k < array.Length; k++)
        {
            str = A_0 + array[k];
            string[] strArray2 = new string[A_1[array[k]].method_1().Count];
            A_1[array[k]].method_1().Keys.CopyTo(strArray2, 0);
            for (int num2 = 0; num2 < strArray2.Length; num2++)
            {
                string str4 = str + strArray2[num2];
                this.method_56(str4, A_1[array[k]].method_1()[strArray2[num2]].method_1());
            }
        }
    }

    private void method_57()
    {
        int num = 15;
        this.method_58();
        if ((this.list_4 != null) || (this.document_0.FontInfoList.method_4() != 0))
        {
            this.method_27(true);
            this.method_70();
            this.dictionary_32 = this.document_0.DocxNameSpace.method_0()[BookmarkStart.b("匴堶圸伺丼", num)];
            MemoryStream stream = new MemoryStream();
            this.class1092_0 = this.method_524(stream);
            this.class1092_0.method_11(BookmarkStart.b("䈴", num), BookmarkStart.b("匴堶圸伺丼", num), this.dictionary_32[BookmarkStart.b("䈴", num)]);
            this.class1092_0.method_6(BookmarkStart.b("䴴娶唸唺丼", num), BookmarkStart.b("場吶", num), null, this.dictionary_32[BookmarkStart.b("場吶", num)]);
            this.class1092_0.method_6(BookmarkStart.b("䴴娶唸唺丼", num), BookmarkStart.b("䜴", num), null, this.dictionary_32[BookmarkStart.b("䜴", num)]);
            this.class1092_0.method_6(BookmarkStart.b("䴴娶唸唺丼", num), BookmarkStart.b("䈴", num), null, this.dictionary_32[BookmarkStart.b("䈴", num)]);
            this.class1092_0.method_6(BookmarkStart.b("䴴娶唸唺丼", num), BookmarkStart.b("䈴ضസ", num), null, this.dictionary_32[BookmarkStart.b("䈴ضസ", num)]);
            this.class1092_0.method_6(BookmarkStart.b("場吶", num), BookmarkStart.b("簴倶圸吺似帾⍀⽂⁄", num), null, BookmarkStart.b("䈴ضസ", num));
            List<string> list = new List<string>();
            if (this.list_4 != null)
            {
                foreach (string str in this.list_4)
                {
                    if (this.document_0.FontInfoList.method_7(str))
                    {
                        list.Add(str);
                        Form4 form = this.document_0.FontInfoList.method_5(str);
                        this.method_60(form);
                    }
                    else
                    {
                        this.class1092_0.method_10(BookmarkStart.b("匴堶圸伺", num), this.dictionary_32[BookmarkStart.b("䈴", num)]);
                        this.class1092_0.method_5(BookmarkStart.b("嬴嘶吸帺", num), this.dictionary_32[BookmarkStart.b("䈴", num)], str);
                        this.class1092_0.method_10(BookmarkStart.b("嘴弶堸䤺丼娾㕀", num), this.dictionary_32[BookmarkStart.b("䈴", num)]);
                        this.class1092_0.method_5(BookmarkStart.b("䌴嘶唸", num), this.dictionary_32[BookmarkStart.b("䈴", num)], BookmarkStart.b("ԴԶ", num));
                        this.class1092_0.method_12();
                        this.class1092_0.method_12();
                    }
                }
            }
            using (IEnumerator enumerator = this.document_0.FontInfoList.System.Collections.IEnumerable.GetEnumerator())
            {
                while (enumerator.MoveNext())
                {
                    Form4 form3 = (Form4) enumerator.Current;
                    if (!list.Contains(form3.method_31()) && (form3.method_31() != string.Empty))
                    {
                        this.method_60(form3);
                    }
                }
            }
            this.class1092_0.method_12();
            this.class1092_0.method_15();
            this.class771_0.method_14(BookmarkStart.b("䈴堶䬸强愼夾⹀ⵂㅄፆ⡈⥊⅌⩎罐⭒㡔㭖", num), stream, false, FileAttributes.Archive);
            this.method_59(this.method_39());
        }
    }

    private void method_58()
    {
        int num = 9;
        if (this.document_0.EmbedFontsInFile && (this.method_0().Count > 0))
        {
            foreach (string str2 in this.method_0())
            {
                string str = str2;
                FontStyle regular = FontStyle.Regular;
                EmbeddedFontStyle boldItalic = EmbeddedFontStyle.Regular;
                string[] strArray = str2.Split(new char[] { '_' }, StringSplitOptions.RemoveEmptyEntries);
                if (strArray.Length > 0)
                {
                    str = strArray[0];
                }
                if (str2.Contains(BookmarkStart.b("瀮匰尲头匶倸伺尼匾⡀⁂", num)))
                {
                    regular = (regular | FontStyle.Bold) | FontStyle.Italic;
                    boldItalic = EmbeddedFontStyle.BoldItalic;
                }
                else if (str2.Contains(BookmarkStart.b("瀮匰尲头匶", num)))
                {
                    regular |= FontStyle.Bold;
                    boldItalic = EmbeddedFontStyle.Bold;
                }
                else if (str2.Contains(BookmarkStart.b("瀮堰䜲吴嬶倸堺", num)))
                {
                    regular |= FontStyle.Italic;
                    boldItalic = EmbeddedFontStyle.Italic;
                }
                Form4 form = null;
                if (!this.document_0.FontInfoList.method_7(str))
                {
                    form = new Form4(this.document_0, str);
                    this.document_0.FontInfoList.method_11(form);
                    form = this.document_0.FontInfoList.method_5(str);
                }
                else
                {
                    form = this.document_0.FontInfoList.method_5(str);
                }
                if (form != null)
                {
                    bool flag = false;
                    if (this.document_0.PrivateFontList.Count > 0)
                    {
                        foreach (PrivateFontPath path in this.document_0.PrivateFontList)
                        {
                            string fontName = path.FontName;
                            FontStyle fontStyle = path.FontStyle;
                            string fontPath = path.FontPath;
                            if ((File.Exists(fontPath) && fontName.ToLowerInvariant().Equals(str)) && (fontStyle == regular))
                            {
                                byte[] buffer2 = File.ReadAllBytes(fontPath);
                                form.method_56(buffer2, EmbeddedFontFormat.OpenType, boldItalic, false);
                                flag = true;
                            }
                        }
                    }
                    if (!flag && this.document_0.EmbedSystemFonts)
                    {
                        using (Font font = new Font(str, 1f, regular))
                        {
                            if (font.Name.ToLowerInvariant().Equals(str))
                            {
                                byte[] buffer = Class668.smethod_0(font);
                                form.method_56(buffer, EmbeddedFontFormat.OpenType, boldItalic, false);
                            }
                        }
                    }
                }
            }
        }
    }

    private void method_59(Dictionary<string, byte[]> A_0)
    {
        int num = 7;
        if ((A_0 != null) && (A_0.Count > 0))
        {
            this.dictionary_32 = this.document_0.DocxNameSpace.method_0()[BookmarkStart.b("缬䨮崰刲䄴帶嘸唺丼圾⡀㍂㙄", num)];
            MemoryStream stream = new MemoryStream();
            this.class1092_0 = this.method_524(stream);
            this.class1092_0.method_10(BookmarkStart.b("缬䨮崰刲䄴帶嘸唺丼圾⡀㍂㙄", num), this.dictionary_32[BookmarkStart.b("唬䈮崰崲䘴", num)]);
            foreach (string str in A_0.Keys)
            {
                byte[] buffer = A_0[str];
                string str2 = BookmarkStart.b("娬䀮䌰圲椴儶嘸唺䤼䰾ᵀ╂⩄⥆㵈", num) + str.Replace(BookmarkStart.b("弬昮唰", num), string.Empty) + BookmarkStart.b("̬䀮唰䜲䄴儶", num);
                this.method_512(stream, str, BookmarkStart.b("䔬嬮䔰䌲༴ᠶᘸ䠺帼圾⑀⹂⑄㑆杈⑊㵌⩎㽐⭒㡔㭖㽘㑚⽜㉞`ᝢᙤ䥦٨ᥪ੬䁮Ṱᕲ፴Ṷ᩸Ṻ㥼ၾﾊꊌ붎ꆐꎒꎔ뢖ﺚﺞ햠쪢쪤즦\udaa8\uc3aa쒬\udfae\uc2b0鲲펴\ud8b6\ud7b8쾺", num), str2.Replace(BookmarkStart.b("娬䀮䌰圲椴", num), string.Empty));
                if (this.class771_0.method_29(str2.Replace(BookmarkStart.b("焬", num), BookmarkStart.b("Ȭ", num))) == -1)
                {
                    this.class771_0.method_14(str2, new MemoryStream(buffer), false, FileAttributes.Archive);
                }
            }
            this.class1092_0.method_12();
            this.class1092_0.method_15();
            this.class771_0.method_14(BookmarkStart.b("娬䀮䌰圲椴栶䬸帺儼䰾ᵀ╂⩄⥆㵈Ὂⱌⵎ㵐㙒答⽖㑘㝚獜ⵞѠརᙤ", num), stream, false, FileAttributes.Archive);
        }
    }

    private Dictionary<Comment, string> method_6()
    {
        if (this.dictionary_33 == null)
        {
            this.dictionary_33 = new Dictionary<Comment, string>();
        }
        return this.dictionary_33;
    }

    private void method_60(Form4 A_0)
    {
        int num = 11;
        this.class1092_0.method_10(BookmarkStart.b("地尲嬴䌶", 11), this.dictionary_32[BookmarkStart.b("䘰", 11)]);
        this.class1092_0.method_5(BookmarkStart.b("弰刲場制", 11), this.dictionary_32[BookmarkStart.b("䘰", 11)], A_0.method_31());
        if (A_0.HasKey(1))
        {
            this.class1092_0.method_10(BookmarkStart.b("倰弲䄴礶堸嘺堼", num), this.dictionary_32[BookmarkStart.b("䘰", num)]);
            string str = A_0.method_33();
            if (str.IndexOf(BookmarkStart.b("㄰", num)) >= 0)
            {
                str = str.Substring(0, str.IndexOf(BookmarkStart.b("㄰", num)));
            }
            str = str.Replace('\0', ';');
            this.class1092_0.method_5(BookmarkStart.b("䜰刲头", num), this.dictionary_32[BookmarkStart.b("䘰", num)], str);
            this.class1092_0.method_12();
        }
        if (A_0.HasKey(2))
        {
            this.class1092_0.method_10(BookmarkStart.b("䄰刲嬴堶䨸帺఼", num), this.dictionary_32[BookmarkStart.b("䘰", num)]);
            this.class1092_0.method_5(BookmarkStart.b("䜰刲头", num), this.dictionary_32[BookmarkStart.b("䘰", num)], this.method_63(A_0.method_35()));
            this.class1092_0.method_12();
        }
        if (!A_0.method_43())
        {
            this.class1092_0.method_10(BookmarkStart.b("弰尲䄴挶䬸为堼款㡀㍂⁄", num), this.dictionary_32[BookmarkStart.b("䘰", num)]);
            this.class1092_0.method_12();
        }
        if (A_0.HasKey(3))
        {
            this.class1092_0.method_10(BookmarkStart.b("到嬲吴䔶䨸帺䤼", num), this.dictionary_32[BookmarkStart.b("䘰", num)]);
            this.class1092_0.method_5(BookmarkStart.b("䜰刲头", num), this.dictionary_32[BookmarkStart.b("䘰", num)], this.method_62(A_0.method_37()));
            this.class1092_0.method_12();
        }
        if (A_0.HasKey(4))
        {
            this.class1092_0.method_10(BookmarkStart.b("地刲場帶唸䈺", num), this.dictionary_32[BookmarkStart.b("䘰", num)]);
            this.class1092_0.method_5(BookmarkStart.b("䜰刲头", num), this.dictionary_32[BookmarkStart.b("䘰", num)], this.method_66(A_0.method_39()));
            this.class1092_0.method_12();
        }
        if (A_0.HasKey(5))
        {
            this.class1092_0.method_10(BookmarkStart.b("䄰娲䄴吶儸", num), this.dictionary_32[BookmarkStart.b("䘰", num)]);
            this.class1092_0.method_5(BookmarkStart.b("䜰刲头", num), this.dictionary_32[BookmarkStart.b("䘰", num)], this.method_67(A_0.method_41()));
            this.class1092_0.method_12();
        }
        if (A_0.HasKey(6))
        {
            this.class1092_0.method_10(BookmarkStart.b("䈰娲刴", num), this.dictionary_32[BookmarkStart.b("䘰", num)]);
            this.class1092_0.method_5(BookmarkStart.b("䐰䀲圴ܶ", num), this.dictionary_32[BookmarkStart.b("䘰", num)], this.method_64(A_0.method_45(), 0, 4, true));
            this.class1092_0.method_5(BookmarkStart.b("䐰䀲圴ض", num), this.dictionary_32[BookmarkStart.b("䘰", num)], this.method_64(A_0.method_45(), 4, 4, true));
            this.class1092_0.method_5(BookmarkStart.b("䐰䀲圴Զ", num), this.dictionary_32[BookmarkStart.b("䘰", num)], this.method_64(A_0.method_45(), 8, 4, true));
            this.class1092_0.method_5(BookmarkStart.b("䐰䀲圴ж", num), this.dictionary_32[BookmarkStart.b("䘰", num)], this.method_64(A_0.method_45(), 12, 4, true));
            this.class1092_0.method_5(BookmarkStart.b("到䀲圴ܶ", num), this.dictionary_32[BookmarkStart.b("䘰", num)], this.method_64(A_0.method_45(), 0x10, 4, true));
            this.class1092_0.method_5(BookmarkStart.b("到䀲圴ض", num), this.dictionary_32[BookmarkStart.b("䘰", num)], this.method_64(A_0.method_45(), 20, 4, true));
            this.class1092_0.method_12();
        }
        Class827[] classArray = A_0.method_52(EmbeddedFontFormat.OpenType);
        if (classArray != null)
        {
            this.method_68(classArray);
        }
        this.class1092_0.method_12();
    }

    private string method_61(int A_0)
    {
        return A_0.ToString(CultureInfo.InvariantCulture);
    }

    private string method_62(int A_0)
    {
        return A_0.ToString(BookmarkStart.b("眮̰", 9), CultureInfo.InvariantCulture);
    }

    private string method_63(byte[] A_0)
    {
        return this.method_64(A_0, 0, A_0.Length, false);
    }

    private string method_64(byte[] A_0, int A_1, int A_2, bool A_3)
    {
        StringBuilder builder = new StringBuilder(A_2 * 2);
        int num2 = A_3 ? -1 : 1;
        if (A_3)
        {
            A_1 += A_2 - 1;
        }
        for (int i = 0; i < A_2; i++)
        {
            builder.Append(this.method_65(A_0[A_1]));
            A_1 += num2;
        }
        return builder.ToString();
    }

    private char[] method_65(byte A_0)
    {
        return new char[] { char_2[(A_0 >> 4) & 15], char_2[A_0 & 15] };
    }

    private string method_66(FontFamily A_0)
    {
        int num = 10;
        switch (A_0)
        {
            case FontFamily.Roman:
                return BookmarkStart.b("戯崱夳圵嘷", num);

            case FontFamily.Swiss:
                return BookmarkStart.b("振䔱崳䔵䬷", num);

            case FontFamily.Decorative:
                return BookmarkStart.b("琯圱圳夵䨷嬹䠻圽㘿❁", num);

            case FontFamily.Modern:
                return BookmarkStart.b("累崱倳匵䨷吹", num);

            case FontFamily.Script:
                return BookmarkStart.b("振儱䘳張䠷丹", num);
        }
        return BookmarkStart.b("焯䜱䀳夵", num);
    }

    private string method_67(FontPitch A_0)
    {
        int num = 9;
        switch (A_0)
        {
            case FontPitch.Fixed:
                return BookmarkStart.b("䤮堰䬲倴匶", num);

            case FontPitch.Variable:
                return BookmarkStart.b("央倰䄲尴嘶嬸场堼", num);
        }
        return BookmarkStart.b("䬮吰唲吴䈶唸伺", num);
    }

    private void method_68(Class827[] A_0)
    {
        int num = 13;
        foreach (Class827 class2 in A_0)
        {
            if (class2 != null)
            {
                string str = BookmarkStart.b("唲娴夶䴸䠺ሼ夾⹀ⵂㅄ", num) + this.method_61(this.int_12++) + BookmarkStart.b("ᴲ娴匶䴸伺嬼", num);
                this.method_69(class2, str);
            }
        }
    }

    private void method_69(Class827 A_0, string A_1)
    {
        int num = 1;
        using (MemoryStream stream = new MemoryStream())
        {
            string key = this.method_71();
            string str2 = Class492.smethod_0(A_0, stream);
            this.method_39().Add(key, stream.ToArray());
            this.class1092_0.method_11(BookmarkStart.b("倦", num), this.method_72(A_0.method_2()), this.dictionary_32[BookmarkStart.b("倦", num)]);
            this.class1092_0.method_6(BookmarkStart.b("唦", num), BookmarkStart.b("並䴨", num), this.dictionary_32[BookmarkStart.b("唦", num)], key);
            if (A_0.method_3())
            {
                this.class1092_0.method_6(BookmarkStart.b("倦", num), BookmarkStart.b("否尨䤪帬䨮䔰䜲倴匶", num), this.dictionary_32[BookmarkStart.b("倦", num)], BookmarkStart.b("ᘦ", num));
            }
            this.class1092_0.method_6(BookmarkStart.b("倦", num), BookmarkStart.b("䄦䘨䔪夬搮吰䨲", num), this.dictionary_32[BookmarkStart.b("倦", num)], str2);
            this.class1092_0.method_12();
            this.bool_10 = true;
        }
    }

    internal Dictionary<string, string> method_7()
    {
        if (this.dictionary_28 == null)
        {
            this.dictionary_28 = new Dictionary<string, string>();
        }
        return this.dictionary_28;
    }

    private void method_70()
    {
        this.int_1 = 0;
    }

    private string method_71()
    {
        return string.Format(BookmarkStart.b("太搬䬮䨰̲䠴", 5), ++this.int_1);
    }

    private string method_72(EmbeddedFontStyle A_0)
    {
        int num = 13;
        switch (A_0)
        {
            case EmbeddedFontStyle.Regular:
                return BookmarkStart.b("嘲場唶尸强漼娾♀㙂⥄♆㭈", num);

            case EmbeddedFontStyle.Bold:
                return BookmarkStart.b("嘲場唶尸强缼倾ⵀ❂", num);

            case EmbeddedFontStyle.Italic:
                return BookmarkStart.b("嘲場唶尸强琼䬾⁀⽂ⱄ⑆", num);

            case EmbeddedFontStyle.BoldItalic:
                return BookmarkStart.b("嘲場唶尸强缼倾ⵀ❂ౄ㍆⡈❊⑌ⱎ", num);
        }
        throw new ArgumentException(BookmarkStart.b("唲娴夶䴸栺䤼䘾ⵀ♂", num));
    }

    private void method_73()
    {
        int num = 0x12;
        this.dictionary_32 = this.document_0.DocxNameSpace.method_0()[BookmarkStart.b("尷唹弻䬽ⴿ❁⩃㉅", 0x12)];
        MemoryStream stream = new MemoryStream(0x1388);
        this.class1092_0 = this.method_524(stream);
        this.class1092_0.method_11(BookmarkStart.b("伷", 0x12), BookmarkStart.b("尷唹弻䬽ⴿ❁⩃㉅", 0x12), this.dictionary_32[BookmarkStart.b("伷", 0x12)]);
        this.class1092_0.method_6(BookmarkStart.b("䀷圹倻倽㌿", 0x12), BookmarkStart.b("伷䨹弻", 0x12), null, this.dictionary_32[BookmarkStart.b("伷䨹弻", 0x12)]);
        this.class1092_0.method_6(BookmarkStart.b("䀷圹倻倽㌿", 0x12), BookmarkStart.b("唷夹", 0x12), null, this.dictionary_32[BookmarkStart.b("唷夹", 0x12)]);
        this.class1092_0.method_6(BookmarkStart.b("䀷圹倻倽㌿", 0x12), BookmarkStart.b("圷", 0x12), null, this.dictionary_32[BookmarkStart.b("圷", 0x12)]);
        this.class1092_0.method_6(BookmarkStart.b("䀷圹倻倽㌿", 0x12), BookmarkStart.b("䨷", 0x12), null, this.dictionary_32[BookmarkStart.b("䨷", 0x12)]);
        this.class1092_0.method_6(BookmarkStart.b("䀷圹倻倽㌿", 0x12), BookmarkStart.b("唷", 0x12), null, this.dictionary_32[BookmarkStart.b("唷", 0x12)]);
        this.class1092_0.method_6(BookmarkStart.b("䀷圹倻倽㌿", 0x12), BookmarkStart.b("丷", 0x12), null, this.dictionary_32[BookmarkStart.b("丷", 0x12)]);
        this.class1092_0.method_6(BookmarkStart.b("䀷圹倻倽㌿", 0x12), BookmarkStart.b("伷䨹഻਽", 0x12), null, this.dictionary_32[BookmarkStart.b("伷䨹഻਽", 0x12)]);
        this.class1092_0.method_6(BookmarkStart.b("䀷圹倻倽㌿", 0x12), BookmarkStart.b("伷䨹", 0x12), null, this.dictionary_32[BookmarkStart.b("伷䨹", 0x12)]);
        this.class1092_0.method_6(BookmarkStart.b("䀷圹倻倽㌿", 0x12), BookmarkStart.b("伷ହ఻", 0x12), null, this.dictionary_32[BookmarkStart.b("伷ହ఻", 0x12)]);
        this.class1092_0.method_6(BookmarkStart.b("䀷圹倻倽㌿", 0x12), BookmarkStart.b("伷", 0x12), null, this.dictionary_32[BookmarkStart.b("伷", 0x12)]);
        this.class1092_0.method_6(BookmarkStart.b("䀷圹倻倽㌿", 0x12), BookmarkStart.b("伷ହ࠻", 0x12), null, this.dictionary_32[BookmarkStart.b("伷ହ࠻", 0x12)]);
        this.class1092_0.method_6(BookmarkStart.b("䀷圹倻倽㌿", 0x12), BookmarkStart.b("伷䨹嬻", 0x12), null, this.dictionary_32[BookmarkStart.b("伷䨹嬻", 0x12)]);
        this.class1092_0.method_6(BookmarkStart.b("䀷圹倻倽㌿", 0x12), BookmarkStart.b("伷䨹唻", 0x12), null, this.dictionary_32[BookmarkStart.b("伷䨹唻", 0x12)]);
        this.class1092_0.method_6(BookmarkStart.b("䀷圹倻倽㌿", 0x12), BookmarkStart.b("伷吹夻", 0x12), null, this.dictionary_32[BookmarkStart.b("伷吹夻", 0x12)]);
        this.class1092_0.method_6(BookmarkStart.b("䀷圹倻倽㌿", 0x12), BookmarkStart.b("伷䨹伻", 0x12), null, this.dictionary_32[BookmarkStart.b("伷䨹伻", 0x12)]);
        if (this.document_0.method_159() == 15)
        {
            this.class1092_0.method_6(BookmarkStart.b("䀷圹倻倽㌿", num), BookmarkStart.b("伷ହऻ", num), null, this.dictionary_32[BookmarkStart.b("伷ହऻ", num)]);
        }
        string str = (this.document_0.method_159() == 15) ? BookmarkStart.b("伷ହ࠻ḽ㜿獁煃晅㽇㩉絋積", num) : BookmarkStart.b("伷ହ࠻ḽ㜿㉁畃牅", num);
        this.class1092_0.method_6(BookmarkStart.b("唷夹", num), BookmarkStart.b("焷崹刻儽㈿⍁♃⩅ⵇ", num), null, str);
        this.method_109(this.document_0.Background);
        this.method_114();
        this.class1092_0.method_12();
        this.class1092_0.method_15();
        this.class771_0.method_14(BookmarkStart.b("伷唹主娽᰿♁⭃╅㵇❉⥋⁍⑏籑ⱓ㭕㑗", num), stream, false, FileAttributes.Archive);
    }

    private void method_74()
    {
        this.dictionary_32 = this.document_0.DocxNameSpace.method_0()[BookmarkStart.b("樷弹倻弽㐿⭁⭃⡅㭇≉╋㹍⍏", 0x12)];
        MemoryStream stream = new MemoryStream();
        this.class1092_0 = this.method_524(stream);
        this.class1092_0.method_10(BookmarkStart.b("樷弹倻弽㐿⭁⭃⡅㭇≉╋㹍⍏", 0x12), this.dictionary_32[BookmarkStart.b("䀷圹倻倽㌿", 0x12)]);
        this.method_512(stream, this.method_527(), BookmarkStart.b("倷丹䠻丽稿流歃㕅⭇≉⥋⍍ㅏ⅑穓㭕ㅗ㥙⹛ㅝ፟ൡɣብ䙧३ͫͭ彯ᵱታၵᅷ᥹᥻兽뉿늁뒃낅ꞇﶓ秊킟톡讣톥잧\ud8a9\uc8ab튯펱ힵ첷\udbb9", 0x12), BookmarkStart.b("丷堹崻稽ℿ㙁╃桅ぇ❉⁋", 0x12));
        this.class1092_0.method_12();
        this.class1092_0.method_15();
        this.class771_0.method_14(BookmarkStart.b("伷唹主娽᰿ᵁ㙃⍅⑇㥉။㡍㉏㍑ѓ⑕㝗す㥛㵝ᑟ䱡٣ཥ٧䑩ṫ୭ᱯű", 0x12), stream, false, FileAttributes.Archive);
    }

    private void method_75()
    {
        this.class771_0.method_14(BookmarkStart.b("帨䐪弬䬮洰䔲圴嘶椸䤺刼唾⑀⁂ㅄ楆⭈≊⍌", 3), this.document_0.VbaProject, false, FileAttributes.Archive);
    }

    private void method_76()
    {
        int num = 8;
        this.dictionary_32 = this.document_0.DocxNameSpace.method_0()[BookmarkStart.b("堭刯匱朳䌵䠷䨹砻弽㐿⍁", 8)];
        MemoryStream stream = new MemoryStream();
        this.class1092_0 = this.method_524(stream);
        this.class1092_0.method_11(BookmarkStart.b("夭帯圱", 8), BookmarkStart.b("堭刯匱朳䌵䠷䨹砻弽㐿⍁", 8), this.dictionary_32[BookmarkStart.b("夭帯圱", 8)]);
        this.class1092_0.method_6(BookmarkStart.b("嘭崯帱娳䔵", 8), BookmarkStart.b("夭䀯儱", 8), null, this.dictionary_32[BookmarkStart.b("夭䀯儱", 8)]);
        this.class1092_0.method_6(BookmarkStart.b("嘭崯帱娳䔵", 8), BookmarkStart.b("䌭匯", 8), null, this.dictionary_32[BookmarkStart.b("䌭匯", 8)]);
        this.class1092_0.method_6(BookmarkStart.b("嘭崯帱娳䔵", 8), BookmarkStart.b("䄭", 8), null, this.dictionary_32[BookmarkStart.b("䄭", 8)]);
        this.class1092_0.method_6(BookmarkStart.b("嘭崯帱娳䔵", 8), BookmarkStart.b("尭", 8), null, this.dictionary_32[BookmarkStart.b("尭", 8)]);
        this.class1092_0.method_6(BookmarkStart.b("嘭崯帱娳䔵", 8), BookmarkStart.b("䌭", 8), null, this.dictionary_32[BookmarkStart.b("䌭", 8)]);
        this.class1092_0.method_6(BookmarkStart.b("嘭崯帱娳䔵", 8), BookmarkStart.b("堭", 8), null, this.dictionary_32[BookmarkStart.b("堭", 8)]);
        this.class1092_0.method_6(BookmarkStart.b("嘭崯帱娳䔵", 8), BookmarkStart.b("夭䀯̱3", 8), null, this.dictionary_32[BookmarkStart.b("夭䀯̱3", 8)]);
        this.class1092_0.method_6(BookmarkStart.b("嘭崯帱娳䔵", 8), BookmarkStart.b("夭䀯", 8), null, this.dictionary_32[BookmarkStart.b("夭䀯", 8)]);
        this.class1092_0.method_6(BookmarkStart.b("嘭崯帱娳䔵", 8), BookmarkStart.b("夭įȱ", 8), null, this.dictionary_32[BookmarkStart.b("夭įȱ", 8)]);
        this.class1092_0.method_6(BookmarkStart.b("嘭崯帱娳䔵", 8), BookmarkStart.b("夭", 8), null, this.dictionary_32[BookmarkStart.b("夭", 8)]);
        this.class1092_0.method_6(BookmarkStart.b("嘭崯帱娳䔵", 8), BookmarkStart.b("夭įر", 8), null, this.dictionary_32[BookmarkStart.b("夭įر", 8)]);
        this.class1092_0.method_6(BookmarkStart.b("嘭崯帱娳䔵", 8), BookmarkStart.b("夭䀯唱", 8), null, this.dictionary_32[BookmarkStart.b("夭䀯唱", 8)]);
        this.class1092_0.method_6(BookmarkStart.b("嘭崯帱娳䔵", 8), BookmarkStart.b("夭䀯嬱", 8), null, this.dictionary_32[BookmarkStart.b("夭䀯嬱", 8)]);
        this.class1092_0.method_6(BookmarkStart.b("嘭崯帱娳䔵", 8), BookmarkStart.b("夭帯圱", 8), null, this.dictionary_32[BookmarkStart.b("夭帯圱", 8)]);
        this.class1092_0.method_6(BookmarkStart.b("嘭崯帱娳䔵", 8), BookmarkStart.b("夭䀯䄱", 8), null, this.dictionary_32[BookmarkStart.b("夭䀯䄱", 8)]);
        this.class1092_0.method_6(BookmarkStart.b("䌭匯", 8), BookmarkStart.b("札圯就嬳䐵夷堹倻嬽", 8), null, BookmarkStart.b("夭įرᐳ䄵䠷ହ࠻", 8));
        if (this.document_0.DocEvents.Count > 0)
        {
            this.class1092_0.method_11(BookmarkStart.b("夭帯圱", num), BookmarkStart.b("䨭弯儱焳䀵崷吹䠻䴽", num), this.dictionary_32[BookmarkStart.b("夭帯圱", num)]);
            foreach (string str in this.document_0.DocEvents)
            {
                this.class1092_0.method_11(BookmarkStart.b("夭帯圱", num), str, this.dictionary_32[BookmarkStart.b("夭帯圱", num)]);
                this.class1092_0.method_12();
            }
            this.class1092_0.method_12();
        }
        if (this.document_0.VbaData.Count > 0)
        {
            this.class1092_0.method_11(BookmarkStart.b("夭帯圱", num), BookmarkStart.b("䌭匯嘱䜳", num), this.dictionary_32[BookmarkStart.b("夭帯圱", num)]);
            foreach (Class512 class2 in this.document_0.VbaData)
            {
                this.class1092_0.method_11(BookmarkStart.b("夭帯圱", num), BookmarkStart.b("䌭匯嘱", num), this.dictionary_32[BookmarkStart.b("夭帯圱", num)]);
                this.class1092_0.method_6(BookmarkStart.b("夭帯圱", num), BookmarkStart.b("䌭儯儱䘳夵瘷嬹儻嬽", num), this.dictionary_32[BookmarkStart.b("夭帯圱", num)], class2.method_0().ToUpper());
                this.class1092_0.method_6(BookmarkStart.b("夭帯圱", num), BookmarkStart.b("䀭儯弱儳", num), this.dictionary_32[BookmarkStart.b("夭帯圱", num)], class2.method_0());
                this.class1092_0.method_6(BookmarkStart.b("夭帯圱", num), BookmarkStart.b("䰭甯就圳䐵䄷䨹䠻", num), this.dictionary_32[BookmarkStart.b("夭帯圱", num)], class2.method_2());
                this.class1092_0.method_6(BookmarkStart.b("夭帯圱", num), BookmarkStart.b("䴭崯唱", num), this.dictionary_32[BookmarkStart.b("夭帯圱", num)], class2.method_4());
                this.class1092_0.method_12();
            }
            this.class1092_0.method_12();
        }
        this.class1092_0.method_12();
        this.class1092_0.method_15();
        this.class771_0.method_14(BookmarkStart.b("夭弯䀱倳樵丷堹崻稽ℿ㙁╃桅ぇ❉⁋", num), stream, false, FileAttributes.Archive);
    }

    private void method_77()
    {
        this.method_78(HeaderFooterType.FooterEven, this.document_0);
        this.method_78(HeaderFooterType.HeaderEven, this.document_0);
        this.method_78(HeaderFooterType.FooterFirstPage, this.document_0);
        this.method_78(HeaderFooterType.HeaderFirstPage, this.document_0);
        this.method_78(HeaderFooterType.FooterOdd, this.document_0);
        this.method_78(HeaderFooterType.HeaderOdd, this.document_0);
    }

    private void method_78(HeaderFooterType A_0, Document A_1)
    {
        int num = 0x12;
        if ((this.method_1().Count != 0) && this.method_1().ContainsKey(A_0))
        {
            Dictionary<string, HeaderFooter> dictionary = this.method_1()[A_0];
            HeaderFooter footer = null;
            foreach (string str in dictionary.Keys)
            {
                string str2;
                string str3;
                footer = dictionary[str];
                if (((A_0 != HeaderFooterType.HeaderEven) && (A_0 != HeaderFooterType.HeaderFirstPage)) && (A_0 != HeaderFooterType.HeaderOdd))
                {
                    str2 = BookmarkStart.b("伷唹主娽᰿⑁⭃⥅㱇⽉㹋", num) + str.Replace(BookmarkStart.b("䨷猹堻", num), "") + BookmarkStart.b("ᘷ䈹儻刽", num);
                    str3 = BookmarkStart.b("伷唹主娽᰿ᵁ㙃⍅⑇㥉။⡍㽏㵑⁓㍕⩗", num) + str.Replace(BookmarkStart.b("䨷猹堻", num), "") + BookmarkStart.b("ᘷ䈹儻刽渿ぁ⅃⩅㭇", num);
                    this.method_83(footer, str, str2, str3);
                }
                else
                {
                    str2 = BookmarkStart.b("伷唹主娽᰿⩁⅃❅ⱇ⽉㹋", num) + str.Replace(BookmarkStart.b("䨷猹堻", num), "") + BookmarkStart.b("ᘷ䈹儻刽", num);
                    str3 = BookmarkStart.b("伷唹主娽᰿ᵁ㙃⍅⑇㥉။♍㕏㍑こ㍕⩗", num) + str.Replace(BookmarkStart.b("䨷猹堻", num), "") + BookmarkStart.b("ᘷ䈹儻刽渿ぁ⅃⩅㭇", num);
                    this.method_79(footer, str, str2, str3);
                }
            }
        }
    }

    private void method_79(HeaderFooter A_0, string A_1, string A_2, string A_3)
    {
        this.bool_21 = false;
        this.dictionary_32 = this.document_0.DocxNameSpace.method_0()[BookmarkStart.b("䜮吰刲儴制䬸崺刼倾㕀♂㝄", 9)];
        MemoryStream stream = new MemoryStream();
        this.class1092_0 = this.method_524(stream);
        this.class1092_0.method_11(BookmarkStart.b("堮", 9), BookmarkStart.b("䜮唰䄲", 9), this.dictionary_32[BookmarkStart.b("堮", 9)]);
        this.class1092_0.method_6(BookmarkStart.b("圮尰弲嬴䐶", 9), BookmarkStart.b("央", 9), null, this.dictionary_32[BookmarkStart.b("央", 9)]);
        this.class1092_0.method_6(BookmarkStart.b("圮尰弲嬴䐶", 9), BookmarkStart.b("堮0̲", 9), null, this.dictionary_32[BookmarkStart.b("堮0̲", 9)]);
        this.class1092_0.method_6(BookmarkStart.b("圮尰弲嬴䐶", 9), BookmarkStart.b("䀮", 9), null, this.dictionary_32[BookmarkStart.b("䀮", 9)]);
        this.class1092_0.method_6(BookmarkStart.b("圮尰弲嬴䐶", 9), BookmarkStart.b("央吰", 9), null, this.dictionary_32[BookmarkStart.b("央吰", 9)]);
        this.class1092_0.method_6(BookmarkStart.b("圮尰弲嬴䐶", 9), BookmarkStart.b("崮", 9), null, this.dictionary_32[BookmarkStart.b("崮", 9)]);
        this.class1092_0.method_6(BookmarkStart.b("圮尰弲嬴䐶", 9), BookmarkStart.b("䈮", 9), null, this.dictionary_32[BookmarkStart.b("䈮", 9)]);
        this.class1092_0.method_6(BookmarkStart.b("圮尰弲嬴䐶", 9), BookmarkStart.b("堮弰嘲", 9), null, this.dictionary_32[BookmarkStart.b("堮弰嘲", 9)]);
        this.class1092_0.method_6(BookmarkStart.b("圮尰弲嬴䐶", 9), BookmarkStart.b("丮", 9), null, this.dictionary_32[BookmarkStart.b("丮", 9)]);
        this.class1092_0.method_6(BookmarkStart.b("圮尰弲嬴䐶", 9), BookmarkStart.b("弮堰倲", 9), null, this.dictionary_32[BookmarkStart.b("弮堰倲", 9)]);
        this.class1092_0.method_6(BookmarkStart.b("圮尰弲嬴䐶", 9), BookmarkStart.b("堮䄰", 9), null, this.dictionary_32[BookmarkStart.b("堮䄰", 9)]);
        this.class1092_0.method_6(BookmarkStart.b("圮尰弲嬴䐶", 9), BookmarkStart.b("堮䄰䀲", 9), null, this.dictionary_32[BookmarkStart.b("堮䄰䀲", 9)]);
        this.paragraph_0 = null;
        if (A_0.Watermark.Type != WatermarkType.NoWatermark)
        {
            this.paragraph_0 = this.method_80(A_0, A_0.Type);
        }
        this.method_116(A_0.Items, true);
        this.class1092_0.method_12();
        this.class1092_0.method_15();
        if (A_0.Watermark.Type == WatermarkType.PictureWatermark)
        {
            Dictionary<string, Class517> dictionary;
            this.bool_0 = true;
            string key = string.Empty;
            foreach (HeaderFooterType type in this.dictionary_10.Keys)
            {
                Dictionary<string, HeaderFooter> dictionary2 = this.dictionary_10[type];
                foreach (string str2 in dictionary2.Keys)
                {
                    if (dictionary2[str2] == A_0)
                    {
                        key = str2;
                    }
                }
            }
            this.method_113((A_0.Watermark as PictureWatermark).WordPicture);
            if (this.method_45().ContainsKey(key))
            {
                dictionary = this.dictionary_7[key];
                dictionary.Add(this.string_3, (A_0.Watermark as PictureWatermark).WordPicture.ImageRecord);
            }
            else
            {
                dictionary = new Dictionary<string, Class517>();
                dictionary.Add(this.string_3, (A_0.Watermark as PictureWatermark).WordPicture.ImageRecord);
                this.method_45().Add(key, dictionary);
            }
        }
        if (this.paragraph_0 != null)
        {
            this.paragraph_0.ChildObjects.Remove(A_0.Watermark);
            this.paragraph_0 = null;
        }
        this.class771_0.method_14(A_2, stream, false, FileAttributes.Archive);
        this.method_84(A_1, A_3);
    }

    internal Dictionary<string, string> method_8()
    {
        if (this.dictionary_27 == null)
        {
            this.dictionary_27 = new Dictionary<string, string>();
        }
        return this.dictionary_27;
    }

    private Paragraph method_80(HeaderFooter A_0, HeaderFooterType A_1)
    {
        if (((A_1 != HeaderFooterType.HeaderEven) && (A_1 != HeaderFooterType.HeaderOdd)) && (A_1 != HeaderFooterType.HeaderFirstPage))
        {
            return null;
        }
        Paragraph entity = null;
        BodyRegionCollection items = A_0.Items;
        if (items.Count == 0)
        {
            entity = new Paragraph(items.Owner.Document);
            items.Insert(0, entity);
        }
        else
        {
            Paragraph paragraph2 = (A_0.Paragraphs.Count > 0) ? A_0.Paragraphs[0] : null;
            DocumentObject obj2 = ((paragraph2 == null) || (items[0] is StructureDocumentTag)) ? items[0] : paragraph2;
            if (obj2 is Table)
            {
                Table table = obj2 as Table;
                entity = this.method_82(table);
                if (entity == null)
                {
                    Section ownerBase = items.Owner.OwnerBase as Section;
                    entity = new Paragraph(ownerBase.Document);
                    ownerBase.HeadersFooters[(int) A_1].Items.Insert(0, entity);
                }
            }
            else if (obj2 is StructureDocumentTag)
            {
                StructureDocumentTag tag = obj2 as StructureDocumentTag;
                entity = this.method_81(tag);
                if (entity == null)
                {
                    Section section = items.Owner.OwnerBase as Section;
                    entity = new Paragraph(section.Document);
                    section.HeadersFooters[(int) A_1].Items.Insert(0, entity);
                }
            }
            else
            {
                entity = obj2 as Paragraph;
            }
        }
        entity.Items.Insert(0, A_0.Watermark);
        return entity;
    }

    private Paragraph method_81(StructureDocumentTag A_0)
    {
        if (A_0.ChildObjects.Count != 0)
        {
            if (A_0.ChildObjects[0] is Paragraph)
            {
                return (A_0.ChildObjects[0] as Paragraph);
            }
            if (A_0.ChildObjects[0] is Table)
            {
                return this.method_82(A_0.ChildObjects[0] as Table);
            }
        }
        return null;
    }

    private Paragraph method_82(Table A_0)
    {
        foreach (TableRow row in A_0.Rows)
        {
            foreach (TableCell cell in row.Cells)
            {
                foreach (BodyRegion region in cell.Items)
                {
                    if (region is Paragraph)
                    {
                        return (region as Paragraph);
                    }
                }
            }
        }
        if (A_0.Rows.Count > 0)
        {
            return A_0.Rows[0].Cells[0].AddParagraph();
        }
        return null;
    }

    private void method_83(HeaderFooter A_0, string A_1, string A_2, string A_3)
    {
        this.dictionary_32 = this.document_0.DocxNameSpace.method_0()[BookmarkStart.b("帵崷嬹堻嬽㈿⑁⭃⥅㱇⽉㹋", 0x10)];
        MemoryStream stream = new MemoryStream();
        this.class1092_0 = this.method_524(stream);
        this.class1092_0.method_11(BookmarkStart.b("䄵", 0x10), BookmarkStart.b("倵䰷䠹", 0x10), this.dictionary_32[BookmarkStart.b("䄵", 0x10)]);
        this.class1092_0.method_6(BookmarkStart.b("丵唷嘹刻䴽", 0x10), BookmarkStart.b("䀵", 0x10), null, this.dictionary_32[BookmarkStart.b("䀵", 0x10)]);
        this.class1092_0.method_6(BookmarkStart.b("丵唷嘹刻䴽", 0x10), BookmarkStart.b("䄵षਹ", 0x10), null, this.dictionary_32[BookmarkStart.b("䄵षਹ", 0x10)]);
        this.class1092_0.method_6(BookmarkStart.b("丵唷嘹刻䴽", 0x10), BookmarkStart.b("夵", 0x10), null, this.dictionary_32[BookmarkStart.b("夵", 0x10)]);
        this.class1092_0.method_6(BookmarkStart.b("丵唷嘹刻䴽", 0x10), BookmarkStart.b("䀵崷", 0x10), null, this.dictionary_32[BookmarkStart.b("䀵崷", 0x10)]);
        this.class1092_0.method_6(BookmarkStart.b("丵唷嘹刻䴽", 0x10), BookmarkStart.b("䐵", 0x10), null, this.dictionary_32[BookmarkStart.b("䐵", 0x10)]);
        this.class1092_0.method_6(BookmarkStart.b("丵唷嘹刻䴽", 0x10), BookmarkStart.b("嬵", 0x10), null, this.dictionary_32[BookmarkStart.b("嬵", 0x10)]);
        this.class1092_0.method_6(BookmarkStart.b("丵唷嘹刻䴽", 0x10), BookmarkStart.b("䄵嘷弹", 0x10), null, this.dictionary_32[BookmarkStart.b("䄵嘷弹", 0x10)]);
        this.class1092_0.method_6(BookmarkStart.b("丵唷嘹刻䴽", 0x10), BookmarkStart.b("圵", 0x10), null, this.dictionary_32[BookmarkStart.b("圵", 0x10)]);
        this.class1092_0.method_6(BookmarkStart.b("丵唷嘹刻䴽", 0x10), BookmarkStart.b("䘵儷夹", 0x10), null, this.dictionary_32[BookmarkStart.b("䘵儷夹", 0x10)]);
        this.class1092_0.method_6(BookmarkStart.b("丵唷嘹刻䴽", 0x10), BookmarkStart.b("䄵䠷", 0x10), null, this.dictionary_32[BookmarkStart.b("䄵䠷", 0x10)]);
        this.class1092_0.method_6(BookmarkStart.b("丵唷嘹刻䴽", 0x10), BookmarkStart.b("䄵䠷䤹", 0x10), null, this.dictionary_32[BookmarkStart.b("䄵䠷䤹", 0x10)]);
        this.class1092_0.method_6(BookmarkStart.b("丵唷嘹刻䴽", 0x10), BookmarkStart.b("嬵嬷", 0x10), null, this.dictionary_32[BookmarkStart.b("嬵嬷", 0x10)]);
        this.method_116(A_0.Items, true);
        this.class1092_0.method_12();
        this.class1092_0.method_15();
        this.class771_0.method_14(A_2, stream, false, FileAttributes.Archive);
        this.method_84(A_1, A_3);
    }

    private void method_84(string A_0, string A_1)
    {
        int num = 3;
        bool flag = this.method_45().ContainsKey(A_0);
        bool flag2 = this.method_13().ContainsKey(A_0);
        bool flag3 = this.method_5().ContainsKey(A_0);
        if (flag || flag2)
        {
            this.dictionary_32 = this.document_0.DocxNameSpace.method_0()[BookmarkStart.b("笨个䄬丮䔰娲娴夶䨸区吼伾㉀", num)];
            MemoryStream stream = new MemoryStream();
            this.class1092_0 = this.method_524(stream);
            this.class1092_0.method_10(BookmarkStart.b("笨个䄬丮䔰娲娴夶䨸区吼伾㉀", num), this.dictionary_32[BookmarkStart.b("儨䘪䄬䄮䈰", num)]);
            if (flag)
            {
                this.method_103(stream, this.method_45()[A_0]);
            }
            if (flag2)
            {
                this.method_102(stream, this.method_13()[A_0]);
            }
            if (flag3)
            {
                this.method_106(stream, this.method_5()[A_0]);
            }
            if (this.method_17().ContainsKey(A_0))
            {
                this.method_108(this.method_17()[A_0]);
            }
            if (this.method_4().ContainsKey(A_0))
            {
                this.method_85(stream, this.method_4()[A_0]);
            }
            this.class1092_0.method_12();
            this.class1092_0.method_15();
            this.class771_0.method_14(A_1, stream, false, FileAttributes.Archive);
        }
    }

    private void method_85(MemoryStream A_0, Dictionary<string, DictionaryEntry> A_1)
    {
        foreach (KeyValuePair<string, DictionaryEntry> pair in A_1)
        {
            string key = pair.Key;
            DictionaryEntry entry = pair.Value;
            string str2 = (string) entry.Key;
            string str3 = (string) entry.Value;
            this.method_512(A_0, key, str2, str3);
        }
    }

    private bool method_86(BodyRegion A_0)
    {
        bool flag = false;
        if (!(A_0 is Table) && !(A_0 is StructureDocumentTag))
        {
            Paragraph paragraph = A_0 as Paragraph;
            if ((paragraph.Items.Count > 0) && (paragraph.Items.Count <= 4))
            {
                Field field = paragraph.Items[0] as Field;
                FieldMark mark = paragraph.Items[paragraph.Items.Count - 1] as FieldMark;
                if (((field != null) && (mark != null)) && ((field.Type == FieldType.FieldPage) && (mark.Type == FieldMarkType.FieldEnd)))
                {
                    flag = true;
                }
            }
        }
        return flag;
    }

    private void method_87(Class1129 A_0)
    {
        this.method_90(A_0, BookmarkStart.b("帨䐪弬䬮Ḱ倲崴嘶䬸伺丼ှ", 3));
    }

    private void method_88(Class1129 A_0)
    {
        this.method_90(A_0, BookmarkStart.b("夭弯䀱倳ᤵ尷匹崻夽㈿⍁⥃㕅杇", 8));
    }

    private void method_89(Class1129 A_0)
    {
        this.method_90(A_0, BookmarkStart.b("帨䐪弬䬮Ḱ刲嘴䌶倸䴺堼朾湀", 3));
    }

    internal Dictionary<string, string> method_9()
    {
        if (this.dictionary_26 == null)
        {
            this.dictionary_26 = new Dictionary<string, string>();
        }
        return this.dictionary_26;
    }

    private void method_90(Class1129 A_0, string A_1)
    {
        int num = 5;
        if (A_0 != null)
        {
            Class1128 class2 = A_0.method_18(A_1);
            if (class2 != null)
            {
                this.method_95(class2, BookmarkStart.b("尪䈬崮唰ᰲ", num));
                if (class2.method_2().Count > 0)
                {
                    this.method_91(A_0, class2);
                }
            }
        }
    }

    private void method_91(Class1129 A_0, Class1128 A_1)
    {
        XmlReader reader = null;
        Dictionary<string, DictionaryEntry> dictionary = null;
        foreach (string str in A_1.method_2().Keys)
        {
            Class230 class2 = A_1.method_2()[str];
            if ((class2.method_4() != null) && (class2.method_4().Length > 0L))
            {
                class2.method_4().Position = 0L;
                reader = XmlReader.Create(class2.method_4());
                dictionary = new Dictionary<string, DictionaryEntry>();
                this.method_93(reader, dictionary);
                if (dictionary.Count > 0)
                {
                    this.method_92(A_0, dictionary);
                }
            }
        }
    }

    private void method_92(Class1129 A_0, Dictionary<string, DictionaryEntry> A_1)
    {
        int num = 9;
        Class229 class2 = null;
        foreach (DictionaryEntry entry in A_1.Values)
        {
            string key = (string) entry.Key;
            string str = (string) entry.Value;
            if (str.IndexOf(BookmarkStart.b("䤮堰弲倴", num)) == -1)
            {
                str = str.Replace(BookmarkStart.b("Įἰ", num), BookmarkStart.b("堮帰䄲儴", num));
                class2 = A_0.method_19(str);
                if ((class2 != null) && (this.class771_0.method_29(str) < 0))
                {
                    this.class771_0.method_14(str, class2.method_4() as MemoryStream, false, FileAttributes.Archive);
                }
                if (str.IndexOf(BookmarkStart.b("䬮䌰刲䈴帶圸尺", num)) != -1)
                {
                    this.bool_18 = true;
                    this.int_11++;
                }
            }
        }
    }

    private void method_93(XmlReader A_0, Dictionary<string, DictionaryEntry> A_1)
    {
        int num = 0x10;
        A_0.MoveToContent();
        if (A_0.LocalName != BookmarkStart.b("搵崷嘹崻䨽⤿ⵁ⩃㕅⁇⍉㱋㵍", 0x10))
        {
            A_0.ReadInnerXml();
        }
        else
        {
            string key = null;
            string attribute = null;
            string str = null;
            while (true)
            {
                A_0.Read();
                key = A_0.GetAttribute(BookmarkStart.b("缵尷", num));
                attribute = A_0.GetAttribute(BookmarkStart.b("戵夷䠹嬻嬽㐿", num));
                str = A_0.GetAttribute(BookmarkStart.b("戵䄷䨹夻", num));
                if ((key != null) && ((attribute != null) && (str != null)))
                {
                    DictionaryEntry entry = new DictionaryEntry(str, attribute);
                    A_1.Add(key, entry);
                }
                if (A_0.LocalName == BookmarkStart.b("搵崷嘹崻䨽⤿ⵁ⩃㕅⁇⍉㱋㵍", num))
                {
                    return;
                }
            }
        }
    }

    private void method_94(Class1129 A_0)
    {
        if (A_0 != null)
        {
            this.method_95(A_0, null);
        }
    }

    private void method_95(Class1128 A_0, string A_1)
    {
        int num = 1;
        A_1 = A_1 + A_0.method_3();
        foreach (Class229 class2 in A_0.method_0().Values)
        {
            string item = A_1 + class2.method_7();
            if (class2.method_7().StartsWith(BookmarkStart.b("䘦䨨弪䐬央吰欲", num)) && !this.method_2().Contains(item))
            {
                this.method_2().Add(item);
            }
            if ((this.class771_0.method_29(item) == -1) && (class2.method_4() != null))
            {
                this.class771_0.method_14(item, class2.method_4() as MemoryStream, false, FileAttributes.Archive);
            }
        }
        foreach (Class230 class4 in A_0.method_2().Values)
        {
            if (((this.class771_0.method_29(class4.method_7()) == -1) && (class4.method_4() != null)) && this.method_96(class4.method_7()))
            {
                this.class771_0.method_14(class4.method_7(), class4.method_4() as MemoryStream, false, FileAttributes.Archive);
            }
        }
        foreach (Class1128 class3 in A_0.method_1().Values)
        {
            if ((this.method_3().Count > 0) && (((class3.method_3() == BookmarkStart.b("倦䘨太䤬.", num)) || (class3.method_3() == BookmarkStart.b("䐦䄨䨪弬嬮䈰ᰲ", num))) || (class3.method_3() == BookmarkStart.b("䈦䐨䤪䠬䬮唰娲嬴倶䨸ᐺ", num))))
            {
                this.method_95(class3, A_1);
            }
        }
    }

    private bool method_96(string A_0)
    {
        if (A_0 == BookmarkStart.b("弧䔩師䨭Ἧ洱䘳匵吷䤹ጻ倽㔿⽁♃⍅㩇⍉≋⥍繏⩑㥓㩕癗⡙㥛㉝፟", 2))
        {
            return false;
        }
        return true;
    }

    private void method_97()
    {
        this.dictionary_32 = this.document_0.DocxNameSpace.method_0()[BookmarkStart.b("簭唯帱唳䈵儷唹刻䴽⠿⭁㑃㕅", 8)];
        MemoryStream stream = new MemoryStream();
        this.class1092_0 = this.method_524(stream);
        this.class1092_0.method_10(BookmarkStart.b("簭唯帱唳䈵儷唹刻䴽⠿⭁㑃㕅", 8), this.dictionary_32[BookmarkStart.b("嘭崯帱娳䔵", 8)]);
        this.method_103(stream, this.method_41());
        this.method_102(stream, this.method_12());
        this.method_107(stream, this.method_23());
        this.class1092_0.method_12();
        this.class1092_0.method_15();
        this.class771_0.method_14(BookmarkStart.b("夭弯䀱倳樵朷䠹夻刽㌿ṁ⅃⡅ⱇ⑉⍋㩍㕏⅑穓⹕㕗㙙牛ⱝ՟๡ᝣ", 8), stream, false, FileAttributes.Archive);
    }

    private void method_98()
    {
        this.dictionary_32 = this.document_0.DocxNameSpace.method_0()[BookmarkStart.b("縫䬭尯匱䀳張圷吹伻嘽⤿㉁㝃", 6)];
        MemoryStream stream = new MemoryStream();
        this.class1092_0 = this.method_524(stream);
        this.class1092_0.method_10(BookmarkStart.b("縫䬭尯匱䀳張圷吹伻嘽⤿㉁㝃", 6), this.dictionary_32[BookmarkStart.b("含䌭尯就䜳", 6)]);
        this.method_103(stream, this.method_40());
        this.method_102(stream, this.method_11());
        this.method_107(stream, this.method_22());
        this.class1092_0.method_12();
        this.class1092_0.method_15();
        this.class771_0.method_14(BookmarkStart.b("嬫䄭䈯嘱栳椵䨷弹倻䴽᰿⑁⭃⥅㱇⑉⍋㩍㕏⅑穓⹕㕗㙙牛ⱝ՟๡ᝣ", 6), stream, false, FileAttributes.Archive);
    }

    private void method_99()
    {
        this.dictionary_32 = this.document_0.DocxNameSpace.method_0()[BookmarkStart.b("琥䴧䘩䴫娭夯崱娳䔵倷匹䰻䴽", 0)];
        MemoryStream stream = new MemoryStream();
        this.class1092_0 = this.method_524(stream);
        this.class1092_0.method_10(BookmarkStart.b("琥䴧䘩䴫娭夯崱娳䔵倷匹䰻䴽", 0), this.dictionary_32[BookmarkStart.b("帥䔧䘩䈫崭", 0)]);
        this.method_103(stream, this.method_42());
        this.method_102(stream, this.method_9());
        this.method_107(stream, this.method_21());
        this.class1092_0.method_12();
        this.class1092_0.method_15();
        this.class771_0.method_14(BookmarkStart.b("儥䜧堩䠫爭漯䀱儳娵䬷昹弻儽ⴿ⽁⅃⡅㱇㥉手㙍㵏㹑穓⑕㵗㙙⽛", 0), stream, false, FileAttributes.Archive);
    }

    void IDisposable.Dispose()
    {
        if (this.class771_0 != null)
        {
            this.class771_0.method_28();
            this.class771_0.System.IDisposable.Dispose();
            this.class771_0 = null;
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
        if (this.list_0 != null)
        {
            this.list_0.Clear();
            this.list_0 = null;
        }
        if (this.list_1 != null)
        {
            this.list_1.Clear();
            this.list_1 = null;
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
        if (this.dictionary_8 != null)
        {
            this.dictionary_8.Clear();
            this.dictionary_8 = null;
        }
        if (this.list_2 != null)
        {
            this.list_2.Clear();
            this.list_2 = null;
        }
        if (this.list_3 != null)
        {
            this.list_3.Clear();
            this.list_3 = null;
        }
        if (this.dictionary_10 != null)
        {
            this.dictionary_10.Clear();
            this.dictionary_10 = null;
        }
        if (this.list_4 != null)
        {
            this.list_4.Clear();
            this.list_4 = null;
        }
        if (this.stack_0 != null)
        {
            this.stack_0.Clear();
            this.stack_0 = null;
        }
        if (this.dictionary_11 != null)
        {
            this.dictionary_11.Clear();
            this.dictionary_11 = null;
        }
        if (this.dictionary_12 != null)
        {
            this.dictionary_12.Clear();
            this.dictionary_12 = null;
        }
        if (this.dictionary_13 != null)
        {
            this.dictionary_13.Clear();
            this.dictionary_13 = null;
        }
        if (this.list_5 != null)
        {
            this.list_5.Clear();
            this.list_5 = null;
        }
        if (this.dictionary_14 != null)
        {
            this.dictionary_14.Clear();
            this.dictionary_14 = null;
        }
        if (this.dictionary_18 != null)
        {
            this.dictionary_18.Clear();
            this.dictionary_18 = null;
        }
        if (this.dictionary_19 != null)
        {
            this.dictionary_19.Clear();
            this.dictionary_19 = null;
        }
        if (this.dictionary_20 != null)
        {
            this.dictionary_20.Clear();
            this.dictionary_20 = null;
        }
        if (this.dictionary_21 != null)
        {
            this.dictionary_21.Clear();
            this.dictionary_21 = null;
        }
        if (this.dictionary_22 != null)
        {
            this.dictionary_22.Clear();
            this.dictionary_22 = null;
        }
        if (this.dictionary_23 != null)
        {
            this.dictionary_23.Clear();
            this.dictionary_23 = null;
        }
        if (this.dictionary_24 != null)
        {
            this.dictionary_24.Clear();
            this.dictionary_24 = null;
        }
        if (this.dictionary_25 != null)
        {
            this.dictionary_25.Clear();
            this.dictionary_25 = null;
        }
        if (this.dictionary_26 != null)
        {
            this.dictionary_26.Clear();
            this.dictionary_26 = null;
        }
        if (this.dictionary_27 != null)
        {
            this.dictionary_27.Clear();
            this.dictionary_27 = null;
        }
        if (this.dictionary_28 != null)
        {
            this.dictionary_28.Clear();
            this.dictionary_28 = null;
        }
        if (this.dictionary_29 != null)
        {
            this.dictionary_29.Clear();
            this.dictionary_29 = null;
        }
        if (this.dictionary_30 != null)
        {
            this.dictionary_30.Clear();
            this.dictionary_30 = null;
        }
        if (this.list_6 != null)
        {
            this.list_6.Clear();
            this.list_6 = null;
        }
        if (this.stack_1 != null)
        {
            this.stack_1.Clear();
            this.stack_1 = null;
        }
        if (this.string_4 != null)
        {
            this.string_4 = null;
        }
        if (this.dictionary_31 != null)
        {
            this.dictionary_31.Clear();
            this.dictionary_31 = null;
        }
        this.comment_0 = null;
        this.dictionary_33 = null;
        this.random_0 = null;
    }
}

