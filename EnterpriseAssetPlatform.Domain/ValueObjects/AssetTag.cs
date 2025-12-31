
namespace EnterpriseAssetPlatform.Domain.ValueObjects;

public sealed class AssetTag
{
    public string Value { get; }

    private AssetTag(string value)
    {
        Value = value;
    }

    public static AssetTag Create(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
            throw new ArgumentException("Asset tag cannot be null or empty.", nameof(value));

        if (value.Length > 50)
            throw new ArgumentException("Asset tag cannot exceed 50 characters.", nameof(value));

        return new AssetTag(value.Trim().ToLowerInvariant());
    }


}
