namespace InformacionLogsBots.DataAccess.Dtos
{
    internal record CredencialesKeyVaultDto(Uri KeyVaultUri,
        string TenantId,
        string ClientId,
        string ClientSecret,
        string NameSecret
        );
}
