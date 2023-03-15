using LearningRessourcesAPI.Adapters;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Reflection.PortableExecutable;
using static LearningRessourcesAPI.Models.LearningResourcesModels;

namespace LearningRessourcesAPI.Controllers;

    public class LearningResourcesController : ControllerBase
    {
    private readonly LearningResourcesDataContex _context;

    public LearningResourcesController(LearningResourcesDataContex context)
    {
        _context = context;
    }

        [HttpGet("/learning-resources")]
        public async Task<ActionResult> GetLearningResources()
        {
        var data = await _context.LearningResources
        .Where(item => item.WhenRemoved == null)
        .Select(item => new LearningResourceSummaryItem(
        item.Id.ToString(), item.Name, item.Description, item.Link))
        .ToListAsync(); var response = new LearningResourcesResponse(data);
        return Ok(response);
    }
    }