using System;

using R5T.T0132;


namespace R5T.T0228.Extensions
{
    [FunctionalityMarker]
    public partial interface IStringOperator : IFunctionalityMarker
    {
        /// <inheritdoc cref="IMethodName"/>
        public IMethodName ToMethodName(string value)
        {
            var output = new MethodName(value);
            return output;
        }

        /// <inheritdoc cref="INamespaceName"/>
        public INamespaceName ToNamespaceName(string value)
        {
            var output = new NamespaceName(value);
            return output;
        }

        /// <inheritdoc cref="IPropertyName"/>
        public IPropertyName ToPropertyName(string value)
        {
            var output = new PropertyName(value);
            return output;
        }

        /// <inheritdoc cref="ITypeName"/>
        public ITypeName ToTypeName(string value)
        {
            var output = new TypeName(value);
            return output;
        }
    }
}
