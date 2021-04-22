using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Bcc.Data;
using System;
using System.Linq;

namespace Bcc.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using(var context = new BccContext(
                serviceProvider.GetRequiredService<
                DbContextOptions<BccContext>>()))
            {
                // Ver se há filmes cadastrados
                if(context.Movie.Any())
                {
                    return; //retorno os filmes cadastrados
                }
                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "Interstelar",
                        ReleaseDate = DateTime.Parse("2014-11-6"),
                        Genre = "Ficção Científica",
                        Rating = "A",
                        Price = 14.99M
                    },

                    new Movie
                    {
                        Title = "Como Treinar Seu Dragão 2",
                        ReleaseDate = DateTime.Parse("2010-3-26"),
                        Genre = "Animação",
                        Rating = "A",
                        Price = 10M
                    },

                    new Movie
                    {
                        Title = "Luca",
                        ReleaseDate = DateTime.Parse("2021-6-16"),
                        Genre = "Animação",
                        Rating = "E",
                        Price = 133M
                    },

                    new Movie
                    {
                        Title = "Bastardos Inglorios",
                        ReleaseDate = DateTime.Parse("2009-10-9"),
                        Genre = "Ação",
                        Rating = "B",
                        Price = 30M
                    }

                );
                context.SaveChanges();
            }
        }
    }
}