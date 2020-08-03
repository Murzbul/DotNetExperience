using DotNetExperience.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetExperience.InterfaceAdapters
{
    public interface IMovieRepository
    {
        Task<List<Movie>> GetAll();
        Task<Movie> Get(int id);
        Task<Movie> Add(Movie entity);
        Task<Movie> Update(Movie entity);
        Task<Movie> Delete(int id);
    }
}
