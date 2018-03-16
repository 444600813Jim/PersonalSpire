using Spire.Doc;
using Spire.Doc.Documents;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

[ToolboxItem(false)]
internal class Class698 : Component
{
    private const ImageType imageType_0 = ImageType.Metafile;
    private int int_0 = 80;
    private List<PageSetup> list_0 = new List<PageSetup>();
    private ToPdfParameterList toPdfParameterList_0;

    private List<PageSetup> method_0()
    {
        return this.list_0;
    }

    private ToPdfParameterList method_1()
    {
        if (this.toPdfParameterList_0 == null)
        {
            this.toPdfParameterList_0 = new ToPdfParameterList();
        }
        return this.toPdfParameterList_0;
    }

    private sprᵑ method_10(BuiltinDocumentProperties A_0)
    {
        sprᵑ rᵑ = new sprᵑ();
        rᵑ.ᜀ(A_0.Author);
        rᵑ.ᜀ(A_0.CreateDate);
        rᵑ.ᜆ(A_0.Company);
        rᵑ.ᜄ(A_0.Keywords);
        rᵑ.ᜉ(A_0.Subject);
        rᵑ.ᜈ(A_0.Title);
        return rᵑ;
    }

    private void method_11(List<Dictionary<string, RectangleF>> A_0, spr⠃ A_1)
    {
        for (int i = 0; i < A_0.Count; i++)
        {
            foreach (KeyValuePair<string, RectangleF> pair in A_0[i])
            {
                RectangleF local1 = pair.Value;
                pair.Key.Equals(string.Empty);
            }
        }
    }

    private void method_12(Class195 A_0, Stream A_1)
    {
        this.method_9(A_0);
        int count = A_0.method_0().Count;
        int num3 = (count > 90) ? 3 : ((count > 60) ? 5 : ((count > 30) ? 10 : count));
        sprᵑ rᵑ = this.method_10(A_0.method_35().BuiltinDocumentProperties);
        sprᵕ rᵕ = this.method_8(rᵑ);
        for (int i = 0; i < count; i++)
        {
            using (MemoryStream stream = new MemoryStream())
            {
                A_0.method_60(i, 1, ImageType.Metafile, stream, false, false, GraphicsUnit.Point);
                spr⇬ r⇬ = new spr⇬(stream);
                spr᧷ r᧷ = new spr᧷();
                r᧷.ᜀ(A_0.method_34().method_0()[i].method_2());
                spr➓ r➓ = new spr⠀(r⇬, r᧷).ᜀ(this.method_0()[i].PageSize, true);
                spr⠃ r⠃ = new spr⠃(this.method_0()[i].PageSize.Width, this.method_0()[i].PageSize.Height);
                r⠃.ᜁ(r➓);
                rᵕ.ᜀ(r⠃);
                A_0.method_34().method_0()[i].method_0().Dispose();
                A_0.method_34().method_0()[i].method_1(null);
            }
            if ((i % num3) == 0)
            {
                GC.Collect();
            }
        }
        A_0.method_51();
        rᵕ.ᜄ();
        rᵕ.ᜁ().ᜀ(A_1);
    }

    private void method_13(int A_0, sprᵕ A_1)
    {
        int num = 14;
        PageSetup setup = this.method_0()[A_0];
        using (MemoryStream stream = new MemoryStream())
        {
            using (Image image = this.method_14(setup, stream))
            {
                using (Graphics graphics = Graphics.FromImage(image))
                {
                    graphics.PageUnit = GraphicsUnit.Point;
                    graphics.DrawString(BookmarkStart.b("朳䘵儷䠹夻ḽпⵁ❃桅", num), new Font(BookmarkStart.b("怳張唷弹伻ḽ฿❁㍃晅ᩇ╉⅋⽍㹏", num), 20f, FontStyle.Bold), Brushes.Red, new PointF(10f, 10f));
                    graphics.DrawString(BookmarkStart.b("爳䐵崷弹᰻䠽┿ぁ㝃⽅❇⑉汋ⵍ㽏㱑≓㍕⩗⹙㕛そݟ䉡፣॥ᩧ๩䱫੭Ὧᅱų᭵ᵷᑹࡻൽꁿꚅ킇憎ﾋ꺍ﮑ뚙벛쾟힡蒣얥즧쒩貫솭\udeaf\udeb1춳隵\udfb7\udfb9좻麽뒿꫁ꇃ껇ꏉ뻋뷍꓏꣗믙믛믝샟跡苣웥냧髩鿫컭雯鯱飳鏵훷", num), new Font(BookmarkStart.b("怳張唷弹伻ḽ฿❁㍃晅ᩇ╉⅋⽍㹏", num), 16f, FontStyle.Regular), Brushes.Red, new PointF(10f, 30f));
                    graphics.DrawString(BookmarkStart.b("愳䘵強䠹崻娽┿扁ぃ⥅桇ॉ⍋⍍㵏㝑♓㕕ㅗ㭙せ繝╟١ൣብŧթɫ乭Ὧᑱ味╵ࡷ፹๻᭽깿욁ꢇ뚉揄꺓릕랗躟잡覣쾥쮧쾩캫슭얯ힱ骳햵ힷힹ鎻꺿뛁뛃꧅곇뿉꿋ꯍￏꗑ믓ꓕ볗뫛뇝鋟쿡諣菥鳧쟩藫胭蓯胱鯳鋵跷駹駻탽棿瘁椃樅㘇␉", num), new Font(BookmarkStart.b("怳張唷弹伻ḽ฿❁㍃晅ᩇ╉⅋⽍㹏", num), 16f, FontStyle.Regular), Brushes.Red, new PointF(10f, 42f));
                }
                spr⇬ r⇬ = new spr⇬(stream);
                spr᧷ r᧷ = new spr᧷();
                spr➓ r➓ = new spr⠀(r⇬, r᧷).ᜀ(setup.PageSize, true);
                spr⠃ r⠃ = new spr⠃(setup.PageSize.Width, setup.PageSize.Height);
                r⠃.ᜁ(r➓);
                A_1.ᜀ(r⠃);
            }
        }
    }

    private Image method_14(PageSetup A_0, MemoryStream A_1)
    {
        Image image;
        int width = (int) A_0.PageSize.Width;
        int height = (int) A_0.PageSize.Height;
        using (Bitmap bitmap = new Bitmap((int) A_0.PageSize.Width, (int) A_0.PageSize.Height, PixelFormat.Format32bppPArgb))
        {
            bitmap.SetResolution(96f, 96f);
            using (Graphics graphics = Graphics.FromImage(bitmap))
            {
                graphics.PageUnit = GraphicsUnit.Point;
                IntPtr hdc = graphics.GetHdc();
                RectangleF frameRect = new RectangleF(0f, 0f, (float) width, (float) height);
                image = new Metafile(A_1, hdc, frameRect, MetafileFrameUnit.Point, EmfType.EmfPlusDual);
            }
        }
        return image;
    }

    internal void method_2(int A_0)
    {
        this.int_0 = A_0;
    }

    public void method_3(Document A_0, Stream A_1)
    {
        using (Class195 class2 = new Class195())
        {
            A_0.OperationType = DocumentOperationType.Layout;
            class2.method_20(this.method_1());
            class2.method_8(true);
            class2.method_43(A_0);
            A_0.OperationType = DocumentOperationType.None;
            this.method_12(class2, A_1);
        }
    }

    public void method_4(Document A_0, Stream A_1, ToPdfParameterList A_2)
    {
        this.toPdfParameterList_0 = A_2;
        this.method_3(A_0, A_1);
    }

    public void method_5(Document A_0, Stream A_1, List<string> A_2)
    {
        ToPdfParameterList list = new ToPdfParameterList {
            EmbeddedFontNameList = A_2
        };
        this.method_4(A_0, A_1, list);
    }

    public void method_6(string A_0, string A_1)
    {
        Document document = new Document(A_0, FileFormat.Auto);
        using (FileStream stream = new FileStream(A_1, FileMode.Create, FileAccess.ReadWrite, FileShare.Read))
        {
            this.method_3(document, stream);
        }
    }

    public void method_7(Stream A_0, Stream A_1)
    {
        Document document = new Document(A_0, FileFormat.Auto);
        this.method_3(document, A_1);
    }

    private sprᵕ method_8(sprᵑ A_0)
    {
        return new sprᵕ(A_0, new sprᶜ());
    }

    private void method_9(Class195 A_0)
    {
        for (int i = 0; i < A_0.method_0().Count; i++)
        {
            Class500 class2 = A_0.method_0()[i];
            this.method_0().Add(class2.method_28());
        }
    }
}

