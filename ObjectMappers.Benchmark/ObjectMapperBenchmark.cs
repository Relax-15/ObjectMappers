using BenchmarkDotNet.Attributes;
using ObjectMappers.AttributeMapping.AutoMapper;
using ObjectMappers.AttributeMapping.Mapster;
using ObjectMappers.CollectionMapping;
using ObjectMappers.CustomPropertyMapping;
using ObjectMappers.DataGenerators;
using ObjectMappers.NestedTypeMapping;
using ObjectMappers.ObjectFlattening;
using ObjectMappers.ReverseMappingAndUnflattening;
using ObjectMappers.SimpleTypeMapping;


namespace ObjectMappers.Benchmark;


[MemoryDiagnoser(false)]
public  class ObjectMapperBenchmark
{
    public readonly int _size = 1_000;

    private SimpleTypeMapping.User[] _simpleObjectSource = null!;
    private CollectionMapping.User[] _collectionObjectSource = null!;
    private NestedTypeMapping.User[] _nestedObjectSource = null!;
    private ObjectFlattening.User[] _flattenedObjectSource = null!;
    private CustomPropertyMapping.User[] _customPropertyObjectSource = null!;
    private ReverseMappingAndUnflattening.UserDTO[] _reverseMappingObjectSource = null!;
    private AttributeMapping.AutoMapper.User[] _automapperAttributeObjectSource = null!;
    private AttributeMapping.Mapster.User[] _mapsterAttributeObjectSource = null!;

    #region SimpleMapping

    [GlobalSetup(Targets = new[] { nameof(AutoMapperSimpleObjectMapping), nameof(MapsterSimpleObjectMapping) })]
    public void SetupDataSourceForSimpleTypeMapping()
    {
        _simpleObjectSource = SimpleTypeMappingDataGenerator.GetSources(_size).ToArray();
    }

    [Benchmark(Description = "AutoMapper_SimpleMapping")]
    public void AutoMapperSimpleObjectMapping()
    {
        for (var i = 0; i < _size; i++)
        {
            AMTypeMapping.Map(_simpleObjectSource[i]);
        }
    }

    [Benchmark(Description = "Mapster_SimpleMapping")]
    public void MapsterSimpleObjectMapping()
    {
        for (var i = 0; i < _size; i++)
        {
            MapsterTypeMapping.Map(_simpleObjectSource[i]);
        }
    }

    #endregion

    #region CollectionMapping

    [GlobalSetup(Targets = new[] { nameof(AutoMapperListOrArrayMapping), nameof(MapsterListOrArrayMapping) })]
    public void SetupDataSourceForCollectionMapping()
    {
        _collectionObjectSource = CollectionMappingDataGenerator.GetSources(_size).ToArray();
    }

    [Benchmark(Description = "AutoMapper_CollectionMapping")]
    public void AutoMapperListOrArrayMapping()
    {
        AM_CollectionMapping.Map(_collectionObjectSource.ToList());
    }

    [Benchmark(Description = "Mapster_CollectionMapping")]
    public void MapsterListOrArrayMapping()
    {
        Mapster_CollectionMapping.Map(_collectionObjectSource.ToList());
    }

    #endregion

    #region NestedMapping

    [GlobalSetup(Targets = new[] { nameof(AutoMapperNestedObjectMapping), nameof(MapsterNestedObjectMapping) })]
    public void SetupDataSourceForNestedTypeMapping()
    {
        _nestedObjectSource = NestedTypeMappingDataGenerator.GetSources(_size).ToArray();
    }

    [Benchmark(Description = "AutoMapper_NestedMapping")]
    public void AutoMapperNestedObjectMapping()
    {
        for (var i = 0; i < _size; i++)
        {
            AM_NestedTypeMapping.Map(_nestedObjectSource[i]);
        }
    }

    [Benchmark(Description = "Mapster_NestedMapping")]
    public void MapsterNestedObjectMapping()
    {
        for (var i = 0; i < _size; i++)
        {
            Mapster_NestedTypeMapping.Map(_nestedObjectSource[i]);
        }
    }

    #endregion

    #region FlattenedMapping

    [GlobalSetup(Targets = new[] { nameof(AutoMapperFlattenedObjectMapping), nameof(MapsterFlattenedObjectMapping) })]
    public void SetupDataSourceForFlattenedMapping()
    {
        _flattenedObjectSource = ObjectFlatteningDataGenerator.GetSources(_size).ToArray();
    }

    [Benchmark(Description = "AutoMapper_FlattenedMapping")]
    public void AutoMapperFlattenedObjectMapping()
    {
        for (var i = 0; i < _size; i++)
        {
            AM_ObjectFlattening.Map(_flattenedObjectSource[i]);
        }
    }

    [Benchmark(Description = "Mapster_FlattenedMapping")]
    public void MapsterFlattenedObjectMapping()
    {
        for (var i = 0; i < _size; i++)
        {
            Mapster_ObjectFlattening.Map(_flattenedObjectSource[i]);
        }
    }

    #endregion

    #region CustomPropertyMapping

    [GlobalSetup(Targets = new[] { nameof(AutoMapperCustomPropertyObjectMapping), nameof(MapsterCustomPropertyObjectMapping) })]
    public void SetupDataSourceForCustomPropertyMapping()
    {
        Mapster_CustomPropertyMapping.Initialize();
        _customPropertyObjectSource = CustomPropertyMappingDataGenerator.GetSources(_size).ToArray();
    }

    [Benchmark(Description = "AutoMapper_CustomPropertyMapping")]
    public void AutoMapperCustomPropertyObjectMapping()
    {
        for (var i = 0; i < _size; i++)
        {
            AM_CustomPropertyMapping.Map(_customPropertyObjectSource[i]);
        }
    }

    [Benchmark(Description = "Mapster_CustomPropertyMapping")]
    public void MapsterCustomPropertyObjectMapping()
    {
        for (var i = 0; i < _size; i++)
        {
            Mapster_CustomPropertyMapping.Map(_customPropertyObjectSource[i]);
        }
    }

    #endregion

    #region CustomPropertyMapping

    [GlobalSetup(Targets = new[] { nameof(AutoMapperReverseObjectMapping), nameof(MapsterReverseObjectMapping) })]
    public void SetupDataSourceForReverseMapping()
    {
        Mapster_ReverseMapping.Initialize();
        _reverseMappingObjectSource = ReverseMappingDataGenerator.GetSources(_size).ToArray();
    }

    [Benchmark(Description = "AutoMapper_ReverseMapping")]
    public void AutoMapperReverseObjectMapping()
    {
        for (var i = 0; i < _size; i++)
        {
            AM_ReverseMapping.Map(_reverseMappingObjectSource[i]);
        }
    }

    [Benchmark(Description = "Mapster_ReverseMapping")]
    public void MapsterReverseObjectMapping()
    {
        for (var i = 0; i < _size; i++)
        {
            Mapster_ReverseMapping.Map(_reverseMappingObjectSource[i]);
        }
    }

    #endregion

    #region AttributeMapping

    [GlobalSetup(Targets = new[] { nameof(AutoMapperAttributeObjectMapping) })]
    public void SetupDataSourceForAutoMapperAttributeMapping()
    {
        _automapperAttributeObjectSource = AttributeMappingDataGenerator.GetSources(_size).ToArray();
    }

    [Benchmark(Description = "AutoMapper_AttributeMapping")]
    public void AutoMapperAttributeObjectMapping()
    {
        for (var i = 0; i < _size; i++)
        {
            AM_AttributeMapping.Map(_automapperAttributeObjectSource[i]);
        }
    }

    [GlobalSetup(Targets = new[] { nameof(MapsterAttributeObjectMapping) })]
    public void SetupDataSourceForMapsterAttributeMapping()
    {
        _mapsterAttributeObjectSource = MapsterAttributeMappingDataGenerator.GetSources(_size).ToArray();
    }

    [Benchmark(Description = "Mapster_AttributeMapping")]
    public void MapsterAttributeObjectMapping()
    {
        for (var i = 0; i < _size; i++)
        {
            Mapster_AttributeMapping.Map(_mapsterAttributeObjectSource[i]);
        }
    }

    #endregion
}