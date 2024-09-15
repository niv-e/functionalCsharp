using Models.Types.Media;
using SkiaSharp;

namespace Models.Media;

public static class ImageEncoding
{
    internal static FileContent ToPng(this SKBitmap bitmap) => new([], string.Empty);
}
