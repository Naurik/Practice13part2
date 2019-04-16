using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Сlasswork_On_Serializable2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Самостоятельно рассмотреть библиотеку Newtonsoft.Json и сериализовать коллекцию в json файл.*/

            MyMusic myCollection = new MyMusic();
            myCollection.Tracks = new Track[3];

            myCollection.Tracks[0] = new Track()
            {
                Artist = "Artist1",
                Album = "Album1",
                Title = "Title1",
                Year = "2015"
            };
            myCollection.Tracks[1] = new Track()
            {
                Artist = "Artist2",
                Album = "Album2",
                Title = "Title2",
                Year = "2015"
            };
            myCollection.Tracks[2] = new Track()
            {
                Artist = "Artist3",
                Album = "Album3",
                Title = "Title3",
                Year = "2015"
            };

            string serialized = JsonConvert.SerializeObject(myCollection);
            Console.WriteLine(serialized);

            Console.ReadLine();

        }
    }
}
