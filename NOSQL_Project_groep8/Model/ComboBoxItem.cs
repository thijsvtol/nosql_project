namespace NOSQL_Project_groep8.Model
{
    public class ComboboxItem
    {
        public string Text { get; set; }
        public int Value { get; set; }
        public string Type { get; set; }
        public override string ToString()
        {
            return Text;
        }
    }
}
