﻿
namespace Rebar.Model
{
    public class RebarStoreDataBaseSetting : IRebarStoreDataBaseSetting
    {
        public string AccountCollectionName { get; set; } = string.Empty;
        public string MenuCollectionName { get; set; } = string.Empty;
        public string OrderCollectionName { get; set; } = string.Empty;
        public string ShakeCollectionName {  get; set; } = string.Empty;
        public string ConnectionString { get; set; } = string.Empty;
        public string DatabaseName { get; set; } = string.Empty;
    }
}
