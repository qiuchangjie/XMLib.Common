/*
 * 作者：Peter Xiang
 * 联系方式：565067150@qq.com
 * 文档: https://github.com/PxGame
 * 创建时间: 2021/1/11 11:13:52
 */

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace XMLib
{
    public static class ListPool<T>
    {
        private static readonly SimpleObjectPool<List<T>> _pool = new SimpleObjectPool<List<T>>(null, OnPop);

        private static void OnPop(List<T> obj)
        {
            obj.Clear();
        }

        public static List<T> Pop() => _pool.Pop();

        public static void Push(List<T> obj) => _pool.Push(obj);

        public static void Clear() => _pool.Clear();
    }
}