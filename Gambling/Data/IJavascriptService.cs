using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gambling.Models;

namespace Gambling.Data
{
    interface IJavascriptService
    {
        Task<WindowDimension> GetWindowDimensions();
    }
}
