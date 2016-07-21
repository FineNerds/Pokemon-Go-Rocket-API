using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokemonGo.RocketAPI.GeneratedCode;

namespace PokemonGo.RocketAPI.Logic.Utils
{
    public static class StringUtils
    {
        public static string GetSummedFriendlyNameOfItemAwardList(IEnumerable<FortSearchResponse.Types.ItemAward> items)
        {
            var enumerable = items as IList<FortSearchResponse.Types.ItemAward> ?? items.ToList();

            if (!enumerable.Any())
                return string.Empty;

            return
                enumerable.GroupBy(i => i.ItemId)
                          .Select(kvp => new { ItemName = kvp.Key.ToString(), Amount = kvp.Sum(x => x.ItemCount) })
                          .Select(y => $"{y.Amount} x {localizeItemName(y.ItemName)}")
                          .Aggregate((a, b) => $"{a}, {b}");
        }

        public static string localizeItemName(string unlocalizedName)
        {
            if (unlocalizedName == "ITEM_POKE_BALL" || unlocalizedName == "ItemPokeBall")
                return "Poke Ball";
            if (unlocalizedName == "ITEM_GREAT_BALL" || unlocalizedName == "ItemGreatBall")
                return "Great Ball";
            if (unlocalizedName == "ITEM_ULTRA_BALL" || unlocalizedName == "ItemUltraBall")
                return "Ultra Ball";
            if (unlocalizedName == "ITEM_MASTER_BALL" || unlocalizedName == "ItemMasterBall")
                return "Master Ball";
            if (unlocalizedName == "ITEM_RAZZ_BERRY" || unlocalizedName == "ItemRazzBerry")
                return "Razzberry";
            if (unlocalizedName == "ITEM_POTION" || unlocalizedName == "ItemPotion")
                return "Potion";
            if (unlocalizedName == "ITEM_SUPER_POTION" || unlocalizedName == "ItemSuperPotion")
                return "Super Potion";
            if (unlocalizedName == "ITEM_MAX_POTION" || unlocalizedName == "ItemMaxPotion")
                return "Max Potion";
            if (unlocalizedName == "ITEM_REVIVE" || unlocalizedName == "ItemRevive")
                return "Revive";
            if (unlocalizedName == "ITEM_MAX_REVIVE" || unlocalizedName == "ItemMaxRevive")
                return "Max Revive";
            if (unlocalizedName == "ITEM_LUCKY_EGG" || unlocalizedName == "ItemLuckyEgg")
                return "LuckyEgg";
            if (unlocalizedName == "ITEM_INCENSE_ORDINARY" || unlocalizedName == "ItemIncenseOrdinary")
                return "Ordinary Incense";
            if (unlocalizedName == "ITEM_INCENSE_SPICY" || unlocalizedName == "ItemIncenseSpicy")
                return "Spicy Incense";
            if (unlocalizedName == "ITEM_INCENSE_COOL" || unlocalizedName == "ItemIncenseCool")
                return "Cool Incense";
            if (unlocalizedName == "ITEM_INCENSE_FLORAL" || unlocalizedName == "ItemIncenseFloral")
                return "Floral Incense";
            if (unlocalizedName == "ITEM_TROY_DISK" || unlocalizedName == "ItemTroyDisk")
                return "Troy Disk";
            if (unlocalizedName == "ITEM_X_ATTACK" || unlocalizedName == "ItemXAttack")
                return "X Attack";
            if (unlocalizedName == "ITEM_X_DEFENSE" || unlocalizedName == "ItemXDefense")
                return "X Defense";
            if (unlocalizedName == "ITEM_X_MIRACLE" || unlocalizedName == "ItemXMiracle")
                return "X Miracle";
            if (unlocalizedName == "ITEM_RAZZ_BERRY" || unlocalizedName == "ItemRazzBerry")
                return "Razz Berry";
            if (unlocalizedName == "ITEM_BLUK_BERRY" || unlocalizedName == "ItemBlukBerry")
                return "Bluk Berry";
            if (unlocalizedName == "ITEM_NANAB_BERRY" || unlocalizedName == "ItemNanabBerry")
                return "Nanab Berry";
            if (unlocalizedName == "ITEM_WEPAR_BERRY" || unlocalizedName == "ItemWeparBerry")
                return "Wepar Berry";
            if (unlocalizedName == "ITEM_PINAP_BERRY" || unlocalizedName == "ItemPinapBerry")
                return "Pinap Berry";
            if (unlocalizedName == "ITEM_SPECIAL_CAMERA" || unlocalizedName == "ItemSpecialCamera")
                return "Special Camera";
            if (unlocalizedName == "ITEM_INCUBATOR_BASIC_UNLIMITED" || unlocalizedName == "ItemIncubatorBasicUnlimited")
                return "Basic Incubator: Unlimited";
            if (unlocalizedName == "ITEM_INCUBATOR_BASIC" || unlocalizedName == "ItemIncubatorBasic")
                return "Basic Incubator: 3 uses";
            if (unlocalizedName == "ITEM_POKEMON_STORAGE_UPGRADE" || unlocalizedName == "ItemPokemonStorageUpgrade")
                return "Pokemon Storage Upgrade";
            if (unlocalizedName == "ITEM_ITEM_STORAGE_UPGRADE" || unlocalizedName == "ItemItemStorageUpgrade")
                return "Item Storage Upgrade";

            return $"Unkown Item: {unlocalizedName}";
        }
    }
}