namespace KB11856_BlazorWasmApp1.Data;

public class CountryRenewableElectricityDataService
{
    public Task<CountryRenewableElectricityItem[]> GetElectricityDataAsync()
    {
        return Task.FromResult(new CountryRenewableElectricityItem[]
        {
            new() {Year = "2000", S1 = 58.20460569, S2 = 39.50036673, S3 = 27.99454227, S4 = 42.54095714},
            new() {Year = "2001", S1 = 60.96069168, S2 = 44.39740295, S3 = 32.86199766, S4 = 47.13757039},
            new() {Year = "2002", S1 = 62.70721935, S2 = 47.83362508, S3 = 36.4119072, S4 = 48.07223462},
            new() {Year = "2003", S1 = 64.70077972, S2 = 51.31332816, S3 = 38.05207781, S4 = 52.51483997},
            new() {Year = "2004", S1 = 67.19898532, S2 = 56.27517966, S3 = 42.63124688, S4 = 55.42185617},
        });
    }
}
