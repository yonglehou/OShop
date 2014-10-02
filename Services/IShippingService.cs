﻿using Orchard;
using OShop.Models;
using System.Collections.Generic;

namespace OShop.Services {
    public interface IShippingService : IDependency {
        #region Shipping zones
        void CreateZone(ShippingZoneRecord record);
        void UpdateZone(ShippingZoneRecord record);
        void DeleteZone(int ZoneId);
        void DeleteZone(ShippingZoneRecord record);
        ShippingZoneRecord GetZone(int Id);
        IEnumerable<ShippingZoneRecord> GetZones();
        IEnumerable<ShippingZoneRecord> GetEnabledZones();
        
        #endregion

        #region Shipping options
        void CreateOption(ShippingOptionRecord record);
        void UpdateOption(ShippingOptionRecord record);
        void DeleteOption(int OptionId);
        void DeleteOption(ShippingOptionRecord record);
        ShippingOptionRecord GetOption(int Id);
        IEnumerable<ShippingOptionRecord> GetOptions(ShippingProviderPart part);
        ShippingOptionRecord GetSuitableOption(int ShippingProviderId, ShippingZoneRecord zone, IEnumerable<ItemShippingInfo> shippingInfos, IEnumerable<ShoppingCartItem> cartItems);
        #endregion
    }
}
