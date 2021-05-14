namespace ListControls
{
    public class TodoItem
    {
        public TodoItem(string title, int completion)
        {
            this.Title = title;
            this.Completion = completion;
        }

        public string Title { get; set; }
        public int Completion { get; set; }
    }
}
