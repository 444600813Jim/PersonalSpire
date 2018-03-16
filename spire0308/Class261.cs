using Spire.Doc;
using Spire.Doc.Documents;
using Spire.Doc.Fields;
using Spire.Doc.Fields.Shape;
using Spire.Doc.Formatting;
using System;
using System.Drawing;
using System.IO;

internal class Class261
{
    private CharacterFormat characterFormat_0;
    private readonly Class352 class352_0;
    private readonly Class423 class423_0;
    private int int_0 = 0x400;
    private const string string_0 = "WordPictureWatermark";
    private const string string_1 = "PowerPlusWaterMarkObject";

    internal Class261(Class423 A_0)
    {
        this.class423_0 = A_0;
        this.class352_0 = new Class352(A_0.method_61());
    }

    internal VisitorAction method_0(ShapeGroup A_0)
    {
        this.method_8(A_0);
        return VisitorAction.Continue;
    }

    internal VisitorAction method_1(ShapeGroup A_0)
    {
        return VisitorAction.Continue;
    }

    private void method_10(ShapeBase A_0)
    {
        switch (A_0.ShapeType)
        {
            case ShapeType.OleObject:
            case ShapeType.Image:
                this.method_11((ShapeObject) A_0);
                return;

            case ShapeType.OleControl:
                this.method_15((ShapeObject) A_0);
                return;
        }
        if (A_0.IsNeedDummyWhenInline)
        {
            this.method_14(A_0);
        }
        else
        {
            this.method_16(A_0);
        }
    }

    private void method_11(ShapeObject A_0)
    {
        if (A_0.HasHyperlink)
        {
            this.class423_0.method_39(FieldType.FieldHyperlink, A_0.CharacterFormat);
            this.class423_0.method_37(new Class488(A_0.HyperlinkAddress, A_0.HyperlinkSubAddress, A_0.ScreenTip, A_0.Target).ToString(), A_0.CharacterFormat);
            this.class423_0.method_44(A_0.CharacterFormat);
        }
        if (A_0.ShapeType == ShapeType.Image)
        {
            this.method_12(A_0);
        }
        else
        {
            this.method_15(A_0);
        }
    }

    private void method_12(ShapeObject A_0)
    {
        if (A_0.ImageData.IsLink)
        {
            this.method_13(A_0);
        }
        else
        {
            this.method_16(A_0);
        }
    }

    private void method_13(ShapeObject A_0)
    {
        int num = 0;
        if (!this.class423_0.method_65())
        {
            this.class423_0.method_39(FieldType.FieldIncludePicture, this.method_21());
            string str = string.Format(BookmarkStart.b("إ愧搩漫戭支瘱焳昵焷礹栻欽ሿ݁摃㵅硇㝉汋ቍ穏牑ᥓፕ੗ᵙᥛᡝ⽟ち⥣❥㱧䩩", num), Class955.smethod_5(A_0.ImageData.SourceFullName));
            if (A_0.ImageData.IsLink && !A_0.HasImageBytes)
            {
                str = str + BookmarkStart.b("稥䰧਩", num);
            }
            this.class423_0.method_37(str, this.method_21());
            this.class423_0.method_44(this.method_21());
        }
        this.method_16(A_0);
    }

    private void method_14(ShapeBase A_0)
    {
        this.class423_0.method_39(FieldType.FieldShape, A_0.CharacterFormat);
        this.class423_0.method_37(BookmarkStart.b("ᤸ栺甼績ᅀق敄杆ᕈ慊浌ɎᑐŒቔቖ὘ᑚཛྷ቞⁠㝢䕤", 0x13), A_0.CharacterFormat);
        this.class423_0.stack_1.Push(new Field(A_0.Document, FieldType.FieldShape, BookmarkStart.b("ᤸ栺甼績ᅀق敄杆ᕈ慊浌ɎᑐŒቔቖ὘ᑚཛྷ቞⁠㝢䕤", 0x13)));
        this.class423_0.method_44(A_0.CharacterFormat);
        this.method_19(A_0);
        this.method_16(A_0);
        this.class423_0.method_40(new FieldMark(A_0.Document, A_0.CharacterFormat, FieldMarkType.FieldEnd));
    }

    private void method_15(ShapeObject A_0)
    {
        FieldType fieldOCX;
        string str;
        int num = 0x10;
        ShapeType shapeType = A_0.ShapeType;
        if (shapeType != ShapeType.OleObject)
        {
            if (shapeType != ShapeType.OleControl)
            {
                throw new InvalidOperationException(BookmarkStart.b("挵嘷弹䐻丽┿⅁ぃ⍅ⱇ橉㽋♍ㅏ≑ㅓ癕ⱗ⍙ⱛ㭝也", num));
            }
            fieldOCX = FieldType.FieldOCX;
            str = Class169.smethod_0(A_0.OleFormat.Interface49.get_ObjectType());
        }
        else if (A_0.OleFormat.IsLink)
        {
            Class677 class5;
            fieldOCX = FieldType.FieldLink;
            if (!A_0.IsOleControl && !A_0.IsOleObject)
            {
                class5 = null;
            }
            else
            {
                class5 = new Class677(A_0);
            }
            char ch = '\v';
            str = Class655.smethod_0(class5).Replace(BookmarkStart.b("ጵ਷ਹ", num), BookmarkStart.b("ᘵ", num)).Replace(BookmarkStart.b("ጵ਷༹", num), BookmarkStart.b("ጵ", num)).Replace(ch.ToString(), string.Empty).Replace(BookmarkStart.b("ਵ", num), BookmarkStart.b("ጵଷ夹", num)).Replace(BookmarkStart.b("࠵", num), BookmarkStart.b("ጵଷ弹", num));
        }
        else
        {
            fieldOCX = FieldType.FieldEmbed;
            str = Class1061.smethod_0(A_0.OleFormat.Interface49.get_ObjectType());
        }
        this.class423_0.method_39(fieldOCX, A_0.CharacterFormat);
        this.class423_0.method_37(str, A_0.CharacterFormat);
        this.class423_0.stack_1.Push(new Field(A_0.Document, fieldOCX, str));
        if (A_0.OleFormat.Interface49.get_Container() == null)
        {
            this.class423_0.method_46(A_0.CharacterFormat, 0);
            this.method_16(A_0);
            goto Label_02FE;
        }
        if (A_0.OleFormat.IsChangeNativeData)
        {
            A_0.OleFormat.method_103();
        }
        Class1132 class2 = new Class1132(A_0.OleFormat.Interface49.get_Container());
        Class454 class3 = null;
        if (class2.method_0().ContainsKey(BookmarkStart.b("椵", num) + A_0.OleFormat.Interface49.get_OleStorageName()))
        {
            Class1089 class4 = class2.method_0()[BookmarkStart.b("椵", num) + A_0.OleFormat.Interface49.get_OleStorageName()] as Class1089;
            class3 = new Class454(Convert.ToInt32(A_0.OleFormat.Interface49.get_OleStorageName()), class4);
            this.class423_0.method_46(A_0.CharacterFormat, class3.method_0());
            this.class423_0.method_62().class1089_0[class3.method_2()] = class3.method_12();
            switch (A_0.OleObjectType)
            {
                case ShapeOleObjectType.Embedded:
                    this.class423_0.method_62().class1089_1[class3.method_2()] = class3.method_12();
                    goto Label_02A7;

                case ShapeOleObjectType.Linked:
                    goto Label_02A7;

                case ShapeOleObjectType.Control:
                    this.class423_0.method_62().bool_2 = true;
                    goto Label_02A7;
            }
            throw new InvalidOperationException(BookmarkStart.b("挵嘷弹䐻丽┿⅁ぃ⍅ⱇ橉͋ɍᕏ牑㭓㑕㉗㽙㽛⩝䁟ᙡᵣᙥ൧䑩", num));
        }
    Label_02A7:
        A_0.OleFormat.Interface49.get_Container().Position = 0L;
        if (((class3 != null) && class3.method_11()) && (class3.method_7() != null))
        {
            this.method_17(class3);
        }
        else
        {
            this.method_16(A_0);
        }
    Label_02FE:
        this.class423_0.method_40(new FieldMark(A_0.Document, A_0.CharacterFormat, FieldMarkType.FieldEnd));
    }

    private void method_16(ShapeBase A_0)
    {
        Stream baseStream = this.class423_0.method_59().BaseStream;
        BinaryWriter writer = this.class423_0.method_59();
        int position = (int) baseStream.Position;
        Class1107 class2 = new Class1107 {
            bool_0 = true,
            int_1 = position
        };
        this.class423_0.method_38(Class816.string_13, A_0.CharacterFormat, class2);
        Class262 class3 = new Class262(A_0);
        class3.method_1(writer);
        if (A_0.CanHaveImage)
        {
            ShapeObject obj2 = (ShapeObject) A_0;
            if (obj2.ImageData.IsLink && !obj2.HasImageBytes)
            {
                Class813.smethod_2(obj2.ImageData.SourceFullName, 0x7fffffff, writer, false, false);
            }
        }
        Class931.smethod_1(A_0, writer);
        int num2 = (int) baseStream.Position;
        class3.int_2 = num2 - position;
        baseStream.Position = position;
        class3.method_1(writer);
        baseStream.Position = num2;
    }

    private void method_17(Class454 A_0)
    {
        Class1107 class2 = new Class1107 {
            bool_0 = true,
            bool_3 = true,
            int_1 = A_0.method_0()
        };
        this.class423_0.method_38(Class816.string_13, this.method_21(), class2);
    }

    private void method_18(ShapeBase A_0)
    {
        if (A_0.IsTopLevel)
        {
            this.method_19(A_0);
        }
        if (A_0.IsOle)
        {
            ShapeObject obj2 = (ShapeObject) A_0;
            this.method_6(obj2);
            Paragraph paragraph = new Paragraph(A_0.Document);
            this.class423_0.vmethod_8(paragraph);
            TextWrappingStyle textWrappingStyle = obj2.TextWrappingStyle;
            obj2.TextWrappingStyle = TextWrappingStyle.Inline;
            this.method_15(obj2);
            obj2.TextWrappingStyle = textWrappingStyle;
            this.class423_0.vmethod_9(paragraph);
            this.method_7(obj2);
        }
    }

    private void method_19(ShapeBase A_0)
    {
        this.class352_0.method_2(A_0, Class813.smethod_22(this.class423_0.method_60()));
        Class347 class2 = new Class347(A_0);
        this.class423_0.method_50(class2);
        this.class423_0.method_38(Class601.string_0, A_0.CharacterFormat, Class423.class1107_1);
    }

    internal VisitorAction method_2(ShapeObject A_0)
    {
        this.method_8(A_0);
        if (A_0.HasChildElements || (A_0.ShapeType == ShapeType.TextBox))
        {
            this.method_6(A_0);
        }
        return VisitorAction.Continue;
    }

    internal Class352 method_20()
    {
        return this.class352_0;
    }

    internal CharacterFormat method_21()
    {
        if (this.characterFormat_0 == null)
        {
            this.characterFormat_0 = new CharacterFormat(this.class423_0.method_61());
        }
        return this.characterFormat_0;
    }

    internal VisitorAction method_3(ShapeObject A_0)
    {
        if (A_0.HasChildElements || (A_0.ShapeType == ShapeType.TextBox))
        {
            this.method_7(A_0);
        }
        return VisitorAction.Continue;
    }

    internal ShapeObject method_4(PictureWatermark A_0)
    {
        int num = 4;
        if (A_0 == null)
        {
            return null;
        }
        ShapeObject obj2 = A_0.WordPicture.Clone() as ShapeObject;
        if (A_0.IsWashout && (!obj2.ShapePr.method_6(0x108) || !obj2.ShapePr.method_6(0x109)))
        {
            obj2.SetShapeAttribute(0x108, 0x4ccd);
            obj2.SetShapeAttribute(0x109, 0x599a);
        }
        else if (!A_0.IsWashout)
        {
            obj2.ShapePr.Remove(0x108);
            obj2.ShapePr.Remove(0x109);
        }
        int num2 = this.method_9();
        obj2.Id = num2;
        obj2.Name = BookmarkStart.b("紩䌫尭启戱崳唵䰷伹主嬽᜿⍁ぃ⍅㩇❉ⵋ㱍㭏", num) + num2.ToString();
        obj2.TextWrappingStyle = TextWrappingStyle.InFrontOfText;
        obj2.SetShapeAttribute(0x3ba, true);
        return obj2;
    }

    internal ShapeObject method_5(TextWatermark A_0)
    {
        int num = 6;
        if (A_0 == null)
        {
            return null;
        }
        ShapeObject obj2 = new ShapeObject(A_0.Document, ShapeType.TextPlainText);
        if (A_0.Semitransparent)
        {
            obj2.SetShapeAttribute(0x182, 0x8000);
        }
        obj2.SetShapeAttribute(0xc0, A_0.Text);
        obj2.SetShapeAttribute(0xc5, A_0.FontName);
        obj2.SetShapeAttribute(0xc3, ((int) A_0.FontSize) * 0x10000);
        if (A_0.Color != Color.Empty)
        {
            obj2.SetShapeAttribute(0x181, A_0.Color);
        }
        if (A_0.ShapeWidthInPixels != -1)
        {
            obj2.Width = ((float) A_0.ShapeWidthInPixels) / 20f;
        }
        else
        {
            obj2.Width = A_0.ShapeSize.Width * 0.6934f;
        }
        if (A_0.ShapeHeightInPixels != -1)
        {
            obj2.Height = ((float) A_0.ShapeHeightInPixels) / 20f;
        }
        else
        {
            obj2.Height = A_0.ShapeSize.Height * 0.67f;
        }
        if (A_0.Layout == WatermarkLayout.Diagonal)
        {
            obj2.SetShapeAttribute(4, 0x13b0000);
        }
        int num2 = this.method_9();
        obj2.Id = num2;
        obj2.SetShapeAttribute(0xf1, true);
        obj2.SetShapeAttribute(0xf5, true);
        obj2.SetShapeAttribute(0x1fc, false);
        obj2.Name = BookmarkStart.b("簫䄭䜯圱䘳昵吷伹伻椽ℿ㙁⅃㑅Շ⭉㹋╍὏け㹓㍕㭗⹙", num) + num2.ToString();
        obj2.TextWrappingStyle = TextWrappingStyle.InFrontOfText;
        obj2.SetShapeAttribute(0x3ba, true);
        return obj2;
    }

    private void method_6(ShapeObject A_0)
    {
        this.class423_0.method_53(Class813.smethod_21(this.class423_0.method_60()));
        Class480 class2 = new Class480 {
            int_1 = 1,
            int_3 = -1,
            int_4 = A_0.Id
        };
        int num = this.class423_0.method_51(class2);
        Class811 class3 = new Class811 {
            int_1 = num
        };
        this.class423_0.method_52(class3);
        int num2 = Convert.ToInt32((int) ((num + 1) << 0x10));
        if (A_0.IsOle)
        {
            A_0.OleFormat.OleTxid = num2;
        }
        else
        {
            while (A_0 != null)
            {
                A_0.Txid = num2++;
                int textboxNextShapeId = A_0.TextboxNextShapeId;
                A_0 = (textboxNextShapeId != 0) ? ((ShapeObject) this.class423_0.method_62().hashtable_0[textboxNextShapeId]) : null;
            }
        }
    }

    private void method_7(ShapeObject A_0)
    {
        new Paragraph(A_0.Document).Accept(this.class423_0);
        this.class423_0.method_54();
    }

    private void method_8(ShapeBase A_0)
    {
        if ((A_0.ShapeType != ShapeType.TextBox) && !A_0.HasChildElements)
        {
            A_0.Id = this.method_9();
            if (A_0.ShapeType == ShapeType.Group)
            {
                foreach (ShapeObject obj2 in A_0.ChildObjects)
                {
                    obj2.Id = this.method_9();
                }
            }
        }
        else
        {
            A_0.Id = A_0.TextboxNextShapeId = this.method_9();
        }
        if (A_0.IsInline)
        {
            this.method_10(A_0);
        }
        else
        {
            this.method_18(A_0);
        }
    }

    internal int method_9()
    {
        return ++this.int_0;
    }
}

