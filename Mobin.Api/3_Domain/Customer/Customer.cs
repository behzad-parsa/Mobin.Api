using Microsoft.EntityFrameworkCore.Metadata.Conventions;

namespace Mobin.Api._3_Domain.Customer
{
    public class Customer /*:EntityBase <- hal tarrif nabod */
    {
        public int Id { get; protected set; }
        public string Username { get; protected set; }
        public int Status { get; protected set; }
        public int ProductId { get; protected set; }

        public void SetStatus(int status)
        {
            Status = status;
        }

    }
}
