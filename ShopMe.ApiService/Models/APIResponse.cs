using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopMe.ApiService.Models
{
    public class APIResponse
    {
        public bool IsSucess { get; set; }
        public string Message { get; set; }
        public object ResponseData { get; set; }
    }
}