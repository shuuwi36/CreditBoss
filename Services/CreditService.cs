using CreditBoss.Data;
using CreditBoss.Interfaces;

namespace CreditBoss.Services;

public class CreditService : ICreditService
{
    private readonly CreditBossContext _db;
    
    public CreditService(CreditBossContext db)
    {
        _db = db;
    }
    
    
}