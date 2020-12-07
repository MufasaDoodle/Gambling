using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.JSInterop;
using Gambling.Models;

namespace Gambling.Data
{
    public class JavascriptService : IJavascriptService
    {
        private readonly IJSRuntime js;

        public JavascriptService(IJSRuntime js)
        {
            this.js = js;
        }

        public async Task<WindowDimension> GetWindowDimensions()
        {
            return await js.InvokeAsync<WindowDimension>("getDimensions");
        }
    }
}
