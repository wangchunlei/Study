namespace Domas.Web.Mvc.UI.Fluent
{
    public class DataSourceFilterComparisonDescriptorBuilder<TValue> : DataSourceFilterComparisonDescriptorBuilderBase<TValue, DataSourceFilterCompositeBuilder<DataSourceFilterComparisonDescriptorBuilder<TValue>>>
    {
        public DataSourceFilterComparisonDescriptorBuilder(CompositeFilterDescriptor descriptor) : base(descriptor)
        {
        }
    }
}