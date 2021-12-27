using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VacationPlanner.DAL;
using VacationPlanner.Data.Models;
using VacationPlanner.Entity.Model;

namespace VacationPlanner.Data
{
    public class PlannerService
    {
        private PlannerDataService service;

        public PlannerService(ApplicationContext context)
        {
            service = new PlannerDataService(context);
        }

        public Task<List<UserModel>> GetUsersAsync()
        {
            return Task.FromResult(service.GetUsers().Select(x => new UserModel(x)).ToList());
        }

        public async Task<UserModel> SaveUserAsync(UserModel user)
        {
            return new UserModel(await service.SaveUser(user.ConvertToDbModel()));
        }

        public Task<List<DepartmentModel>> GetDepartmentsAsync()
        {
            return Task.FromResult(service.GetDepartments().Select(x => new DepartmentModel(x)).ToList());
        }
        public async Task<DepartmentModel> SaveDepartmentAsync(DepartmentModel department)
        {
            return new DepartmentModel(await service.SaveDepartment(department.ConvertToDbModel()));
        }

        public Task<List<PositionModel>> GetPositionsAsync()
        {
            return Task.FromResult(service.GetPositions().Select(x => new PositionModel(x)).ToList());
        }
        public async Task<PositionModel> SavePositionAsync(PositionModel position)
        {
            return new PositionModel(await service.SavePosition(position.ConvertToDbModel()));
        }
    }
}
