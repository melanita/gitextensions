using System;

namespace GitUIPluginInterfaces.BuildServerIntegration
{
    public class BuildInfo
    {
        public enum BuildStatus
        {
            Unknown,
            InProgress,
            Success,
            Failure,
            Unstable,
            Stopped
        }

        public string Id { get; set; }
        public DateTime StartDate { get; set; }
        public BuildStatus Status { get; set; }
        public string Description { get; set; }
        public string[] CommitHashList { get; set; }
        public string Url { get; set; }
    }
}