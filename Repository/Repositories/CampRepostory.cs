using EdgarAparicio.APICampingTeotihuacan.Manager.Entity.Context;
using EdgarAparicio.APICampingTeotihuacan.Manager.Entity.Entities;
using EdgarAparicio.APICampingTeotihuacan.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdgarAparicio.APICampingTeotihuacan.Repository.Repositories
{
    public class CampRepostory : ICampRepository
    {
        private readonly DbContextAPICampingTeotihuacan _context;
        public CampRepostory(DbContextAPICampingTeotihuacan context)
        {
            _context = context;
        }
        public async Task<Camp[]> GetAllCampsAsync(bool includeTalks = false)
        {
            IQueryable<Camp> query = _context.Camps.Include(c => c.Location);
            if (includeTalks)
            {
                query = query.Include(c => c.Talks).ThenInclude(t => t.Speaker);   
            }

            query = query.OrderByDescending(c => c.EventDate);

            return await query.ToArrayAsync();
        }


        public async Task<List<Camp>> GetAllCamps()
        {
            var list =  await _context.Camps
                    .Include(c => c.Location).Include(c => c.Talks).ThenInclude(t => t.Speaker)
                    .OrderByDescending(c => c.EventDate)
                    .ToListAsync();

            return list;
            //List<Camp> listCamp;
            //if (includeTalks)
            //{
            //     listCamp = await _context.Camps
            //        .Include(c => c.Location)
            //        .Include(c => c.Talks)
            //        .ThenInclude(t => t.Speaker)
            //        .OrderByDescending(c => c.EventDate)
            //        .ToListAsync();
            //}
            //else
            //{
            //    listCamp = await _context.Camps
            //        .Include(c => c.Location)
            //        .OrderByDescending(c => c.EventDate)
            //        .ToListAsync();
            //}
            //return listCamp;


        }

        public async Task<Camp> GetCamp(string moniker)
        {
            var entity = await _context.Camps
                .Include(c => c.Location)
                .Where(c => c.Moniker == moniker)
                .FirstOrDefaultAsync();

            return entity;
        }
    }
}
