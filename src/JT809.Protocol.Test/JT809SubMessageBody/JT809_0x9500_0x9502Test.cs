﻿using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using JT809.Protocol;
using JT809.Protocol.JT809Extensions;
using JT809.Protocol.JT809MessageBody;
using JT809.Protocol.JT809Exceptions;
using JT809.Protocol.JT809SubMessageBody;

namespace JT809.Protocol.Test.JT809SubMessageBody
{
    public class JT809_0x9500_0x9502Test
    {
        [Fact]
        public void Test1()
        {
            JT809_0x9500_0x9502 jT809_0X9500_0X9502 = new JT809_0x9500_0x9502
            {
                  LensID=0x09,
                  SizeType=0x01  
            };
            var hex = JT809Serializer.Serialize(jT809_0X9500_0X9502).ToHexString();
            Assert.Equal("0901", hex);
        }

        [Fact]
        public void Test2()
        {
            var bytes = "0901".ToHexBytes();
            JT809_0x9500_0x9502 jT809_0X9500_0X9502 = JT809Serializer.Deserialize<JT809_0x9500_0x9502>(bytes);
            Assert.Equal(0x09, jT809_0X9500_0X9502.LensID);
            Assert.Equal(0x01, jT809_0X9500_0X9502.SizeType);
        }
    }
}
