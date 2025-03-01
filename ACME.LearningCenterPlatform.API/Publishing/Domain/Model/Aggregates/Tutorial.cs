using ACME.LearningCenterPlatform.API.Publishing.Domain.Model.Entities;

namespace ACME.LearningCenterPlatform.API.Publishing.Domain.Model.Aggregates;

public partial class Tutorial
{
    public Tutorial(string title, string summary, int categoryId) : this()
    {
        Title = title;
        Summary = summary;
        CategoryId = categoryId;
    }

    public int Id { get; }
    public string Title { get; private set; }

    public string Summary { get; private set; }

    public Category Category { get; }
    public int CategoryId { get; private set; }    
}