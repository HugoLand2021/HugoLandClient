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
        string ConnectHero(int heroID, int accountID, bool force = false);

        [OperationContract]
        string DisconnectHero(int heroID, bool force = false);

        [OperationContract]
        List<HeroDetailsDTO> ReturnHeroes(string world, int mapBeginX, int mapBeginY, int idHero);

		[OperationContract]
        HeroDetailsDTO PicksUpItem(string itemType, int world, int X, int Y, HeroDetailsDTO hero, bool force = false);

        [OperationContract]
        int RemoveHealth(HeroDetailsDTO hero, int heroDamage, bool force = false);
        [OperationContract]
        int RemoveHealthVSHero(HeroDetailsDTO hero, bool force = false);

        [OperationContract]
        HeroDetailsDTO ReplaceHeroToBones(HeroDetailsDTO hero, int X, int Y, int world, bool force = false);

    }
}
