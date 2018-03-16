using System;

internal class Class727
{
    internal static sprⓚ smethod_0(sprⓚ A_0, sprⓚ A_1)
    {
        if ((A_0.ᜁ() == 0xef) && (A_0.ᜃ() == 240))
        {
            sprⓚ rⓚ = A_1;
            switch (A_0.ᜇ())
            {
                case 1:
                {
                    double num4 = A_0.ᜄ();
                    num4 = (255.0 - num4) / 255.0;
                    spr᭵ r᭵ = new spr᭵(rⓚ);
                    r᭵.ᜀ((float) spr⃘.ᜂ(spr⃘.ᜁ(r᭵.ᜃ() - (r᭵.ᜃ() * num4), 0.0, 255.0)));
                    A_0 = r᭵.ᜂ();
                    return A_0;
                }
                case 2:
                {
                    double num2 = A_0.ᜄ();
                    num2 = (255.0 - num2) / 255.0;
                    Class508 class2 = new Class508(rⓚ.ᜉ());
                    class2.method_7(class2.method_6() + ((1.0 - class2.method_6()) * num2));
                    A_0 = class2.method_0();
                    return A_0;
                }
            }
            A_0 = rⓚ;
        }
        return A_0;
    }
}

