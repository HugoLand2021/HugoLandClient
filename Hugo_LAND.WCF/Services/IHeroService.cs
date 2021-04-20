using Hugo_LAND.WCF.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using Hugo_LAND.Core.Models;

namespace Hugo_LAND.WCF.Services
{
    [ServiceContract]
    public interface IHeroService
    {
        [OperationContract]
        List<HeroDetailsDTO> ReturnHerosFromAccount(int idCompteJoueur);


        [OperationContract]
        void CreateHero(HeroDetailsDTO dto);

        [OperationContract]
        void DeleteHero(HeroDetailsDTO dto);

        [OperationContract]
        void MoveHero(HeroDetailsDTO dto, int newX, int newY);

        [OperationContract]
        HeroDetailsDTO ReturnHero(string idhero);

        //[OperationContract]


    }
}
