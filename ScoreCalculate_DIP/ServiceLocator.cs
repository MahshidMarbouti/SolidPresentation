using System;
using System.Collections.Generic;
using System.IO;

namespace ScoreCalculate_DIP
{
    public static class ServiceLocator
    {
        static readonly Dictionary<Type,Type> TypeMapper = new Dictionary<Type,Type>();

        public static void RegisterAll()
        {
            TypeMapper.Add(typeof(IReader), typeof(ReadTextFile) );
            TypeMapper.Add(typeof(IMapper), typeof(Mapper) );
            TypeMapper.Add(typeof(ISplitter), typeof(SplittByComma));
            TypeMapper.Add(typeof(IExporter), typeof(Exporter));
        }

        public static object Resolve(Type t)
        {
            return Activator.CreateInstance(TypeMapper[t]);
        }
    }
}