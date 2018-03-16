using Spire.Doc;
using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

internal class Class314
{
    [DllImport("user32.dll", CharSet=CharSet.Auto)]
    public static extern long GetGuiResources(IntPtr A_0, long A_1);
    public static string smethod_0()
    {
        Process currentProcess = Process.GetCurrentProcess();
        long handleCount = currentProcess.HandleCount;
        long num2 = currentProcess.PrivateMemorySize64;
        long num3 = currentProcess.VirtualMemorySize64;
        long num4 = currentProcess.WorkingSet64;
        long totalMemory = GC.GetTotalMemory(false);
        int guiResources = (int) GetGuiResources(currentProcess.Handle, 0L);
        int num7 = (int) GetGuiResources(currentProcess.Handle, 1L);
        return string.Format(BookmarkStart.b("漦䠨䔪䤬䌮吰ጲ嘴堶䰸唺䤼Ծ㩀獂罄ॆ祈㙊慌὎⍐㩒⍔㙖ⵘ㹚絜ᵞᡠᝢdᑦ卨ၪ屬啮㽰䍲ࡴ㱶啸孺⭼ᙾꮊ쾌궖ꦚꞜ톞醠\udea2\ueea4讦覨ﲪ슬\uddae\udab0\udab2\udbb4킶馸\ud8bc\ucbbe﯀룂ﷆ蟈﯊냌蓎﷐鋔铖律鏚룜뻞釠쏢뛤軦鏨軪ퟬ铮연짲믴쟶蓸냺퇼\udffe\u4600䜂䰄✆䘈椊朌樎爐朒昔ⴖ战⸚✜儞ᄠ帢तܦ簨堪䠬崮ᄰ簲圴崶尸堺䤼䰾筀㡂獄絆݈筊が", 1), new object[] { handleCount, num2 >> 10, num3 >> 10, num4 >> 10, totalMemory >> 10, guiResources, num7 });
    }
}

