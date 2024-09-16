using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship.Application.Dtos
{
    public class ResponseBase<T>
    {
        public bool IsError { get; set; }
        public T? ReturnObject { get; set; }
        public string Message { get; set; }

    }
}
