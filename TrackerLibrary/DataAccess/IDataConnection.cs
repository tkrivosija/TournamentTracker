using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;

namespace TrackerLibrary.DataAccess
{
    public interface IDataConnection
    {
        PrizeModel CreatePrize(PrizeModel model); //void could be used
        PersonModel CreatePerson(PersonModel model);
        List<PersonModel> GetPerson_All();
        TeamModel CreateTeam(TeamModel model);
    }
}
