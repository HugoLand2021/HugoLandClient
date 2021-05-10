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
        List<HeroDetailsDTO> ReturnHeroes(string world, int mapBeginX, int mapBeginY, int idHero);

        [OperationContract]
        bool IsHeroConnected(string nomHero);
		
		[OperationContract]
        HeroDetailsDTO ArmorHero(int world, int newX, int newY, HeroDetailsDTO hero, int idItem, bool force = false);

        [OperationContract]
        HeroDetailsDTO FoodHero(int world, int newX, int newY, HeroDetailsDTO hero, int idItem, bool force = false);
    }
}
