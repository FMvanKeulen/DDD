using Domain.Interfaces.Generics;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.Repository.Generics
{
    public class RepositoryGenerics<T> : IGeneric<T>, IDisposable where T : class
    {
    }
}
