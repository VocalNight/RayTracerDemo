using Newtonsoft.Json.Linq;
using RayTracer;

namespace RayTracerTest
{
    public class RayTraceService_IsPointVector
    {
        private readonly RayTracerService _rayTraceService;
        public RayTraceService_IsPointVector()
        {
            _rayTraceService = new RayTracerService();
        }


        [Fact]
        public void IsPoint_ReturnTrue()
        {
            var result = _rayTraceService.IsPoint(_rayTraceService.PointFactory((4.3f, -4.1f, 3.1f)));

            Assert.True(result, "Value is a point!");
        }

        [Fact]
        public void IsPoint_ReturnFalse()
        {
            var result = _rayTraceService.IsPoint(_rayTraceService.VectorFactory((4.3f, -4.1f, 3.1f)));

            Assert.False(result, "Value is not a point, it is a vector.");
        }

        /*[Theory]
        [InlineData(-1)]
        [InlineData(1)]
        [InlineData(0)]
        public void IsPrime_ValuesLessThan2_ReturnFalse(int value)
        {
            var result = _primeService.IsPrime(value);
            Assert.False(result, $"{value} should not be prime");
        }*/
    }
}
