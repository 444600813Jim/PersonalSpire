using Spire.Doc;
using System;
using System.Collections;
using System.Text;

internal class Class956
{
    private static readonly Hashtable hashtable_0 = new Hashtable();
    private const int int_0 = 9;
    private static readonly int[] int_1 = new int[] { 
        0x20ac, 0x81, 0x201a, 0x192, 0x201e, 0x2026, 0x2020, 0x2021, 710, 0x2030, 0x160, 0x2039, 0x152, 0x8d, 0x17d, 0x8f, 
        0x90, 0x2018, 0x2019, 0x201c, 0x201d, 0x2022, 0x2013, 0x2014, 0x2dc, 0x2122, 0x161, 0x203a, 0x153, 0x9d, 0x17e, 0x178
     };

    static Class956()
    {
        hashtable_0.Add(BookmarkStart.b("䌬䴮䈰䌲", 7), 160);
        hashtable_0.Add(BookmarkStart.b("䐬䨮䤰倲头", 7), 0xa1);
        hashtable_0.Add(BookmarkStart.b("丬䨮弰䜲", 7), 0xa2);
        hashtable_0.Add(BookmarkStart.b("崬䀮䐰崲儴", 7), 0xa3);
        hashtable_0.Add(BookmarkStart.b("丬娮䌰䄲倴夶", 7), 0xa4);
        hashtable_0.Add(BookmarkStart.b("听䨮弰", 7), 0xa5);
        hashtable_0.Add(BookmarkStart.b("伬崮䜰儲吴䔶", 7), 0xa6);
        hashtable_0.Add(BookmarkStart.b("帬䨮到䜲", 7), 0xa7);
        hashtable_0.Add(BookmarkStart.b("堬䈮崰", 7), 0xa8);
        hashtable_0.Add(BookmarkStart.b("丬䀮䄰䨲", 7), 0xa9);
        hashtable_0.Add(BookmarkStart.b("䈬崮唰唲", 7), 170);
        hashtable_0.Add(BookmarkStart.b("䄬丮䀰䘲娴", 7), 0xab);
        hashtable_0.Add(BookmarkStart.b("䌬䀮䔰", 7), 0xac);
        hashtable_0.Add(BookmarkStart.b("帬䜮䠰", 7), 0xad);
        hashtable_0.Add(BookmarkStart.b("弬䨮嘰", 7), 0xae);
        hashtable_0.Add(BookmarkStart.b("䀬丮到䄲", 7), 0xaf);
        hashtable_0.Add(BookmarkStart.b("䤬䨮嘰", 7), 0xb0);
        hashtable_0.Add(BookmarkStart.b("崬䌮䐰䀲場夶", 7), 0xb1);
        hashtable_0.Add(BookmarkStart.b("帬娮䄰Ĳ", 7), 0xb2);
        hashtable_0.Add(BookmarkStart.b("帬娮䄰2", 7), 0xb3);
        hashtable_0.Add(BookmarkStart.b("䰬䰮䐰䜲倴", 7), 180);
        hashtable_0.Add(BookmarkStart.b("䀬䘮到䄲娴", 7), 0xb5);
        hashtable_0.Add(BookmarkStart.b("崬丮䌰刲", 7), 0xb6);
        hashtable_0.Add(BookmarkStart.b("䀬䘮唰圲娴䌶", 7), 0xb7);
        hashtable_0.Add(BookmarkStart.b("丬䨮唰娲头", 7), 0xb8);
        hashtable_0.Add(BookmarkStart.b("帬娮䄰Ȳ", 7), 0xb9);
        hashtable_0.Add(BookmarkStart.b("䈬崮唰帲", 7), 0xba);
        hashtable_0.Add(BookmarkStart.b("弬丮䀰䘲娴", 7), 0xbb);
        hashtable_0.Add(BookmarkStart.b("䬬崮倰倲д̶", 7), 0xbc);
        hashtable_0.Add(BookmarkStart.b("䬬崮倰倲дԶ", 7), 0xbd);
        hashtable_0.Add(BookmarkStart.b("䬬崮倰倲ش̶", 7), 190);
        hashtable_0.Add(BookmarkStart.b("䐬帮䐰嘲䘴䌶", 7), 0xbf);
        hashtable_0.Add(BookmarkStart.b("氬䠮䌰刲䌴制", 7), 0xc0);
        hashtable_0.Add(BookmarkStart.b("氬丮到䘲䄴制", 7), 0xc1);
        hashtable_0.Add(BookmarkStart.b("氬䰮堰䄲嘴", 7), 0xc2);
        hashtable_0.Add(BookmarkStart.b("氬嬮堰弲儴制", 7), 0xc3);
        hashtable_0.Add(BookmarkStart.b("氬娮尰弲", 7), 0xc4);
        hashtable_0.Add(BookmarkStart.b("氬崮堰崲刴", 7), 0xc5);
        hashtable_0.Add(BookmarkStart.b("氬樮崰娲刴", 7), 0xc6);
        hashtable_0.Add(BookmarkStart.b("測䰮吰圲尴嬶", 7), 0xc7);
        hashtable_0.Add(BookmarkStart.b("栬䠮䌰刲䌴制", 7), 200);
        hashtable_0.Add(BookmarkStart.b("栬丮到䘲䄴制", 7), 0xc9);
        hashtable_0.Add(BookmarkStart.b("栬䰮堰䄲嘴", 7), 0xca);
        hashtable_0.Add(BookmarkStart.b("栬娮尰弲", 7), 0xcb);
        hashtable_0.Add(BookmarkStart.b("搬䠮䌰刲䌴制", 7), 0xcc);
        hashtable_0.Add(BookmarkStart.b("搬丮到䘲䄴制", 7), 0xcd);
        hashtable_0.Add(BookmarkStart.b("搬䰮堰䄲嘴", 7), 0xce);
        hashtable_0.Add(BookmarkStart.b("搬娮尰弲", 7), 0xcf);
        hashtable_0.Add(BookmarkStart.b("栬笮礰", 7), 0xd0);
        hashtable_0.Add(BookmarkStart.b("挬嬮堰弲儴制", 7), 0xd1);
        hashtable_0.Add(BookmarkStart.b("戬䠮䌰刲䌴制", 7), 210);
        hashtable_0.Add(BookmarkStart.b("戬丮到䘲䄴制", 7), 0xd3);
        hashtable_0.Add(BookmarkStart.b("戬䰮堰䄲嘴", 7), 0xd4);
        hashtable_0.Add(BookmarkStart.b("戬嬮堰弲儴制", 7), 0xd5);
        hashtable_0.Add(BookmarkStart.b("戬娮尰弲", 7), 0xd6);
        hashtable_0.Add(BookmarkStart.b("夬䘮尰嘲䘴", 7), 0xd7);
        hashtable_0.Add(BookmarkStart.b("戬尮崰刲䘴弶", 7), 0xd8);
        hashtable_0.Add(BookmarkStart.b("砬䠮䌰刲䌴制", 7), 0xd9);
        hashtable_0.Add(BookmarkStart.b("砬丮到䘲䄴制", 7), 0xda);
        hashtable_0.Add(BookmarkStart.b("砬䰮堰䄲嘴", 7), 0xdb);
        hashtable_0.Add(BookmarkStart.b("砬娮尰弲", 7), 220);
        hashtable_0.Add(BookmarkStart.b("琬丮到䘲䄴制", 7), 0xdd);
        hashtable_0.Add(BookmarkStart.b("礬朮縰愲笴", 7), 0xde);
        hashtable_0.Add(BookmarkStart.b("帬售崰娲刴", 7), 0xdf);
        hashtable_0.Add(BookmarkStart.b("䰬䠮䌰刲䌴制", 7), 0xe0);
        hashtable_0.Add(BookmarkStart.b("䰬丮到䘲䄴制", 7), 0xe1);
        hashtable_0.Add(BookmarkStart.b("䰬䰮堰䄲嘴", 7), 0xe2);
        hashtable_0.Add(BookmarkStart.b("䰬嬮堰弲儴制", 7), 0xe3);
        hashtable_0.Add(BookmarkStart.b("䰬娮尰弲", 7), 0xe4);
        hashtable_0.Add(BookmarkStart.b("䰬崮堰崲刴", 7), 0xe5);
        hashtable_0.Add(BookmarkStart.b("䰬䨮崰娲刴", 7), 230);
        hashtable_0.Add(BookmarkStart.b("丬䰮吰圲尴嬶", 7), 0xe7);
        hashtable_0.Add(BookmarkStart.b("䠬䠮䌰刲䌴制", 7), 0xe8);
        hashtable_0.Add(BookmarkStart.b("䠬丮到䘲䄴制", 7), 0xe9);
        hashtable_0.Add(BookmarkStart.b("䠬䰮堰䄲嘴", 7), 0xea);
        hashtable_0.Add(BookmarkStart.b("䠬娮尰弲", 7), 0xeb);
        hashtable_0.Add(BookmarkStart.b("䐬䠮䌰刲䌴制", 7), 0xec);
        hashtable_0.Add(BookmarkStart.b("䐬丮到䘲䄴制", 7), 0xed);
        hashtable_0.Add(BookmarkStart.b("䐬䰮堰䄲嘴", 7), 0xee);
        hashtable_0.Add(BookmarkStart.b("䐬娮尰弲", 7), 0xef);
        hashtable_0.Add(BookmarkStart.b("䠬嬮夰", 7), 240);
        hashtable_0.Add(BookmarkStart.b("䌬嬮堰弲儴制", 7), 0xf1);
        hashtable_0.Add(BookmarkStart.b("䈬䠮䌰刲䌴制", 7), 0xf2);
        hashtable_0.Add(BookmarkStart.b("䈬丮到䘲䄴制", 7), 0xf3);
        hashtable_0.Add(BookmarkStart.b("䈬䰮堰䄲嘴", 7), 0xf4);
        hashtable_0.Add(BookmarkStart.b("䈬嬮堰弲儴制", 7), 0xf5);
        hashtable_0.Add(BookmarkStart.b("䈬娮尰弲", 7), 0xf6);
        hashtable_0.Add(BookmarkStart.b("䤬䘮䜰娲儴制", 7), 0xf7);
        hashtable_0.Add(BookmarkStart.b("䈬尮崰刲䘴弶", 7), 0xf8);
        hashtable_0.Add(BookmarkStart.b("堬䠮䌰刲䌴制", 7), 0xf9);
        hashtable_0.Add(BookmarkStart.b("堬丮到䘲䄴制", 7), 250);
        hashtable_0.Add(BookmarkStart.b("堬䰮堰䄲嘴", 7), 0xfb);
        hashtable_0.Add(BookmarkStart.b("堬娮尰弲", 7), 0xfc);
        hashtable_0.Add(BookmarkStart.b("听丮到䘲䄴制", 7), 0xfd);
        hashtable_0.Add(BookmarkStart.b("夬䜮帰䄲嬴", 7), 0xfe);
        hashtable_0.Add(BookmarkStart.b("听娮尰弲", 7), 0xff);
        hashtable_0.Add(BookmarkStart.b("䬬䄮帰唲", 7), 0x192);
        hashtable_0.Add(BookmarkStart.b("氬䌮䄰嬲吴", 7), 0x391);
        hashtable_0.Add(BookmarkStart.b("漬䨮䔰刲", 7), 0x392);
        hashtable_0.Add(BookmarkStart.b("樬丮尰帲吴", 7), 0x393);
        hashtable_0.Add(BookmarkStart.b("椬䨮崰䜲吴", 7), 0x394);
        hashtable_0.Add(BookmarkStart.b("栬弮䈰娲头堶圸", 7), 0x395);
        hashtable_0.Add(BookmarkStart.b("眬䨮䔰刲", 7), 0x396);
        hashtable_0.Add(BookmarkStart.b("栬嬮倰", 7), 0x397);
        hashtable_0.Add(BookmarkStart.b("礬䜮吰䜲吴", 7), 920);
        hashtable_0.Add(BookmarkStart.b("搬䀮䔰刲", 7), 0x399);
        hashtable_0.Add(BookmarkStart.b("昬丮䄰䌲吴", 7), 0x39a);
        hashtable_0.Add(BookmarkStart.b("愬丮尰儲儴嘶", 7), 0x39b);
        hashtable_0.Add(BookmarkStart.b("怬娮", 7), 0x39c);
        hashtable_0.Add(BookmarkStart.b("挬娮", 7), 0x39d);
        hashtable_0.Add(BookmarkStart.b("甬䘮", 7), 0x39e);
        hashtable_0.Add(BookmarkStart.b("戬䈮堰倲䜴堶圸", 7), 0x39f);
        hashtable_0.Add(BookmarkStart.b("紬䘮", 7), 0x3a0);
        hashtable_0.Add(BookmarkStart.b("缬䜮帰", 7), 0x3a1);
        hashtable_0.Add(BookmarkStart.b("縬䘮嘰帲吴", 7), 0x3a3);
        hashtable_0.Add(BookmarkStart.b("礬丮䐰", 7), 0x3a4);
        hashtable_0.Add(BookmarkStart.b("砬弮䈰娲头堶圸", 7), 0x3a5);
        hashtable_0.Add(BookmarkStart.b("紬䜮堰", 7), 0x3a6);
        hashtable_0.Add(BookmarkStart.b("測䜮堰", 7), 0x3a7);
        hashtable_0.Add(BookmarkStart.b("紬尮堰", 7), 0x3a8);
        hashtable_0.Add(BookmarkStart.b("戬䈮吰吲吴", 7), 0x3a9);
        hashtable_0.Add(BookmarkStart.b("䰬䌮䄰嬲吴", 7), 0x3b1);
        hashtable_0.Add(BookmarkStart.b("伬䨮䔰刲", 7), 0x3b2);
        hashtable_0.Add(BookmarkStart.b("䨬丮尰帲吴", 7), 0x3b3);
        hashtable_0.Add(BookmarkStart.b("䤬䨮崰䜲吴", 7), 0x3b4);
        hashtable_0.Add(BookmarkStart.b("䠬弮䈰娲头堶圸", 7), 0x3b5);
        hashtable_0.Add(BookmarkStart.b("圬䨮䔰刲", 7), 950);
        hashtable_0.Add(BookmarkStart.b("䠬嬮倰", 7), 0x3b7);
        hashtable_0.Add(BookmarkStart.b("夬䜮吰䜲吴", 7), 0x3b8);
        hashtable_0.Add(BookmarkStart.b("䐬䀮䔰刲", 7), 0x3b9);
        hashtable_0.Add(BookmarkStart.b("䘬丮䄰䌲吴", 7), 0x3ba);
        hashtable_0.Add(BookmarkStart.b("䄬丮尰儲儴嘶", 7), 0x3bb);
        hashtable_0.Add(BookmarkStart.b("䀬娮", 7), 0x3bc);
        hashtable_0.Add(BookmarkStart.b("䌬娮", 7), 0x3bd);
        hashtable_0.Add(BookmarkStart.b("唬䘮", 7), 0x3be);
        hashtable_0.Add(BookmarkStart.b("䈬䈮堰倲䜴堶圸", 7), 0x3bf);
        hashtable_0.Add(BookmarkStart.b("崬䘮", 7), 960);
        hashtable_0.Add(BookmarkStart.b("弬䜮帰", 7), 0x3c1);
        hashtable_0.Add(BookmarkStart.b("帬䘮嘰帲吴儶", 7), 0x3c2);
        hashtable_0.Add(BookmarkStart.b("帬䘮嘰帲吴", 7), 0x3c3);
        hashtable_0.Add(BookmarkStart.b("夬丮䐰", 7), 0x3c4);
        hashtable_0.Add(BookmarkStart.b("堬弮䈰娲头堶圸", 7), 0x3c5);
        hashtable_0.Add(BookmarkStart.b("崬䜮堰", 7), 0x3c6);
        hashtable_0.Add(BookmarkStart.b("丬䜮堰", 7), 0x3c7);
        hashtable_0.Add(BookmarkStart.b("崬尮堰", 7), 0x3c8);
        hashtable_0.Add(BookmarkStart.b("䈬䈮吰吲吴", 7), 0x3c9);
        hashtable_0.Add(BookmarkStart.b("夬䜮吰䜲吴䐶䀸嘺", 7), 0x3d1);
        hashtable_0.Add(BookmarkStart.b("堬弮䈰娲崴", 7), 0x3d2);
        hashtable_0.Add(BookmarkStart.b("崬䘮䜰", 7), 0x3d6);
        hashtable_0.Add(BookmarkStart.b("伬娮崰弲", 7), 0x2022);
        hashtable_0.Add(BookmarkStart.b("䔬䨮崰弲尴䜶", 7), 0x2026);
        hashtable_0.Add(BookmarkStart.b("崬崮堰帲倴", 7), 0x2032);
        hashtable_0.Add(BookmarkStart.b("紬崮堰帲倴", 7), 0x2033);
        hashtable_0.Add(BookmarkStart.b("䈬䌮堰崲倴", 7), 0x203e);
        hashtable_0.Add(BookmarkStart.b("䬬崮倰䀲头", 7), 0x2044);
        hashtable_0.Add(BookmarkStart.b("娬䨮堰嘲䜴䜶", 7), 0x2118);
        hashtable_0.Add(BookmarkStart.b("䐬䈮倰吲倴", 7), 0x2111);
        hashtable_0.Add(BookmarkStart.b("弬䨮倰弲", 7), 0x211c);
        hashtable_0.Add(BookmarkStart.b("夬崮倰圲倴", 7), 0x2122);
        hashtable_0.Add(BookmarkStart.b("䰬䌮吰唲䘴丶吸", 7), 0x2135);
        hashtable_0.Add(BookmarkStart.b("䄬丮䌰䄲", 7), 0x2190);
        hashtable_0.Add(BookmarkStart.b("堬丮䌰䄲", 7), 0x2191);
        hashtable_0.Add(BookmarkStart.b("弬丮䌰䄲", 7), 0x2192);
        hashtable_0.Add(BookmarkStart.b("䤬丮䌰䄲", 7), 0x2193);
        hashtable_0.Add(BookmarkStart.b("䔬丮䌰䄲", 7), 0x2194);
        hashtable_0.Add(BookmarkStart.b("丬崮倰䄲䜴", 7), 0x21b5);
        hashtable_0.Add(BookmarkStart.b("䄬渮䌰䄲", 7), 0x21d0);
        hashtable_0.Add(BookmarkStart.b("堬渮䌰䄲", 7), 0x21d1);
        hashtable_0.Add(BookmarkStart.b("弬渮䌰䄲", 7), 0x21d2);
        hashtable_0.Add(BookmarkStart.b("䤬渮䌰䄲", 7), 0x21d3);
        hashtable_0.Add(BookmarkStart.b("䔬渮䌰䄲", 7), 0x21d4);
        hashtable_0.Add(BookmarkStart.b("䬬䀮䌰刲头嬶", 7), 0x2200);
        hashtable_0.Add(BookmarkStart.b("崬丮䌰䜲", 7), 0x2202);
        hashtable_0.Add(BookmarkStart.b("䠬圮堰䀲䄴", 7), 0x2203);
        hashtable_0.Add(BookmarkStart.b("䠬䈮䄰䜲䰴", 7), 0x2205);
        hashtable_0.Add(BookmarkStart.b("䌬丮匰弲吴", 7), 0x2207);
        hashtable_0.Add(BookmarkStart.b("䐬尮堰崲", 7), 0x2208);
        hashtable_0.Add(BookmarkStart.b("䌬䀮䔰娲嬴", 7), 0x2209);
        hashtable_0.Add(BookmarkStart.b("䌬䘮", 7), 0x220b);
        hashtable_0.Add(BookmarkStart.b("崬崮帰圲", 7), 0x220f);
        hashtable_0.Add(BookmarkStart.b("帬娮尰", 7), 0x2211);
        hashtable_0.Add(BookmarkStart.b("䀬䘮弰䘲䘴", 7), 0x2212);
        hashtable_0.Add(BookmarkStart.b("䄬䀮䘰刲䘴䌶", 7), 0x2217);
        hashtable_0.Add(BookmarkStart.b("弬丮唰娲嘴", 7), 0x221a);
        hashtable_0.Add(BookmarkStart.b("崬崮帰䌲", 7), 0x221d);
        hashtable_0.Add(BookmarkStart.b("䐬䄮地娲嬴", 7), 0x221e);
        hashtable_0.Add(BookmarkStart.b("䰬䄮嘰", 7), 0x2220);
        hashtable_0.Add(BookmarkStart.b("䰬䄮唰", 7), 0x2227);
        hashtable_0.Add(BookmarkStart.b("䈬崮", 7), 0x2228);
        hashtable_0.Add(BookmarkStart.b("丬丮䄰", 7), 0x2229);
        hashtable_0.Add(BookmarkStart.b("丬娮䄰", 7), 0x222a);
        hashtable_0.Add(BookmarkStart.b("䐬䄮䔰", 7), 0x222b);
        hashtable_0.Add(BookmarkStart.b("夬䜮吰䄲倴̶", 7), 0x2234);
        hashtable_0.Add(BookmarkStart.b("帬䘮尰", 7), 0x223c);
        hashtable_0.Add(BookmarkStart.b("丬䀮弰吲", 7), 0x2245);
        hashtable_0.Add(BookmarkStart.b("䰬尮䠰帲䔴", 7), 0x2248);
        hashtable_0.Add(BookmarkStart.b("䌬䨮", 7), 0x2260);
        hashtable_0.Add(BookmarkStart.b("䠬帮䐰娲䌴", 7), 0x2261);
        hashtable_0.Add(BookmarkStart.b("䄬䨮", 7), 0x2264);
        hashtable_0.Add(BookmarkStart.b("䨬䨮", 7), 0x2265);
        hashtable_0.Add(BookmarkStart.b("帬娮匰", 7), 0x2282);
        hashtable_0.Add(BookmarkStart.b("帬娮䄰", 7), 0x2283);
        hashtable_0.Add(BookmarkStart.b("䌬尮䐰儲", 7), 0x2284);
        hashtable_0.Add(BookmarkStart.b("帬娮匰嘲", 7), 0x2286);
        hashtable_0.Add(BookmarkStart.b("帬娮䄰嘲", 7), 0x2287);
        hashtable_0.Add(BookmarkStart.b("䈬弮崰䘲䘴", 7), 0x2295);
        hashtable_0.Add(BookmarkStart.b("䈬嬮堰帲倴䐶", 7), 0x2297);
        hashtable_0.Add(BookmarkStart.b("崬䨮䌰䌲", 7), 0x22a5);
        hashtable_0.Add(BookmarkStart.b("帬䬮帰䜲", 7), 0x22c5);
        hashtable_0.Add(BookmarkStart.b("䄬䰮吰娲头", 7), 0x2308);
        hashtable_0.Add(BookmarkStart.b("弬䰮吰娲头", 7), 0x2309);
        hashtable_0.Add(BookmarkStart.b("䄬䤮崰尲娴䔶", 7), 0x230a);
        hashtable_0.Add(BookmarkStart.b("弬䤮崰尲娴䔶", 7), 0x230b);
        hashtable_0.Add(BookmarkStart.b("䄬丮弰吲", 7), 0x2329);
        hashtable_0.Add(BookmarkStart.b("弬丮弰吲", 7), 0x232a);
        hashtable_0.Add(BookmarkStart.b("䄬䀮䬰", 7), 0x25ca);
        hashtable_0.Add(BookmarkStart.b("帬弮倰圲倴䐶", 7), 0x2660);
        hashtable_0.Add(BookmarkStart.b("丬䌮䐰儲䘴", 7), 0x2663);
        hashtable_0.Add(BookmarkStart.b("䔬䨮倰䄲䄴䐶", 7), 0x2665);
        hashtable_0.Add(BookmarkStart.b("䤬䘮倰帲䘴", 7), 0x2666);
        hashtable_0.Add(BookmarkStart.b("尬娮帰䜲", 7), 0x22);
        hashtable_0.Add(BookmarkStart.b("䰬䈮䄰", 7), 0x26);
        hashtable_0.Add(BookmarkStart.b("䄬嬮", 7), 60);
        hashtable_0.Add(BookmarkStart.b("䨬嬮", 7), 0x3e);
        hashtable_0.Add(BookmarkStart.b("戬樮崰娲刴", 7), 0x152);
        hashtable_0.Add(BookmarkStart.b("䈬䨮崰娲刴", 7), 0x153);
        hashtable_0.Add(BookmarkStart.b("縬䰮倰䄲娴夶", 7), 0x160);
        hashtable_0.Add(BookmarkStart.b("帬䰮倰䄲娴夶", 7), 0x161);
        hashtable_0.Add(BookmarkStart.b("琬娮尰弲", 7), 0x178);
        hashtable_0.Add(BookmarkStart.b("丬䘮䌰倲", 7), 710);
        hashtable_0.Add(BookmarkStart.b("夬䘮崰圲倴", 7), 0x2dc);
        hashtable_0.Add(BookmarkStart.b("䠬䄮䈰䌲", 7), 0x2002);
        hashtable_0.Add(BookmarkStart.b("䠬䈮䈰䌲", 7), 0x2003);
        hashtable_0.Add(BookmarkStart.b("夬䜮堰崲䘴䜶", 7), 0x2009);
        hashtable_0.Add(BookmarkStart.b("圬堮弰夲", 7), 0x200c);
        hashtable_0.Add(BookmarkStart.b("圬堮嬰", 7), 0x200d);
        hashtable_0.Add(BookmarkStart.b("䄬崮尰", 7), 0x200e);
        hashtable_0.Add(BookmarkStart.b("弬䌮尰", 7), 0x200f);
        hashtable_0.Add(BookmarkStart.b("䌬䬮倰䀲崴", 7), 0x2013);
        hashtable_0.Add(BookmarkStart.b("䀬䬮倰䀲崴", 7), 0x2014);
        hashtable_0.Add(BookmarkStart.b("䄬尮䀰䘲娴", 7), 0x2018);
        hashtable_0.Add(BookmarkStart.b("弬尮䀰䘲娴", 7), 0x2019);
        hashtable_0.Add(BookmarkStart.b("帬䴮䀰䘲娴", 7), 0x201a);
        hashtable_0.Add(BookmarkStart.b("䄬䬮䀰䘲娴", 7), 0x201c);
        hashtable_0.Add(BookmarkStart.b("弬䬮䀰䘲娴", 7), 0x201d);
        hashtable_0.Add(BookmarkStart.b("伬䬮䀰䘲娴", 7), 0x201e);
        hashtable_0.Add(BookmarkStart.b("䤬丮嘰吲倴䔶", 7), 0x2020);
        hashtable_0.Add(BookmarkStart.b("椬丮嘰吲倴䔶", 7), 0x2021);
        hashtable_0.Add(BookmarkStart.b("崬䨮䌰帲尴嬶", 7), 0x2030);
        hashtable_0.Add(BookmarkStart.b("䄬尮倰䈲䀴堶", 7), 0x2039);
        hashtable_0.Add(BookmarkStart.b("弬尮倰䈲䀴堶", 7), 0x203a);
        hashtable_0.Add(BookmarkStart.b("䠬娮䌰尲", 7), 0x20ac);
    }

    private Class956()
    {
    }

    internal static string smethod_0(string A_0)
    {
        int num = 8;
        if (A_0 == null)
        {
            return null;
        }
        if (A_0.Length == 0)
        {
            return A_0;
        }
        StringBuilder builder2 = new StringBuilder(A_0.Length);
        ParseState text = ParseState.Text;
        StringBuilder builder = new StringBuilder(10);
        int num2 = 0;
    Label_002E:
        if (num2 >= A_0.Length)
        {
            if (text == ParseState.EntityStart)
            {
                builder2.Append(BookmarkStart.b("࠭", num) + builder);
            }
            return builder2.ToString();
        }
        switch (text)
        {
            case ParseState.Text:
            {
                char ch = A_0[num2];
                if (ch != '&')
                {
                    builder2.Append(A_0[num2]);
                }
                else
                {
                    text = ParseState.EntityStart;
                }
                goto Label_0224;
            }
            case ParseState.EntityStart:
            {
                char ch2 = A_0[num2];
                if (ch2 == '&')
                {
                    builder2.Append(BookmarkStart.b("࠭", num) + builder);
                    builder.Remove(0, builder.Length);
                    goto Label_0224;
                }
                if (ch2 != ';')
                {
                    builder.Append(A_0[num2]);
                    if (builder.Length > 9)
                    {
                        text = ParseState.Text;
                        builder2.Append(BookmarkStart.b("࠭", num) + builder);
                        builder.Remove(0, builder.Length);
                    }
                    goto Label_0224;
                }
                if (builder.Length != 0)
                {
                    if (builder[0] == '#')
                    {
                        try
                        {
                            if ((builder[1] != 'x') && (builder[1] != 'X'))
                            {
                                int num5 = Class1041.smethod_23(builder.ToString(1, builder.Length - 1));
                                builder2.Append(smethod_1(num5));
                            }
                            else
                            {
                                int num4 = Class1041.smethod_26(builder.ToString(2, builder.Length - 2));
                                builder2.Append(smethod_1(num4));
                            }
                        }
                        catch
                        {
                            builder2.Append(BookmarkStart.b("࠭", num) + builder.ToString() + BookmarkStart.b("ᔭ", num));
                        }
                    }
                    else
                    {
                        object obj2 = hashtable_0[builder.ToString()];
                        if (obj2 == null)
                        {
                            builder2.Append(BookmarkStart.b("࠭", num) + builder + BookmarkStart.b("ᔭ", num));
                        }
                        else
                        {
                            int num3 = (int) obj2;
                            builder2.Append((char) num3);
                        }
                    }
                    builder.Remove(0, builder.Length);
                    break;
                }
                builder2.Append(BookmarkStart.b("࠭ଯ", num));
                break;
            }
            default:
                goto Label_0224;
        }
        text = ParseState.Text;
    Label_0224:
        num2++;
        goto Label_002E;
    }

    private static char smethod_1(int A_0)
    {
        int num = (0x80 + int_1.Length) - 1;
        if ((A_0 >= 0x80) && (A_0 <= num))
        {
            return (char) int_1[A_0 - 0x80];
        }
        return (char) A_0;
    }

    private enum ParseState
    {
        Text,
        EntityStart
    }
}

