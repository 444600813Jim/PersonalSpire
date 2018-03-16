using Spire.Doc;
using Spire.Doc.Documents.Converters.OpenDocument.Output;
using Spire.Doc.Fields;
using System;

internal class Class568
{
    private readonly Class422 class422_0;

    internal Class568(Class422 A_0)
    {
        this.class422_0 = A_0;
    }

    internal void method_0(string A_0, ShapeObject A_1)
    {
        if (this.class422_0.method_23() != OpenDocumentWritingStage.MathML)
        {
            this.method_1(A_0, A_1.ImageData);
        }
    }

    private void method_1(string A_0, DocPicture A_1)
    {
        int num = 11;
        byte[] imageBytes = A_1.ImageBytes;
        if ((imageBytes != null) && (imageBytes.Length > 0))
        {
            string str = Class238.smethod_3(Class409.smethod_0(imageBytes));
            this.class422_0.method_26(this.class422_0.method_25() + 1);
            string str2 = string.Format(BookmarkStart.b("愰娲嘴䌶䰸䤺堼䰾湀⩂⡄♆⹈⹊㙌罎ⱐ絒⹔晖⑘", num), this.class422_0.method_25(), str);
            Class113 class2 = new Class113(str2);
            this.class422_0.method_13().method_1().method_1(class2);
            class2.method_3().Write(imageBytes, 0, imageBytes.Length);
            this.class422_0.method_55().Add(new Class979(Class238.smethod_2((FileFormat) Class409.smethod_0(imageBytes)), str2, ""));
            this.method_2(A_0, str2);
        }
    }

    private void method_2(string A_0, string A_1)
    {
        int num = 11;
        Class400 class2 = this.class422_0.method_18();
        if (A_0 == BookmarkStart.b("䔰嘲䴴䌶̸场吼䰾㕀湂⥄≆㽈⹊⅌扎≐❒ⱔ㭖㱘癚㑜㉞`Ѣd", 11))
        {
            class2.method_40(BookmarkStart.b("䤰弲尴夶券ĺ唼䴾⑀╂", num), A_1);
            class2.method_40(BookmarkStart.b("䤰弲尴夶券ĺ䤼䘾ㅀ♂", num), BookmarkStart.b("䈰娲場䜶唸帺", num));
            class2.method_40(BookmarkStart.b("䤰弲尴夶券ĺ丼圾⹀㑂", num), BookmarkStart.b("吰帲圴制崸", num));
            class2.method_40(BookmarkStart.b("䤰弲尴夶券ĺ尼尾㕀㙂⑄㍆ⱈ", num), BookmarkStart.b("帰崲礴堶堸强", num));
        }
        else
        {
            class2.method_66(A_0);
            class2.method_68(BookmarkStart.b("䤰弲尴夶券ĺ唼䴾⑀╂", num), A_1);
            class2.method_68(BookmarkStart.b("䤰弲尴夶券ĺ䤼䘾ㅀ♂", num), BookmarkStart.b("䈰娲場䜶唸帺", num));
            class2.method_68(BookmarkStart.b("䤰弲尴夶券ĺ丼圾⹀㑂", num), BookmarkStart.b("吰帲圴制崸", num));
            class2.method_68(BookmarkStart.b("䤰弲尴夶券ĺ尼尾㕀㙂⑄㍆ⱈ", num), BookmarkStart.b("帰崲礴堶堸强", num));
            if (A_0 == BookmarkStart.b("䈰䜲䰴嬶尸ĺ弼帾≀⡂≄㕆♈㹊⍌⭎籐㩒㡔㙖㹘㹚", num))
            {
                class2.method_68(BookmarkStart.b("䈰䜲䰴嬶尸ĺ似娾ㅀ♂⑄㍆", num), BookmarkStart.b("䈰䜲䜴制䴸堺唼", num));
            }
            class2.method_9(BookmarkStart.b("Ḱല", num));
        }
    }
}

