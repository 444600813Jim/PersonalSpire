using Spire.Doc;
using Spire.Doc.Core.DataStreamParser.Escher;
using Spire.Doc.Documents;
using Spire.Doc.Documents.Converters.OpenDocument.Output;
using Spire.Doc.Fields;
using Spire.Doc.Fields.Shape;
using Spire.Doc.Formatting;
using System;
using System.Collections;
using System.Drawing;

internal class Class468
{
    private readonly Class1093 class1093_0;
    private readonly Class422 class422_0;
    private readonly Class568 class568_0;
    private readonly Class691 class691_0;
    private readonly Class974 class974_0;

    internal Class468(Class422 A_0)
    {
        this.class422_0 = A_0;
        this.class691_0 = new Class691(this.class422_0);
        this.class974_0 = new Class974(this.class422_0);
        this.class568_0 = new Class568(this.class422_0);
        this.class1093_0 = new Class1093(this.class422_0);
    }

    internal VisitorAction method_0(ShapeBase A_0)
    {
        int num = 13;
        if (this.class422_0.method_23() != OpenDocumentWritingStage.MathML)
        {
            if (this.method_1(A_0))
            {
                return VisitorAction.SkipThisElement;
            }
            if (this.method_4(A_0))
            {
                return VisitorAction.Continue;
            }
            if (this.class422_0.method_21())
            {
                if (smethod_7(A_0))
                {
                    this.class974_0.method_1(A_0, true);
                }
                if (smethod_9(A_0))
                {
                    this.class974_0.method_1(A_0, false);
                }
            }
            else if (this.class422_0.method_23() == OpenDocumentWritingStage.StrokeDashForHeadersFooters)
            {
                this.method_5(A_0);
            }
            else
            {
                Class400 class2 = this.class422_0.method_18();
                if (smethod_7(A_0))
                {
                    this.class691_0.method_1();
                }
                if (A_0 is ShapeGroup)
                {
                    this.method_12(A_0);
                }
                else if (A_0.ShapeType == ShapeType.Line)
                {
                    this.method_9((ShapeObject) A_0, BookmarkStart.b("圲䜴嘶丸ĺ儼嘾⽀♂", num));
                }
                else if (smethod_0(A_0.ShapeType))
                {
                    this.method_9((ShapeObject) A_0, BookmarkStart.b("圲䜴嘶丸ĺ帼倾⽀ⵂ⁄⑆㵈⑊㽌", num));
                }
                else if (smethod_10(A_0))
                {
                    this.method_10((ShapeObject) A_0, BookmarkStart.b("圲䜴嘶丸ĺ似娾≀㝂", num));
                }
                else if (A_0.ShapeType == ShapeType.Ellipse)
                {
                    this.method_10((ShapeObject) A_0, BookmarkStart.b("圲䜴嘶丸ĺ堼匾ⵀ⩂㕄㑆ⱈ", num));
                }
                else if (smethod_2(A_0))
                {
                    this.method_3((ShapeObject) A_0);
                }
                else if (smethod_6(A_0))
                {
                    if (Class567.smethod_16(A_0.HRef) && !(A_0.ParentObject is ShapeGroup))
                    {
                        class2.method_66(BookmarkStart.b("圲䜴嘶丸ĺ尼", num));
                        class2.method_68(BookmarkStart.b("䬲头帶圸债ܼ䬾㡀㍂⁄", num), BookmarkStart.b("䀲尴娶䤸场堼", num));
                        class2.method_68(BookmarkStart.b("䬲头帶圸债ܼ圾㍀♂⍄", num), A_0.HRef);
                        class2.method_69(BookmarkStart.b("尲匴儶倸堺堼Ծ㕀≂㝄⁆ⱈ㽊恌⥎⍐㉒㡔㉖瑘㕚㱜㉞Ѡ", num), A_0.Target);
                    }
                    this.method_11(A_0, BookmarkStart.b("圲䜴嘶丸ĺ嬼䴾⁀⹂⁄", num));
                }
                if (A_0 is ShapeObject)
                {
                    ShapeObject obj2 = A_0 as ShapeObject;
                    if (A_0.IsOle)
                    {
                        this.class1093_0.method_0(obj2);
                    }
                    else if (A_0.IsImage || obj2.HasImageBytes)
                    {
                        this.class568_0.method_0(BookmarkStart.b("圲䜴嘶丸ĺ吼刾⁀⑂⁄", num), obj2);
                    }
                }
            }
            this.method_2(A_0);
        }
        return VisitorAction.Continue;
    }

    private bool method_1(ShapeBase A_0)
    {
        int num = 6;
        if (((A_0 is ShapeObject) && !this.class422_0.method_21()) && (this.class422_0.method_23() != OpenDocumentWritingStage.StrokeDashForHeadersFooters))
        {
            ShapeObject obj2 = (ShapeObject) A_0;
            object obj3 = A_0.ShapePr.method_31(0x3b8);
            if (((obj3 != null) && ((bool) obj3)) && (obj2.ScriptType == BookmarkStart.b("堫䬭䠯䘱ᬳ尵夷䰹崻䴽⌿ぁⵃ㙅㱇", num)))
            {
                Class400 class2 = this.class422_0.method_18();
                class2.method_66(BookmarkStart.b("堫䬭䠯䘱ำ䔵嬷䠹唻丽㐿", num));
                class2.method_69(BookmarkStart.b("弫䴭䈯嬱䐳䈵ȷ嘹崻倽✿㝁╃ⅅⵇ", num), BookmarkStart.b("昫伭䘯匱朳唵䨷匹䰻䨽", num));
                class2.method_15(obj2.ScriptText);
                class2.method_67(BookmarkStart.b("堫䬭䠯䘱ำ䔵嬷䠹唻丽㐿", num));
                return true;
            }
        }
        return false;
    }

    private void method_10(ShapeObject A_0, string A_1)
    {
        int num = 8;
        Class400 class2 = this.class422_0.method_18();
        class2.method_66(A_1);
        if (A_0.Rotation == 0.0)
        {
            PointF tf = A_0.method_48(new PointF((float) A_0.Left, (float) A_0.Top));
            class2.method_68(BookmarkStart.b("崭䘯唱ำ丵", num), Class576.smethod_42((double) tf.X));
            class2.method_68(BookmarkStart.b("崭䘯唱ำ伵", num), Class576.smethod_42((double) tf.Y));
        }
        else
        {
            class2.method_68(BookmarkStart.b("崭䘯唱ำ丵", num), BookmarkStart.b("ḭ匯弱", num));
            class2.method_68(BookmarkStart.b("崭䘯唱ำ伵", num), BookmarkStart.b("ḭ匯弱", num));
        }
        class2.method_68(BookmarkStart.b("崭䘯唱ำ䄵儷帹䠻嘽", num), Class576.smethod_42(smethod_11(A_0, (double) A_0.SizeInPoints.Width)));
        class2.method_68(BookmarkStart.b("崭䘯唱ำ帵崷匹嬻嘽㐿", num), Class576.smethod_42(smethod_11(A_0, (double) A_0.SizeInPoints.Height)));
        this.method_8(A_0);
    }

    private void method_11(ShapeBase A_0, string A_1)
    {
        bool flag;
        int num = 0x10;
        Class400 class2 = this.class422_0.method_18();
        class2.method_66(A_1);
        if (!(flag = !(A_0.Rotation == 0.0)))
        {
            PointF tf = A_0.method_48(new PointF((float) A_0.Left, (float) A_0.Top));
            class2.method_68(BookmarkStart.b("䔵丷崹ػ䘽", num), Class576.smethod_42(tf.X - ((!(A_0 is ShapeObject) || !((ShapeObject) A_0).Stroked) ? 0.0 : ((ShapeObject) A_0).StrokeWeight)));
            double num2 = tf.Y - ((!(A_0 is ShapeObject) || !((ShapeObject) A_0).Stroked) ? 0.0 : ((ShapeObject) A_0).StrokeWeight);
            class2.method_68(BookmarkStart.b("䔵丷崹ػ䜽", num), Class576.smethod_42(num2));
        }
        else
        {
            class2.method_68(BookmarkStart.b("䔵丷崹ػ䘽", num), BookmarkStart.b("ص儷吹", num));
            class2.method_68(BookmarkStart.b("䔵丷崹ػ䜽", num), BookmarkStart.b("ص儷吹", num));
        }
        if (A_0.SizeInPoints.Width != 0f)
        {
            class2.method_68(BookmarkStart.b("䔵丷崹ػ䤽⤿♁ぃ⹅", num), Class576.smethod_42((!(A_0 is DocPicture) ? ((double) A_0.SizeInPoints.Width) : ((double) ((A_0.SizeInPoints.Width * ((DocPicture) A_0).WidthScale) / 100f))) + (((!(A_0 is ShapeObject) || !((ShapeObject) A_0).Stroked) || flag) ? 0.0 : (((ShapeObject) A_0).StrokeWeight * 2.0))));
        }
        else
        {
            class2.method_68(BookmarkStart.b("䔵丷崹ػ䤽⤿♁ぃ⹅", num), BookmarkStart.b("ص儷吹", num));
        }
        if (A_0.SizeInPoints.Height != 0f)
        {
            class2.method_68(BookmarkStart.b("䔵丷崹ػ嘽┿⭁⍃⹅㱇", num), Class576.smethod_42((!(A_0 is DocPicture) ? ((double) A_0.SizeInPoints.Height) : ((double) ((A_0.SizeInPoints.Height * ((DocPicture) A_0).HeightScale) / 100f))) + (((!(A_0 is ShapeObject) || !((ShapeObject) A_0).Stroked) || flag) ? 0.0 : (((ShapeObject) A_0).StrokeWeight * 2.0))));
        }
        else
        {
            class2.method_68(BookmarkStart.b("䔵丷崹ػ嘽┿⭁⍃⹅㱇", num), BookmarkStart.b("ص儷吹", num));
        }
        this.method_8(A_0);
    }

    private void method_12(ShapeBase A_0)
    {
        this.class422_0.method_18().method_66(BookmarkStart.b("启䀱唳䄵ȷ崹", 10));
        this.method_8(A_0);
    }

    private void method_2(ShapeBase A_0)
    {
        if ((A_0 is ShapeObject) && smethod_2(A_0))
        {
            ShapeObject obj2 = (ShapeObject) A_0;
            if (obj2.WordArt.On && Class567.smethod_16(obj2.WordArt.Text))
            {
                foreach (string str in obj2.WordArt.Text.Split(new char[] { '\n' }))
                {
                    Paragraph paragraph = new Paragraph(this.class422_0.method_15());
                    paragraph.method_0(obj2);
                    paragraph.ChildObjects.Add(new TextRange(this.class422_0.method_15(), str, new CharacterFormat()));
                    paragraph.Accept(this.class422_0);
                }
            }
        }
    }

    private void method_3(ShapeObject A_0)
    {
        this.class422_0.method_66(true);
        this.method_11(A_0, BookmarkStart.b("䬮䌰刲䈴ശ娸为丼䬾⹀⹂桄㑆ⅈ⩊㵌⩎", 9));
        new Class970(this.class422_0).method_0(A_0);
    }

    private bool method_4(ShapeBase A_0)
    {
        bool flag;
        if (!(A_0 is ShapeGroup))
        {
            goto Label_0074;
        }
        if (A_0.ChildObjects.Count == 0)
        {
            return true;
        }
        bool flag2 = true;
        using (IEnumerator enumerator = A_0.ChildObjects.GetEnumerator())
        {
            while (enumerator.MoveNext())
            {
                DocumentObject current = (DocumentObject) enumerator.Current;
                if ((current is ShapeBase) && !this.method_4(current as ShapeBase))
                {
                    goto Label_0057;
                }
            }
            goto Label_006F;
        Label_0057:
            flag2 = false;
        }
    Label_006F:
        if (flag2)
        {
            return true;
        }
    Label_0074:
        if (((A_0 is ShapeObject) && smethod_1((ShapeObject) A_0)) || this.class422_0.method_73())
        {
            return true;
        }
        if (A_0.Owner == null)
        {
            flag = false;
        }
        else
        {
            flag = A_0.GetAncestor(DocumentObjectType.Comment) != null;
        }
        if ((!Class422.smethod_1(A_0) && this.class422_0.method_20()) || flag)
        {
            return true;
        }
        if (A_0 is ShapeObject)
        {
            DocPicture imageData = (A_0 as ShapeObject).ImageData;
            if ((A_0.IsImage || A_0.IsOleControl) && ((imageData.ImageBytes == null) || (imageData.ImageBytes.Length <= 0)))
            {
                return true;
            }
        }
        return false;
    }

    private void method_5(ShapeBase A_0)
    {
        Class43 shapePr = A_0.ShapePr;
        for (int i = 0; i < shapePr.Count; i++)
        {
            int num2 = shapePr.method_18(i);
            object obj2 = shapePr.method_19(i);
            if (obj2 != null)
            {
                switch (num2)
                {
                    case 0x1ce:
                    {
                        LineDashing dashing = (LineDashing) obj2;
                        Class109 class3 = Class922.smethod_13(A_0, this.class422_0.method_81().method_8());
                        if (((dashing != LineDashing.Solid) && (dashing != LineDashing.Solid)) && (this.class422_0.method_81().method_2(class3.method_0(), null, false, false) == null))
                        {
                            this.class422_0.method_81().method_1(class3, false, false);
                        }
                        break;
                    }
                    case 0x1d0:
                        this.class422_0.method_12(shapePr, (ArrowType) obj2, true);
                        break;

                    case 0x1d1:
                        this.class422_0.method_12(shapePr, (ArrowType) obj2, false);
                        break;
                }
            }
        }
    }

    private void method_6(ShapeBase A_0)
    {
        int num = 2;
        Class400 class2 = this.class422_0.method_18();
        if (A_0.IsInline)
        {
            class2.method_68(BookmarkStart.b("尧伩含娭ਯ匱娳唵倷唹主ጽ㐿㭁㑃⍅", num), BookmarkStart.b("䤧天ī䴭堯匱䘳", num));
        }
        else if ((!A_0.IsImage && !A_0.IsOle) && (!(A_0 is ShapeObject) || !smethod_4(A_0 as ShapeObject)))
        {
            if ((A_0.VerticalOrigin == VerticalOrigin.Page) && (A_0.HorizontalOrigin == HorizontalOrigin.Page))
            {
                class2.method_68(BookmarkStart.b("尧伩含娭ਯ匱娳唵倷唹主ጽ㐿㭁㑃⍅", num), BookmarkStart.b("堧䬩䬫䬭", num));
            }
        }
        else
        {
            class2.method_68(BookmarkStart.b("尧伩含娭ਯ匱娳唵倷唹主ጽ㐿㭁㑃⍅", num), BookmarkStart.b("䬧䈩䴫尭", num));
        }
    }

    internal VisitorAction method_7(ShapeBase A_0)
    {
        int num = 9;
        if (this.class422_0.method_23() != OpenDocumentWritingStage.MathML)
        {
            if (this.method_4(A_0))
            {
                return VisitorAction.Continue;
            }
            Class400 class2 = this.class422_0.method_18();
            if (!this.class422_0.method_21() && (this.class422_0.method_23() != OpenDocumentWritingStage.StrokeDashForHeadersFooters))
            {
                if (Class567.smethod_16(A_0.AlternativeText))
                {
                    class2.method_11(BookmarkStart.b("尮䜰吲༴匶尸䠺帼", num), A_0.AlternativeText);
                }
                if (A_0 is ShapeGroup)
                {
                    class2.method_67(BookmarkStart.b("䬮䌰刲䈴ശ常", num));
                }
                else if (A_0.ShapeType == ShapeType.Line)
                {
                    class2.method_67(BookmarkStart.b("䬮䌰刲䈴ശ唸刺匼娾", num));
                }
                else if (smethod_0(A_0.ShapeType))
                {
                    class2.method_67(BookmarkStart.b("䬮䌰刲䈴ശ娸吺匼儾⑀⁂ㅄ⡆㭈", num));
                }
                else if (smethod_10(A_0))
                {
                    class2.method_67(BookmarkStart.b("䬮䌰刲䈴ശ䬸帺帼䬾", num));
                }
                else if (A_0.ShapeType == ShapeType.Ellipse)
                {
                    class2.method_67(BookmarkStart.b("䬮䌰刲䈴ശ尸场儼嘾ㅀあ⁄", num));
                }
                else if (smethod_2(A_0))
                {
                    class2.method_67(BookmarkStart.b("䬮䌰刲䈴ശ娸为丼䬾⹀⹂桄㑆ⅈ⩊㵌⩎", num));
                    this.class422_0.method_66(false);
                }
                else if (smethod_6(A_0))
                {
                    class2.method_67(BookmarkStart.b("䬮䌰刲䈴ശ弸䤺尼刾⑀", num));
                    if (Class567.smethod_16(A_0.HRef) && !(A_0.ParentObject is ShapeGroup))
                    {
                        class2.method_67(BookmarkStart.b("䬮䌰刲䈴ശ堸", num));
                    }
                }
                if (smethod_7(A_0))
                {
                    this.class691_0.method_2();
                }
            }
        }
        return VisitorAction.Continue;
    }

    private void method_8(ShapeBase A_0)
    {
        int num = 4;
        Class400 class2 = this.class422_0.method_18();
        class2.method_68(BookmarkStart.b("丩師伭䜯࠱䜳䈵䄷嘹夻ጽ⸿⍁⥃⍅", 4), this.class974_0.method_26());
        this.method_6(A_0);
        if (A_0.Rotation != 0.0)
        {
            PointF tf = A_0.method_48(new PointF((float) A_0.Left, (float) A_0.Top));
            class2.method_68(BookmarkStart.b("丩師伭䜯࠱䀳䐵夷吹伻堽⼿ぁ⥃", num), string.Format(BookmarkStart.b("帩師伭帯䄱堳圵䰷弹ᐻ䔽瀿㽁摃㵅祇㝉敋湍≏㵑⁓㝕ⱗ㽙籛癝᭟偡ᥣ佥䡧ṩṫ཭ṯűᡳ᝵౷ό呻ս덿ﾁꒃﶅ벇ꖋ", num), new object[] { Class576.smethod_53(Class576.smethod_43((double) -A_0.SizeInPoints.Width) / 2.0), Class576.smethod_53(Class576.smethod_43((double) -A_0.SizeInPoints.Height) / 2.0), Class1041.smethod_47((3.1415926535897931 * -A_0.Rotation) / 180.0), Class576.smethod_53(Class576.smethod_43((double) tf.X) + (Class576.smethod_43((double) A_0.SizeInPoints.Width) / 2.0)), Class576.smethod_53(Class576.smethod_43((double) tf.Y) + (Class576.smethod_43((double) A_0.SizeInPoints.Height) / 2.0)) }));
        }
        class2.method_69(BookmarkStart.b("丩師伭䜯࠱丳ᬵ儷吹堻嬽㠿", num), ((A_0.ZOrder < 0L) ? 0L : A_0.ZOrder).ToString());
    }

    private void method_9(ShapeObject A_0, string A_1)
    {
        int num = 5;
        PointF tf = A_0.method_48(new PointF((float) A_0.Left, (float) A_0.Top));
        double x = tf.X;
        double num3 = tf.X;
        double y = tf.Y;
        double num5 = tf.Y;
        double num6 = smethod_11(A_0, (double) A_0.SizeInPoints.Width);
        double num7 = smethod_11(A_0, (double) A_0.SizeInPoints.Height);
        switch (A_0.FlipOrientation)
        {
            case FlipOrientation.Horizontal:
                x += num6;
                num5 += num7;
                break;

            case FlipOrientation.Vertical:
                num3 += num6;
                y += num7;
                break;

            case FlipOrientation.Both:
                x += num6;
                y += num7;
                break;

            default:
                num3 += num6;
                num5 += num7;
                break;
        }
        Class400 class2 = this.class422_0.method_18();
        class2.method_66(A_1);
        class2.method_68(BookmarkStart.b("伪弬丮䘰ल䄴丶䤸帺", num), Class922.smethod_7(A_0.ConnectorType));
        class2.method_68(BookmarkStart.b("堪嬬䠮ର䬲д", num), Class576.smethod_42(x));
        class2.method_68(BookmarkStart.b("堪嬬䠮ର䨲д", num), Class576.smethod_42(y));
        class2.method_68(BookmarkStart.b("堪嬬䠮ର䬲ܴ", num), Class576.smethod_42(num3));
        class2.method_68(BookmarkStart.b("堪嬬䠮ର䨲ܴ", num), Class576.smethod_42(num5));
        this.method_8(A_0);
    }

    private static bool smethod_0(ShapeType A_0)
    {
        return (A_0 == ShapeType.StraightConnector1);
    }

    private static bool smethod_1(ShapeObject A_0)
    {
        ShapeType shapeType = A_0.ShapeType;
        return (((!smethod_4(A_0) && (!A_0.IsImage || (A_0.ImageData.ImageBytes == null))) && (((!A_0.HasImageBytes && !A_0.IsOle) && ((shapeType != ShapeType.Line) && (shapeType != ShapeType.Rectangle))) && ((shapeType != ShapeType.Ellipse) && !smethod_0(shapeType)))) && !smethod_2(A_0));
    }

    private static bool smethod_10(ShapeBase A_0)
    {
        if (A_0.ShapeType != ShapeType.Rectangle)
        {
            return false;
        }
        if (((ShapeObject) A_0).TextBox != null)
        {
            return !A_0.HasChildElements;
        }
        return true;
    }

    private static double smethod_11(ShapeObject A_0, double A_1)
    {
        if (A_1 <= ShapeBase.double_0)
        {
            return A_1;
        }
        if (A_0.ParentObject == null)
        {
            return A_1;
        }
        return ShapeBase.double_0;
    }

    private static bool smethod_2(ShapeBase A_0)
    {
        ShapeType shapeType = A_0.ShapeType;
        return (((!(A_0 is ShapeObject) || !(A_0 as ShapeObject).HasImageBytes) && ((((((shapeType != ShapeType.Image) && (shapeType != ShapeType.TextBox)) && ((shapeType != ShapeType.Group) && (shapeType != ShapeType.OleObject))) && (((shapeType != ShapeType.OleControl) && (shapeType != ShapeType.Rectangle)) && ((shapeType != ShapeType.Ellipse) && (shapeType != ShapeType.Line)))) && ((((shapeType != ShapeType.CurvedConnector2) && (shapeType != ShapeType.ActionButtonBlank)) && ((shapeType != ShapeType.ActionButtonHome) && (shapeType != ShapeType.ActionButtonHelp))) && (((shapeType != ShapeType.ActionButtonInformation) && (shapeType != ShapeType.ActionButtonForwardNext)) && ((shapeType != ShapeType.ActionButtonBackPrevious) && (shapeType != ShapeType.ActionButtonEnd))))) && (((((shapeType != ShapeType.ActionButtonBeginning) && (shapeType != ShapeType.ActionButtonReturn)) && ((shapeType != ShapeType.ActionButtonDocument) && (shapeType != ShapeType.ActionButtonSound))) && (((shapeType != ShapeType.ActionButtonMovie) && (shapeType != ShapeType.TextSimple)) && ((shapeType != ShapeType.TextOctagon) && (shapeType != ShapeType.TextHexagon)))) && (((shapeType != ShapeType.TextCurve) && (shapeType != ShapeType.TextWave)) && ((shapeType != ShapeType.TextRing) && (shapeType != ShapeType.TextOnCurve)))))) && (shapeType != ShapeType.TextOnRing));
    }

    internal static bool smethod_3(ShapeObject A_0)
    {
        ShapeType shapeType = A_0.ShapeType;
        if ((!A_0.IsImage && !A_0.IsConnector) && ((shapeType != ShapeType.Line) && (shapeType != ShapeType.Ellipse)))
        {
            return smethod_2(A_0);
        }
        return true;
    }

    private static bool smethod_4(ShapeObject A_0)
    {
        return ((A_0.ShapeType == ShapeType.TextBox) || (((A_0.TextBox != null) && !smethod_3(A_0)) && A_0.HasChildElements));
    }

    private static bool smethod_5(ShapeBase A_0)
    {
        return (((((A_0.ChildObjects.Count == 1) && (A_0.ChildObjects[0] is Paragraph)) && ((((Paragraph) A_0.ChildObjects[0]).ChildObjects.Count == 1) && (((Paragraph) A_0.ChildObjects[0]).ChildObjects[0] is ShapeObject))) && ((ShapeObject) ((Paragraph) A_0.ChildObjects[0]).ChildObjects[0]).IsImage) && (A_0.ParentObject is ShapeGroup));
    }

    private static bool smethod_6(ShapeBase A_0)
    {
        Paragraph parentObject = A_0.ParentObject as Paragraph;
        if ((((parentObject != null) && (parentObject.ChildObjects.Count == 1)) && ((parentObject.ParentObject is ShapeObject) && smethod_4((ShapeObject) parentObject.ParentObject))) && A_0.IsImage)
        {
            if (!A_0.IsImage)
            {
                return false;
            }
            if (parentObject.ParentObject.ChildObjects.Count <= 1)
            {
                return !(parentObject.ParentObject.ParentObject is ShapeGroup);
            }
        }
        return true;
    }

    private static bool smethod_7(ShapeBase A_0)
    {
        Paragraph parentObject = A_0.ParentObject as Paragraph;
        if (!A_0.IsInline || !A_0.IsTopLevel)
        {
            return false;
        }
        return (((!A_0.IsImage && !A_0.IsOle) && (!(A_0 is ShapeObject) || !(A_0 as ShapeObject).HasImageBytes)) || ((((parentObject != null) && (parentObject.ParentObject != null)) && (parentObject.ParentObject.ChildObjects.Count > 1)) && (parentObject.ParentObject.ParentObject is ShapeGroup)));
    }

    private static bool smethod_8(ShapeBase A_0)
    {
        return (((A_0 is ShapeObject) && smethod_4((ShapeObject) A_0)) && !smethod_5(A_0));
    }

    private static bool smethod_9(ShapeBase A_0)
    {
        return (((((A_0 is ShapeGroup) || (A_0.ShapeType == ShapeType.Line)) || (A_0.ShapeType == ShapeType.Ellipse)) || ((A_0.ShapeType == ShapeType.Rectangle) && ((((ShapeObject) A_0).TextBox == null) || !A_0.HasChildElements))) || smethod_6(A_0));
    }
}

