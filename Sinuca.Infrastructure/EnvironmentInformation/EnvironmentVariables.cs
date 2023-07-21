using Sinuca.Application.Interfaces;

namespace Sinuca.Infrastructure.EnvironmentInformation
{
    public class EnvironmentVariables : IEnvironmentVariables
    {
        public string GetEnvironmentVariable(string variableName)
        {
            return Environment.GetEnvironmentVariable(variableName);
        }

        public void SetEnvironmentVariable(string variableName, string value)
        {
            Environment.SetEnvironmentVariable(variableName, value);
        }
    }
}
