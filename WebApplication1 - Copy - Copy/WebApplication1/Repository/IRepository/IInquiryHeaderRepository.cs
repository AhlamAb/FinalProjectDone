using WebApplication1.Models;

namespace WebApplication1.Repository.IRepository
{
    public interface IInquiryHeaderRepository : IRepository<InquiryHeader>
    {
        void Update(InquiryHeader obj);
    }
    
}
