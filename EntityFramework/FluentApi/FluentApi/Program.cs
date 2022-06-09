using System.Security.AccessControl;

string path = @"C:\Windows\System32\config";

// DirectoryInfo info = new(path);
//
// DirectorySecurity security = info.GetAccessControl();
//
// security.AddAccessRule(new FileSystemAccessRule(System.Security.Principal.WindowsIdentity.GetCurrent().Name, FileSystemRights.Read, AccessControlType.Allow));
//
//
// info.SetAccessControl(security);

var files = Directory.GetFiles(path);

foreach (var item in files)
{
    Console.WriteLine(item);   
}