using ObjectMappers.AttributeMapping.AutoMapper;
using ObjectMappers.AttributeMapping.Mapster;
using ObjectMappers.CollectionMapping;
using ObjectMappers.CustomPropertyMapping;
using ObjectMappers.DataGenerators;
using ObjectMappers.NestedTypeMapping;
using ObjectMappers.ObjectFlattening;
using ObjectMappers.ReverseMappingAndUnflattening;
using ObjectMappers.SimpleTypeMapping;
using System.Text.Json;

namespace ObjectMappers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var st_source = SimpleTypeMappingDataGenerator.GetSources(1).FirstOrDefault();
            var nt_source = NestedTypeMappingDataGenerator.GetSources(1).FirstOrDefault();
            var ct_source = CollectionMappingDataGenerator.GetSources(1);
            var of_source = ObjectFlatteningDataGenerator.GetSources(1).First();
            var r_source = ReverseMappingDataGenerator.GetSources(1).First();
            var a_source = AttributeMappingDataGenerator.GetSources(1).FirstOrDefault();
            var cm_source = CustomPropertyMappingDataGenerator.GetSources(1).FirstOrDefault();

            var mapster_source = MapsterAttributeMappingDataGenerator.GetSources(1).First();

            Console.WriteLine("Simple Type Mapping......");
            var sm_Destination = AMTypeMapping.Map(st_source);
            Console.WriteLine(nameof(sm_Destination));
            Console.WriteLine(JsonSerializer.Serialize(sm_Destination) + Environment.NewLine);

            var sm_Destination2 = MapsterTypeMapping.Map(st_source);
            Console.WriteLine(nameof(sm_Destination2));
            Console.WriteLine(JsonSerializer.Serialize(sm_Destination2) + Environment.NewLine);


            Console.WriteLine("Nested Type Mapping");
            var nt_Dest = AM_NestedTypeMapping.Map(nt_source);
            Console.WriteLine(nameof(nt_Dest));
            Console.WriteLine(JsonSerializer.Serialize(nt_Dest) + Environment.NewLine);

            var nt_Dest2 = Mapster_NestedTypeMapping.Map(nt_source);
            Console.WriteLine(nameof(nt_Dest2));
            Console.WriteLine(JsonSerializer.Serialize(nt_Dest2) + Environment.NewLine);

            Console.WriteLine("Collection Type Mapping");
            var ct_Dest = AM_CollectionMapping.Map(ct_source);
            Console.WriteLine(nameof(ct_Dest));
            Console.WriteLine(JsonSerializer.Serialize(ct_Dest) + Environment.NewLine);

            var ct_Dest2 = Mapster_CollectionMapping.Map(ct_source);
            Console.WriteLine(nameof(ct_Dest2));
            Console.WriteLine(JsonSerializer.Serialize(ct_Dest2) + Environment.NewLine);

            Console.WriteLine("Object Flattening Mapping");
            var of_Dest = AM_ObjectFlattening.Map(of_source);
            Console.WriteLine(nameof(of_Dest));
            Console.WriteLine(JsonSerializer.Serialize(of_Dest) + Environment.NewLine);

            var of_Dest2 = Mapster_ObjectFlattening.Map(of_source);
            Console.WriteLine(nameof(of_Dest2));
            Console.WriteLine(JsonSerializer.Serialize(of_Dest2) + Environment.NewLine);

            Console.WriteLine("Reverse Mapping");
            var r_Dest = AM_ReverseMapping.Map(r_source);
            Console.WriteLine(nameof(r_Dest));
            Console.WriteLine(JsonSerializer.Serialize(r_Dest) + Environment.NewLine);

            var r_Dest2 = Mapster_ReverseMapping.Map(r_source);
            Console.WriteLine(nameof(r_Dest2));
            Console.WriteLine(JsonSerializer.Serialize(r_Dest2) + Environment.NewLine);

            Console.WriteLine("Attribute Mapping");
            var a_Dest = AM_AttributeMapping.Map(a_source);
            Console.WriteLine(nameof(a_Dest));
            Console.WriteLine(JsonSerializer.Serialize(a_Dest) + Environment.NewLine);

            var a_Dest2 = Mapster_AttributeMapping.Map(mapster_source);
            Console.WriteLine(nameof(a_Dest2));
            Console.WriteLine(JsonSerializer.Serialize(a_Dest2) + Environment.NewLine);

            Console.WriteLine("Custom Property Mapping");
            var cm_Dest = AM_CustomPropertyMapping.Map(cm_source);
            Console.WriteLine(nameof(cm_Dest));
            Console.WriteLine(JsonSerializer.Serialize(cm_Dest) + Environment.NewLine);

            var cm_Dest2 = Mapster_CustomPropertyMapping.Map(cm_source);
            Console.WriteLine(nameof(cm_Dest2));
            Console.WriteLine(JsonSerializer.Serialize(cm_Dest2) + Environment.NewLine);
        }
    }
}