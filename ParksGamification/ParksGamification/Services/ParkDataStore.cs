using ParksGamification.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ParksGamification.Services
{
    class ParkDataStore : IParkDataStore<Park>
    {
        private List<Park> parks;
        async Task Init()
        {
            await Task.Delay(100);
        }
        public async Task<IEnumerable<Park>> GetParks()
        {
            await Init();
            List<Park> parks = new List<Park>
            {
                new Park{ Id = 1, Name = "Park Güell, Barcelona" , Description = "Unesco-listed Park Güell is one of the icons of Barcelona. Designed by famed architect Antoni Gaudí, the park is filled with creative modernist works inspired by his passion for natural forms. It’s one of the city’s top attractions and draws around four million visitors each year."}
                new Park{ Id = 2, Name = "The National Garden, Athens" , Description = "Located right next to the Greek Parliament, the National Garden provides an ideal refuge from the heat and traffic of Athens. Created by the order of Queen Amalia, the first queen of Greece, the park contains around 519 different plant species. Whilst many are Greek, the agronomist responsible for first planting the garden imported a variety of species from all over the world."},
                new Park{ Id = 3, Name = "Keukenhof, Lisse" , Description = "Located in Lisse, the Netherlands, Keukenhof is famed as the world’s largest flower garden. More than seven million tulips, daffodils and hyacinths fill the 32-hectare garden with colourful and fragrant displays every year. However, as they bloom in Spring, the gardens are only open from late March to late May."},
                new Park{ Id = 4, Name = "Lumpini Park, Bangkok" , Description = "The first public park in Bangkok, Lumpini was named after Buddha’s place of birth in Nepal. Featuring shady paths, green lawns and a large lake, the park is the perfect escape from the city’s urban noise. Kids can take to the playgrounds or couples can take a romantic paddle boat ride. Enormous monitor lizards also roam the park, giving you the chance to meet the local wildlife."},
                new Park{ Id = 5, Name = "Hibiya Park, Tokyo" , Description = "An oasis in the heart of Tokyo, Hibiya Park is Japan’s first Western-style park. The 16-hectare grounds contain some 3,100 trees and 10,000-sqare-metres of green lawns and pretty flower beds. Two outdoor music venues host weekend events and festivals, alongside several restaurants and a tennis court."},
                new Park{ Id = 6, Name = "Central Park, New York" , Description = "Possibly one of the most famous parks in the world, Central Park ranks alongside the Empire State Building and the Statue of Liberty as a symbol of New York City. Not only was Central park the first public park in America, but it’s also the most visited – with over 25-million visitors each year."}
            };
            return parks;
        }

        public async Task<Park> GetPark(int parkId)
        {
            await Init();
            return parks.Find(park => park.Id == parkId);
        }
    }
}
