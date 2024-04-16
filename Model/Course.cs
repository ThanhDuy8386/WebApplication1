namespace WebApplication1.Model
{
    public class Course
    {
        private int teacherId;
        private string teacherId1;

        public string Id { get; set; }
        public string Name { get; set; }
        public string TeacherId { get; set; }
        
        
        public Course(string Id, 
            string Name, 
            string TeacherId) {
            this.Id = Id;
            this.Name = Name;
            this.TeacherId = TeacherId;
        }
    }
}
