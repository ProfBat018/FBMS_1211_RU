using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Adapter.Services.Interfaces
{
    public interface IXMLAdapter<T>
    {
        string ConvertToXml(string json);
    }
}
