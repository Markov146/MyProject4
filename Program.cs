namespace Ezhednevnick
{
    internal class Program
    {

        public static int vertical=1;
        public static int gorizontal=0;
        public static DateTime date = new DateTime();
        public static DateTime dates;
        public static List<Notes> days = new List<Notes>();

        static void Main()
        {
            
            dates = DateTime.Today;
            Notes dateOne = new Notes()
            {
                data = new DateTime(2023, 2, 9),
                affairOne = "Прийти на пары",
                doneOne = "Пришел на пересдачу",
                affairTwo = "Пойти домой",
                doneTwo = "Посмотрел Аватар2"
            };
            Notes.days.Add(dateOne);
            Notes dateTwo = new Notes()
            {
                data = new DateTime(2022, 12, 10),
                affairOne = "Пойти гулять",
                doneOne = "Поиграл в хоккей во дворе",
                affairTwo = "Поехать в магазин",
                doneTwo = "Купил подарки"
            };
            Notes.days.Add(dateTwo);
            Notes dateThree = new Notes()
            {
                data = new DateTime(2022, 12, 11),
                affairOne = "Поиграть в компьютерные игры",
                doneOne = "Ссыграл в Far cry 3",
                affairTwo = "Пойти спать",
                doneTwo = "Не стал спать",
            };
            Notes.days.Add(dateThree);
            Strelki();

        }
        static void Strelki()
        {
            while (true)           
            {
                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key == ConsoleKey.UpArrow)
                {
                    vertical--;
                }
                else if (key.Key == ConsoleKey.DownArrow)
                {
                    vertical++;
                }
                else if (key.Key == ConsoleKey.LeftArrow)
                {
                    gorizontal--;
                    
                }
                else if (key.Key == ConsoleKey.RightArrow)
                {
                    gorizontal++;
                }
                Console.Clear();
                              
                Console.SetCursorPosition(0, vertical);
                Console.WriteLine("->");
            }
            
        }
       static void AffairDates()
       {
            Console.SetCursorPosition(0, 0);
            Console.WriteLine($"Выбрана дата: {dates.AddDays(gorizontal).Day}.{dates.AddDays(vertical).Month}.{dates.Year}");
            foreach (Notes note in days)
            {
                if (note.data == date)
                {
                    Console.WriteLine($"{1}.{note.affairOne}.{note.affairTwo}.");
                }                   

            }                              
            Console.SetCursorPosition(0, vertical);
               
       }  
       static void DoneDates()
        {
            foreach (Notes note in days)
            {
                if (note.data == date)
                {
                    Console.WriteLine($"{note.affairOne}.{note.affairTwo}.\n" +
                        $"Описание: {note.doneOne}.{note.doneOne}\n " +
                        $"Дата:  {dates.AddDays(gorizontal).Day}.{dates.AddDays(vertical).Month}.{dates.Year}");
                }
            }
            Console.SetCursorPosition(0, vertical);

        }
    }
           
            
   

}
    
