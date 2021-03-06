﻿using Xunit;
using ZabbixApi.Services;

namespace ZabbixApiTests.Integration
{
    public class TemplateScreenServiceIntegrationTest : BaseIntegrationTest
    {
        [Fact]
        public void ServiceMustGet()
        {
            var service = new TemplateScreenService(this.context);
            var result = service.Get();
            Assert.NotNull(result);
        }
    }
}
