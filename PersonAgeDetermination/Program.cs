namespace PersonAgeDetermination
{
    public class Program
    {
        public static void Main(string[] args)
        {
            AgeCategoryDeterminer ageDeterminer = new AgeCategoryDeterminer();

            try
            {
                Console.Write("Enter a person's age: ");
                string input = Console.ReadLine();

                if (string.IsNullOrEmpty(input))
                {
                    throw new AgeCategoryException("Invalid age entered.");
                }

                int age = Convert.ToInt32(input);
                string category = ageDeterminer.DetermineAgeCategory(age);
                Console.WriteLine($"The person belongs to the category: {category}");
            }
            catch (AgeCategoryException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid age entered. Please enter a valid age.");
            }
        }
    }
}