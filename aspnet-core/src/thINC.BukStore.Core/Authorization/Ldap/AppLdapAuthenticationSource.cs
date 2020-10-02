using Abp.Zero.Ldap.Authentication;
using Abp.Zero.Ldap.Configuration;
using thINC.BukStore.Authorization.Users;
using thINC.BukStore.MultiTenancy;

namespace thINC.BukStore.Authorization.Ldap
{
    public class AppLdapAuthenticationSource : LdapAuthenticationSource<Tenant, User>
    {
        public AppLdapAuthenticationSource(ILdapSettings settings, IAbpZeroLdapModuleConfig ldapModuleConfig)
            : base(settings, ldapModuleConfig)
        {
        }
    }
}