using TP3Hugo_Land.WCF.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using Hugo_LAND.Core.Models;

namespace TP3Hugo_Land.WCF.Services
{
    [ServiceContract]
    public interface IHeroService
    {
        [OperationContract]
        void CreeHero(int newNiveau, long newExperience, int newX, int newY, int newStatStr, int newStatDex,
            int newStatInt, int newStatVitalite, string newNomHero, bool newConnection, int idClasse, int idCompteJoueur,
              int idMonde);

        [OperationContract]
        void SupprimeHero(HeroDetailsDTO dto);

        [OperationContract]
        void DeplaceHero(HeroDetailsDTO dto, int newX, int newY);
    }
}
