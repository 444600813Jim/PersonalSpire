using Spire.Doc;
using Spire.Doc.Documents;
using Spire.Doc.Fields;
using Spire.Doc.Fields.Caculation;
using System;
using System.Collections;
using System.Text;

internal class Class1136
{
    private const char char_0 = '̂';
    private const char char_1 = '∫';
    private const char char_2 = '&';
    private const char char_3 = '|';
    private const char char_4 = '⏞';
    private readonly Class400 class400_0;
    private readonly Class422 class422_0;
    private static readonly int[] int_0 = new int[] { 
        40, 0x29, 0x5b, 0x5d, 0x7b, 0x7d, 0x2b, 0x2d, 0x2a, 0x2f, 0x5e, 0x3d, 0x3e, 60, 0x3b, 0x2c, 
        0x2e, 0x3a, 0x27, 0x60, 0x5f, 0x7e, 0x25, 0x40, 0x3f, 0x21, 0x7c, 0x5c, 0x2018, 0x2019, 0x201c, 0x201d, 
        0x2016, 0x2016, 0x2308, 0x2309, 0x230a, 0x230b, 0x2772, 0x2773, 0x27e6, 0x27e7, 0x27e8, 0x27e9, 0x27ea, 0x27eb, 0x27ec, 0x27ed, 
        0x27ee, 0x27ef, 0x2980, 0x2980, 0x2983, 0x2984, 0x2985, 0x2986, 0x2987, 0x2988, 0x2989, 0x298a, 0x298b, 0x298c, 0x298d, 0x298e, 
        0x298f, 0x2990, 0x2991, 0x2992, 0x2993, 0x2994, 0x2995, 0x2996, 0x2997, 0x2998, 0x29fc, 0x29fd, 0x2063, 0x2234, 0x2235, 0x3f6, 
        0x2026, 0x22ee, 0x22ef, 0x22f1, 0x220b, 0x22a2, 0x22a3, 0x22a4, 0x22a8, 0x22a9, 0x22ac, 0x22ad, 0x22ae, 0x22af, 0x2228, 0x2227, 
        0x2200, 0x2203, 0x2204, 0x2201, 0x2208, 0x2209, 0x220c, 0x2282, 0x2282, 0x20d2, 0x2283, 0x2283, 0x20d2, 0x2284, 0x2285, 0x2286, 
        0x2287, 0x2288, 0x2289, 0x228a, 0x228b, 0x2264, 0x2265, 0x226f, 0x226e, 0x2248, 0x223c, 0x2249, 0x2262, 0x2260, 0x221d, 0x2224, 
        0x2225, 0x2226, 0x2241, 0x2243, 0x2244, 0x2245, 0x2246, 0x2247, 0x224d, 0x2254, 0x2257, 0x2259, 0x225a, 0x225c, 0x225f, 0x2261, 
        0x2268, 0x2269, 0x226a, 0x226a, 0x338, 0x226b, 0x226b, 0x338, 0x226d, 0x2270, 0x2271, 0x227a, 0x227b, 0x227c, 0x227d, 0x2280, 
        0x2281, 0x22a5, 0x22b4, 0x22b5, 0x22c9, 0x22ca, 0x22cb, 0x22cc, 0x22d4, 0x22d6, 0x22d7, 0x22d8, 0x22d9, 0x22ea, 0x22eb, 0x22ec, 
        0x22ed, 0x25a0, 0x25a1, 0x25aa, 0x25ab, 0x25ad, 0x25ae, 0x25af, 0x25b0, 0x25b1, 0x25b3, 0x25b4, 0x25b5, 0x25b6, 0x25b7, 0x25b8, 
        0x25b9, 0x25bc, 0x25bd, 0x25be, 0x25bf, 0x25c0, 0x25c1, 0x25c2, 0x25c3, 0x25c4, 0x25c5, 0x25c6, 0x25c7, 0x25c8, 0x25c9, 0x25cc, 
        0x25cd, 0x25ce, 0x25cf, 0x25d6, 0x25d7, 0x25e6, 0x29c0, 0x29c1, 0x29e3, 0x29e4, 0x29e5, 0x29e6, 0x29f3, 0x2a87, 0x2a88, 0x2aaf, 
        0x2aaf, 0x338, 0x2ab0, 0x2ab0, 0x338, 0x2044, 0x2206, 0x220a, 0x220d, 0x220e, 0x2215, 0x2217, 0x2218, 0x2219, 0x221f, 0x2223, 
        0x2236, 0x2237, 0x2238, 0x2239, 0x223a, 0x223b, 0x223d, 0x223d, 0x331, 0x223e, 0x223f, 0x2242, 0x2242, 0x338, 0x224a, 0x224b, 
        0x224c, 0x224e, 0x224e, 0x338, 0x224f, 0x224f, 0x338, 0x2250, 0x2251, 0x2252, 0x2253, 0x2255, 0x2256, 0x2258, 0x225d, 0x225e, 
        0x2263, 0x2266, 0x2266, 0x338, 0x2267, 0x226c, 0x2272, 0x2273, 0x2274, 0x2275, 0x2276, 0x2277, 0x2278, 0x2279, 0x227e, 0x227f, 
        0x227f, 0x338, 0x228c, 0x228d, 0x228e, 0x228f, 0x228f, 0x338, 0x2290, 0x2290, 0x338, 0x2291, 0x2292, 0x2293, 0x2294, 0x229a, 
        0x229b, 0x229c, 0x229d, 0x22a6, 0x22a7, 0x22aa, 0x22ab, 0x22b0, 0x22b1, 0x22b2, 0x22b3, 0x22b6, 0x22b7, 0x22b9, 0x22ba, 0x22bb, 
        0x22bc, 0x22bd, 0x22be, 0x22bf, 0x22c4, 0x22c6, 0x22c7, 0x22c8, 0x22cd, 0x22ce, 0x22cf, 0x22d0, 0x22d1, 0x22d2, 0x22d3, 0x22d5, 
        0x22da, 0x22db, 0x22dc, 0x22dd, 0x22de, 0x22df, 0x22e0, 0x22e1, 0x22e2, 0x22e3, 0x22e4, 0x22e5, 0x22e6, 0x22e7, 0x22e8, 0x22e9, 
        0x22f0, 0x22f2, 0x22f3, 0x22f4, 0x22f5, 0x22f6, 0x22f7, 0x22f8, 0x22f9, 0x22fa, 0x22fb, 0x22fc, 0x22fd, 0x22fe, 0x22ff, 0x25b2, 
        0x2758, 0x2981, 0x2982, 0x29a0, 0x29a1, 0x29a2, 0x29a3, 0x29a4, 0x29a5, 0x29a6, 0x29a7, 0x29a8, 0x29a9, 0x29aa, 0x29ab, 0x29ac, 
        0x29ad, 0x29ae, 0x29af, 0x29b0, 0x29b1, 0x29b2, 0x29b3, 0x29b4, 0x29b5, 0x29b6, 0x29b7, 0x29b8, 0x29b9, 0x29ba, 0x29bb, 0x29bc, 
        0x29bd, 0x29be, 0x29bf, 0x29c2, 0x29c3, 0x29c4, 0x29c5, 0x29c6, 0x29c7, 0x29c8, 0x29c9, 0x29ca, 0x29cb, 0x29cc, 0x29cd, 0x29ce, 
        0x29cf, 0x29cf, 0x338, 0x29d0, 0x29d0, 0x338, 0x29d1, 0x29d2, 0x29d3, 0x29d4, 0x29d5, 0x29d6, 0x29d7, 0x29d8, 0x29d9, 0x29db, 
        0x29dc, 0x29dd, 0x29de, 0x29e0, 0x29e1, 0x29e2, 0x29e7, 0x29e8, 0x29e9, 0x29ea, 0x29eb, 0x29ec, 0x29ed, 0x29ee, 0x29f0, 0x29f1, 
        0x29f2, 0x29f5, 0x29f6, 0x29f7, 0x29f8, 0x29f9, 0x29fa, 0x29fb, 0x29fe, 0x29ff, 0x2a1d, 0x2a1e, 0x2a1f, 0x2a20, 0x2a21, 0x2a22, 
        0x2a23, 0x2a24, 0x2a25, 0x2a26, 0x2a27, 0x2a28, 0x2a29, 0x2a2a, 0x2a2b, 0x2a2c, 0x2a2d, 0x2a2e, 0x2a30, 0x2a31, 0x2a32, 0x2a33, 
        0x2a34, 0x2a35, 0x2a36, 0x2a37, 0x2a38, 0x2a39, 0x2a3a, 0x2a3b, 0x2a3c, 0x2a3d, 0x2a3e, 0x2a40, 0x2a41, 0x2a42, 0x2a43, 0x2a44, 
        0x2a45, 0x2a46, 0x2a47, 0x2a48, 0x2a49, 0x2a4a, 0x2a4b, 0x2a4c, 0x2a4d, 0x2a4e, 0x2a4f, 0x2a50, 0x2a51, 0x2a52, 0x2a53, 0x2a54, 
        0x2a55, 0x2a56, 0x2a57, 0x2a58, 0x2a59, 0x2a5a, 0x2a5b, 0x2a5c, 0x2a5d, 0x2a5e, 0x2a5f, 0x2a60, 0x2a61, 0x2a62, 0x2a63, 0x2a64, 
        0x2a65, 0x2a66, 0x2a67, 0x2a68, 0x2a69, 0x2a6a, 0x2a6b, 0x2a6c, 0x2a6d, 0x2a6e, 0x2a6f, 0x2a70, 0x2a71, 0x2a72, 0x2a73, 0x2a74, 
        0x2a75, 0x2a76, 0x2a77, 0x2a78, 0x2a79, 0x2a7a, 0x2a7b, 0x2a7c, 0x2a7d, 0x2a7d, 0x338, 0x2a7e, 0x2a7e, 0x338, 0x2a7f, 0x2a80, 
        0x2a81, 0x2a82, 0x2a83, 0x2a84, 0x2a85, 0x2a86, 0x2a89, 0x2a8a, 0x2a8b, 0x2a8c, 0x2a8d, 0x2a8e, 0x2a8f, 0x2a90, 0x2a91, 0x2a92, 
        0x2a93, 0x2a94, 0x2a95, 0x2a96, 0x2a97, 0x2a98, 0x2a99, 0x2a9a, 0x2a9b, 0x2a9c, 0x2a9d, 0x2a9e, 0x2a9f, 0x2aa0, 0x2aa1, 0x2aa1, 
        0x338, 0x2aa2, 0x2aa2, 0x338, 0x2aa3, 0x2aa4, 0x2aa5, 0x2aa6, 0x2aa7, 0x2aa8, 0x2aa9, 0x2aaa, 0x2aab, 0x2aac, 0x2aad, 0x2aae, 
        0x2ab1, 0x2ab2, 0x2ab3, 0x2ab4, 0x2ab5, 0x2ab6, 0x2ab7, 0x2ab8, 0x2ab9, 0x2aba, 0x2abb, 0x2abc, 0x2abd, 0x2abe, 0x2abf, 0x2ac0, 
        0x2ac1, 0x2ac2, 0x2ac3, 0x2ac4, 0x2ac5, 0x2ac6, 0x2ac7, 0x2ac8, 0x2ac9, 0x2aca, 0x2acb, 0x2acc, 0x2acd, 0x2ace, 0x2acf, 0x2ad0, 
        0x2ad1, 0x2ad2, 0x2ad3, 0x2ad4, 0x2ad5, 0x2ad6, 0x2ad7, 0x2ad8, 0x2ad9, 0x2ada, 0x2adb, 0x2adc, 0x2add, 0x2ade, 0x2adf, 0x2ae0, 
        0x2ae1, 0x2ae2, 0x2ae3, 0x2ae4, 0x2ae5, 0x2ae6, 0x2ae7, 0x2ae8, 0x2ae9, 0x2aea, 0x2aeb, 0x2aec, 0x2aed, 0x2aee, 0x2aef, 0x2af0, 
        0x2af1, 0x2af2, 0x2af3, 0x2af4, 0x2af5, 0x2af6, 0x2af7, 0x2af8, 0x2af9, 0x2afa, 0x2afb, 0x2afd, 0x2afe, 0x2190, 0x2191, 0x2192, 
        0x2193, 0x2194, 0x2195, 0x2196, 0x2197, 0x2198, 0x2199, 0x219a, 0x219b, 0x219c, 0x219d, 0x219e, 0x219f, 0x21a0, 0x21a1, 0x21a2, 
        0x21a3, 0x21a4, 0x21a5, 0x21a6, 0x21a7, 0x21a8, 0x21a9, 0x21aa, 0x21ab, 0x21ac, 0x21ad, 0x21ae, 0x21af, 0x21b0, 0x21b1, 0x21b2, 
        0x21b3, 0x21b4, 0x21b5, 0x21b6, 0x21b7, 0x21b8, 0x21b9, 0x21ba, 0x21bb, 0x21bc, 0x21bd, 0x21be, 0x21bf, 0x21c0, 0x21c1, 0x21c2, 
        0x21c3, 0x21c4, 0x21c5, 0x21c6, 0x21c7, 0x21c8, 0x21c9, 0x21ca, 0x21cb, 0x21cc, 0x21cd, 0x21ce, 0x21cf, 0x21d0, 0x21d1, 0x21d2, 
        0x21d3, 0x21d4, 0x21d5, 0x21d6, 0x21d7, 0x21d8, 0x21d9, 0x21da, 0x21db, 0x21dc, 0x21dd, 0x21de, 0x21df, 0x21e0, 0x21e1, 0x21e2, 
        0x21e3, 0x21e4, 0x21e5, 0x21e6, 0x21e7, 0x21e8, 0x21e9, 0x21ea, 0x21eb, 0x21ec, 0x21ed, 0x21ee, 0x21ef, 0x21f0, 0x21f1, 0x21f2, 
        0x21f3, 0x21f4, 0x21f5, 0x21f6, 0x21f7, 0x21f8, 0x21f9, 0x21fa, 0x21fb, 0x21fc, 0x21fd, 0x21fe, 0x21ff, 0x22b8, 0x27f0, 0x27f1, 
        0x27f5, 0x27f6, 0x27f7, 0x27f8, 0x27f9, 0x27fa, 0x27fb, 0x27fc, 0x27fd, 0x27fe, 0x27ff, 0x2900, 0x2901, 0x2902, 0x2903, 0x2904, 
        0x2905, 0x2906, 0x2907, 0x2908, 0x2909, 0x290a, 0x290b, 0x290c, 0x290d, 0x290e, 0x290f, 0x2910, 0x2911, 0x2912, 0x2913, 0x2914, 
        0x2915, 0x2916, 0x2917, 0x2918, 0x2919, 0x291a, 0x291b, 0x291c, 0x291d, 0x291e, 0x291f, 0x2920, 0x2921, 0x2922, 0x2923, 0x2924, 
        0x2925, 0x2926, 0x2927, 0x2928, 0x2929, 0x292a, 0x292b, 0x292c, 0x292d, 0x292e, 0x292f, 0x2930, 0x2931, 0x2932, 0x2933, 0x2934, 
        0x2935, 0x2936, 0x2937, 0x2938, 0x2939, 0x293a, 0x293b, 0x293c, 0x293d, 0x293e, 0x293f, 0x2940, 0x2941, 0x2942, 0x2943, 0x2944, 
        0x2945, 0x2946, 0x2947, 0x2948, 0x2949, 0x294a, 0x294b, 0x294c, 0x294d, 0x294e, 0x294f, 0x2950, 0x2951, 0x2952, 0x2953, 0x2954, 
        0x2955, 0x2956, 0x2957, 0x2958, 0x2959, 0x295a, 0x295b, 0x295c, 0x295d, 0x295e, 0x295f, 0x2960, 0x2961, 0x2962, 0x2963, 0x2964, 
        0x2965, 0x2966, 0x2967, 0x2968, 0x2969, 0x296a, 0x296b, 0x296c, 0x296d, 0x296e, 0x296f, 0x2970, 0x2971, 0x2972, 0x2973, 0x2974, 
        0x2975, 0x2976, 0x2977, 0x2978, 0x2979, 0x297a, 0x297b, 0x297c, 0x297d, 0x297e, 0x297f, 0x2999, 0x299a, 0x299b, 0x299c, 0x299d, 
        0x299e, 0x299f, 0x29df, 0x29ef, 0x29f4, 0x2b45, 0x2b46, 0xb1, 0xb1, 0x2212, 0x2212, 0x2213, 0x2213, 0x2214, 0x229e, 0x229f, 
        0x2211, 0x2a0a, 0x2a0b, 0x222c, 0x222d, 0x2295, 0x2296, 0x2298, 0x2a01, 0x222b, 0x222e, 0x222f, 0x2230, 0x2231, 0x2232, 0x2233, 
        0x2a0c, 0x2a0d, 0x2a0e, 0x2a0f, 0x2a10, 0x2a11, 0x2a12, 0x2a13, 0x2a14, 0x2a15, 0x2a16, 0x2a17, 0x2a18, 0x2a19, 0x2a1a, 0x2a1b, 
        0x2a1c, 0x22c3, 0x2a03, 0x2a04, 0x22c0, 0x22c1, 0x22c2, 0x2a00, 0x2a02, 0x2a05, 0x2a06, 0x2a07, 0x2a08, 0x2a09, 0x2afc, 0x2aff, 
        0x2240, 0x220f, 0x2210, 0x2229, 0x222a, 0xd7, 0x2022, 0x2062, 0x22a0, 0x22a1, 0x22c5, 0x2a2f, 0x2a3f, 0xb7, 0x2297, 0x2216, 
        0xf7, 0x2220, 0x2221, 0x2222, 0xac, 0x2299, 0x2202, 0x2207, 0x2032, 0x266d, 0x266e, 0x266f, 0x2145, 0x2146, 0x221a, 0x221b, 
        0x221c, 0x2061, 0xa8, 0xaf, 0xb0, 180, 0xb8, 710, 0x2c7, 0x2c9, 0x2ca, 0x2cb, 0x2cd, 0x2d8, 0x2d9, 730, 
        0x2dc, 0x2dd, 0x2f7, 770, 0x311, 0x203e, 0x2064, 0x20db, 0x20dc, 0x23b4, 0x23b5, 0x23dc, 0x23dd, 0x23de, 0x23df, 0x23e0, 
        0x23e1
     };

    internal Class1136(Class422 A_0, Class5 A_1)
    {
        this.class422_0 = A_0;
        string str = A_1.method_38();
        this.class400_0 = A_0.method_3(string.Format(BookmarkStart.b("圫ḭ䴯ᴱ圳夵嘷丹夻倽㐿汁㱃⭅⑇", 6), str));
        this.class422_0.method_59().Add(new Class979(BookmarkStart.b("堫䬭䠯䘱ᬳ丵唷嘹", 6), string.Format(BookmarkStart.b("圫ḭ䴯ᴱ", 6), str), BookmarkStart.b("伫䄭帯䘱儳堵䰷ᐹ䐻匽ⰿ", 6)));
        this.class400_0.method_2(BookmarkStart.b("䄫䌭尯࠱夳圵䰷刹", 6));
        this.class400_0.method_18(BookmarkStart.b("含䌭尯就䜳వ唷圹倻", 6), BookmarkStart.b("䐫娭䐯䈱ำᤵ᜷䴹䬻䤽渿㕁睃桅❇㡉⭋慍慏歑浓湕睗᝙㵛⩝࡟䵡⥣ݥᱧɩⅫ≭", 6));
        this.class400_0.method_18(BookmarkStart.b("含䌭尯就䜳వ唷", 6), BookmarkStart.b("䐫娭䐯䈱ำᤵ᜷䤹弻嘽┿⽁╃㕅晇╉㱋⭍㹏⩑㥓㩕㹗㕙⹛㍝şᙡᝣ䡥ݧᡩ୫䅭Ὧᑱታή᭷ό㡻ᅽﺉꎋ벍ꂏꊑꊓ릕ﮙ", 6));
    }

    internal VisitorAction method_0(Class5 A_0)
    {
        int num = 11;
        switch (A_0.method_32().vmethod_1())
        {
            case MathObjectType.Accent:
                this.method_9(A_0);
                break;

            case MathObjectType.Bar:
                this.method_8(A_0);
                break;

            case MathObjectType.BorderBox:
                this.method_1(A_0);
                break;

            case MathObjectType.Box:
                this.method_2(A_0);
                break;

            case MathObjectType.Delimiter:
                this.method_14(A_0);
                break;

            case MathObjectType.Array:
                this.method_5(A_0);
                break;

            case MathObjectType.Fraction:
                this.method_16(A_0);
                break;

            case MathObjectType.Function:
                this.method_17(A_0);
                break;

            case MathObjectType.GroupCharacter:
                this.method_11(A_0);
                break;

            case MathObjectType.LowerLimit:
                this.method_10(A_0, BookmarkStart.b("尰帲头ശ吸为匼嬾⑀ㅂ", num));
                break;

            case MathObjectType.UpperLimit:
                this.method_10(A_0, BookmarkStart.b("尰帲头ശ吸吺䬼娾㍀", num));
                break;

            case MathObjectType.Matrix:
                this.method_6(A_0);
                break;

            case MathObjectType.MatrixRow:
                this.method_7(A_0);
                break;

            case MathObjectType.NAry:
                this.method_3(A_0);
                break;

            case MathObjectType.Phantom:
                this.method_4(A_0);
                break;

            case MathObjectType.Radical:
                this.method_20(A_0);
                break;

            case MathObjectType.PreSubSuperscript:
                this.method_18(A_0, BookmarkStart.b("尰帲头ശ吸嘺䠼匾㕀⩂㙄⑆㭈≊㵌㭎≐", num), true);
                break;

            case MathObjectType.Subscript:
                this.method_15(A_0, BookmarkStart.b("尰帲头ശ吸䠺䠼崾", num), MathObjectType.SubscriptPart);
                break;

            case MathObjectType.SubSuperscript:
                this.method_18(A_0, BookmarkStart.b("尰帲头ശ吸䠺䠼崾㉀㙂㕄", num), false);
                break;

            case MathObjectType.Supercript:
                this.method_15(A_0, BookmarkStart.b("尰帲头ശ吸䠺䠼伾", num), MathObjectType.SuperscriptPart);
                break;

            default:
                return VisitorAction.Continue;
        }
        return VisitorAction.SkipThisElement;
    }

    private void method_1(Class5 A_0)
    {
        this.class400_0.method_4(BookmarkStart.b("䘪䀬䌮ର帲倴夶娸场刼䰾⑀", 5));
        this.class400_0.method_40(BookmarkStart.b("䔪䈬嬮倰䜲尴堶圸", 5), BookmarkStart.b("䤪䈬圮", 5));
        this.method_22(A_0, MathObjectType.Argument);
        this.class400_0.method_6(BookmarkStart.b("䘪䀬䌮ର帲倴夶娸场刼䰾⑀", 5));
    }

    private void method_10(Class5 A_0, string A_1)
    {
        int num = 6;
        this.class400_0.method_4(A_1);
        this.class400_0.method_4(BookmarkStart.b("䄫䌭尯࠱夳䐵圷䴹", 6));
        foreach (Class5 class2 in A_0.ChildObjects)
        {
            if (class2.method_32().vmethod_1() != MathObjectType.Limit)
            {
                class2.Accept(this.class422_0);
            }
        }
        this.class400_0.method_6(BookmarkStart.b("䄫䌭尯࠱夳䐵圷䴹", num));
        this.class400_0.method_4(BookmarkStart.b("䄫䌭尯࠱夳䐵圷䴹", num));
        this.method_22(A_0, MathObjectType.Limit);
        this.class400_0.method_6(BookmarkStart.b("䄫䌭尯࠱夳䐵圷䴹", num));
        this.class400_0.method_6(A_1);
    }

    private void method_11(Class5 A_0)
    {
        bool flag;
        int num = 6;
        object obj2 = A_0.method_32().method_31(0x3bc4);
        string str = (flag = (obj2 != null) && (((MathVerticalJustification) obj2) == MathVerticalJustification.Bottom)) ? BookmarkStart.b("䄫䌭尯࠱夳夵丷弹主", num) : BookmarkStart.b("䄫䌭尯࠱夳䌵嘷帹夻䰽", num);
        string str2 = flag ? BookmarkStart.b("䴫䴭匯圱娳䈵", num) : BookmarkStart.b("䴫䴭匯圱娳䈵䴷吹堻嬽㈿", num);
        object obj4 = A_0.method_32().method_31(0x3bba);
        bool flag2 = (obj4 != null) && (((MathVerticalJustification) obj4) == MathVerticalJustification.Top);
        object obj3 = A_0.method_32().method_31(0x3bb0);
        if (obj3 == null)
        {
            obj3 = '⏞';
        }
        this.class400_0.method_4(str);
        this.class400_0.vmethod_1(str2, false);
        this.method_12(A_0, obj3, flag2, flag);
        this.class400_0.method_6(str);
    }

    private void method_12(Class5 A_0, object A_1, bool A_2, bool A_3)
    {
        if ((A_2 && A_3) || (!A_2 && !A_3))
        {
            this.method_21(A_0);
            this.method_13((char) A_1);
        }
        else
        {
            this.method_13((char) A_1);
            this.method_21(A_0);
        }
    }

    private void method_13(object A_0)
    {
        this.class400_0.method_4(BookmarkStart.b("崯弱堳వ唷唹", 10));
        this.class400_0.method_15(((char) A_0).ToString());
        this.class400_0.method_6(BookmarkStart.b("崯弱堳వ唷唹", 10));
    }

    private void method_14(Class5 A_0)
    {
        int num = 12;
        object obj2 = A_0.method_32().method_31(0x3b4c);
        object obj3 = A_0.method_32().method_31(0x3b56);
        object obj4 = A_0.method_32().method_31(0x3b60);
        this.class400_0.method_4(BookmarkStart.b("弱夳娵ȷ圹娻嬽⸿⅁⅃≅", 12));
        if (obj2 != null)
        {
            this.class400_0.method_40(BookmarkStart.b("崱䐳匵嘷", num), ((char) obj2).ToString());
        }
        if (obj3 != null)
        {
            this.class400_0.method_40(BookmarkStart.b("儱堳夵䬷弹", num), ((char) obj3).ToString());
        }
        this.class400_0.method_40(BookmarkStart.b("䄱儳䘵夷䠹崻䨽⼿ぁ㝃", num), ((obj4 == null) ? '|' : ((char) obj4)).ToString());
        this.method_21(A_0);
        this.class400_0.method_6(BookmarkStart.b("弱夳娵ȷ圹娻嬽⸿⅁⅃≅", num));
    }

    private void method_15(Class5 A_0, string A_1, MathObjectType A_2)
    {
        Class5 class2 = smethod_3(A_0, MathObjectType.Argument);
        if (class2 != null)
        {
            Class5 class3 = smethod_3(A_0, A_2);
            if (class3 != null)
            {
                this.class400_0.method_4(A_1);
                this.method_19(class2);
                this.method_19(class3);
                this.class400_0.method_6(A_1);
            }
        }
    }

    private void method_16(Class5 A_0)
    {
        int num = 13;
        Class5 class2 = smethod_3(A_0, MathObjectType.Denominator);
        if (class2 != null)
        {
            Class5 class3 = smethod_3(A_0, MathObjectType.Numerator);
            if (class3 != null)
            {
                object obj2 = A_0.method_32().method_31(0x3c64);
                MathFractionType bar = MathFractionType.Bar;
                if (obj2 != null)
                {
                    bar = (MathFractionType) obj2;
                }
                string str = (bar == MathFractionType.Linear) ? BookmarkStart.b("帲場嬶̸嘺似倾㙀", num) : BookmarkStart.b("帲場嬶̸嘺嬼䴾⁀⁂", num);
                this.class400_0.method_4(str);
                switch (bar)
                {
                    case MathFractionType.NoBar:
                        this.class400_0.method_40(BookmarkStart.b("弲尴夶尸伺唼嘾≀⡂⭄≆㩈㡊", num), BookmarkStart.b("̲䔴䌶", num));
                        break;

                    case MathFractionType.Skewed:
                        this.class400_0.method_40(BookmarkStart.b("儲倴䄶尸场儼娾╀", num), BookmarkStart.b("䜲䜴䈶尸", num));
                        break;
                }
                this.method_19(class3);
                if (bar == MathFractionType.Linear)
                {
                    this.method_13('/');
                }
                this.method_19(class2);
                this.class400_0.method_6(str);
            }
        }
    }

    private void method_17(Class5 A_0)
    {
        int num = 3;
        Class5 class2 = smethod_3(A_0, MathObjectType.FunctionName);
        if (class2 != null)
        {
            Class5 class3 = smethod_3(A_0, MathObjectType.Argument);
            this.class400_0.method_4(BookmarkStart.b("䐨䘪䄬ᔮ尰䄲娴䀶", num));
            this.method_19(class2);
            if (class3 != null)
            {
                this.method_13('⁡');
                this.method_19(class3);
            }
            this.class400_0.method_6(BookmarkStart.b("䐨䘪䄬ᔮ尰䄲娴䀶", num));
        }
    }

    private void method_18(Class5 A_0, string A_1, bool A_2)
    {
        int num = 0x10;
        Class5 class2 = smethod_3(A_0, MathObjectType.Argument);
        if (class2 != null)
        {
            Class5 class4 = smethod_3(A_0, MathObjectType.SubscriptPart);
            if (class4 != null)
            {
                Class5 class3 = smethod_3(A_0, MathObjectType.SuperscriptPart);
                if (class3 != null)
                {
                    this.class400_0.method_4(A_1);
                    this.method_19(class2);
                    if (A_2)
                    {
                        this.class400_0.method_10(BookmarkStart.b("嬵唷嘹ػ匽〿ぁ⅃㕅⭇㡉╋㹍⑏⅑", num));
                    }
                    this.method_19(class4);
                    this.method_19(class3);
                    this.class400_0.method_6(A_1);
                }
            }
        }
    }

    private void method_19(Class5 A_0)
    {
        int num = 0x12;
        this.class400_0.method_4(BookmarkStart.b("唷圹倻нⴿぁ⭃ㅅ", 0x12));
        if (A_0 != null)
        {
            A_0.Accept(this.class422_0);
        }
        this.class400_0.method_6(BookmarkStart.b("唷圹倻нⴿぁ⭃ㅅ", num));
    }

    private void method_2(Class5 A_0)
    {
        foreach (Class5 class2 in A_0.ChildObjects)
        {
            class2.Accept(this.class422_0);
        }
    }

    private void method_20(Class5 A_0)
    {
        Class5 class2 = smethod_3(A_0, MathObjectType.Degree);
        if (class2 != null)
        {
            Class5 class3 = smethod_3(A_0, MathObjectType.Argument);
            if (class3 != null)
            {
                if (smethod_0(A_0, 0x3cb4))
                {
                    this.method_24(class3);
                }
                else
                {
                    this.method_23(class2, class3);
                }
            }
        }
    }

    private void method_21(Class5 A_0)
    {
        foreach (Class5 class2 in A_0.GetChildElements(DocumentObjectType.OfficeMath, false))
        {
            if (class2.method_32().vmethod_1() == MathObjectType.Argument)
            {
                this.method_19(class2);
            }
        }
    }

    private void method_22(Class5 A_0, MathObjectType A_1)
    {
        foreach (Class5 class2 in A_0.ChildObjects)
        {
            if (class2.method_32().vmethod_1() == A_1)
            {
                class2.Accept(this.class422_0);
            }
        }
    }

    private void method_23(Class5 A_0, Class5 A_1)
    {
        this.class400_0.method_4(BookmarkStart.b("尰帲头ശ吸䤺刼倾㕀", 11));
        this.method_19(A_1);
        this.method_19(A_0);
        this.class400_0.method_6(BookmarkStart.b("尰帲头ശ吸䤺刼倾㕀", 11));
    }

    private void method_24(Class5 A_0)
    {
        this.class400_0.method_4(BookmarkStart.b("䬥䔧䘩ᘫ䌭䌯䌱䘳䈵", 0));
        this.method_19(A_0);
        this.class400_0.method_6(BookmarkStart.b("䬥䔧䘩ᘫ䌭䌯䌱䘳䈵", 0));
    }

    internal void method_25(ParagraphBase A_0)
    {
        int num = 0x11;
        string text = ((TextRange) A_0).Text;
        int num2 = 0;
        StringBuilder builder = new StringBuilder();
        bool flag = false;
        string str2 = null;
        while (num2 < text.Length)
        {
            char ch = text[num2];
            if (ch == '&')
            {
                if (flag)
                {
                    this.class400_0.method_15(builder.ToString());
                    this.class400_0.method_5();
                    builder.Length = 0;
                    flag = false;
                    str2 = null;
                }
                this.class400_0.method_10(BookmarkStart.b("娶吸场ܼ刾⁀⽂ⱄ⁆❈♊ⱌ㵎㩐", num));
                num2++;
            }
            else
            {
                string str3 = this.method_27(text, num2);
                if (str3 != null)
                {
                    this.class400_0.method_15(builder.ToString());
                    this.class400_0.method_6(str3);
                    builder.Length = 0;
                    flag = false;
                }
                str2 = this.method_26(text, num2);
                if (str2 != null)
                {
                    this.class400_0.method_4(str2);
                    flag = true;
                }
                builder.Append(text[num2]);
                num2++;
            }
        }
        if (!flag)
        {
            this.class400_0.method_4(str2);
        }
        this.class400_0.method_15(builder.ToString());
        this.class400_0.method_5();
    }

    internal string method_26(string A_0, int A_1)
    {
        int num = 0x10;
        if (this.method_28(A_0, A_1) && ((A_1 == 0) || !this.method_28(A_0, A_1 - 1)))
        {
            return BookmarkStart.b("嬵唷嘹ػ匽⤿", num);
        }
        if (this.method_30(A_0, A_1))
        {
            return BookmarkStart.b("嬵唷嘹ػ匽⼿", num);
        }
        if (!this.method_29(A_0, A_1) || ((A_1 != 0) && this.method_29(A_0, A_1 - 1)))
        {
            return null;
        }
        return BookmarkStart.b("嬵唷嘹ػ匽⸿", num);
    }

    internal string method_27(string A_0, int A_1)
    {
        int num = 9;
        if ((!this.method_28(A_0, A_1) && (A_1 != 0)) && this.method_28(A_0, A_1 - 1))
        {
            return BookmarkStart.b("䈮尰弲༴娶倸", num);
        }
        if ((A_1 != 0) && this.method_30(A_0, A_1 - 1))
        {
            return BookmarkStart.b("䈮尰弲༴娶嘸", num);
        }
        if ((!this.method_29(A_0, A_1) && (A_1 != 0)) && this.method_29(A_0, A_1 - 1))
        {
            return BookmarkStart.b("䈮尰弲༴娶圸", num);
        }
        return null;
    }

    internal bool method_28(string A_0, int A_1)
    {
        char ch = A_0[A_1];
        return ((!this.method_29(A_0, A_1) && !this.method_30(A_0, A_1)) && !this.method_31(ch));
    }

    internal bool method_29(string A_0, int A_1)
    {
        char c = A_0[A_1];
        return char.IsDigit(c);
    }

    private void method_3(Class5 A_0)
    {
        Class5 class2 = smethod_3(A_0, MathObjectType.Argument);
        if (class2 != null)
        {
            Class5 class4 = smethod_3(A_0, MathObjectType.SubscriptPart);
            Class5 class3 = smethod_3(A_0, MathObjectType.SuperscriptPart);
            if ((class4 != null) || (class3 != null))
            {
                object obj2 = A_0.method_32().method_31(0x3ac5);
                if (obj2 == null)
                {
                    obj2 = '∫';
                }
                bool flag = smethod_0(A_0, 0x3ca0);
                bool flag2 = smethod_0(A_0, 0x3caa);
                if (class4 == null)
                {
                    flag = true;
                }
                if (class3 == null)
                {
                    flag2 = true;
                }
                string str = smethod_1(A_0, (char) obj2, flag, flag2);
                if (Class567.smethod_16(str))
                {
                    this.class400_0.method_4(str);
                }
                this.method_13((char) obj2);
                if (Class567.smethod_16(str))
                {
                    if (!flag)
                    {
                        this.method_19(class4);
                    }
                    if (!flag2)
                    {
                        this.method_19(class3);
                    }
                    this.class400_0.method_6(str);
                }
                this.method_19(class2);
            }
        }
    }

    internal bool method_30(string A_0, int A_1)
    {
        foreach (int num2 in int_0)
        {
            if (A_0[A_1] == num2)
            {
                return true;
            }
        }
        return false;
    }

    internal bool method_31(char A_0)
    {
        return (A_0 == '&');
    }

    private void method_4(Class5 A_0)
    {
        int num = 5;
        this.class400_0.method_4(BookmarkStart.b("䘪䀬䌮ର帲䔴嘶崸强堼嬾", 5));
        if (smethod_0(A_0, 0x3c5a))
        {
            this.class400_0.method_40(BookmarkStart.b("尪䐬䬮䔰嬲", num), BookmarkStart.b("ᬪ丬䈮", num));
        }
        if (smethod_0(A_0, 0x3be2))
        {
            this.class400_0.method_40(BookmarkStart.b("䌪䠬䘮嘰嬲䄴", num), BookmarkStart.b("ᬪ丬䈮", num));
        }
        if (smethod_0(A_0, 0x3bec))
        {
            this.class400_0.method_40(BookmarkStart.b("伪䠬弮䔰嬲", num), BookmarkStart.b("ᬪ丬䈮", num));
        }
        this.class400_0.method_4(BookmarkStart.b("䘪䀬䌮ର帲䜴堶丸", num));
        this.method_21(A_0);
        this.class400_0.method_6(BookmarkStart.b("䘪䀬䌮ର帲䜴堶丸", num));
        this.class400_0.method_6(BookmarkStart.b("䘪䀬䌮ର帲䔴嘶崸强堼嬾", num));
    }

    private void method_5(Class5 A_0)
    {
        int num = 1;
        this.class400_0.method_4(BookmarkStart.b("䨦䐨䜪ᜬ䈮䔰刲圴嬶尸", 1));
        foreach (Class5 class2 in A_0.GetChildElements(DocumentObjectType.OfficeMath, false))
        {
            if (class2.method_32().vmethod_1() == MathObjectType.Argument)
            {
                this.class400_0.method_4(BookmarkStart.b("䨦䐨䜪ᜬ䈮䔰䄲", num));
                this.class400_0.method_4(BookmarkStart.b("䨦䐨䜪ᜬ䈮䔰圲", num));
                this.class400_0.method_4(BookmarkStart.b("䨦䐨䜪ᜬ䈮䌰尲䈴", num));
                this.class400_0.method_10(BookmarkStart.b("䨦䐨䜪ᜬ䈮倰弲尴倶圸尺似倾㑀㍂", num));
                class2.Accept(this.class422_0);
                this.class400_0.method_6(BookmarkStart.b("䨦䐨䜪ᜬ䈮䌰尲䈴", num));
                this.class400_0.method_6(BookmarkStart.b("䨦䐨䜪ᜬ䈮䔰圲", num));
                this.class400_0.method_6(BookmarkStart.b("䨦䐨䜪ᜬ䈮䔰䄲", num));
            }
        }
        this.class400_0.method_6(BookmarkStart.b("䨦䐨䜪ᜬ䈮䔰刲圴嬶尸", num));
    }

    private void method_6(Class5 A_0)
    {
        this.class400_0.method_4(BookmarkStart.b("䐨䘪䄬ᔮ尰䜲吴唶唸帺", 3));
        this.method_22(A_0, MathObjectType.MatrixRow);
        this.class400_0.method_6(BookmarkStart.b("䐨䘪䄬ᔮ尰䜲吴唶唸帺", 3));
    }

    private void method_7(Class5 A_0)
    {
        int num = 0x10;
        this.class400_0.method_4(BookmarkStart.b("嬵唷嘹ػ匽㐿ぁ", 0x10));
        foreach (Class5 class2 in A_0.GetChildElements(DocumentObjectType.OfficeMath, false))
        {
            if (class2.method_32().vmethod_1() == MathObjectType.Argument)
            {
                this.class400_0.method_4(BookmarkStart.b("嬵唷嘹ػ匽㐿♁", num));
                class2.Accept(this.class422_0);
                this.class400_0.method_6(BookmarkStart.b("嬵唷嘹ػ匽㐿♁", num));
            }
        }
        this.class400_0.method_6(BookmarkStart.b("嬵唷嘹ػ匽㐿ぁ", num));
    }

    private void method_8(Class5 A_0)
    {
        int num = 2;
        string str = BookmarkStart.b("䔧䜩䀫ᐭ崯䜱娳刵崷䠹", 2);
        char ch = '̲';
        object obj2 = A_0.method_32().method_31(0x3ab6);
        if ((obj2 != null) && (((MathPosition) obj2) == MathPosition.Top))
        {
            str = BookmarkStart.b("䔧䜩䀫ᐭ崯崱䈳匵䨷", num);
            ch = '\x00af';
        }
        this.class400_0.method_4(str);
        Class5 class2 = smethod_3(A_0, MathObjectType.Argument);
        this.method_19(class2);
        this.method_13(ch);
        this.class400_0.method_6(str);
    }

    private void method_9(Class5 A_0)
    {
        int num = 0;
        Class5 class2 = smethod_3(A_0, MathObjectType.Argument);
        if (class2 != null)
        {
            object obj2 = A_0.method_32().method_31(0x3ac0);
            if (obj2 == null)
            {
                obj2 = '̂';
            }
            this.class400_0.method_4(BookmarkStart.b("䬥䔧䘩ᘫ䌭弯䐱儳䐵", num));
            this.class400_0.method_40(BookmarkStart.b("䜥䬧䤩䤫䀭䐯", num), BookmarkStart.b("別娧弩䤫", num));
            this.method_19(class2);
            this.method_13((char) obj2);
            this.class400_0.method_6(BookmarkStart.b("䬥䔧䘩ᘫ䌭弯䐱儳䐵", num));
        }
    }

    private static bool smethod_0(Class5 A_0, int A_1)
    {
        object obj2 = A_0.method_32().method_31(A_1);
        return ((obj2 != null) && ((bool) obj2));
    }

    private static string smethod_1(Class5 A_0, char A_1, bool A_2, bool A_3)
    {
        int num = 12;
        object obj2 = A_0.method_32().method_31(0x3c96);
        MathLimitLocation undefined = MathLimitLocation.Undefined;
        if (obj2 != null)
        {
            undefined = (MathLimitLocation) obj2;
        }
        if (undefined == MathLimitLocation.SubscriptSuperscript)
        {
            return smethod_2(A_2, A_3, BookmarkStart.b("弱夳娵ȷ圹伻䬽〿", num), BookmarkStart.b("弱夳娵ȷ圹伻䬽∿", num), BookmarkStart.b("弱夳娵ȷ圹伻䬽∿ㅁㅃ㙅", num));
        }
        if ((undefined != MathLimitLocation.UnderOver) && (A_1 == '∫'))
        {
            return smethod_2(A_2, A_3, BookmarkStart.b("弱夳娵ȷ圹伻䬽〿", num), BookmarkStart.b("弱夳娵ȷ圹伻䬽∿", num), BookmarkStart.b("弱夳娵ȷ圹伻䬽∿ㅁㅃ㙅", num));
        }
        return smethod_2(A_2, A_3, BookmarkStart.b("弱夳娵ȷ圹医䠽┿ぁ", num), BookmarkStart.b("弱夳娵ȷ圹䤻倽␿❁㙃", num), BookmarkStart.b("弱夳娵ȷ圹䤻倽␿❁㙃⥅㹇⽉㹋", num));
    }

    private static string smethod_2(bool A_0, bool A_1, string A_2, string A_3, string A_4)
    {
        if (A_0 && !A_1)
        {
            return A_2;
        }
        if (!A_0 && A_1)
        {
            return A_3;
        }
        if (!A_0)
        {
            return A_4;
        }
        return null;
    }

    private static Class5 smethod_3(Class5 A_0, MathObjectType A_1)
    {
        Class5 class3;
        using (IEnumerator enumerator = A_0.ChildObjects.GetEnumerator())
        {
            Class5 current;
            while (enumerator.MoveNext())
            {
                current = (Class5) enumerator.Current;
                if (current.method_32().vmethod_1() == A_1)
                {
                    goto Label_0035;
                }
            }
            return null;
        Label_0035:
            class3 = current;
        }
        return class3;
    }
}

