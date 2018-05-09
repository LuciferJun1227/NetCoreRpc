﻿using System;
using System.Threading.Tasks;

namespace NetCoreRpc.LockManage
{
    /// <summary>
    /// 类名：ILock.cs
    /// 类功能描述：
    /// 创建标识：yjq 2018/5/9 14:23:28
    /// </summary>
    public interface ILock
    {
        /// <summary>
        /// 获取一个锁(需要自己释放)
        /// </summary>
        /// <param name="key">锁的键</param>
        /// <param name="value">当前占用值</param>
        /// <param name="span">耗时时间</param>
        /// <returns>成功返回true</returns>
        bool LockTake(string key, string value, TimeSpan span);

        /// <summary>
        /// 异步获取一个锁(需要自己释放)
        /// </summary>
        /// <param name="key">锁的键</param>
        /// <param name="value">当前占用值</param>
        /// <param name="span">耗时时间</param>
        /// <returns>成功返回true</returns>
        Task<bool> LockTakeAsync(string key, string value, TimeSpan span);

        /// <summary>
        /// 释放一个锁
        /// </summary>
        /// <param name="key">锁的键</param>
        /// <param name="value">当前占用值</param>
        /// <returns>成功返回true</returns>
        bool LockRelease(string key, string value);

        /// <summary>
        /// 异步释放一个锁
        /// </summary>
        /// <param name="key">锁的键</param>
        /// <param name="value">当前占用值</param>
        /// <returns>成功返回true</returns>
        Task<bool> LockReleaseAsync(string key, string value);
    }
}