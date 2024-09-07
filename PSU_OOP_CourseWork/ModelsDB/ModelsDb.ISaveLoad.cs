using PSU_OOP_CourseWork.Models;

namespace PSU_OOP_CourseWork.ModelsDB;

public partial class ModelsDb : ISaveLoad
{
    /// <summary>
    /// <inheritdoc cref="ISaveLoad.Save"/>
    /// </summary>
    public void Save() => service.Save();

    /// <summary>
    /// <inheritdoc cref="ISaveLoad.Load"/>
    /// </summary>
    public void Load() => service.Load();
}