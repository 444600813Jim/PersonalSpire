using Spire.Doc;
using Spire.Doc.Fields;
using System;

internal class Class1093
{
    private readonly Class422 class422_0;

    internal Class1093(Class422 A_0)
    {
        this.class422_0 = A_0;
    }

    internal void method_0(ShapeObject A_0)
    {
        this.method_2(BookmarkStart.b("嘱䘳圵伷9唻匽ℿ╁⅃", 12), A_0.ImageData);
    }

    private void method_1(string A_0, ShapeObject A_1)
    {
    }

    private void method_2(string A_0, DocPicture A_1)
    {
        int num = 3;
        if ((A_1.ImageBytes != null) && (A_1.ImageBytes.Length > 0))
        {
            byte[] imageBytes = A_1.ImageBytes;
            string str = string.Format(BookmarkStart.b("昨䤪䜬䨮到䜲朴制䤸场尼尾⑀⹂⁄⥆㵈㡊扌N㍐㥒ご㑖ⵘ筚♜潞ᱠ", num), this.class422_0.method_27());
            Class113 class2 = new Class113(str);
            if (this.class422_0.method_13().method_1().method_2(class2.method_1()) == null)
            {
                this.class422_0.method_13().method_1().method_1(class2);
            }
            class2.method_3().Write(imageBytes, 0, imageBytes.Length);
            this.method_3(A_0, str, null);
        }
    }

    private void method_3(string A_0, string A_1, string A_2)
    {
        Class400 class2 = this.class422_0.method_18();
        class2.method_66(A_0);
        class2.method_68(BookmarkStart.b("丵吷匹刻唽稿⩁㙃⍅⹇", 0x10), A_1);
        class2.method_68(BookmarkStart.b("丵吷匹刻唽稿㙁㵃㙅ⵇ", 0x10), BookmarkStart.b("䔵儷圹䰻刽┿", 0x10));
        class2.method_68(BookmarkStart.b("丵吷匹刻唽稿ㅁⱃ⥅㽇", 0x10), BookmarkStart.b("匵唷堹夻娽", 0x10));
        class2.method_68(BookmarkStart.b("丵吷匹刻唽稿⍁❃㉅㵇⭉㡋⭍", 0x10), BookmarkStart.b("夵嘷瘹医弽␿", 0x10));
        class2.method_68(BookmarkStart.b("刵䨷嬹䬻н⌿⹁╃㕅㭇杉╋⩍", 0x10), A_2);
        class2.method_9(BookmarkStart.b("ᤵط", 0x10));
    }
}

