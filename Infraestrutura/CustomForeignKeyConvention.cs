using System;
using FluentNHibernate;
using FluentNHibernate.Conventions;

namespace Infraestrutura
{
    public class CustomForeignKeyConvention : ForeignKeyConvention
    {
        protected override string GetKeyName(Member property, Type type)
        {
            if (property == null)
                return type.Name + "ID";

            return property.Name + "ID";
        }
    }
}
