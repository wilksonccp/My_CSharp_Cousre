namespace FristExercise
{
    public static class ListExtensions
    {
        public static void RemoveEmpty(this List<string> imput)
        {
            List<string> done = new List<string>();
            foreach (string item in imput)
            {
                if (string.IsNullOrWhiteSpace(item))
                {
                    done.Add(item);
                }
            }
            foreach(string item in done)
            {
                imput.Remove(item);
            } 

        }
    }
}
