using LearningRessourcesAPI.Domain;
using Microsoft.EntityFrameworkCore;

namespace LearningRessourcesAPI.Adapters
{
    public class LearningResourcesDataContex : DbContext

    {
        public LearningResourcesDataContex(DbContextOptions<LearningResourcesDataContex> options) : base(options)
        {
        }
        public DbSet<LearningResourcesEntity> LearningResources { get; set; }
    }
}