using System.Collections;
using System.Linq;
using System.Threading.Tasks;

namespace TRRY.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string status { get; set; }
        public Customer Customer{ get; set; }

    }
}
