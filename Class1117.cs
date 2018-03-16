using Spire.Doc;
using Spire.Doc.Documents;
using System;

internal class Class1117
{
    internal static OleObjectType smethod_0(string A_0)
    {
        int num = 14;
        OleObjectType undefined = OleObjectType.Undefined;
        if (!A_0.StartsWith(BookmarkStart.b("申唵䨷唹帻弽㐿扁C⥅⭇㽉⅋⭍㹏♑", 14)) && !A_0.StartsWith(BookmarkStart.b("申唵䨷唹礻䘽⌿⩁橃Ʌ❇⥉㥋⍍㕏㱑⁓", num)))
        {
            if (A_0.StartsWith(BookmarkStart.b("搳圵嬷儹崻夽┿", num)))
            {
                return OleObjectType.Package;
            }
            if (A_0.StartsWith(BookmarkStart.b("搳琵䨷伹伻嘽", num)))
            {
                return OleObjectType.BitmapImage;
            }
            if (A_0.StartsWith(BookmarkStart.b("礳匵尷匹崻ḽ̿⹁ⵃ㙅", num)) || A_0.StartsWith(BookmarkStart.b("礳昵吷嬹䔻嬽㈿", num)))
            {
                return OleObjectType.MediaClip;
            }
            if ((A_0.StartsWith(BookmarkStart.b("礳張嬷䠹医䴽⼿⑁ぃ晅േ㭉㥋⽍⑏㭑㭓㡕硗楙牛湝", num)) || A_0.StartsWith(BookmarkStart.b("焳䜵䴷嬹䠻圽⼿ⱁ橃畅", num))) || A_0.StartsWith(BookmarkStart.b("焳䜵䴷嬹䠻圽⼿ⱁ橃൅ᭇཉो絍", num)))
            {
                return OleObjectType.Equation;
            }
            if (A_0.StartsWith(BookmarkStart.b("礳張嬷䠹医䴽⼿⑁ぃ晅ཇ㡉ⵋ㹍㡏牑ᝓ㹕㥗⡙⡛", num)) || A_0.StartsWith(BookmarkStart.b("礳攵缷䠹崻丽⠿汁݃⹅⥇㡉㡋恍桏", num)))
            {
                return OleObjectType.GraphChart;
            }
            if (A_0.StartsWith(BookmarkStart.b("礳張嬷䠹医䴽⼿⑁ぃ晅݇ⱉ⩋❍㍏㝑瑓ፕ⁗㥙㥛㉝䁟偡呣噥孧䩩㭫ŭɯᥱݳṵᵷόࡻ", num)) || A_0.StartsWith(BookmarkStart.b("焳丵嬷弹倻ွጿ⩁⅃⍅㱇摉瑋", num)))
            {
                return OleObjectType.Excel_97_2003_Worksheet;
            }
            if (A_0.StartsWith(BookmarkStart.b("礳張嬷䠹医䴽⼿⑁ぃ晅݇ⱉ⩋❍㍏㝑瑓ፕ⁗㥙㥛㉝䁟⁡ൣࡥ१ᡩᕫ乭❯ᵱٳᵵ୷ቹ᥻᭽", num)) || A_0.StartsWith(BookmarkStart.b("焳丵嬷弹倻ွጿ⩁⅃⍅㱇ࡉ╋⁍ㅏ⁑ⵓ᭕㥗㥙⹛ㅝ╟ౡգѥѧཀྵ࡫䁭䅯䁱", num)))
            {
                return OleObjectType.ExcelBinaryWorksheet;
            }
            if (A_0.StartsWith(BookmarkStart.b("礳張嬷䠹医䴽⼿⑁ぃ晅݇ⱉ⩋❍㍏㝑瑓ፕ⁗㥙㥛㉝䁟Ⅱౣݥᩧṩ", num)) || A_0.StartsWith(BookmarkStart.b("焳丵嬷弹倻ွ̿⩁╃㑅㱇摉瑋", num)))
            {
                return OleObjectType.ExcelChart;
            }
            if (A_0.StartsWith(BookmarkStart.b("礳張嬷䠹医䴽⼿⑁ぃ晅݇ⱉ⩋❍㍏㝑瑓ፕ⁗㥙㥛㉝䁟㕡ୣᑥͧᥩѫ୭ᕯٱ味幵᭷ᕹ᡻᭽꥿", num)) || A_0.StartsWith(BookmarkStart.b("焳丵嬷弹倻ွጿ⩁⅃⍅㱇݉ⵋⵍ≏㵑ᅓ㡕㥗㡙せ㭝џ䱡啣呥", num)))
            {
                return OleObjectType.ExcelMacroWorksheet;
            }
            if (A_0.StartsWith(BookmarkStart.b("礳張嬷䠹医䴽⼿⑁ぃ晅݇ⱉ⩋❍㍏㝑瑓ፕ⁗㥙㥛㉝䁟㕡ୣᑥͧᥩѫ୭ᕯٱ", num)) || A_0.StartsWith(BookmarkStart.b("焳丵嬷弹倻ွጿ⩁⅃⍅㱇摉絋籍", num)))
            {
                return OleObjectType.ExcelWorksheet;
            }
            if (A_0.StartsWith(BookmarkStart.b("礳張嬷䠹医䴽⼿⑁ぃ晅݇ⱉ⩋❍㍏㝑瑓ٕ㝗ⵙ㥛ⱝたൡൣࡥᱧ䩩啫奭嵯䁱䑳䙵䭷婹ⱻ౽ﲇﾏﲑ", num)) || A_0.StartsWith(BookmarkStart.b("搳夵伷弹主渽⼿⭁⩃㉅晇᥉⑋⅍❏籑汓", num)))
            {
                return OleObjectType.PowerPoint_97_2003_Presentation;
            }
            if (A_0.StartsWith(BookmarkStart.b("礳張嬷䠹医䴽⼿⑁ぃ晅݇ⱉ⩋❍㍏㝑瑓ٕ㝗ⵙ㥛ⱝたൡൣࡥᱧ䩩啫奭嵯䁱䑳䙵䭷婹⽻ች", num)) || A_0.StartsWith(BookmarkStart.b("搳夵伷弹主渽⼿⭁⩃㉅晇᥉⁋❍㑏㝑穓湕", num)))
            {
                return OleObjectType.PowerPoint_97_2003_Slide;
            }
            if (A_0.StartsWith(BookmarkStart.b("礳張嬷䠹医䴽⼿⑁ぃ晅݇ⱉ⩋❍㍏㝑瑓ٕ㝗ⵙ㥛ⱝたൡൣࡥᱧ䩩Ⅻ཭፯q᭳孵㵷ᑹᵻᱽꚅ\ud887\uf889ﶍﲑ", num)) || A_0.StartsWith(BookmarkStart.b("搳夵伷弹主渽⼿⭁⩃㉅晇᥉⑋⅍❏ὑ㕓㕕⩗㕙ᥛそşaࡣͥ౧䑩嵫屭", num)))
            {
                return OleObjectType.PowerPointMacroPresentation;
            }
            if (A_0.StartsWith(BookmarkStart.b("礳張嬷䠹医䴽⼿⑁ぃ晅݇ⱉ⩋❍㍏㝑瑓ٕ㝗ⵙ㥛ⱝたൡൣࡥᱧ䩩Ⅻ཭፯q᭳孵㵷ᑹᵻᱽꚅ\udb87\ue689", num)) || A_0.StartsWith(BookmarkStart.b("搳夵伷弹主渽⼿⭁⩃㉅晇᥉⁋❍㑏㝑ᥓ㝕㭗⡙㍛᭝๟͡٣੥൧๩䉫彭䉯", num)))
            {
                return OleObjectType.PowerPointMacroSlide;
            }
            if (A_0.StartsWith(BookmarkStart.b("礳張嬷䠹医䴽⼿⑁ぃ晅݇ⱉ⩋❍㍏㝑瑓ٕ㝗ⵙ㥛ⱝたൡൣࡥᱧ䩩㱫ᱭᕯűᅳᡵ౷᭹ࡻ᝽", num)) || A_0.StartsWith(BookmarkStart.b("搳夵伷弹主渽⼿⭁⩃㉅晇᥉⑋⅍❏籑敓摕", num)))
            {
                return OleObjectType.PowerPointPresentation;
            }
            if (A_0.StartsWith(BookmarkStart.b("礳張嬷䠹医䴽⼿⑁ぃ晅݇ⱉ⩋❍㍏㝑瑓ٕ㝗ⵙ㥛ⱝたൡൣࡥᱧ䩩㽫ɭ᥯ᙱᅳ", num)) || A_0.StartsWith(BookmarkStart.b("搳夵伷弹主渽⼿⭁⩃㉅晇᥉⁋❍㑏㝑穓杕橗", num)))
            {
                return OleObjectType.PowerPointSlide;
            }
            if (A_0.StartsWith(BookmarkStart.b("礳張嬷䠹医䴽⼿⑁ぃ晅݇ⱉ⩋❍㍏㝑瑓ŕ㝗⡙㡛繝奟啡䥣呥塧婩彫乭㑯ᵱᝳ͵ᕷόቻ੽", num)) || A_0.StartsWith(BookmarkStart.b("挳夵䨷帹ሻ稽⼿⅁ㅃ⭅ⵇ⑉㡋恍桏", num)))
            {
                return OleObjectType.Word_97_2003_Document;
            }
            if ((A_0.StartsWith(BookmarkStart.b("礳張嬷䠹医䴽⼿⑁ぃ晅݇ⱉ⩋❍㍏㝑瑓ŕ㝗⡙㡛繝⑟ൡݣ፥էཀྵɫᩭ", num)) || A_0.StartsWith(BookmarkStart.b("挳夵䨷帹ሻ稽⼿⅁ㅃ⭅ⵇ⑉㡋恍慏恑", num))) || A_0.StartsWith(BookmarkStart.b("礳張嬷䠹医䴽⼿⑁ぃ晅὇╉㹋⩍", num)))
            {
                return OleObjectType.WordDocument;
            }
            if (A_0.StartsWith(BookmarkStart.b("礳張嬷䠹医䴽⼿⑁ぃ晅݇ⱉ⩋❍㍏㝑瑓ŕ㝗⡙㡛繝ⵟ͡ݣᑥݧ䝩⥫mᅯၱᡳ፵ᱷ婹㡻ᅽﺉ", num)) || A_0.StartsWith(BookmarkStart.b("挳夵䨷帹ሻ稽⼿⅁ㅃ⭅ⵇ⑉㡋͍ㅏㅑ♓㥕ᵗ㑙㵛㱝౟ݡc䡥奧塩", num)))
            {
                return OleObjectType.WordMacroDocument;
            }
            if (A_0.StartsWith(BookmarkStart.b("礳張嬷䠹医䴽⼿⑁ぃ晅ṇ⍉㽋❍㽏牑ၓ⑕㥗ⵙ㕛そݟ", num)) || A_0.StartsWith(BookmarkStart.b("戳張䬷匹医ွпぁ╃ㅅⅇ⑉⭋恍慏捑", num)))
            {
                return OleObjectType.VisioDrawing;
            }
            if (A_0.StartsWith(BookmarkStart.b("戳張䬷匹医ွпぁ╃ㅅⅇ⑉⭋恍慏村", num)))
            {
                return OleObjectType.VisioDrawing_2013;
            }
            if (A_0.StartsWith(BookmarkStart.b("笳䘵崷吹砻儽⌿㝁⥃⍅♇㹉汋ṍ≏㝑❓㍕㙗⹙㵛⩝य़ൡ੣", num)) || A_0.StartsWith(BookmarkStart.b("搳夵伷弹主渽⼿⭁⩃㉅晇Չ㱋⭍㹏ᙑ㭓㕕ⵗ㝙㥛そᑟ㉡ᙣͥ᭧ཀྵɫᩭᅯٱᵳ᥵ᙷ呹䵻䱽", num)))
            {
                return OleObjectType.OpenDocumentPresentation;
            }
            if (A_0.StartsWith(BookmarkStart.b("笳䘵崷吹砻儽⌿㝁⥃⍅♇㹉汋ᵍ⁏⁑ㅓ㝕㱗⥙㑛㭝՟ᙡ", num)) || A_0.StartsWith(BookmarkStart.b("焳丵嬷弹倻ွ༿㉁⅃⡅ే╉⽋㭍㵏㝑㩓≕ୗ⩙⹛㭝ş١ᝣ๥൧ཀྵᡫ䁭䅯䁱", num)))
            {
                return OleObjectType.OpenDocumentSpreadsheet;
            }
            if (A_0.StartsWith(BookmarkStart.b("嬳䘵崷吹堻儽⌿㝁⥃⍅♇㹉手്ㅏ㹑㝓ቕ㝗㥙⥛㍝՟ౡၣ䡥奧", num)))
            {
                return OleObjectType.OpenOfficeSpreadsheet;
            }
            if (A_0.StartsWith(BookmarkStart.b("嬳䘵崷吹堻儽⌿㝁⥃⍅♇㹉手᥍≏㭑⁓㍕⩗ṙ㍛㵝ᕟཡţࡥᱧ䑩嵫", num)))
            {
                return OleObjectType.OpenOfficeText;
            }
            if (A_0.StartsWith(BookmarkStart.b("䜳夵帷尹唻崽┿汁ᝃ㉅⥇㡉ཋ⽍㱏ㅑၓ㥕㭗⽙ㅛ㭝๟ᙡ䩣健", num)))
            {
                return OleObjectType.OpenOfficeSpreadsheet1_1;
            }
            if (A_0.StartsWith(BookmarkStart.b("䜳夵帷尹唻崽┿汁ᝃ㉅⥇㡉ᭋ㱍㥏♑ㅓ⑕᱗㕙㽛⭝ൟݡ੣ብ䙧屩", num)))
            {
                return OleObjectType.OpenOfficeText_1_1;
            }
            if (A_0.StartsWith(BookmarkStart.b("戳張尷弹医ḽ̿⹁ⵃ㙅", num)) || A_0.StartsWith(BookmarkStart.b("申怵焷簹唻刽┿", num)))
            {
                return OleObjectType.VideoClip;
            }
            if (!A_0.StartsWith(BookmarkStart.b("挳圵丷弹漻儽㔿ⱁ⁃", num)) && !A_0.StartsWith(BookmarkStart.b("朳夵䴷吹堻氽┿⅁", num)))
            {
                if (!A_0.StartsWith(BookmarkStart.b("挳夵䨷帹氻弽␿扁C⥅⭇㽉⅋⭍㹏♑", num)) && !A_0.StartsWith(BookmarkStart.b("挳夵䨷帹氻弽␿汁C⥅⭇㽉⅋⭍㹏♑穓杕", num)))
                {
                    if (A_0.StartsWith(BookmarkStart.b("挳夵䨷帹ሻ渽⤿⅁ぃ㍅㩇⽉手癍", num)))
                    {
                        undefined = OleObjectType.WordPicture;
                    }
                    return undefined;
                }
                return OleObjectType.WordPadDocument;
            }
            return OleObjectType.WaveSound;
        }
        return OleObjectType.AdobeAcrobatDocument;
    }

    internal static string smethod_1(OleObjectType A_0, bool A_1)
    {
        int num = 0x10;
        string str = string.Empty;
        switch (A_0)
        {
            case OleObjectType.AdobeAcrobatDocument:
                return (A_1 ? BookmarkStart.b("眵嬷䠹医尽ℿ㙁摃Ʌ❇⥉㥋⍍㕏㱑⁓", num) : BookmarkStart.b("眵嬷䠹医笽㠿⅁ⱃ桅ే╉⽋㭍㵏㝑㩓≕癗浙", num));

            case OleObjectType.BitmapImage:
                return BookmarkStart.b("昵稷䠹䤻䴽⠿", num);

            case OleObjectType.MediaClip:
                return (A_1 ? BookmarkStart.b("笵崷帹唻弽怿Ł⡃⽅㡇", num) : BookmarkStart.b("笵样嘹崻䜽┿ぁ", num));

            case OleObjectType.Equation:
                return (A_1 ? BookmarkStart.b("笵儷夹主儽㌿ⵁ≃㉅桇ཉ㵋㭍ㅏ♑㵓㥕㙗穙潛灝偟", num) : BookmarkStart.b("猵䤷伹崻䨽⤿ⵁ⩃桅筇", num));

            case OleObjectType.GraphChart:
                return (A_1 ? BookmarkStart.b("笵儷夹主儽㌿ⵁ≃㉅桇൉㹋⽍⁏㩑瑓ᕕし㭙⹛⩝", num) : BookmarkStart.b("笵欷紹主弽〿⩁橃Յ⁇⭉㹋㩍繏橑", num));

            case OleObjectType.Excel_97_2003_Worksheet:
                return (A_1 ? BookmarkStart.b("笵儷夹主儽㌿ⵁ≃㉅桇Չ⩋⡍㥏ㅑㅓ癕ᵗ≙㽛㭝౟䉡噣噥塧奩䱫㥭Ὧqέյၷό᥻੽", num) : BookmarkStart.b("猵䀷夹夻刽渿ᅁⱃ⍅ⵇ㹉手癍", num));

            case OleObjectType.ExcelBinaryWorksheet:
                return (A_1 ? BookmarkStart.b("笵儷夹主儽㌿ⵁ≃㉅桇Չ⩋⡍㥏ㅑㅓ癕ᵗ≙㽛㭝౟䉡♣ཥ٧୩ṫ᝭偯╱᭳ѵ፷ॹᑻ᭽", num) : BookmarkStart.b("猵䀷夹夻刽渿ᅁⱃ⍅ⵇ㹉๋❍㹏㍑♓⽕ᕗ㭙㽛ⱝཟ❡੣ݥ੧٩५੭幯䍱䙳", num));

            case OleObjectType.ExcelChart:
                return (A_1 ? BookmarkStart.b("笵儷夹主儽㌿ⵁ≃㉅桇Չ⩋⡍㥏ㅑㅓ癕ᵗ≙㽛㭝౟䉡❣๥१ᡩᡫ", num) : BookmarkStart.b("猵䀷夹夻刽渿Łⱃ❅㩇㹉手癍", num));

            case OleObjectType.ExcelMacroWorksheet:
                return (A_1 ? BookmarkStart.b("笵儷夹主儽㌿ⵁ≃㉅桇Չ⩋⡍㥏ㅑㅓ癕ᵗ≙㽛㭝౟䉡㍣॥ᩧũὫ٭ᕯ᝱s噵偷᥹፻᩽ꮁ", num) : BookmarkStart.b("猵䀷夹夻刽渿ᅁⱃ⍅ⵇ㹉ŋ⽍㍏⁑㭓ፕ㙗㭙㹛㉝՟١䩣坥婧", num));

            case OleObjectType.ExcelWorksheet:
                return (A_1 ? BookmarkStart.b("笵儷夹主儽㌿ⵁ≃㉅桇Չ⩋⡍㥏ㅑㅓ癕ᵗ≙㽛㭝౟䉡㍣॥ᩧũὫ٭ᕯ᝱s", num) : BookmarkStart.b("猵䀷夹夻刽渿ᅁⱃ⍅ⵇ㹉手罍扏", num));

            case OleObjectType.PowerPoint_97_2003_Presentation:
                return (A_1 ? BookmarkStart.b("笵儷夹主儽㌿ⵁ≃㉅桇Չ⩋⡍㥏ㅑㅓ癕ࡗ㕙⭛㭝቟㉡ୣཥ٧ṩ䱫坭䝯影䙳䙵䡷䥹屻⹽ﺉ揄憐﶑望", num) : BookmarkStart.b("昵圷䴹夻䰽ဿⵁⵃ⡅㱇摉Ὃ♍㽏║穓湕", num));

            case OleObjectType.PowerPoint_97_2003_Slide:
                return (A_1 ? BookmarkStart.b("笵儷夹主儽㌿ⵁ≃㉅桇Չ⩋⡍㥏ㅑㅓ癕ࡗ㕙⭛㭝቟㉡ୣཥ٧ṩ䱫坭䝯影䙳䙵䡷䥹屻⵽", num) : BookmarkStart.b("昵圷䴹夻䰽ဿⵁⵃ⡅㱇摉Ὃ≍㥏㙑ㅓ硕恗", num));

            case OleObjectType.PowerPointMacroPresentation:
                return (A_1 ? BookmarkStart.b("笵儷夹主儽㌿ⵁ≃㉅桇Չ⩋⡍㥏ㅑㅓ癕ࡗ㕙⭛㭝቟㉡ୣཥ٧ṩ䱫⍭ᅯᅱٳ᥵啷㽹ቻώꢇ\uda89\ufe8b望聯캟", num) : BookmarkStart.b("昵圷䴹夻䰽ဿⵁⵃ⡅㱇摉Ὃ♍㽏║ᥓ㝕㭗⡙㍛᭝๟͡٣੥൧๩䉫彭䉯", num));

            case OleObjectType.PowerPointMacroSlide:
                return (A_1 ? BookmarkStart.b("笵儷夹主儽㌿ⵁ≃㉅桇Չ⩋⡍㥏ㅑㅓ癕ࡗ㕙⭛㭝቟㉡ୣཥ٧ṩ䱫⍭ᅯᅱٳ᥵啷㽹ቻώꢇ\ud989\ue08b", num) : BookmarkStart.b("昵圷䴹夻䰽ဿⵁⵃ⡅㱇摉Ὃ≍㥏㙑ㅓ᭕㥗㥙⹛ㅝ╟ౡգѥѧཀྵ࡫䁭䅯䁱", num));

            case OleObjectType.PowerPointPresentation:
                return (A_1 ? BookmarkStart.b("笵儷夹主儽㌿ⵁ≃㉅桇Չ⩋⡍㥏ㅑㅓ癕ࡗ㕙⭛㭝቟㉡ୣཥ٧ṩ䱫㹭ɯ᝱ݳ፵ᙷ๹ᵻ੽", num) : BookmarkStart.b("昵圷䴹夻䰽ဿⵁⵃ⡅㱇摉Ὃ♍㽏║穓杕橗", num));

            case OleObjectType.PowerPointSlide:
                return (A_1 ? BookmarkStart.b("笵儷夹主儽㌿ⵁ≃㉅桇Չ⩋⡍㥏ㅑㅓ癕ࡗ㕙⭛㭝቟㉡ୣཥ٧ṩ䱫㵭ᱯ᭱ၳ፵", num) : BookmarkStart.b("昵圷䴹夻䰽ဿⵁⵃ⡅㱇摉Ὃ≍㥏㙑ㅓ硕楗桙", num));

            case OleObjectType.Word_97_2003_Document:
                return (A_1 ? BookmarkStart.b("笵儷夹主儽㌿ⵁ≃㉅桇Չ⩋⡍㥏ㅑㅓ癕བྷ㕙⹛㩝䁟孡卣䭥婧婩屫嵭偯㙱᭳ᕵ൷᝹᥻ၽ", num) : BookmarkStart.b("愵圷䠹堻ွпⵁ❃㍅╇⽉≋㩍繏橑", num));

            case OleObjectType.WordDocument:
                return (A_1 ? BookmarkStart.b("笵儷夹主儽㌿ⵁ≃㉅桇Չ⩋⡍㥏ㅑㅓ癕བྷ㕙⹛㩝䁟♡ୣեᵧݩ५mѯ", num) : BookmarkStart.b("愵圷䠹堻ွпⵁ❃㍅╇⽉≋㩍繏捑晓", num));

            case OleObjectType.WordMacroDocument:
                return (A_1 ? BookmarkStart.b("笵儷夹主儽㌿ⵁ≃㉅桇Չ⩋⡍㥏ㅑㅓ癕བྷ㕙⹛㩝䁟⽡գեᩧթ䅫⭭ṯ፱ᙳ᩵ᵷṹ屻㩽", num) : BookmarkStart.b("愵圷䠹堻ွпⵁ❃㍅╇⽉≋㩍ᵏ㍑㝓⑕㝗Ὑ㉛㽝ɟ๡ţɥ䙧孩幫", num));

            case OleObjectType.VisioDrawing:
                return (A_1 ? BookmarkStart.b("笵儷夹主儽㌿ⵁ≃㉅桇᱉╋㵍㥏㵑瑓ቕ⩗㭙⭛㝝๟ա", num) : BookmarkStart.b("怵儷䤹唻儽渿ف㙃❅㽇⍉≋⥍繏捑敓", num));

            case OleObjectType.MIDISequence:
                return BookmarkStart.b("笵焷縹画ḽጿ❁㕃㍅ⵇ⑉⽋⭍", num);

            case OleObjectType.OpenDocumentPresentation:
                return (A_1 ? BookmarkStart.b("礵䠷弹刻稽⼿⅁ㅃ⭅ⵇ⑉㡋湍O⁑ㅓ╕㵗㑙⡛㽝ᑟୡୣࡥ", num) : BookmarkStart.b("昵圷䴹夻䰽ဿⵁⵃ⡅㱇摉͋㹍㕏㱑ၓ㥕㭗⽙ㅛ㭝๟ᙡ㑣ᑥ൧ᥩ५mѯ፱sή᝷ᑹ剻佽뉿", num));

            case OleObjectType.OpenDocumentSpreadsheet:
                return (A_1 ? BookmarkStart.b("礵䠷弹刻稽⼿⅁ㅃ⭅ⵇ⑉㡋湍͏≑♓㍕㥗㹙⽛㙝՟ݡၣ", num) : BookmarkStart.b("猵䀷夹夻刽渿ു㑃⍅♇้⍋ⵍ╏㽑ㅓ㡕ⱗख़ⱛⱝ՟͡cᕥgཀྵ५ᩭ幯䍱䙳", num));

            case OleObjectType.OpenDocumentText:
                return str;

            case OleObjectType.OpenOfficeSpreadsheet1_1:
                return BookmarkStart.b("䔵圷尹娻圽⌿❁橃ᕅ㱇⭉㹋്ㅏ㹑㝓ቕ㝗㥙⥛㍝՟ౡၣ䡥幧", num);

            case OleObjectType.OpenOfficeText_1_1:
                return BookmarkStart.b("䔵圷尹娻圽⌿❁橃ᕅ㱇⭉㹋᥍≏㭑⁓㍕⩗ṙ㍛㵝ᕟཡţࡥᱧ䑩婫", num);

            case OleObjectType.Package:
                return BookmarkStart.b("昵夷夹圻弽✿❁", num);

            case OleObjectType.VideoClip:
                return (A_1 ? BookmarkStart.b("怵儷帹夻儽怿Ł⡃⽅㡇", num) : BookmarkStart.b("眵渷猹稻圽ⰿ❁", num));

            case OleObjectType.WaveSound:
                return (A_1 ? BookmarkStart.b("愵夷䰹夻洽⼿㝁⩃≅", num) : BookmarkStart.b("攵圷伹刻娽ሿ❁❃", num));

            case OleObjectType.WordPadDocument:
                return (A_1 ? BookmarkStart.b("愵圷䠹堻渽ℿ♁摃Ʌ❇⥉㥋⍍㕏㱑⁓", num) : BookmarkStart.b("愵圷䠹堻渽ℿ♁橃Ʌ❇⥉㥋⍍㕏㱑⁓硕楗", num));

            case OleObjectType.OpenOfficeSpreadsheet:
                return BookmarkStart.b("夵䠷弹刻娽⼿⅁ㅃ⭅ⵇ⑉㡋恍ፏ㍑㡓㕕᱗㕙㽛⭝ൟݡ੣ብ䙧孩", num);

            case OleObjectType.OpenOfficeText:
                return BookmarkStart.b("夵䠷弹刻娽⼿⅁ㅃ⭅ⵇ⑉㡋恍ݏ⁑㵓≕㵗⡙ᡛㅝ͟ᝡॣͥ٧ṩ䉫彭", num);

            case OleObjectType.VisioDrawing_2013:
                return BookmarkStart.b("怵儷䤹唻儽渿ف㙃❅㽇⍉≋⥍繏捑慓", num);

            case OleObjectType.WordPicture:
                return BookmarkStart.b("愵圷䠹堻ွဿ⭁❃㉅㵇㡉⥋恍桏", num);
        }
        return str;
    }

    internal static Guid smethod_2(OleObjectType A_0)
    {
        int num = 15;
        Guid guid = Guid.NewGuid();
        string g = null;
        switch (A_0)
        {
            case OleObjectType.AdobeAcrobatDocument:
                g = BookmarkStart.b("圴༶स਺帼帾着療桄♆硈ⵊ⹌扎恐扒ㅔ杖瑘捚桜㹞ՠ乢兤卦嵨幪塬屮䑰䝲䕴䝶䥸䭺", num);
                break;

            case OleObjectType.BitmapImage:
                g = BookmarkStart.b("Դܶस࠺഼༾煀≂桄睆祈筊経扎慐捒敔杖瑘㡚浜潞兠乢啤坦奨孪嵬彮䅰䍲䕴䝶䵸䵺", num);
                break;

            case OleObjectType.Equation:
                g = BookmarkStart.b("Դܶसऺ帼娾煀煂桄睆祈筊経扎慐捒敔杖瑘㡚浜潞兠乢啤坦奨孪嵬彮䅰䍲䕴䝶䵸䵺", num);
                break;

            case OleObjectType.GraphChart:
                g = BookmarkStart.b("Դܶसऺ഼ܾ煀灂桄睆祈筊経扎慐捒敔杖瑘㡚浜潞兠乢啤坦奨孪嵬彮䅰䍲䕴䝶䵸䵺", num);
                break;

            case OleObjectType.Excel_97_2003_Worksheet:
                g = BookmarkStart.b("Դܶसऺ഼ܾ獀獂桄睆祈筊経扎慐捒敔杖瑘㡚浜潞兠乢啤坦奨孪嵬彮䅰䍲䕴䝶䵸䵺", num);
                break;

            case OleObjectType.ExcelBinaryWorksheet:
                g = BookmarkStart.b("Դܶसऺ഼ܾ牀灂桄睆祈筊経扎慐捒敔杖瑘㡚浜潞兠乢啤坦奨孪嵬彮䅰䍲䕴䝶䵸䵺", num);
                break;

            case OleObjectType.ExcelChart:
                g = BookmarkStart.b("Դܶसऺ഼ܾ獀牂桄睆祈筊経扎慐捒敔杖瑘㡚浜潞兠乢啤坦奨孪嵬彮䅰䍲䕴䝶䵸䵺", num);
                break;

            case OleObjectType.ExcelMacroWorksheet:
                g = BookmarkStart.b("Դܶसऺ഼ܾ牀煂桄睆祈筊経扎慐捒敔杖瑘㡚浜潞兠乢啤坦奨孪嵬彮䅰䍲䕴䝶䵸䵺", num);
                break;

            case OleObjectType.ExcelWorksheet:
                g = BookmarkStart.b("Դܶसऺ഼ܾ牀獂桄睆祈筊経扎慐捒敔杖瑘㡚浜潞兠乢啤坦奨孪嵬彮䅰䍲䕴䝶䵸䵺", num);
                break;

            case OleObjectType.PowerPoint_97_2003_Presentation:
                g = BookmarkStart.b("̴̶ĸ਺Լ嬾灀獂桄獆⽈牊⽌扎恐扒㙔ㅖ瑘捚歜㩞`乢啤坦ࡨ੪嵬彮፰䩲䝴乶ᱸ䍺", num);
                break;

            case OleObjectType.PowerPoint_97_2003_Slide:
                g = BookmarkStart.b("̴̶ĸ਺Լ嬾灀牂桄獆⽈牊⽌扎恐扒㙔ㅖ瑘捚歜㩞`乢啤坦ࡨ੪嵬彮፰䩲䝴乶ᱸ䍺", num);
                break;

            case OleObjectType.PowerPointMacroPresentation:
                g = BookmarkStart.b("儴吶सऺ഼ా灀瑂桄≆罈⹊罌扎敐㉒捔敖瑘㥚摜㥞`乢ݤ呦౨൪࡬幮䝰䕲䝴䅶ὸ佺", num);
                break;

            case OleObjectType.PowerPointMacroSlide:
                g = BookmarkStart.b("ش吶࠸̺堼帾⑀睂桄╆⩈祊硌扎敐扒晔捖瑘㥚橜㭞ݠ乢呤ɦ੨੪屬屮䉰䑲ᅴ፶ᵸ᡺", num);
                break;

            case OleObjectType.PowerPointPresentation:
                g = BookmarkStart.b("嘴儶സ崺࠼ਾ❀睂桄罆⽈獊穌扎敐㝒慔恖瑘捚浜㵞͠乢偤彦奨卪屬奮䕰ᅲ᝴䑶ὸ䍺", num);
                break;

            case OleObjectType.PowerPointSlide:
                g = BookmarkStart.b("Դ̶ĸ帺弼ା牀♂桄畆祈繊瑌扎敐慒杔ㅖ瑘扚桜㩞兠乢偤剦幨ཪ౬噮䝰䍲䙴佶ᡸᵺ", num);
                break;

            case OleObjectType.Word_97_2003_Document:
                g = BookmarkStart.b("Դܶसऺ഼ؾ煀畂桄睆祈筊経扎慐捒敔杖瑘㡚浜潞兠乢啤坦奨孪嵬彮䅰䍲䕴䝶䵸䵺", num);
                break;

            case OleObjectType.WordDocument:
                g = BookmarkStart.b("匴̶़ฺุ尾础⅂桄煆絈ⵊ硌扎敐ㅒ慔杖瑘捚㱜㥞啠乢卤偦偨屪幬嵮ၰၲ䕴䅶䥸䱺", num);
                break;

            case OleObjectType.WordMacroDocument:
                g = BookmarkStart.b("д༶堸଺଼崾着⅂桄畆⽈硊⭌扎敐㙒杔㕖瑘㩚歜湞偠乢偤啦୨๪孬屮䁰ᅲ䝴፶䭸䥺", num);
                break;

            case OleObjectType.VisioDrawing:
            case OleObjectType.VisioDrawing_2013:
                g = BookmarkStart.b("Դܶसऺ఼帾灀睂桄睆祈筊経扎慐捒敔杖瑘㡚浜潞兠乢啤坦奨孪嵬彮䅰䍲䕴䝶䵸䵺", num);
                break;

            case OleObjectType.MIDISequence:
                g = BookmarkStart.b("Դܶसऺ༼ा煀灂桄睆祈筊経扎慐捒敔杖瑘㡚浜潞兠乢啤坦奨孪嵬彮䅰䍲䕴䝶䵸䵺", num);
                break;

            case OleObjectType.OpenDocumentPresentation:
                g = BookmarkStart.b("嘴Զĸऺ़฾癀⅂桄畆罈絊罌扎敐杒㝔潖瑘捚㱜晞啠乢噤զཨ൪孬幮ተ䙲䕴乶䥸䭺", num);
                break;

            case OleObjectType.OpenDocumentSpreadsheet:
                g = BookmarkStart.b("倴嘶嬸堺堼尾╀⅂桄⑆⩈穊⹌扎敐㉒捔ㅖ瑘㥚楜㩞剠乢剤Ŧ全卪啬๮䑰ቲᅴᅶ᩸䍺", num);
                break;

            case OleObjectType.OpenOfficeSpreadsheet1_1:
                g = BookmarkStart.b("ȴ唶ਸ༺༼嬾≀睂桄癆穈牊ⱌ扎敐㉒慔慖瑘捚㱜晞剠乢Ťզ奨卪彬塮ተၲၴቶ䁸᡺", num);
                break;

            case OleObjectType.OpenOfficeText_1_1:
                g = BookmarkStart.b("شܶ堸ऺ଼ਾ獀≂桄⍆ⵈⵊ穌扎敐晒ご恖瑘㩚㹜㹞坠乢噤ɦࡨ४彬奮ᝰၲ䵴ᙶ䵸Ṻ", num);
                break;

            case OleObjectType.Package:
                g = BookmarkStart.b("Դܶस࠺഼༾煀⁂桄睆祈筊経扎慐捒敔杖瑘㡚浜潞兠乢啤坦奨孪嵬彮䅰䍲䕴䝶䵸䵺", num);
                break;

            case OleObjectType.WordPadDocument:
                g = BookmarkStart.b("ȴж弸强夼尾祀獂桄♆ⱈ⩊瑌扎恐捒摔㙖瑘扚敜㹞噠乢啤坦ࡨ੪嵬彮䉰䑲䅴乶䱸䉺", num);
                break;

            case OleObjectType.OpenOfficeSpreadsheet:
                g = BookmarkStart.b("ȴ儶堸̺尼娾灀牂桄╆穈⹊繌扎敐㝒浔潖瑘㩚㱜㵞ݠ乢坤剦屨幪彬奮ተᝲ䑴ᑶᱸ䍺", num);
                break;

            case OleObjectType.OpenOfficeText:
                g = BookmarkStart.b("匴Ķ࠸ഺ弼ܾ灀╂桄灆⭈⥊界扎敐㕒杔敖瑘㥚敜㹞呠乢兤偦嵨奪啬୮䑰䩲፴佶ᡸὺ", num);
                break;

            case OleObjectType.WordPicture:
                g = BookmarkStart.b("Դܶसऺ഼ؾ煀瑂桄睆祈筊経扎慐捒敔杖瑘㡚浜潞兠乢啤坦奨孪嵬彮䅰䍲䕴䝶䵸䵺", num);
                break;
        }
        if (g != null)
        {
            guid = new Guid(g);
        }
        return guid;
    }
}

