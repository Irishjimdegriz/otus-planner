using VacationPlanner.Entity.Model;

namespace VacationPlanner.Data.Models
{
    public class DepartmentModel
    {
        public long DepartmentId { get; set; }
        public string Name { get; set; }

        public DepartmentModel() { }

        public DepartmentModel(Department department)
        {
            DepartmentId = department.Id;
            Name = department.Name;

        }

        public Department ConvertToDbModel()
        {
            return new Department() {
                Id = this.DepartmentId,
                Name = this.Name
            };
        }
    }
}
