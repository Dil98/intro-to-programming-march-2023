using LearningRessourcesAPI.Controllers;

namespace LearningRessourcesAPI.Models
{
    public class LearningResourcesModels
    {
        public record LearningResourceSummaryItem(
        string Id, string Name, string Description, string Link);
        public record LearningResourcesResponse(List<LearningResourcesController>Data);
    }
}
