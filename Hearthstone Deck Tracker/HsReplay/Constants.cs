﻿#region

using System.IO;

#endregion

namespace Hearthstone_Deck_Tracker.HsReplay
{
	internal class Constants
	{
		public const string BaseUrl = "http://hsreplay.net";
		private const string UploadApi = "/api/v1/replay/upload";
		private const string GenerateUploadTokenApi = "/api/v1/agents/generate_single_site_upload_token/";
		private const string Msvcr100Dll = "msvcr100.dll";
		private const string HsReplayXmlFile = "hslog.xml";
		private const string HsReplayDir = "HsReplay";
		private const string HsReplayExeFilename = "hsreplayconverter.exe";
		private const string TmpDir = "temp";
		private const string VersionFile = "version";
		private const string BuildDatesFile = "builddates.xml";
		private const string UploadTokenFile = "token";

		public static string UploadUrl => BaseUrl + UploadApi;
		public static string GenerateUploadTokenUrl => BaseUrl + GenerateUploadTokenApi;
		public static string BuildDateFilePath => Path.Combine(HsReplayPath, BuildDatesFile);
		public static string Msvcr100DllHearthstonePath => Path.Combine(Config.Instance.HearthstoneDirectory, Msvcr100Dll);
		public static string Msvcr100DllPath => Path.Combine(HsReplayPath, Msvcr100Dll);
		public static string TmpDirPath => Path.Combine(HsReplayPath, TmpDir);
		public static string HsReplayPath => Path.Combine(Config.AppDataPath, HsReplayDir);
		public static string HsReplayExe => Path.Combine(HsReplayPath, HsReplayExeFilename);
		public static string HsReplayOutput => Path.Combine(TmpDirPath, HsReplayXmlFile);
		public static string VersionFilePath => Path.Combine(HsReplayPath, VersionFile);
		public static string UploadTokenFilePath => Path.Combine(HsReplayPath, UploadTokenFile);
	}
}