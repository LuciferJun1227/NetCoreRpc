﻿using NRpc.Utils;
using System;

namespace NRpc.Serializing.RpcSerializer.Serializer
{
    /// <summary>
    /// Copyright (C) 2018 备胎 版权所有。
    /// 类名：DateTimeSerializer.cs
    /// 类属性：公共类（非静态）
    /// 类功能描述：
    /// 创建标识：yjq 2018/1/26 16:46:47
    /// </summary>
    public sealed class DateTimeSerializer : BaseSerializer
    {
        public override void WriteBytes(object obj, SerializerInputStream serializerInputStream)
        {
            serializerInputStream.Write(RpcSerializerUtil.Byte_DateTime);
            serializerInputStream.Write(ByteUtil.EncodeDateTime((DateTime)obj));
        }
    }
}