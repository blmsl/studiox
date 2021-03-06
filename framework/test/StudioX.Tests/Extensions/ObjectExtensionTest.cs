﻿using System;
using StudioX.Extensions;
using Shouldly;
using Xunit;

namespace StudioX.Tests.Extensions
{
    public class ObjectExtensionsTests
    {
        [Fact]
        public void AsTest()
        {
            var obj = (object)new ObjectExtensionsTests();
            obj.As<ObjectExtensionsTests>().ShouldNotBe(null);

            obj = null;
            obj.As<ObjectExtensionsTests>().ShouldBe(null);
        }

        [Fact]
        public void ToTests()
        {
            "42".To<int>().ShouldBeOfType<int>().ShouldBe(42);
            "42".To<Int32>().ShouldBeOfType<Int32>().ShouldBe(42);

            "28173829281734".To<long>().ShouldBeOfType<long>().ShouldBe(28173829281734);
            "28173829281734".To<Int64>().ShouldBeOfType<Int64>().ShouldBe(28173829281734);

            "2.0".To<double>().ShouldBe(2.0);
            "0.2".To<double>().ShouldBe(0.2);
            (2.0).To<int>().ShouldBe(2);

            "false".To<bool>().ShouldBeOfType<bool>().ShouldBe(false);
            "True".To<bool>().ShouldBeOfType<bool>().ShouldBe(true);
            
            Assert.Throws<FormatException>(() => "test".To<bool>());
            Assert.Throws<FormatException>(() => "test".To<int>());
        }

        [Fact]
        public void IsInTest()
        {
            5.IsIn(1, 3, 5, 7).ShouldBe(true);
            6.IsIn(1, 3, 5, 7).ShouldBe(false);

            int? number = null;
            number.IsIn(2, 3, 5).ShouldBe(false);

            var str = "a";
            str.IsIn("a", "b", "c").ShouldBe(true);

            str = null;
            str.IsIn("a", "b", "c").ShouldBe(false);
        }
    }
}
