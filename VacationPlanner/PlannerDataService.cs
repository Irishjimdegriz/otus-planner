using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VacationPlanner.Entity.Model;

namespace VacationPlanner.DAL
{
    public class PlannerDataService
    {
        private ApplicationContext _context;
        public PlannerDataService(ApplicationContext context)
        {
            _context = context;
        }

        public List<User> GetUsers()
        {
            return _context.User.ToList();
        }

        public async Task<User> SaveUser(User user)
        {
            try
            {
                await _context.User.AddAsync(user);
                _context.SaveChanges();
            }
            catch (Exception)
            {
                return null;
            }

            return user;
        }

        public List<Position> GetPositions()
        {
            return _context.Positions.ToList();
        }

        public async Task<Position> SavePosition(Position position)
        {
            try
            {
                await _context.Positions.AddAsync(position);
                _context.SaveChanges();
            }
            catch (Exception)
            {
                return null;
            }

            return position;
        }

        public List<Department> GetDepartments()
        {
            return _context.Departments.ToList();
        }

        public async Task<Department> SaveDepartment(Department department)
        {
            try
            {
                await _context.Departments.AddAsync(department);
                _context.SaveChanges();
            }
            catch (Exception)
            {
                return null;
            }

            return department;
        }
    }
}
