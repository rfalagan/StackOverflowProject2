using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;

namespace StackOverflowProject.ServiceLayer
{
    public static class MapperExtensions
    {
        private static void IgnoreUnMappedProperties(TypeMap map, IMappingExpression expr)
        {
            foreach (string propName in map.GetUnmappedPropertyNames())
            {

                if(map.SourceType.GetProperty(propName) != null )
                {
                    expr.ForMember(propName, opt => opt.Ignore());
                }

                if (map.DestinationType.GetProperty(propName) != null)
                {
                    expr.ForMember(propName, opt => opt.Ignore());
                }

            }

        }

        public static void IgnoreUnmapped(this IProfileExpression profile)
        {
            profile.ForAllMaps(IgnoreUnMappedProperties);
        }
    }


}
