using Spire.Doc;
using Spire.Doc.Core.DataStreamParser.Escher;
using Spire.Doc.Documents;
using Spire.Doc.Fields.Shape;
using Spire.Doc.Formatting;
using System;
using System.Collections.Generic;
using System.Drawing;

internal class Class43 : AttrCollection
{
    internal const bool bool_1 = false;
    internal const bool bool_2 = false;
    internal const bool bool_3 = true;
    internal const bool bool_4 = false;
    internal const bool bool_5 = true;
    private static readonly Class43 class43_0 = new Class43();
    internal const double double_0 = 36.0;
    internal const double double_1 = 0.0;
    internal const double double_2 = 0.0;
    internal const double double_3 = 0.0;
    internal const double double_4 = 0.0;
    internal const double double_5 = 0.0;
    internal const double double_6 = 0.0;
    internal const float float_0 = 0f;
    internal const float float_1 = 0f;
    internal const float float_2 = 0f;
    internal const float float_3 = 0f;
    internal const int int_10 = 0;
    internal const int int_11 = 0;
    internal const int int_7 = 0;
    internal const int int_8 = 0;
    internal const int int_9 = 0;
    internal const RelativeHorizontalPosition relativeHorizontalPosition_0 = RelativeHorizontalPosition.Column;
    internal const RelativeVerticalPosition relativeVerticalPosition_0 = RelativeVerticalPosition.Paragraph;
    internal const ShapeHorizontalAlignment shapeHorizontalAlignment_0 = ShapeHorizontalAlignment.None;
    internal const ShapeVerticalAlignment shapeVerticalAlignment_0 = ShapeVerticalAlignment.None;
    internal const string string_3 = "";
    internal const TextWrappingStyle textWrappingStyle_0 = TextWrappingStyle.InFrontOfText;

    internal bool method_46()
    {
        return (bool) base.method_32(0x3b0);
    }

    internal bool method_47()
    {
        return (bool) base.method_32(0x3ba);
    }

    internal long method_48()
    {
        return (long) base.method_32(0x103a);
    }

    internal TextWrappingStyle method_49()
    {
        return (TextWrappingStyle) base.method_32(0x1001);
    }

    internal TextWrappingType method_50()
    {
        return (TextWrappingType) base.method_32(0x1002);
    }

    internal HorizontalAlignment method_51()
    {
        return (HorizontalAlignment) base.method_32(0x38f);
    }

    internal VerticalAlignment method_52()
    {
        return (VerticalAlignment) base.method_32(0x391);
    }

    internal RelativeHorizontalPosition method_53()
    {
        return (RelativeHorizontalPosition) base.method_32(0x390);
    }

    internal RelativeVerticalPosition method_54()
    {
        return (RelativeVerticalPosition) base.method_32(0x392);
    }

    internal double method_55()
    {
        return (double) base.method_32(0x1021);
    }

    internal double method_56()
    {
        return (double) base.method_32(0x1022);
    }

    internal bool method_57()
    {
        return (this.method_49() == TextWrappingStyle.Inline);
    }

    internal Borders method_58()
    {
        return (base.method_32(0x157c) as Borders);
    }

    internal static object smethod_5(int A_0)
    {
        return class43_0.method_32(A_0);
    }

    AttrCollection AttrCollection.Clone()
    {
        Class43 class2 = new Class43 {
            m_propertiesHash = new Dictionary<int, object>(base.PropertiesHash)
        };
        if (base.PropertiesHash.ContainsKey(0x100b))
        {
            class2.PropertiesHash[0x100b] = (base.PropertiesHash[0x100b] as Class1031).method_42();
        }
        if (base.PropertiesHash.ContainsKey(0x100d))
        {
            class2.PropertiesHash[0x100d] = (base.PropertiesHash[0x100d] as Class1031).method_42();
        }
        if (base.PropertiesHash.ContainsKey(0x100a))
        {
            class2.PropertiesHash[0x100a] = (base.PropertiesHash[0x100a] as Class1031).method_42();
        }
        if (base.PropertiesHash.ContainsKey(0x100c))
        {
            class2.PropertiesHash[0x100c] = (base.PropertiesHash[0x100c] as Class1031).method_42();
        }
        return class2;
    }

    FormatBase FormatBase.GetDefComposite(int A_0)
    {
        if (A_0 == 0x157c)
        {
            return base.GetDefComposite(0x157c, new Borders(this, 0x157c));
        }
        return base.GetDefComposite(A_0);
    }

    object FormatBase.GetDefValue(int A_0)
    {
        int num = 13;
        switch (A_0)
        {
            case 0x77:
                return false;

            case 120:
                return false;

            case 0x79:
                return false;

            case 0x7a:
                return false;

            case 0x7b:
                return false;

            case 0x7c:
                return false;

            case 0x7d:
                return false;

            case 0x7e:
                return false;

            case 0x7f:
                return false;

            case 0x80:
                return 0;

            case 0x81:
                return Class969.smethod_40(7.2);

            case 130:
                return Class969.smethod_40(3.6);

            case 0x83:
                return Class969.smethod_40(7.2);

            case 0x84:
                return Class969.smethod_40(3.6);

            case 0x85:
                return TextBoxWrapMode.Square;

            case 0x86:
                return 0;

            case 0x87:
                return TextBoxAnchor.Top;

            case 0x88:
                return LayoutFlow.Horizontal;

            case 0x89:
                return TextRotation.Right;

            case 0x8a:
                return 0;

            case 4:
                return 0;

            case 0xbb:
                return true;

            case 0xbc:
                return false;

            case 0xbd:
                return false;

            case 190:
                return false;

            case 0xbf:
                return false;

            case 0xc0:
                return string.Empty;

            case 0xc1:
                return string.Empty;

            case 0xc2:
                return TextPathAlignment.Center;

            case 0xc3:
                return Class969.smethod_71(36.0);

            case 0xc4:
                return Class969.smethod_71(1.0);

            case 0xc5:
                return BookmarkStart.b("爲䜴帶堸场", num);

            case 240:
                return false;

            case 0xf1:
                return false;

            case 0xf2:
                return false;

            case 0xf3:
                return false;

            case 0xf4:
                return false;

            case 0xf5:
                return false;

            case 0xf6:
                return false;

            case 0xf7:
                return false;

            case 0xf8:
                return false;

            case 0xf9:
                return false;

            case 250:
                return false;

            case 0xfb:
                return false;

            case 0xfc:
                return false;

            case 0xfd:
                return false;

            case 0xfe:
                return false;

            case 0xff:
                return false;

            case 0x100:
                return 0;

            case 0x101:
                return 0;

            case 0x102:
                return 0;

            case 0x103:
                return 0;

            case 260:
                return 0;

            case 0x105:
                return 0;

            case 0x107:
                return Color.Empty;

            case 0x108:
                return Class969.smethod_71(1.0);

            case 0x109:
                return 0;

            case 0x10a:
                return 0;

            case 0x13c:
                return false;

            case 0x13d:
                return false;

            case 0x13e:
                return false;

            case 0x13f:
                return false;

            case 0x145:
                return null;

            case 0x146:
                return null;

            case 0x147:
                return 0;

            case 0x148:
                return 0;

            case 0x149:
                return 0;

            case 330:
                return 0;

            case 0x14b:
                return 0;

            case 0x14c:
                return 0;

            case 0x14d:
                return 0;

            case 0x14e:
                return 0;

            case 0x14f:
                return 0;

            case 0x150:
                return 0;

            case 0x151:
                return null;

            case 0x152:
                return null;

            case 0x153:
                return 0;

            case 340:
                return 0;

            case 0x155:
                return null;

            case 0x156:
                return null;

            case 0x157:
                return null;

            case 0x158:
                return ConnectionSiteType.None;

            case 0x17a:
                return true;

            case 0x17b:
                return true;

            case 380:
                return true;

            case 0x17d:
                return false;

            case 0x17e:
                return false;

            case 0x17f:
                return true;

            case 0x180:
                return FillType.Solid;

            case 0x181:
                return Color.White;

            case 0x182:
                return Class969.smethod_71(1.0);

            case 0x183:
                return Color.White;

            case 0x184:
                return Class969.smethod_71(1.0);

            case 0x187:
                return string.Empty;

            case 0x18b:
                return 0;

            case 0x18c:
                return 0;

            case 0x18d:
                return 0;

            case 0x18e:
                return 0;

            case 0x18f:
                return 0;

            case 400:
                return 0;

            case 0x191:
                return 0;

            case 0x192:
                return 0;

            case 0x193:
                return 0;

            case 0x194:
                return 0;

            case 0x195:
                return FillDimensionType.Default;

            case 0x196:
                return 0;

            case 0x197:
                return null;

            case 0x198:
                return 0;

            case 0x199:
                return 0;

            case 410:
                return 0;

            case 0x19b:
                return 0;

            case 0x1b9:
                return false;

            case 0x1ba:
                return false;

            case 0x1bb:
                return true;

            case 0x1bc:
                return true;

            case 0x1bd:
                return true;

            case 0x1be:
                return false;

            case 0x1bf:
                return false;

            case 0x1c0:
                return Color.Black;

            case 0x1c1:
                return Class969.smethod_71(1.0);

            case 450:
                return Color.White;

            case 0x1c4:
                return LineFillType.Solid;

            case 0x1ca:
                return FillDimensionType.Default;

            case 0x1cb:
                return 0x2535;

            case 0x1cd:
                return ShapeLineStyle.Single;

            case 0x1ce:
                return LineDashing.Solid;

            case 0x1cf:
                return null;

            case 0x1d0:
                return ArrowType.None;

            case 0x1d1:
                return ArrowType.None;

            case 0x1d2:
                return StrokeArrowWidth.Medium;

            case 0x1d3:
                return StrokeArrowLength.Medium;

            case 0x1d4:
                return StrokeArrowWidth.Medium;

            case 0x1d5:
                return StrokeArrowLength.Medium;

            case 470:
                return StrokeJoinStyle.Round;

            case 0x1d7:
                return StrokeEndCap.Flat;

            case 0x1fb:
                return false;

            case 0x1fc:
                return true;

            case 0x1fd:
                return true;

            case 510:
                return true;

            case 0x1ff:
                return false;

            case 0x200:
                return ShadowType.Offset;

            case 0x201:
                return Color.FromArgb(0x80, 0x80, 0x80);

            case 0x202:
                return Color.FromArgb(0xcb, 0xcb, 0xcb);

            case 0x204:
                return Class969.smethod_71(1.0);

            case 0x205:
                return 0x6338;

            case 0x206:
                return 0x6338;

            case 0x207:
                return 0;

            case 520:
                return 0;

            case 0x209:
                return Class969.smethod_71(1.0);

            case 0x20a:
                return 0;

            case 0x20b:
                return 0;

            case 0x20c:
                return Class969.smethod_71(1.0);

            case 0x20d:
                return 0;

            case 0x20e:
                return 0;

            case 0x20f:
                return 0x100;

            case 0x210:
                return 0;

            case 0x211:
                return 0;

            case 0x23e:
                return false;

            case 0x23f:
                return false;

            case 0x240:
                return PerspectiveType.Shape;

            case 0x241:
                return 0;

            case 0x242:
                return 0;

            case 0x243:
                return 0x10000;

            case 580:
                return 0;

            case 0x245:
                return 0;

            case 0x246:
                return 0x10000;

            case 0x247:
                return 0;

            case 0x248:
                return 0;

            case 0x249:
                return 0x100;

            case 0x24a:
                return 0x8000;

            case 0x24b:
                return 0x8000;

            case 0x27f:
                return false;

            case 640:
                return 0;

            case 0x281:
                return 0x10000;

            case 0x282:
                return 5;

            case 0x283:
                return 0x319c;

            case 0x284:
                return 0;

            case 0x285:
                return 0x6f9f0;

            case 0x286:
                return PlaneType.XY;

            case 0x287:
                return Color.Empty;

            case 0x288:
                return Color.Empty;

            case 700:
                return false;

            case 0x2bd:
                return false;

            case 0x2be:
                return false;

            case 0x2bf:
                return true;

            case 0x2c0:
                return 0;

            case 0x2c1:
                return 0;

            case 0x2c2:
                return 100;

            case 0x2c3:
                return 0;

            case 0x2c4:
                return 0;

            case 0x2c5:
                return 0;

            case 710:
                return 0;

            case 0x2c7:
                return 0;

            case 0x2c8:
                return 0;

            case 0x2c9:
                return ThreeDRenderMode.FullRender;

            case 0x2ca:
                return 0x7530;

            case 0x2cb:
                return 0x1312d0;

            case 0x2cc:
                return -1250000;

            case 0x2cd:
                return 0x895440;

            case 0x2ce:
                return 0x8000;

            case 0x2cf:
                return -32768;

            case 720:
                return -8847360;

            case 0x2d1:
                return 50;

            case 0x2d2:
                return 0x4e20;

            case 0x2d3:
                return 0xc350;

            case 0x2d4:
                return 0;

            case 0x2d5:
                return 0x2710;

            case 0x2d6:
                return 0x9470;

            case 0x2d7:
                return -50000;

            case 0x2d8:
                return 0;

            case 0x2d9:
                return 0x2710;

            case 730:
                return 0x9470;

            case 0x2fb:
                return true;

            case 0x2fc:
                return false;

            case 0x2fd:
                return true;

            case 0x2fe:
                return true;

            case 0x2ff:
                return false;

            case 0x303:
                return ConnectorType.None;

            case 0x304:
                return BWMode.Automatic;

            case 0x305:
                return BWMode.Automatic;

            case 0x306:
                return BWMode.Automatic;

            case 0x309:
                return DiagramNodeLayout.Standard;

            case 0x30a:
                return DiagramNodeKind.Node;

            case 0x338:
                return false;

            case 0x339:
                return false;

            case 0x33a:
                return false;

            case 0x33b:
                return false;

            case 0x33c:
                return false;

            case 830:
                return false;

            case 0x340:
                return CalloutType.TwoSegment;

            case 0x341:
                return Class969.smethod_40(6.0);

            case 0x342:
                return CalloutAngle.Any;

            case 0x343:
                return CalloutDropType.Specified;

            case 0x344:
                return Class969.smethod_40(9.0);

            case 0x345:
                return 0;

            case 0x379:
                return false;

            case 890:
                return false;

            case 0x37b:
                return true;

            case 0x37c:
                return false;

            case 0x37d:
                return false;

            case 0x37e:
                return false;

            case 0x37f:
                return false;

            case 0x380:
                return "";

            case 0x381:
                return string.Empty;

            case 0x382:
                return string.Empty;

            case 0x383:
                return null;

            case 900:
                return Class969.smethod_40(9.0);

            case 0x385:
                return 0;

            case 0x386:
                return Class969.smethod_40(9.0);

            case 0x387:
                return 0;

            case 0x38d:
                return string.Empty;

            case 910:
                return string.Empty;

            case 0x38f:
                return ShapeHorizontalAlignment.None;

            case 0x390:
                return RelativeHorizontalPosition.Column;

            case 0x391:
                return ShapeVerticalAlignment.None;

            case 0x392:
                return RelativeVerticalPosition.Paragraph;

            case 0x393:
                return 0x3e8;

            case 0x394:
                return ShapeHorizontalAlignment.Left;

            case 0x397:
                return string.Empty;

            case 0x3b0:
                return true;

            case 0x3b1:
                return false;

            case 0x3b2:
                return false;

            case 0x3b3:
                return false;

            case 0x3b4:
                return false;

            case 950:
                return true;

            case 0x3b7:
                return false;

            case 0x3b8:
                return false;

            case 0x3b9:
                return false;

            case 0x3ba:
                return false;

            case 0x3bb:
                return false;

            case 0x3bc:
                return false;

            case 0x3bd:
                return false;

            case 0x3be:
                return false;

            case 0x3bf:
                return true;

            case 0x500:
                return EditAs.Group;

            case 0x501:
                return 0;

            case 0x504:
                return null;

            case 0x505:
                return Class969.smethod_71(1.0);

            case 0x506:
                return Class969.smethod_71(1.0);

            case 0x507:
                return 12;

            case 0x508:
                return null;

            case 0x509:
                return Class969.smethod_71(1.0);

            case 0x53c:
                return false;

            case 0x53d:
                return false;

            case 0x53e:
                return false;

            case 0x53f:
                return false;

            case 0x73f:
                return false;

            case 0x781:
                return null;

            case 0x782:
                return null;

            case 0x783:
                return null;

            case 0x784:
                return null;

            case 0x785:
                return null;

            case 0x786:
                return null;

            case 0x787:
                return null;

            case 0x788:
                return null;

            case 0x7bc:
                return true;

            case 0x7bd:
                return false;

            case 0x7be:
                return false;

            case 0x7bf:
                return false;

            case 0x7c0:
                return 0f;

            case 0x7c1:
                return 0f;

            case 0x7c2:
                return 0f;

            case 0x7c3:
                return 0f;

            case 0x7c4:
                return RelativeWidth.Page;

            case 0x7c5:
                return RelativeHeight.Page;

            case 0x1000:
                return FlipOrientation.None;

            case 0x1001:
                return TextWrappingStyle.InFrontOfText;

            case 0x1002:
                return TextWrappingType.Both;

            case 0x1003:
                return false;

            case 0x1006:
                return null;

            case 0x1007:
                return string.Empty;

            case 0x1008:
                return string.Empty;

            case 0x100a:
                return this.method_58().Top;

            case 0x100b:
                return this.method_58().Left;

            case 0x100c:
                return this.method_58().Bottom;

            case 0x100d:
                return this.method_58().Right;

            case 0x100e:
                return null;

            case 0x100f:
                return null;

            case 0x1010:
                return null;

            case 0x1011:
                return string.Empty;

            case 0x1012:
                return string.Empty;

            case 0x1013:
                return string.Empty;

            case 0x1014:
                return false;

            case 0x1015:
                return false;

            case 0x1016:
                return ShapeOleLinkType.Picture;

            case 0x1017:
                return 0;

            case 0x1018:
                return string.Empty;

            case 0x1019:
                return PresetTexture.Custom;

            case 0x101a:
                return PresetTexture.Custom;

            case 0x101b:
                return false;

            case 0x101c:
                return 0;

            case 0x101d:
                return 0;

            case 0x101e:
                return 0;

            case 0x101f:
                return 0x5460;

            case 0x1020:
                return 0x5460;

            case 0x1021:
                return 0.0;

            case 0x1022:
                return 0.0;

            case 0x1023:
                return 0.0;

            case 0x1024:
                return 0.0;

            case 0x103a:
                return 0L;

            case 0x103b:
                return ShapeType.NonPrimitive;

            case 0x103c:
                return new Struct36();

            case 0x103d:
                return false;

            case 0x103e:
                return new Struct37(100f, 100f);
        }
        throw new NotImplementedException(string.Format(BookmarkStart.b("怲崴嘶䤸帺洼䴾慀㡂畄㩆楈⁊⡌㙎≐獒㭔㡖祘㉚ぜ⽞ൠ٢ࡤɦݨὪ౬᭮ᡰᱲ᭴奶奸", num), A_0));
    }

    int FormatBase.GetFullKey(int A_0)
    {
        switch (A_0)
        {
            case 0x100a:
                return this.method_58().GetFullKey(2);

            case 0x100b:
                return this.method_58().GetFullKey(1);

            case 0x100c:
                return this.method_58().GetFullKey(3);

            case 0x100d:
                return this.method_58().GetFullKey(4);
        }
        return base.GetFullKey(A_0);
    }

    void FormatBase.Remove(int A_0)
    {
        if (base.PropertiesHash.ContainsKey(A_0))
        {
            base.PropertiesHash.Remove(A_0);
        }
    }
}

