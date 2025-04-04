using OneOf.Types;
using OneOf;
using ValueOf;

public class Pixel : ValueOf<int, Pixel>;

public class Percentage : ValueOf<decimal, Percentage>;

/// <summary>
///     Hash - Required for private Vimeo videos. See https://www.drupal.org/project/video_embed_field/issues/3238136
/// </summary>
public record Vimeo(string VideoId, OneOf<string, None> Hash);