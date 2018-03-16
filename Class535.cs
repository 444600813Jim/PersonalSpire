using Spire.Doc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;

[ToolboxItem(false)]
internal class Class535 : Component
{
    private List<PageSetup> list_0 = new List<PageSetup>();
    private ToPdfParameterList toPdfParameterList_0;

    private List<PageSetup> method_0()
    {
        return this.list_0;
    }

    private ToPdfParameterList method_1()
    {
        int num = 3;
        if (this.toPdfParameterList_0 == null)
        {
            this.toPdfParameterList_0 = new ToPdfParameterList();
            this.toPdfParameterList_0.EmbeddedFontNameList.Add(BookmarkStart.b("栨太䐬丮崰ጲ笴嘶䬸䤺刼䠾", num));
        }
        if (this.toPdfParameterList_0.WordBookmarksTitle == null)
        {
            this.toPdfParameterList_0.WordBookmarksTitle = string.Empty;
        }
        return this.toPdfParameterList_0;
    }

    internal Queue<byte[]> method_2(Document A_0, ToPdfParameterList A_1)
    {
        this.toPdfParameterList_0 = A_1;
        this.toPdfParameterList_0.EmbeddedFontNameList.Add(BookmarkStart.b("昦嬨䈪䰬䌮ᄰ紲吴䔶䬸吺䨼", 1));
        using (Class195 class2 = new Class195())
        {
            A_0.OperationType = DocumentOperationType.Layout;
            class2.method_2(this.method_1().UsePSCoversion);
            class2.method_20(this.method_1());
            class2.method_43(A_0);
            A_0.OperationType = DocumentOperationType.None;
            return this.method_4(class2);
        }
    }

    private void method_3(Class195 A_0)
    {
        for (int i = 0; i < A_0.method_0().Count; i++)
        {
            Class500 class2 = A_0.method_0()[i];
            this.method_0().Add(class2.method_28());
        }
    }

    private Queue<byte[]> method_4(Class195 A_0)
    {
        this.method_3(A_0);
        int count = A_0.method_0().Count;
        int num3 = (count > 90) ? 3 : ((count > 60) ? 5 : ((count > 30) ? 10 : count));
        Queue<byte[]> queue = new Queue<byte[]>();
        for (int i = 0; i < count; i++)
        {
            spr⠃ r⠃ = A_0.method_63(i, 1)[i];
            byte[] bytes = Encoding.UTF8.GetBytes(this.method_5(ref r⠃, false));
            queue.Enqueue(bytes);
            if ((i % num3) == 0)
            {
                GC.Collect();
            }
        }
        A_0.method_51();
        return queue;
    }

    private string method_5(ref spr⠃ A_0, bool A_1)
    {
        spr៵ r៵ = new spr៵();
        return r៵.ᜀ(ref A_0, A_1);
    }

    private spr⠃ method_6(int A_0)
    {
        int num = 1;
        PageSetup setup = this.method_0()[A_0];
        using (Class307 class2 = new Class307(setup.PageSize, true))
        {
            class2.method_13(BookmarkStart.b("琦夨䈪弬䨮ᄰ眲娴吶᜸", num), new Font(BookmarkStart.b("猦䀨䘪䠬尮ᄰ紲倴䀶ᤸ椺刼刾⁀ⵂ", num), 16f, FontStyle.Bold), Color.Red, 10f, 10f, null);
            class2.method_13(BookmarkStart.b("愦嬨个䠬༮䜰嘲䜴䐶倸吺匼Ἶ≀ⱂ⭄ㅆⱈ㥊㥌♎㽐㑒畔⁖㙘⥚㥜罞ՠౢ٤ቦѨ๪ͬ᭮ɰ卲Ŵᡶ奸⡺⭼㡾ꆀꆌ꾎ﲒ랖滛漢뾞캠춢즤\udea6\u89a8첪좬\udbae\u91b0잲\uddb4\ud2b6馸\uddba\ud4bc춾닀럂믊곌꣎듐뫔뇖律裚诜飞쇠藢賤详賨엪", num), new Font(BookmarkStart.b("猦䀨䘪䠬尮ᄰ紲倴䀶ᤸ椺刼刾⁀ⵂ", num), 10f), Color.Red, 10f, 30f, null);
            class2.method_13(BookmarkStart.b("爦夨䰪弬丮唰嘲ᔴ䌶嘸ᬺ縼倾ⱀ⹂⁄㕆⩈≊ⱌ⍎煐ᙒㅔ㹖ⵘ㉚㉜ㅞ䅠ౢͤ䝦㩨᭪Ѭᵮᑰ嵲ㅴᡶ᩸孺䅼᝾붆Ꚉꒊ戴붒몖ﶞ춠횢삤覦쪨쒪사肮\uddb2\uc1b4얶횸\udfba\uc8bc\udcbe\ua4c0닄꣆믈꿊꧎뻐ꇒ맖볘꿚뛞迠韢韤裦跨黪軬諮\udff0\u9bf2致髶闸엺폼", num), new Font(BookmarkStart.b("猦䀨䘪䠬尮ᄰ紲倴䀶ᤸ椺刼刾⁀ⵂ", num), 10f), Color.Red, 10f, 42f, null);
            return (spr⠃) (class2.method_0().᜔() as sprḀ).ᜀ()[0];
        }
    }

    void Component.Dispose(bool A_0)
    {
        base.Dispose(A_0);
        if (this.list_0 != null)
        {
            this.list_0.Clear();
            this.list_0 = null;
        }
        this.toPdfParameterList_0 = null;
    }
}

