﻿using System;
using NMock;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NannyApp.BaseLib;
using NannyApp.Model;
using NannyApp.Controllers;
using NannyApp.DAL.Repositories;

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

            ParentController ParentController = new ParentController();
            UserRepository UserRepository = new UserRepository();
            User Parent = ParentController.CreateParent(mock.MockObject, UserRepository);
            _factory.VerifyAllExpectationsHaveBeenMet();
        }

        [TestMethod]
        public void NannyController_CreateNanny()
        {
            var mock = _factory.CreateMock<INannyView>();
            mock.Expects.One.GetProperty(_ => _.Username).WillReturn("aaa");
            mock.Expects.One.GetProperty(_ => _.Password).WillReturn("111");
            mock.Expects.One.GetProperty(_ => _.NannyName).WillReturn("Ana");
            mock.Expects.One.GetProperty(_ => _.Surname).WillReturn("Antić");
            mock.Expects.One.GetProperty(_ => _.Gender).WillReturn(Gender.FEMALE);
            mock.Expects.One.GetProperty(_ => _.Contact).WillReturn("01 257 9581");
            mock.Expects.One.GetProperty(_ => _.DriversLicence).WillReturn(false);
            mock.Expects.One.GetProperty(_ => _.Education).WillReturn("Bachelor of psychology");
            mock.Expects.One.GetProperty(_ => _.ExtraQualification).WillReturn("");
            mock.Expects.One.GetProperty(_ => _.ExtraServices).WillReturn("");
            mock.Expects.One.GetProperty(_ => _.Pets).WillReturn(true);
            mock.Expects.One.GetProperty(_ => _.SickChildren).WillReturn(true);
            mock.Expects.One.GetProperty(_ => _.Smoking).WillReturn(true);

            NannyController NannyController = new NannyController();
            UserRepository UserRepository = new UserRepository();
            User Nanny = NannyController.CreateNanny(mock.MockObject, UserRepository);
            _factory.VerifyAllExpectationsHaveBeenMet();
        }
    }
}
