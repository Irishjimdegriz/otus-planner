using VacationPlanner.Entity.Model;

namespace VacationPlanner.Data.Models
{
    public class PositionModel
    {
        public long PositionId { get; set; }
        public string Name { get; set; }

        public PositionModel() { }

        public PositionModel(Position position)
        {
            PositionId = position.Id;
            Name = position.Name;

        }

        public Position ConvertToDbModel()
        {
            return new Position()
            {
                Id = this.PositionId,
                Name = this.Name
            };
        }
    }
}
