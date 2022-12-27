using WebApplication1.Data;
using WebApplication1.Models;
using WebApplication1.Repository.IRepository;

namespace WebApplication1.Repository
{
    public class InquiryHeaderRepository :Repository<InquiryHeader> , IInquiryHeaderRepository
    {
        private readonly ApplicationDbContext _db;
    public InquiryHeaderRepository(ApplicationDbContext db) : base(db)
    {
        _db = db;
    }

    public void Update(InquiryHeader obj)
    {
        _db.InquiryHeader.Update(obj);
    }
    
    }
}
