namespace EnterpriseAssetPlatform.Domain.Entities;

public class Organization
{
    public Guid Id { get; private set; }
    public string Name { get; private set; }
    public DateTime CreateAtUtc { get; private set; }

    private Organization() { }

    public Organization(string name)
    {
        if (string.IsNullOrWhiteSpace(name))
            throw new ArgumentException("Organization name cannot be null or empty.", nameof(name));

        Id = Guid.NewGuid();
        Name = name;
        CreateAtUtc = DateTime.UtcNow;
    }
}