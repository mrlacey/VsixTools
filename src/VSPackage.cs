using System.Runtime.InteropServices;
using Microsoft.VisualStudio.Shell;

namespace VsixTools
{
    [PackageRegistration(UseManagedResourcesOnly = true, AllowsBackgroundLoading = true)]
    [InstalledProductRegistration("#110", "#112", "1.19")] // Info on this package for Help/About
    [Guid(VSPackage.PackageGuidString)]
    public sealed class VSPackage : AsyncPackage
    {
        public const string PackageGuidString = "75a93d97-9838-4d5e-b089-4ba2c8364adc";
    }
}
