namespace Assignment11
{
    public class ListManager<T>
    {
        public List<T> List { get; set; }

        public void Add(T item)
        {
            List.Add(item);
        }

        public void Remove(T item)
        {
            List.Remove(item);
        }

        public void Display()
        {
            foreach (T item in List)
            {
                Console.WriteLine(item);
            }
        }
    }
}
