namespace WebApplication1.Model
{
    public class Teacher
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public DateTime? Dob { get; set; }
        public string? Address { get; set; }
        public string? LastName { get; set; }
        public Teacher(
            string Id,
            string Name,
            DateTime? Dob,
            string? Address,
            string? LastName)
        {
            this.Id = Id;
            this.Name = Name;
            this.Dob = Dob;
            this.Address = Address;
            this.LastName = LastName;
        }
    }
}
