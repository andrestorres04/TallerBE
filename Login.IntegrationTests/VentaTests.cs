using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Login;
using Login.Core.DTO;
using Xunit;

namespace Login.IntegrationTests
{
    public class VentaTests : IClassFixture<TestFixture<Startup>>
    {
        private HttpClient Client;

        public VentaTests(TestFixture<Startup> fixture)
        {
            Client = fixture.Client;
        }

        [Fact]
        public async Task VentaTest_SizeTotalSales()
        {
            // Arrange
            var request = new
            {
                Url = "/Venta",
            };
            // Act
            var response = await Client.GetAsync(request.Url);
            var value = await response.Content.ReadAsStringAsync();
            var listaVentas = JsonSerializer.Deserialize<List<VentaDTO>>(value);
            // Assert
            response.EnsureSuccessStatusCode();
            Assert.True(listaVentas.Count == 6);
        }

    }
}
