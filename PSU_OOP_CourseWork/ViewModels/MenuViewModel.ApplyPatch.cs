using System.Collections.Frozen;
using System.Linq;
using DynamicData;
using DynamicData.Kernel;
using PSU_OOP_CourseWork.Util;
using PSU_OOP_CourseWork.ViewModels.Rows;

namespace PSU_OOP_CourseWork.ViewModels;

public partial class MenuViewModel
{
    private void ApplyPatch(DishRow[] patch)
    {
        var patchIds = patch.Select(row => row.Id).ToFrozenSet();

        var old = Rows.ToArray();
        var oldIds = old.Select(row => row.Id).ToFrozenSet();
        var updatingIds = patchIds.Intersect(oldIds);
        var updating = old.IndexOfMany(old.Where(row => updatingIds.Contains(row.Id)));

        foreach (var (item, i) in updating)
        {
            var patchedItem = patch.First(row => row.Id == item.Id);

            Rows[i] = new
            (
                item.Id,
                patchedItem.Name,
                patchedItem.Description,
                patchedItem.PriceRoubles,
                0
            );
        }

        Rows.RemoveMany(old.Where(row => !patchIds.Contains(row.Id)));
        Rows.AddRange(patch.Where(row => !oldIds.Contains(row.Id)));
    }
}