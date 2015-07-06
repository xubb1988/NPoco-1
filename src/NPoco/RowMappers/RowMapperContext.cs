using System;

namespace NPoco.RowMappers
{
    public class RowMapperContext
    {
        public object Instance { get; set; }
        public object PrimaryKeyValue { get; set; }
        public PocoData PocoData { get; set; }
        public Type Type { get { return PocoData.Type; } }
    }
}