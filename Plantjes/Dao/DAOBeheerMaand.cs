using System.Collections.Generic;
using System.Linq;
using Plantjes.Models.Db;

namespace Plantjes.Dao;

public partial class DAOBeheerMaand : DAOLogic {
    #region FilterBeheerMaandFromPlant

    public static IQueryable<BeheerMaand> FilterBeheerMaandFromPlant(int selectedItem) {
        return context.BeheerMaands.Distinct().Where(s => s.PlantId == selectedItem);
    }

    #endregion

    public static List<BeheerMaand> FillBeheerdaad() {
        return context.BeheerMaands.ToList();
    }

    //Get a list of all the Beheermaand types
    public static List<BeheerMaand> GetBeheerMaanden() {
        return context.BeheerMaands.ToList();
    }
}