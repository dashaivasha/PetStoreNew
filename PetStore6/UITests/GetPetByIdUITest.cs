﻿using PetStore6.UITests;
using NUnit.Framework;

namespace PetStore6.Tests
{
    [TestFixture]
    public class GetPetByIdUITest : BaseTest
    {
        
        [Test]
        public void GetPetById()
        {
            homePage.PressGetByIdButton();
            homePage.EnterId("22");
            homePage.Execute();
        }
        
    }
}



