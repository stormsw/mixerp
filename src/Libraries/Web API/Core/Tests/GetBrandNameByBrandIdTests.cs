// ReSharper disable All
using System;
using System.Diagnostics;
using System.Linq;
using MixERP.Net.Api.Core.Fakes;
using MixERP.Net.ApplicationState.Cache;
using Xunit;

namespace MixERP.Net.Api.Core.Tests
{
    public class GetBrandNameByBrandIdTests
    {
        public static GetBrandNameByBrandIdController Fixture()
        {
            GetBrandNameByBrandIdController controller = new GetBrandNameByBrandIdController(new GetBrandNameByBrandIdRepository(), "", new LoginView());
            return controller;
        }

        [Fact]
        [Conditional("Debug")]
        public void Execute()
        {
            var actual = Fixture().Execute(new GetBrandNameByBrandIdController.Annotation());
            Assert.Equal("FizzBuzz", actual);
        }
    }
}