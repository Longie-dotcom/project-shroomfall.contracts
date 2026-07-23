using Contract.Enum.EntityDomain;
using System;

namespace Contract.Attributes
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
    public sealed class EntityComponentAttribute : Attribute
    {
        #region Attributes
        #endregion

        #region Properties
        public bool Required { get; set; }
        public EntityType[] SupportedEntityTypes { get; }
        #endregion

        public EntityComponentAttribute(
            params EntityType[] supportedEntityTypes)
        {
            SupportedEntityTypes = supportedEntityTypes;
        }

        #region Methods
        #endregion
    }
}
