using Spire.Doc;
using System;
using System.Diagnostics;

internal class Class1135
{
    private static bool bool_0;
    private static bool bool_1;

    private Class1135()
    {
    }

    [DebuggerStepThrough]
    public static int smethod_0()
    {
        return Debug.IndentLevel;
    }

    [DebuggerStepThrough]
    public static void smethod_1(int A_0)
    {
        Debug.IndentLevel = A_0;
    }

    [Conditional("DEBUG"), DebuggerStepThrough, Conditional("TEST")]
    public static void smethod_10()
    {
    }

    [DebuggerStepThrough, Conditional("DEBUG"), Conditional("TEST")]
    public static void smethod_11(bool A_0)
    {
    }

    [Conditional("TEST"), DebuggerStepThrough, Conditional("DEBUG")]
    public static void smethod_12(bool A_0, string A_1)
    {
    }

    [Conditional("TEST"), Conditional("DEBUG"), DebuggerStepThrough]
    public static void smethod_13(bool A_0, string A_1, string A_2)
    {
        if (!A_0)
        {
            if (bool_0)
            {
                Debugger.Break();
            }
            else if (bool_1)
            {
                throw new InvalidOperationException(new StackTrace(0, true).ToString());
            }
        }
    }

    [Conditional("TEST"), DebuggerStepThrough, Conditional("DEBUG")]
    public static void smethod_14(string A_0)
    {
    }

    [DebuggerStepThrough, Conditional("TEST"), Conditional("DEBUG")]
    public static void smethod_15(string A_0, string A_1)
    {
    }

    [DebuggerStepThrough, Conditional("DEBUG"), Conditional("TEST")]
    public static void smethod_16(string A_0)
    {
    }

    [DebuggerStepThrough, Conditional("TEST"), Conditional("DEBUG")]
    public static void smethod_17(object A_0)
    {
    }

    [DebuggerStepThrough, Conditional("DEBUG"), Conditional("TEST")]
    public static void smethod_18(string A_0, string A_1)
    {
    }

    [DebuggerStepThrough, Conditional("TEST"), Conditional("DEBUG")]
    public static void smethod_19(object A_0, string A_1)
    {
    }

    [DebuggerStepThrough]
    public static int smethod_2()
    {
        return Debug.IndentSize;
    }

    [DebuggerStepThrough, Conditional("TEST"), Conditional("DEBUG")]
    public static void smethod_20(bool A_0, string A_1)
    {
    }

    [Conditional("DEBUG"), Conditional("TEST"), DebuggerStepThrough]
    public static void smethod_21(bool A_0, object A_1)
    {
    }

    [Conditional("TEST"), Conditional("DEBUG"), DebuggerStepThrough]
    public static void smethod_22(bool A_0, string A_1, string A_2)
    {
    }

    [Conditional("DEBUG"), Conditional("TEST"), DebuggerStepThrough]
    public static void smethod_23(bool A_0, object A_1, string A_2)
    {
    }

    [DebuggerStepThrough, Conditional("TEST"), Conditional("DEBUG")]
    public static void smethod_24(string A_0)
    {
    }

    [DebuggerStepThrough, Conditional("TEST"), Conditional("DEBUG")]
    public static void smethod_25(object A_0)
    {
    }

    [Conditional("TEST"), Conditional("DEBUG"), DebuggerStepThrough]
    public static void smethod_26(string A_0, string A_1)
    {
    }

    [Conditional("DEBUG"), Conditional("TEST"), DebuggerStepThrough]
    public static void smethod_27(object A_0, string A_1)
    {
    }

    [Conditional("DEBUG"), DebuggerStepThrough, Conditional("TEST")]
    public static void smethod_28(bool A_0, string A_1)
    {
    }

    [Conditional("DEBUG"), DebuggerStepThrough, Conditional("TEST")]
    public static void smethod_29(bool A_0, object A_1)
    {
    }

    [DebuggerStepThrough]
    public static void smethod_3(int A_0)
    {
        Debug.IndentSize = A_0;
    }

    [DebuggerStepThrough, Conditional("DEBUG"), Conditional("TEST")]
    public static void smethod_30(bool A_0, string A_1, string A_2)
    {
    }

    [Conditional("TEST"), Conditional("DEBUG"), DebuggerStepThrough]
    public static void smethod_31(bool A_0, object A_1, string A_2)
    {
    }

    [Conditional("DEBUG"), Conditional("TEST"), DebuggerStepThrough]
    public static void smethod_32()
    {
    }

    [Conditional("TEST"), DebuggerStepThrough, Conditional("DEBUG")]
    public static void smethod_33()
    {
    }

    [DebuggerStepThrough, Conditional("TEST"), Conditional("DEBUG")]
    public static void smethod_34()
    {
    }

    [Conditional("TEST"), Conditional("DEBUG"), DebuggerStepThrough]
    public static void smethod_35()
    {
    }

    [Conditional("DEBUG"), DebuggerStepThrough, Conditional("TEST")]
    public static void smethod_36()
    {
        Debugger.Break();
    }

    [Conditional("DEBUG"), Conditional("TEST"), DebuggerStepThrough]
    public static void smethod_37(Type A_0)
    {
    }

    [DebuggerStepThrough]
    public static TraceListenerCollection smethod_4()
    {
        return Debug.Listeners;
    }

    [DebuggerStepThrough]
    public static bool smethod_5()
    {
        return Debug.AutoFlush;
    }

    [DebuggerStepThrough]
    public static void smethod_6(bool A_0)
    {
        Debug.AutoFlush = A_0;
    }

    [Conditional("DEBUG"), DebuggerStepThrough, Conditional("TEST")]
    public static void smethod_7(bool A_0)
    {
        DefaultTraceListener listener = smethod_4()[BookmarkStart.b("猶尸崺尼䨾ⵀ㝂", 0x11)] as DefaultTraceListener;
        if (listener != null)
        {
            listener.AssertUiEnabled = A_0;
        }
    }

    [Conditional("DEBUG"), DebuggerStepThrough, Conditional("TEST")]
    public static void smethod_8(bool A_0)
    {
        bool_0 = A_0;
    }

    [DebuggerStepThrough, Conditional("TEST"), Conditional("DEBUG")]
    public static void smethod_9(bool A_0)
    {
        bool_1 = A_0;
    }
}

