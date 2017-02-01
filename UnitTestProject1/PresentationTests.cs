using System;
using NMock;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NannyApp.BaseLib;
using NannyApp.Model;
using NannyApp.Controllers;

namespace NannyApp.Presentation.Tests
{
    [TestClass]
    public class PresentationTests
    {
        private MockFactory _factory = new MockFactory();

        [TestMethod]
        public void ParentController_CreateParent()
        {
            var mock = _factory.CreateMock<IParentView>();
            mock.Expects.One.GetProperty(_ => _.Username).WillReturn("aaa");
            mock.Expects.One.GetProperty(_ => _.Password).WillReturn("111");
            mock.Expects.One.GetProperty(_ => _.Name).WillReturn("Ana");
            mock.Expects.One.GetProperty(_ => _.Surname).WillReturn("Antić");
            mock.Expects.One.GetProperty(_ => _.Gender).WillReturn(Gender.FEMALE);
            mock.Expects.One.GetProperty(_ => _.Contact).WillReturn("01 257 9581");

            NannyApp.Controllers.ParentController ParentController = new ParentController();
        }
    }
}
