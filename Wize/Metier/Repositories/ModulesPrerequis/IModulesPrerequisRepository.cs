using CSharpFunctionalExtensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Metier.Repositories.ModulesPrerequis
{
    public interface IModulesPrerequisRepository
    {
        Maybe<Metier.Entities.ModulesPrerequis> Get(int id);
        Metier.Entities.ModulesPrerequis Add(Metier.Entities.ModulesPrerequis entity);
    }
}
