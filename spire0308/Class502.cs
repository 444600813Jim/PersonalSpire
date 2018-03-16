using System;
using System.Collections;

internal abstract class Class502 : spr᥋
{
    private readonly ArrayList arrayList_0 = new ArrayList();
    private Class505 class505_0;

    protected Class502()
    {
    }

    protected void method_0(spr➓ A_0)
    {
        A_0.ᜀ(this);
    }

    public override void vmethod_0(spr➓ A_0)
    {
        Class505 class2 = new Class505(A_0, this.vmethod_4());
        this.arrayList_0.Add(class2);
        this.class505_0 = class2;
    }

    public override void vmethod_1(spr➓ A_0)
    {
        this.class505_0.method_1(this.vmethod_5());
        int count = this.arrayList_0.Count;
        this.arrayList_0.RemoveAt(count - 1);
        if ((count - 1) > 0)
        {
            this.class505_0 = (Class505) this.arrayList_0[count - 2];
        }
    }

    public override void vmethod_2(sprᲆ A_0)
    {
        sprᲆ[] rᲆArray = this.vmethod_3(A_0);
        this.class505_0.method_0(A_0, rᲆArray);
    }

    protected abstract sprᲆ[] vmethod_3(sprᲆ A_0);
    protected virtual int vmethod_4()
    {
        return 1;
    }

    protected virtual bool vmethod_5()
    {
        return false;
    }
}

