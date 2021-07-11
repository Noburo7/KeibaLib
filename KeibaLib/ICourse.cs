using System.Collections.Generic;

namespace KeibaLib
{
    /// <summary>
    /// 競馬場インターフェース
    /// </summary>
    public interface ICourse
    {
        /// <summary>
        /// 競馬場名
        /// </summary>
        string Name { get; }

        /// <summary>
        /// 文字列型表現
        /// </summary>
        /// <returns></returns>
        string ToString();

        /// <summary>
        /// トラックタイプリストを返す
        /// </summary>
        /// <returns></returns>
        IEnumerable<string> TrackTypeList();

        /// <summary>
        /// 距離リストを返す
        /// </summary>
        /// <returns></returns>
        IEnumerable<int> CourseDistanceList(string trackType);
    }
}
