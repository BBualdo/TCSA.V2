namespace TCSA.V2.Models.DTO;

public class RoadmapSummaryItem
{
    public string Title { get; set; }
    public bool Status { get; set; }
    public RoadmapSummaryItemType Type { get; set; }
}

public enum RoadmapSummaryItemType
{
    Article,
    Project,
    CodeReview,
    CommunityProject
}