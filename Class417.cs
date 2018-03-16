using Spire.Doc;
using Spire.Doc.Documents;
using Spire.Doc.Formatting;
using System;
using System.Collections;
using System.Collections.Generic;

internal class Class417
{
    private static readonly Hashtable hashtable_0 = new Hashtable();
    private static readonly Hashtable hashtable_1 = new Hashtable();
    private static readonly Hashtable hashtable_10 = new Hashtable();
    private static readonly Hashtable hashtable_11 = new Hashtable();
    private static readonly Hashtable hashtable_12 = new Hashtable();
    private static readonly Hashtable hashtable_13 = new Hashtable();
    private static readonly Hashtable hashtable_14 = new Hashtable();
    private static readonly Hashtable hashtable_15 = new Hashtable();
    private static readonly Hashtable hashtable_16 = new Hashtable();
    private static readonly Hashtable hashtable_17 = new Hashtable();
    private static readonly Hashtable hashtable_18 = new Hashtable();
    private static readonly Hashtable hashtable_19 = new Hashtable();
    private static readonly Hashtable hashtable_2 = new Hashtable();
    private static readonly Hashtable hashtable_3 = new Hashtable();
    private static readonly Hashtable hashtable_4 = new Hashtable();
    private static readonly Hashtable hashtable_5 = new Hashtable();
    private static readonly Hashtable hashtable_6 = new Hashtable();
    private static readonly Hashtable hashtable_7 = new Hashtable();
    private static readonly Hashtable hashtable_8 = new Hashtable();
    private static readonly Hashtable hashtable_9 = new Hashtable();

    static Class417()
    {
        Class791.smethod_0(new object[] { BookmarkStart.b("䈥䴧䰩䴫嬭尯䘱", 0), FontPitch.Default, BookmarkStart.b("䀥䄧利䤫䨭", 0), FontPitch.Fixed, BookmarkStart.b("倥䤧堩䔫伭刯帱儳", 0), FontPitch.Variable }, hashtable_0, hashtable_1);
        Class791.smethod_0(new object[] { BookmarkStart.b("䬥䤧堩䬫䜭帯", 0), RelativeHeight.Margin, BookmarkStart.b("嘥䤧䴩䤫", 0), RelativeHeight.Page, BookmarkStart.b("䤥崧帩䤫尭ᴯ弱唳䐵強匹刻ጽℿぁ⅃❅", 0), RelativeHeight.OutsideMargin, BookmarkStart.b("伥䘧䐩䤫尭ᴯ弱唳䐵強匹刻ጽℿぁ⅃❅", 0), RelativeHeight.InsideMargin, BookmarkStart.b("別䜧娩ī䌭儯䀱匳張嘷᜹崻䰽┿⍁", 0), RelativeHeight.TopMargin, BookmarkStart.b("䐥䜧帩堫䄭崯ἱ夳圵䨷崹唻倽洿⍁㙃⍅⥇", 0), RelativeHeight.BottomMargin }, hashtable_2, hashtable_3);
        Class791.smethod_0(new object[] { BookmarkStart.b("䬥䤧堩䬫䜭帯", 0), RelativeWidth.Margin, BookmarkStart.b("嘥䤧䴩䤫", 0), RelativeWidth.Page, BookmarkStart.b("䤥崧帩䤫尭ᴯ弱唳䐵強匹刻ጽℿぁ⅃❅", 0), RelativeWidth.OutsideMargin, BookmarkStart.b("伥䘧䐩䤫尭ᴯ弱唳䐵強匹刻ጽℿぁ⅃❅", 0), RelativeWidth.InsideMargin, BookmarkStart.b("䨥䴧䰩堫̭崯匱䘳儵儷吹ᄻ弽㈿❁╃", 0), RelativeWidth.LeftMargin, BookmarkStart.b("吥䄧䴩䐫娭ᴯ弱唳䐵強匹刻ጽℿぁ⅃❅", 0), RelativeWidth.RightMargin }, hashtable_4, hashtable_5);
        Class791.smethod_0(new object[] { BookmarkStart.b("䬥䤧堩䬫䜭帯", 0), VerticalOrigin.Margin, BookmarkStart.b("嘥䤧䴩䤫", 0), VerticalOrigin.Page, BookmarkStart.b("別䴧利堫", 0), VerticalOrigin.Paragraph, BookmarkStart.b("䨥䄧䐩䤫", 0), VerticalOrigin.Line, BookmarkStart.b("䤥崧帩䤫尭ᴯ弱唳䐵強匹刻ጽℿぁ⅃❅", 0), VerticalOrigin.OuterMarginArea, BookmarkStart.b("伥䘧䐩䤫尭ᴯ弱唳䐵強匹刻ጽℿぁ⅃❅", 0), VerticalOrigin.InnerMarginArea, BookmarkStart.b("別䜧娩ī䌭儯䀱匳張嘷᜹崻䰽┿⍁", 0), VerticalOrigin.TopMarginArea, BookmarkStart.b("䐥䜧帩堫䄭崯ἱ夳圵䨷崹唻倽洿⍁㙃⍅⥇", 0), VerticalOrigin.BottomMarginArea }, hashtable_6, hashtable_7);
        Class791.smethod_0(new object[] { BookmarkStart.b("䬥䤧堩䬫䜭帯", 0), HorizontalOrigin.Margin, BookmarkStart.b("嘥䤧䴩䤫", 0), HorizontalOrigin.Page, BookmarkStart.b("別䴧利堫", 0), HorizontalOrigin.Column, BookmarkStart.b("䔥䀧䬩師", 0), HorizontalOrigin.Character, BookmarkStart.b("䤥崧帩䤫尭ᴯ弱唳䐵強匹刻ጽℿぁ⅃❅", 0), HorizontalOrigin.OuterMarginArea, BookmarkStart.b("伥䘧䐩䤫尭ᴯ弱唳䐵強匹刻ጽℿぁ⅃❅", 0), HorizontalOrigin.InnerMarginArea, BookmarkStart.b("䨥䴧䰩堫̭崯匱䘳儵儷吹ᄻ弽㈿❁╃", 0), HorizontalOrigin.LeftMarginArea, BookmarkStart.b("吥䄧䴩䐫娭ᴯ弱唳䐵強匹刻ጽℿぁ⅃❅", 0), HorizontalOrigin.RightMarginArea }, hashtable_8, hashtable_9);
        Class791.smethod_0(new object[] { BookmarkStart.b("䜥䨧天䌫䈭䔯䘱儳", 0), HorizontalPosition.None, BookmarkStart.b("䨥䴧䰩堫", 0), HorizontalPosition.Left, BookmarkStart.b("䔥䴧䐩堫䬭䈯", 0), HorizontalPosition.Center, BookmarkStart.b("吥䄧䴩䐫娭", 0), HorizontalPosition.Right, BookmarkStart.b("伥䘧天䔫䨭唯", 0), HorizontalPosition.Inside, BookmarkStart.b("䤥崧帩弫䜭启圱", 0), HorizontalPosition.Outside }, hashtable_10, hashtable_11);
        Class791.smethod_0(new object[] { BookmarkStart.b("䜥䨧天䌫䈭䔯䘱儳", 0), VerticalPosition.None, BookmarkStart.b("別䜧娩", 0), VerticalPosition.Top, BookmarkStart.b("䔥䴧䐩堫䬭䈯", 0), VerticalPosition.Center, BookmarkStart.b("䐥䜧帩堫䄭崯", 0), VerticalPosition.Bottom, BookmarkStart.b("伥䘧天䔫䨭唯", 0), VerticalPosition.Inside, BookmarkStart.b("䤥崧帩弫䜭启圱", 0), VerticalPosition.Outside }, hashtable_12, hashtable_13);
        Class791.smethod_0(new object[] { 
            BookmarkStart.b("搥䜧䔩䜫อ搯嬱䀳娵崷", 0), StyleIdentifier.BookTitle, BookmarkStart.b("䜥䘧䐩䌫娭儯䘱崳夵嘷ᨹ主嬽☿❁㙃⍅♇⥉⥋", 0), StyleIdentifier.CommentReference, BookmarkStart.b("戥䴧䰩䴫嬭尯䘱ᐳ昵夷䠹崻夽㈿⍁㑃⹅桇౉⍋⁍⑏", 0), StyleIdentifier.DefaultParagraphFont, BookmarkStart.b("挥䔧娩䐫伭䌯嬱䜳", 0), StyleIdentifier.Emphasis, BookmarkStart.b("䌥䘧丩䈫䄭䐯圱ᐳ䐵崷尹夻䰽┿ⱁ❃⍅", 0), StyleIdentifier.EndnoteReference, BookmarkStart.b("急䜧䘩䀫䄭䜯圱倳縵䄷䨹夻䰽ⰿ⭁⩃ⵅ", 0), StyleIdentifier.FollowedHyperlink, BookmarkStart.b("䀥䜧䔩堫䀭弯䘱儳ᘵ䨷弹娻嬽㈿❁⩃╅ⵇ", 0), StyleIdentifier.FootnoteReference, BookmarkStart.b("渥簧朩怫อ焯儱䘳夵嘷䌹儻", 0), StyleIdentifier.HtmlAcronym, 
            BookmarkStart.b("渥簧朩怫อ猯嬱䀳匵", 0), StyleIdentifier.HtmlCite, BookmarkStart.b("渥簧朩怫อ猯崱倳匵", 0), StyleIdentifier.HtmlCode, BookmarkStart.b("渥簧朩怫อ琯圱刳張嘷匹䠻圽⼿ⱁ", 0), StyleIdentifier.HtmlDefinition, BookmarkStart.b("渥簧朩怫อ笯圱䴳吵圷嬹主娽", 0), StyleIdentifier.HtmlKeyboard, BookmarkStart.b("渥簧朩怫อ振匱夳䘵吷弹", 0), StyleIdentifier.HtmlSample, BookmarkStart.b("渥簧朩怫อ搯䬱䐳匵眷伹䠻丽㔿㙁", 0), StyleIdentifier.HtmlTypeOutput, BookmarkStart.b("渥簧朩怫อ是匱䘳張夷堹倻嬽", 0), StyleIdentifier.HtmlVariable, BookmarkStart.b("渥儧娩䤫尭尯嬱娳崵", 0), StyleIdentifier.Hyperlink, 
            BookmarkStart.b("漥䘧帩䤫䀭䌯圱ᐳ猵唷䨹吻弽㌿⭁㝃", 0), StyleIdentifier.IntenseEmphasis, BookmarkStart.b("漥䘧帩䤫䀭䌯圱ᐳ搵崷尹夻䰽┿ⱁ❃⍅", 0), StyleIdentifier.IntenseReference, BookmarkStart.b("䨥䄧䐩䤫อ帯䜱夳吵崷䠹", 0), StyleIdentifier.LineNumber, BookmarkStart.b("嘥䤧䴩䤫อ帯䜱夳吵崷䠹", 0), StyleIdentifier.PageNumber, BookmarkStart.b("瘥䐧䬩伫䬭堯崱堳刵崷䠹᰻樽┿㩁ぃ", 0), StyleIdentifier.PlaceholderText, BookmarkStart.b("甥尧堩䌫䀭圯", 0), StyleIdentifier.Strong, BookmarkStart.b("甥崧䠩堫䈭唯ሱ焳嬵䠷刹崻䴽⤿ㅁ", 0), StyleIdentifier.SubtleEmphasis, BookmarkStart.b("甥崧䠩堫䈭唯ሱ昳匵帷弹主嬽⸿⅁⅃", 0), StyleIdentifier.SubtleReference, 
            BookmarkStart.b("搥䤧䘩䀫䄭弯就ᐳ戵崷䈹䠻", 0), StyleIdentifier.BalloonText, BookmarkStart.b("搥䜧丩唫อ搯圱䰳䈵", 0), StyleIdentifier.BodyText, BookmarkStart.b("搥䜧丩唫อ搯圱䰳䈵ᠷ࠹", 0), StyleIdentifier.BodyText2, BookmarkStart.b("搥䜧丩唫อ搯圱䰳䈵ᠷह", 0), StyleIdentifier.BodyText3, BookmarkStart.b("搥䜧丩唫อ搯圱䰳䈵ᠷ簹唻䰽㌿㙁摃ཅ♇⹉⥋⁍⑏", 0), StyleIdentifier.BodyText1I, BookmarkStart.b("搥䜧丩唫อ搯圱䰳䈵ᠷ簹唻䰽㌿㙁摃ཅ♇⹉⥋⁍⑏牑晓", 0), StyleIdentifier.BodyText1I2, BookmarkStart.b("搥䜧丩唫อ搯圱䰳䈵ᠷ猹刻娽┿ⱁぃ", 0), StyleIdentifier.BodyTextInd, BookmarkStart.b("搥䜧丩唫อ搯圱䰳䈵ᠷ猹刻娽┿ⱁぃ晅穇", 0), StyleIdentifier.BodyTextInd2, 
            BookmarkStart.b("搥䜧丩唫อ搯圱䰳䈵ᠷ猹刻娽┿ⱁぃ晅筇", 0), StyleIdentifier.BodyTextInd3, BookmarkStart.b("攥䐧䔩弫䜭帯唱", 0), StyleIdentifier.Closing, BookmarkStart.b("䜥䘧䐩䌫娭儯䘱崳夵嘷ᨹ伻䬽∿⡁⅃╅㱇", 0), StyleIdentifier.CommentSubject, BookmarkStart.b("䜥䘧䐩䌫娭儯䘱崳夵嘷ᨹ䠻嬽㠿㙁", 0), StyleIdentifier.CommentText, BookmarkStart.b("戥䤧帩䤫", 0), StyleIdentifier.Date, BookmarkStart.b("戥䜧䤩夫䌭唯就䀳ᘵ男嬹䰻", 0), StyleIdentifier.DocumentMap, BookmarkStart.b("挥ԧ䜩䴫䜭尯ሱ朳張強吹崻䨽㔿ぁ⅃", 0), StyleIdentifier.EmailSignature, BookmarkStart.b("䌥䘧丩䈫䄭䐯圱ᐳ䈵崷䈹䠻", 0), StyleIdentifier.EndnoteText, 
            BookmarkStart.b("䀥䜧䔩堫䬭䈯", 0), StyleIdentifier.Footer, BookmarkStart.b("䀥䜧䔩堫䀭弯䘱儳ᘵ䰷弹䐻䨽", 0), StyleIdentifier.FootnoteText, BookmarkStart.b("严䴧䬩䠫䬭䈯", 0), StyleIdentifier.Header, BookmarkStart.b("严䴧䬩䠫䜭帯唱ᐳܵ", 0), StyleIdentifier.Heading1, BookmarkStart.b("严䴧䬩䠫䜭帯唱ᐳе", 0), StyleIdentifier.Heading2, BookmarkStart.b("严䴧䬩䠫䜭帯唱ᐳԵ", 0), StyleIdentifier.Heading3, BookmarkStart.b("严䴧䬩䠫䜭帯唱ᐳȵ", 0), StyleIdentifier.Heading4, BookmarkStart.b("严䴧䬩䠫䜭帯唱ᐳ̵", 0), StyleIdentifier.Heading5, 
            BookmarkStart.b("严䴧䬩䠫䜭帯唱ᐳ5", 0), StyleIdentifier.Heading6, BookmarkStart.b("严䴧䬩䠫䜭帯唱ᐳĵ", 0), StyleIdentifier.Heading7, BookmarkStart.b("严䴧䬩䠫䜭帯唱ᐳี", 0), StyleIdentifier.Heading8, BookmarkStart.b("严䴧䬩䠫䜭帯唱ᐳ༵", 0), StyleIdentifier.Heading9, BookmarkStart.b("渥簧朩怫อ焯嘱倳䐵崷䤹伻", 0), StyleIdentifier.HtmlAddress, BookmarkStart.b("渥簧朩怫อ爯崱䀳䈵圷圹᰻儽☿扁Ƀ⥅㩇❉", 0), StyleIdentifier.HtmlBottomOfForm, BookmarkStart.b("渥簧朩怫อ怯䀱儳倵圷䠹儻弽㐿㙁⅃≅", 0), StyleIdentifier.HtmlPreformatted, BookmarkStart.b("渥簧朩怫อ搯崱䐳ᘵ圷尹᰻砽⼿ぁ⥃", 0), StyleIdentifier.HtmlTopOfForm, 
            BookmarkStart.b("漥䘧帩䤫䀭䌯圱ᐳ朵䴷唹䠻嬽", 0), StyleIdentifier.IntenseQuote, BookmarkStart.b("䬥䤧䤩師䄭", 0), StyleIdentifier.Macro, BookmarkStart.b("欥䴧天弫伭圯圱ᐳ縵崷嬹堻嬽㈿", 0), StyleIdentifier.MessageHeader, BookmarkStart.b("䠥䜧帩䤫อ堯圱唳刵儷吹嬻", 0), StyleIdentifier.NoteHeading, BookmarkStart.b("瘥䐧䬩䔫䀭ု昱儳丵䰷", 0), StyleIdentifier.PlainText, BookmarkStart.b("眥崧䔩堫䬭", 0), StyleIdentifier.Quote, BookmarkStart.b("甥䤧䘩夫娭儯䘱崳夵嘷", 0), StyleIdentifier.Salutation, BookmarkStart.b("甥䄧䴩䈫伭䐯䜱䘳匵", 0), StyleIdentifier.Signature, 
            BookmarkStart.b("甥崧䠩堫䜭䐯帱儳", 0), StyleIdentifier.Subtitle, BookmarkStart.b("爥䄧帩䀫䬭", 0), StyleIdentifier.Title, BookmarkStart.b("搥䄧䠩䀫䜭弯唱䘳圵䠷刹䔻", 0), StyleIdentifier.Bibliography, BookmarkStart.b("搥䐧䔩伫䔭ု昱儳丵䰷", 0), StyleIdentifier.BlockText, BookmarkStart.b("䔥䤧娩堫䜭弯就", 0), StyleIdentifier.Caption, BookmarkStart.b("䌥䘧尩䤫䈭弯䈱儳ᘵ夷帹堻䰽┿ㅁ㝃", 0), StyleIdentifier.EnvelopeAddress, BookmarkStart.b("䌥䘧尩䤫䈭弯䈱儳ᘵ䨷弹䠻䬽㈿ⱁ", 0), StyleIdentifier.EnvelopeReturn, BookmarkStart.b("伥䘧丩䤫嘭ု̱", 0), StyleIdentifier.Index1, 
            BookmarkStart.b("伥䘧丩䤫嘭ု1", 0), StyleIdentifier.Index2, BookmarkStart.b("伥䘧丩䤫嘭ုı", 0), StyleIdentifier.Index3, BookmarkStart.b("伥䘧丩䤫嘭ုر", 0), StyleIdentifier.Index4, BookmarkStart.b("伥䘧丩䤫嘭ုܱ", 0), StyleIdentifier.Index5, BookmarkStart.b("伥䘧丩䤫嘭ုб", 0), StyleIdentifier.Index6, BookmarkStart.b("伥䘧丩䤫嘭ုԱ", 0), StyleIdentifier.Index7, BookmarkStart.b("伥䘧丩䤫嘭ု਱", 0), StyleIdentifier.Index8, BookmarkStart.b("伥䘧丩䤫嘭ု଱", 0), StyleIdentifier.Index9, 
            BookmarkStart.b("伥䘧丩䤫嘭ု娱儳圵尷匹刻夽", 0), StyleIdentifier.IndexHeading, BookmarkStart.b("樥䄧天堫", 0), StyleIdentifier.List, BookmarkStart.b("樥䄧天堫อȯ", 0), StyleIdentifier.List2, BookmarkStart.b("樥䄧天堫อ̯", 0), StyleIdentifier.List3, BookmarkStart.b("樥䄧天堫อЯ", 0), StyleIdentifier.List4, BookmarkStart.b("樥䄧天堫อԯ", 0), StyleIdentifier.List5, BookmarkStart.b("樥䄧天堫อ爯䜱堳娵崷丹", 0), StyleIdentifier.ListBullet, BookmarkStart.b("樥䄧天堫อ爯䜱堳娵崷丹᰻ఽ", 0), StyleIdentifier.ListBullet2, 
            BookmarkStart.b("樥䄧天堫อ爯䜱堳娵崷丹᰻ഽ", 0), StyleIdentifier.ListBullet3, BookmarkStart.b("樥䄧天堫อ爯䜱堳娵崷丹᰻਽", 0), StyleIdentifier.ListBullet4, BookmarkStart.b("樥䄧天堫อ爯䜱堳娵崷丹᰻ଽ", 0), StyleIdentifier.ListBullet5, BookmarkStart.b("樥䄧天堫อ猯崱娳䈵儷吹䤻嬽", 0), StyleIdentifier.ListContinue, BookmarkStart.b("樥䄧天堫อ猯崱娳䈵儷吹䤻嬽怿灁", 0), StyleIdentifier.ListContinue2, BookmarkStart.b("樥䄧天堫อ猯崱娳䈵儷吹䤻嬽怿煁", 0), StyleIdentifier.ListContinue3, BookmarkStart.b("樥䄧天堫อ猯崱娳䈵儷吹䤻嬽怿癁", 0), StyleIdentifier.ListContinue4, BookmarkStart.b("樥䄧天堫อ猯崱娳䈵儷吹䤻嬽怿睁", 0), StyleIdentifier.ListContinue5, 
            BookmarkStart.b("樥䄧天堫อ縯䜱夳吵崷䠹", 0), StyleIdentifier.ListNumber, BookmarkStart.b("樥䄧天堫อ縯䜱夳吵崷䠹᰻ఽ", 0), StyleIdentifier.ListNumber2, BookmarkStart.b("樥䄧天堫อ縯䜱夳吵崷䠹᰻ഽ", 0), StyleIdentifier.ListNumber3, BookmarkStart.b("樥䄧天堫อ縯䜱夳吵崷䠹᰻਽", 0), StyleIdentifier.ListNumber4, BookmarkStart.b("樥䄧天堫อ縯䜱夳吵崷䠹᰻ଽ", 0), StyleIdentifier.ListNumber5, BookmarkStart.b("樥䄧天堫อ怯匱䘳圵強䠹崻丽⠿", 0), StyleIdentifier.ListParagraph, BookmarkStart.b("栥䜧਩缫席儯儱崳堵強", 0), StyleIdentifier.NoSpacing, BookmarkStart.b("栥䜧堩䄫伭尯", 0), StyleIdentifier.Normal, 
            BookmarkStart.b("栥䜧堩䄫伭尯ሱᰳ愵崷堹ᔻ", 0), StyleIdentifier.NormalWeb, BookmarkStart.b("栥䜧堩䄫伭尯ሱ紳堵尷弹刻䨽", 0), StyleIdentifier.NormalIndent, BookmarkStart.b("琥䴧尩䔫崭夯崱娳", 0), StyleIdentifier.Revision, BookmarkStart.b("別䤧䠩䀫䬭ု崱刳ᘵ夷伹䠻嘽⼿ぁⵃ㉅ⅇ⽉㽋", 0), StyleIdentifier.TableOfAuthorities, BookmarkStart.b("別䤧䠩䀫䬭ု崱刳ᘵ帷匹嬻䬽㈿❁㝃", 0), StyleIdentifier.TableOfFigures, BookmarkStart.b("別䜧䬩ఫ䘭唯匱倳張嘷崹", 0), StyleIdentifier.ToaHeading, BookmarkStart.b("別䜧䤩ఫἭ", 0), StyleIdentifier.Toc1, BookmarkStart.b("別䜧䤩ఫᰭ", 0), StyleIdentifier.Toc2, 
            BookmarkStart.b("別䜧䤩ఫᴭ", 0), StyleIdentifier.Toc3, BookmarkStart.b("別䜧䤩ఫᨭ", 0), StyleIdentifier.Toc4, BookmarkStart.b("別䜧䤩ఫᬭ", 0), StyleIdentifier.Toc5, BookmarkStart.b("別䜧䤩ఫᠭ", 0), StyleIdentifier.Toc6, BookmarkStart.b("別䜧䤩ఫ᤭", 0), StyleIdentifier.Toc7, BookmarkStart.b("別䜧䤩ఫᘭ", 0), StyleIdentifier.Toc8, BookmarkStart.b("別䜧䤩ఫᜭ", 0), StyleIdentifier.Toc9, BookmarkStart.b("爥朧椩ఫ昭唯匱倳張嘷崹", 0), StyleIdentifier.TocHeading, 
            BookmarkStart.b("椥崧帩䀫䜭帯圱ᐳ稵儷䤹䠻ḽ焿", 0), StyleIdentifier.OutlineList1, BookmarkStart.b("椥崧帩䀫䜭帯圱ᐳ稵儷䤹䠻ḽ爿", 0), StyleIdentifier.OutlineList2, BookmarkStart.b("椥崧帩䀫䜭帯圱ᐳ稵儷䤹䠻ḽ猿", 0), StyleIdentifier.OutlineList3, BookmarkStart.b("栥䜧਩怫䜭䌯䘱", 0), StyleIdentifier.NoList, BookmarkStart.b("攥䜧䘩䌫尭嘯䜱堳ᘵ缷䠹唻娽", 0), StyleIdentifier.ColorfulGrid, BookmarkStart.b("攥䜧䘩䌫尭嘯䜱堳ᘵ缷䠹唻娽怿́❃╅ⵇ⑉㡋湍慏", 0), StyleIdentifier.ColorfulGridAccent1, BookmarkStart.b("攥䜧䘩䌫尭嘯䜱堳ᘵ缷䠹唻娽怿́❃╅ⵇ⑉㡋湍扏", 0), StyleIdentifier.ColorfulGridAccent2, BookmarkStart.b("攥䜧䘩䌫尭嘯䜱堳ᘵ缷䠹唻娽怿́❃╅ⵇ⑉㡋湍捏", 0), StyleIdentifier.ColorfulGridAccent3, 
            BookmarkStart.b("攥䜧䘩䌫尭嘯䜱堳ᘵ缷䠹唻娽怿́❃╅ⵇ⑉㡋湍摏", 0), StyleIdentifier.ColorfulGridAccent4, BookmarkStart.b("攥䜧䘩䌫尭嘯䜱堳ᘵ缷䠹唻娽怿́❃╅ⵇ⑉㡋湍敏", 0), StyleIdentifier.ColorfulGridAccent5, BookmarkStart.b("攥䜧䘩䌫尭嘯䜱堳ᘵ缷䠹唻娽怿́❃╅ⵇ⑉㡋湍晏", 0), StyleIdentifier.ColorfulGridAccent6, BookmarkStart.b("攥䜧䘩䌫尭嘯䜱堳ᘵ琷匹伻䨽", 0), StyleIdentifier.ColorfulList, BookmarkStart.b("攥䜧䘩䌫尭嘯䜱堳ᘵ琷匹伻䨽怿́❃╅ⵇ⑉㡋湍慏", 0), StyleIdentifier.ColorfulListAccent1, BookmarkStart.b("攥䜧䘩䌫尭嘯䜱堳ᘵ琷匹伻䨽怿́❃╅ⵇ⑉㡋湍扏", 0), StyleIdentifier.ColorfulListAccent2, BookmarkStart.b("攥䜧䘩䌫尭嘯䜱堳ᘵ琷匹伻䨽怿́❃╅ⵇ⑉㡋湍捏", 0), StyleIdentifier.ColorfulListAccent3, BookmarkStart.b("攥䜧䘩䌫尭嘯䜱堳ᘵ琷匹伻䨽怿́❃╅ⵇ⑉㡋湍摏", 0), StyleIdentifier.ColorfulListAccent4, 
            BookmarkStart.b("攥䜧䘩䌫尭嘯䜱堳ᘵ琷匹伻䨽怿́❃╅ⵇ⑉㡋湍敏", 0), StyleIdentifier.ColorfulListAccent5, BookmarkStart.b("攥䜧䘩䌫尭嘯䜱堳ᘵ琷匹伻䨽怿́❃╅ⵇ⑉㡋湍晏", 0), StyleIdentifier.ColorfulListAccent6, BookmarkStart.b("攥䜧䘩䌫尭嘯䜱堳ᘵ欷刹崻娽⤿ⱁ⍃", 0), StyleIdentifier.ColorfulShading, BookmarkStart.b("攥䜧䘩䌫尭嘯䜱堳ᘵ欷刹崻娽⤿ⱁ⍃晅े⥉⽋⭍㹏♑瑓杕", 0), StyleIdentifier.ColorfulShadingAccent1, BookmarkStart.b("攥䜧䘩䌫尭嘯䜱堳ᘵ欷刹崻娽⤿ⱁ⍃晅े⥉⽋⭍㹏♑瑓摕", 0), StyleIdentifier.ColorfulShadingAccent2, BookmarkStart.b("攥䜧䘩䌫尭嘯䜱堳ᘵ欷刹崻娽⤿ⱁ⍃晅े⥉⽋⭍㹏♑瑓敕", 0), StyleIdentifier.ColorfulShadingAccent3, BookmarkStart.b("攥䜧䘩䌫尭嘯䜱堳ᘵ欷刹崻娽⤿ⱁ⍃晅े⥉⽋⭍㹏♑瑓払", 0), StyleIdentifier.ColorfulShadingAccent4, BookmarkStart.b("攥䜧䘩䌫尭嘯䜱堳ᘵ欷刹崻娽⤿ⱁ⍃晅े⥉⽋⭍㹏♑瑓捕", 0), StyleIdentifier.ColorfulShadingAccent5, 
            BookmarkStart.b("攥䜧䘩䌫尭嘯䜱堳ᘵ欷刹崻娽⤿ⱁ⍃晅े⥉⽋⭍㹏♑瑓恕", 0), StyleIdentifier.ColorfulShadingAccent6, BookmarkStart.b("戥䤧堩䜫อ簯嬱䜳䈵", 0), StyleIdentifier.DarkList, BookmarkStart.b("戥䤧堩䜫อ簯嬱䜳䈵ᠷ笹弻崽┿ⱁぃ晅祇", 0), StyleIdentifier.DarkListAccent1, BookmarkStart.b("戥䤧堩䜫อ簯嬱䜳䈵ᠷ笹弻崽┿ⱁぃ晅穇", 0), StyleIdentifier.DarkListAccent2, BookmarkStart.b("戥䤧堩䜫อ簯嬱䜳䈵ᠷ笹弻崽┿ⱁぃ晅筇", 0), StyleIdentifier.DarkListAccent3, BookmarkStart.b("戥䤧堩䜫อ簯嬱䜳䈵ᠷ笹弻崽┿ⱁぃ晅籇", 0), StyleIdentifier.DarkListAccent4, BookmarkStart.b("戥䤧堩䜫อ簯嬱䜳䈵ᠷ笹弻崽┿ⱁぃ晅絇", 0), StyleIdentifier.DarkListAccent5, BookmarkStart.b("戥䤧堩䜫อ簯嬱䜳䈵ᠷ笹弻崽┿ⱁぃ晅繇", 0), StyleIdentifier.DarkListAccent6, 
            BookmarkStart.b("樥䄧䴩䐫娭ု由䘳張尷", 0), StyleIdentifier.LightGrid, BookmarkStart.b("樥䄧䴩䐫娭ု由䘳張尷ᨹ紻崽⌿❁⩃㉅桇等", 0), StyleIdentifier.LightGridAccent1, BookmarkStart.b("樥䄧䴩䐫娭ု由䘳張尷ᨹ紻崽⌿❁⩃㉅桇硉", 0), StyleIdentifier.LightGridAccent2, BookmarkStart.b("樥䄧䴩䐫娭ု由䘳張尷ᨹ紻崽⌿❁⩃㉅桇祉", 0), StyleIdentifier.LightGridAccent3, BookmarkStart.b("樥䄧䴩䐫娭ု由䘳張尷ᨹ紻崽⌿❁⩃㉅桇繉", 0), StyleIdentifier.LightGridAccent4, BookmarkStart.b("樥䄧䴩䐫娭ု由䘳張尷ᨹ紻崽⌿❁⩃㉅桇罉", 0), StyleIdentifier.LightGridAccent5, BookmarkStart.b("樥䄧䴩䐫娭ု由䘳張尷ᨹ紻崽⌿❁⩃㉅桇籉", 0), StyleIdentifier.LightGridAccent6, BookmarkStart.b("樥䄧䴩䐫娭ု縱崳䔵䰷", 0), StyleIdentifier.LightList, 
            BookmarkStart.b("樥䄧䴩䐫娭ု縱崳䔵䰷ᨹ紻崽⌿❁⩃㉅桇等", 0), StyleIdentifier.LightListAccent1, BookmarkStart.b("樥䄧䴩䐫娭ု縱崳䔵䰷ᨹ紻崽⌿❁⩃㉅桇硉", 0), StyleIdentifier.LightListAccent2, BookmarkStart.b("樥䄧䴩䐫娭ု縱崳䔵䰷ᨹ紻崽⌿❁⩃㉅桇祉", 0), StyleIdentifier.LightListAccent3, BookmarkStart.b("樥䄧䴩䐫娭ု縱崳䔵䰷ᨹ紻崽⌿❁⩃㉅桇繉", 0), StyleIdentifier.LightListAccent4, BookmarkStart.b("樥䄧䴩䐫娭ု縱崳䔵䰷ᨹ紻崽⌿❁⩃㉅桇罉", 0), StyleIdentifier.LightListAccent5, BookmarkStart.b("樥䄧䴩䐫娭ု縱崳䔵䰷ᨹ紻崽⌿❁⩃㉅桇籉", 0), StyleIdentifier.LightListAccent6, BookmarkStart.b("樥䄧䴩䐫娭ု愱尳圵尷匹刻夽", 0), StyleIdentifier.LightShading, BookmarkStart.b("樥䄧䴩䐫娭ု愱尳圵尷匹刻夽怿́❃╅ⵇ⑉㡋湍慏", 0), StyleIdentifier.LightShadingAccent1, 
            BookmarkStart.b("樥䄧䴩䐫娭ု愱尳圵尷匹刻夽怿́❃╅ⵇ⑉㡋湍扏", 0), StyleIdentifier.LightShadingAccent2, BookmarkStart.b("樥䄧䴩䐫娭ု愱尳圵尷匹刻夽怿́❃╅ⵇ⑉㡋湍捏", 0), StyleIdentifier.LightShadingAccent3, BookmarkStart.b("樥䄧䴩䐫娭ု愱尳圵尷匹刻夽怿́❃╅ⵇ⑉㡋湍摏", 0), StyleIdentifier.LightShadingAccent4, BookmarkStart.b("樥䄧䴩䐫娭ု愱尳圵尷匹刻夽怿́❃╅ⵇ⑉㡋湍敏", 0), StyleIdentifier.LightShadingAccent5, BookmarkStart.b("樥䄧䴩䐫娭ု愱尳圵尷匹刻夽怿́❃╅ⵇ⑉㡋湍晏", 0), StyleIdentifier.LightShadingAccent6, BookmarkStart.b("欥䴧丩䔫嬭崯ሱ猳䐵儷帹᰻༽", 0), StyleIdentifier.MediumGrid1, BookmarkStart.b("欥䴧丩䔫嬭崯ሱ猳䐵儷帹᰻༽怿́❃╅ⵇ⑉㡋湍慏", 0), StyleIdentifier.MediumGrid1Accent1, BookmarkStart.b("欥䴧丩䔫嬭崯ሱ猳䐵儷帹᰻༽怿́❃╅ⵇ⑉㡋湍扏", 0), StyleIdentifier.MediumGrid1Accent2, 
            BookmarkStart.b("欥䴧丩䔫嬭崯ሱ猳䐵儷帹᰻༽怿́❃╅ⵇ⑉㡋湍捏", 0), StyleIdentifier.MediumGrid1Accent3, BookmarkStart.b("欥䴧丩䔫嬭崯ሱ猳䐵儷帹᰻༽怿́❃╅ⵇ⑉㡋湍摏", 0), StyleIdentifier.MediumGrid1Accent4, BookmarkStart.b("欥䴧丩䔫嬭崯ሱ猳䐵儷帹᰻༽怿́❃╅ⵇ⑉㡋湍敏", 0), StyleIdentifier.MediumGrid1Accent5, BookmarkStart.b("欥䴧丩䔫嬭崯ሱ猳䐵儷帹᰻༽怿́❃╅ⵇ⑉㡋湍晏", 0), StyleIdentifier.MediumGrid1Accent6, BookmarkStart.b("欥䴧丩䔫嬭崯ሱ猳䐵儷帹᰻ఽ", 0), StyleIdentifier.MediumGrid2, BookmarkStart.b("欥䴧丩䔫嬭崯ሱ猳䐵儷帹᰻ఽ怿́❃╅ⵇ⑉㡋湍慏", 0), StyleIdentifier.MediumGrid2Accent1, BookmarkStart.b("欥䴧丩䔫嬭崯ሱ猳䐵儷帹᰻ఽ怿́❃╅ⵇ⑉㡋湍扏", 0), StyleIdentifier.MediumGrid2Accent2, BookmarkStart.b("欥䴧丩䔫嬭崯ሱ猳䐵儷帹᰻ఽ怿́❃╅ⵇ⑉㡋湍捏", 0), StyleIdentifier.MediumGrid2Accent3, 
            BookmarkStart.b("欥䴧丩䔫嬭崯ሱ猳䐵儷帹᰻ఽ怿́❃╅ⵇ⑉㡋湍摏", 0), StyleIdentifier.MediumGrid2Accent4, BookmarkStart.b("欥䴧丩䔫嬭崯ሱ猳䐵儷帹᰻ఽ怿́❃╅ⵇ⑉㡋湍敏", 0), StyleIdentifier.MediumGrid2Accent5, BookmarkStart.b("欥䴧丩䔫嬭崯ሱ猳䐵儷帹᰻ఽ怿́❃╅ⵇ⑉㡋湍晏", 0), StyleIdentifier.MediumGrid2Accent6, BookmarkStart.b("欥䴧丩䔫嬭崯ሱ猳䐵儷帹᰻ഽ", 0), StyleIdentifier.MediumGrid3, BookmarkStart.b("欥䴧丩䔫嬭崯ሱ猳䐵儷帹᰻ഽ怿́❃╅ⵇ⑉㡋湍慏", 0), StyleIdentifier.MediumGrid3Accent1, BookmarkStart.b("欥䴧丩䔫嬭崯ሱ猳䐵儷帹᰻ഽ怿́❃╅ⵇ⑉㡋湍扏", 0), StyleIdentifier.MediumGrid3Accent2, BookmarkStart.b("欥䴧丩䔫嬭崯ሱ猳䐵儷帹᰻ഽ怿́❃╅ⵇ⑉㡋湍捏", 0), StyleIdentifier.MediumGrid3Accent3, BookmarkStart.b("欥䴧丩䔫嬭崯ሱ猳䐵儷帹᰻ഽ怿́❃╅ⵇ⑉㡋湍摏", 0), StyleIdentifier.MediumGrid3Accent4, 
            BookmarkStart.b("欥䴧丩䔫嬭崯ሱ猳䐵儷帹᰻ഽ怿́❃╅ⵇ⑉㡋湍敏", 0), StyleIdentifier.MediumGrid3Accent5, BookmarkStart.b("欥䴧丩䔫嬭崯ሱ猳䐵儷帹᰻ഽ怿́❃╅ⵇ⑉㡋湍晏", 0), StyleIdentifier.MediumGrid3Accent6, BookmarkStart.b("欥䴧丩䔫嬭崯ሱ砳張䬷丹᰻༽", 0), StyleIdentifier.MediumList1, BookmarkStart.b("欥䴧丩䔫嬭崯ሱ砳張䬷丹᰻༽怿́❃╅ⵇ⑉㡋湍慏", 0), StyleIdentifier.MediumList1Accent1, BookmarkStart.b("欥䴧丩䔫嬭崯ሱ砳張䬷丹᰻༽怿́❃╅ⵇ⑉㡋湍扏", 0), StyleIdentifier.MediumList1Accent2, BookmarkStart.b("欥䴧丩䔫嬭崯ሱ砳張䬷丹᰻༽怿́❃╅ⵇ⑉㡋湍捏", 0), StyleIdentifier.MediumList1Accent3, BookmarkStart.b("欥䴧丩䔫嬭崯ሱ砳張䬷丹᰻༽怿́❃╅ⵇ⑉㡋湍摏", 0), StyleIdentifier.MediumList1Accent4, BookmarkStart.b("欥䴧丩䔫嬭崯ሱ砳張䬷丹᰻༽怿́❃╅ⵇ⑉㡋湍敏", 0), StyleIdentifier.MediumList1Accent5, 
            BookmarkStart.b("欥䴧丩䔫嬭崯ሱ砳張䬷丹᰻༽怿́❃╅ⵇ⑉㡋湍晏", 0), StyleIdentifier.MediumList1Accent6, BookmarkStart.b("欥䴧丩䔫嬭崯ሱ砳張䬷丹᰻ఽ", 0), StyleIdentifier.MediumList2, BookmarkStart.b("欥䴧丩䔫嬭崯ሱ砳張䬷丹᰻ఽ怿́❃╅ⵇ⑉㡋湍慏", 0), StyleIdentifier.MediumList2Accent1, BookmarkStart.b("欥䴧丩䔫嬭崯ሱ砳張䬷丹᰻ఽ怿́❃╅ⵇ⑉㡋湍扏", 0), StyleIdentifier.MediumList2Accent2, BookmarkStart.b("欥䴧丩䔫嬭崯ሱ砳張䬷丹᰻ఽ怿́❃╅ⵇ⑉㡋湍捏", 0), StyleIdentifier.MediumList2Accent3, BookmarkStart.b("欥䴧丩䔫嬭崯ሱ砳張䬷丹᰻ఽ怿́❃╅ⵇ⑉㡋湍摏", 0), StyleIdentifier.MediumList2Accent4, BookmarkStart.b("欥䴧丩䔫嬭崯ሱ砳張䬷丹᰻ఽ怿́❃╅ⵇ⑉㡋湍敏", 0), StyleIdentifier.MediumList2Accent5, BookmarkStart.b("欥䴧丩䔫嬭崯ሱ砳張䬷丹᰻ఽ怿́❃╅ⵇ⑉㡋湍晏", 0), StyleIdentifier.MediumList2Accent6, 
            BookmarkStart.b("欥䴧丩䔫嬭崯ሱ朳帵夷帹唻倽✿扁畃", 0), StyleIdentifier.MediumShading1, BookmarkStart.b("欥䴧丩䔫嬭崯ሱ朳帵夷帹唻倽✿扁畃晅े⥉⽋⭍㹏♑瑓杕", 0), StyleIdentifier.MediumShading1Accent1, BookmarkStart.b("欥䴧丩䔫嬭崯ሱ朳帵夷帹唻倽✿扁畃晅े⥉⽋⭍㹏♑瑓摕", 0), StyleIdentifier.MediumShading1Accent2, BookmarkStart.b("欥䴧丩䔫嬭崯ሱ朳帵夷帹唻倽✿扁畃晅े⥉⽋⭍㹏♑瑓敕", 0), StyleIdentifier.MediumShading1Accent3, BookmarkStart.b("欥䴧丩䔫嬭崯ሱ朳帵夷帹唻倽✿扁畃晅े⥉⽋⭍㹏♑瑓払", 0), StyleIdentifier.MediumShading1Accent4, BookmarkStart.b("欥䴧丩䔫嬭崯ሱ朳帵夷帹唻倽✿扁畃晅े⥉⽋⭍㹏♑瑓捕", 0), StyleIdentifier.MediumShading1Accent5, BookmarkStart.b("欥䴧丩䔫嬭崯ሱ朳帵夷帹唻倽✿扁畃晅े⥉⽋⭍㹏♑瑓恕", 0), StyleIdentifier.MediumShading1Accent6, BookmarkStart.b("欥䴧丩䔫嬭崯ሱ朳帵夷帹唻倽✿扁癃", 0), StyleIdentifier.MediumShading2, 
            BookmarkStart.b("欥䴧丩䔫嬭崯ሱ朳帵夷帹唻倽✿扁癃晅े⥉⽋⭍㹏♑瑓杕", 0), StyleIdentifier.MediumShading2Accent1, BookmarkStart.b("欥䴧丩䔫嬭崯ሱ朳帵夷帹唻倽✿扁癃晅े⥉⽋⭍㹏♑瑓摕", 0), StyleIdentifier.MediumShading2Accent2, BookmarkStart.b("欥䴧丩䔫嬭崯ሱ朳帵夷帹唻倽✿扁癃晅े⥉⽋⭍㹏♑瑓敕", 0), StyleIdentifier.MediumShading2Accent3, BookmarkStart.b("欥䴧丩䔫嬭崯ሱ朳帵夷帹唻倽✿扁癃晅े⥉⽋⭍㹏♑瑓払", 0), StyleIdentifier.MediumShading2Accent4, BookmarkStart.b("欥䴧丩䔫嬭崯ሱ朳帵夷帹唻倽✿扁癃晅े⥉⽋⭍㹏♑瑓捕", 0), StyleIdentifier.MediumShading2Accent5, BookmarkStart.b("欥䴧丩䔫嬭崯ሱ朳帵夷帹唻倽✿扁癃晅े⥉⽋⭍㹏♑瑓恕", 0), StyleIdentifier.MediumShading2Accent6, BookmarkStart.b("爥䤧䠩䀫䬭ုı瀳ᘵ崷尹娻嬽⌿㙁㝃晅祇", 0), StyleIdentifier.Table3DEffects1, BookmarkStart.b("爥䤧䠩䀫䬭ုı瀳ᘵ崷尹娻嬽⌿㙁㝃晅穇", 0), StyleIdentifier.Table3DEffects2, 
            BookmarkStart.b("爥䤧䠩䀫䬭ုı瀳ᘵ崷尹娻嬽⌿㙁㝃晅筇", 0), StyleIdentifier.Table3DEffects3, BookmarkStart.b("爥䤧䠩䀫䬭ု焱堳圵䬷䤹唻崽怿獁", 0), StyleIdentifier.TableClassic1, BookmarkStart.b("爥䤧䠩䀫䬭ု焱堳圵䬷䤹唻崽怿灁", 0), StyleIdentifier.TableClassic2, BookmarkStart.b("爥䤧䠩䀫䬭ု焱堳圵䬷䤹唻崽怿煁", 0), StyleIdentifier.TableClassic3, BookmarkStart.b("爥䤧䠩䀫䬭ု焱堳圵䬷䤹唻崽怿癁", 0), StyleIdentifier.TableClassic4, BookmarkStart.b("爥䤧䠩䀫䬭ု焱嬳娵圷䠹娻䬽ⰿ扁畃", 0), StyleIdentifier.TableColorful1, BookmarkStart.b("爥䤧䠩䀫䬭ု焱嬳娵圷䠹娻䬽ⰿ扁癃", 0), StyleIdentifier.TableColorful2, BookmarkStart.b("爥䤧䠩䀫䬭ု焱嬳娵圷䠹娻䬽ⰿ扁睃", 0), StyleIdentifier.TableColorful3, 
            BookmarkStart.b("爥䤧䠩䀫䬭ု焱嬳娵䴷圹刻䴽怿獁", 0), StyleIdentifier.TableColumns1, BookmarkStart.b("爥䤧䠩䀫䬭ု焱嬳娵䴷圹刻䴽怿灁", 0), StyleIdentifier.TableColumns2, BookmarkStart.b("爥䤧䠩䀫䬭ု焱嬳娵䴷圹刻䴽怿煁", 0), StyleIdentifier.TableColumns3, BookmarkStart.b("爥䤧䠩䀫䬭ု焱嬳娵䴷圹刻䴽怿癁", 0), StyleIdentifier.TableColumns4, BookmarkStart.b("爥䤧䠩䀫䬭ု焱嬳娵䴷圹刻䴽怿睁", 0), StyleIdentifier.TableColumns5, BookmarkStart.b("爥䤧䠩䀫䬭ု焱嬳堵䰷弹儻丽⼿ぁ╃㑅ㅇ", 0), StyleIdentifier.TableContemporary, BookmarkStart.b("爥䤧䠩䀫䬭ု眱堳匵強嬹刻䨽", 0), StyleIdentifier.TableElegant, BookmarkStart.b("爥䤧䠩䀫䬭ု由䘳張尷", 0), StyleIdentifier.TableGrid, 
            BookmarkStart.b("爥䤧䠩䀫䬭ု由䘳張尷ᨹ഻", 0), StyleIdentifier.TableGrid1, BookmarkStart.b("爥䤧䠩䀫䬭ု由䘳張尷ᨹ฻", 0), StyleIdentifier.TableGrid2, BookmarkStart.b("爥䤧䠩䀫䬭ု由䘳張尷ᨹ༻", 0), StyleIdentifier.TableGrid3, BookmarkStart.b("爥䤧䠩䀫䬭ု由䘳張尷ᨹ࠻", 0), StyleIdentifier.TableGrid4, BookmarkStart.b("爥䤧䠩䀫䬭ု由䘳張尷ᨹऻ", 0), StyleIdentifier.TableGrid5, BookmarkStart.b("爥䤧䠩䀫䬭ု由䘳張尷ᨹ਻", 0), StyleIdentifier.TableGrid6, BookmarkStart.b("爥䤧䠩䀫䬭ု由䘳張尷ᨹ଻", 0), StyleIdentifier.TableGrid7, BookmarkStart.b("爥䤧䠩䀫䬭ု由䘳張尷ᨹл", 0), StyleIdentifier.TableGrid8, 
            BookmarkStart.b("爥䤧䠩䀫䬭ု縱崳䔵䰷ᨹ഻", 0), StyleIdentifier.TableList1, BookmarkStart.b("爥䤧䠩䀫䬭ု縱崳䔵䰷ᨹ฻", 0), StyleIdentifier.TableList2, BookmarkStart.b("爥䤧䠩䀫䬭ု縱崳䔵䰷ᨹ༻", 0), StyleIdentifier.TableList3, BookmarkStart.b("爥䤧䠩䀫䬭ု縱崳䔵䰷ᨹ࠻", 0), StyleIdentifier.TableList4, BookmarkStart.b("爥䤧䠩䀫䬭ု縱崳䔵䰷ᨹऻ", 0), StyleIdentifier.TableList5, BookmarkStart.b("爥䤧䠩䀫䬭ု縱崳䔵䰷ᨹ਻", 0), StyleIdentifier.TableList6, BookmarkStart.b("爥䤧䠩䀫䬭ု縱崳䔵䰷ᨹ଻", 0), StyleIdentifier.TableList7, BookmarkStart.b("爥䤧䠩䀫䬭ု縱崳䔵䰷ᨹл", 0), StyleIdentifier.TableList8, 
            BookmarkStart.b("栥䜧堩䄫伭尯ሱ怳圵娷嘹夻", 0), StyleIdentifier.TableNormal, BookmarkStart.b("爥䤧䠩䀫䬭ု戱䘳夵帷弹伻䴽⤿ⵁ⩃❅⑇", 0), StyleIdentifier.TableProfessional, BookmarkStart.b("爥䤧䠩䀫䬭ု愱崳嬵䠷嘹夻ḽ焿", 0), StyleIdentifier.TableSimple1, BookmarkStart.b("爥䤧䠩䀫䬭ု愱崳嬵䠷嘹夻ḽ爿", 0), StyleIdentifier.TableSimple2, BookmarkStart.b("爥䤧䠩䀫䬭ု愱崳嬵䠷嘹夻ḽ猿", 0), StyleIdentifier.TableSimple3, BookmarkStart.b("爥䤧䠩䀫䬭ု愱䄳吵䰷嘹夻ḽ焿", 0), StyleIdentifier.TableSubtle1, BookmarkStart.b("爥䤧䠩䀫䬭ု愱䄳吵䰷嘹夻ḽ爿", 0), StyleIdentifier.TableSubtle2, BookmarkStart.b("爥䤧䠩䀫䬭ု昱尳匵唷弹", 0), StyleIdentifier.TableTheme, 
            BookmarkStart.b("爥䤧䠩䀫䬭ု攱儳吵ᠷହ", 0), StyleIdentifier.TableWeb1, BookmarkStart.b("爥䤧䠩䀫䬭ု攱儳吵ᠷ࠹", 0), StyleIdentifier.TableWeb2, BookmarkStart.b("爥䤧䠩䀫䬭ု攱儳吵ᠷह", 0), StyleIdentifier.TableWeb3
         }, hashtable_14, hashtable_15);
        Class791.smethod_0(new object[] { 
            BookmarkStart.b("䜥䘧䐩䌫娭儯䘱崳夵嘷ᨹ主嬽☿❁㙃⍅♇⥉⥋", 0), BookmarkStart.b("攥䜧䜩䄫䬭帯䘱ᐳ搵崷尹夻䰽┿ⱁ❃⍅", 0), BookmarkStart.b("䌥䘧丩䈫䄭䐯圱ᐳ䐵崷尹夻䰽┿ⱁ❃⍅", 0), BookmarkStart.b("挥䘧丩䈫䄭䐯圱ᐳ搵崷尹夻䰽┿ⱁ❃⍅", 0), BookmarkStart.b("䀥䜧䔩堫䀭弯䘱儳ᘵ䨷弹娻嬽㈿❁⩃╅ⵇ", 0), BookmarkStart.b("急䜧䔩堫䀭弯䘱儳ᘵ樷弹娻嬽㈿❁⩃╅ⵇ", 0), BookmarkStart.b("䨥䄧䐩䤫อ帯䜱夳吵崷䠹", 0), BookmarkStart.b("樥䄧䐩䤫อ縯䜱夳吵崷䠹", 0), BookmarkStart.b("嘥䤧䴩䤫อ帯䜱夳吵崷䠹", 0), BookmarkStart.b("瘥䤧䴩䤫อ縯䜱夳吵崷䠹", 0), BookmarkStart.b("䜥䘧䐩䌫娭儯䘱崳夵嘷ᨹ伻䬽∿⡁⅃╅㱇", 0), BookmarkStart.b("攥䜧䜩䄫䬭帯䘱ᐳ攵䴷堹嘻嬽⌿㙁", 0), BookmarkStart.b("䜥䘧䐩䌫娭儯䘱崳夵嘷ᨹ䠻嬽㠿㙁", 0), BookmarkStart.b("攥䜧䜩䄫䬭帯䘱ᐳ戵崷䈹䠻", 0), BookmarkStart.b("䔥䤧娩堫䜭弯就", 0), BookmarkStart.b("攥䤧娩堫䜭弯就", 0), 
            BookmarkStart.b("䌥䘧丩䈫䄭䐯圱ᐳ䈵崷䈹䠻", 0), BookmarkStart.b("挥䘧丩䈫䄭䐯圱ᐳ戵崷䈹䠻", 0), BookmarkStart.b("䌥䘧尩䤫䈭弯䈱儳ᘵ夷帹堻䰽┿ㅁ㝃", 0), BookmarkStart.b("挥䘧尩䤫䈭弯䈱儳ᘵ礷帹堻䰽┿ㅁ㝃", 0), BookmarkStart.b("䌥䘧尩䤫䈭弯䈱儳ᘵ䨷弹䠻䬽㈿ⱁ", 0), BookmarkStart.b("挥䘧尩䤫䈭弯䈱儳ᘵ樷弹䠻䬽㈿ⱁ", 0), BookmarkStart.b("䀥䜧䔩堫䬭䈯", 0), BookmarkStart.b("急䜧䔩堫䬭䈯", 0), BookmarkStart.b("䀥䜧䔩堫䀭弯䘱儳ᘵ䰷弹䐻䨽", 0), BookmarkStart.b("急䜧䔩堫䀭弯䘱儳ᘵ氷弹䐻䨽", 0), BookmarkStart.b("严䴧䬩䠫䬭䈯", 0), BookmarkStart.b("渥䴧䬩䠫䬭䈯", 0), BookmarkStart.b("严䴧䬩䠫䜭帯唱ᐳܵ", 0), BookmarkStart.b("渥䴧䬩䠫䜭帯唱ᐳܵ", 0), BookmarkStart.b("严䴧䬩䠫䜭帯唱ᐳе", 0), BookmarkStart.b("渥䴧䬩䠫䜭帯唱ᐳе", 0), 
            BookmarkStart.b("严䴧䬩䠫䜭帯唱ᐳԵ", 0), BookmarkStart.b("渥䴧䬩䠫䜭帯唱ᐳԵ", 0), BookmarkStart.b("严䴧䬩䠫䜭帯唱ᐳȵ", 0), BookmarkStart.b("渥䴧䬩䠫䜭帯唱ᐳȵ", 0), BookmarkStart.b("严䴧䬩䠫䜭帯唱ᐳ̵", 0), BookmarkStart.b("渥䴧䬩䠫䜭帯唱ᐳ̵", 0), BookmarkStart.b("严䴧䬩䠫䜭帯唱ᐳ5", 0), BookmarkStart.b("渥䴧䬩䠫䜭帯唱ᐳ5", 0), BookmarkStart.b("严䴧䬩䠫䜭帯唱ᐳĵ", 0), BookmarkStart.b("渥䴧䬩䠫䜭帯唱ᐳĵ", 0), BookmarkStart.b("严䴧䬩䠫䜭帯唱ᐳี", 0), BookmarkStart.b("渥䴧䬩䠫䜭帯唱ᐳี", 0), BookmarkStart.b("严䴧䬩䠫䜭帯唱ᐳ༵", 0), BookmarkStart.b("渥䴧䬩䠫䜭帯唱ᐳ༵", 0), BookmarkStart.b("伥䘧丩䤫嘭ု̱", 0), BookmarkStart.b("漥䘧丩䤫嘭ု̱", 0), 
            BookmarkStart.b("伥䘧丩䤫嘭ု1", 0), BookmarkStart.b("漥䘧丩䤫嘭ု1", 0), BookmarkStart.b("伥䘧丩䤫嘭ုı", 0), BookmarkStart.b("漥䘧丩䤫嘭ုı", 0), BookmarkStart.b("伥䘧丩䤫嘭ုر", 0), BookmarkStart.b("漥䘧丩䤫嘭ုر", 0), BookmarkStart.b("伥䘧丩䤫嘭ုܱ", 0), BookmarkStart.b("漥䘧丩䤫嘭ုܱ", 0), BookmarkStart.b("伥䘧丩䤫嘭ုб", 0), BookmarkStart.b("漥䘧丩䤫嘭ုб", 0), BookmarkStart.b("伥䘧丩䤫嘭ုԱ", 0), BookmarkStart.b("漥䘧丩䤫嘭ုԱ", 0), BookmarkStart.b("伥䘧丩䤫嘭ု਱", 0), BookmarkStart.b("漥䘧丩䤫嘭ု਱", 0), BookmarkStart.b("伥䘧丩䤫嘭ု଱", 0), BookmarkStart.b("漥䘧丩䤫嘭ု଱", 0), 
            BookmarkStart.b("伥䘧丩䤫嘭ု娱儳圵尷匹刻夽", 0), BookmarkStart.b("漥䘧丩䤫嘭ု稱儳圵尷匹刻夽", 0), BookmarkStart.b("䬥䤧䤩師䄭", 0), BookmarkStart.b("欥䤧䤩師䄭", 0), BookmarkStart.b("䠥䜧帩䤫อ堯圱唳刵儷吹嬻", 0), BookmarkStart.b("栥䜧帩䤫อ砯圱唳刵儷吹嬻", 0), BookmarkStart.b("別䤧䠩䀫䬭ု崱刳ᘵ夷伹䠻嘽⼿ぁⵃ㉅ⅇ⽉㽋", 0), BookmarkStart.b("爥䤧䠩䀫䬭ု崱刳ᘵ礷伹䠻嘽⼿ぁⵃ㉅ⅇ⽉㽋", 0), BookmarkStart.b("別䤧䠩䀫䬭ု崱刳ᘵ帷匹嬻䬽㈿❁㝃", 0), BookmarkStart.b("爥䤧䠩䀫䬭ု崱刳ᘵ縷匹嬻䬽㈿❁㝃", 0), BookmarkStart.b("別䜧䬩ఫ䘭唯匱倳張嘷崹", 0), BookmarkStart.b("爥朧欩ఫ昭唯匱倳張嘷崹", 0), BookmarkStart.b("別䜧䤩ఫἭ", 0), BookmarkStart.b("爥朧椩ఫἭ", 0), BookmarkStart.b("別䜧䤩ఫᰭ", 0), BookmarkStart.b("爥朧椩ఫᰭ", 0), 
            BookmarkStart.b("別䜧䤩ఫᴭ", 0), BookmarkStart.b("爥朧椩ఫᴭ", 0), BookmarkStart.b("別䜧䤩ఫᨭ", 0), BookmarkStart.b("爥朧椩ఫᨭ", 0), BookmarkStart.b("別䜧䤩ఫᬭ", 0), BookmarkStart.b("爥朧椩ఫᬭ", 0), BookmarkStart.b("別䜧䤩ఫᠭ", 0), BookmarkStart.b("爥朧椩ఫᠭ", 0), BookmarkStart.b("別䜧䤩ఫ᤭", 0), BookmarkStart.b("爥朧椩ఫ᤭", 0), BookmarkStart.b("別䜧䤩ఫᘭ", 0), BookmarkStart.b("爥朧椩ఫᘭ", 0), BookmarkStart.b("別䜧䤩ఫᜭ", 0), BookmarkStart.b("爥朧椩ఫᜭ", 0), BookmarkStart.b("椥崧帩䀫䜭帯圱ᐳ稵儷䤹䠻ḽ焿", 0), BookmarkStart.b("ᜥࠧԩఫ伭ုᴱᐳ張", 0), 
            BookmarkStart.b("椥崧帩䀫䜭帯圱ᐳ稵儷䤹䠻ḽ爿", 0), BookmarkStart.b("ᜥࠧԩఫἭḯ̱ᐳᤵᠷହሻ༽渿獁", 0), BookmarkStart.b("椥崧帩䀫䜭帯圱ᐳ稵儷䤹䠻ḽ猿", 0), BookmarkStart.b("朥娧帩䔫䴭尯圱ᐳᤵᠷ椹夻崽㐿⭁⭃⡅", 0), BookmarkStart.b("栥䜧堩䄫伭尯ሱ怳圵娷嘹夻", 0), BookmarkStart.b("爥䤧䠩䀫䬭ု簱嬳䐵唷嬹倻", 0)
         }, hashtable_16, hashtable_17);
        Class791.smethod_0(new object[] { 
            BookmarkStart.b("ᜥᠧᠩᠫ嘭ܯбళ", 0), ScreenSize.Size1024x768, BookmarkStart.b("ᜥᤧἩḫ嘭࠯਱س", 0), ScreenSize.Size1152x882, BookmarkStart.b("ᜥᤧἩḫ嘭यȱг", 0), ScreenSize.Size1152x900, BookmarkStart.b("ᜥᨧሩᰫ嘭įȱسȵ", 0), ScreenSize.Size1280x1024, BookmarkStart.b("ᜥḧᨩᰫ嘭į1гص", 0), ScreenSize.Size1600x1200, BookmarkStart.b("ᜥဧᨩᰫ嘭įر3ص", 0), ScreenSize.Size1800x1440, BookmarkStart.b("ᜥᄧᠩᰫ嘭į1гص", 0), ScreenSize.Size1920x1200, BookmarkStart.b("ጥᰧḩ含ᴭܯб", 0), ScreenSize.Size544x376, 
            BookmarkStart.b("ဥᰧᨩ含ᨭ࠯ȱ", 0), ScreenSize.Size640x480, BookmarkStart.b("ᄥᨧᨩ含ᬭį1", 0), ScreenSize.Size720x512, BookmarkStart.b("ḥᠧᨩ含ᠭ/ȱ", 0), ScreenSize.Size800x600
         }, hashtable_18, hashtable_19);
    }

    internal static FramesetBorderType smethod_0(string A_0)
    {
        int num = 5;
        string str = A_0;
        if (str != null)
        {
            if (str == BookmarkStart.b("䴪䄬丮䔰焲娴䔶崸帺似䰾", num))
            {
                return FramesetBorderType.Simple;
            }
            if (str == BookmarkStart.b("䔪䈬洮帰䄲儴制䬸", num))
            {
                return FramesetBorderType.None;
            }
        }
        return FramesetBorderType.Raised;
    }

    internal static string smethod_1(FramesetBorderType A_0)
    {
        int num = 12;
        switch (A_0)
        {
            case FramesetBorderType.None:
                return BookmarkStart.b("就嬳琵圷䠹堻嬽㈿", num);

            case FramesetBorderType.Simple:
                return BookmarkStart.b("吱堳圵䰷砹医䰽␿❁㙃㕅", num);
        }
        return "";
    }

    internal static RelativeWidth smethod_10(string A_0)
    {
        return (RelativeWidth) Class791.smethod_3(hashtable_4, A_0, RelativeWidth.Page);
    }

    internal static string smethod_11(RelativeWidth A_0)
    {
        return (string) Class791.smethod_3(hashtable_5, A_0, "");
    }

    internal static VerticalRelation smethod_12(string A_0)
    {
        return (VerticalRelation) Class791.smethod_3(hashtable_6, A_0, VerticalRelation.Margin);
    }

    internal static RelativeVerticalPosition smethod_13(string A_0, RelativeVerticalPosition A_1)
    {
        return (RelativeVerticalPosition) Class791.smethod_3(hashtable_6, A_0, A_1);
    }

    internal static string smethod_14(VerticalOrigin A_0)
    {
        return (string) Class791.smethod_3(hashtable_7, A_0, "");
    }

    internal static RelativeHorizontalPosition smethod_15(string A_0)
    {
        return (RelativeHorizontalPosition) Class791.smethod_3(hashtable_8, A_0, RelativeHorizontalPosition.Column);
    }

    internal static string smethod_16(HorizontalOrigin A_0)
    {
        return (string) Class791.smethod_3(hashtable_9, A_0, "");
    }

    internal static HorizontalPosition smethod_17(string A_0)
    {
        return (HorizontalPosition) Class791.smethod_3(hashtable_10, A_0, HorizontalPosition.None);
    }

    internal static string smethod_18(HorizontalPosition A_0)
    {
        return (string) Class791.smethod_3(hashtable_11, A_0, "");
    }

    internal static string smethod_19(ShapeHorizontalAlignment A_0)
    {
        return (string) Class791.smethod_3(hashtable_11, A_0, "");
    }

    internal static FrameLayoutType smethod_2(string A_0)
    {
        int num = 7;
        string str = A_0;
        if (str != null)
        {
            if (str == BookmarkStart.b("丬䀮崰䀲", num))
            {
                return FrameLayoutType.Horizontal;
            }
            if (str == BookmarkStart.b("弬䀮䘰䀲", num))
            {
                return FrameLayoutType.Vertical;
            }
        }
        return FrameLayoutType.None;
    }

    internal static VerticalPosition smethod_20(string A_0)
    {
        return (VerticalPosition) Class791.smethod_3(hashtable_12, A_0, VerticalPosition.None);
    }

    internal static HorizontalOrigin smethod_21(HorizontalRelation A_0)
    {
        switch (A_0)
        {
            case HorizontalRelation.Margin:
                return HorizontalOrigin.Margin;

            case HorizontalRelation.Page:
                return HorizontalOrigin.Page;
        }
        return HorizontalOrigin.Column;
    }

    internal static HorizontalRelation smethod_22(RelativeHorizontalPosition A_0)
    {
        switch (A_0)
        {
            case RelativeHorizontalPosition.Margin:
                return HorizontalRelation.Margin;

            case RelativeHorizontalPosition.Page:
                return HorizontalRelation.Page;
        }
        return HorizontalRelation.Column;
    }

    internal static string smethod_23(VerticalPosition A_0)
    {
        return (string) Class791.smethod_3(hashtable_13, A_0, "");
    }

    internal static string smethod_24(ShapeVerticalAlignment A_0)
    {
        return (string) Class791.smethod_3(hashtable_13, A_0, "");
    }

    internal static StyleIdentifier smethod_25(string A_0)
    {
        return (StyleIdentifier) Class791.smethod_3(hashtable_14, A_0, StyleIdentifier.User);
    }

    internal static string smethod_26(StyleIdentifier A_0, string A_1)
    {
        return (string) Class791.smethod_3(hashtable_15, A_0, A_1);
    }

    internal static string smethod_27(string A_0)
    {
        return (string) Class791.smethod_3(hashtable_16, A_0, A_0);
    }

    internal static string smethod_28(string A_0)
    {
        return (string) Class791.smethod_3(hashtable_17, A_0, A_0);
    }

    internal static ScreenSize smethod_29(string A_0)
    {
        return (ScreenSize) Class791.smethod_3(hashtable_18, A_0, ScreenSize.Size800x600);
    }

    internal static string smethod_3(FrameLayoutType A_0)
    {
        int num = 9;
        switch (A_0)
        {
            case FrameLayoutType.Vertical:
                return BookmarkStart.b("崮帰䐲䘴", num);

            case FrameLayoutType.Horizontal:
                return BookmarkStart.b("䰮帰弲䘴", num);
        }
        return "";
    }

    internal static string smethod_30(ScreenSize A_0)
    {
        return (string) Class791.smethod_3(hashtable_19, A_0, "");
    }

    internal static FtsWidth smethod_31(string A_0)
    {
        int num = 8;
        string str = A_0;
        if (str != null)
        {
            if (str == BookmarkStart.b("席匯䘱", num))
            {
                return FtsWidth.Percentage;
            }
            if (str == BookmarkStart.b("䨭䠯匱", num))
            {
                return FtsWidth.Point;
            }
            if (str == BookmarkStart.b("伭䔯䘱嬳", num))
            {
                return FtsWidth.Auto;
            }
        }
        return FtsWidth.Auto;
    }

    internal static WidthType smethod_32(string A_0)
    {
        int num = 0;
        string str = A_0;
        if (str != null)
        {
            if (str == BookmarkStart.b("嘥䬧帩", num))
            {
                return WidthType.Percentage;
            }
            if (str == BookmarkStart.b("䈥倧䬩", num))
            {
                return WidthType.Twip;
            }
            if (str == BookmarkStart.b("䜥崧帩䌫", num))
            {
                return WidthType.Auto;
            }
        }
        return WidthType.Auto;
    }

    internal static string smethod_33(FtsWidth A_0)
    {
        int num = 10;
        switch (A_0)
        {
            case FtsWidth.Auto:
                return BookmarkStart.b("儯䜱䀳夵", num);

            case FtsWidth.Percentage:
                return BookmarkStart.b("䀯儱䀳", num);

            case FtsWidth.Point:
                return BookmarkStart.b("启䨱唳", num);
        }
        return "";
    }

    internal static TextureStyle smethod_34(string A_0)
    {
        int num = 11;
        string key = A_0;
        if (key != null)
        {
            int num2;
            if (Class1160.dictionary_31 == null)
            {
                Dictionary<string, int> dictionary1 = new Dictionary<string, int>(0x49);
                dictionary1.Add(BookmarkStart.b("到弲倴嘶䬸", num), 0);
                dictionary1.Add(BookmarkStart.b("弰娲头", num), 1);
                dictionary1.Add(BookmarkStart.b("䈰尲头帶崸", num), 2);
                dictionary1.Add(BookmarkStart.b("夰尲䜴䴶樸伺似嘾ㅀ♂", num), 3);
                dictionary1.Add(BookmarkStart.b("夰尲䜴䴶ᐸ䠺䤼䴾⡀㍂⁄", num), 4);
                dictionary1.Add(BookmarkStart.b("䜰嘲䜴䌶樸伺似嘾ㅀ♂", num), 5);
                dictionary1.Add(BookmarkStart.b("䜰嘲䜴䌶ᐸ䠺䤼䴾⡀㍂⁄", num), 6);
                dictionary1.Add(BookmarkStart.b("䌰嘲䌴制䬸䠺堼笾⡀≂≄ᑆ㵈㥊⑌㽎㑐", num), 7);
                dictionary1.Add(BookmarkStart.b("䌰嘲䌴制䬸䠺堼ሾ╀⩂⑄⁆摈㡊㥌㵎㡐⍒ご", num), 8);
                dictionary1.Add(BookmarkStart.b("唰娲吴倶樸伺似嘾ㅀ♂", num), 9);
                dictionary1.Add(BookmarkStart.b("唰娲吴倶ᐸ䠺䤼䴾⡀㍂⁄", num), 10);
                dictionary1.Add(BookmarkStart.b("夰尲䜴䴶稸䤺刼䰾㉀", num), 11);
                dictionary1.Add(BookmarkStart.b("夰尲䜴䴶ᐸ堺似倾㉀あ", num), 12);
                dictionary1.Add(BookmarkStart.b("唰娲吴倶稸䤺刼䰾㉀", num), 13);
                dictionary1.Add(BookmarkStart.b("唰娲吴倶ᐸ堺似倾㉀あ", num), 14);
                dictionary1.Add(BookmarkStart.b("䔰嬲尴夶焸吺似䔾ቀ㝂㝄⹆㥈⹊", num), 15);
                dictionary1.Add(BookmarkStart.b("䔰嬲尴夶ᐸ区刼䴾㭀湂㙄㍆㭈≊㵌⩎", num), 0x10);
                dictionary1.Add(BookmarkStart.b("䔰嬲尴夶漸帺似䬾ቀ㝂㝄⹆㥈⹊", num), 0x11);
                dictionary1.Add(BookmarkStart.b("䔰嬲尴夶ᐸ䴺堼䴾㕀湂㙄㍆㭈≊㵌⩎", num), 0x12);
                dictionary1.Add(BookmarkStart.b("䔰嬲尴夶欸帺䬼娾㍀あ⁄͆⁈⩊⩌ᱎ═⅒㱔❖㱘", num), 0x13);
                dictionary1.Add(BookmarkStart.b("䔰嬲尴夶ᐸ䤺堼䤾⑀ㅂ㙄≆摈⽊⑌⹎㙐繒♔⍖⭘㉚ⵜ㩞", num), 20);
                dictionary1.Add(BookmarkStart.b("䔰嬲尴夶紸刺尼堾ቀ㝂㝄⹆㥈⹊", num), 0x15);
                dictionary1.Add(BookmarkStart.b("䔰嬲尴夶ᐸ强吼帾♀湂㙄㍆㭈≊㵌⩎", num), 0x16);
                dictionary1.Add(BookmarkStart.b("䔰嬲尴夶焸吺似䔾ɀㅂ⩄㑆㩈", num), 0x17);
                dictionary1.Add(BookmarkStart.b("䔰嬲尴夶ᐸ区刼䴾㭀湂♄㕆♈㡊㹌", num), 0x18);
                dictionary1.Add(BookmarkStart.b("䔰嬲尴夶紸刺尼堾ɀㅂ⩄㑆㩈", num), 0x19);
                dictionary1.Add(BookmarkStart.b("䔰嬲尴夶ᐸ强吼帾♀湂♄㕆♈㡊㹌", num), 0x1a);
                dictionary1.Add(BookmarkStart.b("䄰倲䄴ȶ", num), 0x1b);
                dictionary1.Add(BookmarkStart.b("䄰倲䄴ᨶస", num), 0x1c);
                dictionary1.Add(BookmarkStart.b("䄰倲䄴ضस", num), 0x1d);
                dictionary1.Add(BookmarkStart.b("䄰倲䄴ᨶ࠸଺", num), 30);
                dictionary1.Add(BookmarkStart.b("䄰倲䄴ضସ", num), 0x1f);
                dictionary1.Add(BookmarkStart.b("䄰倲䄴ᨶ࠸ऺ", num), 0x20);
                dictionary1.Add(BookmarkStart.b("䄰倲䄴ضస", num), 0x21);
                dictionary1.Add(BookmarkStart.b("䄰倲䄴ᨶ࠸ฺ", num), 0x22);
                dictionary1.Add(BookmarkStart.b("䄰倲䄴Զस", num), 0x23);
                dictionary1.Add(BookmarkStart.b("䄰倲䄴ᨶସ଺", num), 0x24);
                dictionary1.Add(BookmarkStart.b("䄰倲䄴Զస", num), 0x25);
                dictionary1.Add(BookmarkStart.b("䄰倲䄴ᨶସฺ", num), 0x26);
                dictionary1.Add(BookmarkStart.b("䄰倲䄴жस", num), 0x27);
                dictionary1.Add(BookmarkStart.b("䄰倲䄴ᨶਸ଺", num), 40);
                dictionary1.Add(BookmarkStart.b("䄰倲䄴жస", num), 0x29);
                dictionary1.Add(BookmarkStart.b("䄰倲䄴ᨶਸฺ", num), 0x2a);
                dictionary1.Add(BookmarkStart.b("䄰倲䄴жุ", num), 0x2b);
                dictionary1.Add(BookmarkStart.b("䄰倲䄴ᨶਸ఺", num), 0x2c);
                dictionary1.Add(BookmarkStart.b("䄰倲䄴̶स", num), 0x2d);
                dictionary1.Add(BookmarkStart.b("䄰倲䄴ᨶസ଺", num), 0x2e);
                dictionary1.Add(BookmarkStart.b("䄰倲䄴̶స", num), 0x2f);
                dictionary1.Add(BookmarkStart.b("䄰倲䄴ᨶസฺ", num), 0x30);
                dictionary1.Add(BookmarkStart.b("䄰倲䄴ȶस", num), 0x31);
                dictionary1.Add(BookmarkStart.b("䄰倲䄴ᨶస଺", num), 50);
                dictionary1.Add(BookmarkStart.b("䄰倲䄴ȶస", num), 0x33);
                dictionary1.Add(BookmarkStart.b("䄰倲䄴ᨶసฺ", num), 0x34);
                dictionary1.Add(BookmarkStart.b("䄰倲䄴Ķस", num), 0x35);
                dictionary1.Add(BookmarkStart.b("䄰倲䄴ᨶ༸଺", num), 0x36);
                dictionary1.Add(BookmarkStart.b("䄰倲䄴Ķସ", num), 0x37);
                dictionary1.Add(BookmarkStart.b("䄰倲䄴ᨶ༸ऺ", num), 0x38);
                dictionary1.Add(BookmarkStart.b("䄰倲䄴Ķస", num), 0x39);
                dictionary1.Add(BookmarkStart.b("䄰倲䄴ᨶ༸ฺ", num), 0x3a);
                dictionary1.Add(BookmarkStart.b("䄰倲䄴6स", num), 0x3b);
                dictionary1.Add(BookmarkStart.b("䄰倲䄴ᨶุ଺", num), 60);
                dictionary1.Add(BookmarkStart.b("䄰倲䄴6స", num), 0x3d);
                dictionary1.Add(BookmarkStart.b("䄰倲䄴ᨶฺุ", num), 0x3e);
                dictionary1.Add(BookmarkStart.b("䄰倲䄴༶स", num), 0x3f);
                dictionary1.Add(BookmarkStart.b("䄰倲䄴ᨶĸ଺", num), 0x40);
                dictionary1.Add(BookmarkStart.b("䄰倲䄴༶స", num), 0x41);
                dictionary1.Add(BookmarkStart.b("䄰倲䄴ᨶĸฺ", num), 0x42);
                dictionary1.Add(BookmarkStart.b("䄰倲䄴༶ุ", num), 0x43);
                dictionary1.Add(BookmarkStart.b("䄰倲䄴ᨶĸ఺", num), 0x44);
                dictionary1.Add(BookmarkStart.b("䄰倲䄴ึस", num), 0x45);
                dictionary1.Add(BookmarkStart.b("䄰倲䄴ᨶ8଺", num), 70);
                dictionary1.Add(BookmarkStart.b("䄰倲䄴ึస", num), 0x47);
                dictionary1.Add(BookmarkStart.b("䄰倲䄴ᨶ8ฺ", num), 0x48);
                Class1160.dictionary_31 = dictionary1;
            }
            if (Class1160.dictionary_31.TryGetValue(key, out num2))
            {
                switch (num2)
                {
                    case 0:
                        return TextureStyle.TextureNone;

                    case 1:
                        return TextureStyle.TextureNil;

                    case 2:
                        return TextureStyle.TextureSolid;

                    case 3:
                    case 4:
                        return TextureStyle.TextureDarkHorizontal;

                    case 5:
                    case 6:
                        return TextureStyle.TextureDarkVertical;

                    case 7:
                    case 8:
                        return TextureStyle.TextureDarkDiagonalDown;

                    case 9:
                    case 10:
                        return TextureStyle.TextureDarkDiagonalUp;

                    case 11:
                    case 12:
                        return TextureStyle.TextureDarkCross;

                    case 13:
                    case 14:
                        return TextureStyle.TextureDarkDiagonalCross;

                    case 15:
                    case 0x10:
                        return TextureStyle.TextureHorizontal;

                    case 0x11:
                    case 0x12:
                        return TextureStyle.TextureVertical;

                    case 0x13:
                    case 20:
                        return TextureStyle.TextureDiagonalDown;

                    case 0x15:
                    case 0x16:
                        return TextureStyle.TextureDiagonalUp;

                    case 0x17:
                    case 0x18:
                        return TextureStyle.TextureCross;

                    case 0x19:
                    case 0x1a:
                        return TextureStyle.TextureDiagonalCross;

                    case 0x1b:
                    case 0x1c:
                        return TextureStyle.Texture5Percent;

                    case 0x1d:
                    case 30:
                        return TextureStyle.Texture10Percent;

                    case 0x1f:
                    case 0x20:
                        return TextureStyle.Texture12Pt5Percent;

                    case 0x21:
                    case 0x22:
                        return TextureStyle.Texture15Percent;

                    case 0x23:
                    case 0x24:
                        return TextureStyle.Texture20Percent;

                    case 0x25:
                    case 0x26:
                        return TextureStyle.Texture25Percent;

                    case 0x27:
                    case 40:
                        return TextureStyle.Texture30Percent;

                    case 0x29:
                    case 0x2a:
                        return TextureStyle.Texture35Percent;

                    case 0x2b:
                    case 0x2c:
                        return TextureStyle.Texture37Pt5Percent;

                    case 0x2d:
                    case 0x2e:
                        return TextureStyle.Texture40Percent;

                    case 0x2f:
                    case 0x30:
                        return TextureStyle.Texture45Percent;

                    case 0x31:
                    case 50:
                        return TextureStyle.Texture50Percent;

                    case 0x33:
                    case 0x34:
                        return TextureStyle.Texture55Percent;

                    case 0x35:
                    case 0x36:
                        return TextureStyle.Texture60Percent;

                    case 0x37:
                    case 0x38:
                        return TextureStyle.Texture62Pt5Percent;

                    case 0x39:
                    case 0x3a:
                        return TextureStyle.Texture65Percent;

                    case 0x3b:
                    case 60:
                        return TextureStyle.Texture70Percent;

                    case 0x3d:
                    case 0x3e:
                        return TextureStyle.Texture75Percent;

                    case 0x3f:
                    case 0x40:
                        return TextureStyle.Texture80Percent;

                    case 0x41:
                    case 0x42:
                        return TextureStyle.Texture85Percent;

                    case 0x43:
                    case 0x44:
                        return TextureStyle.Texture87Pt5Percent;

                    case 0x45:
                    case 70:
                        return TextureStyle.Texture90Percent;

                    case 0x47:
                    case 0x48:
                        return TextureStyle.Texture95Percent;
                }
            }
        }
        return TextureStyle.TextureNone;
    }

    internal static string smethod_35(TextureStyle A_0, bool A_1)
    {
        int num = 9;
        switch (A_0)
        {
            case TextureStyle.TextureNone:
                return BookmarkStart.b("䰮崰嘲吴䔶", num);

            case TextureStyle.TextureSolid:
                return BookmarkStart.b("尮帰弲尴匶", num);

            case TextureStyle.Texture5Percent:
                if (A_1)
                {
                    return BookmarkStart.b("弮到䜲4", num);
                }
                return BookmarkStart.b("弮到䜲ᠴȶ", num);

            case TextureStyle.Texture10Percent:
                if (A_1)
                {
                    return BookmarkStart.b("弮到䜲дܶ", num);
                }
                return BookmarkStart.b("弮到䜲ᠴضस", num);

            case TextureStyle.Texture20Percent:
                if (A_1)
                {
                    return BookmarkStart.b("弮到䜲ܴܶ", num);
                }
                return BookmarkStart.b("弮到䜲ᠴԶस", num);

            case TextureStyle.Texture25Percent:
                if (A_1)
                {
                    return BookmarkStart.b("弮到䜲ܴȶ", num);
                }
                return BookmarkStart.b("弮到䜲ᠴԶస", num);

            case TextureStyle.Texture30Percent:
                if (A_1)
                {
                    return BookmarkStart.b("弮到䜲شܶ", num);
                }
                return BookmarkStart.b("弮到䜲ᠴжस", num);

            case TextureStyle.Texture40Percent:
                if (A_1)
                {
                    return BookmarkStart.b("弮到䜲Ĵܶ", num);
                }
                return BookmarkStart.b("弮到䜲ᠴ̶स", num);

            case TextureStyle.Texture50Percent:
                if (A_1)
                {
                    return BookmarkStart.b("弮到䜲4ܶ", num);
                }
                return BookmarkStart.b("弮到䜲ᠴȶस", num);

            case TextureStyle.Texture60Percent:
                if (A_1)
                {
                    return BookmarkStart.b("弮到䜲̴ܶ", num);
                }
                return BookmarkStart.b("弮到䜲ᠴĶस", num);

            case TextureStyle.Texture70Percent:
                if (A_1)
                {
                    return BookmarkStart.b("弮到䜲ȴܶ", num);
                }
                return BookmarkStart.b("弮到䜲ᠴ6स", num);

            case TextureStyle.Texture75Percent:
                if (A_1)
                {
                    return BookmarkStart.b("弮到䜲ȴȶ", num);
                }
                return BookmarkStart.b("弮到䜲ᠴ6స", num);

            case TextureStyle.Texture80Percent:
                if (A_1)
                {
                    return BookmarkStart.b("弮到䜲ഴܶ", num);
                }
                return BookmarkStart.b("弮到䜲ᠴ༶स", num);

            case TextureStyle.Texture90Percent:
                if (A_1)
                {
                    return BookmarkStart.b("弮到䜲ఴܶ", num);
                }
                return BookmarkStart.b("弮到䜲ᠴึस", num);

            case TextureStyle.TextureDarkHorizontal:
                if (A_1)
                {
                    return BookmarkStart.b("䜮帰䄲伴搶䴸䤺吼伾⑀", num);
                }
                return BookmarkStart.b("䜮帰䄲伴ᨶ䨸伺似嘾ㅀ♂", num);

            case TextureStyle.TextureDarkVertical:
                if (A_1)
                {
                    return BookmarkStart.b("央吰䄲䄴搶䴸䤺吼伾⑀", num);
                }
                return BookmarkStart.b("央吰䄲䄴ᨶ䨸伺似嘾ㅀ♂", num);

            case TextureStyle.TextureDarkDiagonalDown:
                if (A_1)
                {
                    return BookmarkStart.b("崮吰䔲倴䔶䨸帺礼嘾⁀⑂ᙄ㍆㭈≊㵌⩎", num);
                }
                return BookmarkStart.b("崮吰䔲倴䔶䨸帺ြ嬾⡀≂≄橆㩈㽊㽌♎⅐㙒", num);

            case TextureStyle.TextureDarkDiagonalUp:
                if (A_1)
                {
                    return BookmarkStart.b("䬮堰刲刴搶䴸䤺吼伾⑀", num);
                }
                return BookmarkStart.b("䬮堰刲刴ᨶ䨸伺似嘾ㅀ♂", num);

            case TextureStyle.TextureDarkCross:
                if (A_1)
                {
                    return BookmarkStart.b("䜮帰䄲伴琶䬸吺丼䰾", num);
                }
                return BookmarkStart.b("䜮帰䄲伴ᨶ娸䤺刼䰾㉀", num);

            case TextureStyle.TextureDarkDiagonalCross:
                if (A_1)
                {
                    return BookmarkStart.b("䬮堰刲刴琶䬸吺丼䰾", num);
                }
                return BookmarkStart.b("䬮堰刲刴ᨶ娸䤺刼䰾㉀", num);

            case TextureStyle.TextureHorizontal:
                if (A_1)
                {
                    return BookmarkStart.b("嬮夰娲嬴缶嘸䤺䜼氾㕀ㅂⱄ㝆ⱈ", num);
                }
                return BookmarkStart.b("嬮夰娲嬴ᨶ儸吺似䔾汀あㅄ㕆⁈㭊⡌", num);

            case TextureStyle.TextureVertical:
                if (A_1)
                {
                    return BookmarkStart.b("嬮夰娲嬴愶尸䤺䤼氾㕀ㅂⱄ㝆ⱈ", num);
                }
                return BookmarkStart.b("嬮夰娲嬴ᨶ伸帺似䬾汀あㅄ㕆⁈㭊⡌", num);

            case TextureStyle.TextureDiagonalDown:
                if (A_1)
                {
                    return BookmarkStart.b("嬮夰娲嬴收尸䴺堼䴾㉀♂ń⹆⡈ⱊṌ㭎⍐㩒╔㉖", num);
                }
                return BookmarkStart.b("嬮夰娲嬴ᨶ䬸帺䬼娾㍀あ⁄橆ⵈ≊ⱌ⡎籐⁒⅔╖じ⭚㡜", num);

            case TextureStyle.TextureDiagonalUp:
                if (A_1)
                {
                    return BookmarkStart.b("嬮夰娲嬴猶倸娺娼氾㕀ㅂⱄ㝆ⱈ", num);
                }
                return BookmarkStart.b("嬮夰娲嬴ᨶ崸刺尼堾汀あㅄ㕆⁈㭊⡌", num);

            case TextureStyle.TextureCross:
                if (A_1)
                {
                    return BookmarkStart.b("嬮夰娲嬴缶嘸䤺䜼簾㍀ⱂ㙄㑆", num);
                }
                return BookmarkStart.b("嬮夰娲嬴ᨶ儸吺似䔾汀⁂㝄⡆㩈㡊", num);

            case TextureStyle.TextureDiagonalCross:
                if (A_1)
                {
                    return BookmarkStart.b("嬮夰娲嬴猶倸娺娼簾㍀ⱂ㙄㑆", num);
                }
                return BookmarkStart.b("嬮夰娲嬴ᨶ崸刺尼堾汀⁂㝄⡆㩈㡊", num);

            case TextureStyle.Texture2Pt5Percent:
                if (!A_1)
                {
                    return BookmarkStart.b("弮到䜲ᠴȶ", num);
                }
                return BookmarkStart.b("弮到䜲4", num);

            case TextureStyle.Texture7Pt5Percent:
                if (A_1)
                {
                    return BookmarkStart.b("弮到䜲дܶ", num);
                }
                return BookmarkStart.b("弮到䜲ᠴضस", num);

            case TextureStyle.Texture12Pt5Percent:
                if (A_1)
                {
                    return BookmarkStart.b("弮到䜲дԶ", num);
                }
                return BookmarkStart.b("弮到䜲ᠴضସ", num);

            case TextureStyle.Texture15Percent:
                if (A_1)
                {
                    return BookmarkStart.b("弮到䜲дȶ", num);
                }
                return BookmarkStart.b("弮到䜲ᠴضస", num);

            case TextureStyle.Texture17Pt5Percent:
                if (A_1)
                {
                    return BookmarkStart.b("弮到䜲ܴܶ", num);
                }
                return BookmarkStart.b("弮到䜲ᠴԶस", num);

            case TextureStyle.Texture22Pt5Percent:
                if (A_1)
                {
                    return BookmarkStart.b("弮到䜲ܴȶ", num);
                }
                return BookmarkStart.b("弮到䜲ᠴԶస", num);

            case TextureStyle.Texture27Pt5Percent:
                if (A_1)
                {
                    return BookmarkStart.b("弮到䜲شܶ", num);
                }
                return BookmarkStart.b("弮到䜲ᠴжस", num);

            case TextureStyle.Texture32Pt5Percent:
                if (A_1)
                {
                    return BookmarkStart.b("弮到䜲شȶ", num);
                }
                return BookmarkStart.b("弮到䜲ᠴжస", num);

            case TextureStyle.Texture35Percent:
                if (A_1)
                {
                    return BookmarkStart.b("弮到䜲شȶ", num);
                }
                return BookmarkStart.b("弮到䜲ᠴжస", num);

            case TextureStyle.Texture37Pt5Percent:
                if (A_1)
                {
                    return BookmarkStart.b("弮到䜲ش6", num);
                }
                return BookmarkStart.b("弮到䜲ᠴжุ", num);

            case TextureStyle.Texture42Pt5Percent:
                if (A_1)
                {
                    return BookmarkStart.b("弮到䜲Ĵܶ", num);
                }
                return BookmarkStart.b("弮到䜲ᠴ̶स", num);

            case TextureStyle.Texture45Percent:
                if (A_1)
                {
                    return BookmarkStart.b("弮到䜲Ĵȶ", num);
                }
                return BookmarkStart.b("弮到䜲ᠴ̶స", num);

            case TextureStyle.Texture47Pt5Percent:
                if (A_1)
                {
                    return BookmarkStart.b("弮到䜲Ĵȶ", num);
                }
                return BookmarkStart.b("弮到䜲ᠴ̶స", num);

            case TextureStyle.Texture52Pt5Percent:
                if (A_1)
                {
                    return BookmarkStart.b("弮到䜲4ܶ", num);
                }
                return BookmarkStart.b("弮到䜲ᠴȶस", num);

            case TextureStyle.Texture55Percent:
                if (A_1)
                {
                    return BookmarkStart.b("弮到䜲4ȶ", num);
                }
                return BookmarkStart.b("弮到䜲ᠴȶస", num);

            case TextureStyle.Texture57Pt5Percent:
                if (A_1)
                {
                    return BookmarkStart.b("弮到䜲4ȶ", num);
                }
                return BookmarkStart.b("弮到䜲ᠴȶస", num);

            case TextureStyle.Texture62Pt5Percent:
                if (A_1)
                {
                    return BookmarkStart.b("弮到䜲̴Զ", num);
                }
                return BookmarkStart.b("弮到䜲ᠴĶସ", num);

            case TextureStyle.Texture65Percent:
                if (A_1)
                {
                    return BookmarkStart.b("弮到䜲̴ȶ", num);
                }
                return BookmarkStart.b("弮到䜲ᠴĶస", num);

            case TextureStyle.Texture67Pt5Percent:
                if (A_1)
                {
                    return BookmarkStart.b("弮到䜲̴ȶ", num);
                }
                return BookmarkStart.b("弮到䜲ᠴĶస", num);

            case TextureStyle.Texture72Pt5Percent:
                if (A_1)
                {
                    return BookmarkStart.b("弮到䜲ȴܶ", num);
                }
                return BookmarkStart.b("弮到䜲ᠴ6स", num);

            case TextureStyle.Texture77Pt5Percent:
                if (A_1)
                {
                    return BookmarkStart.b("弮到䜲ഴܶ", num);
                }
                return BookmarkStart.b("弮到䜲ᠴ༶स", num);

            case TextureStyle.Texture82Pt5Percent:
                if (A_1)
                {
                    return BookmarkStart.b("弮到䜲ഴȶ", num);
                }
                return BookmarkStart.b("弮到䜲ᠴ༶స", num);

            case TextureStyle.Texture85Percent:
                if (A_1)
                {
                    return BookmarkStart.b("弮到䜲ഴȶ", num);
                }
                return BookmarkStart.b("弮到䜲ᠴ༶స", num);

            case TextureStyle.Texture87Pt5Percent:
                if (A_1)
                {
                    return BookmarkStart.b("弮到䜲ഴ6", num);
                }
                return BookmarkStart.b("弮到䜲ᠴ༶ุ", num);

            case TextureStyle.Texture92Pt5Percent:
                if (A_1)
                {
                    return BookmarkStart.b("弮到䜲ఴܶ", num);
                }
                return BookmarkStart.b("弮到䜲ᠴึस", num);

            case TextureStyle.Texture95Percent:
                if (A_1)
                {
                    return BookmarkStart.b("弮到䜲ఴȶ", num);
                }
                return BookmarkStart.b("弮到䜲ᠴึస", num);

            case TextureStyle.Texture97Pt5Percent:
                if (A_1)
                {
                    return BookmarkStart.b("弮到䜲ఴȶ", num);
                }
                return BookmarkStart.b("弮到䜲ᠴึస", num);

            case TextureStyle.TextureNil:
                return BookmarkStart.b("䄮堰弲", num);
        }
        return BookmarkStart.b("䄮堰弲", num);
    }

    internal static TextDirection smethod_36(int A_0)
    {
        switch (A_0)
        {
            case 1:
                return TextDirection.RightToLeft;

            case 3:
                return TextDirection.LeftToRight;

            case 4:
                return TextDirection.TopToBottomRotated;

            case 5:
                return TextDirection.RightToLeftRotated;
        }
        return TextDirection.TopToBottom;
    }

    internal static int smethod_37(TextDirection A_0)
    {
        switch (A_0)
        {
            case TextDirection.RightToLeft:
                return 1;

            case TextDirection.LeftToRight:
                return 3;

            case TextDirection.TopToBottomRotated:
                return 4;

            case TextDirection.RightToLeftRotated:
                return 5;
        }
        return 0;
    }

    internal static TextDirection smethod_38(string A_0)
    {
        int num = 0x11;
        string key = A_0;
        if (key != null)
        {
            int num2;
            if (Class1160.dictionary_32 == null)
            {
                Dictionary<string, int> dictionary1 = new Dictionary<string, int>(15);
                dictionary1.Add(BookmarkStart.b("嬶䬸", num), 0);
                dictionary1.Add(BookmarkStart.b("唶䴸眺似", num), 1);
                dictionary1.Add(BookmarkStart.b("唶䴸ᘺ儼䴾", num), 2);
                dictionary1.Add(BookmarkStart.b("䌶嬸", num), 3);
                dictionary1.Add(BookmarkStart.b("嬶䬸漺弼", num), 4);
                dictionary1.Add(BookmarkStart.b("嬶䬸ᘺ䤼崾", num), 5);
                dictionary1.Add(BookmarkStart.b("䌶嬸洺", num), 6);
                dictionary1.Add(BookmarkStart.b("嬶䬸漺弼椾", num), 7);
                dictionary1.Add(BookmarkStart.b("嬶䬸ᘺ䤼崾汀㕂", num), 8);
                dictionary1.Add(BookmarkStart.b("䔶唸洺", num), 9);
                dictionary1.Add(BookmarkStart.b("䌶嬸椺儼椾", num), 10);
                dictionary1.Add(BookmarkStart.b("䌶嬸ᘺ似匾汀㕂", num), 11);
                dictionary1.Add(BookmarkStart.b("䔶唸", num), 12);
                dictionary1.Add(BookmarkStart.b("䌶嬸椺儼", num), 13);
                dictionary1.Add(BookmarkStart.b("䌶嬸ᘺ似匾", num), 14);
                Class1160.dictionary_32 = dictionary1;
            }
            if (Class1160.dictionary_32.TryGetValue(key, out num2))
            {
                switch (num2)
                {
                    case 0:
                    case 1:
                    case 2:
                        return TextDirection.LeftToRight;

                    case 3:
                    case 4:
                    case 5:
                        return TextDirection.TopToBottom;

                    case 6:
                    case 7:
                    case 8:
                        return TextDirection.TopToBottomRotated;

                    case 9:
                    case 10:
                    case 11:
                        return TextDirection.RightToLeftRotated;

                    case 12:
                    case 13:
                    case 14:
                        return TextDirection.RightToLeft;
                }
            }
        }
        return TextDirection.TopToBottom;
    }

    internal static string smethod_39(TextDirection A_0, bool A_1)
    {
        int num = 11;
        switch (A_0)
        {
            case TextDirection.RightToLeft:
                if (A_1)
                {
                    return BookmarkStart.b("䔰儲朴嬶", num);
                }
                return BookmarkStart.b("䔰儲ᠴ䔶唸", num);

            case TextDirection.LeftToRightRotated:
                if (A_1)
                {
                    return BookmarkStart.b("䔰儲礴䔶漸", num);
                }
                return string.Empty;

            case TextDirection.LeftToRight:
                if (A_1)
                {
                    return BookmarkStart.b("匰䜲礴䔶", num);
                }
                return BookmarkStart.b("匰䜲ᠴ嬶䬸", num);

            case TextDirection.TopToBottomRotated:
                if (A_1)
                {
                    return BookmarkStart.b("崰䄲愴唶漸", num);
                }
                return BookmarkStart.b("崰䄲ᠴ䌶嬸ᘺ䬼", num);

            case TextDirection.RightToLeftRotated:
                if (A_1)
                {
                    return BookmarkStart.b("䔰儲朴嬶漸", num);
                }
                return BookmarkStart.b("䔰儲ᠴ䔶唸ᘺ䬼", num);
        }
        return string.Empty;
    }

    internal static ConditionalFormattingCode smethod_4(string A_0)
    {
        int num = 10;
        string key = A_0;
        if (key != null)
        {
            int num2;
            if (Class1160.dictionary_30 == null)
            {
                Dictionary<string, int> dictionary1 = new Dictionary<string, int>(13);
                dictionary1.Add(BookmarkStart.b("刯匱娳刵ष爹医䰽㨿", num), 0);
                dictionary1.Add(BookmarkStart.b("刯匱娳刵ष氹夻䰽㐿", num), 1);
                dictionary1.Add(BookmarkStart.b("刯匱娳刵਷爹医䰽㨿", num), 2);
                dictionary1.Add(BookmarkStart.b("刯匱娳刵਷氹夻䰽㐿", num), 3);
                dictionary1.Add(BookmarkStart.b("嘯嬱䘳䔵䰷礹医刽", num), 4);
                dictionary1.Add(BookmarkStart.b("嘯嬱䘳䔵䰷根医䤽", num), 5);
                dictionary1.Add(BookmarkStart.b("尯匱䜳䈵笷唹倻", num), 6);
                dictionary1.Add(BookmarkStart.b("尯匱䜳䈵樷唹䬻", num), 7);
                dictionary1.Add(BookmarkStart.b("帯圱眳匵吷嘹", num), 8);
                dictionary1.Add(BookmarkStart.b("帯䔱眳匵吷嘹", num), 9);
                dictionary1.Add(BookmarkStart.b("䌯圱眳匵吷嘹", num), 10);
                dictionary1.Add(BookmarkStart.b("䌯䔱眳匵吷嘹", num), 11);
                dictionary1.Add(BookmarkStart.b("䜯娱嬳娵崷渹崻尽ⰿ❁", num), 12);
                Class1160.dictionary_30 = dictionary1;
            }
            if (Class1160.dictionary_30.TryGetValue(key, out num2))
            {
                switch (num2)
                {
                    case 0:
                        return ConditionalFormattingCode.OddRowBanding;

                    case 1:
                        return ConditionalFormattingCode.OddColumnBanding;

                    case 2:
                        return ConditionalFormattingCode.EvenRowBanding;

                    case 3:
                        return ConditionalFormattingCode.EvenColumnBanding;

                    case 4:
                        return ConditionalFormattingCode.FirstColumn;

                    case 5:
                        return ConditionalFormattingCode.FirstRow;

                    case 6:
                        return ConditionalFormattingCode.LastColumn;

                    case 7:
                        return ConditionalFormattingCode.LastRow;

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
        return ConditionalFormattingCode.None;
    }

    internal static string smethod_5(ConditionalFormattingCode A_0)
    {
        int num = 0x13;
        switch (A_0)
        {
            case ConditionalFormattingCode.OddRowBanding:
                return BookmarkStart.b("嬸娺匼嬾灀ୂ⩄㕆㍈", num);

            case ConditionalFormattingCode.OddColumnBanding:
                return BookmarkStart.b("嬸娺匼嬾灀ᕂ⁄㕆㵈", num);

            case ConditionalFormattingCode.EvenRowBanding:
                return BookmarkStart.b("嬸娺匼嬾獀ୂ⩄㕆㍈", num);

            case ConditionalFormattingCode.EvenColumnBanding:
                return BookmarkStart.b("嬸娺匼嬾獀ᕂ⁄㕆㵈", num);

            case ConditionalFormattingCode.FirstColumn:
                return BookmarkStart.b("弸刺似䰾㕀B⩄⭆", num);

            case ConditionalFormattingCode.FirstRow:
                return BookmarkStart.b("弸刺似䰾㕀ᅂ⩄う", num);

            case ConditionalFormattingCode.LastColumn:
                return BookmarkStart.b("唸娺丼䬾ɀⱂ⥄", num);

            case ConditionalFormattingCode.LastRow:
                return BookmarkStart.b("唸娺丼䬾ፀⱂ㉄", num);

            case ConditionalFormattingCode.FirstRowLastCell:
                return BookmarkStart.b("圸帺縼娾ⵀ⽂", num);

            case ConditionalFormattingCode.FirstRowFirstCell:
                return BookmarkStart.b("圸䰺縼娾ⵀ⽂", num);

            case ConditionalFormattingCode.LastRowLastCell:
                return BookmarkStart.b("䨸帺縼娾ⵀ⽂", num);

            case ConditionalFormattingCode.LastRowFirstCell:
                return BookmarkStart.b("䨸䰺縼娾ⵀ⽂", num);

            case ConditionalFormattingCode.WholeTable:
                return BookmarkStart.b("丸区刼匾⑀ᝂ⑄╆╈⹊", num);
        }
        return BookmarkStart.b("丸区刼匾⑀ᝂ⑄╆╈⹊", num);
    }

    internal static FontPitch smethod_6(string A_0)
    {
        return (FontPitch) Class791.smethod_3(hashtable_0, A_0, FontPitch.Default);
    }

    internal static string smethod_7(FontPitch A_0)
    {
        return (string) Class791.smethod_3(hashtable_1, A_0, "");
    }

    internal static RelativeHeight smethod_8(string A_0)
    {
        return (RelativeHeight) Class791.smethod_3(hashtable_2, A_0, RelativeHeight.Page);
    }

    internal static string smethod_9(RelativeHeight A_0)
    {
        return (string) Class791.smethod_3(hashtable_3, A_0, "");
    }
}

