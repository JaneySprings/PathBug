using Microsoft.Build.Evaluation;
namespace NetApp;

public class Program {
    public static void Main() {
        Environment.SetEnvironmentVariable("MSBUILD_EXE_PATH", "/home/nromanov/dotnet/sdk/7.0.100/MSBuild.dll");

        Console.WriteLine("\n\nProject output directory:");
        var project = new Project("./../netapp/netapp.csproj");
        Console.WriteLine(project.GetPropertyValue("OutputPath"));
    }
}