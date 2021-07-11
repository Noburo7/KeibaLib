using System.Collections.Generic;
using KeibaLib.Course;

namespace KeibaLib
{
    static public class JRALib
    {
        /// <summary>
        /// 競馬場名リストを返す
        /// </summary>
        /// <returns></returns>
        static public IEnumerable<ICourse> CourseList()
        {
            return new List<ICourse>()
            {
                new TokyoCourse(),
                new NakayamaCourse(),
                new KyotoCourse(),
                new HanshinCourse(),
                new FukushimaCourse(),
                new NiigataCourse(),
                new ChukyoCourse(),
                new KokuraCourse(),
                new SapporoCourse(),
                new HakodateCourse()
            };
        }

        /// <summary>
        /// 馬場状態リストを返す
        /// </summary>
        /// <returns></returns>
        static public IEnumerable<string> TrackConditionList()
        {
            return new List<string>()
            {
                "良",
                "稍重",
                "重",
                "不良"
            };
        }

        /// <summary>
        /// レースクラスリストを返す
        /// </summary>
        /// <returns></returns>
        static public IEnumerable<string> RaceClassList()
        {
            return new List<string>()
            {
                "新馬",
                "未勝利",
                "1勝クラス",
                "2勝クラス",
                "3勝クラス",
                "オープン",
                "リステッド",
                "G3",
                "G2",
                "G1"
            };
        }
    }
}
