﻿using Abp.Application.Navigation;
using Abp.Localization;

namespace Calicot.Store.Web.Startup
{
    /// <summary>
    /// This class defines menus for the application.
    /// </summary>
    public class StoreNavigationProvider : NavigationProvider
    {
        public override void SetNavigation(INavigationProviderContext context)
        {
            context.Manager.MainMenu
                .AddItem(
                new MenuItemDefinition(
                    "ProductList",
                    L("ProductList"),
                    url: "Products",
                    icon: "fa fa-products"
                    )
            );
        }

        private static ILocalizableString L(string name)
        {
            return new LocalizableString(name, StoreConsts.LocalizationSourceName);
        }
    }
}
