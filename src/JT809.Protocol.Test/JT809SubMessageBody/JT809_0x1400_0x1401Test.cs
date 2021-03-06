﻿using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using JT809.Protocol;
using JT809.Protocol.JT809Extensions;
using JT809.Protocol.JT809MessageBody;
using JT809.Protocol.JT809Exceptions;
using JT809.Protocol.JT809SubMessageBody;
using JT809.Protocol.JT809Enums;

namespace JT809.Protocol.Test.JT809SubMessageBody
{
    public class JT809_0x1400_0x1401Test
    {
        [Fact]
        public void Test1()
        {
            JT809_0x1400_0x1401 jT809_0x1400_0x1401 = new JT809_0x1400_0x1401
            {
                  SupervisionID=9898,
                  Result= JT809_0x1401_Result.处理中
            };
            var hex = JT809Serializer.Serialize(jT809_0x1400_0x1401).ToHexString();
            Assert.Equal("000026AA00", hex);
        }

        [Fact]
        public void Test2()
        {
            var bytes = "000026AA00".ToHexBytes();
            JT809_0x1400_0x1401 jT809_0x1400_0x1401 = JT809Serializer.Deserialize<JT809_0x1400_0x1401>(bytes);
            Assert.Equal(JT809_0x1401_Result.处理中, jT809_0x1400_0x1401.Result);
            Assert.Equal((uint)9898, jT809_0x1400_0x1401.SupervisionID);

        }
    }
}
