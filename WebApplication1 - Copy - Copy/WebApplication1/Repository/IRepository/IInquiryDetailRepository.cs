using WebApplication1.Models;

namespace WebApplication1.Repository.IRepository
{
    public interface IInquiryDetailRepository : IRepository<InquiryDetail>
    {
        void Update(InquiryDetail obj);
    }
}
