﻿using System.Dynamic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LBS.DCT.JsonRPC.Requests;

namespace LBS.DCT.JsonRPC.Tests.Requests
{
    [TestClass]
    public class RequestChallengeTest
    {
        private RequestChallenge subject;

        [TestInitialize]
        public void BeforeEach()
        {
            subject = new RequestChallenge("https://pegasus1.pegasusgateway.com/rpc/");
        }

        [TestMethod]
        public void on_execute_it_returns_a_dynamic_object()
        {
            var result = subject.Execute();
            Assert.IsInstanceOfType(result, typeof (IDynamicMetaObjectProvider));
        }

        [TestMethod]
        public void on_execute_it_returns_a_result_field()
        {
            var result = subject.Execute();
            Assert.IsNotNull(result.result);
            Assert.IsNull(result.someValue);
        }
    }
}