/*
 * 作者：Peter Xiang
 * 联系方式：565067150@qq.com
 * 文档: https://github.com/PxGame
 * 创建时间: 2019/9/15 19:46:31
 */

namespace XMLib
{
    /// <summary>
    /// IPoolItem
    /// </summary>
    public interface IPoolItem<T>
    {
        T poolTag { get; }

        /// <summary>
        /// 不能手动修改
        /// </summary>
        bool inPool { get; set; }

        void OnPushPool();

        void OnPopPool();
    }
}