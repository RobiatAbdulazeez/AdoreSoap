using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using AdoreSoap.Data;
using System;
using System.Linq;

namespace AdoreSoap.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new AdoreSoapContext(
                           serviceProvider.GetRequiredService<
                               DbContextOptions<AdoreSoapContext>>()))
            {
                // Look for any soap(Adore) in the database.
                if (context.Adore.Any())
                {
                    return;   //The  DB has been seeded
                }
                context.Adore.AddRange(
                    new Adore
                    {
                        Name = "Lush",
                        ReleaseDate = DateTime.Parse("2020-5-7"),
                        Color = "Pink",
                        Purpose = "Body",
                        Type="Bar",
                        Price = 3.99M
                        

                    },
                     new Adore
                     {
                         Name = "Perfect Skin",
                         ReleaseDate = DateTime.Parse("2020-5-7"),
                         Color = "White",
                         Purpose = "Body",
                         Type = "Bar",
                         Price = 7.99M
                         

                     },
                      new Adore
                      {
                          Name = "Forever young",
                          ReleaseDate = DateTime.Parse("2020-8-12"),
                          Color = "peach",
                          Purpose = "Face",
                          Type = "Wash",
                          Price = 1.99M
                          

                      },
                       new Adore
                       {
                           Name = "Fresh",
                           ReleaseDate = DateTime.Parse("2020-9-7"),
                           Color = "Pink",
                           Purpose = "Body",
                           Type = "Bar",
                           Price = 2.99M
                           

                       },
                        new Adore
                        {
                            Name = "Flawless",
                            ReleaseDate = DateTime.Parse("2020-5-7"),
                            Color = "Orange",
                            Purpose = "Body",
                            Type = "Bar",
                            Price = 1.99M
                            

                        },
                         new Adore
                         {
                             Name = "Spot Removal",
                             ReleaseDate = DateTime.Parse("2020-5-25"),
                             Color = "White",
                             Purpose = "Body",
                             Type = "Bar",
                             Price = 3.99M
                            

                         },
                          new Adore
                          {
                              Name = "Sooth Skin",
                              ReleaseDate = DateTime.Parse("2020-5-7"),
                              Color = "Brown",
                              Purpose = "Body",
                              Type = "Bar",
                              Price = 2.99M
                              

                          },
                           new Adore
                           {
                               Name = "Clear",
                               ReleaseDate = DateTime.Parse("2020-5-7"),
                               Color = "Yellow",
                               Purpose = "Body",
                               Type = "Wash",
                               Price = 1.99M
                              

                           },
                            new Adore
                            {
                                Name = "Beautiful You",
                                ReleaseDate = DateTime.Parse("2020-8-7"),
                                Color = "Wash",
                                Purpose = "Body",
                                Type = "Bar",
                                Price = 2.99M
                               

                            },
                             new Adore
                             {
                                 Name = "Goodbye To Wrinkles",
                                 ReleaseDate = DateTime.Parse("2020-5-7"),
                                 Color = "White",
                                 Purpose = "Body",
                                 Type = "Bar",
                                 Price = 7.99M
                                 
                             }
                              );
                context.SaveChanges();

            }
        }


    }
}
