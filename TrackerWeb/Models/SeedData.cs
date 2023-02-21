using System;
using Microsoft.EntityFrameworkCore;
using TrackerWeb.Data;
namespace TrackerWeb.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new TrackerWebContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<TrackerWebContext>>()))
        {
            if (context == null || context.Issue == null)
            {
                throw new ArgumentNullException("Null TrackerWebContext");
            }

            // Look for any issues.
            //if (context.Issue.Any())
            //{
            //    context.Issue.AddRange(
            //        new Issue
            //        {

            //            Title = "Bug in production",
            //            Description = "A fatal bug in the landing page",
            //            IssueType = IssueType.Bug,
            //            Priority = Priority.High,

            //        },



            //         new Issue
            //         {

            //             Title = "Add new images",
            //             Description = "Images descriping the product",
            //             IssueType = IssueType.Feature,
            //             Priority = Priority.High,

            //         }
            //    );
            //    context.SaveChanges();
            //}
        }
    }
}
