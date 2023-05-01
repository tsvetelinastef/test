using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PearReview.Areas.Courses.Pages;
using PearReview.Data;
using PearReview.Models;

namespace PearReview.Services
{
    public class AssignmentsService
    {
        private readonly ApplicationDbContext _dbContext;

        public AssignmentsService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Assignment>> GetAssignmentsForCourseAsync(int courseId)
        {
            return await _dbContext.Assignments.Where(a => a.CourseId == courseId).ToListAsync();
        }
    }
}
