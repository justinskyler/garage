using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
   public class HeureFonctionnement
    {
        public String store;
        public TimeZoneInfo tz;
        public TimeSpan open;
        public TimeSpan close;
        public TimeSpan of;
        public static System.Timers.Timer aTimer;
        public bool IsOpenNow()
        {
            return IsOpenAt(DateTime.Now.TimeOfDay);
        }

        public bool IsOpenAt(TimeSpan time)
        {
            TimeZoneInfo local = TimeZoneInfo.Local;
            TimeSpan offset = TimeZoneInfo.Local.BaseUtcOffset;

            if (tz.Equals(local))
            {
                return time >= open & time <= close;
            }
            else
            {
                TimeSpan delta = TimeSpan.Zero;
                TimeSpan storeDelta = TimeSpan.Zero;

                if (local.IsDaylightSavingTime(DateTime.Now.Date + time))
                    delta = local.GetAdjustmentRules()[local.GetAdjustmentRules().Length - 1].DaylightDelta;

                TimeSpan comparisonTime = time + (offset - tz.BaseUtcOffset).Negate() + (delta - storeDelta).Negate();
                return comparisonTime >= open & comparisonTime <= close;
            }
        }
    }
    }

