namespace FristExercise
{

    public static class StringExtensions
    {
        public static string Summary(this String imput, int count)
        {
            if (imput.Length <= count)
            {
                return imput;
            }
            else
            {
                string cutInput = imput.Substring(0, count);
                int lastSpace = cutInput.LastIndexOf(" ");
                return imput.Substring(0, lastSpace) + "..."; ;
            }
        }
    }
}
