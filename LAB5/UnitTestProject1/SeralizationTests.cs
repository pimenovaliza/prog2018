using System;
using System.Collections.Generic;
using System.IO;
using GoldApple;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class SeralizationTests
    {
        [TestMethod]
        public void End2EndSerializationTest()
        {
            var dto = new ProductRequestDto
            {
                Filled = DateTime.Now,
                FullName = "Clinique Face Cream Hybrid SPF30",
                Price = 599,
                Currency = Currency.Rubles,
                Product = new ProductRequirements()
                {
                    SunscreenProduct = new List<SunscreenRequirements>()
                    {
                        new SunscreenRequirements() { SPF = 30 },
                        new SunscreenRequirements() { SPF = 50 },
                    },
                    WaterproofProduct = false
                },
                Description = new List<Description>()
                {
                    new Description
                    {
                        Brend = "Clinique",
                        Color = "White",
                        Amount = 30,
                        Code = 354720,
                        Type = SkinType.Any
                    },
                    new Description
                    {
                        Brend = "Clinique",
                        Amount = 20,
                        Code = 1643742,
                        Type = SkinType.Problem
                    },
                }
            };
            var tempFileName = Path.GetTempFileName();
            try
            {
                ProductDtoHelper.WriteToFile(tempFileName, dto);
                var readDto = ProductDtoHelper.LoadFromFile(tempFileName);
                Assert.AreEqual(dto.Description.Count, readDto.Description.Count);
                Assert.AreEqual(dto.Filled, readDto.Filled);
            }
            finally
            {
                File.Delete(tempFileName);
            }
        }
    }
}
