using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0228
{
    /// <inheritdoc cref="IPropertyName"/>
    [StrongTypeImplementationMarker]
    public class PropertyName : TypedBase<string>, IStrongTypeMarker,
        IPropertyName
    {
        public PropertyName(string value)
            : base(value)
        {
        }
    }
}