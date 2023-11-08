namespace Atelje_Konstram.Utility
{
    public class LabeledCollection
    {
        public string Name { get; set; }
        public List<dynamic> Collection { get; } = new();

        public LabeledCollection(string name)
        {
            Name = name;
        }

        public void Add(dynamic item)
        {
            Collection.Add(item);
        }
    }
}
