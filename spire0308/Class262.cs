using Spire.Doc;
using Spire.Doc.Documents;
using Spire.Doc.Documents.Converters.BinaryDoc.Shapes;
using Spire.Doc.Fields;
using Spire.Doc.Fields.Shape;
using Spire.Doc.Formatting;
using System;
using System.Drawing;
using System.IO;
using System.Text;

internal class Class262
{
    private bool bool_0;
    private bool bool_1;
    private bool bool_2;
    private bool bool_3;
    internal static bool bool_4;
    private Border border_0;
    private Border border_1;
    private Border border_2;
    private Border border_3;
    internal const int int_0 = 0x44;
    internal const int int_1 = 0x3e8;
    private int int_10;
    private int int_11;
    private int int_12;
    private int int_13;
    private int int_14;
    private int int_15;
    private int int_16;
    private int int_17;
    private int int_18;
    private int int_19;
    internal int int_2;
    private int int_20;
    private int int_21;
    private int int_22;
    private int int_23;
    private int int_24;
    private int int_25;
    internal int int_3;
    private int int_4;
    private int int_5;
    private int int_6;
    private int int_7;
    private int int_8;
    private int int_9;
    internal PicfSubType picfSubType_0;
    internal PicfType picfType_0;

    internal Class262()
    {
        this.int_3 = 0x44;
        this.int_24 = 0x3e8;
        this.int_25 = 0x3e8;
    }

    internal Class262(ShapeBase A_0) : this()
    {
        float num;
        if (A_0.IsHorizontalRule)
        {
            this.picfType_0 = PicfType.InlineEscher;
            this.picfSubType_0 = (A_0.ShapeType == ShapeType.Image) ? PicfSubType.InlineHorizontalRuleImage : PicfSubType.InlineHorizontalRuleShape;
            goto Label_00B9;
        }
        if (A_0.IsWordArt)
        {
            this.picfType_0 = PicfType.InlineEscher;
            this.picfSubType_0 = PicfSubType.InlineWordArt;
            goto Label_00B9;
        }
        ShapeType shapeType = A_0.ShapeType;
        if (shapeType == ShapeType.OleObject)
        {
            goto Label_00A9;
        }
        if (shapeType != ShapeType.Image)
        {
            if (shapeType == ShapeType.OleControl)
            {
                goto Label_00A9;
            }
            this.picfType_0 = PicfType.InlineEscher;
            this.picfSubType_0 = PicfSubType.InlineShape;
        }
        else
        {
            ShapeObject obj2 = (ShapeObject) A_0;
            this.picfType_0 = (!obj2.ImageData.IsLink || obj2.HasImageBytes) ? PicfType.InlineEscher : PicfType.IncludePicture;
            this.picfSubType_0 = PicfSubType.InlineImage8;
        }
        goto Label_00B9;
    Label_00A9:
        this.picfType_0 = PicfType.InlineEscher;
        this.picfSubType_0 = PicfSubType.InlineOleObject;
    Label_00B9:
        num = 1f;
        float num2 = 1f;
        if ((A_0.ShapeType == ShapeType.Image) || (A_0.ShapeType == ShapeType.OleObject))
        {
            DocPicture imageData = (A_0 as ShapeObject).ImageData;
            num = imageData.WidthScale / 100f;
            num2 = imageData.HeightScale / 100f;
        }
        if (A_0.IsTopLevel)
        {
            this.int_13 = (int) Math.Round((double) ((A_0.Width * num) * 20.0));
            this.int_14 = (int) Math.Round((double) ((A_0.Height * num2) * 20.0));
        }
        else
        {
            this.int_13 = (int) Math.Round((double) (A_0.Width * num));
            this.int_14 = (int) Math.Round((double) (A_0.Height * num2));
        }
        Class43 shapePr = A_0.ShapePr;
        this.border_0 = A_0.ShapePr.method_58().Top;
        this.border_1 = A_0.ShapePr.method_58().Left;
        this.border_2 = A_0.ShapePr.method_58().Bottom;
        this.border_3 = A_0.ShapePr.method_58().Right;
        SizeF ef = smethod_0(A_0.Size, A_0.Rotation);
        this.int_24 = (int) Math.Round((double) ((((double) ef.Width) / A_0.Width) * 1000.0));
        this.int_25 = (int) Math.Round((double) ((((double) ef.Height) / A_0.Height) * 1000.0));
    }

    internal Class262(BinaryReader A_0) : this()
    {
        int num2 = 15;
        long position = A_0.BaseStream.Position;
        this.int_2 = A_0.ReadInt32();
        this.int_3 = A_0.ReadUInt16();
        this.picfType_0 = (PicfType) A_0.ReadUInt16();
        this.int_4 = A_0.ReadUInt16();
        this.int_5 = A_0.ReadUInt16();
        this.int_6 = A_0.ReadUInt16();
        this.picfSubType_0 = (PicfSubType) A_0.ReadUInt16();
        this.int_7 = A_0.ReadUInt16();
        this.int_8 = A_0.ReadUInt16();
        this.int_9 = A_0.ReadUInt16();
        this.int_10 = A_0.ReadUInt16();
        this.int_11 = A_0.ReadUInt16();
        this.int_12 = A_0.ReadUInt16();
        this.int_13 = A_0.ReadUInt16();
        this.int_14 = A_0.ReadUInt16();
        this.int_24 = A_0.ReadUInt16();
        this.int_25 = A_0.ReadUInt16();
        this.int_15 = A_0.ReadInt16();
        this.int_16 = A_0.ReadInt16();
        this.int_17 = A_0.ReadInt16();
        this.int_18 = A_0.ReadInt16();
        int num = A_0.ReadUInt16();
        this.int_19 = num & 15;
        this.bool_0 = (num & 0x10) != 0;
        this.bool_1 = (num & 0x20) != 0;
        this.bool_2 = (num & 0x40) != 0;
        this.bool_3 = (num & 0x80) != 0;
        this.int_20 = (num & 0xff00) >> 8;
        this.border_0 = Class355.smethod_0(A_0, this.border_0);
        this.border_1 = Class355.smethod_0(A_0, this.border_1);
        this.border_2 = Class355.smethod_0(A_0, this.border_2);
        this.border_3 = Class355.smethod_0(A_0, this.border_3);
        this.int_21 = A_0.ReadInt16();
        this.int_22 = A_0.ReadInt16();
        this.int_23 = A_0.ReadInt16();
        if (bool_4)
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(BookmarkStart.b("㼴收尸娺夼Ἶᅀੂلņ獈", num2));
            builder.AppendFormat(BookmarkStart.b("㼴᜶吸崺䴼爾ⱀ祂㹄睆㑈杊浌≎㝐⍒ൔቖ⅘⽚杜⑞偠Ṣ䥤䝦Ѩ൪ᵬ㙮㑰୲Ŵ䵶ɸ䥺|卾ꆀ솈욊쮌떎ꂒ", num2), new object[] { this.picfType_0, this.int_4, this.int_5, this.int_6 });
            builder.AppendFormat(BookmarkStart.b("㼴᜶嬸嘺椼䘾ㅀ♂罄㱆祈㙊慌潎㍐㹒ɔ㹖㵘⽚㕜敞᩠剢ᡤ䭦䥨४l❮ᑰᩲቴὶ൸䅺ټ䵾ﲀ꾂ꖄ\udc8a\ue48cﮒ힔ﺚꖞ\udaa0\u90a2\ud8a4\u8ba6覨즪사ﾮ\uddb0\ud2b2\udbb4\ud2b6쪸膺욼设변ꗆ꓈觊꓌믎ꋐ菒볔꿖볘럚ꓞ퓠黢짤쟦诨蛪꿬蛮藰胲쿴賶쿸蛺", num2), new object[] { this.picfSubType_0, this.int_7, this.int_8, this.int_9, this.int_10, this.int_11, this.int_12 });
            builder.AppendFormat(BookmarkStart.b("㼴᜶崸䌺尼砾⹀≂⥄絆㉈筊が捎煐㝒ⱔ㙖Ṙ㑚㱜㍞孠ᡢ呤ᩦ䕨䭪lᝮ䭰ࡲ䝴੶啸孺ၼپ뮀뚄惘", num2), new object[] { this.int_13, this.int_14, this.int_24, this.int_25 });
            builder.AppendFormat(BookmarkStart.b("㼴᜶崸䌺尼簾㍀ⱂ㕄୆ⱈⵊ㥌畎⩐捒⡔策祘㽚⑜㹞≠ᅢ੤ᝦ㵨Ѫᵬ啮ੰ䉲ࡴ孶奸ὺռṾ슀\udb88\ue28aꦒꖖ랚붜ﮞ\ud8a0\uc2a2햦욨\udbaa\uefac삮얰잲\udab4\udab6莸삺躼슾", num2), new object[] { this.int_13, this.int_14, this.int_17, this.int_18 });
            builder.AppendFormat(BookmarkStart.b("㼴᜶崸䌺尼瀾㍀⩂≄⹆❈煊㙌罎ⱐ罒畔㍖⁘㩚ቜⵞࡠѢ౤०卨ၪ屬ቮ嵰卲ᙴ❶୸ᑺർ౾뮀랄惘", num2), this.int_21, this.int_22, this.int_23);
        }
    }

    internal Border method_0(object A_0)
    {
        Class1031 class2 = (Class1031) A_0;
        return new Border { BorderType = class2.method_1(), LineWidth = class2.method_8(), Color = class2.method_12(), Space = class2.method_28(), Shadow = class2.method_16(), ShadeTheme = class2.method_22() };
    }

    internal void method_1(BinaryWriter A_0)
    {
        A_0.Write(this.int_2);
        A_0.Write((ushort) this.int_3);
        A_0.Write((ushort) this.picfType_0);
        A_0.Write((ushort) this.int_4);
        A_0.Write((ushort) this.int_5);
        A_0.Write((ushort) this.int_6);
        A_0.Write((ushort) this.picfSubType_0);
        A_0.Write((ushort) this.int_7);
        A_0.Write((ushort) this.int_8);
        A_0.Write((ushort) this.int_9);
        A_0.Write((ushort) this.int_10);
        A_0.Write((ushort) this.int_11);
        A_0.Write((ushort) this.int_12);
        A_0.Write((ushort) this.int_13);
        A_0.Write((ushort) this.int_14);
        A_0.Write((ushort) this.int_24);
        A_0.Write((ushort) this.int_25);
        A_0.Write((short) this.int_15);
        A_0.Write((short) this.int_16);
        A_0.Write((short) this.int_17);
        A_0.Write((short) this.int_18);
        int num = 0;
        num = 0 | this.int_19;
        num |= this.bool_0 ? 0x10 : 0;
        num |= this.bool_1 ? 0x20 : 0;
        num |= this.bool_2 ? 0x40 : 0;
        num |= this.bool_3 ? 0x80 : 0;
        num |= this.int_20 << 8;
        A_0.Write((ushort) num);
        Class355.smethod_3(this.border_0, A_0, false, 8f);
        Class355.smethod_3(this.border_1, A_0, false, 8f);
        Class355.smethod_3(this.border_2, A_0, false, 8f);
        Class355.smethod_3(this.border_3, A_0, false, 8f);
        A_0.Write((short) this.int_21);
        A_0.Write((short) this.int_22);
        A_0.Write((short) this.int_23);
    }

    internal void method_2(ShapeBase A_0)
    {
        SizeF ef = smethod_0(new SizeF((float) this.int_13, (float) this.int_14), A_0.Rotation);
        double num = (ef.Width / ((float) this.int_13)) * 1000f;
        double num2 = (ef.Height / ((float) this.int_14)) * 1000f;
        double num3 = ((double) this.int_24) / num;
        double num4 = ((double) this.int_25) / num2;
        num3 = (Math.Abs(num3) < double.Epsilon) ? 1.0 : num3;
        num4 = (Math.Abs(num4) < double.Epsilon) ? 1.0 : num4;
        double num5 = this.int_13 * num3;
        double num6 = this.int_14 * num4;
        A_0.method_39(num6 / 20.0);
        A_0.method_37(num5 / 20.0);
        A_0.method_46();
        if (this.border_1 != null)
        {
            this.border_1.method_56(A_0.ShapePr.method_58().Left);
        }
        if (this.border_0 != null)
        {
            this.border_0.method_56(A_0.ShapePr.method_58().Top);
        }
        if (this.border_3 != null)
        {
            this.border_3.method_56(A_0.ShapePr.method_58().Right);
        }
        if (this.border_2 != null)
        {
            this.border_2.method_56(A_0.ShapePr.method_58().Bottom);
        }
    }

    internal bool method_3()
    {
        if ((this.int_13 == 0) && (this.int_14 == 0))
        {
            return false;
        }
        return true;
    }

    internal static SizeF smethod_0(SizeF A_0, double A_1)
    {
        SizeF ef = A_0;
        int num = (int) smethod_1(A_1);
        if (num <= 90)
        {
            if ((num == 0) || (num != 90))
            {
                return ef;
            }
        }
        else if ((num == 180) || (num != 270))
        {
            return ef;
        }
        return new SizeF(A_0.Height, A_0.Width);
    }

    private static double smethod_1(double A_0)
    {
        double num = A_0 % 360.0;
        if (num >= 0.0)
        {
            return num;
        }
        return (360.0 + num);
    }

    private static void smethod_2(Border A_0, ShapeBase A_1, int A_2, int A_3)
    {
        Class43 shapePr = A_1.ShapePr;
        if (shapePr.method_6(A_3))
        {
            A_0.Color = (Color) shapePr.method_31(A_3);
            shapePr.Remove(A_3);
        }
    }

    private static Class1031 smethod_3(Border A_0)
    {
        Class1031 class2 = new Class1031();
        class2.method_2(A_0.BorderType);
        class2.method_4((double) A_0.LineWidth);
        class2.method_13(A_0.Color);
        class2.method_29((int) A_0.Space);
        class2.method_17(A_0.Shadow);
        class2.method_23(A_0.ShadeTheme);
        return class2;
    }
}

