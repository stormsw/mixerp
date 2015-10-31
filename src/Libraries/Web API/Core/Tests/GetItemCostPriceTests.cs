// ReSharper disable All
using System;
using System.Diagnostics;
using System.Linq;
using MixERP.Net.Api.Core.Fakes;
using MixERP.Net.ApplicationState.Cache;
using Xunit;

namespace MixERP.Net.Api.Core.Tests
{
    public class GetItemCostPriceTests
    {
        public static GetItemCostPriceController Fixture()
        {
            GetItemCostPriceController controller = new GetItemCostPriceController(new GetItemCostPriceRepository(), "", new LoginView());
            return controller;
        }

        [Fact]
        [Conditional("Debug")]
        public void Execute()
        {
            var actual = Fixture().Execute(new GetItemCostPriceController.Annotation());
            Assert.Equal(1, actual);
        }
    }
}