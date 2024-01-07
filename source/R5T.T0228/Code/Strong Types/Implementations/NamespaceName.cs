using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0228
{
    /// <inheritdoc cref="INamespaceName"/>
    [StrongTypeImplementationMarker]
    public class NamespaceName : TypedBase<string>, IStrongTypeMarker,
        INamespaceName
    {
        public NamespaceName(string value)
            : base(value)
        {
        }
    }
}