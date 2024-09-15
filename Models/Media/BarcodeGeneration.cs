using Models.Common;
using Models.Types.Components;
using Models.Types.Media;
using SkiaSharp;

namespace Models.Media;
 public static class BarcodeGeneration
{
    //Code39 is type of barcode format
    public static FileContent ToCode39(this StockKeepingUnit sku, int barHeight) =>
        sku.Value.ToCode39Bars().ToCode39Bitmap(barHeight).ToPng();

    private static SKBitmap ToCode39Bitmap(this IEnumerable<int> bars, int barHeight) =>
        new(10,10);
}
