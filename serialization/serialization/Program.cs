using Serl;
using Newtonsoft;


using Journal;

var date = DateTime.Now;
Magazine magazine = new("Maga", "maga&co", date, 100);
//magazine.printAll();
magazine.serializeMagazine(magazine);
magazine.deserializeMagazine(magazine);

namespace Journal
{
    public class Magazine : ISerialiazation
    {
        public Magazine(string name, string publisherName, DateTime releaseDate, int pagesNumber)
        {
            this.Name = name;
            this.PublisherName = publisherName;
            this.ReleaseDate = releaseDate;
            this.PagesNumber = pagesNumber;
        }

        public void CreateMagazine()
        {
            string tmpPublisherName;
            DateTime tmpReleaseDate;
            int tmpPagesNumber;

            Console.WriteLine("enter name~# ");
            this.Name = Console.ReadLine();

            Console.WriteLine("enter publisher's name~# ");
            this.PublisherName = Console.ReadLine();

            Console.WriteLine("enter date~# ");
            this.ReleaseDate = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("enter page~# ");
            this.PagesNumber = Convert.ToInt32(Console.ReadLine());
        }

        public void printAll()
        {
            Console.WriteLine(
                $"Name: {this.Name}\n" +
                $"Publisher Name: {this.PublisherName}\n" +
                $"Release Date: {this.ReleaseDate}\n" +
                $"Pages Number: {this.PagesNumber}\n"
            );
        }

        public void serializeMagazine(Magazine magazine)
        {
            Serializator service = new();

            var json = service.Serialize(magazine);

            using FileStream fs = new("magazine.json", FileMode.OpenOrCreate);
            using StreamWriter sw = new(fs);

            sw.Write(json);
        }

        public void deserializeMagazine(Magazine magazine)
        {
            using FileStream fs = new("magazine_data.json", FileMode.OpenOrCreate);
            using StreamReader sr = new(fs);

            Serializator service = new();
            var obj = service.Deserialiaze<Magazine>(sr.ReadToEnd());

            Console.WriteLine(obj);
        }


        public string Name { get; set; }
        public string PublisherName { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int PagesNumber { get; set; }
    }


}