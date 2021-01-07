using System;
using Xunit;

namespace UD10_EX7.Tests
{
    public class Ex7Tests
    {
        [Theory]
        [InlineData(-1, 4, 3, 28)]
        [InlineData(-1, 2, 7, 32)]
        [InlineData(9, 0, 2, -72)]
        [InlineData(2, -4, 2, 0)]
        [InlineData(6, -2, 0, 4)]
        [InlineData(-4, 5, -1, 9)]
        [InlineData(-3, 6, -3, 0)]
        [InlineData(1, 0, -9, 36)]
        [InlineData(1, 0, 0, 0)]
        [InlineData(1, 5, 0, 25)]
        public void GetDiscriminanteTest(double a, double b, double c, double esperado)
        {
            // Arrange
            IRaices r = new Raices(a, b, c);
            // Act
            double dis = r.GetDiscriminante();
            // Assert
            Assert.Equal(esperado, dis);
        }

        [Theory]
        [InlineData(-1, 4, 3, true)]
        [InlineData(-1, 2, 7, true)]
        [InlineData(9, 0, 2, false)]
        [InlineData(2, -4, 2, true)]
        [InlineData(6, -2, 0, true)]
        [InlineData(-4, 5, -1, true)]
        [InlineData(-3, 6, -3, true)]
        [InlineData(1, 0, -9, true)]
        [InlineData(1, 0, 0, true)]
        [InlineData(1, 5, 0, true)]
        public void TieneRaicesTest(double a, double b, double c, bool esperado)
        {
            // Arrange
            IRaices r = new Raices(a, b, c);
            // Act
            bool dis = r.TieneRaices();
            // Assert
            Assert.Equal(esperado, dis);
        }

        [Theory]
        [InlineData(-1, 4, 3, false)]
        [InlineData(-1, 2, 7, false)]
        [InlineData(9, 0, 2, false)]
        [InlineData(2, -4, 2, true)]
        [InlineData(6, -2, 0, false)]
        [InlineData(-4, 5, -1, false)]
        [InlineData(-3, 6, -3, true)]
        [InlineData(1, 0, -9, false)]
        [InlineData(1, 0, 0, true)]
        [InlineData(1, 5, 0, false)]
        public void TieneRaizTest(double a, double b, double c, bool esperado)
        {
            // Arrange
            IRaices r = new Raices(a, b, c);
            // Act
            bool dis = r.TieneRaiz();
            // Assert
            Assert.Equal(esperado, dis);
        }
    }
}
