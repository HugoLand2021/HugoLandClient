using Hugo_LAND.WCF.DTOs;
using System.Collections.Generic;
using System.ServiceModel;

namespace Hugo_LAND.WCF.Services
{
    [ServiceContract]
    public interface IHeroService
    {
        [OperationContract]
        List<HeroDetailsDTO> ReturnHerosFromAccount(int idCompteJoueur);


        [OperationContract]
        bool CreateHero(HeroDetailsDTO dto);

        [OperationContract]
        bool DeleteHero(HeroDetailsDTO dto);

        [OperationContract]
        void MoveHero(HeroDetailsDTO dto, int newX, int newY);

        [OperationContract]
        HeroDetailsDTO ReturnHero(string idhero);

        [OperationContract]
        string ConnectHero(bool isConnected, int idHero);

        [OperationContract]
        List<HeroDetailsDTO> ReturnHeros(string world, int mapBeginX, int mapBeginY);




    }
}
