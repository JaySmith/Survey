// [[Highway.Onramp.MVC]]
// Copyright 2013 Timothy J. Rayburn
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//    http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using System.Web.Mvc;
using Castle.Core.Logging;

namespace Survey.Filters
{
    public class ExceptionLoggingFilter : IExceptionFilter
    {
        public ILogger Logger { get; set; }

        public ExceptionLoggingFilter()
        {
            Logger = NullLogger.Instance;
        }
        
        public void OnException(ExceptionContext filterContext)
        {
            Logger.Error(filterContext.HttpContext.Request.Url.ToString(), filterContext.Exception);
        }
    }
}