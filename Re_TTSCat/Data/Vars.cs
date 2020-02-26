﻿using Re_TTSCat.Windows;
using System;
using System.IO;
using System.Reflection;
using System.Threading;

namespace Re_TTSCat.Data
{
    public sealed class Vars
    {
        public static readonly string apiBaidu = "https://fanyi.baidu.com/gettts?lan=zh&text=$TTSTEXT&spd=5&source=web";
        public static readonly string apiBaiduCantonese = "https://fanyi.baidu.com/gettts?lan=cte&text=$TTSTEXT&spd=5&source=web";
        public static readonly string apiYoudao = "http://tts.youdao.com/fanyivoice?word=$TTSTEXT&le=zh&keyfrom=speaker-target";
        public static readonly string dllFileName = Assembly.GetExecutingAssembly().Location;
        public static readonly string dllPath = (new FileInfo(dllFileName)).DirectoryName;
        public static readonly string confDir = Path.Combine(dllPath, "RE-TTSCat");
        public static readonly string cacheDir = Path.Combine(confDir, "Cache");
        public static readonly string confFileName = Path.Combine(confDir, "Config.json");
        public static readonly string audioLibFileName = Path.Combine(confDir, "NAudio.dll");
        public static readonly Version currentVersion = new Version("3.1.16.320");

        public static Conf CurrentConf = new Conf();
        public static Thread MainBridge;
        public static Thread Player;
        public static uint RoomCount;
        public static uint TotalPlayed = 0;
        public static bool CallBridgeStop = false;
        public static bool CallPlayerStop = false;
        public static OptionsWindow ManagementWindow;
    }
}
