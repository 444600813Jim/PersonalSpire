namespace Spire.Doc
{
    using Spire.Doc.Core.DataStreamParser.Escher;
    using Spire.Doc.Documents;
    using Spire.Doc.Fields.Shape;
    using System;
    using System.Drawing;

    public class BackgroundGradient : VMLFill
    {
        private BackgroundFillType backgroundFillType_0;
        private Color color_0;
        private Color color_1;
        private float[] float_2;
        private float float_3;
        private GradientShadingStyle gradientShadingStyle_0;
        private GradientShadingVariant gradientShadingVariant_0;
        internal const uint uint_0 = 0xffa60000;
        internal const uint uint_1 = 0xff790000;
        internal const uint uint_2 = 0xffd30000;
        internal const uint uint_3 = 100;
        internal const uint uint_4 = 0xffffffce;
        internal const uint uint_5 = 50;

        internal BackgroundGradient() : base(new ShapeObject(null))
        {
            this.color_0 = Color.White;
            this.color_1 = Color.White;
            this.color_0 = Color.White;
            this.color_1 = Color.Black;
        }

        internal BackgroundGradient(Interface0 A_0) : base(A_0)
        {
            this.color_0 = Color.White;
            this.color_1 = Color.White;
        }

        public Color Color1
        {
            get
            {
                return base.Color;
            }
            set
            {
                base.Color = value;
            }
        }

        public Color Color2
        {
            get
            {
                return base.Color2;
            }
            set
            {
                base.Color2 = value;
            }
        }

        public GradientShadingStyle ShadingStyle
        {
            get
            {
                if (base.FillType == FillType.ShadeShape)
                {
                    return GradientShadingStyle.FromCenter;
                }
                if (base.FillType == FillType.ShadeCenter)
                {
                    return GradientShadingStyle.FromCorner;
                }
                if (base.Angle == -45.0)
                {
                    return GradientShadingStyle.DiagonalDown;
                }
                if (base.Angle == -90.0)
                {
                    return GradientShadingStyle.Vertical;
                }
                if (base.Angle == -135.0)
                {
                    return GradientShadingStyle.DiagonalUp;
                }
                return GradientShadingStyle.Horizontal;
            }
            set
            {
                switch (value)
                {
                    case GradientShadingStyle.Horizontal:
                        base.Angle = 0.0;
                        return;

                    case GradientShadingStyle.Vertical:
                        base.Angle = -95.0;
                        return;

                    case GradientShadingStyle.DiagonalUp:
                        base.Angle = -135.0;
                        return;

                    case GradientShadingStyle.DiagonalDown:
                        base.Angle = -45.0;
                        return;

                    case GradientShadingStyle.FromCorner:
                        base.FillType = FillType.ShadeCenter;
                        base.Angle = -45.0;
                        switch (this.ShadingVariant)
                        {
                            case GradientShadingVariant.ShadingDown:
                                base.FocusLeft = 1.0;
                                goto Label_00D6;

                            case GradientShadingVariant.ShadingOut:
                                base.FocusLeft = 1.0;
                                base.FocusTop = 1.0;
                                goto Label_00D6;

                            case GradientShadingVariant.ShadingMiddle:
                                base.FocusTop = 1.0;
                                goto Label_00D6;
                        }
                        break;

                    case GradientShadingStyle.FromCenter:
                        base.FillType = FillType.ShadeShape;
                        base.Angle = -45.0;
                        base.FocusLeft = 0.5;
                        base.FocusTop = 0.5;
                        if (this.ShadingVariant == GradientShadingVariant.ShadingDown)
                        {
                            base.Focus = 0;
                        }
                        return;

                    default:
                        return;
                }
            Label_00D6:
                base.Focus = 100;
            }
        }

        public GradientShadingVariant ShadingVariant
        {
            get
            {
                int focus = base.Focus;
                switch (focus)
                {
                    case -50:
                        return GradientShadingVariant.ShadingOut;

                    case 50:
                        return GradientShadingVariant.ShadingMiddle;
                }
                if (focus != 100)
                {
                    return GradientShadingVariant.ShadingDown;
                }
                return GradientShadingVariant.ShadingUp;
            }
            set
            {
                switch (value)
                {
                    case GradientShadingVariant.ShadingUp:
                        base.Focus = 100;
                        if (base.FillType != FillType.ShadeCenter)
                        {
                            break;
                        }
                        base.Parent.imethod_4(0x18d);
                        base.Parent.imethod_4(0x18e);
                        return;

                    case GradientShadingVariant.ShadingDown:
                        base.Focus = 0;
                        if (base.FillType != FillType.ShadeCenter)
                        {
                            break;
                        }
                        base.FocusLeft = 1.0;
                        base.Parent.imethod_4(0x18e);
                        return;

                    case GradientShadingVariant.ShadingOut:
                        if (base.FillType == FillType.ShadeShape)
                        {
                            break;
                        }
                        base.Focus = -50;
                        if (base.FillType != FillType.ShadeCenter)
                        {
                            break;
                        }
                        base.FocusLeft = 1.0;
                        base.FocusTop = 1.0;
                        return;

                    case GradientShadingVariant.ShadingMiddle:
                        if (base.FillType != FillType.ShadeShape)
                        {
                            base.Focus = 50;
                            if (base.FillType == FillType.ShadeCenter)
                            {
                                base.FocusTop = 1.0;
                                base.Parent.imethod_4(0x18d);
                            }
                        }
                        break;

                    default:
                        return;
                }
            }
        }
    }
}

