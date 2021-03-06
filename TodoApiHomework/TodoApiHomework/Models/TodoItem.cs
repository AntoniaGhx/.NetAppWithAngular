namespace TodoApiHomework.Models
{
    public class TodoItem
    {
        public long Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Date { get; set; }
        public string? Hours { get; set; }
        public bool IsComplete { get; set; }
    }
}
