namespace asp_net_core_app.Models.Account
{
    public class LoggedOutViewModel
    {
            public string PostLogoutRedirectUri { get; set; }
            public string ClientName { get; set; }
            public string SignOutIframeUrl { get; set; }

            public bool AutomaticRedirectAfterSignOut { get; set; }

            public string LogoutId { get; set; }
            public bool TriggerExternalSignout => ExternalAuthenticationScheme != null;
            public string ExternalAuthenticationScheme { get; set; }
    }
}