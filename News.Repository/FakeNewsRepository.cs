using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using News.Entity;
namespace News.Repositories
{
    // This project can output the Class library as a NuGet Package.
    // To enable this option, right-click on the project and select the Properties menu item. In the Build tab select "Produce outputs on build".
    public class FakeNewsRepository : INewsRepository
    {
        public FakeNewsRepository()
        {
            NewsEntity ne1 = new NewsEntity(1, "У Харкові під час обшуку в маєтку бізнесмена постраждав нардеп ",
                "wwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwww");
            NewsEntity ne2 = new NewsEntity(2, "Енергоблокада Криму загрожує відключеннями світла в Україні - Кононенко",
                "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa");
            NewsEntity ne3 = new NewsEntity(3, "У Стокгольмі розпочинається тиждень Нобелівських урочистостей  ",
                "mmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmm");
            NewsEntity ne4 = new NewsEntity(4, "Волонтер показав фото незламної Зінкевич",
                "iiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiii");
            NewsEntity ne5 = new NewsEntity(5, "Говерла програла учетверте поспіль", 
                "qqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqq");

            fake.Add(ne1);
            fake.Add(ne2);
            fake.Add(ne3);
            fake.Add(ne4);
            fake.Add(ne5);
        }


        public static List<NewsEntity> fake = new List<NewsEntity>();

        public List<NewsEntity> GetAll()
        {
            return fake;
        }

    }
}
