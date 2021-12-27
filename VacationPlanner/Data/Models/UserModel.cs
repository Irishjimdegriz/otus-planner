using System;
using VacationPlanner.Entity.Model;

namespace VacationPlanner.Data.Models
{
    public class UserModel
    {
        public long UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }
        public long DepartmentId { get; set; }
        public long ChiefId { get; set; }
        public long PositionId { get; set; }

        public UserModel() { }

        public UserModel(User user)
        {
            UserId = user.Id;
            FirstName = user.FirstName;
            LastName = user.LastName;
            MiddleName = user.MiddleName;
            Email = user.Email;
            Password = user.Password;
            Phone = user.Phone;
            DateStart = user.DateStart;
            DateEnd = user.DateEnd;
            ChiefId = user.ChiefId;
            DepartmentId = user.DepartmentId;
            PositionId = user.PositionId;
        }

        public User ConvertToDbModel()
        {
            return new User() {
                Id = this.UserId, 
                FirstName = this.FirstName,
                LastName = this.LastName, 
                MiddleName = this.MiddleName,
                Email = this.Email, 
                Password = this.Password, 
                Phone = this.Phone,
                DateStart = this.DateStart, 
                DateEnd = this.DateEnd, 
                ChiefId = this.ChiefId, 
                DepartmentId = this.DepartmentId, 
                PositionId = this.PositionId
            };
        }
    }
}
