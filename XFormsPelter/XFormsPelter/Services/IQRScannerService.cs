using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace XFormsPelter.Services
{
    interface IQRScannerService
    {
          Task<string> ScanAsync();
    }
}
