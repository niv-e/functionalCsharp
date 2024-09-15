using Models.Types.Media;

namespace Models.Media;

public static class StringEnconding
{
    public static StringEncodedFile EncodeBase64(this FileContent file) =>
        new(file.MineType + ";base64" + Convert.ToBase64String(file.Content));
}