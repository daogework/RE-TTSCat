﻿namespace Re_TTSCat.Data
{
    public partial class Bridge
    {
        public static void Log(string content)
        {
            PendingLogs.Add(content);
        }
    }
}
