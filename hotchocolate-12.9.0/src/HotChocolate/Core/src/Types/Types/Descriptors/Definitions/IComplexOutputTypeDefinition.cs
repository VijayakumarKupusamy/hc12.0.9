using System;
using System.Collections.Generic;

#nullable enable

namespace HotChocolate.Types.Descriptors.Definitions;

public interface IComplexOutputTypeDefinition
{
    NameString Name { get; }

    Type RuntimeType { get; }

    IList<Type> KnownRuntimeTypes { get; }

    IList<ITypeReference> Interfaces { get; }
}
