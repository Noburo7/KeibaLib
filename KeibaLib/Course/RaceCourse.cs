using System.Collections.Generic;

namespace KeibaLib.Course
{
    /// <summary>
    /// 競馬場クラス
    /// </summary>
    internal abstract class RaceCourse : ICourse
    {
        static protected readonly string TRACK_TYPE_TURF = "芝";
        static protected readonly string TRACK_TYPE_DIRT = "ダ";

        /// <summary>
        /// 競馬場名
        /// </summary>
        public string Name { get; protected set; }

        public override string ToString()
        {
            return Name;
        }

        /// <summary>
        /// トラックタイプを返す
        /// </summary>
        /// <returns></returns>
        public IEnumerable<string> TrackTypeList()
        {
            return new List<string>()
            {
                TRACK_TYPE_TURF,
                TRACK_TYPE_DIRT
            };
        }

        /// <summary>
        /// 距離リストを返す
        /// </summary>
        /// <returns></returns>
        public abstract IEnumerable<int> CourseDistanceList(string trackType);

    }

    /// <summary>
    /// 東京競馬場クラス
    /// </summary>
    internal class TokyoCourse : RaceCourse
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public TokyoCourse()
        {
            Name = "東京";
        }

        /// <summary>
        /// 距離リストを返す
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<int> CourseDistanceList(string trackType)
        {
            if (trackType == TRACK_TYPE_TURF)
            {
                return new List<int>
                {
                    1400,
                    1600,
                    1800,
                    2000,
                    2300,
                    2400,
                    2500,
                    3400
                };
            }
            else
            {
                return new List<int>
                {
                    1300,
                    1400,
                    1600,
                    2100,
                    2400
                };
            }
        }
    }

    /// <summary>
    /// 中山競馬場クラス
    /// </summary>
    internal class NakayamaCourse : RaceCourse
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public NakayamaCourse()
        {
            Name = "中山";
        }

        /// <summary>
        /// 距離リストを返す
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<int> CourseDistanceList(string trackType)
        {
            if (trackType == TRACK_TYPE_TURF)
            {
                return new List<int>
                {
                    1200,
                    1600,
                    1800,
                    2000,
                    2200,
                    2500,
                    3600
                };
            }
            else
            {
                return new List<int>
                {
                    1200,
                    1800,
                    2400
                };
            }
        }
    }

    /// <summary>
    /// 京都競馬場クラス
    /// </summary>
    internal class KyotoCourse : RaceCourse
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public KyotoCourse()
        {
            Name = "京都";
        }

        /// <summary>
        /// 距離リストを返す
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<int> CourseDistanceList(string trackType)
        {
            if (trackType == TRACK_TYPE_TURF)
            {
                return new List<int>
                {
                    1200,
                    1400,
                    1600,
                    1800,
                    2000,
                    2200,
                    2400,
                    3000,
                    3200
                };
            }
            else
            {
                return new List<int>
                {
                    1200,
                    1400,
                    1800,
                    1900
                };
            }
        }
    }

    /// <summary>
    /// 阪神競馬場クラス
    /// </summary>
    internal class HanshinCourse : RaceCourse
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public HanshinCourse()
        {
            Name = "阪神";
        }

        /// <summary>
        /// 距離リストを返す
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<int> CourseDistanceList(string trackType)
        {
            if (trackType == TRACK_TYPE_TURF)
            {
                return new List<int>
                {
                    1200,
                    1400,
                    1600,
                    1800,
                    2000,
                    2200,
                    2400,
                    2600,
                    3000,
                    3200
                };
            }
            else
            {
                return new List<int>
                {
                    1200,
                    1400,
                    1800,
                    2000
                };
            }
        }
    }

    /// <summary>
    /// 福島競馬場クラス
    /// </summary>
    internal class FukushimaCourse : RaceCourse
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public FukushimaCourse()
        {
            Name = "福島";
        }

        /// <summary>
        /// 距離リストを返す
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<int> CourseDistanceList(string trackType)
        {
            if (trackType == TRACK_TYPE_TURF)
            {
                return new List<int>
                {
                    1200,
                    1800,
                    2000,
                    2600
                };
            }
            else
            {
                return new List<int>
                {
                    1150,
                    1700,
                    2400
                };
            }
        }
    }

    /// <summary>
    /// 新潟競馬場クラス
    /// </summary>
    internal class NiigataCourse : RaceCourse
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public NiigataCourse()
        {
            Name = "新潟";
        }

        /// <summary>
        /// 距離リストを返す
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<int> CourseDistanceList(string trackType)
        {
            if (trackType == TRACK_TYPE_TURF)
            {
                return new List<int>
                {
                    1000,
                    1200,
                    1400,
                    1600,
                    1800,
                    2000,
                    2200,
                    2400
                };
            }
            else
            {
                return new List<int>
                {
                    1200,
                    1800
                };
            }
        }
    }

    /// <summary>
    /// 中京競馬場クラス
    /// </summary>
    internal class ChukyoCourse : RaceCourse
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public ChukyoCourse()
        {
            Name = "中京";
        }

        /// <summary>
        /// 距離リストを返す
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<int> CourseDistanceList(string trackType)
        {
            if (trackType == TRACK_TYPE_TURF)
            {
                return new List<int>
                {
                    1200,
                    1400,
                    1600,
                    2000,
                    2200
                };
            }
            else
            {
                return new List<int>
                {
                    1200,
                    1400,
                    1800,
                    1900
                };
            }
        }
    }

    /// <summary>
    /// 小倉競馬場クラス
    /// </summary>
    internal class KokuraCourse : RaceCourse
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public KokuraCourse()
        {
            Name = "小倉";
        }

        /// <summary>
        /// 距離リストを返す
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<int> CourseDistanceList(string trackType)
        {
            if (trackType == TRACK_TYPE_TURF)
            {
                return new List<int>
                {
                    1200,
                    1700,
                    1800,
                    2000,
                    2600
                };
            }
            else
            {
                return new List<int>
                {
                    1000,
                    1700,
                    2400
                };
            }
        }
    }

    /// <summary>
    /// 札幌競馬場クラス
    /// </summary>
    internal class SapporoCourse : RaceCourse
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public SapporoCourse()
        {
            Name = "札幌";
        }

        /// <summary>
        /// 距離リストを返す
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<int> CourseDistanceList(string trackType)
        {
            if (trackType == TRACK_TYPE_TURF)
            {
                return new List<int>
                {
                    1000,
                    1200,
                    1500,
                    1800,
                    2000,
                    2600
                };
            }
            else
            {
                return new List<int>
                {
                    1000,
                    1700,
                    2400
                };
            }
        }
    }

    /// <summary>
    /// 函館競馬場クラス
    /// </summary>
    internal class HakodateCourse : RaceCourse
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public HakodateCourse()
        {
            Name = "函館";
        }

        /// <summary>
        /// 距離リストを返す
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<int> CourseDistanceList(string trackType)
        {
            if (trackType == TRACK_TYPE_TURF)
            {
                return new List<int>
                {
                    1000,
                    1200,
                    1800,
                    2000,
                    2600
                };
            }
            else
            {
                return new List<int>
                {
                    1000,
                    1700,
                    2400
                };
            }
        }
    }
}
