using DotNetExperience.Domain.Models;
using DotNetExperience.InterfaceAdapters;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetExperience.Infrastructure.Repositories
{
    public class MovieRepository: IMovieRepository
    {
        private readonly DotNetExperienceContext context;

        public MovieRepository(DotNetExperienceContext context)
        {
            this.context = context;
        }
        public async Task<Movie> Add(Movie entity)
        {
            context.Set<Movie>().Add(entity);

            await context.SaveChangesAsync();

            return entity;
        }

        public async Task<Movie> Delete(int id)
        {
            var entity = await context.Set<Movie>().FindAsync(id);

            if (entity == null)
            {
                return entity;
            }

            context.Set<Movie>().Remove(entity);

            await context.SaveChangesAsync();

            return entity;
        }

        public async Task<Movie> Get(int id)
        {
            return await context.Set<Movie>().FindAsync(id);
        }

        public async Task<List<Movie>> GetAll()
        {
            return await context.Set<Movie>().ToListAsync();
        }

        public async Task<Movie> Update(Movie entity)
        {
            context.Entry(entity).State = EntityState.Modified;
            await context.SaveChangesAsync();

            return entity;
        }
    }
}
