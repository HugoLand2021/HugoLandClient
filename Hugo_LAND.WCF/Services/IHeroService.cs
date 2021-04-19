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
        List<HeroDetailsDTO> RetourneHerosCompte(int idCompteJoueur);


        [OperationContract]
        void CreateHero(HeroDetailsDTO dto);

        [OperationContract]
        void SupprimeHero(HeroDetailsDTO dto);

        [OperationContract]
        void DeplaceHero(HeroDetailsDTO dto, int newX, int newY);

        [OperationContract]
        HeroDetailsDTO RetourneHerosActuel(string idhero);


    }
}
