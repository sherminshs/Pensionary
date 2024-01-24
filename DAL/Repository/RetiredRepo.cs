using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository
{
    public class RetiredRepo
    {
        PensionaryContext Context = new PensionaryContext();

        //public async Task<bool> RetiredRepoSearchById(long id)
        //{
        //     var result= await Context.Retireds.Where(x => x.RetiredId == id).ToListAsync();
        //    return (result.Count() > 0 ? false : true);
        //}
        //public async void RetiredRepoAdd(Retired ret)
        //{
        //    await Context.Retireds.AddAsync(ret);
        //    await Context.SaveChangesAsync();
            
        //}

    }
}
