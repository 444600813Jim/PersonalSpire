using Spire.Doc;
using System;
using System.Collections.Generic;

internal class Class1128 : IDisposable
{
    protected Dictionary<string, Class229> dictionary_0;
    protected Dictionary<string, Class1128> dictionary_1;
    protected Dictionary<string, Class230> dictionary_2;
    protected string string_0;

    internal Dictionary<string, Class229> method_0()
    {
        if (this.dictionary_0 == null)
        {
            this.dictionary_0 = new Dictionary<string, Class229>(StringComparer.OrdinalIgnoreCase);
        }
        return this.dictionary_0;
    }

    internal Dictionary<string, Class1128> method_1()
    {
        if (this.dictionary_1 == null)
        {
            this.dictionary_1 = new Dictionary<string, Class1128>(StringComparer.OrdinalIgnoreCase);
        }
        return this.dictionary_1;
    }

    internal void method_10(Class229 A_0)
    {
        Class230 class2 = new Class230(A_0);
        this.method_2().Add(A_0.method_7(), class2);
    }

    private string method_11(string A_0)
    {
        int startIndex = A_0.LastIndexOf('/') + 1;
        int length = A_0.Length - startIndex;
        return A_0.Substring(startIndex, length);
    }

    internal Class229 method_12(string A_0)
    {
        if (this.method_0().ContainsKey(A_0))
        {
            return this.method_0()[A_0];
        }
        return null;
    }

    internal Class230 method_13(string A_0)
    {
        if (this.method_2().ContainsKey(A_0))
        {
            return this.method_2()[A_0];
        }
        return null;
    }

    internal Class1128 method_14(string A_0)
    {
        if (this.method_1().ContainsKey(A_0))
        {
            return this.method_1()[A_0];
        }
        return null;
    }

    internal Dictionary<string, Class230> method_15()
    {
        return this.method_16(this);
    }

    internal Dictionary<string, Class230> method_16(Class1128 A_0)
    {
        Dictionary<string, Class230> dictionary = new Dictionary<string, Class230>();
        Class1128 class2 = A_0;
        foreach (KeyValuePair<string, Class230> pair3 in class2.method_2())
        {
            dictionary.Add(pair3.Key, pair3.Value);
        }
        foreach (KeyValuePair<string, Class1128> pair2 in class2.method_1())
        {
            foreach (KeyValuePair<string, Class230> pair in pair2.Value.method_15())
            {
                dictionary.Add(pair.Key, pair.Value);
            }
        }
        return dictionary;
    }

    internal Class1128 method_17()
    {
        Class1128 class2 = new Class1128();
        class2.method_4(this.string_0);
        if ((this.dictionary_0 != null) && (this.dictionary_0.Count > 0))
        {
            foreach (string str2 in this.dictionary_0.Keys)
            {
                class2.method_0().Add(str2, this.dictionary_0[str2].method_9());
            }
        }
        if ((this.dictionary_2 != null) && (this.dictionary_2.Count > 0))
        {
            foreach (string str in this.dictionary_2.Keys)
            {
                class2.method_2().Add(str, this.dictionary_2[str].method_10() as Class230);
            }
        }
        if ((this.dictionary_1 != null) && (this.dictionary_1.Count > 0))
        {
            foreach (string str3 in this.dictionary_1.Keys)
            {
                class2.method_1().Add(str3, this.dictionary_1[str3].method_17());
            }
        }
        return class2;
    }

    internal Dictionary<string, Class230> method_2()
    {
        if (this.dictionary_2 == null)
        {
            this.dictionary_2 = new Dictionary<string, Class230>(StringComparer.OrdinalIgnoreCase);
        }
        return this.dictionary_2;
    }

    internal string method_3()
    {
        return this.string_0;
    }

    internal void method_4(string A_0)
    {
        this.string_0 = A_0;
    }

    internal void method_5(Class814 A_0)
    {
        Class229 class2 = new Class229(A_0.method_7());
        class2.method_8(this.method_11(A_0.method_0()));
        this.method_6(class2);
    }

    internal void method_6(Class229 A_0)
    {
        string[] strArray = A_0.method_7().Split(new char[] { '/' });
        string key = strArray[strArray.Length - 1];
        this.method_0().Add(key, A_0);
    }

    internal void method_7(Class1128 A_0)
    {
        this.method_1().Add(A_0.method_3(), A_0);
    }

    internal Class1128 method_8(string[] A_0, int A_1)
    {
        int num = 4;
        if (A_0.Length == 1)
        {
            return this;
        }
        string key = A_0[A_1] + BookmarkStart.b("ԩ", num);
        Class1128 class2 = null;
        if (this.method_1().ContainsKey(key))
        {
            class2 = this.method_1()[key];
        }
        if (class2 == null)
        {
            if (key.EndsWith(BookmarkStart.b("甩師䬭尯䄱ᬳ", num)))
            {
                return this;
            }
            class2 = new Class1128();
            class2.method_4(key);
            this.method_7(class2);
        }
        if (A_1 < (A_0.Length - 2))
        {
            return class2.method_8(A_0, ++A_1);
        }
        return class2;
    }

    internal void method_9(Class814 A_0)
    {
        Class230 class2 = new Class230(A_0);
        this.method_2().Add(A_0.method_0(), class2);
    }

    void IDisposable.Dispose()
    {
        if (this.dictionary_0 != null)
        {
            foreach (KeyValuePair<string, Class229> pair2 in this.dictionary_0)
            {
                if (pair2.Value != null)
                {
                    pair2.Value.System.IDisposable.Dispose();
                }
            }
            this.dictionary_0.Clear();
            this.dictionary_0 = null;
        }
        if (this.dictionary_2 != null)
        {
            foreach (KeyValuePair<string, Class230> pair3 in this.dictionary_2)
            {
                if (pair3.Value != null)
                {
                    pair3.Value.System.IDisposable.Dispose();
                }
            }
            this.dictionary_2.Clear();
            this.dictionary_2 = null;
        }
        if (this.dictionary_1 != null)
        {
            foreach (KeyValuePair<string, Class1128> pair in this.dictionary_1)
            {
                if (pair.Value != null)
                {
                    pair.Value.System.IDisposable.Dispose();
                }
            }
            this.dictionary_1.Clear();
            this.dictionary_1 = null;
        }
    }

    internal virtual List<Class229> vmethod_0(string A_0)
    {
        int num = 15;
        List<Class229> list = new List<Class229>();
        if ((this.dictionary_2 != null) && (this.dictionary_2.Count > 0))
        {
            foreach (KeyValuePair<string, Class230> pair2 in this.dictionary_2)
            {
                pair2.Value.method_8(BookmarkStart.b("ᨴ", num) + pair2.Value.method_7());
                pair2.Value.method_1(BookmarkStart.b("吴䜶䤸场吼尾⁀㝂ⱄ⡆❈摊㭌ⅎ㕐絒㩔❖㱘㕚╜㉞ൠբ੤ᕦѨ੪ᥬᱮ屰Ͳᑴᑶቸ᩺᩼᩾꾀ﾊﾐﶔﺖ뚜철쾢", num));
                list.Add(pair2.Value);
            }
        }
        if ((!string.IsNullOrEmpty(this.string_0) && (this.dictionary_0 != null)) && (this.dictionary_0.Count > 0))
        {
            string str2 = A_0 + this.string_0;
            foreach (KeyValuePair<string, Class229> pair in this.dictionary_0)
            {
                string str = pair.Key.ToLower();
                Class229 item = pair.Value;
                item.method_8(str2 + str);
                if (str.StartsWith(BookmarkStart.b("儴堶娸为值娾⽀㝂", num)))
                {
                    item.method_1(BookmarkStart.b("吴䜶䤸场吼尾⁀㝂ⱄ⡆❈摊㭌ⅎ㕐絒㩔❖㱘㕚╜㉞ൠբ੤ᕦѨ੪ᥬᱮ屰ᱲ፴ᅶၸ᡺᡼᭾歷ꆎﲒﲞ쒠킢횤캦잨첪사쎮龰ힲ\udab4\ud4b6첸횺\ud8bc\ud1be뗀꣄ꛆꃈꗊ럎볐뿒", num));
                }
                else if (str.StartsWith(BookmarkStart.b("䘴䌶䀸场堼䰾", num)))
                {
                    item.method_1(BookmarkStart.b("吴䜶䤸场吼尾⁀㝂ⱄ⡆❈摊㭌ⅎ㕐絒㩔❖㱘㕚╜㉞ൠբ੤ᕦѨ੪ᥬᱮ屰ᱲ፴ᅶၸ᡺᡼᭾歷ꆎﲒﲞ쒠킢횤캦잨첪사쎮龰삲솴캶햸\udeba\ucebc钾맀껂꧄", num));
                }
                else if (str.StartsWith(BookmarkStart.b("嬴䈶吸夺堼䴾⡀ⵂ≄", num)))
                {
                    item.method_1(BookmarkStart.b("吴䜶䤸场吼尾⁀㝂ⱄ⡆❈摊㭌ⅎ㕐絒㩔❖㱘㕚╜㉞ൠբ੤ᕦѨ੪ᥬᱮ屰ᱲ፴ᅶၸ᡺᡼᭾歷ꆎﲒﲞ쒠킢횤캦잨첪사쎮龰\uddb2\uc0b4\udab6\udbb8\udeba\ucfbc횾꿀꓂뿆꓈ꟊ", num));
                }
                else if (str.StartsWith(BookmarkStart.b("䘴制䴸伺吼儾♀あ", num)))
                {
                    item.method_1(BookmarkStart.b("吴䜶䤸场吼尾⁀㝂ⱄ⡆❈摊㭌ⅎ㕐絒㩔❖㱘㕚╜㉞ൠբ੤ᕦѨ੪ᥬᱮ屰ᱲ፴ᅶၸ᡺᡼᭾歷ꆎﲒﲞ쒠킢횤캦잨첪사쎮龰삲킴쎶춸튺펼\ud8be\ub2c0뷄꫆ꗈ", num));
                }
                else if (str.StartsWith(BookmarkStart.b("䈴制嬸䠺堼䬾㕀⩂⭄⁆㩈", num)))
                {
                    item.method_1(BookmarkStart.b("吴䜶䤸场吼尾⁀㝂ⱄ⡆❈摊㭌ⅎ㕐絒㩔❖㱘㕚╜㉞ൠբ੤ᕦѨ੪ᥬᱮ屰ᱲ፴ᅶၸ᡺᡼᭾歷ꆎﲒﲞ쒠킢횤캦잨첪사쎮龰쒲킴햶\udeba\uc9bc쮾ꣀ귂ꋄ듆돊ꃌꏎ", num));
                }
                else if (str.StartsWith(BookmarkStart.b("嘴堶吸嘺堼儾㕀", num)))
                {
                    item.method_1(BookmarkStart.b("吴䜶䤸场吼尾⁀㝂ⱄ⡆❈摊㭌ⅎ㕐絒㩔❖㱘㕚╜㉞ൠբ੤ᕦѨ੪ᥬᱮ屰ᱲ፴ᅶၸ᡺᡼᭾歷ꆎﲒﲞ쒠킢횤캦잨첪사쎮龰킲\udab4\udab6풸\udeba\ud3bc쮾닀뷄꫆ꗈ", num));
                }
                else if (str.StartsWith(BookmarkStart.b("崴制堸强堼䴾", num)))
                {
                    item.method_1(BookmarkStart.b("吴䜶䤸场吼尾⁀㝂ⱄ⡆❈摊㭌ⅎ㕐絒㩔❖㱘㕚╜㉞ൠբ੤ᕦѨ੪ᥬᱮ屰ᱲ፴ᅶၸ᡺᡼᭾歷ꆎﲒﲞ쒠킢횤캦잨첪사쎮龰\udbb2\ud0b4횶\uddb8\udeba쾼钾맀껂꧄", num));
                }
                else if (str.StartsWith(BookmarkStart.b("匴堶嘸伺堼䴾", num)))
                {
                    item.method_1(BookmarkStart.b("吴䜶䤸场吼尾⁀㝂ⱄ⡆❈摊㭌ⅎ㕐絒㩔❖㱘㕚╜㉞ൠբ੤ᕦѨ੪ᥬᱮ屰ᱲ፴ᅶၸ᡺᡼᭾歷ꆎﲒﲞ쒠킢횤캦잨첪사쎮龰햲\udab4\ud8b6춸\udeba\ucfbc钾맀껂꧄", num));
                }
                else if (str.StartsWith(BookmarkStart.b("倴夶崸唺刼䬾⑀", num)))
                {
                    item.method_1(BookmarkStart.b("吴䜶䤸场吼尾⁀㝂ⱄ⡆❈摊㭌ⅎ㕐絒㩔❖㱘㕚╜㉞ൠբ੤ᕦѨ੪ᥬᱮ屰ᱲ፴ᅶၸ᡺᡼᭾歷ꆎﲒﲞ쒠킢횤캦잨첪사쎮龰횲\udbb4\ud3b6ힸ풺즼\udabe\ub2c0뷄꫆ꗈ", num));
                }
                else if (str.StartsWith(BookmarkStart.b("匴堶嘸伺匼倾㕀♂", num)))
                {
                    item.method_1(BookmarkStart.b("吴䜶䤸场吼尾⁀㝂ⱄ⡆❈摊㭌ⅎ㕐絒㩔❖㱘㕚╜㉞ൠբ੤ᕦѨ੪ᥬᱮ屰ᱲ፴ᅶၸ᡺᡼᭾歷ꆎﲒﲞ쒠킢횤캦잨첪사쎮龰햲\udab4\ud8b6춸햺튼쮾꓀냂뿆꓈ꟊ", num));
                }
                else if (str.StartsWith(BookmarkStart.b("匴堶圸伺䤼帾⍀⽂⁄", num)))
                {
                    item.method_1(BookmarkStart.b("吴䜶䤸场吼尾⁀㝂ⱄ⡆❈摊㭌ⅎ㕐絒㩔❖㱘㕚╜㉞ൠբ੤ᕦѨ੪ᥬᱮ屰ᱲ፴ᅶၸ᡺᡼᭾歷ꆎﲒﲞ쒠킢횤캦잨첪사쎮龰햲\udab4\ud9b6춸\udcbc\uddbe귀ꛂ뿆꓈ꟊ", num));
                }
                else if (str.StartsWith(BookmarkStart.b("匴堶圸伺", num)))
                {
                    item.method_1(BookmarkStart.b("吴䜶䤸场吼尾⁀㝂ⱄ⡆❈摊㭌ⅎ㕐絒㩔❖㱘㕚╜㉞ൠբ੤ᕦѨ੪ᥬᱮ屰ᱲ፴ᅶၸ᡺᡼᭾歷ꆎﺐﲜ쒠잢좦잨\udfaa", num));
                }
                else if (str.StartsWith(BookmarkStart.b("䄴弶尸嘺堼", num)))
                {
                    item.method_1(BookmarkStart.b("吴䜶䤸场吼尾⁀㝂ⱄ⡆❈摊㭌ⅎ㕐絒㩔❖㱘㕚╜㉞ൠբ੤ᕦѨ੪ᥬᱮ屰ᱲ፴ᅶၸ᡺᡼᭾歷ꆎﮒ殺ﲘ낚춠", num));
                }
                else if (str.StartsWith(BookmarkStart.b("匴堶圸伺䤼帾⍀⽂⁄", num)))
                {
                    item.method_1(BookmarkStart.b("吴䜶䤸场吼尾⁀㝂ⱄ⡆❈摊㭌ⅎ㕐絒㩔❖㱘㕚╜㉞ൠբ੤ᕦѨ੪ᥬᱮ屰ᱲ፴ᅶၸ᡺᡼᭾歷ꆎﲒﲞ쒠킢횤캦잨첪사쎮龰햲\udab4\ud9b6춸\udcbc\uddbe귀ꛂ뿆꓈ꟊ", num));
                }
                else if (str.StartsWith(BookmarkStart.b("嘴䈶䨸伺刼刾", num)))
                {
                    item.method_1(BookmarkStart.b("吴䜶䤸场吼尾⁀㝂ⱄ⡆❈摊㭌ⅎ㕐絒㩔❖㱘㕚╜㉞ൠբ੤ᕦѨ੪ᥬᱮ屰ᱲ፴ᅶၸ᡺᡼᭾歷ꆎ난펠첢햤슦\udba8\udfaa쒬쪮슰颲춴\udab6\ud5b8", num));
                }
                else if (str.StartsWith(BookmarkStart.b("嘴堶䬸帺", num)))
                {
                    item.method_1(BookmarkStart.b("吴䜶䤸场吼尾⁀㝂ⱄ⡆❈摊㭌ⅎ㕐絒㩔❖㱘㕚╜㉞ൠբ੤ᕦѨ੪ᥬᱮ屰Ͳᑴᑶቸ᩺᩼᩾꾀Ꚋﶌﶎﺐ誠\udba2\uc8a4쮦", num));
                }
                else if (str.StartsWith(BookmarkStart.b("吴䜶䤸", num)))
                {
                    item.method_1(BookmarkStart.b("吴䜶䤸场吼尾⁀㝂ⱄ⡆❈摊㭌ⅎ㕐絒㩔❖㱘㕚╜㉞ൠբ੤ᕦѨ੪ᥬᱮ屰ᱲ፴ᅶၸ᡺᡼᭾歷ꆎﾚﮞ負펢힤좦\ud9a8\uceaa\udfac\udbae\ud8b0\ud6b2운鲶솸횺톼", num));
                }
                else if (str.StartsWith(BookmarkStart.b("尴䌶尸嘺", num)))
                {
                    item.method_1(BookmarkStart.b("吴䜶䤸场吼尾⁀㝂ⱄ⡆❈摊㕌≎㵐", num));
                }
                else if (str.StartsWith(BookmarkStart.b("尴䌶尸嘺䴼䴾⹀㍂㙄", num)))
                {
                    item.method_1(BookmarkStart.b("吴䜶䤸场吼尾⁀㝂ⱄ⡆❈摊㭌ⅎ㕐絒㩔❖㱘㕚╜㉞ൠբ੤ᕦѨ੪ᥬᱮ屰ᱲ፴ᅶၸ᡺᡼᭾歷ꆎ얜춠힤좦\ud9a8\uceaa\udfac\udbae\ud8b0\ud6b2운鲶솸횺톼", num));
                }
                else if (str.StartsWith(BookmarkStart.b("嘴弶堸䤺䤼", num)))
                {
                    item.method_1(BookmarkStart.b("吴䜶䤸场吼尾⁀㝂ⱄ⡆❈摊㭌ⅎ㕐絒㩔❖㱘㕚╜㉞ൠբ੤ᕦѨ੪ᥬᱮ屰ᱲ፴ᅶၸ᡺᡼᭾歷ꆎ煮춠趢욤쾦좨\ud9aa\ud9ac蒮즰\udeb2\ud9b4", num));
                }
                else if (str.StartsWith(BookmarkStart.b("儴嘶䴸娺", num)))
                {
                    item.method_1(BookmarkStart.b("吴䜶䤸场吼尾⁀㝂ⱄ⡆❈摊㭌ⅎ㕐絒㩔❖㱘㕚╜㉞ൠբ੤ᕦѨ੪ᥬᱮ屰ᱲ፴ᅶၸ᡺᡼᭾歷ꆎ煮춠趢솤캦좨첪\udfac\uceae\udcb0\uf7b2풴쎶\ud8b8\u90ba얼튾귀", num));
                }
                else if (str.StartsWith(BookmarkStart.b("嘴堶唸吺似", num)))
                {
                    item.method_1(BookmarkStart.b("吴䜶䤸场吼尾⁀㝂ⱄ⡆❈摊㭌ⅎ㕐絒㩔❖㱘㕚╜㉞ൠբ੤ᕦѨ੪ᥬᱮ屰ᱲ፴ᅶၸ᡺᡼᭾歷ꆎ煮춠趢솤캦좨첪\udfac\uceae\udcb0\uf0b2\udab4\udbb6횸즺캼钾맀껂꧄", num));
                }
                else if (str.StartsWith(BookmarkStart.b("䐴䈶倸堺嘼䰾㕀㩂⥄≆", num)))
                {
                    item.method_1(BookmarkStart.b("吴䜶䤸场吼尾⁀㝂ⱄ⡆❈摊㭌ⅎ㕐絒㩔❖㱘㕚╜㉞ൠբ੤ᕦѨ੪ᥬᱮ屰ᱲ፴ᅶၸ᡺᡼᭾歷ꆎ煮춠趢솤캦좨첪\udfac\uceae\udcb0\ue0b2솴캶햸\udeba\u96bc잾곀꿂", num));
                }
                else if (str.StartsWith(BookmarkStart.b("头嘶䀸吺䠼䬾", num)))
                {
                    item.method_1(BookmarkStart.b("吴䜶䤸场吼尾⁀㝂ⱄ⡆❈摊㭌ⅎ㕐絒㩔❖㱘㕚╜㉞ൠբ੤ᕦѨ੪ᥬᱮ屰ᱲ፴ᅶၸ᡺᡼᭾歷ꆎ煮춠趢솤캦좨첪\udfac\uceae\udcb0\uffb2풴캶횸캺즼钾맀껂꧄", num));
                }
                else if (!str.EndsWith(BookmarkStart.b("᬴崶䤸帺娼", num)) && !str.EndsWith(BookmarkStart.b("᬴崶䤸尺", num)))
                {
                    if (!str.EndsWith(BookmarkStart.b("᬴制吸崺", num)) && !str.EndsWith(BookmarkStart.b("᬴䀶吸崺", num)))
                    {
                        if (str.EndsWith(BookmarkStart.b("᬴倶倸崺", num)))
                        {
                            item.method_1(BookmarkStart.b("尴娶堸尺堼ှ♀⩂⍄", num));
                        }
                        else if (str.EndsWith(BookmarkStart.b("᬴䜶圸尺", num)))
                        {
                            item.method_1(BookmarkStart.b("尴娶堸尺堼ှ潀㍂⭄⁆", num));
                        }
                        else
                        {
                            item.method_1(BookmarkStart.b("吴䜶䤸场吼尾⁀㝂ⱄ⡆❈摊㕌≎㵐", num));
                        }
                    }
                    else
                    {
                        item.method_1(BookmarkStart.b("尴娶堸尺堼ှ㥀湂㉄⩆⽈", num));
                    }
                }
                else
                {
                    item.method_1(BookmarkStart.b("尴娶堸尺堼ှ⭀㍂⁄⁆", num));
                }
                list.Add(item);
            }
        }
        if ((this.dictionary_1 != null) && (this.dictionary_1.Count > 0))
        {
            foreach (KeyValuePair<string, Class1128> pair3 in this.dictionary_1)
            {
                Class1128 class3 = pair3.Value;
                string str3 = !string.IsNullOrEmpty(this.string_0) ? (A_0 + this.string_0) : A_0;
                list.AddRange(class3.vmethod_0(str3));
            }
        }
        return list;
    }
}

