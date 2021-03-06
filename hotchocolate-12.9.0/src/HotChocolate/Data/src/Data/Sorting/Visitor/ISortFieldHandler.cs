using HotChocolate.Configuration;

namespace HotChocolate.Data.Sorting;

public interface ISortFieldHandler
{
    /// <summary>
    /// Tests if this field handler can handle a field If it can handle the field it
    /// will be attached to the <see cref="SortField"/>
    /// </summary>
    /// <param name="context">The discovery context of the schema</param>
    /// <param name="typeDefinition">The definition of the declaring type of the field</param>
    /// <param name="fieldDefinition">The definition of the field</param>
    /// <returns>Returns true if the field can be handled</returns>
    bool CanHandle(
        ITypeCompletionContext context,
        ISortInputTypeDefinition typeDefinition,
        ISortFieldDefinition fieldDefinition);
}
