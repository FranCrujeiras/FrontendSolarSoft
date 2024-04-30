using BlazorBootstrap;

namespace FrontBlazor.Components.Extensions
{
    public class SideBarData
    {
        public Sidebar sidebar = default!;
        public IEnumerable<NavItem>? navItems;

        public async Task<SidebarDataProviderResult> SidebarDataProvider(SidebarDataProviderRequest request)
        {
            if (navItems is null)
                navItems = GetNavItems();

            return await Task.FromResult(request.ApplyTo(navItems));
        }

        public IEnumerable<NavItem> GetNavItems()
        {
            navItems = new List<NavItem>
        {
            new NavItem { Id = "1", Href = "/Home", IconName = IconName.HouseDoorFill, Text = "Inicio"},

            new NavItem { Id = "2", Href="/", IconName = IconName.HouseAddFill, Text = "Nueva Instalación" },

            new NavItem { Id = "4", IconName = IconName.DatabaseFillAdd, Text = "Nuevo Componente" },
            new NavItem { Id = "5", Href = "/NuevoPanel", IconName = IconName.SunFill, Text = "Nuevo Panel", ParentId="4"},
            new NavItem { Id = "6", Href = "/NuevaBateria", IconName = IconName.BatteryCharging, Text = "Nueva Batería", ParentId="4"},
            new NavItem { Id = "7", Href = "/mapa", IconName = IconName.MapFill, Text= "Mapa"},

        };

            return navItems;
        }
        public void ToggleSidebar() => sidebar.ToggleSidebar();
    }
}
