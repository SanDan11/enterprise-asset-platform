
namespace EnterpriseAssetPlatform.Domain.Entities;


public class Site
{
    public Guid Id { get; private set; }
    public Guid OrganizationId { get; private set; }

    public string Name { get; private set; }
    public string Address { get; private set; }

    public DateTime CreatedAtUtc { get; private set; }

    private Site() { }

    public Site(Guid organizedId, string name, string address) 
    {
        if (organizedId == Guid.Empty)
            throw new ArgumentException("Organization ID cannot be empty.", nameof(organizedId));

        if (string.IsNullOrWhiteSpace(name))
            throw new ArgumentException("Site name cannot be null or empty.", nameof(name));

        Id = Guid.NewGuid();
        OrganizationId = organizedId;
        Name = name;
        Address = address;
        CreatedAtUtc = DateTime.UtcNow;

    }

}
