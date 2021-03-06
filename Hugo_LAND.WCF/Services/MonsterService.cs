using Hugo_LAND.Core.Models;
using Hugo_LAND.WCF.DTOs;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Linq;

namespace Hugo_LAND.WCF.Services
{
    public partial class HugoLandService : IMonsterService
    {
        public int RemoveHealthMonster(MonsterDetailsDTO monster, int heroDamage, bool force = false)
        {
            using (var context = new HugoLANDContext())
            {
                Monstre currMonster;

                try
                {
                    currMonster = context.Monstres.Find(monster.Id);
                    currMonster.StatPV -= heroDamage;
                }
                catch
                {
                    return monster.StatPV;
                }

                int itr = force ? 5 : 1;
                var currVersion = currMonster.RowVersion;
                do
                {
                    try
                    {
                        context.SaveChanges();
                        monster.StatPV = currMonster.StatPV;
                        return monster.StatPV;
                    }
                    catch (DbUpdateConcurrencyException)
                    {
                        if (itr > 0)
                        {
                            var objContext = ((IObjectContextAdapter)context).ObjectContext;
                            objContext.Refresh(RefreshMode.ClientWins, currMonster);
                            itr--;
                        }
                    }
                } while (itr > 0 && currVersion != currMonster.RowVersion);

                return monster.StatPV;
            }
        }

        public void ReplaceMonsterToBones(MonsterDetailsDTO monster, int world, bool force = false)
        {
            using (var context = new HugoLANDContext())
            {
                Monstre currMonstre;
                Item item;

                currMonstre = context.Monstres.First(m => m.Id == monster.Id);

                try
                {

                    context.Monstres.Remove(currMonstre);
                    context.Mondes.Find(world).Items.Add(new Item { Nom = "Bones", Description = "Bones", x = monster.x, y = monster.y, ImageId = 168 });

                    item = context.Items.Where(x => x.Monde.Id == world && x.x == monster.x && x.y == monster.y).FirstOrDefault();
                }
                catch
                {
                    return;
                }

                int itr = force ? 5 : 1;
                var currVersion = currMonstre.RowVersion;
                do
                {
                    try
                    {
                        context.SaveChanges();
                        return;
                    }
                    catch (DbUpdateConcurrencyException)
                    {
                        if (itr > 0)
                        {
                            var objContext = ((IObjectContextAdapter)context).ObjectContext;
                            objContext.Refresh(RefreshMode.ClientWins, currMonstre);
                            objContext.Refresh(RefreshMode.ClientWins, item);
                            itr--;
                        }
                    }
                } while (itr > 0 && currVersion != currMonstre.RowVersion);
            }
        }

        public List<MonsterDetailsDTO> ReturnMonsters(string world, int mapBeginX, int mapBeginY)
        {
            try
            {
                using (HugoLANDContext context = new HugoLANDContext())
                {

                    return context.Mondes.First(w => w.Description == world)
                        .Monstres
                        .Where(obj => ((obj.x >= mapBeginX) && (obj.x < mapBeginX + 8)) && ((obj.y >= mapBeginY) && (obj.y < mapBeginY + 8)))
                        .Select(m => new MonsterDetailsDTO
                        {
                            Id = m.Id,
                            Nom = m.Nom,
                            x = m.x,
                            y = m.y,
                            ImageId = m.ImageId,
                            Niveau = m.Niveau,
                            StatDmgMax = m.StatDmgMax,
                            StatDmgMin = m.StatDmgMin,
                            StatPV = m.StatPV
                        }).ToList();
                }
            }
            catch
            {
                return null;
            }
        }

    }
}