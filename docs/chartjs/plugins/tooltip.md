## Enabled
Are on-canvas tooltips enabled? default true
```csharp
.Enabled(true)
```

## External
External function name.
```csharp
.External("example")
```

## Mode
Sets which elements appear in the tooltip.
```csharp
.Mode(default)
```

## Mode
Sets which elements appear in the tooltip. 'Custom mode'
```csharp
.Mode("example")
```

## Intersect
If true, the tooltip mode applies only when the mouse position intersects with an element. 
            If false, the mode will be applied at all times.
```csharp
.Intersect(true)
```

## Position
The mode for positioning the tooltip. default 'average'
```csharp
.Position(default)
```

## Position
The mode for positioning the tooltip. 'Custom position'
```csharp
.Position("example")
```

## Callbacks

```csharp
.Callbacks(default)
```

## ItemSort
Sort tooltip items.
```csharp
.ItemSort("example")
```

## Filter
Filter tooltip items.
```csharp
.Filter("example")
```

## BackgroundColor
Background color of the tooltip.
```csharp
.BackgroundColor("example")
```

## TitleColor
Color of title text. default '#fff'
```csharp
.TitleColor("example")
```

## TitleFont

```csharp
.TitleFont(default)
```

## TitleAlign
Horizontal alignment of the title text lines. default 'left'
```csharp
.TitleAlign(default)
```

## TitleSpacing
Spacing to add to top and bottom of each title line. default 2
```csharp
.TitleSpacing(15)
```

## TitleMarginBottom
Margin to add on bottom of title section. default 6
```csharp
.TitleMarginBottom(15)
```

## BodyColor
Color of body text. defautl '#fff'
```csharp
.BodyColor("example")
```

## BodyFont

```csharp
.BodyFont(default)
```

## BodyAlign
Horizontal alignment of the body text lines. default 'left'
```csharp
.BodyAlign(default)
```

## BodySpacing
Spacing to add to top and bottom of each tooltip item. default 2
```csharp
.BodySpacing(15)
```

## FooterColor
Color of footer text. default '#fff'
```csharp
.FooterColor("example")
```

## FooterFont

```csharp
.FooterFont(default)
```

## FooterAlign
Horizontal alignment of the footer text lines. defautl 'left'
```csharp
.FooterAlign(default)
```

## FooterSpacing
Spacing to add to top and bottom of each footer line. default 2
```csharp
.FooterSpacing(15)
```

## FooterMarginTop
Margin to add before drawing the footer. default 6
```csharp
.FooterMarginTop(15)
```

## Padding
Padding inside the tooltip. default 6
```csharp
.Padding(15)
```

## Padding

```csharp
.Padding(default)
```

## CaretPadding
Extra distance to move the end of the tooltip arrow away from the tooltip point. default 2
```csharp
.CaretPadding(15)
```

## CaretSize
Size, in px, of the tooltip arrow. default 5
```csharp
.CaretSize(15)
```

## CornerRadius
Radius of tooltip corner curves. default 6
```csharp
.CornerRadius(15)
```

## MultiKeyBackground
Color to draw behind the colored boxes when multiple items are in the tooltip. default '#fff'
```csharp
.MultiKeyBackground("example")
```

## DisplayColors
If true, color boxes are shown in the tooltip. default true
```csharp
.DisplayColors(true)
```

## BoxWidth
Width of the color box if displayColors is true.
```csharp
.BoxWidth(15)
```

## BoxHeight
Height of the color box if displayColors is true.
```csharp
.BoxHeight(15)
```

## BoxPadding
Padding between the color box and the text. default 1
```csharp
.BoxPadding(15)
```

## UsePointStyle
Use the corresponding point style (from dataset options) instead of color boxes, ex: star, triangle etc.
            (size is based on the minimum value between boxWidth and boxHeight). default false
```csharp
.UsePointStyle(true)
```

## BorderColor
Color of the border.
```csharp
.BorderColor("example")
```

## BorderWidth
Size of the border. default 0
```csharp
.BorderWidth(15)
```

## Rtl
true for rendering the tooltip from right to left.
```csharp
.Rtl(true)
```

## TextDirection
This will force the text direction 'rtl' or 'ltr' on the canvas for rendering the tooltips, 
            regardless of the css specified on the canvas.
```csharp
.TextDirection("example")
```

## XAlign
Position of the tooltip caret in the X direction.
```csharp
.XAlign("example")
```

## YAlign
Position of the tooltip caret in the Y direction.
```csharp
.YAlign("example")
```

