using Spire.Doc;
using Spire.Doc.Documents;
using System;
using System.Collections;

internal class Class911
{
    private static readonly Hashtable hashtable_0 = new Hashtable();
    private static readonly Hashtable hashtable_1 = new Hashtable();
    private static readonly Hashtable hashtable_10 = new Hashtable();
    private static readonly Hashtable hashtable_11 = new Hashtable();
    private static readonly Hashtable hashtable_12 = new Hashtable();
    private static readonly Hashtable hashtable_13 = new Hashtable();
    private static readonly Hashtable hashtable_2 = new Hashtable();
    private static readonly Hashtable hashtable_3 = new Hashtable();
    private static readonly Hashtable hashtable_4 = new Hashtable();
    private static readonly Hashtable hashtable_5 = new Hashtable();
    private static readonly Hashtable hashtable_6 = new Hashtable();
    private static readonly Hashtable hashtable_7 = new Hashtable();
    private static readonly Hashtable hashtable_8 = new Hashtable();
    private static readonly Hashtable hashtable_9 = new Hashtable();

    static Class911()
    {
        Class791.smethod_0(new object[] { 
            BookmarkStart.b("帯嬱堳", 10), BorderStyle.Cleared, BookmarkStart.b("帯崱娳匵", 10), BorderStyle.None, BookmarkStart.b("䌯嬱娳儵吷弹", 10), BorderStyle.Single, BookmarkStart.b("䐯娱崳唵匷", 10), BorderStyle.Thick, BookmarkStart.b("启崱䄳吵吷弹", 10), BorderStyle.Double, BookmarkStart.b("启崱䀳䈵崷帹", 10), BorderStyle.Dot, BookmarkStart.b("启匱䜳帵崷帹", 10), BorderStyle.DashLargeGap, BookmarkStart.b("启崱䀳ᬵ尷嬹伻嘽", 10), BorderStyle.DotDash, 
            BookmarkStart.b("启崱䀳ᬵ尷唹䠻ጽ␿⍁㝃⹅", 10), BorderStyle.DotDotDash, BookmarkStart.b("䐯䀱崳䘵吷弹", 10), BorderStyle.Triple, BookmarkStart.b("䐯娱崳堵ᔷ丹吻圽⌿⥁楃㕅╇⭉⁋≍絏㕑㕓♕", 10), BorderStyle.ThinThickSmallGap, BookmarkStart.b("䐯娱崳唵匷᜹䠻嘽⤿ⱁ楃㕅╇⭉⁋≍絏㕑㕓♕", 10), BorderStyle.ThickThinSmallGap, BookmarkStart.b("䐯娱崳堵ᔷ丹吻圽⌿⥁楃㉅⁇⍉≋捍⍏㽑㕓㩕㑗睙㭛㽝ၟ", 10), BorderStyle.ThinThickThinSmallGap, BookmarkStart.b("䐯娱崳堵ᔷ丹吻圽⌿⥁楃⭅ⵇ⹉╋㭍㵏网㍓㝕⡗", 10), BorderStyle.ThinThickMediumGap, BookmarkStart.b("䐯娱崳唵匷᜹䠻嘽⤿ⱁ楃⭅ⵇ⹉╋㭍㵏网㍓㝕⡗", 10), BorderStyle.ThickThinMediumGap, BookmarkStart.b("䐯娱崳堵ᔷ丹吻圽⌿⥁楃㉅⁇⍉≋捍㵏㝑こ㽕ⵗ㝙煛㥝şቡ", 10), BorderStyle.ThinThickThinMediumGap, 
            BookmarkStart.b("䐯娱崳堵ᔷ丹吻圽⌿⥁楃⩅⥇㡉⭋⭍絏㕑㕓♕", 10), BorderStyle.ThinThickLargeGap, BookmarkStart.b("䐯娱崳唵匷᜹䠻嘽⤿ⱁ楃⩅⥇㡉⭋⭍絏㕑㕓♕", 10), BorderStyle.ThickThinLargeGap, BookmarkStart.b("䐯娱崳堵ᔷ丹吻圽⌿⥁楃㉅⁇⍉≋捍㱏㍑♓ㅕ㵗睙㭛㽝ၟ", 10), BorderStyle.ThinThickThinLargeGap, BookmarkStart.b("䜯匱䈳匵", 10), BorderStyle.Wave, BookmarkStart.b("启崱䄳吵吷弹ᄻ䤽ℿ㑁⅃", 10), BorderStyle.DoubleWave, BookmarkStart.b("启匱䜳帵ᔷ䤹儻弽ⰿ⹁楃ⅅ⥇㩉", 10), BorderStyle.DashSmallGap, BookmarkStart.b("启匱䜳帵ᔷ帹医䨽洿ㅁぃ㑅❇ⅉ⥋⩍", 10), BorderStyle.DashDotStroker, BookmarkStart.b("䐯娱䘳匵崷᜹堻ጽ┿⽁♃⥅㭇㥉", 10), BorderStyle.Emboss3D, 
            BookmarkStart.b("䐯娱䘳匵崷᜹堻ጽ┿ⱁ⍃㑅⥇㱉⥋", 10), BorderStyle.Engrave3D, BookmarkStart.b("弯䜱䀳䔵崷丹", 10), BorderStyle.Outset, BookmarkStart.b("夯就䜳匵䰷", 10), BorderStyle.Inset, BookmarkStart.b("儯䈱䐳娵崷䤹", 10), (BorderStyle) 0x40, BookmarkStart.b("儯䀱圳帵崷帹ᄻ䴽⌿⍁⡃⩅❇㩉㽋", 10), (BorderStyle) 0x41, BookmarkStart.b("刯匱嘳伵ᔷ䨹崻崽⤿⑁ⵃ⍅㩇", 10), (BorderStyle) 0x42, BookmarkStart.b("刯匱嘳伵ᔷ䠹崻䨽㐿⹁⅃", 10), (BorderStyle) 0x43, BookmarkStart.b("刯匱堳娵圷唹刻䴽洿煁楃╅❇♉⍋㱍⍏", 10), (BorderStyle) 0x44, 
            BookmarkStart.b("刯匱堳娵圷唹刻䴽洿⩁⭃㉅敇⭉╋㱍", 10), (BorderStyle) 0x45, BookmarkStart.b("刯匱䜳張嬷᜹帻刽ℿ⅁⽃歅ⱇ⭉㽋♍㕏⅑", 10), (BorderStyle) 70, BookmarkStart.b("刯匱䜳張嬷᜹帻刽ℿ⅁⽃歅ⱇ╉㡋㵍", 10), (BorderStyle) 0x47, BookmarkStart.b("刯匱䜳張嬷᜹帻刽ℿ⅁⽃歅㭇㭉㥋⽍≏㝑❓", 10), (BorderStyle) 0x48, BookmarkStart.b("刯匱䜳張嬷᜹䠻嘽⤿ⱁ楃⩅ⅇ⑉⥋㵍", 10), (BorderStyle) 0x49, BookmarkStart.b("刯匱䜳張嬷᜹䬻嘽⤿㙁⅃歅ⱇ⭉㽋♍㕏⅑", 10), (BorderStyle) 0x4a, BookmarkStart.b("刯匱䜳張嬷᜹䬻嘽⤿㙁⅃歅ⱇ╉㡋㵍", 10), (BorderStyle) 0x4b, BookmarkStart.b("刯匱䜳張嬷᜹䬻嘽⤿㙁⅃歅㭇㭉㥋⽍≏㝑❓", 10), (BorderStyle) 0x4c, 
            BookmarkStart.b("刯匱䜳張嬷᜹䬻圽␿❁楃⽅♇♉╋⁍㕏", 10), (BorderStyle) 0x4d, BookmarkStart.b("刯匱䜳張嬷᜹䬻圽␿❁楃⭅ⅇ⹉⁋❍㹏㝑", 10), (BorderStyle) 0x4e, BookmarkStart.b("刯匱䜳張嬷᜹䬻圽␿❁楃⥅㵇㹉⁋❍㹏㝑", 10), (BorderStyle) 0x4f, BookmarkStart.b("刯匱䀳䔵", 10), (BorderStyle) 80, BookmarkStart.b("刯嬱䘳刵䬷", 10), (BorderStyle) 0x51, BookmarkStart.b("刯嬱䘳刵䬷᜹娻刽⤿╁ⱃ㉅", 10), (BorderStyle) 0x52, BookmarkStart.b("匯匱嘳張嘷䤹", 10), (BorderStyle) 0x53, BookmarkStart.b("匯匱弳匵ᔷ䤹倻圽⌿❁", 10), (BorderStyle) 0x54, 
            BookmarkStart.b("匯匱娳刵䄷᜹弻儽㈿ⱁ", 10), (BorderStyle) 0x55, BookmarkStart.b("匯圱堳䈵儷夹ᄻ唽⸿ⵁぃㅅ❇㡉❋", 10), (BorderStyle) 0x56, BookmarkStart.b("匯圱䘳䈵儷尹唻崽ℿ㙁⅃歅⩇⭉≋⁍㕏⁑", 10), (BorderStyle) 0x57, BookmarkStart.b("匯娱唳張嘷᜹倻圽⸿⥁", 10), (BorderStyle) 0x58, BookmarkStart.b("匯娱唳嬵䠷嬹嬻倽┿潁♃⥅㱇㹉⁋⭍", 10), (BorderStyle) 0x59, BookmarkStart.b("匯娱儳唵匷弹堻ጽ∿⍁㙃歅⩇♉ⵋⵍ㭏", 10), (BorderStyle) 90, BookmarkStart.b("匯娱儳唵匷弹堻ጽ∿⍁㙃歅⭇╉⁋⅍≏", 10), (BorderStyle) 0x5b, BookmarkStart.b("匯娱儳唵匷弹主嬽␿", 10), (BorderStyle) 0x5c, 
            BookmarkStart.b("匯娱䘳張䬷丹儻弽㌿潁ぃ㑅ⵇ⽉", 10), (BorderStyle) 0x5d, BookmarkStart.b("匯嬱䘳唵吷弹伻ጽⰿ⭁⩃⍅㭇", 10), (BorderStyle) 0x5e, BookmarkStart.b("匯嬱䘳唵吷弹伻ጽ㈿❁❃㉅⥇⑉⭋≍㕏⅑", 10), (BorderStyle) 0x5f, BookmarkStart.b("匯帱唳䔵䬷匹弻弽ⰿ潁㍃❅㹇⽉", 10), (BorderStyle) 0x60, BookmarkStart.b("匯帱嬳唵匷䤹", 10), (BorderStyle) 0x61, BookmarkStart.b("匯崱夳䘵夷䤹伻", 10), (BorderStyle) 0x62, BookmarkStart.b("匯崱娳倵崷丹䠻圽", 10), (BorderStyle) 0x63, BookmarkStart.b("匯崱娳倵崷丹䠻圽洿╁㙃❅ㅇ㥉", 10), (BorderStyle) 100, 
            BookmarkStart.b("匯崱娳倵崷丹䠻圽洿ⵁㅃ㉅⑇⍉≋⭍", 10), (BorderStyle) 0x65, BookmarkStart.b("匯崱娳倵崷丹䠻圽洿ㅁぃ㑅ⵇ⭉⅋⭍≏⅑", 10), (BorderStyle) 0x66, BookmarkStart.b("匯崱娳倵崷丹䠻圽洿㕁ⱃ⽅㱇⽉", 10), (BorderStyle) 0x67, BookmarkStart.b("匯崱䘳堵崷䠹ᄻ䨽㈿⭁╃⡅⽇♉⥋㵍", 10), (BorderStyle) 0x68, BookmarkStart.b("匯崱䄳䘵圷吹ᄻ崽㔿㙁⭃㍅㱇杉⡋⽍⍏㩑ㅓ╕", 10), (BorderStyle) 0x69, BookmarkStart.b("匯崱䄳䘵圷吹ᄻ崽㔿㙁⭃㍅㱇杉⡋⅍⑏⅑", 10), (BorderStyle) 0x6a, BookmarkStart.b("匯䀱唳䰵䄷᜹儻弽㨿❁", 10), (BorderStyle) 0x6b, BookmarkStart.b("匯䀱儳圵䰷伹主嬽㌿潁♃㍅㱇㹉⥋㱍㙏㹑ⵓ", 10), (BorderStyle) 0x6c, 
            BookmarkStart.b("匯䀱儳圵䰷伹主嬽㌿潁≃⽅㭇≉", 10), (BorderStyle) 0x6d, BookmarkStart.b("匯䀱儳圵䰷伹主嬽㌿潁ⵃ⡅㭇⽉⽋㩍⍏", 10), (BorderStyle) 110, BookmarkStart.b("匯䀱儳圵䰷伹主嬽㌿潁⡃❅ⱇ㍉態ⱍ╏㕑", 10), (BorderStyle) 0x6f, BookmarkStart.b("匯䀱嬳䔵䬷᜹伻䨽⤿㙁❃⹅", 10), (BorderStyle) 0x70, BookmarkStart.b("匯䜱䐳", 10), (BorderStyle) 0x71, BookmarkStart.b("启圱圳夵ᔷ嬹主崽⠿", 10), (BorderStyle) 0x72, BookmarkStart.b("启圱圳夵ᔷ嬹主崽⠿潁❃⥅⑇╉㹋", 10), (BorderStyle) 0x73, BookmarkStart.b("启圱圳夵ᔷ堹倻儽⌿⥁㝃", 10), (BorderStyle) 0x74, 
            BookmarkStart.b("启嬱唳嬵圷吹堻䴽洿╁㙃❅ㅇ", 10), (BorderStyle) 0x75, BookmarkStart.b("启崱䄳吵吷弹ᄻ娽", 10), (BorderStyle) 0x76, BookmarkStart.b("启崱䄳吵吷弹ᄻ娽⤿⍁⥃⥅♇⹉㽋", 10), (BorderStyle) 0x77, BookmarkStart.b("唯匱䘳䈵倷᜹഻", 10), (BorderStyle) 120, BookmarkStart.b("唯匱䘳䈵倷᜹฻", 10), (BorderStyle) 0x79, BookmarkStart.b("唯儱堳張䠷䤹唻倽✿潁㝃㝅㵇⭉㹋⭍⍏网敓", 10), (BorderStyle) 0x7a, BookmarkStart.b("唯儱堳張䠷䤹唻倽✿潁㝃㝅㵇⭉㹋⭍⍏网晓", 10), (BorderStyle) 0x7b, BookmarkStart.b("唯唱匳䔵ᔷ堹倻弽⌿⥁", 10), (BorderStyle) 0x7c, 
            BookmarkStart.b("嘯匱娳䔵", 10), (BorderStyle) 0x7d, BookmarkStart.b("嘯嬱堳嬵", 10), (BorderStyle) 0x7e, BookmarkStart.b("嘯嬱䘳匵嬷䠹崻崽⬿❁㙃㕅", 10), (BorderStyle) 0x7f, BookmarkStart.b("嘯帱嬳䄵崷䠹伻ጽ∿⹁⭃╅⍇杉㱋㱍㥏㱑⁓", 10), (BorderStyle) 0x80, BookmarkStart.b("嘯帱嬳䄵崷䠹伻ጽ␿⍁ⵃ㕅ⅇ⽉㽋", 10), (BorderStyle) 0x81, BookmarkStart.b("嘯帱嬳䄵崷䠹伻ጽⴿⵁ⁃⍅㩇⑉態罍", 10), (BorderStyle) 130, BookmarkStart.b("嘯帱嬳䄵崷䠹伻ጽⴿⵁ⁃⍅㩇⑉態籍", 10), (BorderStyle) 0x83, BookmarkStart.b("嘯帱嬳䄵崷䠹伻ጽ〿⍁⩃㕅ㅇ", 10), (BorderStyle) 0x84, 
            BookmarkStart.b("嘯帱嬳䄵崷䠹伻ጽ㈿❁⁃歅㩇╉㽋⭍", 10), (BorderStyle) 0x85, BookmarkStart.b("嘯帱嬳䄵崷䠹伻ጽ㈿ⵁ㝃⍅㭇", 10), (BorderStyle) 0x86, BookmarkStart.b("嘯帱嬳䄵崷䠹伻ጽ㐿❁╃╅㵇㩉", 10), (BorderStyle) 0x87, BookmarkStart.b("嘯帱嬳䄵崷䠹伻ጽ㐿⭁⩃㽅", 10), (BorderStyle) 0x88, BookmarkStart.b("圯圱夳䔵", 10), (BorderStyle) 0x89, BookmarkStart.b("圯嬱娳儵崷䠹帻䰽┿⍁⁃歅╇⭉≋", 10), (BorderStyle) 0x8a, BookmarkStart.b("圯䀱唳刵儷弹刻䨽", 10), (BorderStyle) 0x8b, BookmarkStart.b("堯匱娳刵唷嬹堻嬽洿獁", 10), (BorderStyle) 140, 
            BookmarkStart.b("堯匱娳刵唷嬹堻嬽洿灁", 10), (BorderStyle) 0x8d, BookmarkStart.b("堯圱唳䐵䰷᜹帻弽ⰿ⹁⭃⥅♇", 10), (BorderStyle) 0x8e, BookmarkStart.b("堯圱唳䐵䰷᜹嬻䰽ℿ㭁", 10), (BorderStyle) 0x8f, BookmarkStart.b("堯圱唳䐵䰷䤹", 10), (BorderStyle) 0x90, BookmarkStart.b("堯圱儳吵儷弹ᄻ吽┿❁♃⽅ⵇ㥉", 10), (BorderStyle) 0x91, BookmarkStart.b("堯崱堳娵䄷", 10), (BorderStyle) 0x92, BookmarkStart.b("堯崱䄳䔵崷᜹娻䬽⸿⥁㵃", 10), (BorderStyle) 0x93, BookmarkStart.b("堯䬱䐳堵圷丹唻崽", 10), (BorderStyle) 0x94, 
            BookmarkStart.b("夯儱儳ᬵ嬷䠹夻弽ⴿ潁❃⥅♇⽉㽋", 10), (BorderStyle) 0x95, BookmarkStart.b("尯嬱匳帵䰷᜹帻䬽ⰿ⁁", 10), (BorderStyle) 150, BookmarkStart.b("尯嬱匳帵䰷吹唻倽✿潁畃", 10), (BorderStyle) 0x97, BookmarkStart.b("尯嬱匳帵䰷吹唻倽✿潁癃", 10), (BorderStyle) 0x98, BookmarkStart.b("崯匱䐳ᬵ䠷匹刻䴽", 10), (BorderStyle) 0x99, BookmarkStart.b("崯匱䐳娵崷᜹倻嬽ℿ⑁", 10), (BorderStyle) 0x9a, BookmarkStart.b("崯匱䐳娵崷᜹儻䬽☿⑁ⵃ⡅㭇", 10), (BorderStyle) 0x9b, BookmarkStart.b("崯匱䘳䜵䴷弹夻", 10), (BorderStyle) 0x9c, 
            BookmarkStart.b("崯匱䘳䜵䴷弹夻ጽ㐿ⵁ⭃㉅⁇⽉⡋", 10), (BorderStyle) 0x9d, BookmarkStart.b("崯崱嬳堵䬷", 10), (BorderStyle) 0x9e, BookmarkStart.b("崯崱䜳圵儷夹", 10), (BorderStyle) 0x9f, BookmarkStart.b("崯䜱䜳張嬷᜹刻儽㐿❁㝃", 10), (BorderStyle) 160, BookmarkStart.b("帯崱䘳䈵倷䴹夻䴽㐿", 10), (BorderStyle) 0xa1, BookmarkStart.b("弯䐱唳娵䬷", 10), (BorderStyle) 0xa2, BookmarkStart.b("䀯匱圳崵夷崹夻䴽", 10), (BorderStyle) 0xa3, BookmarkStart.b("䀯匱堳嬵䬷᜹帻刽ℿ⅁⽃", 10), (BorderStyle) 0xa4, 
            BookmarkStart.b("䀯匱堳嬵䬷᜹弻儽ⰿⵁ㙃", 10), (BorderStyle) 0xa5, BookmarkStart.b("䀯匱䐳匵䨷᜹弻刽⤿㉁㝃", 10), (BorderStyle) 0xa6, BookmarkStart.b("䀯匱䐳伵䨷伹伻", 10), (BorderStyle) 0xa7, BookmarkStart.b("䀯匱䘳䈵䄷᜹娻弽㘿ⵁ㙃", 10), (BorderStyle) 0xa8, BookmarkStart.b("䀯匱䘳䈵䄷᜹嬻刽ℿㅁ㝃", 10), (BorderStyle) 0xa9, BookmarkStart.b("䀯圱娳唵儷嘹伻", 10), (BorderStyle) 170, BookmarkStart.b("䀯圱嬳䘵吷弹", 10), (BorderStyle) 0xab, BookmarkStart.b("䀯圱嬳䘵吷弹ᄻ䤽ℿ㑁ⵃ⡅⽇", 10), (BorderStyle) 0xac, 
            BookmarkStart.b("䀯圱嬳䘵吷弹ᄻ嘽ℿ㙁㝃", 10), (BorderStyle) 0xad, BookmarkStart.b("䀯崱崳堵䬷弹䠻䨽⤿⍁㝃", 10), (BorderStyle) 0xae, BookmarkStart.b("䀯崱䜳䈵夷崹夻ጽ㌿㙁╃⭅㡇", 10), (BorderStyle) 0xaf, BookmarkStart.b("䀯䜱夳䘵匷匹刻ጽ焿", 10), (BorderStyle) 0xb0, BookmarkStart.b("䀯䜱䜳帵ᔷ䨹唻倽洿ⱁ⭃㉅ⵇ杉絋", 10), (BorderStyle) 0xb2, BookmarkStart.b("䀯䜱䜳帵ᔷ䨹唻倽洿ⱁ⭃㉅ⵇ杉繋", 10), (BorderStyle) 0xb1, BookmarkStart.b("䀯䬱䘳圵唷匹堻䴽", 10), (BorderStyle) 0xb3, BookmarkStart.b("䀯䬱䘳圵唷匹堻䴽洿⍁♃⥅㹇⽉", 10), (BorderStyle) 180, 
            BookmarkStart.b("䄯䜱唳刵䨷嬹刻䨽㌿", 10), (BorderStyle) 0xb5, BookmarkStart.b("䈯嬱娳儵䬷", 10), (BorderStyle) 0xb6, BookmarkStart.b("䌯匱刳圵䨷匹", 10), (BorderStyle) 0xb7, BookmarkStart.b("䌯匱䌳䈵圷唹䠻嘽", 10), (BorderStyle) 0xb8, BookmarkStart.b("䌯匱䌳䈵圷唹䠻嘽洿╁㙃❅ㅇ", 10), (BorderStyle) 0xb9, BookmarkStart.b("䌯儱唳䐵崷帹ᄻ崽ℿ㙁", 10), (BorderStyle) 0xba, BookmarkStart.b("䌯圱唳䈵䰷嘹夻", 10), (BorderStyle) 0xbb, BookmarkStart.b("䌯娱唳刵圷䴹夻娽洿ㅁ㕃㍅⥇㡉⥋㵍", 10), (BorderStyle) 0xbc, 
            BookmarkStart.b("䌯娱唳䐵匷䤹ᄻ䨽┿❁ぃ⹅", 10), (BorderStyle) 0xbd, BookmarkStart.b("䌯娱嬳䐵崷堹唻䰽␿潁ぃ㑅⥇⥉❋㵍", 10), (BorderStyle) 190, BookmarkStart.b("䌯失䴳䐵圷夹圻嬽㐿", 10), (BorderStyle) 0xbf, BookmarkStart.b("䌯就嬳䄵帷嘹崻唽┿潁≃❅♇⥉㕋", 10), (BorderStyle) 0xc0, BookmarkStart.b("䌯就嬳䄵帷嘹崻唽┿ㅁ", 10), (BorderStyle) 0xc1, BookmarkStart.b("䌯崱夳吵䨷弹主儽", 10), (BorderStyle) 0xc2, BookmarkStart.b("䌯崱䄳䈵倷䴹夻䴽㐿", 10), (BorderStyle) 0xc3, BookmarkStart.b("䌯䘱唳䐵䬷", 10), (BorderStyle) 0xc4, 
            BookmarkStart.b("䌯䘱唳䐵䬷᜹䠻儽〿", 10), (BorderStyle) 0xc5, BookmarkStart.b("䌯䘱唳䐵䬷᜹༻娽", 10), (BorderStyle) 0xc6, BookmarkStart.b("䌯䘱唳䐵䬷᜹帻刽ℿ⅁⽃", 10), (BorderStyle) 0xc7, BookmarkStart.b("䌯䘱唳䐵䬷᜹伻嘽ℿ♁⭃ㅅⵇ⹉", 10), (BorderStyle) 200, BookmarkStart.b("䌯䜱娳", 10), (BorderStyle) 0xc9, BookmarkStart.b("䌯䔱崳䐵吷匹嬻圽✿", 10), (BorderStyle) 0xca, BookmarkStart.b("䐯崱䘳堵ᔷ䨹崻丽┿ぁ", 10), (BorderStyle) 0xcb, BookmarkStart.b("䐯崱䘳堵ᔷ䨹崻丽┿ぁ楃⑅⑇⭉⽋╍", 10), (BorderStyle) 0xcc, 
            BookmarkStart.b("䐯䀱儳匵䬷", 10), (BorderStyle) 0xcd, BookmarkStart.b("䐯䀱崳圵嘷崹倻嬽洿㉁╃㑅㱇㍉", 10), (BorderStyle) 0xce, BookmarkStart.b("䐯䀱崳圵嘷崹倻嬽㌿", 10), (BorderStyle) 0xcf, BookmarkStart.b("䐯䀱崳吵夷嘹ᄻ༽", 10), (BorderStyle) 0xd0, BookmarkStart.b("䐯䀱崳吵夷嘹ᄻఽ", 10), (BorderStyle) 0xd1, BookmarkStart.b("䐯䀱崳吵夷嘹ᄻഽ", 10), (BorderStyle) 210, BookmarkStart.b("䐯䀱崳吵夷嘹ᄻ਽", 10), (BorderStyle) 0xd3, BookmarkStart.b("䐯䀱崳吵夷嘹ᄻଽ", 10), (BorderStyle) 0xd4, 
            BookmarkStart.b("䐯䀱崳吵夷嘹ᄻ࠽", 10), (BorderStyle) 0xd5, BookmarkStart.b("䐯䔱崳䔵䰷弹堻ጽⰿ⭁⩃⍅㭇杉絋", 10), BorderStyle.TwistedLines1, BookmarkStart.b("䐯䔱崳䔵䰷弹堻ጽⰿ⭁⩃⍅㭇杉繋", 10), BorderStyle.TwistedLines1 | BorderStyle.Single, BookmarkStart.b("䘯嬱娳匵", 10), (BorderStyle) 0xd8, BookmarkStart.b("䜯匱䈳匵吷匹刻嬽", 10), (BorderStyle) 0xd9, BookmarkStart.b("䜯圱唳䀵儷吹嬻ጽℿⱁ⍃⩅ⵇ㥉", 10), (BorderStyle) 0xda, BookmarkStart.b("䜯圱唳䀵儷吹嬻ጽ∿ぁ╃⽅ⱇ", 10), (BorderStyle) 0xdb, BookmarkStart.b("䜯圱唳䀵儷吹嬻ጽ㈿⭁♃⑅❇⑉", 10), (BorderStyle) 220, 
            BookmarkStart.b("䜯圱唳䀵儷吹嬻ጽ㌿㙁㙃⽅㡇㥉", 10), (BorderStyle) 0xdd, BookmarkStart.b("䜯娱崳䈵崷᜹娻刽⼿㕁⅃㑅㭇", 10), BorderStyle.TwistedLines1 | BorderStyle.DotDash, BookmarkStart.b("䜯崱嬳刵伷唹主唽", 10), BorderStyle.TwistedLines1 | BorderStyle.DotDotDash, BookmarkStart.b("䠯ἱ崳娵吷伹伻圽⼿ⱁ㝃", 10), (BorderStyle) 0xe0, BookmarkStart.b("䨯匱娳伵ᔷ丹主圽ℿⱁ⍃⩅ⵇ㥉", 10), (BorderStyle) 0xe1, BookmarkStart.b("䨯嬱匳ᬵ䈷嬹嬻", 10), (BorderStyle) 0xe2, BookmarkStart.b("䨯嬱匳ᬵ䈷嬹嬻ጽ㌿㙁ⵃ㉅⭇≉", 10), (BorderStyle) 0xe3
         }, hashtable_4, hashtable_5);
        Class791.smethod_0(new object[] { 
            BookmarkStart.b("启圱圳張唷嬹倻", 10), ListPatternType.Arabic, BookmarkStart.b("䔯䈱䐳匵䨷᜹主儽ⴿ⍁⩃", 10), ListPatternType.UpRoman, BookmarkStart.b("尯崱䌳匵䨷᜹主儽ⴿ⍁⩃", 10), ListPatternType.LowRoman, BookmarkStart.b("䔯䈱䐳匵䨷᜹倻嬽㐿㙁⅃㑅", 10), ListPatternType.UpLetter, BookmarkStart.b("尯崱䌳匵䨷᜹倻嬽㐿㙁⅃㑅", 10), ListPatternType.LowLetter, BookmarkStart.b("弯䀱倳張嘷嬹倻", 10), ListPatternType.Ordinal, BookmarkStart.b("匯匱䘳刵儷吹崻刽洿㙁⅃㹅㱇", 10), ListPatternType.CardinalText, BookmarkStart.b("弯䀱倳張嘷嬹倻ጽ㐿❁㱃㉅", 10), ListPatternType.OrdinalText, 
            BookmarkStart.b("匯娱崳唵夷崹医", 10), ListPatternType.Chicago, BookmarkStart.b("启圱圳張唷嬹倻ጽ☿㝁⡃⩅敇㵉╋⩍⑏㩑晓", 10), ListPatternType.DecimalFullWidth, BookmarkStart.b("启圱圳張唷嬹倻ጽ㨿❁㙃⥅", 10), ListPatternType.LeadingZero, BookmarkStart.b("刯䜱堳娵崷丹", 10), ListPatternType.Bullet, BookmarkStart.b("帯崱娳匵", 10), ListPatternType.None, BookmarkStart.b("堯圱嘳䐵崷䴹ᄻ༽", 10), ListPatternType.Hebrew1, BookmarkStart.b("堯圱嘳䐵崷䴹ᄻఽ", 10), ListPatternType.Hebrew2, BookmarkStart.b("儯䀱唳吵儷夹ᄻ弽ⰿ㉁ⱃ❅", 10), ListPatternType.ArabicAlpha, 
            BookmarkStart.b("儯䀱唳吵儷夹ᄻ弽∿⡁╃≅", 10), ListPatternType.ArabicAbjad
         }, hashtable_2, hashtable_3);
        Class791.smethod_0(new object[] { BookmarkStart.b("䀯匱䘳圵強䠹崻丽⠿", 10), StyleType.ParagraphStyle, BookmarkStart.b("匯娱唳䐵夷夹䠻嬽㈿", 10), StyleType.CharacterStyle, BookmarkStart.b("䐯匱嘳娵崷", 10), StyleType.TableStyle, BookmarkStart.b("尯嬱䜳䈵", 10), StyleType.ListStyle }, hashtable_6, hashtable_7);
        Class791.smethod_0(new object[] { BookmarkStart.b("尯䀱ᤳ䈵娷", 10), TextDirection.TopToBottom, BookmarkStart.b("䐯倱ᤳ䐵吷", 10), TextDirection.RightToLeft, BookmarkStart.b("尯䀱ᤳ䈵娷᜹䨻", 10), TextDirection.TopToBottomRotated }, hashtable_8, hashtable_9);
        Class791.smethod_0(new object[] { BookmarkStart.b("焯䜱䀳夵", 10), FontFamily.Auto, BookmarkStart.b("琯圱圳夵䨷嬹䠻圽㘿❁", 10), FontFamily.Decorative, BookmarkStart.b("累崱倳匵䨷吹", 10), FontFamily.Modern, BookmarkStart.b("戯崱夳圵嘷", 10), FontFamily.Roman, BookmarkStart.b("振儱䘳張䠷丹", 10), FontFamily.Script, BookmarkStart.b("振䔱崳䔵䬷", 10), FontFamily.Swiss }, hashtable_0, hashtable_1);
        Class791.smethod_0(new object[] { BookmarkStart.b("帯崱䘳嬵夷嘹", 10), FootnoteSeparatorType.Normal, BookmarkStart.b("䌯圱䐳圵䨷嬹䠻儽㈿", 10), FootnoteSeparatorType.FootnoteSeparator, BookmarkStart.b("匯崱娳䈵儷吹䤻弽㐿⭁⭃⡅敇㥉⥋㹍ㅏ⁑㕓≕㝗⡙", 10), FootnoteSeparatorType.FootnoteContinuation, BookmarkStart.b("匯崱娳䈵儷吹䤻弽㐿⭁⭃⡅敇⑉⍋㩍㥏ㅑㅓ", 10), FootnoteSeparatorType.FootnoteContinuationNotice }, hashtable_10, hashtable_11);
        Class791.smethod_0(new object[] { BookmarkStart.b("帯崱䘳嬵夷嘹", 10), FootnoteSeparatorType.Normal, BookmarkStart.b("䌯圱䐳圵䨷嬹䠻儽㈿", 10), FootnoteSeparatorType.EndnoteSeparator, BookmarkStart.b("匯崱娳䈵儷吹䤻弽㐿⭁⭃⡅敇㥉⥋㹍ㅏ⁑㕓≕㝗⡙", 10), FootnoteSeparatorType.EndnoteContinuation, BookmarkStart.b("匯崱娳䈵儷吹䤻弽㐿⭁⭃⡅敇⑉⍋㩍㥏ㅑㅓ", 10), FootnoteSeparatorType.EndnoteContinuationNotice }, hashtable_12, hashtable_13);
    }

    internal static FontFamily smethod_0(string A_0)
    {
        return (FontFamily) Class791.smethod_3(hashtable_0, A_0, FontFamily.Auto);
    }

    internal static string smethod_1(FontFamily A_0)
    {
        return (string) Class791.smethod_3(hashtable_1, A_0, "");
    }

    internal static FootnoteSeparatorType smethod_10(string A_0, bool A_1)
    {
        Hashtable hashtable = A_1 ? hashtable_12 : hashtable_10;
        return (FootnoteSeparatorType) Class791.smethod_3(hashtable, A_0, FootnoteSeparatorType.Normal);
    }

    internal static string smethod_11(FootnoteSeparatorType A_0, bool A_1)
    {
        Hashtable hashtable = A_1 ? hashtable_13 : hashtable_11;
        return (string) Class791.smethod_3(hashtable, A_0, "");
    }

    internal static ListPatternType smethod_12(FootnoteNumberFormat A_0)
    {
        switch (A_0)
        {
            case FootnoteNumberFormat.UpperCaseRoman:
                return ListPatternType.UpRoman;

            case FootnoteNumberFormat.LowerCaseRoman:
                return ListPatternType.LowRoman;

            case FootnoteNumberFormat.UpperCaseLetter:
                return ListPatternType.UpLetter;

            case FootnoteNumberFormat.LowerCaseLetter:
                return ListPatternType.LowLetter;

            case FootnoteNumberFormat.Chicago:
                return ListPatternType.Chicago;

            case FootnoteNumberFormat.DecimalFullWidth:
                return ListPatternType.DecimalFullWidth;

            case FootnoteNumberFormat.DecimalEnclosedCircleChinese:
                return ListPatternType.DecimalEnclosedCircleChinese;

            case FootnoteNumberFormat.IdeographEnclosedCircle:
                return ListPatternType.IdeographEnclosedCircle;

            case FootnoteNumberFormat.IdeographTraditional:
                return ListPatternType.IdeographTraditional;

            case FootnoteNumberFormat.IdeographZodiac:
                return ListPatternType.IdeographZodiac;

            case FootnoteNumberFormat.ChineseLegalSimplified:
                return ListPatternType.ChineseLegalSimplified;

            case FootnoteNumberFormat.ChineseCountingThousand:
                return ListPatternType.ChineseCountingThousand;

            case FootnoteNumberFormat.Hebrew1:
                return ListPatternType.Hebrew1;

            case FootnoteNumberFormat.ArabicAlpha:
                return ListPatternType.ArabicAlpha;

            case FootnoteNumberFormat.Hebrew2:
                return ListPatternType.Hebrew2;

            case FootnoteNumberFormat.ArabicAbjad:
                return ListPatternType.ArabicAbjad;

            case FootnoteNumberFormat.None:
                return ListPatternType.None;
        }
        return ListPatternType.Arabic;
    }

    internal static FootnoteNumberFormat smethod_13(ListPatternType A_0)
    {
        switch (A_0)
        {
            case ListPatternType.UpRoman:
                return FootnoteNumberFormat.UpperCaseRoman;

            case ListPatternType.LowRoman:
                return FootnoteNumberFormat.LowerCaseRoman;

            case ListPatternType.UpLetter:
                return FootnoteNumberFormat.UpperCaseLetter;

            case ListPatternType.LowLetter:
                return FootnoteNumberFormat.LowerCaseLetter;

            case ListPatternType.Chicago:
                return FootnoteNumberFormat.Chicago;

            case ListPatternType.DecimalFullWidth:
                return FootnoteNumberFormat.DecimalFullWidth;

            case ListPatternType.DecimalEnclosedCircleChinese:
                return FootnoteNumberFormat.DecimalEnclosedCircleChinese;

            case ListPatternType.IdeographEnclosedCircle:
                return FootnoteNumberFormat.IdeographEnclosedCircle;

            case ListPatternType.IdeographTraditional:
                return FootnoteNumberFormat.IdeographTraditional;

            case ListPatternType.IdeographZodiac:
                return FootnoteNumberFormat.IdeographZodiac;

            case ListPatternType.ChineseLegalSimplified:
                return FootnoteNumberFormat.ChineseLegalSimplified;

            case ListPatternType.ChineseCountingThousand:
                return FootnoteNumberFormat.ChineseCountingThousand;

            case ListPatternType.Hebrew1:
                return FootnoteNumberFormat.Hebrew1;

            case ListPatternType.ArabicAlpha:
                return FootnoteNumberFormat.ArabicAlpha;

            case ListPatternType.Hebrew2:
                return FootnoteNumberFormat.Hebrew2;

            case ListPatternType.ArabicAbjad:
                return FootnoteNumberFormat.ArabicAbjad;

            case ListPatternType.None:
                return FootnoteNumberFormat.None;
        }
        return FootnoteNumberFormat.Arabic;
    }

    internal static ListPatternType smethod_2(string A_0)
    {
        return (ListPatternType) Class791.smethod_3(hashtable_2, A_0, ListPatternType.Arabic);
    }

    internal static string smethod_3(object A_0)
    {
        return (string) Class791.smethod_3(hashtable_3, A_0, "");
    }

    internal static TextDirection smethod_4(string A_0)
    {
        return (TextDirection) Class791.smethod_3(hashtable_8, A_0, TextDirection.TopToBottom);
    }

    internal static string smethod_5(TextDirection A_0)
    {
        return (string) Class791.smethod_3(hashtable_9, A_0, "");
    }

    internal static BorderStyle smethod_6(string A_0)
    {
        return (BorderStyle) Class791.smethod_3(hashtable_4, A_0, BorderStyle.None);
    }

    internal static string smethod_7(BorderStyle A_0)
    {
        int num = 0x11;
        if (A_0 == BorderStyle.Hairline)
        {
            return BookmarkStart.b("䐶倸唺娼匾⑀", num);
        }
        return (string) Class791.smethod_3(hashtable_5, A_0, BookmarkStart.b("夶嘸唺堼", num));
    }

    internal static StyleType smethod_8(string A_0)
    {
        return (StyleType) Class791.smethod_3(hashtable_6, A_0, StyleType.ParagraphStyle);
    }

    internal static string smethod_9(StyleType A_0)
    {
        return (string) Class791.smethod_3(hashtable_7, A_0, BookmarkStart.b("席儯䀱唳儵䨷嬹䰻嘽", 8));
    }
}

