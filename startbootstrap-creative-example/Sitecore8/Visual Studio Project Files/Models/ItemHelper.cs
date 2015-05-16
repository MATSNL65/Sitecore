using Sitecore.Data.Fields;
using Sitecore.Data.Items;

namespace Sitecore8.Models
{
    public static class ItemHelper
    {
        public static Item GetDataSourceTargetItemByFieldName(this Item item, string fieldName)
        {
            DatasourceField linkDataSource = item.Fields[fieldName];
            return linkDataSource.TargetItem;            
        }
    }
}