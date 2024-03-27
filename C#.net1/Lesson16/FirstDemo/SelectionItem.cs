namespace FirstDemo
{
    public class SelectionItem
    {
        public int Value { get; set; }
        public string DisplayName { get; set; }
        public SelectionItem(int value , string displayName) 
        {
            Value = value;
            DisplayName = displayName;
        }
    }
}
